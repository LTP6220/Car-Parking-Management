namespace CarParkingManagement
{
    partial class SignUpForm
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
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_fullName = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_confirmPassword = new System.Windows.Forms.TextBox();
            this.label_fullname = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_confirmPassword = new System.Windows.Forms.Label();
            this.label_checkEmail = new System.Windows.Forms.Label();
            this.label_checkUsername = new System.Windows.Forms.Label();
            this.label_checkLong = new System.Windows.Forms.Label();
            this.label_checkLetter = new System.Windows.Forms.Label();
            this.button_signup = new System.Windows.Forms.Button();
            this.label_checkUsername2 = new System.Windows.Forms.Label();
            this.label_toSignInForm = new System.Windows.Forms.Label();
            this.label_position = new System.Windows.Forms.Label();
            this.comboBox_position = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(100, 190);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(350, 20);
            this.textBox_email.TabIndex = 1;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(97, 173);
            this.label_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(39, 15);
            this.label_email.TabIndex = 6;
            this.label_email.Text = "Email";
            // 
            // textBox_fullName
            // 
            this.textBox_fullName.Location = new System.Drawing.Point(100, 90);
            this.textBox_fullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_fullName.Name = "textBox_fullName";
            this.textBox_fullName.Size = new System.Drawing.Size(350, 20);
            this.textBox_fullName.TabIndex = 7;
            this.textBox_fullName.TextChanged += new System.EventHandler(this.textBox_fullName_TextChanged);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(100, 260);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(350, 20);
            this.textBox_username.TabIndex = 8;
            this.textBox_username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_username_MouseClick);
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(100, 330);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.Size = new System.Drawing.Size(350, 20);
            this.textBox_password.TabIndex = 9;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // textBox_confirmPassword
            // 
            this.textBox_confirmPassword.Location = new System.Drawing.Point(100, 400);
            this.textBox_confirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_confirmPassword.Name = "textBox_confirmPassword";
            this.textBox_confirmPassword.PasswordChar = '•';
            this.textBox_confirmPassword.Size = new System.Drawing.Size(350, 20);
            this.textBox_confirmPassword.TabIndex = 10;
            this.textBox_confirmPassword.TextChanged += new System.EventHandler(this.textBox_confirmPassword_TextChanged);
            // 
            // label_fullname
            // 
            this.label_fullname.AutoSize = true;
            this.label_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fullname.Location = new System.Drawing.Point(98, 73);
            this.label_fullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_fullname.Name = "label_fullname";
            this.label_fullname.Size = new System.Drawing.Size(64, 15);
            this.label_fullname.TabIndex = 11;
            this.label_fullname.Text = "Full Name";
            this.label_fullname.Click += new System.EventHandler(this.label_fullname_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(97, 243);
            this.label_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(65, 15);
            this.label_username.TabIndex = 12;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(97, 312);
            this.label_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(61, 15);
            this.label_password.TabIndex = 13;
            this.label_password.Text = "Password";
            // 
            // label_confirmPassword
            // 
            this.label_confirmPassword.AutoSize = true;
            this.label_confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_confirmPassword.Location = new System.Drawing.Point(97, 383);
            this.label_confirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_confirmPassword.Name = "label_confirmPassword";
            this.label_confirmPassword.Size = new System.Drawing.Size(107, 15);
            this.label_confirmPassword.TabIndex = 14;
            this.label_confirmPassword.Text = "Confirm Password";
            this.label_confirmPassword.Click += new System.EventHandler(this.label_confirmPassword_Click);
            // 
            // label_checkEmail
            // 
            this.label_checkEmail.AutoSize = true;
            this.label_checkEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkEmail.Location = new System.Drawing.Point(212, 212);
            this.label_checkEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_checkEmail.Name = "label_checkEmail";
            this.label_checkEmail.Size = new System.Drawing.Size(118, 15);
            this.label_checkEmail.TabIndex = 15;
            this.label_checkEmail.Text = "Email already in use";
            this.label_checkEmail.Click += new System.EventHandler(this.label_checkEmail_Click);
            // 
            // label_checkUsername
            // 
            this.label_checkUsername.AutoSize = true;
            this.label_checkUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkUsername.Location = new System.Drawing.Point(199, 282);
            this.label_checkUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_checkUsername.Name = "label_checkUsername";
            this.label_checkUsername.Size = new System.Drawing.Size(144, 15);
            this.label_checkUsername.TabIndex = 16;
            this.label_checkUsername.Text = "Username already in use";
            // 
            // label_checkLong
            // 
            this.label_checkLong.AutoSize = true;
            this.label_checkLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkLong.Location = new System.Drawing.Point(173, 351);
            this.label_checkLong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_checkLong.Name = "label_checkLong";
            this.label_checkLong.Size = new System.Drawing.Size(215, 15);
            this.label_checkLong.TabIndex = 17;
            this.label_checkLong.Text = "Password is at least 8 characters long.";
            this.label_checkLong.Click += new System.EventHandler(this.label_checkLong_Click);
            // 
            // label_checkLetter
            // 
            this.label_checkLetter.AutoSize = true;
            this.label_checkLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkLetter.Location = new System.Drawing.Point(142, 351);
            this.label_checkLetter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_checkLetter.Name = "label_checkLetter";
            this.label_checkLetter.Size = new System.Drawing.Size(266, 15);
            this.label_checkLetter.TabIndex = 18;
            this.label_checkLetter.Text = "Password contains at least one letter or number";
            // 
            // button_signup
            // 
            this.button_signup.BackColor = System.Drawing.Color.Yellow;
            this.button_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signup.Location = new System.Drawing.Point(145, 470);
            this.button_signup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(260, 63);
            this.button_signup.TabIndex = 19;
            this.button_signup.Text = "Create Account";
            this.button_signup.UseVisualStyleBackColor = false;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            this.button_signup.MouseLeave += new System.EventHandler(this.button_signup_MouseLeave);
            this.button_signup.MouseHover += new System.EventHandler(this.button_signup_MouseHover);
            // 
            // label_checkUsername2
            // 
            this.label_checkUsername2.AutoSize = true;
            this.label_checkUsername2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkUsername2.Location = new System.Drawing.Point(174, 351);
            this.label_checkUsername2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_checkUsername2.Name = "label_checkUsername2";
            this.label_checkUsername2.Size = new System.Drawing.Size(213, 15);
            this.label_checkUsername2.TabIndex = 20;
            this.label_checkUsername2.Text = "Only letters and numbers are allowed.";
            this.label_checkUsername2.Click += new System.EventHandler(this.label_checkUsername2_Click);
            // 
            // label_toSignInForm
            // 
            this.label_toSignInForm.AutoSize = true;
            this.label_toSignInForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_toSignInForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_toSignInForm.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_toSignInForm.Location = new System.Drawing.Point(308, 551);
            this.label_toSignInForm.Name = "label_toSignInForm";
            this.label_toSignInForm.Size = new System.Drawing.Size(58, 15);
            this.label_toSignInForm.TabIndex = 21;
            this.label_toSignInForm.Text = "SIGN IN";
            this.label_toSignInForm.Click += new System.EventHandler(this.label2_Click);
            this.label_toSignInForm.MouseLeave += new System.EventHandler(this.label_toSignInForm_MouseLeave);
            this.label_toSignInForm.MouseHover += new System.EventHandler(this.label_toSignInForm_MouseHover);
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_position.Location = new System.Drawing.Point(97, 122);
            this.label_position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(51, 15);
            this.label_position.TabIndex = 23;
            this.label_position.Text = "Position";
            this.label_position.Click += new System.EventHandler(this.label_position_Click);
            // 
            // comboBox_position
            // 
            this.comboBox_position.FormattingEnabled = true;
            this.comboBox_position.Items.AddRange(new object[] {
            "Car Manager",
            "Accountant",
            "Cashier",
            ""});
            this.comboBox_position.Location = new System.Drawing.Point(100, 140);
            this.comboBox_position.Name = "comboBox_position";
            this.comboBox_position.Size = new System.Drawing.Size(350, 21);
            this.comboBox_position.TabIndex = 24;
            this.comboBox_position.SelectedIndexChanged += new System.EventHandler(this.comboBox_position_SelectedIndexChanged);
            this.comboBox_position.TextChanged += new System.EventHandler(this.comboBox_position_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(174, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Already have an account ?";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CarParkingManagement.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(37, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarParkingManagement.Properties.Resources.bg_image;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1000, 740);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_checkEmail);
            this.panel1.Controls.Add(this.label_checkUsername);
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Controls.Add(this.label_checkLong);
            this.panel1.Controls.Add(this.label_checkLetter);
            this.panel1.Controls.Add(this.label_checkUsername2);
            this.panel1.Controls.Add(this.textBox_username);
            this.panel1.Controls.Add(this.label_toSignInForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_position);
            this.panel1.Controls.Add(this.textBox_fullName);
            this.panel1.Controls.Add(this.label_position);
            this.panel1.Controls.Add(this.label_password);
            this.panel1.Controls.Add(this.label_confirmPassword);
            this.panel1.Controls.Add(this.button_signup);
            this.panel1.Controls.Add(this.textBox_password);
            this.panel1.Controls.Add(this.textBox_email);
            this.panel1.Controls.Add(this.label_fullname);
            this.panel1.Controls.Add(this.textBox_confirmPassword);
            this.panel1.Controls.Add(this.label_email);
            this.panel1.Location = new System.Drawing.Point(225, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 600);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 422);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Password does not match";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 701);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_fullName;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_confirmPassword;
        private System.Windows.Forms.Label label_fullname;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_confirmPassword;
        private System.Windows.Forms.Label label_checkEmail;
        private System.Windows.Forms.Label label_checkUsername;
        private System.Windows.Forms.Label label_checkLong;
        private System.Windows.Forms.Label label_checkLetter;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.Label label_checkUsername2;
        private System.Windows.Forms.Label label_toSignInForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.ComboBox comboBox_position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}