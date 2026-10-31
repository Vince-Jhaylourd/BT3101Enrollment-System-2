using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace UI
{
    public partial class Student_InformationReport : Form
    {
        public Student_InformationReport()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cboFilterType.Text == "" || txtAcademicYear.Text == "")
            {
                MessageBox.Show("Please fill in Filter type and Academic year.");
                return;
            }

            listBox1.Items.Clear();
            listBox1.Items.Add("STUDENT INFORMATION REPORT");
            listBox1.Items.Add("Filter: " + cboFilterType.Text);
            listBox1.Items.Add("Grade level: " + cboGradeLevel.Text);
            listBox1.Items.Add("Section: " + cboSection.Text);
            listBox1.Items.Add("Academic year: " + txtAcademicYear.Text);
            listBox1.Items.Add("-----------------------------------");
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Generate a report first.");
                return;
            }

            PrintDocument doc = new PrintDocument();
            doc.PrintPage += (s, ev) =>
            {
                float y = 50;
                foreach (object item in listBox1.Items)
                {
                    ev.Graphics.DrawString(item.ToString(), new Font("Arial", 12), Brushes.Black, 50, y);
                    y += 25;
                }
            };

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = doc;
            preview.ShowDialog();
        }

      
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out",
       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
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

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagement UserManagementForm = new UserManagement();
            UserManagementForm.Show();
            this.Hide();
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
    }
}

