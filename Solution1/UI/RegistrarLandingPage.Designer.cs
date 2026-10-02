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
            this.btnSearchStudents = new System.Windows.Forms.Button();
            this.btnPerformAssessment = new System.Windows.Forms.Button();
            this.btnManageStudentRecords = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchStudents
            // 
            this.btnSearchStudents.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchStudents.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudents.ForeColor = System.Drawing.Color.White;
            this.btnSearchStudents.Location = new System.Drawing.Point(232, 182);
            this.btnSearchStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchStudents.Name = "btnSearchStudents";
            this.btnSearchStudents.Size = new System.Drawing.Size(180, 110);
            this.btnSearchStudents.TabIndex = 4;
            this.btnSearchStudents.Text = "Search students";
            this.btnSearchStudents.UseVisualStyleBackColor = false;
            // 
            // btnPerformAssessment
            // 
            this.btnPerformAssessment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPerformAssessment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerformAssessment.ForeColor = System.Drawing.Color.White;
            this.btnPerformAssessment.Location = new System.Drawing.Point(455, 182);
            this.btnPerformAssessment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPerformAssessment.Name = "btnPerformAssessment";
            this.btnPerformAssessment.Size = new System.Drawing.Size(180, 110);
            this.btnPerformAssessment.TabIndex = 5;
            this.btnPerformAssessment.Text = "Perform assessment";
            this.btnPerformAssessment.UseVisualStyleBackColor = false;
            // 
            // btnManageStudentRecords
            // 
            this.btnManageStudentRecords.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnManageStudentRecords.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStudentRecords.ForeColor = System.Drawing.Color.White;
            this.btnManageStudentRecords.Location = new System.Drawing.Point(12, 181);
            this.btnManageStudentRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageStudentRecords.Name = "btnManageStudentRecords";
            this.btnManageStudentRecords.Size = new System.Drawing.Size(180, 110);
            this.btnManageStudentRecords.TabIndex = 6;
            this.btnManageStudentRecords.Text = "Manage student records";
            this.btnManageStudentRecords.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(293, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "WELCOME TO REGISTRAR\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Modern_Office_Registration_Banner;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // RegistrarLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 713);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnManageStudentRecords);
            this.Controls.Add(this.btnPerformAssessment);
            this.Controls.Add(this.btnSearchStudents);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistrarLandingPage";
            this.Text = "RegistrarLandingPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchStudents;
        private System.Windows.Forms.Button btnPerformAssessment;
        private System.Windows.Forms.Button btnManageStudentRecords;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}