using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShoppingBOL
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateOrder { get; set; }


        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

        //Navigation Properties
        public Customer Customer { get; set; }
        public IEnumerable<Product_Order> ProductOrders { get; set; }

    }
}
