using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.Windows.Forms;
using System_C_Sharp_SuperMarket_DB_MISS.Cacher;
using System_C_Sharp_SuperMarket_DB_MISS.Cacher.Payments;
using System_C_Sharp_SuperMarket_DB_MISS.Cards;
using System_C_Sharp_SuperMarket_DB_MISS.Customers;
using System_C_Sharp_SuperMarket_DB_MISS.Employees;
using System_C_Sharp_SuperMarket_DB_MISS.Invoices;
using System_C_Sharp_SuperMarket_DB_MISS.Products;
using System_C_Sharp_SuperMarket_DB_MISS.Settings;
using System_C_Sharp_SuperMarket_DB_MISS.Shared;
using System_C_Sharp_SuperMarket_DB_MISS.Suppliers;
using System_C_Sharp_SuperMarket_DB_MISS.Users;
using System.Diagnostics;
using System.Threading;

namespace System_C_Sharp_SuperMarket_DB_MISS.Salespeople
{
    public partial class frmSalesCacherScreen : frmSharedLayoutTop
    {
 
        public enum enModePay { PayWithPrint = 1, PayNotWithPrint = 2};

        public DataTable Products, WaitingInvoice;
        public DataColumn NewColumn, ColumnsWaitingInvoice;
        public int Qty = 1;
        public int CustomerID = -1;



        public struct stInvoice
        {
            public int InvoiceID;
            public int UserID;
            public float TotalPriceInvoice;
            public float AmountPaid;
            public float RemainingAmount;
            public int CustomerID;
            public int TypeInvoicID;
        }

        public stInvoice Invoice;

        public void Referch(int ID)
        {
            Products.AcceptChanges();
            _UpdateTotalPriceOfItem(ID);
            _ShowProductsToDGV();
            _ShowTotalPrice();
            ShowCountItems();
        }
        private void _PluseQty(int ID)
        {
            DataRow[] ProductDataRow = Products.Select("ID = " + ID);

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
            DataRow[] ProductDataRow = Products.Select("ID = " + ID);

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
            DataRow[] ProductDataRow = Products.Select("ID = " + ID);

            foreach (var row in ProductDataRow)
            {
                int Q;
                Q = Convert.ToInt32(row[3]);
                Q = NewQty;
                row[3] = Q;
            }
        }

        private void _UpdateTotalPriceOfItem(int ID)
        {
            DataRow[] ProductDataRow = Products.Select("ID = " + ID);

            foreach (var row in ProductDataRow)
            {
                float Price;
                int Qty;

                Price = Convert.ToSingle(row[2]);
                Qty = Convert.ToInt32(row[3]);

                row[4] = Price * Qty;
            }
        }

        private void _EditItem()
        {
           
        }

        private void _DeleteItem(int ID)
        {
            DataRow[] ProductDataRow = Products.Select("ID = " + ID);

            foreach (var row in ProductDataRow)
            {
                row.Delete();
            } 
        }

        public int GetCountItems()
        {
            int count = 0;  
            foreach(DataRow row in Products.Rows)
            {
                count += Convert.ToInt32(row["الكمية"]);
            }
            return count;
        }

        public void ShowCountItems()
        {
            if(dgvShowProducts.Rows.Count > 0)
                txtCountItems.Text = GetCountItems().ToString();
        }

        private void _ClearAllFiald()
        {
            txtQty.Clear();
            txtCalculate.Clear();
            txtCountItems.Clear();
            txtTotalPriceAfterTax.Clear();
            txtTotalTax.Clear();
            txtTotalPriceBeforTax.Clear();
            txtTotalPriceFinal.Clear();
        }
        private void _ClearTableItems()
        {
            Products.Clear();
        }

        private void _CreateTableProduct()
        {
            Products = new DataTable();

            NewColumn = new DataColumn();

            NewColumn.DataType = typeof(int);
            NewColumn.ColumnName = "ID";
            NewColumn.AutoIncrement = true;
            NewColumn.AutoIncrementSeed = 1;
            NewColumn.AutoIncrementStep = 1;

            Products.Columns.Add(NewColumn);

            DataColumn[] PrimaryKeyID = new DataColumn[1];
            PrimaryKeyID[0] = Products.Columns["ID"];
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
            NewColumn.ColumnName = "الكمية";

            Products.Columns.Add(NewColumn);

            NewColumn = new DataColumn();
            NewColumn.DataType = typeof(double);
            NewColumn.ColumnName = "الاجمالي";

            Products.Columns.Add(NewColumn);


        }
      
