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
        private readonly SectionRepository _sectionRepository =
    new SectionRepository();
        public StudentInformationReport()
        {
            InitializeComponent();
            LoadGradeLevels();

            cmbGradeLevel.Enabled = false;
            cmbSection.Enabled = false;
        }

        private void LoadSections()
        {
            var sections = _sectionRepository.GetAllSections();

            string selectedGrade = cmbGradeLevel.Text;

            cmbSection.Items.Clear();

            var filteredSections = sections
                .Where(s => s.GradeLevel == selectedGrade)
                .Select(s => s.SectionName)
                .Distinct()
                .OrderBy(s => s)
                .ToList();

            foreach (var section in filteredSections)
            {
                cmbSection.Items.Add(section);
            }

            if (cmbSection.Items.Count > 0)
            {
                cmbSection.SelectedIndex = 0;
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
            // Filter by Section
            if (cmbFilterType.Text == "By Section")
            {
                if (cmbGradeLevel.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Grade Level.");
                    return;
                }

                if (cmbSection.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Section.");
                    return;
                }
            }

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

            cmbSection.Items.Clear();

            if (filterType == "By Section" &&
                !string.IsNullOrWhiteSpace(cmbGradeLevel.Text))
            {
                LoadSections();
            }
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
        }


        private void cmbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbFilterType.Text == "By Section")
            {
                LoadSections();
            }
        }


        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();


        }

        private int printRowIndex = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            Graphics graphics = e.Graphics;

            int left = 50;
            int top = 50;
            int rowHeight = 30;

            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 9, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 9);

            // REPORT TITLE
            graphics.DrawString(
                "STUDENT INFORMATION REPORT",
                titleFont,
                Brushes.Black,
                left,
                top
            );

            top += 40;

            // ACADEMIC YEAR
            graphics.DrawString(
                "Academic Year: " + txtAcademicYear.Text,
                bodyFont,
                Brushes.Black,
                left,
                top
            );

            top += 40;

            // COLUMN HEADERS
            int x = left;

            foreach (DataGridViewColumn column in dgvStudentInformationReport.Columns)
            {
                if (column.Visible)
                {
                    graphics.DrawString(
                        column.HeaderText,
                        headerFont,
                        Brushes.Black,
                        x,
                        top
                    );

                    x += 120;
                }
            }

            top += rowHeight;

            // STUDENT ROWS
            while (printRowIndex < dgvStudentInformationReport.Rows.Count)
            {
                DataGridViewRow row =
                    dgvStudentInformationReport.Rows[printRowIndex];

                if (!row.IsNewRow)
                {
                    x = left;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (dgvStudentInformationReport.Columns[cell.ColumnIndex].Visible)
                        {
                            string value = cell.Value?.ToString() ?? "";

                            graphics.DrawString(
                                value,
                                bodyFont,
                                Brushes.Black,
                                x,
                                top
                            );

                            x += 120;
                        }
                    }

                    top += rowHeight;
                }

                printRowIndex++;

                if (top > e.MarginBounds.Bottom - rowHeight)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            printRowIndex = 0;
            e.HasMorePages = false;
        }

    }
}

