using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Org.BouncyCastle.Asn1.Mozilla;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace ITP4519M
{
    class DataBaseMethod
    {
        bool isConnected;

        public MySqlConnection ServerConnect()
        {
            string dbHost = "systemproject.mysql.database.azure.com";
            string dbUser = "Stick6770";
            string dbPass = "6sMpao&ei9M";
            string dbName = "systemproject";
            string dbSsl = "Required";
            string connStr = "Server=" + dbHost + ";Uid=" + dbUser + ";Pwd=" + dbPass + ";Database=" + dbName + ";SslMode=" + dbSsl + ";allow zero datetime = true; Convert Zero Datetime=True ";
            MySqlConnection conn = new MySqlConnection(connStr);
            isConnected = IsDatabaseConnected(connStr);

            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect the Database");
                        break;
                    case 1045:
                        Console.WriteLine("User or Password is wrong");
                        break;
                }
            }
            return conn;
        }

        public static bool IsDatabaseConnected(string connectionString)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (MySqlException)
            {
                return false;
            }
        }



        //Login with username
        public string getPassword(string userName)
        {
            string sql = "SELECT Password FROM staff WHERE UserName=@userName";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@userName", userName);
            object password = cmd.ExecuteScalar();
            ServerConnect().Close();
            if (password != null)
            {
                return password.ToString();
            }
            else
            {
                return string.Empty;
            }


        }

        //Checking user general role
        public string getDepartmentIDByUserName(string userName)
        {
            string sql = "SELECT DepartmentID FROM staff WHERE UserName=@userName";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@userName", userName);
            object departmentID = cmd.ExecuteScalar();
            ServerConnect().Close();
            return departmentID.ToString();
        }

        public string getDepartmentIDByDepartName(string departName)
        {
            string sql = "SELECT DepartmentID FROM staff WHERE Department=@departName";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@departName", departName);   
            ServerConnect().Close();
            object Department = cmd.ExecuteScalar();
            if (Department != null)
            {
                return Department.ToString();
            }
            else
            {
                return "Department not found.";
            }
        }


        //Get UserID length in DB when creating account
        public string getUserID()
        {
            string sql = "SELECT MAX(userID) FROM staff";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object userID = cmd.ExecuteScalar();
            ServerConnect().Close();
            return userID.ToString();
        }

        public string getUserDisplayName(string username)
        {
            string sql = "SELECT DisplayName FROM staff WHERE UserName=@username";
            using (MySqlCommand cmd = new MySqlCommand(sql, ServerConnect()))
            {
                cmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string displayName = reader["DisplayName"].ToString();
  
                        return displayName;
                    }
                    else
                    {
                        return ("displayName not found.");
                    }
                }
            }


        }

        public string getUserDepartment(string username)
        {
            string sql = "SELECT Department FROM staff WHERE UserName=@username";
            using (MySqlCommand cmd = new MySqlCommand(sql, ServerConnect()))
            {
                cmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string department = reader["Department"].ToString();
                        return department;
                    }
                    else
                    {
                        return ("Department not found.");
                    }
                }
            }


        }



        //Get departmentID when creating account match DepartmentID and departmentname
        public string getDeptID(string departmentName)
        {
            Debug.WriteLine(departmentName);
            string sql = "SELECT DepartmentID FROM department WHERE DepartmentName=@dept";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@dept", departmentName);
            object deptID = cmd.ExecuteScalar();
            ServerConnect().Close();
            if (deptID != null)
            {
                return deptID.ToString();
            }
            else
            {
                return "Department not found.";
            }
        }



        //Create a new user account
        public bool createUser(string userID, string username, string password, string displayname, string departmentID, string title, string phonenum, string email, string department)
        {
            try
            {
                string sql = "INSERT INTO staff(UserID, UserName, DisplayName, Password, DepartmentID, Title, PhoneNum, EmailAddress, Department) VALUES(@userID, @username, @displayname, @password, @departmentID, @title, @PhoneNum, @EmailAddress, @Department)";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@displayname", displayname);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@departmentID", departmentID);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@PhoneNum", phonenum);
                cmd.Parameters.AddWithValue("@EmailAddress", email);
                cmd.Parameters.AddWithValue("@Department", department);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }

        //disable a new user account
        public bool disableUser(string userID)
        {
            try
            {
                string sql = "UPDATE staff SET AccountStatus=@accountStatus WHERE UserID=@userID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@accountStatus", "Inactive");
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }

        public bool delProduct(string productID)
        {
            try
            {
                string sql = "DELETE FROM product WHERE ProductID=@ProductID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@ProductID", productID);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }

        public bool contactDel(string contactID)
        {
            string sql;
            try
            {
                if (contactID.StartsWith("D"))
                {
                    sql = "DELETE FROM dealer WHERE DealerID=@ContactID";
                }
                else {
                    sql = "DELETE FROM supplier WHERE SupplierID=@ContactID";
                }

                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@ContactID", contactID);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }

        //enable a new user account
        public bool enableUser(string userID)
        {
            try
            {
                string sql = "UPDATE staff SET AccountStatus=@accountStatus WHERE UserID=@userID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@accountStatus", "Active");
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }

        //search username
        public DataTable searchUserInfoByName(string username)
        {
            //  string sql = "SELECT * FROM staff, department WHERE department.departmentID = staff.DepartmentID AND UserName LIKE @username";
            string sql = "SELECT * FROM staff WHERE UserName LIKE @username";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@username", "%"+username+"%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        //searchSupplierInfoByName
        public DataTable searchDealerInfoByName(string contactname) { 

            string sql = "SELECT * FROM dealer WHERE DealerName LIKE @contactname";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@contactname", "%" + contactname + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable searchSupplierInfoByName(string contactname)
        {

            string sql = "SELECT * FROM supplier WHERE SupplierName LIKE @contactname";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@contactname", "%" + contactname + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        //search product name
        public DataTable searchProductInfoByName(string productname)
        {
            string sql = "SELECT ProductID, ProductName, ProductCategory, BinLocation, UnitPrice, CostPrice, QuantityInStock, DemandStock, Status FROM product WHERE ProductName LIKE @productname";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@productname", "%"+productname+"%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }


        //search username by departmentName
        public DataTable searchUserInformation(string username, string dept)
        {
            string sql = "SELECT UserID, UserName, Password, department.DepartmentName, Title FROM staff, department WHERE staff.DepartmentID=department.DepartmentID AND UserID=@userName OR UserName=@userName AND department.DepartmentName=@dept";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@dept", dept);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable overallUserInfo()
        {
            string sql = "SELECT * FROM staff";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }


        public DataTable overviewDealerinfo()
        {
            string sql = "SELECT * FROM dealer";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable overviewSupplierinfo()
        {
            string sql = "SELECT * FROM supplier";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public UserDetails GetUserDetails(MySqlConnection connection, string userID)
        {
            UserDetails userDetails = null;
            string query = "SELECT * FROM staff WHERE UserID = @UserID";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", userID);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    userDetails = new UserDetails
                    {
                        UserID = reader["UserID"].ToString(),
                        UserName = reader["UserName"].ToString(),
                        Department = reader["Department"].ToString(),
                        EmailAddress = reader["EmailAddress"].ToString(),
                        DisplayName = reader["DisplayName"].ToString(),
                        Title = reader["Title"].ToString(),
                        PhoneNum = reader["PhoneNum"].ToString()
                 
                    };
                }
            }
            return userDetails;
        }


        public class UserDetails
        {
            public string UserID { get; set; }
            public string UserName { get; set; }
            public string EmailAddress { get; set; }
            public string PhoneNum { get; set; }
            public string Department { get; set; }
            public string DisplayName { get; set; }
            public string Title { get; set; }


        }

        public DealerDetails GetDealerDetails(MySqlConnection connection, string dealerID)
        {
            DealerDetails dealerDetails = null;
            string query = "SELECT * FROM dealer WHERE DealerID = @DealerID";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@DealerID", dealerID);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    dealerDetails = new DealerDetails
                    {
                        DealerID = reader["DealerID"].ToString(),
                        DealerName = reader["DealerName"].ToString(),
                        DealerCompanyName = reader["DealerCompanyName"].ToString(),
                        DealerPhoneNum = reader["DealerPhoneNum"].ToString(),
                        DealerEmailAddress = reader["DealerEmailAddress"].ToString(),


                    };
                }
            }
            return dealerDetails;
        }


        public class DealerDetails
        {
            public string DealerID { get; set; }
            public string DealerName { get; set; }
            public string DealerCompanyName { get; set; }
            public string DealerPhoneNum { get; set; }
            public string DealerEmailAddress { get; set; }


        }

        public SupplierDetails GetSupplierDetails(MySqlConnection connection, string supplierID)
        {
            SupplierDetails supplierDetails = null;
            string query = "SELECT * FROM supplier WHERE SupplierID = @SupplierID";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@SupplierID", supplierID);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    supplierDetails = new SupplierDetails
                    {
                        SupplierID = reader["SupplierID"].ToString(),
                        SupplierName = reader["SupplierName"].ToString(),
                        SupplierPhoneNum = reader["SupplierPhoneNum"].ToString(),
                        SupplierEmail = reader["SupplierEmail"].ToString(),
                        SupplierAddress = reader["SupplierAddress"].ToString(),


                    };
                }
            }
            return supplierDetails;
        }


        public class SupplierDetails
        {
            public string SupplierID { get; set; }
            public string SupplierName { get; set; }
            public string SupplierPhoneNum { get; set; }
            public string SupplierEmail { get; set; }
            public string SupplierAddress { get; set; }


        }


        public ProductDetails GetProductDetails(MySqlConnection connection, string productID)
        {
            ProductDetails productDetails = null;
            string query = "SELECT * FROM product WHERE ProductID = @ProductID";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductID", productID);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    productDetails = new ProductDetails
                    {
                        ProductID = reader["ProductID"].ToString(),
                        ProductName = reader["ProductName"].ToString(),
                        SerialNumber = reader["SerialNumber"].ToString(),
                        ProductCategory = reader["ProductCategory"].ToString(),
                        BinLocation = reader["BinLocation"].ToString(),
                        Weight = reader["Weight"].ToString(),
                        UnitPrice = reader["UnitPrice"].ToString(),
                        CostPrice = reader["CostPrice"].ToString(),
                        autoOrder = reader["autoOrder"].ToString(),
                        QuantityInStock = reader["QuantityInStock"].ToString(),
                        DemandStock = reader["DemandStock"].ToString(),
                        ReOrderQty = reader["ReOrderQty"].ToString(),
                        DangerQty = reader["DangerQty"].ToString(),
                        Description = reader["Description"].ToString(),
                        Status = reader["Status"].ToString()
                    };
                }
            }
            return productDetails;
        }


        public class ProductDetails
        {
            public string ProductID { get; set; }
            public string ProductName { get; set; }
            public string SerialNumber { get; set; }
            public string ProductCategory { get; set; }
            public string BinLocation { get; set; }
            public string Weight { get; set; }
            public string UnitPrice { get; set; }
            public string CostPrice { get; set; }
            public string autoOrder { get; set; }
            public string QuantityInStock { get; set; }
            public string DemandStock { get; set; }
            public string ReOrderQty { get; set; }
            public string DangerQty { get; set; }
            public string Description { get; set; }
            public string Status { get; set; }
        }


        //Update User information
        public bool updateUserInfor(string userID, string userName, string password, string displayName, string deptID, string title, string phonenum, string email, string department)
        {
            try
            {
                string sql = "UPDATE staff SET UserName=@userName, Password=@password, DisplayName=@displayName, DepartmentID=@deptID, Title=@title, EmailAddress=@email, PhoneNum=@phonenum, Department=@department WHERE UserID=@userID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@displayName", displayName);
                cmd.Parameters.AddWithValue("@deptID", deptID);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phonenum", phonenum);
                cmd.Parameters.AddWithValue("@department", department);
                cmd.Parameters.AddWithValue("@userID", userID);
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                    return true;
            }
            catch (MySqlException ex) {
                Console.WriteLine("MySQL Error: " + ex.Message);
            }
            return false;
        }

        public DataTable overallStockinfo()
        {
            string sql = "SELECT ProductID, ProductName, ProductCategory, BinLocation, UnitPrice, CostPrice, QuantityInStock, DemandStock, Status FROM product";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable overallOrderinfo()
        {
            string sql = "SELECT * FROM `order` ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }


        //Get current max ID when creating new product
        public String getProductID(char character)
        {
            string sql = "SELECT MAX(ProductID) FROM product WHERE LEFT(ProductID,1)=@character";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@character", character);
            Object productID = cmd.ExecuteScalar();
            return productID.ToString();
        }
                                            //productID, productName, productCategory, wareHouse, sn, unitPrice, costPrice, weight, autoOrder, quantityInStock,  demand, description, status
        public bool createNewProduct(string productID, string productname , string productcategory, string binlocation, String sn, string unitprice, string costprice, string weight, string autoOrder, string quantitystock,  string demandstock, string description, string status )
        {
            try
            {
                string sql = "INSERT INTO product(ProductID, ProductName, SerialNumber, ProductCategory, BinLocation, Weight, UnitPrice, CostPrice, autoOrder, QuantityInStock, DemandStock, Description, Status) VALUES (@pid, @pName, @sn, @pCategory, @binLocation, @weight, @uniPrice, @costPrice, @autoOrder, @quantityStock, @demandStock,  @description, @status)";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@pid", productID);
                cmd.Parameters.AddWithValue("@pName", productname);
                cmd.Parameters.AddWithValue("@sn", sn);
                cmd.Parameters.AddWithValue("@pCategory",productcategory);
                cmd.Parameters.AddWithValue("@binLocation", binlocation);
                cmd.Parameters.AddWithValue("@weight", weight);
                cmd.Parameters.AddWithValue("@uniPrice", unitprice);
                cmd.Parameters.AddWithValue("@costPrice", costprice);
                cmd.Parameters.AddWithValue("@autoOrder", autoOrder);
                cmd.Parameters.AddWithValue("@quantityStock", quantitystock);
                cmd.Parameters.AddWithValue("@demandStock", demandstock);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@status", status);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }
        
        public bool updateProductinfo(string productID, string productname, string productcategory, string binlocation, string sn, string unitprice, string costprice, string weight, string autoOrder, string quantitystock, string demandstock, string description, string status)
        {
            try
            {
                
                string sql = "UPDATE product SET ProductName = @pName, SerialNumber = @sn, ProductCategory = @pCategory, BinLocation = @binLocation, Weight = @weight, UnitPrice = @unitPrice, CostPrice = @costPrice, autoOrder = @autoOrder, QuantityInStock = @quantityStock, DemandStock = @demandStock, Description = @description, Status = @status WHERE ProductID = @pid";
                
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@pid", productID);
                cmd.Parameters.AddWithValue("@pName", productname);
                cmd.Parameters.AddWithValue("@sn", sn);
                cmd.Parameters.AddWithValue("@pCategory", productcategory);
                cmd.Parameters.AddWithValue("@binLocation", binlocation);
                cmd.Parameters.AddWithValue("@weight", weight);
                cmd.Parameters.AddWithValue("@unitPrice", unitprice);
                cmd.Parameters.AddWithValue("@costPrice", costprice);
                cmd.Parameters.AddWithValue("@autoOrder", autoOrder);
                cmd.Parameters.AddWithValue("@quantityStock", quantitystock);
                cmd.Parameters.AddWithValue("@demandStock", demandstock);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@status", status);


                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }
        //dealerID, dealername, dealerCompanyName, dealerMailBox, DealerPhoneNumBox, dealerAddressBox
        public bool createDealer(string dealerID, string dealername, string dealerCompanyName, string dealerMailBox, string dealerPhoneNumBox, string dealerAddressBox)
        {
            try
            {
                string sql = "INSERT INTO dealer(DealerID, DealerName, DealerCompanyName, DealerPhoneNum, DealerEmailAddress) VALUES(@DealerID, @DealerName, @DealerCompanyName, @DealerPhoneNum, @DealerEmailAddress)";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@DealerID", dealerID);
                cmd.Parameters.AddWithValue("@DealerName", dealername);
                cmd.Parameters.AddWithValue("@DealerCompanyName", dealerCompanyName);
                cmd.Parameters.AddWithValue("@DealerEmailAddress", dealerMailBox);
                cmd.Parameters.AddWithValue("@DealerPhoneNum", dealerPhoneNumBox);
              //  cmd.Parameters.AddWithValue("@DealerAddressBox", dealerAddressBox);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }
        public bool updateDealerInfo(string dealerid, String dealerName, string dealerCompanyName, string dealerMail, string dealerPhoneNum, string dealerAddress)
        {
            try
            {

                string sql = "UPDATE dealer SET DealerName = @dealerName, DealerCompanyName = @dealerCompanyName, DealerPhoneNum = @dealerPhoneNum, DealerEmailAddress = @dealerEmailAddress WHERE DealerID = @dealerID";

                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@dealerID", dealerid);
                cmd.Parameters.AddWithValue("@dealerName", dealerName);
                cmd.Parameters.AddWithValue("@dealerCompanyName", dealerCompanyName);
                cmd.Parameters.AddWithValue("@dealerPhoneNum", dealerPhoneNum);
                cmd.Parameters.AddWithValue("@dealerEmailAddress", dealerMail);
              //  cmd.Parameters.AddWithValue("@DealerAddress", dealerAddress);



                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }

        public bool createSupplier(string SupplierID, string Suppliername, string SupplierMailBox, string SupplierPhoneNumBox, string SupplierAddressBox)
        {
            try
            {
                string sql = "INSERT INTO Supplier(SupplierID, SupplierName,  SupplierPhoneNum, SupplierEmail) VALUES(@SupplierID, @SupplierName, @SupplierPhoneNum, @SupplierEmail)";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@SupplierID", SupplierID);
                cmd.Parameters.AddWithValue("@SupplierName", Suppliername);
                cmd.Parameters.AddWithValue("@SupplierEmail", SupplierMailBox);
                cmd.Parameters.AddWithValue("@SupplierPhoneNum", SupplierPhoneNumBox);


                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }
        public bool updateSupplierInfo(string supplierid, String supplierName, string supplierMail, string supplierPhoneNum, string supplierAddress)
        {
            try
            {

                string sql = "UPDATE supplier SET SupplierName = @SupplierName, SupplierPhoneNum = @SupplierPhoneNum, SupplierEmail = @SupplierEmail, SupplierAddress = @SupplierAddress WHERE SupplierID = @SupplierID";

                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@SupplierID", supplierid);
                cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                cmd.Parameters.AddWithValue("@SupplierPhoneNum", supplierPhoneNum); 
                cmd.Parameters.AddWithValue("@SupplierEmail", supplierMail);
                cmd.Parameters.AddWithValue("@SupplierAddress", supplierAddress);
                //  cmd.Parameters.AddWithValue("@DealerAddress", dealerAddress);



                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }

        public bool CreateDealer(string dealerID, string dearlerOrderNo, string dealerName, string companyName, string phoneNum, string Eamil,  string regionNo)
        {
            string sql = "INSERT INTO dealer VALUES(@dealerID, @dealerOderNo, @dealerName, @companyName, @phoneNum, @Email, @regionNo)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@dealerID", dealerID);
            cmd.Parameters.AddWithValue("@dealerOrderNo", dearlerOrderNo);
            cmd.Parameters.AddWithValue("@dealerName", dealerName);
            cmd.Parameters.AddWithValue("@companyName", companyName);
            cmd.Parameters.AddWithValue("@phoneNum", phoneNum);
            cmd.Parameters.AddWithValue("@Email", Eamil);
            cmd.Parameters.AddWithValue("@regionNo", regionNo);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }



        public string searchDealerID(string dealerID)
        {
            try
            {
                string sql = "SELECT DealerID FROM dealer WHERE DealerID=@dealerID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@dealerID", dealerID);
                Object dealer = cmd.ExecuteScalar();
                return dealer.ToString();
            }
            catch
            { return null; }
        }

        public string searchOrderID(string orderID)
        {
            try
            {
                string sql = "SELECT OrderID FROM `order` WHERE OrderID=@orderID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@orderID", orderID);
                Object order = cmd.ExecuteScalar();
                return order.ToString();
            }
            catch
            { return null; }
        }

        public DataTable searchDealerDetail(string dealerID)
        {
            string sql = "SELECT * FROM dealer WHERE DealerID=@dealerID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@dealerID", dealerID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public string searchProductIDofOrder(string productID)
        {
            try {
                string sql = "SELECT ProductID FROM product WHERE ProductID=@productid";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@productid", productID);
                Object product = cmd.ExecuteScalar();
                return product.ToString();
            } catch { return null; }


        }

        public string searchProductNameOrder(string ProductName)
        {
            try { 
                string sql = "SELECT ProductName FROM product WHERE ProductName=@productname";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@productname", ProductName);
                Object dealer = cmd.ExecuteScalar();
                return dealer.ToString();
            
            }catch { return null; }
            }

        public DataTable searchOrderItemDetail(string keyword)
        {
            string sql = "SELECT * FROM product WHERE ProductID=@keyword OR ProductName=@keyword";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword", keyword);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }


        public string getDealerID()
        {
            string sql = "SELECT MAX(DealerID) FROM dealer";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            Object dealer = cmd.ExecuteScalar();
            return dealer.ToString();
        }

        public string getSupplierID()
        {
            string sql = "SELECT MAX(SupplierID) FROM supplier";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            Object supplier = cmd.ExecuteScalar();
            return supplier.ToString();
        }


        public string getOrderID()
        {   
            string sql = "SELECT MAX(OrderID) FROM `order` ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            Object orderID = cmd.ExecuteScalar();
            return orderID.ToString();
        }


        public bool createSalesOrder(string orderID, string dealerID, string orderstatusID)
        {
            DateTime orderDate = DateTime.Now;
            orderDate.ToString("yyyy-MM-dd HH:mm");
            Console.WriteLine(orderDate);
            string sql = "INSERT INTO `order` (OrderID, DealerID, OrderStatusID, OrderDate) VALUES(@orderID, @dealerID, @orderStatusID, @orderDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@dealerID", dealerID);
            cmd.Parameters.AddWithValue("@orderStatusID", orderstatusID);
            cmd.Parameters.AddWithValue("@orderDate", orderDate);

            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool createOrderItem(string orderID, string productID, string orderQty)
        {
            string sql = "INSERT INTO orderitem (ProductID,OrderID, OrderedQuantity) VALUES(@orderID,@productID,@orderQty)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@orderQty", orderQty);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool updateOrderItemDemand(string productID, int Qty)
        {
            string sql = "UPDATE product SET DemandStock=DemandStock+@Qty WHERE ProductID=@productID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@Qty", Qty);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }


        //public OrderDetails GetOrderDetails(MySqlConnection connection, string orderID)
        //{
        //    OrderDetails oderDetails = null;
        //    string query = "SELECT * FROM `order`WHERE OrderID = @orderID";

        //    MySqlCommand command = new MySqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@UserID", orderID);

        //    using (MySqlDataReader reader = command.ExecuteReader())
        //    {
        //        if (reader.Read())
        //        {
        //            oderDetails = new UserDetails
        //            {
        //                OrderID = reader["OrderID"].ToString(),
        //                DealerID = reader["DealerID"].ToString(),
        //                OrderSatusID = reader["OrderStatusID"].ToString(),
        //                OrderDate = reader["OrderDate"].ToString(),

        //            };
        //        }
        //    }
        //    return OrderDetails;
        //}

        public DataTable getOrderDetails(string orderID)
        {
            string sql = "SELECT * FROM `order` WHERE OrderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;

        }

        public DataTable getOrderDealerName(string orderID, string dealerID)
        { 
            string sql = "SELECT DealerName, DealerCompanyName, DealerPhoneNum FROM dealer, `order` WHERE dealer.DealerID = `order`.DealerID AND dealer.DealerID = @dealerID AND `order`.OrderID = @orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@dealerID", dealerID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getOrderItemDetails(string orderID) 
        {
            string sql = "SELECT * FROM orderitem WHERE OrderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getOrderItemProductDeatails(string orderID, string productID) 
        {
            string sql = "SELECT ProductName, UnitPrice FROM product, orderitem WHERE orderitem.ProductID= product.ProductID AND orderitem.OrderID =@orderID ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@productID", productID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable searchGRNDate(string startDate, string endDate)
        {
            string sql = "SELECT * FROM grn WHERE ReceiveDate BETWEEN @startdate AND @enddate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@startdate", startDate);
            cmd.Parameters.AddWithValue("@enddate", endDate);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable overallGRNinfo()
        {
            string sql = "SELECT * FROM grn ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;

        }

        public void increaseStock(string productID, int qty ) 
        {
            string sql = "UPDATE item SET QuantityInStock=QuantityInStock+ @qty WHERE ProrductID=@productID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.ExecuteNonQuery();
        }


        public bool createGRN(string grnID, string POID, string productID, string warehouse , string recQty, string recDate)
        {

            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO grn (grnID, PurcahseOrderID, ProductID, ReceiveQty, ReceiveDate, WareHouse)VALUES(@grnID, @poID @productID, @recqty, @recdate, @warehouse)";           
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@grnID", grnID);
            cmd.Parameters.AddWithValue("@poID", POID);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@recqty", recQty);
            cmd.Parameters.AddWithValue("@recdate", recDate);
            cmd.Parameters.AddWithValue("@warehouse", warehouse);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }

        public string getGRNID(char character) 
        {
            string sql = "SELECT MAX(grnID) FROM grn WHERE LEFT(grnID,1)=@character";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@character", character);
            Object grn = cmd.ExecuteScalar();
            return grn.ToString();
        }
    }

}
