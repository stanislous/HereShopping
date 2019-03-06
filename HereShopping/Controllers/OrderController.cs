using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using ShoppingBLL;
using ShoppingBOL;


namespace HereShopping.Controllers
{
    
    public class OrderController : Controller
    {
        private OrderBL orderBl;

        public OrderController()
        {
            orderBl = new OrderBL();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ShoppingBOL.Order order)
        {
            orderBl.CreateOrder(order);
            return RedirectToAction("Create", "Order");
        }
    }
}