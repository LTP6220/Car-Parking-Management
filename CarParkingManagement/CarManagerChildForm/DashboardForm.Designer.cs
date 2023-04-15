namespace CarParkingManagement.CarManagerChildForm
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_parkingSlot = new System.Windows.Forms.Panel();
            this.iconPictureBox_parkingSlot = new FontAwesome.Sharp.IconPictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_revenue = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_totalCars = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_parkingSlot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_parkingSlot)).BeginInit();
            this.panel_revenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel_totalCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1192, 304);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(76, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 392);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_parkingSlot
            // 
            this.panel_parkingSlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel_parkingSlot.Controls.Add(this.iconPictureBox_parkingSlot);
            this.panel_parkingSlot.Controls.Add(this.panel5);
            this.panel_parkingSlot.Controls.Add(this.label5);
            this.panel_parkingSlot.Controls.Add(this.label2);
            this.panel_parkingSlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_parkingSlot.Location = new System.Drawing.Point(76, 71);
            this.panel_parkingSlot.Name = "panel_parkingSlot";
            this.panel_parkingSlot.Size = new System.Drawing.Size(365, 183);
            this.panel_parkingSlot.TabIndex = 4;
            this.panel_parkingSlot.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_parkingSlot_Paint);
            this.panel_parkingSlot.MouseEnter += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseEnter);
            this.panel_parkingSlot.MouseLeave += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseLeave);
            // 
            // iconPictureBox_parkingSlot
            // 
            this.iconPictureBox_parkingSlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.iconPictureBox_parkingSlot.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.iconPictureBox_parkingSlot.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_parkingSlot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_parkingSlot.IconSize = 92;
            this.iconPictureBox_parkingSlot.Location = new System.Drawing.Point(257, 23);
            this.iconPictureBox_parkingSlot.Margin = new System.Windows.Forms.Padding(111, 7, 7, 7);
            this.iconPictureBox_parkingSlot.Name = "iconPictureBox_parkingSlot";
            this.iconPictureBox_parkingSlot.Size = new System.Drawing.Size(92, 93);
            this.iconPictureBox_parkingSlot.TabIndex = 9;
            this.iconPictureBox_parkingSlot.TabStop = false;
            this.iconPictureBox_parkingSlot.MouseEnter += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseEnter);
            this.iconPictureBox_parkingSlot.MouseLeave += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 164);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(365, 19);
            this.panel5.TabIndex = 6;
            this.panel5.MouseEnter += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 61);
            this.label5.TabIndex = 8;
            this.label5.Text = "2";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseEnter += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parking Slots";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseLeave);
            // 
            // panel_revenue
            // 
            this.panel_revenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel_revenue.Controls.Add(this.iconPictureBox1);
            this.panel_revenue.Controls.Add(this.panel7);
            this.panel_revenue.Controls.Add(this.label6);
            this.panel_revenue.Controls.Add(this.label3);
            this.panel_revenue.Location = new System.Drawing.Point(903, 71);
            this.panel_revenue.Name = "panel_revenue";
            this.panel_revenue.Size = new System.Drawing.Size(365, 183);
            this.panel_revenue.TabIndex = 5;
            this.panel_revenue.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 92;
            this.iconPictureBox1.Location = new System.Drawing.Point(258, 23);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(92, 93);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 164);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(365, 19);
            this.panel7.TabIndex = 9;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 61);
            this.label6.TabIndex = 8;
            this.label6.Text = "423413";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Revenue";
            // 
            // panel_totalCars
            // 
            this.panel_totalCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel_totalCars.Controls.Add(this.iconPictureBox2);
            this.panel_totalCars.Controls.Add(this.panel6);
            this.panel_totalCars.Controls.Add(this.label4);
            this.panel_totalCars.Controls.Add(this.label1);
            this.panel_totalCars.Location = new System.Drawing.Point(492, 71);
            this.panel_totalCars.Name = "panel_totalCars";
            this.panel_totalCars.Size = new System.Drawing.Size(365, 183);
            this.panel_totalCars.TabIndex = 5;
            this.panel_totalCars.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 92;
            this.iconPictureBox2.Location = new System.Drawing.Point(257, 23);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(92, 93);
            this.iconPictureBox2.TabIndex = 9;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 164);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(365, 19);
            this.panel6.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 61);
            this.label4.TabIndex = 7;
            this.label4.Text = "2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Cars";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1290, 748);
            this.Controls.Add(this.panel_totalCars);
            this.Controls.Add(this.panel_revenue);
            this.Controls.Add(this.panel_parkingSlot);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_parkingSlot.ResumeLayout(false);
            this.panel_parkingSlot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_parkingSlot)).EndInit();
            this.panel_revenue.ResumeLayout(false);
            this.panel_revenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel_totalCars.ResumeLayout(false);
            this.panel_totalCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_parkingSlot;
        private System.Windows.Forms.Panel panel_revenue;
        private System.Windows.Forms.Panel panel_totalCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_parkingSlot;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}