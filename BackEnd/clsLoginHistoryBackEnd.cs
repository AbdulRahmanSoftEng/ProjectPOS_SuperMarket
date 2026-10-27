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
    public class clsLoginHistoryBackEnd
    {
        static clsConnection clsConnection = new clsConnection();
        public static DataTable GetAllLoginHistory()
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT 
                LoginHistory.ID AS الرقم,
                Persons.FirstName + ' ' + Persons.LastName AS المستخدم,
    
                -- استخراج التاريخ فقط
                FORMAT(LoginHistory.LoginDate, 'dd/MM/yyyy') AS تاريخ_الدخول,
                FORMAT(LoginHistory.LoginDate, 'hh:mm:ss tt') AS توقيت_الدخول,
    
                FORMAT(LoginHistory.ExitDate, 'dd/MM/yyyy') AS تاريخ_الخروج,
                FORMAT(LoginHistory.ExitDate, 'hh:mm:ss tt') AS توقيت_الخروج,

                -- حساب إجمالي الوقت باستخدام DATEDIFF والـ TIME FORMAT الصحيح
                FORMAT(DATEADD(SECOND, DATEDIFF(SECOND, LoginHistory.LoginDate, LoginHistory.ExitDate), '00:00:00'), 'HH:mm:ss') 
                AS اجمالي_الوقت_في_استخدام_النظام

            FROM Users 
            INNER JOIN LoginHistory ON Users.ID = LoginHistory.UserID
            INNER JOIN Persons ON Persons.ID = Users.PersonID

            ORDER BY LoginHistory.ID DESC;";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                SqlDataReader Reader = command.ExecuteReader();

                if(Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return dt;
        }

        public static DataTable FindLoginHistoryByUserFirstName(string FirstName)
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT 
                LoginHistory.ID AS الرقم,
                Persons.FirstName + ' ' + Persons.LastName AS المستخدم,
    
                -- استخراج التاريخ فقط
                FORMAT(LoginHistory.LoginDate, 'dd/MM/yyyy') AS تاريخ_الدخول,
                FORMAT(LoginHistory.LoginDate, 'hh:mm:ss tt') AS توقيت_الدخول,
    
                FORMAT(LoginHistory.ExitDate, 'dd/MM/yyyy') AS تاريخ_الخروج,
                FORMAT(LoginHistory.ExitDate, 'hh:mm:ss tt') AS توقيت_الخروج,

                -- حساب إجمالي الوقت باستخدام DATEDIFF والـ TIME FORMAT الصحيح
                FORMAT(DATEADD(SECOND, DATEDIFF(SECOND, LoginHistory.LoginDate, LoginHistory.ExitDate), '00:00:00'), 'HH:mm:ss') 
                AS اجمالي_الوقت_في_استخدام_النظام

            FROM Users 
            INNER JOIN LoginHistory ON Users.ID = LoginHistory.UserID
            INNER JOIN Persons ON Persons.ID = Users.PersonID

			where Persons.FirstName like '%'+ @FirstName +'%' Order by Persons.ID DESC ";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@FirstName", FirstName);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return dt;
        }
    }
}
