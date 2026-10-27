using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_C_Sharp_SuperMarket_DB_MISS.Cacher;
using System_C_Sharp_SuperMarket_DB_MISS.Cacher.Payments;
using System_C_Sharp_SuperMarket_DB_MISS.Invoices;
using System_C_Sharp_SuperMarket_DB_MISS.Products.ReturnInvoice;
using System_C_Sharp_SuperMarket_DB_MISS.Shared;

namespace System_C_Sharp_SuperMarket_DB_MISS.Products
{
    public partial class frmReturnItems : frmSharedLayoutTop
    {
        public DataTable dtInvoiceDetails, dtInvoiceReturnsItems;
        public DataColumn NewColumn;

        public List<string> ListItemDeleted = new List<string>();
        public float TotalInvoiceBeforEdit = 0, TotalInvoiceAfterEdit = 0;
        public string DefaultCustomer = "العميل الافتراضي";
        public int InvoiceID = -1;

        public int ItemID = -1;


        public void Referch(int ID)
        {
            dtInvoiceDetails.AcceptChanges();
            _UpdateTotalPriceOfItem(ID);
            ShowInvoiceFromDataTable();
            _ShowTotalPrice();
        }

        public frmReturnItems(string Title = "...")
            :base(Title)
        {
            InitializeComponent();
        }

        private void _CreateTableInvoiceDetails(string InvoiceDetails, string ReturnItems)
        {
            //-----------------------------------------------------------------------  
            // انشاء جدول حتوي على تفاصيل الفاتورة التي تم ارجاعها
            //-----------------------------------------------------------------------
            dtInvoiceDetails = new DataTable(InvoiceDetails);

            // add column ID
            NewColumn = new DataColumn();

            NewColumn.ColumnName = "ID";
            NewColumn.DataType = typeof(int) ;
            NewColumn.AutoIncrement = true;
            NewColumn.AutoIncrementSeed = 1;
            NewColumn.AutoIncrementStep = 1;

            dtInvoiceDetails.Columns.Add(NewColumn);

            DataColumn[] PK_InvoiceDetails_ID = new DataColumn[1];
            PK_InvoiceDetails_ID[0] = dtInvoiceDetails.Columns["ID"];
            dtInvoiceDetails.PrimaryKey = PK_InvoiceDetails_ID;

            // add column Name
            NewColumn = new DataColumn();

            NewColumn.ColumnName = "Name";
            NewColumn.DataType = typeof(string);

            dtInvoiceDetails.Columns.Add(NewColumn);

            // add column Price
            NewColumn = new DataColumn();

            NewColumn.ColumnName = "Price";
            NewColumn.DataType = typeof(float);

            dtInvoiceDetails.Columns.Add(NewColumn);

            // add column Quantity
            NewColumn = new DataColumn();

            NewColumn.ColumnName = "Qty";
            NewColumn.DataType = typeof(int);

            dtInvoiceDetails.Columns.Add(NewColumn);

            // add column TotalPrice
            NewColumn = new DataColumn();

            NewColumn.ColumnName = "TotalPrice";
            NewColumn.DataType = typeof(float);

            dtInvoiceDetails.Columns.Add(NewColumn);

            //-----------------------------------------------------------------------  
            // انشاء جدول حتوي على المنتجات التي تم ارجاعها مع الكمية التي تم ارجاعها
            //-----------------------------------------------------------------------
            dtInvoiceReturnsItems = new DataTable(ReturnItems);

            // add column ID
            NewColumn = new DataColumn();

            NewColumn.ColumnName = "ID";
            NewColumn.DataType = typeof(int);
            NewColumn.AutoIncrement = true;
            NewColumn.AutoIncrementSeed = 1;
            NewColumn.AutoIncrementStep = 1;

            dtInvoiceReturnsItems.Columns.Add(NewColumn);

            DataColumn[] PK_ReturnItems_ID = new DataColumn[1];
            PK_ReturnItems_ID[0] = dtInvoiceReturnsItems.Columns["ID"];
            dtInvoiceReturnsItems.PrimaryKey = PK_ReturnItems_ID;

            // add column Name
            NewColumn = new DataColumn();

            NewColumn.ColumnName = "Name";
            NewColumn.DataType = typeof(string);

            dtInvoiceReturnsItems.Columns.Add(NewColumn);

            // add column OldQty
            NewColumn = new DataColumn();

            NewColumn.ColumnName = "OldQty";
            NewColumn.DataType = typeof(int);

            dtInvoiceReturnsItems.Columns.Add(NewColumn);

            // add column TotalAmount
            NewColumn = new DataColumn();

            NewColumn.ColumnName = "TotalAmount";
            NewColumn.DataType = typeof(float);

            dtInvoiceReturnsItems.Columns.Add(NewColumn);
        }

