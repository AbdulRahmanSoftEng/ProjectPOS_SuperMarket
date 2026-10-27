using BackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsServerSettings
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string ModeAuthentication { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public clsServerSettings()
        {
            ServerName = "";
            DatabaseName = "";
            ModeAuthentication = "";
            Username = "";
            Password = "";
        }

        public clsServerSettings(string serverName, string databaseName, string modeAuthentication, string username, string password)
        {
            ServerName = serverName;
            DatabaseName = databaseName;
            ModeAuthentication = modeAuthentication;
            Username = username;
            Password = password;
        }

        public bool SaveChanged()
        {
            return clsServerSettingsBackEnd.SaveChanged(ServerName, DatabaseName, ModeAuthentication, Username, Password);
        }

        public static clsServerSettings GetServerInformation()
        {
            string ServerName = "";
            string DatabaseName = "";
            string ModeAuthentication = "";
            string Username = "";
            string Password = "";

            if(clsServerSettingsBackEnd.GetServerInformation(ref ServerName, ref DatabaseName, ref ModeAuthentication, ref Username, ref Password))
            {
                return new clsServerSettings(ServerName, DatabaseName, ModeAuthentication, Username, Password);
            }

            return null;
        }
    }
}
