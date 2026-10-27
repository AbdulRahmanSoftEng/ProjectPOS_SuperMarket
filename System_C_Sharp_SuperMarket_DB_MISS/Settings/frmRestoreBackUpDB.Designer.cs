namespace System_C_Sharp_SuperMarket_DB_MISS.Settings
{
    partial class frmRestoreBackUpDB
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.txtBackUpPath = new System.Windows.Forms.TextBox();
            this.btnRestorBackUpDB = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1480, 127);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "استعادة نسخة احطياطية";
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPath.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOpenPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.btnOpenPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnOpenPath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOpenPath.ForeColor = System.Drawing.Color.Black;
            this.btnOpenPath.Location = new System.Drawing.Point(1250, 52);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(189, 36);
            this.btnOpenPath.TabIndex = 2;
            this.btnOpenPath.Text = "اختيار مسار النسخة";
            this.btnOpenPath.UseVisualStyleBackColor = false;
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // txtBackUpPath
            // 
            this.txtBackUpPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackUpPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBackUpPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackUpPath.Location = new System.Drawing.Point(21, 52);
            this.txtBackUpPath.Multiline = true;
            this.txtBackUpPath.Name = "txtBackUpPath";
            this.txtBackUpPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBackUpPath.Size = new System.Drawing.Size(1223, 36);
            this.txtBackUpPath.TabIndex = 1;
            this.txtBackUpPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRestorBackUpDB
            // 
            this.btnRestorBackUpDB.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestorBackUpDB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRestorBackUpDB.ForeColor = System.Drawing.Color.White;
            this.btnRestorBackUpDB.Location = new System.Drawing.Point(12, 221);
            this.btnRestorBackUpDB.Name = "btnRestorBackUpDB";
            this.btnRestorBackUpDB.Size = new System.Drawing.Size(189, 45);
            this.btnRestorBackUpDB.TabIndex = 3;
            this.btnRestorBackUpDB.Text = "استعادة";
            this.btnRestorBackUpDB.UseVisualStyleBackColor = false;
            this.btnRestorBackUpDB.Click += new System.EventHandler(this.btnSaveBackUpDB_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmRestoreBackUpDB
            // 
            this.AcceptButton = this.btnRestorBackUpDB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1504, 598);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRestorBackUpDB);
            this.Name = "frmRestoreBackUpDB";
            this.Text = "frmShowAllUsers";
            this.Controls.SetChildIndex(this.btnRestorBackUpDB, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.TextBox txtBackUpPath;
        private System.Windows.Forms.Button btnRestorBackUpDB;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}