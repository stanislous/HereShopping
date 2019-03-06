using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShoppingBOL
{
    //Relational Table
    [Table("Product_Order")]
    public class Product_Order
    {
        [Key]
        public int POId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }

    }
}
