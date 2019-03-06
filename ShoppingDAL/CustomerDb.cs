using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShoppingBOL;

namespace ShoppingDAL
{
    public class CustomerDb
    {
        HShoppingDbContext hShoppingDbContext;
        public CustomerDb()
        {
            hShoppingDbContext = new HShoppingDbContext();
        }

        //Create a Customer
        public void CreateCustomer(Customer customer)
        {
            hShoppingDbContext.Customers.Add(customer);
        }

        //Update a Customer
        public void UpdateCustomer(Customer customer)
        {
            hShoppingDbContext.Customers.Update(customer);
        }

        //Delete a Customer
        public void DeleteCustomer(Customer customer)
        {
            hShoppingDbContext.Customers.Remove(customer);
        }

        //Get All Customers
        public IEnumerable<Customer> GetAllCustomers()
        {
            return hShoppingDbContext.Customers.ToList();
        }

        //Select a Customer using Id
        public Customer GetCustomerById(int id)
        {
            return hShoppingDbContext.Customers.Find(id);
        }

        //Get Orders from particular Customer
        public IEnumerable<Customer> CustomersWithOrders(int id)
        {
            return hShoppingDbContext.Customers.Include(x => x.Orders).ToList();
        }

        //Save Changes
        public void Save()
        {
            hShoppingDbContext.SaveChanges();
        }
    }
}
