using DataAccess.Extensions;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class DeliverContext : DbContext
    {
        public DeliverContext(DbContextOptions<DeliverContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Menu>? Menus { get; set; }
        public DbSet<MenuCategory>? MenuCategories { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderItem>? OrderItems { get; set; }
        public DbSet<Review>? Reviews { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<UserAddress>? UserAddresses { get; set; }
        public DbSet<UserPaymentDetails>? UserPaymentDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SetUpPrimaryKeys();
            modelBuilder.SetUpForeignKeys();
            modelBuilder.SetUpIndexes();
            modelBuilder.SeedDataInDb();
        }


    }
}