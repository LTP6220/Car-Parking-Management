using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Account
    {
        private string id;
        private string email;
        private string fullname;
        private string username;
        private string password;
        private string position;

        public DTO_Account()
        {
        }

        public DTO_Account(string id, string fullname, string username, string password, string email, string position)
        {
            this.id = id;
            this.email = email;
            this.fullname = fullname;
            this.username = username;
            this.password = password;
            this.position = position;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Position { get => position; set => position = value; }
    }
}
