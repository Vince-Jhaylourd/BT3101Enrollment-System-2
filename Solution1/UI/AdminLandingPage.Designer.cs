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
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageUserAccounts = new System.Windows.Forms.Button();
            this.btnManageSections = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnFullSystemAccess = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 65);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO ADMIN\r\n";
            // 
            // btnManageUserAccounts
            // 
            this.btnManageUserAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUserAccounts.Location = new System.Drawing.Point(12, 106);
            this.btnManageUserAccounts.Name = "btnManageUserAccounts";
            this.btnManageUserAccounts.Size = new System.Drawing.Size(180, 109);
            this.btnManageUserAccounts.TabIndex = 2;
            this.btnManageUserAccounts.Text = "Manage user accounts";
            this.btnManageUserAccounts.UseVisualStyleBackColor = true;
            // 
            // btnManageSections
            // 
            this.btnManageSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSections.Location = new System.Drawing.Point(208, 106);
            this.btnManageSections.Name = "btnManageSections";
            this.btnManageSections.Size = new System.Drawing.Size(180, 109);
            this.btnManageSections.TabIndex = 3;
            this.btnManageSections.Text = "Manage sections";
            this.btnManageSections.UseVisualStyleBackColor = true;
            // 
            // btnViewReports
            // 
            this.btnViewReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReports.Location = new System.Drawing.Point(417, 106);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(180, 109);
            this.btnViewReports.TabIndex = 4;
            this.btnViewReports.Text = "View reports";
            this.btnViewReports.UseVisualStyleBackColor = true;
            // 
            // btnFullSystemAccess
            // 
            this.btnFullSystemAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullSystemAccess.Location = new System.Drawing.Point(12, 235);
            this.btnFullSystemAccess.Name = "btnFullSystemAccess";
            this.btnFullSystemAccess.Size = new System.Drawing.Size(180, 109);
            this.btnFullSystemAccess.TabIndex = 5;
            this.btnFullSystemAccess.Text = "Full system access";
            this.btnFullSystemAccess.UseVisualStyleBackColor = true;
            // 
            // AdminLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(656, 713);
            this.Controls.Add(this.btnFullSystemAccess);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.btnManageSections);
            this.Controls.Add(this.btnManageUserAccounts);
            this.Controls.Add(this.panel1);
            this.Name = "AdminLandingPage";
            this.Text = "AdminLandingPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageUserAccounts;
        private System.Windows.Forms.Button btnManageSections;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnFullSystemAccess;
    }
}