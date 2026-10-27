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

namespace System_C_Sharp_SuperMarket_DB_MISS.Cacher
{
    public partial class frmDashBoard : frmSharedLayoutTop
    {
        
        public frmDashBoard(string Title = "...")
        :base(Title)
        {
            
            InitializeComponent();
        }

        private void _ShowCountUsers()
        {
            int Count = clsUser.GetCountUsers();
            if (Count > 0)
                lblCountUsers.Text = Count.ToString();
        }

        private void _ShowCountEmployees()
        {
            int Count = clsEmployee.GetCountEmployees();
            if (Count > 0)
                lblCountEmployees.Text = Count.ToString();
          
        }

        private void _ShowCountSuppliers()
        {
            int Count = clsSupplier.GetCountSuppliers();
            if (Count > 0)
                lblCountSuppliers.Text = Count.ToString();
           
        }

        private void _ShowCountCustomers()
        {
            int Count = clsCustomer.GetCountCustomers();
            if (Count > 0)
                lblCountCustomers.Text = Count.ToString();  
        }
        
        private void _ShowSalesToDayCachAndDebt()
        {
            decimal Total = clsDashBoard.GetSalesOfToDayCachAndDebt();
            if (Total > 0)
                lblSalesToDayCachAndDebt.Text = Total.ToString("F1");

        }

        private void _ShowSalesToDayCach()
        {
            decimal Total = clsDashBoard.GetSalesOfToDayCach();
            if (Total > 0)
                lblSalesToDayCach.Text = Total.ToString("F1");

        }

        private void _ShowSalesToDayDebt()
        {
            decimal Total = clsDashBoard.GetSalesOfToDayDebt();
            if (Total > 0)
                lblSalesToDayDebt.Text = Total.ToString("F1");

        }  
        
        private void _ShowSalesToDayDebtAmount()
        {
            decimal Total = clsDashBoard.GetSalesOfToDayDebtAmount();
            if (Total > 0)
                lblSalesToDayDebtAmount.Text = Total.ToString("F1");

        } 
        
        private void _ShowTotalDebtOfToDay()
        {
            decimal Total = clsDashBoard.GetTotalDebtOfToDay();
            if (Total > 0)
                lblTotalDebtToDay.Text = Total.ToString("F1");

        } 
        
        private void _ShowTotalDebtOfToDayAmountPaid()
        {
            decimal Total = clsDashBoard.GetTotalDebtOfToDayAmountPaid();
            if (Total > 0)
                lblTotalDebtToDayAmountPaid.Text = Total.ToString("F1");

        }  
        
        private void _ShowTotalDebtOfToDayRemainingAmount()
        {
            decimal Total = clsDashBoard.GetTotalDebtOfToDayRemainingAmount();
            if (Total > 0)
                lblTotalDebtToDayRemainingAmount.Text = Total.ToString("F1");

        }

        private void _Loadding()
        {
            _ShowCountUsers();
            _ShowCountEmployees();
            _ShowCountSuppliers();
            _ShowCountCustomers();

            _ShowSalesToDayCachAndDebt();
            _ShowSalesToDayCach();
            _ShowSalesToDayDebt();
            _ShowSalesToDayDebtAmount();

            _ShowTotalDebtOfToDay();
            _ShowTotalDebtOfToDayAmountPaid();
            _ShowTotalDebtOfToDayRemainingAmount();

        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            _Loadding();
        }
    }
}
