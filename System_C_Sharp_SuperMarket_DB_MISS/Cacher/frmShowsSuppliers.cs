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
    public partial class frmShowsSuppliers : Form
    {
        public enum enTypeSearch { FindByFirstName = 0, FindByLastName = 1, FindByPhone = 2 };

        public string[] arrTypeSearch = { "بحث بستخدام الاسم الاول", "بحث بستخدام الاسم الخير", "بحث بستخدام رقم الهاتف" };

        public static int SupplierID = -1;

        public frmShowsSuppliers()
        {
            InitializeComponent();
        }

        private void _FillComboBoxTypeSearch()
        {

            cbTypeSearchSuppliers.Items.AddRange(arrTypeSearch);

            cbTypeSearchSuppliers.SelectedIndex = 0;
        }

        private void _FindSuppliers(string Text, string TypeSearch)
        {
            dgbShowSuppliers.DataSource = clsSupplier.FindSuppliersUsingLike(txtSuppliersSearch.Text, TypeSearch);
        }

        private void _Find()
        {
            int ItemSelected = cbTypeSearchSuppliers.SelectedIndex;

            switch ((enTypeSearch)ItemSelected)
            {

                case enTypeSearch.FindByFirstName:
                    _FindSuppliers(txtSuppliersSearch.Text, "FirstName");
                    break;

                case enTypeSearch.FindByLastName:
                    _FindSuppliers(txtSuppliersSearch.Text, "LastName");
                    break;

                case enTypeSearch.FindByPhone:
                    _FindSuppliers(txtSuppliersSearch.Text, "Phone");
                    break;
            }
        }

        private void _ShowAllSuppliers()
        {
            if (clsSupplier.GetAllSuppliers() != null)
            {
                dgbShowSuppliers.DataSource = clsSupplier.GetAllSuppliers();
            }
        }

        private void _Loadding()
        {
            _ShowAllSuppliers();
            _FillComboBoxTypeSearch();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSuppliersSearch_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtSuppliersSearch.Text))
            {
                _Find();
            }
            else
            {
                dgbShowSuppliers.DataSource = clsSupplier.GetAllSuppliers();
                txtSuppliersSearch.Focus();
            }
        }

        private void cbTypeSearchSuppliers_SelectedValueChanged(object sender, EventArgs e)
        {
            txtSuppliersSearch.Focus();
        }

        private void dgbShowSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SupplierID = (int)dgbShowSuppliers.CurrentRow.Cells[0].Value;
            this.Close();
        }

        private void frmShowSuppliers_Load(object sender, EventArgs e)
        {
            _Loadding();
        }
    }
}
