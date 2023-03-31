﻿using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
                System.Diagnostics.Debug.WriteLine(command.CommandText);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DTO_Account account = new DTO_Account();
                    account.Id = reader.GetString(0);
                    account.Email = reader.GetString(1);
                    account.Fullname = reader.GetString(2);
                    account.Username = reader.GetString(3);
                    account.Password = reader.GetString(4);

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
                string query = "insert into Account values (@id, @fullname, @username, @password, @email)";
                command = new SqlCommand(query, connection);
                System.Diagnostics.Debug.WriteLine(command.CommandText);
                command.Parameters.AddWithValue("@id", account.Id);
                command.Parameters.AddWithValue("@fullname", account.Fullname);
                command.Parameters.AddWithValue("@username", account.Username);
                command.Parameters.AddWithValue("@password", account.Password);
                command.Parameters.AddWithValue("@email", account.Email);
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