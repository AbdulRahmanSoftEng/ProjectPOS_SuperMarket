using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BackEnd
{
    public class clsSettingBackEnd
    {
        static clsConnection clsConnection = new clsConnection();
        public static string GetTitleSocke()
        {
            string Title = "";

            string Query = @"select Title From ProfileStock where ID = 1";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    Title = Convert.ToString(Result);
                }

            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return Title;
        }

        public static string GetLogoStocke()
        {
            string Logo = "";

            string Query = @"select Logo From ProfileStock where ID = 1";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    Logo = Convert.ToString(Result);
                }

            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return Logo;
        }

        public static int GetDefaultQuantityDemand()
        {
            int Num = -1;

            string Query = @"select DefaultQuantityDemand From Settings where ID = 1";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    Num = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return Num;
        }

        public static float GetTax()
        {
            float Tax = -1;

            string Query = @"select Tax From Settings where ID = 1";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                Object Result = command.ExecuteScalar();

                if(Result != DBNull.Value)
                {
                    Tax = Convert.ToSingle(Result);
                }

            }catch(Exception ex)
            {
                //ex.Message
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return Tax;
        }

        public static int GetTimeClearFiald()
        {
            int Time = -1;

            string Query = @"select TimeOfClearData From Settings where ID = 1";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    Time = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return Time;
        }

        public static int GetTimeMsgTasbih()
        {
            int Time = -1;

            string Query = @"select TimeOfMsgTasbih From Settings where ID = 1";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    Time = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return Time;
        }

        public static int GetTimeWaitingInvoice()
        {
            int Time = -1;

            string Query = @"select TimeOfWaitingInvoice From Settings where ID = 1";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    Time = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return Time;
        }

        public static int GetTimeBackUpDB()
        {
            int Time = -1;

            string Query = @"select TimeOfBackUpDB From Settings where ID = 1";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    Time = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return Time;
        }

        public static bool UpdateDefaultValues(int DefaultQuantityDemand, int Tax, int TimeOfWaitingInvoice, int TimeOfClearData, int TimeOfMsgTasbih, int TimeOfBackUpDB)
        {
            bool IsUpdate = false;

            string Query = @"Update Settings set

                            DefaultQuantityDemand = @DefaultQuantityDemand,
                            Tax = @Tax,
                            TimeOfWaitingInvoice = @TimeOfWaitingInvoice,
                            TimeOfClearData = @TimeOfClearData,
                            TimeOfMsgTasbih = @TimeOfMsgTasbih,
                            TimeOfBackUpDB = @TimeOfBackUpDB

                            FROM Settings where ID = 1";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@DefaultQuantityDemand", DefaultQuantityDemand);
                command.Parameters.AddWithValue("@Tax", Tax);
                command.Parameters.AddWithValue("@TimeOfWaitingInvoice", TimeOfWaitingInvoice);
                command.Parameters.AddWithValue("@TimeOfClearData", TimeOfClearData);
                command.Parameters.AddWithValue("@TimeOfMsgTasbih", TimeOfMsgTasbih);
                command.Parameters.AddWithValue("@TimeOfBackUpDB", TimeOfBackUpDB);

                int rowAffected = command.ExecuteNonQuery();
                if(rowAffected > 0)
                {
                    IsUpdate = true;
                }

            }catch(Exception ex)
            {
                IsUpdate = false;
            }
            finally { clsConnection.connection.Close(); }

            return IsUpdate;
        }

        // انشاء نسخة احطياطة من قاعدة البيانات مع الاختلافات
        public static bool BackUpDatabase(string Path)
        {
            bool isSuccess = false;

            // تأكد من أن المسار ينتهي بـ \
            if (!Path.EndsWith("\\"))
            {
                Path += "\\";
            }

            // تكوين اسم ملف النسخة الاحتياطية
            string backupFilePath = Path + clsConnection._DatabaseName + ".bak";

            string Query = $@"
                            DECLARE @FilePath NVARCHAR(260) = '{backupFilePath}';
                            DECLARE @FileExists INT;

                            EXEC xp_fileexist @FilePath, @FileExists OUTPUT;

                            IF @FileExists = 1
                                BACKUP DATABASE [{clsConnection._DatabaseName}]
                                TO DISK = '{backupFilePath}'
                                WITH DIFFERENTIAL;
                            ELSE
                                BACKUP DATABASE [{clsConnection._DatabaseName}]
                                TO DISK = '{backupFilePath}'";
                            

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                // تنفيذ الاستعلام
                command.ExecuteNonQuery();

                isSuccess = true; // إذا نجح التنفيذ
            }
            catch (Exception ex)
            {
                // يمكن تسجيل الخطأ هنا
                Console.WriteLine($"Error: {ex.Message}");
                isSuccess = false;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return isSuccess;
        }

        public static bool RestoreDatabase(string backupFilePath)
        {
            bool isSuccess = false;

            if (!File.Exists(backupFilePath))
            {
                Console.WriteLine("Backup file does not exist.");
                return false;
            }

            string Query = $@"
                            USE master;
                            ALTER DATABASE [{clsConnection._DatabaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

                            RESTORE DATABASE [{clsConnection._DatabaseName}] FROM DISK = '{backupFilePath}' WITH REPLACE;

                            ALTER DATABASE [{clsConnection._DatabaseName}] SET MULTI_USER;";

            /*string Query = $@"use master
                            Alter Database [{clsConnection._DatabaseName}] set offline with ROLLBACK IMMEDIATE;
                            Restore database [{clsConnection._DatabaseName}] FROM Disk = '{backupFilePath}'
                            with replace;";*/

            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
                Console.WriteLine($"SQL State: {sqlEx.State}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
            finally
            {
                if (clsConnection.connection.State == System.Data.ConnectionState.Open)
                {
                    clsConnection.connection.Close();
                }
            }

            return isSuccess;
        }


        // get information of profile stock
        public static DataTable GetInfoProfileStock()
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT TOP 1 
                             [ID]
                            ,[Title]
                            ,[Owner]
                            ,[City]
                            ,[Street]
                            ,[InFrontOfStock]
                            ,[Location]
                            ,[WebSite]
                            ,[Logo]
                        FROM [ProfileStock]";

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
            }catch(Exception ex)
            {
                //ex.Message
            }
            finally { clsConnection.connection.Close(); }
            return dt;
        }

        public static bool UpdateProfile( int ID,  string Title,  string Owner,  string City,  string Street,  string InFrontOfStock,  string Location,  string WebSite,  string Logo)
        {
            bool IsFound = false;

            string Query = @"Update ProfileStock set
                            Title = @Title, 
                            Owner = @Owner,
                            City = @City,
                            Street = @Street,
                            InFrontOfStock = @InFrontOfStock,
                            Location = @Location,
                            WebSite = @WebSite,
                            Logo = @Logo

                            where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Title", Title);
                command.Parameters.AddWithValue("@Owner", Owner);
                command.Parameters.AddWithValue("@City", City);
                command.Parameters.AddWithValue("@Street", Street);
                command.Parameters.AddWithValue("@InFrontOfStock", InFrontOfStock);
                command.Parameters.AddWithValue("@Location", Location);
                command.Parameters.AddWithValue("@WebSite", WebSite);
                command.Parameters.AddWithValue("@Logo", Logo);

                int rowAffected = command.ExecuteNonQuery();

                if(rowAffected > 0)
                {
                    IsFound = true;
                }

            }catch(Exception ex)
            {

            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound;
        } 
        
        public static bool AddProfileStock( int ID,  string Title,  string Owner,  string City,  string Street,  string InFrontOfStock,  string Location,  string WebSite,  string Logo)
        {
            bool IsFound = false;

            string Query = @"Insert Into ProfileStock(Title, Owner, City, Street, InFrontOfStock, Location, WebSite, Logo)values(@Title,@Owner,@City,@Street,@InFrontOfStock, @Location,@WebSite,@Logo)";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                command.Parameters.AddWithValue("@Title", Title);
                command.Parameters.AddWithValue("@Owner", Owner);
                command.Parameters.AddWithValue("@City", City);
                command.Parameters.AddWithValue("@Street", Street);
                command.Parameters.AddWithValue("@InFrontOfStock", InFrontOfStock);
                command.Parameters.AddWithValue("@Location", Location);
                command.Parameters.AddWithValue("@WebSite", WebSite);
                command.Parameters.AddWithValue("@Logo", Logo);

                int rowAffected = command.ExecuteNonQuery();

                if(rowAffected > 0)
                {
                    IsFound = true;
                }

            }catch(Exception ex)
            {

            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound;
        } 
        
        public static bool FindProfileStock(ref int ID, ref string Title, ref string Owner, ref string City, ref string Street, ref string InFrontOfStock, ref string Location, ref  string WebSite,  ref string Logo)
        {
            bool IsFound = false;

            string Query = @"Select * from ProfileStock where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);

                SqlDataReader readre = command.ExecuteReader();

                if(readre.HasRows)
                {
                    IsFound = true;
                    ID = readre["ID"] != DBNull.Value? Convert.ToInt32(readre["ID"]) : 0;
                    Title = readre["Title"] != DBNull.Value? Convert.ToString(readre["Title"]): "";
                    Owner = readre["Owner"] != DBNull.Value ? Convert.ToString(readre["Owner"]) : "";
                    City = readre["City"] != DBNull.Value ? Convert.ToString(readre["City"]) : "";
                    Street = readre["Street"] != DBNull.Value ? Convert.ToString(readre["Street"]) : "";
                    InFrontOfStock = readre["InFrontOfStock"] != DBNull.Value ? Convert.ToString(readre["InFrontOfStock"]) : "";
                    Location = readre["Location"] != DBNull.Value ? Convert.ToString(readre["Location"]) : "";
                    WebSite = readre["WebSite"] != DBNull.Value ? Convert.ToString(readre["WebSite"]) : "";
                    Logo = readre["Logo"] != DBNull.Value ? Convert.ToString(readre["Logo"]) : "";
                }

            }catch(Exception ex)
            {

            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound;
        }
    }
}
