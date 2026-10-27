namespace System_C_Sharp_SuperMarket_DB_MISS.Suppliers
{
    partial class frmShowAllSuppliers
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
            this.dgvShowSuppliers = new System.Windows.Forms.DataGridView();
            this.btnAddNewSupplier = new System.Windows.Forms.Button();
            this.btnSupplierSearch = new System.Windows.Forms.Button();
            this.txtSearchSuppliers = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCountSuppliers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSuppliers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowSuppliers
            // 
            this.dgvShowSuppliers.AllowUserToAddRows = false;
            this.dgvShowSuppliers.AllowUserToDeleteRows = false;
            this.dgvShowSuppliers.AllowUserToOrderColumns = true;
            this.dgvShowSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowSuppliers.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvShowSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowSuppliers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvShowSuppliers.Location = new System.Drawing.Point(8, 76);
            this.dgvShowSuppliers.Name = "dgvShowSuppliers";
            this.dgvShowSuppliers.ReadOnly = true;
            this.dgvShowSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvShowSuppliers.RowHeadersWidth = 51;
            this.dgvShowSuppliers.RowTemplate.Height = 24;
            this.dgvShowSuppliers.Size = new System.Drawing.Size(1482, 390);
            this.dgvShowSuppliers.TabIndex = 1;
            // 
            // btnAddNewSupplier
            // 
            this.btnAddNewSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewSupplier.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAddNewSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewSupplier.Location = new System.Drawing.Point(1282, 28);
            this.btnAddNewSupplier.Name = "btnAddNewSupplier";
            this.btnAddNewSupplier.Size = new System.Drawing.Size(208, 45);
            this.btnAddNewSupplier.TabIndex = 2;
            this.btnAddNewSupplier.Text = "مورد جديد";
            this.btnAddNewSupplier.UseVisualStyleBackColor = false;
            this.btnAddNewSupplier.Click += new System.EventHandler(this.btnAddNewSupplier_Click);
            // 
            // btnSupplierSearch
            // 
            this.btnSupplierSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSupplierSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupplierSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSupplierSearch.Location = new System.Drawing.Point(840, 35);
            this.btnSupplierSearch.Name = "btnSupplierSearch";
            this.btnSupplierSearch.Size = new System.Drawing.Size(131, 35);
            this.btnSupplierSearch.TabIndex = 2;
            this.btnSupplierSearch.Text = "بحــث";
            this.btnSupplierSearch.UseVisualStyleBackColor = false;
            this.btnSupplierSearch.Click += new System.EventHandler(this.btnSupplierSearch_Click);
            // 
            // txtSearchSuppliers
            // 
            this.txtSearchSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearchSuppliers.Location = new System.Drawing.Point(12, 39);
            this.txtSearchSuppliers.Name = "txtSearchSuppliers";
            this.txtSearchSuppliers.Size = new System.Drawing.Size(822, 26);
            this.txtSearchSuppliers.TabIndex = 3;
            this.txtSearchSuppliers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchSuppliers.TextChanged += new System.EventHandler(this.txtSearchSuppliers_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(1074, 28);
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
            this.btnEdit.Location = new System.Drawing.Point(1178, 28);
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
            this.tsmiDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 52);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(115, 24);
            this.tsmiEdit.Text = "تعديل";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(115, 24);
            this.tsmiDelete.Text = "حذف";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.lblCountSuppliers);
            this.panel3.Controls.Add(this.btnAddNewSupplier);
            this.panel3.Controls.Add(this.dgvShowSuppliers);
            this.panel3.Controls.Add(this.txtSearchSuppliers);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnSupplierSearch);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1504, 524);
            this.panel3.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.BlueViolet;
            this.panel6.Location = new System.Drawing.Point(12, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(822, 3);
            this.panel6.TabIndex = 68;
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
            this.button1.Location = new System.Drawing.Point(15, 41);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(24, 21);
            this.button1.TabIndex = 67;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BackColor = System.Drawing.Color.AliceBlue;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(1342, 477);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 36);
            this.label17.TabIndex = 65;
            this.label17.Text = "عدد الموردين";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountSuppliers
            // 
            this.lblCountSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountSuppliers.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblCountSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountSuppliers.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblCountSuppliers.Location = new System.Drawing.Point(1173, 477);
            this.lblCountSuppliers.Name = "lblCountSuppliers";
            this.lblCountSuppliers.Size = new System.Drawing.Size(163, 36);
            this.lblCountSuppliers.TabIndex = 66;
            this.lblCountSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmShowAllSuppliers
            // 
            this.AcceptButton = this.btnAddNewSupplier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 598);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel3);
            this.Name = "frmShowAllSuppliers";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.frmShowAllSuppliers_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSuppliers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowSuppliers;
        private System.Windows.Forms.Button btnAddNewSupplier;
        private System.Windows.Forms.Button btnSupplierSearch;
        private System.Windows.Forms.TextBox txtSearchSuppliers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblCountSuppliers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
    }
}