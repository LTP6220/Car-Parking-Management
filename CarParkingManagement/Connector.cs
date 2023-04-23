using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace CarParkingManagement
{
    public class Connector
    {
        public OleDbConnection connection;
        public OleDbCommand command;
        public OleDbDataAdapter adapter;
        public OleDbDataReader reader;

        public void Link()
        {
            connection = new OleDbConnection();
            command = new OleDbCommand();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\Database1.mdf";
            command.Connection = connection;

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Close();
                connection.Open();

            }
        }
    }
}
