using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Model;

namespace UnicomTICManagementSystem.Views
{
    public partial class Lecturer_Management : Form
    {
        private LecturerController lecturerController = new LecturerController();
        public Lecturer_Management()
        {
            InitializeComponent();
           
        }

        private void Lecturer_Management_Load(object sender, EventArgs e)
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
            var lecturer = new Lecturer
            {
                LecturerName = name.Text,
                SubjectName = subject.Text,
                Address = addresstextbox.Text,
                Gender = gendercombobox.Text,
                Dateofbirth = dateofbirthTextBox1.Text,
                MobileNumber = mobilenum.Text,
                Email = emailtextbox.Text,

            };
            lecturerController.AddLecturer(lecturer);
            MessageBox.Show("SuccesFully Add Lecturer!", "Success" ,MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }

        private void lecturerData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lecturerData.SelectedRows.Count > 0)
            {
                name.Text = lecturerData.SelectedRows[0].Cells[" LectureID "].Value.ToString();
            }
        }
    }
    
}
