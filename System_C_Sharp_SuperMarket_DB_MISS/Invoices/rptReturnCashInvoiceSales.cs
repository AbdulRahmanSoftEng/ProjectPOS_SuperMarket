using Business;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace System_C_Sharp_SuperMarket_DB_MISS.Invoices
{
    public partial class rptReturnCashInvoiceSales : DevExpress.XtraReports.UI.XtraReport
    {
        public DataTable dt;
        public static float RemainingAmountCash;
        public rptReturnCashInvoiceSales()
        {
            InitializeComponent();
        }

        public void _PrintCashInvoiceSalesHeader(int InvoiceID)
        {
            string Title = clsSetting.GetTitleSocke();
            string SubTitle = "فاتورة مرتجع مبيعات";
            lblTitleInvoice.Text = Title.ToString();
            lblSubTitleInvoice.Text = SubTitle.ToString();

            lblNumInvoice.Text = InvoiceID.ToString();
            lblTypeInvoice.DataBindings.Add("Text", dt, "TypeInvoice");


            xrTableCell1.Text = "اسم الصنف";
            xrTableCell2.Text = "السعر";
            xrTableCell3.Text = "الكمية";
            xrTableCell4.Text = "الاجمالي";
        }

        // طباعة تفاصيل الاصناف المشتراة
        public void _PrintCashInvoiceSalesDetails()
        {
            lblNameItem.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Name"));
            lblPriceItem.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Price"));
            lblQtyItem.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "QtyItems"));
            lblTotalPriceItem.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "TotalAmount"));
        }

        // طباعة المعلومات الخاصة بالفاتوة في الاسفل
        public void _PrintCashInvoiceSalesFooter(int InvoiceID)
        {
            dt = clsInvoiceSales.GetCashReturnInvoiceSalesFooter(InvoiceID);
            lblCountItems.DataBindings.Add("Text", dt, "CountItems");
            lblTotalPriceItems.DataBindings.Add("Text", dt, "TotalInvoiceAfterEdit");// يمكن تعديلة بحسب الظريبة
            lblTotalInvoiceAfterEdit.DataBindings.Add("Text", dt, "TotalInvoiceAfterEdit");
            lblTotalInvoiceBeforEdit.DataBindings.Add("Text", dt, "TotalInvoiceReturn");
            lblRemainingAmount.Text = RemainingAmountCash.ToString();
            lblQRCodeInvoice.DataBindings.Add("Text", dt, "ID");
            lblUserInvoice.DataBindings.Add("Text", dt, "UserFullName");
            lblDateTimeInvoice.DataBindings.Add("Text", dt, "DateInvoice");
        }

        public static void PrintCashReturnInvoiceSales(int InvoiceID, float remainingAmountCash)
        {
            RemainingAmountCash = remainingAmountCash;
            rptReturnCashInvoiceSales invoiceSales = new rptReturnCashInvoiceSales();
            invoiceSales.DataSource = clsInvoiceSalesDetails.GetInvoiceSalesDetails(InvoiceID);
            invoiceSales.DataMember = "Details";

            invoiceSales._PrintCashInvoiceSalesFooter(InvoiceID);
            invoiceSales._PrintCashInvoiceSalesDetails();
            invoiceSales._PrintCashInvoiceSalesHeader(InvoiceID);

            invoiceSales.ShowPreview();

        }
    }
}
