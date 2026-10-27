using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_C_Sharp_SuperMarket_DB_MISS.Products
{
    public partial class frmPaymentDebtInvoice : Form
    {
        public float TotalInvoiceBeforEdit;
        public float TotalInvoiceAfterEdit;
        public float AmountPaidBeforEdit;

        public static float TotalAmountPaidAfterEdit;
        public static float RemainingAmountAfterEdit;
        private static float ReminingAmountAfterPaidEdit;
        public frmPaymentDebtInvoice(float TotalInvoiceBeforEdit, float TotalInvoiceAfterEdit, float AmountPaidBeforEdit)
        {
            InitializeComponent();
            this.TotalInvoiceBeforEdit = TotalInvoiceBeforEdit;
            this.TotalInvoiceAfterEdit = TotalInvoiceAfterEdit;
            this.AmountPaidBeforEdit = AmountPaidBeforEdit;
        }

        public void CalculateAmount()
        {
            try
            {
                float BeforPaid = !string.IsNullOrEmpty(txtAmountPaidBeforEditing.Text) ? Convert.ToSingle(txtAmountPaidBeforEditing.Text) : 0;
                float AfterPaid = !string.IsNullOrEmpty(txtAmountPaidAfterditing.Text) ? Convert.ToSingle(txtAmountPaidAfterditing.Text) : 0;
                
                TotalAmountPaidAfterEdit = BeforPaid + AfterPaid;
                RemainingAmountAfterEdit = Convert.ToSingle(txtRemainingAmountAfterEditing.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }

        private void btnPay_Click(object sender, EventArgs e)
        {  
            CalculateAmount();
            this.Close();
        }

        public void ShowDataToFiald()
        {
            txtTotalInvoiceBeforEditing.Text = TotalInvoiceBeforEdit.ToString();
            txtTotalInvoiceAfterEditing.Text = TotalInvoiceAfterEdit.ToString();

            txtAmountPaidBeforEditing.Text = AmountPaidBeforEdit.ToString();

            float Remaining = TotalInvoiceAfterEdit - AmountPaidBeforEdit;
            txtRemainingAmountAfterEditing.Text = Remaining.ToString();
            ReminingAmountAfterPaidEdit = Convert.ToSingle(txtRemainingAmountAfterEditing.Text);
        }

        public void _Loadding()
        {
            ShowDataToFiald();
        }


        private void frmPaymentAmount_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmountPaidAfterditing.Text.Trim()))
            {
                float FinalRemaining = ReminingAmountAfterPaidEdit - Convert.ToSingle(txtAmountPaidAfterditing.Text.Trim());

                txtRemainingAmountAfterEditing.Text = FinalRemaining.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
