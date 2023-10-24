using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class User
    {
        [Required]
        public string? UserID { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
    }
}
