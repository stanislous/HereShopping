using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingBLL;
using ShoppingBOL;

namespace HereShopping.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerBL customerBl;

        public CustomerController()
        {
            customerBl = new CustomerBL();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            customerBl.CreateCustomer(customer);
            customerBl.SaveChanges();
            return RedirectToAction("Create", "Order");
        }
    }
}