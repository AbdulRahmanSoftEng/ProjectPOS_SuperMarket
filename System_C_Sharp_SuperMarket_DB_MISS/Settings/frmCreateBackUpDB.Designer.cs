namespace System_C_Sharp_SuperMarket_DB_MISS.Settings
{
    partial class frmCreateBackUpDB
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
            this.btnSaveBackUpDB = new System.Windows.Forms.Button();
            this.txtBackUpPath = new System.Windows.Forms.TextBox();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveBackUpDB
            // 
            this.btnSaveBackUpDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveBackUpDB.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveBackUpDB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveBackUpDB.ForeColor = System.Drawing.Color.White;
            this.btnSaveBackUpDB.Location = new System.Drawing.Point(1299, 155);
            this.btnSaveBackUpDB.Name = "btnSaveBackUpDB";
            this.btnSaveBackUpDB.Size = new System.Drawing.Size(189, 45);
            this.btnSaveBackUpDB.TabIndex = 3;
            this.btnSaveBackUpDB.Text = "انشاء";
            this.btnSaveBackUpDB.UseVisualStyleBackColor = false;
            this.btnSaveBackUpDB.Click += new System.EventHandler(this.btnSaveBackUpDB_Click);
            // 
            // txtBackUpPath
            // 
            this.txtBackUpPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackUpPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBackUpPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackUpPath.Location = new System.Drawing.Point(19, 52);
            this.txtBackUpPath.Multiline = true;
            this.txtBackUpPath.Name = "txtBackUpPath";
            this.txtBackUpPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBackUpPath.Size = new System.Drawing.Size(1225, 36);
            this.txtBackUpPath.TabIndex = 1;
            this.txtBackUpPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOpenPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.btnOpenPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnOpenPath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOpenPath.ForeColor = System.Drawing.Color.Black;
            this.btnOpenPath.Location = new System.Drawing.Point(1250, 52);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(189, 36);
            this.btnOpenPath.TabIndex = 2;
            this.btnOpenPath.Text = "اختيار مسار النصخة";
            this.btnOpenPath.UseVisualStyleBackColor = false;
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnOpenPath);
            this.groupBox1.Controls.Add(this.txtBackUpPath);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1480, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انشاء نصخة احطياطية";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnSaveBackUpDB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1504, 524);
            this.panel1.TabIndex = 7;
            // 
            // frmCreateBackUpDB
            // 
            this.AcceptButton = this.btnSaveBackUpDB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1504, 598);
            this.Controls.Add(this.panel1);
            this.Name = "frmCreateBackUpDB";
            this.Text = "frmShowAllUsers";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSaveBackUpDB;
        private System.Windows.Forms.TextBox txtBackUpPath;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}