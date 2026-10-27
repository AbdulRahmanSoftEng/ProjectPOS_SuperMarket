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

namespace System_C_Sharp_SuperMarket_DB_MISS.Settings
{
    public partial class frmSetting : frmSharedLayoutTop
    {
        public frmSetting(string Title = "...")
        :base(Title){
            InitializeComponent();
        }

        public clsSetting ReadDataFromFiald()
        {
            clsSetting Setting;
            try
            {
                Setting = new clsSetting();
                Setting.DefaultQuantityDemand = !string.IsNullOrEmpty(txtDefaultQuantityDemand.Text) ? Convert.ToInt32(txtDefaultQuantityDemand.Text) : 0;
                Setting.Tax = !string.IsNullOrEmpty(txtTax.Text) ? Convert.ToInt32(txtTax.Text) : 0;
                Setting.TimeBackUpDB = !string.IsNullOrEmpty(textTimeBackUpDB.Text) ? Convert.ToInt32(textTimeBackUpDB.Text) : 0;
                Setting.TimeWaitingInvoice = !string.IsNullOrEmpty(txtTimeWaitingInvoice.Text) ? Convert.ToInt32(txtTimeWaitingInvoice.Text) : 0;
                Setting.TimeClearFiald = !string.IsNullOrEmpty(txtTimeClearFiald.Text) ? Convert.ToInt32(txtTimeClearFiald.Text) : 0;
                Setting.TimeMsgTasbih = !string.IsNullOrEmpty(txtTimeMsgTasbih.Text) ? Convert.ToInt32(txtTimeMsgTasbih.Text) : 0;

                return Setting;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:"+ ex.Message);
            }
           

            return null;
        }

        public void UpdateBackUpPath()
        {
            Properties.Settings.Default.DefaultBackUpPath = !string.IsNullOrEmpty(txtBackUpPath.Text)? txtBackUpPath.Text: @"C:\";
            Properties.Settings.Default.Save();
        }

        public void Save()
        {
            clsSetting setting = ReadDataFromFiald();

            if (setting != null)
            {
                if (setting.Save())
                {
                    UpdateBackUpPath();
                    MessageBox.Show("تم الحفظ بنجاح");
                    _Loadding();
                }
                else
                {
                    MessageBox.Show("لم يتم الحفظ");
                }
            }
        }

        public void ShowDataToFiald()
        {
            txtDefaultQuantityDemand.Text = clsSetting.GetDefaultQuantityDemand().ToString();
            txtTax.Text = clsSetting.GetTax().ToString();
            txtTimeClearFiald.Text = clsSetting.GetTimeClearFiald().ToString();
            txtTimeMsgTasbih.Text = clsSetting.GetTimeMsgTasbih().ToString();
            txtTimeWaitingInvoice.Text = clsSetting.GetTimeWaitingInvoice().ToString();
            textTimeBackUpDB.Text = clsSetting.GetTimeBackUpDB().ToString();
            txtBackUpPath.Text = Properties.Settings.Default.DefaultBackUpPath.ToString();
        }
        public void _Loadding()
        {
            ShowDataToFiald();
        }
        private void frmSetting_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            Save();
        }

        private string GetBackUpDBPath()
        {
            string Path = "";
            folderBrowserDialog1.ShowNewFolderButton = true;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Path = folderBrowserDialog1.SelectedPath;
            }

            return Path;
        }

        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            txtBackUpPath.Text = GetBackUpDBPath();
        }
    }
}
