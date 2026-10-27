using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_C_Sharp_SuperMarket_DB_MISS.Cacher.Payments
{
    public partial class frmPaymentAmount : Form
    {
        public float TotalInvoice;
        public static float AmountPaid;
        public static float RemainingAmount;
        public static bool IsPay = false;

        public frmPaymentAmount(float TotalInvoice)
        {
            InitializeComponent();
            this.TotalInvoice = TotalInvoice;
        }


        public void CalculateAmount()
        {
            try
            {
                float Amount = !string.IsNullOrEmpty(txtAmountPaid.Text) ? Convert.ToSingle(txtAmountPaid.Text) : 0;

                AmountPaid = Amount;
                RemainingAmount = Convert.ToSingle(txtRemainingAmount.Text);
                
            }
            catch(Exception ex)
            {

            }
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
         
            CalculateAmount();
            frmMessage Message = new frmMessage("تم الدفع بنجاح", enTypeIcon.Success, 2);
            Message.ShowDialog();
            IsPay = true;
            this.Close();
            
           
        }

        public void _Loadding()
        {
            txtTotalInvoice.Text = TotalInvoice.ToString();
            txtRemainingAmount.Text = TotalInvoice.ToString();
        }


        private void frmPaymentAmount_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmountPaid.Text.Trim()))
            {
                float Remaining = TotalInvoice - Convert.ToSingle(txtAmountPaid.Text.Trim());

                txtRemainingAmount.Text = Remaining.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
