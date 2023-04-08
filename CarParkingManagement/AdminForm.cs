using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            dataGridView_info.DataSource = accountController.GetAccounts("select * from Account");
            AdjustStudentGridView();
            dataGridView_info.Columns[0].HeaderCell.Value = "ID";
            dataGridView_info.Columns[1].HeaderCell.Value = "Full Name";
            dataGridView_info.Columns[2].HeaderCell.Value = "Username";
            dataGridView_info.Columns[3].HeaderCell.Value = "Password";
            dataGridView_info.Columns[4].HeaderCell.Value = "Email";
            dataGridView_info.Columns[5].HeaderCell.Value = "Position";
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

            if (id != "-1")
            {
                accountController.DeleteAccount(id);
                dataGridView_info.DataSource = accountController.GetAccounts("SELECT * FROM Account");
            }
            else
            {
                MessageBox.Show("Please select a account to delete.");
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
            string id = dataGridView_info.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
            string email = dataGridView_info.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
            string fullname = dataGridView_info.Rows[e.RowIndex].Cells["Fullname"].FormattedValue.ToString();
            string position = dataGridView_info.Rows[e.RowIndex].Cells["Position"].FormattedValue.ToString();
            string username = dataGridView_info.Rows[e.RowIndex].Cells["Username"].FormattedValue.ToString();
            string password = dataGridView_info.Rows[e.RowIndex].Cells["Password"].FormattedValue.ToString();

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


    }
}
