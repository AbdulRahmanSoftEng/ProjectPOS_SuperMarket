using Business;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System_C_Sharp_SuperMarket_DB_MISS.Invoices;

namespace System_C_Sharp_SuperMarket_DB_MISS.Products
{
    public partial class frmAddNewQty : Form
    {
        public string [] MethodeSearch = { "بحث باستخدام الباركود", "بحث باستخدام اسم الصنف", "بحث باستخدام القسم", "بحث باستخدام رقم الصنف" };

        public DataTable tbBarcodes;
        public DataColumn BarcodeProperties;

        public frmAddNewQty()
        {
            
            InitializeComponent();
            
        }

        public void Refresh()
        {
            tbBarcodes.AcceptChanges();
            ShowAllBarcodeGenrate();
        }

        public void ShowAllBarcodeGenrate()
        {
            dgvShowBarcodeGenrater.DataSource = tbBarcodes;

            dgvShowBarcodeGenrater.Columns[0].Visible = false;
            dgvShowBarcodeGenrater.Columns[1].Width = 200;
            dgvShowBarcodeGenrater.Columns[2].Visible = false;
            dgvShowBarcodeGenrater.Columns[3].Width = 40;
        }

        public void AddNewBarcode(string ProductName, string Barcode, int Qty)
        {
            tbBarcodes.Rows.Add(null, ProductName, Barcode, Qty);
        }

        public void CreateTableContentBarcode()
        {
            tbBarcodes = new DataTable("Barcodes");
            BarcodeProperties = new DataColumn();

            BarcodeProperties.ColumnName = "ID";
            BarcodeProperties.DataType = typeof(int);
            BarcodeProperties.AutoIncrement = true;
            BarcodeProperties.AutoIncrementSeed = 1;
            BarcodeProperties.AutoIncrementStep = 1;

            tbBarcodes.Columns.Add(BarcodeProperties);

            DataColumn[] PrimaryKeyID = new DataColumn[1];
            PrimaryKeyID[0] = tbBarcodes.Columns["ID"];
            tbBarcodes.PrimaryKey = PrimaryKeyID;

            BarcodeProperties = new DataColumn();
            BarcodeProperties.ColumnName = "الاسم";
            BarcodeProperties.DataType = typeof(string);

            tbBarcodes.Columns.Add(BarcodeProperties);

            BarcodeProperties = new DataColumn();
            BarcodeProperties.ColumnName = "الباركود";
            BarcodeProperties.DataType = typeof(string);

            tbBarcodes.Columns.Add(BarcodeProperties);

            BarcodeProperties = new DataColumn();
            BarcodeProperties.ColumnName = "العدد";
            BarcodeProperties.DataType = typeof(int);

            tbBarcodes.Columns.Add(BarcodeProperties);
        }

        private void _PluseQty(int ID)
        {
            DataRow[] ProductDataRow = tbBarcodes.Select("ID = " + ID);

            foreach (var row in ProductDataRow)
            {
                int Q;
                Q = Convert.ToInt32(row[3]);
                Q++;
                row[3] = Q;
            }
        }

        private void _MinusQty(int ID)
        {
            DataRow[] ProductDataRow = tbBarcodes.Select("ID = " + ID);

            foreach (var row in ProductDataRow)
            {
                int Q;
                Q = Convert.ToInt32(row[3]);
                if (Q > 1)
                {
                    Q--;
                    row[3] = Q;

                }
                else
                {
                    // row.Delete();
                }
            }
        }

        private void _UpdateQty(int ID, int NewQty)
        {
            DataRow[] ProductDataRow = tbBarcodes.Select("ID = " + ID);

            foreach (var row in ProductDataRow)
            {
                int Q;
                Q = Convert.ToInt32(row[3]);
                Q = NewQty;
                row[3] = Q;
            }
        }

        private void _DeleteItem(int ID)
        {
            DataRow[] ProductDataRow = tbBarcodes.Select("ID = " + ID);

            foreach (var row in ProductDataRow)
            {
                row.Delete();
            }
        }

        public void _ClearTableBarcodes()
        {
            tbBarcodes.Clear();
        }

        public void _Loadding()
        {
            cbMethodSearchProduct.Items.AddRange(MethodeSearch);
            cbMethodSearchProduct.SelectedIndex = 1;

            ShowAllProducts();
            CreateTableContentBarcode();

        }

