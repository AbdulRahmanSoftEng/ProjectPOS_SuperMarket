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

namespace System_C_Sharp_SuperMarket_DB_MISS.Products
{
    public partial class frmShowAllProducts : frmSharedLayoutTop
    {
        frmAddEditProducts AddEditProduct;
        private void _UpdateProduct(string Barcode)
        {
            AddEditProduct = new frmAddEditProducts(Barcode);
            AddEditProduct.DataUpdated += frmShowAllProducts_Load;
            AddEditProduct.ShowDialog();

        }

        private void _DeleteProduct(string Barcode)
        {
            if (clsProduct.IsProductExistByBarcode(Barcode))
            {
                var Result = MessageBox.Show("هل تريد حذف الصنف", "حذف صنف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if(Result == DialogResult.OK)
                {
                    clsProduct.DeleteProductByBarcode(Barcode);
                    MessageBox.Show("تم الحذف بنجاح");
                    _ShowAllProduct();
                }
            }
            else
            {
                MessageBox.Show("هذا الصنف لايوجد");
            }
        }

        public void ShowCountItems()
        {
            lblCountProducts.Text = clsProduct.GetCountProducts().ToString();
        }

        private void _AddNewProduct()
        {
            AddEditProduct = new frmAddEditProducts("");
            AddEditProduct.DataUpdated += frmShowAllProducts_Load;
            AddEditProduct.ShowDialog();
        }
        private void _ShowAllProduct()
        {
            if(clsProduct.GetAllProducts() != null)
                dgvShowProducts.DataSource = clsProduct.GetAllProducts();
        }

        private void _LoadingForm()
        {
            _ShowAllProduct();
            ShowCountItems();
        }

        /// <summary>
        /// Abfe is funcation that using CRUD
        /// </summary>
        /// 
        public frmShowAllProducts(string Title = "...")
           :base(Title)
        {
            InitializeComponent();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            _AddNewProduct();
        }

        private void frmShowAllProducts_Load(object sender, EventArgs e)
        {
            _LoadingForm();
        }

        public void Delete()
        {
            if (dgvShowProducts.SelectedCells.Count > 0)
                _DeleteProduct((string)dgvShowProducts.CurrentRow.Cells[1].Value);
            else
            {
                frmMessage Message = new frmMessage("يرجا تحديد الصنف المراد حذفة", enTypeIcon.Success, 2);
                Message.ShowDialog();
            }
        }

        public void Update()
        {
            if (dgvShowProducts.SelectedCells.Count > 0)
                _UpdateProduct((string)dgvShowProducts.CurrentRow.Cells[1].Value);
            else
            {
                frmMessage Message = new frmMessage("يرجا تحديد الصنف المراد تعديلة", enTypeIcon.Success, 2);
                Message.ShowDialog();
            }
        }

        public void Search()
        {
            if (!string.IsNullOrEmpty(txtProductSearch.Text))
            {
                dgvShowProducts.DataSource = clsProduct.GetAllProductUsingLikeByNameOrBarcode(txtProductSearch.Text.Trim());
            }
            else
            {
                _ShowAllProduct();
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

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnAddNewQty_Click(object sender, EventArgs e)
        {
            frmAddNewQty addNewQty = new frmAddNewQty();
            addNewQty.ShowDialog();
        }

        private void tsmiAddNewQty_Click(object sender, EventArgs e)
        {
            frmAddNewQty addNewQty = new frmAddNewQty();
            addNewQty.ShowDialog();
        }
    }
}
