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

        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
        public Product_Order ProductOrder{ get; set; }

    }
}
