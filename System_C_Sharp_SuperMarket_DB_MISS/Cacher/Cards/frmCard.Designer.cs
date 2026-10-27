namespace System_C_Sharp_SuperMarket_DB_MISS.Cards
{
    partial class frmCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblPriceProductCard = new System.Windows.Forms.Label();
            this.btnImageProductCard = new System.Windows.Forms.Button();
            this.lblNameProductCard = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lblPriceProductCard);
            this.pnlCard.Controls.Add(this.btnImageProductCard);
            this.pnlCard.Controls.Add(this.lblNameProductCard);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.Location = new System.Drawing.Point(1, 1);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(107, 124);
            this.pnlCard.TabIndex = 0;
            // 
            // lblPriceProductCard
            // 
            this.lblPriceProductCard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPriceProductCard.ForeColor = System.Drawing.Color.Orange;
            this.lblPriceProductCard.Location = new System.Drawing.Point(3, 95);
            this.lblPriceProductCard.Name = "lblPriceProductCard";
            this.lblPriceProductCard.Size = new System.Drawing.Size(101, 29);
            this.lblPriceProductCard.TabIndex = 2;
            this.lblPriceProductCard.Text = "$150.0";
            this.lblPriceProductCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImageProductCard
            // 
            this.btnImageProductCard.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.search;
            this.btnImageProductCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImageProductCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImageProductCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImageProductCard.FlatAppearance.BorderSize = 0;
            this.btnImageProductCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageProductCard.Location = new System.Drawing.Point(0, 0);
            this.btnImageProductCard.Name = "btnImageProductCard";
            this.btnImageProductCard.Size = new System.Drawing.Size(107, 59);
            this.btnImageProductCard.TabIndex = 1;
            this.btnImageProductCard.UseVisualStyleBackColor = true;
            // 
            // lblNameProductCard
            // 
            this.lblNameProductCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProductCard.Location = new System.Drawing.Point(3, 62);
            this.lblNameProductCard.Name = "lblNameProductCard";
            this.lblNameProductCard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNameProductCard.Size = new System.Drawing.Size(101, 33);
            this.lblNameProductCard.TabIndex = 0;
            this.lblNameProductCard.Text = "عصير راني حبيبات";
            // 
            // frmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCard);
            this.Name = "frmCard";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(109, 126);
            this.pnlCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblPriceProductCard;
        private System.Windows.Forms.Button btnImageProductCard;
        private System.Windows.Forms.Label lblNameProductCard;
    }
}
