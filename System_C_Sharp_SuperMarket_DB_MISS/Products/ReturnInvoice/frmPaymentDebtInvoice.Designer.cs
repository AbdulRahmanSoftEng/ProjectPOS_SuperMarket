namespace System_C_Sharp_SuperMarket_DB_MISS.Products
{
    partial class frmPaymentDebtInvoice
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountPaidAfterditing = new System.Windows.Forms.MaskedTextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtTotalInvoiceAfterEditing = new System.Windows.Forms.TextBox();
            this.txtRemainingAmountAfterEditing = new System.Windows.Forms.TextBox();
            this.txtAmountPaidBeforEditing = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalInvoiceBeforEditing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.txtAmountPaidAfterditing);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.txtTotalInvoiceAfterEditing);
            this.panel1.Controls.Add(this.txtRemainingAmountAfterEditing);
            this.panel1.Controls.Add(this.txtAmountPaidBeforEditing);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTotalInvoiceBeforEditing);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 612);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(4, 604);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(442, 4);
            this.panel7.TabIndex = 57;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(146)))));
            this.panel6.Controls.Add(this.btnClose);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(4, 4);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(442, 55);
            this.panel6.TabIndex = 56;
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
            this.btnClose.Location = new System.Drawing.Point(7, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 38);
            this.btnClose.TabIndex = 80;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(146)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-4, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 59);
            this.label4.TabIndex = 54;
            this.label4.Text = "دفع مبلغ فاتورة مرتجع اجل";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmountPaidAfterditing
            // 
            this.txtAmountPaidAfterditing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmountPaidAfterditing.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtAmountPaidAfterditing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountPaidAfterditing.Culture = new System.Globalization.CultureInfo("");
            this.txtAmountPaidAfterditing.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtAmountPaidAfterditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtAmountPaidAfterditing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(146)))));
            this.txtAmountPaidAfterditing.HidePromptOnLeave = true;
            this.txtAmountPaidAfterditing.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAmountPaidAfterditing.Location = new System.Drawing.Point(10, 361);
            this.txtAmountPaidAfterditing.Mask = "00000000000000000000000000";
            this.txtAmountPaidAfterditing.Name = "txtAmountPaidAfterditing";
            this.txtAmountPaidAfterditing.ShortcutsEnabled = false;
            this.txtAmountPaidAfterditing.Size = new System.Drawing.Size(426, 46);
            this.txtAmountPaidAfterditing.TabIndex = 55;
            this.txtAmountPaidAfterditing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmountPaidAfterditing.TextChanged += new System.EventHandler(this.txtAmountPaid_TextChanged);
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(8, 545);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(432, 55);
            this.btnPay.TabIndex = 52;
            this.btnPay.Text = "دفع";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtTotalInvoiceAfterEditing
            // 
            this.txtTotalInvoiceAfterEditing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalInvoiceAfterEditing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.txtTotalInvoiceAfterEditing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalInvoiceAfterEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txtTotalInvoiceAfterEditing.ForeColor = System.Drawing.Color.Black;
            this.txtTotalInvoiceAfterEditing.Location = new System.Drawing.Point(12, 187);
            this.txtTotalInvoiceAfterEditing.Multiline = true;
            this.txtTotalInvoiceAfterEditing.Name = "txtTotalInvoiceAfterEditing";
            this.txtTotalInvoiceAfterEditing.Size = new System.Drawing.Size(426, 44);
            this.txtTotalInvoiceAfterEditing.TabIndex = 53;
            this.txtTotalInvoiceAfterEditing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRemainingAmountAfterEditing
            // 
            this.txtRemainingAmountAfterEditing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemainingAmountAfterEditing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.txtRemainingAmountAfterEditing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemainingAmountAfterEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txtRemainingAmountAfterEditing.ForeColor = System.Drawing.Color.Black;
            this.txtRemainingAmountAfterEditing.Location = new System.Drawing.Point(8, 450);
            this.txtRemainingAmountAfterEditing.Multiline = true;
            this.txtRemainingAmountAfterEditing.Name = "txtRemainingAmountAfterEditing";
            this.txtRemainingAmountAfterEditing.Size = new System.Drawing.Size(426, 44);
            this.txtRemainingAmountAfterEditing.TabIndex = 53;
            this.txtRemainingAmountAfterEditing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmountPaidBeforEditing
            // 
            this.txtAmountPaidBeforEditing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmountPaidBeforEditing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.txtAmountPaidBeforEditing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountPaidBeforEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txtAmountPaidBeforEditing.ForeColor = System.Drawing.Color.Black;
            this.txtAmountPaidBeforEditing.Location = new System.Drawing.Point(10, 275);
            this.txtAmountPaidBeforEditing.Multiline = true;
            this.txtAmountPaidBeforEditing.Name = "txtAmountPaidBeforEditing";
            this.txtAmountPaidBeforEditing.Size = new System.Drawing.Size(426, 44);
            this.txtAmountPaidBeforEditing.TabIndex = 53;
            this.txtAmountPaidBeforEditing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(269, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 27);
            this.label6.TabIndex = 54;
            this.label6.Text = "المبلغ المتبقي على العميل";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(269, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 27);
            this.label5.TabIndex = 54;
            this.label5.Text = "سداد مبلغ اضافي";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(270, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 27);
            this.label3.TabIndex = 54;
            this.label3.Text = "المبلغ المدفوع سابقاً";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(269, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 27);
            this.label2.TabIndex = 54;
            this.label2.Text = "اجمالي الفاتورة الحالية";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalInvoiceBeforEditing
            // 
            this.txtTotalInvoiceBeforEditing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalInvoiceBeforEditing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.txtTotalInvoiceBeforEditing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalInvoiceBeforEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txtTotalInvoiceBeforEditing.ForeColor = System.Drawing.Color.Black;
            this.txtTotalInvoiceBeforEditing.Location = new System.Drawing.Point(12, 105);
            this.txtTotalInvoiceBeforEditing.Multiline = true;
            this.txtTotalInvoiceBeforEditing.Name = "txtTotalInvoiceBeforEditing";
            this.txtTotalInvoiceBeforEditing.Size = new System.Drawing.Size(424, 44);
            this.txtTotalInvoiceBeforEditing.TabIndex = 53;
            this.txtTotalInvoiceBeforEditing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(274, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 54;
            this.label1.Text = "اجمالي الفاتورة السابقة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(4, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(442, 4);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 608);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(146)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 608);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 4);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(446, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 612);
            this.panel2.TabIndex = 0;
            // 
            // frmPaymentDebtInvoice
            // 
            this.AcceptButton = this.btnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(450, 612);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPaymentDebtInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPaymentAmount";
            this.Load += new System.EventHandler(this.frmPaymentAmount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtAmountPaidBeforEditing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalInvoiceBeforEditing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtAmountPaidAfterditing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalInvoiceAfterEditing;
        private System.Windows.Forms.TextBox txtRemainingAmountAfterEditing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnClose;
    }
}