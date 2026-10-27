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
using ZXing;
using System_C_Sharp_SuperMarket_DB_MISS.Categories;
using Microsoft.SqlServer.Server;
using DevExpress.XtraReports.UserDesigner;
using System_C_Sharp_SuperMarket_DB_MISS.Invoices;

namespace System_C_Sharp_SuperMarket_DB_MISS.Products
{
    public partial class frmAddEditProducts : Form
    {
        public DataTable tbBarcodes;
        public DataColumn BarcodeProperties;
        public enum enMode { AddNew, UpdateInfo};
        public enMode Mode;

        public clsProduct Product;

        public event EventHandler DataUpdated;
        public string ProductBarcode = "";

         
        public void Refresh()
        {
            tbBarcodes.AcceptChanges();
            ShowAllBarcodeGenrate();
            btnAutoBarcode.Tag = "";
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

        public void NotifyDataTable()
        {
            if (DataUpdated != null)
                DataUpdated(this, EventArgs.Empty);
        }

        private void _BrowserImage()
        {

            openFileDialog1.Title = "اختيار صورة";
            openFileDialog1.Filter = "أنواع الصور|*.png;*.jpg;*.jpeg;*.gif;*.bmp;*.tiff;*.ico;*.jfif;*.webp;";
            openFileDialog1.DefaultExt = @"C:\";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = openFileDialog1.FileName;
                btnRemoveImage.Visible = true;
            }
        }

        private void _FillCategoryToComboBox()
        {
            DataTable dt = clsCategory.GetAllCategories();
             
            if(dt != null){

                foreach(DataRow row in dt.Rows)
                {
                    if (!cbCategory.Items.Contains(row["الاسم"].ToString()))
                    {
                        cbCategory.Items.Add(row["الاسم"].ToString());
                    }
                   
                }
            }
        }

