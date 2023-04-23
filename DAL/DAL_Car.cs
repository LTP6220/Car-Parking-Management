using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Car
    {
        List<DTO_Car> cars;
        SqlCommand command;
        SqlDataReader reader;

        public List<DTO_Car> GetCars(string query)
        {
            cars = new List<DTO_Car>();
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                command = new SqlCommand(query, connection);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DTO_Car car = new DTO_Car();
                    car.Car_id = reader.GetString(0);
                    car.Car_name = reader.GetString(1);
                    car.Car_number = reader.GetString(2);
                    car.Car_color = reader.GetString(3);
                    cars.Add(car);
                }

                connection.Close();
            }

            return cars;
        }

        public void AddCar(DTO_Car car)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "insert into Car values (@car_id, @car_name, @car_number, @car_color)";
                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@car_id", car.Car_id);
                command.Parameters.AddWithValue("@car_name", car.Car_name);
                command.Parameters.AddWithValue("@car_number", car.Car_number);
                command.Parameters.AddWithValue("@car_color", car.Car_color);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateCar(DTO_Car car)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "UPDATE Car SET car_id = @car_id, car_name = @car_name, car_number = @car_number, car_color = @car_color WHERE car_id = @car_id";
                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@car_id", car.Car_id);
                command.Parameters.AddWithValue("@car_name", car.Car_name);
                command.Parameters.AddWithValue("@car_number", car.Car_number);
                command.Parameters.AddWithValue("@car_color", car.Car_color);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteCar(string car_id)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "DELETE FROM Car where car_id = @car_id";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@car_id", car_id);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
