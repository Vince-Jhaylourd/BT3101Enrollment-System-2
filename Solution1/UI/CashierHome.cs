using BusinessLogic.Repository;
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
    public partial class CashierHome : Form
    {
        private readonly StudentRepository _studentRepository =
            new StudentRepository();

        private readonly AssessmentRepository _assessmentRepository =
            new AssessmentRepository();

        public CashierHome()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            try
            {
                int totalStudents =
                    _studentRepository.GetTotalStudents();

                int totalEnrolledStudents =
                    _assessmentRepository.GetTotalEnrolledStudents();

                int totalSections =
                    _assessmentRepository.GetTotalSections();

                decimal collectionsToday =
                    _assessmentRepository.GetCollectionsToday();

                decimal outstandingBalance =
                    _assessmentRepository.GetOutstandingBalance();

                lblTotalofStudentsValue.Text =
                    totalStudents.ToString();

                lblTotalofEnrolledStudentsValue.Text =
                    totalEnrolledStudents.ToString();

                lblTotalofSectionsValue.Text =
                    totalSections.ToString();

                lblCollectionsValue.Text =
                    "₱" + collectionsToday.ToString("N2");

                lblOutstandingBalanceValue.Text =
                    "₱" + outstandingBalance.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load cashier dashboard: " + ex.Message
                );
            }
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

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            CashierPaymentHistory historyForm = new CashierPaymentHistory();
            historyForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

    }
}
