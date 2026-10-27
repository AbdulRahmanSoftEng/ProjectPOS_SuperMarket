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

namespace System_C_Sharp_SuperMarket_DB_MISS.Cacher
{
    public partial class frmShowsUser : Form
    {
        public enum enFindType { FindByFirstName = 0, FindByLastName = 1, FindByPhone = 2 };

        public string[] arrTypeSearch = { "بحث بستخدام الاسم الاول", "بحث بستخدام الاسم الخير", "بحث بستخدام رقم الهاتف" };

        public static int id = -1;

        public frmShowsUser()
        {
            InitializeComponent();
        }

        private void _FillComboBoxTypeSearch()
        {

            cbTypeSearchUser.Items.AddRange(arrTypeSearch);

            cbTypeSearchUser.SelectedIndex = 0;
        }

        private void _FindUserByFirstName(string FirstName)
        {
            dgbShowUsers.DataSource = clsUser.GetAllUserByNameUsingLike(FirstName);
        }

        private void _FindUserByLastName(string LastName)
        {
            dgbShowUsers.DataSource = clsUser.GetAllUserByLastNameUsingLike(LastName);

        }

        private void _FindUserByPhone(string Phone)
        {
            dgbShowUsers.DataSource = clsUser.GetAllUserByPhoneUsingLike(Phone);

        }

        private void _Find()
        {
            int ItemSelected = cbTypeSearchUser.SelectedIndex;

            switch ((enFindType)ItemSelected)
            {

                case enFindType.FindByFirstName:
                    _FindUserByFirstName(txtUserSearch.Text);
                    break;

                case enFindType.FindByLastName:
                    _FindUserByLastName(txtUserSearch.Text);
                    break;

                case enFindType.FindByPhone:
                    _FindUserByPhone(txtUserSearch.Text);
                    break;
            }
        }

        private void _ShowAllUsers()
        {
            DataTable dt = clsUser.GetAllUsers();
            if (dt != null)
            {
                dgbShowUsers.DataSource = dt;
            }
        }

        private void _Loadding()
        {
            _ShowAllUsers();
            _FillComboBoxTypeSearch();
        }

        private void frmShowsCustomer_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserSearch.Text))
            {
                _Find();
            }
            else
            {
                dgbShowUsers.DataSource = clsCustomer.GetAllCustomers();
                txtUserSearch.Focus();
            }
        }

        private void dgbShowUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgbShowUsers.CurrentRow.Cells[0].Value);
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTypeSearchCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            txtUserSearch.Focus();
        }

    }
}
