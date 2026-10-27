namespace System_C_Sharp_SuperMarket_DB_MISS.Settings
{
    partial class frmLoginHistory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearchLoginHistories = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvShowLoginHistories = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowLoginHistories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtSearchLoginHistories);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dgvShowLoginHistories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1504, 593);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.BlueViolet;
            this.panel5.Location = new System.Drawing.Point(12, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1290, 3);
            this.panel5.TabIndex = 59;
            // 
            // txtSearchLoginHistories
            // 
            this.txtSearchLoginHistories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchLoginHistories.BackColor = System.Drawing.Color.White;
            this.txtSearchLoginHistories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchLoginHistories.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtSearchLoginHistories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchLoginHistories.Location = new System.Drawing.Point(12, 34);
            this.txtSearchLoginHistories.Name = "txtSearchLoginHistories";
            this.txtSearchLoginHistories.Size = new System.Drawing.Size(1290, 31);
            this.txtSearchLoginHistories.TabIndex = 11;
            this.txtSearchLoginHistories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchLoginHistories.TextChanged += new System.EventHandler(this.txtSearchLoginHistories_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.Location = new System.Drawing.Point(1308, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(184, 31);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "بحــث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvShowLoginHistories
            // 
            this.dgvShowLoginHistories.AllowUserToAddRows = false;
            this.dgvShowLoginHistories.AllowUserToDeleteRows = false;
            this.dgvShowLoginHistories.AllowUserToOrderColumns = true;
            this.dgvShowLoginHistories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowLoginHistories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowLoginHistories.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvShowLoginHistories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowLoginHistories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvShowLoginHistories.Location = new System.Drawing.Point(12, 78);
            this.dgvShowLoginHistories.Name = "dgvShowLoginHistories";
            this.dgvShowLoginHistories.ReadOnly = true;
            this.dgvShowLoginHistories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvShowLoginHistories.RowHeadersWidth = 51;
            this.dgvShowLoginHistories.RowTemplate.Height = 24;
            this.dgvShowLoginHistories.Size = new System.Drawing.Size(1480, 509);
            this.dgvShowLoginHistories.TabIndex = 5;
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
            this.button1.Location = new System.Drawing.Point(22, 41);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(24, 21);
            this.button1.TabIndex = 60;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmLoginHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1504, 667);
            this.Controls.Add(this.panel1);
            this.Name = "frmLoginHistory";
            this.Load += new System.EventHandler(this.frmLoginHistory_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowLoginHistories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvShowLoginHistories;
        private System.Windows.Forms.TextBox txtSearchLoginHistories;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
    }
}