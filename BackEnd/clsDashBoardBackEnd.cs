using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEnd
{
    public class clsDashBoardBackEnd
    {
        static clsConnection clsConnection = new clsConnection();

        // استعلام عن نسبة البيعات الكاش والاجل بشكل يوم
        public static decimal GetSalesOfToDayCachAndDebt()
        {
            decimal Total = 0;

            // تعديل الاستعلام للتعامل مع الحقل DateInvoices من النوع DATETIME
            string Query = @"SELECT SUM(TotalInvoice) AS TotalSalesToDay
                     FROM Invoices
                     WHERE CAST(DateInvoice AS DATE) = CAST(GETDATE() AS DATE)";

            try
            {
                // فتح الاتصال بقاعدة البيانات
                clsConnection.connection.Open();

                // إنشاء وتنفيذ أمر SQL
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                object Result = command.ExecuteScalar();

                // تحويل النتيجة إلى رقم عشري
                Total = Result != DBNull.Value? Convert.ToDecimal(Result) : 0;
            }
            catch (Exception ex)
            {
                // تسجيل الخطأ
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // إغلاق الاتصال
                clsConnection.connection.Close();
            }

            return Total;
        } 
        
        // استعلام عن نسبة البيعات الكاش بشكل يوم
        public static decimal GetSalesOfToDayCach()
        {
            decimal Total = 0;

            // تعديل الاستعلام للتعامل مع الحقل DateInvoices من النوع DATETIME
            string Query = @"SELECT SUM(TotalInvoice) AS TotalSalesToDay
                     FROM Invoices
                     WHERE CAST(DateInvoice AS DATE) = CAST(GETDATE() AS DATE)  and TypeInvoiceID = 1";

            try
            {
                // فتح الاتصال بقاعدة البيانات
                clsConnection.connection.Open();

                // إنشاء وتنفيذ أمر SQL
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                object Result = command.ExecuteScalar();

                // تحويل النتيجة إلى رقم عشري
                Total = Result != DBNull.Value? Convert.ToDecimal(Result) : 0;
            }
            catch (Exception ex)
            {
                // تسجيل الخطأ
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // إغلاق الاتصال
                clsConnection.connection.Close();
            }

            return Total;
        } 
        
        
        // استعلام عن نسبة البيعات الاجل بشكل يوم
        public static decimal GetSalesOfToDayDebt()
        {
            decimal Total = 0;

            // تعديل الاستعلام للتعامل مع الحقل DateInvoices من النوع DATETIME
            string Query = @"SELECT SUM(TotalInvoice) AS TotalSalesToDay
                     FROM Invoices
                     WHERE CAST(DateInvoice AS DATE) = CAST(GETDATE() AS DATE) and TypeInvoiceID = 2";

            try
            {
                // فتح الاتصال بقاعدة البيانات
                clsConnection.connection.Open();

                // إنشاء وتنفيذ أمر SQL
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                object Result = command.ExecuteScalar();

                // تحويل النتيجة إلى رقم عشري
                Total = Result != DBNull.Value? Convert.ToDecimal(Result) : 0;
            }
            catch (Exception ex)
            {
                // تسجيل الخطأ
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // إغلاق الاتصال
                clsConnection.connection.Close();
            }

            return Total;
        } 
        
        // استعلام عن البالغ التي تم سدادة في المبيعات الاجل
        public static decimal GetSalesOfToDayDebtAmount()
        {
            decimal Total = 0;

            // تعديل الاستعلام للتعامل مع الحقل DateInvoices من النوع DATETIME
            string Query = @"select 
  
                          Sum(DebtInvoices.AmountPaid) As AmountPaidDebt

                          From Invoices inner join Debtinvoices

                          On Invoices.ID = DebtInvoices.InvoiceID

                          where Cast(Invoices.DateInvoice As Date) = Cast(GetDate() As Date);";

            try
            {
                // فتح الاتصال بقاعدة البيانات
                clsConnection.connection.Open();

                // إنشاء وتنفيذ أمر SQL
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                object Result = command.ExecuteScalar();

                // تحويل النتيجة إلى رقم عشري
                Total = Result != DBNull.Value? Convert.ToDecimal(Result) : 0;
            }
            catch (Exception ex)
            {
                // تسجيل الخطأ
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // إغلاق الاتصال
                clsConnection.connection.Close();
            }

            return Total;
        }

        // استعلام عن اجمالي الديون  
        public static decimal GetTotalDebtOfToDay()
        {
            decimal Total = 0;

            // تعديل الاستعلام للتعامل مع الحقل DateInvoices من النوع DATETIME
            string Query = @"select 
  
                          Sum(DebtInvoices.TotalInvoice) As TotalInvoiceDebt

                          From Invoices inner join Debtinvoices

                          On Invoices.ID = DebtInvoices.InvoiceID

                          where Cast(Invoices.DateInvoice As Date) = Cast(GetDate() As Date);";

            try
            {
                // فتح الاتصال بقاعدة البيانات
                clsConnection.connection.Open();

                // إنشاء وتنفيذ أمر SQL
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                object Result = command.ExecuteScalar();

                // تحويل النتيجة إلى رقم عشري
                Total = Result != DBNull.Value ? Convert.ToDecimal(Result) : 0;
            }
            catch (Exception ex)
            {
                // تسجيل الخطأ
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // إغلاق الاتصال
                clsConnection.connection.Close();
            }

            return Total;
        }



        // استعلام عن المبالغ التي تم سدادة في ديون اليوم  
        public static decimal GetTotalDebtOfToDayAmountPaid()
        {
            decimal Total = 0;

            // تعديل الاستعلام للتعامل مع الحقل DateInvoices من النوع DATETIME
            string Query = @"select 
  
                          Sum(DebtInvoices.AmountPaid) As AmountPaidDebt

                          From Invoices inner join Debtinvoices

                          On Invoices.ID = DebtInvoices.InvoiceID

                          where Cast(Invoices.DateInvoice As Date) = Cast(GetDate() As Date);";

            try
            {
                // فتح الاتصال بقاعدة البيانات
                clsConnection.connection.Open();

                // إنشاء وتنفيذ أمر SQL
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                object Result = command.ExecuteScalar();

                // تحويل النتيجة إلى رقم عشري
                Total = Result != DBNull.Value ? Convert.ToDecimal(Result) : 0;
            }
            catch (Exception ex)
            {
                // تسجيل الخطأ
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // إغلاق الاتصال
                clsConnection.connection.Close();
            }

            return Total;
        }

        // استعلام عن اجمالي المبالغ المتبقية من ديون اليوم
        public static decimal GetTotalDebtOfToDayRemainingAmount()
        {
            decimal Total = 0;

            // تعديل الاستعلام للتعامل مع الحقل DateInvoices من النوع DATETIME
            string Query = @"select 

                          Sum(DebtInvoices.RemainingAmount) As RemainingAmountDebt
                          
                          From Invoices inner join Debtinvoices

                          On Invoices.ID = DebtInvoices.InvoiceID

                          where Cast(Invoices.DateInvoice As Date) = Cast(GetDate() As Date);";

            try
            {
                // فتح الاتصال بقاعدة البيانات
                clsConnection.connection.Open();

                // إنشاء وتنفيذ أمر SQL
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                object Result = command.ExecuteScalar();

                // تحويل النتيجة إلى رقم عشري
                Total = Result != DBNull.Value ? Convert.ToDecimal(Result) : 0;
            }
            catch (Exception ex)
            {
                // تسجيل الخطأ
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // إغلاق الاتصال
                clsConnection.connection.Close();
            }

            return Total;
        } 
     

    }
}
