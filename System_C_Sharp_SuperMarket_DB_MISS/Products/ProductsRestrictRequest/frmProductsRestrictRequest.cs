using Business;
using DevExpress.Data.TreeList;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_C_Sharp_SuperMarket_DB_MISS.Cacher;
using System_C_Sharp_SuperMarket_DB_MISS.Cacher.Payments;
using System_C_Sharp_SuperMarket_DB_MISS.Invoices;
using System_C_Sharp_SuperMarket_DB_MISS.Shared;

namespace System_C_Sharp_SuperMarket_DB_MISS.Products
{
    public partial class frmProductsRestrictRequest : frmSharedLayoutTop
    {
        public DataTable Products, ItemsShows;
        public DataColumn NewColumn, NewColumn2;
        public int SupplierID = -1;

        public struct stInvoice
        {
            public int InvoiceID;
            public int SupplierID;
            public int UserID;
        }

        stInvoice Invoice;
        public frmProductsRestrictRequest(string Title = "...")
        :base(Title)
        {
            InitializeComponent();
        }

        private void _CreateTable()
        {
            Products = new DataTable();

            NewColumn = new DataColumn();

            NewColumn.DataType = typeof(int);
            NewColumn.ColumnName = "الرقم";
            NewColumn.AutoIncrement = true;
            NewColumn.AutoIncrementSeed = 1;
            NewColumn.AutoIncrementStep = 1;
            Products.Columns.Add(NewColumn);

            DataColumn[] PrimaryKeyID = new DataColumn[1];
            PrimaryKeyID[0] = Products.Columns["الرقم"];
            Products.PrimaryKey = PrimaryKeyID;


            NewColumn = new DataColumn();

            NewColumn.DataType = typeof(string);
            NewColumn.ColumnName = "اسم_الصنف";

            Products.Columns.Add(NewColumn);

            NewColumn = new DataColumn();

            NewColumn.DataType = typeof(float);
            NewColumn.ColumnName = "السعر";

            Products.Columns.Add(NewColumn);

            NewColumn = new DataColumn();

            NewColumn.DataType = typeof(int);
            NewColumn.ColumnName = "الكمية_المتبقية";

            Products.Columns.Add(NewColumn);

            NewColumn = new DataColumn();

            NewColumn.DataType = typeof(bool);
            NewColumn.ColumnName = "اختيار_الصنف";

            Products.Columns.Add(NewColumn);
        }

 
        private void _AddProductToDataTable(string Name, float Price, int Qantity)
        {
            Products.Rows.Add(null, Name, Price, Qantity, false);
        }

        private void _GetAllProductsRestrictRequest()
        {
            
            DataTable dt = clsProduct.GetAllProductsRestrictRequest();
            Products.Clear();
            foreach (DataRow Row in dt.Rows)
            {
                _AddProductToDataTable(Row[0].ToString(), Convert.ToSingle(Row[1]), (int)Row[2]);
            }
        }

        private void _GetAllProducts()
        {
                        
            DataTable dt = clsProduct.GetAllProducts();
            Products.Clear();

            foreach (DataRow Row in dt.Rows)
            {
                _AddProductToDataTable(Row[2].ToString(), Convert.ToSingle(Row[3]), (int)Row[4]);
            }
        }

        public void _ShowAllProducts() { 

            dgvShowProductsRestrictRequest.DataSource = Products;
            dgvShowProductsRestrictRequest.Columns[0].Width = 35;
            dgvShowProductsRestrictRequest.Columns[1].Width = 190;
            dgvShowProductsRestrictRequest.Columns[2].Width = 60;
            dgvShowProductsRestrictRequest.Columns[3].Width = 100;

        }

        public void _Loadding()
        {
            txtInvoiceNumber.Text = clsInvoicePuy.GetLasNumbertInvoicePuy().ToString();
            _CreateTable();
            cbMethodsDisplayProducts.SelectedIndex = 1;
            _GetAllProductsRestrictRequest();
            _CreateTableItemsShows();
            _ShowAllProducts();
        }

        private void _EditAllItems(bool Value)
        {
            DataRow[] Data = Products.Select();

            foreach (DataRow row in Data)
            {
                row[4] = Value;
            }

            Products.AcceptChanges();
            
        }

        private void _EditItem(bool Value, int ItemID)
        {
            DataRow[] Data = Products.Select("الرقم = "+ ItemID);

            foreach (DataRow row in Data)
            {
                row[4] = Value;
            }

            Products.AcceptChanges();
            _ShowAllProducts();
        }

