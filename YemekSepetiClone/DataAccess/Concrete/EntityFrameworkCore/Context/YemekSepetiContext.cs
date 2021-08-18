using Microsoft.EntityFrameworkCore;
using YemekSepetiClone.Models;
using YemekSepetiClone.Models.User;

namespace YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class YemekSepetiContext : DbContext
    {
        public YemekSepetiContext(DbContextOptions<YemekSepetiContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Shop>().ToTable("Shops");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}