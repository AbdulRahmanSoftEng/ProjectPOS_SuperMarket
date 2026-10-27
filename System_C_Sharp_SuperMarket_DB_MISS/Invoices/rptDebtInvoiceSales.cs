using Business;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace System_C_Sharp_SuperMarket_DB_MISS.Invoices
{
    public partial class rptDebtInvoiceSales : DevExpress.XtraReports.UI.XtraReport
    {
        public DataTable dt;
        private static int CustomerID;
        public rptDebtInvoiceSales()
        {
            InitializeComponent();
        }

        // طباعة المعلومات الخاصة بالفاتوة في الاعلى
        public void _PrintDebtInvoiceSalesHeader(int InvoiceID)
        {
            string Title = clsSetting.GetTitleSocke();
            string SubTitle = "فاتورة مبيعات";
            lblTitleInvoice.Text = Title.ToString();
            lblSubTitleInvoice.Text = SubTitle.ToString();

            lblNumInvoice.Text = InvoiceID.ToString();
            lblTypeInvoice.DataBindings.Add("Text", dt, "TypeInvoice");
            lblCustomerName.DataBindings.Add("Text", dt, "CustmerFullName");


            xrTableCell1.Text = "اسم الصنف";
            xrTableCell2.Text = "السعر";
            xrTableCell3.Text = "الكمية";
            xrTableCell4.Text = "الاجمالي";
        }

        // طباعة تفاصيل الاصناف المشتراة
        public void _PrintDebtInvoiceSalesDetails()
        {
            lblNameItem.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Name"));
            lblPriceItem.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Price"));
            lblQtyItem.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "QtyItems"));
            lblTotalPriceItem.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "TotalAmount"));
        }

        // طباعة المعلومات الخاصة بالفاتوة في الاسفل
        public void _PrintDebtInvoiceSalesFooter(int InvoiceID)
        {
            dt = clsInvoiceSales.GetDebtInvoiceSalesFooter(InvoiceID);
            lblTotalPriceItems.DataBindings.Add("Text", dt, "TotalInvoice");// يمكن تعديلة بحسب الظريبة
            lblTotalInvoice.DataBindings.Add("Text", dt, "TotalInvoice");
            lblAmountPaid.DataBindings.Add("Text", dt, "AmountPaid");
            lblRemainingAmount.DataBindings.Add("Text", dt, "RemainingAmount");
            lblQRCodeInvoice.DataBindings.Add("Text", dt, "ID");
            lblUserInvoice.DataBindings.Add("Text", dt, "UserFullName");
            lblDateTimeInvoice.DataBindings.Add("Text", dt, "DateInvoice");
            lblCountItems.DataBindings.Add("Text", dt, "CountItems");

            decimal Total = 0;
            Total = clsDebtCustomer.GetTotalRemainingAmountDebtCustomerByCustomerID(CustomerID) - clsDebtCustomer.GetTotalAmountPaidPaymentsByCustomerID(CustomerID);

            lblTotalDebtCustomer.Text = (Total + Convert.ToDecimal(lblRemainingAmount.Text)).ToString("F2");
        }

        public static void PrintDebtInvoiceSales(int InvoiceID, int customerID)
        {
            CustomerID = customerID;
            rptDebtInvoiceSales invoiceSales = new rptDebtInvoiceSales();
            invoiceSales.DataSource = clsInvoiceSalesDetails.GetInvoiceSalesDetails(InvoiceID);
            invoiceSales.DataMember = "Details";

            invoiceSales._PrintDebtInvoiceSalesFooter(InvoiceID);
            invoiceSales._PrintDebtInvoiceSalesDetails();
            invoiceSales._PrintDebtInvoiceSalesHeader(InvoiceID);

            invoiceSales.ShowPreview();

        }

    }
}
