namespace DataAccess.Models
{
    public class UserAddress
    {
        public string? AddressId { get; set; }
        public string? Address { get; set; }
        public string? AddressLabel { get; set; }
        public string? UserId { get; set; }
        public User? User { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
