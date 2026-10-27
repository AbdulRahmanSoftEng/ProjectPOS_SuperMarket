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

namespace System_C_Sharp_SuperMarket_DB_MISS.Categories
{
    public partial class AddCategory : Form
    {
        public event EventHandler CategoryChanged;
        private void _Clear()
        {
            txtName.Text = "";
            txtDescription.Text ="";
        }

        private void _ShowCountCategories()
        {
            txtCategoryID.Text = clsCategory.GetCountCategories() != -1 ? Convert.ToString(clsCategory.GetCountCategories()) : "";
        }

        public void NotifyCategoryChanged()
        {
            if(CategoryChanged != null)
            {
                CategoryChanged(this, EventArgs.Empty);
            }
        }
        private void _AddNewCategory()
        {
            clsCategory NewCategory = new clsCategory();

            if (!string.IsNullOrEmpty(txtName.Text))
            {
                NewCategory.Name = txtName.Text;
                NewCategory.Description = txtDescription.Text;

                if (NewCategory.Save())
                {
                    frmMessage Message = new frmMessage("تم الاضافة بنجاح", enTypeIcon.Success, 2);
                    Message.ShowDialog();
                    _Clear();
                    _ShowCountCategories();
                    NotifyCategoryChanged();
                    txtName.Focus();
                }
                else
                {
                    frmMessage Message = new frmMessage("لم يتم اضافة القسم", enTypeIcon.Error, 2);
                    Message.ShowDialog(); 
                }

            }
            else
            {
                frmMessage Message = new frmMessage("قم بكتابة اسم القسم/المجموعة", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
        }

        public AddCategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _AddNewCategory();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            _ShowCountCategories();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _Clear();
        }
    }
}
