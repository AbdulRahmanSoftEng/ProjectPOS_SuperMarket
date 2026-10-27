using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using DevExpress.XtraRichEdit;

namespace System_C_Sharp_SuperMarket_DB_MISS.Users
{
    public partial class frmAddEditUsers : Form
    {

        public enum enMode { AddNew, UpdateInfo};
        public enMode Mode;
        public event EventHandler DataUpdated;

        public int UserID = -1;

        private void NotifyDataUpdated()
        {
            if (DataUpdated != null)
                DataUpdated(this, EventArgs.Empty);
        }
        private void ReadDataFromFiald(ref clsUser User)
        {
            try
            {
                User.ID = UserID;
                User.FirstName = txtFirstName.Text;
                User.LastName = txtLastName.Text;
                User.Phone = !string.IsNullOrEmpty(txtPhone.Text) ? txtPhone.Text : "";
                User.Username = txtUsername.Text;
                User.Password = txtPassword.Text;

                if (txtPermission.Text != "")
                    User.Permission = Convert.ToInt64(txtPermission.Text);
            }
            catch(Exception ex)
            {
                //ex.Message;
            }
        }

        private void _AddNewUser()
        {
            clsUser NewUser = new clsUser();

            ReadDataFromFiald(ref NewUser);

          
            if (NewUser.Save())
            {
                frmMessage Message = new frmMessage("تم الاضافة بنجاح", enTypeIcon.Success, 2);
                Message.ShowDialog();
                NotifyDataUpdated();
                _ClearFiald();
            }
            else
            {
                frmMessage Message = new frmMessage("لم يتم الاضافة", enTypeIcon.Error, 2);
                Message.ShowDialog();
            }
        }


        private void _UpdateUser()
        {
            clsUser UpdateUser = clsUser.FindUserByID(UserID);

            ReadDataFromFiald(ref UpdateUser);

            if(UpdateUser != null)
            {
               
                if (UpdateUser.Save())
                {
                    frmMessage Message = new frmMessage("تم التعديل بنجاح", enTypeIcon.Success, 2);
                    Message.ShowDialog();
                    NotifyDataUpdated();
                    _ClearFiald();
                }
                else
                {
                    frmMessage Message = new frmMessage("لم يتم لتعديل", enTypeIcon.Error, 2);
                    Message.ShowDialog();
                }
            }
            else
            {
                frmMessage Message = new frmMessage($"لا يوجد بيانات بهذا الرقم = {UserID}", enTypeIcon.Error, 2);
                Message.ShowDialog();
            }
            
        }

        
        private void _SaveUserInfo()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    _AddNewUser();
                    break;

                case enMode.UpdateInfo:
                    _UpdateUser();
                    break;
            }
            
        }

        private void _SetUserToUpdate()
        {
           
            clsUser UpdateUser = clsUser.FindUserByID(this.UserID);

            if (UpdateUser != null)
            {
                txtUserID.Text = (UserID).ToString();
                txtFirstName.Text = UpdateUser.FirstName;
                txtLastName.Text = UpdateUser.LastName;
                txtPhone.Text = UpdateUser.Phone;
                txtUsername.Text = UpdateUser.Username;
                txtPassword.Text = UpdateUser.Password;

                txtPermission.Text = UpdateUser.Permission.ToString();

                // set operation
                lblTitle.Text = "تعديل بيانات المستخدم رقم = " + UserID;
                Mode = enMode.UpdateInfo;
            }
        }


        public void _LoadForm()
        {
            if (this.UserID != -1)
            {
                
                _SetUserToUpdate();
            }
            else
            {
                lblTitle.Text = "اضافة مستخدم جديد";
            }
        }

        private void _ClearFiald()
        {
            UserID = -1;
            Mode = enMode.AddNew;

            int ID = clsUser.GetLastIDUser();
            txtUserID.Text = ID != -1? ID.ToString(): "لايوجد اي مستخدم";
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtPermission.Clear();
        }

        private void _CheckFialdInputUser(TextBox txt, CancelEventArgs e, string NameFiald)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                txt.Focus();
                txt.BackColor = Color.FromArgb(255, 128, 128);
                errorProvider1.SetError(txt, "الرجاء قم بادخال " + NameFiald);
            }
            else
            {
                errorProvider1.Clear();
                e.Cancel = false;
                txt.BackColor = Color.White;

            }
        }

        public frmAddEditUsers(int ID)
        {

            InitializeComponent();
            this.UserID = ID;

            if (ID != -1)
                Mode = enMode.UpdateInfo;
            else
                Mode = enMode.AddNew;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPermission_Click(object sender, EventArgs e)
        {
            frmAddEditDelPermissions addEditDelPermissions = new frmAddEditDelPermissions();
            addEditDelPermissions.ShowDialog();

            txtPermission.Text = addEditDelPermissions.Permisssions != 0 ? addEditDelPermissions.Permisssions.ToString(): "";
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtPermission.Text))
            {
                _SaveUserInfo();
            }
            else
            {
                frmMessage Message = new frmMessage("قم بملا الحقول الفارغة", enTypeIcon.Error, 2);
                Message.ShowDialog();
            }
        }

        private void frmAddEditUsers_Load(object sender, EventArgs e)
        {
            _LoadForm();
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            _ClearFiald();
        }

        private void txtFiald_Validating(object sender, EventArgs e)
        {
            //_CheckFialdInputUser((TextBox)sender, e, ((TextBox)sender).Tag.ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
