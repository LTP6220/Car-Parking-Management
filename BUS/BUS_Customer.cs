using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Customer
    {
        private DAL_Customer customerModel = new DAL_Customer();

        public List<DTO_Customer> GetCustomers(string query)
        {
            return customerModel.GetCustomers(query);
        }

        public void AddCustomer(string customer_id, string customer_name, string email, string phone, string identification)
        {
            DTO_Customer customer = new DTO_Customer();
            customer.Customer_id = customer_id;
            customer.Customer_name = customer_name;
            customer.Email = email;
            customer.Phone = phone;
            customer.Identification = identification;
            customerModel.AddCustomer(customer);
        }

        public void UpdateCustomer(string customer_id, string customer_name, string email, string phone, string identification)
        {
            DTO_Customer customer = new DTO_Customer();
            customer.Customer_id = customer_id;
            customer.Customer_name = customer_name;
            customer.Email = email;
            customer.Phone = phone;
            customer.Identification = identification;
            customerModel.UpdateCustomer(customer);
        }

        public void DeleteCustomer(string customer_id)
        {
            customerModel.DeleteCustomer(customer_id);
        }

    }
}
