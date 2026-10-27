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
    public class clsSupplierBackEnd
    {
        static clsConnection clsConnection = new clsConnection();
        // get all Suppliers
        public static DataTable GetAllSuppliers()
        {
            DataTable dt = new DataTable();
          
            string Query = @"select
                            Suppliers.ID as الرقم,
                            Persons.FirstName  as الاسم_الاول ,
                            Persons.LastName as الاسم_الاخير,
                            Phones.Phone as رقم_الهاتف,
                            Suppliers.Address as العنوان

                            From Persons join Phones
                            On Persons.ID = Phones.PersonID
                            Join Suppliers
                            On Persons.ID = Suppliers.PersonID
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


            }catch(Exception ex)
            {
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return dt;
        }

        // get all Suppliers
        public static DataTable GetAllSuppliersFirstName()
        {
            DataTable dt = new DataTable();
            string Query = @"Select Persons.FirstName from Persons inner join Suppliers
                            on Persons.ID = Suppliers.PersonID
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


        // add new Suppler
        public static bool AddNewSupplier(string FirstName, string LastName, string Phone, string Address)
        {
            bool IsFound = false;

            string QueryAddToPersons = @"insert into Persons(FirstName, LastName) values(@FirstName, @LastName); select SCOPE_IDENTITY()";

            string QueryAddToSuppliers = @"insert into Suppliers(Address, PersonID) values(@Address, @PersonID);";

            string QueryAddToPhones = @"insert into Phones(Phone, PersonID) values(@Phone, @PersonID)";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command1 = new SqlCommand(QueryAddToPersons, clsConnection.connection);
                command1.Parameters.AddWithValue("@FirstName", FirstName);
                command1.Parameters.AddWithValue("@LastName", LastName);
                Object rowAdded = command1.ExecuteScalar();

                if (rowAdded != DBNull.Value)
                {

                    int ID = Convert.ToInt32(rowAdded);

                    SqlCommand command2 = new SqlCommand(QueryAddToSuppliers, clsConnection.connection);
                    command2.Parameters.AddWithValue("@Address", Address);
                    command2.Parameters.AddWithValue("@PersonID", ID);
                    int rowAffectedSuppliers = command2.ExecuteNonQuery();

                    SqlCommand command3 = new SqlCommand(QueryAddToPhones, clsConnection.connection);
                    if (Phone != "")
                        command3.Parameters.AddWithValue("@Phone", Phone);
                    else
                        command3.Parameters.AddWithValue("@Phone", DBNull.Value);

                    command3.Parameters.AddWithValue("@PersonID", ID);
                    int rowAffectedPhones = command3.ExecuteNonQuery();

                    if (rowAffectedSuppliers > 0 && rowAffectedPhones > 0)
                    {
                        IsFound = true;
                    }

                }
                
            }
            catch (Exception ex)
            {
                //IsFound = false;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsFound;
        }

        // Update Supplier inforamtion by id
        public static bool UpdateSupplier(int SupplierID, string FirstName, string LastName, string Phone, string Address)
        {
            bool IsFound = false;
            int rowAffectedPersons = -1, rowAffectedPhones = -1, PersonID = -1;

            string QueryToSupplers = @"Update Suppliers set
                                     Address = @Address
                                     Where ID = @ID; select PersonID From Suppliers where ID = @ID" ;

            string QueryToPersons = @"Update Persons set
                                     FirstName = @FirstName,
                                     LastName = @LastName
                                     Where ID = @ID";

            string QueryToPhones = @"Update Phones set
                                     Phone = @Phone
                                     Where PersonID = @PersonID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command3 = new SqlCommand(QueryToSupplers, clsConnection.connection);
                command3.Parameters.AddWithValue("@ID", SupplierID);
                command3.Parameters.AddWithValue("@Address", Address);

                Object Result = command3.ExecuteScalar();

                //if (Result == DBNull.Value)
                    PersonID = Convert.ToInt32(Result);

                SqlCommand command1 = new SqlCommand(QueryToPersons, clsConnection.connection);
                command1.Parameters.AddWithValue("@ID", PersonID);
                command1.Parameters.AddWithValue("@FirstName", FirstName);
                command1.Parameters.AddWithValue("@LastName", LastName);

                rowAffectedPersons = command1.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand(QueryToPhones, clsConnection.connection);
                command2.Parameters.AddWithValue("@PersonID", PersonID);
               
                if(Phone != "")
                    command2.Parameters.AddWithValue("@Phone", Phone);
                else
                    command2.Parameters.AddWithValue("@Phone", DBNull.Value);

                rowAffectedPhones = command2.ExecuteNonQuery();

                

                if (rowAffectedPersons > 0 && rowAffectedPhones > 0 && PersonID > 0)
                    IsFound = true;
               

            }
            catch (Exception ex)
            {
                //IsFound = false;
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound;
        }

        // Find Supplier by id
        public static bool FindSupplierByID(int SupplierID, ref string FirstName, ref string LastName, ref string Phone, ref string Address)
        {
            bool IsFound = false;

            string Query = @"SELECT Suppliers.ID, Persons.FirstName, Persons.LastName ,Phones.Phone, Suppliers.Address
                             From Persons inner join Suppliers
                             On Persons.ID = Suppliers.PersonID
                             Inner join Phones
                             On Persons.ID = Phones.PersonID
                             Where Suppliers.ID = @SupplierID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@SupplierID", SupplierID);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];

                    if (Reader["Phone"] != DBNull.Value)
                        Phone = (string)Reader["Phone"];
                    else
                        Phone = "";

                    if (Reader["Address"] != DBNull.Value)
                        Address = (string)Reader["Address"];
                    else
                        Address = "";

                }
                else
                    IsFound = false;

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

        // Supplier is exist by id
        public static bool SupplierIsExistByID(int ID)
        {
            bool IsFound = false;

            string Qyery = @"Select Found = 'A' From Suppliers
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

        public static int GetInvoicePuyIDBySupplierID(int SupplierID)
        {
            int ID = -1;

            string Query = @"SELECT ID From InvoicesPuy where SupplierID = @SupplierID";

            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@SupplierID", SupplierID);

                Object Result = command.ExecuteScalar();
                
                ID = (Result != DBNull.Value) ? Convert.ToInt32(Result) : 0;
            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return ID;
        }

        public static int GetPersonIDBySupplierID(int SupplierID)
        {
            int ID = -1;

            string Query = @"SELECT PersonID From Suppliers where ID = @SupplierID";

            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@SupplierID", SupplierID);

                Object Result = command.ExecuteScalar();

                ID = (Result != DBNull.Value) ? Convert.ToInt32(Result) : 0;
            }
            catch (Exception ex)
            {
                //ex.Message
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return ID;
        }


        // Delete Supplier by ID
        public static bool DeleteSupplierByID(int SupplierID)
        {
            bool IsFound = false;
            int rowAffectedPersons = -1, rowAffectedPhones = -1;

            string QueryToInvoicesPuyDetails = @"Delete from InvoicesPuyDetails where InovicePuyID = @InovicePuyID";

            string QueryToInvoicesPuy = @"delete from InvoicesPuy where SupplierID = @SupplierID";

            string QueryToSuppliers = @"Delete From Suppliers Where ID = @SupplierID";

            string QueryToPhones = @"Delete From Phones Where PersonID = @PersonID";

            string QueryToPersons = @"Delete From Persons Where ID = @PersonID";


            int InvoicePuyID = GetInvoicePuyIDBySupplierID(SupplierID);

            int PersonID = GetPersonIDBySupplierID(SupplierID);

            try
            {
                clsConnection.connection.Open();


                SqlCommand command1 = new SqlCommand(QueryToInvoicesPuyDetails, clsConnection.connection);
                command1.Parameters.AddWithValue("@InovicePuyID", InvoicePuyID);
                command1.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand(QueryToInvoicesPuy, clsConnection.connection);
                command2.Parameters.AddWithValue("@SupplierID", SupplierID);
                command2.ExecuteNonQuery();

                SqlCommand command3 = new SqlCommand(QueryToSuppliers, clsConnection.connection);
                command3.Parameters.AddWithValue("@SupplierID", SupplierID);
                Object Result = command3.ExecuteScalar();

                PersonID = Convert.ToInt32(Result);

                SqlCommand command4 = new SqlCommand(QueryToPhones, clsConnection.connection);
                command4.Parameters.AddWithValue("@PersonID", PersonID);
                rowAffectedPhones = command4.ExecuteNonQuery();


                SqlCommand command5 = new SqlCommand(QueryToPersons, clsConnection.connection);
                command5.Parameters.AddWithValue("@ID", PersonID);
                rowAffectedPersons = command5.ExecuteNonQuery();

                if (rowAffectedPhones > 0 && PersonID > 0 && rowAffectedPersons > 0)
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

        // Find Suppliers using like
        public static DataTable FindSuppliersUsingLike(string txtSearch,  string TypeSearch)
        {
            string ModeSearch = "Persons.";
            DataTable dt = new DataTable();
            switch (TypeSearch)
            {
                case "FirstName":
                    ModeSearch += TypeSearch;
                    break;
                case "LastName":
                    ModeSearch += TypeSearch;
                    break;
                case "Phone":
                    ModeSearch = "Phones."+ TypeSearch;
                    break;

                    default:
                    ModeSearch += "FirstName";
                    break;
            }
            string Query = $@"SELECT Persons.*,Phones.Phone, Suppliers.Address
                             From Persons inner join Suppliers
                             On Persons.ID = Suppliers.PersonID
                             Inner join Phones
                             On Persons.ID = Phones.PersonID
                             Where {ModeSearch} like '%'+ @txtSearch +'%' order by Persons.ID asc ";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@txtSearch", txtSearch);

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

        public static int GetSupplierIDByFirstName(string FirstName)
        {
            int ID = -1;

            string Query = @"select Suppliers.ID From Suppliers inner join Persons
                            On Suppliers.PersonID = Persons.ID
                            where Persons.FirstName = @FirstName";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                command.Parameters.AddWithValue("@FirstName", FirstName);

                Object Result = command.ExecuteScalar();

                if(Result != DBNull.Value)
                {
                    ID = Convert.ToInt32(Result);
                }


            }catch(Exception ex)
            {
                //ex.Message
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return ID;

        }

        // get count Suppliers
        public static int GetCountSuppliers()
        {
            int Count = -1;
            string Query = @"SELECT COUNT(ID) FROM Suppliers";

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

        // get Last ID Suppliers
        public static int GetLastSuppliersID()
        {
            int LastID = -1;
            string Query = @"SELECT Top 1 ID FROM Suppliers Order by ID desc";

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
