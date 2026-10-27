namespace System_C_Sharp_SuperMarket_DB_MISS.DebtCustomers
{
    partial class frmPaymentDebt
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalInvoicesBefor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalAmountPaidBefor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalRemainingAmountBefor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRemainingAmountAfter = new System.Windows.Forms.Label();
            this.txtNewAmountPaidAfter = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(146)))));
            this.btnClose.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageIndex = 5;
            this.btnClose.Location = new System.Drawing.Point(10, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 38);
            this.btnClose.TabIndex = 79;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(146)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 53);
            this.label2.TabIndex = 78;
            this.label2.Text = "تفاصيل الفاتورة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(13, 577);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(426, 55);
            this.btnPay.TabIndex = 78;
            this.btnPay.Tag = "No";
            this.btnPay.Text = "تسديد";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(146)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 638);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 4);
            this.panel2.TabIndex = 79;
            // 
            // lblTotalInvoicesBefor
            // 
            this.lblTotalInvoicesBefor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalInvoicesBefor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.lblTotalInvoicesBefor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalInvoicesBefor.ForeColor = System.Drawing.Color.Black;
            this.lblTotalInvoicesBefor.Location = new System.Drawing.Point(13, 110);
            this.lblTotalInvoicesBefor.Name = "lblTotalInvoicesBefor";
            this.lblTotalInvoicesBefor.Size = new System.Drawing.Size(426, 44);
            this.lblTotalInvoicesBefor.TabIndex = 77;
            this.lblTotalInvoicesBefor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(13, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(426, 34);
            this.label9.TabIndex = 76;
            this.label9.Text = "اجمالي مبلغ الديون";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmountPaidBefor
            // 
            this.lblTotalAmountPaidBefor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmountPaidBefor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.lblTotalAmountPaidBefor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmountPaidBefor.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmountPaidBefor.Location = new System.Drawing.Point(13, 201);
            this.lblTotalAmountPaidBefor.Name = "lblTotalAmountPaidBefor";
            this.lblTotalAmountPaidBefor.Size = new System.Drawing.Size(426, 44);
            this.lblTotalAmountPaidBefor.TabIndex = 77;
            this.lblTotalAmountPaidBefor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(13, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 34);
            this.label3.TabIndex = 76;
            this.label3.Text = "اجمالي المبلغ المسدد";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalRemainingAmountBefor
            // 
            this.lblTotalRemainingAmountBefor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRemainingAmountBefor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.lblTotalRemainingAmountBefor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalRemainingAmountBefor.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRemainingAmountBefor.Location = new System.Drawing.Point(13, 297);
            this.lblTotalRemainingAmountBefor.Name = "lblTotalRemainingAmountBefor";
            this.lblTotalRemainingAmountBefor.Size = new System.Drawing.Size(426, 44);
            this.lblTotalRemainingAmountBefor.TabIndex = 77;
            this.lblTotalRemainingAmountBefor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(13, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(426, 34);
            this.label6.TabIndex = 76;
            this.label6.Text = "اجمالي المبلغ المتبقي";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(16, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(426, 34);
            this.label10.TabIndex = 76;
            this.label10.Text = "المبلغ المراد تسديده";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(16, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(426, 34);
            this.label7.TabIndex = 76;
            this.label7.Text = "المبلغ المتبقي بعد التسديد";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRemainingAmountAfter
            // 
            this.lblRemainingAmountAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemainingAmountAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.lblRemainingAmountAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRemainingAmountAfter.ForeColor = System.Drawing.Color.Black;
            this.lblRemainingAmountAfter.Location = new System.Drawing.Point(13, 494);
            this.lblRemainingAmountAfter.Name = "lblRemainingAmountAfter";
            this.lblRemainingAmountAfter.Size = new System.Drawing.Size(429, 44);
            this.lblRemainingAmountAfter.TabIndex = 77;
            this.lblRemainingAmountAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewAmountPaidAfter
            // 
            this.txtNewAmountPaidAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewAmountPaidAfter.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtNewAmountPaidAfter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewAmountPaidAfter.Culture = new System.Globalization.CultureInfo("");
            this.txtNewAmountPaidAfter.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtNewAmountPaidAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtNewAmountPaidAfter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(146)))));
            this.txtNewAmountPaidAfter.HidePromptOnLeave = true;
            this.txtNewAmountPaidAfter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNewAmountPaidAfter.Location = new System.Drawing.Point(16, 400);
            this.txtNewAmountPaidAfter.Mask = "00000000000000000000000000";
            this.txtNewAmountPaidAfter.Name = "txtNewAmountPaidAfter";
            this.txtNewAmountPaidAfter.ShortcutsEnabled = false;
            this.txtNewAmountPaidAfter.Size = new System.Drawing.Size(426, 46);
            this.txtNewAmountPaidAfter.TabIndex = 81;
            this.txtNewAmountPaidAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewAmountPaidAfter.TextChanged += new System.EventHandler(this.txtNewAmountPaidAfter_TextChanged);
            // 
            // frmPaymentDebt
            // 
            this.AcceptButton = this.btnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 642);
            this.Controls.Add(this.txtNewAmountPaidAfter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblRemainingAmountAfter);
            this.Controls.Add(this.lblTotalRemainingAmountBefor);
            this.Controls.Add(this.lblTotalAmountPaidBefor);
            this.Controls.Add(this.lblTotalInvoicesBefor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaymentDebt";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفع مبلغ الديون";
            this.Load += new System.EventHandler(this.frmPaymentDebt_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalInvoicesBefor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalAmountPaidBefor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalRemainingAmountBefor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRemainingAmountAfter;
        private System.Windows.Forms.MaskedTextBox txtNewAmountPaidAfter;
    }
}