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
            this.btnManageUserAccounts = new System.Windows.Forms.Button();
            this.btnManageSections = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnFullSystemAccess = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManageUserAccounts
            // 
            this.btnManageUserAccounts.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnManageUserAccounts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUserAccounts.ForeColor = System.Drawing.Color.White;
            this.btnManageUserAccounts.Location = new System.Drawing.Point(21, 183);
            this.btnManageUserAccounts.Name = "btnManageUserAccounts";
            this.btnManageUserAccounts.Size = new System.Drawing.Size(180, 109);
            this.btnManageUserAccounts.TabIndex = 2;
            this.btnManageUserAccounts.Text = "Manage user accounts";
            this.btnManageUserAccounts.UseVisualStyleBackColor = false;
            // 
            // btnManageSections
            // 
            this.btnManageSections.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnManageSections.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSections.ForeColor = System.Drawing.Color.White;
            this.btnManageSections.Location = new System.Drawing.Point(261, 183);
            this.btnManageSections.Name = "btnManageSections";
            this.btnManageSections.Size = new System.Drawing.Size(180, 109);
            this.btnManageSections.TabIndex = 3;
            this.btnManageSections.Text = "Manage sections";
            this.btnManageSections.UseVisualStyleBackColor = false;
            // 
            // btnViewReports
            // 
            this.btnViewReports.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewReports.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReports.ForeColor = System.Drawing.Color.White;
            this.btnViewReports.Location = new System.Drawing.Point(493, 183);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(180, 109);
            this.btnViewReports.TabIndex = 4;
            this.btnViewReports.Text = "View reports";
            this.btnViewReports.UseVisualStyleBackColor = false;
            // 
            // btnFullSystemAccess
            // 
            this.btnFullSystemAccess.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFullSystemAccess.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullSystemAccess.ForeColor = System.Drawing.Color.White;
            this.btnFullSystemAccess.Location = new System.Drawing.Point(21, 326);
            this.btnFullSystemAccess.Name = "btnFullSystemAccess";
            this.btnFullSystemAccess.Size = new System.Drawing.Size(180, 109);
            this.btnFullSystemAccess.TabIndex = 5;
            this.btnFullSystemAccess.Text = "Full system access";
            this.btnFullSystemAccess.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Modern_Blue_Office_Administration_Banner1;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(362, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "WELCOME TO ADMIN";
            // 
            // AdminLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 713);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFullSystemAccess);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.btnManageSections);
            this.Controls.Add(this.btnManageUserAccounts);
            this.Name = "AdminLandingPage";
            this.Text = "AdminLandingPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnManageUserAccounts;
        private System.Windows.Forms.Button btnManageSections;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnFullSystemAccess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}