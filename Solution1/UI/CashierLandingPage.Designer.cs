namespace UI
{
    partial class CashierLandingPage
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
            this.btnSearchStudentAccount = new System.Windows.Forms.Button();
            this.btnViewBalance = new System.Windows.Forms.Button();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchStudentAccount
            // 
            this.btnSearchStudentAccount.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchStudentAccount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudentAccount.ForeColor = System.Drawing.Color.White;
            this.btnSearchStudentAccount.Location = new System.Drawing.Point(22, 189);
            this.btnSearchStudentAccount.Name = "btnSearchStudentAccount";
            this.btnSearchStudentAccount.Size = new System.Drawing.Size(180, 109);
            this.btnSearchStudentAccount.TabIndex = 3;
            this.btnSearchStudentAccount.Text = "Search student account";
            this.btnSearchStudentAccount.UseVisualStyleBackColor = false;
            // 
            // btnViewBalance
            // 
            this.btnViewBalance.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewBalance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBalance.ForeColor = System.Drawing.Color.White;
            this.btnViewBalance.Location = new System.Drawing.Point(242, 189);
            this.btnViewBalance.Name = "btnViewBalance";
            this.btnViewBalance.Size = new System.Drawing.Size(180, 109);
            this.btnViewBalance.TabIndex = 4;
            this.btnViewBalance.Text = "View Balance";
            this.btnViewBalance.UseVisualStyleBackColor = false;
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnProcessPayment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessPayment.ForeColor = System.Drawing.Color.White;
            this.btnProcessPayment.Location = new System.Drawing.Point(462, 189);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(180, 109);
            this.btnProcessPayment.TabIndex = 5;
            this.btnProcessPayment.Text = "Process payment";
            this.btnProcessPayment.UseVisualStyleBackColor = false;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrintReceipt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.ForeColor = System.Drawing.Color.White;
            this.btnPrintReceipt.Location = new System.Drawing.Point(22, 351);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(180, 109);
            this.btnPrintReceipt.TabIndex = 6;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(305, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "WELCOME TO CASHIER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Modern_Cashier_Checkout_Banner;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CashierLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 713);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.btnProcessPayment);
            this.Controls.Add(this.btnViewBalance);
            this.Controls.Add(this.btnSearchStudentAccount);
            this.Name = "CashierLandingPage";
            this.Text = "CashierLandingPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchStudentAccount;
        private System.Windows.Forms.Button btnViewBalance;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}