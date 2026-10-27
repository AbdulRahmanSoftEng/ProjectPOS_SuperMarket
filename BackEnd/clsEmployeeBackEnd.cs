using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class clsEmployeeBackEnd
    {
        static clsConnection clsConnection = new clsConnection();

        // get all Employees
        public static DataTable GetAllEmployees()
        {
            /*string Query = @"SELECT Persons.*,Phones.Phone, Employees.Salary, Employees.BonusPerc, Employees.HierDate
                             From Persons inner join Employees
                             On Persons.ID = Employees.PersonID
                             Inner join Phones
                             On Persons.ID = Phones.PersonID
							 order by Persons.ID asc;";*/
            
            string Query = @"select
                            Persons.ID as الرقم,
                            Persons.FirstName  as الاسم_الاول ,
                            Persons.LastName as الاسم_الاخير,
                            Phones.Phone as رقم_الهاتف,
                            Employees.Salary as الراتب,
                            Employees.BonusPerc as الحوافز,
                            Employees.HierDate as تاريخ_التعيين

                            From Persons inner join Employees
                            On Persons.ID = Employees.PersonID
                            Inner join Phones
                            On Persons.ID = Phones.PersonID
                            order by Persons.[FirstName] asc;";



            DataTable dt = new DataTable();

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
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return dt;
        }

        // add new employee
        public static bool AddNewEmployee(string FirstName, string LastName, string Phone, decimal Salary, decimal BonusPerc)
        {
            bool IsFound = false;

            string QueryAddToPersons = @"insert into Persons(FirstName, LastName) values(@FirstName, @LastName); select SCOPE_IDENTITY()";

            string QueryAddToEmployees = @"insert into Employees(Salary, BonusPerc, PersonID) values(@Salary,@BonusPerc, @PersonID);";

            string QueryAddToPhones = @"insert into Phones(Phone, PersonID) values(@Phone, @PersonID)";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command1 = new SqlCommand(QueryAddToPersons, clsConnection.connection);
                command1.Parameters.AddWithValue("@FirstName", FirstName);
                command1.Parameters.AddWithValue("@LastName", LastName);
                Object rowAdded = command1.ExecuteScalar();

                if(rowAdded != null && int.TryParse(rowAdded.ToString(), out int idAdded))
                {
                    

                    SqlCommand command2 = new SqlCommand(QueryAddToEmployees, clsConnection.connection);
                    command2.Parameters.AddWithValue("@Salary", Salary);
                    command2.Parameters.AddWithValue("@BonusPerc", BonusPerc);
                    command2.Parameters.AddWithValue("@PersonID", idAdded);
                    int rowAffectedEmpoyees = command2.ExecuteNonQuery();

                    SqlCommand command3 = new SqlCommand(QueryAddToPhones, clsConnection.connection);
                    command3.Parameters.AddWithValue("@Phone", Phone);
                    command3.Parameters.AddWithValue("@PersonID", idAdded);
                    int rowAffectedPhones = command3.ExecuteNonQuery();

                    if (rowAffectedEmpoyees > 0 && rowAffectedPhones > 0)
                    {
                        IsFound = true;
                    }
                    
                }
                else
                {
                    IsFound = false;
                }
              
            }
            catch(Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsFound;
        }

        // Update employee inforamtion by id
        public static bool UpdateEmployee(int EmployeeID, string FirstName, string LastName, string Phone, decimal Salary, decimal BonusPerc)
        {
            bool IsFound = false;
            int rowAffectedPersons = -1, rowAffectedPhones = -1, rowAffectedEmployees = -1;

            string QueryToPersons = @"Update Persons set
                                     FirstName = @FirstName,
                                     LastName = @LastName
                                     Where ID = @ID";

            string QueryToPhones = @"Update Phones set
                                     Phone = @Phone
                                     Where PersonID = @PersonID";

            string QueryToEmployees = @"Update Employees set
                                     Salary = @Salary,
                                     BonusPerc = @BonusPerc
                                     Where PersonID = @PersonID";
            try
            {
                clsConnection.connection.Open();

                SqlCommand command1 = new SqlCommand(QueryToPersons, clsConnection.connection);
                command1.Parameters.AddWithValue("@FirstName", FirstName);
                command1.Parameters.AddWithValue("@LastName", LastName);
                command1.Parameters.AddWithValue("@ID", EmployeeID);
                rowAffectedPersons = command1.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand(QueryToPhones, clsConnection.connection);
                command2.Parameters.AddWithValue("@Phone", Phone);
                command2.Parameters.AddWithValue("@PersonID", EmployeeID);
                rowAffectedPhones = command2.ExecuteNonQuery();

                SqlCommand command3 = new SqlCommand(QueryToEmployees, clsConnection.connection);
                command3.Parameters.AddWithValue("@Salary", Salary);
                command3.Parameters.AddWithValue("@BonusPerc", BonusPerc);
                command3.Parameters.AddWithValue("@PersonID", EmployeeID);
                rowAffectedEmployees = command3.ExecuteNonQuery();

                if (rowAffectedPersons > 0 && rowAffectedPhones > 0 && rowAffectedEmployees > 0)
                    IsFound = true;
                else
                    IsFound = false;


            } catch (Exception ex)
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

        // Find Employee by id
        public static bool FindEmployeeByID(int EmployeeID, ref string FirstName, ref string LastName, ref string Phone, ref decimal Salary, ref decimal BonusPerc)
        {
            bool IsFound = false;

            string Query = @"SELECT Persons.*,Phones.Phone, Employees.Salary, Employees.BonusPerc
                             From Persons inner join Employees
                             On Persons.ID = Employees.PersonID
                             Inner join Phones
                             On Persons.ID = Phones.PersonID
                             Where Persons.ID = @EmployeeID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    FirstName = (string)Reader["FirstName"] + "";
                    LastName = (string)Reader["LastName"] + "";

                    if (Reader["Phone"] != DBNull.Value)
                        Phone = (string)Reader["Phone"];
                    else
                        Phone = "";

                    Salary = (decimal)Reader["Salary"] + 0;


                    if (Reader["BonusPerc"] != DBNull.Value)
                        BonusPerc = (decimal)Reader["BonusPerc"];
                    else
                        BonusPerc = 0;

                }
                else
                    IsFound = false;

                Reader.Close();

            }catch(Exception ex)
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

        // employee is exist by id
        public static bool EmployeeIsExistByID(int ID)
        {
            bool IsFound = false;

            string Qyery = @"Select Found = 'A' From Persons
                            where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Qyery, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);

                Object Result = command.ExecuteScalar();

                if (Result != null)
                    IsFound = true;
                else
                    IsFound = false;

            }catch(Exception ex)
            {
                IsFound = false;
                //ex.Message;
            }
            finally {clsConnection.connection.Close(); }

            return IsFound;
        }

        // Delete Employee by ID
        public static bool DeleteEmployeeByID(int ID)
        {
            bool IsFound = false;
            int rowAffectedPersons = -1, rowAffectedPhones = -1, rowAffectedEmployees = -1;


            string QueryToPhones = @"Delete From Phones
                                     Where PersonID = @PersonID";

            string QueryToEmployees = @"Delete From Employees
                                     Where PersonID = @PersonID";

            string QueryToPersons = @"Delete From Persons
                                     Where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command1 = new SqlCommand(QueryToPhones, clsConnection.connection);
                command1.Parameters.AddWithValue("@PersonID", ID);
                rowAffectedPhones = command1.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand(QueryToEmployees, clsConnection.connection);
                command2.Parameters.AddWithValue("@PersonID", ID);
                rowAffectedEmployees = command2.ExecuteNonQuery();

                SqlCommand command3 = new SqlCommand(QueryToPersons, clsConnection.connection);
                command3.Parameters.AddWithValue("@ID", ID);
                rowAffectedPersons = command3.ExecuteNonQuery();

                if(rowAffectedPhones > 0 && rowAffectedEmployees > 0 && rowAffectedPersons > 0)
                    IsFound = true;
                else
                    IsFound = false;

            }
            catch (Exception ex)
            {
                IsFound = false;
                //ex.Message;
            }
            finally { clsConnection.connection.Close(); }

            return IsFound;
        }

        // Find employees using like
        public static DataTable FindEmployeeByNameUsingLike(string Name)
        {

            DataTable dt = new DataTable();

            string Query = @"SELECT Persons.*,Phones.Phone, Employees.Salary, Employees.BonusPerc, Employees.HierDate
                             From Persons inner join Employees
                             On Persons.ID = Employees.PersonID
                             Inner join Phones
                             On Persons.ID = Phones.PersonID
                             Where Persons.FirstName like '%'+ @FirstName +'%' order by Persons.ID asc ";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@FirstName", Name);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return dt;
        }

        // get count Employeees
        public static int GetCountEmployees()
        {
            int Count = -1;
            string Query = @"SELECT COUNT(ID) FROM Employees";

            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                    Count = Convert.ToInt32(Result);
            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return Count;
        }

        // get Last ID Employeees
        public static int GetLastIDEmployee()
        {
            int LastID = -1;
            string Query = @"SELECT Top 1 ID FROM Employees Order by ID desc";

            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                    LastID = Convert.ToInt32(Result);
            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return LastID;
        }
    }
}
