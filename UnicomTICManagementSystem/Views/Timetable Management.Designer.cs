namespace UnicomTICManagementSystem.Views
{
    partial class Timetable_Management
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
            this.timetabledataGridView1 = new System.Windows.Forms.DataGridView();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.dateTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.date = new System.Windows.Forms.Label();
            this.subjectname = new System.Windows.Forms.Label();
            this.tittle = new System.Windows.Forms.Label();
            this.lecturername = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.subjectname1 = new System.Windows.Forms.ComboBox();
            this.lecturername1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.timetabledataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timetabledataGridView1
            // 
            this.timetabledataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetabledataGridView1.Location = new System.Drawing.Point(384, 314);
            this.timetabledataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timetabledataGridView1.Name = "timetabledataGridView1";
            this.timetabledataGridView1.RowHeadersWidth = 51;
            this.timetabledataGridView1.Size = new System.Drawing.Size(804, 390);
            this.timetabledataGridView1.TabIndex = 17;
            this.timetabledataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.timetabledataGridView1_CellContentClick);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(1108, 242);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(141, 34);
            this.deletebtn.TabIndex = 14;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(723, 242);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(141, 34);
            this.updatebtn.TabIndex = 15;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(323, 242);
            this.addbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(141, 34);
            this.addbtn.TabIndex = 16;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // dateTextBox1
            // 
            this.dateTextBox1.Location = new System.Drawing.Point(1067, 182);
            this.dateTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTextBox1.Mask = "00/00/0000";
            this.dateTextBox1.Name = "dateTextBox1";
            this.dateTextBox1.Size = new System.Drawing.Size(264, 22);
            this.dateTextBox1.TabIndex = 12;
            this.dateTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(1128, 130);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(60, 27);
            this.date.TabIndex = 9;
            this.date.Text = "Date";
            // 
            // subjectname
            // 
            this.subjectname.AutoSize = true;
            this.subjectname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectname.Location = new System.Drawing.Point(273, 130);
            this.subjectname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subjectname.Name = "subjectname";
            this.subjectname.Size = new System.Drawing.Size(153, 27);
            this.subjectname.TabIndex = 10;
            this.subjectname.Text = "Subject Name";
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.Location = new System.Drawing.Point(693, 25);
            this.tittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(197, 43);
            this.tittle.TabIndex = 7;
            this.tittle.Text = "Timetable";
            this.tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lecturername
            // 
            this.lecturername.AutoSize = true;
            this.lecturername.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturername.Location = new System.Drawing.Point(673, 130);
            this.lecturername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lecturername.Name = "lecturername";
            this.lecturername.Size = new System.Drawing.Size(161, 27);
            this.lecturername.TabIndex = 10;
            this.lecturername.Text = "Lecturer Name";
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(13, 802);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(132, 38);
            this.backbtn.TabIndex = 19;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // subjectname1
            // 
            this.subjectname1.FormattingEnabled = true;
            this.subjectname1.Location = new System.Drawing.Point(232, 161);
            this.subjectname1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subjectname1.Name = "subjectname1";
            this.subjectname1.Size = new System.Drawing.Size(231, 24);
            this.subjectname1.TabIndex = 20;
            // 
            // lecturername1
            // 
            this.lecturername1.FormattingEnabled = true;
            this.lecturername1.Location = new System.Drawing.Point(647, 161);
            this.lecturername1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lecturername1.Name = "lecturername1";
            this.lecturername1.Size = new System.Drawing.Size(244, 24);
            this.lecturername1.TabIndex = 20;
            // 
            // Timetable_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 853);
            this.Controls.Add(this.lecturername1);
            this.Controls.Add(this.subjectname1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.timetabledataGridView1);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.dateTextBox1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.lecturername);
            this.Controls.Add(this.subjectname);
            this.Controls.Add(this.tittle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Timetable_Management";
            this.Text = "Timetable_Management";
            this.Load += new System.EventHandler(this.Timetable_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timetabledataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView timetabledataGridView1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.MaskedTextBox dateTextBox1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label subjectname;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Label lecturername;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.ComboBox subjectname1;
        private System.Windows.Forms.ComboBox lecturername1;
    }
}