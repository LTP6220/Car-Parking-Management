using BUS;
using CarParkingManagement.CarManagerChildForm;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarParkingManagement
{
    public partial class SignInForm : Form
    {
        BUS_Account accountController = new BUS_Account();
        SqlDataAdapter data;
        DataTable tb;
        SqlConnection cn;

        public SignInForm()
        {
            InitializeComponent();
        }



        private void SignInForm_Load(object sender, EventArgs e)
        {
            button_signIn.Enabled = false;

        }

        private void button_signIn_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;


            button_signIn.Enabled = true;
            string query = "Select * from Account where username = '" + username + "' and password = '" + password + "'";
            if (username == "admin" && password == "123456")
            {
                AdminForm adminForm = new AdminForm();
                this.Hide();
                adminForm.ShowDialog();
            }
            else
            {
                if (accountController.GetAccounts(query).Count > 0)
                {
                    /*                MessageBox.Show("Login Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    */

                    SignInForm signInForm = new SignInForm();
                    this.Hide();
                    string fullname = "select top 1 fullname from Account where username = '" + username + "'";
                    data = new SqlDataAdapter(fullname, Connection.GetSqlConnection());
                    tb = new DataTable();
                    data.Fill(tb);
                    fullname = tb.Rows[0][0].ToString();


                    string id = "select top 1 id from Account where username = '" + username + "'";
                    data = new SqlDataAdapter(id, Connection.GetSqlConnection());
                    tb = new DataTable();
                    data.Fill(tb);
                    id = tb.Rows[0][0].ToString();

                    string info = fullname + "#" + id;
                    CarManagerForm home = new CarManagerForm(info);
                    home.ShowDialog();

                }
                else
                {
                    MessageBox.Show("The username or password is incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            if (username.Trim() != "" && password.Trim() != "")
            {
                button_signIn.Enabled = true;

            }
            else
            {
                button_signIn.Enabled = false;
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            if (username.Trim() != "" && password.Trim() != "")
            {
                button_signIn.Enabled = true;

            }
            else
            {
                button_signIn.Enabled = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.ShowDialog();

        }



        private void label3_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.ShowDialog();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            /*       label_signUpHere.ForeColor = Color.DarkOliveGreen;*/
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            /* label_signUpHere.ForeColor = Color.Olive;*/
        }



        private void label_forgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            this.Hide();
            forgotPasswordForm.ShowDialog();
        }

        private void label_forgotPassword_MouseHover(object sender, EventArgs e)
        {
            /*        label_forgotPassword.ForeColor = Color.DarkOliveGreen;*/
        }

        private void label_forgotPassword_MouseLeave(object sender, EventArgs e)
        {
            label_forgotPassword.ForeColor = Color.FromArgb(209, 54, 57);
        }

        private void rjButton_show_Click(object sender, EventArgs e)
        {
            if (textBox_password.PasswordChar == '•')
            {
                rjButton_hide.BringToFront();
                textBox_password.PasswordChar = '\0';
            }
        }

        private void rjButton_hide_Click(object sender, EventArgs e)
        {
            if (textBox_password.PasswordChar == '\0')
            {
                rjButton_show.BringToFront();
                textBox_password.PasswordChar = '•';
            }
        }

        private void textBox_username_MouseClick(object sender, MouseEventArgs e)
        {
            /*  textBox_username.BackColor = Color.White;
              rjTextBox1.BackColor = Color.White;
              rjTextBox1.BorderColor = Color.Black;*/
        }

        private void SignInForm_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_username.BackColor = Color.FromArgb(237, 237, 237);
            rjTextBox1.BackColor = Color.FromArgb(237, 237, 237);
            rjTextBox1.BorderColor = Color.Transparent;
        }

        private void button_signIn_Enter(object sender, EventArgs e)
        {

        }

        private void button_signIn_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                button_signIn_Click_1(sender, e);
            }
        }

        private void textBox_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                button_signIn_Click_1(sender, e);
            }
        }

        private void button_signIn_Click_1(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;


            button_signIn.Enabled = true;
            string query = "Select * from Account where username = '" + username + "' and password = '" + password + "'";
            if (username == "admin" && password == "123456")
            {
                AdminForm adminForm = new AdminForm();
                this.Hide();
                adminForm.ShowDialog();
            }
            else
            {
                if (accountController.GetAccounts(query).Count > 0)
                {
                    /*                MessageBox.Show("Login Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    */
                    string position = "select top 1 position from Account where username = '" + username + "'";
                    data = new SqlDataAdapter(position, Connection.GetSqlConnection());
                    tb = new DataTable();
                    data.Fill(tb);
                    position = tb.Rows[0][0].ToString();

                    if (position == "Car Manager")
                    {
                        SignInForm signInForm = new SignInForm();
                        this.Hide();
                        string fullname = "select top 1 fullname from Account where username = '" + username + "'";
                        data = new SqlDataAdapter(fullname, Connection.GetSqlConnection());
                        tb = new DataTable();
                        data.Fill(tb);
                        fullname = tb.Rows[0][0].ToString();


                        string id = "select top 1 id from Account where username = '" + username + "'";
                        data = new SqlDataAdapter(id, Connection.GetSqlConnection());
                        tb = new DataTable();
                        data.Fill(tb);
                        id = tb.Rows[0][0].ToString();

                        string info = fullname + "#" + id;
                        CarManagerForm home = new CarManagerForm(info);
                        home.ShowDialog();
                    }
                    else if (position == "Accountant")
                    {

                        SignInForm signInForm = new SignInForm();
                        this.Hide();
                        string fullname = "select top 1 fullname from Account where username = '" + username + "'";
                        data = new SqlDataAdapter(fullname, Connection.GetSqlConnection());
                        tb = new DataTable();
                        data.Fill(tb);
                        fullname = tb.Rows[0][0].ToString();


                        string id = "select top 1 id from Account where username = '" + username + "'";
                        data = new SqlDataAdapter(id, Connection.GetSqlConnection());
                        tb = new DataTable();
                        data.Fill(tb);
                        id = tb.Rows[0][0].ToString();

                        string info = fullname + "#" + id;
                        AccountantForm accountantForm = new AccountantForm(info);
                        this.Hide();
                        accountantForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("The username or password is incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox_exit_MouseEnter(object sender, EventArgs e)
        {
            iconPictureBox_exit.BackColor = Color.Red;
        }

        private void iconPictureBox_exit_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox_exit.BackColor = Color.Transparent;
        }

        private void iconPictureBox_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void button_signIn_MouseEnter(object sender, EventArgs e)
        {
            button_signIn.BackColor = Color.FromArgb(188, 37, 42);
        }

        private void button_signIn_MouseLeave(object sender, EventArgs e)
        {
            button_signIn.BackColor = Color.FromArgb(209, 54, 57);

        }

        private void label_forgotPassword_MouseEnter(object sender, EventArgs e)
        {
            label_forgotPassword.ForeColor = Color.FromArgb(188, 37, 42);
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
