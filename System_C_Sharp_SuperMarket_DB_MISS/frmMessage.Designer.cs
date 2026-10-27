namespace System_C_Sharp_SuperMarket_DB_MISS
{
    partial class frmMessage
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
            this.lblMessageTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbMessageIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMessageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessageTitle
            // 
            this.lblMessageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessageTitle.BackColor = System.Drawing.Color.White;
            this.lblMessageTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblMessageTitle.ForeColor = System.Drawing.Color.Black;
            this.lblMessageTitle.Location = new System.Drawing.Point(12, 0);
            this.lblMessageTitle.Name = "lblMessageTitle";
            this.lblMessageTitle.Size = new System.Drawing.Size(324, 76);
            this.lblMessageTitle.TabIndex = 53;
            this.lblMessageTitle.Text = "سبحان الله وبحمدة سبحان الله العظيم";
            this.lblMessageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbMessageIcon
            // 
            this.pbMessageIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbMessageIcon.Image = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.warring;
            this.pbMessageIcon.Location = new System.Drawing.Point(17, 79);
            this.pbMessageIcon.Name = "pbMessageIcon";
            this.pbMessageIcon.Size = new System.Drawing.Size(319, 135);
            this.pbMessageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMessageIcon.TabIndex = 54;
            this.pbMessageIcon.TabStop = false;
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 226);
            this.Controls.Add(this.pbMessageIcon);
            this.Controls.Add(this.lblMessageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Load += new System.EventHandler(this.frmMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMessageIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessageTitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbMessageIcon;
    }
}