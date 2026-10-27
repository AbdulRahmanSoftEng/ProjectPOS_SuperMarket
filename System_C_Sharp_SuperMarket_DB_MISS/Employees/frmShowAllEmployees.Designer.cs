namespace System_C_Sharp_SuperMarket_DB_MISS.Employees
{
    partial class frmShowAllEmployees
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
            this.dgvShowEmployees = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUpdateEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewEmployees = new System.Windows.Forms.Button();
            this.btnEmployeeSearch = new System.Windows.Forms.Button();
            this.txtEmployeeSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCountEmployees = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowEmployees)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowEmployees
            // 
            this.dgvShowEmployees.AllowUserToAddRows = false;
            this.dgvShowEmployees.AllowUserToDeleteRows = false;
            this.dgvShowEmployees.AllowUserToOrderColumns = true;
            this.dgvShowEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowEmployees.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvShowEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowEmployees.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvShowEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvShowEmployees.Location = new System.Drawing.Point(8, 65);
            this.dgvShowEmployees.Name = "dgvShowEmployees";
            this.dgvShowEmployees.ReadOnly = true;
            this.dgvShowEmployees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvShowEmployees.RowHeadersWidth = 51;
            this.dgvShowEmployees.RowTemplate.Height = 24;
            this.dgvShowEmployees.Size = new System.Drawing.Size(1480, 405);
            this.dgvShowEmployees.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdateEmployee,
            this.tsmiDeleteEmployee});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 52);
            // 
            // tsmiUpdateEmployee
            // 
            this.tsmiUpdateEmployee.Name = "tsmiUpdateEmployee";
            this.tsmiUpdateEmployee.Size = new System.Drawing.Size(115, 24);
            this.tsmiUpdateEmployee.Text = "تعديل";
            this.tsmiUpdateEmployee.Click += new System.EventHandler(this.tsmiUpdateEmployee_Click);
            // 
            // tsmiDeleteEmployee
            // 
            this.tsmiDeleteEmployee.Name = "tsmiDeleteEmployee";
            this.tsmiDeleteEmployee.Size = new System.Drawing.Size(115, 24);
            this.tsmiDeleteEmployee.Text = "حذف";
            this.tsmiDeleteEmployee.Click += new System.EventHandler(this.tsmiDeleteEmployee_Click);
            // 
            // btnAddNewEmployees
            // 
            this.btnAddNewEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewEmployees.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAddNewEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNewEmployees.Location = new System.Drawing.Point(1294, 17);
            this.btnAddNewEmployees.Name = "btnAddNewEmployees";
            this.btnAddNewEmployees.Size = new System.Drawing.Size(194, 45);
            this.btnAddNewEmployees.TabIndex = 2;
            this.btnAddNewEmployees.Text = "موضف جديد";
            this.btnAddNewEmployees.UseVisualStyleBackColor = false;
            this.btnAddNewEmployees.Click += new System.EventHandler(this.btnAddNewEmployees_Click);
            // 
            // btnEmployeeSearch
            // 
            this.btnEmployeeSearch.BackColor = System.Drawing.Color.Gold;
            this.btnEmployeeSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmployeeSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEmployeeSearch.Location = new System.Drawing.Point(879, 24);
            this.btnEmployeeSearch.Name = "btnEmployeeSearch";
            this.btnEmployeeSearch.Size = new System.Drawing.Size(145, 35);
            this.btnEmployeeSearch.TabIndex = 2;
            this.btnEmployeeSearch.Text = "بحــث";
            this.btnEmployeeSearch.UseVisualStyleBackColor = false;
            this.btnEmployeeSearch.Click += new System.EventHandler(this.btnEmployeeSearch_Click);
            // 
            // txtEmployeeSearch
            // 
            this.txtEmployeeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmployeeSearch.Location = new System.Drawing.Point(8, 24);
            this.txtEmployeeSearch.Name = "txtEmployeeSearch";
            this.txtEmployeeSearch.Size = new System.Drawing.Size(865, 30);
            this.txtEmployeeSearch.TabIndex = 3;
            this.txtEmployeeSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmployeeSearch.TextChanged += new System.EventHandler(this.txtEmployeeSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(1190, 17);
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
            this.btnEdit.Location = new System.Drawing.Point(1086, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 45);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.lblCountEmployees);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnAddNewEmployees);
            this.panel3.Controls.Add(this.dgvShowEmployees);
            this.panel3.Controls.Add(this.txtEmployeeSearch);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEmployeeSearch);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1504, 524);
            this.panel3.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BackColor = System.Drawing.Color.AliceBlue;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(1338, 479);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 36);
            this.label17.TabIndex = 67;
            this.label17.Text = "عدد الموظفين";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountEmployees
            // 
            this.lblCountEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountEmployees.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblCountEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountEmployees.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblCountEmployees.Location = new System.Drawing.Point(1169, 479);
            this.lblCountEmployees.Name = "lblCountEmployees";
            this.lblCountEmployees.Size = new System.Drawing.Size(163, 36);
            this.lblCountEmployees.TabIndex = 68;
            this.lblCountEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.BlueViolet;
            this.panel6.Location = new System.Drawing.Point(8, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(865, 3);
            this.panel6.TabIndex = 63;
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
            this.button1.Location = new System.Drawing.Point(15, 29);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(24, 21);
            this.button1.TabIndex = 62;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmShowAllEmployees
            // 
            this.AcceptButton = this.btnAddNewEmployees;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 598);
            this.Controls.Add(this.panel3);
            this.Name = "frmShowAllEmployees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frmShowAllEmployees_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowEmployees)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowEmployees;
        private System.Windows.Forms.Button btnAddNewEmployees;
        private System.Windows.Forms.Button btnEmployeeSearch;
        private System.Windows.Forms.TextBox txtEmployeeSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteEmployee;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblCountEmployees;
    }       
}
