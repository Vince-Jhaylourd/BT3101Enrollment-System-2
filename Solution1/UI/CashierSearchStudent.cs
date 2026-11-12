using System;
using System.Windows.Forms;
using BusinessLogic.Repository;
using Model;

namespace UI
{
    public partial class CashierSearchStudent : Form
    {
        private readonly StudentRepository _studentRepository =
            new StudentRepository();
        private readonly AssessmentRepository _assessmentRepository =
    new AssessmentRepository();

        public CashierSearchStudent()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            dgvStudents.DataSource = _studentRepository.GetAll();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            CashierHome homeForm = new CashierHome();
            homeForm.Show();
            this.Hide();
        }

        private void btnCashiering_Click(object sender, EventArgs e)
        {
            CashierCashieringPayment paymentForm =
                new CashierCashieringPayment();

            paymentForm.Show();
            this.Hide();
        }

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            CashierPaymentHistory historyForm =
                new CashierPaymentHistory();

            historyForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to log out?",
                "Log out",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

            int studentId = Convert.ToInt32(
                row.Cells["StudentId"].Value
            );

            string lastName =
                row.Cells["LastName"].Value?.ToString();

            string firstName =
                row.Cells["FirstName"].Value?.ToString();

            // Display student name
            lblStudentValue.Text =
                lastName + ", " + firstName;

            // Get student's assessment and payment information
            StudentAccount account =
                _assessmentRepository.GetStudentAccount(studentId);

            if (account != null)
            {
                lblEnrollmentStatusValue.Text =
                    account.EnrollmentStatus;

                lblTotalAssessmentValue.Text =
                    "₱" + account.TotalAssessment.ToString("N2");

                lblTotalPaidValue.Text =
                    "₱" + account.TotalPaid.ToString("N2");

                lblRemainingBalanceValue.Text =
                    "₱" + account.CurrentBalance.ToString("N2");
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchText = txtSearchStudent.Text.Trim();

            dgvStudents.DataSource =
                _studentRepository.Search(searchText);
        }
    }
}
