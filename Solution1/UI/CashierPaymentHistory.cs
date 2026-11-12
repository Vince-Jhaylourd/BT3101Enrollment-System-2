using System;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public partial class CashierPaymentHistory : Form
    {
        private readonly PaymentRepository _paymentRepository =
            new PaymentRepository();

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
            this.Hide();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            CashierSearchStudent searchForm =
                new CashierSearchStudent();

            searchForm.Show();
            this.Hide();
        }

        private void btnCashiering_Click(object sender, EventArgs e)
        {
            CashierCashieringPayment paymentForm =
                new CashierCashieringPayment();

            paymentForm.Show();
            this.Hide();
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
            //if (selectedPaymentId == 0)
            //{
            //MessageBox.Show("Please select a payment first.");
            //return;
            //}

            //CashierPaymentReceipt receiptForm =
            //    new CashierPaymentReceipt(selectedPaymentId);

            //receiptForm.Show();
        }
    }
}
