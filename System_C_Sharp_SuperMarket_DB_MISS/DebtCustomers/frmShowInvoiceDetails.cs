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

namespace System_C_Sharp_SuperMarket_DB_MISS.DebtCustomers
{
    public partial class frmShowInvoiceDetails : Form
    {
        public int InvoiceID;
        public frmShowInvoiceDetails(int InvoiceID)
        {
            InitializeComponent();
            this.InvoiceID = InvoiceID;
        }

        public void ShowInvoiceDetails()
        {
            DataTable dt = clsInvoiceSalesDetails.GetInvoiceSalesDetails(InvoiceID);
            if (dt != null)
            {
                dgvShowInvoiceDetails.DataSource = dt;
            }
        }

        public void ShowInvoice()
        {
            DataTable dt = clsInvoiceSales.GetDebtInvoiceSalesFooter(InvoiceID);
            //select Invoices.ID, (select Sum(QtyItems) from InvoiceDetails where InvoiceID = @InvoiceID) as CountItems,  Invoices.TotalInvoice, FORMAT(Invoices.DateInvoice, 'dd/MM/yyyy - hh:mm:ss tt') AS DateInvoice,  uPersons.FirstName +' '+uPersons.LastName As UserFullName, TypeInvoices.Name as TypeInvoice, DebtInvoices.AmountPaid, DebtInvoices.RemainingAmount, cPersons.FirstName +' '+cPersons.LastName as CustmerFullName

            foreach (DataRow row in dt.Rows)
            {
                lblCustomerFullName.Text = row["CustmerFullName"].ToString();
                lblUserFullName.Text = row["UserFullName"].ToString();
                lblInvoiceID.Text = row["ID"].ToString();
                lblCountItems.Text = row["CountItems"].ToString();
                lblDateTimeInvoices.Text = row["DateInvoice"].ToString();
                lblTotalInvoice.Text = row["TotalInvoice"].ToString();
                lblAmountPaid.Text = row["AmountPaid"].ToString();
                lblRemainingAmount.Text = row["RemainingAmount"].ToString();
            }
           
        }

        public void RenameColumns()
        {
            dgvShowInvoiceDetails.Columns[0].HeaderText = "اسم_الصنف";
            dgvShowInvoiceDetails.Columns[1].HeaderText = "السعر";
            dgvShowInvoiceDetails.Columns[2].HeaderText = "الكمية";
            dgvShowInvoiceDetails.Columns[3].HeaderText = "الاجمالي";


            dgvShowInvoiceDetails.Columns[0].Width = 130;
        }
        public void _Loadding()
        {
            ShowInvoiceDetails();
            ShowInvoice();
            RenameColumns();

        }

        private void frmShowInvoiceDetails_Load(object sender, EventArgs e)
        {
            _Loadding();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
