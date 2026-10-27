using Business;
using DevExpress.XtraExport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Skins.SolidColorHelper;

namespace System_C_Sharp_SuperMarket_DB_MISS.Cards
{
    public partial class frmCard : UserControl
    {
        public event EventHandler AddToCartClicked = null;
        public frmCard(clsCardInfo CardInfo)
        {
            InitializeComponent();
            btnImageProductCard.Click += (s, e) => AddToCartClicked?.Invoke(this, EventArgs.Empty);

            try
            {
                pnlCard.Tag = CardInfo.Id.ToString();
                btnImageProductCard.Tag = CardInfo.Barcode.ToString();
                lblNameProductCard.Text = CardInfo.Name.ToString();
                lblPriceProductCard.Text = CardInfo.Price.ToString();

                _ShowImage(CardInfo.Image);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public frmCard(int ID, string Barcode,string Name,  float Price, string ImagePath)
        {
            InitializeComponent();
            
            try
            {
                pnlCard.Tag = ID.ToString();
                btnImageProductCard.Tag = Barcode.ToString();
                lblNameProductCard.Text = Name.ToString();
                lblPriceProductCard.Text = Price.ToString();

                _ShowImage(ImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }

        private void _ShowImage(string Path)
        {
            if (Path != "" && !String.IsNullOrWhiteSpace(Path) && Path != null)
            {
                Path = clsShared.DefaultPathImages + "\\" + Path;
                btnImageProductCard.BackgroundImage = Image.FromFile(@Path);
            }
        }

        public int getID()
        {
            return (int)pnlCard.Tag;
        }
     
        public string getBarcode()
        {
            return btnImageProductCard.Tag.ToString();
        }

        public string getName()
        {
            return (string)lblNameProductCard.Text;
        }

        public float getPrice()
        {
            return Convert.ToSingle(lblPriceProductCard.Text);
        }
    }
}
