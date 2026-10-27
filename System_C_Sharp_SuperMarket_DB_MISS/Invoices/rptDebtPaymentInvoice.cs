using Business;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace System_C_Sharp_SuperMarket_DB_MISS.Invoices
{
    public partial class rptDebtPaymentInvoice : DevExpress.XtraReports.UI.XtraReport
    {
        public clsPayment Payment;
        public rptDebtPaymentInvoice()
        {
            InitializeComponent();
        }

        // طباعة المعلومات الخاصة بالفاتوة في الاعلى
        public void _PrintInvoiceDebtPaymentHeader(int InvoiceID)
        {
            string Title = clsSetting.GetTitleSocke();
            string SubTitle = "فاتورة سداد ديون";

            lblTitleInvoice.Text = Title.ToString();
            lblSubTitleInvoice.Text = SubTitle.ToString();

            lblNumInvoice.Text = InvoiceID.ToString();
            lblTypeInvoice.Text = "دفع مالي";

            lblCustomerName.Text = Payment.CustomerFullName.ToString();
        }

        // طباعة المعلومات الخاصة بالفاتوة في الاسفل
        public void _PrintInvoiceDebtPaymentFooter(int InvoiceID)
        {
            Payment = clsPayment.GetDebtPaymentDetails(InvoiceID);

            lblCountInvoices.Text = Payment.CountInvoices.ToString();

            lblTotalInvoices.Text = Payment.TotalInvoicesBefor.ToString();
            lblAmountPaidBefor.Text = Payment.TotalAmountPaidBefor.ToString();
            lblRemainingAmountBefor.Text = Payment.RemainingAmountBefor.ToString();
            lblAmountPaidAfter.Text = Payment.AmountPaidAfter.ToString();
            lblTotalInvoicesFinal.Text = Payment.RemainingAmountAfter.ToString();

            lblQRCodeInvoice.Text = Payment.PaymentID.ToString();
            lblUserInvoice.Text = Payment.UserFullName.ToString();
            lblDateTimeInvoice.Text = Payment.DateTimePayment.ToString("dd/MM/yyyy - hh:mm:ss tt");
        }

        public static void PrintDebtPayment(int InvoiceID)
        {

            rptDebtPaymentInvoice invoiceSales = new rptDebtPaymentInvoice();

            invoiceSales._PrintInvoiceDebtPaymentFooter(InvoiceID);
            invoiceSales._PrintInvoiceDebtPaymentHeader(InvoiceID);

            invoiceSales.ShowPreview();

        }
    }
}
