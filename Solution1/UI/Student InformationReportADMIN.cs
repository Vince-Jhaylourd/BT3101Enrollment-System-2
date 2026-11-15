using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace UI
{
    public partial class Student_InformationReport : Form
    {
        public Student_InformationReport()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLogOut_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to log out?", "Log out",
       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }

            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminLandingPage HomeForm = new AdminLandingPage();
            HomeForm.Show();

            this.Hide();
        }

        private void btnSectionManagement_Click(object sender, EventArgs e)
        {
            SectionManagement SectionManagementForm = new SectionManagement();
            SectionManagementForm.Show();
            this.Hide();
        }

        private void btnStudentSearchAccountADMIN_Click(object sender, EventArgs e)
        {
            SearchStudentAccountADMIN SearchStudentAccountADMINForm = new SearchStudentAccountADMIN(); 
            SearchStudentAccountADMINForm.Show();
            this.Hide();
        }

        private void btnPaymentHistoryReceipt_Click(object sender, EventArgs e)
        {
            PaymentHistoryReceipts paymentHistoryReceiptsForm = new PaymentHistoryReceipts();
            paymentHistoryReceiptsForm.Show();
            this.Hide();
        }

        private void btnStudentInformationReport_Click(object sender, EventArgs e)
        {
            Student_InformationReport studentInformationReportForm = new Student_InformationReport();
            studentInformationReportForm.Show();
            this.Hide();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagement userManagementForm = new UserManagement();
            userManagementForm.Show();
            this.Hide();
        }
    }
}

