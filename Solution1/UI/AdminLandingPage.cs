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
           
        }

        private void btnSectionManagement_Click(object sender, EventArgs e)
        {
        
           SectionManagement SectionForm = new SectionManagement();
            SectionForm.Show();
            this.Hide();
        }

        private void btnSearchStudentAccount_Click(object sender, EventArgs e)
        {
          
            SearchStudentAccount SearchStudentForm = new SearchStudentAccount();
            SearchStudentForm.Show();
            this.Hide();
        }

        private void btnPaymentHistoryReceipst_Click(object sender, EventArgs e)
        {
        
            PaymentHistoryReceipts PaymentReceiptForms = new PaymentHistoryReceipts();
            PaymentReceiptForms.Show();
            this.Hide();
        }

        private void btnStudentInformationReport_Click(object sender, EventArgs e)
        {
         
            Student_InformationReport StudentInfoForm = new Student_InformationReport();
            StudentInfoForm.Show();
            this.Hide();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            
            UserManagement UserManagementForm = new UserManagement();
            UserManagementForm.Show();
            this.Hide();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
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