namespace System_C_Sharp_SuperMarket_DB_MISS
{
    partial class frmShowAllUsers
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
            this.dgvShowUsers = new System.Windows.Forms.DataGridView();
            this.ContaxtMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCountUsers = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUsers)).BeginInit();
            this.ContaxtMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowUsers
            // 
            this.dgvShowUsers.AllowUserToAddRows = false;
            this.dgvShowUsers.AllowUserToDeleteRows = false;
            this.dgvShowUsers.AllowUserToOrderColumns = true;
            this.dgvShowUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowUsers.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvShowUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowUsers.ContextMenuStrip = this.ContaxtMenuStrip;
            this.dgvShowUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvShowUsers.Location = new System.Drawing.Point(12, 129);
            this.dgvShowUsers.Name = "dgvShowUsers";
            this.dgvShowUsers.ReadOnly = true;
            this.dgvShowUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvShowUsers.RowHeadersWidth = 51;
            this.dgvShowUsers.RowTemplate.Height = 24;
            this.dgvShowUsers.Size = new System.Drawing.Size(1480, 400);
            this.dgvShowUsers.TabIndex = 1;
            // 
            // ContaxtMenuStrip
            // 
            this.ContaxtMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContaxtMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDelete});
            this.ContaxtMenuStrip.Name = "ContaxtMenuStrip";
            this.ContaxtMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContaxtMenuStrip.Size = new System.Drawing.Size(116, 52);
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
            this.tsmiDelete.Text = "حدف";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.Location = new System.Drawing.Point(12, 82);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(194, 45);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "مستخدم جديد";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserSearch.BackColor = System.Drawing.Color.Gold;
            this.btnUserSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUserSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUserSearch.Location = new System.Drawing.Point(499, 89);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(145, 35);
            this.btnUserSearch.TabIndex = 2;
            this.btnUserSearch.Text = "بحــث";
            this.btnUserSearch.UseVisualStyleBackColor = false;
            this.btnUserSearch.Click += new System.EventHandler(this.btnUserSearch_Click);
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserSearch.Location = new System.Drawing.Point(650, 93);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(842, 27);
            this.txtUserSearch.TabIndex = 3;
            this.txtUserSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserSearch.TextChanged += new System.EventHandler(this.txtUserSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(316, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(212, 82);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 45);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.BackColor = System.Drawing.Color.AliceBlue;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(13, 541);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 36);
            this.label17.TabIndex = 63;
            this.label17.Text = "عدد المستخدمين";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountUsers
            // 
            this.lblCountUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCountUsers.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblCountUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountUsers.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblCountUsers.Location = new System.Drawing.Point(168, 541);
            this.lblCountUsers.Name = "lblCountUsers";
            this.lblCountUsers.Size = new System.Drawing.Size(163, 36);
            this.lblCountUsers.TabIndex = 64;
            this.lblCountUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageIndex = 5;
            this.button1.Location = new System.Drawing.Point(1465, 93);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(24, 21);
            this.button1.TabIndex = 65;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.BlueViolet;
            this.panel6.Location = new System.Drawing.Point(650, 120);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(842, 3);
            this.panel6.TabIndex = 67;
            // 
            // frmShowAllUsers
            // 
            this.AcceptButton = this.btnAddUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 598);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblCountUsers);
            this.Controls.Add(this.txtUserSearch);
            this.Controls.Add(this.btnUserSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.dgvShowUsers);
            this.Name = "frmShowAllUsers";
            this.Text = "frmShowAllUsers";
            this.Load += new System.EventHandler(this.frmShowAllUsers_Load);
            this.Controls.SetChildIndex(this.dgvShowUsers, 0);
            this.Controls.SetChildIndex(this.btnAddUser, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnUserSearch, 0);
            this.Controls.SetChildIndex(this.txtUserSearch, 0);
            this.Controls.SetChildIndex(this.lblCountUsers, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUsers)).EndInit();
            this.ContaxtMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUserSearch;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ContextMenuStrip ContaxtMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblCountUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
    }
}