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

namespace System_C_Sharp_SuperMarket_DB_MISS.Suppliers
{
    public partial class frmAddEditSuppliers : Form
    {
        public enum enMode { AddNew, UpdateInfo };

        public enMode Mode;

        public event EventHandler DataUpdated;

        public int SupplierID = -1;

        public clsSupplier Supplier;

        public void NotifyDataUpdated()
        {
            if (DataUpdated != null)
                DataUpdated(this, EventArgs.Empty);
        }

        public void ReadDataFromFalid(ref clsSupplier Supplier)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text.Trim()) &&
                !string.IsNullOrEmpty(txtLastName.Text.Trim()) &&
                !string.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
               
                try
                {
                    Supplier.FirstName = txtFirstName.Text;
                    Supplier.LastName = txtLastName.Text;
                    Supplier.Address = txtAddress.Text;
                    Supplier.Phone = !string.IsNullOrEmpty(txtPhone.Text) ? txtPhone.Text : "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("هناك خطا في البيانات المدخله"+ ex.Message);
                }
            }
            else
            {
                frmMessage Message = new frmMessage("يرجا ملا الحقول الفارغة", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }

        }

        private void _AddSupplier()
        {
            clsSupplier NewSupplier = new clsSupplier();

            ReadDataFromFalid(ref NewSupplier);

            if (NewSupplier.Save())
            {
                frmMessage Message = new frmMessage("تم الاضافة بنجاح", enTypeIcon.Success, 2);
                Message.ShowDialog();
                NotifyDataUpdated();
                _ClearDataFromFalid();
            }
            else
            {
                frmMessage Message = new frmMessage("لم يتم الاضافة", enTypeIcon.Warring, 2);
                Message.ShowDialog(); 
            }
        }

        private void _UpdateSupplier()
        {
            clsSupplier UpdateSupplier = clsSupplier.FindSupplierByID(SupplierID);

            ReadDataFromFalid(ref UpdateSupplier);

            if (UpdateSupplier.Save())
            {

                frmMessage Message = new frmMessage("تم التعديل بنجاح", enTypeIcon.Success, 2);
                Message.ShowDialog();
                NotifyDataUpdated();
                _ClearDataFromFalid();
            }
            else
            {
                frmMessage Message = new frmMessage("لم يتم التعديل", enTypeIcon.Warring, 2);
                Message.ShowDialog();            
            }
        }

        private void _SaveSupplier()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    _AddSupplier();
                    break;

                case enMode.UpdateInfo:
                    _UpdateSupplier();
                    break;

                default:
                    // لم يتم تحديد العملية
                    break;
            }
        }

        private void _SetDataToFalid()
        {
            clsSupplier Supplier = clsSupplier.FindSupplierByID(SupplierID);

            if (Supplier != null)
            {
                txtSupplierID.Text = Supplier.ID.ToString();
                txtFirstName.Text = Supplier.FirstName;
                txtLastName.Text = Supplier.LastName;
                txtPhone.Text = Supplier.Phone;
                txtAddress.Text = Supplier.Address;

                lblTitle.Text = $"تعديل بيانات مورد";
                Mode = enMode.UpdateInfo;
            }
            else
            {
                frmMessage Message = new frmMessage($"لايوجد مورد بهاذا الرقم = {SupplierID}", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }


        }

        private void _ClearDataFromFalid()
        {
            int ID = clsSupplier.GetLastSuppliersID();
            txtSupplierID.Text = ID != -1? ID.ToString(): "لايوجد اي مورد";
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        private void _Loading()
        {
            if (SupplierID != -1)
                _SetDataToFalid();
            else
                lblTitle.Text = "أضافة مورد جديد";

        }
        public frmAddEditSuppliers(int ID)
        {
            InitializeComponent();
            this.SupplierID = ID;

            if (ID != -1)
                Mode = enMode.UpdateInfo;
            else
                Mode = enMode.AddNew;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(txtAddress.Text))
            {
                _SaveSupplier();
            }
            else
            {
                frmMessage Message = new frmMessage("قم بملا الحقول الفارغة ", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _ClearDataFromFalid();
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            _ClearDataFromFalid();
        }

        private void frmAddEditSuppliers_Load(object sender, EventArgs e)
        {
            _Loading();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
