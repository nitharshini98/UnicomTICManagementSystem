﻿namespace UnicomTICManagementSystem.Views
{
    partial class StaffForm
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
            this.attendancetbtn = new System.Windows.Forms.Button();
            this.timetalebtn = new System.Windows.Forms.Button();
            this.tittle = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // marksbtn
            // 
            this.marksbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marksbtn.Location = new System.Drawing.Point(10, 304);
            this.marksbtn.Name = "marksbtn";
            this.marksbtn.Size = new System.Drawing.Size(193, 69);
            this.marksbtn.TabIndex = 9;
            this.marksbtn.Text = "View Marks";
            this.marksbtn.UseVisualStyleBackColor = true;
            this.marksbtn.Click += new System.EventHandler(this.marksbtn_Click);
            // 
            // exambtn
            // 
            this.exambtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exambtn.Location = new System.Drawing.Point(10, 229);
            this.exambtn.Name = "exambtn";
            this.exambtn.Size = new System.Drawing.Size(193, 69);
            this.exambtn.TabIndex = 10;
            this.exambtn.Text = "View Exam";
            this.exambtn.UseVisualStyleBackColor = true;
            this.exambtn.Click += new System.EventHandler(this.exambtn_Click);
            // 
            // attendancetbtn
            // 
            this.attendancetbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendancetbtn.Location = new System.Drawing.Point(10, 139);
            this.attendancetbtn.Name = "attendancetbtn";
            this.attendancetbtn.Size = new System.Drawing.Size(193, 69);
            this.attendancetbtn.TabIndex = 11;
            this.attendancetbtn.Text = "View Attendance";
            this.attendancetbtn.UseVisualStyleBackColor = true;
            this.attendancetbtn.Click += new System.EventHandler(this.attendancetbtn_Click);
            // 
            // timetalebtn
            // 
            this.timetalebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetalebtn.Location = new System.Drawing.Point(12, 64);
            this.timetalebtn.Name = "timetalebtn";
            this.timetalebtn.Size = new System.Drawing.Size(193, 69);
            this.timetalebtn.TabIndex = 12;
            this.timetalebtn.Text = "View Timetable";
            this.timetalebtn.UseVisualStyleBackColor = true;
            this.timetalebtn.Click += new System.EventHandler(this.timetalebtn_Click);
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Modern No. 20", 23.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tittle.Location = new System.Drawing.Point(12, 18);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(251, 32);
            this.tittle.TabIndex = 7;
            this.tittle.Text = "NewStaff Interface";
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(27, 401);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(99, 31);
            this.backbtn.TabIndex = 13;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(285, 449);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.marksbtn);
            this.Controls.Add(this.exambtn);
            this.Controls.Add(this.attendancetbtn);
            this.Controls.Add(this.timetalebtn);
            this.Controls.Add(this.tittle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StaffForm";
            this.Text = "NewStaff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button marksbtn;
        private System.Windows.Forms.Button exambtn;
        private System.Windows.Forms.Button attendancetbtn;
        private System.Windows.Forms.Button timetalebtn;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Button backbtn;
    }
}