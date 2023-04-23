using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using BUS;
using DAL;
namespace CarParkingManagement.CarManagerChildForm
{
    public partial class CustomersForm : Form
    {
        BUS_Customer customerController = new BUS_Customer();
        DataTable dt;

        string customer_id = "";
        string customer_name = "";
        string email = "";
        string phone = "";
        string identification = "";
        public CustomersForm()
        {
            InitializeComponent();
        }


        private void CustomersForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = Connection.GetSqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customer", connection);
            dt = new DataTable();
            connection.Open();
            adapter.Fill(dt);
            dataGridView_info.DataSource = dt;
            connection.Close();

            rjButton_save.Enabled = false;
            rjButton_edit.Enabled = false;

            AdjustStudentGridView();
            dataGridView_info.Columns[0].HeaderCell.Value = "ID";
            dataGridView_info.Columns[1].HeaderCell.Value = "Full Name";
            dataGridView_info.Columns[2].HeaderCell.Value = "Email";
            dataGridView_info.Columns[3].HeaderCell.Value = "Phone Number";
            dataGridView_info.Columns[4].HeaderCell.Value = "Identification";


            dataGridView_info.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(157, 164, 171);
            dataGridView_info.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView_info.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 58, 64);
            dataGridView_info.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_info.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 58, 64);
            dataGridView_info.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView_info.EnableHeadersVisualStyles = false;

            dataGridView_info.CurrentCell = null;


            // diabled information form
            textBox_customerId.Enabled = false;
            textBox_customerName.Enabled = false;
            textBox_email.Enabled = false;
            textBox_phone.Enabled = false;
            textBox_Identification.Enabled = false;
        }

        private void AdjustStudentGridView()
        {
            dataGridView_info.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        SqlDataAdapter data;
        DataTable tb;
        public string AutoCreateCustomerId()
        {
            string s = "SELECT TOP 1 customer_id FROM Customer ORDER BY customer_id DESC";
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
                    s = "CUS" + "00" + stt.ToString();
                }
                else if (stt < 100)
                {
                    s = "CUS" + "0" + stt.ToString();
                }
                else
                {
                    s = "CUS" + stt.ToString();
                }
            }
            else
            {
                s = "CUS" + "001";
            }


            return s;

        }

        private string getSelectedIdCustomer()
        {
            if (dataGridView_info.SelectedRows.Count > 0)
            {
                string id = dataGridView_info.SelectedRows[0].Cells[0].Value.ToString();
                return id;
            }
            else
            {
                return "-1";
            }
        }


        private void rjButton3_Click_1(object sender, EventArgs e)
        {
            string id = getSelectedIdCustomer();
            DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (id != "-1")
                {
                    customerController.DeleteCustomer(id);
                    dataGridView_info.DataSource = customerController.GetCustomers("SELECT * FROM Customer");
                }
                else
                {
                    MessageBox.Show("Please select an customer to delete.");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_info_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView_info.EnableHeadersVisualStyles = false;

            foreach (DataGridViewRow r in dataGridView_info.Rows)
            {
                r.DefaultCellStyle.BackColor = Color.FromArgb(52, 58, 64);
                r.DefaultCellStyle.ForeColor = Color.White;
            }

        }

        private void rjButton_create_Click(object sender, EventArgs e)
        {
            string customer_id = textBox_customerId.Text;
            string customer_name = textBox_customerName.Text;
            string email = textBox_email.Text;
            string phone = textBox_phone.Text;
            string identification = textBox_Identification.Text;

            if (textBox_customerId.Enabled == false)
            {
                customerController.UpdateCustomer(customer_id, customer_name, email, phone, identification);
                dataGridView_info.DataSource = customerController.GetCustomers("SELECT * FROM Customer");

            }
            else
            {
                customerController.AddCustomer(customer_id, customer_name, email, phone, identification);
                dataGridView_info.DataSource = customerController.GetCustomers("SELECT * FROM Customer");
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rjButton_edit.Enabled = true;

            customer_id = dataGridView_info.Rows[e.RowIndex].Cells["customer_id"].FormattedValue.ToString();
            customer_name = dataGridView_info.Rows[e.RowIndex].Cells["customer_name"].FormattedValue.ToString();
            email = dataGridView_info.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
            phone = dataGridView_info.Rows[e.RowIndex].Cells["Phone"].FormattedValue.ToString();
            identification = dataGridView_info.Rows[e.RowIndex].Cells["Identification"].FormattedValue.ToString();


        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            textBox_customerId.Text = customer_id;
            textBox_customerName.Text = customer_name;
            textBox_email.Text = email;
            textBox_phone.Text = phone;
            textBox_Identification.Text = identification;

            label_customerId.Enabled = false;
            textBox_customerId.Enabled = false;
            rjButton_save.Enabled = true;

            textBox_customerName.Enabled = true;
            textBox_email.Enabled = true;
            textBox_phone.Enabled = true;
            textBox_Identification.Enabled = true;
        }

        private void rjButton_create_Click_1(object sender, EventArgs e)
        {
            textBox_customerId.Text = AutoCreateCustomerId();

            textBox_customerName.Text = "";
            textBox_email.Text = "";
            textBox_phone.Text = "";
            textBox_Identification.Text = "";

            textBox_customerId.ReadOnly = true;
            textBox_customerId.Enabled = true;
            label_customerId.Enabled = true;
            rjButton_save.Enabled = true;

            textBox_customerId.Enabled = true;
            textBox_customerName.Enabled = true;
            textBox_email.Enabled = true;
            textBox_phone.Enabled = true;
            textBox_Identification.Enabled = true;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("customer_name like '%{0}%'", textBox_search.Text);
            dataGridView_info.DataSource = dv.ToTable();
        }
    }
}
