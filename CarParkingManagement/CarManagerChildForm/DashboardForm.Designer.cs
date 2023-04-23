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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_info = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_parkingSlot = new System.Windows.Forms.Panel();
            this.iconPictureBox_parkingSlot = new FontAwesome.Sharp.IconPictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_slot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_customer = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label_revenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rjButton_delete = new CarParkingManagement.RJControls.RJButton();
            this.rjButton3 = new CarParkingManagement.RJControls.RJButton();
            this.rjButton2 = new CarParkingManagement.RJControls.RJButton();
            this.rjButton1 = new CarParkingManagement.RJControls.RJButton();
            this.rjButton4 = new CarParkingManagement.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_parkingSlot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_parkingSlot)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_info
            // 
            this.dataGridView_info.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.dataGridView_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_info.ColumnHeadersHeight = 20;
            this.dataGridView_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_info.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.dataGridView_info.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_info.Name = "dataGridView_info";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_info.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_info.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_info.Size = new System.Drawing.Size(1237, 344);
            this.dataGridView_info.TabIndex = 2;
            this.dataGridView_info.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_info_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.dataGridView_info);
            this.panel1.Location = new System.Drawing.Point(52, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 348);
            this.panel1.TabIndex = 3;
            // 
            // panel_parkingSlot
            // 
            this.panel_parkingSlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel_parkingSlot.Controls.Add(this.iconPictureBox_parkingSlot);
            this.panel_parkingSlot.Controls.Add(this.panel5);
            this.panel_parkingSlot.Controls.Add(this.label_slot);
            this.panel_parkingSlot.Controls.Add(this.label2);
            this.panel_parkingSlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_parkingSlot.Location = new System.Drawing.Point(52, 71);
            this.panel_parkingSlot.Name = "panel_parkingSlot";
            this.panel_parkingSlot.Size = new System.Drawing.Size(365, 183);
            this.panel_parkingSlot.TabIndex = 4;
            this.panel_parkingSlot.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_parkingSlot_Paint);
            this.panel_parkingSlot.MouseEnter += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseEnter);
            this.panel_parkingSlot.MouseLeave += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseLeave);
            // 
            // iconPictureBox_parkingSlot
            // 
            this.iconPictureBox_parkingSlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.iconPictureBox_parkingSlot.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.iconPictureBox_parkingSlot.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_parkingSlot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_parkingSlot.IconSize = 92;
            this.iconPictureBox_parkingSlot.Location = new System.Drawing.Point(258, 35);
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
            // label_slot
            // 
            this.label_slot.AutoSize = true;
            this.label_slot.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_slot.ForeColor = System.Drawing.Color.White;
            this.label_slot.Location = new System.Drawing.Point(31, 55);
            this.label_slot.Name = "label_slot";
            this.label_slot.Size = new System.Drawing.Size(129, 61);
            this.label_slot.TabIndex = 8;
            this.label_slot.Text = "2/42";
            this.label_slot.Click += new System.EventHandler(this.label5_Click);
            this.label_slot.MouseEnter += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseEnter);
            this.label_slot.MouseLeave += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseLeave);
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
            this.label2.MouseEnter += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.iconPictureBox_parkingSlot_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label_customer);
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(488, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 183);
            this.panel2.TabIndex = 7;
            // 
            // label_customer
            // 
            this.label_customer.AutoSize = true;
            this.label_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer.ForeColor = System.Drawing.Color.White;
            this.label_customer.Location = new System.Drawing.Point(24, 55);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(56, 61);
            this.label_customer.TabIndex = 11;
            this.label_customer.Text = "2";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 92;
            this.iconPictureBox2.Location = new System.Drawing.Point(261, 35);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(92, 93);
            this.iconPictureBox2.TabIndex = 12;
            this.iconPictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Customers";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 19);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.iconPictureBox1);
            this.panel4.Controls.Add(this.label_revenue);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(924, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 183);
            this.panel4.TabIndex = 9;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 92;
            this.iconPictureBox1.Location = new System.Drawing.Point(270, 35);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(92, 93);
            this.iconPictureBox1.TabIndex = 9;
            this.iconPictureBox1.TabStop = false;
            // 
            // label_revenue
            // 
            this.label_revenue.AutoSize = true;
            this.label_revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_revenue.ForeColor = System.Drawing.Color.White;
            this.label_revenue.Location = new System.Drawing.Point(15, 55);
            this.label_revenue.Name = "label_revenue";
            this.label_revenue.Size = new System.Drawing.Size(201, 61);
            this.label_revenue.TabIndex = 11;
            this.label_revenue.Text = "423413";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Revenue";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 164);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(365, 19);
            this.panel8.TabIndex = 6;
            // 
            // rjButton_delete
            // 
            this.rjButton_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.rjButton_delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.rjButton_delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(136)))));
            this.rjButton_delete.BorderRadius = 20;
            this.rjButton_delete.BorderSize = 0;
            this.rjButton_delete.FlatAppearance.BorderSize = 0;
            this.rjButton_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_delete.ForeColor = System.Drawing.Color.White;
            this.rjButton_delete.Location = new System.Drawing.Point(1101, 663);
            this.rjButton_delete.Name = "rjButton_delete";
            this.rjButton_delete.Size = new System.Drawing.Size(200, 60);
            this.rjButton_delete.TabIndex = 35;
            this.rjButton_delete.Text = "Delete";
            this.rjButton_delete.TextColor = System.Drawing.Color.White;
            this.rjButton_delete.UseVisualStyleBackColor = false;
            this.rjButton_delete.Click += new System.EventHandler(this.rjButton_delete_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.Enabled = false;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(914, 63);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(387, 202);
            this.rjButton3.TabIndex = 10;
            this.rjButton3.Text = "rjButton3";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Enabled = false;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(478, 63);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(387, 202);
            this.rjButton2.TabIndex = 8;
            this.rjButton2.Text = "rjButton2";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Enabled = false;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(42, 63);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(387, 202);
            this.rjButton1.TabIndex = 6;
            this.rjButton1.Text = "rjButton1";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 20;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.Enabled = false;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(42, 285);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(1259, 372);
            this.rjButton4.TabIndex = 11;
            this.rjButton4.Text = "rjButton4";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(164)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1321, 748);
            this.Controls.Add(this.rjButton_delete);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.panel_parkingSlot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rjButton4);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_parkingSlot.ResumeLayout(false);
            this.panel_parkingSlot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_parkingSlot)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_parkingSlot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_slot;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_parkingSlot;
        private RJControls.RJButton rjButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private RJControls.RJButton rjButton2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private RJControls.RJButton rjButton3;
        private System.Windows.Forms.Label label_customer;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label_revenue;
        private System.Windows.Forms.Label label3;
        private RJControls.RJButton rjButton4;
        private RJControls.RJButton rjButton_delete;
    }
}