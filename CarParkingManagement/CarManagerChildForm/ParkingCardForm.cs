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
    public partial class ParkingCardForm : Form
    {
        DataTable dt;
        public ParkingCardForm()
        {
            InitializeComponent();
        }

        private void ParkingCardForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = Connection.GetSqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ParkingCard", connection);
            dt = new DataTable();
            connection.Open();
            adapter.Fill(dt);
            dataGridView_info.DataSource = dt;
            connection.Close();

            AdjustStudentGridView();

            dataGridView_info.Columns[0].HeaderCell.Value = "Card ID";
            dataGridView_info.Columns[1].HeaderCell.Value = "Slot ID";
            dataGridView_info.Columns[2].HeaderCell.Value = "Car Number";
            dataGridView_info.Columns[3].HeaderCell.Value = "Customer ID";
            dataGridView_info.Columns[4].HeaderCell.Value = "Check In";
            dataGridView_info.Columns[5].HeaderCell.Value = "Check Out";


            dataGridView_info.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(157, 164, 171);
            dataGridView_info.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView_info.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 58, 64);
            dataGridView_info.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_info.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 58, 64);
            dataGridView_info.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView_info.EnableHeadersVisualStyles = false;

            dataGridView_info.CurrentCell = null;
        }

        private void AdjustStudentGridView()
        {
            dataGridView_info.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
    }
}
