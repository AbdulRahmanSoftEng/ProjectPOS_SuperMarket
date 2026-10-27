using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_C_Sharp_SuperMarket_DB_MISS.Cacher
{
    public class clsPayInvoice
    {
        public int InvoiceID;
        public int UserID;
        public float TotalPriceInvoice;
        public int CustomerID;
        public int TypeInvoicID;
        public float AmountPaid;
        public float RemainingAmount;

        public clsPayInvoice(int UserID, float TotalPriceInvoice, float AmountPaid, float RemainingAmount, int CustomerID, int TypeInvoiceID)
        {
            this.UserID = UserID;
            this.TotalPriceInvoice = TotalPriceInvoice;
            this.AmountPaid = AmountPaid;
            this.RemainingAmount = RemainingAmount;
            this.CustomerID = CustomerID;
            this.TypeInvoicID = TypeInvoiceID;
        }


        public int PayInvoiceCash(DataTable ProductsDetails)
        {

            InvoiceID = clsInvoiceSales.AddNewInvoiceSales(UserID, TotalPriceInvoice, CustomerID, TypeInvoicID);

            

            if (InvoiceID != -1)
            {
                clsInvoiceSales.AddDebtInvoice(InvoiceID, TotalPriceInvoice, AmountPaid, RemainingAmount);

                clsInvoiceSalesDetails.AddInvoiceSalesDetails(ProductsDetails, InvoiceID);
            }

            return InvoiceID;
        }
    }
}
