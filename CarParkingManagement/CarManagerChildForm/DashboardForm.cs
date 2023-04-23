using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManagement.CarManagerChildForm
{
    public partial class DashboardForm : Form
    {
        BUS_Bill billController = new BUS_Bill();
        DataTable dt;
        public DashboardForm()
        {
            InitializeComponent();
        }



        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            iconPictureBox_parkingSlot.Size = new Size(120, 120);
        }

        private void panel_parkingSlot_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox_parkingSlot.Size = new Size(92, 93);
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            /*   label2.Enabled = false;*//*
               label2.ForeColor = Color.White;*/
            SqlConnection connection = Connection.GetSqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Bill", connection);
            dt = new DataTable();
            connection.Open();
            adapter.Fill(dt);
            dataGridView_info.DataSource = dt;
            connection.Close();

            AdjustStudentGridView();

            dataGridView_info.Columns[0].HeaderCell.Value = "Bill ID";
            dataGridView_info.Columns[1].HeaderCell.Value = "Card ID";
            dataGridView_info.Columns[2].HeaderCell.Value = "Slot ID";
            dataGridView_info.Columns[3].HeaderCell.Value = "Customer ID";
            dataGridView_info.Columns[4].HeaderCell.Value = "Customer Name";
            dataGridView_info.Columns[5].HeaderCell.Value = "Car ID";
            dataGridView_info.Columns[6].HeaderCell.Value = "Car Number";
            dataGridView_info.Columns[7].HeaderCell.Value = "Check In";
            dataGridView_info.Columns[8].HeaderCell.Value = "Check Out";
            dataGridView_info.Columns[9].HeaderCell.Value = "Revenue";
            dataGridView_info.Columns[10].HeaderCell.Value = "Pay Method";


            dataGridView_info.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(157, 164, 171);
            dataGridView_info.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView_info.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 58, 64);
            dataGridView_info.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_info.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 58, 64);
            dataGridView_info.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView_info.EnableHeadersVisualStyles = false;

            dataGridView_info.CurrentCell = null;


            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                // Create the SqlCommand object with the SQL query and conn
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM ParkingSlot WHERE availability = '0'", conn);

                // Open the conn
                conn.Open();

                // Execute the query and retrieve the count
                int count = (int)command.ExecuteScalar();

                // Close the conn
                conn.Close();

                // Display the count
                label_slot.Text = count.ToString() + "/42";

            }

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

                // Display the count
                label_customer.Text = count.ToString();

            }

            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                // Create the SqlCommand object with the SQL query and conn
                SqlCommand command = new SqlCommand("SELECT SUM(total) FROM Bill", conn);

                // Open the conn
                conn.Open();

                // Execute the query and retrieve the count
                int count = (int)command.ExecuteScalar();

                // Close the conn
                conn.Close();

                // Display the count
                label_revenue.Text = count.ToString();

            }
        }

        private void AdjustStudentGridView()
        {
            dataGridView_info.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void panel_parkingSlot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox_parkingSlot_MouseEnter(object sender, EventArgs e)
        {
            /*            iconPictureBox_parkingSlot.BackColor = 
            */
        }

        private void iconPictureBox_parkingSlot_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox_parkingSlot.Size = new Size(92, 93);
            iconPictureBox_parkingSlot.Location = new Point(257, 23);
        }

        private void label5_Click(object sender, EventArgs e)
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

        private string getSelectedIdBill()
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

        private void rjButton_delete_Click(object sender, EventArgs e)
        {
            string id = getSelectedIdBill();
            DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (id != "-1")
                {
                    billController.DeleteBill(id);
                    dataGridView_info.DataSource = billController.GetBills("SELECT * FROM Bill");
                    using (SqlConnection conn = Connection.GetSqlConnection())
                    {
                        // Create the SqlCommand object with the SQL query and conn
                        SqlCommand command = new SqlCommand("SELECT SUM(total) FROM Bill", conn);

                        // Open the conn
                        conn.Open();

                        // Execute the query and retrieve the count
                        int count = (int)command.ExecuteScalar();

                        // Close the conn
                        conn.Close();

                        // Display the count
                        label_revenue.Text = count.ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Please select a bill to delete.");
                }
            }
        }
    }
}
