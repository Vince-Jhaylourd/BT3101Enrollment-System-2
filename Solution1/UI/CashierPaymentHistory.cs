using System;
using System.Windows.Forms;
using BusinessLogic.Repository;
using Model;
using System.Drawing;
using System.Drawing.Printing;

namespace UI
{
    public partial class CashierPaymentHistory : Form
    {
        private readonly PaymentRepository _paymentRepository =
            new PaymentRepository();


        private PaymentReceipt receiptData = null;
        private int selectedPaymentId = 0;

        public CashierPaymentHistory()
        {
            InitializeComponent();
            LoadPaymentHistory();
        }

        private void LoadPaymentHistory(string searchText = "")
        {
            dgvPaymentHistory.DataSource =
                _paymentRepository.GetPaymentHistory(searchText);
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            CashierHome homeForm = new CashierHome();
            homeForm.Show();
            
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            CashierSearchStudent searchForm =
                new CashierSearchStudent();

            searchForm.Show();
            
        }

        private void btnCashiering_Click(object sender, EventArgs e)
        {
            CashierCashieringPayment paymentForm =
                new CashierCashieringPayment();

            paymentForm.Show();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to log out?",
                "Log out",
                MessageBoxButtons.YesNo
            ) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

            LoadPaymentHistory(txtSearchStudent.Text.Trim());
        }

        private void dgvPaymentHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            selectedPaymentId = Convert.ToInt32(
                dgvPaymentHistory.Rows[e.RowIndex]
                    .Cells["PaymentId"].Value
            );
        }

        private void btnViewReceipt_Click(object sender, EventArgs e)
        {
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

                    printDocument1.DefaultPageSettings.PaperSize =
                        new PaperSize("Receipt", 315, 600);

                    printDocument1.DefaultPageSettings.Margins =
                        new Margins(15, 15, 15, 15);

                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.PrintPreviewControl.AutoZoom = false;
                    printPreviewDialog1.PrintPreviewControl.Zoom = 0.75;

                    printPreviewDialog1.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open receipt: " + ex.Message);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (receiptData == null)
            {
                e.HasMorePages = false;
                return;
            }

            using (Font receiptFont = new Font("Consolas", 14, FontStyle.Regular))
            {
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                float lineHeight = receiptFont.GetHeight(e.Graphics) + 8;

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

        private string CenterText(string text, int width)
        {
            if (text.Length >= width)
                return text;

            int spaces = (width - text.Length) / 2;

            return new string(' ', spaces) + text;
        }
    }
}
