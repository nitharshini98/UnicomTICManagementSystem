namespace UnicomTICManagementSystem.Views
{
    partial class Mainlogin
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
            this.userlogin = new System.Windows.Forms.Label();
            this.rolecomboBox1 = new System.Windows.Forms.ComboBox();
            this.role = new System.Windows.Forms.Label();
            this.cancelbtn1 = new System.Windows.Forms.Button();
            this.loginbtn1 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.Label();
            this.username1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userlogin
            // 
            this.userlogin.AutoSize = true;
            this.userlogin.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userlogin.Location = new System.Drawing.Point(41, 37);
            this.userlogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userlogin.Name = "userlogin";
            this.userlogin.Size = new System.Drawing.Size(213, 31);
            this.userlogin.TabIndex = 0;
            this.userlogin.Text = "Main-User Login";
            this.userlogin.Click += new System.EventHandler(this.userlogin_Click);
            // 
            // rolecomboBox1
            // 
            this.rolecomboBox1.FormattingEnabled = true;
            this.rolecomboBox1.Items.AddRange(new object[] {
            "admin",
            "lecturer",
            "newstaff",
            "student"});
            this.rolecomboBox1.Location = new System.Drawing.Point(106, 97);
            this.rolecomboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.rolecomboBox1.Name = "rolecomboBox1";
            this.rolecomboBox1.Size = new System.Drawing.Size(134, 21);
            this.rolecomboBox1.TabIndex = 1;
            this.rolecomboBox1.SelectedIndexChanged += new System.EventHandler(this.rolecomboBox1_SelectedIndexChanged);
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.role.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.Location = new System.Drawing.Point(38, 97);
            this.role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(38, 16);
            this.role.TabIndex = 2;
            this.role.Text = "Role:";
            this.role.Click += new System.EventHandler(this.role_Click);
            // 
            // cancelbtn1
            // 
            this.cancelbtn1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn1.Location = new System.Drawing.Point(153, 241);
            this.cancelbtn1.Margin = new System.Windows.Forms.Padding(2);
            this.cancelbtn1.Name = "cancelbtn1";
            this.cancelbtn1.Size = new System.Drawing.Size(87, 32);
            this.cancelbtn1.TabIndex = 9;
            this.cancelbtn1.Text = "Cancel";
            this.cancelbtn1.UseVisualStyleBackColor = true;
            this.cancelbtn1.Click += new System.EventHandler(this.cancelbtn1_Click);
            // 
            // loginbtn1
            // 
            this.loginbtn1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn1.Location = new System.Drawing.Point(47, 241);
            this.loginbtn1.Margin = new System.Windows.Forms.Padding(2);
            this.loginbtn1.Name = "loginbtn1";
            this.loginbtn1.Size = new System.Drawing.Size(89, 32);
            this.loginbtn1.TabIndex = 10;
            this.loginbtn1.Text = "Login";
            this.loginbtn1.UseVisualStyleBackColor = true;
            this.loginbtn1.Click += new System.EventHandler(this.loginbtn1_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(106, 186);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(134, 23);
            this.password.TabIndex = 7;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(106, 140);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(134, 23);
            this.username.TabIndex = 8;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password1
            // 
            this.password1.AutoSize = true;
            this.password1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.password1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password1.Location = new System.Drawing.Point(14, 186);
            this.password1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(65, 16);
            this.password1.TabIndex = 5;
            this.password1.Text = "Password";
            // 
            // username1
            // 
            this.username1.AutoSize = true;
            this.username1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.username1.Location = new System.Drawing.Point(11, 131);
            this.username1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(68, 16);
            this.username1.TabIndex = 6;
            this.username1.Text = "Username";
            // 
            // Mainlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(349, 321);
            this.Controls.Add(this.cancelbtn1);
            this.Controls.Add(this.loginbtn1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.username1);
            this.Controls.Add(this.role);
            this.Controls.Add(this.rolecomboBox1);
            this.Controls.Add(this.userlogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mainlogin";
            this.Text = "Mainlogin";
            this.Load += new System.EventHandler(this.Mainlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userlogin;
        private System.Windows.Forms.ComboBox rolecomboBox1;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Button cancelbtn1;
        private System.Windows.Forms.Button loginbtn1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label password1;
        private System.Windows.Forms.Label username1;
    }
}