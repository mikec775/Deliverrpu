using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class MenuCategory
    {
        public string? CategoryId { get; set; }
        public string? Category { get; set; }
        public string? MenuId { get; set; }
        public Menu? Menu { get; set; }
    }
}
