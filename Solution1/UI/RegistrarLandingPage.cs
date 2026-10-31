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
    public partial class RegistrarLandingPage : Form
    {
        public RegistrarLandingPage()
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
            RegistrarLandingPage StudentMaintenanceForm = new RegistrarLandingPage();
            StudentMaintenanceForm.Show();
            this.Hide();

        }

        private void btnStudentAssesssment_Click(object sender, EventArgs e)
        {
            RegistrarLandingPage StudentAssessmentForm = new RegistrarLandingPage();
            StudentAssessmentForm.Show();
            this.Hide();
        }

        private void btnSearchStudentAccount_Click(object sender, EventArgs e)
        {
            RegistrarLandingPage SeacrhStudentAccount = new RegistrarLandingPage();
            SeacrhStudentAccount.Show();
            this.Hide();

        }

        private void btnStudentInformationReport_Click(object sender, EventArgs e)
        {
            

        }
    }
}
