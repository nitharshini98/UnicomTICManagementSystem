namespace UnicomTICManagementSystem.Views
{
    partial class Attendance_Management
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
            this.tittle = new System.Windows.Forms.Label();
            this.dateofbirthTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.statuscombobox = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.Label();
            this.subjectname = new System.Windows.Forms.Label();
            this.studentname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.submitbtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.ComboBox();
            this.subjectnametextbox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.Location = new System.Drawing.Point(528, 53);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(186, 34);
            this.tittle.TabIndex = 0;
            this.tittle.Text = "Attendance";
            // 
            // dateofbirthTextBox1
            // 
            this.dateofbirthTextBox1.Location = new System.Drawing.Point(276, 327);
            this.dateofbirthTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.dateofbirthTextBox1.Mask = "00/00/0000 ";
            this.dateofbirthTextBox1.Name = "dateofbirthTextBox1";
            this.dateofbirthTextBox1.Size = new System.Drawing.Size(318, 20);
            this.dateofbirthTextBox1.TabIndex = 15;
            this.dateofbirthTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // statuscombobox
            // 
            this.statuscombobox.FormattingEnabled = true;
            this.statuscombobox.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Late",
            "Excused"});
            this.statuscombobox.Location = new System.Drawing.Point(276, 393);
            this.statuscombobox.Margin = new System.Windows.Forms.Padding(2);
            this.statuscombobox.Name = "statuscombobox";
            this.statuscombobox.Size = new System.Drawing.Size(318, 21);
            this.statuscombobox.TabIndex = 14;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(87, 386);
            this.status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(66, 22);
            this.status.TabIndex = 9;
            this.status.Text = "Status:";
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSize = true;
            this.dateofbirth.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirth.Location = new System.Drawing.Point(87, 320);
            this.dateofbirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(53, 22);
            this.dateofbirth.TabIndex = 10;
            this.dateofbirth.Text = "Date:";
            // 
            // subjectname
            // 
            this.subjectname.AutoSize = true;
            this.subjectname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectname.Location = new System.Drawing.Point(87, 247);
            this.subjectname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subjectname.Name = "subjectname";
            this.subjectname.Size = new System.Drawing.Size(128, 22);
            this.subjectname.TabIndex = 11;
            this.subjectname.Text = "Subject Name:";
            // 
            // studentname
            // 
            this.studentname.AutoSize = true;
            this.studentname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentname.Location = new System.Drawing.Point(87, 174);
            this.studentname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(132, 22);
            this.studentname.TabIndex = 8;
            this.studentname.Text = "Student Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(666, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(478, 487);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(12, 650);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(99, 31);
            this.backbtn.TabIndex = 19;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(530, 439);
            this.submitbtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(63, 25);
            this.submitbtn.TabIndex = 31;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // name
            // 
            this.name.FormattingEnabled = true;
            this.name.Location = new System.Drawing.Point(275, 174);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(318, 21);
            this.name.TabIndex = 32;
            // 
            // subjectnametextbox
            // 
            this.subjectnametextbox.FormattingEnabled = true;
            this.subjectnametextbox.Location = new System.Drawing.Point(275, 247);
            this.subjectnametextbox.Name = "subjectnametextbox";
            this.subjectnametextbox.Size = new System.Drawing.Size(318, 21);
            this.subjectnametextbox.TabIndex = 32;
            // 
            // Attendance_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.subjectnametextbox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateofbirthTextBox1);
            this.Controls.Add(this.statuscombobox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.subjectname);
            this.Controls.Add(this.studentname);
            this.Controls.Add(this.tittle);
            this.Name = "Attendance_Management";
            this.Text = "Attendance_Management";
            this.Load += new System.EventHandler(this.Attendance_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.MaskedTextBox dateofbirthTextBox1;
        private System.Windows.Forms.ComboBox statuscombobox;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label dateofbirth;
        private System.Windows.Forms.Label subjectname;
        private System.Windows.Forms.Label studentname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.ComboBox subjectnametextbox;
    }
}