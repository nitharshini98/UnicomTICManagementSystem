namespace UnicomTICManagementSystem.Views
{
    partial class Exam_Management
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
            this.examdataGridView1 = new System.Windows.Forms.DataGridView();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.subjectname = new System.Windows.Forms.Label();
            this.tittle = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.subjectextBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.examdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // examdataGridView1
            // 
            this.examdataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.examdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examdataGridView1.Location = new System.Drawing.Point(264, 123);
            this.examdataGridView1.Name = "examdataGridView1";
            this.examdataGridView1.RowHeadersWidth = 51;
            this.examdataGridView1.Size = new System.Drawing.Size(395, 251);
            this.examdataGridView1.TabIndex = 17;
            this.examdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.examdataGridView1_CellContentClick);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(553, 419);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(106, 28);
            this.deletebtn.TabIndex = 14;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(388, 419);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(106, 28);
            this.updatebtn.TabIndex = 15;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(244, 419);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(106, 28);
            this.addbtn.TabIndex = 16;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedTextBox2.Location = new System.Drawing.Point(54, 333);
            this.maskedTextBox2.Mask = "90:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(175, 20);
            this.maskedTextBox2.TabIndex = 13;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedTextBox1.Location = new System.Drawing.Point(54, 249);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(175, 20);
            this.maskedTextBox1.TabIndex = 12;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.time.Location = new System.Drawing.Point(65, 296);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(50, 22);
            this.time.TabIndex = 8;
            this.time.Text = "Time";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.date.Location = new System.Drawing.Point(65, 224);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(48, 22);
            this.date.TabIndex = 9;
            this.date.Text = "Date";
            // 
            // subjectname
            // 
            this.subjectname.AutoSize = true;
            this.subjectname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subjectname.Location = new System.Drawing.Point(65, 123);
            this.subjectname.Name = "subjectname";
            this.subjectname.Size = new System.Drawing.Size(123, 22);
            this.subjectname.TabIndex = 10;
            this.subjectname.Text = "Subject Name";
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tittle.Location = new System.Drawing.Point(326, 30);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(205, 34);
            this.tittle.TabIndex = 7;
            this.tittle.Text = "Exam Details";
            this.tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(29, 462);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(99, 31);
            this.backbtn.TabIndex = 18;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // subjectextBox2
            // 
            this.subjectextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.subjectextBox2.FormattingEnabled = true;
            this.subjectextBox2.Location = new System.Drawing.Point(54, 148);
            this.subjectextBox2.Name = "subjectextBox2";
            this.subjectextBox2.Size = new System.Drawing.Size(175, 21);
            this.subjectextBox2.TabIndex = 19;
            // 
            // Exam_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(728, 542);
            this.Controls.Add(this.subjectextBox2);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.subjectname);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.examdataGridView1);
            this.Controls.Add(this.tittle);
            this.Name = "Exam_Management";
            this.Text = "Exam_Management";
            this.Load += new System.EventHandler(this.Exam_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView examdataGridView1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label subjectname;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.ComboBox subjectextBox2;
    }
}