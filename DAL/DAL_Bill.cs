using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Bill
    {
        List<DTO_Bill> bills;
        SqlCommand command;
        SqlDataReader reader;



        public List<DTO_Bill> GetBills(string query)
        {
            bills = new List<DTO_Bill>();
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                command = new SqlCommand(query, connection);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DTO_Bill bill = new DTO_Bill();
                    bill.Bill_id = reader.GetString(0);
                    bill.Card_id = reader.GetString(1);
                    bill.Slot_id = reader.GetString(2);
                    bill.Customer_id = reader.GetString(3);
                    bill.Customer_name = reader.GetString(4);
                    bill.Car_id = reader.GetString(5);
                    bill.Car_number = reader.GetString(6);
                    bill.Check_in = reader.GetDateTime(7);
                    bill.Check_out = reader.GetDateTime(8);
                    bill.Total = reader.GetInt32(9);
                    bill.Pay_method = reader.GetString(10);
                    bills.Add(bill);
                }

                connection.Close();
            }

            return bills;
        }

        public void AddBill(DTO_Bill bill)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "insert into Bill values (@bill_id, @card_id, @slot_id, @customer_id, @customer_name, @car_id, @car_number, @check_in, @check_out, @total, @pay_method)";
                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@bill_id", bill.Bill_id);
                command.Parameters.AddWithValue("@card_id", bill.Card_id);
                command.Parameters.AddWithValue("@slot_id", bill.Slot_id);
                command.Parameters.AddWithValue("@customer_id", bill.Customer_id);
                command.Parameters.AddWithValue("@customer_name", bill.Customer_name);

                command.Parameters.AddWithValue("@car_id", bill.Car_id);
                command.Parameters.AddWithValue("@car_number", bill.Car_number);
                command.Parameters.AddWithValue("@check_in", bill.Check_in);
                command.Parameters.AddWithValue("@check_out", bill.Check_out);
                command.Parameters.AddWithValue("@total", bill.Total);
                command.Parameters.AddWithValue("@pay_method", bill.Pay_method);


                command.ExecuteNonQuery();
                connection.Close();

            }
        }

        public void DeleteBill(string bill_id)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "DELETE FROM Bill where bill_id = @bill_id";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@bill_id", bill_id);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }


}



