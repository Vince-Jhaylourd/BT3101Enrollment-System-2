using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public partial class StudentAssessment : Form
    {
        private readonly StudentRepository _studentRepository;
        public StudentAssessment()
        {
            InitializeComponent();
            _studentRepository = new StudentRepository();
            LoadStudents();
        }
        private void LoadStudents()
        {
            try
            {
                dgvListofStudents.AutoGenerateColumns = true;
                dgvListofStudents.DataSource = _studentRepository.GetAll();

                dgvListofStudents.ReadOnly = true;
                dgvListofStudents.AllowUserToAddRows = false;
                dgvListofStudents.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvListofStudents.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;


                dgvListofStudents1.AutoGenerateColumns = true;
                dgvListofStudents1.DataSource = _studentRepository.GetAll();

                dgvListofStudents1.ReadOnly = true;
                dgvListofStudents1.AllowUserToAddRows = false;
                dgvListofStudents1.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvListofStudents1.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load students: " + ex.Message);
            }
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
            }
            this.Hide();
        }
    }
}
