using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Bill
    {
        private DAL_Bill billModel = new DAL_Bill();
        public BUS_Bill() { }
        public List<DTO_Bill> GetBills(string query)
        {
            return billModel.GetBills(query);
        }
        public void AddBill(string bill_id, string card_id, string slot_id, string customer_id, string customer_name, string car_id, string car_number, DateTime check_in, DateTime check_out, int total, string pay_method)
        {
            DTO_Bill bill = new DTO_Bill();
            bill.Bill_id = bill_id;
            bill.Card_id = card_id;
            bill.Slot_id = slot_id;
            bill.Customer_id = customer_id;
            bill.Customer_name = customer_name;
            bill.Car_id = car_id;
            bill.Car_number = car_number;
            bill.Check_in = check_in;
            bill.Check_out = check_out;
            bill.Total = total;
            bill.Pay_method = pay_method;
            billModel.AddBill(bill);
        }

        public void DeleteBill(string bill_id)
        {
            billModel.DeleteBill(bill_id);
        }
    }
}