        private void _AddProductToDataTable(string Name, float Price, int Qty, double TotalAmount)
        {

            Products.Rows.Add(null, Name, Price, Qty, TotalAmount);
            _ShowTotalPrice();
        }

        private bool IsExistItemInDataTable(string NameItem)
        {
            DataRow[] ProductDataRow = Products.Select("اسم_الصنف = '" + NameItem + "'");


            if (ProductDataRow.Length > 0)
                return true;
            else
                return false;
        }

        private int FindItemByName(string NameItem)
        {
            DataRow[] ProductDataRow = Products.Select("اسم_الصنف = '" + NameItem + "'");
            foreach (var row in ProductDataRow)
            {
                return Convert.ToInt32(row[0]);
            }

            return 0;
        }

        private int GetQtyItemByName(string Name)
        {
            DataRow[] ProductDataRow = Products.Select("اسم_الصنف = '" + Name + "'");
            foreach (var row in ProductDataRow)
            {
                return Convert.ToInt32(row[3]);
            }

            return 0;
        }

        private float GetTotalPriceBeforTax()
        {
            float TotalPrice = 0;

            foreach (DataRow row in Products.Rows)
            {
                TotalPrice += Convert.ToSingle(row[4]);
            }

            return TotalPrice;
        }

        private float CalculateTax()
        {
            // Tax Retrive from database after add column Tax
            float totalTax = 0;

            totalTax = GetTotalPriceBeforTax() * (clsSetting.GetTax() / 100) ;
            
            return totalTax;
        }

        private float GetTotalPriceAfterTax()
        {
            float Total = 0;
           
            Total = GetTotalPriceBeforTax() + CalculateTax();
            
            return Total;
        }

        private float GetTotalPriceFinally()
        {
            return GetTotalPriceAfterTax();
        }

