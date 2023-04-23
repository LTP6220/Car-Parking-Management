using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Customer
    {
        List<DTO_Customer> customers;
        SqlCommand command;
        SqlDataReader reader;

        public List<DTO_Customer> GetCustomers(string query)
        {
            customers = new List<DTO_Customer>();
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                command = new SqlCommand(query, connection);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DTO_Customer customer = new DTO_Customer();
                    customer.Customer_id = reader.GetString(0);
                    customer.Customer_name = reader.GetString(1);
                    customer.Email = reader.GetString(2);
                    customer.Phone = reader.GetString(3);
                    customer.Identification = reader.GetString(4);
                    customers.Add(customer);
                }

                connection.Close();
            }

            return customers;
        }

        public void AddCustomer(DTO_Customer customer)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "insert into Customer values (@customer_id, @customer_name, @email, @phone, @identification)";
                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@customer_id", customer.Customer_id);
                command.Parameters.AddWithValue("@customer_name", customer.Customer_name);
                command.Parameters.AddWithValue("@email", customer.Email);
                command.Parameters.AddWithValue("@phone", customer.Phone);
                command.Parameters.AddWithValue("@identification", customer.Identification);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateCustomer(DTO_Customer customer)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "UPDATE Customer SET customer_id = @customer_id, customer_name = @customer_name, email = @email, phone = @phone, identification = @identification WHERE customer_id = @customer_id";
                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@customer_id", customer.Customer_id);
                command.Parameters.AddWithValue("@customer_name", customer.Customer_name);
                command.Parameters.AddWithValue("@email", customer.Email);
                command.Parameters.AddWithValue("@phone", customer.Phone);
                command.Parameters.AddWithValue("@identification", customer.Identification);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteCustomer(string customer_id)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "DELETE FROM Customer where customer_id = @customer_id";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@customer_id", customer_id);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
