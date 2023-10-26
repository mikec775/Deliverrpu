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
        public virtual ICollection<Review>? Reviews { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
        public virtual ICollection<UserPaymentDetails>? UserPaymentDetails { get; set; }

    }
}
