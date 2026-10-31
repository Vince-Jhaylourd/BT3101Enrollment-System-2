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
    public partial class StudentMaintenance : Form
    {
        public StudentMaintenance()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            RegistrarLandingPage homeForm = new RegistrarLandingPage();
            homeForm.Show();
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

       
    }
}
