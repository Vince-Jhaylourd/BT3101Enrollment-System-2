using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Repository;
using Model;

namespace UI
{
    public partial class StudentMaintenance : Form
    {

        private readonly StudentRepository _studentRepository;
        private int selectedStudentId = 0;

        public StudentMaintenance()
        {
            InitializeComponent();


            _studentRepository = new StudentRepository();

            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");

            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadStudents();
        }
        private void LoadStudents()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = _studentRepository.GetAll();


            dgvStudents.Columns["StudentId"].Visible = false;
        }
        private Student GetStudentFromForm()
        {
            return new Student
            {
                StudentId = selectedStudentId,
                LRN = txtLRN.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                MiddleName = txtMiddleName.Text.Trim(),
                Gender = cbGender.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                ContactNo = txtContactInfo.Text.Trim(),
                GuardianName = txtGuardianName.Text.Trim(),
                GuardianContact = txtGuardianContactInfo.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };
        }
        private void ClearForm()
        {
            selectedStudentId = 0;

            txtLRN.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();

            cbGender.SelectedIndex = -1;

            dtpDateOfBirth.Value = DateTime.Today;

            txtContactInfo.Clear();
            txtGuardianName.Clear();
            txtGuardianContactInfo.Clear();
            txtAddress.Clear();

            dgvStudents.ClearSelection();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            RegistrarLandingPage HomeForm = new RegistrarLandingPage();
            HomeForm.Show();
            this.Hide();
        }

        private void btnStudentMaintenance_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStudentAssesssment_Click(object sender, EventArgs e)
        {
            StudentAssessment StudentAssessmentForm = new StudentAssessment();
            StudentAssessmentForm.Show();
            this.Hide();
        }

        private void btnSearchStudentAccount_Click(object sender, EventArgs e)
        {
            SearchStudentAccount SeacrhStudentAccount = new SearchStudentAccount();
            SeacrhStudentAccount.Show();
            this.Hide();
        }

        private void btnStudentInformationReport_Click(object sender, EventArgs e)
        {
            StudentInformationReport studentInformationReportForm = new StudentInformationReport();
            studentInformationReportForm.Show();
            this.Hide();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out",
       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
            this.Hide();
        }

        private void StudentMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = GetStudentFromForm();

                int newStudentId = _studentRepository.Add(student);

                MessageBox.Show("Student added successfully!");

                LoadStudents();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

            selectedStudentId = Convert.ToInt32(row.Cells["StudentId"].Value);

            txtLRN.Text = row.Cells["LRN"].Value?.ToString();
            txtLastName.Text = row.Cells["LastName"].Value?.ToString();
            txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
            txtMiddleName.Text = row.Cells["MiddleName"].Value?.ToString();
            cbGender.Text = row.Cells["Gender"].Value?.ToString();

            if (row.Cells["DateOfBirth"].Value != null)
                dtpDateOfBirth.Value =
                    Convert.ToDateTime(row.Cells["DateOfBirth"].Value);

            txtContactInfo.Text = row.Cells["ContactNo"].Value?.ToString();
            txtGuardianName.Text = row.Cells["GuardianName"].Value?.ToString();
            txtGuardianContactInfo.Text =
                row.Cells["GuardianContact"].Value?.ToString();
            txtAddress.Text = row.Cells["Address"].Value?.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (selectedStudentId == 0)
                {
                    MessageBox.Show("Please select a student first.");
                    return;
                }

                Student student = GetStudentFromForm();

                _studentRepository.Update(student);

                MessageBox.Show("Student updated successfully!");

                LoadStudents();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (selectedStudentId == 0)
                {
                    MessageBox.Show("Please select a student first.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this student?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    _studentRepository.Delete(selectedStudentId);

                    MessageBox.Show("Student deleted successfully!");

                    LoadStudents();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
    }
}
