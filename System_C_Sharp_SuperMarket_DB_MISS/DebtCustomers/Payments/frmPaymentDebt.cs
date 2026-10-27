using DevExpress.Data.TreeList;
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
    public partial class frmPaymentDebt : Form
    {
        public   decimal TotalInvoicesBefor { get; set; }
        public decimal TotalAmountPaidBefor { get; set; }
        public decimal RemainingAmountBefor { get; set; }
        public static decimal AmountPaidAfter { get; set; }
        public static decimal RemainingAmountAfter { get; set; }

        public static bool IsPay = false;
        public frmPaymentDebt(decimal TotalInvoices, decimal AmountPaid, decimal RemainingAmount)
        {

            this.TotalInvoicesBefor = TotalInvoices;
            this.TotalAmountPaidBefor = AmountPaid;
            this.RemainingAmountBefor = RemainingAmount;

            InitializeComponent();
        }

        public void CalculateAmount()
        {
            try
            {
                decimal BeforPaid = !string.IsNullOrEmpty(txtNewAmountPaidAfter.Text) ? Convert.ToDecimal(txtNewAmountPaidAfter.Text) : 0;
                

                AmountPaidAfter = BeforPaid;
                RemainingAmountAfter = Convert.ToDecimal(lblRemainingAmountAfter.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }

        public void ShowDataToFiald()
        {
            lblTotalInvoicesBefor.Text = TotalInvoicesBefor.ToString();
            lblTotalAmountPaidBefor.Text = TotalAmountPaidBefor.ToString();
            lblTotalRemainingAmountBefor.Text = RemainingAmountBefor.ToString();

            lblRemainingAmountAfter.Text = RemainingAmountBefor.ToString();
        }

        public void _Loadding()
        {
            ShowDataToFiald();
            txtNewAmountPaidAfter.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewAmountPaidAfter.Text))
            {
                CalculateAmount();
                IsPay = true;
                this.Close();
            }
            else
            {
                frmMessage Message = new frmMessage("قم بادخال المبلغ المراد تسديده", enTypeIcon.Warring, 2);
                Message.ShowDialog(); 
            }   
        }

        private void frmPaymentDebt_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void txtNewAmountPaidAfter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewAmountPaidAfter.Text.Trim()))
            {
                decimal Remaining = RemainingAmountBefor - Convert.ToDecimal(txtNewAmountPaidAfter.Text.Trim());

                lblRemainingAmountAfter.Text = Remaining.ToString();
            }
        }
    }
}
