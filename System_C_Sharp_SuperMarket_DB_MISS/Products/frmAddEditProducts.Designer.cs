namespace System_C_Sharp_SuperMarket_DB_MISS.Products
{
    partial class frmAddEditProducts
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
            System.Windows.Forms.Button btnClose2;
            System.Windows.Forms.Button btnPluseQty;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditProducts));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbIsBarcodeContentProduct = new System.Windows.Forms.CheckBox();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAutoBarcode = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvShowBarcodeGenrater = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMinusQty = new System.Windows.Forms.Button();
            this.btnPrintAllBarcodes = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGoToCategoryForm = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            btnClose2 = new System.Windows.Forms.Button();
            btnPluseQty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBarcodeGenrater)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose2
            // 
            btnClose2.BackColor = System.Drawing.Color.Transparent;
            btnClose2.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.close;
            btnClose2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnClose2.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClose2.FlatAppearance.BorderSize = 0;
            btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnClose2.ForeColor = System.Drawing.Color.White;
            btnClose2.ImageIndex = 5;
            btnClose2.Location = new System.Drawing.Point(10, 7);
            btnClose2.Name = "btnClose2";
            btnClose2.Size = new System.Drawing.Size(32, 51);
            btnClose2.TabIndex = 32;
            btnClose2.UseVisualStyleBackColor = false;
            btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // btnPluseQty
            // 
            btnPluseQty.BackColor = System.Drawing.Color.Transparent;
            btnPluseQty.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.pluse;
            btnPluseQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnPluseQty.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPluseQty.FlatAppearance.BorderSize = 0;
            btnPluseQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPluseQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnPluseQty.ForeColor = System.Drawing.Color.White;
            btnPluseQty.ImageIndex = 5;
            btnPluseQty.Location = new System.Drawing.Point(271, 11);
            btnPluseQty.Name = "btnPluseQty";
            btnPluseQty.Size = new System.Drawing.Size(40, 40);
            btnPluseQty.TabIndex = 15;
            btnPluseQty.UseVisualStyleBackColor = false;
            btnPluseQty.Click += new System.EventHandler(this.btnPluseQty_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 500;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.Location = new System.Drawing.Point(346, 408);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(837, 63);
            this.panel1.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(456, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 43);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(576, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 43);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtProductID);
            this.panel2.Controls.Add(this.cbCategory);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtBarcode);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.cbIsBarcodeContentProduct);
            this.panel2.Controls.Add(this.btnRemoveImage);
            this.panel2.Controls.Add(this.btnAddImage);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnAutoBarcode);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pbImage);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(346, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(837, 399);
            this.panel2.TabIndex = 9;
            // 
            // txtProductID
            // 
            this.txtProductID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtProductID.Enabled = false;
            this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtProductID.Location = new System.Drawing.Point(157, 11);
            this.txtProductID.Multiline = true;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(526, 39);
            this.txtProductID.TabIndex = 7;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(157, 242);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbCategory.Size = new System.Drawing.Size(526, 33);
            this.cbCategory.TabIndex = 5;
            this.cbCategory.Tag = "القسم او المجموعة";
            this.cbCategory.Validating += new System.ComponentModel.CancelEventHandler(this.cbCategory_Validating);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label14.Location = new System.Drawing.Point(140, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 22);
            this.label14.TabIndex = 47;
            this.label14.Text = "*";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQty
            // 
            this.txtQty.Culture = new System.Globalization.CultureInfo("ar-YE");
            this.txtQty.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.HidePromptOnLeave = true;
            this.txtQty.Location = new System.Drawing.Point(157, 193);
            this.txtQty.Mask = "00000000";
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(526, 38);
            this.txtQty.TabIndex = 4;
            this.txtQty.ValidatingType = typeof(int);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label13.Location = new System.Drawing.Point(140, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 22);
            this.label13.TabIndex = 46;
            this.label13.Text = "*";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.Culture = new System.Globalization.CultureInfo("ar-YE");
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.HidePromptOnLeave = true;
            this.txtPrice.Location = new System.Drawing.Point(157, 148);
            this.txtPrice.Mask = "000000000000000000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(526, 38);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.ValidatingType = typeof(int);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(140, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 22);
            this.label12.TabIndex = 45;
            this.label12.Text = "*";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(157, 101);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(526, 39);
            this.txtName.TabIndex = 2;
            this.txtName.Tag = "اسم الصنف";
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFiald_Validating);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(140, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 22);
            this.label11.TabIndex = 44;
            this.label11.Text = "*";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBarcode.Location = new System.Drawing.Point(372, 60);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(266, 34);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.Tag = "الباركود";
            this.txtBarcode.Validating += new System.ComponentModel.CancelEventHandler(this.txtFiald_Validating);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(356, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 22);
            this.label9.TabIndex = 43;
            this.label9.Text = "*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.clear;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Yellow;
            this.btnClear.Location = new System.Drawing.Point(157, 353);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(43, 39);
            this.btnClear.TabIndex = 40;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbIsBarcodeContentProduct
            // 
            this.cbIsBarcodeContentProduct.AutoSize = true;
            this.cbIsBarcodeContentProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsBarcodeContentProduct.Location = new System.Drawing.Point(490, 359);
            this.cbIsBarcodeContentProduct.Name = "cbIsBarcodeContentProduct";
            this.cbIsBarcodeContentProduct.Size = new System.Drawing.Size(220, 24);
            this.cbIsBarcodeContentProduct.TabIndex = 7;
            this.cbIsBarcodeContentProduct.Text = "هل المنتج لا يحتوي على باركود";
            this.cbIsBarcodeContentProduct.UseVisualStyleBackColor = true;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.BackColor = System.Drawing.Color.White;
            this.btnRemoveImage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveImage.ForeColor = System.Drawing.Color.DimGray;
            this.btnRemoveImage.Location = new System.Drawing.Point(10, 237);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(124, 41);
            this.btnRemoveImage.TabIndex = 38;
            this.btnRemoveImage.Text = "الغاء الصورة";
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddImage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddImage.ForeColor = System.Drawing.Color.White;
            this.btnAddImage.Location = new System.Drawing.Point(10, 194);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(125, 41);
            this.btnAddImage.TabIndex = 8;
            this.btnAddImage.Text = "اختيار صورة";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescription.Location = new System.Drawing.Point(157, 283);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(526, 64);
            this.txtDescription.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 39);
            this.label3.TabIndex = 35;
            this.label3.Text = "انشاء باركود تلقائي";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAutoBarcode
            // 
            this.btnAutoBarcode.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAutoBarcode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAutoBarcode.ForeColor = System.Drawing.Color.Yellow;
            this.btnAutoBarcode.Location = new System.Drawing.Point(157, 56);
            this.btnAutoBarcode.Name = "btnAutoBarcode";
            this.btnAutoBarcode.Size = new System.Drawing.Size(66, 39);
            this.btnAutoBarcode.TabIndex = 10;
            this.btnAutoBarcode.Tag = "No";
            this.btnAutoBarcode.Text = "انشاء";
            this.btnAutoBarcode.UseVisualStyleBackColor = false;
            this.btnAutoBarcode.Click += new System.EventHandler(this.btnAutoBarcode_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(690, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 39);
            this.label8.TabIndex = 33;
            this.label8.Text = "القسم/المجموعة";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(688, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 39);
            this.label7.TabIndex = 33;
            this.label7.Text = "الكمية الموجوده";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.barcode_anamtions;
            this.pictureBox1.Location = new System.Drawing.Point(642, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 39);
            this.label10.TabIndex = 29;
            this.label10.Text = "اضافة صورة";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(688, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 64);
            this.label6.TabIndex = 25;
            this.label6.Text = "وصف الصنف";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(688, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 39);
            this.label5.TabIndex = 24;
            this.label5.Text = "ثمن البيع";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(690, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 39);
            this.label4.TabIndex = 23;
            this.label4.Text = "اسم الصنف";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(688, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 39);
            this.label2.TabIndex = 21;
            this.label2.Text = "الباركود";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(688, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "الرقم التسلسلي";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbImage.Image = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.current_user;
            this.pbImage.Location = new System.Drawing.Point(10, 49);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(124, 133);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 11;
            this.pbImage.TabStop = false;
            this.pbImage.Tag = "صورة للصنف";
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            this.pbImage.Validating += new System.ComponentModel.CancelEventHandler(this.pbImage_Validating);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.panel3.Location = new System.Drawing.Point(0, 112);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(1193, 484);
            this.panel3.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dgvShowBarcodeGenrater);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.btnPrintAllBarcodes);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(10, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(332, 466);
            this.panel5.TabIndex = 48;
            // 
            // dgvShowBarcodeGenrater
            // 
            this.dgvShowBarcodeGenrater.AllowUserToAddRows = false;
            this.dgvShowBarcodeGenrater.AllowUserToDeleteRows = false;
            this.dgvShowBarcodeGenrater.AllowUserToOrderColumns = true;
            this.dgvShowBarcodeGenrater.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowBarcodeGenrater.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowBarcodeGenrater.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowBarcodeGenrater.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowBarcodeGenrater.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowBarcodeGenrater.ColumnHeadersHeight = 30;
            this.dgvShowBarcodeGenrater.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvShowBarcodeGenrater.Location = new System.Drawing.Point(4, 52);
            this.dgvShowBarcodeGenrater.Name = "dgvShowBarcodeGenrater";
            this.dgvShowBarcodeGenrater.ReadOnly = true;
            this.dgvShowBarcodeGenrater.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvShowBarcodeGenrater.RowHeadersWidth = 51;
            this.dgvShowBarcodeGenrater.RowTemplate.Height = 24;
            this.dgvShowBarcodeGenrater.Size = new System.Drawing.Size(324, 289);
            this.dgvShowBarcodeGenrater.TabIndex = 2;
            this.dgvShowBarcodeGenrater.DoubleClick += new System.EventHandler(this.dgvShowBarcodeGenrater_DoubleClick);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnClearTable);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.btnMinusQty);
            this.panel6.Controls.Add(btnPluseQty);
            this.panel6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.panel6.Location = new System.Drawing.Point(4, 343);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(3);
            this.panel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel6.Size = new System.Drawing.Size(324, 68);
            this.panel6.TabIndex = 8;
            // 
            // btnClearTable
            // 
            this.btnClearTable.BackColor = System.Drawing.Color.Transparent;
            this.btnClearTable.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.clear;
            this.btnClearTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearTable.FlatAppearance.BorderSize = 0;
            this.btnClearTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClearTable.ForeColor = System.Drawing.Color.White;
            this.btnClearTable.ImageIndex = 5;
            this.btnClearTable.Location = new System.Drawing.Point(4, 9);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(40, 40);
            this.btnClearTable.TabIndex = 18;
            this.btnClearTable.UseVisualStyleBackColor = false;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.close;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageIndex = 5;
            this.btnDelete.Location = new System.Drawing.Point(93, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMinusQty
            // 
            this.btnMinusQty.BackColor = System.Drawing.Color.Transparent;
            this.btnMinusQty.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.minus;
            this.btnMinusQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinusQty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinusQty.FlatAppearance.BorderSize = 0;
            this.btnMinusQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinusQty.ForeColor = System.Drawing.Color.White;
            this.btnMinusQty.ImageIndex = 5;
            this.btnMinusQty.Location = new System.Drawing.Point(182, 11);
            this.btnMinusQty.Name = "btnMinusQty";
            this.btnMinusQty.Size = new System.Drawing.Size(40, 40);
            this.btnMinusQty.TabIndex = 16;
            this.btnMinusQty.UseVisualStyleBackColor = false;
            this.btnMinusQty.Click += new System.EventHandler(this.btnMinusQty_Click);
            // 
            // btnPrintAllBarcodes
            // 
            this.btnPrintAllBarcodes.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnPrintAllBarcodes.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnPrintAllBarcodes.FlatAppearance.BorderSize = 0;
            this.btnPrintAllBarcodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAllBarcodes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrintAllBarcodes.ForeColor = System.Drawing.Color.Black;
            this.btnPrintAllBarcodes.Location = new System.Drawing.Point(4, 418);
            this.btnPrintAllBarcodes.Name = "btnPrintAllBarcodes";
            this.btnPrintAllBarcodes.Size = new System.Drawing.Size(324, 38);
            this.btnPrintAllBarcodes.TabIndex = 8;
            this.btnPrintAllBarcodes.Text = "طابعة الكل";
            this.btnPrintAllBarcodes.UseVisualStyleBackColor = false;
            this.btnPrintAllBarcodes.Click += new System.EventHandler(this.btnPrintAllBarcodes_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(60, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(272, 39);
            this.label15.TabIndex = 29;
            this.label15.Text = "طباعة باركود للمنتجات";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.barcode_static;
            this.pictureBox2.Location = new System.Drawing.Point(4, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Elham", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1193, 61);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "صنف جديد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(btnClose2);
            this.panel4.Controls.Add(this.lblTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1193, 61);
            this.panel4.TabIndex = 32;
            // 
            // btnGoToCategoryForm
            // 
            this.btnGoToCategoryForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGoToCategoryForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGoToCategoryForm.ForeColor = System.Drawing.Color.Black;
            this.btnGoToCategoryForm.Location = new System.Drawing.Point(10, 65);
            this.btnGoToCategoryForm.Name = "btnGoToCategoryForm";
            this.btnGoToCategoryForm.Size = new System.Drawing.Size(130, 42);
            this.btnGoToCategoryForm.TabIndex = 11;
            this.btnGoToCategoryForm.Text = "قسم جديد";
            this.btnGoToCategoryForm.UseVisualStyleBackColor = false;
            this.btnGoToCategoryForm.Click += new System.EventHandler(this.btnGoToCategoryForm_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "barcode1.png");
            // 
            // frmAddEditProducts
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1193, 596);
            this.Controls.Add(this.btnGoToCategoryForm);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditProducts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات الاصناف";
            this.Load += new System.EventHandler(this.frmAddEditProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBarcodeGenrater)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAutoBarcode;
        private System.Windows.Forms.Button btnGoToCategoryForm;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbIsBarcodeContentProduct;
        private System.Windows.Forms.MaskedTextBox txtQty;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvShowBarcodeGenrater;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPrintAllBarcodes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMinusQty;
    }
}