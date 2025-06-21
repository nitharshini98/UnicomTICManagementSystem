using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Model;

namespace UnicomTICManagementSystem.Views
{
    public partial class Staff_Management : Form
    {
        public Staff_Management()
        {
            InitializeComponent();
        }

        private void Staff_Management_Load(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Interface adminInterface = new Admin_Interface();
            adminInterface.Show();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            var Staff = new NewStaff
            {
                StaffName = name.Text,    
                Address = addresstextbox.Text,
                Gender = gendercombobox.Text,
                Dateofbirth = dateofbirthTextBox1.Text,
                MobileNumber = mobilenum.Text,
                EmailId = emailtextbox.Text,

            };
            StaffController.AddStaff(Staff);
            MessageBox.Show("SuccesFully Add NewStaff!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mo(object sender, EventArgs e)
        {

        }
    }
}
