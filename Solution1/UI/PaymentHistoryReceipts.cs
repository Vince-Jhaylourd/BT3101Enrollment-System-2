using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class PaymentHistoryReceipts : Form
    {
        public PaymentHistoryReceipts()
        {
            InitializeComponent();
        }

        private List<string> allReceipts = new List<string>()
        {

            " |  |  | | ",
              " |  |  | | ",
        };
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (string r in allReceipts)
            {
                if (r.ToLower().Contains(txtSearchTransactionID.Text.ToLower()))
                    listBox1.Items.Add(r);
            }

            if (listBox1.Items.Count == 0)
                MessageBox.Show("No records found.");
        }

        private void PaymentHistoryReceipts_Load(object sender, EventArgs e)
        {
            foreach (string r in allReceipts)
                listBox1.Items.Add(r);
        }

        private void btnViewPrintReceipts_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select a receipt first.");
                return;
            }

            string receipt = listBox1.SelectedItem.ToString();

            PrintDocument doc = new PrintDocument();
            doc.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString("PAYMENT RECEIPT", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, 50);
                ev.Graphics.DrawString(receipt, new Font("Arial", 12), Brushes.Black, 50, 100);
            };

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = doc;
            preview.ShowDialog();
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
            SearchStudentAccount studentForm = new SearchStudentAccount();
            studentForm.Show();
            this.Hide();
        }

        private void btnPaymentHistoryReceipst_Click(object sender, EventArgs e)
        {
           
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