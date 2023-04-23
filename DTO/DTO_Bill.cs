using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Bill
    {
        private string bill_id;
        private string card_id;
        private string slot_id;
        private string customer_id;
        private string customer_name;
        private string car_id;
        private string car_number;
        private int total;
        private DateTime check_in;
        private DateTime check_out;
        private string pay_method;
        public DTO_Bill() { }
        public DTO_Bill(string bill_id, string card_id, string slot_id, string customer_id, string customer_name, string car_id, string car_number, DateTime check_in, DateTime check_out, int total, string pay_method)
        {
            this.bill_id = bill_id;
            this.card_id = card_id;
            this.slot_id = slot_id;
            this.customer_id = customer_id;
            this.customer_name = customer_name;
            this.car_id = car_id;
            this.car_number = car_number;
            this.check_in = check_in;
            this.check_out = check_out;
            this.total = total;
            this.pay_method = pay_method;
        }

        public string Bill_id { get => bill_id; set => bill_id = value; }
        public string Card_id { get => card_id; set => card_id = value; }
        public string Slot_id { get => slot_id; set => slot_id = value; }
        public string Customer_id { get => customer_id; set => customer_id = value; }
        public string Customer_name { get => customer_name; set => customer_name = value; }
        public string Car_id { get => car_id; set => car_id = value; }
        public string Car_number { get => car_number; set => car_number = value; }
        public DateTime Check_in { get => check_in; set => check_in = value; }
        public DateTime Check_out { get => check_out; set => check_out = value; }
        public int Total { get => total; set => total = value; }
        public string Pay_method { get => pay_method; set => pay_method = value; }
    }
}
