using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_C_Sharp_SuperMarket_DB_MISS.Settings;
using System_C_Sharp_SuperMarket_DB_MISS.Users;

namespace System_C_Sharp_SuperMarket_DB_MISS
{

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

       
        public static void Main()
       {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(!clsConnectionTest.TestConnection())
            {
                // اضهار واجة معلومات الاتصال في حال لم يتم الاتصال بالسيرفر
                ShowScreenServerInfo();
                return;
            }

            // استدعاء واجة ادخال مستخدم جديد في حال لم يكن هنالك مستخدم موجود في قاعدة البيانات
            ShowScreenAddUser();
        }

        public static  void ShowScreenServerInfo()
        {
            frmConnectionInformation Info = new frmConnectionInformation();
            Info.ShowDialog();
        }
        
        public static  void ShowScreenAddUser()
        {
            int Flage = -1;

            if(clsUser.GetCountUsers() == Flage)
            {
                frmAddEditUsers addEditUsers = new frmAddEditUsers(Flage);
                addEditUsers.ShowDialog();
            }
            // في حال لم يتم ايجاد اي مستخدم فرح يتم اعادة استدعاء واجة ادخال مستخدم جديد

            // في حال تم ايجاد مستخدم في قاعدة البيانات
            Application.Run(new frmIntro());
        }

    }
}
