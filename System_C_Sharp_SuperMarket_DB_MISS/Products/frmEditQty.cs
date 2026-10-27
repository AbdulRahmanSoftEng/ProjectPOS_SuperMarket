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
    public partial class frmEditQty : Form
    {
        public int NewQty { get; set; }
        public frmEditQty()
        {
            InitializeComponent();
            NewQty = 0;
            txtQty.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQty.Text))
            {
                NewQty = Convert.ToInt32(txtQty.Text);
                if(NewQty > 0)
                {
                    this.Close();
                }
                else
                {
                    lblError.Text = "الكمية غير صحيحة قم بادخال كمية اكبر من الصفر";
                }
               
            }
            else
            {
                lblError.Text = "قم بتحديد الكمية";
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditQty_Load(object sender, EventArgs e)
        {
            txtQty.Focus();
        }
    }
}
