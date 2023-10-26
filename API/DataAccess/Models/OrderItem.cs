using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class OrderItem
    {
        public int Quantity { get; set; }

        public Order? Order { get; set; }
        public Menu? Menu { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; } 
    }
}