        public void ClearAllFiald()
        {
            txtNewQtyItem.Clear();
            txtNameItem.Clear();
            txtPriceItem.Clear();
            txtQtyItem.Clear();
            txtSearchProducts.Clear();
        }

        public void AddBarcode()
        {
            int Qty = !string.IsNullOrEmpty(txtNewQtyItem.Text)? Convert.ToInt32(txtNewQtyItem.Text): 0;

            string Barcode = clsProduct.GetBarcodeByName(txtNameItem.Text.ToString());
            AddNewBarcode(txtNameItem.Text, Barcode, Qty);
            Refresh();
        }

        public void _AddNewQty()
        {
            int NewQty = Convert.ToInt32(txtNewQtyItem.Text);

            if (!string.IsNullOrEmpty(txtNameItem.Text) && dgvShowProducts.CurrentCell != null && !string.IsNullOrEmpty(txtNameItem.Text))
            {
                if (clsProduct.UpdateNewQtyItemByName(txtNameItem.Text, NewQty))
                {
                    AddBarcode();
                    frmMessage Message = new frmMessage("تم الاضافة بنجاح", enTypeIcon.Success, 2);
                    Message.ShowDialog();
                    ShowAllProducts();
                    ClearAllFiald();
                }
                else
                {
                    frmMessage Message = new frmMessage("لم يتم الاضافة هنالك خطا ما", enTypeIcon.Error, 2);
                    Message.ShowDialog();
                }
            }  
        }

        private void FindByBarcode()
        {
            clsProduct Product = clsProduct.FindProductByBarcode(txtSearchProducts.Text);

            if(Product != null)
            {
                txtNameItem.Text = Product.Name;
                txtPriceItem.Text = Product.Price.ToString();
                txtQtyItem.Text = Product.Quantity.ToString();
            }
        }

        private void FindByName()
        {
            dgvShowProducts.DataSource = clsProduct.FindProductsByNameUsingLike(txtSearchProducts.Text);
        }

        private void FindByCategory()
        {
            
            dgvShowProducts.DataSource = clsProduct.GetAllProductsByCategoryNameUsingLike(txtSearchProducts.Text);
        }

