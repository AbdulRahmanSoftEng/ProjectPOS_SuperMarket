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
    public class clsTasbihBackEnd
    {
        static clsConnection clsConnection = new clsConnection();

        public static DataTable GetAllTasbih()
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT
                 [ID] As الرقم
                ,[Name] As الرسالة
                ,[Bred]
                ,[Bgreen]
                ,[Bblue]
                ,[Fred]
                ,[Fgreen]
                ,[Fblue]
            FROM [Tasbihs]";


            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
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
        
        public static DataTable FindTasbihByNameUsingLike(string Name)
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT
                 [ID] As الرقم
                ,[Name] As الرسالة
                ,[Bred]
                ,[Bgreen]
                ,[Bblue]
                ,[Fred]
                ,[Fgreen]
                ,[Fblue]
            FROM [Tasbihs]

            where Name Like '%'+@Name+'%'";


            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", Name);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
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


        public static bool GetTasbih(ref string Name, ref byte bred, ref byte bgreen, ref byte bblue, ref byte fred, ref byte fgreen, ref byte fblue)
        {
            bool IsFound = false;

            string Query = @"SELECT TOP 1 
                [Name]
                ,[Bred]
                ,[Bgreen]
                ,[Bblue]
                ,[Fred]
                ,[Fgreen]
                ,[Fblue]
            From [Tasbihs]

            Order by  NEWID();";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true; //Names of columns => ID, Name, Bred, Bgreen, Bblue, Fred, Fgreen, Fblue
                    Name = Reader["Name"] != DBNull.Value ? Convert.ToString(Reader["Name"]) : "";
                    bred = Reader["Bred"] != DBNull.Value ? Convert.ToByte(Reader["Bred"]) : (byte)255;
                    bgreen = Reader["Bgreen"] != DBNull.Value ? Convert.ToByte(Reader["Bgreen"]) : (byte)255;
                    bblue = Reader["Bblue"] != DBNull.Value ? Convert.ToByte(Reader["Bblue"]) : (byte)255;
                    fred = Reader["Fred"] != DBNull.Value ? Convert.ToByte(Reader["Fred"]) : (byte)0;
                    fgreen = Reader["Fgreen"] != DBNull.Value ? Convert.ToByte(Reader["Fgreen"]) : (byte)0;
                    fblue = Reader["Fblue"] != DBNull.Value ? Convert.ToByte(Reader["Fblue"]) : (byte)0;

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

            return IsFound;
        }
        
        public static bool FindTasbihByID(int ID, ref string Name, ref byte bred, ref byte bgreen, ref byte bblue, ref byte fred, ref byte fgreen, ref byte fblue)
        {
            bool IsFound = false;

            string Query = @"SELECT 
                 [ID]
                ,[Name]
                ,[Bred]
                ,[Bgreen]
                ,[Bblue]
                ,[Fred]
                ,[Fgreen]
                ,[Fblue]

            From [Tasbihs]

            where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true; //Names of columns => ID, Name, Bred, Bgreen, Bblue, Fred, Fgreen, Fblue
                    ID = Reader["ID"] != DBNull.Value ? Convert.ToInt32(Reader["ID"]) : 0;
                    Name = Reader["Name"] != DBNull.Value ? Convert.ToString(Reader["Name"]) : "";
                    bred = Reader["Bred"] != DBNull.Value ? Convert.ToByte(Reader["Bred"]) : (byte)255;
                    bgreen = Reader["Bgreen"] != DBNull.Value ? Convert.ToByte(Reader["Bgreen"]) : (byte)255;
                    bblue = Reader["Bblue"] != DBNull.Value ? Convert.ToByte(Reader["Bblue"]) : (byte)255;
                    fred = Reader["Fred"] != DBNull.Value ? Convert.ToByte(Reader["Fred"]) : (byte)0;
                    fgreen = Reader["Fgreen"] != DBNull.Value ? Convert.ToByte(Reader["Fgreen"]) : (byte)0;
                    fblue = Reader["Fblue"] != DBNull.Value ? Convert.ToByte(Reader["Fblue"]) : (byte)0;

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

            return IsFound;
        }

        public static bool AddNew(string Name, byte Bred, byte Bgreen, byte Bblue, byte Fred, byte Fgreen, byte Fblue)
        {
            bool IsFound = false;

            string Query = @"insert into Tasbihs(Name, Bred, Bgreen, Bblue, Fred, Fgreen, Fblue)values(@Name, @Bred, @Bgreen, @Bblue, @Fred, @Fgreen, @Fblue)";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Bred", Bred);
                command.Parameters.AddWithValue("@Bgreen", Bgreen);
                command.Parameters.AddWithValue("@Bblue", Bblue);
                command.Parameters.AddWithValue("@Fred", Fred);
                command.Parameters.AddWithValue("@Fgreen", Fgreen);
                command.Parameters.AddWithValue("@Fblue", Fblue);

                int rowAffected = command.ExecuteNonQuery();

                IsFound = rowAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound;
        }

        public static bool Update(int ID, string Name, byte Bred, byte Bgreen, byte Bblue, byte Fred, byte Fgreen, byte Fblue)
        {
            bool IsFound = false;

            string Query = @"Update Tasbihs set
            Name = @Name,
            Bred = @Bred,
            Bgreen = @Bgreen,
            Bblue = @Bblue,
            Fred = @Fred,
            Fgreen = @Fgreen,
            Fblue = @Fblue
            
            From Tasbihs

            where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Bred", Bred);
                command.Parameters.AddWithValue("@Bgreen", Bgreen);
                command.Parameters.AddWithValue("@Bblue", Bblue);
                command.Parameters.AddWithValue("@Fred", Fred);
                command.Parameters.AddWithValue("@Fgreen", Fgreen);
                command.Parameters.AddWithValue("@Fblue", Fblue);

                int rowAffected = command.ExecuteNonQuery();

                IsFound = rowAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound;
        }

        public static bool Delete(int ID)
        {
            bool IsFound = false;

            string Query = @"delete From Tasbihs

            where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);

                int rowAffected = command.ExecuteNonQuery();

                IsFound = rowAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound;
        }
         
        public static bool IsExistTasbih(int ID)
        {
            bool IsFound = false;

            string Query = @"select ID From Tasbihs where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);

                Object Result = command.ExecuteScalar();

                IsFound = Result != DBNull.Value? true : false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound;
        }
        
        public static bool IsExistTasbihByName(string Name)
        {
            bool IsFound = false;

            string Query = @"select Name From Tasbihs where Name = @Name";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", Name);

                Object Result = command.ExecuteScalar();

                IsFound = Result != DBNull.Value && Result != null? true : false;
            }
            catch (Exception ex)
            {
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
