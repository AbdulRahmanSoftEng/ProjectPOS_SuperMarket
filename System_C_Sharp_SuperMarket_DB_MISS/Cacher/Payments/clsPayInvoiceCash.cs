using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_C_Sharp_SuperMarket_DB_MISS.Shared;

namespace System_C_Sharp_SuperMarket_DB_MISS.Cacher
{
    public class clsPayInvoiceCash
    {

        public int InvoiceID;
        public int UserID;
        public float TotalPriceInvoice;
        public int CustomerID;
        public int TypeInvoicID;
        
        public clsPayInvoiceCash(int UserID, float TotalPriceInvoice, int CustomerID, int TypeInvoiceID)
        {
            this.UserID = UserID;
            this.TotalPriceInvoice = TotalPriceInvoice;
            this.CustomerID = CustomerID;
            this.TypeInvoicID = TypeInvoiceID;
        }


        public int PayInvoiceCash(DataTable ProductsDetails)
        {

            InvoiceID = clsInvoiceSales.AddNewInvoiceSales(UserID, TotalPriceInvoice, CustomerID, TypeInvoicID);

            if (InvoiceID != -1)
            {
                clsInvoiceSalesDetails.AddInvoiceSalesDetails(ProductsDetails, InvoiceID);
            }

            return InvoiceID;
        }
    }
}
