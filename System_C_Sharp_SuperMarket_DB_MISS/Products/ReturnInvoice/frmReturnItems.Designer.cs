namespace System_C_Sharp_SuperMarket_DB_MISS.Products
{
    partial class frmReturnItems
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReturnItems = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditQty = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInvoiceID = new System.Windows.Forms.MaskedTextBox();
            this.btnShowsIDFromAllInvoices = new System.Windows.Forms.Button();
            this.txtLastNumberInvoices = new System.Windows.Forms.TextBox();
            this.btnShowAllInvoices = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShowsCustomer = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnEditInvoiceNotPrint = new System.Windows.Forms.Button();
            this.btnEditInvoiceWithinPrint = new System.Windows.Forms.Button();
            this.lblTxtShowRemainingAmount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalRemainingInvoiceAfterEditing = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalInvoiceAfterEditing = new System.Windows.Forms.Label();
            this.lblTotalInvoiceBeforEditing = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.lblRemainingAmount = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblCustomerFullNameInvoice = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.lblDateInvoice = new System.Windows.Forms.Label();
            this.lblTypeInvoice = new System.Windows.Forms.Label();
            this.lblUserFullNameInvoice = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMinusQty = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNameItem = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtQtyItem = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnItems)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReturnItems
            // 
            this.dgvReturnItems.AllowUserToAddRows = false;
            this.dgvReturnItems.AllowUserToDeleteRows = false;
            this.dgvReturnItems.AllowUserToOrderColumns = true;
            this.dgvReturnItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReturnItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnItems.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvReturnItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReturnItems.ColumnHeadersHeight = 30;
            this.dgvReturnItems.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvReturnItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvReturnItems.Location = new System.Drawing.Point(228, 224);
            this.dgvReturnItems.Name = "dgvReturnItems";
            this.dgvReturnItems.ReadOnly = true;
            this.dgvReturnItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvReturnItems.RowHeadersWidth = 51;
            this.dgvReturnItems.RowTemplate.Height = 24;
            this.dgvReturnItems.Size = new System.Drawing.Size(968, 305);
            this.dgvReturnItems.TabIndex = 2;
            this.dgvReturnItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturnItems_CellClick);
            this.dgvReturnItems.DoubleClick += new System.EventHandler(this.dgvReturnItems_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditQty});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 28);
            // 
            // tsmiEditQty
            // 
            this.tsmiEditQty.Name = "tsmiEditQty";
            this.tsmiEditQty.Size = new System.Drawing.Size(158, 24);
            this.tsmiEditQty.Text = "تعديل الكمية";
            this.tsmiEditQty.Click += new System.EventHandler(this.tsmiEditQty_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lblInvoiceID);
            this.panel3.Controls.Add(this.lblRemainingAmount);
            this.panel3.Controls.Add(this.lblAmountPaid);
            this.panel3.Controls.Add(this.lblCustomerFullNameInvoice);
            this.panel3.Controls.Add(this.d);
            this.panel3.Controls.Add(this.lblDateInvoice);
            this.panel3.Controls.Add(this.lblTypeInvoice);
            this.panel3.Controls.Add(this.lblUserFullNameInvoice);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtNameItem);
            this.panel3.Controls.Add(this.txtItemID);
            this.panel3.Controls.Add(this.dgvReturnItems);
            this.panel3.Controls.Add(this.txtQtyItem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1316, 586);
            this.panel3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtInvoiceID);
            this.groupBox1.Controls.Add(this.btnShowsIDFromAllInvoices);
            this.groupBox1.Controls.Add(this.txtLastNumberInvoices);
            this.groupBox1.Controls.Add(this.btnShowAllInvoices);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblShowsCustomer);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1295, 102);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "طرق استرجاع فاتورة المبيعات";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInvoiceID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtInvoiceID.Culture = new System.Globalization.CultureInfo("");
            this.txtInvoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtInvoiceID.ForeColor = System.Drawing.Color.Black;
            this.txtInvoiceID.Location = new System.Drawing.Point(898, 44);
            this.txtInvoiceID.Mask = "0000000";
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(196, 38);
            this.txtInvoiceID.TabIndex = 57;
            this.txtInvoiceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInvoiceID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInvoiceID_KeyDown);
            // 
            // btnShowsIDFromAllInvoices
            // 
            this.btnShowsIDFromAllInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowsIDFromAllInvoices.BackColor = System.Drawing.Color.Transparent;
            this.btnShowsIDFromAllInvoices.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.barcode_anamtions;
            this.btnShowsIDFromAllInvoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowsIDFromAllInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowsIDFromAllInvoices.FlatAppearance.BorderSize = 0;
            this.btnShowsIDFromAllInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowsIDFromAllInvoices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnShowsIDFromAllInvoices.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowsIDFromAllInvoices.ImageIndex = 5;
            this.btnShowsIDFromAllInvoices.Location = new System.Drawing.Point(1099, 44);
            this.btnShowsIDFromAllInvoices.Name = "btnShowsIDFromAllInvoices";
            this.btnShowsIDFromAllInvoices.Size = new System.Drawing.Size(30, 38);
            this.btnShowsIDFromAllInvoices.TabIndex = 56;
            this.btnShowsIDFromAllInvoices.UseVisualStyleBackColor = false;
            this.btnShowsIDFromAllInvoices.Click += new System.EventHandler(this.btnShowsIDFromAllInvoices_Click);
            // 
            // txtLastNumberInvoices
            // 
            this.txtLastNumberInvoices.BackColor = System.Drawing.Color.White;
            this.txtLastNumberInvoices.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLastNumberInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLastNumberInvoices.Location = new System.Drawing.Point(14, 42);
            this.txtLastNumberInvoices.Multiline = true;
            this.txtLastNumberInvoices.Name = "txtLastNumberInvoices";
            this.txtLastNumberInvoices.ReadOnly = true;
            this.txtLastNumberInvoices.Size = new System.Drawing.Size(113, 36);
            this.txtLastNumberInvoices.TabIndex = 52;
            this.txtLastNumberInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShowAllInvoices
            // 
            this.btnShowAllInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAllInvoices.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowAllInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAllInvoices.FlatAppearance.BorderSize = 0;
            this.btnShowAllInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllInvoices.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowAllInvoices.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowAllInvoices.Location = new System.Drawing.Point(766, 46);
            this.btnShowAllInvoices.Name = "btnShowAllInvoices";
            this.btnShowAllInvoices.Size = new System.Drawing.Size(122, 34);
            this.btnShowAllInvoices.TabIndex = 57;
            this.btnShowAllInvoices.Text = "اختيار فاتورة";
            this.btnShowAllInvoices.UseVisualStyleBackColor = false;
            this.btnShowAllInvoices.Click += new System.EventHandler(this.btnShowAllInvoices_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "رقم اخر فاتورة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShowsCustomer
            // 
            this.lblShowsCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowsCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblShowsCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowsCustomer.Location = new System.Drawing.Point(1134, 44);
            this.lblShowsCustomer.Name = "lblShowsCustomer";
            this.lblShowsCustomer.Size = new System.Drawing.Size(150, 38);
            this.lblShowsCustomer.TabIndex = 12;
            this.lblShowsCustomer.Text = "رقم الفاتورة /الباركود";
            this.lblShowsCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Controls.Add(this.panel10);
            this.groupBox2.Controls.Add(this.panel9);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.btnEditInvoiceNotPrint);
            this.groupBox2.Controls.Add(this.btnEditInvoiceWithinPrint);
            this.groupBox2.Controls.Add(this.lblTxtShowRemainingAmount);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblTotalRemainingInvoiceAfterEditing);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblTotalInvoiceAfterEditing);
            this.groupBox2.Controls.Add(this.lblTotalInvoiceBeforEditing);
            this.groupBox2.Location = new System.Drawing.Point(10, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 461);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حساب فاتورة المرتجع";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel10.Location = new System.Drawing.Point(5, 264);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(202, 3);
            this.panel10.TabIndex = 66;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(5, 180);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(202, 3);
            this.panel9.TabIndex = 66;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel8.Location = new System.Drawing.Point(5, 96);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(202, 3);
            this.panel8.TabIndex = 66;
            // 
            // btnEditInvoiceNotPrint
            // 
            this.btnEditInvoiceNotPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditInvoiceNotPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnEditInvoiceNotPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditInvoiceNotPrint.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnEditInvoiceNotPrint.FlatAppearance.BorderSize = 3;
            this.btnEditInvoiceNotPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInvoiceNotPrint.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEditInvoiceNotPrint.ForeColor = System.Drawing.Color.Black;
            this.btnEditInvoiceNotPrint.Location = new System.Drawing.Point(5, 404);
            this.btnEditInvoiceNotPrint.Name = "btnEditInvoiceNotPrint";
            this.btnEditInvoiceNotPrint.Size = new System.Drawing.Size(202, 51);
            this.btnEditInvoiceNotPrint.TabIndex = 65;
            this.btnEditInvoiceNotPrint.Text = "تعديل بدون طباعة";
            this.btnEditInvoiceNotPrint.UseVisualStyleBackColor = false;
            this.btnEditInvoiceNotPrint.Click += new System.EventHandler(this.btnEditInvoiceNotPrint_Click);
            // 
            // btnEditInvoiceWithinPrint
            // 
            this.btnEditInvoiceWithinPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditInvoiceWithinPrint.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEditInvoiceWithinPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditInvoiceWithinPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInvoiceWithinPrint.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEditInvoiceWithinPrint.ForeColor = System.Drawing.Color.White;
            this.btnEditInvoiceWithinPrint.Location = new System.Drawing.Point(5, 350);
            this.btnEditInvoiceWithinPrint.Name = "btnEditInvoiceWithinPrint";
            this.btnEditInvoiceWithinPrint.Size = new System.Drawing.Size(202, 51);
            this.btnEditInvoiceWithinPrint.TabIndex = 64;
            this.btnEditInvoiceWithinPrint.Text = "تعديل وطباعة";
            this.btnEditInvoiceWithinPrint.UseVisualStyleBackColor = false;
            this.btnEditInvoiceWithinPrint.Click += new System.EventHandler(this.btnEditInvoiceWithinPrint_Click);
            // 
            // lblTxtShowRemainingAmount
            // 
            this.lblTxtShowRemainingAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTxtShowRemainingAmount.BackColor = System.Drawing.Color.Navy;
            this.lblTxtShowRemainingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtShowRemainingAmount.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTxtShowRemainingAmount.Location = new System.Drawing.Point(5, 191);
            this.lblTxtShowRemainingAmount.Name = "lblTxtShowRemainingAmount";
            this.lblTxtShowRemainingAmount.Size = new System.Drawing.Size(202, 36);
            this.lblTxtShowRemainingAmount.TabIndex = 59;
            this.lblTxtShowRemainingAmount.Text = "المبلغ الباقي لمرتجع اصناف";
            this.lblTxtShowRemainingAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(5, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 36);
            this.label11.TabIndex = 59;
            this.label11.Text = "اجمالي الفاتورة بعد التعديل";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalRemainingInvoiceAfterEditing
            // 
            this.lblTotalRemainingInvoiceAfterEditing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRemainingInvoiceAfterEditing.BackColor = System.Drawing.Color.White;
            this.lblTotalRemainingInvoiceAfterEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRemainingInvoiceAfterEditing.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalRemainingInvoiceAfterEditing.Location = new System.Drawing.Point(5, 227);
            this.lblTotalRemainingInvoiceAfterEditing.Name = "lblTotalRemainingInvoiceAfterEditing";
            this.lblTotalRemainingInvoiceAfterEditing.Size = new System.Drawing.Size(202, 40);
            this.lblTotalRemainingInvoiceAfterEditing.TabIndex = 60;
            this.lblTotalRemainingInvoiceAfterEditing.Text = "0";
            this.lblTotalRemainingInvoiceAfterEditing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.MediumVioletRed;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 36);
            this.label10.TabIndex = 59;
            this.label10.Text = "اجمالي الفاتورة قبل التعديل";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalInvoiceAfterEditing
            // 
            this.lblTotalInvoiceAfterEditing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalInvoiceAfterEditing.BackColor = System.Drawing.Color.White;
            this.lblTotalInvoiceAfterEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvoiceAfterEditing.ForeColor = System.Drawing.Color.Black;
            this.lblTotalInvoiceAfterEditing.Location = new System.Drawing.Point(5, 143);
            this.lblTotalInvoiceAfterEditing.Name = "lblTotalInvoiceAfterEditing";
            this.lblTotalInvoiceAfterEditing.Size = new System.Drawing.Size(202, 40);
            this.lblTotalInvoiceAfterEditing.TabIndex = 60;
            this.lblTotalInvoiceAfterEditing.Text = "0";
            this.lblTotalInvoiceAfterEditing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalInvoiceBeforEditing
            // 
            this.lblTotalInvoiceBeforEditing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalInvoiceBeforEditing.BackColor = System.Drawing.Color.White;
            this.lblTotalInvoiceBeforEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvoiceBeforEditing.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTotalInvoiceBeforEditing.Location = new System.Drawing.Point(5, 59);
            this.lblTotalInvoiceBeforEditing.Name = "lblTotalInvoiceBeforEditing";
            this.lblTotalInvoiceBeforEditing.Size = new System.Drawing.Size(202, 40);
            this.lblTotalInvoiceBeforEditing.TabIndex = 60;
            this.lblTotalInvoiceBeforEditing.Text = "0";
            this.lblTotalInvoiceBeforEditing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.BackColor = System.Drawing.Color.AliceBlue;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(312, 537);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 36);
            this.label16.TabIndex = 59;
            this.label16.Text = "المبلغ المتبقي";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.BackColor = System.Drawing.Color.AliceBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(464, 537);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 36);
            this.label12.TabIndex = 59;
            this.label12.Text = "المبلغ المدفوع";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BackColor = System.Drawing.Color.AliceBlue;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(676, 536);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 36);
            this.label17.TabIndex = 59;
            this.label17.Text = "العميل";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.Color.AliceBlue;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(1201, 452);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 36);
            this.label15.TabIndex = 59;
            this.label15.Text = "نوع الفاتورة";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(1204, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 36);
            this.label8.TabIndex = 59;
            this.label8.Text = "رقم الفاتورة";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.AliceBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(908, 536);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 36);
            this.label13.TabIndex = 59;
            this.label13.Text = "المستخدم";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceID.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblInvoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceID.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblInvoiceID.Location = new System.Drawing.Point(1202, 267);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(104, 174);
            this.lblInvoiceID.TabIndex = 60;
            this.lblInvoiceID.Text = "0";
            this.lblInvoiceID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemainingAmount
            // 
            this.lblRemainingAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRemainingAmount.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblRemainingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingAmount.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblRemainingAmount.Location = new System.Drawing.Point(227, 536);
            this.lblRemainingAmount.Name = "lblRemainingAmount";
            this.lblRemainingAmount.Size = new System.Drawing.Size(80, 36);
            this.lblRemainingAmount.TabIndex = 60;
            this.lblRemainingAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAmountPaid.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaid.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblAmountPaid.Location = new System.Drawing.Point(376, 536);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(82, 36);
            this.lblAmountPaid.TabIndex = 60;
            this.lblAmountPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerFullNameInvoice
            // 
            this.lblCustomerFullNameInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerFullNameInvoice.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblCustomerFullNameInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFullNameInvoice.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblCustomerFullNameInvoice.Location = new System.Drawing.Point(528, 536);
            this.lblCustomerFullNameInvoice.Name = "lblCustomerFullNameInvoice";
            this.lblCustomerFullNameInvoice.Size = new System.Drawing.Size(143, 36);
            this.lblCustomerFullNameInvoice.TabIndex = 60;
            this.lblCustomerFullNameInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d
            // 
            this.d.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.d.BackColor = System.Drawing.Color.AliceBlue;
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.d.ForeColor = System.Drawing.Color.Blue;
            this.d.Location = new System.Drawing.Point(1201, 536);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(104, 36);
            this.d.TabIndex = 59;
            this.d.Text = "تاريخ الفاتورة";
            this.d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateInvoice
            // 
            this.lblDateInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateInvoice.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblDateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDateInvoice.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblDateInvoice.Location = new System.Drawing.Point(990, 536);
            this.lblDateInvoice.Name = "lblDateInvoice";
            this.lblDateInvoice.Size = new System.Drawing.Size(206, 36);
            this.lblDateInvoice.TabIndex = 60;
            this.lblDateInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTypeInvoice
            // 
            this.lblTypeInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTypeInvoice.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblTypeInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeInvoice.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTypeInvoice.Location = new System.Drawing.Point(1201, 493);
            this.lblTypeInvoice.Name = "lblTypeInvoice";
            this.lblTypeInvoice.Size = new System.Drawing.Size(104, 36);
            this.lblTypeInvoice.TabIndex = 60;
            this.lblTypeInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserFullNameInvoice
            // 
            this.lblUserFullNameInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserFullNameInvoice.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblUserFullNameInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullNameInvoice.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblUserFullNameInvoice.Location = new System.Drawing.Point(752, 536);
            this.lblUserFullNameInvoice.Name = "lblUserFullNameInvoice";
            this.lblUserFullNameInvoice.Size = new System.Drawing.Size(150, 36);
            this.lblUserFullNameInvoice.TabIndex = 60;
            this.lblUserFullNameInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnClearTable);
            this.panel7.Controls.Add(this.btnDelete);
            this.panel7.Controls.Add(this.btnMinusQty);
            this.panel7.Controls.Add(this.btnDeleteInvoice);
            this.panel7.Location = new System.Drawing.Point(228, 160);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1076, 53);
            this.panel7.TabIndex = 58;
            // 
            // btnClearTable
            // 
            this.btnClearTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnClearTable.BackColor = System.Drawing.Color.Transparent;
            this.btnClearTable.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.clear;
            this.btnClearTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearTable.FlatAppearance.BorderSize = 0;
            this.btnClearTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClearTable.ForeColor = System.Drawing.Color.White;
            this.btnClearTable.ImageIndex = 5;
            this.btnClearTable.Location = new System.Drawing.Point(434, 3);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(40, 40);
            this.btnClearTable.TabIndex = 67;
            this.btnClearTable.UseVisualStyleBackColor = false;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.close;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageIndex = 5;
            this.btnDelete.Location = new System.Drawing.Point(491, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMinusQty
            // 
            this.btnMinusQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnMinusQty.BackColor = System.Drawing.Color.Transparent;
            this.btnMinusQty.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.minus;
            this.btnMinusQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinusQty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinusQty.FlatAppearance.BorderSize = 0;
            this.btnMinusQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinusQty.ForeColor = System.Drawing.Color.White;
            this.btnMinusQty.ImageIndex = 5;
            this.btnMinusQty.Location = new System.Drawing.Point(548, 4);
            this.btnMinusQty.Name = "btnMinusQty";
            this.btnMinusQty.Size = new System.Drawing.Size(40, 40);
            this.btnMinusQty.TabIndex = 59;
            this.btnMinusQty.UseVisualStyleBackColor = false;
            this.btnMinusQty.Click += new System.EventHandler(this.btnMinusQty_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteInvoice.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteInvoice.FlatAppearance.BorderSize = 0;
            this.btnDeleteInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteInvoice.Font = new System.Drawing.Font("Segoe UI", 11.8F, System.Drawing.FontStyle.Bold);
            this.btnDeleteInvoice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(940, 6);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(131, 40);
            this.btnDeleteInvoice.TabIndex = 57;
            this.btnDeleteInvoice.Text = "حذف الفاتورة ";
            this.btnDeleteInvoice.UseVisualStyleBackColor = false;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Lavender;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(528, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 36);
            this.label7.TabIndex = 56;
            this.label7.Text = "الكمية";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Lavender;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(956, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 36);
            this.label6.TabIndex = 56;
            this.label6.Text = "اسم الصنف";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(1199, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 36);
            this.label4.TabIndex = 56;
            this.label4.Text = "رقم الصنف";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Location = new System.Drawing.Point(228, 150);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(297, 3);
            this.panel6.TabIndex = 54;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(606, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(344, 3);
            this.panel5.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(1097, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 3);
            this.panel4.TabIndex = 54;
            // 
            // txtNameItem
            // 
            this.txtNameItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameItem.BackColor = System.Drawing.Color.Snow;
            this.txtNameItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameItem.Location = new System.Drawing.Point(606, 116);
            this.txtNameItem.Multiline = true;
            this.txtNameItem.Name = "txtNameItem";
            this.txtNameItem.ReadOnly = true;
            this.txtNameItem.Size = new System.Drawing.Size(344, 37);
            this.txtNameItem.TabIndex = 53;
            this.txtNameItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtItemID
            // 
            this.txtItemID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemID.BackColor = System.Drawing.Color.Snow;
            this.txtItemID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(1097, 116);
            this.txtItemID.Multiline = true;
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(97, 37);
            this.txtItemID.TabIndex = 53;
            this.txtItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtyItem
            // 
            this.txtQtyItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtyItem.BackColor = System.Drawing.Color.White;
            this.txtQtyItem.Culture = new System.Globalization.CultureInfo("");
            this.txtQtyItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtQtyItem.ForeColor = System.Drawing.Color.Black;
            this.txtQtyItem.Location = new System.Drawing.Point(228, 115);
            this.txtQtyItem.Mask = "0000000";
            this.txtQtyItem.Name = "txtQtyItem";
            this.txtQtyItem.Size = new System.Drawing.Size(297, 38);
            this.txtQtyItem.TabIndex = 62;
            this.txtQtyItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtyItem.TextChanged += new System.EventHandler(this.txtQtyItem_TextChanged);
            // 
            // frmReturnItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1316, 660);
            this.Controls.Add(this.panel3);
            this.Name = "frmReturnItems";
            this.Text = "شاشة مرتجع المبيعات";
            this.Load += new System.EventHandler(this.frmReturnItems_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnItems)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReturnItems;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblShowsCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNameItem;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Button btnShowsIDFromAllInvoices;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMinusQty;
        private System.Windows.Forms.MaskedTextBox txtInvoiceID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCustomerFullNameInvoice;
        private System.Windows.Forms.Label lblTypeInvoice;
        private System.Windows.Forms.Label lblUserFullNameInvoice;
        private System.Windows.Forms.Label lblTotalInvoiceBeforEditing;
        private System.Windows.Forms.Label lblDateInvoice;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.MaskedTextBox txtQtyItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditQty;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditInvoiceNotPrint;
        private System.Windows.Forms.Button btnEditInvoiceWithinPrint;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblTxtShowRemainingAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalRemainingInvoiceAfterEditing;
        private System.Windows.Forms.Label lblTotalInvoiceAfterEditing;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblRemainingAmount;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtLastNumberInvoices;
        private System.Windows.Forms.Button btnShowAllInvoices;
        private System.Windows.Forms.Label label1;
    }
}