namespace DataAccess.Models
{
    public class Menu
    {
        public string? MenuId { get; set; }
        public string? MenuName { get; set; }
        public string? MenuDescription { get; set; }
        public string? MenuNutrience { get; set; }
        public int MenuPrepTime { get; set; }
        public string? MenuImage { get; set; }
        public decimal MenuPrice { get; set; }
    }
}
