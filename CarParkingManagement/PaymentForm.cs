using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using BUS;
using DAL;

namespace CarParkingManagement
{
    public partial class PaymentForm : Form
    {
        BUS_Bill billController = new BUS_Bill();
        BUS_ParkingCard parkingCardController = new BUS_ParkingCard();

        SqlDataAdapter data;
        DataTable tb;
        public PaymentForm(string slot_name, string bill_id, string card_id, string slot_id, string customer_id, string customer_name, string car_id, string car_number, DateTime check_in)
        {
            InitializeComponent();
            this.Slot_name = slot_name;
            this.Bill_id = bill_id;
            this.Card_id = card_id;
            this.Slot_id = slot_id;
            this.Customer_id = customer_id;
            this.Customer_name = customer_name;
            this.Car_id = car_id;
            this.Car_number = car_number;
            this.Check_in = check_in;

        }

        //        - Mua thẻ giờ(tạo card mã dạng hxxxx với x là số, h viết tắt hour) :
        //+) Lấy xe trước 22:00 40k/ 1 lượt
        //+) Sau 22:00 60K/ 1 lượt
        //+) Nếu lấy từ 6:00 sáng hôm sau sẽ là 60 + 40 = 100
        //+) Tương tự sau 22:00 ngày hôm sau 60 + 60 = 120
        //- Mua thẻ tháng(mxxxx) : 1tr400, ra vào tùy ý số lần
        public string Slot_name { get; set; }
        public string Bill_id { get; set; }
        public string Card_id { get; set; }
        public string Slot_id { get; set; }
        public string Customer_id { get; set; }
        public string Customer_name { get; set; }
        public string Car_id { get; set; }
        public string Car_number { get; set; }
        public DateTime Check_in { get; set; }


        public DateTime Check_out(string slot_id)
        {
            string check_out = "SELECT TOP 1 check_out FROM ParkingCard WHERE slot_id = '" + slot_id + "'";
            data = new SqlDataAdapter(check_out, Connection.GetSqlConnection());
            tb = new DataTable();
            data.Fill(tb);
            check_out = tb.Rows[0][0].ToString();
            DateTime check_out2 = DateTime.Parse(check_out);
            return check_out2;
        }
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            label_slotName.Text = Slot_name;
            textBox_cardId.Text = Card_id;
            textBox_billId.Text = Bill_id;
            textBox_slotId.Text = Slot_id;
            textBox_customerID.Text = Customer_id;
            textBox_customerName.Text = Customer_name;
            textBox_carId.Text = Car_id;
            textBox_carNumber.Text = Car_number;
            dateTimePicker_checkIn.Value = Check_in;



            if (Card_id.Substring(0, 1) == "H")
            {
                dateTimePicker_checkOut.Value = DateTime.Now;
                dateTimePicker_checkOut.Enabled = true;
            }
            else
            {
                dateTimePicker_checkOut.Value = Check_out(Slot_id);
                dateTimePicker_checkOut.Enabled = true;

            }
        }

        private void iconPictureBox_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBox_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void iconButton_booking_Click(object sender, EventArgs e)
        {
            string bill_id = textBox_billId.Text;
            string card_id = textBox_cardId.Text;
            string slot_id = textBox_slotId.Text;
            string customer_id = textBox_customerID.Text;
            string customer_name = textBox_customerName.Text;
            string car_id = textBox_carId.Text;
            string car_number = textBox_carNumber.Text;

            DateTime check_in = dateTimePicker_checkIn.Value;
            DateTime check_out = dateTimePicker_checkOut.Value;


            DateTime? check_in1 = null;

            DateTime? check_out1 = null;


            int total = int.Parse(textBox_total.Text);
            string pay_method = comboBox_payMethod.Text;
            billController.AddBill(bill_id, card_id, slot_id, customer_id, customer_name, car_id, car_number, check_in, check_out, total, pay_method);
            parkingCardController.UpdateNullToParkingSlot(slot_id, null, check_in1, check_out1);
            parkingCardController.UpdateNotAvailabilityToParkingSlot("1");
   
            DialogResult result = MessageBox.Show("Do you want to print bill?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Lệnh in
                printBillButton_Click(sender, e);
            }

            this.Hide();

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
           


        }


