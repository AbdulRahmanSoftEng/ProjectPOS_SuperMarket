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
    public class clsInvoicePuyBackEnd
    {
        static clsConnection clsConnection = new clsConnection();
        // اضافة فاتورة شراء اصناف
        public static int AddNewInvoicePuy(int SupplierID, int UserID)
        {
            int id = -1;


            string Query = @"INSERT INTO InvoicesPuy
                            (SupplierID, UserID, DateTimeInvoice)
                            values(@SupplierID, @UserID, @DateTimeInvoice);
                            SELECT SCOPE_Identity()";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                command.Parameters.AddWithValue("@SupplierID", SupplierID);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@DateTimeInvoice", DateTime.Now);

                Object Result = command.ExecuteScalar();

                if(Result != DBNull.Value)
                    id = Convert.ToInt32(Result);

            }catch(Exception e)
            {
                // e.message
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return id;  

        }

        //ارجاع معلومات الفاتورة في الاسفل
        public static DataTable GetInvoicePuyFooter(int InvoiceID)
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT 
                                InvoicesPuy.ID, 
                                UPersons.FirstName + ' ' + UPersons.LastName AS UserFullName, -- اسم المستخدم بالكامل
	                            SPersons.FirstName + ' ' + SPersons.LastName AS SupplierFullName, -- اسم المورد بالكامل
                                FORMAT(InvoicesPuy.DateTimeInvoice, 'dd/MM/yyyy - hh:mm:ss tt') As DateTimeInvoice
                            FROM 
                                Users 
                            INNER JOIN 
                                Persons UPersons ON Users.PersonID = UPersons.ID -- ربط المستخدم مع جدول الأشخاص
                            INNER JOIN 
                                InvoicesPuy ON Users.ID = InvoicesPuy.UserID -- ربط المستخدم مع الفواتير
                            INNER JOIN 
                                Suppliers ON InvoicesPuy.SupplierID = Suppliers.ID -- ربط الموردين مع الفواتير
                            INNER JOIN 
                                Persons SPersons ON Suppliers.PersonID = SPersons.ID -- ربط الموردين مع جدول الأشخاص

                            WHERE 
                                InvoicesPuy.ID = @InvoiceID;
";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@InvoiceID", InvoiceID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) { 
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

        public static int GetLasNumbertInvoicePuy()
        {
            int Number = 0;

            string Query = @"SELECT Top 1 ID From InvoicesPuy order by ID desc";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                Object Result = command.ExecuteScalar();    

                Number = (Result != DBNull.Value)? Convert.ToInt32(Result) : 0;
            }catch(Exception ex)
            {
                //ex.message;
            }
            finally
            {
                clsConnection.connection.Close();

            }

            return Number;
        }
    }
}
