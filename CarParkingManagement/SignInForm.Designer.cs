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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel_forgotPassword = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button_signIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.textBox_username.Location = new System.Drawing.Point(262, 210);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(196, 20);
            this.textBox_username.TabIndex = 1;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(262, 253);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.Size = new System.Drawing.Size(196, 20);
            this.textBox_password.TabIndex = 2;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarParkingManagement.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(232, 205);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarParkingManagement.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(232, 248);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel_forgotPassword
            // 
            this.linkLabel_forgotPassword.AutoSize = true;
            this.linkLabel_forgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_forgotPassword.Location = new System.Drawing.Point(240, 291);
            this.linkLabel_forgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_forgotPassword.Name = "linkLabel_forgotPassword";
            this.linkLabel_forgotPassword.Size = new System.Drawing.Size(86, 13);
            this.linkLabel_forgotPassword.TabIndex = 5;
            this.linkLabel_forgotPassword.TabStop = true;
            this.linkLabel_forgotPassword.Text = "Forgot Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Don\'t have an account ?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Olive;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Olive;
            this.linkLabel1.Location = new System.Drawing.Point(369, 317);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SIGN UP HERE";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.MouseLeave += new System.EventHandler(this.linkLabel1_MouseLeave);
            this.linkLabel1.MouseHover += new System.EventHandler(this.linkLabel1_MouseHover);
            // 
            // button_signIn
            // 
            this.button_signIn.BackColor = System.Drawing.Color.Yellow;
            this.button_signIn.Location = new System.Drawing.Point(298, 350);
            this.button_signIn.Margin = new System.Windows.Forms.Padding(2);
            this.button_signIn.Name = "button_signIn";
            this.button_signIn.Size = new System.Drawing.Size(120, 32);
            this.button_signIn.TabIndex = 8;
            this.button_signIn.Text = "Sign In";
            this.button_signIn.UseVisualStyleBackColor = false;
            this.button_signIn.Click += new System.EventHandler(this.button_signIn_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 496);
            this.Controls.Add(this.button_signIn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel_forgotPassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignInForm";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel_forgotPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_signIn;
    }
}

