using BUS;
using CarParkingManagement.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9]{3,20}@gmail.com(.vn|)$");
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
            button_recoverPassword.Enabled = false;
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
            string query = "select * from Account where email = '" + email + "'";
            if (accountController.GetAccounts(query).Count != 0)
            {
                label_password.ForeColor = Color.Green;
                label_password.Text = "Password: " + accountController.GetAccounts(query)[0].Password;
            }
            else
            {
                label_password.ForeColor = Color.Red;
                label_password.Text = "Email not found !";
            }

        }



        private void rjTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_email_TextChanged_1(object sender, EventArgs e)
        {
            if (checkEmail(textBox_email.Text))
            {
                button_recoverPassword.Enabled = true;
            }
            else
            {
                button_recoverPassword.Enabled = false;
            }
        }
    }
}
