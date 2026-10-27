using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace UI
{
    public partial class SectionManagement : Form
    {

   
        private int nextId = 1;

        public SectionManagement()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

        
            if (txtSectionName.Text == "" || cboGradeLevel.Text == "" ||
                txtSchoolYear.Text == "" || cboCapacity.Text == "")
            {

                MessageBox.Show("Please fill in all fields.");
                return;
            }

            lstSections.Items.Add(txtSectionName.Text + " | " + cboGradeLevel.Text + " | " +
                                  txtSchoolYear.Text + " | " + cboCapacity.Text);
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            if (lstSections.SelectedIndex == -1)
            { 

                MessageBox.Show("Select a section first.");
                return;
            }

            lstSections.Items[lstSections.SelectedIndex] = txtSectionName.Text + " | " + cboGradeLevel.Text + " | " +
                                                          txtSchoolYear.Text + " | " + cboCapacity.Text;
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstSections.SelectedIndex == -1)
            {
                MessageBox.Show("Select a section first.");
                return;
            }

            lstSections.Items.RemoveAt(lstSections.SelectedIndex);
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearFields();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
          
        }

        private void ClearFields()
        
        {
            txtSectionName.Clear();
            txtSchoolYear.Clear();
            cboGradeLevel.SelectedIndex = -1;
            cboCapacity.SelectedIndex = -1;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminLandingPage homeForm = new AdminLandingPage();
            homeForm.Show();
            this.Hide();
        }

        private void btnSectionManagement_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSearchStudentAccount_Click(object sender, EventArgs e)
        {
            SearchStudentAccount studentForm = new SearchStudentAccount();
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

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagement userForm = new UserManagement();
            userForm.Show();
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