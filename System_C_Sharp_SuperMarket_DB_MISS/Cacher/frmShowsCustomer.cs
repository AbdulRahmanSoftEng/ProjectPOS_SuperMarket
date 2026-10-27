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
using System_C_Sharp_SuperMarket_DB_MISS.Customers;

namespace System_C_Sharp_SuperMarket_DB_MISS.Salespeople
{
    public partial class frmShowsCustomer : Form
    {
        public enum enFindType{FindByFirstName = 0, FindByLastName = 1, FindByPhone = 2};

        public string[] arrTypeSearch = { "بحث بستخدام الاسم الاول", "بحث بستخدام الاسم الخير", "بحث بستخدام رقم الهاتف" };

        public static int id = -1;

        public frmShowsCustomer()
        {
            InitializeComponent();
        }

        private void _FillComboBoxTypeSearch()
        {

            cbTypeSearchCustomer.Items.AddRange(arrTypeSearch);

            cbTypeSearchCustomer.SelectedIndex = 0;
        }

        private void _FindCustomerByFirstName(string FirstName)
        {
            dgbShowCustomers.DataSource = clsCustomer.FindCustomersByFirstNameUsingLike(FirstName);
        }

        private void _FindCustomerByLastName(string LastName)
        {
            dgbShowCustomers.DataSource = clsCustomer.FindCustomersByLastNameUsingLike(LastName);

        }

        private void _FindCustomerByPhone(string Phone)
        {
            dgbShowCustomers.DataSource = clsCustomer.FindCustomersByPhoneUsingLike(Phone);

        }

        private void _Find()
        {
            int ItemSelected = cbTypeSearchCustomer.SelectedIndex;

            switch ((enFindType)ItemSelected)
            {

                case enFindType.FindByFirstName:
                    _FindCustomerByFirstName(txtCustomerSearch.Text);
                    break;

                case enFindType.FindByLastName:
                    _FindCustomerByLastName(txtCustomerSearch.Text);
                    break;

                case enFindType.FindByPhone:
                    _FindCustomerByPhone(txtCustomerSearch.Text);
                    break;
            }
        }

        private void _ShowAllCustomers()
        {
            DataTable dt = clsCustomer.GetAllCustomers();
            if(dt != null)
            {
                dgbShowCustomers.DataSource = dt;
            }
        }

        private void _Loadding()
        {
            _ShowAllCustomers();
            _FillComboBoxTypeSearch();
        }

        private void frmShowsCustomer_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustomerSearch.Text))
            {
                _Find();
            }
            else
            {
                dgbShowCustomers.DataSource = clsCustomer.GetAllCustomers();
                txtCustomerSearch.Focus();
            }
        }

        private void dgbShowCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dgbShowCustomers.CurrentRow.Cells[0].Value;
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTypeSearchCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            txtCustomerSearch.Focus();
        }

    }
}
