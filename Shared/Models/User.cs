using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Synaptica.Shared.Models
{
    [Table("Users")] // Maps to the user table in database
    public class User
    {
        [Key]
        [Column("userId")] // Maps to the userId column in table
        public int UserId { get; set; }

        [Column("name")] // Maps to the name column
        public string? Name { get; set; }

        [Column("email")] // Maps to the email column
        public string? Email { get; set; }

        [Column("password")] // Maps to the password column
        public string? Password { get; set; }
    }
}