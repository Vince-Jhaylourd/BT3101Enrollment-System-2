namespace UI
{
    partial class CashierCashieringPayment
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
            this.button7 = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStudentValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalAssessmentValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalPaidValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRemainingBalanceValue = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.cmbPaymentScheme = new System.Windows.Forms.ComboBox();
            this.txtReferenceNotes = new System.Windows.Forms.TextBox();
            this.btnRecordPayment = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 68);
            this.panel2.TabIndex = 5;
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
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
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
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnSearchStudent);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 720);
            this.panel1.TabIndex = 4;
            // 
            // btnPaymentHistory
            // 
            this.btnPaymentHistory.Location = new System.Drawing.Point(17, 415);
            this.btnPaymentHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaymentHistory.Name = "btnPaymentHistory";
            this.btnPaymentHistory.Size = new System.Drawing.Size(232, 54);
            this.btnPaymentHistory.TabIndex = 11;
            this.btnPaymentHistory.Text = "PAYMENT HISTORY";
            this.btnPaymentHistory.UseVisualStyleBackColor = true;
            this.btnPaymentHistory.Click += new System.EventHandler(this.btnPaymentHistory_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(17, 332);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(232, 54);
            this.button7.TabIndex = 10;
            this.button7.Text = "CASHIERING PAYMENT";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(17, 255);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(232, 54);
            this.btnSearchStudent.TabIndex = 9;
            this.btnSearchStudent.Text = "SEARCH STUDENT ACCOUNT";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
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
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
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
            this.label2.Location = new System.Drawing.Point(288, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cashiering Payments";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Location = new System.Drawing.Point(624, 154);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(293, 154);
            this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(319, 22);
            this.txtSearchStudent.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Search Student ID, LRN or Name";
            // 
            // lblStudentValue
            // 
            this.lblStudentValue.AutoSize = true;
            this.lblStudentValue.Location = new System.Drawing.Point(292, 533);
            this.lblStudentValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentValue.Name = "lblStudentValue";
            this.lblStudentValue.Size = new System.Drawing.Size(44, 16);
            this.lblStudentValue.TabIndex = 14;
            this.lblStudentValue.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 503);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Student";
            // 
            // lblTotalAssessmentValue
            // 
            this.lblTotalAssessmentValue.AutoSize = true;
            this.lblTotalAssessmentValue.Location = new System.Drawing.Point(620, 533);
            this.lblTotalAssessmentValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAssessmentValue.Name = "lblTotalAssessmentValue";
            this.lblTotalAssessmentValue.Size = new System.Drawing.Size(44, 16);
            this.lblTotalAssessmentValue.TabIndex = 16;
            this.lblTotalAssessmentValue.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(616, 502);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Assessment";
            // 
            // lblTotalPaidValue
            // 
            this.lblTotalPaidValue.AutoSize = true;
            this.lblTotalPaidValue.Location = new System.Drawing.Point(872, 533);
            this.lblTotalPaidValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPaidValue.Name = "lblTotalPaidValue";
            this.lblTotalPaidValue.Size = new System.Drawing.Size(51, 16);
            this.lblTotalPaidValue.TabIndex = 18;
            this.lblTotalPaidValue.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(869, 502);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Total Paid";
            // 
            // lblRemainingBalanceValue
            // 
            this.lblRemainingBalanceValue.AutoSize = true;
            this.lblRemainingBalanceValue.Location = new System.Drawing.Point(1037, 533);
            this.lblRemainingBalanceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemainingBalanceValue.Name = "lblRemainingBalanceValue";
            this.lblRemainingBalanceValue.Size = new System.Drawing.Size(51, 16);
            this.lblRemainingBalanceValue.TabIndex = 20;
            this.lblRemainingBalanceValue.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1037, 502);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 16);
            this.label14.TabIndex = 19;
            this.label14.Text = "Remaining Balance";
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(293, 618);
            this.txtPaymentAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(220, 22);
            this.txtPaymentAmount.TabIndex = 21;
            // 
            // cmbPaymentScheme
            // 
            this.cmbPaymentScheme.FormattingEnabled = true;
            this.cmbPaymentScheme.Items.AddRange(new object[] {
            "Cash",
            "Gcash",
            "Bank-Transfer"});
            this.cmbPaymentScheme.Location = new System.Drawing.Point(544, 617);
            this.cmbPaymentScheme.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPaymentScheme.Name = "cmbPaymentScheme";
            this.cmbPaymentScheme.Size = new System.Drawing.Size(212, 24);
            this.cmbPaymentScheme.TabIndex = 22;
            // 
            // txtReferenceNotes
            // 
            this.txtReferenceNotes.Location = new System.Drawing.Point(791, 618);
            this.txtReferenceNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferenceNotes.Name = "txtReferenceNotes";
            this.txtReferenceNotes.Size = new System.Drawing.Size(333, 22);
            this.txtReferenceNotes.TabIndex = 23;
            // 
            // btnRecordPayment
            // 
            this.btnRecordPayment.BackColor = System.Drawing.Color.LawnGreen;
            this.btnRecordPayment.Location = new System.Drawing.Point(296, 671);
            this.btnRecordPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecordPayment.Name = "btnRecordPayment";
            this.btnRecordPayment.Size = new System.Drawing.Size(169, 33);
            this.btnRecordPayment.TabIndex = 24;
            this.btnRecordPayment.Text = "Record Payment";
            this.btnRecordPayment.UseVisualStyleBackColor = false;
            this.btnRecordPayment.Click += new System.EventHandler(this.btnRecordPayment_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 598);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Payment Amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(540, 597);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Payment Scheme";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(787, 597);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 16);
            this.label16.TabIndex = 27;
            this.label16.Text = "Reference Notes";
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(302, 208);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(968, 271);
            this.dgvStudents.TabIndex = 28;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // CashierCashieringPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 719);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnRecordPayment);
            this.Controls.Add(this.txtReferenceNotes);
            this.Controls.Add(this.cmbPaymentScheme);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.lblRemainingBalanceValue);
            this.Controls.Add(this.label14);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CashierCashieringPayment";
            this.Text = "CashierCashieringPayment";
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
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStudentValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalAssessmentValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalPaidValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRemainingBalanceValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.ComboBox cmbPaymentScheme;
        private System.Windows.Forms.TextBox txtReferenceNotes;
        private System.Windows.Forms.Button btnRecordPayment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}