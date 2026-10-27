using Business;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace System_C_Sharp_SuperMarket_DB_MISS.Invoices
{
    public partial class rptInvoicPuy : DevExpress.XtraReports.UI.XtraReport
    {
        public DataTable dt;
        public rptInvoicPuy()
        {
            InitializeComponent();
        }

       
        // طباعة المعلومات الخاصة بالفاتوة في الاعلى
        public void _PrintInvoicePuyHeader(int InvoiceID)
        {
            string Title = clsSetting.GetTitleSocke();
            string SubTitle = "فاتورة مشتريات";

            lblTitleInvoice.Text = Title.ToString();
            lblSubTitleInvoice.Text = SubTitle.ToString();

            lblNumInvoice.Text = InvoiceID.ToString();
            lblSupplierName.DataBindings.Add("Text", dt, "SupplierFullName");

            lblTitleName.Text = "اسم الصنف";
            lblTitleQtyUnit.Text = "بالحبة";
            lblTitleQtyGroup.Text = "بالدرزن";
            lblTitleNotes.Text = "ملاحظة";
        }

        // طباعة تفاصيل الاصناف المباعة
        public void _PrintInvoicePuyDetails()
        {
            // هذة الخصائص هية خاصة بفاتورة المبيعات ولاكن اعدنا استخدامها في عرض تفاصيل فاتورة المشتريات
            lblNameItem.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Name"));
            lblQtyUnit.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "QtyUnit"));
            lblQtyGroup.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "QtyGroup"));
            lblNotes.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Notes"));
        }

        // طباعة المعلومات الخاصة بالفاتوة في الاسفل
        public void _PrintInvoicePuyFooter(int InvoiceID)
        {

            dt = clsInvoicePuy.GetInvoicePuyFooter(InvoiceID);
            lblQRCodeInvoice.DataBindings.Add("Text", dt, "ID");
            lblUserInvoice.DataBindings.Add("Text", dt, "UserFullName");
            lblDateTimeInvoice.DataBindings.Add("Text", dt, "DateTimeInvoice");           

        }

        public static void PrintInvoicePuy(int InvoiceID)
        {

            rptInvoicPuy invoicePuy = new rptInvoicPuy();
            invoicePuy.DataSource = clsInvoicePuyDetails.GetInvoicePuyDetails(InvoiceID);
            invoicePuy.DataMember = "Details";

            invoicePuy._PrintInvoicePuyFooter(InvoiceID);
            invoicePuy._PrintInvoicePuyDetails();
            invoicePuy._PrintInvoicePuyHeader(InvoiceID);

            invoicePuy.ShowPreview();

        }
    }
}
