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
    public partial class frmCreateBackUpDB : frmSharedLayoutTop
    {
        public frmCreateBackUpDB(string Title = "...")
        :base(Title)
        {
            InitializeComponent();
        }

        private string GetBackUpDBPath()
        {
            string Path = "";
            folderBrowserDialog1.ShowNewFolderButton = true;
 
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Path = folderBrowserDialog1.SelectedPath;
            }

            return Path;
        }

        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            txtBackUpPath.Text = GetBackUpDBPath();
        }

        private void btnSaveBackUpDB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBackUpPath.Text))
            {
                if (clsSetting.BackUpDatabase(txtBackUpPath.Text.Trim()))
                {
                    MessageBox.Show("تم اضافة نسخة احطياطية بنجاح");
                    
                }
                else
                {
                    MessageBox.Show("لم يتم اضافة النسخة الاحطياطية هنالك مشكلة");
                }
            }
            else
            {
                MessageBox.Show("قم باختيار مسار النسخة الاحطياطية");
            }
        }

    }
}
