using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Views
{
    public partial class ViewExams : Form
    {
        public ViewExams()
        {
            InitializeComponent();
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainlogin mainlogin = new Mainlogin();
            mainlogin.ShowDialog(); ;
        }

        private void viewexamdata2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
