using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class clsSalesCacherBackEnd
    {
        static clsConnection clsConnection = new clsConnection();
        public static DataTable GetAllTypeInvoices()
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT Name From TypeInvoices";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
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

        public static int GetTypeInvoiceIDByName(string Name)
        {
            string Query = @"SELECT ID From TypeInvoices where Name = @Name";

            int ID = -1;
            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", Name);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    ID = Convert.ToInt32(Result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return ID;
        }

       
    }
}
