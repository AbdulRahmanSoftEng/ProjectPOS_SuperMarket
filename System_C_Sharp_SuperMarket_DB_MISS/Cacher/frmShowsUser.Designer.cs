namespace System_C_Sharp_SuperMarket_DB_MISS.Cacher
{
    partial class frmShowsUser
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
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.dgbShowUsers = new System.Windows.Forms.DataGridView();
            this.cbTypeSearchUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbShowUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtUserSearch.Location = new System.Drawing.Point(148, 66);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(754, 34);
            this.txtUserSearch.TabIndex = 1;
            this.txtUserSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserSearch.TextChanged += new System.EventHandler(this.txtUserSearch_TextChanged);
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserSearch.BackColor = System.Drawing.Color.Gold;
            this.btnUserSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUserSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUserSearch.Location = new System.Drawing.Point(14, 65);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(129, 39);
            this.btnUserSearch.TabIndex = 5;
            this.btnUserSearch.Text = "بحــث";
            this.btnUserSearch.UseVisualStyleBackColor = false;
            // 
            // dgbShowUsers
            // 
            this.dgbShowUsers.AllowUserToAddRows = false;
            this.dgbShowUsers.AllowUserToDeleteRows = false;
            this.dgbShowUsers.AllowUserToOrderColumns = true;
            this.dgbShowUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbShowUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgbShowUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbShowUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbShowUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgbShowUsers.Location = new System.Drawing.Point(14, 110);
            this.dgbShowUsers.Name = "dgbShowUsers";
            this.dgbShowUsers.ReadOnly = true;
            this.dgbShowUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgbShowUsers.RowHeadersWidth = 51;
            this.dgbShowUsers.RowTemplate.Height = 24;
            this.dgbShowUsers.Size = new System.Drawing.Size(887, 168);
            this.dgbShowUsers.TabIndex = 4;
            this.dgbShowUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbShowUsers_CellClick);
            // 
            // cbTypeSearchUser
            // 
            this.cbTypeSearchUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTypeSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTypeSearchUser.FormattingEnabled = true;
            this.cbTypeSearchUser.ItemHeight = 25;
            this.cbTypeSearchUser.Location = new System.Drawing.Point(148, 16);
            this.cbTypeSearchUser.Name = "cbTypeSearchUser";
            this.cbTypeSearchUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTypeSearchUser.Size = new System.Drawing.Size(277, 33);
            this.cbTypeSearchUser.TabIndex = 7;
            this.cbTypeSearchUser.SelectedValueChanged += new System.EventHandler(this.cbTypeSearchCustomer_SelectedValueChanged);
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
            this.btnCloseForm.Location = new System.Drawing.Point(863, 7);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(32, 32);
            this.btnCloseForm.TabIndex = 13;
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Location = new System.Drawing.Point(148, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(753, 3);
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
            this.button1.Location = new System.Drawing.Point(872, 74);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(19, 21);
            this.button1.TabIndex = 65;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmShowsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(912, 290);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTypeSearchUser);
            this.Controls.Add(this.btnUserSearch);
            this.Controls.Add(this.dgbShowUsers);
            this.Controls.Add(this.txtUserSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowsUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowsCustomer";
            this.Load += new System.EventHandler(this.frmShowsCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbShowUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Button btnUserSearch;
        private System.Windows.Forms.DataGridView dgbShowUsers;
        private System.Windows.Forms.ComboBox cbTypeSearchUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
    }
}