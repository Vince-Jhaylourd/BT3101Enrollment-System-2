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

