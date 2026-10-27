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

namespace System_C_Sharp_SuperMarket_DB_MISS.Products.ReturnInvoice
{
    public partial class frmShowAllInvoices : Form
    {
        public static int InvoiceID = 0;

        public frmShowAllInvoices()
        {
            InitializeComponent();
        }

        public static int GetInvoiceID()
        {
            return InvoiceID;
        }

        public void ShowAllInvoices()
        {
            DataTable dt = clsInvoiceSales.GetAllInvoices();
            if (dt.Rows.Count > 0)
                dgvShowAllInvoices.DataSource = dt;
        }
        
        public void ShowAllInvoicesByDateTime(DateTime startDate, DateTime endDate)
        {
            if (dgvShowAllInvoices.Rows.Count > 0)
                dgvShowAllInvoices.DataSource = clsInvoiceSales.GetAllInvoicesByDateTime(startDate, endDate);
            else
                ShowAllInvoices();
        }
        
        public void ShowAllInvoicesByTotalInvoice(string TotalInvoice)
        {
            try
            {
                float Total = Convert.ToSingle(TotalInvoice);
                DataTable dt = clsInvoiceSales.GetAllInvoicesByTotalInvoice(Total);
                if (dt.Rows.Count > 0)
                    dgvShowAllInvoices.DataSource = dt;

            } catch (Exception ex)
            {
                frmMessage Message = new frmMessage("قم بادخال ارقام وليس احرف او رموز", enTypeIcon.Error, 2);
                Message.ShowDialog();
            }
           
        }

        public void _Loadding()
        {
            ShowAllInvoices();

            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yyyy hh:mm:ss";//12/01/2025 10:33:44

        }

        private void frmShowAllInvoices_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void dgvShowAllInvoices_Click(object sender, EventArgs e)
        {
            if (dgvShowAllInvoices.Rows.Count > 0) {
                InvoiceID = Convert.ToInt32(dgvShowAllInvoices.CurrentRow.Cells[0].Value);
                this.Close();
            }
        }

        private void dtpDateTimeInvoices_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpDate.Value.Date;
            DateTime endDate = startDate.AddDays(1).AddSeconds(-1);

            ShowAllInvoicesByDateTime(startDate, endDate);

        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtTotalInvoice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotalInvoice.Text))
                ShowAllInvoicesByTotalInvoice(txtTotalInvoice.Text);
            else
                ShowAllInvoices();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
