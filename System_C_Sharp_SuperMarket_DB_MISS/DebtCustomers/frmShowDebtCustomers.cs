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

namespace System_C_Sharp_SuperMarket_DB_MISS.DebtCustomers
{
    public partial class frmShowDebtCustomers : frmSharedLayoutTop
    {
        public string[] MethodeSearch = { "بحث باستخدام الاسم او اللقب", "بحث باستخدام رقم الهاتف" };

        public frmShowDebtCustomers(string Title = "...")
            : base(Title)
        {
            InitializeComponent();
        }

        public void ShowAllDebtCustomers()
        {
            DataTable dt = clsDebtCustomer.GetAllDebtCustomers();
            if(dt.Rows.Count > 0)
            {
                dgvShowDebtCustomers.DataSource = dt;
                RenameColumns();
            }
        }

        private void FindByName()
        {
            dgvShowDebtCustomers.DataSource = clsDebtCustomer.GetAllDebtCustomersByNameUsingLike(txtSearchDebtCustomers.Text);
        }

        private void FindByPhone()
        {
            dgvShowDebtCustomers.DataSource = clsDebtCustomer.GetAllDebtCustomersByPhone(txtSearchDebtCustomers.Text);
        }

        public void RenameColumns()
        {
            try
            {
                dgvShowDebtCustomers.Columns[0].HeaderText = "رقم العميل";
                dgvShowDebtCustomers.Columns[1].HeaderText = "الاسم الاول";
                dgvShowDebtCustomers.Columns[2].HeaderText = "الاسم الاخير";
                dgvShowDebtCustomers.Columns[3].HeaderText = "العنوان";
                dgvShowDebtCustomers.Columns[4].HeaderText = "رقم الهاتف";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void _Loadding()
        {
            ShowAllDebtCustomers();
            cbMethodSearchDebtCustomers.Items.AddRange(MethodeSearch);
            cbMethodSearchDebtCustomers.SelectedIndex = 1;
        }

        private void frmShowDebtCustomers_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void txtSearchDebtCustomers_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtSearchDebtCustomers.Text))
            {
                switch (cbMethodSearchDebtCustomers.SelectedIndex)
                {
                    case 0:
                        FindByName();
                        break;

                    case 1:
                        FindByPhone();
                        break;
                }

            }
            else
            {
                ShowAllDebtCustomers();
            }
        }

        private void dgvShowDebtCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvShowDebtCustomers.SelectedCells.Count > 0)
            {
                int CustomerID = Convert.ToInt32(dgvShowDebtCustomers.CurrentRow.Cells[0].Value);
                frmDebtCustomer debtCustomer = new frmDebtCustomer(CustomerID);
                debtCustomer.ShowDialog();
            }
            
        }

     
    }
}
