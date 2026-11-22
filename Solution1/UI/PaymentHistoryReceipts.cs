using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using BusinessLogic.Repository;
using Model;

namespace UI
{
    public partial class PaymentHistoryReceipts : Form
    {
        private readonly PaymentRepository _paymentRepository =new PaymentRepository();

        private PaymentReceipt receiptData;


        public PaymentHistoryReceipts()
        {
            InitializeComponent();


        }

        

        private void LoadPaymentHistory()
        {
            try
            {
                dgvPaymentHistory.DataSource =
                    _paymentRepository.GetPaymentHistory();

                dgvPaymentHistory.ReadOnly = true;
                dgvPaymentHistory.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvPaymentHistory.MultiSelect = false;
                dgvPaymentHistory.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load payment history: " + ex.Message);
            }
        }

        private void dgvPaymentHistory_CellDoubleClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                int paymentId = Convert.ToInt32(
                    dgvPaymentHistory.Rows[e.RowIndex]
                    .Cells["PaymentId"].Value);

                receiptData =
                    _paymentRepository.GetPaymentReceipt(paymentId);

                if (receiptData == null)
                {
                    MessageBox.Show("Receipt not found.");
                    return;
                }

                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to open receipt.\n" + ex.Message);
            }
        }



        private string CenterText(string text, int width)
        {
            if (text.Length >= width)
                return text;

            int spaces = (width - text.Length) / 2;

            return new string(' ', spaces) + text;
        }

        private void btnHome_Click(object sender, EventArgs e)
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
            SearchStudentAccountADMIN studentForm =
                new SearchStudentAccountADMIN();

            studentForm.Show();
            this.Hide();
        }

        private void btnPaymentHistoryReceipst_Click(object sender, EventArgs e)
        {
            PaymentHistoryReceipts paymentHistoryReceiptsForm =
                new PaymentHistoryReceipts();

            paymentHistoryReceiptsForm.Show();
            this.Hide();
        }

        private void btnStudentInformationReport_Click(object sender, EventArgs e)
        {
            Student_InformationReport studentinfoForm =
                new Student_InformationReport();

            studentinfoForm.Show();
            this.Hide();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to log out?",
                "Log out",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }

        }

        private void btnViewPrintReceipts_Click(object sender, EventArgs e)
        {
            if (dgvPaymentHistory.CurrentRow == null)
            {
                MessageBox.Show("Please select a payment first.",
                    "No Payment Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int paymentId = Convert.ToInt32(
                    dgvPaymentHistory.CurrentRow.Cells["PaymentId"].Value);

                receiptData = _paymentRepository.GetPaymentReceipt(paymentId);

                if (receiptData == null)
                {
                    MessageBox.Show("Unable to retrieve the receipt.");
                    return;
                }

                printPreviewDialog1.Document = printDocument1;

                printPreviewDialog1.PrintPreviewControl.AutoZoom = false;
                printPreviewDialog1.PrintPreviewControl.Zoom = 0.80;

                printPreviewDialog1.ShowDialog();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open receipt: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearchTransaction.Text.Trim();

                dgvPaymentHistory.DataSource =
                    _paymentRepository.GetPaymentHistory(searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
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

                string receiptNumber = "OR-" +
                    DateTime.Now.Year + "-" +
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
            "Previous Balance:    " + receiptData.PreviousBalance.ToString("N2"),
            "Amount Paid:         " + receiptData.Amount.ToString("N2"),
            "Payment Scheme:      " + receiptData.PaymentMethod,
            "Remaining Balance:   " + receiptData.RemainingBalance.ToString("N2"),
            separator,
            "Reference Notes:",
            string.IsNullOrWhiteSpace(receiptData.ReferenceNumber)
                ? "N/A" : receiptData.ReferenceNumber,
            "",
            separator,
            CenterText("Thank you!", 46),
            separator
        };

                foreach (string line in receiptLines)
                {
                    e.Graphics.DrawString(
                        line, receiptFont, Brushes.Black, x, y);

                    y += lineHeight;
                }
            }

            e.HasMorePages = false;
        }

        private void PaymentHistoryReceipts_Load_1(object sender, EventArgs e)
        {
            LoadPaymentHistory();
        }
    }
    
}
