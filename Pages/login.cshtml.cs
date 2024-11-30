using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Synaptica.Data;
using System.ComponentModel.DataAnnotations;
using Synaptica.Services;
namespace Synaptica.Pages
{   //this model contains the functionality of the login page to verify the users creds
    public class LoginModel : PageModel
    {
        private readonly SynpaticaDbContext _dbContext;
        private readonly SessionService _sessionService;

        //constructor
        public LoginModel(SynpaticaDbContext dbContext, SessionService sessionService)
        {
            _dbContext = dbContext;
            _sessionService = sessionService;
        }

        //properties for registration along with required, and error messages for data feilds 
        [BindProperty]
        [Required(ErrorMessage = "Email is required.")]
        public string? Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password is required.")]
        public string? Password { get; set; }

        //holds error messages that will be displayed
        public string? ErrorMessage { get; set; }

        public void OnGet()
        {
           
        }
        //proccess and validate login creds
        public async Task<IActionResult> OnPostAsync()
        {   //checks feilds for requred
            if (!ModelState.IsValid)
            {
                return Page(); // reload page with errors if any 
            }

            try
            {
                // check db for user with the same email and password
                var user = await _dbContext.Users
                    .FirstOrDefaultAsync(u => u.Email == Email && u.Password == Password);
                //error message updated if there is no user mathing 
                if (user == null)
                {
                    ErrorMessage = "Invalid email or password.";
                    return Page();
                }
                //when there is a valid user then set the logged in user to their name
                _sessionService.LoggedInUser = user.UserId;

                return Redirect("/index"); // redirects to our home page after login
            }
            catch (Exception e)
            { /// here in case something goes wrong 
                ErrorMessage = "An error occurred during login: " + e;
                return Page();
            }
        }
    }
}

