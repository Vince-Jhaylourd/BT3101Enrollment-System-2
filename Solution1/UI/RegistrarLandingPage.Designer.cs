namespace UI
{
    partial class RegistrarLandingPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchStudents = new System.Windows.Forms.Button();
            this.btnPerformAssessment = new System.Windows.Forms.Button();
            this.btnManageStudentRecords = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 53);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO REGISTRAR\r\n";
            // 
            // btnSearchStudents
            // 
            this.btnSearchStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudents.Location = new System.Drawing.Point(171, 74);
            this.btnSearchStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchStudents.Name = "btnSearchStudents";
            this.btnSearchStudents.Size = new System.Drawing.Size(135, 89);
            this.btnSearchStudents.TabIndex = 4;
            this.btnSearchStudents.Text = "Search students";
            this.btnSearchStudents.UseVisualStyleBackColor = true;
            // 
            // btnPerformAssessment
            // 
            this.btnPerformAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerformAssessment.Location = new System.Drawing.Point(322, 74);
            this.btnPerformAssessment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPerformAssessment.Name = "btnPerformAssessment";
            this.btnPerformAssessment.Size = new System.Drawing.Size(135, 89);
            this.btnPerformAssessment.TabIndex = 5;
            this.btnPerformAssessment.Text = "Perform assessment";
            this.btnPerformAssessment.UseVisualStyleBackColor = true;
            // 
            // btnManageStudentRecords
            // 
            this.btnManageStudentRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStudentRecords.Location = new System.Drawing.Point(10, 74);
            this.btnManageStudentRecords.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageStudentRecords.Name = "btnManageStudentRecords";
            this.btnManageStudentRecords.Size = new System.Drawing.Size(135, 89);
            this.btnManageStudentRecords.TabIndex = 6;
            this.btnManageStudentRecords.Text = "Manage student records";
            this.btnManageStudentRecords.UseVisualStyleBackColor = true;
            // 
            // RegistrarLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 579);
            this.Controls.Add(this.btnManageStudentRecords);
            this.Controls.Add(this.btnPerformAssessment);
            this.Controls.Add(this.btnSearchStudents);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistrarLandingPage";
            this.Text = "RegistrarLandingPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchStudents;
        private System.Windows.Forms.Button btnPerformAssessment;
        private System.Windows.Forms.Button btnManageStudentRecords;
    }
}