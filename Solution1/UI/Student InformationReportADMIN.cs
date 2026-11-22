using BusinessLogic.Repository;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class Student_InformationReport : Form
    {
        private int _printRowIndex = 0;

        private readonly AssessmentRepository _assessmentRepository =
    new AssessmentRepository();

        private readonly SectionRepository _sectionRepository = new SectionRepository();

        public Student_InformationReport()
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

        private void LoadStudentReport()
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbFilterType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Filter Type.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAcademicYear.Text))
            {
                MessageBox.Show("Please enter the Academic Year.");
                txtAcademicYear.Focus();
                return;
            }

            if (cmbFilterType.Text == "By Grade Level" &&
                cmbGradeLevel.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a Grade Level.");
                cmbGradeLevel.Focus();
                return;
            }

            if (cmbFilterType.Text == "By Section" &&
                cmbSection.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a Section.");
                cmbSection.Focus();
                return;
            }

            LoadStudentReport();

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

        private void cmbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSections();
        }

        private void cmbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {

            string filterType = cmbFilterType.Text;

            cmbGradeLevel.Enabled = filterType == "By Grade Level"
                                 || filterType == "By Section";

            cmbSection.Enabled = filterType == "By Section";
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {

            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.PrintPreviewControl.AutoZoom = false;
            printPreviewDialog1.PrintPreviewControl.Zoom = 0.80;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 100;
            int rowHeight = 30;
            int x = 50;

            e.Graphics.DrawString(
                "STUDENT INFORMATION REPORT",
                new Font("Arial", 16, FontStyle.Bold),
                Brushes.Black,
                x,
                40
            );

            e.Graphics.DrawString(
                "Academic Year: " + txtAcademicYear.Text,
                new Font("Arial", 10),
                Brushes.Black,
                x,
                70
            );

            // Print column headers
            int columnX = x;

            foreach (DataGridViewColumn column in dgvStudentInformationReport.Columns)
            {
                if (column.Visible)
                {
                    e.Graphics.DrawString(
                        column.HeaderText,
                        new Font("Arial", 8, FontStyle.Bold),
                        Brushes.Black,
                        columnX,
                        y
                    );

                    columnX += 100;
                }
            }

            y += rowHeight;

            // Print student rows
            while (_printRowIndex < dgvStudentInformationReport.Rows.Count)
            {
                DataGridViewRow row = dgvStudentInformationReport.Rows[_printRowIndex];

                if (!row.IsNewRow)
                {
                    columnX = x;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (dgvStudentInformationReport.Columns[cell.ColumnIndex].Visible)
                        {
                            string value = Convert.ToString(cell.Value);

                            e.Graphics.DrawString(
                                value,
                                new Font("Arial", 8),
                                Brushes.Black,
                                columnX,
                                y
                            );

                            columnX += 100;
                        }
                    }

                    y += rowHeight;
                }

                _printRowIndex++;

                if (y > e.MarginBounds.Bottom - rowHeight)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            _printRowIndex = 0;
            e.HasMorePages = false;
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _printRowIndex = 0;
        }
    }
}


