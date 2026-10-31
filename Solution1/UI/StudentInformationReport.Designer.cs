namespace UI
{
    partial class StudentInformationReport
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
            this.btnStudentInformationReport = new System.Windows.Forms.Button();
            this.btnSearchStudentAccount = new System.Windows.Forms.Button();
            this.btnStudentAssesssment = new System.Windows.Forms.Button();
            this.btnStudentMaintenance = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGradelevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFilterType = new System.Windows.Forms.ComboBox();
            this.cbGradeLevel = new System.Windows.Forms.ComboBox();
            this.cbSection = new System.Windows.Forms.ComboBox();
            this.txtAcademicYear = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnStudentInformationReport);
            this.panel1.Controls.Add(this.btnSearchStudentAccount);
            this.panel1.Controls.Add(this.btnStudentAssesssment);
            this.panel1.Controls.Add(this.btnStudentMaintenance);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 585);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(198, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 46);
            this.panel2.TabIndex = 23;
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
            // 
            // btnSearchStudentAccount
            // 
            this.btnSearchStudentAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudentAccount.Location = new System.Drawing.Point(9, 258);
            this.btnSearchStudentAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchStudentAccount.Name = "btnSearchStudentAccount";
            this.btnSearchStudentAccount.Size = new System.Drawing.Size(178, 34);
            this.btnSearchStudentAccount.TabIndex = 15;
            this.btnSearchStudentAccount.Text = "Search Student Account";
            this.btnSearchStudentAccount.UseVisualStyleBackColor = true;
            this.btnSearchStudentAccount.Click += new System.EventHandler(this.btnSearchStudentAccount_Click);
            // 
            // btnStudentAssesssment
            // 
            this.btnStudentAssesssment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentAssesssment.Location = new System.Drawing.Point(9, 210);
            this.btnStudentAssesssment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudentAssesssment.Name = "btnStudentAssesssment";
            this.btnStudentAssesssment.Size = new System.Drawing.Size(178, 34);
            this.btnStudentAssesssment.TabIndex = 15;
            this.btnStudentAssesssment.Text = "Student Assesssment";
            this.btnStudentAssesssment.UseVisualStyleBackColor = true;
            this.btnStudentAssesssment.Click += new System.EventHandler(this.btnStudentAssesssment_Click);
            // 
            // btnStudentMaintenance
            // 
            this.btnStudentMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentMaintenance.Location = new System.Drawing.Point(9, 161);
            this.btnStudentMaintenance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudentMaintenance.Name = "btnStudentMaintenance";
            this.btnStudentMaintenance.Size = new System.Drawing.Size(178, 34);
            this.btnStudentMaintenance.TabIndex = 17;
            this.btnStudentMaintenance.Text = "Student Maintenance";
            this.btnStudentMaintenance.UseVisualStyleBackColor = true;
            this.btnStudentMaintenance.Click += new System.EventHandler(this.btnStudentMaintenance_Click);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.buttonLogOut);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(200, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(789, 48);
            this.panel3.TabIndex = 27;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Registrar Staff | Registrar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(216, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 26);
            this.label4.TabIndex = 28;
            this.label4.Text = "Student Infomation Report";
            // 
            // lblGradelevel
            // 
            this.lblGradelevel.AutoSize = true;
            this.lblGradelevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradelevel.Location = new System.Drawing.Point(226, 113);
            this.lblGradelevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradelevel.Name = "lblGradelevel";
            this.lblGradelevel.Size = new System.Drawing.Size(87, 17);
            this.lblGradelevel.TabIndex = 60;
            this.lblGradelevel.Text = "Filter type*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Grade level*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(545, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Section*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(702, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 63;
            this.label7.Text = "Academic year*";
            // 
            // cbFilterType
            // 
            this.cbFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterType.FormattingEnabled = true;
            this.cbFilterType.Location = new System.Drawing.Point(230, 132);
            this.cbFilterType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFilterType.Name = "cbFilterType";
            this.cbFilterType.Size = new System.Drawing.Size(137, 25);
            this.cbFilterType.TabIndex = 69;
            // 
            // cbGradeLevel
            // 
            this.cbGradeLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGradeLevel.FormattingEnabled = true;
            this.cbGradeLevel.Location = new System.Drawing.Point(391, 132);
            this.cbGradeLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGradeLevel.Name = "cbGradeLevel";
            this.cbGradeLevel.Size = new System.Drawing.Size(137, 25);
            this.cbGradeLevel.TabIndex = 70;
            // 
            // cbSection
            // 
            this.cbSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSection.FormattingEnabled = true;
            this.cbSection.Location = new System.Drawing.Point(548, 132);
            this.cbSection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(137, 25);
            this.cbSection.TabIndex = 71;
            // 
            // txtAcademicYear
            // 
            this.txtAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcademicYear.Location = new System.Drawing.Point(705, 133);
            this.txtAcademicYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAcademicYear.Name = "txtAcademicYear";
            this.txtAcademicYear.Size = new System.Drawing.Size(137, 23);
            this.txtAcademicYear.TabIndex = 72;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(845, 119);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(121, 35);
            this.btnGenerate.TabIndex = 73;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(230, 162);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(738, 368);
            this.listBox1.TabIndex = 74;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPrintReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Location = new System.Drawing.Point(230, 535);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(148, 34);
            this.btnPrintReport.TabIndex = 75;
            this.btnPrintReport.Text = "Print report";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            // 
            // StudentInformationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(989, 584);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtAcademicYear);
            this.Controls.Add(this.cbSection);
            this.Controls.Add(this.cbGradeLevel);
            this.Controls.Add(this.cbFilterType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGradelevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentInformationReport";
            this.Text = "StudentInformationReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStudentInformationReport;
        private System.Windows.Forms.Button btnSearchStudentAccount;
        private System.Windows.Forms.Button btnStudentAssesssment;
        private System.Windows.Forms.Button btnStudentMaintenance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGradelevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbFilterType;
        private System.Windows.Forms.ComboBox cbGradeLevel;
        private System.Windows.Forms.ComboBox cbSection;
        private System.Windows.Forms.TextBox txtAcademicYear;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPrintReport;
    }
}