namespace System_C_Sharp_SuperMarket_DB_MISS.Products
{
    partial class frmShowAllProducts
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
            this.dgvShowProducts = new System.Windows.Forms.DataGridView();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCountProducts = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddNewQty = new System.Windows.Forms.Button();
            this.tsmiAddNewQty = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProducts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowProducts
            // 
            this.dgvShowProducts.AllowUserToAddRows = false;
            this.dgvShowProducts.AllowUserToDeleteRows = false;
            this.dgvShowProducts.AllowUserToOrderColumns = true;
            this.dgvShowProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowProducts.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvShowProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvShowProducts.Location = new System.Drawing.Point(12, 79);
            this.dgvShowProducts.Name = "dgvShowProducts";
            this.dgvShowProducts.ReadOnly = true;
            this.dgvShowProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvShowProducts.RowHeadersWidth = 51;
            this.dgvShowProducts.RowTemplate.Height = 24;
            this.dgvShowProducts.Size = new System.Drawing.Size(1479, 394);
            this.dgvShowProducts.TabIndex = 1;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewProduct.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAddNewProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewProduct.Location = new System.Drawing.Point(1277, 28);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(214, 45);
            this.btnAddNewProduct.TabIndex = 2;
            this.btnAddNewProduct.Text = "صنف جديد";
            this.btnAddNewProduct.UseVisualStyleBackColor = false;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.BackColor = System.Drawing.Color.Gold;
            this.btnProductSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProductSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnProductSearch.Location = new System.Drawing.Point(750, 40);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(140, 35);
            this.btnProductSearch.TabIndex = 2;
            this.btnProductSearch.Text = "بحــث";
            this.btnProductSearch.UseVisualStyleBackColor = false;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSearch.Location = new System.Drawing.Point(12, 43);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(732, 27);
            this.txtProductSearch.TabIndex = 3;
            this.txtProductSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProductSearch.TextChanged += new System.EventHandler(this.txtProductSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(1020, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(916, 28);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 45);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDelete,
            this.tsmiAddNewQty});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(193, 24);
            this.tsmiEdit.Text = "تعديل";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(193, 24);
            this.tsmiDelete.Text = "حذف";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.lblCountProducts);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnAddNewProduct);
            this.panel3.Controls.Add(this.txtProductSearch);
            this.panel3.Controls.Add(this.dgvShowProducts);
            this.panel3.Controls.Add(this.btnProductSearch);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnAddNewQty);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1504, 524);
            this.panel3.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.BlueViolet;
            this.panel6.Location = new System.Drawing.Point(12, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(732, 3);
            this.panel6.TabIndex = 67;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BackColor = System.Drawing.Color.AliceBlue;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(1342, 480);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 36);
            this.label17.TabIndex = 61;
            this.label17.Text = "عدد الاصناف";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountProducts
            // 
            this.lblCountProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountProducts.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblCountProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountProducts.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblCountProducts.Location = new System.Drawing.Point(1173, 480);
            this.lblCountProducts.Name = "lblCountProducts";
            this.lblCountProducts.Size = new System.Drawing.Size(163, 36);
            this.lblCountProducts.TabIndex = 62;
            this.lblCountProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageIndex = 5;
            this.button1.Location = new System.Drawing.Point(23, 45);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(24, 21);
            this.button1.TabIndex = 49;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAddNewQty
            // 
            this.btnAddNewQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddNewQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewQty.ForeColor = System.Drawing.Color.White;
            this.btnAddNewQty.Location = new System.Drawing.Point(1124, 28);
            this.btnAddNewQty.Name = "btnAddNewQty";
            this.btnAddNewQty.Size = new System.Drawing.Size(147, 45);
            this.btnAddNewQty.TabIndex = 2;
            this.btnAddNewQty.Text = "كمية جديدة";
            this.btnAddNewQty.UseVisualStyleBackColor = false;
            this.btnAddNewQty.Click += new System.EventHandler(this.btnAddNewQty_Click);
            // 
            // tsmiAddNewQty
            // 
            this.tsmiAddNewQty.Name = "tsmiAddNewQty";
            this.tsmiAddNewQty.Size = new System.Drawing.Size(210, 24);
            this.tsmiAddNewQty.Text = "اضافة كمية جديدة";
            this.tsmiAddNewQty.Click += new System.EventHandler(this.tsmiAddNewQty_Click);
            // 
            // frmShowAllProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 598);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel3);
            this.Name = "frmShowAllProducts";
            this.Text = "frmShowAllUsers";
            this.Load += new System.EventHandler(this.frmShowAllProducts_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProducts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowProducts;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblCountProducts;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewQty;
        private System.Windows.Forms.Button btnAddNewQty;
    }
}