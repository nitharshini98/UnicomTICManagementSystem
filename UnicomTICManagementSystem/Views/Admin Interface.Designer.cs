﻿namespace UnicomTICManagementSystem.Views
{
    partial class Admin_Interface
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
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.Tittle = new System.Windows.Forms.Label();
            this.studentbtn = new System.Windows.Forms.Button();
            this.subjectbtn = new System.Windows.Forms.Button();
            this.exambtn = new System.Windows.Forms.Button();
            this.lecturebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.marksbtn = new System.Windows.Forms.Button();
            this.timetablebtn = new System.Windows.Forms.Button();
            this.staffbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Baskerville Old Face", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tittle.Location = new System.Drawing.Point(129, 19);
            this.Tittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(233, 35);
            this.Tittle.TabIndex = 0;
            this.Tittle.Text = "Admin Interface";
            // 
            // studentbtn
            // 
            this.studentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentbtn.Location = new System.Drawing.Point(151, 88);
            this.studentbtn.Margin = new System.Windows.Forms.Padding(2);
            this.studentbtn.Name = "studentbtn";
            this.studentbtn.Size = new System.Drawing.Size(177, 43);
            this.studentbtn.TabIndex = 1;
            this.studentbtn.Text = "Student Management";
            this.studentbtn.UseVisualStyleBackColor = true;
            this.studentbtn.Click += new System.EventHandler(this.studentbtn_Click);
            // 
            // subjectbtn
            // 
            this.subjectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectbtn.Location = new System.Drawing.Point(151, 147);
            this.subjectbtn.Margin = new System.Windows.Forms.Padding(2);
            this.subjectbtn.Name = "subjectbtn";
            this.subjectbtn.Size = new System.Drawing.Size(177, 44);
            this.subjectbtn.TabIndex = 1;
            this.subjectbtn.Text = "Subejct Management";
            this.subjectbtn.UseVisualStyleBackColor = true;
            this.subjectbtn.Click += new System.EventHandler(this.subjectbtn_Click);
            // 
            // exambtn
            // 
            this.exambtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exambtn.Location = new System.Drawing.Point(151, 195);
            this.exambtn.Margin = new System.Windows.Forms.Padding(2);
            this.exambtn.Name = "exambtn";
            this.exambtn.Size = new System.Drawing.Size(177, 36);
            this.exambtn.TabIndex = 1;
            this.exambtn.Text = "Exam Management\r\n";
            this.exambtn.UseVisualStyleBackColor = true;
            this.exambtn.Click += new System.EventHandler(this.exambtn_Click);
            // 
            // lecturebtn
            // 
            this.lecturebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturebtn.Location = new System.Drawing.Point(151, 235);
            this.lecturebtn.Margin = new System.Windows.Forms.Padding(2);
            this.lecturebtn.Name = "lecturebtn";
            this.lecturebtn.Size = new System.Drawing.Size(177, 41);
            this.lecturebtn.TabIndex = 1;
            this.lecturebtn.Text = "Lectures Management\r\n";
            this.lecturebtn.UseVisualStyleBackColor = true;
            this.lecturebtn.Click += new System.EventHandler(this.lecturebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(26, 495);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(88, 42);
            this.backbtn.TabIndex = 2;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // marksbtn
            // 
            this.marksbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marksbtn.Location = new System.Drawing.Point(151, 378);
            this.marksbtn.Margin = new System.Windows.Forms.Padding(2);
            this.marksbtn.Name = "marksbtn";
            this.marksbtn.Size = new System.Drawing.Size(177, 47);
            this.marksbtn.TabIndex = 3;
            this.marksbtn.Text = "Marks Management";
            this.marksbtn.UseVisualStyleBackColor = true;
            this.marksbtn.Click += new System.EventHandler(this.marksbtn_Click);
            // 
            // timetablebtn
            // 
            this.timetablebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetablebtn.Location = new System.Drawing.Point(151, 330);
            this.timetablebtn.Margin = new System.Windows.Forms.Padding(2);
            this.timetablebtn.Name = "timetablebtn";
            this.timetablebtn.Size = new System.Drawing.Size(177, 44);
            this.timetablebtn.TabIndex = 4;
            this.timetablebtn.Text = "Timtable Management\r\n";
            this.timetablebtn.UseVisualStyleBackColor = true;
            this.timetablebtn.Click += new System.EventHandler(this.timetablebtn_Click);
            // 
            // staffbtn
            // 
            this.staffbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffbtn.Location = new System.Drawing.Point(151, 280);
            this.staffbtn.Margin = new System.Windows.Forms.Padding(2);
            this.staffbtn.Name = "staffbtn";
            this.staffbtn.Size = new System.Drawing.Size(177, 46);
            this.staffbtn.TabIndex = 5;
            this.staffbtn.Text = "NewStaff Management";
            this.staffbtn.UseVisualStyleBackColor = true;
            this.staffbtn.Click += new System.EventHandler(this.staffbtn_Click);
            // 
            // Admin_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(532, 588);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.marksbtn);
            this.Controls.Add(this.timetablebtn);
            this.Controls.Add(this.staffbtn);
            this.Controls.Add(this.lecturebtn);
            this.Controls.Add(this.exambtn);
            this.Controls.Add(this.subjectbtn);
            this.Controls.Add(this.studentbtn);
            this.Controls.Add(this.Tittle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin_Interface";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Admin_Interface";
            this.Load += new System.EventHandler(this.Admin_Interface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Button studentbtn;
        private System.Windows.Forms.Button subjectbtn;
        private System.Windows.Forms.Button exambtn;
        private System.Windows.Forms.Button lecturebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button marksbtn;
        private System.Windows.Forms.Button timetablebtn;
        private System.Windows.Forms.Button staffbtn;
    }
}