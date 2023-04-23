using BUS;
using CarParkingManagement.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManagement
{
    public partial class ForgotPasswordForm : Form
    {
        public RJTextBox rJTextBox = new RJTextBox();
        public ForgotPasswordForm forgotPasswordForm;
        /*     BUS_Account accountController = new BUS_Account();*/
        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9]{3,20}@gmail.com(.vn|)$");
        }

        public bool checkAccount(string account) //check password va username
        {
            return Regex.IsMatch(account, @"^[a-zA-Z0-9]{4,24}$");
        }

        public ForgotPasswordForm()
        {
            InitializeComponent();
            /*  rjTextBox_email.Text = "";*/
            label_password.Text = "";
        }

        BUS_Account accountController = new BUS_Account();


        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            rjButton_sendPassword.Enabled = false;
            this.ActiveControl = textBox_email;
        }

        private void rjTextBox_email_TextChanged(object sender, EventArgs e)
        {
            /*if (rjTextBox_email.Texts.Length > 1)
            {
                button_recoverPassword.Enabled = true;
            }
            else
            {
                button_recoverPassword.Enabled = false;
            }*/
        }

        private void rjTextBox_email_Load(object sender, EventArgs e)
        {

        }

        private void button_recoverPassword_Click(object sender, EventArgs e)
        {
            string email = textBox_email.Text;
            string username = textBox_email.Text;
            string query = "select * from Account where email = '" + email + "' or username = '" + username + "'";
            if (accountController.GetAccounts(query).Count != 0)
            {
                label_password.ForeColor = Color.Green;
                label_password.Text = "Password: " + accountController.GetAccounts(query)[0].Password;
            }
            else
            {
                label_password.ForeColor = Color.Red;
                label_password.Text = "Email or username not found !";
            }

        }



        private void rjTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_email_TextChanged_1(object sender, EventArgs e)
        {
            if (checkEmail(textBox_email.Text) || checkAccount(textBox_email.Text))
            {
                rjButton_sendPassword.Enabled = true;
            }
            else
            {
                rjButton_sendPassword.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            this.Hide();
            signInForm.ShowDialog();
        }



        private void rjButton_sendPassword_Click(object sender, EventArgs e)
        {
            string email = textBox_email.Text;
            string username = textBox_email.Text;
            string query = "select * from Account where email = '" + email + "' or username = '" + username + "'";
            if (accountController.GetAccounts(query).Count != 0)
            {
                label_password.ForeColor = Color.Green;
                label_password.Text = "Password: " + accountController.GetAccounts(query)[0].Password;
            }
            else
            {
                label_password.ForeColor = Color.Red;
                label_password.Text = "Email or username not found !";
            }
        }

        private void iconPictureBox2_MouseEnter(object sender, EventArgs e)
        {
            iconPictureBox2.BackColor = Color.Red;
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox2_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox2.BackColor = Color.Transparent;
        }

        private void iconPictureBox1_MouseEnter(object sender, EventArgs e)
        {
            iconPictureBox1.BackColor = Color.FromArgb(55, 59, 63);
        }

        private void iconPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox1.BackColor = Color.Transparent;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox_email_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_email.Text == "Email or Phone")
            {
                textBox_email.Text = "";
                textBox_email.ForeColor = Color.Black;
            }
        }

        private void rjButton_sendPassword_MouseEnter(object sender, EventArgs e)
        {
            rjButton_sendPassword.BackColor = Color.FromArgb(188, 37, 42);
        }

        private void rjButton_sendPassword_MouseLeave(object sender, EventArgs e)
        {
            rjButton_sendPassword.BackColor = Color.FromArgb(209, 54, 57);

        }
    }
}
