using BusinessLogic.Repository;
using Model;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace UI
{
    public partial class SectionManagement : Form
    {

        private readonly SectionRepository _sectionRepository =
    new SectionRepository();

        private int selectedSectionId = 0;

        private int nextId = 1;

        public SectionManagement()
        {
            InitializeComponent();
            cbGradeLevel.Items.Clear();
            cbGradeLevel.Items.AddRange(new object[]
            {
                "Grade 1",
                "Grade 2",
                "Grade 3",
                "Grade 4",
                "Grade 5",
                "Grade 6"
            });
   

            LoadSections();
        }
        private void LoadSections()
        {
            var sections = _sectionRepository.GetAllSections();

            dgvSections.DataSource = null;
            dgvSections.AutoGenerateColumns = true;
            dgvSections.DataSource = sections;

            dgvSections.Refresh();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSectionId == 0)
            {
                MessageBox.Show("Please select a section first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSectionName.Text) ||
                string.IsNullOrWhiteSpace(cbGradeLevel.Text) ||
                string.IsNullOrWhiteSpace(txtSchoolYear.Text))
            {
                MessageBox.Show("Please complete all section details.");
                return;
            }

            Model.Section section = new Model.Section
            {
                SectionId = selectedSectionId,
                SectionName = txtSectionName.Text.Trim(),
                GradeLevel = cbGradeLevel.Text,
                SchoolYear = txtSchoolYear.Text.Trim(),
                Capacity = (int)nudCapacity.Value,
                IsActive = 1
            };

            try
            {
                if (_sectionRepository.UpdateSection(section))
                {
                    MessageBox.Show("Section updated successfully!");
                    LoadSections();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("No section was updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update section: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (selectedSectionId == 0)
            {
                MessageBox.Show("Please select a section first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to deactivate this section?",
                "Confirm Deactivation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                bool success = _sectionRepository.DeactivateSection(selectedSectionId);

                if (success)
                {
                    MessageBox.Show("Section deactivated successfully!");
                    LoadSections();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to deactivate section.");
                }
            }
        }


        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
          
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

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            
    if (string.IsNullOrWhiteSpace(txtSectionName.Text) ||
        string.IsNullOrWhiteSpace(cbGradeLevel.Text) ||
        string.IsNullOrWhiteSpace(txtSchoolYear.Text))
    {
        MessageBox.Show("Please complete all section details.");
        return;
    }

    Model.Section section = new Model.Section
    {
        SectionName = txtSectionName.Text.Trim(),
        GradeLevel = cbGradeLevel.Text,
        SchoolYear = txtSchoolYear.Text.Trim(),
        Capacity = (int)nudCapacity.Value,
        IsActive = 1
    };

    try
    {
        bool result = _sectionRepository.AddSection(section);

        if (result)
        {
            MessageBox.Show("Section saved successfully!");

            LoadSections();
            ClearFields();
        }
        else
        {
            MessageBox.Show("Section was not saved.");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Database error: " + ex.Message);
    }
        }

        private void ClearFields()
        {
            selectedSectionId = 0;

            txtSectionName.Clear();
            cbGradeLevel.SelectedIndex = -1;
            txtSchoolYear.Clear();

            nudCapacity.Value = 40;

            dgvSections.ClearSelection();
        }

        private void dgvSections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvSections.Rows[e.RowIndex];

            selectedSectionId = Convert.ToInt32(row.Cells["SectionId"].Value);

            txtSectionName.Text = row.Cells["SectionName"].Value.ToString();
            cbGradeLevel.Text = row.Cells["GradeLevel"].Value.ToString();
            txtSchoolYear.Text = row.Cells["SchoolYear"].Value.ToString();

            nudCapacity.Value = Convert.ToDecimal(
                row.Cells["Capacity"].Value
            );
        }
    }
}
