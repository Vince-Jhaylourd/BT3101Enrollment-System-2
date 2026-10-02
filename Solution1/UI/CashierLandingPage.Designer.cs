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
            this.btnPaymentCashiering = new System.Windows.Forms.Button();
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
            this.btnSearchStudentAccount.Location = new System.Drawing.Point(33, 154);
            this.btnSearchStudentAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchStudentAccount.Name = "btnSearchStudentAccount";
            this.btnSearchStudentAccount.Size = new System.Drawing.Size(135, 89);
            this.btnSearchStudentAccount.TabIndex = 3;
            this.btnSearchStudentAccount.Text = "Search student account";
            this.btnSearchStudentAccount.UseVisualStyleBackColor = false;
            // 
            // btnPaymentCashiering
            // 
            this.btnPaymentCashiering.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPaymentCashiering.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentCashiering.ForeColor = System.Drawing.Color.White;
            this.btnPaymentCashiering.Location = new System.Drawing.Point(243, 154);
            this.btnPaymentCashiering.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaymentCashiering.Name = "btnPaymentCashiering";
            this.btnPaymentCashiering.Size = new System.Drawing.Size(135, 89);
            this.btnPaymentCashiering.TabIndex = 5;
            this.btnPaymentCashiering.Text = "Payment / Cashiering";
            this.btnPaymentCashiering.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(229, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "WELCOME TO CASHIER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Modern_Cashier_Checkout_Banner;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CashierLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPaymentCashiering);
            this.Controls.Add(this.btnSearchStudentAccount);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CashierLandingPage";
            this.Text = "CashierLandingPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchStudentAccount;
        private System.Windows.Forms.Button btnPaymentCashiering;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}