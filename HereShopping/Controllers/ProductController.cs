using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingBOL;
using ShoppingBLL;

namespace HereShopping.Controllers
{
    public class ProductController : Controller
    {
        private ProductBL productBl;
        public ProductController()
        {
            productBl = new ProductBL();
        }

        public IActionResult Index( )
        {
            return View();
        }

        #region Create Product
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            productBl.CreateProduct(product);
            productBl.SaveChanges();
            return RedirectToAction("Create", "Product");
        }
        #endregion

        #region See All Products

        public IActionResult SeeAll( )
        {
            IEnumerable<Product> AllProducts = productBl.GetAllProducts();
            return View(AllProducts);
        }
        #endregion
    }
}