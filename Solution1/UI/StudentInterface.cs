using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class StudentInterface : Form
    {
        public StudentInterface()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StudentController controller = new StudentController();

            var students = controller.GetStudents(txtSearch.Text);
            dgvStudents.DataSource = students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validation for required fields
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtLRN.Text) 
                || string.IsNullOrWhiteSpace(txtContactInfo.Text) || string.IsNullOrWhiteSpace(txtGuardianContact.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (txtLRN.Text.Length != 12 || !long.TryParse(txtLRN.Text, out _))
            {
                MessageBox.Show("Please enter a valid 12-digit LRN.");
                return;
            }


            StudentController controller = new StudentController();


            Student student = new Student {

                FullName = txtFullName.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                LRN = txtLRN.Text,
                ContactInfo = txtContactInfo.Text,
                GuardianContactInfo = txtGuardianContact.Text,
                isActive = true
            };
            controller.AddStudent(student);
            MessageBox.Show("Student added successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //validation for required fields
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtLRN.Text)
                || string.IsNullOrWhiteSpace(txtContactInfo.Text) || string.IsNullOrWhiteSpace(txtGuardianContact.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (txtLRN.Text.Length != 12 || !long.TryParse(txtLRN.Text, out _))
            {
                MessageBox.Show("Please enter a valid 12-digit LRN.");
                return;
            }


            StudentController controller = new StudentController();

            Student student = new Student
            {
                StudentId = Convert.ToInt32(txtStudentID.Text),
                FullName = txtFullName.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                LRN = txtLRN.Text,
                ContactInfo = txtContactInfo.Text,
                GuardianContactInfo = txtGuardianContact.Text,
                isActive = true

            };
            controller.UpdateStudent(student);
            MessageBox.Show("Student updated successfully >//<");
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

            txtStudentID.Text = row.Cells["StudentId"].Value.ToString();
            txtFullName.Text = row.Cells["FullName"].Value.ToString();
            dtpDateOfBirth.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
            txtLRN.Text = row.Cells["LRN"].Value.ToString();
            txtContactInfo.Text = row.Cells["ContactInfo"].Value.ToString();
            txtGuardianContact.Text = row.Cells["GuardianContactInfo"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                StudentController controller = new StudentController();
                int studentId = Convert.ToInt32(txtStudentID.Text);
                controller.DeleteStudent(studentId);
                MessageBox.Show("Student deleted successfully!");

                txtSearch.Text = "";
                var students = controller.GetStudents("");
                dgvStudents.DataSource = students;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            txtLRN.Clear();
            txtContactInfo.Clear();
            txtGuardianContact.Clear();

            dtpDateOfBirth.Value = DateTime.Today;
            dgvStudents.ClearSelection();
        }
    }
}
