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
            this.btnStudentAssessment = new System.Windows.Forms.Button();
            this.btnStudentMaintenance = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudentAssessment
            // 
            this.btnStudentAssessment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStudentAssessment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentAssessment.ForeColor = System.Drawing.Color.White;
            this.btnStudentAssessment.Location = new System.Drawing.Point(244, 148);
            this.btnStudentAssessment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudentAssessment.Name = "btnStudentAssessment";
            this.btnStudentAssessment.Size = new System.Drawing.Size(135, 89);
            this.btnStudentAssessment.TabIndex = 4;
            this.btnStudentAssessment.Text = "Student Assessment";
            this.btnStudentAssessment.UseVisualStyleBackColor = false;
            // 
            // btnStudentMaintenance
            // 
            this.btnStudentMaintenance.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStudentMaintenance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnStudentMaintenance.Location = new System.Drawing.Point(31, 148);
            this.btnStudentMaintenance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudentMaintenance.Name = "btnStudentMaintenance";
            this.btnStudentMaintenance.Size = new System.Drawing.Size(135, 89);
            this.btnStudentMaintenance.TabIndex = 6;
            this.btnStudentMaintenance.Text = "Student Maintenance";
            this.btnStudentMaintenance.UseVisualStyleBackColor = false;
            this.btnStudentMaintenance.Click += new System.EventHandler(this.btnStudentMaintenance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(220, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "WELCOME TO REGISTRAR\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Modern_Office_Registration_Banner;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // RegistrarLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStudentMaintenance);
            this.Controls.Add(this.btnStudentAssessment);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistrarLandingPage";
            this.Text = "RegistrarLandingPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStudentAssessment;
        private System.Windows.Forms.Button btnStudentMaintenance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}