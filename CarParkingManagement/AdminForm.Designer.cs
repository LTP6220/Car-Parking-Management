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
            this.dataGridView_info = new System.Windows.Forms.DataGridView();
            this.panel_title = new System.Windows.Forms.Panel();
            this.iconButton_user = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox_minimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox_exit = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.rjButton_update = new CarParkingManagement.RJControls.RJButton();
            this.rjButton_delete = new CarParkingManagement.RJControls.RJButton();
            this.rjButton_createAccount = new CarParkingManagement.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).BeginInit();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_info
            // 
            this.dataGridView_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_info.Location = new System.Drawing.Point(0, 96);
            this.dataGridView_info.Name = "dataGridView_info";
            this.dataGridView_info.Size = new System.Drawing.Size(984, 321);
            this.dataGridView_info.TabIndex = 0;
            this.dataGridView_info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_info_CellClick);
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.Transparent;
            this.panel_title.Controls.Add(this.iconButton_user);
            this.panel_title.Controls.Add(this.iconPictureBox_minimize);
            this.panel_title.Controls.Add(this.iconPictureBox_exit);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(984, 95);
            this.panel_title.TabIndex = 4;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            // 
            // iconButton_user
            // 
            this.iconButton_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.iconButton_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_user.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton_user.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton_user.IconColor = System.Drawing.Color.White;
            this.iconButton_user.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton_user.IconSize = 35;
            this.iconButton_user.Location = new System.Drawing.Point(1105, 35);
            this.iconButton_user.Name = "iconButton_user";
            this.iconButton_user.Size = new System.Drawing.Size(60, 60);
            this.iconButton_user.TabIndex = 10;
            this.iconButton_user.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox_minimize
            // 
            this.iconPictureBox_minimize.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox_minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPictureBox_minimize.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_minimize.IconSize = 20;
            this.iconPictureBox_minimize.Location = new System.Drawing.Point(1300, 1);
            this.iconPictureBox_minimize.Name = "iconPictureBox_minimize";
            this.iconPictureBox_minimize.Size = new System.Drawing.Size(35, 20);
            this.iconPictureBox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox_minimize.TabIndex = 9;
            this.iconPictureBox_minimize.TabStop = false;
            // 
            // iconPictureBox_exit
            // 
            this.iconPictureBox_exit.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconPictureBox_exit.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_exit.IconSize = 20;
            this.iconPictureBox_exit.Location = new System.Drawing.Point(1335, 1);
            this.iconPictureBox_exit.Name = "iconPictureBox_exit";
            this.iconPictureBox_exit.Size = new System.Drawing.Size(35, 20);
            this.iconPictureBox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox_exit.TabIndex = 8;
            this.iconPictureBox_exit.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(378, 443);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Refresh";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // rjButton_update
            // 
            this.rjButton_update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.rjButton_update.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.rjButton_update.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton_update.BorderRadius = 20;
            this.rjButton_update.BorderSize = 0;
            this.rjButton_update.FlatAppearance.BorderSize = 0;
            this.rjButton_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_update.ForeColor = System.Drawing.Color.White;
            this.rjButton_update.Location = new System.Drawing.Point(483, 434);
            this.rjButton_update.Name = "rjButton_update";
            this.rjButton_update.Size = new System.Drawing.Size(150, 40);
            this.rjButton_update.TabIndex = 7;
            this.rjButton_update.Text = "Update";
            this.rjButton_update.TextColor = System.Drawing.Color.White;
            this.rjButton_update.UseVisualStyleBackColor = false;
            this.rjButton_update.Click += new System.EventHandler(this.rjButton_update_Click);
            // 
            // rjButton_delete
            // 
            this.rjButton_delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.rjButton_delete.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.rjButton_delete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton_delete.BorderRadius = 20;
            this.rjButton_delete.BorderSize = 0;
            this.rjButton_delete.FlatAppearance.BorderSize = 0;
            this.rjButton_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_delete.ForeColor = System.Drawing.Color.White;
            this.rjButton_delete.Location = new System.Drawing.Point(639, 434);
            this.rjButton_delete.Name = "rjButton_delete";
            this.rjButton_delete.Size = new System.Drawing.Size(150, 40);
            this.rjButton_delete.TabIndex = 6;
            this.rjButton_delete.Text = "Delete";
            this.rjButton_delete.TextColor = System.Drawing.Color.White;
            this.rjButton_delete.UseVisualStyleBackColor = false;
            this.rjButton_delete.Click += new System.EventHandler(this.rjButton_delete_Click);
            // 
            // rjButton_createAccount
            // 
            this.rjButton_createAccount.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.rjButton_createAccount.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.rjButton_createAccount.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton_createAccount.BorderRadius = 20;
            this.rjButton_createAccount.BorderSize = 0;
            this.rjButton_createAccount.FlatAppearance.BorderSize = 0;
            this.rjButton_createAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_createAccount.ForeColor = System.Drawing.Color.White;
            this.rjButton_createAccount.Location = new System.Drawing.Point(795, 434);
            this.rjButton_createAccount.Name = "rjButton_createAccount";
            this.rjButton_createAccount.Size = new System.Drawing.Size(150, 40);
            this.rjButton_createAccount.TabIndex = 5;
            this.rjButton_createAccount.Text = "Create Account";
            this.rjButton_createAccount.TextColor = System.Drawing.Color.White;
            this.rjButton_createAccount.UseVisualStyleBackColor = false;
            this.rjButton_createAccount.Click += new System.EventHandler(this.rjButton_createAccount_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(984, 741);
            this.Controls.Add(this.rjButton_update);
            this.Controls.Add(this.rjButton_delete);
            this.Controls.Add(this.rjButton_createAccount);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dataGridView_info);
            this.Name = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).EndInit();
            this.panel_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel_title;
        private FontAwesome.Sharp.IconButton iconButton_user;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_minimize;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_exit;
        private RJControls.RJButton rjButton_createAccount;
        private RJControls.RJButton rjButton_delete;
        private RJControls.RJButton rjButton_update;
        public System.Windows.Forms.DataGridView dataGridView_info;
    }
}