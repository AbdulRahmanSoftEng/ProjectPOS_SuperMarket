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

namespace System_C_Sharp_SuperMarket_DB_MISS.Customers
{
    public partial class frmAddEditCustomers : Form
    {
        public enum enMode { AddNew, UpdateInfo };

        public enMode Mode;

        public event EventHandler DataUpdated;

        public int CustomerID = -1;

        public clsCustomer Customer;

        public void NotifyDataUpdated()
        {
            if (DataUpdated != null)
                DataUpdated(this, EventArgs.Empty);
        }

        public void ReadDataFromFalid(ref clsCustomer Customer)
        {
               
            try
            {
                Customer.FirstName = txtFirstName.Text;
                Customer.LastName = txtLastName.Text;
                Customer.Phone = !string.IsNullOrEmpty(txtPhone.Text) ? txtPhone.Text : "";
                Customer.Address = txtAddress.Text;
                
            
            }catch (Exception ex)
            {

                frmMessage Message = new frmMessage("هناك خطا في البيانات المدخله", enTypeIcon.Error, 2);
                Message.ShowDialog();
                return;
            }
               
        }

        private void _AddCustomer()
        {
            clsCustomer NewCustomer = new clsCustomer();

            ReadDataFromFalid(ref NewCustomer);
 
            if(NewCustomer != null)
            {
                if (NewCustomer.Save())
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
        }

        private void _UpdateCustomer()
        {
            clsCustomer UpdatecCustomer = clsCustomer.FindCustomerByID(CustomerID);

            ReadDataFromFalid(ref UpdatecCustomer);

            if(!string.IsNullOrEmpty(txtCustomerID.Text))
            {
                if (UpdatecCustomer.Save())
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
        }

        private void _SaveCustomer()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    _AddCustomer();
                    break;

                case enMode.UpdateInfo:
                    _UpdateCustomer();
                    break;

                default:
                    // لم يتم تحديد العملية
                    break;
            }
        }

        private void _SetDataToFalid()
        {
            clsCustomer Customer = clsCustomer.FindCustomerByID(CustomerID);
            if (Customer != null)
            {
                txtCustomerID.Text = Customer.ID.ToString();
                txtFirstName.Text = Customer.FirstName.ToString();
                txtLastName.Text = Customer.LastName.ToString();
                txtPhone.Text = Customer.Phone.ToString();

                txtAddress.Text = Customer.Address.ToString();

                //cbTypeCustomer.SelectedIndex = cbTypeCustomer.FindString(clsCustomer.FindTypeCustomerByID(Customer.TypeCustomer));

                lblTitle.Text = $"تعديل بيانات عميل";
                Mode = enMode.UpdateInfo;
            }
            else
            {
                MessageBox.Show($"لايوجد عميل بهاذا الرقم = {CustomerID}");
            }
        }

     
        private void _ClearDataFromFalid()
        {
            int ID = clsCustomer.GetLastIDCustomer();
            txtCustomerID.Text = ID != -1? ID.ToString(): "لايوجد اي عميل";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }

        private void _Loading()
        {
            try
            {
                if (CustomerID != -1)
                    _SetDataToFalid();
                else
                    lblTitle.Text = "أضافة عميل جديد";
            }
            catch(Exception ex)
            {

            }
           

        }
        public frmAddEditCustomers(int ID)
        {
            InitializeComponent();
            this.CustomerID = ID;

            if (ID != -1)
                Mode = enMode.UpdateInfo;
            else
                Mode = enMode.AddNew;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(txtAddress.Text))
            {
                _SaveCustomer();

            }
            else
            {

                frmMessage Message = new frmMessage("قم بملا الحقول الفارغة", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            _ClearDataFromFalid();
        }

        private void frmAddEditCustomers_Load(object sender, EventArgs e)
        {
            _Loading();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
