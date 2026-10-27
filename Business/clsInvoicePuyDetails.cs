using BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsInvoicePuyDetails
    {

        public static DataTable GetInvoicePuyDetails(int InvoiceID)
        {
            return clsInvoicePuyDetailsBackEnd.GetInvoicePuyDetails(InvoiceID);
        }

        public static int AddNewInvoicePuyDetails(DataTable InvoiceDetails, int InvoiceID)
        {
            int rowAffected = 0;
            foreach (DataRow Row in InvoiceDetails.Rows)
            {
                int ProductID = clsProductBackEnd.GetProductIDByName(Row[1].ToString());
                int QtyU;
                float QtyG;
                string Notes;
                if (Row[2] != DBNull.Value)
                    QtyU = Convert.ToInt32(Row[2]);
                else
                    QtyU = 0;

                if (Row[3] != DBNull.Value)
                    QtyG = Convert.ToInt32(Row[3]);
                else
                    QtyG = 0;

                if (Row[4] != DBNull.Value)
                    Notes = Row[4].ToString();
                else
                    Notes = "";


                rowAffected = clsInvoicePuyDetailsBackEnd.AddNewInvoicePuyDetails(InvoiceID, ProductID, QtyU, QtyG, Notes);
            }

            return rowAffected;
        }
    }
}
