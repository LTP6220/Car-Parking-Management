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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            iconPictureBox_parkingSlot.Size = new Size(120, 120);
        }

        private void panel_parkingSlot_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox_parkingSlot.Size = new Size(92, 93);
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            /*   label2.Enabled = false;*//*
               label2.ForeColor = Color.White;*/
        }

        private void panel_parkingSlot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox_parkingSlot_MouseEnter(object sender, EventArgs e)
        {
/*            iconPictureBox_parkingSlot.BackColor = 
*/        }

        private void iconPictureBox_parkingSlot_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox_parkingSlot.Size = new Size(92, 93);
            iconPictureBox_parkingSlot.Location = new Point(257, 23);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
