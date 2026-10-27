using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_C_Sharp_SuperMarket_DB_MISS.Properties;
using System_C_Sharp_SuperMarket_DB_MISS.Shared;

namespace System_C_Sharp_SuperMarket_DB_MISS
{
    public partial class frmLogin : Form
    {
      
        private Form SplashForm;
        
        public frmLogin(Form SplashForm)
        {
            InitializeComponent();
            this.SplashForm = SplashForm;
        }

        public void ShowLogo()
        {
            //string LogoPath = clsSetting.GetLogoStocke();
            //if (LogoPath != "")
            //    pbLogo.ImageLocation = clsShared.DefaultPathImages + "\\" + LogoPath;
            //else
                pbLogo.Image = Resources.logo_Intro;
        }

        public void ShowTitle()
        {
            string Title = lblTitleStocke.Text = clsSetting.GetTitleSocke();
            if (Title != "")
                lblTitleStocke.Text = Title;
            else
                lblTitleStocke.Text = "الموشكي للبرمجيات";
        }

        public void _Loadding()
        {
            ShowLogo();
            ShowTitle();
        }

        private void CheckFialdInputUser(TextBox txt, CancelEventArgs e, string NameFiald)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, "الرجاء قم بادخال "+ NameFiald);
            }
            else
            {
                errorProvider1.Clear();
                e.Cancel = false;
            }
        }

        private bool _Login()
        {
            bool IsFound = false;

            clsUser User = clsUser.FindUserByUserAndPass(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (User != null)
            {
                clsGlobal.UserID = User.ID;
                clsGlobal.CurrentUser = User.Username;
                clsGlobal.FullNameUser = User.FullName;
                clsGlobal.PermissionsUser = User.Permission;

                clsGlobal.LoginDateID = clsUser.AddLoginHistoryLoginDate(User.ID);
                IsFound = true;
            }

            return IsFound;  
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("لو سمحت املأ الحقول الفارغة", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
                else
                {
                    if (_Login())
                    {
                        frmMessage Message = new frmMessage("تم الدخول بنجاح", enTypeIcon.Success, 2);
                        Message.ShowDialog();

                        frmHome Home = new frmHome();
                        this.Hide();
                        Home.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("أسم المستخدم او كلمة المرور خطا", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void txtFiald_Validating(object sender, CancelEventArgs e)
        {
            CheckFialdInputUser((TextBox)sender, e, ((TextBox)sender).Tag.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(cbkShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
                cbkShowPass.Text = "أخفاء كلمة المرور";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                cbkShowPass.Text = "اضهار كلمة المرور";
            }
        }

        private void frmLogin_FontChanged(object sender, EventArgs e)
        {
            SplashForm.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
