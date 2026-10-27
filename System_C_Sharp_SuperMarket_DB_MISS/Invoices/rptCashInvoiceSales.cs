using Business;
using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace System_C_Sharp_SuperMarket_DB_MISS.Invoices
{
    public partial class rptCashInvoiceSales : DevExpress.XtraReports.UI.XtraReport
    {
        public DataTable dt;
        public rptCashInvoiceSales()
        {
            InitializeComponent();
        }

        // طباعة المعلومات الخاصة بالفاتوة في الاعلى
        public void _PrintInvoiceSalesHeader(int InvoiceID)
        {
            string Title = clsSetting.GetTitleSocke();
            string SubTitle = "فاتورة مشتريات";

            lblTitleInvoice.Text = Title.ToString();
            lblSubTitleInvoice.Text = SubTitle.ToString();

            lblNumInvoice.Text = InvoiceID.ToString();
            lblTypeInvoice.DataBindings.Add("Text", dt, "TypeInvoice");

            lblTitleName.Text = "اسم الصنف";
            lblTitlePrice.Text = "السعر";
            lblTitleQty.Text = "الكمية";
            lblTitleTotal.Text = "الاجمالي";
        }


        // طباعة تفاصيل الاصناف المشتراة
        public void _PrintInvoiceSalesDetails()
        {
            lblNameItem.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Name"));
            lblPriceItem.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Price"));
            lblQtyItem.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "QtyItems"));
            lblTotalPriceItem.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "TotalAmount"));
        }

        // طباعة المعلومات الخاصة بالفاتوة في الاسفل
        public void _PrintInvoiceSalesFooter(int InvoiceID)
        {
            dt = clsInvoiceSales.GetCashInvoiceSalesFooter(InvoiceID);
            lblTotalPriceItems.DataBindings.Add("Text", dt, "TotalInvoice");// يمكن تعديلة بحسب الظريبة
            lblTotalFinal.DataBindings.Add("Text", dt, "TotalInvoice");
            lblQRCodeInvoice.DataBindings.Add("Text", dt, "ID");
            lblUserInvoice.DataBindings.Add("Text", dt, "UserFullName");
            lblDateTimeInvoice.DataBindings.Add("Text", dt, "DateInvoice");
            lblCountItems.DataBindings.Add("Text", dt, "CountItems");
            

        }

        public static void PrintCashInvoiceSales(int InvoiceID)
        {

            rptCashInvoiceSales invoiceSales = new rptCashInvoiceSales();
            invoiceSales.DataSource = clsInvoiceSalesDetails.GetInvoiceSalesDetails(InvoiceID);
            invoiceSales.DataMember = "Details";

            invoiceSales._PrintInvoiceSalesFooter(InvoiceID);
            invoiceSales._PrintInvoiceSalesDetails();
            invoiceSales._PrintInvoiceSalesHeader(InvoiceID);

            invoiceSales.ShowPreview();
            invoiceSales.Print();

        }
    }
}
