namespace UnicomTICManagementSystem.Views
{
    partial class Staff_Management
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
            this.number = new System.Windows.Forms.TextBox();
            this.mobilenum = new System.Windows.Forms.MaskedTextBox();
            this.dateofbirthTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.gendercombobox = new System.Windows.Forms.ComboBox();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.addresstextbox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.Backbtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.staffname = new System.Windows.Forms.Label();
            this.tittle = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(336, 376);
            this.number.Margin = new System.Windows.Forms.Padding(2);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(50, 21);
            this.number.TabIndex = 47;
            this.number.Text = "+94";
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mobilenum
            // 
            this.mobilenum.Location = new System.Drawing.Point(397, 380);
            this.mobilenum.Margin = new System.Windows.Forms.Padding(2);
            this.mobilenum.Mask = " 00-000-000";
            this.mobilenum.Name = "mobilenum";
            this.mobilenum.Size = new System.Drawing.Size(257, 20);
            this.mobilenum.TabIndex = 46;
            this.mobilenum.TextChanged += new System.EventHandler(this.mo);
            // 
            // dateofbirthTextBox1
            // 
            this.dateofbirthTextBox1.Location = new System.Drawing.Point(336, 315);
            this.dateofbirthTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.dateofbirthTextBox1.Mask = "00/00/0000 ";
            this.dateofbirthTextBox1.Name = "dateofbirthTextBox1";
            this.dateofbirthTextBox1.Size = new System.Drawing.Size(318, 20);
            this.dateofbirthTextBox1.TabIndex = 45;
            this.dateofbirthTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // gendercombobox
            // 
            this.gendercombobox.FormattingEnabled = true;
            this.gendercombobox.Location = new System.Drawing.Point(336, 244);
            this.gendercombobox.Margin = new System.Windows.Forms.Padding(2);
            this.gendercombobox.Name = "gendercombobox";
            this.gendercombobox.Size = new System.Drawing.Size(318, 21);
            this.gendercombobox.TabIndex = 43;
            // 
            // emailtextbox
            // 
            this.emailtextbox.Location = new System.Drawing.Point(336, 432);
            this.emailtextbox.Margin = new System.Windows.Forms.Padding(2);
            this.emailtextbox.Multiline = true;
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(318, 30);
            this.emailtextbox.TabIndex = 41;
            // 
            // addresstextbox
            // 
            this.addresstextbox.Location = new System.Drawing.Point(336, 184);
            this.addresstextbox.Margin = new System.Windows.Forms.Padding(2);
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.Size = new System.Drawing.Size(318, 20);
            this.addresstextbox.TabIndex = 42;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(336, 124);
            this.name.Margin = new System.Windows.Forms.Padding(2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(318, 20);
            this.name.TabIndex = 40;
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(9, 650);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(84, 34);
            this.Backbtn.TabIndex = 39;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.Location = new System.Drawing.Point(1165, 696);
            this.registerbtn.Margin = new System.Windows.Forms.Padding(2);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(92, 34);
            this.registerbtn.TabIndex = 38;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(76, 244);
            this.gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(73, 22);
            this.gender.TabIndex = 37;
            this.gender.Text = "Gender:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(76, 432);
            this.email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(82, 22);
            this.email.TabIndex = 36;
            this.email.Text = "Email ID:";
            // 
            // phonenumber
            // 
            this.phonenumber.AutoSize = true;
            this.phonenumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumber.Location = new System.Drawing.Point(76, 376);
            this.phonenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(102, 22);
            this.phonenumber.TabIndex = 34;
            this.phonenumber.Text = "Mobile No:";
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSize = true;
            this.dateofbirth.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirth.Location = new System.Drawing.Point(76, 315);
            this.dateofbirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(120, 22);
            this.dateofbirth.TabIndex = 33;
            this.dateofbirth.Text = "Date of Birth:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(76, 184);
            this.address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(81, 22);
            this.address.TabIndex = 32;
            this.address.Text = "Address:";
            // 
            // staffname
            // 
            this.staffname.AutoSize = true;
            this.staffname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffname.Location = new System.Drawing.Point(76, 124);
            this.staffname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staffname.Name = "staffname";
            this.staffname.Size = new System.Drawing.Size(143, 22);
            this.staffname.TabIndex = 31;
            this.staffname.Text = "NewStaff Name:";
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.Location = new System.Drawing.Point(430, 17);
            this.tittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(421, 34);
            this.tittle.TabIndex = 30;
            this.tittle.Text = "NewStaff Registration Form";
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(590, 483);
            this.submitbtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(63, 25);
            this.submitbtn.TabIndex = 48;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // Staff_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.number);
            this.Controls.Add(this.mobilenum);
            this.Controls.Add(this.dateofbirthTextBox1);
            this.Controls.Add(this.gendercombobox);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.addresstextbox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.address);
            this.Controls.Add(this.staffname);
            this.Controls.Add(this.tittle);
            this.Name = "Staff_Management";
            this.Text = "Staff_Management";
            this.Load += new System.EventHandler(this.Staff_Management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.MaskedTextBox mobilenum;
        private System.Windows.Forms.MaskedTextBox dateofbirthTextBox1;
        private System.Windows.Forms.ComboBox gendercombobox;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.TextBox addresstextbox;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label phonenumber;
        private System.Windows.Forms.Label dateofbirth;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label staffname;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Button submitbtn;
    }
}