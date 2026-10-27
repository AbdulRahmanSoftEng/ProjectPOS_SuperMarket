using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BackEnd
{
    public class clsUsersBackEnd
    {
        static clsConnection clsConnection = new clsConnection();

        // get All users info from table users
        public static int GetCountUsers()
        {
            int count = -1;
            string Query = @"select count(Persons.ID) As Count

                            From Persons inner join Users

                            on Persons.ID = Users.PersonID";

            SqlCommand command = new SqlCommand(Query, clsConnection.connection);

            try
            {
                clsConnection.connection.Open();
                Object Result = command.ExecuteScalar();

                count = (Result != DBNull.Value)? (int)Result: -1;


            }
            catch (Exception ex)
            {
                //ex.message;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return count;
        }

        // get Last ID users
        public static int GetLastIDUser()
        {
            int LastID = -1;
            string Query = @"SELECT Top 1 ID FROM Users Order by ID desc";

            SqlCommand command = new SqlCommand(Query, clsConnection.connection);

            try
            {
                clsConnection.connection.Open();
                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    LastID = Convert.ToInt32(Result);
                } 

            }
            catch (Exception ex)
            {
                LastID = -1;
                //ex.message;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return LastID;
        }


        // رجعلي جميع المستخدمين الذين يبدا اول حرف
        public static DataTable GetAllUserByNameUsingLike(string Name)
        {
            DataTable dt = new DataTable();
            string Query = @"select Persons.*,Phones.Phone ,Users.Username, Users.Password, Users.Permission

                            From Persons inner join Users

                            on Persons.ID = Users.PersonID

                            inner join Phones
 
                            on Persons.ID = Phones.PersonID

                            where Persons.FirstName Like '%'+ @Name +'%' Order by FirstName asc";

            SqlCommand command = new SqlCommand(Query, clsConnection.connection);
            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                clsConnection.connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();

            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return dt;
        }

        // رجعلي جميع المستخدمين الذين يبدا القب بحرف
        public static DataTable GetAllUserByLastNameUsingLike(string Name)
        {
            DataTable dt = new DataTable();
            string Query = @"select Persons.*,Phones.Phone ,Users.Username, Users.Password, Users.Permission

                            From Persons inner join Users

                            on Persons.ID = Users.PersonID

                            inner join Phones
 
                            on Persons.ID = Phones.PersonID

                            where Persons.LastName Like '%'+ @Name +'%' Order by FirstName asc";

            SqlCommand command = new SqlCommand(Query, clsConnection.connection);
            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                clsConnection.connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();

            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return dt;
        }


        public static DataTable GetAllUserByPhoneUsingLike(string Phone)
        {
            DataTable dt = new DataTable();
            string Query = @"select Persons.*,Phones.Phone ,Users.Username, Users.Password, Users.Permission

                            From Persons inner join Users

                            on Persons.ID = Users.PersonID

                            inner join Phones
 
                            on Persons.ID = Phones.PersonID

                            where Phones.Phone Like '%'+ @Phone +'%' Order by FirstName asc";

            SqlCommand command = new SqlCommand(Query, clsConnection.connection);
            command.Parameters.AddWithValue("@Phone", Phone);

            try
            {
                clsConnection.connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();

            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return dt;
        }


        // get All users info from table users
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            string Query = @"select
                            Persons.ID as الرقم,
                            Persons.FirstName  as الاسم_الاول ,
                            Persons.LastName as الاسم_الاخير,
                            Phones.Phone  as رقم_الهاتف,
                            Users.HierDate as تاريخ_التعيين,
                            Users.Username as اسم_المستخدم,
                            Users.Password as كلمة_المرور,
                            Users.Permission as الصلاحية

                            From Persons inner join Users

                            on Persons.ID = Users.PersonID

                            inner join Phones
 
                            on Persons.ID = Phones.PersonID

                            Order by FirstName asc";

            SqlCommand command = new SqlCommand(Query, clsConnection.connection);

            try
            {
                clsConnection.connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows || Reader.Read())
                {
                    dt.Load(Reader);
                }

                Reader.Close();

            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return dt;
        }


        // add data from table users
        public static int AddUser(string FirstName, string LastName, string Phone, string Username, string Password, Int64 Permission)
        {
            int RowAdded = -1;

            try
            {
                string QueryAddToPersons = @"INSERT INTO Persons(FirstName, LastName)
                            Values(@FirstName, @LastName);
                            select SCOPE_IDENTITY();";

                string QueryAddToUsers = @"INSERT INTO Users(Username, Password, Permission, PersonID)
                            Values(@Username, @Password, @Permission, @PersonID)";

                string QueryAddToPhones = @"INSERT INTO Phones(Phone, PersonID)
                            Values(@Phone, @PersonID)";

                clsConnection.connection.Open();

                SqlCommand command1 = new SqlCommand(QueryAddToPersons, clsConnection.connection);
                command1.Parameters.AddWithValue("@FirstName", FirstName);
                command1.Parameters.AddWithValue("@LastName", LastName);

                Object RowInserted = command1.ExecuteScalar();

                if (RowInserted != DBNull.Value && int.TryParse(RowInserted.ToString(), out int rowPersonID))
                {
                    RowAdded = rowPersonID;

                    SqlCommand command2 = new SqlCommand(QueryAddToUsers, clsConnection.connection);
                    command2.Parameters.AddWithValue("@Username", Username);
                    command2.Parameters.AddWithValue("@Password", Password);
                    command2.Parameters.AddWithValue("@Permission", Permission);
                    command2.Parameters.AddWithValue("@PersonID", rowPersonID);
                    command2.ExecuteNonQuery();

                    SqlCommand command3 = new SqlCommand(QueryAddToPhones, clsConnection.connection);
                    if(Phone != "")
                        command3.Parameters.AddWithValue("@Phone", Phone);
                    else
                        command3.Parameters.AddWithValue("@Phone", DBNull.Value);

                    command3.Parameters.AddWithValue("@PersonID", rowPersonID);
                    command3.ExecuteNonQuery();
                }
                else
                {
                    RowAdded = -1;
                }

            }
            catch (Exception ex)
            {
                RowAdded = -1;
                //ex.message
            }
            finally { clsConnection.connection.Close(); }

            return RowAdded;
        }

        // Update user info 
        public static bool UpdateUserInfo(int ID, string FirstName, string LastName,string Phone, string Username, string Password, Int64 Permission)
        {
            bool IsFound = false;

            string QueryUpdateToPersons = @"update Persons set
                            FirstName = @FirstName,
                            LastName  = @LastName
                            Where ID = @ID";

            string QueryUpdateToUsers = @"update Users Set
                            Username = @Username,
                            Password = @Password,
                            Permission = @Permission
                            where PersonID = @PersonID";

            string QueryUpdateToPhones = @"update Phones set
                            Phone = @Phone
                            Where PersonID = @PersonID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command1 = new SqlCommand(QueryUpdateToPersons, clsConnection.connection);
                command1.Parameters.AddWithValue("@ID", ID);
                command1.Parameters.AddWithValue("@FirstName", FirstName);
                command1.Parameters.AddWithValue("@LastName", LastName);

                int personsUpdated = command1.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand(QueryUpdateToUsers, clsConnection.connection);
                command2.Parameters.AddWithValue("@PersonID", ID);
                command2.Parameters.AddWithValue("@Username", Username);
                command2.Parameters.AddWithValue("@Password", Password);
                command2.Parameters.AddWithValue("@Permission", Permission);

                int usersUpdated = command2.ExecuteNonQuery();

                SqlCommand command3 = new SqlCommand(QueryUpdateToPhones, clsConnection.connection);
               
                command3.Parameters.AddWithValue("@PersonID", ID);

                if(Phone != "")
                    command3.Parameters.AddWithValue("@Phone", Phone);
                else
                    command3.Parameters.AddWithValue("@Phone", DBNull.Value);


                int phonesUpdated = command3.ExecuteNonQuery();

                if(personsUpdated > 0 && usersUpdated > 0 && phonesUpdated > 0)
                {
                    IsFound = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                IsFound = false;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound;
        }


        // Update user info 
        public static bool DeleteUser(int ID)
        {
            bool IsFound = false;
            int rowAffectedPerson = -1, rowAffectedUsers = -1, rowAffectedPhones = -1, rowAffectedLoginHistory = -1;

            try
            {
                

                string QueryDeleteToUsers = @"Delete From Users
                                        
                                        Where PersonID = @ID";


                string QueryDeleteToPhones = @"Delete From Phones
                                            
                                        Where PersonID = @ID";

                string QueryAddToPersons = @"Delete From Persons

                                        Where ID = @ID";

                string QueryDeleteToLoginHistory = @"Delete From LoginHistory

                                        Where UserID = @ID";

                clsConnection.connection.Open();


                SqlCommand command1 = new SqlCommand(QueryDeleteToUsers, clsConnection.connection);
                command1.Parameters.AddWithValue("@ID", ID);
                rowAffectedUsers = command1.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand(QueryDeleteToPhones, clsConnection.connection);
                command2.Parameters.AddWithValue("@ID", ID);
                rowAffectedPhones = command2.ExecuteNonQuery();

                SqlCommand command3 = new SqlCommand(QueryDeleteToLoginHistory, clsConnection.connection);
                command3.Parameters.AddWithValue("@ID", ID);
                rowAffectedLoginHistory = command3.ExecuteNonQuery();

                SqlCommand command4 = new SqlCommand(QueryAddToPersons, clsConnection.connection);
                command4.Parameters.AddWithValue("@ID", ID);
                rowAffectedPerson = command4.ExecuteNonQuery();

                if (rowAffectedPerson > 0 && rowAffectedUsers > 0 && rowAffectedPhones > 0 && rowAffectedLoginHistory > 0)
                {
                    IsFound = true;
                }
                else
                {
                    IsFound = false;
                }

            }
            catch (Exception ex)
            {
                IsFound = false;
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally { clsConnection.connection.Close(); }

            return IsFound;
        }



        // find user info by ID
        public static bool FindUserByID(

            int ID,
            ref string FirstName,
            ref string LastName,
            ref string Phone,
            ref string Username,
            ref string Password,
            ref Int64 Permission){

            bool IsFound = false;

            try
            {
                clsConnection.connection.Open();

                string Query = @"select Persons.*, Phones.Phone, Users.Username, Users.Password, Users.Permission

                                From Persons inner join Users

                                on Persons.ID = Users.PersonID

                                inner join Phones
 
                                on Persons.ID = Phones.PersonID

                                where Persons.ID = @ID";

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    FirstName = Convert.ToString(Reader["FirstName"]) + "";
                    LastName = Convert.ToString(Reader["LastName"]) + "";
                    Phone = Convert.ToString(Reader["Phone"]) + "";
                    Username = Convert.ToString(Reader["Username"]) + "";
                    Password = Convert.ToString(Reader["Password"]) + "";
                    Permission = Convert.ToInt64(Reader["Permission"]);
                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();

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

        // find user by FirstName
        public static bool FindUserByName(
            ref int ID,
            ref string FirstName,
            ref string LastName,
            ref string Phone,
            ref string Username,
            ref string Password,
            ref Int64 Permission)
        {

            bool IsFound = false;

            try
            {
                clsConnection.connection.Open();

                string Query = @"select Persons.*, Phones.Phone ,Users.Username, Users.Password, Users.Permission

                                From Persons inner join Users

                                on Persons.ID = Users.PersonID

                                inner join Phones
 
                                on Persons.ID = Phones.PersonID

                                where Persons.FirstName = @Name
                                Order by FirstName asc;";

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", FirstName);
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    IsFound = true;
                    ID = (int)Reader["ID"];
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];

                   
                    if (Reader["Phone"] != DBNull.Value)
                        Phone = (string)Reader["Phone"];
                    else
                        Phone = "";

                    Username = (string)Reader["Username"];
                    Password = (string)Reader["Password"];
                    Permission = (Int64)Reader["Permission"];
                }
                else
                {
                    IsFound = false;
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


        // find user by Username and Password
        public static bool FindUserByUserAndPass(

            ref int Id,
            ref string Username,
            ref string Password,
            ref Int64 Permission,
            ref string FullName)
        {

            bool IsFound = false;

            try
            {
                clsConnection.connection.Open();

                string Query = @"select Users.ID, Users.Username, Users.Password, Users.Permission, Persons.FirstName +' '+Persons.LastName As FullName

                                From Persons inner join Users

                                on Persons.ID = Users.PersonID
                               
                                where Users.Username = @Username and Users.Password = @Password;";

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    Id = (int)Reader["ID"];
                    Username = (string)Reader["Username"];
                    Password = (string)Reader["Password"];
                    Permission = Convert.ToInt64(Reader["Permission"]);
                    FullName = (string)Reader["FullName"];
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


        // find user by Username and Password bacuse get all columns
        public static bool FindUserByUserAndPass(
            ref int ID,
            ref string FirstName,
            ref string LastName,
            ref string Phone,
            ref string Username,
            ref string Password,
            ref Int64 Permission)
        {

            bool IsFound = false;

            try
            {
                clsConnection.connection.Open();

                string Query = @"select Persons.*, Phones.Phone, Users.Username, Users.Password, Users.Permission

                                From Persons inner join Users

                                on Persons.ID = Users.PersonID

                                inner join Phones
 
                                on Persons.ID = Phones.PersonID

                                where Users.Username = @Username and Users.Password = @Password
                                Order by FirstName asc;";

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    IsFound = true;
                    ID = (int)Reader["ID"];
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];

                   

                    if (Reader["Phone"] != DBNull.Value)
                        Phone = (string)Reader["Phone"];
                    else
                        Phone = "";

                    Username = (string)Reader["Username"];
                    Password = (string)Reader["Password"];
                    Permission = (Int64)Reader["Permission"];
                }
                else
                {
                    IsFound = false;
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


        // User is Exist by ID
        public static bool UserIsExistByID(int ID)
        {

            bool IsFound = false;

            try
            {
                clsConnection.connection.Open();

                string Query = @"select Found = 'A' From Users 
                                where Users.PersonID = @ID";

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    IsFound = true;
                }
                else
                {
                    IsFound = false;
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

        // User is Exist by FirstName
        public static bool UserIsExistByName(string FirstName)
        {

            bool IsFound = false;

            try
            {
                clsConnection.connection.Open();

                string Query = @"select Found = 'A' 

                                From Users Inner join Persons

                                On Users.PersonID = Persons.ID

                                where Persons.FirstName = @FirstName";

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@FirstName", FirstName);

                SqlDataReader Reader = command.ExecuteReader();

                // IsFound = Reader.HasRows

                if (Reader.HasRows)
                {
                    IsFound = true;
                }
                else
                {
                    IsFound = false;
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

        // User is Exist by FirstName
        public static bool UserIsExistByUserAndPass(string Username, string Password)
        {

            bool IsFound = false;

            try
            {
                clsConnection.connection.Open();

                string Query = @"select Found = 'A' 

                                From Users Inner join Persons

                                On Users.PersonID = Persons.ID

                                where Users.Username = @Username and Users.Password = @Password";

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    IsFound = true;
                }
                else
                {
                    IsFound = false;
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


        // دالة لاسترجاع رقم المستخدم من خلال اسم المستخدم
        public static int GetUserIDByUsername(string Username)
        {
            int UsernameID = -1;
            string Query = @"SELECT ID From Users where Username = @Username";
            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Username", Username);

                Object Result = command.ExecuteScalar();

                // UsernameID = ((Result != DBNull.Value)? Convert.ToInt32(Result): -1;

                if (Result != DBNull.Value)
                {
                    UsernameID = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                UsernameID = -1;
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return UsernameID;
        }

        public static int AddLoginHistoryLoginDate(int UserID)
        {
            int recordAdded = -1;

            string Query = @"Insert into LoginHistory(LoginDate, UserID)values(@LoginDate, @UserID); SELECT SCOPE_IDENTITY()";
            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@LoginDate", DateTime.Now);
 
                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    recordAdded = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                recordAdded = -1;
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return recordAdded;
        }

        public static int UpdateLoginHistoryLoginExit(int ID)
        {
            int recordUpdated = -1;

            string Query = @"Update LoginHistory set
                            ExitDate = @ExitDate
                            where ID = @ID;";

            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ExitDate", DateTime.Now);
                command.Parameters.AddWithValue("@ID", ID);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    recordUpdated = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                recordUpdated = -1;
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return recordUpdated;
        }

        // find user info by ID
        public static bool FindUserByPersonID(

            int ID,
            ref string FirstName,
            ref string LastName,
            ref string Phone,
            ref string Username,
            ref string Password,
            ref Int64 Permission)
        {

            bool IsFound = false;

            try
            {
                clsConnection.connection.Open();

                string Query = @"select Persons.*, Phones.Phone, Users.Username, Users.Password, Users.Permission

                                From Persons inner join Users

                                on Persons.ID = Users.PersonID

                                inner join Phones
 
                                on Persons.ID = Phones.PersonID

                                where Persons.ID = @ID";

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    FirstName = Convert.ToString(Reader["FirstName"]) + "";
                    LastName = Convert.ToString(Reader["LastName"]) + "";
                    Phone = Convert.ToString(Reader["Phone"]) + "";
                    Username = Convert.ToString(Reader["Username"]) + "";
                    Password = Convert.ToString(Reader["Password"]) + "";
                    Permission = Convert.ToInt64(Reader["Permission"]);
                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();

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
        
        // find user id by person id
        public static int GetUserIDByPersonID(int PersonID){

            int UserID = 0;

            try
            {
                clsConnection.connection.Open();

                string Query = @"select Persons.ID

                                From Persons inner join Users

                                on Persons.ID = Users.PersonID

                                where Persons.ID = @PersonID";

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);

                Object Result = command.ExecuteScalar();
                    
                UserID = Result != DBNull.Value? Convert.ToInt32(Result) : 0;

            }
            catch (Exception ex)
            {
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return UserID;
        }

    }
}
