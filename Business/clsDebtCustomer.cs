using BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsDebtCustomer
    {
        public decimal TotalInvoices { get; set; }
        public decimal AmountPaidInvoices { get; set; }
        public decimal RemainingAmountInvoices { get; set; }

        public clsDebtCustomer(decimal TotalInvoices, decimal AmountPaidInvoices, decimal RemainingAmountInvoices)
        {
            this.TotalInvoices = TotalInvoices;
            this.AmountPaidInvoices = AmountPaidInvoices;
            this.RemainingAmountInvoices = RemainingAmountInvoices;
        }

        public static DataTable GetAllDebtCustomers()
        {
            return  clsDebtCustomerBackEnd.GetAllDebtCustomers();
        } 
        
        public static DataTable GetAllDebtCustomersByNameUsingLike(string Name)
        {
            return  clsDebtCustomerBackEnd.GetAllDebtCustomersByNameUsingLike(Name);
        }
        
        public static DataTable GetAllDebtCustomersByPhone(string Phone)
        {
            return  clsDebtCustomerBackEnd.GetAllDebtCustomersByPhone(Phone);
        }  
        
        public static DataTable GetAllInvoicesByCustomerID(int CustomerID)
        {
            return  clsDebtCustomerBackEnd.GetAllInvoicesByCustomerID(CustomerID);
        }
        
        public static DataTable GetAllInvoicesByCustomerIDAndFromDateToDate(int CustomerID, DateTime From, DateTime To)
        {
            return  clsDebtCustomerBackEnd.GetAllInvoicesByCustomerIDAndFromDateToDate(CustomerID, From, To);
        }
        
        public static clsDebtCustomer FindTotalInvoicesAndAmountPaidAndRemainingAmountInvoices(int CustomerID)
        {
            decimal TotalInvoices = 0 , AmountPaidInvoices = 0, RemainingAmountInvoices = 0;

            if(clsDebtCustomerBackEnd.FindTotalInvoicesAndAmountPaidAndRemainingAmountInvoices(CustomerID, ref TotalInvoices, ref AmountPaidInvoices, ref RemainingAmountInvoices))
            {
                return new clsDebtCustomer(TotalInvoices, AmountPaidInvoices, RemainingAmountInvoices);

            }
            return null;
        } 
        
        public static int GetCountInvoices(int CustomerID)
        {
            return clsDebtCustomerBackEnd.GetCountInvoices(CustomerID);
        } 
        
        public static decimal GetTotalAmountPaidPaymentsByCustomerID(int CustomerID)
        {
            return clsDebtCustomerBackEnd.GetTotalAmountPaidPaymentsByCustomerID(CustomerID);
        } 
        
        public static decimal GetTotalRemainingAmountDebtCustomerByCustomerID(int CustomerID)
        {
            return clsDebtCustomerBackEnd.GetTotalRemainingAmountDebtCustomerByCustomerID(CustomerID);
        }
    }
}
