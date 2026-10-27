using BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsInvoiceSalesDetails
    {
        public string ProductName { get; set; }
        public string InvoiceID { get; set; }
        public int Quantity { get; set; }
        public float TotalAmount { get; set; }
        
        public clsInvoiceSalesDetails(string productName, string invoiceID, int quantity, float totalAmount)
        {
            ProductName = productName;
            InvoiceID = invoiceID;
            Quantity = quantity;
            TotalAmount = totalAmount;
            
        }
        
        public static void AddInvoiceSalesDetails(DataTable Products, int InvoiceID)
        {
            
            foreach(DataRow Row in Products.Rows)
            {

                int ProductID = Convert.ToInt32(clsProductBackEnd.GetProductIDByName(Row[1].ToString()));
                int QtyItems = Convert.ToInt32(Row[3]);
                float TotalAmount = Convert.ToSingle(Row[4]);

                clsProductBackEnd.UpdateMinuseQuantity(ProductID, QtyItems);// Edit quantity of item is minuse qty

                clsInvoiceSalesDetailsBackEnd.AddInvoiceSalesDetails(ProductID, InvoiceID, QtyItems, TotalAmount);

            }
        }

        public static DataTable GetInvoiceSalesDetails(int InvoiceID)
        {
            return clsInvoiceSalesDetailsBackEnd.GetInvoiceSalesDetails(InvoiceID);
        }
    }
}
