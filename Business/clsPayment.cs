using BackEnd;
using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsPayment
    {

        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public decimal TotalInvoicesBefor { get; set; }
        public decimal TotalAmountPaidBefor { get; set; }
        public decimal RemainingAmountBefor { get; set; }
        public decimal AmountPaidAfter { get; set; }
        public decimal RemainingAmountAfter { get; set; }
        public int CountInvoices { get; set; }
        public string Notes { get; set; }
        public string UserFullName { get; set; }
        public string CustomerFullName { get; set; }
        public DateTime DateTimePayment { get; set; }
        public int PaymentID { get; set; }

        public clsPayment()
        {
            TotalInvoicesBefor = 0;
            TotalAmountPaidBefor = 0;
            RemainingAmountBefor = 0;
            AmountPaidAfter = 0;
            CustomerID = 0;
            UserID = 0;
            RemainingAmountAfter = 0;
            CountInvoices = 0;
            Notes = "";
        }

        public clsPayment(int customerID, int userID, decimal totalInvoicesBefor, decimal totalAmountPaidBefor, decimal remainingAmountBefor, decimal amountPaidAfter, decimal remainingAmountAfter, int countInvoices, string notes)
        {
            CustomerID = customerID;
            UserID = userID;
            TotalInvoicesBefor = totalInvoicesBefor;
            TotalAmountPaidBefor = totalAmountPaidBefor;
            RemainingAmountBefor = remainingAmountBefor;
            AmountPaidAfter = amountPaidAfter;
            RemainingAmountAfter = remainingAmountAfter;
            CountInvoices = countInvoices;
            Notes = notes;
        }

        public clsPayment(int paymentID, string userFullName, string customerFullName, decimal totalInvoicesBefor, decimal totalAmountPaidBefor, decimal remainingAmountBefor, decimal amountPaidAfter, decimal remainingAmountAfter, int countInvoices, DateTime DateTimePayment)
        {
            this.PaymentID = paymentID;
            this.UserFullName = userFullName;
            this.CustomerFullName = customerFullName;
            this.TotalInvoicesBefor = totalInvoicesBefor;
            this.TotalAmountPaidBefor = totalAmountPaidBefor;
            this.RemainingAmountBefor = remainingAmountBefor;
            this.AmountPaidAfter = amountPaidAfter;
            this.RemainingAmountAfter = remainingAmountAfter;
            this.CountInvoices = countInvoices;
            this.DateTimePayment = DateTimePayment;
        }

        public int AddNewPayments()
        {
            return clsDebtCustomerBackEnd.AddNewPayments(CustomerID, UserID, TotalInvoicesBefor, TotalAmountPaidBefor, RemainingAmountBefor, AmountPaidAfter, RemainingAmountAfter, CountInvoices, Notes);
        }

        public static decimal GetTotalAmountPaid(int CustomerID)
        {

            return clsDebtCustomerBackEnd.GetTotalAmountPaid(CustomerID);
        }

        public static clsPayment GetDebtPaymentDetails(int PaymentID)
        {
            int CountInvoices = 0;
            string UserFullName = "", CustomerFullName = "";
            decimal TotalInvoicesBefor = 0, TotalAmountPaidBefor = 0, RemainingAmountBefor = 0, AmountPaidAfter = 0, RemainingAmountAfter = 0;
            DateTime DateTimePayment = DateTime.MinValue;

            if(clsDebtCustomerBackEnd.GetDebtPaymentDetails(PaymentID, ref UserFullName, ref CustomerFullName, ref TotalInvoicesBefor, ref TotalAmountPaidBefor, ref RemainingAmountBefor, ref AmountPaidAfter, ref RemainingAmountAfter, ref CountInvoices, ref DateTimePayment))
            {
                return new clsPayment(PaymentID, UserFullName, CustomerFullName, TotalInvoicesBefor, TotalAmountPaidBefor, RemainingAmountBefor, AmountPaidAfter, RemainingAmountAfter, CountInvoices, DateTimePayment);
            }
            return null;
        }
    }
}
