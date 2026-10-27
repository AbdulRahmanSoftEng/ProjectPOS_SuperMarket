using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Reflection.Emit;
using Business;
using System_C_Sharp_SuperMarket_DB_MISS.Properties;

namespace System_C_Sharp_SuperMarket_DB_MISS
{
    public partial class frmIntro : Form
    {

        private int _Counter = 0;
        public frmIntro()
        {
            InitializeComponent();           
        }

        public void ShowLogo()
        {

            string LogoPath = clsSetting.GetLogoStocke();
            if (LogoPath != "")
                pbLogo.ImageLocation = clsShared.DefaultPathImages + "\\" + LogoPath;
        }

        public void ShowTitle()
        {
            string Title =  lblTitleStocke.Text = clsSetting.GetTitleSocke();
            if (Title != "")
                lblTitleStocke.Text = Title;
            else
                lblTitleStocke.Text = "الموشكي للبرمجيات";
        }

        public void _Loadding()
        {
            ShowTitle();
            ShowLogo();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("abosheren2000@gmail.com");
        }

        int start = 4;
        private void timer1_Tick(object sender, EventArgs e)
        {
            _Counter+=start;
            lblCounter.Text = _Counter + "%";
            pbProgramStart.Value += start;
            pbProgramStart.Refresh();
            lblCounter.Refresh();

            if (pbProgramStart.Value == 100)
            {
                pbProgramStart.Value = 0;
                lblCounter.Text = "%";
                timer1.Stop();
                frmLogin login = new frmLogin(this);
                this.Hide();
                login.ShowDialog();
                this.Close();
                this.Dispose();
            }
        }

        private void frmIntro_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
