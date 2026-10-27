namespace System_C_Sharp_SuperMarket_DB_MISS
{
    partial class frmIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntro));
            this.lblTitleStocke = new System.Windows.Forms.Label();
            this.pbProgramStart = new System.Windows.Forms.ProgressBar();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleStocke
            // 
            this.lblTitleStocke.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleStocke.Font = new System.Drawing.Font("(A) Arslan Wessam A", 40F, System.Drawing.FontStyle.Bold);
            this.lblTitleStocke.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitleStocke.Location = new System.Drawing.Point(126, 37);
            this.lblTitleStocke.Name = "lblTitleStocke";
            this.lblTitleStocke.Size = new System.Drawing.Size(628, 76);
            this.lblTitleStocke.TabIndex = 1;
            this.lblTitleStocke.Text = "سوبر ماركت البــــــــاردة";
            this.lblTitleStocke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbProgramStart
            // 
            this.pbProgramStart.Location = new System.Drawing.Point(139, 406);
            this.pbProgramStart.Name = "pbProgramStart";
            this.pbProgramStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pbProgramStart.RightToLeftLayout = true;
            this.pbProgramStart.Size = new System.Drawing.Size(610, 30);
            this.pbProgramStart.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgramStart.TabIndex = 3;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.POS;
            this.pbLogo.Location = new System.Drawing.Point(40, 134);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(213, 182);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // lblCounter
            // 
            this.lblCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblCounter.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.White;
            this.lblCounter.Location = new System.Drawing.Point(784, 406);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(79, 30);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Text = "0%";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(693, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "الاصدار 1.0.9";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 27);
            this.panel1.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(179, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "abosheren2000@gmail.com";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.background_intro;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.pbLogo);
            this.panel2.Controls.Add(this.lblTitleStocke);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblCounter);
            this.panel2.Controls.Add(this.pbProgramStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 500);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.loading_gif;
            this.pictureBox2.Location = new System.Drawing.Point(838, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(6, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 31;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::System_C_Sharp_SuperMarket_DB_MISS.Properties.Resources.background_intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIntro";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مرحباً بك";
            this.Load += new System.EventHandler(this.frmIntro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitleStocke;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ProgressBar pbProgramStart;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnClose;
    }
}

