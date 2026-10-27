namespace System_C_Sharp_SuperMarket_DB_MISS.Cacher
{
    partial class frmShowsSuppliers
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
            this.txtSuppliersSearch = new System.Windows.Forms.TextBox();
            this.btnSupplirsSearch = new System.Windows.Forms.Button();
            this.dgbShowSuppliers = new System.Windows.Forms.DataGridView();
            this.cbTypeSearchSuppliers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbShowSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSuppliersSearch
            // 
            this.txtSuppliersSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuppliersSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSuppliersSearch.Location = new System.Drawing.Point(148, 65);
            this.txtSuppliersSearch.Name = "txtSuppliersSearch";
            this.txtSuppliersSearch.Size = new System.Drawing.Size(518, 34);
            this.txtSuppliersSearch.TabIndex = 1;
            this.txtSuppliersSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSuppliersSearch.TextChanged += new System.EventHandler(this.txtSuppliersSearch_TextChanged);
            // 
            // btnSupplirsSearch
            // 
            this.btnSupplirsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupplirsSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSupplirsSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupplirsSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSupplirsSearch.Location = new System.Drawing.Point(10, 65);
            this.btnSupplirsSearch.Name = "btnSupplirsSearch";
            this.btnSupplirsSearch.Size = new System.Drawing.Size(127, 39);
            this.btnSupplirsSearch.TabIndex = 5;
            this.btnSupplirsSearch.Text = "بحــث";
            this.btnSupplirsSearch.UseVisualStyleBackColor = false;
            // 
            // dgbShowSuppliers
            // 
            this.dgbShowSuppliers.AllowUserToAddRows = false;
            this.dgbShowSuppliers.AllowUserToDeleteRows = false;
            this.dgbShowSuppliers.AllowUserToOrderColumns = true;
            this.dgbShowSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbShowSuppliers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgbShowSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbShowSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbShowSuppliers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgbShowSuppliers.Location = new System.Drawing.Point(10, 110);
            this.dgbShowSuppliers.Name = "dgbShowSuppliers";
            this.dgbShowSuppliers.ReadOnly = true;
            this.dgbShowSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgbShowSuppliers.RowHeadersWidth = 51;
            this.dgbShowSuppliers.RowTemplate.Height = 24;
            this.dgbShowSuppliers.Size = new System.Drawing.Size(654, 168);
            this.dgbShowSuppliers.TabIndex = 4;
            this.dgbShowSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbShowSuppliers_CellClick);
            // 
            // cbTypeSearchSuppliers
            // 
            this.cbTypeSearchSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeSearchSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTypeSearchSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTypeSearchSuppliers.FormattingEnabled = true;
            this.cbTypeSearchSuppliers.ItemHeight = 25;
            this.cbTypeSearchSuppliers.Location = new System.Drawing.Point(148, 16);
            this.cbTypeSearchSuppliers.Name = "cbTypeSearchSuppliers";
            this.cbTypeSearchSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTypeSearchSuppliers.Size = new System.Drawing.Size(277, 33);
            this.cbTypeSearchSuppliers.TabIndex = 7;
            this.cbTypeSearchSuppliers.SelectedValueChanged += new System.EventHandler(this.cbTypeSearchSuppliers_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "اختيار طريقة البحث";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.close;
            this.btnCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.ImageIndex = 5;
            this.btnCloseForm.Location = new System.Drawing.Point(631, 7);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(34, 46);
            this.btnCloseForm.TabIndex = 13;
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.BlueViolet;
            this.panel6.Location = new System.Drawing.Point(148, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(517, 3);
            this.panel6.TabIndex = 66;
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
            this.button1.Location = new System.Drawing.Point(639, 74);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 65;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmShowsSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(676, 290);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTypeSearchSuppliers);
            this.Controls.Add(this.txtSuppliersSearch);
            this.Controls.Add(this.btnSupplirsSearch);
            this.Controls.Add(this.dgbShowSuppliers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowsSuppliers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowsCustomer";
            this.Load += new System.EventHandler(this.frmShowSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbShowSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSuppliersSearch;
        private System.Windows.Forms.Button btnSupplirsSearch;
        private System.Windows.Forms.DataGridView dgbShowSuppliers;
        private System.Windows.Forms.ComboBox cbTypeSearchSuppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
    }
}