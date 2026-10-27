using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_C_Sharp_SuperMarket_DB_MISS.Shared;

namespace System_C_Sharp_SuperMarket_DB_MISS
{
    public partial class frmSharedLayoutTop : Form
    {
        private string _Title;
        private string _CurrentUser;
        private string _FullNameUser;
        public frmSharedLayoutTop()
        {
            InitializeComponent(); 
            this._Title = "...";

        }

        public frmSharedLayoutTop(string Title = "...")
        {
           
            InitializeComponent(); 
            
            this._Title = Title;
            this._CurrentUser = clsGlobal.CurrentUser;
            this._FullNameUser = clsGlobal.FullNameUser;
        }


        private void _ShowTitle(string title) {
            lblTitleShared.Text = title;
        }
        
        private void _ShowDate(string CurrentDate)
        {
            lblDateShared.Text = CurrentDate;
        } 
        
        private void _ShowCurrentUser(string CurrentUser)
        {
            lblCurrentUser.Text = CurrentUser;
        }
        
        private void _ShowCurrentTime(string CurrentTime)
        {
            lblTimeShared.Text = CurrentTime;
        }

       
        
        private void _LaodForm()
        {
            _ShowDate(_GetDateNow());
            _ShowTitle(_Title);
            _ShowCurrentUser(clsGlobal.FullNameUser);
        }
        
        private string _GetDateNow()
        {
            return (string)DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void frmSharedLayoutTop_Load(object sender, EventArgs e)
        {
            _LaodForm();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string CurrentTime = DateTime.Now.ToString("hh:mm:ss tt");
            _ShowCurrentTime(CurrentTime);
        }
    }
}
