using BUS;
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
    public partial class UpdateForm : Form
    {
        BUS_Account accountController = new BUS_Account();
        AdminForm adminForm = new AdminForm();
        public UpdateForm(string id, string fullname, string username, string password, string email, string position, AdminForm adminForm)
        {
            InitializeComponent();
            this.Id = id;
            this.Fullname = fullname;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Position = position;
            this.adminForm = adminForm;
        }

        public string Id { get; set; }

        public string Fullname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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
            string email = textBox_email.Text;
            string password = textBox_password.Text;
            string username = textBox_username.Text;
            string fullname = textBox_fullName.Text;
            string position = comboBox_position.Text;
            string id = textBox_id.Text;

            /*            DataGridView dataGridView_info = adminForm.Controls["dataGridView_info"] as DataGridView;
            */
            accountController.UpdateAccount(id, fullname, username, password, email, position);
            this.Hide();
            /*  adminForm.ShowDialog();*/
            adminForm.dataGridView_info.DataSource = accountController.GetAccounts("SELECT * FROM Account");

        }

        /*    string email = textBox_email.Text;
            string password = textBox_password.Text;
            string username = textBox_username.Text;
            string fullname = textBox_fullName.Text;
            string position = comboBox_position.Text;
            string id = textBox_id.Text;


            accountController.UpdateAccount(id, fullname, username, password, email, position);
                this.Hide();

            adminForm.dataGridView_info.DataSource = accountController.GetAccounts("SELECT * FROM Account");*/

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

            textBox_id.Enabled = false;

            /*    label_checkEmail.Hide();*/
        }



        private void textBox_email_TextChanged_1(object sender, EventArgs e)
        {
            string email = textBox_email.Text;
            string password = textBox_password.Text;

            string username = textBox_username.Text;

            if (email == Email)
            {
                label_checkEmail.Hide();
                label_checkEmail.ForeColor = Color.Black;
            }
            else if (accountController.GetAccounts("Select * from Account where email = '" + email + "'").Count != 0)
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
            else if (label_checkUsername.ForeColor == Color.Black && checkAccount(username) && label_checkEmail.ForeColor == Color.Black && checkEmail(email) && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green && comboBox_position.Text != "")
            {
                button_signup.Enabled = true;
            }
            else
            {
                button_signup.Enabled = false;
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            string password = textBox_password.Text;
            string email = textBox_email.Text;
            string username = textBox_username.Text;
            if (password.Length >= 8)
            {
                label_checkLong.ForeColor = Color.Green;
            }
            else
            {
                label_checkLong.ForeColor = Color.White;
            }

            if (ValidatePassword(password))
            {
                label_checkLetter.ForeColor = Color.Green;
            }
            else
            {
                label_checkLetter.ForeColor = Color.White;
            }
            if (label_checkUsername.ForeColor == Color.Black && checkAccount(username) && label_checkEmail.ForeColor == Color.Black && checkEmail(email) && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green && comboBox_position.Text != "")
            {
                button_signup.Enabled = true;
            }
            else
            {
                button_signup.Enabled = false;
            }
        }

        private void textBox_fullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_position_TextChanged(object sender, EventArgs e)
        {
            string password = textBox_password.Text;
            string email = textBox_email.Text;
            string username = textBox_username.Text;

            if (label_checkUsername.ForeColor == Color.Black && checkAccount(username) && label_checkEmail.ForeColor == Color.Black && checkEmail(email) && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green && comboBox_position.Text != "")
            {
                button_signup.Enabled = true;
            }
            else
            {
                button_signup.Enabled = false;
            }
        }

        private void button_signup_MouseHover(object sender, EventArgs e)
        {
            button_signup.BackColor = Color.Orange;
        }

        private void comboBox_position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string email = textBox_email.Text;
            string password = textBox_password.Text;

            if (username == "")
            {
                label_checkUsername2.Show();
            }
            else
            {
                label_checkUsername2.Hide();
            }


            if (username == Username)
            {
                label_checkUsername.ForeColor = Color.Black;
                label_checkUsername.Hide();
            }
            else if (accountController.GetAccounts("Select * from Account where username = '" + username + "'").Count != 0)
            {
                label_checkUsername.ForeColor = Color.Red;
                label_checkUsername.Show();
            }
            else
            {
                label_checkUsername.ForeColor = Color.Black;
                label_checkUsername.Hide();
            }

            if (label_checkUsername.ForeColor == Color.Red)
            {
                button_signup.Enabled = false;
            }
            else if (label_checkUsername.ForeColor == Color.Black && checkAccount(username) && label_checkEmail.ForeColor == Color.Black && checkEmail(email) && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green && comboBox_position.Text != "")
            {
                button_signup.Enabled = true;
            }
            else
            {
                button_signup.Enabled = false;
            }
        }

        private void label_checkLong_Click(object sender, EventArgs e)
        {

        }

        private void panel_title_MouseDown(object sender, MouseEventArgs e)
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

        private void label_fullname_Click(object sender, EventArgs e)
        {

        }

        private void button_signup_Click_1(object sender, EventArgs e)
        {
            string email = textBox_email.Text;
            string password = textBox_password.Text;
            string username = textBox_username.Text;
            string fullname = textBox_fullName.Text;
            string position = comboBox_position.Text;
            string id = textBox_id.Text;

            /*            DataGridView dataGridView_info = adminForm.Controls["dataGridView_info"] as DataGridView;
            */
            accountController.UpdateAccount(id, fullname, username, password, email, position);
            this.Hide();
            /*  adminForm.ShowDialog();*/
            adminForm.dataGridView_info.DataSource = accountController.GetAccounts("SELECT * FROM Account");
        }

        private void guna2ComboBox1_TextChanged(object sender, EventArgs e)
        {
            string password = textBox_password.Text;
            string email = textBox_email.Text;
            string username = textBox_username.Text;

            if (label_checkUsername.ForeColor == Color.Black && checkAccount(username) && label_checkEmail.ForeColor == Color.Black && checkEmail(email) && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green && comboBox_position.Text != "")
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
