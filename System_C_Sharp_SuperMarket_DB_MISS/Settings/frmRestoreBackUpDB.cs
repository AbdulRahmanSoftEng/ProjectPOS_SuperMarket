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
    public partial class frmRestoreBackUpDB : frmSharedLayoutTop
    {
        public frmRestoreBackUpDB(string Title = "...")
        : base(Title)
        {
            InitializeComponent();
        }

        private string GetRestorDBPath()
        {
            string restorDBPath = "";
            openFileDialog1.Title = "اختيار النسخة الاحطياطة";
            openFileDialog1.Filter = "نوع الملف |*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                restorDBPath = openFileDialog1.FileName;
            }

            return restorDBPath;
        }

        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            txtBackUpPath.Text = GetRestorDBPath();
        }

        private void btnSaveBackUpDB_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtBackUpPath.Text))
            {
                if (clsSetting.RestoreDatabase(txtBackUpPath.Text.Trim()))
                {
                    MessageBox.Show("تم استعادة النسخة الاحطياطية بنجاح");

                }
                else
                {
                    MessageBox.Show("لم يتم استعادة النسخة الاحطياطية هنالك مشكلة");
                }
            }
            else
            {
                MessageBox.Show("قم باختيار مسار النسخة الاحطياطية");
            }
           
        }
    }
}
