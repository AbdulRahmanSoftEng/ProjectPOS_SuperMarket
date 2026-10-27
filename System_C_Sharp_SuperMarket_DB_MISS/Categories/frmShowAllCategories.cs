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

namespace System_C_Sharp_SuperMarket_DB_MISS.Products
{
    public partial class frmShowAllCategories : frmSharedLayoutTop
    {
        public enum enMode { AddNew, UpdateInfo};
        public enMode Mode;

        public int CategoryID = 1;

        private void _ReadDataFromFalids(ref clsCategory category)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                category.Name = txtName.Text.ToString();
                category.Description = txtDescription.Text.ToString();
                Mode = enMode.AddNew;
                lblTitle.Text = "اضافة قسم جديد";
            }
            else
            {
                frmMessage Message = new frmMessage("قم بملا الحقول الفارغة", enTypeIcon.Warring, 2);
                Message.ShowDialog();
                return;
            }
        }

        private void _SetDataToFalids()
        {
            //CategoryID = (int)dgvShowAllCategories.CurrentRow.Cells[0].Value;
            CategoryID = dgvShowAllCategories.CurrentRow.Cells[0].Value != DBNull.Value ? Convert.ToInt32(dgvShowAllCategories.CurrentRow.Cells[0].Value) : -1;
            txtCategoryID.Text = dgvShowAllCategories.CurrentRow.Cells[0].Value?.ToString();// column ID
            txtName.Text = dgvShowAllCategories.CurrentRow.Cells[1].Value?.ToString();// column Name
            txtDescription.Text = dgvShowAllCategories.CurrentRow.Cells[2].Value?.ToString();// column Description
            Mode = enMode.UpdateInfo;
            lblTitle.Text = "تعديل بيانات قسم";
        }

        private void _ShowAllCategories()
        {
            if (clsCategory.GetAllCategories() != null)
                dgvShowAllCategories.DataSource = clsCategory.GetAllCategories();
        }

        private void _AddNewCategory()
        {
            clsCategory category = new clsCategory();

            _ReadDataFromFalids(ref category);

            if(category != null && !string.IsNullOrEmpty(txtName.Text))
            {
                if(category.Save()){
                    frmMessage Message = new frmMessage("تم الاضافة بنجاح", enTypeIcon.Success, 2);
                    Message.ShowDialog(); 
                    _ShowAllCategories();
                    _Clear();
                }
                else
                {
                    frmMessage Message = new frmMessage("لم تتم اضافة القسم", enTypeIcon.Error, 2);
                    Message.ShowDialog();
                }
            }
        }

        private void _UpdateCategory()
        {
            if(Mode != enMode.AddNew)
            {
                clsCategory category = clsCategory.FindCategoryByID(CategoryID);

                //if (category != null)
                //{
                    category.Name = txtName.Text;
                    category.Description = txtDescription.Text;

                    if (category.Save())
                    {

                        frmMessage Message = new frmMessage("تم التعديل بنجاح", enTypeIcon.Success, 2);
                        Message.ShowDialog(); 
                        _ShowAllCategories();
                        _Clear();
                    }
                    else
                    {
                        frmMessage Message = new frmMessage("لم يتم تعديل معلومات القسم", enTypeIcon.Error, 2);
                        Message.ShowDialog();
                    }
                //}
                //else
                //{
                //    MessageBox.Show("لم يتم العثور على القسم");
                //}
            }            
        }

        // delete category by id
        private void _DeleteCategory(int ID)
        {
            if(clsCategory.CategoryIsExistByID(ID))
            {
                var Result = MessageBox.Show("هل تريد حذف القسم", "حذف قسم", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if(Result == DialogResult.OK)
                {
                    clsCategory.DeleteCategory(ID);
                    frmMessage Message = new frmMessage("تم الحذف بنجاح", enTypeIcon.Success, 2);
                    Message.ShowDialog();
                    _ShowAllCategories();
                    _Clear();
                }
            }
        }

        private void _Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    _AddNewCategory();
                    break;

                case enMode.UpdateInfo:
                    _UpdateCategory();
                    break;
            }
        }

        private void _SearchCategoryUsingLikeByName(string Name)
        {
            if(clsCategory.SearchCategoryUsingLikeByName(Name) != null)
                dgvShowAllCategories.DataSource = clsCategory.SearchCategoryUsingLikeByName(Name);
        }

        private void _Clear()
        {
            txtCategoryID.Text = "???";
            txtName.Text = "";
            txtDescription.Text = "";
            Mode = enMode.AddNew;
            lblTitle.Text = "اضافة قسم جديد";
        }

        private void _Loading()
        {
            _ShowAllCategories();
            txtCategoryID.Text = "???";
            Mode = enMode.AddNew;
        }
        public frmShowAllCategories(string Title)
            :base(Title)
        {
            
            InitializeComponent();
        }


        private void frmShowAllCategories_Load(object sender, EventArgs e)
        {
            _Loading();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void dgvShowAllCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _SetDataToFalids();
        }

        private void dgvShowAllCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _SetDataToFalids();
        }

        private void txtSearchCategories_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchCategories.Text))
                _SearchCategoryUsingLikeByName(txtSearchCategories.Text.Trim());
            else
                _ShowAllCategories();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Search()
        {
            if (!string.IsNullOrEmpty(txtSearchCategories.Text))
                _SearchCategoryUsingLikeByName(txtSearchCategories.Text.Trim());
            else
                _ShowAllCategories();
        }

        public void Delete()
        {
            if (dgvShowAllCategories.SelectedCells.Count > 0)
                _DeleteCategory((int)dgvShowAllCategories.CurrentRow.Cells[0].Value);
            else
            {
                frmMessage Message = new frmMessage("قم باختيار القسم المراد حذفة", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
        }

        public void Update()
        {
            if (dgvShowAllCategories.SelectedCells.Count > 0 && txtCategoryID.Text != "???")
                _Save();
            else
            {
                frmMessage Message = new frmMessage("قم باختيار القسم المراد تعديل بياناته", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           Update();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            Update();

        }

        private void btnSearchCategories_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
