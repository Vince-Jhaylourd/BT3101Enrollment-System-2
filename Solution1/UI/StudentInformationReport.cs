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
    public partial class StudentInformationReport : Form
    {
        public StudentInformationReport()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            RegistrarLandingPage HomeForm = new RegistrarLandingPage();
            HomeForm.Show();
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
            SearchStudentAccount SeacrhStudentAccount = new SearchStudentAccount();
            SeacrhStudentAccount.Show();
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