        private void ChackItems(bool value)
        {
            foreach(DataRow row in Products.Rows)
            {
                row[4] = value;
            }
            Products.AcceptChanges();
            _ShowAllProducts();
        }
        private void frmProductsRestrictRequest_Load(object sender, EventArgs e)
        {
            _Loadding();
        }
        
        private void dgvShowProductsRestrictRequest_Click(object sender, EventArgs e)
        {

            if(dgvShowProductsRestrictRequest.SelectedCells.Count > 0)
            {
                if ((bool)dgvShowProductsRestrictRequest.CurrentRow.Cells[4].Value != true)
                {
                    _EditItem(true, (int)dgvShowProductsRestrictRequest.CurrentRow.Cells[0].Value);
                }
                else
                {
                    _EditItem(false, (int)dgvShowProductsRestrictRequest.CurrentRow.Cells[0].Value);
                }
            }
           


            //dgvShowProductsRestrictRequest.Rows.RemoveAt(dgvShowProductsRestrictRequest.CurrentRow.Index);
        }

        private void _SelectAllItems()
        {
            if (cbSelecteItems.Checked)
            {
                _EditAllItems(true);
                cbSelecteItems.Text = "الغاء تحديد الكل";
                AddToTable();
                _ShowAllProducts();
            }
            else
            {
                _EditAllItems(false);
                cbSelecteItems.Text = "تحديد كل الاصناف";
                ItemsShows.Clear();
                _ShowAllProducts();
            }
        }
        private void cbSelecteItems_Click(object sender, EventArgs e)
        {
            _SelectAllItems();
        }

        private void _CreateTableItemsShows()
        {
            ItemsShows = new DataTable();

            NewColumn2 = new DataColumn();

            NewColumn2.DataType = typeof(int);
            NewColumn2.ColumnName = "الرقم";
            
            ItemsShows.Columns.Add(NewColumn2);

            DataColumn[] PrimaryKeyID = new DataColumn[1];
            PrimaryKeyID[0] = ItemsShows.Columns["الرقم"];
            ItemsShows.PrimaryKey = PrimaryKeyID;


            NewColumn2 = new DataColumn();

            NewColumn2.DataType = typeof(string);
            NewColumn2.ColumnName = "اسم_الصنف";

            ItemsShows.Columns.Add(NewColumn2);

            NewColumn2 = new DataColumn();

            NewColumn2.DataType = typeof(float);
            NewColumn2.ColumnName = "الكمية_بالحبة";

            ItemsShows.Columns.Add(NewColumn2);

            NewColumn2 = new DataColumn();

            NewColumn2.DataType = typeof(float);
            NewColumn2.ColumnName = "الكمية_بالدرزن";

            ItemsShows.Columns.Add(NewColumn2);

            NewColumn2 = new DataColumn();

            NewColumn2.DataType = typeof(string);
            NewColumn2.ColumnName = "ملاحظة";

            ItemsShows.Columns.Add(NewColumn2);

        }

        private void AddItemShows(int ID, string Name)
        {      
            ItemsShows.Rows.Add(ID, Name);
        }

        public bool IsItemIfExist(int ID)
        {
            DataRow[] Rows = ItemsShows.Select("الرقم = " + ID);
            foreach (DataRow row in Rows)
            {
                return true;
            }
            return false;
        }

        private void _ShowItemsSelected()
        {
            dgvItemsShows.DataSource = ItemsShows;
            dgvItemsShows.Columns[0].Width = 40;
            dgvItemsShows.Columns[1].Width = 200;
            dgvItemsShows.Columns[2].Width = 110;
            dgvItemsShows.Columns[3].Width = 110;
            dgvItemsShows.Columns[4].Width = 110;
        }

        private void _ClearFaild()
        {
            txtName.Clear();
            txtNotes.Clear();
            txtQuantityUnit.Clear();
            txtQuantityGroup.Clear();
            txtName.Tag = "";
        }

        private void UpdateItem(int ID, float QtyUnit, float QtyGroup, string Notes)
        {
           
                DataRow[] Rows = ItemsShows.Select("الرقم = " + ID);

                foreach(var row in Rows)
                {
                    row[2] = QtyUnit;
                    row[3] = QtyGroup;
                    row[4] = Notes;
                }
                ItemsShows.AcceptChanges();
                    
        }

