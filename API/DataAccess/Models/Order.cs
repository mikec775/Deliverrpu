using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Order
    {
        [Required]
        public string? OrderId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public int TotalPrice { get; set; }
        public UserAddress? UserAddress { get; set; }
        public User? User { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
