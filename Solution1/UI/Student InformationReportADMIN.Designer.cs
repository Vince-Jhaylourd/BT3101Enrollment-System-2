namespace UI
{
    partial class Student_InformationReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_InformationReport));
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFiltertype = new System.Windows.Forms.Label();
            this.lblGradelevel = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblAcademicyear = new System.Windows.Forms.Label();
            this.txtAcademicYear = new System.Windows.Forms.TextBox();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.cmbGradeLevel = new System.Windows.Forms.ComboBox();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStudentInformationReport = new System.Windows.Forms.Button();
            this.btnPaymentHistoryReceipt = new System.Windows.Forms.Button();
            this.btnStudentSearchAccountADMIN = new System.Windows.Forms.Button();
            this.btnSectionManagement = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvStudentInformationReport = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInformationReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.buttonLogOut);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(269, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1052, 59);
            this.panel3.TabIndex = 26;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.Red;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.Black;
            this.buttonLogOut.Location = new System.Drawing.Point(891, 11);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(149, 42);
            this.buttonLogOut.TabIndex = 18;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "System Administrator | Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(275, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Student Information Report";
            // 
            // lblFiltertype
            // 
            this.lblFiltertype.AutoSize = true;
            this.lblFiltertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltertype.Location = new System.Drawing.Point(295, 150);
            this.lblFiltertype.Name = "lblFiltertype";
            this.lblFiltertype.Size = new System.Drawing.Size(101, 20);
            this.lblFiltertype.TabIndex = 28;
            this.lblFiltertype.Text = "Filter type*";
            // 
            // lblGradelevel
            // 
            this.lblGradelevel.AutoSize = true;
            this.lblGradelevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradelevel.Location = new System.Drawing.Point(497, 150);
            this.lblGradelevel.Name = "lblGradelevel";
            this.lblGradelevel.Size = new System.Drawing.Size(105, 20);
            this.lblGradelevel.TabIndex = 29;
            this.lblGradelevel.Text = "Grade level";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(701, 150);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(72, 20);
            this.lblSection.TabIndex = 30;
            this.lblSection.Text = "Section";
            // 
            // lblAcademicyear
            // 
            this.lblAcademicyear.AutoSize = true;
            this.lblAcademicyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicyear.Location = new System.Drawing.Point(907, 150);
            this.lblAcademicyear.Name = "lblAcademicyear";
            this.lblAcademicyear.Size = new System.Drawing.Size(140, 20);
            this.lblAcademicyear.TabIndex = 31;
            this.lblAcademicyear.Text = "Academic year*";
            // 
            // txtAcademicYear
            // 
            this.txtAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcademicYear.Location = new System.Drawing.Point(901, 174);
            this.txtAcademicYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAcademicYear.Name = "txtAcademicYear";
            this.txtAcademicYear.Size = new System.Drawing.Size(169, 27);
            this.txtAcademicYear.TabIndex = 32;
            this.txtAcademicYear.Text = "2026-2027";
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Items.AddRange(new object[] {
            "By Grade Level",
            "By Section",
            "All Enrolled"});
            this.cmbFilterType.Location = new System.Drawing.Point(299, 174);
            this.cmbFilterType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(169, 28);
            this.cmbFilterType.TabIndex = 33;
            this.cmbFilterType.SelectedIndexChanged += new System.EventHandler(this.cmbFilterType_SelectedIndexChanged);
            // 
            // cmbGradeLevel
            // 
            this.cmbGradeLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGradeLevel.FormattingEnabled = true;
            this.cmbGradeLevel.Location = new System.Drawing.Point(501, 174);
            this.cmbGradeLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGradeLevel.Name = "cmbGradeLevel";
            this.cmbGradeLevel.Size = new System.Drawing.Size(169, 28);
            this.cmbGradeLevel.TabIndex = 34;
            this.cmbGradeLevel.SelectedIndexChanged += new System.EventHandler(this.cmbGradeLevel_SelectedIndexChanged);
            // 
            // cmbSection
            // 
            this.cmbSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(705, 174);
            this.cmbSection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(169, 28);
            this.cmbSection.TabIndex = 35;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(1092, 159);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(123, 42);
            this.btnGenerate.TabIndex = 36;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPrintReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Location = new System.Drawing.Point(299, 649);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(255, 43);
            this.btnPrintReport.TabIndex = 38;
            this.btnPrintReport.Text = " Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnStudentInformationReport);
            this.panel1.Controls.Add(this.btnPaymentHistoryReceipt);
            this.panel1.Controls.Add(this.btnStudentSearchAccountADMIN);
            this.panel1.Controls.Add(this.btnSectionManagement);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 720);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(264, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 57);
            this.panel2.TabIndex = 23;
            // 
            // btnStudentInformationReport
            // 
            this.btnStudentInformationReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentInformationReport.Location = new System.Drawing.Point(12, 385);
            this.btnStudentInformationReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudentInformationReport.Name = "btnStudentInformationReport";
            this.btnStudentInformationReport.Size = new System.Drawing.Size(237, 42);
            this.btnStudentInformationReport.TabIndex = 15;
            this.btnStudentInformationReport.Text = "Student Information Report";
            this.btnStudentInformationReport.UseVisualStyleBackColor = true;
            this.btnStudentInformationReport.Click += new System.EventHandler(this.btnStudentInformationReport_Click);
            // 
            // btnPaymentHistoryReceipt
            // 
            this.btnPaymentHistoryReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentHistoryReceipt.Location = new System.Drawing.Point(12, 318);
            this.btnPaymentHistoryReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPaymentHistoryReceipt.Name = "btnPaymentHistoryReceipt";
            this.btnPaymentHistoryReceipt.Size = new System.Drawing.Size(237, 42);
            this.btnPaymentHistoryReceipt.TabIndex = 15;
            this.btnPaymentHistoryReceipt.Text = "Payment History Receipts";
            this.btnPaymentHistoryReceipt.UseVisualStyleBackColor = true;
            this.btnPaymentHistoryReceipt.Click += new System.EventHandler(this.btnPaymentHistoryReceipt_Click);
            // 
            // btnStudentSearchAccountADMIN
            // 
            this.btnStudentSearchAccountADMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentSearchAccountADMIN.Location = new System.Drawing.Point(12, 258);
            this.btnStudentSearchAccountADMIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudentSearchAccountADMIN.Name = "btnStudentSearchAccountADMIN";
            this.btnStudentSearchAccountADMIN.Size = new System.Drawing.Size(237, 42);
            this.btnStudentSearchAccountADMIN.TabIndex = 15;
            this.btnStudentSearchAccountADMIN.Text = "Search Student Account";
            this.btnStudentSearchAccountADMIN.UseVisualStyleBackColor = true;
            this.btnStudentSearchAccountADMIN.Click += new System.EventHandler(this.btnStudentSearchAccountADMIN_Click);
            // 
            // btnSectionManagement
            // 
            this.btnSectionManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectionManagement.Location = new System.Drawing.Point(12, 198);
            this.btnSectionManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSectionManagement.Name = "btnSectionManagement";
            this.btnSectionManagement.Size = new System.Drawing.Size(237, 42);
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
            this.label3.Location = new System.Drawing.Point(60, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "ENROLLMENT";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 138);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(237, 42);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dgvStudentInformationReport
            // 
            this.dgvStudentInformationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentInformationReport.Location = new System.Drawing.Point(306, 226);
            this.dgvStudentInformationReport.Name = "dgvStudentInformationReport";
            this.dgvStudentInformationReport.RowHeadersWidth = 51;
            this.dgvStudentInformationReport.RowTemplate.Height = 24;
            this.dgvStudentInformationReport.Size = new System.Drawing.Size(958, 407);
            this.dgvStudentInformationReport.TabIndex = 40;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Student_InformationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1319, 719);
            this.Controls.Add(this.dgvStudentInformationReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.cmbGradeLevel);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.txtAcademicYear);
            this.Controls.Add(this.lblAcademicyear);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.lblGradelevel);
            this.Controls.Add(this.lblFiltertype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Student_InformationReport";
            this.Text = "Student_InformationReport";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInformationReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFiltertype;
        private System.Windows.Forms.Label lblGradelevel;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblAcademicyear;
        private System.Windows.Forms.TextBox txtAcademicYear;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.ComboBox cmbGradeLevel;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStudentInformationReport;
        private System.Windows.Forms.Button btnPaymentHistoryReceipt;
        private System.Windows.Forms.Button btnStudentSearchAccountADMIN;
        private System.Windows.Forms.Button btnSectionManagement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dgvStudentInformationReport;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}