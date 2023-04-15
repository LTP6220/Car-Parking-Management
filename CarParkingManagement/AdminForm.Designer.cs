namespace CarParkingManagement
{
    partial class AdminForm
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
            this.dataGridView_info = new System.Windows.Forms.DataGridView();
            this.panel_title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox_minimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox_exit = new FontAwesome.Sharp.IconPictureBox();
            this.rjButton_update = new CarParkingManagement.RJControls.RJButton();
            this.rjButton_delete = new CarParkingManagement.RJControls.RJButton();
            this.rjButton_createAccount = new CarParkingManagement.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).BeginInit();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_exit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_info
            // 
            this.dataGridView_info.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.dataGridView_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_info.ColumnHeadersHeight = 40;
            this.dataGridView_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_info.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.dataGridView_info.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_info.Name = "dataGridView_info";
            this.dataGridView_info.ReadOnly = true;
            this.dataGridView_info.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_info.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_info.RowHeadersVisible = false;
            this.dataGridView_info.RowTemplate.Height = 30;
            this.dataGridView_info.RowTemplate.ReadOnly = true;
            this.dataGridView_info.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_info.Size = new System.Drawing.Size(1028, 343);
            this.dataGridView_info.TabIndex = 0;
            this.dataGridView_info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_info_CellClick);
            this.dataGridView_info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_info_CellContentClick);
            this.dataGridView_info.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_info_CellFormatting);
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.Transparent;
            this.panel_title.Controls.Add(this.iconPictureBox1);
            this.panel_title.Controls.Add(this.label1);
            this.panel_title.Controls.Add(this.iconPictureBox_minimize);
            this.panel_title.Controls.Add(this.iconPictureBox_exit);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1052, 99);
            this.panel_title.TabIndex = 4;
            this.panel_title.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_title_Paint);
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(335, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "ACCOUNT MANAGEMENT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconPictureBox_minimize
            // 
            this.iconPictureBox_minimize.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox_minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPictureBox_minimize.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_minimize.IconSize = 20;
            this.iconPictureBox_minimize.Location = new System.Drawing.Point(983, 0);
            this.iconPictureBox_minimize.Name = "iconPictureBox_minimize";
            this.iconPictureBox_minimize.Size = new System.Drawing.Size(35, 20);
            this.iconPictureBox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox_minimize.TabIndex = 11;
            this.iconPictureBox_minimize.TabStop = false;
            this.iconPictureBox_minimize.Click += new System.EventHandler(this.iconPictureBox_minimize_Click);
            this.iconPictureBox_minimize.MouseEnter += new System.EventHandler(this.iconPictureBox_minimize_MouseEnter);
            this.iconPictureBox_minimize.MouseLeave += new System.EventHandler(this.iconPictureBox_minimize_MouseLeave);
            // 
            // iconPictureBox_exit
            // 
            this.iconPictureBox_exit.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconPictureBox_exit.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_exit.IconSize = 20;
            this.iconPictureBox_exit.Location = new System.Drawing.Point(1017, 0);
            this.iconPictureBox_exit.Name = "iconPictureBox_exit";
            this.iconPictureBox_exit.Size = new System.Drawing.Size(35, 20);
            this.iconPictureBox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox_exit.TabIndex = 10;
            this.iconPictureBox_exit.TabStop = false;
            this.iconPictureBox_exit.Click += new System.EventHandler(this.iconPictureBox2_Click);
            this.iconPictureBox_exit.MouseEnter += new System.EventHandler(this.iconPictureBox_exit_MouseEnter);
            this.iconPictureBox_exit.MouseLeave += new System.EventHandler(this.iconPictureBox2_MouseLeave);
            // 
            // rjButton_update
            // 
            this.rjButton_update.BackColor = System.Drawing.Color.Transparent;
            this.rjButton_update.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton_update.BorderColor = System.Drawing.Color.White;
            this.rjButton_update.BorderRadius = 0;
            this.rjButton_update.BorderSize = 1;
            this.rjButton_update.FlatAppearance.BorderSize = 0;
            this.rjButton_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_update.ForeColor = System.Drawing.Color.White;
            this.rjButton_update.Location = new System.Drawing.Point(475, 371);
            this.rjButton_update.Name = "rjButton_update";
            this.rjButton_update.Size = new System.Drawing.Size(150, 40);
            this.rjButton_update.TabIndex = 7;
            this.rjButton_update.Text = "Update";
            this.rjButton_update.TextColor = System.Drawing.Color.White;
            this.rjButton_update.UseVisualStyleBackColor = false;
            this.rjButton_update.Click += new System.EventHandler(this.rjButton_update_Click);
            this.rjButton_update.MouseEnter += new System.EventHandler(this.rjButton_update_MouseEnter);
            this.rjButton_update.MouseLeave += new System.EventHandler(this.rjButton_update_MouseLeave);
            // 
            // rjButton_delete
            // 
            this.rjButton_delete.BackColor = System.Drawing.Color.Transparent;
            this.rjButton_delete.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton_delete.BorderColor = System.Drawing.Color.White;
            this.rjButton_delete.BorderRadius = 0;
            this.rjButton_delete.BorderSize = 1;
            this.rjButton_delete.FlatAppearance.BorderSize = 0;
            this.rjButton_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_delete.ForeColor = System.Drawing.Color.White;
            this.rjButton_delete.Location = new System.Drawing.Point(658, 371);
            this.rjButton_delete.Name = "rjButton_delete";
            this.rjButton_delete.Size = new System.Drawing.Size(150, 40);
            this.rjButton_delete.TabIndex = 6;
            this.rjButton_delete.Text = "Delete";
            this.rjButton_delete.TextColor = System.Drawing.Color.White;
            this.rjButton_delete.UseVisualStyleBackColor = false;
            this.rjButton_delete.Click += new System.EventHandler(this.rjButton_delete_Click);
            this.rjButton_delete.MouseEnter += new System.EventHandler(this.rjButton_delete_MouseEnter);
            this.rjButton_delete.MouseLeave += new System.EventHandler(this.rjButton_delete_MouseLeave);
            // 
            // rjButton_createAccount
            // 
            this.rjButton_createAccount.BackColor = System.Drawing.Color.Transparent;
            this.rjButton_createAccount.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton_createAccount.BorderColor = System.Drawing.Color.White;
            this.rjButton_createAccount.BorderRadius = 0;
            this.rjButton_createAccount.BorderSize = 1;
            this.rjButton_createAccount.FlatAppearance.BorderSize = 0;
            this.rjButton_createAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_createAccount.ForeColor = System.Drawing.Color.White;
            this.rjButton_createAccount.Location = new System.Drawing.Point(833, 371);
            this.rjButton_createAccount.Name = "rjButton_createAccount";
            this.rjButton_createAccount.Size = new System.Drawing.Size(150, 40);
            this.rjButton_createAccount.TabIndex = 5;
            this.rjButton_createAccount.Text = "Create Account";
            this.rjButton_createAccount.TextColor = System.Drawing.Color.White;
            this.rjButton_createAccount.UseVisualStyleBackColor = false;
            this.rjButton_createAccount.Click += new System.EventHandler(this.rjButton_createAccount_Click);
            this.rjButton_createAccount.MouseEnter += new System.EventHandler(this.rjButton_createAccount_MouseEnter);
            this.rjButton_createAccount.MouseLeave += new System.EventHandler(this.rjButton_createAccount_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.rjButton_update);
            this.panel1.Controls.Add(this.dataGridView_info);
            this.panel1.Controls.Add(this.rjButton_delete);
            this.panel1.Controls.Add(this.rjButton_createAccount);
            this.panel1.Location = new System.Drawing.Point(12, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 454);
            this.panel1.TabIndex = 8;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 49;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 31);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(54, 49);
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1052, 657);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).EndInit();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_exit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_title;
        private RJControls.RJButton rjButton_createAccount;
        private RJControls.RJButton rjButton_delete;
        private RJControls.RJButton rjButton_update;
        public System.Windows.Forms.DataGridView dataGridView_info;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_minimize;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}