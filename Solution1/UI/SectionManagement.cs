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
            this.Close();
        }

        private void btnSectionManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SectionManagement().ShowDialog();
            this.Show();
        }

        private void btnSearchStudentAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchStudentAccount().ShowDialog();
            this.Show();
        }

        private void btnPaymentHistoryReceipst_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PaymentHistoryReceipts().ShowDialog();
            this.Show();
        }

        private void btnStudentInformationReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Student_InformationReport().ShowDialog();
            this.Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserManagement().ShowDialog();
            this.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out",
       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}