using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_C_Sharp_SuperMarket_DB_MISS.Users
{
    public partial class frmAddEditDelPermissions : Form
    {
        public  Int64 Permisssions { get; set; }

        public frmAddEditDelPermissions()
        {
            InitializeComponent();
        }

        private int GetPermissionFromListCacher()
        {
            int _Permission = 0;

            if (cbFullAccessListCacher.Checked)
            {
                _Permission = Convert.ToInt32(cbFullAccessListCacher.Tag);
            }
            else
            {
                
                _Permission += (cbAccessSalesProducts.Checked)? Convert.ToInt32(cbAccessSalesProducts.Tag): 0;
                _Permission += (cbAccessDashBoard.Checked) ? Convert.ToInt32(cbAccessDashBoard.Tag) : 0;
                _Permission += (cbAccessSalesRate.Checked) ? Convert.ToInt32(cbAccessSalesRate.Tag) : 0;
            }

            return _Permission;
        }
                                 
        private int GetPermissionFromListProducts()
        {
            int _Permission = 0;

            if (cbFullAccessListProducts.Checked)
            {
                _Permission = Convert.ToInt32(cbFullAccessListProducts.Tag);
            }
            else
            {

                _Permission += (cbAccessShowAllProducts.Checked) ? Convert.ToInt32(cbAccessShowAllProducts.Tag) : 0;
                _Permission += (cbAccessAddNewProduct.Checked) ? Convert.ToInt32(cbAccessAddNewProduct.Tag) : 0;
                _Permission += (cbAccessDeleteProduct.Checked) ? Convert.ToInt32(cbAccessDeleteProduct.Tag) : 0;
                _Permission += (cbAccessUpdateProduct.Checked) ? Convert.ToInt32(cbAccessUpdateProduct.Tag) : 0;
                _Permission += (cbAccessFindProduct.Checked) ? Convert.ToInt32(cbAccessFindProduct.Tag) : 0;
            }

            return _Permission;
        }
                                 
        private int GetPermissionFromProductCategories()
        {
            int _Permission = 0;

            if (cbFullAccessProductsCategories.Checked)
            {
                _Permission = Convert.ToInt32(cbFullAccessProductsCategories.Tag);
            }
            else
            {

                _Permission += (cbAccessShowAllCategories.Checked) ? Convert.ToInt32(cbAccessShowAllCategories.Tag) : 0;
                _Permission += (cbAccessAddNewCategory.Checked) ? Convert.ToInt32(cbAccessAddNewCategory.Tag) : 0;
                _Permission += (cbAccessDeleteCategory.Checked) ? Convert.ToInt32(cbAccessDeleteCategory.Tag) : 0;
                _Permission += (cbAccessUpdateCategory.Checked) ? Convert.ToInt32(cbAccessUpdateCategory.Tag) : 0;
                _Permission += (cbAccessFindCategory.Checked) ? Convert.ToInt32(cbAccessFindCategory.Tag) : 0;
            }

            return _Permission;
        }
                                 
        private int GetPermissionFromListCustomers()
        {
            int _Permission = 0;

            if (cbFullAccessListCustomers.Checked)
            {
                _Permission = Convert.ToInt32(cbFullAccessListCustomers.Tag);
            }
            else
            {

                _Permission += (cbAccessShowAllCustomers.Checked) ? Convert.ToInt32(cbAccessShowAllCustomers.Tag) : 0;
                _Permission += (cbAccessAddNewCustomer.Checked) ? Convert.ToInt32(cbAccessAddNewCustomer.Tag) : 0;
                _Permission += (cbAccessDeleteCustomer.Checked) ? Convert.ToInt32(cbAccessDeleteCustomer.Tag) : 0;
                _Permission += (cbAccessUpdateCustomer.Checked) ? Convert.ToInt32(cbAccessUpdateCustomer.Tag) : 0;
                _Permission += (cbAccessFindCustomer.Checked) ? Convert.ToInt32(cbAccessFindCustomer.Tag) : 0;
            }

            return _Permission;
        }

        private Int64 GetPermissionFromListSuppliers()
        {
            Int64 _Permission = 0;

            if (cbFullAccessListSuppliers.Checked)
            {
                _Permission = Convert.ToInt64(cbFullAccessListSuppliers.Tag);
            }
            else
            {

                _Permission += (cbAccessShowAllSuppliers.Checked) ? Convert.ToInt64(cbAccessShowAllSuppliers.Tag) : 0;
                _Permission += (cbAccessAddNewSupplier.Checked) ? Convert.ToInt64(cbAccessAddNewSupplier.Tag) : 0;
                _Permission += (cbAccessDeleteSupplier.Checked) ? Convert.ToInt64(cbAccessDeleteSupplier.Tag) : 0;
                _Permission += (cbAccessUpdateSupplier.Checked) ? Convert.ToInt64(cbAccessUpdateSupplier.Tag) : 0;
                _Permission += (cbAccessFindSupplier.Checked) ? Convert.ToInt64(cbAccessFindSupplier.Tag) : 0;
            }

            return _Permission;
        }

        private Int64 GetPermissionFromListUsers()
        {
            Int64 _Permission = 0;

            if (cbFullAccessListUsers.Checked)
            {
                _Permission = Convert.ToInt64(cbFullAccessListUsers.Tag);
            }
            else
            {

                _Permission += (cbAccessShowAllUsers.Checked) ? Convert.ToInt64(cbAccessShowAllUsers.Tag) : 0;
                _Permission += (cbAccessAddNewUser.Checked) ? Convert.ToInt64(cbAccessAddNewUser.Tag) : 0;
                _Permission += (cbAccessDeleteUser.Checked) ? Convert.ToInt64(cbAccessDeleteUser.Tag) : 0;
                _Permission += (cbAccessUpdateUser.Checked) ? Convert.ToInt64(cbAccessUpdateUser.Tag) : 0;
                _Permission += (cbAccessFindUser.Checked) ? Convert.ToInt64(cbAccessFindUser.Tag) : 0;
            }

            return _Permission;
        }

        private Int64 GetPermissionFromListEmployees()
        {
            Int64 _Permission = 0;

            if (cbFullAccessListEmployees.Checked)
            {
                _Permission = Convert.ToInt64(cbFullAccessListEmployees.Tag);
            }
            else
            {

                _Permission += (cbAccessShowAllEmployees.Checked) ? Convert.ToInt64(cbAccessShowAllEmployees.Tag) : 0;
                _Permission += (cbAccessAddNewEmployee.Checked) ? Convert.ToInt64(cbAccessAddNewEmployee.Tag) : 0;
                _Permission += (cbAccessDeleteEmployee.Checked) ? Convert.ToInt64(cbAccessDeleteEmployee.Tag) : 0;
                _Permission += (cbAccessUpdateEmployee.Checked) ? Convert.ToInt64(cbAccessUpdateEmployee.Tag) : 0;
                _Permission += (cbAccessFindEmployee.Checked) ? Convert.ToInt64(cbAccessFindEmployee.Tag) : 0;
            }

            return _Permission;
        }

        private Int64 GetPermissionFromListSettings()
        {
            Int64 _Permission = 0;

            if (cbFullAccessListSettings.Checked)
            {
                _Permission = Convert.ToInt64(cbFullAccessListSettings.Tag);
            }
            else
            {

                _Permission += (cbAccessCreateBackUp.Checked) ? Convert.ToInt64(cbAccessCreateBackUp.Tag) : 0;
                _Permission += (cbAccessRestoreBackUp.Checked) ? Convert.ToInt64(cbAccessRestoreBackUp.Tag) : 0;
                _Permission += (cbAccessShowScreenPerUsers.Checked) ? Convert.ToInt64(cbAccessShowScreenPerUsers.Tag) : 0;
                _Permission += (cbAccessSettingProduct.Checked) ? Convert.ToInt64(cbAccessSettingProduct.Tag) : 0;
                _Permission += (cbAccessCommonSettings.Checked) ? Convert.ToInt64(cbAccessCommonSettings.Tag) : 0;
            }

            return _Permission;
        }


        private Int64 GetPermission()
        {
            Int64 _Permissions = 0;

            if (cbFullAccessControlSystem.Checked)
            {
                _Permissions = -1;
            }
            else
            {
                
                _Permissions += GetPermissionFromListCacher(); 
                _Permissions += GetPermissionFromListProducts(); 
                _Permissions += GetPermissionFromProductCategories(); 
                _Permissions += GetPermissionFromListCustomers(); 
                _Permissions += GetPermissionFromListSuppliers(); 
                _Permissions += GetPermissionFromListUsers(); 
                _Permissions += GetPermissionFromListEmployees();
                _Permissions += GetPermissionFromListSettings(); 
            }

            return _Permissions;
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseTop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            Int64 _Permissions  = GetPermission();

            if(_Permissions != 0)
            {
                Permisssions = _Permissions;
                this.Close();
            }
            else
            {
                frmMessage Message = new frmMessage("رجاء قم باختيار صلاحية المستخدم", enTypeIcon.Warring, 2);
                Message.ShowDialog();
            }  
         }


        private void cbFullAccessListCacher_CheckedChanged(object sender, EventArgs e)
        {
            cbAccessSalesProducts.Checked = cbFullAccessListCacher.Checked;
            cbAccessDashBoard.Checked = cbFullAccessListCacher.Checked;
            cbAccessSalesRate.Checked = cbFullAccessListCacher.Checked;
        }

        private void cbFullAccessControlSystem_CheckedChanged(object sender, EventArgs e)
        {
            cbFullAccessListCacher.Checked = cbFullAccessControlSystem.Checked;
            cbFullAccessListProducts.Checked = cbFullAccessControlSystem.Checked;
            cbFullAccessProductsCategories.Checked = cbFullAccessControlSystem.Checked;
            cbFullAccessListCustomers.Checked = cbFullAccessControlSystem.Checked;
            cbFullAccessListSuppliers.Checked = cbFullAccessControlSystem.Checked;
            cbFullAccessListUsers.Checked = cbFullAccessControlSystem.Checked;
            cbFullAccessListEmployees.Checked = cbFullAccessControlSystem.Checked;
            cbFullAccessListSettings.Checked = cbFullAccessControlSystem.Checked;
        }

        private void cbFullAccessListProducts_CheckedChanged(object sender, EventArgs e)
        {
            cbAccessShowAllProducts.Checked = cbFullAccessListProducts.Checked;
            cbAccessAddNewProduct.Checked = cbFullAccessListProducts.Checked;
            cbAccessDeleteProduct.Checked = cbFullAccessListProducts.Checked;
            cbAccessUpdateProduct.Checked = cbFullAccessListProducts.Checked;
            cbAccessFindProduct.Checked = cbFullAccessListProducts.Checked;
  
        }

        private void cbFullAccessProductsCategories_CheckedChanged(object sender, EventArgs e)
        {
            cbAccessShowAllCategories.Checked = cbFullAccessProductsCategories.Checked;
            cbAccessAddNewCategory.Checked = cbFullAccessProductsCategories.Checked;
            cbAccessDeleteCategory.Checked = cbFullAccessProductsCategories.Checked;
            cbAccessUpdateCategory.Checked = cbFullAccessProductsCategories.Checked;
            cbAccessFindCategory.Checked = cbFullAccessProductsCategories.Checked;
        }

        private void cbFullAccessListCustomers_CheckedChanged(object sender, EventArgs e)
        {
            cbAccessShowAllCustomers.Checked = cbFullAccessListCustomers.Checked;
            cbAccessAddNewCustomer.Checked = cbFullAccessListCustomers.Checked;
            cbAccessDeleteCustomer.Checked = cbFullAccessListCustomers.Checked;
            cbAccessUpdateCustomer.Checked = cbFullAccessListCustomers.Checked;
            cbAccessFindCustomer.Checked = cbFullAccessListCustomers.Checked;
        }

        private void cbFullAccessListSuppliers_CheckedChanged(object sender, EventArgs e)
        {
            cbAccessShowAllSuppliers.Checked = cbFullAccessListSuppliers.Checked;
            cbAccessAddNewSupplier.Checked = cbFullAccessListSuppliers.Checked;
            cbAccessDeleteSupplier.Checked = cbFullAccessListSuppliers.Checked;
            cbAccessUpdateSupplier.Checked = cbFullAccessListSuppliers.Checked;
            cbAccessFindSupplier.Checked = cbFullAccessListSuppliers.Checked;
        }

        private void cbFullAccessListUsers_CheckedChanged(object sender, EventArgs e)
        {
            cbAccessShowAllUsers.Checked = cbFullAccessListUsers.Checked;
            cbAccessAddNewUser.Checked = cbFullAccessListUsers.Checked;
            cbAccessDeleteUser.Checked = cbFullAccessListUsers.Checked;
            cbAccessUpdateUser.Checked = cbFullAccessListUsers.Checked;
            cbAccessFindUser.Checked = cbFullAccessListUsers.Checked;
        }

        private void cbFullAccessListEmployees_CheckedChanged(object sender, EventArgs e)
        {
            cbAccessShowAllEmployees.Checked = cbFullAccessListEmployees.Checked;
            cbAccessAddNewEmployee.Checked = cbFullAccessListEmployees.Checked;
            cbAccessDeleteEmployee.Checked = cbFullAccessListEmployees.Checked;
            cbAccessUpdateEmployee.Checked = cbFullAccessListEmployees.Checked;
            cbAccessFindEmployee.Checked = cbFullAccessListEmployees.Checked;
        }

        private void cbFullAccessListSettings_CheckedChanged(object sender, EventArgs e)
        {
            cbAccessCreateBackUp.Checked = cbFullAccessListSettings.Checked;
            cbAccessRestoreBackUp.Checked = cbFullAccessListSettings.Checked;
            cbAccessShowScreenPerUsers.Checked = cbFullAccessListSettings.Checked;
            cbAccessSettingProduct.Checked = cbFullAccessListSettings.Checked;
            cbAccessCommonSettings.Checked = cbFullAccessListSettings.Checked;
        }
    }
}
