using FontAwesome.Sharp;
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
    public partial class CarManagerForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;


        bool visible = false;
        public CarManagerForm(string value)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40);
            /*     currentBtn = iconButton_dashboard;*/
            panel_menu.Controls.Add(leftBorderBtn);
            /*    ActivateButton(currBtn, colorActive);*/
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Value = value;
        }

        public string Value { get; set; }

        public static Color colorActive = Color.FromArgb(172, 126, 241);

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                label_titleChildForm.ForeColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(52, 58, 64);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_desktop.Controls.Add(childForm);
            panel_desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label_titleChildForm.Text = childForm.Text;
        }

        private void rjButton_signOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.ShowDialog();
        }



        private void iconButton_dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new CarManagerChildForm.DashboardForm());
        }



        private void iconButton_customers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new CarManagerChildForm.CustomersForm());
        }

        private void iconButton_cars_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new CarManagerChildForm.CarsForm());
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            Reset();
            currentChildForm.Close();
        }


        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            label_titleChildForm.ForeColor = Color.White;
            label_titleChildForm.Text = "Home";
        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void iconButton_parkingSlot_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new CarManagerChildForm.ParkingSlotForm());
        }

        private void panel_display_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_titleChildForm_Click(object sender, EventArgs e)
        {

        }

        private void panel_title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox_exit_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox_exit.BackColor = Color.Red;
        }

        private void iconPictureBox_exit_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox_exit.BackColor = Color.Transparent;
        }

        private void iconPictureBox_exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void iconPictureBox_minimize_MouseHover(object sender, EventArgs e)
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


        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CarManagerChildForm.InformationForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox_user_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (!visible)
            {
                panel_info.Visible = true;
                visible = true;
            }
            else
            {
                panel_info.Visible = false;
                visible = false;
            }
        }

        private void rjButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!visible)
            {
                panel_info.Visible = true;
                visible = true;
            }
            else
            {
                panel_info.Visible = false;
                visible = false;
            }
        }

        private void iconButton_user_MouseClick(object sender, MouseEventArgs e)
        {
            if (!visible)
            {
                panel_info.Visible = true;
                visible = true;
            }
            else
            {
                panel_info.Visible = false;
                visible = false;
            }
        }

        private void iconButton_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CarManagerForm_Load(object sender, EventArgs e)
        {
            string info = Value;
            label_fullname.Text = info.Substring(0, info.IndexOf('#')).ToUpper();
            label_id.Text = info.Substring(info.Length - 9, 9);
            /*      label_id.Text = label_fullname.Width.ToString();*/
            if (label_fullname.Width > 130)
            {
                label_id.Location = new Point(label_fullname.Width - 130 + 142, 30);
            }
            else if (label_fullname.Width < 130)
            {
                label_id.Location = new Point(142 - (130 - label_fullname.Width), 30);
            }
            /* label_id.Text = label_fullname.Width.ToString();*/
            label_id.ForeColor = Color.Gray;
        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void iconButton_signOut_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            this.Hide();
            signInForm.ShowDialog();
        }
    }
}