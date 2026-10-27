using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_C_Sharp_SuperMarket_DB_MISS.Cacher.Payments
{
    public class clsPayInvoicePuy
    {
        public int InvoiceID;
        public int SupplierID;
        public int UserID;
        
        public clsPayInvoicePuy(int SupplierID, int UserID)
        {
             this.SupplierID = SupplierID;
             this.UserID = UserID;
        }


        public int InvoicePuy(DataTable ProductsDetails)
        {

            InvoiceID = clsInvoicePuy.AddNewInvoicePuy(SupplierID, UserID);

            if (InvoiceID != -1)
            {
                clsInvoicePuyDetails.AddNewInvoicePuyDetails(ProductsDetails, InvoiceID);
            }

            return InvoiceID;
        }
    }
}
