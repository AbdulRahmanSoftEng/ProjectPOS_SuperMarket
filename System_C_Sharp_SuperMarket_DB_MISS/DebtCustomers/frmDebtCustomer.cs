using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_C_Sharp_SuperMarket_DB_MISS.Invoices;
using System_C_Sharp_SuperMarket_DB_MISS.Shared;

namespace System_C_Sharp_SuperMarket_DB_MISS.DebtCustomers
{
    public partial class frmDebtCustomer : Form
    {
        public string[] MethodeSearch = { "اضهار جميع الفواتير", "بحث باستخدام تاريخين"};

        public int CustomerID { get; set; }

        public frmDebtCustomer(int CustomerID)
        {
            this.CustomerID = CustomerID;
            InitializeComponent();
        }

        public void ShowCalcInvoices(decimal TotalInvoice, decimal AmounPaid, decimal RemainingAmount, int CountInvoices)
        {
            lblSearchTotalInvoices.Text = TotalInvoice.ToString("F2");
            lblSearchAmountPaid.Text = (AmounPaid + clsPayment.GetTotalAmountPaid(CustomerID)).ToString("F2");
            lblSearchRemainingAmount.Text = (RemainingAmount - clsPayment.GetTotalAmountPaid(CustomerID)).ToString("F2");
            lblSearchCountInvoices.Text = CountInvoices.ToString();
        }
      
        public void GetCalculateDGV()
        {
            decimal TotalInvoices = 0, AmountPaid = 0, RemainingAmount = 0;
            int Count = 0;

            if(dgvShowAllDebtInvoiceCustomer.Rows.Count > 0)
            {
                DataTable dt = (DataTable)dgvShowAllDebtInvoiceCustomer.DataSource;

                foreach (DataRow row in dt.Rows)
                {
                    TotalInvoices += Convert.ToDecimal(row[2]);
                    AmountPaid += Convert.ToDecimal(row[3]);
                    RemainingAmount += Convert.ToDecimal(row[4]);
                    Count++;
                }

                ShowCalcInvoices(TotalInvoices, AmountPaid, RemainingAmount, Count);

            }
            else
            {
                ShowCalcInvoices(0, 0, 0, 0);
            }
           
        }
        public void SetTotalInvoices(decimal TotalInvoices)
        {
            lblTotalInvoices.Text = TotalInvoices.ToString("F2");
        }

        public void SetAmountPaidInvoices(decimal AmountPaidInvoices)
        {
            decimal Amount = AmountPaidInvoices +  clsPayment.GetTotalAmountPaid(CustomerID);

            lblAmountPaidInvoices.Text = Amount.ToString("F2");
        }

        public void SetRemainingAmountInvoices(decimal RemainingAmountInvoices)
        {
            decimal Amount = RemainingAmountInvoices - clsPayment.GetTotalAmountPaid(CustomerID);

            lblRemainingAmountInvoices.Text = Amount.ToString("F2");
        }

        public void CalculateDebtInvoices()
        {
            clsDebtCustomer debtCustomer = clsDebtCustomer.FindTotalInvoicesAndAmountPaidAndRemainingAmountInvoices(CustomerID);

            if(debtCustomer != null)
            {
                SetTotalInvoices(debtCustomer.TotalInvoices);
                SetAmountPaidInvoices(debtCustomer.AmountPaidInvoices);
                SetRemainingAmountInvoices(debtCustomer.RemainingAmountInvoices);
            }
        }

        public void ShowCountDebtInvoices()
        {
            lblCountDebtInvoices.Text = clsDebtCustomer.GetCountInvoices(CustomerID).ToString();
        }

        public void SetDataCustomerToFiald(clsCustomer Customer)
        {
            txtFirstName.Text = Customer.FirstName.ToString();
            txtLastName.Text = Customer.LastName.ToString();
            txtPhone.Text = Customer.Phone.ToString();
            txtAddress.Text = Customer.Address.ToString();
        }

        public void ShowAllDebtInvoiceByCustomerID()
        {
            dgvShowAllDebtInvoiceCustomer.DataSource = clsDebtCustomer.GetAllInvoicesByCustomerID(CustomerID);
        }
        
        public void FindCustomerByCustomerID()
        {
            clsCustomer Customer = clsCustomer.FindCustomerByID2(CustomerID);
            
            if(Customer != null)
            {
                SetDataCustomerToFiald(Customer);
            }
        }

