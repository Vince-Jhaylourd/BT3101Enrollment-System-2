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
    public partial class SearchStudentAccountADMIN : Form
    {
        private readonly StudentRepository _studentRepository =
    new StudentRepository();
        private readonly AssessmentRepository _assessmentRepository =
    new AssessmentRepository();

        public SearchStudentAccountADMIN()
        {
            InitializeComponent();
            LoadAllStudents();
        }

        private void LoadAllStudents()
        {
            var students = _studentRepository.GetAll();

            dgvListOfStudentADMIN.DataSource = null;
            dgvListOfStudentADMIN.AutoGenerateColumns = true;
            dgvListOfStudentADMIN.DataSource = students;
        }

        private void LoadStudentAccountDetails(int studentId)
        {
            var account = _assessmentRepository.GetStudentAccount(studentId);

            if (account == null)
            {
                lblTotalAssessment.Text = "0.00";
                lblTotalPaid.Text = "0.00";
                lblEnrollmentStatus.Text = "Not Enrolled";
                lblCurrentBalance.Text = "0.00";
                return;
            }

            lblTotalAssessment.Text = account.TotalAssessment.ToString("N2");
            lblTotalPaid.Text = account.TotalPaid.ToString("N2");
            lblEnrollmentStatus.Text = account.EnrollmentStatus;
            lblCurrentBalance.Text = account.CurrentBalance.ToString("N2");
        }
        private void SearchStudents()
        {
            string searchText = txtStudentAdmin.Text.Trim().ToLower();

            var students = _studentRepository.GetAll();

            var results = students.Where(student =>
                student.StudentId.ToString().Contains(searchText) ||
                (student.LRN ?? "").ToLower().Contains(searchText) ||
                (student.FirstName ?? "").ToLower().Contains(searchText) ||
                (student.LastName ?? "").ToLower().Contains(searchText)
            ).ToList();

            dgvListOfStudentADMIN.DataSource = null;
            dgvListOfStudentADMIN.AutoGenerateColumns = true;
            dgvListOfStudentADMIN.DataSource = results;

            if (results.Count == 0)
            {
                MessageBox.Show("No matching student found.");
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHomeAdmin_Click(object sender, EventArgs e)
        {
            AdminLandingPage homeForm = new AdminLandingPage();
            homeForm.Show();
            this.Hide();
        }

        private void btnSectionManagement_Click(object sender, EventArgs e)
        {
            SectionManagement sectionForm = new SectionManagement();
            sectionForm.Show();
            this.Hide();
        }

        private void btnSearchStudentAccount_Click(object sender, EventArgs e)
        {
            SearchStudentAccountADMIN studentForm = new SearchStudentAccountADMIN();
            studentForm.Show();
            this.Hide();
        }

        private void btnPaymentHistoryReceipst_Click(object sender, EventArgs e)
        {
            PaymentHistoryReceipts paymentForm = new PaymentHistoryReceipts();
            paymentForm.Show();
            this.Hide();
        }

        private void btnStudentInformationReport_Click(object sender, EventArgs e)
        {
            Student_InformationReport studentInformationReportFormADMIN = new Student_InformationReport();
            studentInformationReportFormADMIN.Show();
            this.Hide();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btnSearchADMIN_Click(object sender, EventArgs e)
        {

            SearchStudents();
        }

        private void DisplayStudentDetails()
        {
            if (dgvListOfStudentADMIN.CurrentRow == null)
                return;

            var row = dgvListOfStudentADMIN.CurrentRow;

            string firstName = row.Cells["FirstName"].Value?.ToString() ?? "";
            string lastName = row.Cells["LastName"].Value?.ToString() ?? "";
            string middleName = row.Cells["MiddleName"].Value?.ToString() ?? "";

            lblStudent.Text = $"{lastName}, {firstName} {middleName}".Trim();

            int studentId = Convert.ToInt32(row.Cells["StudentId"].Value);

            LoadStudentAccountDetails(studentId);
        }

        private void dgvListOfStudentADMIN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DisplayStudentDetails();
        }
    }
}
