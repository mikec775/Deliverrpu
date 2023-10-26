namespace DataAccess.Models
{
    public class UserPaymentDetails
    {
        public string? CardId { get; set; }
        public int Card_number { get; set; }//here is diferent than in scheme
        public string? CardName { get; set; }
        public string? PaymentAddress { get; set; }
        public DateTime ExpiryDate { get; set; }//here as well
        public User? User { get; set; }
    }
}
