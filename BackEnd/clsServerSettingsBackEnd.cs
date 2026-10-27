using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public  class clsServerSettingsBackEnd
    {
        static clsConnection clsConnection = new clsConnection();
        public static bool SaveChanged(string ServerName, string DatabaseName, string Mode, string Username, string Password)
        {
            bool IsFound = false;

            try
            {
                Properties.Settings.Default.ServerName = ServerName.ToString();
                Properties.Settings.Default.DatabaseName = DatabaseName.ToString();
                Properties.Settings.Default.ModeAuthentication = Mode.ToString();
                Properties.Settings.Default.Username = Username.ToString();
                Properties.Settings.Default.Password = Password.ToString();
                Properties.Settings.Default.Save();
                IsFound = true;

            }catch(Exception ex)
            {
                //ex.Message
            }

            return IsFound;
        }

        public static bool GetServerInformation(ref string ServerName, ref string DatabaseName, ref string Mode, ref string Username, ref string Password)
        {

            bool IsFound = false;

            try
            {
                ServerName = Properties.Settings.Default.ServerName;
                DatabaseName = Properties.Settings.Default.DatabaseName;
                Mode = Properties.Settings.Default.ModeAuthentication;
                Username = Properties.Settings.Default.Username;
                Password = Properties.Settings.Default.Password;
                IsFound = true;

            }
            catch (Exception ex)
            {
                //ex.Message
            }

            return IsFound;

        }
    }
}
