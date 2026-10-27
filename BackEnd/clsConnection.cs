using System;
using System.Data;
using System.Data.SqlClient;

namespace BackEnd
{
    public class clsConnection
    {

        public SqlConnection connection;

        private static string _ServerURL    = @Properties.Settings.Default.ServerName;
        public  static string _DatabaseName  = Properties.Settings.Default.DatabaseName;
        private static bool   _ModeAccess   = true;
        private static string _Username     = Properties.Settings.Default.Username;
        private static string _Password     = Properties.Settings.Default.Password;

        
        public clsConnection()
        {
            if (Properties.Settings.Default.ModeAuthentication == "Windows Authentication")
            {
                string ConnectionString = "Server=" + _ServerURL + "; Database=" + _DatabaseName + ";Integrated Security=" + _ModeAccess + "";
                connection  = new SqlConnection(ConnectionString);
            }
            else
            {
                string ConnectionString = "Server=" + _ServerURL + "; Database=" + _DatabaseName + ";Integrated Security=" + _ModeAccess + "; User Id=" + _Username + "; Password=" + _Password + ";";
                connection = new SqlConnection(ConnectionString);
            }
        }
  
        public bool IsConnectDB()
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    return true;
                }
            } catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            
            
            return false;
        }
    }
}
