using BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsInvoiceSales
    {
        public int ID   { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public clsInvoiceSales()
        {
            ID = 0;
            Barcode = "";
            Name = "";
            Price = 0;
        }

        public clsInvoiceSales(int ID, string Barcode, string Name, float Price)
        {
            this.ID = ID;
            this.Barcode = Barcode;
            this.Name = Name;
            this.Price = Price;
        }

        public clsInvoiceSales( string Barcode, string Name, float Price)
        {
            this.Barcode = Barcode;
            this.Name = Name;
            this.Price = Price;
        }

        // هذة الدالة تقوم باضافة معلومات الفاتورة ومن ثما تقوم بارجاع رقم الفاتورة الذي تم اضافتة
        public static int AddNewInvoiceSales(int UserID, float TotalInvoice, int CustomerID, int TypeInvoiceID)
        {
            return clsInvoiceSalesBackEnd.AddInvoiceSales(UserID, TotalInvoice, CustomerID, TypeInvoiceID);
        }

        // هذة الدالة تقوم باضافة معلومات الفاتورة ومن ثما تقوم بارجاع رقم الفاتورة الذي تم اضافتة
        public static int AddDebtInvoice(int InvoiceID, float TotalInvoice, float AmountPaid, float RemainingAmount)
        {
            return clsInvoiceSalesBackEnd.AddDebtInvoice(InvoiceID, TotalInvoice, AmountPaid, RemainingAmount);
        }
        public static DataTable GetDebtInvoiceSalesFooter(int InvoiceID)
        {
            return clsInvoiceSalesBackEnd.GetDebtInvoiceSalesFooter(InvoiceID);
        }
        
        public static DataTable GetCashReturnInvoiceSalesFooter(int InvoiceID)
        {
            return clsInvoiceSalesBackEnd.GetCashReturnInvoiceSalesFooter(InvoiceID);
        }
        public static DataTable GetDebtReturnInvoiceSalesFooter(int InvoiceID)
        {
            return clsInvoiceSalesBackEnd.GetDebtReturnInvoiceSalesFooter(InvoiceID);
        }
        
        public static DataTable GetCashInvoiceSalesFooter(int InvoiceID)
        {
            return clsInvoiceSalesBackEnd.GetCashInvoiceSales(InvoiceID);
        }

        public static int GetCountInvoiceSales()
        {
            return clsInvoiceSalesBackEnd.GetCountInvoiceSales();
        }

        public static int GetLastNumberInvoiceSales()
        {
            return clsInvoiceSalesBackEnd.GetLastNumberInvoiceSales();
        }
         
        public static DataTable GetAllInvoices()
        {
            return clsInvoiceSalesBackEnd.GetAllInvoices();
        } 
        
        public static DataTable GetAllInvoicesByDateTime(DateTime startDate, DateTime endDate)
        {
            return clsInvoiceSalesBackEnd.GetAllInvoicesByDateTime(startDate, endDate);
        }
        
        public static DataTable GetAllInvoicesByTotalInvoice(float TotalInvoice)
        {
            return clsInvoiceSalesBackEnd.GetAllInvoicesByTotalInvoice(TotalInvoice);
        }


       
    }
}
