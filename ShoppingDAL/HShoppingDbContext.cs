using System;
using Microsoft.EntityFrameworkCore;
using ShoppingBOL;

namespace ShoppingDAL
{
    public class HShoppingDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ANDROIDAP;Database=HereShoppingDb;Trusted_Connection=true;");
        }

        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product_Order> ProductOrders{ get; set; }
        
    }
}
