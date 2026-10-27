using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class clsInvoicePuyDetailsBackEnd
    {
        static clsConnection clsConnection = new clsConnection();

        public static int AddNewInvoicePuyDetails(int InvoiceID, int ProductID, int QtyUnit, float QtyGroup, string Notes)
        {
            int rowAffected = -1;


            string Query = @"Insert into InvoicesPuyDetails
                            (ProductID, InovicePuyID, QtyUnit, QtyGroup, Notes)
                            values(@ProductID, @InovicePuyID, @QtyUnit, @QtyGroup, @Notes)";
            
            try {

                 clsConnection.connection.Open();


                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                command.Parameters.AddWithValue("@ProductID", ProductID);
                command.Parameters.AddWithValue("@InovicePuyID", InvoiceID);

                if (QtyUnit != 0)
                    command.Parameters.AddWithValue("@QtyUnit", QtyUnit);
                else
                    command.Parameters.AddWithValue("@QtyUnit", DBNull.Value);

                if (QtyGroup != 0)
                    command.Parameters.AddWithValue("@QtyGroup", QtyGroup);
                else
                    command.Parameters.AddWithValue("@QtyGroup", DBNull.Value);

                if (Notes != "")
                     command.Parameters.AddWithValue("@Notes",Notes);
                else
                    command.Parameters.AddWithValue("@Notes", DBNull.Value);


                    rowAffected += command.ExecuteNonQuery();
                
            }
            catch(Exception e)
            {
                //e.message
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return rowAffected;
        } 

        // get details invoice 
        public static DataTable GetInvoicePuyDetails(int InvoiceID)
        {
            DataTable dt = new DataTable("Details");
            string Query = @"select Products.Name, InvoicesPuyDetails.QtyUnit, InvoicesPuyDetails.QtyGroup, InvoicesPuyDetails.Notes

                            FROM Products inner join InvoicesPuyDetails

                            on Products.ID = InvoicesPuyDetails.ProductID

                            where InvoicesPuyDetails.InovicePuyID = @InvoiceID";

            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }catch(Exception ex)
            {
               // ex.Message
            }
            finally
            {
                clsConnection.connection.Close();

            }

            return dt;
        }
    }
}
