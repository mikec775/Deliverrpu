using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class OrderItem
    {
        public int Quantity { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Menu? Menu { get; set; }
    }
}

