using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_C_Sharp_SuperMarket_DB_MISS.Settings
{
    public partial class frmConnectionInformation : Form
    {
        public string[] Modes = { "Windows Authentication", "SQL Server Authentication" };
        public frmConnectionInformation()
        {
            InitializeComponent();
        }

        public void _Loadding()
        {
            try
            {
                cbModeAuthentication.Items.AddRange(Modes);
                cbModeAuthentication.SelectedIndex = 0;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            ShowServerInformation();

            ActionOfMode(false);
        }

        public void ActionOfMode(bool Action)
        {
            lblUsername.Enabled = Action;
            lblPasswrod.Enabled = Action;

            pnlUsername.Visible = Action;
            pnlPassword.Visible = Action;

            txtUsername.Visible = Action;
            txtPassword.Visible = Action;
        }

        public void _Close()
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _Close();
        }

        public void ReadInformationFromFiald(ref clsServerSettings Info)
        {
            Info.ServerName = txtServerName.Text;
            Info.DatabaseName = txtDatabaseName.Text;
            Info.ModeAuthentication = cbModeAuthentication.Text;
            Info.Username = txtUsername.Text;
            Info.Password = txtPassword.Text;
        }

        public void ShowServerInformation()
        {
            clsServerSettings Info = clsServerSettings.GetServerInformation();

            txtServerName.Text = Info.ServerName;
            txtDatabaseName.Text = Info.DatabaseName;
            if(Info.ModeAuthentication == "Windows Authentication")
            {
                cbModeAuthentication.Text = Info.ModeAuthentication;
                ActionOfMode(false);
            }
            else
            {
                cbModeAuthentication.Text = Info.ModeAuthentication;
                ActionOfMode(true);
                txtUsername.Text = Info.Username;
                txtPassword.Text = Info.Password;
            }
            
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            clsServerSettings Info = new clsServerSettings();

            ReadInformationFromFiald(ref Info);

            if(Info != null)
            {
                if (Info.SaveChanged())
                {

                    MessageBox.Show("تم حفظ الاعدادات بنجاح");
                }
                else
                {
                    MessageBox.Show("لم يتم حفظ الاعدادات هنالك مشكلة");
                }
            }
            else
            {
                MessageBox.Show("لايوجد بيانات ليتم حفظها");
            }
           
        }

        private void frmConnectionInformation_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void cbModeAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbModeAuthentication.SelectedIndex == 0)
                ActionOfMode(false);
            else
            {
                ActionOfMode(true);
                clsServerSettings Info = clsServerSettings.GetServerInformation();
                txtUsername.Text = Info.Username;
                txtPassword.Text = Info.Password;
            }
        }
    }
}
