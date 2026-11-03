using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Repository;
using System.Windows.Forms;

namespace UI
{
    public partial class RegistrarLandingPage : Form
    {
        private readonly StudentRepository _studentRepository = new StudentRepository();
        public RegistrarLandingPage()
        {
            InitializeComponent();

            LoadDashboard();

        }
        private void LoadDashboard()
        {
            try
            {
                int totalStudents = _studentRepository.GetTotalStudents();

                lblTotalofStudentsValue.Text = totalStudents.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load dashboard: " + ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            RegistrarLandingPage homeForm = new RegistrarLandingPage();
            homeForm.Show();
            this.Hide();
        }

        private void btnStudentMaintenance_Click(object sender, EventArgs e)
        {
            StudentMaintenance StudentMaintenanceForm = new StudentMaintenance();
            StudentMaintenanceForm.Show();
            this.Hide();

        }

        private void btnStudentAssesssment_Click(object sender, EventArgs e)
        {
            StudentAssessment StudentAssessmentForm = new StudentAssessment();
            StudentAssessmentForm.Show();
            this.Hide();
        }

        private void btnSearchStudentAccount_Click(object sender, EventArgs e)
        {
            SearchStudentAccountREG SeacrhStudentAccount = new SearchStudentAccountREG();
            SeacrhStudentAccount.Show();
            this.Hide();

        }

        private void btnStudentInformationReport_Click(object sender, EventArgs e)
        {
            StudentInformationReport studentInformationReportForm = new StudentInformationReport();
            studentInformationReportForm.Show();
            this.Hide();

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out",
       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();

                this.Hide();

            }
            else
            {
                return;
            }
            
        }
    }
}
