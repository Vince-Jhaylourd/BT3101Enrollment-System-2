using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminLandingPage : Form
    {
        public AdminLandingPage()
        {
            InitializeComponent();
        }
        private void AdminLandingPage_Load(object sender, EventArgs e)
        {
            lstTotalStudents.Items.Add("Total students: 0");
            lstEnrollmentStudents.Items.Add("Enrolled students: 0");
            lstSections.Items.Add("Sections: 0");
            lstCollectionsToday.Items.Add("Collections today: 0.00");
            lstOutstandingBalances.Items.Add("Outstanding balances: 0.00");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSectionManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SectionManagement().ShowDialog();
            this.Show();
        }

        private void btnSearchStudentAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchStudentAccount().ShowDialog();
            this.Show();
        }

        private void btnPaymentHistoryReceipst_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PaymentHistoryReceipts().ShowDialog();
            this.Show();
        }

        private void btnStudentInformationReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Student_InformationReport().ShowDialog();
            this.Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserManagement().ShowDialog();
            this.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out",
       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}