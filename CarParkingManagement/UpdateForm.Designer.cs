namespace CarParkingManagement
{
    partial class UpdateForm
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
            this.comboBox_position = new System.Windows.Forms.ComboBox();
            this.label_position = new System.Windows.Forms.Label();
            this.label_checkUsername2 = new System.Windows.Forms.Label();
            this.button_signup = new System.Windows.Forms.Button();
            this.label_checkUsername = new System.Windows.Forms.Label();
            this.label_checkEmail = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_fullname = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_fullName = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_checkLong = new System.Windows.Forms.Label();
            this.label_checkLetter = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_position
            // 
            this.comboBox_position.FormattingEnabled = true;
            this.comboBox_position.Items.AddRange(new object[] {
            "Car Manager",
            "Accountant",
            "Cashier",
            ""});
            this.comboBox_position.Location = new System.Drawing.Point(311, 233);
            this.comboBox_position.Name = "comboBox_position";
            this.comboBox_position.Size = new System.Drawing.Size(314, 21);
            this.comboBox_position.TabIndex = 44;
            this.comboBox_position.SelectedIndexChanged += new System.EventHandler(this.comboBox_position_SelectedIndexChanged);
            this.comboBox_position.TextChanged += new System.EventHandler(this.comboBox_position_TextChanged);
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_position.Location = new System.Drawing.Point(134, 233);
            this.label_position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(51, 15);
            this.label_position.TabIndex = 43;
            this.label_position.Text = "Position";
            // 
            // label_checkUsername2
            // 
            this.label_checkUsername2.AutoSize = true;
            this.label_checkUsername2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkUsername2.Location = new System.Drawing.Point(305, 307);
            this.label_checkUsername2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_checkUsername2.Name = "label_checkUsername2";
            this.label_checkUsername2.Size = new System.Drawing.Size(213, 15);
            this.label_checkUsername2.TabIndex = 41;
            this.label_checkUsername2.Text = "Only letters and numbers are allowed.";
            // 
            // button_signup
            // 
            this.button_signup.BackColor = System.Drawing.Color.Yellow;
            this.button_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signup.Location = new System.Drawing.Point(258, 496);
            this.button_signup.Margin = new System.Windows.Forms.Padding(2);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(260, 63);
            this.button_signup.TabIndex = 40;
            this.button_signup.Text = "Update";
            this.button_signup.UseVisualStyleBackColor = false;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            this.button_signup.MouseHover += new System.EventHandler(this.button_signup_MouseHover);
            // 
            // label_checkUsername
            // 
            this.label_checkUsername.AutoSize = true;
            this.label_checkUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkUsername.Location = new System.Drawing.Point(305, 307);
            this.label_checkUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_checkUsername.Name = "label_checkUsername";
            this.label_checkUsername.Size = new System.Drawing.Size(144, 15);
            this.label_checkUsername.TabIndex = 37;
            this.label_checkUsername.Text = "Username already in use";
            // 
            // label_checkEmail
            // 
            this.label_checkEmail.AutoSize = true;
            this.label_checkEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkEmail.Location = new System.Drawing.Point(308, 154);
            this.label_checkEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_checkEmail.Name = "label_checkEmail";
            this.label_checkEmail.Size = new System.Drawing.Size(118, 15);
            this.label_checkEmail.TabIndex = 36;
            this.label_checkEmail.Text = "Email already in use";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(135, 276);
            this.label_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(65, 15);
            this.label_username.TabIndex = 33;
            this.label_username.Text = "Username";
            // 
            // label_fullname
            // 
            this.label_fullname.AutoSize = true;
            this.label_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fullname.Location = new System.Drawing.Point(135, 188);
            this.label_fullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_fullname.Name = "label_fullname";
            this.label_fullname.Size = new System.Drawing.Size(64, 15);
            this.label_fullname.TabIndex = 32;
            this.label_fullname.Text = "Full Name";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(311, 276);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(314, 20);
            this.textBox_username.TabIndex = 29;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // textBox_fullName
            // 
            this.textBox_fullName.Location = new System.Drawing.Point(311, 183);
            this.textBox_fullName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_fullName.Name = "textBox_fullName";
            this.textBox_fullName.Size = new System.Drawing.Size(314, 20);
            this.textBox_fullName.TabIndex = 28;
            this.textBox_fullName.TextChanged += new System.EventHandler(this.textBox_fullName_TextChanged);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(138, 130);
            this.label_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(39, 15);
            this.label_email.TabIndex = 27;
            this.label_email.Text = "Email";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(311, 123);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(314, 20);
            this.textBox_email.TabIndex = 26;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, -42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Sign Up";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CarParkingManagement.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(60, -58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(135, 355);
            this.label_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(61, 15);
            this.label_password.TabIndex = 34;
            this.label_password.Text = "Password";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(311, 350);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.Size = new System.Drawing.Size(314, 20);
            this.textBox_password.TabIndex = 30;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // label_checkLong
            // 
            this.label_checkLong.AutoSize = true;
            this.label_checkLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkLong.Location = new System.Drawing.Point(263, 405);
            this.label_checkLong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_checkLong.Name = "label_checkLong";
            this.label_checkLong.Size = new System.Drawing.Size(215, 15);
            this.label_checkLong.TabIndex = 38;
            this.label_checkLong.Text = "Password is at least 8 characters long.";
            // 
            // label_checkLetter
            // 
            this.label_checkLetter.AutoSize = true;
            this.label_checkLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkLetter.Location = new System.Drawing.Point(252, 442);
            this.label_checkLetter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_checkLetter.Name = "label_checkLetter";
            this.label_checkLetter.Size = new System.Drawing.Size(266, 15);
            this.label_checkLetter.TabIndex = 39;
            this.label_checkLetter.Text = "Password contains at least one letter or number";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(138, 87);
            this.label_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(17, 15);
            this.label_id.TabIndex = 45;
            this.label_id.Text = "Id";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(311, 82);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(314, 20);
            this.textBox_id.TabIndex = 46;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 640);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.comboBox_position);
            this.Controls.Add(this.label_position);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_checkUsername2);
            this.Controls.Add(this.label_checkLetter);
            this.Controls.Add(this.label_checkLong);
            this.Controls.Add(this.label_checkUsername);
            this.Controls.Add(this.label_checkEmail);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_fullname);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_fullName);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_signup);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_position;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_checkUsername2;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.Label label_checkUsername;
        private System.Windows.Forms.Label label_checkEmail;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_fullname;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_fullName;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_checkLong;
        private System.Windows.Forms.Label label_checkLetter;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
    }
}