        private void DeleteItemSelected(int ID)
        {
            DataRow[] Rows = ItemsShows.Select("الرقم = "+ID);
            foreach(DataRow row in Rows)
            {
                row.Delete();
            }
            ItemsShows.AcceptChanges();
        }
      
        private void btnClearTable_Click(object sender, EventArgs e)
        {
            ItemsShows.Clear();
            _ShowItemsSelected();
            _ClearFaild();

        }

        private void btnDeleteItemSelected_Click(object sender, EventArgs e)
        {
            DeleteItemSelected((int)dgvItemsShows.CurrentRow.Cells[0].Value);
            _ShowItemsSelected();
            _ClearFaild();

        }

        private void setItemToFaildUpdate()
        {
            if (dgvItemsShows.SelectedCells.Count > 0)
            {
                txtName.Tag = dgvItemsShows.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvItemsShows.CurrentRow.Cells[1].Value.ToString();
                txtQuantityUnit.Text = dgvItemsShows.CurrentRow.Cells[2].Value.ToString();
                txtQuantityGroup.Text = dgvItemsShows.CurrentRow.Cells[3].Value.ToString();
                txtNotes.Text = dgvItemsShows.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void dgvItemsShows_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtName.Text)) 
            //    _UpdateItems();
            setItemToFaildUpdate();


        }

        private void frmProductsRestrictRequest_KeyDown(object sender, KeyEventArgs e)
        {
            _UpdateItems();
        }

