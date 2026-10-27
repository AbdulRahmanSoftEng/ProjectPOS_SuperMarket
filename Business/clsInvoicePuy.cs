using BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsInvoicePuy
    {

        public static int AddNewInvoicePuy(int SupplierID, int UserID)
        {
            return clsInvoicePuyBackEnd.AddNewInvoicePuy(SupplierID, UserID);
        }


        public static DataTable GetInvoicePuyFooter(int InvoiceID)
        {
            return clsInvoicePuyBackEnd.GetInvoicePuyFooter(InvoiceID);
        }

        public static int GetLasNumbertInvoicePuy()
        {
            return clsInvoicePuyBackEnd.GetLasNumbertInvoicePuy();
        }


    }
}
