using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class SearchStudentAccount : Form
    {
        public SearchStudentAccount()
        {
            InitializeComponent();
        }

        private List<string> allStudents = new List<string>()
        {

            " |  |  | | ",
              " |  |  | | ",
        };

        private void SearchStudentAccount_Load(object sender, EventArgs e)
        {
            foreach (string s in allStudents)
                listBox1.Items.Add(s);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (string s in allStudents)
            {
                if (s.ToLower().Contains(txtSearchStudent.Text.ToLower()))
                    listBox1.Items.Add(s);
            }

            if (listBox1.Items.Count == 0)
                MessageBox.Show("No student found.");
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
            MessageBox.Show("You are already on this page.");
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
