using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;

namespace CarParkingManagement
{
    public partial class SlotDetailsEmpty : Form
    {
        BUS_ParkingCard parkingCardController = new BUS_ParkingCard();
        CarManagerForm carManagerForm = new CarManagerForm("12345678");
        BUS_Car carController = new BUS_Car();
        bool visible = false;
        SqlDataAdapter data;
        DataTable tb;
        public SlotDetailsEmpty(string slot_name, string card_id, string slot_id, string car_number, string customer_id, DateTime check_in, DateTime check_out)
        {
            InitializeComponent();
            this.Slot_name = slot_name;
            this.Card_id = card_id;
            this.Slot_id = slot_id;
            this.Car_number = car_number;
            this.Customer_id = customer_id;
            this.Check_in = check_in;
            this.Check_out = check_out;

        }

        public string Slot_name { get; set; }
        public string Card_id { get; set; }
        public string Slot_id { get; set; }
        public string Car_number { get; set; }
        public string Customer_id { get; set; }
        public DateTime Check_in { get; set; }
        public DateTime Check_out { get; set; }


        private void SlotDetailsEmpty_Load(object sender, EventArgs e)
        {
            label_slotName.Text = Slot_name;
            textBox_cardId.Text = Card_id;
            textBox_slotId.Text = Slot_id;
            dateTimePicker_checkIn.Value = DateTime.Now;
            dateTimePicker_checkOut.Value = DateTime.Now;

            SqlConnection connection = Connection.GetSqlConnection();
            //string query = "SELECT car_number FROM Car";
            string query = "SELECT car_number " +
                            "FROM Car " +
                            "LEFT JOIN ParkingSlot ON Car.car_id = ParkingSlot.car_id " +
                            "WHERE ParkingSlot.car_id IS NULL";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            var data = new List<string>();
            while (reader.Read())
            {
                string car_number = reader.GetString(0);
                data.Add(car_number);
            }
            connection.Close();

            // Add data vao comboBox Car Number
            comboBox_carNumber.Items.Clear();
            comboBox_carNumber.DataSource = data;
            comboBox_carNumber.Text = "";


            query = "SELECT customer_id FROM Customer";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();

            data = new List<string>();
            while (reader.Read())
            {
                string customer_id = reader.GetString(0);
                data.Add(customer_id);
            }
            connection.Close();

            // Add data vao comboBox Customer ID
            comboBox_customerId.Items.Clear();
            comboBox_customerId.DataSource = data;
            comboBox_customerId.Text = "";

            // Hide checkin checkout
            label_checkIn.Hide();
            dateTimePicker_checkIn.Hide();
            label_checkOut.Hide();
            dateTimePicker_checkOut.Hide();
        }


        private void rjButton1_Click(object sender, EventArgs e)
        {
            //string card_id = textBox_cardId.Text;
            //string slot_id = textBox_slotId.Text;
            //string car_number = comboBox_carNumber.Text;
            //string customer_id = comboBox_customerId.Text;
            //DateTime check_in = dateTimePicker_checkIn.Value;
            //DateTime check_out = dateTimePicker_checkOut.Value;
            ////parkingCardController.UpdateToParkingSlot(check_in, check_out);
            //parkingCardController.AddParkingCard(card_id, slot_id, car_number, customer_id, check_in, check_out);
            //parkingCardController.UpdateToParkingSlot(slot_id, check_in, check_out);
            //parkingCardController.UpdateAvailabilityToParkingSlot("0");

            //this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void OpenChildForm(Form childForm)
        {
            CarManagerForm carManagerForm = new CarManagerForm("12345678");

            //open only form
            if (carManagerForm.currentChildForm != null)
            {
                carManagerForm.currentChildForm.Close();
            }
            carManagerForm.currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            carManagerForm.panel_desktop.Controls.Add(childForm);
            carManagerForm.panel_desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            carManagerForm.label_titleChildForm.Text = childForm.Text;
        }

        private void iconButton_booking_Click(object sender, EventArgs e)
        {
            string card_id = textBox_cardId.Text;
            string slot_id = textBox_slotId.Text;
            string car_number = comboBox_carNumber.Text;
            string customer_id = comboBox_customerId.Text;
            DateTime check_in = dateTimePicker_checkIn.Value;
            DateTime check_out = dateTimePicker_checkOut.Value;
            //parkingCardController.UpdateToParkingSlot(check_in, check_out);

            string car_id = "SELECT car_id FROM Car WHERE car_number = '" + car_number + "'";
            data = new SqlDataAdapter(car_id, Connection.GetSqlConnection());
            tb = new DataTable();
            data.Fill(tb);
            car_id = tb.Rows[0][0].ToString();

            if (dateTimePicker_checkOut.Visible == false)
            {
                DateTime? check_out1 = null;
                parkingCardController.AddParkingCardHour(card_id, slot_id, car_number, customer_id, check_in, check_out1);
                parkingCardController.UpdateToParkingSlotHour(slot_id, car_id, check_in, check_out1);
                parkingCardController.UpdateAvailabilityToParkingSlot("0");
            }
            else
            {
                parkingCardController.AddParkingCard(card_id, slot_id, car_number, customer_id, check_in, check_out);
                parkingCardController.UpdateToParkingSlot(slot_id, car_id, check_in, check_out);
                parkingCardController.UpdateAvailabilityToParkingSlot("0");
            }



            List<Form> form = Application.OpenForms.Cast<Form>().ToList();
            CarManagerForm forms;

            foreach (Form formItem in form)
            {
                if (formItem.Name == "CarManagerForm")
                {
                    forms = (CarManagerForm)formItem;
                    forms.iconButton_parkingSlot_Click(sender, e);
                    break;
                }
            }
            this.Hide();
        }

        private void iconButton_booking_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label_slotName_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox_exit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void iconPictureBox_exit_MouseEnter(object sender, EventArgs e)
        {
            iconPictureBox_exit.BackColor = Color.Red;
        }

        private void iconPictureBox_exit_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox_exit.BackColor = Color.Transparent;
        }

