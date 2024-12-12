using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Synaptica.Data;
using Synaptica.Shared.Models;
using System.ComponentModel.DataAnnotations;

namespace Synaptica.Pages
{   //this model is for the logic within the registration page along with functionality
    public class RegisterModel : PageModel
    {
        private readonly SynpaticaDbContext _dbContext;
        //constructor
        public RegisterModel(SynpaticaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //properties for registration along with required, and error messages for data feilds 
        [BindProperty]
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; } = string.Empty;

        [BindProperty]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; } = string.Empty;

        [BindProperty]
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long.")]
        public string Password { get; set; } = string.Empty;

        [BindProperty]
        [Required(ErrorMessage = "Password confirmation is required.")]
        public string ConfirmPassword { get; set; } = string.Empty;

        public string ErrorMessage { get; set; } = string.Empty;

        public void OnGet()
        {}

        //method for handling when the user presses register
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                // check if passwords match
                if (Password != ConfirmPassword)
                {
                    ErrorMessage = "Passwords do not match.";
                    return Page();
                }

                // Validate password for uppercase, special characyers
                if (!Password.Any(char.IsUpper) || !Password.Any(ch => !char.IsLetterOrDigit(ch)))
                {
                    ErrorMessage = "Password must include at least one uppercase letter and one special character.";
                    return Page();
                }

                // Check if user already exists
                var existingUser = _dbContext.Users.FirstOrDefault(u => u.Email == Email);
                if (existingUser != null)
                {
                    ErrorMessage = "A user with this email already exists.";
                    return Page();
                }

                // save user to the database
                var user = new User
                {
                    Name = Username,
                    Email = Email,
                    Password = Password // we should change this later for better password security (hashing???)
                };

                _dbContext.Users.Add(user);
                await _dbContext.SaveChangesAsync();

                // Redirect to login page
                return Redirect("/login");
            }
            catch (DbUpdateException e)
            {
                // privode database error message in case
                ErrorMessage = "Database error" + e;
                return Page();
            }
            catch (Exception e)
            {
                // provide message on random error
                ErrorMessage = "An error occurred" + e;
                return Page();
            }
        }

    }
}


