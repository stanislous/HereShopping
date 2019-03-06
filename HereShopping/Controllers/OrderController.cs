using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using ShoppingBLL;

namespace HereShopping.Controllers
{
    
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {

            return RedirectToAction("Create", "Order");
        }
    }
}