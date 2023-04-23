using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ParkingCard
    {
        private string card_id;
        private string slot_id;
        private string car_number;
        private string customer_id;
        private DateTime check_in;
        private DateTime check_out;


        public DTO_ParkingCard()
        {

        }

        public DTO_ParkingCard(string card_id, string slot_id, string car_number, string customer_id, DateTime check_in, DateTime check_out)
        {
            this.card_id = card_id;
            this.car_number = car_number;
            this.check_in = check_in;
            this.check_out = check_out;
            this.customer_id = customer_id;
            this.slot_id = slot_id;
        }

        public string Car_id { get => card_id; set => card_id = value; }

        public string Slot_id { get => slot_id; set => slot_id = value; }

        public string Car_number { get => car_number; set => car_number = value; }

        public string Customer_id { get => customer_id; set => customer_id = value; }

        public DateTime Check_in { get => check_in; set => check_in = value; }

        public DateTime Check_out { get => check_out; set => check_out = value; }


    }
}
