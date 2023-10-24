using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class MenuCategory
    {
        [Required]
        public string? CategoryId { get; set; }
        [Required]
        public string? Category { get; set; }
        public virtual Menu? Menu { get; set; }
    }
}
