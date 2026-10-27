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
using System_C_Sharp_SuperMarket_DB_MISS.Suppliers;

namespace System_C_Sharp_SuperMarket_DB_MISS.Customers
{
    public partial class frmShowAllCustomers : frmSharedLayoutTop
    {
        frmAddEditCustomers AddEditCustomer;

        private void _AddNewCustomer()
        {
            AddEditCustomer = new frmAddEditCustomers(-1);
            AddEditCustomer.DataUpdated += frmShowAllCustomers_Load;
            AddEditCustomer.ShowDialog();
        }

        private void _ShowAllCustomers()
        {
            if (clsCustomer.GetAllCustomers() != null)
                dgbShowCustomers.DataSource = clsCustomer.GetAllCustomers();
        }

        private void _EditRowCustomer(int ID)
        {
            AddEditCustomer = new frmAddEditCustomers(ID);
            AddEditCustomer.DataUpdated += frmShowAllCustomers_Load;
            AddEditCustomer.ShowDialog();
        }

        private void _DeleteRowCustomer(int ID)
        {
            if (clsCustomer.CustomerIsExistByID(ID))
            {
                var Result = MessageBox.Show("هل تريد حذف العميل ", "حذف مورد", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Result == DialogResult.OK)
                {
                    clsCustomer.DeleteCustomerByID(ID);
                    frmMessage Message = new frmMessage("تم حذف العميل بنجاح", enTypeIcon.Success, 2);
                    Message.ShowDialog();
                    AddEditCustomer.NotifyDataUpdated();
                }
            }
            else
            {
                frmMessage Message = new frmMessage("لم يتم حذف العميل", enTypeIcon.Success, 2);
                Message.ShowDialog();
            }

        }

        private void _SearchCustomersUsingLike(string FirstName)
        {
            dgbShowCustomers.DataSource = clsCustomer.FindCustomersByFirstNameUsingLike(FirstName);
        }

        public void ShowCountCustomers()
        {
            lblCountCustomers.Text = clsCustomer.GetCountCustomers().ToString();
        }

        private void _Loading()
        {
            _ShowAllCustomers();
            ShowCountCustomers();
        }

        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            _AddNewCustomer();
        }

        private void frmShowAllCustomers_Load(object sender, EventArgs e)
        {
            _Loading();
        }

        public void Delete()
        {

            if (dgbShowCustomers.SelectedCells.Count > 0)
                _DeleteRowCustomer((int)dgbShowCustomers.CurrentRow.Cells[0].Value);
            else
            {
                frmMessage Message = new frmMessage("قم بتحديد العميل المراد حذفه  بياناته", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
        }

        public void Update()
        {
            if (dgbShowCustomers.SelectedCells.Count > 0)
                _EditRowCustomer((int)dgbShowCustomers.CurrentRow.Cells[0].Value);
            else
            {
                frmMessage Message = new frmMessage("قم بتحديد العميل المراد تعديل بياناته", enTypeIcon.Success, 2);
                Message.ShowDialog();
            }
        }

        public void Search()
        {
            if (!string.IsNullOrEmpty(txtCustomerSearch.Text.Trim()))
                _SearchCustomersUsingLike(txtCustomerSearch.Text.Trim());
            else
                _ShowAllCustomers();
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
      
        public frmShowAllCustomers(string Title = "...")
            :base(Title)
        {
            InitializeComponent();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            _AddNewCustomer();
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

      
    }
}
