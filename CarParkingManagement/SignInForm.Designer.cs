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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_signUpHere = new System.Windows.Forms.Label();
            this.label_forgotPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(618, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(524, 404);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(388, 31);
            this.textBox_username.TabIndex = 1;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(524, 487);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.Size = new System.Drawing.Size(388, 31);
            this.textBox_password.TabIndex = 2;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 826);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Don\'t have an account ?";
            // 
            // button_signIn
            // 
            this.button_signIn.BackColor = System.Drawing.Color.Yellow;
            this.button_signIn.Location = new System.Drawing.Point(606, 741);
            this.button_signIn.Margin = new System.Windows.Forms.Padding(4);
            this.button_signIn.Name = "button_signIn";
            this.button_signIn.Size = new System.Drawing.Size(240, 62);
            this.button_signIn.TabIndex = 8;
            this.button_signIn.Text = "Sign In";
            this.button_signIn.UseVisualStyleBackColor = false;
            this.button_signIn.Click += new System.EventHandler(this.button_signIn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarParkingManagement.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(464, 477);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarParkingManagement.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(464, 394);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label_signUpHere
            // 
            this.label_signUpHere.AutoSize = true;
            this.label_signUpHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_signUpHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signUpHere.ForeColor = System.Drawing.Color.Olive;
            this.label_signUpHere.Location = new System.Drawing.Point(729, 826);
            this.label_signUpHere.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_signUpHere.Name = "label_signUpHere";
            this.label_signUpHere.Size = new System.Drawing.Size(183, 26);
            this.label_signUpHere.TabIndex = 9;
            this.label_signUpHere.Text = "SIGN UP HERE";
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
            this.label_forgotPassword.Location = new System.Drawing.Point(475, 558);
            this.label_forgotPassword.Name = "label_forgotPassword";
            this.label_forgotPassword.Size = new System.Drawing.Size(244, 25);
            this.label_forgotPassword.TabIndex = 10;
            this.label_forgotPassword.Text = "FORGOT PASSWORD";
            this.label_forgotPassword.Click += new System.EventHandler(this.label_forgotPassword_Click);
            this.label_forgotPassword.MouseLeave += new System.EventHandler(this.label_forgotPassword_MouseLeave);
            this.label_forgotPassword.MouseHover += new System.EventHandler(this.label_forgotPassword_MouseHover);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 954);
            this.Controls.Add(this.label_forgotPassword);
            this.Controls.Add(this.label_signUpHere);
            this.Controls.Add(this.button_signIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignInForm";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignInForm_Load);
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
    }
}

