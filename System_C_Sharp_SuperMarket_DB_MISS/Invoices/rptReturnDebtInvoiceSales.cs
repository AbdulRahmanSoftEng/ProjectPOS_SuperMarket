using Business;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace System_C_Sharp_SuperMarket_DB_MISS.Invoices
{
    public partial class rptReturnDebtInvoiceSales : DevExpress.XtraReports.UI.XtraReport
    {
        public DataTable dt;
        public rptReturnDebtInvoiceSales()
        {
            InitializeComponent();
        }

        public void _PrintDebtInvoiceSalesHeader(int InvoiceID)
        {
            string Title = clsSetting.GetTitleSocke();
            string SubTitle = "فاتورة مرتجع مبيعات";
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
            dt = clsInvoiceSales.GetDebtReturnInvoiceSalesFooter(InvoiceID);
            lblCountItems.DataBindings.Add("Text", dt, "CountItems");

            lblTotalPriceItems.DataBindings.Add("Text", dt, "TotalInvoiceAfterEdit");// يمكن تعديلة بحسب الظريبة
            lblTotalInvoiceAfterEdit.DataBindings.Add("Text", dt, "TotalInvoiceAfterEdit");
            lblTotalInvoiceBeforEdit.DataBindings.Add("Text", dt, "TotalInvoiceReturn");
            lblAmountPaidAfterEdit.DataBindings.Add("Text", dt, "AmountPaid");
            lblRemainingAmountAfterEdit.DataBindings.Add("Text", dt, "RemainingAmount");

            lblQRCodeInvoice.DataBindings.Add("Text", dt, "ID");
            lblUserInvoice.DataBindings.Add("Text", dt, "UserFullName");
            lblDateTimeInvoice.DataBindings.Add("Text", dt, "DateInvoice");
        }

        public static void PrintDebtReturnInvoiceSales(int InvoiceID)
        {
            rptReturnDebtInvoiceSales invoiceSales = new rptReturnDebtInvoiceSales();
            invoiceSales.DataSource = clsInvoiceSalesDetails.GetInvoiceSalesDetails(InvoiceID);
            invoiceSales.DataMember = "Details";

            invoiceSales._PrintDebtInvoiceSalesFooter(InvoiceID);
            invoiceSales._PrintDebtInvoiceSalesDetails();
            invoiceSales._PrintDebtInvoiceSalesHeader(InvoiceID);

            invoiceSales.ShowPreview();

        }

        private void xrLine2_BeforePrint(object sender, CancelEventArgs e)
        {

        }
    }
}
