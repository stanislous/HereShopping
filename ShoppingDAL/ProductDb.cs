using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShoppingBOL;

namespace ShoppingDAL
{
    public class ProductDb
    {
        HShoppingDbContext hShoppingDbContext;
        public ProductDb()
        {
            hShoppingDbContext = new HShoppingDbContext();
        }
        
        //Create a Product
        public void CreateProduct(Product product)
        {
            hShoppingDbContext.Products.Add(product);
        }

        //Update a Product
        public void UpdateProduct(Product product)
        {
            hShoppingDbContext.Products.Update(product);
        }

        //Delete a Product
        public void DeleteProduct(Product product)
        {
            hShoppingDbContext.Products.Remove(product);
        }

        //Get All Products
        public IEnumerable<Product> GetAllProducts( )
        {
            return hShoppingDbContext.Products.ToList();
        }

        //Select a product using Id
        public Product GetProductById(int id)
        {
            return hShoppingDbContext.Products.Find(id);
        }

        //Get Orders from particular product
        public IEnumerable<Product> ProductsWithOrders(int id)
        {
            return hShoppingDbContext.Products.Include(x => x.ProductOrders).ToList();
        }

        //Save Changes
        public void Save( )
        {
            hShoppingDbContext.SaveChanges();
        }

    }
}