        private void FindByID()
        {
            try
            {
                int ID = Convert.ToInt32(txtSearchProducts.Text);

                clsProduct Product = clsProduct.FindProductById3Columns(ID);

                if (Product != null)
                {
                    txtNameItem.Text = Product.Name;
                    txtPriceItem.Text = Product.Price.ToString();
                    txtQtyItem.Text = Product.Quantity.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
            }
            
        }

        public void PluseQty()
        {
            float Qty = 0;

            if (!string.IsNullOrEmpty(txtNewQtyItem.Text))
            {
                Qty = Convert.ToSingle(txtNewQtyItem.Text);

                Qty++;

                txtNewQtyItem.Text = Qty.ToString();
            }
            else
            {
                txtNewQtyItem.Text = 1.ToString();
            }
        }
        
        public void MinuseQty()
        {

            float Qty = 0;
            if (!string.IsNullOrEmpty(txtNewQtyItem.Text))
            {
                if (Convert.ToSingle(txtNewQtyItem.Text) > 0)
                {
                    Qty = Convert.ToSingle(txtNewQtyItem.Text);

                    Qty--;

                    txtNewQtyItem.Text = Qty.ToString();
                }

            }
            txtNewQtyItem.Text = Qty.ToString();
        }

        public void EditQty(int NewQty)
        {
            try
            {
                if (NewQty <= 0)
                {
                    frmMessage Message = new frmMessage("الكمية المدخلة خاطة", enTypeIcon.Warring, 2);
                    Message.ShowDialog();
                    return;
                }

                int ID = Convert.ToInt32(dgvShowBarcodeGenrater.CurrentRow.Cells[0].Value);

                _UpdateQty(ID, NewQty);
                Refresh();

               

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }

        public void ShowAllProducts()
        {
            dgvShowProducts.DataSource = clsProduct.GetAllProducts3Column();
        } 
        
        public void SetDataToFiald()
        {
            txtNameItem.Text = dgvShowProducts.CurrentRow.Cells[0].Value.ToString();
            txtPriceItem.Text = dgvShowProducts.CurrentRow.Cells[1].Value.ToString();
            txtQtyItem.Text = dgvShowProducts.CurrentRow.Cells[2].Value.ToString();
        }

        private void frmAddNewQty_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void dgvShowProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetDataToFiald();
        }

        private void txtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchProducts.Text))
            {
                switch (cbMethodSearchProduct.SelectedIndex)
                {
                    case 0:
                        FindByBarcode();
                        break;

                    case 1:
                        FindByName();
                        break;

                    case 2:
                        FindByCategory();
                        break;

                    case 3:
                        FindByID();
                        break;
                }
               
            }
            else
            {
                ShowAllProducts();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNameItem.Text))
            {
                if (!string.IsNullOrEmpty(txtNewQtyItem.Text))
                {
                    _AddNewQty();
                }
                else
                {
                    frmMessage Message = new frmMessage("قم بادخال الكمية الجديدة", enTypeIcon.Warring, 2);
                    Message.ShowDialog();
                }
            }
            else
            {

                frmMessage Message = new frmMessage("قم باختيار الصنف المراد زيادة الكمية", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
        }

        private void btnPluseQty_Click(object sender, EventArgs e)
        {
            PluseQty();
        }

        private void btnMinusQty_Click(object sender, EventArgs e)
        {
            MinuseQty();
        }

        public void Answer()
        {
            if (dgvShowBarcodeGenrater.Rows.Count > 0)
            {
                var Result = MessageBox.Show("هل تريد طباعة جميع الباركود الموجوده في الجدول ومتابعة الاغلاق", "طباعة الباركود", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Result == DialogResult.OK)
                {

                    PrintAllBarcodes();
                }
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Answer();
        }
        public void PrintBarcode(clsProductBarcode ProductBarcode)
        {
            for (int i = 0; i < ProductBarcode.PrintQty; i++)
            {
                rptCreateBarcodeInvoice.PrintInvoices(ProductBarcode);
            }
        }

        public void PrintAllBarcodes()
        {
            foreach (DataRow row in tbBarcodes.Rows)
            {
                string Name = row["الاسم"].ToString();
                string Barcode = row["الباركود"].ToString();
                int PrintQty = Convert.ToInt32(row["العدد"]);

                clsProductBarcode productBarcode = new clsProductBarcode(Name, Barcode, PrintQty);

                PrintBarcode(productBarcode);
            }
            _ClearTableBarcodes();
        }

        private void btnPrintAllBarcodes_Click(object sender, EventArgs e)
        {
            if (dgvShowBarcodeGenrater.Rows.Count > 0)
            {
                PrintAllBarcodes();
            }
        }

        private void btnPluseQtyBarcode_Click(object sender, EventArgs e)
        {

            if (dgvShowBarcodeGenrater.Rows.Count > 0 && dgvShowBarcodeGenrater.CurrentCell != null)
            {
                int ID = Convert.ToInt32(dgvShowBarcodeGenrater.CurrentRow.Cells[0].Value);

                _PluseQty(ID);
                Refresh();
            }
        }

        private void btnMinuseQtyBarcode_Click(object sender, EventArgs e)
        {

            if (dgvShowBarcodeGenrater.Rows.Count > 0 && dgvShowBarcodeGenrater.CurrentCell != null)
            {
                int ItemID = Convert.ToInt32(dgvShowBarcodeGenrater.CurrentRow.Cells[0].Value);
                _MinusQty(ItemID);
                Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvShowBarcodeGenrater.Rows.Count > 0 && dgvShowBarcodeGenrater.CurrentCell != null)
            {
                int ItemID = Convert.ToInt32(dgvShowBarcodeGenrater.CurrentRow.Cells[0].Value);
                _DeleteItem(ItemID);
                Refresh();
            }
        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            _ClearTableBarcodes();
        }

        private void dgvShowBarcodeGenrater_DoubleClick(object sender, EventArgs e)
        {

            if (dgvShowBarcodeGenrater.SelectedCells.Count > 0)
            {
                frmEditQty Qty = new frmEditQty();
                Qty.ShowDialog();

                EditQty(Qty.NewQty);
            }
        }

        private void dgvShowBarcodeGenrater_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvShowProducts_DoubleClick(object sender, EventArgs e)
        {
            AddBarcode();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
