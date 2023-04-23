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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
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
            this.label_checkUsername2 = new System.Windows.Forms.Label();
            this.label_position = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.panel_title = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox_minimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox_exit = new FontAwesome.Sharp.IconPictureBox();
            this.button_signup = new CarParkingManagement.RJControls.RJButton();
            this.rjTextBox_search = new CarParkingManagement.RJControls.RJTextBox();
            this.rjTextBox1 = new CarParkingManagement.RJControls.RJTextBox();
            this.rjTextBox2 = new CarParkingManagement.RJControls.RJTextBox();
            this.rjTextBox3 = new CarParkingManagement.RJControls.RJTextBox();
            this.rjTextBox4 = new CarParkingManagement.RJControls.RJTextBox();
            this.rjButton1 = new CarParkingManagement.RJControls.RJButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.comboBox_position = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.White;
            this.label_email.Location = new System.Drawing.Point(77, 128);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(45, 18);
            this.label_email.TabIndex = 6;
            this.label_email.Text = "Email";
            // 
            // textBox_fullName
            // 
            this.textBox_fullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.textBox_fullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_fullName.ForeColor = System.Drawing.Color.White;
            this.textBox_fullName.Location = new System.Drawing.Point(89, 236);
            this.textBox_fullName.Multiline = true;
            this.textBox_fullName.Name = "textBox_fullName";
            this.textBox_fullName.Size = new System.Drawing.Size(321, 25);
            this.textBox_fullName.TabIndex = 7;
            this.textBox_fullName.TextChanged += new System.EventHandler(this.textBox_fullName_TextChanged);
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.textBox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_username.ForeColor = System.Drawing.Color.White;
            this.textBox_username.Location = new System.Drawing.Point(90, 376);
            this.textBox_username.Multiline = true;
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(320, 25);
            this.textBox_username.TabIndex = 8;
            this.textBox_username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_username_MouseClick);
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.ForeColor = System.Drawing.Color.White;
            this.textBox_password.Location = new System.Drawing.Point(90, 457);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.Size = new System.Drawing.Size(320, 25);
            this.textBox_password.TabIndex = 9;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // textBox_confirmPassword
            // 
            this.textBox_confirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.textBox_confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_confirmPassword.ForeColor = System.Drawing.Color.White;
            this.textBox_confirmPassword.Location = new System.Drawing.Point(91, 552);
            this.textBox_confirmPassword.Multiline = true;
            this.textBox_confirmPassword.Name = "textBox_confirmPassword";
            this.textBox_confirmPassword.PasswordChar = '•';
            this.textBox_confirmPassword.Size = new System.Drawing.Size(319, 25);
            this.textBox_confirmPassword.TabIndex = 10;
            this.textBox_confirmPassword.TextChanged += new System.EventHandler(this.textBox_confirmPassword_TextChanged);
            // 
            // label_fullname
            // 
            this.label_fullname.AutoSize = true;
            this.label_fullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.label_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fullname.ForeColor = System.Drawing.Color.White;
            this.label_fullname.Location = new System.Drawing.Point(77, 211);
            this.label_fullname.Name = "label_fullname";
            this.label_fullname.Size = new System.Drawing.Size(75, 18);
            this.label_fullname.TabIndex = 11;
            this.label_fullname.Text = "Full Name";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(77, 350);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(77, 18);
            this.label_username.TabIndex = 12;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(77, 431);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(75, 18);
            this.label_password.TabIndex = 13;
            this.label_password.Text = "Password";
            // 
            // label_confirmPassword
            // 
            this.label_confirmPassword.AutoSize = true;
            this.label_confirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.label_confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_confirmPassword.ForeColor = System.Drawing.Color.White;
            this.label_confirmPassword.Location = new System.Drawing.Point(79, 526);
            this.label_confirmPassword.Name = "label_confirmPassword";
            this.label_confirmPassword.Size = new System.Drawing.Size(132, 18);
            this.label_confirmPassword.TabIndex = 14;
            this.label_confirmPassword.Text = "Confirm Password";
            // 
            // label_checkEmail
            // 
            this.label_checkEmail.AutoSize = true;
            this.label_checkEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.label_checkEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkEmail.ForeColor = System.Drawing.Color.White;
            this.label_checkEmail.Location = new System.Drawing.Point(86, 189);
            this.label_checkEmail.Name = "label_checkEmail";
            this.label_checkEmail.Size = new System.Drawing.Size(118, 15);
            this.label_checkEmail.TabIndex = 15;
            this.label_checkEmail.Text = "Email already in use";
            // 
            // label_checkUsername
            // 
            this.label_checkUsername.AutoSize = true;
            this.label_checkUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkUsername.Location = new System.Drawing.Point(87, 408);
            this.label_checkUsername.Name = "label_checkUsername";
            this.label_checkUsername.Size = new System.Drawing.Size(144, 15);
            this.label_checkUsername.TabIndex = 16;
            this.label_checkUsername.Text = "Username already in use";
            // 
            // label_checkLong
            // 
            this.label_checkLong.AutoSize = true;
            this.label_checkLong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.label_checkLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkLong.ForeColor = System.Drawing.Color.White;
            this.label_checkLong.Location = new System.Drawing.Point(88, 488);
            this.label_checkLong.Name = "label_checkLong";
            this.label_checkLong.Size = new System.Drawing.Size(215, 15);
            this.label_checkLong.TabIndex = 17;
            this.label_checkLong.Text = "Password is at least 8 characters long.";
            this.label_checkLong.Click += new System.EventHandler(this.label_checkLong_Click);
            // 
            // label_checkLetter
            // 
            this.label_checkLetter.AutoSize = true;
            this.label_checkLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.label_checkLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkLetter.ForeColor = System.Drawing.Color.White;
            this.label_checkLetter.Location = new System.Drawing.Point(88, 505);
            this.label_checkLetter.Name = "label_checkLetter";
            this.label_checkLetter.Size = new System.Drawing.Size(266, 15);
            this.label_checkLetter.TabIndex = 18;
            this.label_checkLetter.Text = "Password contains at least one letter or number";
            // 
            // label_checkUsername2
            // 
            this.label_checkUsername2.AutoSize = true;
            this.label_checkUsername2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.label_checkUsername2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkUsername2.ForeColor = System.Drawing.Color.White;
            this.label_checkUsername2.Location = new System.Drawing.Point(86, 408);
            this.label_checkUsername2.Name = "label_checkUsername2";
            this.label_checkUsername2.Size = new System.Drawing.Size(213, 15);
            this.label_checkUsername2.TabIndex = 20;
            this.label_checkUsername2.Text = "Only letters and numbers are allowed.";
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.label_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_position.ForeColor = System.Drawing.Color.White;
            this.label_position.Location = new System.Drawing.Point(76, 286);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(62, 18);
            this.label_position.TabIndex = 23;
            this.label_position.Text = "Position";
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_email.ForeColor = System.Drawing.Color.White;
            this.textBox_email.Location = new System.Drawing.Point(91, 154);
            this.textBox_email.Multiline = true;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(319, 24);
            this.textBox_email.TabIndex = 65;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged_1);
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.panel_title.Controls.Add(this.label2);
            this.panel_title.Controls.Add(this.iconPictureBox_minimize);
            this.panel_title.Controls.Add(this.iconPictureBox_exit);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(500, 97);
            this.panel_title.TabIndex = 66;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            this.panel_title.MouseEnter += new System.EventHandler(this.panel_title_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "CREATE ACCOUNT";
            // 
            // iconPictureBox_minimize
            // 
            this.iconPictureBox_minimize.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox_minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPictureBox_minimize.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_minimize.IconSize = 20;
            this.iconPictureBox_minimize.Location = new System.Drawing.Point(431, 0);
            this.iconPictureBox_minimize.Name = "iconPictureBox_minimize";
            this.iconPictureBox_minimize.Size = new System.Drawing.Size(35, 20);
            this.iconPictureBox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox_minimize.TabIndex = 13;
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
            this.iconPictureBox_exit.Location = new System.Drawing.Point(465, 0);
            this.iconPictureBox_exit.Name = "iconPictureBox_exit";
            this.iconPictureBox_exit.Size = new System.Drawing.Size(35, 20);
            this.iconPictureBox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox_exit.TabIndex = 12;
            this.iconPictureBox_exit.TabStop = false;
            this.iconPictureBox_exit.Click += new System.EventHandler(this.iconPictureBox_exit_Click);
            this.iconPictureBox_exit.MouseEnter += new System.EventHandler(this.iconPictureBox_exit_MouseEnter);
            this.iconPictureBox_exit.MouseLeave += new System.EventHandler(this.iconPictureBox_exit_MouseLeave);
            // 
            // button_signup
            // 
            this.button_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.button_signup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.button_signup.BorderColor = System.Drawing.Color.White;
            this.button_signup.BorderRadius = 5;
            this.button_signup.BorderSize = 1;
            this.button_signup.FlatAppearance.BorderSize = 0;
            this.button_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signup.ForeColor = System.Drawing.Color.White;
            this.button_signup.Location = new System.Drawing.Point(150, 601);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(204, 40);
            this.button_signup.TabIndex = 67;
            this.button_signup.Text = "CREATE ACCOUNT";
            this.button_signup.TextColor = System.Drawing.Color.White;
            this.button_signup.UseVisualStyleBackColor = false;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click_1);
            // 
            // rjTextBox_search
            // 
            this.rjTextBox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.rjTextBox_search.BorderColor = System.Drawing.Color.White;
            this.rjTextBox_search.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_search.BorderRadius = 10;
            this.rjTextBox_search.BorderSize = 1;
            this.rjTextBox_search.Enabled = false;
            this.rjTextBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_search.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox_search.Location = new System.Drawing.Point(79, 146);
            this.rjTextBox_search.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox_search.Multiline = false;
            this.rjTextBox_search.Name = "rjTextBox_search";
            this.rjTextBox_search.Padding = new System.Windows.Forms.Padding(10);
            this.rjTextBox_search.PasswordChar = false;
            this.rjTextBox_search.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_search.PlaceholderText = "";
            this.rjTextBox_search.Size = new System.Drawing.Size(341, 37);
            this.rjTextBox_search.TabIndex = 59;
            this.rjTextBox_search.Texts = "";
            this.rjTextBox_search.UnderlinedStyle = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.White;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 10;
            this.rjTextBox1.BorderSize = 1;
            this.rjTextBox1.Enabled = false;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.Location = new System.Drawing.Point(80, 229);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(340, 37);
            this.rjTextBox1.TabIndex = 60;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.rjTextBox2.BorderColor = System.Drawing.Color.White;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderRadius = 10;
            this.rjTextBox2.BorderSize = 1;
            this.rjTextBox2.Enabled = false;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox2.Location = new System.Drawing.Point(80, 369);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(340, 37);
            this.rjTextBox2.TabIndex = 61;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.rjTextBox3.BorderColor = System.Drawing.Color.White;
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox3.BorderRadius = 10;
            this.rjTextBox3.BorderSize = 1;
            this.rjTextBox3.Enabled = false;
            this.rjTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox3.Location = new System.Drawing.Point(81, 450);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(10);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox3.PlaceholderText = "";
            this.rjTextBox3.Size = new System.Drawing.Size(339, 37);
            this.rjTextBox3.TabIndex = 62;
            this.rjTextBox3.Texts = "";
            this.rjTextBox3.UnderlinedStyle = false;
            // 
            // rjTextBox4
            // 
            this.rjTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.rjTextBox4.BorderColor = System.Drawing.Color.White;
            this.rjTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox4.BorderRadius = 10;
            this.rjTextBox4.BorderSize = 1;
            this.rjTextBox4.Enabled = false;
            this.rjTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox4.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox4.Location = new System.Drawing.Point(81, 545);
            this.rjTextBox4.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox4.Multiline = false;
            this.rjTextBox4.Name = "rjTextBox4";
            this.rjTextBox4.Padding = new System.Windows.Forms.Padding(10);
            this.rjTextBox4.PasswordChar = false;
            this.rjTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox4.PlaceholderText = "";
            this.rjTextBox4.Size = new System.Drawing.Size(339, 37);
            this.rjTextBox4.TabIndex = 63;
            this.rjTextBox4.Texts = "";
            this.rjTextBox4.UnderlinedStyle = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Enabled = false;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(0, 92);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(500, 605);
            this.rjButton1.TabIndex = 64;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // comboBox_position
            // 
            this.comboBox_position.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.comboBox_position.BorderRadius = 10;
            this.comboBox_position.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_position.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.comboBox_position.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_position.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBox_position.ForeColor = System.Drawing.Color.White;
            this.comboBox_position.ItemHeight = 30;
            this.comboBox_position.Items.AddRange(new object[] {
            "Car Manager",
            "Accountant"});
            this.comboBox_position.Location = new System.Drawing.Point(81, 307);
            this.comboBox_position.Name = "comboBox_position";
            this.comboBox_position.Size = new System.Drawing.Size(339, 36);
            this.comboBox_position.TabIndex = 68;
            this.comboBox_position.TextChanged += new System.EventHandler(this.guna2ComboBox1_TextChanged);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.comboBox_position);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_position);
            this.Controls.Add(this.label_checkUsername2);
            this.Controls.Add(this.label_checkLetter);
            this.Controls.Add(this.label_checkLong);
            this.Controls.Add(this.label_checkUsername);
            this.Controls.Add(this.label_checkEmail);
            this.Controls.Add(this.label_confirmPassword);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_fullname);
            this.Controls.Add(this.textBox_confirmPassword);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_fullName);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.rjTextBox_search);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.rjTextBox2);
            this.Controls.Add(this.rjTextBox3);
            this.Controls.Add(this.rjTextBox4);
            this.Controls.Add(this.rjButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label_checkUsername2;
        private System.Windows.Forms.Label label_position;
        private RJControls.RJTextBox rjTextBox_search;
        private RJControls.RJTextBox rjTextBox1;
        private RJControls.RJTextBox rjTextBox2;
        private RJControls.RJTextBox rjTextBox3;
        private RJControls.RJTextBox rjTextBox4;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_minimize;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_exit;
        private RJControls.RJButton button_signup;
        private RJControls.RJButton rjButton1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_position;
    }
}