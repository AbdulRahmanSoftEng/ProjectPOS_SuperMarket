using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class clsCustomerBackEnd
    {
        static clsConnection clsConnection = new clsConnection();

        // get all Customers
        public static DataTable GetAllCustomers()
        {
            DataTable dt = new DataTable();
            /*string Query = @"Select Persons.*, Phones.Phone, Customers.Address
                        From Persons join Phones
                        On Persons.ID = Phones.PersonID
                        Join Customers
                        On Persons.ID = Customers.PersonID
                       
                        Order by FirstName asc";*/ 
            
            string Query = @"select
                        Persons.ID as الرقم,
                        Persons.FirstName  as الاسم_الاول ,
                        Persons.LastName as الاسم_الاخير,
                        Phones.Phone as رقم_الهاتف,
                        Customers.Address  as العنوان

                        From Persons join Phones
                        On Persons.ID = Phones.PersonID
                        Join Customers
                        On Persons.ID = Customers.PersonID
                       
                        Order by FirstName asc";



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

        // add new Customer
        public static bool AddNewCustomer(string FirstName, string LastName, string Phone, string Address)
        {
            bool IsFound = false;

            string QueryAddToPersons = @"insert into Persons(FirstName, LastName) values(@FirstName, @LastName); select SCOPE_IDENTITY()";

            string QueryAddToCustomers = @"insert into Customers(Address, PersonID) values(@Address, @PersonID);";

            string QueryAddToPhones = @"insert into Phones(Phone, PersonID) values(@Phone, @PersonID)";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command1 = new SqlCommand(QueryAddToPersons, clsConnection.connection);
                command1.Parameters.AddWithValue("@FirstName", FirstName);
                command1.Parameters.AddWithValue("@LastName", LastName);
                Object rowAdded = command1.ExecuteScalar();

                if (rowAdded != null && int.TryParse(rowAdded.ToString(), out int idAdded))
                {


                    SqlCommand command2 = new SqlCommand(QueryAddToCustomers, clsConnection.connection);
                    command2.Parameters.AddWithValue("@PersonID", idAdded);
                    command2.Parameters.AddWithValue("@Address", Address);

                    int rowAffectedCustomers = command2.ExecuteNonQuery();

                    SqlCommand command3 = new SqlCommand(QueryAddToPhones, clsConnection.connection);
                    command3.Parameters.AddWithValue("@Phone", Phone);
                    command3.Parameters.AddWithValue("@PersonID", idAdded);
                    int rowAffectedPhones = command3.ExecuteNonQuery();

                    if (rowAffectedCustomers > 0 && rowAffectedPhones > 0)
                    {
                        IsFound = true;
                    }

                }
              
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsFound;
        }

        // Update Customer inforamtion by id
        public static bool UpdateCustomer(int CustomerID, string FirstName, string LastName, string Phone, string Address)
        {
            bool IsFound = false;
            int rowAffectedPersons = -1, rowAffectedPhones = -1, rowAffectedCustomers = -1;

            string QueryToPersons = @"Update Persons set
                                    FirstName = @FirstName,
                                    LastName = @LastName
                                    Where ID = @ID";

            string QueryToPhones = @"Update Phones set
                                    Phone = @Phone
                                    Where PersonID = @PersonID";

            string QueryToCustomers = @"Update Customers set
                                    Address = @Address
                                    Where PersonID = @PersonID";
            try
            {
                clsConnection.connection.Open();

                SqlCommand command1 = new SqlCommand(QueryToPersons, clsConnection.connection);
                command1.Parameters.AddWithValue("@ID", CustomerID);
                command1.Parameters.AddWithValue("@FirstName", FirstName);
                command1.Parameters.AddWithValue("@LastName", LastName);
                rowAffectedPersons = command1.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand(QueryToPhones, clsConnection.connection);
                command2.Parameters.AddWithValue("@Phone", Phone);
                command2.Parameters.AddWithValue("@PersonID", CustomerID);
                rowAffectedPhones = command2.ExecuteNonQuery();

                SqlCommand command3 = new SqlCommand(QueryToCustomers, clsConnection.connection);
                command3.Parameters.AddWithValue("@Address", Address);
                command3.Parameters.AddWithValue("@PersonID", CustomerID);
                rowAffectedCustomers = command3.ExecuteNonQuery();

                if (rowAffectedPersons > 0 && rowAffectedPhones > 0 && rowAffectedCustomers > 0)
                    IsFound = true;
              
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

        // Find Supplier by id
        public static bool FindCustomerByID(int CustomerID, ref string FirstName, ref string LastName, ref string Phone, ref string Address)
        {
            bool IsFound = false;

            string Query = @"SELECT Persons.*, Phones.Phone, Customers.Address
                                From Persons inner join Customers
                                On Persons.ID = Customers.PersonID
                                Inner join Phones
                                On Persons.ID = Phones.PersonID
                                
                                Where Persons.ID = @CustomerID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@CustomerID", CustomerID);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows && Reader.Read())
                {
                    IsFound = true;

                    FirstName = Reader["FirstName"] != DBNull.Value ? Convert.ToString(Reader["FirstName"]): "";
                    LastName = Reader["LastName"] != DBNull.Value ? Convert.ToString(Reader["LastName"]): "";

                    Phone = Reader["Phone"] != DBNull.Value ? Convert.ToString(Reader["Phone"]) : "";
                    Address = Reader["Address"] != DBNull.Value ? Convert.ToString(Reader["Address"]) : "";
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
        
         public static bool FindCustomerByID2(int CustomerID, ref string FirstName, ref string LastName, ref string Phone, ref string Address)
        {
            bool IsFound = false;

            string Query = @"SELECT Persons.FirstName, Persons.LastName, Phones.Phone, Customers.Address
                                From Persons inner join Customers
                                On Persons.ID = Customers.PersonID
                                Inner join Phones
                                On Persons.ID = Phones.PersonID
                                
                                Where Customers.ID = @CustomerID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@CustomerID", CustomerID);

                using (SqlDataReader Reader = command.ExecuteReader())
                {

                    if (Reader.HasRows && Reader.Read())
                    {
                        IsFound = true;

                        FirstName = Reader["FirstName"] != DBNull.Value ? Convert.ToString(Reader["FirstName"]) : "";
                        LastName = Reader["LastName"] != DBNull.Value ? Convert.ToString(Reader["LastName"]) : "";

                        Phone = Reader["Phone"] != DBNull.Value ? Convert.ToString(Reader["Phone"]) : "";
                        Address = Reader["Address"] != DBNull.Value ? Convert.ToString(Reader["Address"]) : "";
                    }


                    Reader.Close();
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

        // Customer is exist by id
        public static bool CustomerIsExistByID(int ID)
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

            }
            catch (Exception ex)
            {
                IsFound = false;
                //ex.Message;
            }
            finally { clsConnection.connection.Close(); }

            return IsFound;
        }

        // Delete Customer by ID
        public static bool DeleteCustomerByID(int ID)
        {
            int CustomerID;
            bool IsFound = false;
            int rowAffectedPersons = -1, rowAffectedPhones = -1, rowAffectedCustomers = -1, rowAffectedInvoice = -1;

            string QueryToCustomersGetID = @"Select ID from Customers where PersonID = @PersonID";

            string QueryToPhones = @"Delete From Phones
                                    Where PersonID = @PersonID";

            string QueryToInvoices = @"Delete From Invoices
                                    Where CustomerID = @CustomerID";

            string QueryToCustomers = @"Delete From Customers
                                    Where PersonID = @PersonID";

            string QueryToPersons = @"Delete From Persons
                                    Where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command1 = new SqlCommand(QueryToCustomersGetID, clsConnection.connection);
                command1.Parameters.AddWithValue("@PersonID", ID);
                Object Result = command1.ExecuteScalar();

                if (Result != DBNull.Value && int.TryParse(Result.ToString(), out CustomerID))
                {

                    SqlCommand command2 = new SqlCommand(QueryToInvoices, clsConnection.connection);
                    command2.Parameters.AddWithValue("@CustomerID", CustomerID);
                    rowAffectedInvoice = command2.ExecuteNonQuery();
                }

                SqlCommand command3 = new SqlCommand(QueryToPhones, clsConnection.connection);
                command3.Parameters.AddWithValue("@PersonID", ID);
                rowAffectedPhones = command3.ExecuteNonQuery();

                SqlCommand command4 = new SqlCommand(QueryToCustomers, clsConnection.connection);
                command4.Parameters.AddWithValue("@PersonID", ID);
                rowAffectedCustomers = command4.ExecuteNonQuery();

                SqlCommand command5 = new SqlCommand(QueryToPersons, clsConnection.connection);
                command5.Parameters.AddWithValue("@ID", ID);
                rowAffectedPersons = command5.ExecuteNonQuery();

                if (rowAffectedPhones > 0 && rowAffectedCustomers > 0 && rowAffectedPersons > 0)
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

        // Find Customers using like
        public static DataTable FindCustomersByFirstNameUsingLike(string FirstName)
        {

            DataTable dt = new DataTable();

            string Query = @"Select Persons.*, Phones.Phone, Customers.Address
                            From Persons join Phones
                            On Persons.ID = Phones.PersonID
                            Join Customers
                            On Persons.ID = Customers.PersonID
                            Where Persons.FirstName like '%'+ @FirstName +'%' Order by Persons.ID asc ";

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
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return dt;
        }

        // Find Customers using like
        public static DataTable FindCustomersByLastNameUsingLike(string LastName)
        {

            DataTable dt = new DataTable();

            string Query = @"Select Persons.*, Phones.Phone, Customers.Address
                            From Persons join Phones
                            On Persons.ID = Phones.PersonID
                            Join Customers
                            On Persons.ID = Customers.PersonID

                            Where Persons.LastName like '%'+ @LastName +'%' Order by Persons.ID asc ";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@LastName", LastName);

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

        public static DataTable FindCustomersByPhoneUsingLike(string Phone)
        {

            DataTable dt = new DataTable();

            string Query = @"Select Persons.*, Phones.Phone, Customers.Address
                            From Persons join Phones
                            On Persons.ID = Phones.PersonID
                            Join Customers
                            On Persons.ID = Customers.PersonID

                            Where Phones.Phone like '%'+ @Phone +'%' Order by Persons.ID asc ";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Phone", Phone);

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
        
      
     
        public static int GetCustomerIDByPersonID(int PersonID)
        {
            int ID = -1;

            string Query = @"SELECT ID FROM Customers where PersonID = @PersonID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);

                Object Result = command.ExecuteScalar();

                if(Result != DBNull.Value)
                    ID = Convert.ToInt32(Result);


            }catch(Exception Ex)
            {
                //Ex.Message;
            }

            finally
            {
                clsConnection.connection.Close();
            }

            return ID;
        }

        // get count Customers
        public static int GetCountCustomers()
        {
            int Count = -1;
            string Query = @"SELECT COUNT(ID) FROM Customers";

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

        // get Last ID Customers
        public static int GetLastIDCustomer()
        {
            int LastID = -1;
            string Query = @"  SELECT Top 1 ID FROM Customers Order by ID desc";

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