using System;
using System.Collections.Generic;
using System.Text;
using ShoppingBOL;
using ShoppingDAL;

namespace ShoppingBLL
{
    public class OrderBL
    {
        private OrderDb _orderDb;

        public OrderBL()
        {
            _orderDb = new OrderDb();
        }

        //Create a Product
        public void CreateOrder(Order order)
        {
            _orderDb.CreateOrder(order);
        }

        //Update a Customer
        public void UpdateOrder(Order order)
        {
            _orderDb.UpdateOrder(order);
        }

        //Delete a Customer
        public void DeleteOrder(Order order)
        {
            _orderDb.DeleteOrder(order);
        }

        //Get All Customer
        public IEnumerable<Order> GetAllOrder()
        {
            return _orderDb.GetAllOrders();
        }

        //Select a Customer using Id
        public Order GetOrderById(int id)
        {
            return _orderDb.GetOrderById(id);
        }

//        //Get Orders from particular Customer
//        public IEnumerable<Customer> CustomerWithOrders(int id)
//        {
//            return customerDb.CustomersWithOrders(id);
//        }

        //Save Changes
        public void SaveChanges()
        {
            _orderDb.Save();
        }

    }
}
