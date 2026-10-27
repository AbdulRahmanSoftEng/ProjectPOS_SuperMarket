using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class clsInvoiceSalesBackEnd
    {
        static clsConnection clsConnection = new clsConnection();

        public static int AddInvoiceSales(int UserID, float TotalInvoice, int CustomerID, int TypeInvoiceID)
        {
            int rowAdded = -1;


            string Query = @"INSERT INTO Invoices(UserID, TotalInvoice, DateInvoice, CustomerID, TypeInvoiceID) values(@UserID, @TotalInvoice, @DateInvoice, @CustomerID, @TypeInvoiceID);
                             Select SCOPE_Identity()";


            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@TotalInvoice", TotalInvoice);
                command.Parameters.Add(new SqlParameter("@DateInvoice", SqlDbType.DateTime) { Value = DateTime.Now });


                if (CustomerID > 0)
                    command.Parameters.AddWithValue("@CustomerID", CustomerID) ;
                else
                    command.Parameters.AddWithValue("@CustomerID", DBNull.Value);
                

                command.Parameters.AddWithValue("@TypeInvoiceID", TypeInvoiceID);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                    rowAdded = Convert.ToInt32(Result);

            }
            catch (Exception ex)
            {
                rowAdded = -1;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return rowAdded;
        }

        public static int AddDebtInvoice(int InvoiceID, float TotalInvoice, float AmountPaid, float RemainingAmount)
        {
            int rowAdded = -1;

            string Query = @"INSERT INTO DebtInvoices(InvoiceID, TotalInvoice, AmountPaid, RemainingAmount) values(@InvoiceID, @TotalInvoice, @AmountPaid, @RemainingAmount);
                             Select SCOPE_Identity()";


            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                command.Parameters.AddWithValue("@TotalInvoice", TotalInvoice);
                command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
                command.Parameters.AddWithValue("@RemainingAmount", RemainingAmount);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                    rowAdded = Convert.ToInt32(Result);

            }
            catch (Exception ex)
            {
                rowAdded = -1;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return rowAdded;
        }

     
        // get Count Invoices
        public static int GetCountInvoiceSales()
        {
            int count = -1;

            string Query = @"SELECT COUNT(ID) as CountInvoices FROM Invoices";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                    count = Convert.ToInt32(Result);

            }
            catch (Exception ex)
            {
                count = -1;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return count;
        }

        public static int GetLastNumberInvoiceSales()
        {
            int count = -1;

            string Query = @"SELECT Top 1 ID as NumberInvoice FROM Invoices Order by ID Desc";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                    count = Convert.ToInt32(Result);

            }
            catch (Exception ex)
            {
                count = -1;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return count;
        }

        // استعلام عن معلومات الفاتورة التي تضهر في الاسفل
        public static DataTable GetDebtInvoiceSalesFooter(int InvoiceID)// footer
        {
            DataTable dt = new DataTable("InvoiceFooter");

            string Query = @"select Invoices.ID, (select Sum(QtyItems) from InvoiceDetails where InvoiceID = @InvoiceID) as CountItems,  Invoices.TotalInvoice, FORMAT(Invoices.DateInvoice, 'dd/MM/yyyy - hh:mm:ss tt') AS DateInvoice,  uPersons.FirstName +' '+uPersons.LastName As UserFullName, TypeInvoices.Name as TypeInvoice, DebtInvoices.AmountPaid, DebtInvoices.RemainingAmount, cPersons.FirstName +' '+cPersons.LastName as CustmerFullName
 
                            From Users inner join Invoices

                            on Invoices.UserID = Users.ID

                            inner join TypeInvoices
							
                            On TypeInvoices.ID	= Invoices.TypeInvoiceID

                            inner join Persons uPersons

                            On uPersons.ID = Users.PersonID

                            inner join DebtInvoices

                            On DebtInvoices.InvoiceID = Invoices.ID

                            Inner Join Customers Customers

                            On Customers.ID = Invoices.CustomerID

                            Inner Join Persons cPersons

                            On cPersons.ID = Customers.PersonID

                            where Invoices.ID = @InvoiceID";

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

        // استعلام عن معلومات فاتورة مرتجع مبيعات التي تضهر في الاسفل
        public static DataTable GetDebtReturnInvoiceSalesFooter(int InvoiceID)// footer
        {
            DataTable dt = new DataTable("InvoiceFooter");

            string Query = @"select Invoices.ID, (select Sum(QtyItems) from InvoiceDetails where InvoiceID = @InvoiceID) as CountItems,  Invoices.TotalInvoice As TotalInvoiceAfterEdit, ReturnInvoice.TotalInvoiceReturn, FORMAT(Invoices.DateInvoice, 'dd/MM/yyyy - hh:mm:ss tt') AS DateInvoice,  uPersons.FirstName +' '+uPersons.LastName As UserFullName, TypeInvoices.Name as TypeInvoice, DebtInvoices.AmountPaid, DebtInvoices.RemainingAmount, cPersons.FirstName +' '+cPersons.LastName as CustmerFullName
 
                            From Users inner join Invoices

                            on Invoices.UserID = Users.ID

                            inner join TypeInvoices
							
                            On TypeInvoices.ID	= Invoices.TypeInvoiceID

                            inner join Persons uPersons

                            On uPersons.ID = Users.PersonID

                            inner join DebtInvoices

                            On DebtInvoices.InvoiceID = Invoices.ID

                            Inner Join Customers Customers

                            On Customers.ID = Invoices.CustomerID

                            Inner Join Persons cPersons

                            On cPersons.ID = Customers.PersonID

                            inner join ReturnInvoice

							on Invoices.ID = ReturnInvoice.InvoiceID

                            where Invoices.ID = @InvoiceID";

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


        // استعلام عن معلومات فاتورة المرتجع التي تضهر في الاسفل
        public static DataTable GetCashReturnInvoiceSalesFooter(int InvoiceID)// footer
        {
            DataTable dt = new DataTable("InvoiceFooter");

            string Query = @"select Invoices.ID, (select Sum(QtyItems) from InvoiceDetails where InvoiceID = @InvoiceID) as CountItems,  Invoices.TotalInvoice As TotalInvoiceAfterEdit, ReturnInvoice.TotalInvoiceReturn , FORMAT(Invoices.DateInvoice, 'dd/MM/yyyy - hh:mm:ss tt') As DateInvoice,  Persons.FirstName +' '+Persons.LastName As UserFullName, TypeInvoices.Name as TypeInvoice

                            From Users inner join Invoices

                            on Invoices.UserID = Users.ID

                            inner join TypeInvoices
							
                            On TypeInvoices.ID	= Invoices.TypeInvoiceID

                            inner join Persons

                            On Persons.ID = Users.PersonID

							inner join ReturnInvoice

							on Invoices.ID = ReturnInvoice.InvoiceID

                            where Invoices.ID = @InvoiceID";

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

        // استعلام عن معلومات الفاتورة التي تضهر في الاسفل
        public static DataTable GetCashInvoiceSales(int InvoiceID)// footer
        {
            DataTable dt = new DataTable("InvoiceFooter");

            string Query = @"select Invoices.ID, (select Sum(QtyItems) from InvoiceDetails where InvoiceID = @InvoiceID) as CountItems,  Invoices.TotalInvoice, FORMAT(Invoices.DateInvoice, 'dd/MM/yyyy - hh:mm:ss tt') As DateInvoice,  Persons.FirstName +' '+Persons.LastName As UserFullName, TypeInvoices.Name as TypeInvoice

                            From Users inner join Invoices

                            on Invoices.UserID = Users.ID

                            inner join TypeInvoices
							
                            On TypeInvoices.ID	= Invoices.TypeInvoiceID

                            inner join Persons

                            On Persons.ID = Users.PersonID

                         
                            where Invoices.ID = @InvoiceID";

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


        // استعلام عن جميع الفواتير
        public static DataTable GetAllInvoices()// 
        {
            DataTable dt = new DataTable();

            string Query = @"select 

            Invoices.ID,
            Invoices.TotalInvoice,
            FORMAT(Invoices.DateInvoice, 'dd/MM/yyyy') As DateInvoice,
            FORMAT(Invoices.DateInvoice, 'hh:mm:ss tt') As TimeInvoice,
            TypeInvoices.Name

            From Invoices inner join TypeInvoices

            On Invoices.TypeInvoiceID = TypeInvoices.ID

            Order by Invoices.DateInvoice desc;";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows && Reader.Read())
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


        // استعلام عن جميع الفواتير من خلال تاريخ معين
        public static DataTable GetAllInvoicesByDateTime(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();

            string Query = @"select 

            Invoices.ID,
            Invoices.TotalInvoice,
            FORMAT(Invoices.DateInvoice, 'dd/MM/yyyy') As DateInvoice,
            FORMAT(Invoices.DateInvoice, 'hh:mm:ss tt') As TimeInvoice,
            TypeInvoices.Name

            From Invoices inner join TypeInvoices

            On Invoices.TypeInvoiceID = TypeInvoices.ID
            
            where Invoices.DateInvoice between @startDate and @endDate";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);

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
        
        // استعلام عن جميع الفواتير من خلال اجمالي الفاتورة
        public static DataTable GetAllInvoicesByTotalInvoice(float TotalInvoice)
        {
            DataTable dt = new DataTable();

            string Query = @"select 

            Invoices.ID,
            Invoices.TotalInvoice,
            FORMAT(Invoices.DateInvoice, 'dd/MM/yyyy') As DateInvoice,
            FORMAT(Invoices.DateInvoice, 'hh:mm:ss tt') As TimeInvoice,
            TypeInvoices.Name

            From Invoices inner join TypeInvoices

            On Invoices.TypeInvoiceID = TypeInvoices.ID
            
            where Invoices.TotalInvoice = @TotalInvoice

            Order by Invoices.DateInvoice desc;";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@TotalInvoice", TotalInvoice);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows && Reader.Read())
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
