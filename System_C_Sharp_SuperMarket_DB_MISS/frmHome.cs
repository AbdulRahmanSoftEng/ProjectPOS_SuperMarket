using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_C_Sharp_SuperMarket_DB_MISS.Customers;
using System_C_Sharp_SuperMarket_DB_MISS.Employees;
using System_C_Sharp_SuperMarket_DB_MISS.Products;
using System_C_Sharp_SuperMarket_DB_MISS.Properties;
using System_C_Sharp_SuperMarket_DB_MISS.Salespeople;
using System_C_Sharp_SuperMarket_DB_MISS.Settings;
using System_C_Sharp_SuperMarket_DB_MISS.Suppliers;
using System_C_Sharp_SuperMarket_DB_MISS.Users;
using Business;
using System_C_Sharp_SuperMarket_DB_MISS.Cacher;
using DevExpress.XtraEditors;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using System_C_Sharp_SuperMarket_DB_MISS.Shared;
using System_C_Sharp_SuperMarket_DB_MISS.DebtCustomers;
using DevExpress.XtraReports.UI;

namespace System_C_Sharp_SuperMarket_DB_MISS
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }


        private void CloseChildrenForms()
        {
            foreach (Form Chalid in this.MdiChildren)
            {
                Chalid.Close();
            }
        }


        private void tsmiShowAllUsers_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmShowAllUsers UserList = new frmShowAllUsers("شاشة المستخدمين");
            UserList.MdiParent = this;
            UserList.Dock = DockStyle.Fill;
            UserList.Show();
        }

        private void tmsiShowAllEmployees_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmShowAllEmployees EmployeeList = new frmShowAllEmployees("شاشة الموظفين");
            EmployeeList.MdiParent = this;
            EmployeeList.Dock = DockStyle.Fill;
            EmployeeList.Show();
        }

        private void tsmiShowAllProducts_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmShowAllProducts ListProduct = new frmShowAllProducts("شاشة الاصناف");
            ListProduct.MdiParent = this;
            ListProduct.Dock = DockStyle.Fill;
            ListProduct.Show();
        }

        private void tsmiShowAllCustomers_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmShowAllCustomers ListCustomer = new frmShowAllCustomers("شاشة العملاء");
            ListCustomer.MdiParent = this;
            ListCustomer.Dock = DockStyle.Fill;
            ListCustomer.Show();
        }

        private void tsmiShowAllSuppliers_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmShowAllSuppliers ListSupplier = new frmShowAllSuppliers("شاشة الموردين");
            ListSupplier.MdiParent = this;
            ListSupplier.Dock = DockStyle.Fill;
            ListSupplier.Show();
        }

        private void tsmiCreateBackUpDatabase_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmCreateBackUpDB CreateBackUp = new frmCreateBackUpDB("انشاء نصخة احطياطية ");
            CreateBackUp.MdiParent = this;
            CreateBackUp.Dock = DockStyle.Fill;
            CreateBackUp.Show();
        }

        private void tsmiRestoreBackUpDatabase_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmRestoreBackUpDB RestoreBackUp = new frmRestoreBackUpDB("استعادة نسخة احطياطية");
            RestoreBackUp.MdiParent = this;
            RestoreBackUp.Dock = DockStyle.Fill;
            RestoreBackUp.Show();
        }

        private void tsmiSetting_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmSetting Setting = new frmSetting("الاعدادات");
            Setting.MdiParent = this;
            Setting.Dock = DockStyle.Fill;
            Setting.Show();
        }

        private void tsmiUserPermissions_Click(object sender, EventArgs e)
        {
            //foreach (Form Chalid in this.MdiChildren)
            //{
            //    Chalid.Close();
            //}
            //frmAddEditDelPermissions AddEditDelPermission = new frmAddEditDelPermissions();
            //AddEditDelPermission.MdiParent = this;
            //AddEditDelPermission.Dock = DockStyle.Fill;
            //AddEditDelPermission.Show();
        }

        private void tsmiShowAllCategories_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmShowAllCategories ShowAllCategories = new frmShowAllCategories("شاشة مجموعة الاصناف");
            ShowAllCategories.MdiParent = this;
            ShowAllCategories.Dock = DockStyle.Fill;
            ShowAllCategories.Show();
        }

        private void tsmiSalesScreen_Click(object sender, EventArgs e)
        {

            ShowDefaultForm();
        }

        public void ShowDefaultForm()
        {
            CloseChildrenForms();

            frmSalesCacherScreen SalesCacherScreen = new frmSalesCacherScreen("شاشة البيع");
            SalesCacherScreen.MdiParent = this;
            SalesCacherScreen.Dock = DockStyle.Fill;
            SalesCacherScreen.Show();
        }

        private void _Loading()
        {
            ShowDefaultForm();
            timer1.Start();

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            _Loading();
        }

        private void tsmiAddNewProduct_Click(object sender, EventArgs e)
        {
            frmAddEditProducts AddEditProducts = new frmAddEditProducts("");

            AddEditProducts.ShowDialog();
            
        }

        private void tsmiDashBoard_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmDashBoard DashBoard = new frmDashBoard("شاشة لوحة القيادة");
            DashBoard.MdiParent = this;
            DashBoard.Dock = DockStyle.Fill;
            DashBoard.Show();
        }

        private void tsmiSalesRate_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmSalesRate SalesRate = new frmSalesRate("شاشة احصائيات نسبة البيع");
            SalesRate.MdiParent = this;
            SalesRate.Dock = DockStyle.Fill;
            SalesRate.Show();
        }

        private void tsmiProductsRestrictRequest_Click(object sender, EventArgs e)
        {

            CloseChildrenForms();

            frmProductsRestrictRequest ProductsRestrictRequest = new frmProductsRestrictRequest("شاشة المشتريات قيد الطلب");
            ProductsRestrictRequest.MdiParent = this;
            ProductsRestrictRequest.Dock = DockStyle.Fill;
            ProductsRestrictRequest.Show();
            
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            var Result = MessageBox.Show(
                "هل تريد اغلاق النظام بالكامل",
                "اغلاق الفورم",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

            if(Result != DialogResult.Yes)
            {
                
                e.Cancel = true;
            }
            else
            {
                clsUser.UpdateLoginHistoryLoginExit(clsGlobal.LoginDateID);
            }
        }

        private void tsmiProfileStock_Click(object sender, EventArgs e)
        {
            

            Form ProfileStock = new frmProfileStock("شاشة معلومات المحل");
            ProfileStock.MdiParent = this;
            ProfileStock.Dock = DockStyle.Fill;
            ProfileStock.Show();

        }

        private void tsmiReturnItems_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmReturnItems ReturnItems = new frmReturnItems("شاشة مرتجع المبيعات");
            ReturnItems.MdiParent = this;
            ReturnItems.Dock = DockStyle.Fill;
            ReturnItems.Show();
        }

        private void tsmiShowDebtCustomers_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmShowDebtCustomers DebtCustomers = new frmShowDebtCustomers("شاشة ديون العملاء");
            DebtCustomers.MdiParent = this;
            DebtCustomers.Dock = DockStyle.Fill;
            DebtCustomers.Show();
        }

        private void tsmiServerInformaionConn_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmConnectionInformation ConnectionInformation = new frmConnectionInformation();
            ConnectionInformation.MdiParent = this;
            ConnectionInformation.Dock = DockStyle.Fill;
            ConnectionInformation.btnExit.Visible = false;
            ConnectionInformation.Show();
           
        }

        private void tsmiTasbihs_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmTasbihs Tasbihs = new frmTasbihs("شاشة رسائل التسبيح");
            Tasbihs.MdiParent = this;
            Tasbihs.Dock = DockStyle.Fill;
            Tasbihs.Show();
        }

        private void tsmiLoginHistoriesUsers_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmLoginHistory History = new frmLoginHistory("شاشة سجلات دخول المستخدمين للنظام");
            History.MdiParent = this;
            History.Dock = DockStyle.Fill;
            History.Show();
        }

        int Counter = 0;
        int TimeOfBackUp = clsSetting.GetTimeBackUpDB();
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (Counter == TimeOfBackUp)
            {
                try
                {
                    if (!clsSetting.BackUpDatabase(Properties.Settings.Default.DefaultBackUpPath.ToString()))
                    {
                        MessageBox.Show("لم يتم اضافة النسخة الاحطياطية هنالك مشكلة");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
               
                Counter = 0;

            }
            Counter++;

        }

        private void tsmiAddNewQtyItems_Click(object sender, EventArgs e)
        {
            CloseChildrenForms();

            frmAddNewQty AddNewQty = new frmAddNewQty();
            AddNewQty.MdiParent = this;
            AddNewQty.Dock = DockStyle.Fill;
            AddNewQty.Show();
        }
    }
}
