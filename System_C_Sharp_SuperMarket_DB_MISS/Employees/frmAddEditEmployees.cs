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

namespace System_C_Sharp_SuperMarket_DB_MISS.Employees
{
    public partial class frmAddEditEmployees : Form
    {
        public enum enMode { AddNew, UpdateInfo};

        public enMode Mode;

        public event EventHandler DataUpdated;

        public int EmployeeID = -1;

        public clsEmployee Employee;

        public void NotifyDataUpdated()
        {
            if (DataUpdated != null)
                DataUpdated(this, EventArgs.Empty);
        }

        public void ReadDataFromFalid(ref clsEmployee Employee)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text.Trim()) &&
                !string.IsNullOrEmpty(txtLastName.Text.Trim()) &&
                !string.IsNullOrEmpty(txtSalary.Text.Trim()))
            {
                Employee.FirstName = txtFirstName.Text;
                Employee.LastName = txtLastName.Text;
                Employee.Phone = txtPhone.Text;

                try
                {
                    if (!string.IsNullOrEmpty(txtSalary.Text.Trim()))
                        Employee.Salary = Convert.ToDecimal(txtSalary.Text);
                    else
                        Employee.Salary = 0;

                    if (!string.IsNullOrEmpty(txtBonusPerc.Text.Trim()))
                        Employee.BonusPerc = Convert.ToDecimal(txtBonusPerc.Text);
                    else
                        Employee.BonusPerc = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هناك خطا في البيانات المدخله");
                }
            }
            else
            {
                frmMessage Message = new frmMessage("يرجا ملا الحقول الفارغة", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }

        }

        private void _AddEmpoyee()
        {
            clsEmployee NewEmployee = new clsEmployee();

            ReadDataFromFalid(ref NewEmployee);

            if (NewEmployee.Save())
            {

                frmMessage Message = new frmMessage("تم الاضافة بنجاح", enTypeIcon.Success, 2);
                Message.ShowDialog();
                NotifyDataUpdated();
                _ClearDataFromFalid();
            }
            else
            {
                frmMessage Message = new frmMessage("لم يتم الاضافة", enTypeIcon.Error, 2);
                Message.ShowDialog();
            }
        }

        private void _UpdateEmployee()
        {
            clsEmployee UpdateEmployee = clsEmployee.FindEmployeeByID(EmployeeID);

            ReadDataFromFalid(ref UpdateEmployee);

            if (UpdateEmployee.Save())
            {
                frmMessage Message = new frmMessage("تم التعديل بنجاح", enTypeIcon.Success, 2);
                Message.ShowDialog();
                NotifyDataUpdated();
                _ClearDataFromFalid();
            }
            else
            {
                frmMessage Message = new frmMessage("لم يتم التعديل", enTypeIcon.Error, 2);
                Message.ShowDialog();
            }
        }

        private void _SaveEmpoyee()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    _AddEmpoyee();
                    break;

                case enMode.UpdateInfo:
                    _UpdateEmployee();
                    break;

                default:
                    // لم يتم تحديد العملية
                    break;
            }
        }

        private void _SetDataToFalid()
        {
            clsEmployee Employee = clsEmployee.FindEmployeeByID(EmployeeID);
            if(Employee != null)
            {
                txtEmployeeID.Text = Employee.ID.ToString();
                txtFirstName.Text = Employee.FirstName.ToString();
                txtLastName.Text = Employee.LastName.ToString();
                txtPhone.Text = Employee.Phone.ToString();
                txtSalary.Text = Employee.Salary.ToString();
                txtBonusPerc.Text = Employee.BonusPerc.ToString();

                lblTitle.Text =$"تعديل بيانات موظف";
                Mode = enMode.UpdateInfo;
            }
            else
            {
                frmMessage Message = new frmMessage($"لايوجد موضف بهاذا الرقم = {EmployeeID}", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
            

        }

        private void _ClearDataFromFalid()
        {
            int ID = clsEmployee.GetLastIDEmployee();
            txtEmployeeID.Text = ID != -1? ID.ToString(): "لايوجد اي موظف";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
            txtBonusPerc.Text = "";
        }

        private void _Loading()
        {
            if (EmployeeID != -1)
                _SetDataToFalid();
            else
                lblTitle.Text = "أضافة موضف جديد";

        }
        public frmAddEditEmployees(int ID)
        {
            InitializeComponent();
            this.EmployeeID = ID;

            if (ID != -1)
                Mode = enMode.UpdateInfo;
            else
                Mode = enMode.AddNew;
        }   

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(txtSalary.Text))
            {
                _SaveEmpoyee();
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

        private void frmAddEditEmployees_Load(object sender, EventArgs e)
        {
            _Loading();
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            _ClearDataFromFalid();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
