using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BUS;
using DAL;
using System.Data.SqlClient;
using System.Windows.Markup;

namespace CarParkingManagement.CarManagerChildForm
{
    public partial class CarsForm : Form
    {
        BUS_Car carController = new BUS_Car();
        DataTable dt;
        string car_id = "";
        string car_name = "";
        string car_number = "";
        string car_color = "";

        public CarsForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void CarsForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = Connection.GetSqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Car", connection);
            dt = new DataTable();
            connection.Open();
            adapter.Fill(dt);
            dataGridView_info.DataSource = dt;
            connection.Close();

            rjButton_save.Enabled = false;
            rjButton_edit.Enabled = false;

            AdjustStudentGridView();
            dataGridView_info.Columns[0].HeaderCell.Value = "ID";
            dataGridView_info.Columns[1].HeaderCell.Value = "Car Name";
            dataGridView_info.Columns[2].HeaderCell.Value = "Car Number";
            dataGridView_info.Columns[3].HeaderCell.Value = "Car Color";


            dataGridView_info.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(157, 164, 171);
            dataGridView_info.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView_info.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 58, 64);
            dataGridView_info.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_info.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 58, 64);
            dataGridView_info.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView_info.EnableHeadersVisualStyles = false;

            textBox_carId.Enabled = false;
            textBox_carName.Enabled = false;
            textBox_carNumber.Enabled = false;
            textBox_carColor.Enabled = false;
        }
        SqlDataAdapter data;
        DataTable tb;
        public string AutoCreateCarId()
        {
            string s = "SELECT TOP 1 car_id FROM Car ORDER BY car_id DESC";
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
                    s = "CAR" + "00" + stt.ToString();
                }
                else if (stt < 100)
                {
                    s = "CAR" + "0" + stt.ToString();
                }
                else
                {
                    s = "CAR" + stt.ToString();
                }
            }
            else
            {
                s = "CAR" + "001";
            }


            return s;

        }

        private void AdjustStudentGridView()
        {
            dataGridView_info.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton_save_Click(object sender, EventArgs e)
        {
            string car_id = textBox_carId.Text;
            string car_name = textBox_carName.Text;
            string car_number = textBox_carNumber.Text;
            string car_color = textBox_carColor.Text;

            if (textBox_carId.Enabled == false)
            {
                carController.UpdateCar(car_id, car_name, car_number, car_color);
                dataGridView_info.DataSource = carController.GetCars("SELECT * FROM Car");
            }
            else
            {
                carController.AddCar(car_id, car_name, car_number, car_color);
                dataGridView_info.DataSource = carController.GetCars("SELECT * FROM Car");
            }

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

        private void dataGridView_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rjButton_edit.Enabled = true;
            car_id = dataGridView_info.Rows[e.RowIndex].Cells["car_id"].FormattedValue.ToString();
            car_name = dataGridView_info.Rows[e.RowIndex].Cells["car_name"].FormattedValue.ToString();
            car_number = dataGridView_info.Rows[e.RowIndex].Cells["car_number"].FormattedValue.ToString();
            car_color = dataGridView_info.Rows[e.RowIndex].Cells["car_color"].FormattedValue.ToString();
        }

        private void rjButton_create_Click(object sender, EventArgs e)
        {
            textBox_carId.Text = AutoCreateCarId();
            textBox_carName.Text = "";
            textBox_carNumber.Text = "";
            textBox_carColor.Text = "";

            textBox_carId.ReadOnly = true;
            label_carId.Enabled = true;
            textBox_carId.Enabled = true;
            rjButton_save.Enabled = true;

            textBox_carName.Enabled = true;
            textBox_carNumber.Enabled = true;
            textBox_carColor.Enabled = true;
        }

        private void rjButton_edit_Click(object sender, EventArgs e)
        {
            textBox_carId.Text = car_id;
            textBox_carName.Text = car_name;
            textBox_carNumber.Text = car_number;
            textBox_carColor.Text = car_color;

            label_carId.Enabled = false;
            textBox_carId.Enabled = false;
            rjButton_save.Enabled = true;


            textBox_carName.Enabled = true;
            textBox_carNumber.Enabled = true;
            textBox_carColor.Enabled = true;

        }

        private string getSelectedIdCar()
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
            string id = getSelectedIdCar();
            DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (id != "-1")
                {
                    carController.DeleteCar(id);
                    dataGridView_info.DataSource = carController.GetCars("SELECT * FROM Car");
                }
                else
                {
                    MessageBox.Show("Please select an car to delete.");
                }
            }
        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("car_number like '%{0}%'", textBox_search.Text);
            dataGridView_info.DataSource = dv.ToTable();
        }
    }
}

