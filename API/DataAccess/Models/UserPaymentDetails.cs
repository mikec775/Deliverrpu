namespace DataAccess.Models
{
    public class UserPaymentDetails
    {
        public string? CardId { get; set; }
        public int CardNumber { get; set; }
        public string? CardName { get; set; }
        public string? PaymentAddress { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