        public void RenameTableDetails()
        {
            dgvReturnItems.Columns[0].HeaderText = "رقم الصنف";
            dgvReturnItems.Columns[1].HeaderText = "اسم الصنف";
            dgvReturnItems.Columns[2].HeaderText = "السعر";
            dgvReturnItems.Columns[3].HeaderText = "الكمية";
            dgvReturnItems.Columns[4].HeaderText = "اجمالي السعر";
        }
        private void AddRowToTableInvoiceDetails(string Name, float Price, int Qty , float TotalPrice)
        {
            dtInvoiceDetails.Rows.Add(null, Name, Price, Qty, TotalPrice);
        }
        
        private void AddRowToTableReturnItems(string Name, int OldQty, float TotalPrice)
        {
            dtInvoiceReturnsItems.Rows.Add(null, Name, OldQty, TotalPrice);
        }

        private void AddRowsToInvoiceDetails(DataTable dt)
        {
            foreach(DataRow row in dt.Rows)
            {
                string Name = row["Name"].ToString();
                float Price = Convert.ToSingle(row["Price"]);
                int Qty = Convert.ToInt32(row["QtyItems"]);
                float TotalPrice = Convert.ToSingle(row["TotalAmount"]);

                AddRowToTableReturnItems(Name, Qty, TotalPrice);
                AddRowToTableInvoiceDetails(Name, Price, Qty, TotalPrice);
            }
        }


        private void _GetInviceDetails(int InvoiceID)
        {
            DataTable dt = clsReturnInvoiceDetails.GetInvoiceDetails(InvoiceID);
            if (dt != null)
            {
                AddRowsToInvoiceDetails(dt);
            }
            txtInvoiceID.Clear();
        }

        public void ShowInvoiceFromDataTable()
        {
            dgvReturnItems.DataSource = dtInvoiceDetails;
        }

        private void _ShowInvoiceDetails(int InvoiceID)
        {
            _GetInviceDetails(InvoiceID);

            if (dtInvoiceDetails != null)
            {
                dgvReturnItems.DataSource = dtInvoiceDetails;
            }
        }

