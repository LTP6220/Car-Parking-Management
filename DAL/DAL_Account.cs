using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Account
    {
        List<DTO_Account> accounts;
        SqlCommand command;
        SqlDataReader reader;
        public List<DTO_Account> GetAccounts(string query)
        {
            accounts = new List<DTO_Account>();
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                command = new SqlCommand(query, connection);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DTO_Account account = new DTO_Account();
                    account.Id = reader.GetString(0);
                    account.Fullname = reader.GetString(1);
                    account.Username = reader.GetString(2);
                    account.Password = reader.GetString(3);
                    account.Email = reader.GetString(4);
                    account.Position = reader.GetString(5);
                    accounts.Add(account);
                }

                connection.Close();
            }

            return accounts;
        }

        public void AddAccount(DTO_Account account)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "insert into Account values (@id, @fullname, @username, @password, @email, @position)";
                command = new SqlCommand(query, connection);
                System.Diagnostics.Debug.WriteLine(command.CommandText);
                command.Parameters.AddWithValue("@id", account.Id);
                command.Parameters.AddWithValue("@fullname", account.Fullname);
                command.Parameters.AddWithValue("@username", account.Username);
                command.Parameters.AddWithValue("@password", account.Password);
                command.Parameters.AddWithValue("@email", account.Email);
                command.Parameters.AddWithValue("@position", account.Position);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteAccount(string id)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "DELETE FROM Account where id = @id";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateAccount(DTO_Account account)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "UPDATE Account SET id = @id," +
                    "fullname = @fullname, username = @username, password = @password," +
                    "email = @email, position = @position " +
                    "WHERE id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", account.Id);
                command.Parameters.AddWithValue("@fullname", account.Fullname);
                command.Parameters.AddWithValue("@username", account.Username);
                command.Parameters.AddWithValue("@password", account.Password);
                command.Parameters.AddWithValue("@email", account.Email);
                command.Parameters.AddWithValue("@position", account.Position);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void UpdatePassword(string newPassword, string username)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "UPDATE Account SET password = '" + newPassword + "' where username = '" + username + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter data = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                data.Fill(dt);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }


        public void Command(string query)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
