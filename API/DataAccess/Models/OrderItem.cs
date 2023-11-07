using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        [Required]
        public string? OrderId { get; set; }
        public Order? Order { get; set; }
        [Required]
        public string? MenuId { get; set; }
        public Menu? Menu { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; } 
    }
}

