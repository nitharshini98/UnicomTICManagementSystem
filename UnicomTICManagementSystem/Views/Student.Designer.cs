namespace UnicomTICManagementSystem.Views
{
    partial class Student
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
            this.marksbtn = new System.Windows.Forms.Button();
            this.exambtn = new System.Windows.Forms.Button();
            this.subjectbtn = new System.Windows.Forms.Button();
            this.timetalebtn = new System.Windows.Forms.Button();
            this.student1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.attendancebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // marksbtn
            // 
            this.marksbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marksbtn.Location = new System.Drawing.Point(46, 370);
            this.marksbtn.Name = "marksbtn";
            this.marksbtn.Size = new System.Drawing.Size(189, 46);
            this.marksbtn.TabIndex = 3;
            this.marksbtn.Text = "View Marks";
            this.marksbtn.UseVisualStyleBackColor = true;
            this.marksbtn.Click += new System.EventHandler(this.marksbtn_Click);
            // 
            // exambtn
            // 
            this.exambtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exambtn.Location = new System.Drawing.Point(46, 275);
            this.exambtn.Name = "exambtn";
            this.exambtn.Size = new System.Drawing.Size(189, 46);
            this.exambtn.TabIndex = 4;
            this.exambtn.Text = "View Exam";
            this.exambtn.UseVisualStyleBackColor = true;
            this.exambtn.Click += new System.EventHandler(this.exambtn_Click);
            // 
            // subjectbtn
            // 
            this.subjectbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectbtn.Location = new System.Drawing.Point(46, 170);
            this.subjectbtn.Name = "subjectbtn";
            this.subjectbtn.Size = new System.Drawing.Size(189, 46);
            this.subjectbtn.TabIndex = 5;
            this.subjectbtn.Text = "View Subject";
            this.subjectbtn.UseVisualStyleBackColor = true;
            this.subjectbtn.Click += new System.EventHandler(this.subjectbtn_Click);
            // 
            // timetalebtn
            // 
            this.timetalebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetalebtn.Location = new System.Drawing.Point(46, 76);
            this.timetalebtn.Name = "timetalebtn";
            this.timetalebtn.Size = new System.Drawing.Size(189, 46);
            this.timetalebtn.TabIndex = 6;
            this.timetalebtn.Text = "View Timetable";
            this.timetalebtn.UseVisualStyleBackColor = true;
            this.timetalebtn.Click += new System.EventHandler(this.timetalebtn_Click);
            // 
            // student1
            // 
            this.student1.AutoSize = true;
            this.student1.Font = new System.Drawing.Font("Modern No. 20", 23.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.student1.Location = new System.Drawing.Point(40, 21);
            this.student1.Name = "student1";
            this.student1.Size = new System.Drawing.Size(231, 32);
            this.student1.TabIndex = 2;
            this.student1.Text = "Student Interface";
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(46, 534);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(99, 31);
            this.backbtn.TabIndex = 7;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // attendancebtn
            // 
            this.attendancebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendancebtn.Location = new System.Drawing.Point(46, 468);
            this.attendancebtn.Name = "attendancebtn";
            this.attendancebtn.Size = new System.Drawing.Size(189, 46);
            this.attendancebtn.TabIndex = 3;
            this.attendancebtn.Text = "View Attendance";
            this.attendancebtn.UseVisualStyleBackColor = true;
            this.attendancebtn.Click += new System.EventHandler(this.attendancebtn_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(354, 577);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.attendancebtn);
            this.Controls.Add(this.marksbtn);
            this.Controls.Add(this.exambtn);
            this.Controls.Add(this.subjectbtn);
            this.Controls.Add(this.timetalebtn);
            this.Controls.Add(this.student1);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button marksbtn;
        private System.Windows.Forms.Button exambtn;
        private System.Windows.Forms.Button subjectbtn;
        private System.Windows.Forms.Button timetalebtn;
        private System.Windows.Forms.Label student1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button attendancebtn;
    }
}