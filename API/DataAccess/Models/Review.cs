namespace DataAccess.Models;
using System.ComponentModel.DataAnnotations;
public class Review
{
    public string? ReviewText { get; set; }
    public decimal ReviewRating { get; set; }
    public string? UserId { get; set; }
    public User? User { get; set; }
    public string? OrderItemId { get; set; }
    public OrderItem? OrderedItem { get; set; }
}