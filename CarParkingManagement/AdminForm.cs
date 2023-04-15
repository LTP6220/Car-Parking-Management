using BUS;
using DAL;
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

namespace CarParkingManagement
{
    public partial class AdminForm : Form
    {
        BUS_Account accountController = new BUS_Account();
        DataTable dt;
        string updateId;
        string updateEmail;
        string updateFullname;
        string updatePosition;
        string updateUsername;
        string updatePassword;
        public AdminForm()
        {
            InitializeComponent();
            //Form

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            rjButton_update.Enabled = false;
            /*     dataGridView_info.DataSource = accountController.GetAccounts("select * from Account");*/


            SqlConnection connection = Connection.GetSqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Account", connection);
            dt = new DataTable();
            connection.Open();
            adapter.Fill(dt);
            dataGridView_info.DataSource = dt;
            connection.Close();


            AdjustStudentGridView();
            dataGridView_info.Columns[0].HeaderCell.Value = "ID";
            dataGridView_info.Columns[1].HeaderCell.Value = "Full Name";
            dataGridView_info.Columns[2].HeaderCell.Value = "Username";
            dataGridView_info.Columns[3].HeaderCell.Value = "Password";
            dataGridView_info.Columns[4].HeaderCell.Value = "Email";
            dataGridView_info.Columns[5].HeaderCell.Value = "Position";
            /*
                        dataGridView_info.RowHeadersVisible = false;*/
            /*            dataGridView_info.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            */
            /*   dataGridView_info.RowHeadersDefaultCellStyle = ;*/
            /*   dataGridView_info.ColumnHeadersDefaultCellStyle.SelectionForeColor = dataGridView_info.BackColor;*/
            /*            dataGridView_info.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView_info.ColumnHeadersDefaultCellStyle.BackColor;
            */


            dataGridView_info.RowsDefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView_info.RowsDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_info.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 39);
            dataGridView_info.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_info.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 39, 39);
            dataGridView_info.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView_info.EnableHeadersVisualStyles = false;

            dataGridView_info.AllowUserToResizeRows = false;

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void AdjustStudentGridView()
        {
            dataGridView_info.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void iconButton_createAccount_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            dataGridView_info.DataSource = accountController.GetAccounts("SELECT * FROM Account");
        }

        private void panel_title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void rjButton_createAccount_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void rjButton_delete_Click(object sender, EventArgs e)
        {
            string id = getSelectedIdAccount();
            DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (id != "-1")
                {
                    accountController.DeleteAccount(id);
                    dataGridView_info.DataSource = accountController.GetAccounts("SELECT * FROM Account");
                }
                else
                {
                    MessageBox.Show("Please select an account to delete.");
                }
            }


        }

        private string getSelectedIdAccount()
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

        private void dataGridView_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rjButton_update.Enabled = true;
            TextBox textBox_id = new TextBox();
            string id = "";
            string email = "";
            string fullname = "";
            string position = "";
            string username = "";
            string password = "";

            /*  dataGridView_info.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.Red;
              if (e.RowIndex == -1) // Check if the clicked cell is a header cell
              {
                  dataGridView_info.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.Red;
              }*/
            id = dataGridView_info.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
            email = dataGridView_info.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
            fullname = dataGridView_info.Rows[e.RowIndex].Cells["Fullname"].FormattedValue.ToString();
            position = dataGridView_info.Rows[e.RowIndex].Cells["Position"].FormattedValue.ToString();
            username = dataGridView_info.Rows[e.RowIndex].Cells["Username"].FormattedValue.ToString();
            password = dataGridView_info.Rows[e.RowIndex].Cells["Password"].FormattedValue.ToString();

            updateId = id;
            updateEmail = email;
            updateFullname = fullname;
            updatePosition = position;
            updateUsername = username;
            updatePassword = password;



            /*    UpdateForm updateForm = new UpdateForm(id);
                updateForm.ShowDialog();*/


        }

        private void rjButton_update_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm(updateId, updateFullname, updateUsername, updatePassword, updateEmail, updatePosition, this);
            updateForm.ShowDialog();
        }

        private void dataGridView_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_info_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*dataGridView_info.Rows[0].DefaultCellStyle.BackColor = Color.Red;*/
            dataGridView_info.EnableHeadersVisualStyles = false;

            foreach (DataGridViewRow r in dataGridView_info.Rows)
            {
                r.DefaultCellStyle.BackColor = Color.FromArgb(41, 39, 39);
                r.DefaultCellStyle.ForeColor = Color.White;
            }

            // Header color Datagridview


        }

        /*  private void iconPictureBox2_MouseHover(object sender, EventArgs e)
          {
              iconPictureBox_exit.BackColor = Color.Red;
          }*/

        private void iconPictureBox2_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox_exit.BackColor = Color.Transparent;
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjButton_createAccount_MouseEnter(object sender, EventArgs e)
        {
            rjButton_createAccount.BackColor = Color.FromArgb(15, 14, 14);
        }

        private void rjButton_createAccount_MouseLeave(object sender, EventArgs e)
        {
            rjButton_createAccount.BackColor = Color.Transparent;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox_exit_MouseEnter(object sender, EventArgs e)
        {
            iconPictureBox_exit.BackColor = Color.Red;
        }

        private void rjButton_delete_MouseEnter(object sender, EventArgs e)
        {
            rjButton_delete.BackColor = Color.FromArgb(15, 14, 14);
        }

        private void rjButton_delete_MouseLeave(object sender, EventArgs e)
        {
            rjButton_delete.BackColor = Color.Transparent;
        }

        private void rjButton_update_MouseEnter(object sender, EventArgs e)
        {
            rjButton_update.BackColor = Color.FromArgb(15, 14, 14);
        }

        private void rjButton_update_MouseLeave(object sender, EventArgs e)
        {
            rjButton_update.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBox_minimize_MouseEnter(object sender, EventArgs e)
        {
            iconPictureBox_minimize.BackColor = Color.FromArgb(55, 59, 63);
        }

        private void iconPictureBox_minimize_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox_minimize.BackColor = Color.Transparent;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            this.Hide();
            signInForm.ShowDialog();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("fullname like '%{0}%'", textBox_search.Text);
            dataGridView_info.DataSource = dv.ToTable();
        }
    }
}
