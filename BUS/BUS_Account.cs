using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Account
    {
        private DAL_Account accountModel = new DAL_Account();

        public List<DTO_Account> GetAccounts(string query)
        {
            return accountModel.GetAccounts(query);
        }

        public void AddAccount(string id, string fullname, string username, string password, string email, string position)
        {
            DTO_Account account = new DTO_Account();
            account.Id = id;
            account.Fullname = fullname;
            account.Username = username;
            account.Password = password;
            account.Email = email;
            account.Position = position;
            accountModel.AddAccount(account);
        }


        public void DeleteAccount(string id)
        {
            accountModel.DeleteAccount(id);
        }

        public void UpdateAccount(string id, string fullname, string username, string password, string email, string position)
        {
            DTO_Account account = new DTO_Account();
            account.Id = id;
            account.Fullname = fullname;
            account.Username = username;
            account.Password = password;
            account.Email = email;
            account.Position = position;
            accountModel.UpdateAccount(account);
        }

        public void Command(string query)
        {
            accountModel.Command(query);
        }
    }
}
