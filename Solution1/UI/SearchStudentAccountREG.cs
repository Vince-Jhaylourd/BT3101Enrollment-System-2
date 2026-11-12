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

namespace UI
{
    public partial class SearchStudentAccountREG: Form
    {
        private readonly StudentRepository _studentRepository =
    new StudentRepository();
        private readonly AssessmentRepository _assessmentRepository =
    new AssessmentRepository();
        public SearchStudentAccountREG()
        {
            InitializeComponent();
            LoadStudents();
        }
        private void LoadStudents()
        {
            try
            {
                dgvListofStudentREG.AutoGenerateColumns = true;
                dgvListofStudentREG.DataSource = _studentRepository.GetAll();

                dgvListofStudentREG.ReadOnly = true;
                dgvListofStudentREG.AllowUserToAddRows = false;

                dgvListofStudentREG.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvListofStudentREG.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load students: " + ex.Message);
            }
        }
        private void SearchStudents()
        {
            string searchText = txtStudents.Text.Trim().ToLower();

            var students = _studentRepository.GetAll();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dgvListofStudentREG.DataSource = students;
                return;
            }

            var filteredStudents = students
                .Where(student =>
                    student.StudentId.ToString().Contains(searchText) ||
                    student.LRN.ToLower().Contains(searchText) ||
                    student.FirstName.ToLower().Contains(searchText) ||
                    student.LastName.ToLower().Contains(searchText))
                .ToList();

            dgvListofStudentREG.DataSource = filteredStudents;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            RegistrarLandingPage HomeForm = new RegistrarLandingPage();
            HomeForm.Show();
            this.Hide();
        }

        private void btnStudentMaintenance_Click(object sender, EventArgs e)
        {
            StudentMaintenance StudentMaintenanceForm = new StudentMaintenance();
            StudentMaintenanceForm.Show();
            this.Hide();
        }

        private void btnStudentAssesssment_Click(object sender, EventArgs e)
        {
            StudentAssessment StudentAssessmentForm = new StudentAssessment();
            StudentAssessmentForm.Show();
            this.Hide();
        }

        private void btnStudentInformationReport_Click(object sender, EventArgs e)
        {
            StudentInformationReport studentInformationReportFormREG = new StudentInformationReport();
            studentInformationReportFormREG.Show();
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

        private void btnSearchStudentAccount_Click(object sender, EventArgs e)
        {
            SearchStudentAccountREG SeacrhStudentAccount = new SearchStudentAccountREG();
            SeacrhStudentAccount.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStudents();   
        }

        private void dgvListofStudentREG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string lastName = dgvListofStudentREG.Rows[e.RowIndex]
                .Cells["LastName"].Value?.ToString() ?? "";

            string firstName = dgvListofStudentREG.Rows[e.RowIndex]
                .Cells["FirstName"].Value?.ToString() ?? "";

            string middleName = dgvListofStudentREG.Rows[e.RowIndex]
                .Cells["MiddleName"].Value?.ToString() ?? "";

            lblStudent.Text =
                lastName + ", " + firstName + " " + middleName;

            int studentId = Convert.ToInt32(dgvListofStudentREG.Rows[e.RowIndex].Cells["StudentId"].Value);

            var account =
                _assessmentRepository.GetStudentAccount(studentId);

            if (account != null)
            {
                lblEnrollmentStatus.Text =
                    account.EnrollmentStatus;

                lblTotalAssessment.Text =
                    "₱" + account.TotalAssessment.ToString("N2");

                lblTotalPaid.Text =
                    "₱" + account.TotalPaid.ToString("N2");

                lblCurrentBalance.Text =
                    "₱" + account.CurrentBalance.ToString("N2");
            }
            else
            {
                lblEnrollmentStatus.Text = "Not Enrolled";
                lblTotalAssessment.Text = "₱0.00";
                lblTotalPaid.Text = "₱0.00";
                lblCurrentBalance.Text = "₱0.00";
            }
        }
    }
}
