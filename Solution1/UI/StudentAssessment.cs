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
        private readonly AssessmentRepository _assessmentRepository;
        private int selectedStudentId = 0;
        public StudentAssessment()
        {
            InitializeComponent();

            _studentRepository = new StudentRepository();
            _assessmentRepository = new AssessmentRepository();

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
                dgvListofStudents1.DataSource = _assessmentRepository.GetAssessedStudents();
                // Format currency columns
                if (dgvListofStudents1.Columns["TotalFees"] != null)
                {
                    dgvListofStudents1.Columns["TotalFees"].DefaultCellStyle.Format = "₱#,##0.00";
                }

                if (dgvListofStudents1.Columns["Discount"] != null)
                {
                    dgvListofStudents1.Columns["Discount"].DefaultCellStyle.Format = "₱#,##0.00";
                }

                if (dgvListofStudents1.Columns["TotalPaid"] != null)
                {
                    dgvListofStudents1.Columns["TotalPaid"].DefaultCellStyle.Format = "₱#,##0.00";
                }

                if (dgvListofStudents1.Columns["Balance"] != null)
                {
                    dgvListofStudents1.Columns["Balance"].DefaultCellStyle.Format = "₱#,##0.00";
                }


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
        private void SearchStudents()
        {
            string searchText = txtSearchStudent.Text.Trim().ToLower();

            var students = _studentRepository.GetAll();

            var filteredStudents = students
                .Where(student =>
                    student.LRN.ToLower().Contains(searchText) ||
                    student.FirstName.ToLower().Contains(searchText) ||
                    student.LastName.ToLower().Contains(searchText))
                .ToList();

            dgvListofStudents.DataSource = filteredStudents;
        }
        private void CalculateAssessment(object sender, EventArgs e)
        {
            string gradeLevel = cbGradelevel.Text.Trim();

            decimal tuition = _assessmentRepository.GetTuitionFee(gradeLevel);
            decimal mandatoryFees =
                _assessmentRepository.GetMandatorySchoolFees(gradeLevel);

            string discountText = cbDiscountSchoolarship.Text
                .Replace("%", "")
                .Trim();

            decimal discountPercent = 0;
            decimal.TryParse(discountText, out discountPercent);

            decimal discount = _assessmentRepository.CalculateDiscount(
                tuition, discountPercent);

            decimal total = _assessmentRepository.CalculateTotalAssessment(
                tuition, mandatoryFees, discount);

            lblTuition.Text = "₱" + tuition.ToString("N2");
            lblMandatorySchoolFees.Text = "₱" + mandatoryFees.ToString("N2");
            lblDiscount.Text = "₱" + discount.ToString("N2");
            lblTotalAssessment.Text = "₱" + total.ToString("N2");
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

        private void cbDiscountSchoolarship_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateAssessment(sender, e);
        }

        private void cbGradelevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateAssessment(sender, e);
        }

        private void btnComputeSaveAssessment_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a student was selected
                if (selectedStudentId == 0)
                {
                    MessageBox.Show("Please select a student first.");
                    return;
                }

                // Get Grade Level and School Year
                string gradeLevel = cbGradelevel.Text.Trim();
                string schoolYear = txtSchoolYear.Text.Trim();

                if (string.IsNullOrWhiteSpace(gradeLevel))
                {
                    MessageBox.Show("Please select a Grade Level.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(schoolYear))
                {
                    MessageBox.Show("Please enter a School Year.");
                    return;
                }
                if (_assessmentRepository.HasEnrollment(selectedStudentId, schoolYear))
                {
                    MessageBox.Show(
                        "This student is already enrolled and assessed for this school year."
                    );
                    return;
                }


                // Calculate fees
                decimal tuition =
                    _assessmentRepository.GetTuitionFee(gradeLevel);

                decimal mandatoryFees =
                    _assessmentRepository.GetMandatorySchoolFees(gradeLevel);

                // Get discount percentage
                string discountText = cbDiscountSchoolarship.Text
                    .Replace("%", "")
                    .Trim();

                decimal discountPercent = 0;
                decimal.TryParse(discountText, out discountPercent);

                decimal discount =
                    _assessmentRepository.CalculateDiscount(
                        tuition,
                        discountPercent
                    );

                decimal total =
                    _assessmentRepository.CalculateTotalAssessment(
                        tuition,
                        mandatoryFees,
                        discount
                    );

                // Find a section automatically
                int sectionId =
                    _assessmentRepository.GetAvailableSectionId(
                        gradeLevel,
                        schoolYear
                    );

                if (sectionId == 0)
                {
                    MessageBox.Show(
                        "No available section was found for this Grade Level and School Year."
                    );
                    return;
                }

                // Save Enrollment + Assessment
                _assessmentRepository.CreateEnrollmentAndAssessment(
                    selectedStudentId,
                    sectionId,
                    schoolYear,
                    total,
                    discount
                );

                // Update labels
                lblTuition.Text = "₱" + tuition.ToString("N2");
                lblMandatorySchoolFees.Text =
                    "₱" + mandatoryFees.ToString("N2");
                lblDiscount.Text = "₱" + discount.ToString("N2");
                lblTotalAssessment.Text = "₱" + total.ToString("N2");

                MessageBox.Show(
                    "Assessment saved successfully!"
                );

                // Refresh the student lists
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save assessment: " + ex.Message
                );
            }
        }

        private void dgvListofStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedStudentId = Convert.ToInt32(dgvListofStudents.Rows[e.RowIndex].Cells["StudentId"].Value);
            }

            MessageBox.Show("Student selected successfully.");
        }

        private void dgvListofStudents1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedStudentId = Convert.ToInt32(dgvListofStudents.Rows[e.RowIndex].Cells["StudentId"].Value);
            }
            MessageBox.Show("Student selected successfully.");
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            SearchStudents();
        }
    }
    
}
