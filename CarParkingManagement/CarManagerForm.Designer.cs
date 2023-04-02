namespace CarParkingManagement
{
    partial class CarManagerForm
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton_parkingSlot = new FontAwesome.Sharp.IconButton();
            this.iconButton_cars = new FontAwesome.Sharp.IconButton();
            this.iconButton_customers = new FontAwesome.Sharp.IconButton();
            this.iconButton_dashboard = new FontAwesome.Sharp.IconButton();
            this.panel_picture = new System.Windows.Forms.Panel();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.panel_display = new System.Windows.Forms.Panel();
            this.panel_desktop = new System.Windows.Forms.Panel();
            this.panel_title = new System.Windows.Forms.Panel();
            this.iconPictureBox_minimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox_exit = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox_user = new FontAwesome.Sharp.IconPictureBox();
            this.label_titleChildForm = new System.Windows.Forms.Label();
            this.rjButton1 = new CarParkingManagement.RJControls.RJButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel_menu.SuspendLayout();
            this.panel_picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            this.panel_display.SuspendLayout();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel_menu.Controls.Add(this.iconButton5);
            this.panel_menu.Controls.Add(this.iconButton_parkingSlot);
            this.panel_menu.Controls.Add(this.iconButton_cars);
            this.panel_menu.Controls.Add(this.iconButton_customers);
            this.panel_menu.Controls.Add(this.iconButton_dashboard);
            this.panel_menu.Controls.Add(this.panel_picture);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(185, 555);
            this.panel_menu.TabIndex = 0;
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 32;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 270);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(185, 40);
            this.iconButton5.TabIndex = 7;
            this.iconButton5.Text = "iconButton5";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton_parkingSlot
            // 
            this.iconButton_parkingSlot.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_parkingSlot.FlatAppearance.BorderSize = 0;
            this.iconButton_parkingSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_parkingSlot.ForeColor = System.Drawing.Color.White;
            this.iconButton_parkingSlot.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.iconButton_parkingSlot.IconColor = System.Drawing.Color.White;
            this.iconButton_parkingSlot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_parkingSlot.IconSize = 32;
            this.iconButton_parkingSlot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_parkingSlot.Location = new System.Drawing.Point(0, 230);
            this.iconButton_parkingSlot.Name = "iconButton_parkingSlot";
            this.iconButton_parkingSlot.Size = new System.Drawing.Size(185, 40);
            this.iconButton_parkingSlot.TabIndex = 6;
            this.iconButton_parkingSlot.Text = "Parking Slot";
            this.iconButton_parkingSlot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_parkingSlot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_parkingSlot.UseVisualStyleBackColor = true;
            this.iconButton_parkingSlot.Click += new System.EventHandler(this.iconButton_parkingSlot_Click);
            // 
            // iconButton_cars
            // 
            this.iconButton_cars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_cars.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_cars.FlatAppearance.BorderSize = 0;
            this.iconButton_cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_cars.ForeColor = System.Drawing.Color.White;
            this.iconButton_cars.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.iconButton_cars.IconColor = System.Drawing.Color.White;
            this.iconButton_cars.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_cars.IconSize = 32;
            this.iconButton_cars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_cars.Location = new System.Drawing.Point(0, 190);
            this.iconButton_cars.Name = "iconButton_cars";
            this.iconButton_cars.Size = new System.Drawing.Size(185, 40);
            this.iconButton_cars.TabIndex = 5;
            this.iconButton_cars.Text = "Cars";
            this.iconButton_cars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_cars.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_cars.UseVisualStyleBackColor = true;
            this.iconButton_cars.Click += new System.EventHandler(this.iconButton_cars_Click);
            // 
            // iconButton_customers
            // 
            this.iconButton_customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_customers.FlatAppearance.BorderSize = 0;
            this.iconButton_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_customers.ForeColor = System.Drawing.Color.White;
            this.iconButton_customers.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconButton_customers.IconColor = System.Drawing.Color.White;
            this.iconButton_customers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_customers.IconSize = 32;
            this.iconButton_customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_customers.Location = new System.Drawing.Point(0, 150);
            this.iconButton_customers.Name = "iconButton_customers";
            this.iconButton_customers.Size = new System.Drawing.Size(185, 40);
            this.iconButton_customers.TabIndex = 4;
            this.iconButton_customers.Text = "Custumers";
            this.iconButton_customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_customers.UseVisualStyleBackColor = true;
            this.iconButton_customers.Click += new System.EventHandler(this.iconButton_customers_Click);
            // 
            // iconButton_dashboard
            // 
            this.iconButton_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_dashboard.FlatAppearance.BorderSize = 0;
            this.iconButton_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_dashboard.ForeColor = System.Drawing.Color.White;
            this.iconButton_dashboard.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.iconButton_dashboard.IconColor = System.Drawing.Color.White;
            this.iconButton_dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_dashboard.IconSize = 32;
            this.iconButton_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_dashboard.Location = new System.Drawing.Point(0, 110);
            this.iconButton_dashboard.Name = "iconButton_dashboard";
            this.iconButton_dashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton_dashboard.Size = new System.Drawing.Size(185, 40);
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
            this.panel_picture.Size = new System.Drawing.Size(185, 110);
            this.panel_picture.TabIndex = 8;
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_home.Image = global::CarParkingManagement.Properties.Resources.Peaceful_Black__Car;
            this.pictureBox_home.Location = new System.Drawing.Point(49, 12);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(79, 77);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_home.TabIndex = 0;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // panel_display
            // 
            this.panel_display.BackgroundImage = global::CarParkingManagement.Properties.Resources.Tumblr_1;
            this.panel_display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_display.Controls.Add(this.panel_desktop);
            this.panel_display.Controls.Add(this.panel_title);
            this.panel_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_display.Location = new System.Drawing.Point(185, 0);
            this.panel_display.Name = "panel_display";
            this.panel_display.Size = new System.Drawing.Size(762, 555);
            this.panel_display.TabIndex = 1;
            this.panel_display.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_display_Paint);
            // 
            // panel_desktop
            // 
            this.panel_desktop.BackColor = System.Drawing.Color.Transparent;
            this.panel_desktop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_desktop.Location = new System.Drawing.Point(0, 75);
            this.panel_desktop.Name = "panel_desktop";
            this.panel_desktop.Size = new System.Drawing.Size(762, 480);
            this.panel_desktop.TabIndex = 2;
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.Transparent;
            this.panel_title.Controls.Add(this.iconPictureBox_minimize);
            this.panel_title.Controls.Add(this.iconPictureBox_exit);
            this.panel_title.Controls.Add(this.iconPictureBox_user);
            this.panel_title.Controls.Add(this.label_titleChildForm);
            this.panel_title.Controls.Add(this.rjButton1);
            this.panel_title.Controls.Add(this.iconCurrentChildForm);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(762, 75);
            this.panel_title.TabIndex = 3;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            // 
            // iconPictureBox_minimize
            // 
            this.iconPictureBox_minimize.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox_minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPictureBox_minimize.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_minimize.IconSize = 20;
            this.iconPictureBox_minimize.Location = new System.Drawing.Point(692, 1);
            this.iconPictureBox_minimize.Name = "iconPictureBox_minimize";
            this.iconPictureBox_minimize.Size = new System.Drawing.Size(35, 20);
            this.iconPictureBox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox_minimize.TabIndex = 9;
            this.iconPictureBox_minimize.TabStop = false;
            this.iconPictureBox_minimize.Click += new System.EventHandler(this.iconPictureBox_minimize_Click);
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
            this.iconPictureBox_exit.Location = new System.Drawing.Point(727, 1);
            this.iconPictureBox_exit.Name = "iconPictureBox_exit";
            this.iconPictureBox_exit.Size = new System.Drawing.Size(35, 20);
            this.iconPictureBox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox_exit.TabIndex = 8;
            this.iconPictureBox_exit.TabStop = false;
            this.iconPictureBox_exit.Click += new System.EventHandler(this.iconPictureBox_exit_Click);
            this.iconPictureBox_exit.MouseLeave += new System.EventHandler(this.iconPictureBox_exit_MouseLeave);
            this.iconPictureBox_exit.MouseHover += new System.EventHandler(this.iconPictureBox_exit_MouseHover);
            // 
            // iconPictureBox_user
            // 
            this.iconPictureBox_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.iconPictureBox_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox_user.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox_user.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_user.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_user.Location = new System.Drawing.Point(707, 37);
            this.iconPictureBox_user.Name = "iconPictureBox_user";
            this.iconPictureBox_user.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox_user.TabIndex = 3;
            this.iconPictureBox_user.TabStop = false;
            // 
            // label_titleChildForm
            // 
            this.label_titleChildForm.AutoSize = true;
            this.label_titleChildForm.ForeColor = System.Drawing.Color.White;
            this.label_titleChildForm.Location = new System.Drawing.Point(55, 26);
            this.label_titleChildForm.Name = "label_titleChildForm";
            this.label_titleChildForm.Size = new System.Drawing.Size(35, 13);
            this.label_titleChildForm.TabIndex = 2;
            this.label_titleChildForm.Text = "Home";
            this.label_titleChildForm.Click += new System.EventHandler(this.label_titleChildForm_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Enabled = false;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(696, 27);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(52, 49);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(21, 24);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // CarManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 555);
            this.Controls.Add(this.panel_display);
            this.Controls.Add(this.panel_menu);
            this.Name = "CarManagerForm";
            this.Text = " ";
            this.panel_menu.ResumeLayout(false);
            this.panel_picture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            this.panel_display.ResumeLayout(false);
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private RJControls.RJButton rjButton_signOut;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton_parkingSlot;
        private FontAwesome.Sharp.IconButton iconButton_cars;
        private FontAwesome.Sharp.IconButton iconButton_customers;
        private FontAwesome.Sharp.IconButton iconButton_dashboard;
        private System.Windows.Forms.Panel panel_desktop;
        private System.Windows.Forms.Panel panel_picture;
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.Panel panel_display;
        private System.Windows.Forms.Panel panel_title;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label label_titleChildForm;
        private RJControls.RJButton rjButton1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_user;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_exit;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_minimize;
    }
}