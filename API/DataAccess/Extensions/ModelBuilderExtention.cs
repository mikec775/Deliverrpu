using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Extensions
{
    public static class ModelBuilderExtention
    {
        public static void SetUpPrimaryKeys(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().HasKey(m => m.MenuId);
            modelBuilder.Entity<Menu>().Property(m => m.MenuId).ValueGeneratedOnAdd();

            modelBuilder.Entity<MenuCategory>().HasKey(c => c.CategoryId);
            modelBuilder.Entity<MenuCategory>().Property(c => c.CategoryId).ValueGeneratedOnAdd();

            modelBuilder.Entity<Order>().HasKey(o => o.OrderId);
            modelBuilder.Entity<Order>().Property(o => o.OrderId).ValueGeneratedOnAdd();

            modelBuilder.Entity<OrderItem>().HasKey(oi => new
            {
                oi.OrderId,
                oi.MenuId
            });

            modelBuilder.Entity<Review>().HasKey(r => new
            {
                r.UserId,
                r.OrderItemId
            });
            modelBuilder.Entity<User>().HasKey(u => u.UserID);
            modelBuilder.Entity<User>().Property(u => u.UserID).ValueGeneratedOnAdd();

            modelBuilder.Entity<UserAddress>().HasKey(ua => ua.AddressId);
            modelBuilder.Entity<UserAddress>().Property(u => u.AddressId).ValueGeneratedOnAdd();

            modelBuilder.Entity<UserPaymentDetails>().HasKey(pd => pd.CardId);
            modelBuilder.Entity<UserPaymentDetails>().Property(upd => upd.CardId).ValueGeneratedOnAdd();
        }

        public static void SetUpForeignKeys(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuCategory>()
            .HasOne(mc => mc.Menu)
            .WithMany(m => m.MenuCategories);

            modelBuilder.Entity<OrderItem>().HasOne(o => o.Order).WithMany(o => o.OrderItems);
            modelBuilder.Entity<OrderItem>().HasOne(o => o.Menu).WithMany(m => m.OrderItems);

            modelBuilder.Entity<Review>().HasOne(r => r.OrderedItem).WithMany(oi => oi.Reviews);
            modelBuilder.Entity<Review>().HasOne(r => r.User).WithMany(u => u.Reviews);

            modelBuilder.Entity<Order>().HasMany(o => o.OrderItems).WithOne(o => o.Order);
            modelBuilder.Entity<Order>().HasOne(o => o.User).WithMany(u => u.Orders);
            modelBuilder.Entity<Order>().HasOne(o => o.UserAddress).WithMany(ua => ua.Orders);

            modelBuilder.Entity<UserAddress>().HasOne(ua => ua.User).WithMany(u => u.UserAddresses);

            modelBuilder.Entity<UserPaymentDetails>().HasOne(upd => upd.User).WithMany(u => u.UserPaymentDetails);
        }

        public static void SetUpIndexes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPaymentDetails>().HasIndex(upd => upd.CardNumber).IsUnique(true);
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique(true);
            modelBuilder.Entity<UserAddress>().HasIndex(ua => ua.Address).IsUnique(true);
            modelBuilder.Entity<Menu>().HasIndex(m => m.MenuName).IsUnique(true);
            modelBuilder.Entity<MenuCategory>().HasIndex(mc => mc.Category).IsUnique(true);

            modelBuilder.Entity<Menu>().Property(m => m.MenuPrice).HasPrecision(5, 2);
            modelBuilder.Entity<Review>().Property(m => m.ReviewRating).HasPrecision(1, 0);

        }
    }
}
