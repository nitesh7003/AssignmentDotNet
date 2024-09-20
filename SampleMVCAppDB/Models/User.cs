using System.ComponentModel.DataAnnotations;

namespace SampleMVCAppDB.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }  // Primary key, no validation needed

        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long")]
        public string PasswordHash { get; set; }

        [Required(ErrorMessage = "Role is required")]
        [RegularExpression("User|Admin", ErrorMessage = "Role must be either 'User' or 'Admin'")]
        public string Role { get; set; } = "User";  // Default role set to "User"
    }
}
