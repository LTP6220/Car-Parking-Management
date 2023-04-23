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
    public partial class SignUpForm : Form
    {
        BUS_Account accountController = new BUS_Account();
        AdminForm adminForm = new AdminForm();
        public SignUpForm()
        {
            InitializeComponent();
        }

        public bool checkAccount(string account) //check password va username
        {
            return Regex.IsMatch(account, @"^[a-zA-Z0-9]{4,24}$");
        }

        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9]{3,20}@gmail.com(.vn|)$");
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


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

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            button_signup.Enabled = false;
            label_checkEmail.Hide();
            label_checkUsername.Hide();
            label_checkUsername2.Hide();
        }

        public int rnd()
        {
            Random rnd = new Random();
            return rnd.Next(10000000, 99999999);
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            string email = textBox_email.Text;
            string password = textBox_password.Text;
            string username = textBox_username.Text;
            string fullname = textBox_fullName.Text;
            string position = comboBox_position.Text;
            string id = rnd().ToString();
            /* string query = "insert into Account values ('" + id + "','" + fullname + "','" + username + "','" + password + "','" + email + "')";
             accountController.Command(query);*/

            /*            DataGridView dataGridView_info = adminForm.Controls["dataGridView_info"] as DataGridView;
            */
            accountController.AddAccount(id, fullname, username, password, email, position);
            this.Hide();
            /*   adminForm.ShowDialog();*/
            adminForm.dataGridView_info.DataSource = accountController.GetAccounts("SELECT * FROM Account");
            /*
                        MessageBox.Show("Signup successful");*/
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            string email = textBox_email.Text;
            string password = textBox_password.Text;
            string confirmPassword = textBox_confirmPassword.Text;
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
            else if (label_checkUsername.ForeColor == Color.Black && checkAccount(username) && label_checkEmail.ForeColor == Color.Black && checkEmail(email) && confirmPassword == password && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green && comboBox_position.Text != "")
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
            string confirmPassword = textBox_confirmPassword.Text;
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
            if (label_checkUsername.ForeColor == Color.Black && checkAccount(username) && label_checkEmail.ForeColor == Color.Black && checkEmail(email) && confirmPassword == password && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green && comboBox_position.Text != "")
            {
                button_signup.Enabled = true;
            }
            else
            {
                button_signup.Enabled = false;
            }
        }

        private void textBox_confirmPassword_TextChanged(object sender, EventArgs e)
        {
            string confirmPassword = textBox_confirmPassword.Text;
            string password = textBox_password.Text;
            string email = textBox_email.Text;
            string username = textBox_username.Text;
            if (label_checkUsername.ForeColor == Color.Black && checkAccount(username) && label_checkEmail.ForeColor == Color.Black && checkEmail(email) && confirmPassword == password && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green && comboBox_position.Text != "")
            {
                button_signup.Enabled = true;
            }
            else
            {
                button_signup.Enabled = false;
            }
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string email = textBox_email.Text;
            string password = textBox_password.Text;
            string confirmPassword = textBox_confirmPassword.Text;
            if (username == "")
            {
                label_checkUsername2.Show();
            }
            else
            {
                label_checkUsername2.Hide();
            }
            if (accountController.GetAccounts("Select * from Account where username = '" + username + "'").Count != 0)
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
            else if (label_checkUsername.ForeColor == Color.Black && checkAccount(username) && label_checkEmail.ForeColor == Color.Black && checkEmail(email) && confirmPassword == password && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green && comboBox_position.Text != "")
            {
                button_signup.Enabled = true;
            }
            else
            {
                button_signup.Enabled = false;
            }
        }

        private void textBox_username_MouseClick(object sender, MouseEventArgs e)
        {
            string username = textBox_username.Text;
            if (username == "")
            {
                label_checkUsername2.Show();
            }
            else
            {
                label_checkUsername2.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            this.Hide();
            signInForm.ShowDialog();
        }

        private void label_toSignInForm_MouseHover(object sender, EventArgs e)
        {

        }

        private void label_toSignInForm_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            this.Hide();
            signInForm.ShowDialog();
        }

        private void comboBox_position_TextChanged(object sender, EventArgs e)
        {
            string password = textBox_password.Text;
            string confirmPassword = textBox_confirmPassword.Text;
            string email = textBox_email.Text;
            string username = textBox_username.Text;

            if (label_checkUsername.ForeColor == Color.Black && checkAccount(username) && label_checkEmail.ForeColor == Color.Black && checkEmail(email) && confirmPassword == password && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green && comboBox_position.Text != "")
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

        private void comboBox_position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_signup_MouseHover(object sender, EventArgs e)
        {
            button_signup.BackColor = Color.Orange;
        }

        private void button_signup_MouseLeave(object sender, EventArgs e)
        {
            button_signup.BackColor = Color.Yellow;
        }

        private void label_checkLong_Click(object sender, EventArgs e)
        {

        }

        private void textBox_email_TextChanged_1(object sender, EventArgs e)
        {
            string email = textBox_email.Text;
            string password = textBox_password.Text;
            string confirmPassword = textBox_confirmPassword.Text;
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
            else if (label_checkUsername.ForeColor == Color.Black && checkAccount(username) && label_checkEmail.ForeColor == Color.Black && checkEmail(email) && confirmPassword == password && label_checkLong.ForeColor == Color.Green && label_checkLetter.ForeColor == Color.Green && comboBox_position.Text != "")
            {
                button_signup.Enabled = true;
            }
            else
            {
                button_signup.Enabled = false;
            }
        }

        private void button_signup_Click_1(object sender, EventArgs e)
        {
            string email = textBox_email.Text;
            string password = textBox_password.Text;
            string username = textBox_username.Text;
            string fullname = textBox_fullName.Text;
            string position = comboBox_position.Text;
            string id = rnd().ToString();
            accountController.AddAccount(id, fullname, username, password, email, position);
            this.Hide();
            /*   adminForm.ShowDialog();*/
            List<Form> form = Application.OpenForms.Cast<Form>().ToList();
            AdminForm forms;

            foreach (Form formItem in form)
            {
                if (formItem.Name == "AdminForm")
                {
                    forms = (AdminForm)formItem;
                    forms.AdminForm_Load(sender, e);
                    break;
                }
            }


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

        private void panel_title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel_title_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
