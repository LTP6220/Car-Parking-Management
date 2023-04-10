using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManagement.CarManagerChildForm
{

    public partial class InformationForm : Form
    {

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

            rjTextBox_id.Enabled = false;
            rjTextBox_id.BackColor = Color.FromArgb(41, 39, 39);
            rjTextBox_id.ForeColor = Color.White;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
