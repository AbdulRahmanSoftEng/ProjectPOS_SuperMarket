namespace System_C_Sharp_SuperMarket_DB_MISS.Invoices
{
    partial class rptCreateBarcodeInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            DevExpress.XtraReports.UI.XRWatermark xrWatermark1 = new DevExpress.XtraReports.UI.XRWatermark();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.lblBarcode = new DevExpress.XtraReports.UI.XRBarCode();
            this.lblProductName = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 10F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 32.70007F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 289.0333F;
            this.Detail.HierarchyPrintOptions.Indent = 50.8F;
            this.Detail.Name = "Detail";
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.BorderWidth = 1.5F;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblBarcode,
            this.lblProductName});
            this.xrPanel1.Dpi = 254F;
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.xrPanel1.SizeF = new System.Drawing.SizeF(580F, 251.3332F);
            this.xrPanel1.StylePriority.UseBorders = false;
            this.xrPanel1.StylePriority.UseBorderWidth = false;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoModule = true;
            this.lblBarcode.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblBarcode.Dpi = 254F;
            this.lblBarcode.LocationFloat = new DevExpress.Utils.PointFloat(24.99999F, 85.93665F);
            this.lblBarcode.Module = 5.08F;
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Padding = new DevExpress.XtraPrinting.PaddingInfo(26, 26, 0, 0, 254F);
            this.lblBarcode.SizeF = new System.Drawing.SizeF(530F, 153.3833F);
            this.lblBarcode.StylePriority.UseBorders = false;
            this.lblBarcode.StylePriority.UseTextAlignment = false;
            this.lblBarcode.Symbology = code128Generator1;
            this.lblBarcode.Text = "454654565465445";
            this.lblBarcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblProductName.Dpi = 254F;
            this.lblProductName.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblProductName.LocationFloat = new DevExpress.Utils.PointFloat(10.58329F, 14.81667F);
            this.lblProductName.Multiline = true;
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblProductName.SizeF = new System.Drawing.SizeF(555F, 58.42F);
            this.lblProductName.StylePriority.UseBorders = false;
            this.lblProductName.StylePriority.UseFont = false;
            this.lblProductName.StylePriority.UseTextAlignment = false;
            this.lblProductName.Text = "كيك صنعاني  100 جرام";
            this.lblProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // rptCreateBarcode
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Dpi = 254F;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(9F, 9F, 10F, 32.70007F);
            this.PageHeight = 295;
            this.PageWidth = 599;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.RollPaper = true;
            this.SnapGridSize = 25F;
            this.Version = "24.1";
            xrWatermark1.Id = "Watermark1";
            this.Watermarks.AddRange(new DevExpress.XtraPrinting.Drawing.Watermark[] {
            xrWatermark1});
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRBarCode lblBarcode;
        private DevExpress.XtraReports.UI.XRLabel lblProductName;
    }
}
