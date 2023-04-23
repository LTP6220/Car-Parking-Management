using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ParkingSlot
    {
        private string slot_id;
        private string slot_name;
        private int availability;
        private string car_id;
        private DateTime check_in;
        private DateTime check_out;

        public DTO_ParkingSlot() { }

        public DTO_ParkingSlot(string slot_id, string slot_name, int availability, string car_id, DateTime check_in, DateTime check_out)
        {
            this.slot_id = slot_id;
            this.slot_name = slot_name;
            this.availability = availability;
            this.car_id = car_id;
            this.check_in = check_in;
            this.check_out = check_out;
        }

        public string Slot_id { get => slot_id; set => slot_id = value; }

        public string Slot_name { get => slot_name; set => slot_name = value; }

        public int Availability { get => availability; set => availability = value; }

        public string Car_id { get => car_id; set => car_id = value; }

        public DateTime Check_in { get => check_in; set => check_in = value; }

        public DateTime Check_out { get => check_out; set => check_out = value; }

    }
}
