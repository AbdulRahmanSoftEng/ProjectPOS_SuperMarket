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
    public partial class frmShowAllEmployees : frmSharedLayoutTop
    {
        frmAddEditEmployees AddEditEmployee;

        private void _AddNewEmployee()
        {
            AddEditEmployee = new frmAddEditEmployees(-1);
            AddEditEmployee.DataUpdated += frmShowAllEmployees_Load;
            AddEditEmployee.ShowDialog();
        }

        private void _ShowAllEmployees()
        {
            if (clsEmployee.GetAllEmployees() != null)
                dgvShowEmployees.DataSource = clsEmployee.GetAllEmployees();
        }

        private void _EditRowEmployee(int ID)
        {
            AddEditEmployee = new frmAddEditEmployees(ID);
            AddEditEmployee.DataUpdated += frmShowAllEmployees_Load;
            AddEditEmployee.ShowDialog();
        }

        private void _DeleteRowEmployee(int ID)
        {
            if (clsEmployee.EmployeeIsExistByID(ID))
            {
                var Result = MessageBox.Show("هل تريد حذف الموظف ", "حذف موظف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if(Result == DialogResult.OK)
                {
                    clsEmployee.DeleteEmployeeByID(ID);
                    frmMessage Message = new frmMessage("تم حذف الموظف بنجاح", enTypeIcon.Success, 2);
                    Message.ShowDialog();
                    AddEditEmployee.NotifyDataUpdated();
                }
            }
            else
            {
                frmMessage Message = new frmMessage("لم يتم حذف الموظف", enTypeIcon.Error, 2);
                Message.ShowDialog();
            }

        }
 
        private void _SearchEmployeesUsingLike(string Name)
        {
            dgvShowEmployees.DataSource = clsEmployee.FindEmployeeByNameUsingLike(Name);
        }

        public void ShowCountEmployees()
        {
            lblCountEmployees.Text = clsEmployee.GetCountEmployees().ToString();
        }

        private void _Loading()
        {
            _ShowAllEmployees();
            ShowCountEmployees();
        }

        public frmShowAllEmployees(string Title = "...")
            : base(Title)
        {
            InitializeComponent();
        }

        private void btnAddNewEmployees_Click(object sender, EventArgs e)
        {
            _AddNewEmployee();
        }

        private void frmShowAllEmployees_Load(object sender, EventArgs e)
        {
            _Loading();
        }

        public void Delete()
        {
            if (dgvShowEmployees.SelectedCells.Count > 0)
                _DeleteRowEmployee((int)dgvShowEmployees.CurrentRow.Cells[0].Value);
            else
            {
                frmMessage Message = new frmMessage("قم بتحديد الموظف المراد حذفه  بياناته", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
        }

        public void Update()
        {
            if (dgvShowEmployees.SelectedCells.Count > 0)
                _EditRowEmployee((int)dgvShowEmployees.CurrentRow.Cells[0].Value);
            else
            {
                frmMessage Message = new frmMessage("قم بتحديد الموظف المراد تعديل بياناته", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }
        }

        public void Search()
        {
            if (!string.IsNullOrEmpty(txtEmployeeSearch.Text))
                _SearchEmployeesUsingLike(txtEmployeeSearch.Text);
            else
                _ShowAllEmployees();
        }

        private void tsmiUpdateEmployee_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Update();
            
        }

        private void tsmiDeleteEmployee_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void txtEmployeeSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnEmployeeSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
