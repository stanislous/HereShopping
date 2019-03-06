using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShoppingBOL
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public double PricePerUnit { get; set; }
        [Required]
        public int Stock { get; set; }

        //Navigation Properties
        public IEnumerable<Product_Order> ProductOrders { get; set; }

    }
}
