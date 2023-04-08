using BUS;
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
    public partial class UpdateForm : Form
    {
        BUS_Account accountController = new BUS_Account();
        public UpdateForm(string id, string fullname, string username, string password, string email, string position)
        {
            InitializeComponent();
            this.Id = id;
            this.Fullname = fullname;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Position = position;

        }

        public string Id { get; set; }

        public string Fullname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }

        public bool checkAccount(string account) //check password va username
        {
            return Regex.IsMatch(account, @"^[a-zA-Z0-9]{4,24}$");
        }

        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9]{3,20}@gmail.com(.vn|)$");
        }

        static bool ValidatePassword(string passWord)
        {
            int validConditions = 0;
            foreach (char c in passWord)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    break;
                }
            }
            /*foreach (char c in passWord)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    break;
                }
            }*/
            if (validConditions == 0) return false;
            foreach (char c in passWord)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    break;
                }
            }
            /*          if (validConditions == 1) return false;*/
            if (validConditions == 1)
            {
                char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' }; // or whatever    
                if (passWord.IndexOfAny(special) == -1) return false;
            }
            return true;
        }

        private void button_signup_Click(object sender, EventArgs e)
        {

        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            string id = Id;
            string fullname = Fullname;
            string username = Username;
            string password = Password;
            string email = Email;
            string position = Position;

            textBox_id.Text = id;
            textBox_email.Text = email;
            textBox_fullName.Text = fullname;
            textBox_username.Text = username;
            textBox_password.Text = password;
            comboBox_position.Text = position;
        }



        private void textBox_email_TextChanged_1(object sender, EventArgs e)
        {
            string email = textBox_email.Text;
            string password = textBox_password.Text;

            string username = textBox_username.Text;
            if (accountController.GetAccounts("Select * from Account where email = '" + email + "'").Count != 0)
            {
                label_checkEmail.ForeColor = Color.Red;
                label_checkEmail.Show();
            }
            else
            {
                label_checkEmail.ForeColor = Color.Black;
                label_checkEmail.Hide();
            }

            if (label_checkEmail.ForeColor == Color.Red)
            {
                button_signup.Enabled = false;
            }
            else if (label_checkUsername.ForeColor == Color.Black && checkAccount(username) && label_checkEmail.ForeColor == Color.Black && checkEmail(email)  && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green)
            {
                button_signup.Enabled = true;
            }
            else
            {
                button_signup.Enabled = false;
            }
        }
    }
}
