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
    public partial class frmProfileStock : frmSharedLayoutTop
    {
        public frmProfileStock(string Title = "...")
        :base(Title)
        {
            InitializeComponent();
        }

        private void _BrowserImage()
        {

            openFileDialog1.Title = "اختيار صورة";
            openFileDialog1.Filter = "أنواع الصور|*.png;*.jpg;*.jpeg;*.gif;*.bmp;*.tiff;*.ico;*.jfif;*.webp;";
            openFileDialog1.DefaultExt = @"C:\";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbLogo.ImageLocation = openFileDialog1.FileName;
                btnRemoveImage.Visible = true;
            }
        }

        public void ClearAllFiald()
        {
            txtTitleStock.Clear();
            txtOwner.Clear();
            txtCity.Clear();
            txtStreet.Clear();
            txtInFrontOfStock.Clear();
            txtLocationMap.Clear();
            txtWebSite.Clear();
            pbLogo.ImageLocation = "";

        }

        public void SetDataToFiald()
        {
            txtID.Text = dgvProfileStock.CurrentRow.Cells[0].Value.ToString();
            txtTitleStock.Text = dgvProfileStock.CurrentRow.Cells[1].Value.ToString();
            txtOwner.Text = dgvProfileStock.CurrentRow.Cells[2].Value.ToString();
            txtCity.Text = dgvProfileStock.CurrentRow.Cells[3].Value.ToString();
            txtStreet.Text = dgvProfileStock.CurrentRow.Cells[4].Value.ToString();
            txtInFrontOfStock.Text = dgvProfileStock.CurrentRow.Cells[5].Value.ToString();
            txtLocationMap.Text = dgvProfileStock.CurrentRow.Cells[6].Value.ToString();
            txtWebSite.Text = dgvProfileStock.CurrentRow.Cells[7].Value.ToString();
            
            if (dgvProfileStock.CurrentRow.Cells[8].Value != null)
            {
                pbLogo.ImageLocation = clsShared.DefaultPathImages + "\\" + dgvProfileStock.CurrentRow.Cells[8].Value.ToString();
            }
        }

        public void ShowProfileStock()
        {
            dgvProfileStock.DataSource = clsProfileStock.GetInfoProfileStock();
        }

        public void _Loadding()
        {
            ShowProfileStock();

            if(dgvProfileStock.Rows.Count > 0)
            {
                btnAdd.Enabled = false;
            }

        }

        public void ReadDataFromFiald(ref clsProfileStock Profile)
        {
            Profile.Title = txtTitleStock.Text;
            Profile.Owner = txtOwner.Text;
            Profile.City = txtCity.Text;
            Profile.Street = txtStreet.Text;
            Profile.InFrontOfStock = txtInFrontOfStock.Text;
            Profile.Location = txtLocationMap.Text;
            Profile.WebSite = txtWebSite.Text;

            if (!string.IsNullOrEmpty(pbLogo.ImageLocation))
                Profile.Logo = pbLogo.ImageLocation;
            else
                Profile.Logo = "";

        }

        public void AddInfoProfileStock()
        {
            clsProfileStock Profile = new clsProfileStock();

            ReadDataFromFiald(ref Profile);
            if(Profile != null)
            {
                if(Profile.Save())
                {
                    MessageBox.Show("تم الحفظ بنجاح");
                    ShowProfileStock();
                    ClearAllFiald();
                }
                else
                {
                    MessageBox.Show("لم يتم الحفظ");

                }
            }
        }

        public void UpdateInfoProfileStock(int ID)
        {
            clsProfileStock Profile = clsProfileStock.FindProfileStock(ID);
            

            if (Profile != null)
            {
                ReadDataFromFiald(ref Profile);
                if (Profile.Save())
                {
                    MessageBox.Show("تم التعديل بنجاح");
                    ShowProfileStock();
                    ClearAllFiald();
                }
                else
                {
                    MessageBox.Show("لم يتم التعديل");

                }
            }
            else
            {
                MessageBox.Show("لايوجد اي بيانات");
            }
        }
        private void frmProfileStock_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            _BrowserImage(); 
        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddInfoProfileStock();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                UpdateInfoProfileStock(Convert.ToInt32(txtID.Text));
            }
            
        }

        private void dgvProfileStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            SetDataToFiald();
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbLogo.ImageLocation = "";
            btnRemoveImage.Visible = false;
        }
    }
}
