using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class clsInvoiceSalesDetailsBackEnd
    {
        static clsConnection clsConnection = new clsConnection();
        public static bool AddInvoiceSalesDetails(int ProductID, int InvoiceID, int QtyItems, float TotalAmount)
        {
            bool IsAdded = false;

            string Query = @"INSERT INTO InvoiceDetails(ProductID, InvoiceID, QtyItems, TotalAmount) values(@ProductID, @InvoiceID, @QtyItems, @TotalAmount)";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ProductID", ProductID);
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                command.Parameters.AddWithValue("@QtyItems", QtyItems);
                command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                int rowAffected = command.ExecuteNonQuery();

                if(rowAffected > 0)
                    IsAdded = true;

            }catch(Exception ex)
            {
                IsAdded = false;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsAdded;
        }

        public static DataTable GetInvoiceSalesDetails(int InvoiceID)
        {
            DataTable dt = new DataTable("Details");

            string Query = @"select Products.Name, Products.Price, InvoiceDetails.QtyItems, InvoiceDetails.TotalAmount

                            from Products inner join InvoiceDetails

                            on Products.ID = InvoiceDetails.ProductID

                            where InvoiceDetails.InvoiceID = @InvoiceID;";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                    dt.Load(Reader);

                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return dt;
        }

    }

}
