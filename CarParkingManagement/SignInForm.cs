using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarParkingManagement
{
    public partial class SignInForm : Form
    {
        BUS_Account accountController = new BUS_Account();
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
            if (accountController.GetAccounts(query).Count > 0)
            {
                /*                MessageBox.Show("Login Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                */
                SignInForm signInForm = new SignInForm();
                this.Hide();
                CarManagerForm home = new CarManagerForm();
                home.ShowDialog();

            }
            else
            {
                MessageBox.Show("The username or password is incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            label_signUpHere.ForeColor = Color.DarkOliveGreen;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label_signUpHere.ForeColor = Color.Olive;
        }



        private void label_forgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            this.Hide();
            forgotPasswordForm.ShowDialog();
        }

        private void label_forgotPassword_MouseHover(object sender, EventArgs e)
        {
            label_forgotPassword.ForeColor = Color.DarkOliveGreen;
        }

        private void label_forgotPassword_MouseLeave(object sender, EventArgs e)
        {
            label_forgotPassword.ForeColor = Color.Olive;
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
            textBox_username.BackColor = Color.White;
            rjTextBox1.BackColor = Color.White;
            rjTextBox1.BorderColor = Color.Black;
        }

        private void SignInForm_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_username.BackColor = Color.FromArgb(237, 237, 237);
            rjTextBox1.BackColor = Color.FromArgb(237, 237, 237);
            rjTextBox1.BorderColor = Color.Transparent;
        }
    }
}
