using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEnd
{
    public class clsAnalyzesSalesBackEnd
    {
        static clsConnection clsConnection = new clsConnection();

        // استعلام عن نسبة البيعات خلال تاريخين الكاش والاجل وعن جميع المستخدمين
        public static decimal GetTotalSales(DateTime From, DateTime To)
        {
            decimal totalSales = 0;

            string Query = @"select Sum(TotalInvoice) As TotalInvoices

            from Invoices 

            where CAST(DateInvoice As Date) between  Cast(@DateFrom As Date) and Cast(@DateTo As Date); ";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@DateFrom", From);
                command.Parameters.AddWithValue("@DateTo", To);

                Object Result = command.ExecuteScalar();
                totalSales = Result != DBNull.Value && Result != null ? Convert.ToDecimal(Result) : 0;

            }catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return totalSales;
        }

        // استعلام عن نسبة البيعات خلال تاريخين الكاش والاجل وعن مستخدم معين
        public static decimal GetTotalSalesAndUser(DateTime From, DateTime To, int UserID)
        {
            decimal totalSales = 0;

            string Query = @"select Sum(TotalInvoice) As TotalInvoices

            from Invoices 

            where (CAST(DateInvoice As Date) between  Cast(@DateFrom As Date) and Cast(@DateTo As Date)) and UserID = @UserID; ";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@DateFrom", From);
                command.Parameters.AddWithValue("@DateTo", To);
                command.Parameters.AddWithValue("@UserID", UserID);

                Object Result = command.ExecuteScalar();
                totalSales = Result != DBNull.Value && Result != null ? Convert.ToDecimal(Result) : 0;

            }catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return totalSales;
        }


        //  استعلام عن نسبة البيعات خلال تاريخين الفواتير الكاش وعن جميع المستخدمين
        public static decimal GetTotalSalesCach(DateTime From, DateTime To)
        {
            decimal totalSales = 0;

            string Query = @"select Sum(TotalInvoice) As TotalInvoices

            from Invoices 

            where (CAST(DateInvoice As Date) between  Cast(@DateFrom As Date) and Cast(@DateTo As Date)) and TypeInvoiceID = @typeInvoiceCach; ";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@DateFrom", From);
                command.Parameters.AddWithValue("@DateTo", To);
                command.Parameters.AddWithValue("@typeInvoiceCach", 1);

                Object Result = command.ExecuteScalar();
                totalSales = Result != DBNull.Value && Result != null ? Convert.ToDecimal(Result) : 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return totalSales;
        }

        //  استعلام عن نسبة البيعات خلال تاريخين الفواتير الاجل وعن جميع المستخدمين
        public static decimal GetTotalSalesDebt(DateTime From, DateTime To)
        {
            decimal totalSales = 0;

            string Query = @"select Sum(TotalInvoice) As TotalInvoices

            from Invoices 

            where (CAST(DateInvoice As Date) between  Cast(@DateFrom As Date) and Cast(@DateTo As Date)) and TypeInvoiceID = @typeInvoiceDebt; ";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@DateFrom", From);
                command.Parameters.AddWithValue("@DateTo", To);
                command.Parameters.AddWithValue("@typeInvoiceDebt", 2);

                Object Result = command.ExecuteScalar();
                totalSales = Result != DBNull.Value && Result != null ? Convert.ToDecimal(Result) : 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return totalSales;
        }


        // استعلام عن نسبة البيعات خلال تاريخين الفواتير الكاش وعن مستخدم معين
        public static decimal GetTotalSalesCachAndUser(DateTime From, DateTime To, int UserID)
        {
            decimal totalSales = 0;

            string Query = @"select Sum(TotalInvoice) As TotalInvoices

            from Invoices 

            where (CAST(DateInvoice As Date) between  Cast(@DateFrom As Date) and Cast(@DateTo As Date))  and TypeInvoiceID = @typeInvoiceCach and UserID = @userID;";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@DateFrom", From);
                command.Parameters.AddWithValue("@DateTo", To);
                command.Parameters.AddWithValue("@typeInvoiceCach", 1);
                command.Parameters.AddWithValue("@userID", UserID);

                Object Result = command.ExecuteScalar();
                totalSales = Result != DBNull.Value && Result != null ? Convert.ToDecimal(Result) : 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return totalSales;
        }

        //  استعلام عن نسبة البيعات خلال تاريخين الفواتير الاجل وعن مستخدم معين
        public static decimal GetTotalSalesDebtAndUser(DateTime From, DateTime To, int UserID)
        {
            decimal totalSales = 0;

            string Query = @"select Sum(TotalInvoice) As TotalInvoices

            from Invoices 

            where (CAST(DateInvoice As Date) between  Cast(@DateFrom As Date) and Cast(@DateTo As Date))  and TypeInvoiceID = @typeInvoiceDebt and UserID = @userID;";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@DateFrom", From);
                command.Parameters.AddWithValue("@DateTo", To);
                command.Parameters.AddWithValue("@typeInvoiceDebt", 2);
                command.Parameters.AddWithValue("@userID", UserID);

                Object Result = command.ExecuteScalar();
                totalSales = Result != DBNull.Value && Result != null ? Convert.ToDecimal(Result) : 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return totalSales;
        }


        //   استعلام عن المنتجات الاكثر مبيعاً خلال تاريخين التي تم بيعها من جميع المستخدمين
        public static DataTable GetAllProductsSales()
        {
            DataTable dt = new DataTable();

            string Query = @"select Distinct Products.Name as اسم_المنتج, SUM(InvoiceDetails.QtyItems) As الكمية_المباعة, Sum(InvoiceDetails.TotalAmount) As اجمالي_السعر

            From Products inner join InvoiceDetails

            On Products.ID = InvoiceDetails.ProductID

            inner join Invoices

            On Invoices.ID = InvoiceDetails.InvoiceID

            Group By  Products.Name
            
            Order By SUM(InvoiceDetails.QtyItems) desc";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                SqlDataReader Reader = command.ExecuteReader();
                
                if(Reader.Read() || Reader.HasRows)
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return dt;
        } 
        
        //   استعلام عن المنتجات الاكثر مبيعاً خلال تاريخين التي تم بيعها من جميع المستخدمين
        public static DataTable GetAllProductsSalesBetweenDates(DateTime From, DateTime To)
        {
            DataTable dt = new DataTable();

            string Query = @"select Distinct Top 10 Products.Name as اسم_المنتج, SUM(InvoiceDetails.QtyItems) As الكمية_المباعة, Sum(InvoiceDetails.TotalAmount) As اجمالي_السعر

            From Products inner join InvoiceDetails

            On Products.ID = InvoiceDetails.ProductID

            inner join Invoices

            On Invoices.ID = InvoiceDetails.InvoiceID

            where Cast(Invoices.DateInvoice As Date) between Cast(@DateFrom As Date) and Cast(@DateTo As Date)

            Group By  Products.Name

            Order By SUM(InvoiceDetails.QtyItems) desc";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@DateFrom", From);
                command.Parameters.AddWithValue("@DateTo", To);
                command.Parameters.AddWithValue("@Number", 10);

                SqlDataReader Reader = command.ExecuteReader();
                
                if(Reader.HasRows)
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return dt;
        }


        //  استعلام عن المنتجات الاكثر مبيعاً خلال تاريخين التي تم بيعها من خلال مستخدم معين
        public static DataTable GetAllProductsSalesBetweenDatesAndUser(DateTime From, DateTime To, int UserID)
        {
            DataTable dt = new DataTable();

            string Query = @"select Distinct Top 10 Products.Name as اسم_المنتج, SUM(InvoiceDetails.QtyItems) As الكمية_المباعة, Sum(InvoiceDetails.TotalAmount) As اجمالي_السعر

            From Products inner join InvoiceDetails

            On Products.ID = InvoiceDetails.ProductID

            inner join Invoices

            On Invoices.ID = InvoiceDetails.InvoiceID

            inner join Users

            On Invoices.UserID = Users.ID

            where Cast(Invoices.DateInvoice As Date) between Cast(@DateFrom As Date) and Cast(@DateTo As Date) and Users.ID = @userID

            Group By  Products.Name
            
            Order By SUM(InvoiceDetails.QtyItems) desc";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@DateFrom", From);
                command.Parameters.AddWithValue("@DateTo", To);
                command.Parameters.AddWithValue("@userID", UserID);
                command.Parameters.AddWithValue("@Number", 10);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return dt;
        }

    }
}
