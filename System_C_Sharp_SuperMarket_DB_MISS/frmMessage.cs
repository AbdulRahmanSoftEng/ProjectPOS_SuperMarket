using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_C_Sharp_SuperMarket_DB_MISS;
using System_C_Sharp_SuperMarket_DB_MISS.Properties;

namespace System_C_Sharp_SuperMarket_DB_MISS
{
    public partial class frmMessage : Form
    {      
        public enTypeIcon TypeIcon { get; set; }

        public string MessageTitle { get; set; }
        public byte TimeShowMessage { get; set; }


        public frmMessage(string MessageTitle, enTypeIcon TypeIcon, byte TimeShowMessage)
        {
          
            InitializeComponent();
            
            this.MessageTitle = MessageTitle;
            this.TypeIcon = TypeIcon;
            this.TimeShowMessage = TimeShowMessage;
        }

        short Counter = 2;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Counter == TimeShowMessage)
            {
                Counter = 0;
                timer1.Stop();
                this.Close();
            }
            Counter++;
        }

        public void ShowMessage(string Title, enTypeIcon Icon)
        {
            lblMessageTitle.Text = Title;

            switch (Icon)
            {
                case enTypeIcon.Success:
                    pbMessageIcon.Image = Resources.successfully;
                    break;

                case enTypeIcon.Information:
                    pbMessageIcon.Image = Resources.information;
                    break;

                case enTypeIcon.Warring:
                    pbMessageIcon.Image = Resources.warring;
                    break;

                case enTypeIcon.Error:
                    pbMessageIcon.Image = Resources.close;
                    break;
            }
        }

        public void _Loadding()
        {
            timer1.Start();
            ShowMessage(MessageTitle, TypeIcon);
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {
            _Loadding();
        }
    }
}
