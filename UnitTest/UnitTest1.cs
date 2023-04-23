using CarParkingManagement;
using DAL;
using System;
using System.Data;
using System.Drawing;
using BUS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using CarParkingManagement.CarManagerChildForm;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime check_in1 = DateTime.Now;
            PaymentForm paymentForm = new PaymentForm("", "", "", "", "", "", "", "", check_in1);

            DateTime check_in = DateTime.Parse("2023-04-22 15:30:00");

            DateTime check_out = DateTime.Parse("2023-04-23 10:00:00");

            int expectedResult = 175000;

            int result = paymentForm.total(check_in, check_out);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DashboardForm dashboardForm = new DashboardForm();
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                // Create the SqlCommand object with the SQL query and conn
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Customer", conn);

                // Open the conn
                conn.Open();

                // Execute the query and retrieve the count
                int count = (int)command.ExecuteScalar();

                // Close the conn
                conn.Close();
                int expectedResult = count;
                int result = dashboardForm.CountCustomer();
                Assert.AreEqual(expectedResult, result);
                // Display the count
            }

        }


    }
}
