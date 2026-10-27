using System;
using System_C_Sharp_SuperMarket_DB_MISS.Users;
using Business;
using System.Windows.Forms;

namespace System_C_Sharp_SuperMarket_DB_MISS
{
    public partial class frmShowAllUsers : frmSharedLayoutTop
    {
        
        
        public frmAddEditUsers AddEditUser;
        private void DeleteUser(int ID)
        {
            
            if (clsUser.UserIsExistByID(ID))
            {
                var Answer = MessageBox.Show("هل تريد حذف المستخدم؟ ", " حذف مستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if(Answer == DialogResult.Yes)
                {
                    clsUser.DeleteUser(ID);
                    frmMessage Message = new frmMessage("تم الحذف بنجاح", enTypeIcon.Success, 2);
                    Message.ShowDialog();
                    ShowAllUsers();
                }   
            }
            else
            {
                frmMessage Message = new frmMessage($"لايوجد هناك مستخدم بهذا الرقم {ID}", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
        }

        private void _EditRowEmployee(int ID)
        {
            AddEditUser = new frmAddEditUsers(ID);
            AddEditUser.DataUpdated += frmShowAllUsers_Load;
            AddEditUser.ShowDialog();
        }

        private void ShowAllUsers()
        {
            if(clsUser.GetAllUsers() != null)
                dgvShowUsers.DataSource = clsUser.GetAllUsers();
        }

        public void ShowCountUsers()
        {
            lblCountUsers.Text = clsUser.GetCountUsers().ToString();
        }

        public frmShowAllUsers(string Title = "...")
            :base(Title)
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddEditUser = new frmAddEditUsers(-1);
            AddEditUser.DataUpdated += frmShowAllUsers_Load;
            AddEditUser.ShowDialog();
        }

        private void _Loading()
        {
            ShowAllUsers();
            ShowCountUsers();
        }

        private void frmShowAllUsers_Load(object sender, EventArgs e)
        {
            _Loading();
        }

        public void Delete()
        {
            if (dgvShowUsers.SelectedCells.Count > 0)
                DeleteUser((int)dgvShowUsers.CurrentRow.Cells[0].Value);
            else
            {
                frmMessage Message = new frmMessage("قم بتحديد المستخدم المراد حذفه", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
        }

        public void Update()
        {
            if (dgvShowUsers.SelectedCells.Count > 0)
            {
                _EditRowEmployee((int)dgvShowUsers.CurrentRow.Cells[0].Value);
            }
            else
            {
                frmMessage Message = new frmMessage("قم بتحديد المستخدم المراد تعديل بياناتة", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
        }

        public void Search()
        {
            if (string.IsNullOrEmpty(txtUserSearch.Text))
            {
                dgvShowUsers.DataSource = clsUser.GetAllUsers();
            }
            else
            {
                dgvShowUsers.DataSource = clsUser.GetAllUserByNameUsingLike(txtUserSearch.Text);
            }
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            Update();
            
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            Delete();           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            
        }

        private void btnUserSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
