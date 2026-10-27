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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> passwords = new Dictionary<string, string>();

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtFullName.Text == "" ||
       cboRole.Text == "" || txtPasswordReset.Text == "")
            {
                MessageBox.Show("Please fill in all required fields (*).");
                return;
            }

            if (passwords.ContainsKey(txtUserName.Text))
            {
                MessageBox.Show("That user name already exists.");
                return;
            }

            passwords.Add(txtUserName.Text, txtPasswordReset.Text);

            string status = chkActive.Checked ? "Active" : "Inactive";
            lstUserManagement.Items.Add(txtUserName.Text + " | " + txtEmail.Text + " | " +
                                        txtFullName.Text + " | " + cboRole.Text + " | " + status);
            ClearFields();
        }

        private void ClearFields()
        {
            throw new NotImplementedException();
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            if (lstUserManagement.SelectedIndex == -1)
            {
                MessageBox.Show("Select a user first.");
                return;
            }

            string status = chkActive.Checked ? "Active" : "Inactive";
            lstUserManagement.Items[lstUserManagement.SelectedIndex] =
                txtUserName.Text + " | " + txtEmail.Text + " | " +
                txtFullName.Text + " | " + cboRole.Text + " | " + status;
            ClearFields();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (lstUserManagement.SelectedIndex == -1)
            {
                MessageBox.Show("Select a user first.");
                return;
            }

            if (txtPasswordReset.Text == "")
            {
                MessageBox.Show("Type the new password first.");
                return;
            }

            passwords[txtUserName.Text] = txtPasswordReset.Text;
            MessageBox.Show("Password has been reset.");
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void lstUserManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUserManagement.SelectedIndex == -1) return;

            string[] parts = lstUserManagement.SelectedItem.ToString().Split(new string[] { " | " }, StringSplitOptions.None);
            txtUserName.Text = parts[0];
            txtEmail.Text = parts[1];
            txtFullName.Text = parts[2];
            cboRole.Text = parts[3];
            chkActive.Checked = (parts[4] == "Active");
            txtPasswordReset.Clear();


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminLandingPage AdminForm = new AdminLandingPage();
            AdminForm.Show();
            this.Hide();
        }

        private void btnSectionManagement_Click(object sender, EventArgs e)
        {
            SectionManagement SectionForm = new SectionManagement();
            SectionForm.Show();
            this.Hide();
        }

        private void btnSearchStudentAccount_Click(object sender, EventArgs e)
        {
            SearchStudentAccount SearchStudentForm = new SearchStudentAccount();
            SearchStudentForm.Show();
            this.Hide();
        }

        private void btnPaymentHistoryReceipst_Click(object sender, EventArgs e)
        {
            PaymentHistoryReceipts PaymentReceiptForms = new PaymentHistoryReceipts();
            PaymentReceiptForms.Show();
            this.Hide();
        }

        private void btnStudentInformationReport_Click(object sender, EventArgs e)
        {
            Student_InformationReport StudentInfoForm = new Student_InformationReport();
            StudentInfoForm.Show();
            this.Hide();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
           
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


   
    

