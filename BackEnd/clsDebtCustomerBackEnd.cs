using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace BackEnd
{
    public class clsDebtCustomerBackEnd
    {
        static clsConnection clsConnection = new clsConnection();
        public static DataTable GetAllDebtCustomers()
        {
            DataTable dt = new DataTable();
            //استعلام عن جميع العملاءالذين عليهم ديون مبيعات دون تكرار

            string Query = @"select DISTINCT Customers.ID, Persons.FirstName, Persons.LastName,  Customers.Address, Phones.Phone

                          From Persons inner join Customers

                          On Persons.ID = Customers.PersonID

                          inner join Phones

                          On Persons.ID = Phones.PersonID

                          inner join Invoices

                          On Invoices.CustomerID = Customers.ID

                          Inner join DebtInvoices

                          On Invoices.ID = DebtInvoices.InvoiceID;";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally { clsConnection.connection.Close(); }

            return dt;
        }
        
        public static DataTable GetAllDebtCustomersByNameUsingLike(string Name)
        {
            DataTable dt = new DataTable();
            //  --  استعلام عن جميع العملاءالذين عليهم ديون مبيعات دون تكرار باستخدام اسم العميل من اول حرف  Using Like

            string Query = @"select DISTINCT Customers.ID, Persons.FirstName, Persons.LastName,  Customers.Address,  Phones.Phone

                            From Persons inner join Customers

                            On Persons.ID = Customers.PersonID

                            inner join Phones

                            On Persons.ID = Phones.PersonID

                            inner join Invoices

                            On Invoices.CustomerID = Customers.ID

                            Inner join DebtInvoices

                            On Invoices.ID = DebtInvoices.InvoiceID

                            where Persons.FirstName like '%'+@Name+'%' or Persons.LastName like '%'+@Name+'%' ;";
                             //يمكن اضافة شرط لاضهار فقط العملاء الذين لم يزال عندهم مبلغ متبقي  

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", Name);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally { clsConnection.connection.Close(); }

            return dt;
        }

        public static DataTable GetAllDebtCustomersByPhone(string Phone)
        {
            DataTable dt = new DataTable();
            //  --  استعلام عن جميع العملاءالذين عليهم ديون مبيعات دون تكرار باستخدام اسم العميل من اول حرف  Using Like

            string Query = @"select DISTINCT Customers.ID, Persons.FirstName, Persons.LastName,  Customers.Address,  Phones.Phone

                            From Persons inner join Customers

                            On Persons.ID = Customers.PersonID

                            inner join Phones

                            On Persons.ID = Phones.PersonID

                            inner join Invoices

                            On Invoices.CustomerID = Customers.ID

                            Inner join DebtInvoices

                            On Invoices.ID = DebtInvoices.InvoiceID

                            where Phones.Phone like '%'+ @Phone+'%';";
            //يمكن اضافة شرط لاضهار فقط العملاء الذين لم يزال عندهم مبلغ متبقي  

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Phone", Phone);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally { clsConnection.connection.Close(); }

            return dt;
        }  
        
        
        public static DataTable GetAllInvoicesByCustomerID(int CustomerID)
        {
            DataTable dt = new DataTable();
            //  --  استعلام عن جميع العملاءالذين عليهم ديون مبيعات دون تكرار باستخدام اسم العميل من اول حرف  Using Like

            string Query = @"select
                            Invoices.ID  as رقم_الفاتورة,
                            Invoices.DateInvoice as تاريخ_الفاتورة,
                            Invoices.TotalInvoice as اجمالي_الفاتورة,
                            DebtInvoices.AmountPaid as المبلغ_المدفوع,
                            DebtInvoices.RemainingAmount as المبلغ_المتبقي

                            From Invoices inner join DebtInvoices

                            On Invoices.ID = DebtInvoices.InvoiceID

                            where Invoices.CustomerID = @CustomerID;";
 
            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@CustomerID", CustomerID);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally { clsConnection.connection.Close(); }

            return dt;
        } 
        
        public static DataTable GetAllInvoicesByCustomerIDAndFromDateToDate(int CustomerID, DateTime From, DateTime To)
        {
            DataTable dt = new DataTable();

            //استعلام عن الفواتير التي قام العميل بسحبها  حسب رقم العميل و مابين تاريخين للفاتورة

            string Query = @"select

                            Invoices.ID  as رقم_الفاتورة,
                            Invoices.DateInvoice as تاريخ_الفاتورة,
                            Invoices.TotalInvoice as اجمالي_الفاتورة,
                            DebtInvoices.AmountPaid as المبلغ_المدفوع,
                            DebtInvoices.RemainingAmount as المبلغ_المتبقي

                            From Invoices inner join DebtInvoices

                            On Invoices.ID = DebtInvoices.InvoiceID

                            where Invoices.CustomerID = @CustomerID and Invoices.DateInvoice between @From and @To;
";
 
            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@CustomerID", CustomerID);
                command.Parameters.AddWithValue("@From", From);
                command.Parameters.AddWithValue("@To", To);

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows || reader.Read())
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally { clsConnection.connection.Close(); }

            return dt;
        }
        
        public static bool FindTotalInvoicesAndAmountPaidAndRemainingAmountInvoices(int CustomerID, ref decimal TotalInvoices,ref decimal AmountPaidInvoices, ref decimal RemainingAmountInvoices)
        {
            bool IsFound = false;

            //	استعلام عن الاجمالي الكلي عن الفواتير و عن الاجمالي الكامل الذي تم تسديده وعن الاجمالي الكامل المتبقي بعد التسديد بحسب رقم العميل
            string Query = @"select Sum(DebtInvoices.TotalInvoice) as TotalDebtInvoices , Sum(DebtInvoices.AmountPaid) as TotalAmountPaid, Sum(DebtInvoices.RemainingAmount) as TotalRemainingAmount
			
			                From Invoices inner join DebtInvoices

			                On Invoices.ID = DebtInvoices.InvoiceID

			                inner join Customers 

			                On Customers.ID = Invoices.CustomerID

			                where Customers.ID = @CustomerID;";
 
            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@CustomerID", CustomerID);

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows && reader.Read())
                {
                    IsFound = true;
                    TotalInvoices = reader["TotalDebtInvoices"] != DBNull.Value ? Convert.ToDecimal(reader["TotalDebtInvoices"]) : 0;
                    AmountPaidInvoices = reader["TotalAmountPaid"] != DBNull.Value ? Convert.ToDecimal(reader["TotalAmountPaid"]) : 0;
                    RemainingAmountInvoices = reader["TotalRemainingAmount"] != DBNull.Value ? Convert.ToDecimal(reader["TotalRemainingAmount"]) : 0;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally { clsConnection.connection.Close(); }

            return IsFound;
        }
        
        public static int GetCountInvoices(int CustomerID)
        {
            int CountDebInvoices = 0;

            //	استعلام عن الاجمالي الكلي عن الفواتير و عن الاجمالي الكامل الذي تم تسديده وعن الاجمالي الكامل المتبقي بعد التسديد بحسب رقم العميل
            string Query = @"select Count(DebtInvoices.TotalInvoice) as CountDebtInvoices
			
		                    From Invoices inner join DebtInvoices

		                    On Invoices.ID = DebtInvoices.InvoiceID

		                    inner join Customers 

		                    On Customers.ID = Invoices.CustomerID

		                    where Customers.ID = @CustomerID";
 
            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@CustomerID", CustomerID);

                object Result = command.ExecuteScalar();

                CountDebInvoices = Result != DBNull.Value ? Convert.ToInt32(Result) : 0;

            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally { clsConnection.connection.Close(); }

            return CountDebInvoices;
        }


        public static int AddNewPayments(int CustomerID, int UserID, decimal TotalInvoicesBefor, decimal TotalAmountPaidBefor, decimal RemainingAmountBefor, decimal AmountPaidAfter, decimal RemainingAmountAfter, int CountInvoices, string Notes)
        {
            int PaymentID = -1;

            string Query = @"insert into Payments
                            (DateTimePayment, CustomerID, UserID, TotalInvoicesBefor , TotalAmountPaidBefor, RemainingAmountBefor,AmountPaidAfter, RemainingAmountAfter, CountInvoices, Notes )
                            values(@DateTimePayment, @CustomerID, @UserID, @TotalInvoicesBefor , @TotalAmountPaidBefor, @RemainingAmountBefor,@AmountPaidAfter, @RemainingAmountAfter, @CountInvoices, @Notes );   select SCOPE_IDENTITY();";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@DateTimePayment", DateTime.Now);
                command.Parameters.AddWithValue("@CustomerID", CustomerID);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@TotalInvoicesBefor", TotalInvoicesBefor);
                command.Parameters.AddWithValue("@TotalAmountPaidBefor", TotalAmountPaidBefor);
                command.Parameters.AddWithValue("@RemainingAmountBefor", RemainingAmountBefor);
                command.Parameters.AddWithValue("@AmountPaidAfter", AmountPaidAfter);
                command.Parameters.AddWithValue("@RemainingAmountAfter", RemainingAmountAfter);
                command.Parameters.AddWithValue("@CountInvoices", CountInvoices);
                command.Parameters.AddWithValue("@Notes", Notes);

                Object Result = command.ExecuteScalar();

                PaymentID = Result != DBNull.Value ? Convert.ToInt32(Result): -1 ; 

            } catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return PaymentID;
        }
        

        public static decimal GetTotalAmountPaid(int CustomerID)
        {
            decimal Total = 0;

            string Query = @"SELECT SUM(AmountPaidAfter) as TotalAmountPaid from Payments where CustomerID = @CustomerID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@CustomerID", CustomerID);
                
                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    Total = Convert.ToDecimal(Result);
                }

            } catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return Total;
        }
          
        public static decimal GetTotalRemainingAmountDebtCustomerByCustomerID(int CustomerID)
        {
            decimal Total = 0;

            string Query = @"select Sum(DebtInvoices.RemainingAmount) as TotalRemainingAmount
			
			                From Invoices inner join DebtInvoices

			                On Invoices.ID = DebtInvoices.InvoiceID

			                inner join Customers 

			                On Customers.ID = Invoices.CustomerID

			                where Customers.ID = @CustomerID;";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@CustomerID", CustomerID);
                
                Object Result = command.ExecuteScalar();

                Total = Result != DBNull.Value ? Convert.ToDecimal(Result) : 0;

            } catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return Total;
        }

        public static bool GetDebtPaymentDetails(int PaymentID, ref string UserFullName, ref string CustomerFullName, ref decimal TotalInvoicesBefor, ref decimal TotalAmountPaidBefor, ref decimal RemainingAmountBefor, ref decimal AmountPaidAfter, ref decimal RemainingAmountAfter, ref int CountInvoices, ref DateTime DateTimePayment)
        {
            bool IsFound = false;

            string Query = @"select 

                            UPersons.FirstName +' '+ UPersons.LastName as UserFullName, 
                            CPersons.FirstName +' '+ CPersons.LastName as CustomerFullName,
                            Payments.CountInvoices,
                            Payments.TotalInvoicesBefor,
                            Payments.TotalAmountPaidBefor,
                            Payments.RemainingAmountBefor,
                            Payments.AmountPaidAfter,
                            Payments.RemainingAmountAfter,
                            DateTimePayment

                            From Payments inner join Users

                            On Payments.UserID = Users.ID

                            Inner Join Customers

                            On Payments.CustomerID = Customers.ID

                            Inner join Persons UPersons

                            On UPersons.ID = Users.PersonID

                            Inner Join Persons CPersons

                            On CPersons.ID = Customers.PersonID

                            where Payments.ID = @PaymentID;";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@PaymentID", PaymentID);

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows && reader.Read())
                {
                    IsFound = true;
                    TotalInvoicesBefor = reader["TotalInvoicesBefor"] != DBNull.Value ? Convert.ToDecimal(reader["TotalInvoicesBefor"]) : 0;
                    TotalAmountPaidBefor = reader["TotalAmountPaidBefor"] != DBNull.Value ? Convert.ToDecimal(reader["TotalAmountPaidBefor"]) : 0;
                    RemainingAmountBefor = reader["RemainingAmountBefor"] != DBNull.Value ? Convert.ToDecimal(reader["RemainingAmountBefor"]) : 0;
                    AmountPaidAfter = reader["AmountPaidAfter"] != DBNull.Value ? Convert.ToDecimal(reader["AmountPaidAfter"]) : 0;
                    RemainingAmountAfter = reader["RemainingAmountAfter"] != DBNull.Value ? Convert.ToDecimal(reader["RemainingAmountAfter"]) : 0;
                    CountInvoices = reader["CountInvoices"] != DBNull.Value ? Convert.ToInt32(reader["CountInvoices"]) : 0;
                    DateTimePayment = reader["DateTimePayment"] != DBNull.Value ? Convert.ToDateTime(reader["DateTimePayment"]) : DateTime.MinValue;
                    UserFullName = reader["UserFullName"] != DBNull.Value ? Convert.ToString(reader["UserFullName"]) : "";
                    CustomerFullName = reader["CustomerFullName"] != DBNull.Value ? Convert.ToString(reader["CustomerFullName"]) : "";
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsFound;
        }  
        
        public static decimal GetTotalAmountPaidPaymentsByCustomerID(int CustomerID)
        {
            decimal RemainingAmount = 0;

            string Query = @"select  SUM(AmountPaidAfter) As TotalAmountPaid From Payments where CustomerID = @CustomerID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@CustomerID", CustomerID);

                Object Result = command.ExecuteScalar();

                RemainingAmount = Result != DBNull.Value ? Convert.ToDecimal(Result) : 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return RemainingAmount;
        }

    }
}