        private void _UpdateItems()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("قم بتحديد الصنف المراد تعديل كميت الشراء");
                return;
            }

            if (!string.IsNullOrEmpty(txtQuantityUnit.Text) || !string.IsNullOrEmpty(txtQuantityGroup.Text))
            {
                int ID = Convert.ToInt32(txtName.Tag);
                float QtyUnit = txtQuantityUnit.Text != "" ? Convert.ToSingle(txtQuantityUnit.Text) : 0;
                float QtyGroup = txtQuantityGroup.Text != "" ? Convert.ToSingle(txtQuantityGroup.Text) : 0;
                string Note = txtNotes.Text;
                UpdateItem(ID, QtyUnit, QtyGroup, Note);
                _ShowItemsSelected();
                _ClearFaild();
            }
            else
            {
                MessageBox.Show("يرجا تحديد الكمية بالوحدة او الدرزن");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _UpdateItems();
        }

        private void btnPluseQtyUnit_Click(object sender, EventArgs e)
        {
            float Qty = 0;

            if (!string.IsNullOrEmpty(txtQuantityUnit.Text))
            {
                Qty = Convert.ToSingle(txtQuantityUnit.Text);

                Qty++;

                txtQuantityUnit.Text = Qty.ToString();
            }
            else
            {
                txtQuantityUnit.Text = 1.ToString();
            }


        }

        private void btnMunisQtyUnit_Click(object sender, EventArgs e)
        {
            float Qty = 0;
            if (!string.IsNullOrEmpty(txtQuantityUnit.Text))
            {
                if (Convert.ToSingle(txtQuantityUnit.Text) > 0)
                {
                    Qty = Convert.ToSingle(txtQuantityUnit.Text);

                    Qty--;

                    txtQuantityUnit.Text = Qty.ToString();
                }

            }
            txtQuantityUnit.Text = Qty.ToString();
        }

        private void btnPluseQtyGroup_Click(object sender, EventArgs e)
        {   
            float Qty = 0;
            
            if (!string.IsNullOrEmpty(txtQuantityGroup.Text))
            {
                 Qty = Convert.ToSingle(txtQuantityGroup.Text);

                Qty++;

                txtQuantityGroup.Text = Qty.ToString();
            }
            else
            {
                txtQuantityGroup.Text = 1.ToString();
            }
        }

        private void btnMinusQtyGroup_Click(object sender, EventArgs e)
        {
            float Qty = 0;
            if (!string.IsNullOrEmpty(txtQuantityGroup.Text))
            {
                if(Convert.ToSingle(txtQuantityGroup.Text) > 0)
                {
                    Qty = Convert.ToSingle(txtQuantityGroup.Text);

                    Qty--;

                    txtQuantityGroup.Text = Qty.ToString();
                }
                
            }
            txtQuantityGroup.Text = Qty.ToString();
        }



        public int Pay()
        {
            Invoice = new stInvoice();
            Invoice.UserID = clsGlobal.UserID;
            Invoice.SupplierID = SupplierID;

            clsPayInvoicePuy PayInvoicePuy = new clsPayInvoicePuy(Invoice.SupplierID, Invoice.UserID);
            Invoice.InvoiceID = PayInvoicePuy.InvoicePuy(ItemsShows);
           
            return Invoice.InvoiceID;
        }

        public void PayWithingPrint()
        {


                if (!string.IsNullOrEmpty(txtSuppliersShows.Text))
                {
                    rptInvoicPuy.PrintInvoicePuy(Pay());
                }
                else
                {
                    MessageBox.Show("قم باختيار المورد");
                }

            txtInvoiceNumber.Text = Invoice.InvoiceID.ToString();
        }

        public void PayNotWithingPrint()
        {

            if (!string.IsNullOrEmpty(txtSuppliersShows.Text))
            {
                Pay();
            }
            else
            {
                MessageBox.Show("قم باختيار المورد");
            }

            txtInvoiceNumber.Text = Invoice.InvoiceID.ToString();
        }


        private void btnPayProducts_Click(object sender, EventArgs e)
        {

            if (dgvItemsShows.SelectedCells.Count > 0)
            {
                PayWithingPrint(); 
            }
            else
            {
                MessageBox.Show("قم بتحديد الاصناف المراد الشراء منها");
            }
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductSearch.Text))
            {
                if(cbMethodsDisplayProducts.SelectedIndex == 1)
                {
                    Products.Clear();
                    DataTable dt = clsProduct.GetAllProductsRestrictRequestUsingLike(txtProductSearch.Text);

                    foreach (DataRow Row in dt.Rows)
                    {
                        _AddProductToDataTable(Row[0].ToString(), Convert.ToSingle(Row[1]), (int)Row[2]);
                    }
                    _ShowAllProducts();
                }
                else
                {
                    Products.Clear();
                    DataTable dt = clsProduct.GetAllProductUsingLikeByName(txtProductSearch.Text);

                    foreach (DataRow Row in dt.Rows)
                    {
                        _AddProductToDataTable(Row[2].ToString(), Convert.ToSingle(Row[3]), (int)Row[4]);
                    }
                    _ShowAllProducts();
                }
               
            }
            else
            {
                _ShowProducts();
            }
        }

        private void tsmiAddToRequstProduct_Click(object sender, EventArgs e)
        {
            AddToTable();
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            cbSelecteItems.Checked = true;
            _SelectAllItems();
        }

        private void tsmiUnSelectedIProductRequest_Click(object sender, EventArgs e)
        {
            cbSelecteItems.Checked = false;
            _SelectAllItems();
        }

        private void tsmiDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteItemSelected((int)dgvItemsShows.CurrentRow.Cells[0].Value);
            _ShowItemsSelected();
            _ClearFaild();
        }

        private void tsmiUpdateItem_Click(object sender, EventArgs e)
        {
            setItemToFaildUpdate();
        }
        private void _ShowProducts()
        {
            if (cbMethodsDisplayProducts.SelectedIndex == 1)// show products restrict request
            {
                _GetAllProductsRestrictRequest();
                _ShowAllProducts();

            }
            else
            {
                _GetAllProducts();
                _ShowAllProducts();
            }
        }
        private void cbMethodsDisplayProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ShowProducts();
               
        }

        private void txtSuppliersSearch_Click(object sender, EventArgs e)
        {
            frmShowsSuppliers showsSuppliers = new frmShowsSuppliers();
            showsSuppliers.ShowDialog();
            SupplierID = frmShowsSuppliers.SupplierID;

            if(SupplierID != -1)
            {
                clsSupplier Supplier = clsSupplier.FindSupplierByID(SupplierID);
                txtSuppliersShows.Text = Supplier.FirstName +" "+Supplier.LastName;
            }
  
        }

        private void AddToTable()
        {
            if (cbSelecteItems.Checked)
            {
                foreach (DataRow row in Products.Rows)
                {
                    if (!IsItemIfExist((int)row[0]))
                        AddItemShows((int)row[0], row[1].ToString());
                }

                _ShowItemsSelected();
            }
            else
            {
                foreach (DataRow row in Products.Rows)
                {
                    if ((bool)row[4] != false && !IsItemIfExist((int)row[0]))
                    {
                        AddItemShows((int)row[0], row[1].ToString());
                    }
                }

                _ShowItemsSelected();
            }
        }

        private void btnAddTo_Click(object sender, EventArgs e)
        {
            AddToTable();
        }
     
    }
}
