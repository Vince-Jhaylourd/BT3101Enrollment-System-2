using BusinessLogic.Repository;
using Model;
using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

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
        private int currentPaymentId = 0;
        private PaymentReceipt receiptData = null;



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

            if (selectedStudentId == 0)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            decimal amount;

            if (!decimal.TryParse(txtPaymentAmount.Text, out amount)
                || amount <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.");
                return;
            }

            if (cmbPaymentScheme.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment scheme.");
                return;
            }

            StudentAccount account =
                _assessmentRepository.GetStudentAccount(selectedStudentId);

            if (account == null)
            {
                MessageBox.Show("Student account not found.");
                return;
            }

            if (amount > account.CurrentBalance)
            {
                MessageBox.Show(
                    "Payment amount cannot be greater than the remaining balance."
                );
                return;
            }

            int assessmentId =
                _paymentRepository.GetAssessmentId(selectedStudentId);

            if (assessmentId == 0)
            {
                MessageBox.Show(
                    "This student does not have an assessment yet."
                );
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to record this payment?",
                "Confirm Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                // Save payment and retrieve its ID
                currentPaymentId = _paymentRepository.RecordPayment(
                    assessmentId,
                    amount,
                    cmbPaymentScheme.Text,
                    txtReferenceNotes.Text
                );

                MessageBox.Show(
                    "Payment recorded successfully!",
                    "Payment Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Refresh account information
                RefreshStudentAccount();

                // Clear payment fields
                txtPaymentAmount.Clear();
                txtReferenceNotes.Clear();
                cmbPaymentScheme.SelectedIndex = -1;

                // Ask whether to open the official receipt
                DialogResult receiptResult = MessageBox.Show(
                    "Payment recorded. Open the official receipt now?",
                    "Official Receipt",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (receiptResult == DialogResult.Yes)
                {
                    receiptData =
                        _paymentRepository.GetPaymentReceipt(currentPaymentId);

                    if (receiptData != null)
                    {
                        printPreviewDialog1.Document = printDocument1;
                        printPreviewDialog1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Unable to retrieve payment receipt.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while recording payment:\n" + ex.Message,
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
        //CENTER TEXT FUNCTION
        private string CenterText(string text, int width)
        {
            if (text.Length >= width)
                return text;

            int spaces = (width - text.Length) / 2;

            return new string(' ', spaces) + text;
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (receiptData == null)
            {
                e.HasMorePages = false;
                return;
            }

            using (Font receiptFont = new Font("Consolas", 10))
            {
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;

                float lineHeight = receiptFont.GetHeight(e.Graphics) + 5;

                string separator = new string('=', 46);

                string receiptNumber =
                    "OR-" + DateTime.Now.Year + "-" +
                    receiptData.PaymentId.ToString("D6");

                string[] receiptLines =
                {
            separator,
            CenterText("OFFICIAL RECEIPT", 46),
            CenterText("Enrollment System - Cashier", 46),
            separator,
            "",
            "Receipt No.: " + receiptNumber,
            "Date: " + receiptData.PaymentDate,
            "Student ID: " + receiptData.StudentId,
            "Student Name: " + receiptData.StudentName,
            "",
            separator,
            "Previous Balance:    " +
                receiptData.PreviousBalance.ToString("N2"),
            "Amount Paid:         " +
                receiptData.Amount.ToString("N2"),
            "Payment Scheme:      " + receiptData.PaymentMethod,
            "Remaining Balance:   " +
                receiptData.RemainingBalance.ToString("N2"),
            separator,
            "Reference Notes:",
            string.IsNullOrWhiteSpace(receiptData.ReferenceNumber)
                ? "N/A"
                : receiptData.ReferenceNumber,
            "",
            separator,
            CenterText("Thank you!", 46),
            separator
        };

                foreach (string line in receiptLines)
                {
                    e.Graphics.DrawString(
                        line,
                        receiptFont,
                        Brushes.Black,
                        x,
                        y
                    );

                    y += lineHeight;
                }
            }

            e.HasMorePages = false;
        }
    
    }
}
