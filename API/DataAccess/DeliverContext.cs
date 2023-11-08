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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=tcp:deliverrpu.database.windows.net,1433;Initial Catalog=Deliverrpu;
                Persist Security Info=False;User ID=deliverrpu;Password=cpsd@2023;MultipleActiveResultSets=False;
                Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

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