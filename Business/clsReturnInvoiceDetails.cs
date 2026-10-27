using BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsReturnInvoiceDetails
    {
        
        public static DataTable GetInvoiceDetails(int InvoiceID)
        {
            return clsReturnItemsBackEnd.GetInvoiceDetails(InvoiceID);
        }
        public static bool UpdateInvoiceDetails(int InvoiceID, string ProductName, int QtyItem, float TotalPriceItems)
        {
            return clsReturnItemsBackEnd.UpdateInvoiceDetails(InvoiceID, ProductName, QtyItem, TotalPriceItems);
        }

        public static bool DeleteItemFromInvoiceDetails(int InvoiceID, string ProductName)
        {
            return clsReturnItemsBackEnd.DeleteItemFromInvoiceDetails(InvoiceID, ProductName);
        }  
        
        public static bool AddNewReturnInvoiceDetails(int ProductID, int InvoiceID, int QtyItem, float TotalAmount)
        {
            return clsReturnItemsBackEnd.AddNewReturnInvoiceDetails( ProductID, InvoiceID, QtyItem, TotalAmount);
        }
    }
}
