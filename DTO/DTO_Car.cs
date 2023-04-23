using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Car
    {
        private string car_id;
        private string car_number;
        private string car_name;
        private string car_color;

        public DTO_Car() { }
        public DTO_Car(string car_id, string car_name, string car_number, string car_color)
        {
            this.car_id = car_id;
            this.car_number = car_number;
            this.car_name = car_name;
            this.car_color = car_color;
        }
        public string Car_id { get => car_id; set => car_id = value; }
        public string Car_name { get => car_name; set => car_name = value; }
        public string Car_number { get => car_number; set => car_number = value; }

        public string Car_color { get => car_color; set => car_color = value; }
    }
}
