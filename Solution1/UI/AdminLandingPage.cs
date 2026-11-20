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
using BusinessLogic.Repository;

namespace UI
{
    public partial class AdminLandingPage : Form
    {
        private readonly StudentRepository _studentRepository =
    new StudentRepository();

        private readonly AssessmentRepository _assessmentRepository =
    new AssessmentRepository();
        private readonly SectionRepository _sectionRepository =
    new SectionRepository();
        private readonly PaymentRepository _paymentRepository =
    new PaymentRepository();

        public AdminLandingPage()
        {
            InitializeComponent();
            LoadDashboardStats();
        }
        private void LoadDashboardStats()
        {
            int totalStudents = _studentRepository.GetAll().Count;
            int totalEnrolled = _assessmentRepository.GetAssessedStudents().Count;
            int totalSections = _sectionRepository.GetTotalSections();

            lblTotalofStudentsValue.Text = totalStudents.ToString();
            lblTotalofEnrolledStudentsValue.Text = totalEnrolled.ToString();
            lblTotalofSectionsValue.Text = totalSections.ToString();

            //collectiontoday
            decimal collectionsToday = _paymentRepository.GetCollectionsToday();

            lblCollectionsValue.Text =
                collectionsToday.ToString("N2");
            //outstanding balance
            decimal outstandingBalance = _assessmentRepository.GetOutstandingBalance();

            lblOutstandingBalanceValue.Text =
                outstandingBalance.ToString("N2");
        }
        private void AdminLandingPage_Load(object sender, EventArgs e)
        {

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
            SearchStudentAccountADMIN studentForm = new SearchStudentAccountADMIN();
            studentForm.Show();
            this.Hide();
        }

        private void btnPaymentHistoryReceipst_Click(object sender, EventArgs e)
        {
          
            PaymentHistoryReceipts paymentForm = new PaymentHistoryReceipts();
            paymentForm.Show();
            this.Hide();
        }

        private void btnStudentInformationReport_Click(object sender, EventArgs e)
        {
         
             Student_InformationReport studentinfoForm = new Student_InformationReport();
            studentinfoForm.Show();
            this.Hide(); 

        }


        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out",
       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}