        private void _ReadDataFromFields(ref clsProduct Product)
        {
            try
            {
                // التحقق من صحة الإدخالات قبل التحويل
                if (int.TryParse(txtProductID.Text, out int productId))
                {
                    Product.Id = productId;
                }
                
                Product.Barcode = txtBarcode.Text.Trim();
                Product.Name = txtName.Text.Trim();

                if (decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    Product.Price = (float)price;
                }
                else
                {
                    throw new Exception("السعر المدخل غير صالح.");
                }

                if (int.TryParse(txtQty.Text, out int qty))
                {
                    Product.Quantity = qty;
                }
                else
                {
                    throw new Exception("الكمية المدخلة غير صالحة.");
                }

                if (!string.IsNullOrEmpty(cbCategory.Text))
                {
                    int category = clsCategory.GetCategoryIDByName(cbCategory.Text.Trim());
                    Product.Category = category;

                }
                else
                {
                    Product.Category = -1;
                }

                if (!string.IsNullOrEmpty(txtDescription.Text))
                {
                    Product.Description = txtDescription.Text.Trim();
                }
                else
                {

                    Product.Description = "";
                }

                // التحقق من صورة المنتج
                if (!string.IsNullOrEmpty(pbImage.ImageLocation))
                {
                    Product.Image = pbImage.ImageLocation.Trim();
                }
                else
                {
                    Product.Image = "";
                }


                Product.IsBarcode = Convert.ToByte(cbIsBarcodeContentProduct.Checked);
            }
            catch (Exception ex)
            {
                // تسجيل الخطأ أو عرضه للمطور/المستخدم
                MessageBox.Show($"خطأ أثناء قراءة البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void _SetDataToFalids()
        {
            Product = clsProduct.FindProductByBarcode(ProductBarcode);
            try
            {
                if (Product != null)
                {
                    txtProductID.Text = Product.Id.ToString();
                    txtBarcode.Text = Product.Barcode;
                    txtName.Text = Product.Name;
                    txtPrice.Text = Product.Price.ToString();
                    txtQty.Text = Product.Quantity.ToString();
                    cbCategory.SelectedIndex = cbCategory.FindString(clsCategory.GetCategoryNameByID(Product.Category));
                    txtDescription.Text = Product.Description;
                    pbImage.ImageLocation = Product.Image;

                    lblTitle.Text = "تعديل بيانات صنف";

                    if (Product.IsBarcode == 1)
                        cbIsBarcodeContentProduct.Checked = true;
                    else
                        cbIsBarcodeContentProduct.Checked = false ;
                }
                else
                {
                    frmMessage Message = new frmMessage("لم يتم العثور على الصنف", enTypeIcon.Warring, 2);
                    Message.ShowDialog();
                }
            }
            catch(Exception ex) { }
            
        }

        private void _AddNew()
        {
            Product = new clsProduct();

            _ReadDataFromFields(ref Product);

            if (!clsProduct.IsProductExistByBarcodeAndName(txtBarcode.Text, txtName.Text))
            {

                if (Product.Save())
                {
                    if(btnAutoBarcode.Tag.ToString() == txtBarcode.Text.ToString())
                    {
                        int Qty = Convert.ToInt32(txtQty.Text);

                        AddNewBarcode(txtName.Text, txtBarcode.Text, Qty);
                        Refresh();
                    }

                    frmMessage Message = new frmMessage("تم الاضافة بنجاح", enTypeIcon.Success, 2);
                    Message.ShowDialog();
                    NotifyDataTable();
                    _ClearAllFiald();
                    txtBarcode.Focus();
                }
                else
                {
                    frmMessage Message = new frmMessage("لم يتم الاضافة", enTypeIcon.Error, 2);
                    Message.ShowDialog();
                }
            }
            else
            {
                frmMessage Message = new frmMessage("هذا الصنف موجود بالفعل", enTypeIcon.Warring, 3);
                Message.ShowDialog();
            }

        }

        private void _UpdateInfo()
        {
            Product = clsProduct.FindProductByBarcode(ProductBarcode);

            _ReadDataFromFields(ref Product);

            if (Product.Save())
            {
                frmMessage Message = new frmMessage("تم التعديل بنجاح", enTypeIcon.Success, 2);
                Message.ShowDialog();
             
                NotifyDataTable();
                _ClearAllFiald();
                txtBarcode.Focus();
            }
            else
            {
                frmMessage Message = new frmMessage("لم يتم التعديل", enTypeIcon.Error, 2);
                Message.ShowDialog();
            }
        }


        private void Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    _AddNew();
                    break;

                case enMode.UpdateInfo:
                    _UpdateInfo();
                    break;
            }
        }

        private string _GenerateBarcodeText()
        {
            Random random = new Random();

            int LengthBarcode = 13;
            string Barcode = "";

            for(short i = 0;i<LengthBarcode; i++)
            {
                Barcode += random.Next(0, 10).ToString();
            }

            return Barcode;
        }

        private void _ClearAllFiald()
        {
            int ID = clsProduct.GetLastIDProduct();
            txtProductID.Text = ID != -1? ID.ToString(): "لايوجد اي منتج";
            txtBarcode.Clear();
            txtName.Clear();
            txtQty.Clear();
            txtPrice.Clear();
            cbCategory.Text = "";
            txtDescription.Clear();
            cbIsBarcodeContentProduct.Checked = false;
            btnRemoveImage.Enabled = false;
            pbImage.ImageLocation = "";
            cbIsBarcodeContentProduct.Checked = false;
            
        }

        public frmAddEditProducts(string ProductBarcode)
        {
            
            InitializeComponent();
            this.ProductBarcode = ProductBarcode;

            if (ProductBarcode != "")
                Mode = enMode.UpdateInfo;
            else
                Mode = enMode.AddNew;
        }

        public void _Loadding()
        {
            txtBarcode.Focus();

            _FillCategoryToComboBox();
            if (ProductBarcode != "")
            {
                _SetDataToFalids();
            }
            else
            {
                lblTitle.Text = "اضافة صنف جديد";
            }

            CreateTableContentBarcode();    
        }
       
        private void frmAddEditProducts_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void _SetFoucsWithFialdEmpty()
        {
            if (string.IsNullOrEmpty(txtBarcode.Text))
            {
                txtBarcode.Focus();
            }

            else if (string.IsNullOrEmpty(txtName.Text)){
                txtName.Focus();
            }

            else if (string.IsNullOrEmpty(txtPrice.Text))
            {
                txtPrice.Focus();
            }

            else if (string.IsNullOrEmpty(txtQty.Text))
            {
                txtQty.Focus();
            }

            else if (string.IsNullOrEmpty(cbCategory.Text))
            {
                cbCategory.Focus();
            }

            else if (string.IsNullOrEmpty(pbImage.ImageLocation))
            {
                btnAddImage.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbIsBarcodeContentProduct.Checked)
            {
                if(!string.IsNullOrEmpty(txtBarcode.Text) && !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtQty.Text) && !string.IsNullOrEmpty(cbCategory.Text) && !string.IsNullOrEmpty(pbImage.ImageLocation))
                {
                    Save();
                }
                else
                {
                    _SetFoucsWithFialdEmpty();
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtBarcode.Text) && !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtQty.Text) && !string.IsNullOrEmpty(cbCategory.Text))
                {
                    Save();
                }
                else
                {
                    _SetFoucsWithFialdEmpty();
                }
            }
         }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            _BrowserImage();
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbImage.ImageLocation = "";
            btnRemoveImage.Visible = false;
        }

        private void btnGoToCategoryForm_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.CategoryChanged += frmAddEditProducts_Load;
            addCategory.ShowDialog();
        }

        private void btnAutoBarcode_Click(object sender, EventArgs e)
        {
            txtBarcode.Text = _GenerateBarcodeText();
            cbIsBarcodeContentProduct.Checked = true;
            btnAutoBarcode.Tag = txtBarcode.Text.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _ClearAllFiald();
            
        }

        private void _CheckFialdInputUser(TextBox txt, CancelEventArgs e, string NameFiald)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                txt.Focus();
                //txt.BackColor = Color.FromArgb(255, 128, 128);
                errorProvider1.SetError(txt, "الرجاء قم بادخال " + NameFiald);
            }
            else
            {
                errorProvider1.Clear();
                e.Cancel = false;
                txt.BackColor = Color.White;

            }
        }

        private void txtFiald_Validating(object sender, CancelEventArgs e)
        {
            //_CheckFialdInputUser((TextBox)sender, e, ((TextBox)(sender)).Tag.ToString());
        }

        private void cbCategory_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(cbCategory.Text))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(cbCategory, "الرجاء قم باختيار "+cbCategory.Tag.ToString());
            //}
        }

        private void pbImage_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(pbImage.ImageLocation) && cbIsBarcodeContentProduct.Checked)
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(pbImage, "الرجاء قم باختيار " + pbImage.Tag.ToString());
            //}
        } 

        private void pbImage_Click(object sender, EventArgs e)
        {
            _BrowserImage();
           
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
            foreach(DataRow row in tbBarcodes.Rows)
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
            if(dgvShowBarcodeGenrater.Rows.Count > 0)
            {
                PrintAllBarcodes();
            }
        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            _ClearTableBarcodes();
        }

        private void btnPluseQty_Click(object sender, EventArgs e)
        {
            if (dgvShowBarcodeGenrater.Rows.Count > 0 && dgvShowBarcodeGenrater.CurrentCell != null)
            {
                int ID = Convert.ToInt32(dgvShowBarcodeGenrater.CurrentRow.Cells[0].Value);

                _PluseQty(ID);
                Refresh();
            }
        }

        private void btnMinusQty_Click(object sender, EventArgs e)
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

        private void dgvShowBarcodeGenrater_DoubleClick(object sender, EventArgs e)
        {
            if (dgvShowBarcodeGenrater.SelectedCells.Count > 0)
            {
                frmEditQty Qty = new frmEditQty();
                Qty.ShowDialog();

                EditQty(Qty.NewQty);
            }
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

        private void btnClose2_Click(object sender, EventArgs e)
        {
            Answer();

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Answer();
        }
    }
}