        public void FindInvoicesByDateTime()
        {
            DataTable dt = clsDebtCustomer.GetAllInvoicesByCustomerIDAndFromDateToDate(CustomerID, dtpDateInvoiceFrom.Value, dtpDateInvoiceTo.Value);

            if(dt != null) 
                dgvShowAllDebtInvoiceCustomer.DataSource = dt;
        }

        public void _Loadding()
        {
            ShowAllDebtInvoiceByCustomerID();
            FindCustomerByCustomerID();
       
            dtpDateInvoiceFrom.Format = DateTimePickerFormat.Custom;
            dtpDateInvoiceFrom.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            dtpDateInvoiceTo.Format = DateTimePickerFormat.Custom;
            dtpDateInvoiceTo.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            cbMethodSearchInvoices.Items.AddRange(MethodeSearch);
            cbMethodSearchInvoices.SelectedIndex = 0;

            CalculateDebtInvoices();
            ShowCountDebtInvoices();
            GetCalculateDGV();
        }

        public void FindInvoices()
        {

            switch (cbMethodSearchInvoices.SelectedIndex)
            {
                case 0:
                    ShowAllDebtInvoiceByCustomerID();
                    GetCalculateDGV();
                    break;

                case 1:

                    FindInvoicesByDateTime();
                    GetCalculateDGV();
                    break;
            }
        }

        public int AddNewPayments(decimal TotalInvoices, decimal AmountPaid, decimal RemainingAmount, decimal AmountPaidAfter, decimal RemainingAmountAfter)
        {
            int PaymentID = -1;

            clsPayment Payment = new clsPayment();
            Payment.CustomerID = CustomerID;
            Payment.UserID = clsGlobal.UserID;
            Payment.TotalInvoicesBefor = TotalInvoices;
            Payment.TotalAmountPaidBefor = AmountPaid;
            Payment.RemainingAmountBefor = RemainingAmount;
            Payment.AmountPaidAfter = AmountPaidAfter;
            Payment.RemainingAmountAfter = RemainingAmountAfter;

            Payment.CountInvoices = Convert.ToInt32(lblCountDebtInvoices.Text);
            if(Payment != null && frmPaymentDebt.IsPay)
            {
                if ((PaymentID = Payment.AddNewPayments()) != -1)
                {
                    CalculateDebtInvoices();
                    frmMessage Message = new frmMessage("تم الدفع بنجاح", enTypeIcon.Success, 2);
                    Message.ShowDialog();
                    GetCalculateDGV();
                }
                else
                {
                    MessageBox.Show("لم يتم تسديد المبلغ ");
                }
                frmPaymentDebt.IsPay = false;
            }

            return PaymentID;
        }

        private void frmDebtCustomer_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpDateInvoiceFrom_ValueChanged(object sender, EventArgs e)
        {
            FindInvoices();
        }

        private void dtpDateInvoiceTo_ValueChanged(object sender, EventArgs e)
        {
            FindInvoices();
        }

        private void cbMethodSearchInvoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMethodSearchInvoices.SelectedIndex == 0)
            {
                ShowAllDebtInvoiceByCustomerID();
                GetCalculateDGV();
            }
        }

        private void dgvShowAllDebtInvoiceCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (dgvShowAllDebtInvoiceCustomer.Rows.Count > 0)
            {
                int InvoiceID = Convert.ToInt32(dgvShowAllDebtInvoiceCustomer.CurrentRow.Cells[0].Value);
                frmShowInvoiceDetails ShowInvoiceDetails = new frmShowInvoiceDetails(InvoiceID);
                ShowInvoiceDetails.ShowDialog();

            }
        }

        public int AddNew()
        {
            decimal TotalInvoices = Convert.ToDecimal(lblTotalInvoices.Text);
            decimal AmountPaid = Convert.ToDecimal(lblAmountPaidInvoices.Text);
            decimal RemainingAmount = Convert.ToDecimal(lblRemainingAmountInvoices.Text);

            frmPaymentDebt Payment = new frmPaymentDebt(TotalInvoices, AmountPaid, RemainingAmount);
            Payment.ShowDialog();

            return AddNewPayments(TotalInvoices, AmountPaid, RemainingAmount, frmPaymentDebt.AmountPaidAfter, frmPaymentDebt.RemainingAmountAfter);
        }

        private void btnPaymentDebt_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void btnPaymentDebtWithPrint_Click(object sender, EventArgs e)
        {
            int Id = AddNew();

            if (Id != -1)
                rptDebtPaymentInvoice.PrintDebtPayment(Id);
        }
    }
}
