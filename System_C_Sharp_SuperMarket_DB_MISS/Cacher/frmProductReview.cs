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
    public partial class frmProductReview : Form
    {
        public frmProductReview()
        {
            InitializeComponent();
        }

        private void _ShowDetailsProducts(clsProduct Product)
        {
            txtBarcode.Text = Product.Barcode;
            txtName.Text = Product.Name;
            txtPrice.Text = Product.Price.ToString();
            txtQty.Text = Product.Quantity.ToString();
            txtCategory.Text = clsCategory.GetCategoryNameByID(Product.Category);

            if(Product.Image != "")
                pbImage.ImageLocation = @Product.Image;
        }

        private void _ClearAllFiald()
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtCategory.Clear();
            pbImage.ImageLocation = "";
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtBarcode.Text))
                {
                    if (clsProduct.IsProductExistByBarcode(txtBarcode.Text.Trim()))
                    {
                        clsProduct Product = clsProduct.FindProductByBarcode(txtBarcode.Text.Trim());
                        _ShowDetailsProducts(Product);
                        timer1.Start();
                    }
                }
            }
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        short Counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Counter++;
            if (Counter == Convert.ToInt32(txtTimeClearFaild.Text))
            {
                _ClearAllFiald();
                timer1.Stop();
                Counter = 0;
            }
        }

        private void _Loadding()
        {
            txtTimeClearFaild.Text = clsSetting.GetTimeClearFiald().ToString(); // هذة القيمة يمكن ان يتم استدعاها من قاعدة البيانات
        }

        private void frmProductReview_Load(object sender, EventArgs e)
        {
            _Loadding();
        }
    }
}
