namespace CarParkingManagement
{
    partial class AccountantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantForm));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.iconButton_dashboard = new FontAwesome.Sharp.IconButton();
            this.panel_picture = new System.Windows.Forms.Panel();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.panel_display = new System.Windows.Forms.Panel();
            this.panel_info = new System.Windows.Forms.Panel();
            this.iconButton_exit = new FontAwesome.Sharp.IconButton();
            this.iconButton_signOut = new FontAwesome.Sharp.IconButton();
            this.iconButton_accountDetails = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_id = new System.Windows.Forms.Label();
            this.label_fullname = new System.Windows.Forms.Label();
            this.panel_desktop = new System.Windows.Forms.Panel();
            this.panel_title = new System.Windows.Forms.Panel();
            this.iconButton_user = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox_minimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox_exit = new FontAwesome.Sharp.IconPictureBox();
            this.label_titleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel_menu.SuspendLayout();
            this.panel_picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            this.panel_display.SuspendLayout();
            this.panel_info.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel_menu.Controls.Add(this.iconButton_dashboard);
            this.panel_menu.Controls.Add(this.panel_picture);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(199, 846);
            this.panel_menu.TabIndex = 0;
            this.panel_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_menu_Paint);
            // 
            // iconButton_dashboard
            // 
            this.iconButton_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_dashboard.FlatAppearance.BorderSize = 0;
            this.iconButton_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_dashboard.ForeColor = System.Drawing.Color.White;
            this.iconButton_dashboard.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.iconButton_dashboard.IconColor = System.Drawing.Color.White;
            this.iconButton_dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_dashboard.IconSize = 32;
            this.iconButton_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_dashboard.Location = new System.Drawing.Point(0, 214);
            this.iconButton_dashboard.Name = "iconButton_dashboard";
            this.iconButton_dashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton_dashboard.Size = new System.Drawing.Size(199, 60);
            this.iconButton_dashboard.TabIndex = 3;
            this.iconButton_dashboard.Text = "Dashboard";
            this.iconButton_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_dashboard.UseVisualStyleBackColor = true;
            this.iconButton_dashboard.Click += new System.EventHandler(this.iconButton_dashboard_Click);
            // 
            // panel_picture
            // 
            this.panel_picture.Controls.Add(this.pictureBox_home);
            this.panel_picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_picture.Location = new System.Drawing.Point(0, 0);
            this.panel_picture.Name = "panel_picture";
            this.panel_picture.Size = new System.Drawing.Size(199, 214);
            this.panel_picture.TabIndex = 8;
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_home.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_home.Image")));
            this.pictureBox_home.Location = new System.Drawing.Point(25, 44);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(151, 149);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_home.TabIndex = 0;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // panel_display
            // 
            this.panel_display.BackgroundImage = global::CarParkingManagement.Properties.Resources.CarParkingManager;
            this.panel_display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_display.Controls.Add(this.panel_info);
            this.panel_display.Controls.Add(this.panel_desktop);
            this.panel_display.Controls.Add(this.panel_title);
            this.panel_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_display.Location = new System.Drawing.Point(199, 0);
            this.panel_display.Name = "panel_display";
            this.panel_display.Size = new System.Drawing.Size(1335, 846);
            this.panel_display.TabIndex = 1;
            this.panel_display.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_display_Paint);
            // 
            // panel_info
            // 
            this.panel_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel_info.Controls.Add(this.iconButton_exit);
            this.panel_info.Controls.Add(this.iconButton_signOut);
            this.panel_info.Controls.Add(this.iconButton_accountDetails);
            this.panel_info.Controls.Add(this.panel1);
            this.panel_info.Location = new System.Drawing.Point(942, 35);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(297, 269);
            this.panel_info.TabIndex = 10;
            this.panel_info.Visible = false;
            // 
            // iconButton_exit
            // 
            this.iconButton_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_exit.FlatAppearance.BorderSize = 0;
            this.iconButton_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_exit.ForeColor = System.Drawing.Color.White;
            this.iconButton_exit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_exit.IconColor = System.Drawing.Color.Black;
            this.iconButton_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_exit.IconSize = 30;
            this.iconButton_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_exit.Location = new System.Drawing.Point(0, 179);
            this.iconButton_exit.Name = "iconButton_exit";
            this.iconButton_exit.Size = new System.Drawing.Size(297, 53);
            this.iconButton_exit.TabIndex = 2;
            this.iconButton_exit.Text = "EXIT";
            this.iconButton_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_exit.UseVisualStyleBackColor = true;
            this.iconButton_exit.Click += new System.EventHandler(this.iconButton_exit_Click);
            // 
            // iconButton_signOut
            // 
            this.iconButton_signOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_signOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_signOut.FlatAppearance.BorderSize = 0;
            this.iconButton_signOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_signOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_signOut.ForeColor = System.Drawing.Color.White;
            this.iconButton_signOut.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_signOut.IconColor = System.Drawing.Color.Black;
            this.iconButton_signOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_signOut.IconSize = 30;
            this.iconButton_signOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_signOut.Location = new System.Drawing.Point(0, 126);
            this.iconButton_signOut.Name = "iconButton_signOut";
            this.iconButton_signOut.Size = new System.Drawing.Size(297, 53);
            this.iconButton_signOut.TabIndex = 1;
            this.iconButton_signOut.Text = "SIGN OUT";
            this.iconButton_signOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_signOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_signOut.UseVisualStyleBackColor = true;
            this.iconButton_signOut.Click += new System.EventHandler(this.iconButton_signOut_Click);
            // 
            // iconButton_accountDetails
            // 
            this.iconButton_accountDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.iconButton_accountDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_accountDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_accountDetails.FlatAppearance.BorderSize = 0;
            this.iconButton_accountDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_accountDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_accountDetails.ForeColor = System.Drawing.Color.White;
            this.iconButton_accountDetails.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_accountDetails.IconColor = System.Drawing.Color.Black;
            this.iconButton_accountDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_accountDetails.IconSize = 30;
            this.iconButton_accountDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_accountDetails.Location = new System.Drawing.Point(0, 73);
            this.iconButton_accountDetails.Name = "iconButton_accountDetails";
            this.iconButton_accountDetails.Size = new System.Drawing.Size(297, 53);
            this.iconButton_accountDetails.TabIndex = 0;
            this.iconButton_accountDetails.Text = "ACCOUNT DETAILS";
            this.iconButton_accountDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_accountDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_accountDetails.UseVisualStyleBackColor = true;
            this.iconButton_accountDetails.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Controls.Add(this.label_fullname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 73);
            this.panel1.TabIndex = 3;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.White;
            this.label_id.Location = new System.Drawing.Point(126, 30);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(79, 15);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "#12345678";
            this.label_id.Click += new System.EventHandler(this.label_id_Click);
            // 
            // label_fullname
            // 
            this.label_fullname.AutoSize = true;
            this.label_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fullname.ForeColor = System.Drawing.Color.White;
            this.label_fullname.Location = new System.Drawing.Point(16, 30);
            this.label_fullname.Name = "label_fullname";
            this.label_fullname.Size = new System.Drawing.Size(130, 15);
            this.label_fullname.TabIndex = 0;
            this.label_fullname.Text = "LAM TRUONG PHU";
            // 
            // panel_desktop
            // 
            this.panel_desktop.BackColor = System.Drawing.Color.Transparent;
            this.panel_desktop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_desktop.Location = new System.Drawing.Point(0, 95);
            this.panel_desktop.Name = "panel_desktop";
            this.panel_desktop.Size = new System.Drawing.Size(1335, 826);
            this.panel_desktop.TabIndex = 2;
            this.panel_desktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_desktop_Paint);
            this.panel_desktop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_desktop_MouseClick);
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.Transparent;
            this.panel_title.Controls.Add(this.iconButton_user);
            this.panel_title.Controls.Add(this.iconPictureBox_minimize);
            this.panel_title.Controls.Add(this.iconPictureBox_exit);
            this.panel_title.Controls.Add(this.label_titleChildForm);
            this.panel_title.Controls.Add(this.iconCurrentChildForm);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1335, 95);
            this.panel_title.TabIndex = 3;
            this.panel_title.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_title_Paint);
            this.panel_title.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseClick);
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
            this.iconButton_user.Location = new System.Drawing.Point(1259, 35);
            this.iconButton_user.Name = "iconButton_user";
            this.iconButton_user.Size = new System.Drawing.Size(60, 60);
            this.iconButton_user.TabIndex = 10;
            this.iconButton_user.UseVisualStyleBackColor = false;
            this.iconButton_user.Click += new System.EventHandler(this.iconButton_user_Click);
            this.iconButton_user.MouseClick += new System.Windows.Forms.MouseEventHandler(this.iconButton_user_MouseClick);
            // 
            // iconPictureBox_minimize
            // 
            this.iconPictureBox_minimize.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox_minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPictureBox_minimize.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_minimize.IconSize = 20;
            this.iconPictureBox_minimize.Location = new System.Drawing.Point(1265, 0);
            this.iconPictureBox_minimize.Name = "iconPictureBox_minimize";
            this.iconPictureBox_minimize.Size = new System.Drawing.Size(35, 20);
            this.iconPictureBox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox_minimize.TabIndex = 9;
            this.iconPictureBox_minimize.TabStop = false;
            this.iconPictureBox_minimize.Click += new System.EventHandler(this.iconPictureBox_minimize_Click);
            this.iconPictureBox_minimize.MouseEnter += new System.EventHandler(this.iconPictureBox_minimize_MouseEnter);
            this.iconPictureBox_minimize.MouseLeave += new System.EventHandler(this.iconPictureBox_minimize_MouseLeave);
            this.iconPictureBox_minimize.MouseHover += new System.EventHandler(this.iconPictureBox_minimize_MouseHover);
            // 
            // iconPictureBox_exit
            // 
            this.iconPictureBox_exit.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconPictureBox_exit.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_exit.IconSize = 20;
            this.iconPictureBox_exit.Location = new System.Drawing.Point(1300, 0);
            this.iconPictureBox_exit.Name = "iconPictureBox_exit";
            this.iconPictureBox_exit.Size = new System.Drawing.Size(35, 20);
            this.iconPictureBox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox_exit.TabIndex = 8;
            this.iconPictureBox_exit.TabStop = false;
            this.iconPictureBox_exit.Click += new System.EventHandler(this.iconPictureBox_exit_Click);
            this.iconPictureBox_exit.MouseEnter += new System.EventHandler(this.iconPictureBox_exit_MouseEnter);
            this.iconPictureBox_exit.MouseLeave += new System.EventHandler(this.iconPictureBox_exit_MouseLeave);
            this.iconPictureBox_exit.MouseHover += new System.EventHandler(this.iconPictureBox_exit_MouseHover);
            // 
            // label_titleChildForm
            // 
            this.label_titleChildForm.AutoSize = true;
            this.label_titleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titleChildForm.ForeColor = System.Drawing.Color.White;
            this.label_titleChildForm.Location = new System.Drawing.Point(55, 35);
            this.label_titleChildForm.Name = "label_titleChildForm";
            this.label_titleChildForm.Size = new System.Drawing.Size(86, 31);
            this.label_titleChildForm.TabIndex = 2;
            this.label_titleChildForm.Text = "Home";
            this.label_titleChildForm.Click += new System.EventHandler(this.label_titleChildForm_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(21, 35);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // AccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1534, 846);
            this.Controls.Add(this.panel_display);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountantForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CarManagerForm_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_picture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            this.panel_display.ResumeLayout(false);
            this.panel_info.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private RJControls.RJButton rjButton_signOut;
        private FontAwesome.Sharp.IconButton iconButton_dashboard;
        private System.Windows.Forms.Panel panel_picture;
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.Panel panel_display;
        private System.Windows.Forms.Panel panel_title;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_exit;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_minimize;
        private FontAwesome.Sharp.IconButton iconButton_exit;
        private FontAwesome.Sharp.IconButton iconButton_signOut;
        private FontAwesome.Sharp.IconButton iconButton_accountDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_fullname;
        private FontAwesome.Sharp.IconButton iconButton_user;
        private System.Windows.Forms.Label label_id;
        public System.Windows.Forms.Panel panel_info;
        public System.Windows.Forms.Panel panel_desktop;
        public System.Windows.Forms.Label label_titleChildForm;
    }
}