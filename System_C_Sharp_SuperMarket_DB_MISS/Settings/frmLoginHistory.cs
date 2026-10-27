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

namespace System_C_Sharp_SuperMarket_DB_MISS.Settings
{
    public partial class frmLoginHistory : frmSharedLayoutTop
    {
        public frmLoginHistory(string Title = "...")
        :base(Title){
            InitializeComponent();
        }

        public void ShowAllLoginHistory()
        {

            DataTable dt = clsLoginHistory.GetAllLoginHistory();
            if (dt.Rows.Count > 0)
                dgvShowLoginHistories.DataSource = dt;
        }
        
        public void ShowAllLoginHistoryByUserFirstName(string FirstName)
        {
            DataTable dt = clsLoginHistory.FindLoginHistoryByUserFirstName(FirstName);
            if(dt.Rows.Count > 0)
                dgvShowLoginHistories.DataSource = dt;
        }

        private void txtSearchLoginHistories_TextChanged(object sender, EventArgs e)
        {
            if(dgvShowLoginHistories.Rows.Count > 0)
            {
                if (!string.IsNullOrEmpty(txtSearchLoginHistories.Text))
                {
                    ShowAllLoginHistoryByUserFirstName(txtSearchLoginHistories.Text.Trim());
                }
                else
                {
                    ShowAllLoginHistory();
                }
            }
        }

        public void _Loadding()
        {
            ShowAllLoginHistory();
        }

        private void frmLoginHistory_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchLoginHistories.Text))
            {
                ShowAllLoginHistoryByUserFirstName(txtSearchLoginHistories.Text);
            }
            else
            {
                ShowAllLoginHistory();
            }
        }
    }
}