        private void _ShowInvoice(int InvoiceID)
        {
            clsReturnInvoice Invoice = clsReturnInvoice.FindInvoiceByInvoiceID(InvoiceID);

            try
            {
                if (Invoice != null)
                {
                    lblInvoiceID.Text = InvoiceID.ToString();
                    lblTotalInvoiceBeforEditing.Text = Invoice.TotalInvoice.ToString();
                    lblUserFullNameInvoice.Text = Invoice.UserFullName.ToString();
                    lblTypeInvoice.Text = Invoice.TypeInvoice.ToString();
                    lblDateInvoice.Text = Invoice.DateInvoice.ToString();

                    if(Invoice.CustomerFullName != "")
                    {
                        lblTxtShowRemainingAmount.Text = "المبلغ المخصوم للعميل";
                        lblRemainingAmount.Visible = true;
                        lblAmountPaid.Visible = true;
                        lblCustomerFullNameInvoice.Text = Invoice.CustomerFullName.ToString();
                        lblAmountPaid.Text = Invoice.AmountPaid.ToString();
                        lblRemainingAmount.Text = Invoice.RemainingAmount.ToString();
                    }
                    else
                    {
                        lblRemainingAmount.Visible = false;
                        lblAmountPaid.Visible = false;
                        lblTxtShowRemainingAmount.Text = "المبلغ المتبقي للعميل";
                        lblCustomerFullNameInvoice.Text = DefaultCustomer;
                    }


                    txtInvoiceID.Clear();

                    _ShowTotalPrice();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
           
        }

        private void _ClearTableItems()
        {
            dtInvoiceDetails.Clear();
        } 
        
        private void _ClearTableReturnItems()
        {
            dtInvoiceReturnsItems.Clear();
        }

        private void _ClearAllFiald()
        {
            lblInvoiceID.Text = "";
            lblTotalInvoiceBeforEditing.Text = "";
            lblTotalInvoiceAfterEditing.Text = "";
            lblTotalRemainingInvoiceAfterEditing.Text = "";
            lblUserFullNameInvoice.Text = "";
            lblTypeInvoice.Text = "";
            lblDateInvoice.Text = "";
            lblCustomerFullNameInvoice.Text = "";
            ListItemDeleted.Clear();

            txtItemID.Clear();
            txtNameItem.Clear();
            txtQtyItem.Clear();

        }

        public void UpdateQtyProduct()
        {
            foreach (DataRow row in dtInvoiceReturnsItems.Rows)
            {
                string ProductName = row[1].ToString(); 
                ReturnItemsToTableProducts(ProductName);
            }
        }

        private void _DeleteInvoice(int InvoiceID)
        {
            if (clsReturnInvoice.DeleteInvoice(InvoiceID))
            {
                UpdateQtyProduct();
                frmMessage Message = new frmMessage("تم حذف الفاتورة بنجاح", enTypeIcon.Success, 2);
                Message.ShowDialog();
                _ClearAllFiald();
                _ClearTableItems();
                _ClearTableReturnItems();
            }
            else
            {
                frmMessage Message = new frmMessage("لم يتم حذف الفاتورة", enTypeIcon.Error, 2);
                Message.ShowDialog();
            }
        }

        // show row data to failds
        private void _SetDataToFiald()
        {
            txtItemID.Text = dgvReturnItems.CurrentRow.Cells[0].Value.ToString();
            txtNameItem.Text = dgvReturnItems.CurrentRow.Cells[1].Value.ToString();
            txtQtyItem.Text = dgvReturnItems.CurrentRow.Cells[3].Value.ToString();
        }

        // get invoice by id
        private void _GetInvoice()
        {
           
            if (!string.IsNullOrEmpty(txtInvoiceID.Text))
            {

                int InvoiceID = Convert.ToInt32(txtInvoiceID.Text.Trim());
                _ClearAllFiald();
                _ClearTableItems();
                _ClearTableReturnItems();

                _ShowInvoiceDetails(InvoiceID);
                _ShowInvoice(InvoiceID);
            }
        }
   
        // تنقيس كمي من الصنف
        private void _MinusQty(int ID)
        {
            DataRow[] ProductDataRow = dtInvoiceDetails.Select("ID = " + ID);

            foreach (var row in ProductDataRow)
            {
                int Q;
                Q = Convert.ToInt32(row[3]);
                if (Q > 1)
                {
                    Q--;
                    row[3] = Q;

                }
                //else
                //{
                //    ListItemDeleted.Add(dgvReturnItems.CurrentRow.Cells[1].Value.ToString());
                //    row.Delete();
                //}
            }
        }

        // حذف صنف بالكامل
        private void _DeleteItem(int ID)
        {
            DataRow[] ProductDataRow = dtInvoiceDetails.Select("ID = " + ID);

            foreach (var row in ProductDataRow)
            {
                row.Delete();
            }
        }

        private void _UpdateQty(int ID, int NewQty)
        {
            DataRow[] ProductDataRow = dtInvoiceDetails.Select("ID = " + ID);

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
                    frmMessage Message = new frmMessage("الكمية المدخلة غير صحيحة", enTypeIcon.Warring, 2);
                    Message.ShowDialog();
                    return;
                }

                int ID = Convert.ToInt32(dgvReturnItems.CurrentRow.Cells[0].Value);

                _UpdateQty(ID, NewQty);
                Referch(ID);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }

        public bool ReturnItemsToTableProducts(string ProductName)
        {
            int OldQty = GetOldQtyItemByName(ProductName);
            
            return clsProduct.UpdateNewQtyItemByName(ProductName, OldQty);
        }

        public bool ReturnItemsToTableProducts(string ProductName, int UpdateItem)
        {
            int OldQty = GetOldQtyItemByName(ProductName);
            int NewQty = OldQty - UpdateItem;

            if(NewQty > 0 && UpdateItem != 0)
                return clsProduct.UpdateNewQtyItemByName(ProductName, NewQty);
            else
                return false;
        }

        public bool SaveReturnInvoiceDetails(int InvoiceID)
        {
            bool IsFound = false;
            foreach (DataRow row in dtInvoiceReturnsItems.Rows)
            {
                string Name = row["Name"].ToString();
                int ProductID = clsProduct.GetProductIDByName(Name);

                int QtyItem = Convert.ToInt32(row["OldQty"]);
                float TotalPrice = Convert.ToSingle(row["TotalAmount"]);
                IsFound = clsReturnInvoiceDetails.AddNewReturnInvoiceDetails(ProductID, InvoiceID, QtyItem, TotalPrice);
            }
            return IsFound;
        }

        public int SaveReturnInvoice(int InvoiceID, float TotalInvoiceBeforEdit)
        {

            if (clsReturnInvoice.IsExistReturnInvoiceByInvoiceID(InvoiceID))
            {
                //MessageBox.Show("لقد تم استرجاع الفاتورة من قبل");
                clsReturnInvoice.UpdateTotalInvoiceBeforEdit(InvoiceID, TotalInvoiceBeforEdit);
            }
            else
            {

                if (lblCustomerFullNameInvoice.Text != DefaultCustomer)
                {
                    float AmountPaidBeforEdit = Convert.ToSingle(lblAmountPaid.Text);
                    float RemainingAmountBeforEdit = Convert.ToSingle(lblRemainingAmount.Text);
                    return clsReturnInvoice.AddNewReturnInvoice(InvoiceID, clsGlobal.UserID, TotalInvoiceBeforEdit, AmountPaidBeforEdit, RemainingAmountBeforEdit);
                }
                else
                {
                    return clsReturnInvoice.AddNewReturnInvoice(InvoiceID, clsGlobal.UserID, TotalInvoiceBeforEdit);
                }
            }

            return 0;
        }

        public bool UpdateInvoiceDetails(int InvoiceID)
        {
            bool IsFound = false;
            foreach (DataRow row in dtInvoiceDetails.Rows)
            {
                string ProductName = Convert.ToString(row[1]);
                int QtyItem = Convert.ToInt32(row[3]);
                float TotalPriceItems = Convert.ToSingle(row[4]);
                ReturnItemsToTableProducts(ProductName, QtyItem);
                IsFound = clsReturnInvoiceDetails.UpdateInvoiceDetails(InvoiceID, ProductName, QtyItem, TotalPriceItems);
            }

            return IsFound;
        }

        public bool DeleteItemFromInvoiceDetails(int InvoiceID)
        {
            bool IsFound = false;

            foreach (string Item in ListItemDeleted)
            {
                ReturnItemsToTableProducts(Item.ToString());
                IsFound = clsReturnInvoiceDetails.DeleteItemFromInvoiceDetails(InvoiceID, Item.ToString());
            }

            return IsFound;
        }

        public bool UpdateTotalInvoice(int InvoiceID, float TotalInvoiceAfterEdit)
        {
            bool IsFound = false;
           
            IsFound = clsReturnInvoice.UpdateTotalInvoice(InvoiceID, TotalInvoiceAfterEdit);

            return IsFound;
        }
  
        public int UpdateReturnInvoice()
        {
            bool IsFound = false;
            InvoiceID = Convert.ToInt32(lblInvoiceID.Text);

            try
            {
                
                TotalInvoiceBeforEdit = Convert.ToSingle(lblTotalInvoiceBeforEditing.Text);
                TotalInvoiceAfterEdit = Convert.ToSingle(lblTotalInvoiceAfterEditing.Text);

                IsFound = UpdateInvoiceDetails(InvoiceID);

                IsFound = DeleteItemFromInvoiceDetails(InvoiceID);

                IsFound = UpdateTotalInvoice(InvoiceID, TotalInvoiceAfterEdit);

                int ReturnInvoiceID = SaveReturnInvoice(InvoiceID, TotalInvoiceBeforEdit);

                if (lblCustomerFullNameInvoice.Text != DefaultCustomer)
                {
                    float AmountPaidBeforEdit = Convert.ToSingle(lblAmountPaid.Text);
                    float RemainingAmountBeforEdit = Convert.ToSingle(lblRemainingAmount.Text);
                    frmPaymentDebtInvoice paymentAmount = new frmPaymentDebtInvoice(TotalInvoiceBeforEdit, TotalInvoiceAfterEdit, AmountPaidBeforEdit);
                    paymentAmount.ShowDialog();

                    IsFound = clsReturnInvoice.UpdateDebtInvoiceByInvoiceID(InvoiceID, TotalInvoiceAfterEdit, frmPaymentDebtInvoice.TotalAmountPaidAfterEdit, frmPaymentDebtInvoice.RemainingAmountAfterEdit);
                }


               
                if(ReturnInvoiceID > 0)
                {
                    IsFound = SaveReturnInvoiceDetails(ReturnInvoiceID);
                }

                if (IsFound)
                {
                    frmMessage Message = new frmMessage("تم تعديل بيانات الفاتورة بنجاح", enTypeIcon.Success, 2);
                    Message.ShowDialog();

                }
                else
                {
                    frmMessage Message = new frmMessage("لم يتم تعديل بيانات الفاتورة", enTypeIcon.Error, 2);
                    Message.ShowDialog();
                }

            }catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

            return InvoiceID;
        }

        private void _UpdateTotalPriceOfItem(int ID)
        {
            DataRow[] ProductDataRow = dtInvoiceDetails.Select("ID = " + ID);

            foreach (var row in ProductDataRow)
            {
                float Price;
                int Qty;

                Price = Convert.ToSingle(row[2]);
                Qty = Convert.ToInt32(row[3]);

                row[4] = Price * Qty;
            }
        }

        // استرجاع الكمية التي قد تم طلبها العميل من قائمة الطلبات
        private int GetQtyItemByName(string Name)
        {
            DataRow[] ProductDataRow = dtInvoiceDetails.Select("Name = '" + Name + "'");
            foreach (var row in ProductDataRow)
            {
                return Convert.ToInt32(row[3]);
            }

            return -1;
        }


        // استرجاع الكمية التي قد تم طلبها العميل من قائمة الطلبات
        private int GetOldQtyItemByName(string Name)
        {
            DataRow[] ProductDataRow = dtInvoiceReturnsItems.Select("Name = '" + Name + "'");
            foreach (var row in ProductDataRow)
            {
                return Convert.ToInt32(row[2]);
            }

            return 0;
        }

        // ارجاع كم المبلغ المتبقي من الفاتورة سواء باقي للعميل او متبقي عند العميل
        public float RemainingAmountOfInvoice()
        {
            float TotalAmount = 0;

            float TotalInvoiceAfterEdit = Convert.ToSingle(lblTotalInvoiceAfterEditing.Text);
            float TotalInvoiceBeforEdit = Convert.ToSingle(lblTotalInvoiceBeforEditing.Text);

            TotalAmount = TotalInvoiceBeforEdit - TotalInvoiceAfterEdit;
            return TotalAmount;   
        }

        private float GetTotalPriceBeforTax()
        {
            float TotalPrice = 0;

            foreach (DataRow row in dtInvoiceDetails.Rows)
            {
                TotalPrice += Convert.ToSingle(row[4]);
            }

            return TotalPrice;
        }

        private float CalculateTax()
        {
            // Tax Retrive from database after add column Tax
            float totalTax = 0;

            totalTax = GetTotalPriceBeforTax() * (clsSetting.GetTax() / 100);

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

        private void _ShowTotalPrice()
        {
            lblTotalInvoiceAfterEditing.Text = GetTotalPriceFinally().ToString();
            lblTotalRemainingInvoiceAfterEditing.Text = RemainingAmountOfInvoice().ToString();
        }

        public void ShowLastNumberInvoice()
        {
            txtLastNumberInvoices.Text = clsInvoiceSales.GetLastNumberInvoiceSales().ToString();
        }
        private void _Loadding()
        {
            _CreateTableInvoiceDetails("DetailsInvoice", "ReturnItems");
            ShowLastNumberInvoice();
        }

        private void txtInvoiceID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _GetInvoice();
                RenameTableDetails();
            }

        }

