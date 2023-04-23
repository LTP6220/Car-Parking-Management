using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Customer
    {
        private string customer_id;
        private string customer_name;
        private string email;
        private string phone;
        private string identification;

        public DTO_Customer()
        {

        }

        public DTO_Customer(string customer_id, string customer_name, string email, string phone, string identification)
        {
            this.customer_id = customer_id;
            this.customer_name = customer_name;
            this.email = email;
            this.phone = phone;
            this.identification = identification;
        }

        public string Customer_id { get => customer_id; set => customer_id = value; }

        public string Customer_name { get => customer_name; set => customer_name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Identification { get => identification; set => identification = value; }
    }
}
