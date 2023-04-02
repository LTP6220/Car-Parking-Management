namespace CarParkingManagement
{
    partial class SignInForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_signIn = new System.Windows.Forms.Button();
            this.label_signUpHere = new System.Windows.Forms.Label();
            this.label_forgotPassword = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rjButton_show = new CarParkingManagement.RJControls.RJButton();
            this.rjButton_hide = new CarParkingManagement.RJControls.RJButton();
            this.rjTextBox1 = new CarParkingManagement.RJControls.RJTextBox();
            this.rjTextBox2 = new CarParkingManagement.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.textBox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_username.Location = new System.Drawing.Point(262, 206);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(201, 13);
            this.textBox_username.TabIndex = 1;
            this.textBox_username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_username_MouseClick);
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Location = new System.Drawing.Point(262, 264);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.Size = new System.Drawing.Size(184, 13);
            this.textBox_password.TabIndex = 2;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 430);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Don\'t have an account ?";
            // 
            // button_signIn
            // 
            this.button_signIn.BackColor = System.Drawing.Color.Yellow;
            this.button_signIn.Location = new System.Drawing.Point(303, 385);
            this.button_signIn.Margin = new System.Windows.Forms.Padding(2);
            this.button_signIn.Name = "button_signIn";
            this.button_signIn.Size = new System.Drawing.Size(120, 32);
            this.button_signIn.TabIndex = 8;
            this.button_signIn.Text = "Sign In";
            this.button_signIn.UseVisualStyleBackColor = false;
            this.button_signIn.Click += new System.EventHandler(this.button_signIn_Click);
            // 
            // label_signUpHere
            // 
            this.label_signUpHere.AutoSize = true;
            this.label_signUpHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_signUpHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signUpHere.ForeColor = System.Drawing.Color.Olive;
            this.label_signUpHere.Location = new System.Drawing.Point(364, 430);
            this.label_signUpHere.Name = "label_signUpHere";
            this.label_signUpHere.Size = new System.Drawing.Size(140, 13);
            this.label_signUpHere.TabIndex = 9;
            this.label_signUpHere.Text = "CREATE AN ACCOUNT";
            this.label_signUpHere.Click += new System.EventHandler(this.label3_Click);
            this.label_signUpHere.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.label_signUpHere.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label_forgotPassword
            // 
            this.label_forgotPassword.AutoSize = true;
            this.label_forgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_forgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forgotPassword.ForeColor = System.Drawing.Color.Olive;
            this.label_forgotPassword.Location = new System.Drawing.Point(335, 303);
            this.label_forgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_forgotPassword.Name = "label_forgotPassword";
            this.label_forgotPassword.Size = new System.Drawing.Size(144, 13);
            this.label_forgotPassword.TabIndex = 10;
            this.label_forgotPassword.Text = "FORGOT PASSWORD ?";
            this.label_forgotPassword.Click += new System.EventHandler(this.label_forgotPassword_Click);
            this.label_forgotPassword.MouseLeave += new System.EventHandler(this.label_forgotPassword_MouseLeave);
            this.label_forgotPassword.MouseHover += new System.EventHandler(this.label_forgotPassword_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.pictureBox2.Image = global::CarParkingManagement.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(232, 260);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.pictureBox1.Image = global::CarParkingManagement.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(233, 202);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rjButton_show
            // 
            this.rjButton_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.rjButton_show.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.rjButton_show.BackgroundImage = global::CarParkingManagement.Properties.Resources.eye_solid;
            this.rjButton_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton_show.BorderColor = System.Drawing.Color.Black;
            this.rjButton_show.BorderRadius = 0;
            this.rjButton_show.BorderSize = 0;
            this.rjButton_show.FlatAppearance.BorderSize = 0;
            this.rjButton_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_show.ForeColor = System.Drawing.Color.White;
            this.rjButton_show.Location = new System.Drawing.Point(451, 258);
            this.rjButton_show.Name = "rjButton_show";
            this.rjButton_show.Size = new System.Drawing.Size(25, 25);
            this.rjButton_show.TabIndex = 16;
            this.rjButton_show.TextColor = System.Drawing.Color.White;
            this.rjButton_show.UseVisualStyleBackColor = false;
            this.rjButton_show.Click += new System.EventHandler(this.rjButton_show_Click);
            // 
            // rjButton_hide
            // 
            this.rjButton_hide.BackColor = System.Drawing.Color.Gainsboro;
            this.rjButton_hide.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.rjButton_hide.BackgroundImage = global::CarParkingManagement.Properties.Resources.eye_slash_solid;
            this.rjButton_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton_hide.BorderColor = System.Drawing.Color.Black;
            this.rjButton_hide.BorderRadius = 0;
            this.rjButton_hide.BorderSize = 0;
            this.rjButton_hide.FlatAppearance.BorderSize = 0;
            this.rjButton_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_hide.ForeColor = System.Drawing.Color.White;
            this.rjButton_hide.Location = new System.Drawing.Point(451, 258);
            this.rjButton_hide.Name = "rjButton_hide";
            this.rjButton_hide.Size = new System.Drawing.Size(25, 25);
            this.rjButton_hide.TabIndex = 17;
            this.rjButton_hide.TextColor = System.Drawing.Color.White;
            this.rjButton_hide.UseVisualStyleBackColor = false;
            this.rjButton_hide.Click += new System.EventHandler(this.rjButton_hide_Click);
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 3;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Enabled = false;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.Location = new System.Drawing.Point(218, 195);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(8);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(261, 33);
            this.rjTextBox1.TabIndex = 12;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.rjTextBox2.BorderColor = System.Drawing.Color.Transparent;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderRadius = 3;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Enabled = false;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox2.Location = new System.Drawing.Point(218, 253);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(5);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(8);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(261, 33);
            this.rjTextBox2.TabIndex = 13;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 496);
            this.Controls.Add(this.rjButton_show);
            this.Controls.Add(this.rjButton_hide);
            this.Controls.Add(this.label_forgotPassword);
            this.Controls.Add(this.label_signUpHere);
            this.Controls.Add(this.button_signIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.rjTextBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignInForm";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SignInForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_signIn;
        private System.Windows.Forms.Label label_signUpHere;
        private System.Windows.Forms.Label label_forgotPassword;
        private RJControls.RJTextBox rjTextBox1;
        private RJControls.RJTextBox rjTextBox2;
        private RJControls.RJButton rjButton_show;
        private RJControls.RJButton rjButton_hide;
    }
}

