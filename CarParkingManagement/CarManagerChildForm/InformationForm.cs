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
using System.Windows.Markup;

namespace CarParkingManagement.CarManagerChildForm
{

    public partial class InformationForm : Form
    {
        BUS_Account accountController = new BUS_Account();
        SqlDataAdapter data;
        DataTable tb;
        public InformationForm(string id, string fullname, string username, string email, string position)
        {
            InitializeComponent();
            this.Id = id;
            this.Fullname = fullname;
            this.Username = username;
            /* this.Password = password;*/
            this.Email = email;
            this.Position = position;

        }

        public string Id { get; set; }

        public string Fullname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }


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
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            rjTextBox_fullname.Texts = Fullname;
            rjTextBox_id.Texts = Id;
            rjTextBox_username.Texts = Username;
            rjTextBox_email.Texts = Email;
            rjTextBox_position.Texts = Position;

            /* rjTextBox_id.Enabled = false;*/

            rjTextBox_id.BackColor = Color.FromArgb(41, 39, 39);
            rjTextBox_id.ForeColor = Color.White;

            label_checkPassword.Hide();
            rjButton_saveChanges.Enabled = false;
            textBox_currentPassword.Text = "";
        }


        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton_saveChanges_Click(object sender, EventArgs e)
        {
            string currentPassword = textBox_currentPassword.Text;
            string newPassword = textBox_newPassword.Text;
            string confirmNewPassword = textBox_confirmNewPassword.Text;
            string password = "SELECT top 1 password from Account where username ='" + Username + "'";
            data = new SqlDataAdapter(password, Connection.GetSqlConnection());
            tb = new DataTable();
            data.Fill(tb);
            password = tb.Rows[0][0].ToString();

            if (textBox_currentPassword.Text != password)
            {
                label_checkPassword.Show();
            }
            else
            {
                if (newPassword == confirmNewPassword && newPassword != "" && confirmNewPassword != "" && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green)
                {

                    accountController.UpdatePassword(confirmNewPassword, Username);
                    MessageBox.Show("Change Password Successful");
                    this.Hide();
                    SignInForm signInForm = new SignInForm();
                    signInForm.ShowDialog();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox_currentPassword_Load(object sender, EventArgs e)
        {

        }

        private void rjTextBox_currentPassword_MouseClick(object sender, MouseEventArgs e)
        {
            label_checkPassword.Hide();
        }

        private void textBox_currentPassword_TextChanged(object sender, EventArgs e)
        {
            string currentPassword = textBox_currentPassword.Text;
            string newPassword = textBox_newPassword.Text;
            string confirmNewPassword = textBox_confirmNewPassword.Text;

            if (currentPassword != "" && newPassword == confirmNewPassword && newPassword != "" && confirmNewPassword != "" && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green)
            {
                rjButton_saveChanges.Enabled = true;
            }
            else
            {
                rjButton_saveChanges.Enabled = false;
            }
        }

        private void textBox_currentPassword_MouseClick(object sender, MouseEventArgs e)
        {
            label_checkPassword.Hide();
        }

        private void textBox_confirmNewPassword_TextChanged(object sender, EventArgs e)
        {
            string currentPassword = textBox_currentPassword.Text;
            string newPassword = textBox_newPassword.Text;
            string confirmNewPassword = textBox_confirmNewPassword.Text;

            if (currentPassword != "" && newPassword == confirmNewPassword && newPassword != "" && confirmNewPassword != "" && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green)
            {
                rjButton_saveChanges.Enabled = true;
            }
            else
            {
                rjButton_saveChanges.Enabled = false;
            }
        }

        private void textBox_newPassword_TextChanged(object sender, EventArgs e)
        {
            string currentPassword = textBox_currentPassword.Text;
            string newPassword = textBox_newPassword.Text;
            string confirmNewPassword = textBox_confirmNewPassword.Text;
            if (newPassword.Length >= 8)
            {
                label_checkLong.ForeColor = Color.Green;
            }
            else
            {
                label_checkLong.ForeColor = Color.White;
            }

            if (ValidatePassword(newPassword))
            {
                label_checkLetter.ForeColor = Color.Green;
            }
            else
            {
                label_checkLetter.ForeColor = Color.White;
            }

            if (currentPassword != "" && newPassword == confirmNewPassword && newPassword != "" && confirmNewPassword != "" && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green)
            {
                rjButton_saveChanges.Enabled = true;
            }
            else
            {
                rjButton_saveChanges.Enabled = false;
            }
        }

        private void InformationForm_MouseClick(object sender, MouseEventArgs e)
        {
            CarManagerForm carManagerForm = new CarManagerForm("");
            carManagerForm.panel_info.Visible = false;
        }

        private void rjTextBox2_Load(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
