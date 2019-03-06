using System;
using System.Collections.Generic;
using ShoppingBOL;
using ShoppingDAL;

namespace ShoppingBLL
{
    public class ProductBL
    {
        ProductDb productDb;

        public ProductBL()
        {
            productDb = new ProductDb();
        }

        //Create a Product
        public void CreateProduct(Product product)
        {
            productDb.CreateProduct(product);
        }

        //Update a Product
        public void UpdateProduct(Product product)
        {
            productDb.UpdateProduct(product);
        }

        //Delete a Product
        public void DeleteProduct(Product product)
        {
            productDb.DeleteProduct(product);
        }

        //Get All Products
        public IEnumerable<Product> GetAllProducts( )
        {
            return productDb.GetAllProducts();
        }
    
        //Select a product using Id
        public Product GetProductById(int id)
        {
            return productDb.GetProductById(id);
        }

        //Get Orders from particular product
        public IEnumerable<Product> ProductsWithOrders(int id)
        {
            return productDb.ProductsWithOrders(id);
        }

        //Save Changes
        public void SaveChanges( )
        {
            productDb.Save();
        }
    }
}
