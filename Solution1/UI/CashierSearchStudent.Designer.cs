namespace UI
{
    partial class CashierSearchStudent
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPaymentHistory = new System.Windows.Forms.Button();
            this.btnCashiering = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStudentValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalAssessmentValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalPaidValue = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblEnrollmentStatusValue = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblRemainingBalanceValue = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Location = new System.Drawing.Point(264, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 68);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cashier";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(895, 15);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 37);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnPaymentHistory);
            this.panel1.Controls.Add(this.btnCashiering);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 720);
            this.panel1.TabIndex = 2;
            // 
            // btnPaymentHistory
            // 
            this.btnPaymentHistory.Location = new System.Drawing.Point(17, 415);
            this.btnPaymentHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaymentHistory.Name = "btnPaymentHistory";
            this.btnPaymentHistory.Size = new System.Drawing.Size(232, 54);
            this.btnPaymentHistory.TabIndex = 11;
            this.btnPaymentHistory.Text = "PAYMENT HISTORY";
            this.btnPaymentHistory.UseVisualStyleBackColor = true;
            this.btnPaymentHistory.Click += new System.EventHandler(this.btnPaymentHistory_Click);
            // 
            // btnCashiering
            // 
            this.btnCashiering.Location = new System.Drawing.Point(17, 332);
            this.btnCashiering.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCashiering.Name = "btnCashiering";
            this.btnCashiering.Size = new System.Drawing.Size(232, 54);
            this.btnCashiering.TabIndex = 10;
            this.btnCashiering.Text = "CASHIERING PAYMENT";
            this.btnCashiering.UseVisualStyleBackColor = true;
            this.btnCashiering.Click += new System.EventHandler(this.btnCashiering_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 255);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(232, 54);
            this.button6.TabIndex = 9;
            this.button6.Text = "SEARCH STUDENT ACCOUNT";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(41, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "ENROLLMENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(71, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "SYSTEM";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(17, 172);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(232, 54);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Student Account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Search Student ID, LRN or Name";
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(296, 151);
            this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(319, 22);
            this.txtSearchStudent.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Location = new System.Drawing.Point(627, 151);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 524);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Student";
            // 
            // lblStudentValue
            // 
            this.lblStudentValue.AutoSize = true;
            this.lblStudentValue.Location = new System.Drawing.Point(303, 554);
            this.lblStudentValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentValue.Name = "lblStudentValue";
            this.lblStudentValue.Size = new System.Drawing.Size(44, 16);
            this.lblStudentValue.TabIndex = 10;
            this.lblStudentValue.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 603);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total Assessment";
            // 
            // lblTotalAssessmentValue
            // 
            this.lblTotalAssessmentValue.AutoSize = true;
            this.lblTotalAssessmentValue.Location = new System.Drawing.Point(305, 634);
            this.lblTotalAssessmentValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAssessmentValue.Name = "lblTotalAssessmentValue";
            this.lblTotalAssessmentValue.Size = new System.Drawing.Size(44, 16);
            this.lblTotalAssessmentValue.TabIndex = 12;
            this.lblTotalAssessmentValue.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(623, 603);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Total Paid";
            // 
            // lblTotalPaidValue
            // 
            this.lblTotalPaidValue.AutoSize = true;
            this.lblTotalPaidValue.Location = new System.Drawing.Point(625, 634);
            this.lblTotalPaidValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPaidValue.Name = "lblTotalPaidValue";
            this.lblTotalPaidValue.Size = new System.Drawing.Size(51, 16);
            this.lblTotalPaidValue.TabIndex = 14;
            this.lblTotalPaidValue.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(908, 524);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Enrollment Status";
            // 
            // lblEnrollmentStatusValue
            // 
            this.lblEnrollmentStatusValue.AutoSize = true;
            this.lblEnrollmentStatusValue.Location = new System.Drawing.Point(908, 554);
            this.lblEnrollmentStatusValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnrollmentStatusValue.Name = "lblEnrollmentStatusValue";
            this.lblEnrollmentStatusValue.Size = new System.Drawing.Size(51, 16);
            this.lblEnrollmentStatusValue.TabIndex = 16;
            this.lblEnrollmentStatusValue.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(908, 603);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Remaining Balance";
            // 
            // lblRemainingBalanceValue
            // 
            this.lblRemainingBalanceValue.AutoSize = true;
            this.lblRemainingBalanceValue.Location = new System.Drawing.Point(908, 634);
            this.lblRemainingBalanceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemainingBalanceValue.Name = "lblRemainingBalanceValue";
            this.lblRemainingBalanceValue.Size = new System.Drawing.Size(51, 16);
            this.lblRemainingBalanceValue.TabIndex = 18;
            this.lblRemainingBalanceValue.Text = "label15";
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(303, 211);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(980, 296);
            this.dgvStudents.TabIndex = 19;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // CashierSearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 719);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.lblRemainingBalanceValue);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblEnrollmentStatusValue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTotalPaidValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalAssessmentValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblStudentValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CashierSearchStudent";
            this.Text = "CashierSearchStudent";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPaymentHistory;
        private System.Windows.Forms.Button btnCashiering;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStudentValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalAssessmentValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalPaidValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblEnrollmentStatusValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblRemainingBalanceValue;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}