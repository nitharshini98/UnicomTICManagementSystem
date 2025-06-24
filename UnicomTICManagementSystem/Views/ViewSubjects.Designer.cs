namespace UnicomTICManagementSystem.Views
{
    partial class ViewSubjects
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
            this.viewtsubjectdata2 = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewtsubjectdata2)).BeginInit();
            this.SuspendLayout();
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tittle.Font = new System.Drawing.Font("Modern No. 20", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tittle.Location = new System.Drawing.Point(49, 31);
            this.tittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(200, 32);
            this.tittle.TabIndex = 7;
            this.tittle.Text = "View Subjects";
            // 
            // viewtsubjectdata2
            // 
            this.viewtsubjectdata2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewtsubjectdata2.Location = new System.Drawing.Point(41, 91);
            this.viewtsubjectdata2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewtsubjectdata2.Name = "viewtsubjectdata2";
            this.viewtsubjectdata2.RowHeadersWidth = 51;
            this.viewtsubjectdata2.RowTemplate.Height = 24;
            this.viewtsubjectdata2.Size = new System.Drawing.Size(271, 238);
            this.viewtsubjectdata2.TabIndex = 6;
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(41, 378);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(99, 31);
            this.backbtn.TabIndex = 8;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // ViewSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(392, 473);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.viewtsubjectdata2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewSubjects";
            this.Text = "ViewSubjects";
            this.Load += new System.EventHandler(this.ViewSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewtsubjectdata2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.DataGridView viewtsubjectdata2;
        private System.Windows.Forms.Button backbtn;
    }
}