using BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsSalesCacher
    {
        public static DataTable GetAllTypeInvoices()
        {
            return clsSalesCacherBackEnd.GetAllTypeInvoices();
        }

        public static int GetTypeInvoiceIDByName(string Name)
        {
            return clsSalesCacherBackEnd.GetTypeInvoiceIDByName(Name);
        }
   
    }
}
