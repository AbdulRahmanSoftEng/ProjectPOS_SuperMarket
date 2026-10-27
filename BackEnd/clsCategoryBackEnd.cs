using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class clsCategoryBackEnd
    {
        static clsConnection clsConnection = new clsConnection();

        // get all Categories
        public static DataTable GetAllCategories()
        {
            DataTable dt = new DataTable();

            //string Query = @"Select * from Categories";

            string Query = @"Select
                        ID as الارقم,
                        Name as الاسم,
                        Description as الوصف

                        from Categories order by ID asc";

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

            }catch(Exception ex)
            {
                // ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return dt;
        }

        // Search Category Using Like By Name
        public static DataTable SearchCategoryUsingLikeByName(string Name)
        {
            DataTable dt = new DataTable();

            string Query = @"Select * from Categories where Name like '%'+@Name+'%'";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", Name);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);

                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                // ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return dt;
        }

        // Add new category
        public static bool AddNewCategory(string Name, string Description)
        {
            bool IsFound = false;

            string Query = @"Insert into Categories(Name, Description) values(@Name, @Description)";

            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", Name);

                if (Description != "")
                    command.Parameters.AddWithValue("@Description", Description);
                else
                    command.Parameters.AddWithValue("@Description", DBNull.Value);

                int rowAffected = command.ExecuteNonQuery();

                if(rowAffected > 0)
                {
                    IsFound = true;
                }

            }
            catch (Exception ex)
            {
                // ex.Message
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsFound;
        }

        // Update Category Info
        public static bool UpdateCategory(int ID, string Name, string Description)
        {
            bool IsFound = false;

            string Query = @"Update Categories set Name = @Name,  Description = @Description where ID = @ID";

            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Name", Name);

                if(Description != "")
                    command.Parameters.AddWithValue("@Description", Description);
                else
                    command.Parameters.AddWithValue("@Description", DBNull.Value);

                int rowAffected = command.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    IsFound = true;
                }

            }
            catch (Exception ex)
            {
                // ex.Message
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsFound;
        }

        // find category by id
        public static bool FindCategoryByID(int ID, out string Name, out string Description)
        {
            Name = null;
            Description = null;
            bool IsFound = false;

            string query = @"SELECT * FROM Categories WHERE ID = @ID";

            try
            {
                clsConnection.connection.Open();

                using (SqlCommand command = new SqlCommand(query, clsConnection.connection))
                {
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IsFound = true;
                            Name = reader["Name"]?.ToString();
                            Description = reader["Description"]?.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound;
        }


        // find category by Name
        public static bool FindCategoryByName(ref int ID, ref string Name, ref string Description)
        {
            bool IsFound = false;

            string Query = @"Select * from Categories where Name = @Name";
            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", Name);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    IsFound = true;
                    ID = (int)Reader["ID"];
                    Name = Reader["Name"]?.ToString();
                    Description = Reader["Description"]?.ToString();
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsFound;
        }

        

        // get ID of Category by Name
        public static int GetCategoryIDByName(string Name)
        {
            int ID = -1;
            string Query = @"Select ID from Categories where Name = @Name";

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
                // ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return ID;
        }



        // get ID of Category by Name
        public static string GetCategoryNameByID(int ID)
        {
            string Name = "";
            string Query = @"Select Name from Categories where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    Name =  Result.ToString();
                }
            }
            catch (Exception ex)
            {
                // ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return Name;
        }


        public static bool DeleteCategory(int ID)
        {
            bool IsDeleted = false;

            int rowAffectedInProducts = -1, rowAffectedInCategories = -1;

            string QueryToProducts = @"delete from Products where CategoryID = @CategoryID";

            string QueryToCategories = @"delete from Categories where ID = @ID";
            try
            {
                clsConnection.connection.Open();

                SqlCommand command1 = new SqlCommand(QueryToProducts, clsConnection.connection);
                command1.Parameters.AddWithValue("@CategoryID", ID);
                rowAffectedInProducts = command1.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand(QueryToCategories, clsConnection.connection);
                command2.Parameters.AddWithValue("@ID", ID);
                rowAffectedInCategories = command2.ExecuteNonQuery();

                if(rowAffectedInCategories > 0)
                {
                    IsDeleted = true;
                }

            }catch(Exception ex)
            {
                IsDeleted = false;
                Console.WriteLine("ERROR: Command executed");
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsDeleted;
        }
        
        // category is exist by id
        public static bool CategoryIsExistByID(int ID)
        {
            bool IsExist = false;

            string Query = @"SELECT found = 'A' From Categories Where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);

                Object Result = command.ExecuteScalar();

                if(Result != DBNull.Value)
                {
                    IsExist = true;
                }


            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsExist;
        }

        // get count Categories
        public static int GetCountCategories()
        {
            int Count = -1;

            string Query = @"Select Count(ID) As CountCategories From Categories;";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                object Result = command.ExecuteScalar();

                if(Result!= DBNull.Value)
                    Count = Result != DBNull.Value ? Convert.ToInt32(Result) : -1;
            }catch(Exception ex)
            {
                Console.WriteLine("ERROR: command "+ ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return Count;
        }
    }
}
