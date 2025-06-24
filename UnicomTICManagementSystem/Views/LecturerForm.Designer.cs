﻿namespace UnicomTICManagementSystem.Views
{
    partial class Lectrer
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
            this.lecturer = new System.Windows.Forms.Label();
            this.timetalebtn = new System.Windows.Forms.Button();
            this.subjectbtn = new System.Windows.Forms.Button();
            this.exambtn = new System.Windows.Forms.Button();
            this.marksbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lecturer
            // 
            this.lecturer.AutoSize = true;
            this.lecturer.Font = new System.Drawing.Font("Baskerville Old Face", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lecturer.Location = new System.Drawing.Point(34, 9);
            this.lecturer.Name = "lecturer";
            this.lecturer.Size = new System.Drawing.Size(256, 35);
            this.lecturer.TabIndex = 0;
            this.lecturer.Text = "Lecturer Interface";
            // 
            // timetalebtn
            // 
            this.timetalebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetalebtn.Location = new System.Drawing.Point(97, 75);
            this.timetalebtn.Name = "timetalebtn";
            this.timetalebtn.Size = new System.Drawing.Size(173, 48);
            this.timetalebtn.TabIndex = 1;
            this.timetalebtn.Text = "View Timetable";
            this.timetalebtn.UseVisualStyleBackColor = true;
            this.timetalebtn.Click += new System.EventHandler(this.timetalebtn_Click);
            // 
            // subjectbtn
            // 
            this.subjectbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectbtn.Location = new System.Drawing.Point(97, 153);
            this.subjectbtn.Name = "subjectbtn";
            this.subjectbtn.Size = new System.Drawing.Size(173, 45);
            this.subjectbtn.TabIndex = 1;
            this.subjectbtn.Text = "View Subject";
            this.subjectbtn.UseVisualStyleBackColor = true;
            this.subjectbtn.Click += new System.EventHandler(this.subjectbtn_Click);
            // 
            // exambtn
            // 
            this.exambtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exambtn.Location = new System.Drawing.Point(97, 230);
            this.exambtn.Name = "exambtn";
            this.exambtn.Size = new System.Drawing.Size(173, 45);
            this.exambtn.TabIndex = 1;
            this.exambtn.Text = "View Exam";
            this.exambtn.UseVisualStyleBackColor = true;
            this.exambtn.Click += new System.EventHandler(this.exambtn_Click);
            // 
            // marksbtn
            // 
            this.marksbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marksbtn.Location = new System.Drawing.Point(97, 309);
            this.marksbtn.Name = "marksbtn";
            this.marksbtn.Size = new System.Drawing.Size(173, 45);
            this.marksbtn.TabIndex = 1;
            this.marksbtn.Text = "View Marks";
            this.marksbtn.UseVisualStyleBackColor = true;
            this.marksbtn.Click += new System.EventHandler(this.marksbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(12, 360);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(99, 31);
            this.backbtn.TabIndex = 2;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Lectrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(437, 417);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.marksbtn);
            this.Controls.Add(this.exambtn);
            this.Controls.Add(this.subjectbtn);
            this.Controls.Add(this.timetalebtn);
            this.Controls.Add(this.lecturer);
            this.Name = "Lectrer";
            this.Text = "Lecturer";
            this.Load += new System.EventHandler(this.Lecturer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lecturer;
        private System.Windows.Forms.Button timetalebtn;
        private System.Windows.Forms.Button subjectbtn;
        private System.Windows.Forms.Button exambtn;
        private System.Windows.Forms.Button marksbtn;
        private System.Windows.Forms.Button backbtn;
    }
}