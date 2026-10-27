using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class clsReturnItemsBackEnd
    {
        static clsConnection clsConnection = new clsConnection();
        // تخزين بيانات الفاتورة التي تم استرجاعها قبل التعديل
        public static bool AddNewReturnInvoiceDetails(int ProductID, int InvoiceID, int QtyItem, float TotalAmount)
        {
            bool IsFound = false;

            string Query = @"insert into ReturnInvoiceDetails(ProductID, InvoiceID, QtyItem, TotalAmount) values(@ProductID, @InvoiceID, @QtyItem, @TotalAmount);";

            try
            {

                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ProductID", ProductID);
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                command.Parameters.AddWithValue("@QtyItem", QtyItem);
                command.Parameters.AddWithValue("@TotalAmount", TotalAmount);

                int rowAffcted = command.ExecuteNonQuery();

                IsFound = (rowAffcted > 0);
               
            }
            catch (Exception ex)
            {
                //ex.message
            }
            finally { clsConnection.connection.Close(); }

            return IsFound;
        }

        // تخزين معلومات الفاتورة التي تم استرجاعها قبل التعديل
        public static int AddNewReturnInvoice(int InvoiceID, int UserID, float TotalReturnInvoice, float AmountPaidInvoiceReturn, float RemainingAmountReturn)
        {
            int ID = -1;

            string Query = @"insert into ReturnInvoice(InvoiceID, UserID, DateTimeInvoice, TotalInvoiceReturn, AmountPaidInvoiceReturn, RemainingAmount)
                            values(@InvoiceID, @UserID, @DateTimeInvoice, @TotalInvoiceReturn, @AmountPaidInvoiceReturn, @RemainingAmount); SELECT SCOPE_IDENTITY()";

            try
            {

                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@DateTimeInvoice", DateTime.Now);
                command.Parameters.AddWithValue("@TotalInvoiceReturn", TotalReturnInvoice);
                command.Parameters.AddWithValue("@AmountPaidInvoiceReturn", AmountPaidInvoiceReturn);
                command.Parameters.AddWithValue("@RemainingAmount", RemainingAmountReturn);

                Object Result = command.ExecuteScalar();

                if(Result != DBNull.Value)
                {
                    ID = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                //ex.message
            }
            finally { clsConnection.connection.Close(); }

            return ID;
        }

        // تخزين معلومات الفاتورة التي تم استرجاعها قبل التعديل
        public static int AddNewReturnInvoice(int InvoiceID, int UserID, float TotalReturnInvoice)
        {
            int ID = -1;
            
            string Query = @"INSERT INTO ReturnInvoice(InvoiceID, UserID, DateTimeInvoice, TotalInvoiceReturn) values(@InvoiceID, @UserID, @DateTimeInvoice, @TotalInvoiceReturn);
                             Select SCOPE_Identity()";

            try
            {

                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@DateTimeInvoice", DateTime.Now);
                command.Parameters.AddWithValue("@TotalInvoiceReturn", TotalReturnInvoice);

                Object Result = command.ExecuteScalar();

                if( Result != DBNull.Value)
                {
                    ID = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                //ex.message
            }
            finally { clsConnection.connection.Close(); }

            return ID;
        }

        public static DataTable GetInvoiceDetails(int InvoiceID)
        {
            DataTable dt = new DataTable();

            string Query = @"select Products.Name, Products.Price, InvoiceDetails.QtyItems, InvoiceDetails.TotalAmount

                            From InvoiceDetails Inner Join Products

                                On InvoiceDetails.ProductID = Products.ID

                            where InvoiceDetails.InvoiceID = @InvoiceID;";

            try {

                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                //ex.message
            }
            finally { clsConnection.connection.Close(); }

            return dt;
        }

        public static DataTable GetInvoice(int InvoiceID)
        {
            DataTable dt = new DataTable();

            string Query = @"select Invoices.ID, Persons.FirstName +' '+ Persons.LastName As UserFullName, Invoices.TotalInvoice, Invoices.DateInvoice, TypeInvoices.Name

                            From Invoices Inner join Users

                                On Users.ID = Invoices.UserID

                            Inner join TypeInvoices

                                On TypeInvoices.ID = Invoices.TypeInvoiceID

                            Inner join Persons

                                On Persons.ID = Users.PersonID

                            Where Invoices.ID = @InvoiceID;";

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
            }
            catch (Exception ex)
            {
                //ex.message
            }
            finally { clsConnection.connection.Close(); }

            return dt;
        }
        
        public static bool FindInvoiceByInvoiceID(ref int InvoiceID, ref float TotalInvoice, ref DateTime DateInvoice, ref string UserFullName, ref string TypeInvoice)
        {
            bool IsFound = false;

            string Query = @"select Invoices.ID, Invoices.TotalInvoice,  Invoices.DateInvoice, TypeInvoices.Name as TypeInvoiceName , Persons.FirstName +' '+ Persons.LastName As UserFullName

                            From Invoices Inner join Users

                                On Users.ID = Invoices.UserID

                            Inner join TypeInvoices

                                On TypeInvoices.ID = Invoices.TypeInvoiceID

                            Inner join Persons

                                On Persons.ID = Users.PersonID

                            Where Invoices.ID = @InvoiceID";

            try
            {

                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    IsFound = true;
                    InvoiceID = reader["ID"] !=  DBNull.Value? Convert.ToInt32(reader["ID"]) : 0;
                    TotalInvoice = reader["TotalInvoice"] !=  DBNull.Value? Convert.ToSingle(reader["TotalInvoice"]) : 00;
                    DateInvoice = reader["DateInvoice"] !=  DBNull.Value? Convert.ToDateTime(reader["DateInvoice"]) : DateTime.MinValue;
                    TypeInvoice = reader["TypeInvoiceName"] !=  DBNull.Value? Convert.ToString(reader["TypeInvoiceName"]) : "";
                    UserFullName = reader["UserFullName"] !=  DBNull.Value? Convert.ToString(reader["UserFullName"]) : "";
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                //ex.message
            }
            finally { clsConnection.connection.Close(); }

            return IsFound;
        }
        
        public static string GetCustomerFullNameByInvoiceID(int InvoiceID)
        {
            string CustomerFullName = "";

            string Query = @"select Persons.FirstName +' '+ Persons.LastName as CustomerFullName

                            From Invoices inner join Customers

                            On Invoices.CustomerID = Customers.ID

                            Inner join Persons

                            On Persons.ID = Customers.PersonID

                            where Invoices.ID = @InvoiceID";

            try
            {

                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                Object Result = command.ExecuteScalar();

                CustomerFullName = Result != DBNull.Value ? Convert.ToString(Result) : "";

            }
            catch (Exception ex)
            {
                //ex.message
            }
            finally { clsConnection.connection.Close(); }

            return CustomerFullName;
        }

        public static bool DeleteInvoice(int InvoiceID)
        {
            bool IsDeleted = false;

            int rowAffctedOfInvoiceDetails = 0, rowAffectedOfInvoice = 0, rowAffectedOfDebtInvoice = 0;

            string QueryToTableInvoiceDetails = @"Delete from InvoiceDetails

                            where InvoiceDetails.InvoiceID = @InvoiceID";           
            
            string QueryToTableDebtInvoices = @"Delete from DebtInvoices

                            where DebtInvoices.InvoiceID = @InvoiceID";

            string QueryToTableInvoice = @"Delete from Invoices

                            where Invoices.ID = @InvoiceID";

            try
            {

                clsConnection.connection.Open();

                SqlCommand command1 = new SqlCommand(QueryToTableInvoiceDetails, clsConnection.connection);
                command1.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                rowAffctedOfInvoiceDetails = command1.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand(QueryToTableDebtInvoices, clsConnection.connection);
                command2.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                rowAffectedOfDebtInvoice = command2.ExecuteNonQuery();

                SqlCommand command3 = new SqlCommand(QueryToTableInvoice, clsConnection.connection);
                command3.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                rowAffectedOfInvoice = command3.ExecuteNonQuery();

                if (rowAffctedOfInvoiceDetails > 0 &&  rowAffectedOfInvoice > 0 )
                    IsDeleted = true;

            }
            catch (Exception ex)
            {
                //ex.message
            }
            finally { clsConnection.connection.Close(); }

            return IsDeleted;
        }

        // update invoice details
        public static bool UpdateInvoiceDetails(int InvoiceID, string ProductName, int QtyItem, float TotalPriceItems)
        {
            bool IsDeleted = false;

            string Query = @"update InvoiceDetails set
                             QtyItems = @QtyItem,
                             TotalAmount = @TotalPriceItems
 
                             where InvoiceID = @InvoiceID and ProductID = (select Top 1 ID From Products where Name = @ProductName);";

            try
            {

                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@QtyItem", QtyItem);
                command.Parameters.AddWithValue("@TotalPriceItems", TotalPriceItems);

                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                command.Parameters.AddWithValue("@ProductName", ProductName);
                int rowAffected = command.ExecuteNonQuery();
                
                if( rowAffected > 0 )
                    IsDeleted = true;

            }
            catch (Exception ex)
            {
                //ex.message
            }
            finally { clsConnection.connection.Close(); }

            return IsDeleted;
        }


        // تعديل اجمالي الفاتورة بعد تعديل تفاصيل الفاتورة
        public static bool UpdateInvoice(int InvoiceID, float TotalInvoice)
        {
            bool IsDeleted = false;

            string Query = @" Update Invoices set

                             TotalInvoice = @TotalInvoice,
                             DateInvoice = @DateInvoice

                             where ID = @InvoiceID;";

            try
            {

                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                command.Parameters.AddWithValue("@TotalInvoice", TotalInvoice);
                command.Parameters.AddWithValue("@DateInvoice", DateTime.Now);
                int rowAffected = command.ExecuteNonQuery();

                if (rowAffected > 0)
                    IsDeleted = true;

            }
            catch (Exception ex)
            {
                //ex.message
            }
            finally { clsConnection.connection.Close(); }

            return IsDeleted;
        }

        // حذف صنف من تفاصيل الفاتورة 
        public static bool DeleteItemFromInvoiceDetails(int InvoiceID, string ProductName)
        {
            bool IsDeleted = false;

            // يمكن يحدث خطا في الاستعلام بسبب عدم البحث باستخدام الباركود
            string Query = @"delete From InvoiceDetails

                            where InvoiceID = @InvoiceID and ProductID = (select ID From Products where Name = @ProductName);";

            try
            {

                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                command.Parameters.AddWithValue("@ProductName", ProductName);
                int rowAffected = command.ExecuteNonQuery();

                    IsDeleted = (rowAffected > 0);

            }
            catch (Exception ex)
            {
                //ex.message
            }
            finally { clsConnection.connection.Close(); }

            return IsDeleted;
        }

        // استرجاع معلمومات من جدول الديون من خلال رقم الفاتورة
        public static bool FindDebtInvoiceByInvoiceID(int InvoiceID, ref float AmountPaid, ref float RemainingAmount)
        {
            bool IsFound = false;

            string Query = @"select AmountPaid, RemainingAmount from DebtInvoices where InvoiceID = @InvoiceID;";


            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    IsFound = true;
                    AmountPaid = reader["AmountPaid"] != DBNull.Value ? Convert.ToSingle(reader["AmountPaid"]) : -1;
                    RemainingAmount = reader["RemainingAmount"] != DBNull.Value ? Convert.ToSingle(reader["RemainingAmount"]) : -1;
                }
                    

            }
            catch (Exception ex)
            {
                IsFound = false;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound;
        }

        // تعديل معلومات من جدول الديون من خالال رقم الفاتورة
        public static bool UpdateDebtInvoiceByInvoiceID(int InvoiceID, float TotalInvoice, float AmountPaid, float RemainingAmount)
        {
            bool IsFound = false;

            string Query = @"Update DebtInvoices set

                             TotalInvoice = @TotalInvoice,
                             AmountPaid = @AmountPaid,
                             RemainingAmount = @RemainingAmount

                             where InvoiceID = @InvoiceID;";


            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                command.Parameters.AddWithValue("@TotalInvoice", TotalInvoice);
                command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
                command.Parameters.AddWithValue("@RemainingAmount", RemainingAmount);

                int Result = command.ExecuteNonQuery();

                if (Result > 0)
                    IsFound = true;

            }
            catch (Exception ex)
            {
                IsFound = false;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound;
        }  
        
        // التحقق من ان الفاتورة موجوده في جدول الفواتير المسترجعة
        public static bool IsExistReturnInvoiceByInvoiceID(int InvoiceID)
        {
            bool IsFound = false;

            string Query = @"select * From ReturnInvoice

                             where InvoiceID = @InvoiceID;";


            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);


                Object Result = command.ExecuteScalar();

                int count = Convert.ToInt32(command.ExecuteScalar());
                IsFound = (count > 0);

            }
            catch (Exception ex)
            {
                //IsFound = false;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound;
        } 
        
        // تعديل على القيمة السابقة للفاتورة المسترجعة مرة ثانية
        public static bool UpdateTotalInvoiceBeforEdit(int InvoiceID, float TotalInvoiceBeforEdit)
        {
            bool IsFound = false;

            string Query = @"Update ReturnInvoice set
                             TotalInvoiceReturn = @TotalInvoiceBeforEdit
                             where InvoiceID = @InvoiceID;";


            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                command.Parameters.AddWithValue("@TotalInvoiceBeforEdit", TotalInvoiceBeforEdit);


                Object Result = command.ExecuteScalar();

                int count = Convert.ToInt32(command.ExecuteNonQuery());
                IsFound = (count > 0);

            }
            catch (Exception ex)
            {
                //IsFound = false;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound;
        }

    }
}
