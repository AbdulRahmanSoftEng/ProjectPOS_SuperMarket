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
using System_C_Sharp_SuperMarket_DB_MISS.Salespeople;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace System_C_Sharp_SuperMarket_DB_MISS.Cacher
{
    public partial class frmSalesRate : frmSharedLayoutTop
    {

        public string[] TypeSales = { "المبيعات الكاش", "المبيعات الاجل", "المبيعات الكاش والاجل" };
        public int PersonID = 0;
        public frmSalesRate(string Title = "...")
        :base(Title)
        {
            InitializeComponent();
        }

        public void Refrech()
        {
            ShowAllProductsSalesByDates();
            ShowCharts();
            ShowTotalSales();
            ShowCountItemSales();
            ShowCountItems();
        }

        public void ShowTypeSalesForComboBox()
        {
            cbTypeSales.Items.AddRange(TypeSales);
        }

        public void ShowAllProductsSales()
        {
            DataTable dt = clsAnalyzesSales.GetAllProductsSales();
            if (dt != null)
                dgvShowProducts.DataSource = dt;
            else
                ShowAllProductsSales();
        }

        public void ShowAllProductsSalesByDates()
        {
            DataTable dt = clsAnalyzesSales.GetAllProductsSalesBetweenDates(dtpDateFrom.Value, dtpDateTo.Value);
            if(dt != null)
                dgvShowProducts.DataSource = dt;
            else
                ShowAllProductsSales();

        }

        public int GetCountItemSales()
        {
            DataTable dt = (DataTable)dgvShowProducts.DataSource;
            int count = 0;
            if(dgvShowProducts.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    count += Convert.ToInt32(dr["الكمية_المباعة"]);
                }
            }

            return count;
        }

        public int GetCountItem()
        {
            int count = 0;

            if(dgvShowProducts.Rows.Count > 0)
            {
                count = dgvShowProducts.Rows.Count; 
            }
         
            return count;
        }

        public decimal GetTotalSales()
        {

            if (string.IsNullOrEmpty(cbTypeSales.Text) && string.IsNullOrEmpty(txtShowsUsers.Text))
            {
                 return clsAnalyzesSales.GetTotalSales(dtpDateFrom.Value, dtpDateTo.Value);
            }

            if (cbTypeSales.SelectedIndex == 0 && string.IsNullOrEmpty(txtShowsUsers.Text))
            {
                return clsAnalyzesSales.GetTotalSalesCach(dtpDateFrom.Value, dtpDateTo.Value);
            }

            if (cbTypeSales.SelectedIndex == 1 && string.IsNullOrEmpty(txtShowsUsers.Text))
            {
                return clsAnalyzesSales.GetTotalSalesDebt(dtpDateFrom.Value, dtpDateTo.Value);
            }

            if (cbTypeSales.SelectedIndex == 2 && string.IsNullOrEmpty(txtShowsUsers.Text))
            {
                return clsAnalyzesSales.GetTotalSales(dtpDateFrom.Value, dtpDateTo.Value);
            }

            //----------------------

            int UserID = clsUser.GetUserIDByPersonID(PersonID);

            if (cbTypeSales.SelectedIndex == 0 && UserID > 0)
            {
                return clsAnalyzesSales.GetTotalSalesCachAndUser(dtpDateFrom.Value, dtpDateTo.Value, UserID);
            }

            if (cbTypeSales.SelectedIndex == 1 && UserID > 0)
            {
                return clsAnalyzesSales.GetTotalSalesDebtAndUser(dtpDateFrom.Value, dtpDateTo.Value, UserID);
            }

            if (cbTypeSales.SelectedIndex == 2 && UserID > 0)
            {
                return clsAnalyzesSales.GetTotalSalesDebtAndUser(dtpDateFrom.Value, dtpDateTo.Value, UserID);
            }

            return 0;
        }

        public void ShowTotalSales()
        {
            lblTotalSales.Text = GetTotalSales().ToString("F2");
        }

        public void ShowCountItemSales()
        {
            lblCountItemSales.Text = GetCountItemSales().ToString();
        }

        public void ShowCountItems()
        {
            lblCountItems.Text = GetCountItem().ToString();
        }


        public void ShowChart1TypeColumnsVert(DataTable dt)
        {
            Chart1.DataSource = dt;
            Chart1.Series["Series1"].XValueMember = "اسم_المنتج";
            Chart1.Series["Series1"].YValueMembers = "الكمية_المباعة";

            Chart1.DataBind();

            Chart1.ChartAreas[0].AxisX.Title = "المنتجات";
            Chart1.ChartAreas[0].AxisY.Title = "الكميات المباعة";
            Chart1.Series["Series1"].IsValueShownAsLabel = true;
        }

        public void ShowChart2TypeColumnsVert(DataTable dt)
        {
            Chart2.DataSource = dt;
            Chart2.Series["Series1"].XValueMember = "اسم_المنتج";
            Chart2.Series["Series1"].YValueMembers = "اجمالي_السعر";
                 
            Chart2.DataBind();
                 
            Chart2.ChartAreas[0].AxisX.Title = "المنتجات";
            Chart2.ChartAreas[0].AxisY.Title = "الكميات المباعة";
            Chart2.Series["Series1"].IsValueShownAsLabel = true;
        }

        public void ShowChart3TypeColumnsVert(DataTable dt)
        {
            Chart3.DataSource = dt;
            Chart3.Series["Series1"].XValueMember = "اجمالي_السعر";
            Chart3.Series["Series1"].YValueMembers = "الكمية_المباعة";
                 
            Chart3.DataBind();
                 
            Chart3.ChartAreas[0].AxisX.Title = "اسعار المنتجات";
            Chart3.ChartAreas[0].AxisY.Title = "الكميات المباعة";
            Chart3.Series["Series1"].IsValueShownAsLabel = true;
        }

        public void Results()
        {
            DataTable dt = clsAnalyzesSales.GetAllProductsSalesBetweenDates(dtpDateFrom.Value, dtpDateTo.Value);
            if (dt != null)
            {
               ShowChart1TypeColumnsVert(dt);
               ShowChart2TypeColumnsVert(dt);
               ShowChart3TypeColumnsVert(dt);
            }
        }

        public void ShowCharts()
        {
            Results();
        }

        public void _Loadding()
        {
           

            dtpDateFrom.Format = DateTimePickerFormat.Custom;
            dtpDateFrom.CustomFormat = "dd/MM/yyyy";

            dtpDateTo.Format = DateTimePickerFormat.Custom;
            dtpDateTo.CustomFormat = "dd/MM/yyyy";

            ShowTypeSalesForComboBox();
            Refrech();

            cbTypeSales.SelectedIndex = 0;

        }

        private void dtpDateInvoiceFrom_ValueChanged(object sender, EventArgs e)
        {
            Refrech();

        }

        private void frmSalesRate_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void txtShowsUsers_Click(object sender, EventArgs e)
        {
            frmShowsUser ShowsCustomer = new frmShowsUser();
            ShowsCustomer.ShowDialog();
            PersonID = frmShowsUser.id;
            if (PersonID != -1)
            {
                clsUser Customer = clsUser.FindUserByPersonID(PersonID);
                txtShowsUsers.Text = Customer.FirstName + " " + Customer.LastName;
                ShowTotalSales();
            }
            else
            {
                //cbTypeInvoice.SelectedIndex = 0;
            }
        }

        private void btnSearchProductsSalaes_Click(object sender, EventArgs e)
        {
            Refrech();

        }

        private void dtpDateTo_ValueChanged(object sender, EventArgs e)
        {
            Refrech();
        }

        private void cbTypeSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refrech();
        }
    }
}