        private void frmReturnItems_Load(object sender, EventArgs e)
        {
            _Loadding();
            
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد حذف الفاتورة", "حذف فاتورة", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.OK){

                if (dgvReturnItems.Rows.Count > 0)
                {
                     int InvoiceID = Convert.ToInt32(lblInvoiceID.Text);
                     _DeleteInvoice(InvoiceID);
                     
                }
               
            }
        }

        private void dgvReturnItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvReturnItems.Rows.Count > 0)
            {
                
                _SetDataToFiald();
                
            }
        }

        private void btnMinusQty_Click(object sender, EventArgs e)
        {
            if (dgvReturnItems.SelectedCells.Count > 0)
            {
                ItemID = Convert.ToInt32(dgvReturnItems.CurrentRow.Cells[0].Value);
                _MinusQty(ItemID);
                Referch(ItemID);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReturnItems.SelectedCells.Count > 0)
            {
                ItemID = Convert.ToInt32(dgvReturnItems.CurrentRow.Cells[0].Value);

                string Name = dgvReturnItems.CurrentRow.Cells[1].Value.ToString();
 
                ListItemDeleted.Add(Name);

                _DeleteItem(ItemID);
                Referch(ItemID);
            }
        }

        private void txtQtyItem_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQtyItem.Text) && dgvReturnItems.SelectedCells.Count > 0)
            {

                int NewQty = Convert.ToInt32(txtQtyItem.Text);

                EditQty(NewQty);

            }
        }

        public void ShowFormEditQty()
        {
            try
            {
                if (dgvReturnItems.SelectedCells.Count > 0)
                {
                    frmEditQty Qty = new frmEditQty();
                    Qty.ShowDialog();

                    EditQty(Qty.NewQty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvReturnItems_DoubleClick(object sender, EventArgs e)
        {
            ShowFormEditQty();
        }

        private void tsmiEditQty_Click(object sender, EventArgs e)
        {
            ShowFormEditQty();
        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            _ClearTableItems();
            _ClearTableReturnItems();
            _ClearAllFiald();
        }

        public void PrintInvoice()
        {

        }



        public void UpdateWithPrintCashInvoice()
        {
            float TotalRemainingInvoiceAfterEditing = Convert.ToSingle(lblTotalRemainingInvoiceAfterEditing.Text);
            
              rptReturnCashInvoiceSales.PrintCashReturnInvoiceSales(UpdateReturnInvoice(), TotalRemainingInvoiceAfterEditing);
                  
        }

        public void UpdateWithPrintDebtInvoice()
        {
            rptReturnDebtInvoiceSales.PrintDebtReturnInvoiceSales(UpdateReturnInvoice());
        }

        public void UpdateWithPrint()
        {
            if(lblCustomerFullNameInvoice.Text != DefaultCustomer)
            {
                // print Return Debt invoice
                UpdateWithPrintDebtInvoice();
            }
            else
            {
                // Print Return Cash Invoice
                UpdateWithPrintCashInvoice();
            }

        }

        public void ShowsInvoice()
        {
            frmShowAllInvoices Invoices = new frmShowAllInvoices();
            Invoices.ShowDialog();
            InvoiceID = frmShowAllInvoices.GetInvoiceID();

            if (InvoiceID > 0)
                txtInvoiceID.Text = InvoiceID.ToString();
        }

        public void UpdateNotWithPrint()
        {
            UpdateReturnInvoice();

        }

        private void btnShowsIDFromAllInvoices_Click(object sender, EventArgs e)
        {
            ShowsInvoice();
        }

        private void btnShowAllInvoices_Click(object sender, EventArgs e)
        {
            ShowsInvoice();
        }

        // تعديل فاتورة مرتحع مبيعات بدون طباعة
        private void btnEditInvoiceNotPrint_Click(object sender, EventArgs e)
        {

            if (dgvReturnItems.Rows.Count > 0)
            {
                if (MessageBox.Show("هل تريد تعديل فاتورة المبيعات الحالية", "تعديل فاتورة مبيعات", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.OK)
                {
                    UpdateNotWithPrint();
                    _ClearAllFiald();
                    _ClearTableItems();
                    _ClearTableReturnItems();
                }
            }
        }

        // تعديل فاتورى مرتجع مبيعات مع الطباعة
        private void btnEditInvoiceWithinPrint_Click(object sender, EventArgs e)
        {

            if (dgvReturnItems.Rows.Count > 0)
            {
                if (MessageBox.Show("هل تريد تعديل فاتورة المبيعات الحالية", "تعديل فاتورة مبيعات", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.OK)
                {
                    UpdateWithPrint();
                    _ClearAllFiald();
                    _ClearTableItems();
                    _ClearTableReturnItems();
                }
            }
        }
    }
}
