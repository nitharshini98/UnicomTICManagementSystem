namespace UnicomTICManagementSystem.Views
{
    partial class VIewAttendance
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
            this.viewattendancedata2 = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewattendancedata2)).BeginInit();
            this.SuspendLayout();
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tittle.Font = new System.Drawing.Font("Modern No. 20", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tittle.Location = new System.Drawing.Point(39, 34);
            this.tittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(240, 32);
            this.tittle.TabIndex = 7;
            this.tittle.Text = "View Attendance";
            // 
            // viewattendancedata2
            // 
            this.viewattendancedata2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewattendancedata2.Location = new System.Drawing.Point(46, 91);
            this.viewattendancedata2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewattendancedata2.Name = "viewattendancedata2";
            this.viewattendancedata2.RowHeadersWidth = 51;
            this.viewattendancedata2.RowTemplate.Height = 24;
            this.viewattendancedata2.Size = new System.Drawing.Size(264, 251);
            this.viewattendancedata2.TabIndex = 6;
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(46, 371);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(99, 31);
            this.backbtn.TabIndex = 8;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // VIewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(405, 431);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.viewattendancedata2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VIewAttendance";
            this.Text = "VIewAttendance";
            ((System.ComponentModel.ISupportInitialize)(this.viewattendancedata2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.DataGridView viewattendancedata2;
        private System.Windows.Forms.Button backbtn;
    }
}