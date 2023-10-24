namespace DataAccess.Models
{
    public class UserAddress
    {
        public string? AddressId { get; set; }
        public string? Address { get; set; }
        public string? AddressLabel { get; set; }
        public virtual User? User { get; set; }
    }
}
