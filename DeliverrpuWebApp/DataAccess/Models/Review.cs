namespace DataAccess.Models;
using System.ComponentModel.DataAnnotations;
public class Review
{
    [Required]
    public string? ReviewText { get; set; }

    [Required]
    [Range(1, 5)]
    public decimal ReviewRating { get; set; }
    public virtual User? User { get; set; }
    public virtual Menu? Menu { get; set; }

    public virtual OrderItem? OrderedItem { get; set; }
}