namespace UI
{
    partial class AdminLandingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnStudentInformationReport = new System.Windows.Forms.Button();
            this.btnPaymentHistoryReceipst = new System.Windows.Forms.Button();
            this.btnSearchStudentAccount = new System.Windows.Forms.Button();
            this.btnSectionManagement = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstTotalStudents = new System.Windows.Forms.ListBox();
            this.lstEnrollmentStudents = new System.Windows.Forms.ListBox();
            this.lstSections = new System.Windows.Forms.ListBox();
            this.lstCollectionsToday = new System.Windows.Forms.ListBox();
            this.lstOutstandingBalances = new System.Windows.Forms.ListBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnUserManagement);
            this.panel1.Controls.Add(this.btnStudentInformationReport);
            this.panel1.Controls.Add(this.btnPaymentHistoryReceipst);
            this.panel1.Controls.Add(this.btnSearchStudentAccount);
            this.panel1.Controls.Add(this.btnSectionManagement);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 585);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(198, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 46);
            this.panel2.TabIndex = 23;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.Location = new System.Drawing.Point(9, 365);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(178, 34);
            this.btnUserManagement.TabIndex = 15;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnStudentInformationReport
            // 
            this.btnStudentInformationReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentInformationReport.Location = new System.Drawing.Point(9, 313);
            this.btnStudentInformationReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudentInformationReport.Name = "btnStudentInformationReport";
            this.btnStudentInformationReport.Size = new System.Drawing.Size(178, 34);
            this.btnStudentInformationReport.TabIndex = 15;
            this.btnStudentInformationReport.Text = "Student Information Report";
            this.btnStudentInformationReport.UseVisualStyleBackColor = true;
            this.btnStudentInformationReport.Click += new System.EventHandler(this.btnStudentInformationReport_Click);
            // 
            // btnPaymentHistoryReceipst
            // 
            this.btnPaymentHistoryReceipst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentHistoryReceipst.Location = new System.Drawing.Point(9, 258);
            this.btnPaymentHistoryReceipst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaymentHistoryReceipst.Name = "btnPaymentHistoryReceipst";
            this.btnPaymentHistoryReceipst.Size = new System.Drawing.Size(178, 34);
            this.btnPaymentHistoryReceipst.TabIndex = 15;
            this.btnPaymentHistoryReceipst.Text = "Payment History Receipts";
            this.btnPaymentHistoryReceipst.UseVisualStyleBackColor = true;
            this.btnPaymentHistoryReceipst.Click += new System.EventHandler(this.btnPaymentHistoryReceipst_Click);
            // 
            // btnSearchStudentAccount
            // 
            this.btnSearchStudentAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudentAccount.Location = new System.Drawing.Point(9, 210);
            this.btnSearchStudentAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchStudentAccount.Name = "btnSearchStudentAccount";
            this.btnSearchStudentAccount.Size = new System.Drawing.Size(178, 34);
            this.btnSearchStudentAccount.TabIndex = 15;
            this.btnSearchStudentAccount.Text = "Search Student Account";
            this.btnSearchStudentAccount.UseVisualStyleBackColor = true;
            this.btnSearchStudentAccount.Click += new System.EventHandler(this.btnSearchStudentAccount_Click);
            // 
            // btnSectionManagement
            // 
            this.btnSectionManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectionManagement.Location = new System.Drawing.Point(9, 161);
            this.btnSectionManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSectionManagement.Name = "btnSectionManagement";
            this.btnSectionManagement.Size = new System.Drawing.Size(178, 34);
            this.btnSectionManagement.TabIndex = 17;
            this.btnSectionManagement.Text = "Section Management";
            this.btnSectionManagement.UseVisualStyleBackColor = true;
            this.btnSectionManagement.Click += new System.EventHandler(this.btnSectionManagement_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "ENROLLMENT";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(9, 112);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(178, 34);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "System Administrator | Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(205, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Welcome, Sytem Administartor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(446, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Manage section, user accounts and roles, review payment logs, and print reports.";
            // 
            // lstTotalStudents
            // 
            this.lstTotalStudents.FormattingEnabled = true;
            this.lstTotalStudents.Location = new System.Drawing.Point(209, 137);
            this.lstTotalStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstTotalStudents.Name = "lstTotalStudents";
            this.lstTotalStudents.Size = new System.Drawing.Size(193, 108);
            this.lstTotalStudents.TabIndex = 17;
            // 
            // lstEnrollmentStudents
            // 
            this.lstEnrollmentStudents.FormattingEnabled = true;
            this.lstEnrollmentStudents.Location = new System.Drawing.Point(435, 137);
            this.lstEnrollmentStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstEnrollmentStudents.Name = "lstEnrollmentStudents";
            this.lstEnrollmentStudents.Size = new System.Drawing.Size(193, 108);
            this.lstEnrollmentStudents.TabIndex = 18;
            // 
            // lstSections
            // 
            this.lstSections.FormattingEnabled = true;
            this.lstSections.Location = new System.Drawing.Point(665, 137);
            this.lstSections.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstSections.Name = "lstSections";
            this.lstSections.Size = new System.Drawing.Size(193, 108);
            this.lstSections.TabIndex = 19;
            // 
            // lstCollectionsToday
            // 
            this.lstCollectionsToday.FormattingEnabled = true;
            this.lstCollectionsToday.Location = new System.Drawing.Point(209, 292);
            this.lstCollectionsToday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCollectionsToday.Name = "lstCollectionsToday";
            this.lstCollectionsToday.Size = new System.Drawing.Size(193, 108);
            this.lstCollectionsToday.TabIndex = 20;
            // 
            // lstOutstandingBalances
            // 
            this.lstOutstandingBalances.FormattingEnabled = true;
            this.lstOutstandingBalances.Location = new System.Drawing.Point(435, 292);
            this.lstOutstandingBalances.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstOutstandingBalances.Name = "lstOutstandingBalances";
            this.lstOutstandingBalances.Size = new System.Drawing.Size(193, 108);
            this.lstOutstandingBalances.TabIndex = 21;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.Red;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.Black;
            this.buttonLogOut.Location = new System.Drawing.Point(668, 9);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(112, 34);
            this.buttonLogOut.TabIndex = 18;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.buttonLogOut);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(789, 48);
            this.panel3.TabIndex = 22;
            // 
            // AdminLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(989, 584);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lstOutstandingBalances);
            this.Controls.Add(this.lstCollectionsToday);
            this.Controls.Add(this.lstSections);
            this.Controls.Add(this.lstEnrollmentStudents);
            this.Controls.Add(this.lstTotalStudents);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminLandingPage";
            this.Text = "AdminLandingPage";
            this.Load += new System.EventHandler(this.AdminLandingPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPaymentHistoryReceipst;
        private System.Windows.Forms.Button btnSearchStudentAccount;
        private System.Windows.Forms.Button btnSectionManagement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStudentInformationReport;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstTotalStudents;
        private System.Windows.Forms.ListBox lstEnrollmentStudents;
        private System.Windows.Forms.ListBox lstSections;
        private System.Windows.Forms.ListBox lstCollectionsToday;
        private System.Windows.Forms.ListBox lstOutstandingBalances;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}