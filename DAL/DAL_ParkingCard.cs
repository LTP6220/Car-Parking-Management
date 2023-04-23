
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ParkingCard
    {

        List<DTO_ParkingCard> parkingCards;
        SqlCommand command;
        SqlDataReader reader;


        public List<DTO_ParkingCard> GetParkingCards(string query)
        {
            parkingCards = new List<DTO_ParkingCard>();
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                command = new SqlCommand(query, connection);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DTO_ParkingCard parkingCard = new DTO_ParkingCard();
                    parkingCard.Car_id = reader.GetString(0);
                    parkingCard.Slot_id = reader.GetString(1);
                    parkingCard.Car_number = reader.GetString(2);
                    parkingCard.Customer_id = reader.GetString(3);
                    parkingCard.Check_in = reader.GetDateTime(4);
                    parkingCard.Check_out = reader.GetDateTime(5);

                    parkingCards.Add(parkingCard);
                }

                connection.Close();
            }

            return parkingCards;
        }

        public void AddParkingCard(DTO_ParkingCard parkingCard)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "insert into ParkingCard values (@card_id, @slot_id, @car_number, @customer_id, @check_in, @check_out)";
                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@card_id", parkingCard.Car_id);
                command.Parameters.AddWithValue("@slot_id", parkingCard.Slot_id);
                command.Parameters.AddWithValue("@car_number", parkingCard.Car_number);
                command.Parameters.AddWithValue("@customer_id", parkingCard.Customer_id);
                command.Parameters.AddWithValue("@check_in", parkingCard.Check_in);
                command.Parameters.AddWithValue("@check_out", parkingCard.Check_out);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }



        public void AddParkingCardHour(string card_id, string slot_id, string car_number, string customer_id, DateTime check_in, DateTime? check_out)
        {

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "insert into ParkingCard values (@card_id, @slot_id, @car_number, @customer_id, @check_in, @check_out)";
                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@card_id", card_id);
                command.Parameters.AddWithValue("@slot_id", slot_id);
                command.Parameters.AddWithValue("@car_number", car_number);
                command.Parameters.AddWithValue("@customer_id", customer_id);
                command.Parameters.AddWithValue("@check_in", check_in);
                command.Parameters.AddWithValue("@check_out", check_out ?? (object)DBNull.Value);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }


        public void UpdateToParkingSlot(string slot_id, string car_id, DateTime check_in, DateTime check_out)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                //string query = "UPDATE ParkingSlot SET check_in = '" + check_in + "', check_out = '" + check_out + "' WHERE slot_id = '" + slot_id + "'";

                string query = "UPDATE ParkingSlot SET check_in = @check_in, check_out = @check_out, car_id = @car_id WHERE slot_id = @slot_id";
                command = new SqlCommand(query, connection);
                //SqlDataAdapter data = new SqlDataAdapter(command);
                //DataTable dt = new DataTable();
                //data.Fill(dt);

                command.Parameters.AddWithValue("@slot_id", slot_id);
                command.Parameters.AddWithValue("@check_in", check_in);
                command.Parameters.AddWithValue("@check_out", check_out);
                command.Parameters.AddWithValue("@car_id", car_id);


                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateNullToParkingSlot(string slot_id, string car_id, DateTime? check_in, DateTime? check_out)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                //string query = "UPDATE ParkingSlot SET check_in = '" + check_in + "', check_out = '" + check_out + "' WHERE slot_id = '" + slot_id + "'";

                string query = "UPDATE ParkingSlot SET check_in = @check_in, check_out = @check_out, car_id = @car_id WHERE slot_id = @slot_id";
                command = new SqlCommand(query, connection);
                //SqlDataAdapter data = new SqlDataAdapter(command);
                //DataTable dt = new DataTable();
                //data.Fill(dt);

                command.Parameters.AddWithValue("@slot_id", slot_id);
                command.Parameters.AddWithValue("@check_in", check_in ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@check_out", check_out ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@car_id", car_id ?? (object)DBNull.Value);


                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateToParkingSlotHour(string slot_id, string car_id, DateTime check_in, DateTime? check_out)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                //string query = "UPDATE ParkingSlot SET check_in = '" + check_in + "', check_out = '" + check_out + "' WHERE slot_id = '" + slot_id + "'";

                string query = "UPDATE ParkingSlot SET check_in = @check_in, check_out = @check_out, car_id = @car_id WHERE slot_id = @slot_id";
                command = new SqlCommand(query, connection);
                //SqlDataAdapter data = new SqlDataAdapter(command);
                //DataTable dt = new DataTable();
                //data.Fill(dt);

                command.Parameters.AddWithValue("@slot_id", slot_id);
                command.Parameters.AddWithValue("@check_in", check_in);
                command.Parameters.AddWithValue("@check_out", check_out ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@car_id", car_id);


                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateAvailabilityToParkingSlot(string availability)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "UPDATE ParkingSlot SET ParkingSlot.availability = @availability where check_in is not NULL ";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@availability", availability);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateNotAvailabilityToParkingSlot(string availability)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "UPDATE ParkingSlot SET ParkingSlot.availability = @availability where check_in is NULL ";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@availability", availability);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
