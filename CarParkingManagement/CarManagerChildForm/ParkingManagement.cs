using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManagement
{
    public partial class ParkingManagement : Form
    {

        SqlDataAdapter data;
        DataTable tb;


        public ParkingManagement()
        {
            InitializeComponent();
        }

        private string AutoCreateCardId()
        {
            string s = "SELECT TOP 1 card_id FROM ParkingCard ORDER BY card_id DESC";
            data = new SqlDataAdapter(s, Connection.GetSqlConnection());
            tb = new DataTable();
            data.Fill(tb);

            if (tb.Rows.Count > 0)
            {
                s = tb.Rows[0][0].ToString();
                s = s.Substring(s.Length - 3, 3);
                int stt = int.Parse(s) + 1;

                if (stt < 10)
                {
                    s = "CD" + "00" + stt.ToString();
                }
                else if (stt < 100)
                {
                    s = "CD" + "0" + stt.ToString();
                }
                else
                {
                    s = "CD" + stt.ToString();
                }
            }
            else
            {
                s = "CD" + "001";
            }


            return s;
        }



        public void Form1_Load(object sender, EventArgs e)
        {
            string[] slot_name = new string[14];
            for (int i = 0; i < slot_name.Length; i++)
            {
                slot_name[i] = "A" + (i + 1).ToString("D2");
            }

            string[] slot_nameB = new string[14];
            for (int i = 0; i < slot_nameB.Length; i++)
            {
                slot_nameB[i] = "B" + (i + 1).ToString("D2");
            }

            string[] slot_nameC = new string[14];
            for (int i = 0; i < slot_nameC.Length; i++)
            {
                slot_nameC[i] = "C" + (i + 1).ToString("D2");
            }

            string[] panel_a = new string[14];
            for (int i = 0; i < panel_a.Length; i++)
            {
                panel_a[i] = "panel_a" + (i + 1).ToString();
            }

            string[] panel_b = new string[14];
            for (int i = 0; i < panel_b.Length; i++)
            {
                panel_b[i] = "panel_b" + (i + 1).ToString();
            }

            string[] panel_c = new string[14];
            for (int i = 0; i < panel_c.Length; i++)
            {
                panel_c[i] = "panel_c" + (i + 1).ToString();
            }

            int k = 0;
            foreach (string panelName in panel_a)
            {
                Panel panel = this.Controls.Find(panelName, true).FirstOrDefault() as Panel;
                if (panel != null)
                {
                    panel.BackColor = Color.FromArgb(150, 0, 0, 0);
                }

                if (Availability(slot_name[k]) == "1")
                {
                    panel.Visible = false;
                    panel.Enabled = false;

                }
                else
                {
                    panel.Visible = true;
                    panel.Enabled = true;
                }

                k++;
            }

            int j = 0;
            foreach (string panelName in panel_b)
            {
                Panel panel = this.Controls.Find(panelName, true).FirstOrDefault() as Panel;
                if (panel != null)
                {
                    panel.BackColor = Color.FromArgb(150, 0, 0, 0);
                }

                if (Availability(slot_nameB[j]) == "1")
                {
                    panel.Visible = false;
                    panel.Enabled = false;
                }
                else
                {
                    panel.Visible = true;
                    panel.Enabled = true;
                }

                j++;
            }

            int l = 0;
            foreach (string panelName in panel_c)
            {
                Panel panel = this.Controls.Find(panelName, true).FirstOrDefault() as Panel;
                if (panel != null)
                {
                    panel.BackColor = Color.FromArgb(150, 0, 0, 0);
                }

                if (Availability(slot_nameC[l]) == "1")
                {
                    panel.Visible = false;
                    panel.Enabled = false;
                }
                else
                {
                    panel.Visible = true;
                    panel.Enabled = true;
                }

                l++;
            }
            //panel_picA1.Enabled = false;
            //panel_a1.Enabled = true;
        }

        private string Availability(string slot_name)
        {
            string availability = "SELECT TOP 1 availability FROM ParkingSlot WHERE slot_name = '" + slot_name + "'";
            data = new SqlDataAdapter(availability, Connection.GetSqlConnection());
            tb = new DataTable();
            data.Fill(tb);
            availability = tb.Rows[0][0].ToString();
            return availability;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel_a1_Paint(object sender, PaintEventArgs e)
        {

        }

        private string AutoCreateBillId()
        {
            string s = "SELECT TOP 1 bill_id FROM Bill ORDER BY bill_id DESC";
            data = new SqlDataAdapter(s, Connection.GetSqlConnection());
            tb = new DataTable();
            data.Fill(tb);

            if (tb.Rows.Count > 0)
            {
                s = tb.Rows[0][0].ToString();
                s = s.Substring(s.Length - 4, 4);
                int stt = int.Parse(s) + 1;

                if (stt < 10)
                {
                    s = "BILL" + "000" + stt.ToString();
                }
                else if (stt < 100)
                {
                    s = "BILL" + "00" + stt.ToString();
                }
                else if (stt < 1000)
                {
                    s = "BILL" + "0" + stt.ToString();
                }
                else
                {
                    s = "BILL" + stt.ToString();
                }
            }
            else
            {
                s = "BILL" + "0001";
            }


            return s;
        }

        public string Card_id(string slot_id)
        {
            string card_id = "SELECT TOP 1 card_id FROM ParkingCard WHERE slot_id = '" + slot_id + "'";
            data = new SqlDataAdapter(card_id, Connection.GetSqlConnection());
            tb = new DataTable();
            data.Fill(tb);
            card_id = tb.Rows[0][0].ToString();
            return card_id;
        }

        public string Customer_id(string slot_id)
        {
            string customer_id = "SELECT TOP 1 customer_id FROM ParkingCard WHERE slot_id = '" + slot_id + "'";
            data = new SqlDataAdapter(customer_id, Connection.GetSqlConnection());
            tb = new DataTable();
            data.Fill(tb);
            customer_id = tb.Rows[0][0].ToString();
            return customer_id;
        }

        public string Customer_name(string customer_id)
        {
            string customer_name = "SELECT TOP 1 customer_name FROM Customer WHERE customer_id = '" + customer_id + "'";
            data = new SqlDataAdapter(customer_name, Connection.GetSqlConnection());
            tb = new DataTable();
            data.Fill(tb);
            customer_name = tb.Rows[0][0].ToString();
            return customer_name;
        }

        public string Car_number(string slot_id)
        {
            string car_number = "SELECT TOP 1 car_number FROM ParkingCard WHERE slot_id = '" + slot_id + "'";
            data = new SqlDataAdapter(car_number, Connection.GetSqlConnection());
            tb = new DataTable();
            data.Fill(tb);
            car_number = tb.Rows[0][0].ToString();
            return car_number;
        }

        public string Car_id(string car_number)
        {
            string car_id = "SELECT TOP 1 car_id FROM Car WHERE car_number = '" + car_number + "'";
            data = new SqlDataAdapter(car_id, Connection.GetSqlConnection());
            tb = new DataTable();
            data.Fill(tb);
            car_id = tb.Rows[0][0].ToString();
            return car_id;
        }

        public DateTime Check_in(string slot_id)
        {
            string check_in = "SELECT TOP 1 check_in FROM ParkingCard WHERE slot_id = '" + slot_id + "'";
            data = new SqlDataAdapter(check_in, Connection.GetSqlConnection());
            tb = new DataTable();
            data.Fill(tb);
            check_in = tb.Rows[0][0].ToString();
            DateTime check_in2 = DateTime.Parse(check_in);
            return check_in2;
        }




        private void panel_picA1_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("A01", "", "SL01", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_a2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_picA2_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("A02", "", "SL02", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel_picA3_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("A03", "", "SL03", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picA4_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("A04", "", "SL04", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picA5_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("A05", "", "SL05", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picA6_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("A06", "", "SL06", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picA7_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("A07", "", "SL07", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picA8_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("A08", "", "SL08", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picA9_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("A09", "", "SL09", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picA10_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("A10", "", "SL10", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picA11_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("A11", "", "SL11", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picA12_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("A12", "", "SL12", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picA13_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("A13", "", "SL13", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picA14_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("A14", "", "SL14", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picB5_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("B05", "", "SL19", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picB1_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("B01", "", "SL15", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picB2_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("B02", "", "SL16", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picB3_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("B03", "", "SL17", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picB4_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("B04", "", "SL18", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picB6_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("B06", "", "SL20", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picB7_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("B07", "", "SL21", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picB8_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("B08", "", "SL22", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picB9_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("B09", "", "SL23", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picB10_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("B10", "", "SL24", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picB11_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("B11", "", "SL25", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picB12_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("B12", "", "SL26", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picB13_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("B13", "", "SL27", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picB14_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("B14", "", "SL28", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picC1_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("C01", "", "SL29", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picC2_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("C02", "", "SL30", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picC3_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("C03", "", "SL31", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picC4_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("C04", "", "SL32", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picC5_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("C05", "", "SL33", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picC6_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("C06", "", "SL34", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picC7_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("C07", "", "SL35", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picC8_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("C08", "", "SL36", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picC9_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("C09", "", "SL37", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picC10_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("C10", "", "SL38", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picC11_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("C11", "", "SL39", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picC12_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("C12", "", "SL40", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picC13_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("C13", "", "SL41", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_picC14_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date1 = new DateTime(2003, 05, 30);
            SlotDetailsEmpty slotDetailsEmpty = new SlotDetailsEmpty("C14", "", "SL42", "", "", date1, date1);
            slotDetailsEmpty.ShowDialog();
        }

        private void panel_a1_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL01";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("A01", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_a2_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL02";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("A02", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_a3_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL03";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("A03", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_a4_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL04";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("A04", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_a5_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL05";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("A05", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_a6_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL06";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("A06", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_a7_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL07";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("A07", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_a8_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL08";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("A08", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_a9_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL09";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("A09", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_a10_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL10";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("A10", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_a11_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL11";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("A11", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_a12_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL12";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("A12", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_a13_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL13";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("A13", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_a14_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL14";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("A14", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_b1_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL15";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("B01", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_b2_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL16";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("B02", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_b3_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL17";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("B03", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }



        private void panel_b4_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL18";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("B04", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_b5_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL19";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("B05", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_b6_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL20";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("B06", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_b7_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL21";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("B07", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_b8_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL22";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("B08", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_b9_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL23";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("B09", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_b10_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL24";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("B10", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_b11_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL25";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("B11", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_b12_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL26";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("B12", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_b13_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL27";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("B13", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_b14_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL28";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("B14", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_c1_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL29";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("C01", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_c2_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL30";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("C02", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_c3_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL31";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("C03", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_c4_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL32";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("C04", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_c5_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL33";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("C05", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_c6_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL34";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("C06", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_c7_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL35";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("C07", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_c8_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL36";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("C08", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_c9_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL37";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("C09", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_c10_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL38";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("C10", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_c11_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL39";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("C11", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_c12_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL40";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("C12", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_c13_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL41";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("C13", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }

        private void panel_c14_MouseClick(object sender, MouseEventArgs e)
        {
            string slot_id = "SL42";
            string card_id = Card_id(slot_id);
            string customer_id = Customer_id(slot_id);
            string customer_name = Customer_name(customer_id);
            string car_number = Car_number(slot_id);
            string car_id = Car_id(car_number);
            DateTime check_in = Check_in(slot_id);

            PaymentForm paymentForm = new PaymentForm("C14", AutoCreateBillId(), card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in);
            paymentForm.ShowDialog();
        }
    }
}