        private void iconPictureBox_minimize_MouseEnter(object sender, EventArgs e)
        {
            iconPictureBox_minimize.BackColor = Color.FromArgb(55, 59, 63);

        }

        private void iconPictureBox_minimize_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox_minimize.BackColor = Color.Transparent;

        }

        private void iconPictureBox_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void rjTextBox1_Load(object sender, EventArgs e)
        {

        }


        private string AutoCreateCardIdHour()
        {
            string s = "SELECT TOP 1 card_id FROM ParkingCard ORDER BY card_id DESC";
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
                    s = "H" + "000" + stt.ToString();
                }
                else if (stt < 100)
                {
                    s = "H" + "00" + stt.ToString();
                }
                else if (stt < 1000)
                {
                    s = "H" + "0" + stt.ToString();
                }
                else
                {
                    s = "H" + stt.ToString();
                }
            }
            else
            {
                s = "H" + "0001";
            }


            return s;
        }

        private string AutoCreateCardIdMonth()
        {
            string s = "SELECT TOP 1 card_id FROM ParkingCard ORDER BY card_id DESC";
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
                    s = "M" + "000" + stt.ToString();
                }
                else if (stt < 100)
                {
                    s = "M" + "00" + stt.ToString();
                }
                else if (stt < 1000)
                {
                    s = "M" + "0" + stt.ToString();
                }
                else
                {
                    s = "M" + stt.ToString();
                }
            }
            else
            {
                s = "M" + "0001";
            }


            return s;
        }

        private void iconButton_hour_Click(object sender, EventArgs e)
        {
            textBox_cardId.Text = AutoCreateCardIdHour();
            if (!visible)
            {

                label_checkIn.Visible = true;
                dateTimePicker_checkIn.Visible = true;
                visible = true;
            }
            else if (label_checkIn.Visible == true && dateTimePicker_checkIn.Visible == true && label_checkOut.Visible == true && dateTimePicker_checkOut.Visible)
            {
                label_checkOut.Visible = false;
                dateTimePicker_checkOut.Visible = false;
            }
            else
            {
                label_checkIn.Visible = false;
                dateTimePicker_checkIn.Visible = false;
                visible = false;
            }

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            textBox_cardId.Text = AutoCreateCardIdMonth();

            if (!visible)
            {
                label_checkIn.Visible = true;
                dateTimePicker_checkIn.Visible = true;
                label_checkOut.Visible = true;
                dateTimePicker_checkOut.Visible = true;
                visible = true;
            }
            else if (label_checkIn.Visible == true && dateTimePicker_checkIn.Visible == true && label_checkOut.Visible == false && dateTimePicker_checkOut.Visible == false)
            {
                label_checkOut.Visible = true;
                dateTimePicker_checkOut.Visible = true;
            }
            else
            {
                label_checkIn.Visible = false;
                dateTimePicker_checkIn.Visible = false;
                label_checkOut.Visible = false;
                dateTimePicker_checkOut.Visible = false;
                visible = false;
            }
        }

        private void dateTimePicker_checkOut_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
