using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Model;

namespace UnicomTICManagementSystem.Views
{
    public partial class Mainlogin : Form
    {
        // Admin Loin Details========================
        internal string adminUsername = "admin";
        internal string adminPassword = "admin123";
        // Lecturer Login Details========================
        internal string LecturerUsername = "lecturer";
        internal string LecturerPassword = "lecturer123";
        //Staff Login Details==========================
        internal string StaffUsername = "newstaff";
        internal string StaffPassword = "newstaff123";
        // Student Login Details==========================
        internal string StudentUsername = "student";
        internal string StudentPassword = "student123";

        public Mainlogin()
        {
            InitializeComponent();
        }

        private void cancelbtn1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Mainlogin_Load(object sender, EventArgs e)
        {
           Admin_Interface adminInterface = new Admin_Interface();
           Lecturer lecturer = new Lecturer();
           StaffForm staff = new StaffForm();
           Student student = new Student();
        }

        private void loginbtn1_Click(object sender, EventArgs e)
        {
            string selectedRole = rolecomboBox1.SelectedItem?.ToString();
            string enteredUsername = username.Text.Trim();
            string enteredPassword = password.Text.Trim();

            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please select a role.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedRole == "admin")
            {
                if (enteredUsername == adminUsername && enteredPassword == adminPassword)
                {
                    MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Admin_Interface adminInterface = new Admin_Interface();
                    this.Hide();
                    adminInterface.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Admin credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (selectedRole == "lecturer")
            {
                if (enteredUsername == LecturerUsername && enteredPassword == LecturerPassword)
                {
                    MessageBox.Show("Lecturer login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Lectrer lecturerForm = new Lectrer();
                    this.Hide();
                    lecturerForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Admin credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (selectedRole == "newstaff")
            {
                if (enteredUsername == StaffUsername && enteredPassword == StaffPassword)
                {
                    MessageBox.Show("NewStaff login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StaffForm staff = new StaffForm();
                    this.Hide();
                    staff.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (selectedRole == "student")
            {
                if (enteredUsername == StudentUsername && enteredPassword == StudentPassword)
                {
                    MessageBox.Show("Student login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Student student = new Student();
                    this.Hide();
                    student.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid role.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }        
        }
    }
}
