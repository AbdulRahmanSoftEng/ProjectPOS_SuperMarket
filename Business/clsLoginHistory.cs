using BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsLoginHistory
    {
        public static DataTable GetAllLoginHistory()
        {
            return clsLoginHistoryBackEnd.GetAllLoginHistory();
        }
        public static DataTable FindLoginHistoryByUserFirstName(string FirstName)
        {
            return clsLoginHistoryBackEnd.FindLoginHistoryByUserFirstName(FirstName);
        }


    }
}