        // Lệnh in
        private void printBillButton_Click(object sender, EventArgs e)
        {
            // Create a new PrintDocument object
            PrintDocument pd = new PrintDocument();

            // Set the printer name (optional)
            pd.PrinterSettings.PrinterName = "Brother DCP-B7535DW series Printer";

            // Set the document name (optional)
            pd.DocumentName = "Bill";

            // Add an event handler for the PrintPage event
            pd.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            // Print the document
            pd.Print();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Set the font and color for the text
            Font font = new Font("Arial", 12, FontStyle.Regular);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Set the x and y positions for the text
            float x = 10;
            float y = 10;


            string bill_id = textBox_billId.Text;
            string card_id = textBox_cardId.Text;
            string slot_id = textBox_slotId.Text;
            string customer_id = textBox_customerID.Text;
            string customer_name = textBox_customerName.Text;
            string car_id = textBox_carId.Text;
            string car_number = textBox_carNumber.Text;
            DateTime check_in = dateTimePicker_checkIn.Value;
            DateTime check_out = dateTimePicker_checkOut.Value;
            string pay_method = comboBox_payMethod.Text;
            int total = int.Parse(textBox_total.Text);
            int cash = int.Parse(textBox_cash.Text);
            int change = cash - total;

            string billHeader = $"Bill ID:\t\t\t" + bill_id + "\n" +

                    $"Card ID:\t\t\t" + card_id + "\n" +

                    $"Slot ID:\t\t\t" + slot_id + "\n" +

                    $"Customer ID:\t\t" + customer_id + "\n" +

                    $"Customer Name:\t\t" + customer_name + "\n" +

                    $"Car ID:\t\t\t" + car_id + "\n" +

                    $"Car Number:\t\t" + car_number + "\n" +

                    $"Check-In: \t\t" + check_in + "\n" +

                    $"Check-Out:\t\t" + check_out + "\n" +

                    $"Payment Method:\t" + pay_method + "\n\n" +

                    "-------------------------------------------------------------------\n\n" +
                    $"Parking Fee:\t\t" + total.ToString() + " VND\n" +
                    $"Cash:\t\t\t" + cash.ToString() + " VND\n" +
                    $"Change:\t\t\t" + change.ToString() + " VND\n";




            // Set the text to be printed
            string text = "\t\tBill Details\n\n" + "-------------------------------------------------------------------\n\n" + billHeader;


            // Draw the text on the page
            e.Graphics.DrawString(text, font, brush, x, y);
        }


        private void textBox_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_checkOut_ValueChanged(object sender, EventArgs e)
        {

        }

        public int total(DateTime check_in, DateTime check_out)
        {
            TimeSpan timeSpan = check_out - check_in;
            double hours = timeSpan.TotalHours;
            int hour = (int)hours;
            int total = (hour / 4 + 1) * 35000;
            return total;
        }

        private void iconButton_charge_Click(object sender, EventArgs e)
        {
            string slot_id = textBox_slotId.Text;
            DateTime check_in = dateTimePicker_checkIn.Value;

            int months = 0;
            int totalMonth = 0;




            if (Card_id.Substring(0, 1) == "H")
            {
                DateTime check_out = dateTimePicker_checkOut.Value;

                int totals = total(check_in, check_out);

                textBox_total.Text = totals.ToString();
            }
            else
            {
                DateTime check_out = Check_out(slot_id);
                DateTime check_outReal = dateTimePicker_checkOut.Value;
                TimeSpan timeSpan = check_out - check_in;

                if (check_outReal == check_out)
                {
                    months = ((check_out.Year - check_in.Year) * 12) + check_out.Month - check_in.Month;
                    totalMonth = months * 2000000;
                    textBox_total.Text = totalMonth.ToString();

                }
                else
                {
                    TimeSpan timeSpan1 = check_outReal - check_out;
                    double hours = timeSpan1.TotalHours;
                    int hour = (int)hours;
                    int totalHour = (hour / 4 + 1) * 35000;
                    months = ((check_out.Year - check_in.Year) * 12) + check_out.Month - check_in.Month;
                    totalMonth = months * 2000000;
                    int total = totalHour + totalMonth;
                    textBox_total.Text = total.ToString();
                }


                //int months = ((check_out.Year - check_in.Year) * 12) + check_out.Month - check_in.Month;
                //int totalMonth = months * 2000000;



            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string slot_id = textBox_slotId.Text;
            DateTime check_in = dateTimePicker_checkIn.Value;

            int months = 0;
            int totalMonth = 0;




            if (Card_id.Substring(0, 1) == "H")
            {
                DateTime check_out = dateTimePicker_checkOut.Value;

                int totals = total(check_in, check_out);

                textBox_total.Text = totals.ToString();
            }
            else
            {
                DateTime check_out = Check_out(slot_id);
                DateTime check_outReal = dateTimePicker_checkOut.Value;
                TimeSpan timeSpan = check_out - check_in;

                if (check_outReal == check_out)
                {
                    months = ((check_out.Year - check_in.Year) * 12) + check_out.Month - check_in.Month;
                    totalMonth = months * 2000000;
                    textBox_total.Text = totalMonth.ToString();

                }
                else
                {
                    TimeSpan timeSpan1 = check_outReal - check_out;
                    double hours = timeSpan1.TotalHours;
                    int hour = (int)hours;
                    int totalHour = (hour / 4 + 1) * 35000;
                    months = ((check_out.Year - check_in.Year) * 12) + check_out.Month - check_in.Month;
                    totalMonth = months * 2000000;
                    int total = totalHour + totalMonth;
                    textBox_total.Text = total.ToString();
                }


                //int months = ((check_out.Year - check_in.Year) * 12) + check_out.Month - check_in.Month;
                //int totalMonth = months * 2000000;


            }
        }
    }
}