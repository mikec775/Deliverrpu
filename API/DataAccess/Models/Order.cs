using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Order
    {
        public string? OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalPrice { get; set; }
        public string? UserAddressId { get; set; }
        public UserAddress? UserAddress { get; set; }
        public string? UserId { get; set; }
        public User? User { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
