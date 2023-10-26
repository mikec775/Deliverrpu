namespace DataAccess.Models;
using System.ComponentModel.DataAnnotations;
public class Review
{
    [Required]
    public string? ReviewText { get; set; }

    [Required]
    [Range(1, 5)]
    public decimal ReviewRating { get; set; }
    public User? User { get; set; }
    public Menu? Menu { get; set; }

    public OrderItem? OrderedItem { get; set; }
}