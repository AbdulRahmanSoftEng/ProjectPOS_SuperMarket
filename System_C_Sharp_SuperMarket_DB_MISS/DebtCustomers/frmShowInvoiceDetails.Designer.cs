namespace System_C_Sharp_SuperMarket_DB_MISS.DebtCustomers
{
    partial class frmShowInvoiceDetails
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
            this.dgvShowInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDateTimeInvoices = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalInvoice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRemainingAmount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCountItems = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCustomerFullName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInvoiceDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowInvoiceDetails
            // 
            this.dgvShowInvoiceDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowInvoiceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowInvoiceDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.dgvShowInvoiceDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowInvoiceDetails.ColumnHeadersHeight = 25;
            this.dgvShowInvoiceDetails.Location = new System.Drawing.Point(10, 162);
            this.dgvShowInvoiceDetails.Name = "dgvShowInvoiceDetails";
            this.dgvShowInvoiceDetails.RowHeadersWidth = 51;
            this.dgvShowInvoiceDetails.RowTemplate.Height = 24;
            this.dgvShowInvoiceDetails.Size = new System.Drawing.Size(474, 286);
            this.dgvShowInvoiceDetails.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(146)))));
            this.label20.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(0, 702);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(495, 8);
            this.label20.TabIndex = 76;
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d
            // 
            this.d.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.d.BackColor = System.Drawing.Color.AliceBlue;
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.d.ForeColor = System.Drawing.Color.Blue;
            this.d.Location = new System.Drawing.Point(13, 468);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(102, 36);
            this.d.TabIndex = 74;
            this.d.Text = "رقم الفاتورة";
            this.d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceID.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblInvoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInvoiceID.Location = new System.Drawing.Point(123, 468);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(133, 36);
            this.lblInvoiceID.TabIndex = 75;
            this.lblInvoiceID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(146)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 55);
            this.label2.TabIndex = 74;
            this.label2.Text = "تفاصيل الفاتورة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(146)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(495, 55);
            this.label3.TabIndex = 76;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateTimeInvoices
            // 
            this.lblDateTimeInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTimeInvoices.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblDateTimeInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateTimeInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDateTimeInvoices.Location = new System.Drawing.Point(123, 513);
            this.lblDateTimeInvoices.Name = "lblDateTimeInvoices";
            this.lblDateTimeInvoices.Size = new System.Drawing.Size(361, 36);
            this.lblDateTimeInvoices.TabIndex = 75;
            this.lblDateTimeInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(13, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 36);
            this.label4.TabIndex = 74;
            this.label4.Text = "تاريخ الفاتورة";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalInvoice
            // 
            this.lblTotalInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalInvoice.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTotalInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalInvoice.Location = new System.Drawing.Point(123, 562);
            this.lblTotalInvoice.Name = "lblTotalInvoice";
            this.lblTotalInvoice.Size = new System.Drawing.Size(361, 36);
            this.lblTotalInvoice.TabIndex = 75;
            this.lblTotalInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(13, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 36);
            this.label6.TabIndex = 74;
            this.label6.Text = "الاجمالي";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmountPaid.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAmountPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAmountPaid.Location = new System.Drawing.Point(123, 609);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(361, 36);
            this.lblAmountPaid.TabIndex = 75;
            this.lblAmountPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(13, 609);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 36);
            this.label8.TabIndex = 74;
            this.label8.Text = "المبلغ المدفوع";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRemainingAmount
            // 
            this.lblRemainingAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemainingAmount.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblRemainingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemainingAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRemainingAmount.Location = new System.Drawing.Point(123, 655);
            this.lblRemainingAmount.Name = "lblRemainingAmount";
            this.lblRemainingAmount.Size = new System.Drawing.Size(361, 36);
            this.lblRemainingAmount.TabIndex = 75;
            this.lblRemainingAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.AliceBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(13, 655);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 36);
            this.label10.TabIndex = 74;
            this.label10.Text = "المبلغ المتبقي";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountItems
            // 
            this.lblCountItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountItems.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblCountItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCountItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCountItems.Location = new System.Drawing.Point(357, 468);
            this.lblCountItems.Name = "lblCountItems";
            this.lblCountItems.Size = new System.Drawing.Size(128, 36);
            this.lblCountItems.TabIndex = 75;
            this.lblCountItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.AliceBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(262, 468);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 36);
            this.label12.TabIndex = 74;
            this.label12.Text = "عدد الاصناف";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerFullName
            // 
            this.lblCustomerFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerFullName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblCustomerFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomerFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerFullName.Location = new System.Drawing.Point(121, 66);
            this.lblCustomerFullName.Name = "lblCustomerFullName";
            this.lblCustomerFullName.Size = new System.Drawing.Size(364, 36);
            this.lblCustomerFullName.TabIndex = 75;
            this.lblCustomerFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.AliceBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(10, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 36);
            this.label14.TabIndex = 74;
            this.label14.Text = "العميل";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserFullName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserFullName.Location = new System.Drawing.Point(121, 113);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(364, 36);
            this.lblUserFullName.TabIndex = 75;
            this.lblUserFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.AliceBlue;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(10, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 36);
            this.label16.TabIndex = 74;
            this.label16.Text = "المستخدم";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnClose.Location = new System.Drawing.Point(453, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 38);
            this.btnClose.TabIndex = 77;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 710);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblRemainingAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalInvoice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDateTimeInvoices);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblUserFullName);
            this.Controls.Add(this.lblCountItems);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblCustomerFullName);
            this.Controls.Add(this.d);
            this.Controls.Add(this.lblInvoiceID);
            this.Controls.Add(this.dgvShowInvoiceDetails);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowInvoiceDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضهار تفاصيل الفاتورة";
            this.Load += new System.EventHandler(this.frmShowInvoiceDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInvoiceDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowInvoiceDetails;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDateTimeInvoices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalInvoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRemainingAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCountItems;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCustomerFullName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnClose;
    }
}