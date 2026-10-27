using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_C_Sharp_SuperMarket_DB_MISS.Suppliers;

namespace System_C_Sharp_SuperMarket_DB_MISS.Suppliers
{
    public partial class frmShowAllSuppliers : frmSharedLayoutTop
    {
        frmAddEditSuppliers AddEditSupplier;

        private void _AddNewSupplier()
        {
            AddEditSupplier = new frmAddEditSuppliers(-1);
            AddEditSupplier.DataUpdated += frmShowAllSuppliers_Load;
            AddEditSupplier.ShowDialog();
        }

        private void _ShowAllSuppliers()
        {
            if (clsSupplier.GetAllSuppliers() != null)
                dgvShowSuppliers.DataSource = clsSupplier.GetAllSuppliers();
        }

        private void _EditRowSupplier(int ID)
        {
            AddEditSupplier = new frmAddEditSuppliers(ID);
            AddEditSupplier.DataUpdated += frmShowAllSuppliers_Load;
            AddEditSupplier.ShowDialog();
        }

        private void _DeleteRowSupplier(int ID)
        {
            if (clsSupplier.SupplierIsExistByID(ID))
            {
                var Result = MessageBox.Show("هل تريد حذف المورد ", "حذف مورد", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Result == DialogResult.OK)
                {
                    clsSupplier.DeleteSupplierByID(ID);
                    frmMessage Message = new frmMessage("تم حذف المورد بنجاح", enTypeIcon.Success, 2);
                    Message.ShowDialog();
                    _ShowAllSuppliers();
                }
                else
                {
                    frmMessage Message = new frmMessage("لم يتم حذف المورد", enTypeIcon.Error, 2);
                    Message.ShowDialog();
                }
            }
            else
            {
                frmMessage Message = new frmMessage("لم يتم حذف العثور على المورد", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }

        }

        private void _SearchSuppliersUsingLike(string txt)
        {
            // find suppliers using firstName by default
            dgvShowSuppliers.DataSource = clsSupplier.FindSuppliersUsingLike(txt, "FirstName");
        }

        public void ShowCountSuppliers()
        {
            lblCountSuppliers.Text = clsSupplier.GetCountSuppliers().ToString();
        }

        private void _Loading()
        {
            _ShowAllSuppliers();
            ShowCountSuppliers();
        }

        public frmShowAllSuppliers(string Title = "...")
            :base(Title)
        {

            InitializeComponent();
        }

        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            _AddNewSupplier();
        }

        private void frmShowAllSuppliers_Load(object sender, EventArgs e)
        {
            _Loading();
        }

        public void Delete()
        {
            if (dgvShowSuppliers.SelectedCells.Count > 0)
                _DeleteRowSupplier((int)dgvShowSuppliers.CurrentRow.Cells[0].Value);
            else
            {
                frmMessage Message = new frmMessage("قم بتحديد المورد المراد حذف بياناته", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
        }

        public void Update()
        {
            if (dgvShowSuppliers.SelectedCells.Count > 0)
                _EditRowSupplier((int)dgvShowSuppliers.CurrentRow.Cells[0].Value);
            else
            {
                frmMessage Message = new frmMessage("قم بتحديد المورد المراد تعديل بياناته", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
        }

        public void Search()
        {
            if (!string.IsNullOrEmpty(txtSearchSuppliers.Text.Trim()))
                _SearchSuppliersUsingLike(txtSearchSuppliers.Text.Trim());
            else
                _ShowAllSuppliers();
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

        private void txtSearchSuppliers_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnSupplierSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

    }
}
