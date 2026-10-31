using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CashierPaymentHistory : Form
    {
        public CashierPaymentHistory()
        {
            InitializeComponent();
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

        private void btnCashiering_Click(object sender, EventArgs e)
        {
            CashierCashieringPayment paymentForm = new CashierCashieringPayment();
            paymentForm.Show();
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
    }
}
