using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace BackEnd
{
    public class clsProductBackEnd
    {
        static clsConnection clsConnection = new clsConnection();

        // get all products
        public static DataTable GetAllProducts()
        {
            DataTable products = new DataTable();

            //string Query = @"SELECT *  FROM Products order by ID desc";
            string Query = @"
                        select Products.ID as الرقم,
                        Products.Barcode  as الباركو,
                        Products.Name as الاسم,
                        Products.Price as السعر,
                        Products.Quantity as الكمية,
                        Categories.Name as القسم,
                        Products.Image as الصورة,
                        Products.IsBarcode  as تصنيف

                        From Products inner join Categories

                        on Products.CategoryID = Categories.ID order by Products.Name asc;";


            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    products.Load(Reader);
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
            return products;
        }

        // get all products Name ,price ,qty
        public static DataTable GetAllProducts3Column()
        {
            DataTable products = new DataTable();

            string Query = @"select 
                            Name,
                            Price,
                            Quantity,
                            IsBarcode

                            from Products Order By Name desc";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    products.Load(Reader);
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
            return products;
        }

        // get all products Name ,price ,qty
        public static DataTable GetAllProductsByNameUsingLike(string Name)
        {
            DataTable products = new DataTable();

            string Query = @"select 
                            Name,
                            Price,
                            Quantity,
                            IsBarcode

                            from Products where Name Like '%'+@Name+'%' Order By Name desc";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", Name);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    products.Load(Reader);
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
            return products;
        }

        // get all products Name ,price ,qty
        public static DataTable GetAllProductsByCategoryNameUsingLike(string CategoryName)
        {
            DataTable products = new DataTable();

            string Query = @"  select 
                            Products.Name,
                            Price,
                            Quantity,
                            IsBarcode
                            
                            From Products inner join Categories

                            On Products.CategoryID = Categories.ID

                            where Categories.Name = @CategoryName;";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@CategoryName", CategoryName);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    products.Load(Reader);
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
            return products;
        }

        public static bool FindProductByBarcode(ref string Barcode, ref string Name, ref float Price, ref int Quantity, ref byte IsBarcode)
        {
            bool IsFound = false;
            string query = @"SELECT Barcode, Name, Price, IsBarcode FROM Products WHERE Barcode = @Barcode";

            try
            {
                clsConnection.connection.Open();

                using (SqlCommand command = new SqlCommand(query, clsConnection.connection))
                {
                    command.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = Barcode;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IsFound = true;
                            Barcode = reader["Barcode"].ToString();
                            Name = reader["Name"].ToString();
                            Price = reader["Price"] != DBNull.Value ? Convert.ToSingle(reader["Price"]) : 0;
                            Quantity = reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0;
                            IsBarcode = reader["IsBarcode"] != DBNull.Value ? Convert.ToByte(reader["IsBarcode"]) : (byte)0;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (e.g., to a file or monitoring system)
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound; // Return null if the product is not found
        }

        public static bool FindProductById(int ID, ref string Name, ref float Price, ref int Quantity, ref byte IsBarcode)
        {
            bool IsFound = false;
            string query = @"SELECT Barcode, Name, Price, IsBarcode FROM Products WHERE ID = @ID";

            try
            {
                clsConnection.connection.Open();

                using (SqlCommand command = new SqlCommand(query, clsConnection.connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IsFound = true;
                            Name = reader["Name"].ToString();
                            Price = reader["Price"] != DBNull.Value ? Convert.ToSingle(reader["Price"]) : 0;
                            Quantity = reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0;
                            IsBarcode = reader["IsBarcode"] != DBNull.Value ? Convert.ToByte(reader["IsBarcode"]) : (byte)0;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (e.g., to a file or monitoring system)
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound; // Return null if the product is not found
        }


        // get all products that is quantity minmum of <= 2 
        public static DataTable GetAllProductsRestrictRequest()
        {
            DataTable products = new DataTable();

            string Query = @"select 
                            Name,
                            Price,
                            Quantity

                            from Products 

                            where Quantity <= (select DefaultQuantityDemand From Settings where ID = 1); ";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows || Reader.Read())
                {
                    products.Load(Reader);
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
            return products;
        }

        // get all products that is quantity minmum of <= 2  and Name matching like
        public static DataTable GetAllProductsRestrictRequestUsingLike(string Name)
        {
            DataTable products = new DataTable();

            string Query = @"select 
                            Name,
                            Price,
                            Quantity

                            from Products 

                            where Quantity <= (select DefaultQuantityDemand From Settings where ID = 1) and Name Like '%'+@Name+'%';";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", Name);

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    products.Load(Reader);
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
            return products;
        }


        // Add new product
        public static bool AddNewProduct(string Barcode, string Name, float Price, int Quantity, int CategoryID, string Description, string Image, byte IsBarcode)
        {
            bool IsFound = false;

            //string Query = @"insert into Products(Barcode,Name, Price, Quantity, CategoryID, Description, Image)
            //                values(@Barcode, @Name, @Price, @Quantity, @CategoryID, @Description, @Image)";

            string Query = @"insert into Products(Barcode,Name, Price, Quantity, CategoryID, Description, Image, IsBarcode)
                            values(@Barcode, @Name, @Price, @Quantity, @CategoryID, @Description, @Image, @IsBarcode)";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Barcode", Barcode);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Price", Price);
                command.Parameters.AddWithValue("@Quantity", Quantity);
                command.Parameters.AddWithValue("@CategoryID", CategoryID);

                if (Description != "")
                    command.Parameters.AddWithValue("@Description", Description);
                else
                    command.Parameters.AddWithValue("@Description", DBNull.Value);

                if (Image != "")
                    command.Parameters.AddWithValue("@Image", Image);
                else
                    command.Parameters.AddWithValue("@Image", DBNull.Value);

                command.Parameters.AddWithValue("@IsBarcode", IsBarcode);

                int Result = command.ExecuteNonQuery();

                IsFound = Result > 0;


            }
            catch (Exception ex)
            {
                //ex.Message;

            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsFound;
        }

        // update product info
        public static bool UpdateProduct(int ID, string Barcode, string Name, float Price, int Quantity, int CategoryID, string Description, string Image, byte IsBarcode)
        {
            bool IsFound = false;

            string Query = @"update Products set
                            Barcode = @Barcode,
                            Name = @Name,
                            Price = @Price,
                            Quantity = @Quantity,
                            CategoryID = @CategoryID,
                            Description = @Description,
                            Image = @Image,
                            IsBarcode = @IsBarcode
                            Where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Barcode", Barcode);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Price", Price);
                command.Parameters.AddWithValue("@Quantity", Quantity);
                command.Parameters.AddWithValue("@CategoryID", CategoryID);

                if (Description != "")
                    command.Parameters.AddWithValue("@Description", Description);
                else
                    command.Parameters.AddWithValue("@Description", DBNull.Value);

                if (Image != "")
                    command.Parameters.AddWithValue("@Image", Image);
                else
                    command.Parameters.AddWithValue("@Image", DBNull.Value);

                command.Parameters.AddWithValue("@IsBarcode", IsBarcode);

                int Result = command.ExecuteNonQuery();

                if (Result > 0)
                    IsFound = true;

            }
            catch (Exception ex)
            {
                //ex.Message;
                IsFound = false;

            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsFound;
        }

        // update product info
        public static bool UpdateMinuseQuantity(int ID, int Quantity)
        {
            bool IsFound = false;

            string Query = @"update Products set
                            
                            Quantity = Quantity - @Quantity
                           
                            Where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Quantity", Quantity);


                int Result = command.ExecuteNonQuery();

                if (Result > 0)
                    IsFound = true;

            }
            catch (Exception ex)
            {
                //ex.Message;
                IsFound = false;

            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsFound;
        }

        // update product info
        public static bool FindProductByID(ref int ID, ref string Barcode, ref string Name, ref float Price, ref int Quantity, ref int CategoryID, ref string Description, ref string Image, ref byte IsBarcode)
        {
            bool IsFound = false;

            string Query = @"select * from Products where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    IsFound = true;
                    ID = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : 0;
                    Barcode = reader["Barcode"].ToString();
                    Name = reader["Name"].ToString();
                    Price = reader["Price"] != DBNull.Value ? Convert.ToSingle(reader["Price"]) : 0;
                    Quantity = reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0;
                    CategoryID = reader["CategoryID"] != DBNull.Value ? Convert.ToInt32(reader["CategoryID"]) : 0;
                    Description = reader["Description"]?.ToString();
                    Image = reader["Image"]?.ToString();
                    IsBarcode = reader["IsBarcode"] != DBNull.Value ? Convert.ToByte(reader["IsBarcode"]) : (byte)0;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //ex.Message;
                IsFound = false;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsFound;
        }

        // Find Product By Barcode
        public static bool FindProductByBarcode(ref int ID, ref string Barcode, ref string Name, ref float Price, ref int Quantity, ref int CategoryID, ref string Description, ref string Image, ref byte IsBarcode)
        {
            bool IsFound = false;
            string query = @"SELECT * FROM Products WHERE Barcode = @Barcode";

            try
            {
                clsConnection.connection.Open();

                using (SqlCommand command = new SqlCommand(query, clsConnection.connection))
                {
                    command.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = Barcode;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IsFound = true;
                            ID = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : 0;
                            Barcode = reader["Barcode"].ToString();
                            Name = reader["Name"].ToString();
                            Price = reader["Price"] != DBNull.Value ? Convert.ToSingle(reader["Price"]) : 0;
                            Quantity = reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0;
                            CategoryID = reader["CategoryID"] != DBNull.Value ? Convert.ToInt32(reader["CategoryID"]) : 0;
                            Description = reader["Description"]?.ToString();
                            Image = reader["Image"] != DBNull.Value ? reader["Image"].ToString() : "";
                            IsBarcode = reader["IsBarcode"] != DBNull.Value ? Convert.ToByte(reader["IsBarcode"]) : (byte)0;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (e.g., to a file or monitoring system)
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound; // Return null if the product is not found
        }



        // Find Product By Barcode
        public static bool FindProductByBarcode(ref int Id, ref string Barcode, ref string Name, ref float Price, ref int Qty)
        {
            bool IsFound = false;
            string query = @"SELECT ID, Barcode, Name, Price, Quantity FROM Products WHERE Barcode = @Barcode";

            try
            {
                clsConnection.connection.Open();

                using (SqlCommand command = new SqlCommand(query, clsConnection.connection))
                {
                    command.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = Barcode;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IsFound = true;
                            Id = Convert.ToInt32(reader["ID"]);
                            Barcode = reader["Barcode"].ToString();
                            Name = reader["Name"].ToString();
                            Price = reader["Price"] != DBNull.Value ? Convert.ToSingle(reader["Price"]) : 0;
                            Qty = reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (e.g., to a file or monitoring system)
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound; // Return null if the product is not found
        }

        // Find Product By Name
        public static bool FindProductByName(ref int ID, ref string Barcode, ref string Name, ref float Price, ref int Quantity, ref int CategoryID, ref string Description, ref string Image, ref byte IsBarcode)
        {
            bool IsFound = false;

            string Query = @"select * from Products where Name = @Name";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", Name);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    IsFound = true;
                    ID = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : 0;
                    Barcode = reader["Barcode"].ToString();
                    Name = reader["Name"].ToString();
                    Price = reader["Price"] != DBNull.Value ? Convert.ToSingle(reader["Price"]) : 0;
                    Quantity = reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0;
                    CategoryID = reader["CategoryID"] != DBNull.Value ? Convert.ToInt32(reader["CategoryID"]) : 0;
                    Description = reader["Description"]?.ToString();
                    Image = reader["Image"]?.ToString();
                    IsBarcode = reader["IsBarcode"] != DBNull.Value ? Convert.ToByte(reader["IsBarcode"]) : (byte)0;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //ex.Message;
                IsFound = false;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsFound;
        }

        // find Prodcut by ID
        public static bool IsProductIsExistByID(int ID)
        {
            bool IsFound = false;

            string Query = @"select found = 'A' from Products where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                    IsFound = true;
                else
                    IsFound = false;

            }
            catch (Exception ex)
            {
                //ex.Message;
                IsFound = false;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsFound;


        }

        // Is a product in table is Exist by Barcode
        public static bool IsProductExistByBarcode(string Barcode)
        {
            bool IsFound = false;

            string Query = @"SELECT COUNT(*) FROM Products WHERE Barcode = @Barcode";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Barcode", Barcode);

                // استخدم ExecuteScalar للتحقق من وجود المنتج
                int count = Convert.ToInt32(command.ExecuteScalar());

                // إذا كانت النتيجة أكبر من 0، فهذا يعني أن المنتج موجود
                IsFound = count > 0;
            }
            catch (Exception ex)
            {
                // تسجيل الخطأ إذا لزم الأمر
                Console.WriteLine(ex.Message);
                IsFound = false;
            }
            finally
            {
                // إغلاق الاتصال
                clsConnection.connection.Close();
            }

            return IsFound;
        }

        // Is a product in table is Exist by Barcode and name
        public static bool IsProductExistByBarcodeAndName(string Barcode, string Name)
        {
            bool IsFound = false;

            string Query = @"SELECT COUNT(*) FROM Products WHERE Barcode = @Barcode or Name = @Name";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Barcode", Barcode);
                command.Parameters.AddWithValue("@Name", Name);

                // استخدم ExecuteScalar للتحقق من وجود المنتج
                int count = Convert.ToInt32(command.ExecuteScalar());

                // إذا كانت النتيجة أكبر من 0، فهذا يعني أن المنتج موجود
                IsFound = count > 0;
            }
            catch (Exception ex)
            {
                // تسجيل الخطأ إذا لزم الأمر
                Console.WriteLine(ex.Message);
                IsFound = false;
            }
            finally
            {
                // إغلاق الاتصال
                clsConnection.connection.Close();
            }

            return IsFound;
        }


        // delete product by ID
        public static bool DeleteProductByID(int ID)
        {
            bool IsFound = false;

            string Query = @"delete From Products where ID = @ID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@ID", ID);

                int Result = command.ExecuteNonQuery();

                if (Result > 0)
                    IsFound = true;
                else
                    IsFound = false;

            }
            catch (Exception ex)
            {
                //ex.Message;
                IsFound = false;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsFound;
        }

        // delete product by Barcode
        public static bool DeleteProductByBarcode(string Barcode)
        {
            bool IsFound = false;

            string Query = @"delete From Products where Barcode = @Barcode";

            try
            {
                clsConnection.connection.Open();

                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Barcode", Barcode);

                int Result = command.ExecuteNonQuery();

                if (Result > 0)
                    IsFound = true;
                else
                    IsFound = false;

            }
            catch (Exception ex)
            {
                //ex.Message;
                IsFound = false;
            }
            finally
            {
                clsConnection.connection.Close();
            }
            return IsFound;
        }

        public static DataTable GetAllProductUsingLikeByName(string Name)
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT * FROM Products where Name like '%'+@Name+'%'";
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
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();

            }

            return dt;
        }

        public static DataTable GetAllProductUsingLikeByNameOrBarcode(string value)
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT * FROM Products where Name like '%'+@value+'%' or Barcode = @value";
            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@value", value);

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

        // دالة لاسترجاع رقم المنتج من خلال اسم المنتج
        public static int GetProductIDByName(string Name)
        {
            int ProductID = -1;
            string Query = @"SELECT ID From Products where Name = @Name";
            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", Name);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    ProductID = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                ProductID = -1;
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return ProductID;
        }

        // دالة لاسترجاع رقم اخر منتج
        public static int GeLastIDProduct()
        {
            int LastID = -1;
            string Query = @"SELECT Top 1 ID FROM Products Order by ID desc";
            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    LastID = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                LastID = -1;
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return LastID;
        }

        // Get product is not has barcode the visicley
        // Find Product By Barcode
        public static DataTable GetAllProductIsNotHasBarcode(byte IsBarcode = 1)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT ID, Barcode, Name, Price, Image FROM Products WHERE IsBarcode = @IsBarcode";

            try
            {
                clsConnection.connection.Open();

                using (SqlCommand command = new SqlCommand(query, clsConnection.connection))
                {
                    command.Parameters.AddWithValue("@IsBarcode", IsBarcode);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (e.g., to a file or monitoring system)
                Console.WriteLine(ex.Message);
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return dt; // Return null if the product is not found
        }

        public static int GetQuantityItemByProducts(string Barcode)
        {
            int Quantity = -1;
            string Query = @"SELECT Quantity FROM Products  where Barcode = @Barcode";
            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Barcode", Barcode);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    Quantity = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                Quantity = -1;
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return Quantity;
        }

        public static int GetCountProducts()
        {
            int count = 0;
            string Query = @"SELECT Count(*) As CountProducts FROM Products";
            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    count = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return count;
        }

        public static int GetQuantityItemByName(string Name)
        {
            int Quantity = -1;
            string Query = @"SELECT Quantity FROM Products  where Name = @Name";
            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", Name);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    Quantity = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                Quantity = -1;
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return Quantity;
        }


        public static string GetBarcodeByName(string Name)
        {
            string Barcode = "";
            string Query = @"SELECT Barcode FROM Products  where Name = @Name";
            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", Name);

                Object Result = command.ExecuteScalar();

                if (Result != DBNull.Value)
                {
                    Barcode = Result.ToString();
                }

            }
            catch (Exception ex)
            {
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return Barcode;
        }

        public static bool UpdateNewQtyItemByName(string Name, int Quantity)
        {
            bool IsFound = false;

            string Query = @"update Products set
                            Quantity= Quantity + @Quantity 
                            where Name = @Name";
            try
            {
                clsConnection.connection.Open();
                SqlCommand command = new SqlCommand(Query, clsConnection.connection);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Quantity", Quantity);

                Object Result = command.ExecuteScalar();

                IsFound = Result != DBNull.Value ? true : false;

            }
            catch (Exception ex)
            {
                //ex.Message;
            }
            finally
            {
                clsConnection.connection.Close();
            }

            return IsFound;
        }

        // هذه الدالة سيتم نقلها مع الوقت الى كلاسها الخاص بالاشخاص عند تحسين الكود
        public static string GetImageNameByProductID(int ProductID)
        {
            string FileName = "";

            string Sql = @"SELECT Image FROM Products WHERE ID = @ProductID";

            try
            {
                clsConnection.connection.Open();

                SqlCommand cmd = new SqlCommand(Sql, clsConnection.connection);
                cmd.Parameters.AddWithValue("@ProductID", ProductID);

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read() || Reader.HasRows)
                {
                    FileName = (Reader["Image"] != DBNull.Value) ? Convert.ToString(Reader["Image"]) : "";
                }
                Reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally { clsConnection.connection.Close(); }

            return FileName;
        }
    }
}
