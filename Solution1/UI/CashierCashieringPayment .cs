using System;
using System.Windows.Forms;
using BusinessLogic.Repository;
using Model;

namespace UI
{
    public partial class CashierCashieringPayment : Form
    {
        // Add the StudentRepository instance
        private readonly StudentRepository _studentRepository =
    new StudentRepository();

        // Add the AssessmentRepository instance
        private readonly AssessmentRepository _assessmentRepository =
            new AssessmentRepository();

        // Add the PaymentRepository instance
        private readonly PaymentRepository _paymentRepository =
    new PaymentRepository();

        private int selectedStudentId = 0;
        public CashierCashieringPayment()
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

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            CashierSearchStudent searchForm = new CashierSearchStudent();
            searchForm.Show();
            this.Hide();
        }

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            CashierPaymentHistory historyForm = new CashierPaymentHistory();
            historyForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to log out?", "Log out",
       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchStudent.Text.Trim();

            dgvStudents.DataSource =
                _studentRepository.Search(searchText);
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

            selectedStudentId = Convert.ToInt32(
                row.Cells["StudentId"].Value
            );

            string lastName =
                row.Cells["LastName"].Value?.ToString();

            string firstName =
                row.Cells["FirstName"].Value?.ToString();

            lblStudentValue.Text =
                lastName + ", " + firstName;

            StudentAccount account =
                _assessmentRepository.GetStudentAccount(selectedStudentId);

            if (account != null)
            {
                lblTotalAssessmentValue.Text =
                    "₱" + account.TotalAssessment.ToString("N2");

                lblTotalPaidValue.Text =
                    "₱" + account.TotalPaid.ToString("N2");

                lblRemainingBalanceValue.Text =
                    "₱" + account.CurrentBalance.ToString("N2");
            }
        }

        private void btnRecordPayment_Click(object sender, EventArgs e)
        {
            // Ensure a student is selected
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            // Validate payment amount
            decimal amount;

            if (!decimal.TryParse(txtPaymentAmount.Text, out amount)
                || amount <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.");
                return;
            }

            // Check payment method
            if (cmbPaymentScheme.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment scheme.");
                return;
            }

            // Get the student's current account
            StudentAccount account =
                _assessmentRepository.GetStudentAccount(selectedStudentId);

            if (account == null)
            {
                MessageBox.Show("Student account not found.");
                return;
            }

            // Prevent overpayment
            if (amount > account.CurrentBalance)
            {
                MessageBox.Show(
                    "Payment amount cannot be greater than the remaining balance."
                );
                return;
            }

            // Get assessment
            int assessmentId =
                _paymentRepository.GetAssessmentId(selectedStudentId);

            if (assessmentId == 0)
            {
                MessageBox.Show(
                    "This student does not have an assessment yet."
                );
                return;
            }
        }
        private void RefreshStudentAccount()
        {
            if (selectedStudentId == 0)
                return;

            StudentAccount account =
                _assessmentRepository.GetStudentAccount(selectedStudentId);

            if (account != null)
            {
                lblTotalAssessmentValue.Text =
                    "₱" + account.TotalAssessment.ToString("N2");

                lblTotalPaidValue.Text =
                    "₱" + account.TotalPaid.ToString("N2");

                lblRemainingBalanceValue.Text =
                    "₱" + account.CurrentBalance.ToString("N2");
            }
        }
    }
}