        private void _ShowProductsToDGV()
        {
            try
            {
                dgvShowProducts.DataSource = Products;
                dgvShowProducts.Columns[0].Frozen = true;

                dgvShowProducts.Columns[0].Visible = false;
                dgvShowProducts.Columns[2].Width = 60;
                dgvShowProducts.Columns[3].Width = 60;
                dgvShowProducts.Columns[4].Width = 60;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void _ShowTotalPrice()
        {
            txtTotalPriceBeforTax.Text = GetTotalPriceBeforTax().ToString();
            txtTotalTax.Text = CalculateTax().ToString();
            txtTotalPriceAfterTax.Text = GetTotalPriceAfterTax().ToString();
            txtTotalPriceFinal.Text = GetTotalPriceFinally().ToString();
        }

        // calculator
        private void _Calculator(Button btn)
        {
            int Number = Convert.ToInt32(btn.Tag);

            txtCalculate.Text += Number;
        }

        private void _BackspaceCalc()
        {
            if (!string.IsNullOrEmpty(txtCalculate.Text))
            {
                txtCalculate.Text = txtCalculate.Text.Remove(txtCalculate.Text.Length - 1, 1);
            }            
        }

        private void _FillComboBoxTypeInvoice()
        {
            try
            {
                cbTypeInvoice.Items.Clear();
                DataTable TypeInvoices = clsSalesCacher.GetAllTypeInvoices();

                foreach (DataRow Row in TypeInvoices.Rows)
                {
                    cbTypeInvoice.Items.Add(Row[0].ToString());
                }

                if (TypeInvoices.Rows != null)
                    cbTypeInvoice.SelectedIndex = 0;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _ShowCountInvoices()
        {
            try
            {
                int num = clsInvoiceSales.GetLastNumberInvoiceSales();

                if(num > 0)
                    txtInvoiceNumber.Text = num.ToString();
            }
            catch(Exception e)
            {

            }

        }

        private void _Loading()
        {

        }

        private async void _ShownForm()
        {
            Task t1 = init();

            

        }

        private async Task init()
        {
            _CreateTableProduct();  
            _ShowAllProductIsNotHaveBarcode();
            _FillComboBoxTypeInvoice();
            _ShowCountInvoices();

            txtProductBarcode.Focus();
            txtProductBarcode.Cursor = Cursors.IBeam;
        }

        //------------------------
        public frmSalesCacherScreen(string Title)
            :base(Title)
        {
            InitializeComponent();

        }

        private void _AddProduct(string Barcode)
        {
            
            clsProduct Product = clsProduct.GetProductByBarcode(Barcode);
            if (Product != null)
            {
                if (Product.Quantity > GetQtyItemByName(Product.Name))
                {
                    if (IsExistItemInDataTable(Product.Name))
                    {
                        int id = FindItemByName(Product.Name);
                        _PluseQty(id);
                        Referch(id);
                        txtProductBarcode.Clear();
                    }
                    else
                    {
                        _AddProductToDataTable(Product.Name, Product.Price, Qty, Product.Price);
                        _ShowProductsToDGV();
                        txtProductBarcode.Clear();
                    }
                                  
                }
                else
                {
                    frmMessage Message = new frmMessage("الكمية غير كافية لهذا الصنف", enTypeIcon.Information, 2);
                    Message.ShowDialog();
                }
                ShowCountItems();
            }
        }
        private void txtProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                _AddProduct(txtProductBarcode.Text);
            }
            
        }

        private void frmSalesCacherScreen_Load(object sender, EventArgs e)
        {
            _Loading();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            
                if (!string.IsNullOrEmpty(txtQty.Text))
                {
                    if (dgvShowProducts.CurrentRow == null || dgvShowProducts.CurrentRow.Index < 0)
                    {

                        frmMessage message = new frmMessage("قم باختيار الصنف أولاً لكي يتم تعديل الكمية", enTypeIcon.Information, 2);
                        message.ShowDialog();

                    }
                    else
                    {
                        int NewQty = Convert.ToInt32(txtQty.Text);
                        EditQty(NewQty);
                    }
                }

            
            
        }

        private void btnPluse_Click(object sender, EventArgs e)
        {
            if (dgvShowProducts.SelectedCells.Count > 0)
            {
                int ID = Convert.ToInt32(dgvShowProducts.CurrentRow.Cells[0].Value);
                string Name = Convert.ToString(dgvShowProducts.CurrentRow.Cells[1].Value);
                if (GetQtyItemByName(Name) >= clsProduct.GetQuantityItemByName(Name))
                {
                    frmMessage Message = new frmMessage("الكمية غير كافية لهذا الصنف", enTypeIcon.Information, 2);
                    Message.ShowDialog();
                    return;
                }
                else
                {
                    _PluseQty(ID);
                    Referch(ID);
                }
               
            }
        }

        private void btnMinusQty_Click(object sender, EventArgs e)
        {
            if (dgvShowProducts.SelectedCells.Count > 0)
            {
                 int ItemID = Convert.ToInt32(dgvShowProducts.CurrentRow.Cells[0].Value);
                _MinusQty(ItemID);
                Referch(ItemID);
            }
        }

        private void btnEditCellQty_Click(object sender, EventArgs e)
        {
            if(dgvShowProducts.SelectedCells.Count > 0 && dgvShowProducts.Rows.Count > 0)
            {
                _EditItem();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            _ClearTableItems();
            _ClearAllFiald();
        }

       
        private void btnCalc(object sender, EventArgs e)
        {
            _Calculator((Button)sender);
        }

        public void EditQty(int NewQty)
        {
            try
            {
                if(NewQty <= 0)
                {
                    frmMessage Message = new frmMessage("الكمية المدخلة خاطة", enTypeIcon.Warring, 2);
                    Message.ShowDialog();
                    return;
                }


                if (dgvShowProducts.CurrentRow == null || dgvShowProducts.CurrentRow.Index < 0)
                {
                    frmMessage Message = new frmMessage("قم باختيار الصنف أولاً لكي يتم تعديل الكمية", enTypeIcon.Information, 2);
                    Message.ShowDialog();
                }
                else
                {
                    string NameProduct = dgvShowProducts.CurrentRow.Cells[1].Value.ToString();

                    int ID = Convert.ToInt32(dgvShowProducts.CurrentRow.Cells[0].Value);

                    if (clsProduct.GetQuantityItemByName(NameProduct) >= NewQty)
                    {

                        _UpdateQty(ID, NewQty);
                        Referch(ID);

                    }
                    else
                    {
                        frmMessage Message = new frmMessage("الكمية غير كافية لهذا الصنف : " + NameProduct, enTypeIcon.Information, 2);
                        Message.ShowDialog();
                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            
        }
        private void btnCalcEqule_Click(object sender, EventArgs e)
        {
             
           
            if (!string.IsNullOrEmpty(txtCalculate.Text))
            {
                int NewQty = Convert.ToInt32(txtCalculate.Text);
                
                EditQty(NewQty);
            }
            txtCalculate.Clear();
        }

        private void btnCalcClear_Click(object sender, EventArgs e)
        {
           txtCalculate.Clear();
        }
      
        public int PaymentCash()
        {
            Invoice = new stInvoice();
            Invoice.UserID = clsGlobal.UserID;
            Invoice.TotalPriceInvoice = GetTotalPriceFinally();
            Invoice.CustomerID = clsCustomer.GetCustomerIDByPersonID(CustomerID);
            Invoice.TypeInvoicID = clsSalesCacher.GetTypeInvoiceIDByName(cbTypeInvoice.Text);

            clsPayInvoiceCash PayInvoiceCash = new clsPayInvoiceCash(Invoice.UserID, Invoice.TotalPriceInvoice, Invoice.CustomerID, Invoice.TypeInvoicID);
            Invoice.InvoiceID = PayInvoiceCash.PayInvoiceCash(Products);
            _ClearTableItems();
            _ClearAllFiald();
            _FialdCustomerShows(false);

            return Invoice.InvoiceID;
        }

        public int PaymentDebt()
        {
            Invoice.UserID = clsGlobal.UserID;
            Invoice.CustomerID = clsCustomer.GetCustomerIDByPersonID(CustomerID);
            Invoice.TypeInvoicID = clsSalesCacher.GetTypeInvoiceIDByName(cbTypeInvoice.Text);

            clsPayInvoice PayInvoice = new clsPayInvoice(Invoice.UserID, Invoice.TotalPriceInvoice, Invoice.AmountPaid, Invoice.RemainingAmount, Invoice.CustomerID, Invoice.TypeInvoicID);
            Invoice.InvoiceID = PayInvoice.PayInvoiceCash(Products);
            _ClearTableItems();
            _FialdCustomerShows(false);
            return Invoice.InvoiceID;
        }

        public void PayWithingPrint()
        {
            
            switch (cbTypeInvoice.Text)
            {
                case "كاش":
                    {
                        Invoices.rptCashInvoiceSales.PrintCashInvoiceSales(PaymentCash());
                        _ShowCountInvoices();
                    }
                    break;
                case "اجل":
                    {
                        if (!string.IsNullOrEmpty(txtShowsCustomer.Text))
                        {
                            Invoice.TotalPriceInvoice = GetTotalPriceFinally();
                            frmPaymentAmount paymentAmount = new frmPaymentAmount(Invoice.TotalPriceInvoice);
                            paymentAmount.ShowDialog();
                            Invoice.AmountPaid = frmPaymentAmount.AmountPaid;
                            Invoice.RemainingAmount = frmPaymentAmount.RemainingAmount;

                            if (frmPaymentAmount.IsPay)
                            {
                                rptDebtInvoiceSales.PrintDebtInvoiceSales(PaymentDebt(), Invoice.CustomerID);
                            }
                        }
                        else
                        {
                            frmMessage Message = new frmMessage("قم باختيار العميل", enTypeIcon.Warring, 2);
                            Message.ShowDialog();
                        } 
                        
                        _ShowCountInvoices();

                    }
                    break;
            }

        }

        public void PayNotWithingPrint()
        {

            switch (cbTypeInvoice.Text)
            {
                case "كاش":
                    {
                        if(PaymentCash() != -1)
                        {
                            frmMessage message = new frmMessage("تم الشراء بنجاج", enTypeIcon.Success, 2);
                            message.ShowDialog();
                           
                        }
                        else
                        {
                            frmMessage message = new frmMessage("هنالك خطا! لم يتم الشراء", enTypeIcon.Error, 2);
                            message.ShowDialog();
                        }
                        _ShowCountInvoices();
                    }
                    break;
                case "اجل":
                    {
                        if (!string.IsNullOrEmpty(txtShowsCustomer.Text))
                        {
                            Invoice.TotalPriceInvoice = GetTotalPriceFinally();
                            frmPaymentAmount paymentAmount = new frmPaymentAmount(Invoice.TotalPriceInvoice);
                            paymentAmount.ShowDialog();
                            Invoice.AmountPaid = frmPaymentAmount.AmountPaid;
                            Invoice.RemainingAmount = frmPaymentAmount.RemainingAmount;

                            if (frmPaymentAmount.IsPay)
                            {
                                if (PaymentDebt() != -1)
                                {
                                    frmMessage message = new frmMessage("تم الشراء بنجاج", enTypeIcon.Success, 2);
                                    message.ShowDialog();
                                }
                                else
                                {
                                    frmMessage message = new frmMessage("هنالك خطا! لم يتم الشراء", enTypeIcon.Error, 2);
                                    message.ShowDialog();
                                }


                            }                               
                            _ShowCountInvoices();

                        }
                        else
                        {
                            frmMessage Message = new frmMessage("قم باختيار العميل", enTypeIcon.Warring, 2);
                            Message.ShowDialog();
                        }
                    }
                    break;
            }

        }

        public void Pay(enModePay ModePay)
        {
            if (dgvShowProducts.Rows.Count > 0)
            {
                switch (ModePay)
                {
                    case enModePay.PayWithPrint:
                        PayWithingPrint();
                        break;

                    case enModePay.PayNotWithPrint:
                        PayNotWithingPrint();
                        break;
                }
            }
            else
            {
                frmMessage Message = new frmMessage("قم باختيار الاصناف", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
        }

        //بيع اصناف بدون طباعة
        private void btnPay_Click(object sender, EventArgs e)
        {

            Pay(enModePay.PayNotWithPrint);
        }

        // بيع اصناف والطباعة
        private void btnPayPrint_Click(object sender, EventArgs e)
        {
            Pay(enModePay.PayWithPrint);

        }

        private void _FialdCustomerShows(bool Action)
        {
            if (!Action)
            {
                txtShowsCustomer.Clear();
                cbTypeInvoice.SelectedIndex = 0;
            }

            txtShowsCustomer.Enabled = Action;
        }

        private void cbTypeInvoice_SelectedValueChanged(object sender, EventArgs e)
        {
            switch(cbTypeInvoice.Text)
            {
                case "اجل":
                    _FialdCustomerShows(true);
                    break;

                case "كاش":
                    _FialdCustomerShows(false);
                    break;

                case "دفع عبر حساب":
                    _FialdCustomerShows(true);
                    break;
            }
        }

        private void txtShowsCustomer_Click(object sender, EventArgs e)
        {
            
            frmShowsCustomer ShowsCustomer = new frmShowsCustomer();
            ShowsCustomer.ShowDialog();
            CustomerID = frmShowsCustomer.id;
            if (CustomerID != -1)
            {
                clsCustomer Customer = clsCustomer.FindCustomerByID(CustomerID);
                txtShowsCustomer.Text = Customer.FirstName + " " + Customer.LastName;
                txtProductBarcode.Focus();

            }
            else
            {
                _FialdCustomerShows(false);
                cbTypeInvoice.SelectedIndex = 0;
            }
            
        }

        public void EditQty()
        {
            if (dgvShowProducts.SelectedCells.Count > 0)
            {
                frmEditQty Qty = new frmEditQty();
                Qty.ShowDialog();

                EditQty(Qty.NewQty);
            }
        }

        private void dgvShowProducts_DoubleClick(object sender, EventArgs e)
        {

            EditQty();
        }

        private void tsmiEditQty_Click(object sender, EventArgs e)
        {
            EditQty();
        }

        public void DeleteItem()
        {
            if (dgvShowProducts.SelectedCells.Count > 0)
            {
                // خطا عند الحذف
                _DeleteItem((int)dgvShowProducts.CurrentRow.Cells[0].Value);
                Referch((int)dgvShowProducts.CurrentRow.Cells[0].Value);
            }
        }

        private void tsmiDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteItem();           
        }

        private void _CreateTableProductTemp()
        {
            WaitingInvoice = new DataTable("ProductTemp");

            ColumnsWaitingInvoice = new DataColumn();

            ColumnsWaitingInvoice.DataType = typeof(int);
            ColumnsWaitingInvoice.ColumnName = "ID";
            ColumnsWaitingInvoice.AutoIncrement = true;
            ColumnsWaitingInvoice.AutoIncrementSeed = 1;
            ColumnsWaitingInvoice.AutoIncrementStep = 1;

            WaitingInvoice.Columns.Add(ColumnsWaitingInvoice);

            DataColumn[] PrimaryKeyID = new DataColumn[1];
            PrimaryKeyID[0] = Products.Columns["ID"];
            Products.PrimaryKey = PrimaryKeyID;

            ColumnsWaitingInvoice = new DataColumn();
            ColumnsWaitingInvoice.DataType = typeof(string);
            ColumnsWaitingInvoice.ColumnName = "اسم_الصنف";

            WaitingInvoice.Columns.Add(ColumnsWaitingInvoice);

            ColumnsWaitingInvoice = new DataColumn();
            ColumnsWaitingInvoice.DataType = typeof(float);
            ColumnsWaitingInvoice.ColumnName = "السعر";

            WaitingInvoice.Columns.Add(ColumnsWaitingInvoice);

            ColumnsWaitingInvoice = new DataColumn();
            ColumnsWaitingInvoice.DataType = typeof(int);
            ColumnsWaitingInvoice.ColumnName = "الكمية";

            WaitingInvoice.Columns.Add(ColumnsWaitingInvoice);

            ColumnsWaitingInvoice = new DataColumn();
            ColumnsWaitingInvoice.DataType = typeof(double);
            ColumnsWaitingInvoice.ColumnName = "الاجمالي";

            WaitingInvoice.Columns.Add(ColumnsWaitingInvoice);
        }

        private void _RestoreProductFromTableTemp()
        {
            try
            { 
                foreach (DataRow row in WaitingInvoice.Rows)
                {
                    _AddProductToDataTable(row[1].ToString(), Convert.ToSingle(row[2]), Convert.ToInt32(row[3]), Convert.ToDouble(row[4]));
                }
                _ShowProductsToDGV();
                _ShowTotalPrice();
                WaitingInvoice.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRestoreInvoice_Click(object sender, EventArgs e)
        {
            if (WaitingInvoice != null)
            {
                _ClearTableItems();
                _ShowProductsToDGV();
                _RestoreProductFromTableTemp();
            }
            else
            {
                frmMessage Message = new frmMessage("لاتوجد فاتورة تم تعليقها مسبقاً", enTypeIcon.Information, 2);
                Message.ShowDialog();
            }
        }

        private void _AddProductToDataTableTemp(string Name, float Price, int Qty, double TotalPrice)
        {
            WaitingInvoice.Rows.Add(null, Name, Price, Qty, TotalPrice);
        }
       
        private void AddInvoiceInWaiting()
        {
            _CreateTableProductTemp();
            try
            {
                foreach (DataRow row in Products.Rows)
                {
                    _AddProductToDataTableTemp(row[1].ToString(), Convert.ToSingle(row[2]), Convert.ToInt32(row[3]), Convert.ToDouble(row[4]));
                }
                _ClearTableItems();
                tmrRemoveWaitingInvoice.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            } 
           
        }

        public void ClearAllProductsIsNotHasBarcode()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void _ShowAllProductIsNotHaveBarcode()
        {
            try
            {
                DataTable dt = clsProduct.GetAllProductIsNotHasBarcode(1);
                clsCardInfo CardInfo;
                ClearAllProductsIsNotHasBarcode();

                foreach (DataRow row in dt.Rows)
                {
                    int Id = Convert.ToInt32(row[0]);
                    string Barcode = Convert.ToString(row[1]);
                    string Name = Convert.ToString(row[2]);
                    float Price = Convert.ToSingle(row[3]);
                    string ImagePath = Convert.ToString(row[4]);

                    CardInfo = new clsCardInfo(Id, Barcode, Name, Price, ImagePath);

                    //frmCard frmCard = new frmCard(Id, Barcode, Name, Price, ImagePath);
                    frmCard frmCard = new frmCard(CardInfo);

                    frmCard.AddToCartClicked += (s, e) =>
                    {
                        _AddProduct(frmCard.getBarcode());
                    };
                   
                
                    flowLayoutPanel1.Controls.Add(frmCard);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tsmiAddNewProduct_Click(object sender, EventArgs e)
        {
            frmAddEditProducts AddEditProduct = new frmAddEditProducts("");
            AddEditProduct.DataUpdated += frmSalesCacherScreen_Load;
            AddEditProduct.ShowDialog();
        }

        private void btnReviewProduct_Click(object sender, EventArgs e)
        {
            frmProductReview ProductReview = new frmProductReview();
            ProductReview.ShowDialog();
        }

        int CounterRemovieWaitingInvoice = 0;
        private void tmrRemoveWaitingInvoice_Tick(object sender, EventArgs e)
        {
            CounterRemovieWaitingInvoice++;

            int ValueFromDatabase = clsSetting.GetTimeWaitingInvoice();// هذة القيمة يتم جلبها من قاعدة البيانات
            if (CounterRemovieWaitingInvoice == ValueFromDatabase)
            {
                tmrRemoveWaitingInvoice.Stop();
                WaitingInvoice.Clear();
                CounterRemovieWaitingInvoice = 0;
            }
        }
        
        public int GetRandomNumber(int From, int To)
        {
            Random r = new Random();

            return r.Next(From, To);
        }

        int CounterShowTasbih = 0;
        int TimeShowTasbih = clsSetting.GetTimeMsgTasbih();
        private void tmrShowNameTasbih_Tick(object sender, EventArgs e) 
        {

            try
            {
                clsTasbih tasbih = clsTasbih.GetTasbih();
                if(tasbih != null)
                {
                    if (CounterShowTasbih == TimeShowTasbih)
                    {
                        //Debug.WriteLine("ERROR: " + tasbih.Name, "Green: " + tasbih.Bgreen, "blue: " + tasbih.Bblue, "red: " + tasbih.Bred);
                        lblNameTasbih.BackColor = Color.FromArgb(tasbih.Bred, tasbih.Bgreen, tasbih.Bblue);
                        lblNameTasbih.ForeColor = Color.FromArgb(tasbih.Fred, tasbih.Fgreen, tasbih.Fblue);
                        lblNameTasbih.Text = tasbih.Name.ToString();
                        CounterShowTasbih = 0;
                        lblNameTasbih.Refresh();
                    }

                    CounterShowTasbih++;
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            _BackspaceCalc();
        }

        private void btnReturnItems_Click(object sender, EventArgs e)
        {
            frmReturnItems ReturnItems = new frmReturnItems("مرتجع مبيعات");
            ReturnItems.FormBorderStyle = FormBorderStyle.FixedSingle;
            ReturnItems.ShowDialog();
        }

        private void btnIconWaitingInvoice_Click(object sender, EventArgs e)
        {
            if (dgvShowProducts.Rows.Count > 0)
            {
                AddInvoiceInWaiting();
            }
            else
            {
                frmMessage Message = new frmMessage("لاتوجد فاتورة لكي نعمل لها تعليق", enTypeIcon.Information, 2);
                Message.ShowDialog();
            }
        }

        private void tsmiAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddEditCustomers AddEditCustomers = new frmAddEditCustomers(-1);
            AddEditCustomers.ShowDialog();
        }

        private void tsmiAddNewEmployees_Click(object sender, EventArgs e)
        {

            frmAddEditEmployees AddEditEmployees = new frmAddEditEmployees(-1);
            AddEditEmployees.ShowDialog();
        }

        private void tsmiAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditUsers AddEditUsers = new frmAddEditUsers(-1);
            AddEditUsers.ShowDialog();
        }

        private void tsmiAddNewSupplier_Click(object sender, EventArgs e)
        {
            frmAddEditSuppliers AddEditSuppliers = new frmAddEditSuppliers(-1);
            AddEditSuppliers.ShowDialog();
        }

        private void tsmiAddNewTasbih_Click(object sender, EventArgs e)
        {
            frmTasbihs Tasbihs = new frmTasbihs();
            Tasbihs.ShowDialog();
        }

        private void tsmiAddNewQtyItems_Click(object sender, EventArgs e)
        {
            frmAddNewQty addNewQty = new frmAddNewQty();
            addNewQty.ShowDialog();
        }

        private void dgvShowProducts_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {
            // التأكد من أن العمود الأول يبقى في مكانه
            if (e.Column.DisplayIndex == 0 && e.Column.Index != 0)
            {
                e.Column.DisplayIndex = 0; // منع تحريكه
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmSalesCacherScreen_Shown(object sender, EventArgs e)
        {
            _ShownForm();
        }

        private void btnAddNewQty_Click(object sender, EventArgs e)
        {
            frmAddNewQty addNewQty = new frmAddNewQty();
            addNewQty.ShowDialog();
        }

        private void btnWaitingInvoice_Click(object sender, EventArgs e)
        {
            if (dgvShowProducts.Rows.Count > 0)
            { 
                AddInvoiceInWaiting();
            }
            else
            {
                frmMessage Message = new frmMessage("لاتوجد فاتورة لكي نعمل لها تعليق", enTypeIcon.Information, 2);
                Message.ShowDialog();
            }
        }
    }
}
