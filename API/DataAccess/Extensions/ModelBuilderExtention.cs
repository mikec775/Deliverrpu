using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace DataAccess.Extensions
{
    public static class ModelBuilderExtention
    {
        public static void setUpModelBuilder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().HasKey(m => m.MenuId);

            modelBuilder.Entity<MenuCategory>().HasKey(c => c.CategoryId);

            modelBuilder.Entity<MenuCategory>()
                .HasOne(mc => mc.Menu)
                .WithMany(m => m.MenuCategories);

            modelBuilder.Entity<Order>().HasKey(o => o.OrderId);

            modelBuilder.Entity<OrderItem>().HasKey(oi => new
            {
                oi.Order,
                oi.Menu
            });

            modelBuilder.Entity<Review>().HasKey(r => new
            {
                r.User,
                r.OrderedItem,
                r.Menu
            });

            modelBuilder.Entity<Review>().HasOne(r => new { r.OrderedItem, r.Menu }).WithMany();

            modelBuilder.Entity<User>().HasKey(u => u.UserID);

            modelBuilder.Entity<UserAddress>().HasKey(ua => ua.AddressId);

            modelBuilder.Entity<UserPaymentDetails>().HasKey(pd => pd.CardId);
        }
    }
}
