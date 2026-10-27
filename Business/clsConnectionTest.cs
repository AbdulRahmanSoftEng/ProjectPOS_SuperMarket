using BackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsConnectionTest
    {
        static clsConnection clsConnection = new clsConnection();
        public static bool TestConnection()
        {
            
            return clsConnection.IsConnectDB();
        }
    }
}
