using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Extensions
{
    public static class SeedData
    {
        public static void SeedDataInDb(this ModelBuilder builder)
        {
            builder.Entity<User>().HasData(TestData.GetUsers);
            builder.Entity<UserPaymentDetails>().HasData(TestData.GetUserPaymentDetails);
            builder.Entity<UserAddress>().HasData(TestData.GetUserAddresses);
            builder.Entity<Menu>().HasData(TestData.GetMenus);
            builder.Entity<MenuCategory>().HasData(TestData.GetMenuCategories);
            builder.Entity<Order>().HasData(TestData.GetOrders);
            builder.Entity<OrderItem>().HasData(TestData.GetOrderItems);
            builder.Entity<Review>().HasData(TestData.GetReviews);
        }
    }
}
