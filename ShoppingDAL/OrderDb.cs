using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShoppingBOL;

namespace ShoppingDAL
{
    public class OrderDb
    {
        HShoppingDbContext hShoppingDbContext;
        public OrderDb()
        {
            hShoppingDbContext = new HShoppingDbContext();
        }
        //Create an Order
        public void CreateOrder(Order order)
        {
            hShoppingDbContext.Orders.Add(order);
        }

        //Update a Order
        public void UpdateOrder(Order order)
        {
            hShoppingDbContext.Orders.Update(order);
        }

        //Delete a Order
        public void DeleteOrder(Order order)
        {
            hShoppingDbContext.Orders.Remove(order);
        }

        //Get All Orders
        public IEnumerable<Order> GetAllOrders()
        {
            return hShoppingDbContext.Orders.ToList();
        }

        //Select a order using Id
        public Order GetOrderById(int id)
        {
            return hShoppingDbContext.Orders.Find(id);
        }

        //Get Customers from particular Order
        public IEnumerable<Order> OrdersWithCustomers(int id)
        {
            return hShoppingDbContext.Orders.Include(x => x.Customer).ToList();
        }

        //Save Changes
        public void Save()
        {
            hShoppingDbContext.SaveChanges();
        }
    }
}
