using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Car
    {
        private DAL_Car carModel = new DAL_Car();

        public List<DTO_Car> GetCars(string query)
        {
            return carModel.GetCars(query);
        }

        public void AddCar(string car_id, string car_name, string car_number, string car_color)
        {
            DTO_Car car = new DTO_Car();
            car.Car_id = car_id;
            car.Car_name = car_name;
            car.Car_number = car_number;
            car.Car_color = car_color;
            carModel.AddCar(car);
        }

        public void UpdateCar(string car_id, string car_name, string car_number, string car_color)
        {
            DTO_Car car = new DTO_Car();
            car.Car_id = car_id;
            car.Car_name = car_name;
            car.Car_number = car_number;
            car.Car_color = car_color;
            carModel.UpdateCar(car);
        }

        public void DeleteCar(string car_id)
        {
            carModel.DeleteCar(car_id);
        }
    }
}
