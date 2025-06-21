namespace UnicomTICManagementSystem.Views
{
    partial class ViewTimetable
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
            this.viewtimetabledata2 = new System.Windows.Forms.DataGridView();
            this.tittle = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewtimetabledata2)).BeginInit();
            this.SuspendLayout();
            // 
            // viewtimetabledata2
            // 
            this.viewtimetabledata2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewtimetabledata2.Location = new System.Drawing.Point(489, 185);
            this.viewtimetabledata2.Name = "viewtimetabledata2";
            this.viewtimetabledata2.RowHeadersWidth = 51;
            this.viewtimetabledata2.RowTemplate.Height = 24;
            this.viewtimetabledata2.Size = new System.Drawing.Size(603, 430);
            this.viewtimetabledata2.TabIndex = 4;
            this.viewtimetabledata2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewtimetabledata2_CellContentClick);
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.Location = new System.Drawing.Point(635, 58);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(310, 50);
            this.tittle.TabIndex = 5;
            this.tittle.Text = "View Timetable";
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(13, 802);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(132, 38);
            this.backbtn.TabIndex = 9;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // ViewTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 853);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.viewtimetabledata2);
            this.Name = "ViewTimetable";
            this.Text = "ViewTimetable";
            this.Load += new System.EventHandler(this.ViewTimetable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewtimetabledata2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewtimetabledata2;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Button backbtn;
    }
}