using BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsReturnInvoice
    {
        public int InvoiceId { get; set; }
        public float TotalInvoice { get; set; }
        public DateTime DateInvoice { get; set; }
        public string UserFullName { get; set; }
        public string TypeInvoice { get; set; }
        public string CustomerFullName { get; set; }
        public float AmountPaid { get; set; }
        public float RemainingAmount { get; set; }


        public clsReturnInvoice(int invoiceId, float totalInvoice, DateTime DateInvoice, string userFullName, string typeInvoice, string customerFullName, float AmountPaid, float RemainingAmount)
        {
            this.InvoiceId = invoiceId;
            this.TotalInvoice = totalInvoice;
            this.DateInvoice = DateInvoice;
            this.UserFullName = userFullName;
            this.TypeInvoice = typeInvoice;
            this.CustomerFullName = customerFullName;
            this.AmountPaid = AmountPaid;
            this.RemainingAmount = RemainingAmount;
        }

        public clsReturnInvoice(int invoiceId, float totalInvoice, DateTime DateInvoice, string userFullName, string typeInvoice)
        {
            this.InvoiceId = invoiceId;
            this.TotalInvoice = totalInvoice;
            this.UserFullName = userFullName;
            this.TypeInvoice = typeInvoice;
        }

        public static clsReturnInvoice FindInvoiceByInvoiceID(int InvoiceID)
        {
            float TotalInvoice = 0;
            DateTime DateInvoice = DateTime.MinValue;
            string UserFullName = "";
            string TypeInvoice = "";
            string CustomerFullName = "";
            float AmountPaid = 0;
            float RemainingAmount = 0;

            if (clsReturnItemsBackEnd.FindInvoiceByInvoiceID(ref InvoiceID, ref TotalInvoice, ref DateInvoice, ref UserFullName, ref TypeInvoice))
            {
                CustomerFullName = clsReturnItemsBackEnd.GetCustomerFullNameByInvoiceID(InvoiceID);

                clsReturnItemsBackEnd.FindDebtInvoiceByInvoiceID(InvoiceID, ref AmountPaid, ref RemainingAmount);

                return new clsReturnInvoice(InvoiceID, TotalInvoice, DateInvoice, UserFullName, TypeInvoice, CustomerFullName, AmountPaid, RemainingAmount);
                
            }

            return null;
        }
        public static DataTable GetInvoice(int InvoiceID)
        {
            return clsReturnItemsBackEnd.GetInvoice(InvoiceID);
        }
        
        public static bool DeleteInvoice(int InvoiceID)
        {
            return clsReturnItemsBackEnd.DeleteInvoice(InvoiceID);
        }
        
        public static bool UpdateTotalInvoice(int InvoiceID, float TotalInvoice)
        {
            return clsReturnItemsBackEnd.UpdateInvoice(InvoiceID, TotalInvoice);
        }

        public static bool UpdateDebtInvoiceByInvoiceID(int InvoiceID, float TotalInvoice, float AmountPaid, float RemainingAmount)
        {
            return clsReturnItemsBackEnd.UpdateDebtInvoiceByInvoiceID(InvoiceID, TotalInvoice, AmountPaid, RemainingAmount);
        }
        
        public static int AddNewReturnInvoice(int InvoiceID, int UserID, float TotalReturnInvoice, float AmountPaidInvoiceReturn, float RemainingAmountReturn)
        {
            return clsReturnItemsBackEnd.AddNewReturnInvoice( InvoiceID, UserID, TotalReturnInvoice, AmountPaidInvoiceReturn, RemainingAmountReturn);
        }
        
        public static int AddNewReturnInvoice(int InvoiceID, int UserID, float TotalReturnInvoice)
        {
            return clsReturnItemsBackEnd.AddNewReturnInvoice( InvoiceID, UserID, TotalReturnInvoice);
        }

        public static bool IsExistReturnInvoiceByInvoiceID(int InvoiceID)
        {
            return clsReturnItemsBackEnd.IsExistReturnInvoiceByInvoiceID(InvoiceID);
        }
        
        public static bool UpdateTotalInvoiceBeforEdit(int InvoiceID, float TotalInvoiceBeforEdit)
        {
            return clsReturnItemsBackEnd.UpdateTotalInvoiceBeforEdit(InvoiceID, TotalInvoiceBeforEdit);
        }
    }
}
