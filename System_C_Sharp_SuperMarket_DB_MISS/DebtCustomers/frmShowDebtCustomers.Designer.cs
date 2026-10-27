namespace System_C_Sharp_SuperMarket_DB_MISS.DebtCustomers
{
    partial class frmShowDebtCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMethodSearchDebtCustomers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchDebtCustomers = new System.Windows.Forms.TextBox();
            this.dgvShowDebtCustomers = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDebtCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.dgvShowDebtCustomers);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 62);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1504, 526);
            this.panel7.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbMethodSearchDebtCustomers);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtSearchDebtCustomers);
            this.panel3.Location = new System.Drawing.Point(11, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1480, 59);
            this.panel3.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(602, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 33);
            this.label3.TabIndex = 62;
            this.label3.Text = "اختيار طريقة البحث";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMethodSearchDebtCustomers
            // 
            this.cbMethodSearchDebtCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethodSearchDebtCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMethodSearchDebtCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbMethodSearchDebtCustomers.FormattingEnabled = true;
            this.cbMethodSearchDebtCustomers.Location = new System.Drawing.Point(13, 10);
            this.cbMethodSearchDebtCustomers.Name = "cbMethodSearchDebtCustomers";
            this.cbMethodSearchDebtCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbMethodSearchDebtCustomers.Size = new System.Drawing.Size(583, 33);
            this.cbMethodSearchDebtCustomers.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Lavender;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(1370, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 36);
            this.label6.TabIndex = 60;
            this.label6.Text = "بحث";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchDebtCustomers
            // 
            this.txtSearchDebtCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchDebtCustomers.BackColor = System.Drawing.Color.Snow;
            this.txtSearchDebtCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDebtCustomers.Location = new System.Drawing.Point(801, 12);
            this.txtSearchDebtCustomers.Name = "txtSearchDebtCustomers";
            this.txtSearchDebtCustomers.Size = new System.Drawing.Size(563, 34);
            this.txtSearchDebtCustomers.TabIndex = 58;
            this.txtSearchDebtCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchDebtCustomers.TextChanged += new System.EventHandler(this.txtSearchDebtCustomers_TextChanged);
            // 
            // dgvShowDebtCustomers
            // 
            this.dgvShowDebtCustomers.AllowUserToAddRows = false;
            this.dgvShowDebtCustomers.AllowUserToDeleteRows = false;
            this.dgvShowDebtCustomers.AllowUserToOrderColumns = true;
            this.dgvShowDebtCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowDebtCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowDebtCustomers.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowDebtCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowDebtCustomers.ColumnHeadersHeight = 30;
            this.dgvShowDebtCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvShowDebtCustomers.Location = new System.Drawing.Point(11, 68);
            this.dgvShowDebtCustomers.Name = "dgvShowDebtCustomers";
            this.dgvShowDebtCustomers.ReadOnly = true;
            this.dgvShowDebtCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvShowDebtCustomers.RowHeadersWidth = 51;
            this.dgvShowDebtCustomers.RowTemplate.Height = 24;
            this.dgvShowDebtCustomers.Size = new System.Drawing.Size(1480, 451);
            this.dgvShowDebtCustomers.TabIndex = 59;
            this.dgvShowDebtCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowDebtCustomers_CellClick);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.BlueViolet;
            this.panel6.Location = new System.Drawing.Point(801, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(563, 3);
            this.panel6.TabIndex = 64;
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
            this.button1.Location = new System.Drawing.Point(811, 17);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(24, 21);
            this.button1.TabIndex = 63;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmShowDebtCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1504, 600);
            this.Controls.Add(this.panel7);
            this.Name = "frmShowDebtCustomers";
            this.Text = "شاشة ديون العملاء";
            this.Load += new System.EventHandler(this.frmShowDebtCustomers_Load);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDebtCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvShowDebtCustomers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchDebtCustomers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMethodSearchDebtCustomers;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
    }
}