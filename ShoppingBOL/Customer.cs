using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingBOL
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        [EmailAddress, Required]
        public string Email { get; set; }

        //Navigation Properties
        public IEnumerable<Order> Orders { get; set; }

    }
}
