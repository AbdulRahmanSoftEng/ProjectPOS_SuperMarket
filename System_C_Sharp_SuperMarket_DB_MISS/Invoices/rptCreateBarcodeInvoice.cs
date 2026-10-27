using Business;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace System_C_Sharp_SuperMarket_DB_MISS.Invoices
{
    public partial class rptCreateBarcodeInvoice : DevExpress.XtraReports.UI.XtraReport
    {

        public string Barcode { get; set; }
        public string ProductName { get; set; }
        public int PrintQty { get; set; }

        public rptCreateBarcodeInvoice()
        {
            InitializeComponent();
        }

        public void PrintBarcodes(string Name, string Barcode)
        {
            lblProductName.Text = Name.ToString();
            lblBarcode.Text = Barcode.ToString();
        }

        public static void PrintInvoices(clsProductBarcode ProductBarcode)
        {
            rptCreateBarcodeInvoice Barcode = new rptCreateBarcodeInvoice();

            Barcode.PrintBarcodes(ProductBarcode.ProductName, ProductBarcode.Barcode);
            Barcode.ShowPreview();

        }
    }
}
