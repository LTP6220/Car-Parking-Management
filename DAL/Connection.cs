using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        public static string GetConnectionString()
        {
            SqlConnectionStringBuilder builder;
            builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            builder["Data Source"] = "(LocalDB)\\MSSQLLocalDB";
            builder["integrated Security"] = true;
            /*builder["Initial Catalog"] = "";*/
            builder["AttachDbFilename"] = "D:\\TDTU\\HK4\\Công nghệ phần mềm\\Đồ Án\\Car-Parking-Management\\CarParkingManagement\\Database1.mdf";
            /*builder.UserID = "DESKTOP-DJDATBB\\ASUS";*/
            Console.WriteLine(builder.ConnectionString);
            /*builder["Password"] = "";*/
            Console.Write(builder.ConnectionString);
            return builder.ConnectionString;
        }

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}
