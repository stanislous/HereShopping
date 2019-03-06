using System;
using System.Collections.Generic;
using System.Text;
using ShoppingBOL;
using ShoppingDAL;

namespace ShoppingBLL
{
    public class CustomerBL
    {
        private CustomerDb customerDb;

        public CustomerBL()
        {
            customerDb = new CustomerDb();
        }

        //Create a Product
        public void CreateCustomer(Customer customer)
        {
            customerDb.CreateCustomer(customer);
        }

        //Update a Customer
        public void UpdateProduct(Customer customer)
        {
            customerDb.UpdateCustomer(customer);
        }

        //Delete a Customer
        public void DeleteCustomer(Customer customer)
        {
            customerDb.DeleteCustomer(customer);
        }

        //Get All Customer
        public IEnumerable<Customer> GetAllCustomer()
        {
            return customerDb.GetAllCustomers();
        }

        //Select a Customer using Id
        public Customer GetCustomerById(int id)
        {
            return customerDb.GetCustomerById(id);
        }

        //Get Orders from particular Customer
        public IEnumerable<Customer> CustomerWithOrders(int id)
        {
            return customerDb.CustomersWithOrders(id);
        }

        //Save Changes
        public void SaveChanges()
        {
            customerDb.Save();
        }
    }
}
