namespace System_C_Sharp_SuperMarket_DB_MISS.Salespeople
{
    partial class frmShowsCustomer
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
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.dgbShowCustomers = new System.Windows.Forms.DataGridView();
            this.cbTypeSearchCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbShowCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCustomerSearch.Location = new System.Drawing.Point(148, 66);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(518, 34);
            this.txtCustomerSearch.TabIndex = 1;
            this.txtCustomerSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerSearch.TextChanged += new System.EventHandler(this.txtCustomerSearch_TextChanged);
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomerSearch.BackColor = System.Drawing.Color.Gold;
            this.btnCustomerSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCustomerSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCustomerSearch.Location = new System.Drawing.Point(10, 65);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(127, 39);
            this.btnCustomerSearch.TabIndex = 5;
            this.btnCustomerSearch.Text = "بحــث";
            this.btnCustomerSearch.UseVisualStyleBackColor = false;
            // 
            // dgbShowCustomers
            // 
            this.dgbShowCustomers.AllowUserToAddRows = false;
            this.dgbShowCustomers.AllowUserToDeleteRows = false;
            this.dgbShowCustomers.AllowUserToOrderColumns = true;
            this.dgbShowCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbShowCustomers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgbShowCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbShowCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbShowCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgbShowCustomers.Location = new System.Drawing.Point(10, 110);
            this.dgbShowCustomers.Name = "dgbShowCustomers";
            this.dgbShowCustomers.ReadOnly = true;
            this.dgbShowCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgbShowCustomers.RowHeadersWidth = 51;
            this.dgbShowCustomers.RowTemplate.Height = 24;
            this.dgbShowCustomers.Size = new System.Drawing.Size(654, 168);
            this.dgbShowCustomers.TabIndex = 4;
            this.dgbShowCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbShowCustomers_CellClick);
            // 
            // cbTypeSearchCustomer
            // 
            this.cbTypeSearchCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTypeSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTypeSearchCustomer.FormattingEnabled = true;
            this.cbTypeSearchCustomer.ItemHeight = 25;
            this.cbTypeSearchCustomer.Location = new System.Drawing.Point(148, 16);
            this.cbTypeSearchCustomer.Name = "cbTypeSearchCustomer";
            this.cbTypeSearchCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTypeSearchCustomer.Size = new System.Drawing.Size(277, 33);
            this.cbTypeSearchCustomer.TabIndex = 7;
            this.cbTypeSearchCustomer.SelectedValueChanged += new System.EventHandler(this.cbTypeSearchCustomer_SelectedValueChanged);
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
            this.btnCloseForm.Location = new System.Drawing.Point(630, 7);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(37, 42);
            this.btnCloseForm.TabIndex = 13;
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnClose_Click);
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
            this.button1.Location = new System.Drawing.Point(640, 72);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 65;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmShowsCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(676, 290);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTypeSearchCustomer);
            this.Controls.Add(this.txtCustomerSearch);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.dgbShowCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowsCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowsCustomer";
            this.Load += new System.EventHandler(this.frmShowsCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbShowCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.DataGridView dgbShowCustomers;
        private System.Windows.Forms.ComboBox cbTypeSearchCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
    }
}