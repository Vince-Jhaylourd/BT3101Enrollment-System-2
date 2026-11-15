using BusinessLogic.Repository;
using Model;
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
        private readonly StudentRepository _studentRepository = new StudentRepository();
        private readonly AssessmentRepository _assessmentRepository =
    new AssessmentRepository();
        public StudentInformationReport()
        {
            InitializeComponent();
            LoadGradeLevels();

            cmbGradeLevel.Enabled = false;
            cmbSection.Enabled = false;
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

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out",
       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
            this.Hide();
        }

        private void btnStudentInformationReport_Click(object sender, EventArgs e)
        {
            Student_InformationReport student_InformationReport = new Student_InformationReport();
            student_InformationReport.Show();
            this.Hide();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var students = _assessmentRepository.GetAssessedStudents();

            // Filter by Grade Level
            if (cmbFilterType.Text == "By Grade Level")
            {
                string selectedGrade = cmbGradeLevel.Text;

                students = students
                    .Where(s =>
                    {
                        var property = s.GetType().GetProperty("GradeLevel");

                        return property != null &&
                               Convert.ToString(property.GetValue(s)) == selectedGrade;
                    })
                    .ToList();
            }

            // Filter by Section
            else if (cmbFilterType.Text == "By Section")
            {
                string selectedGrade = cmbGradeLevel.Text;
                string selectedSection = cmbSection.Text;

                students = students
                    .Where(s =>
                    {
                        var gradeProperty = s.GetType().GetProperty("GradeLevel");
                        var sectionProperty = s.GetType().GetProperty("Section");

                        return gradeProperty != null &&
                               sectionProperty != null &&
                               Convert.ToString(gradeProperty.GetValue(s)) == selectedGrade &&
                               Convert.ToString(sectionProperty.GetValue(s)) == selectedSection;
                    })
                    .ToList();
            }

            // Filter by Academic Year
            string selectedYear = txtAcademicYear.Text.Trim();

            if (!string.IsNullOrWhiteSpace(selectedYear))
            {
                students = students
                    .Where(s =>
                    {
                        var property = s.GetType().GetProperty("SchoolYear");

                        return property != null &&
                               Convert.ToString(property.GetValue(s)) == selectedYear;
                    })
                    .ToList();
            }

            dgvStudentInformationReport.DataSource = null;
            dgvStudentInformationReport.DataSource = students;

        }

        private void cmbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterType = cmbFilterType.Text;

            cmbGradeLevel.Enabled = filterType == "By Grade Level"
                                 || filterType == "By Section";

            cmbSection.Enabled = filterType == "By Section";
        }
        private void LoadGradeLevels()
        {
            cmbGradeLevel.Items.Clear();

            cmbGradeLevel.Items.Add("Grade 1");
            cmbGradeLevel.Items.Add("Grade 2");
            cmbGradeLevel.Items.Add("Grade 3");
            cmbGradeLevel.Items.Add("Grade 4");
            cmbGradeLevel.Items.Add("Grade 5");
            cmbGradeLevel.Items.Add("Grade 6");
            cmbGradeLevel.Items.Add("Grade 7");
            cmbGradeLevel.Items.Add("Grade 8");
            cmbGradeLevel.Items.Add("Grade 9");
            cmbGradeLevel.Items.Add("Grade 10");
            cmbGradeLevel.Items.Add("Grade 11");
            cmbGradeLevel.Items.Add("Grade 12");
        }

    }
}
