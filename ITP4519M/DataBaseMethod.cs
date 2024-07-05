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
using static ProgramMethod.ProgramMethod;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Drawing.Printing;
using Org.BouncyCastle.Asn1.X509;
using System.Drawing;
using System.Diagnostics.Tracing;
using System.Globalization;
using MySqlX.XDevAPI.Common;
using static ITP4519M.DataBaseMethod;


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

            if (password != null)
            {
                return password.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public bool getUserNameAndCheckStaus(string userName)
        {
            string sql = "SELECT COUNT(UserName) FROM staff WHERE UserName=@userName AND AccountStatus='active'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@userName", userName);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }


        //Checking user general role
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

        public string getDepartmentIDbyUsername(string username)
        {

            string sql = "select DepartmentID from staff where UserName=@userName";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@userName", username);
            object title = cmd.ExecuteScalar();
            ServerConnect().Close();
            return title.ToString();
        }

        public string getUserTitle(string userName)
        {
            string sql = "SELECT Title FROM staff WHERE UserName=@userName";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@userName", userName);
            ServerConnect().Close();
            object title = cmd.ExecuteScalar();
            return title.ToString();
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

        public bool getUserStatus(string username)
        {
            string sql = "SELECT AccountStatus FROM staff WHERE UserName=@userName";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@userName", username);
            ServerConnect().Close();
            object result = cmd.ExecuteScalar();
            if (result.ToString() == "Inactive")
            {
                result = false;
            }

            return true;
        }

        public string getUserID(string userName)
        {
            string sql = "SELECT UserID FROM staff WHERE UserName =@userName";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@userName", userName);
            object userID = cmd.ExecuteScalar();
            ServerConnect().Close();
            return userID.ToString();
        }

        

        //public void udpateLastLoginTime(string userID)
        //{
        //    string sql = "Update INTO staff SET WHERE UserName =@userName";
        //    MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
        //    cmd.Parameters.AddWithValue("@userName", userName);
        //    object userID = cmd.ExecuteScalar();
        //    ServerConnect().Close();
        //    return userID.ToString();
        //}

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
                using (var connection = ServerConnect())
                {


                    if (AccountExistsInDatabase(connection, "UserName", username))
                    {
                        MessageBox.Show("The username already exists. Please choose a different username.");
                        return false;
                    }

                    if (AccountExistsInDatabase(connection, "EmailAddress", email))
                    {
                        MessageBox.Show("The email address already exists. Please use a different email address.");
                        return false;
                    }

                    if (AccountExistsInDatabase(connection, "PhoneNum", phonenum))
                    {
                        MessageBox.Show("The phone number already exists. Please use a different phone number.");
                        return false;
                    }

                    string sql = "INSERT INTO staff(UserID, UserName, DisplayName, Password, DepartmentID, Title, PhoneNum, EmailAddress, Department) " +
                                 "VALUES(@userID, @username, @displayname, @password, @departmentID, @title, @PhoneNum, @EmailAddress, @Department)";

                    MySqlCommand cmd = new MySqlCommand(sql, connection);
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
                    {
                        return true;
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }

        private bool AccountExistsInDatabase(MySqlConnection connection, string column, string value, string userID = null)
        {
            string sql = $"SELECT COUNT(*) FROM staff WHERE {column} = @value";
            if (!string.IsNullOrEmpty(userID))
            {
                sql += " AND UserID != @userID";
            }
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@value", value);
            if (!string.IsNullOrEmpty(userID))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
            }
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
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
            ServerConnect().Close();
            return false;
        }

        public bool dealerDel(string contactID)
        {
            string sql;
            try
            {

                sql = "DELETE FROM dealer WHERE DealerID=@ContactID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@ContactID", contactID);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            ServerConnect().Close();
            return false;
        }

        public bool supplierDel(string contactID, string productID)
        {
            string sql1;
            string sql2;
            string sqlCheck;
            try
            {

                sql1 = "DELETE FROM supplierproducts WHERE SupplierID=@ContactID and ProductID=@ProductID";
                sql2 = "DELETE FROM supplier WHERE SupplierID=@ContactID";
                sqlCheck = "SELECT COUNT(*) FROM supplierproducts WHERE SupplierID=@ContactID";

                MySqlCommand cmd = new MySqlCommand(sql1, ServerConnect());
                cmd.Parameters.AddWithValue("@ContactID", contactID);
                cmd.Parameters.AddWithValue("@ProductID", productID);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, ServerConnect());
                    cmdCheck.Parameters.AddWithValue("@ContactID", contactID);

                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    // If no other records exist for this SupplierID, delete the supplier
                    if (count == 0)
                    {
                        sql2 = "DELETE FROM supplier WHERE SupplierID=@ContactID";
                        MySqlCommand cmd2 = new MySqlCommand(sql2, ServerConnect());
                        cmd2.Parameters.AddWithValue("@ContactID", contactID);
                        cmd2.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            ServerConnect().Close();
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
            ServerConnect().Close();
            return false;
        }

        //search username
        public DataTable searchUserInfoByName(string username)
        {
            //  string sql = "SELECT * FROM staff, department WHERE department.departmentID = staff.DepartmentID AND UserName LIKE @username";
            string sql = "SELECT * FROM staff WHERE UserName LIKE @username";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@username", "%" + username + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }
        //searchSupplierInfoByName
        public DataTable searchDealerInfoByName(string contactname)
        {

            string sql = "SELECT * FROM dealer WHERE DealerName LIKE @contactname";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@contactname", "%" + contactname + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable searchSupplierInfoByName(string contactname)
        {

            string sql = "SELECT * FROM supplier WHERE SupplierCompanyName LIKE @contactname";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@contactname", "%" + contactname + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }


        public DataTable GetDealerCurrentRecords(int page, int pageSize)
        {
            string sql = "SELECT * FROM dealer ORDER BY DealerID LIMIT @PgSize";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable GetDealerCurrentRecords2(int page, int pageSize)
        {
            string sql = "SELECT * FROM (SELECT * FROM dealer ORDER BY DealerID LIMIT @PreviousPageOffset, @PgSize) AS subquery ORDER BY DealerID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            cmd.Parameters.AddWithValue("@PreviousPageOffset", (page - 1) * pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable GetSupplierCurrentRecords(int page, int pageSize)
        {
            string sql = "SELECT s.SupplierID, p.ProductID, s.SupplierCompanyName, s.SupplierContactPerson, s.SupplierPhoneNum, s.SupplierEmail, s.SupplierAddress, p.ProductName FROM supplier s LEFT JOIN supplierproducts sp ON s.SupplierID = sp.SupplierID LEFT JOIN product p ON sp.ProductID = p.ProductID ORDER BY s.SupplierID LIMIT @PgSize";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;

        }

        public DataTable GetSupplierCurrentRecords2(int page, int pageSize)
        {
            string sql = "SELECT* FROM(SELECT s.SupplierID, p.ProductID, s.SupplierCompanyName, s.SupplierContactPerson, s.SupplierPhoneNum, s.SupplierEmail, s.SupplierAddress, p.ProductName FROM supplier s LEFT JOIN supplierproducts sp ON s.SupplierID = sp.SupplierID LEFT JOIN product p ON sp.ProductID = p.ProductID ORDER BY s.SupplierID LIMIT @PreviousPageOffset, @PgSize) AS subquery ORDER BY SupplierID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            cmd.Parameters.AddWithValue("@PreviousPageOffset", (page - 1) * pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }
        
        //search product information
        public DataTable searchProductInfo(string keyword)
        {
            string sql = "SELECT ProductID, ProductName, SerialNumber AS PartNumber, BinLocation AS WareHouse, DemandStock, Status ,UnitPrice, QuantityInStock FROM product WHERE ProductID LIKE @keyword1 OR ProductName LIKE @keyword1 OR ProductName LIKE @keyword2 OR ProductID LIKE @keyword2 OR ProductName LIKE @keyword2";
            //string sql = "SELECT ProductID, ProductName, SerialNumber AS PartNumber, BinLocation AS WareHouse, DemandStock, Status ,UnitPrice, QuantityInStock FROM product WHERE ProductName LIKE @keyword OR ProductID LIKE @keyword OR SerialNumber LIKE @keyword";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword1", "%" + keyword + "%");
            string keyword2 = keyword.Length > 0 ? $"%{char.ToUpper(keyword[0])}{keyword.Substring(1)}%" : keyword;
            cmd.Parameters.AddWithValue("@keyword2", keyword2);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable searchInvoiceInfo(string keyword)
        {
            string sql = "SELECT *  FROM invoice WHERE InvoiceID LIKE @keyword1 OR OrderID LIKE @keyword1 OR DealerID LIKE @keyword1 OR DeliveryID LIKE @keyword1 OR DeliveryID LIKE @keyword2 OR OrderID LIKE @keyword2 OR DealerID LIKE @keyword2 OR DeliveryID LIKE @keyword2 ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword1", "%" + keyword + "%");
            string keyword2 = keyword.Length > 0 ? $"%{char.ToUpper(keyword[0])}{keyword.Substring(1)}%" : keyword;
            cmd.Parameters.AddWithValue("@keyword2", keyword2);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }


        public DataTable searchDeliveryNote(string keyword)
        {
            string sql = "SELECT DeliveryID,OrderID, DeliveryDate , DeliveryStatus FROM delivery WHERE deliveryID LIKE @keyword OR OrderID LIKE @keyword";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
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
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable overallUserInfo()
        {
            string sql = "SELECT * FROM staff";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }


        public DataTable overviewDealerinfo()
        {
            string sql = "SELECT * FROM dealer";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable overviewSupplierinfo()
        {
            string sql = "SELECT * FROM supplier";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public int GetDealerCount()
        {
            string sql = "SELECT COUNT(*) FROM dealer";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            ServerConnect().Close();
            return count;
        }

        public int GetSupplierCount()
        {
            string sql = "SELECT COUNT(*) FROM supplierproducts";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            ServerConnect().Close();
            return count;
        }

        public int GetSupplierNum()
        {
            string sql = "SELECT COUNT(*) FROM supplier";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            ServerConnect().Close();
            return count;
        }

        public int GetPOCount()
        {
            string sql = "SELECT COUNT(PurchaseOrderID) FROM purchaseorder";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            ServerConnect().Close();
            return count;
        }

        public int GetInvoiceCount()
        {
            string sql = "SELECT COUNT(InvoiceID) FROM invoice";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            ServerConnect().Close();
            return count;
        }

        public int GetOrderCount()
        {
            string sql = "SELECT COUNT(OrderID) FROM 1";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            ServerConnect().Close();
            return count;
        }

        public int GetDeliveryCount()
        {
            string sql = "SELECT COUNT(DeliveryID) FROM delivery";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            ServerConnect().Close();
            return count;
        }

        public int GetGRNCount()
        {
            string sql = "SELECT COUNT(grnID) FROM grn";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            ServerConnect().Close();
            return count;
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
                        DealerRegionNum = reader["DealerRegionNum"].ToString(),
                        DealerCompanyAddress = reader["DealerCompanyAddress"].ToString(),
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
            public string DealerRegionNum { get; set; }
            public string DealerCompanyAddress { get; set; }

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
                        SupplierCompanyName = reader["SupplierCompanyName"].ToString(),
                        SupplierContactPerson = reader["SupplierContactPerson"].ToString(),
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
            public string SupplierCompanyName { get; set; }
            public string SupplierContactPerson { get; set; }
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
                        OutOfStockQty = reader["OutOfStockQty"].ToString(),
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
            public string OutOfStockQty { get; set; }
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
                using (var connection = ServerConnect())
                {

                    if (AccountExistsInDatabase(connection, "UserName", userName, userID))
                    {
                        MessageBox.Show("The username already exists. Please choose a different username.");
                        return false;
                    }

                    if (AccountExistsInDatabase(connection, "EmailAddress", email, userID))
                    {
                        MessageBox.Show("The email address already exists. Please use a different email address.");
                        return false;
                    }

                    if (AccountExistsInDatabase(connection, "PhoneNum", phonenum, userID))
                    {
                        MessageBox.Show("The phone number already exists. Please use a different phone number.");
                        return false;
                    }

                    string sql = "UPDATE staff SET UserName=@userName, Password=@password, DisplayName=@displayName, DepartmentID=@deptID, Title=@title, EmailAddress=@email, PhoneNum=@phonenum, Department=@department WHERE UserID=@userID";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
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
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL Error: " + ex.Message);
            }
            return false;
        }
        public DataTable getProductID()
        {
            string sql = "SELECT ProductID  FROM product";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getProductCategory()
        {
            string sql = "SELECT distinct ProductCategory FROM product";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable overallStockinfo()
        {
            string sql = "SELECT ProductID,ProductName, SerialNumber, BinLocation, DemandStock, Status, QuantityInStock, UnitPrice FROM product";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getStockReOrderInfo()
        {
            string sql = "SELECT ProductID,ProductName, SerialNumber, BinLocation, DemandStock, Status, QuantityInStock, UnitPrice FROM  product WHERE Status = 'Re-Order'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getStockOutOfStockInfo()
        {
            string sql = "SELECT ProductID ,ProductName, SerialNumber, BinLocation, DemandStock, Status, QuantityInStock, UnitPrice FROM product WHERE Status = 'Out-Of-Stock'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getStockDangerInfo()
        {
            string sql = "SELECT ProductID,ProductName, SerialNumber, BinLocation, DemandStock, Status, QuantityInStock, UnitPrice  FROM product WHERE Status = 'Danger'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }


        public string getStockOutofStockLevelLabel()
        {
            string sql = "SELECT COUNT(*) FROM product WHERE Status = 'Out-of-Stock'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object result = cmd.ExecuteScalar();
            ServerConnect().Close();
            return result.ToString();
        }

        public string getStockDangerLevelLabel()
        {
            string sql = "SELECT COUNT(*) FROM product WHERE Status = 'Danger'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object result = cmd.ExecuteScalar();
            ServerConnect().Close();
            return result.ToString();
        }

        public string getStockReOrderLevelLabel()
        {
            string sql = "SELECT COUNT(*) FROM product WHERE Status = 'Re-Order'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object result = cmd.ExecuteScalar();
            ServerConnect().Close();
            return result.ToString();
        }

        
        public DataTable overallOrderinfo()
        {
            string sql = "SELECT OrderID, DealerID, OrderStatus, OrderDate FROM `order` WHERE OrderStatus = 'OrderProcessing' OR OrderStatus = 'PartialProductPackaged' OR OrderStatus = 'ALLProductPackaged'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable searchOrderAccembly(string keyword)
        {
            string sql = "SELECT OrderID, DealerID, OrderStatus, OrderDate FROM `order` WHERE (OrderStatus = 'OrderProcessing' OR OrderStatus = 'PartialProductPackaged' OR OrderStatus = 'ALLProductPackaged') AND OrderID LIKE @keyword ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@keyword",keyword);
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
        public bool createNewProduct(string productID, string productname, string productcategory, string binlocation, String sn, string unitprice, string costprice, string weight, string outofStockQty, string quantitystock, string productReOrder, string productDanger, string demandstock, string description, string status)
        {
            try
            {
                using (var connection = ServerConnect())
                {

                    if (productExistsInDatabase(connection, "product", "ProductName", productname))
                    {
                        MessageBox.Show("The product name already exists. Please choose a different name.");
                        return false;
                    }

                    if (productExistsInDatabase(connection, "product", "SerialNumber", sn))
                    {
                        MessageBox.Show("The serial number already exists. Please use a different serial number.");
                        return false;
                    }

                    string sql = "INSERT INTO product(ProductID, ProductName, SerialNumber, ProductCategory, BinLocation, Weight, UnitPrice, CostPrice, OutOfStockQty, QuantityInStock, ReOrderQty, DangerQty, DemandStock, Description, Status) VALUES (@pid, @pName, @sn, @pCategory, @binLocation, @weight, @uniPrice, @costPrice, @OutOfStockQty, @quantityStock,  @reOrderQty, @dangerQty, @demandStock,  @description, @status)";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@pid", productID);
                    cmd.Parameters.AddWithValue("@pName", productname);
                    cmd.Parameters.AddWithValue("@sn", sn);
                    cmd.Parameters.AddWithValue("@pCategory", productcategory);
                    cmd.Parameters.AddWithValue("@binLocation", binlocation);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    cmd.Parameters.AddWithValue("@uniPrice", unitprice);
                    cmd.Parameters.AddWithValue("@costPrice", costprice);
                    cmd.Parameters.AddWithValue("@OutOfStockQty", outofStockQty);
                    cmd.Parameters.AddWithValue("@quantityStock", quantitystock);
                    cmd.Parameters.AddWithValue("@demandStock", demandstock);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@reOrderQty", productReOrder);
                    cmd.Parameters.AddWithValue("@dangerQty", productDanger);

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }

        //productID, productName, productCategory, productWarehouse, productSerial, productUnitPrice, productCost, productWeight, productOutOfStock, productInStock, productReOrder, productDanger, productDemand, productDescription, productStatus
        public bool updateProductinfo(string productID, string productname, string productcategory, string binlocation, string sn, string unitprice, string costprice, string weight, string outOfStockQty, string quantityInStock, string productReOrder, string productDanger, string demandstock, string description, string status)
        {
            try
            {
                using (var connection = ServerConnect())
                {

                    if (productExistsInDatabase(connection, "product", "ProductName", productname, "ProductID", productID))
                    {
                        Console.WriteLine("The product name already exists. Please choose a different name.");
                        return false;
                    }

                    if (productExistsInDatabase(connection, "product", "SerialNumber", sn, "ProductID", productID))
                    {
                        Console.WriteLine("The serial number already exists. Please use a different serial number.");
                        return false;
                    }

                    string sql = "UPDATE product SET ProductName = @pName, SerialNumber = @sn, ProductCategory = @pCategory, BinLocation = @binLocation, Weight = @weight, UnitPrice = @unitPrice, CostPrice = @costPrice, OutOfStockQty = @outOfStockQty, QuantityInStock = @quantityInStock, ReOrderQty = @reOrderQty, DangerQty = @dangerQty, DemandStock = @demandStock, Description = @description, Status = @status WHERE ProductID = @pid";

                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@pid", productID);
                    cmd.Parameters.AddWithValue("@pName", productname);
                    cmd.Parameters.AddWithValue("@sn", sn);
                    cmd.Parameters.AddWithValue("@pCategory", productcategory);
                    cmd.Parameters.AddWithValue("@binLocation", binlocation);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    cmd.Parameters.AddWithValue("@unitPrice", unitprice);
                    cmd.Parameters.AddWithValue("@costPrice", costprice);
                    cmd.Parameters.AddWithValue("@outOfStockQty", outOfStockQty);
                    cmd.Parameters.AddWithValue("@quantityInStock", quantityInStock);
                    cmd.Parameters.AddWithValue("@demandStock", demandstock);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@reOrderQty", productReOrder);
                    cmd.Parameters.AddWithValue("@dangerQty", productDanger);

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }

        private bool productExistsInDatabase(MySqlConnection connection, string table, string column, string value, string idColumn = null, string idValue = null)
        {
            string sql = $"SELECT COUNT(*) FROM {table} WHERE {column} = @value";
            if (!string.IsNullOrEmpty(idColumn) && !string.IsNullOrEmpty(idValue))
            {
                sql += $" AND {idColumn} != @idValue";
            }
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@value", value);
            if (!string.IsNullOrEmpty(idColumn) && !string.IsNullOrEmpty(idValue))
            {
                cmd.Parameters.AddWithValue("@idValue", idValue);
            }
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
        public bool createDealer(string dealerID, string dealername, string dealerCompanyName, string dealerMailBox, string dealerPhoneNumBox, string dealerRegionNum, string dealerAddressBox)
        {
            try
            {
                using (var connection = ServerConnect())
                {

                    if (DealerExistsInDatabase(connection, "dealer", "DealerName", dealername))
                    {
                        MessageBox.Show("The dealer name already exists. Please choose a different name.");
                        return false;
                    }

                    if (DealerExistsInDatabase(connection, "dealer", "DealerEmailAddress", dealerMailBox))
                    {
                        MessageBox.Show("The dealer email already exists. Please use a different email address.");
                        return false;
                    }

                    if (DealerExistsInDatabase(connection, "dealer", "DealerPhoneNum", dealerPhoneNumBox))
                    {
                        MessageBox.Show("The dealer phone number already exists. Please use a different phone number.");
                        return false;
                    }

                    string sql = "INSERT INTO dealer (DealerID, DealerOrderNo, DealerName, DealerCompanyName, DealerPhoneNum, DealerRegionNum, DealerEmailAddress, DealerCompanyAddress) VALUES (@DealerID, @DealerOrderNo, @DealerName, @DealerCompanyName, @DealerPhoneNum, @DealerRegionNum, @DealerEmailAddress, @DealerCompanyAddress)";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@DealerID", dealerID);
                    cmd.Parameters.AddWithValue("@DealerName", dealername);
                    cmd.Parameters.AddWithValue("@DealerCompanyName", dealerCompanyName);
                    cmd.Parameters.AddWithValue("@DealerEmailAddress", dealerMailBox);
                    cmd.Parameters.AddWithValue("@DealerPhoneNum", dealerPhoneNumBox);
                    cmd.Parameters.AddWithValue("@DealerRegionNum", dealerRegionNum);
                    cmd.Parameters.AddWithValue("@DealerCompanyAddress", dealerAddressBox);
                    cmd.Parameters.AddWithValue("@DealerOrderNo", dealerID);

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }
        public bool updateDealerInfo(string dealerid, String dealerName, string dealerCompanyName, string dealerMail, string dealerPhoneNum, string dealerRegionNum, string dealerAddress)
        {
            try
            {
                using (var connection = ServerConnect())
                {

                    if (DealerExistsInDatabase(connection, "dealer", "DealerName", dealerName, "DealerID", dealerid))
                    {
                        MessageBox.Show("The dealer name already exists. Please choose a different name.");
                        return false;
                    }

                    if (DealerExistsInDatabase(connection, "dealer", "DealerCompanyName", dealerCompanyName, "DealerID", dealerid))
                    {
                        MessageBox.Show("The company name already exists. Please choose a different company name.");
                        return false;
                    }

                    if (DealerExistsInDatabase(connection, "dealer", "DealerEmailAddress", dealerMail, "DealerID", dealerid))
                    {
                        MessageBox.Show("The dealer email already exists. Please use a different email address.");
                        return false;
                    }

                    if (DealerExistsInDatabase(connection, "dealer", "DealerPhoneNum", dealerPhoneNum, "DealerID", dealerid))
                    {
                        MessageBox.Show("The dealer phone number already exists. Please use a different phone number.");
                        return false;
                    }

                    string sql = "UPDATE dealer SET DealerName = @dealerName, DealerCompanyName = @dealerCompanyName, DealerPhoneNum = @dealerPhoneNum, DealerRegionNum = @dealerRegionNum, DealerEmailAddress = @dealerEmailAddress WHERE DealerID = @dealerID";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@dealerID", dealerid);
                    cmd.Parameters.AddWithValue("@dealerName", dealerName);
                    cmd.Parameters.AddWithValue("@dealerCompanyName", dealerCompanyName);
                    cmd.Parameters.AddWithValue("@dealerPhoneNum", dealerPhoneNum);
                    cmd.Parameters.AddWithValue("@dealerEmailAddress", dealerMail);
                    cmd.Parameters.AddWithValue("@DealerRegionNum", dealerRegionNum);
                    cmd.Parameters.AddWithValue("@DealerCompanyAddress", dealerAddress);

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }

        private bool DealerExistsInDatabase(MySqlConnection connection, string table, string column, string value, string idColumn = null, string idValue = null)
        {
            string sql = $"SELECT COUNT(*) FROM {table} WHERE {column} = @value";
            if (!string.IsNullOrEmpty(idColumn) && !string.IsNullOrEmpty(idValue))
            {
                sql += $" AND {idColumn} != @idValue";
            }
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@value", value);
            if (!string.IsNullOrEmpty(idColumn) && !string.IsNullOrEmpty(idValue))
            {
                cmd.Parameters.AddWithValue("@idValue", idValue);
            }
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public bool createSupplier(string SupplierID, string SupplierCompanyName, string SupplierMailBox, string SupplierPhoneNumBox, string SupplierAddressBox, string SupplierContactNameBox, DataTable GetProducts)
        {


            try
            {
                using (var connection = ServerConnect())
                {


                    try
                    {
                        if (SupplierExistsInDatabase(connection, "SupplierCompanyName", SupplierCompanyName))
                        {
                            MessageBox.Show("The supplier name already exists. Please choose a different name.");
                            return false;
                        }

                        if (SupplierExistsInDatabase(connection, "SupplierEmail", SupplierMailBox))
                        {
                            MessageBox.Show("The supplier email already exists. Please use a different email address.");
                            return false;
                        }

                        if (SupplierExistsInDatabase(connection, "SupplierPhoneNum", SupplierPhoneNumBox))
                        {
                            MessageBox.Show("The supplier phone number already exists. Please use a different phone number.");
                            return false;
                        }

                        string sql = "INSERT INTO supplier(SupplierID, SupplierCompanyName, SupplierContactPerson, SupplierPhoneNum, SupplierEmail, SupplierAddress ) VALUES(@SupplierID, @SupplierCompanyName, @supplierContactPerson, @SupplierPhoneNum, @SupplierEmail, @SupplierAddress)";
                        MySqlCommand cmd = new MySqlCommand(sql, connection);
                        cmd.Parameters.AddWithValue("@SupplierID", SupplierID);
                        cmd.Parameters.AddWithValue("@SupplierCompanyName", SupplierCompanyName);
                        cmd.Parameters.AddWithValue("@SupplierContactPerson", SupplierContactNameBox);
                        cmd.Parameters.AddWithValue("@SupplierEmail", SupplierMailBox);
                        cmd.Parameters.AddWithValue("@SupplierPhoneNum", SupplierPhoneNumBox);
                        cmd.Parameters.AddWithValue("@SupplierAddress", SupplierAddressBox);

                        cmd.ExecuteNonQuery();
                        if (GetProducts != null && GetProducts.Rows.Count > 0)
                        {

                            foreach (DataRow row in GetProducts.Rows)
                            {
                                string productID = row["ProductID"].ToString();
                                string productSql = "INSERT INTO supplierproducts (SupplierID, ProductID) VALUES (@SupplierID, @ProductID)";
                                MySqlCommand productCmd = new MySqlCommand(productSql, connection);
                                productCmd.Parameters.AddWithValue("@SupplierID", SupplierID);
                                productCmd.Parameters.AddWithValue("@ProductID", productID);
                                productCmd.ExecuteNonQuery();
                            }
                        }


                        return true;
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {

                        Console.WriteLine("An exception occurred: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }


        public bool updateSupplierInfo(string supplierid, string supplierCompanyName, string supplierContactPerson, string supplierMail, string supplierPhoneNum, string supplierAddress, DataTable GetProducts)
        {
            try
            {
                using (var connection = ServerConnect())
                {


                    if (SupplierExistsInDatabase(connection, "SupplierCompanyName", supplierCompanyName, supplierid))
                    {
                        MessageBox.Show("The supplier name already exists. Please choose a different name.");
                        return false;
                    }

                    if (SupplierExistsInDatabase(connection, "SupplierEmail", supplierMail, supplierid))
                    {
                        MessageBox.Show("The supplier email already exists. Please use a different email address.");
                        return false;
                    }

                    if (SupplierExistsInDatabase(connection, "SupplierPhoneNum", supplierPhoneNum, supplierid))
                    {
                        MessageBox.Show("The supplier phone number already exists. Please use a different phone number.");
                        return false;
                    }

                    string sql = "UPDATE Supplier SET SupplierCompanyName = @SupplierCompanyName, SupplierContactPerson = @SupplierContactPerson, SupplierPhoneNum = @SupplierPhoneNum, SupplierEmail = @SupplierEmail, SupplierAddress = @SupplierAddress WHERE SupplierID = @SupplierID";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@SupplierID", supplierid);
                    cmd.Parameters.AddWithValue("@SupplierCompanyName", supplierCompanyName);
                    cmd.Parameters.AddWithValue("@SupplierContactPerson", supplierContactPerson);
                    cmd.Parameters.AddWithValue("@SupplierPhoneNum", supplierPhoneNum);
                    cmd.Parameters.AddWithValue("@SupplierEmail", supplierMail);
                    cmd.Parameters.AddWithValue("@SupplierAddress", supplierAddress);

                    cmd.ExecuteNonQuery();
                    if (GetProducts != null && GetProducts.Rows.Count > 0)
                    {

                        foreach (DataRow row in GetProducts.Rows)
                        {
                            string productID = row["ProductID"].ToString();
                            string productSql = "INSERT INTO supplierproducts (SupplierID, ProductID) VALUES (@SupplierID, @ProductID)";
                            // string productSql = "UPDATE supplierproducts SET SupplierID = @SupplierID, ProductID = @ProductID";
                            MySqlCommand productCmd = new MySqlCommand(productSql, connection);
                            productCmd.Parameters.AddWithValue("@SupplierID", supplierid);
                            productCmd.Parameters.AddWithValue("@ProductID", productID);
                            productCmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }

        private bool SupplierExistsInDatabase(MySqlConnection connection, string column, string value, string supplierID = null)
        {
            string sql = $"SELECT COUNT(*) FROM Supplier WHERE {column} = @value";
            if (!string.IsNullOrEmpty(supplierID))
            {
                sql += " AND SupplierID != @supplierID";
            }
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@value", value);
            if (!string.IsNullOrEmpty(supplierID))
            {
                cmd.Parameters.AddWithValue("@supplierID", supplierID);
            }
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
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

        public string getOrderOfDealerID(string orderID)
        {
            string sql = "SELECT DealerID FROM `order` WHERE OrderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            Object dealerID = cmd.ExecuteScalar();
            ServerConnect().Close();
            return dealerID.ToString();
        }

        public DataTable searchDealerDetail(string keyword)
        {

            // string sql = "SELECT DealerID, DealerName, DealerCompanyName, DealerPhoneNum, DealerRegionNum FROM dealer WHERE DealerID LIKE @keyword1 OR DealerID LIKE @keyword2 OR DealerName LIKE @keyword1 OR DealerName LIKE @keyword2 OR DealerCompanyName LIKE @keyword1 OR DealerCompanyName LIKE @keyword2 OR DealerPhoneNum LIKE @keyword2";
            //string sql = "SELECT DealerID, DealerName, DealerCompanyName, DealerPhoneNum, DealerRegionNum FROM dealer WHERE DealerID LIKE @keyword1 OR DealerID LIKE @keyword2 OR DealerName LIKE @keyword1 OR DealerName LIKE @keyword2 OR DealerCompanyName LIKE @keyword1 OR DealerCompanyName LIKE @keyword2";
            // string sql = "SELECT DealerID, DealerName, DealerCompanyName, DealerPhoneNum, DealerRegionNum FROM dealer WHERE DealerID LIKE @keyword1 OR DealerID LIKE @keyword2 OR TRIM(DealerName) LIKE @keyword1 OR TRIM(DealerName) LIKE @keyword2 OR DealerCompanyName LIKE @keyword1 OR TRIM(DealerCompanyName) LIKE @keyword2 LIMIT 5";
            // string sql = "SELECT DealerID, DealerName, DealerCompanyName, DealerPhoneNum, DealerRegionNum FROM dealer WHERE DealerID LIKE @keyword1 OR DealerID LIKE @keyword2 OR TRIM(DealerName) LIKE @keyword1 OR TRIM(DealerName) LIKE @keyword2 LIMIT 10";
            string sql = "SELECT * FROM dealer WHERE DealerID LIKE @keyword1 OR DealerID LIKE @keyword2 OR DealerName LIKE @keyword1 OR DealerName LIKE @keyword2 OR DealerCompanyName LIKE @keyword1 OR DealerCompanyName LIKE @keyword2 ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword1", "%" + keyword + "%");
            string keyword2 = keyword.Length > 0 ? $"%{char.ToUpper(keyword[0])}{keyword.Substring(1)}%" : keyword;
            cmd.Parameters.AddWithValue("@keyword2", keyword2);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable searchProductDetail(string keyword)
        {

            string sql = "SELECT * FROM product WHERE ProductID LIKE @keyword1 OR ProductID LIKE @keyword2 OR ProductName LIKE @keyword1 OR ProductName LIKE @keyword2 OR SerialNumber LIKE @keyword1 OR SerialNumber LIKE @keyword2 ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword1", "%" + keyword + "%");
            string keyword2 = keyword.Length > 0 ? $"%{char.ToUpper(keyword[0])}{keyword.Substring(1)}%" : keyword;
            cmd.Parameters.AddWithValue("@keyword2", keyword2);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }


        public string searchProductIDofOrder(string productID)
        {
            try
            {
                string sql = "SELECT ProductID FROM product WHERE ProductID=@productid";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@productid", productID);
                Object product = cmd.ExecuteScalar();
                return product.ToString();
            }
            catch { return null; }


        }

        public string searchProductNameOrder(string ProductName)
        {
            try
            {
                string sql = "SELECT ProductName FROM product WHERE ProductName=@productname";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@productname", "%" + ProductName + "%");
                Object dealer = cmd.ExecuteScalar();
                return dealer.ToString();

            }
            catch { return null; }
        }

        public DataTable searchOrderItemDetail(string keyword)
        {
            string sql = "SELECT * FROM product WHERE ProductID=@keyword OR ProductName=@keyword OR SerialNumber = @keyword";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword", keyword);
            //string keyword2 = keyword.Length > 0 ? $"%{char.ToUpper(keyword[0])}{keyword.Substring(1)}%" : keyword;
            //cmd.Parameters.AddWithValue("@keyword2", keyword2);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        
        public DataTable grnAllPOID()
        {
            string sql = "SELECT DISTINCT(PurchaseOrderID) FROM purchaseorder WHERE Status != 'Recevied'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable getOrderForDelivery()
        {
            string sql = "SELECT DISTINCT(OrderID) FROM `order` WHERE OrderStatus = 'PartialProductPackaged' OR OrderStatus = 'ALLProductPackaged'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect()); 
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable getOrderForOutstanding()
        {
            string sql = "SELECT DISTINCT(OutstandingOrderID) FROM outstandingorder WHERE Status = 'Active'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public string getGRNReceiveQty(string POID, string ProductID)
        {
                string sql = "SELECT IFNULL((SELECT ReceiveQty FROM grn WHERE PurchaseOrderID = @POID AND ProductID = @ProductID), 0) AS ReceiveQty";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@POID", POID);
                cmd.Parameters.AddWithValue("@ProductID", ProductID);
                Object result = cmd.ExecuteScalar();
                return result.ToString(); 
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
            ServerConnect().Close();
            return orderID.ToString();
        }


        public bool createSalesOrder(string orderID, string dealerID, string orderstatus, string deliveryAddress, string DealerContactName, string DealerContactPhoneNum, string TotalPrice)
        {
            DateTime orderDate = DateTime.Now;
            orderDate.ToString("yyyy-MM-dd HH:mm");
            Console.WriteLine(orderDate);
            string sql = "INSERT INTO `order` (OrderID, DealerID, OrderStatus, OrderDate,DeliveryAddress, DealerContactName, DealerContactPhoneNum, TotalPrice) VALUES(@orderID, @dealerID, @orderStatus, @orderDate,@DeliveryAddress, @DealerContactName,@DealerContactPhoneNum, @TotalPrice)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@dealerID", dealerID);
            cmd.Parameters.AddWithValue("@orderStatus", orderstatus);
            cmd.Parameters.AddWithValue("@orderDate", orderDate);
            cmd.Parameters.AddWithValue("@DeliveryAddress", deliveryAddress);
            cmd.Parameters.AddWithValue("@DealerContactName", DealerContactName);
            cmd.Parameters.AddWithValue("@DealerContactPhoneNum", DealerContactPhoneNum);
            cmd.Parameters.AddWithValue("@TotalPrice", TotalPrice);
            ServerConnect().Close();
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool createOrderItem(string orderID, string productID, string productName, string orderQty, string price, string discount)
        {
            float finalPrice = 0;
            if (discount != "100")
            {
                finalPrice = (float.Parse(price) * ((100 - float.Parse(discount)) / 100)) * int.Parse(orderQty);
            }
            else
            {
                finalPrice = float.Parse(price) * int.Parse(orderQty);
            }
            string sql = "INSERT INTO orderitem (OrderID,ProductID, OrderedQuantity,ProductName, Price ,Discount, QuantityFollow) VALUES(@orderID,@productID,@orderQty,@productName,@price, @discount,@orderQty)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@orderQty", orderQty);
            cmd.Parameters.AddWithValue("@productName", productName);
            cmd.Parameters.AddWithValue("@price", finalPrice);
            cmd.Parameters.AddWithValue("@discount", discount);
            cmd.Parameters.AddWithValue("@followQuantity", discount);
            ServerConnect().Close();
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
            ServerConnect().Close();
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }


        public DataTable getOrderDetails(string orderID)
        {
            string sql = "SELECT * FROM `order` WHERE OrderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;

        }

        public DataTable getOrderItemDetailsForOrderAccembly(string orderID)
        {
            string sql = "SELECT orderitem.ProductID, orderitem.ProductName, BinLocation, QuantityInStock, OrderedQuantity FROM product, orderitem WHERE orderitem.OrderID=@orderID AND orderitem.ProductID=product.ProductID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;

        }

        public DataTable getOrderItemDetailsForAcutalDespatch(string orderID)
        {
            string sql = "SELECT ProductID, ProductName, TotalDespatchQuantity FROM orderitem WHERE orderitem.OrderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;

        }

        public DataTable getProductIDAndpProductName(string orderID)
        {
            string sql = "SELECT ProductID,ProductName FROM orderitem WHERE OrderID = @orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable getProductIDAndpProductName()
        {
            string sql = "SELECT ProductID,ProductName FROM product";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public bool checkOrderItemFollowQuantity(string orderID)
        {
            string sql = "SELECT COUNT(*) FROM orderitem WHERE orderitem.OrderID=@orderID AND QuantityFollow IS NULL";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            var result = cmd.ExecuteScalar();
            if (result != null && Convert.ToInt32(result) > 0)
            {
                return true;
            }

            return false;

        }


        public bool checkDeliveryOrderIDExist(string orderID)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM delivery WHERE OrderID=@orderID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@orderID", orderID);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                ServerConnect().Close();
                return count > 1;

            }
            catch (Exception ex) {
                Console.WriteLine("An error occurred: " + ex.Message);

                return false;
            }
        }

        public bool checkOutstandingOrderIDExist(string orderID,string productID)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM outstandingorder WHERE OrderID=@orderID AND ProductID =@productID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.Parameters.AddWithValue("@productID", productID);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                ServerConnect().Close();
                return count > 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);

                return false;
            }
        }

        public string getOrderItemOrderedQuantity(string orderID, string productID)
        {
            string sql = "SELECT OrderedQuantity FROM orderitem WHERE OrderID=@orderID AND ProductID =@productID ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@productID", productID);
            Object result = cmd.ExecuteScalar();
            ServerConnect().Close();
            return result.ToString();
        }

        public string getOrderItemFollowQuantity(string orderID, string productID)
        {
            string sql = "SELECT QuantityFollow FROM orderitem WHERE OrderID =@orderID AND ProductID =@productID ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@productID", productID);
            Object result = cmd.ExecuteScalar();
            ServerConnect().Close();
            return result.ToString();
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
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable getOrderItemDetails(string orderID)
        {
            string sql = "SELECT orderitem.ProductID, product.ProductName, orderitem.OrderedQuantity, product.UnitPrice ,orderitem.Discount FROM orderitem, product WHERE orderitem.ProductID=product.ProductID AND orderItem.OrderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }


        public DataTable getOrderItemDetailForDelivery(string orderID, int updateCount)
        {
            //string sql = "SELECT orderitem.ProductID, product.ProductName, orderitem.OrderedQuantity, product.UnitPrice, orderitem.FollowUpQuantity FROM orderitem, product WHERE orderitem.ProductID=product.ProductID AND orderItem.OrderID=@orderID";
            // string sql = "SELECT * FROM orderitem_audit oia JOIN product p ON oia.ProductID = p.ProductID WHERE oia.OrderID = @orderID AND oia.UpdateCount = (SELECT MAX(UpdateCount) FROM orderitem_audit WHERE OrderID = @orderID)";
            string sql = "SELECT orderitem_audit.* FROM orderitem_audit, product WHERE orderitem_audit.ProductID=product.ProductID AND orderitem_audit.OrderID=@orderID AND UpdateCount = @updateCount";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@updateCount", updateCount);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }


        public int getMaxUpdateCount(string orderID)
        {
            string sql = "SELECT MAX(UpdateCount) FROM orderitem_audit WHERE OrderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            object result = cmd.ExecuteScalar();
            int rowCount = Convert.ToInt32(result);
            ServerConnect().Close();
            return rowCount;
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

        public void updateProductStatus(string productID, string status)
        {
            string sql = "UPDATE product SET Status=@status WHERE ProductID=@productID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@status", status);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }


        public string getOrderStatus(string orderID)
        {
            string sql = "SELECT OrderStatus FROM `order` WHERE OrderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            object status = cmd.ExecuteScalar();
            ServerConnect().Close();
            return status.ToString();
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
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable searchPODate(string startDate, string endDate)
        {
            //string sql = "SELECT po.PurchaseOrderID, p.ProductName, po.OrderQuantity, po.UnitPrice, po.TotalPrice, s.SupplierCompanyName, po.Status, po.Date " +
                         //"FROM purchaseorder po " +
                         //"JOIN product p ON po.ProductID = p.ProductID " +
                         //"JOIN supplier s ON po.SupplierID = s.SupplierID " +
                         //"ORDER BY po.PurchaseOrderID " +
                         //"WHERE po.Date BETWEEN @startdate AND @enddate";
            string sql = "SELECT * FROM purchaseorder WHERE Date BETWEEN @startdate AND @enddate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@startdate", startDate);
            cmd.Parameters.AddWithValue("@enddate", endDate);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable searchDeliveryDate(string startDate, string endDate)
        {
            string sql = "SELECT DeliveryID,OrderID, DeliveryDate , DeliveryStatus FROM delivery WHERE DeliveryDate BETWEEN @startdate AND @enddate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@startdate", startDate);
            cmd.Parameters.AddWithValue("@enddate", endDate);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable overallGRNinfo()
        {
            string sql = "SELECT * FROM grn ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;

        }

        public DataTable overallDeliveryinfo()
        {
            string sql = "SELECT DeliveryID,OrderID, DeliveryDate , DeliveryStatus FROM delivery ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;

        }

        public void increaseStock(string productID, string qty)
        {
            string sql = "UPDATE product SET QuantityInStock=@qty WHERE ProductID=@productID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.ExecuteNonQuery();
            ServerConnect().Close();
        }

        public void ReduceStock(string productID, string qty)
        {
            string sql = "UPDATE product SET QuantityInStock=@qty WHERE ProductID=@productID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.ExecuteNonQuery();
            ServerConnect().Close();
        }

        public string getProductQuantity(string productID)
        {
            string sql = "SELECT QuantityInStock FROM product WHERE ProductID=@productID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect()); ;
            cmd.Parameters.AddWithValue("@productID", productID);
            object qty = cmd.ExecuteScalar();
            ServerConnect().Close();
            return qty.ToString();
        }

        public DataTable getProductQuantityLevel(string productID)
        {
            string sql = "SELECT ReOrderQty,DangerQty, OutOfStockQty FROM product WHERE ProductID=@productID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect()); ;
            cmd.Parameters.AddWithValue("@productID", productID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }



        public bool createGRN(string grnID, string POID, string productID, string warehouse, string recQty, string recDate)
        {
            string sql = "INSERT INTO grn (grnID, ProductID, PurchaseOrderID, ReceiveQty, ReceiveDate, WareHouse) VALUES (@grnID, @productID, @poID, @recqty, @recdate, @warehouse) ON DUPLICATE KEY UPDATE ReceiveQty = ReceiveQty + VALUES(ReceiveQty)";
            // string sql = "INSERT INTO grn (grnID, ProductID, PurchaseOrderID, ReceiveQty, ReceiveDate, WareHouse) VALUES(@grnID, @productID, @poID , @recqty, @recdate, @warehouse)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@grnID", grnID);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@poID", POID);
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
            ServerConnect().Close();
            return grn.ToString();
        }

        public void orderDeleteItem(string orderID)
        {
            string sql = "DELETE FROM orderitem WHERE OrderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@OrderID", orderID);
            cmd.ExecuteNonQuery();
            ServerConnect().Close();
        }

        public DataTable getInvoiceDetails(string orderID)
        {
            string sql = "SELECT * FROM invoice WHERE OrderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;

        }

        public string getDeliveryID()
        {
            string sql = "SELECT MAX(RIGHT(DeliveryID,5)) FROM delivery";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            Object DeliveryID = cmd.ExecuteScalar();
            ServerConnect().Close();
            return DeliveryID.ToString();
        }

        public bool createDelivery(string deliveryID, string orderID, string deliveryDate, string status)
        {
            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(deliveryDate);
            var date = dt.ToString("yyyy-MM-dd");
            string sql = "INSERT INTO delivery (DeliveryID, OrderID, DeliveryDate,DeliveryStatus) VALUES(@deliveryID,@orderID, @deliveryDate ,@deliverystatus)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@deliveryID", deliveryID);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@deliveryDate", date);
            cmd.Parameters.AddWithValue("@deliverystatus", status);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }

        public void createDeliveryNoteItem(string deliveryID, string productID, string PreQtyDelivered, string DeliveryQuantity, string quantityToFollow)
        {
            string sql = "INSERT INTO deliverynoteitem VALUES(@deliveryID,@productID,@PreQtyDelivered, @deliveryQuantity, @quantityToFollow)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@deliveryID", deliveryID);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@PreQtyDelivered", PreQtyDelivered);
            cmd.Parameters.AddWithValue("@deliveryQuantity", DeliveryQuantity);
            cmd.Parameters.AddWithValue("@quantityToFollow", quantityToFollow);
            cmd.ExecuteNonQuery();
            ServerConnect().Close();
        }




        public void updateOrderStatus(String status, String orderID)
        {
            string sql = "UPDATE `order` Set OrderStatus=@status WHERE OrderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.ExecuteNonQuery();
            ServerConnect().Close();
        }

        public void updateDeliveryStatus(String status, String deliveryID, string deliveredDate)
        {
            string sql = "UPDATE delivery Set DeliveryStatus=@status , DeliveredDate=@deliveredDate WHERE DeliveryID=@deliveryID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@deliveryID", deliveryID);
            cmd.Parameters.AddWithValue("@deliveredDate", deliveredDate);
            cmd.ExecuteNonQuery();
            ServerConnect().Close();
        }
        

         public string getDeliveryDate(string deliveryID)
        {
            string sql = "SELECT DeliveryDate FROM delivery WHERE DeliveryID=@deliveryID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@deliveryID", deliveryID);
            object result = cmd.ExecuteScalar();
            ServerConnect().Close();
            return result.ToString();
        }

        public DataTable getDeliveryDetails(string deliveryID)
        {
            string sql = "SELECT * FROM delivery WHERE DeliveryID=@deliveryID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@deliveryID", deliveryID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable getOrderItemProductNameForDelivery(string orderID, string ProductID)
        {
            string sql = "SELECT ProductName, Discount FROM orderitem_audit WHERE OrderID=@orderID AND ProductID = @ProductID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@ProductID", ProductID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }


        public DataTable getDeliveryOfOrderDetails(string deliveryID)
        {
            string sql = "SELECT DeliveryDate,DeliveryAddress,DealerContactPhoneNum FROM delivery,`order` WHERE DeliveryID=@deliveryID AND delivery.OrderID = `order`.OrderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@deliveryID", deliveryID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }


        public DataTable getDeliveryNoteItem(string deliveryID)
        {
            //string sql = "SELECT * FROM deliverynoteitem, delviery, orderitem WHERE delviery.DeliveryID=@deliveryID AND delivery.DeliveryID = deliverynoteitem.DeliveryID AND delivery.OrderID = orderitem.OrderID";
            //string sql = "SELECT distinct orderitem.ProductID, orderitem.ProductName FROM deliverynoteitem, delivery, orderitem WHERE delivery.DeliveryID=@deliveryID AND delivery.OrderID = orderitem.OrderID AND delivery.DeliveryID = deliverynoteitem.DeliveryID";
            string sql = "SELECT * FROM deliverynoteitem WHERE DeliveryID = @deliveryID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@deliveryID", deliveryID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable getDepartmentNameDataSource()

        {
            string sql = "SELECT DepartmentName FROM department";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public int getAccountRowCount()
        {
            string sql = "SELECT COUNT(DISTINCT UserID) FROM staff";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object result = cmd.ExecuteScalar();
            int rowCount = Convert.ToInt32(result);
            ServerConnect().Close();
            return rowCount;
        }

        public int getDeliveryRowCount()
        {
            string sql = "SELECT COUNT(DISTINCT DeliveryID) FROM delivery";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object result = cmd.ExecuteScalar();
            int rowCount = Convert.ToInt32(result);
            ServerConnect().Close();
           // MessageBox.Show(rowCount.ToString());
            return rowCount;
        }

        public int getGRNRowCount()
        {
            string sql = "SELECT COUNT(DISTINCT CONCAT(grnID, '-', ProductID, '-', PurchaseOrderID)) AS UniqueCombinationCount FROM `grn`";
            //string sql = "SELECT COUNT(DISTINCT grnID) FROM `grn`";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object result = cmd.ExecuteScalar();
            int rowCount = Convert.ToInt32(result);
            ServerConnect().Close();
            return rowCount;
        }

        public int getPORowCount()
        {
            string sql = "SELECT COUNT(DISTINCT CONCAT(PurchaseOrderID, '-', ProductID)) AS UniqueCombinationCount FROM purchaseorder";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object result = cmd.ExecuteScalar();
            int rowCount = Convert.ToInt32(result);
            ServerConnect().Close();
            return rowCount;
        }

        public int getDealersRowCount()
        {
            string sql = "SELECT COUNT(DISTINCT DealerID) FROM dealer";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object result = cmd.ExecuteScalar();
            int rowCount = Convert.ToInt32(result);
            ServerConnect().Close();
            return rowCount;
        }

        public int getSuppliersRowCount()
        {
            string sql = "SELECT COUNT(*) FROM supplier WHERE 1=1";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object result = cmd.ExecuteScalar();
            int rowCount = Convert.ToInt32(result);
            ServerConnect().Close();
            return rowCount;
        }



        public string getNewUserName()
        {
            string sql = "SELECT UserName FROM staff WHERE UserID = (SELECT MAX(UserID) FROM staff)";
            using (MySqlConnection conn = ServerConnect())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
                else
                {
                    return null;
                }
            }
        }

        public int getStockRowCount()
        {
            string sql = "SELECT COUNT(DISTINCT ProductID) FROM product";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object result = cmd.ExecuteScalar();
            int rowCount = Convert.ToInt32(result);
            ServerConnect().Close();
            return rowCount;
        }

        public int getOrderRowCount()
        {
            string sql = "SELECT COUNT(DISTINCT OrderID) FROM `order` WHERE OrderStatus != 'Cancelled' AND OrderStatus != 'Outstanding'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object result = cmd.ExecuteScalar();
            int rowCount = Convert.ToInt32(result);
            ServerConnect().Close();
            return rowCount;
        }

        public int getOutstandingRowCount()
        {
            string sql = "SELECT COUNT(DISTINCT OutstandingOrderID)  FROM outstandingorder WHERE Status != 'Completed'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object result = cmd.ExecuteScalar();
            int rowCount = Convert.ToInt32(result);
            ServerConnect().Close();
            return rowCount;
        }

        public string getAccountStatusCount()
        {
            string sql = "SELECT COUNT(DISTINCT UserID) FROM staff WHERE AccountStatus = @status";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            string status = "Active";
            cmd.Parameters.AddWithValue("@status", status);
            object result = cmd.ExecuteScalar();
            ServerConnect().Close();
            return result.ToString();
        }


        public DataTable GetAccountCurrentRecords(int page, int pageSize)
        {
            string sql = "SELECT UserID,DisplayName,UserName,Department,Title,AccountStatus FROM staff ORDER BY UserID LIMIT @PgSize";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable GetAccountCurrentRecords2(int page, int pageSize)
        {
            string sql = "SELECT UserID,DisplayName,UserName,Department,Title,AccountStatus FROM (SELECT * FROM staff ORDER BY UserID LIMIT @PreviousPageOffset, @PgSize) AS subquery ORDER BY UserID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            cmd.Parameters.AddWithValue("@PreviousPageOffset", (page - 1) * pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        //public DataTable GetStockCurrentRecords(int page, int pageSize)
        //{
        //    string sql = "SELECT ProductID,ProductName, ProductCategory, BinLocation, UnitPrice, CostPrice, QuantityInStock, DemandStock, Status FROM product ORDER BY ProductID LIMIT @PgSize";
        //    MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
        //    cmd.Parameters.AddWithValue("@PgSize", pageSize);
        //    MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
        //    DataTable dataTable = new DataTable();
        //    adat.Fill(dataTable);
        //    ServerConnect().Close();
        //    return dataTable;
        //}

        public DataTable GetStockCurrentRecords(int page, int pageSize)
        {

            //Out-Of-Stock, Danger, Re-Order, Available
            string sql = "SELECT ProductID,ProductName, SerialNumber, BinLocation, DemandStock, Status, QuantityInStock, UnitPrice FROM product ORDER BY FIELD(Status, 'Re-Order', 'Danger','Out-Of-Stock' ) DESC, ProductID LIMIT @PgSize";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }


        public DataTable GetStockCurrentRecords2(int page, int pageSize)
        {
            string sql = "SELECT ProductID,ProductName, SerialNumber, BinLocation, DemandStock, Status, QuantityInStock, UnitPrice FROM (SELECT * FROM product ORDER BY FIELD(Status, 'Re-Order', 'Danger','Out-Of-Stock' ) DESC, ProductID LIMIT @PreviousPageOffset, @PgSize) AS subquery ORDER BY ProductID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            cmd.Parameters.AddWithValue("@PreviousPageOffset", (page - 1) * pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }
        
        public DataTable GetPOCurrentRecords(int page, int pageSize)
        {
            string sql = "SELECT po.PurchaseOrderID, p.ProductName, po.OrderQuantity, po.UnitPrice, po.TotalPrice, s.SupplierCompanyName, po.Status, po.Date " +
                         "FROM purchaseorder po " +
                         "JOIN product p ON po.ProductID = p.ProductID " +
                         "JOIN supplier s ON po.SupplierID = s.SupplierID " +
                         "ORDER BY po.PurchaseOrderID " +
                         "LIMIT @PgSize OFFSET @Offset";

            using (MySqlConnection conn = ServerConnect())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PgSize", pageSize);
                cmd.Parameters.AddWithValue("@Offset", (page - 1) * pageSize);

                MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adat.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable GetPOCurrentRecords2(int page, int pageSize)
        {
    
            string sql = "SELECT* FROM(SELECT po.PurchaseOrderID, p.ProductName, po.OrderQuantity, po.UnitPrice, po.TotalPrice, s.SupplierCompanyName, po.Status, po.Date FROM purchaseorder po LEFT JOIN product p ON p.ProductID=po.ProductID LEFT JOIN supplier s ON po.SupplierID=s.SupplierID ORDER BY po.PurchaseOrderID LIMIT @PreviousPageOffset, @PgSize) AS subquery ORDER BY PurchaseOrderID";

            using (MySqlConnection conn = ServerConnect())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PgSize", pageSize);
                cmd.Parameters.AddWithValue("@PreviousPageOffset", (page - 1) * pageSize);

                MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adat.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable GetOrderCurrentRecords(int page, int pageSize)
        {
            string sql = "SELECT OrderID, DealerID, OrderStatus, OrderDate FROM `order` WHERE OrderStatus != 'Cancelled' AND OrderStatus != 'Outstanding' ORDER BY OrderID LIMIT @PgSize";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable GetOrderCurrentRecords2(int page, int pageSize)
        {
            string sql = "SELECT OrderID, DealerID, OrderStatus, OrderDate FROM (SELECT * FROM `order` WHERE OrderStatus != 'Cancelled' AND OrderStatus != 'Outstanding' ORDER BY OrderID LIMIT @PreviousPageOffset, @PgSize) AS subquery ORDER BY OrderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            cmd.Parameters.AddWithValue("@PreviousPageOffset", (page - 1) * pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable GetInvoiceCurrentRecords(int page, int pageSize)
        {
            string sql = "SELECT * FROM invoice ORDER BY InvoiceID LIMIT @PgSize";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable GetInvoiceCurrentRecords2(int page, int pageSize)
        {
            string sql = "SELECT * FROM (SELECT * FROM invoice ORDER BY InvoiceID LIMIT @PreviousPageOffset, @PgSize) AS subquery ORDER BY InvoiceID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            cmd.Parameters.AddWithValue("@PreviousPageOffset", (page - 1) * pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable GetDeliveryCurrentRecords(int page, int pageSize)
        {
            string sql = "SELECT DeliveryID,OrderID, DeliveryDate , DeliveryStatus FROM delivery ORDER BY DeliveryID LIMIT @PgSize";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable GetDeliveryCurrentRecords2(int page, int pageSize)
        {
            string sql = "SELECT DeliveryID,OrderID, DeliveryDate , DeliveryStatus FROM (SELECT DeliveryID,OrderID, DeliveryDate , DeliveryStatus FROM delivery ORDER BY DeliveryID LIMIT @PreviousPageOffset, @PgSize) AS subquery ORDER BY DeliveryID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            cmd.Parameters.AddWithValue("@PreviousPageOffset", (page - 1) * pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable GetGRNCurrentRecords(int page, int pageSize)
        {
            //string sql = "SELECT * FROM grn ORDER BY grnID LIMIT @PgSize";
            string sql = "SELECT* FROM grn ORDER BY grnID, ProductID, PurchaseOrderID LIMIT @PgSize";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable GetGRNCurrentRecords2(int page, int pageSize)
        {
            //string sql = "SELECT * FROM (SELECT * FROM grn ORDER BY grnID LIMIT @PreviousPageOffset, @PgSize) AS subquery ORDER BY grnID";
            string sql = "SELECT * FROM (SELECT * FROM grn ORDER BY grnID, ProductID, PurchaseOrderID LIMIT @PreviousPageOffset, @PgSize) AS subquery ORDER BY grnID, ProductID, PurchaseOrderID;";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            cmd.Parameters.AddWithValue("@PreviousPageOffset", (page - 1) * pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable GetOutstandingCurrentRecords(int page, int pageSize)
        {
            string sql = "SELECT OutstandingOrderID, OrderID, ProductID, DealerID, FollowUpQuantity FROM outstandingorder WHERE Status != 'Completed' ORDER BY OutstandingOrderID LIMIT @PgSize";
            //string sql = "SELECT OutstandingOrderID,OrderID, outstandingorder.ProductID, DealerID,FollowUpQuantity,OutstandingDate FROM outstandingorder, product WHERE outstandingorder.Status != 'Completed'AND outstandingorder.ProductID=product.ProductID ORDER BY OutstandingOrderID LIMIT @PgSize";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable GetOutstandingCurrentRecords2(int page, int pageSize)
        {
            // string sql = "SELECT OutstandingOrderID,OrderID,outstandingorder.ProductID, DealerID,FollowUpQuantity,OutstandingDate FROM (SELECT * FROM outstandingorder WHERE outstandingorder.Status != 'Completed'  ORDER BY OutstandingOrderID LIMIT @PreviousPageOffset, @PgSize) AS subquery ORDER BY OutstandingOrderID";
             string sql = "SELECT OutstandingOrderID, OrderID, ProductID, DealerID, FollowUpQuantity FROM (SELECT * FROM outstandingorder ORDER BY OutstandingOrderID LIMIT @PreviousPageOffset, @PgSize) AS subquery ORDER BY OutstandingOrderID";
           // string sql = "SELECT * AS MaxOutstandingDate FROM (SELECT OrderID, OutstandingDate, OutstandingOrderID FROM outstandingorder ORDER BY OutstandingOrderID LIMIT @PreviousPageOffset, @PgSize) AS subquery GROUP BY OrderID ORDER BY OutstandingOrderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PgSize", pageSize);
            cmd.Parameters.AddWithValue("@PreviousPageOffset", (page - 1) * pageSize);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable searchOrderEachItemDetail(string orderID)
        {
            string sql = "SELECT ProductID FROM orderitem WHERE OrderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getOrderEachItemDetail(string productID, string orderID)
        {
            string sql = "SELECT product.ProductID, product.ProductName, ActualDespatchQuantity, OrderedQuantity FROM product, orderitem WHERE product.ProductID=orderitem.ProductID AND OrderID=@orderID AND product.ProductID=@productID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@productID", productID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getOrderItemDetailforAsb(string orderID)
        {
            string sql = "SELECT orderitem.ProductID, orderitem.ProductName, BinLocation, QuantityInStock, OrderedQuantity FROM product, orderitem WHERE product.ProductID=orderitem.ProductID AND orderitem.OrderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getOrderItemDetailforDeliveryANDInvoice(string deliveryID)
        {
            //string sql = "SELECT orderitem_audit.* FROM orderitem_audit, product WHERE orderitem_audit.ProductID=product.ProductID AND orderitem_audit.OrderID=@orderID";
            string sql = "SELECT  deliverynoteitem.ProductID, orderitem.Price, orderitem.OrderedQuantity ,orderitem.ProductName, delivery.DeliveryDate, deliverynoteitem.DeliveryQuantity,deliverynoteitem.PreQtyDelivered,  deliverynoteitem.QuantityToFollow , orderitem.Discount FROM orderitem,delivery, deliverynoteitem WHERE  delivery.DeliveryID = @deliveryID  AND delivery.OrderID = orderitem.OrderID AND delivery.DeliveryID = deliverynoteitem.DeliveryID AND deliverynoteitem.ProductID = orderitem.ProductID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@deliveryID", deliveryID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public string getPrdocutQuantityInStock(string productID)
        {
            string sql = "SELECT QuantityInStock FROM product WHERE ProductID=@prouductID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@prouductID", productID);
            Object stock = cmd.ExecuteScalar();
            return stock.ToString();
        }
        public string getProdcutReOrderQty(string prouductID)
        {
            string sql = "SELECT ReOrderQty FROM product WHERE ProductID=@prouductID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@prouductID", prouductID);
            Object reorderQty = cmd.ExecuteScalar();
            return reorderQty.ToString();
        }



        public string getOrderItemActualDespatchQuantity(string orderID, string productID)
        {
            try
            {
                string sql = "SELECT ActualDespatchQuantity FROM orderitem WHERE OrderID=@orderID AND ProductID=@prouductID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.Parameters.AddWithValue("@prouductID", productID);
                Object reorderQty = cmd.ExecuteScalar();
                return reorderQty.ToString();
            }
            catch (Exception ex) {
                return "N/A";
            }

        }

        public string getProdcutDangerQty(string prouductID)
        {
            string sql = "SELECT DangerQty FROM product WHERE ProductID=@prouductID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@prouductID", prouductID);
            Object dangerlevel = cmd.ExecuteScalar();
            return dangerlevel.ToString();
        }

        public string getOutStandingID()
        {
            string sql = "SELECT MAX(RIGHT(OutstandingOrderID,6)) FROM outstandingorder";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            Object dealer = cmd.ExecuteScalar();
            return dealer.ToString();
        }
        
        public bool createOutstandingOrder(string outID, string orderID, string productID, string dealerID, string followUpQuantity)
        {
            string sql = "INSERT INTO outstandingorder VALUES(@outID,@orderID,@productID,@dealerId,@followUpQuantity,@date, 'Active')";
            DateTime date = DateTime.Now;
            date.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@outID", outID);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@followUpQuantity", followUpQuantity);
            cmd.Parameters.AddWithValue("@dealerID", dealerID);
            cmd.Parameters.AddWithValue("@date", date);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public void DeleteOutstandingOrderForOrderAccembly(string orderID, string productID)
        {
            string sql = "DELETE FROM outstandingorder WHERE OrderID=@orderID AND ProductID=@productID";
            DateTime date = DateTime.Now;
            date.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.ExecuteNonQuery();
        }

        public void DeleteOutstandingOrderForOrderAccembly(string orderID)
        {
            string sql = "DELETE FROM outstandingorder WHERE OrderID=@orderIDD";
            DateTime date = DateTime.Now;
            date.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.ExecuteNonQuery();
        }

        public void DeleteOutstandingOrder(string outID)
        {
            string sql = "DELETE FROM outstandingorder WHERE OutstandingOrderID=@outID";
            DateTime date = DateTime.Now;
            date.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@outID", outID);
            cmd.ExecuteNonQuery();
        }

        
        public bool createInvoice(string invoiceID, string orderID, string dealerID, string deliveryID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO invoice VALUES(@invoiceID,@orderID,@dealerID,@date,@deliveryID)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@dealerID", dealerID);
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.Parameters.AddWithValue("@deliveryID", deliveryID);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool checkFinalTimeOrderStatusForDeliver(string orderID)
        {
            string sql = "SELECT COUNT(OrderID) FROM `order` WHERE OrderStatus != 'ALLProductPackaged'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public string getInvoiceID()
        {
            string sql = "SELECT MAX((RIGHT(InvoiceID,6))) FROM invoice";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            Object InvoiceID = cmd.ExecuteScalar();
            ServerConnect().Close();
            return InvoiceID.ToString();
        }

        public bool createPurchaseOrder(string purID, string productID, string orderQty, string status)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO purchaseorder (PurchaseOrderID, ProductID, OrderQuantity,Status, Date )VALUES(@purID, @productID, @orderQty, @status, @date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@purID", purID);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@orderQty", orderQty);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@date", Date);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public string getPurchasesOrderID()
        {
            string sql = "SELECT MAX(RIGHT(PurchaseOrderID,6)) FROM purchaseorder";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            Object purID = cmd.ExecuteScalar();
            ServerConnect().Close();
            return purID.ToString();
        }

        public int checkPurchaseOrderExist(string productID)
        {
            string sql = "SELECT COUNT(productID) FROM purchaseorder WHERE ProductID=@productID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@productID", productID);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            ServerConnect().Close();
            return count;
        }

        public String getPurchaseOrderQty(string POID, string supplierID, string productID)
        {
            string sql = "SELECT OrderQuantity FROM purchaseorder WHERE PurchaseOrderID=@POID AND SupplierID = @supplierID AND ProductID=@productID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@POID", POID);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Parameters.AddWithValue("@productID", productID);
            object orderQty = cmd.ExecuteScalar();
            ServerConnect().Close();
            return orderQty.ToString();
        }

        public DataTable getPurchaseOrderProductIDAndQty(string POID)
        {
            string sql = "SELECT SupplierID, ProductID, OrderQuantity FROM purchaseorder WHERE PurchaseOrderID=@POID AND  Status != 'Recevied' ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@POID", POID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        } 

            public bool updatePurchaseOrder(string POID, string productID, string status)
        {
            string sql = "UPDATE purchaseorder SET Status=@status WHERE PurchaseOrderID=@POID AND ProductID = @productID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@POID", POID);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@status", status);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool updateOrderItem(string orderID, string productID, string Qty, string quantityFollow, int updateCount)
        {
            //string sql = "UPDATE orderitem SET ActualDespatchQuantity = IFNULL(ActualDespatchQuantity, 0) + @qty, QuantityFollow = @quantityFollow , UpdateCount =@updateCount WHERE OrderID = @orderID AND ProductID = @productID";
            string sql = "UPDATE orderitem SET TotalDespatchQuantity = IFNULL(ActualDespatchQuantity, 0) + @qty, ActualDespatchQuantity = @qty, QuantityFollow = @quantityFollow , UpdateCount =@updateCount WHERE OrderID = @orderID AND ProductID = @productID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@qty", Qty);
            cmd.Parameters.AddWithValue("@quantityFollow", quantityFollow);
            cmd.Parameters.AddWithValue("@updateCount", updateCount);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public int getOrderItemUpdateCount(string orderID, string productID)
        {
            string sql = "SELECT UpdateCount FROM orderitem WHERE OrderID = @orderID AND ProductID = @productID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@productID", productID);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count;

        }

        public bool createOrderItemAudit(string orderID, string productID)
        {
            string sql = "INSERT INTO orderitem_audit (OrderID, ProductID, OrderedQuantity, ActualDespatchQuantity, ProductName, Discount, Price, UpdateCount, QuantityFollow, PreQtyDelivered) SELECT OrderID, ProductID, OrderedQuantity, ActualDespatchQuantity, ProductName, Discount, Price, UpdateCount , QuantityFollow, TotalDespatchQuantity FROM orderitem WHERE OrderID = @orderID AND ProductID = @productID;";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@productID", productID);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }


        public bool setDefualtInStock(string productID)
        {
            string sql = "UPDATE product SET QuantityInStock=0 WHERE ProductID=@productID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@productID", productID);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }


        public DataTable getProductWeight(string orderID)
        {
            string sql = "SELECT Weight, orderitem.OrderedQuantity FROM product, orderitem WHERE product.ProductID=orderitem.ProductID AND orderitem.OrderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable searchOrder(string keyword)
        {
            string sql = "SELECT OrderID, DealerID, OrderStatus, OrderDate FROM `order` WHERE OrderID LIKE @keyword OR DealerID LIKE @keyword OR DealerContactName LIKE @keyword";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }
        
        public DataTable orderDateFilter(string fromDate, string toDate)
        {

            string sql = "SELECT OrderID, DealerID, OrderStatus, OrderDate FROM `order` WHERE OrderDate BETWEEN @fromDate AND @toDate";
            //string sql = "SELECT * FROM `order` WHERE OrderDate BETWEEN @fromDate AND @toDate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@fromDate", fromDate);
            cmd.Parameters.AddWithValue("@toDate", toDate);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;

        }
       

        public DataTable reportFilterByDateAndProductID(string fromDate, string toDate, string productID)
        {

            string sql = "SELECT  OrderDate, `order`.OrderID, DealerID, OrderStatus,SUM(OrderedQuantity) AS Quantity ,TotalPrice AS 'TotalPrice (CNY¥)' FROM orderitem,`order` WHERE OrderDate BETWEEN @fromDate AND @toDate  AND orderitem.ProductID = @productID GROUP BY  `order`.OrderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@fromDate", fromDate);
            cmd.Parameters.AddWithValue("@toDate", toDate);
            cmd.Parameters.AddWithValue("@productID", productID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;

        }
        
        public DataTable reportFilterByDateAndCategory(string fromDate, string toDate, string productCategory)
        {
            string sql = "SELECT  OrderDate, `order`.OrderID, DealerID, OrderStatus,SUM(OrderedQuantity) AS Quantity ,TotalPrice AS 'TotalPrice (CNY¥)' FROM `order`, orderitem,product WHERE OrderDate BETWEEN @fromDate AND @toDate  AND orderitem.ProductID = product.ProductID AND ProductCategoroy = @productCategory GROUP BY  `order`.OrderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@fromDate", fromDate);
            cmd.Parameters.AddWithValue("@toDate", toDate);
            cmd.Parameters.AddWithValue("@productCategory", productCategory);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;

        }

        public DataTable reportStockFilterByDateAndCategory(string productCategory)
        {
            string sql = "SELECT ProductID, ProductName, SerialNumber AS PartNumber, BinLocation AS WareHouse, UnitPrice, CostPrice, QuantityInStock, DemandStock, OutOfStockQty AS 'Out-Of-StockLevel', ReOrderQty AS 'ReOrderLevel', DangerQty AS 'DangerLevel'FROM product WHERE ProductCategory=@productcategory";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@productCategory", productCategory);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;

        }

        public DataTable reportFilterByDateAndCategoryANDProductID(string fromDate, string toDate, string productID, string productCategory)
        {
            string sql = "SELECT  OrderDate, `order`.OrderID, DealerID, OrderStatus,SUM(OrderedQuantity) AS Quantity ,TotalPrice AS 'TotalPrice (CNY¥)' FROM `order`, orderitem,product WHERE OrderDate BETWEEN @fromDate AND @toDate  AND orderitem.ProductID = @productID AND ProductCategory = @productCategory GROUP BY  `order`.OrderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@fromDate", fromDate);
            cmd.Parameters.AddWithValue("@toDate", toDate);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@productCategory", productCategory);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;

        }


        public DataTable orderAccemblyDateFilter(string fromDate, string toDate)
        {
            string sql = "SELECT OrderID, DealerID, OrderStatus,OrderDate FROM `order` WHERE OrderDate BETWEEN @fromDate AND @toDate AND (OrderStatus = 'Outstanding' OR OrderStatus = 'OrderProcessing')";
            //string sql = "SELECT * FROM `order` WHERE OrderDate BETWEEN @fromDate AND @toDate"; 
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@fromDate", fromDate);
            cmd.Parameters.AddWithValue("@toDate", toDate);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;

        }
        
        public DataTable getOutstandingDateFilter(string fromDate, string toDate)
        {
            string sql = "SELECT * FROM outstandingorder WHERE OutstandingDate BETWEEN @fromDate AND @toDate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@fromDate", fromDate);
            cmd.Parameters.AddWithValue("@toDate", toDate);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }
        
        public DataTable getInvoiceDateFilter(string fromDate, string toDate)
        {
            string sql = "SELECT * FROM invoice WHERE IssueDate BETWEEN @fromDate AND @toDate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@fromDate", fromDate);
            cmd.Parameters.AddWithValue("@toDate", toDate);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }
        public DataTable getAuditLogDateFilter(string fromDate, string toDate)
        {
            string sql = "SELECT * FROM log WHERE LogDate BETWEEN @fromDate AND @toDate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@fromDate", fromDate);
            cmd.Parameters.AddWithValue("@toDate", toDate);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }
        
        public DataTable orderDateStatusFilter(string fromDate, string toDate, string status)
        {
            try
            {
                string sql = "SELECT OrderID, DealerID, OrderStatus, OrderDate FROM `order` WHERE (OrderDate BETWEEN @fromDate AND @toDate) AND OrderStatus=@status";
                // string sql = "SELECT * FROM `order` WHERE (OrderDate BETWEEN @fromDate AND @toDate) AND OrderStatus=@status";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);
                cmd.Parameters.AddWithValue("@status", status);
                MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adat.Fill(dataTable);
                ServerConnect().Close();
                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

           
        }


        public DataTable auditLogDateStatusFilter(string fromDate, string toDate, string type, string status)
        {
            try
            {
                string sql = "SELECT LogID, UserID, UserName AS 'Display Name',TypeID AS 'Target ID ' , Description, LogDate FROM log  WHERE (LogDate BETWEEN @fromDate AND @toDate) AND Type = @type AND Action= (SELECT ActionID FROM log_action WHERE ActionDetail = @status)";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@status", status);
                MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adat.Fill(dataTable);
                ServerConnect().Close();
                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }          
        }

        public DataTable getOrderMinAndMaxDate()
        {
            string sql = "SELECT MIN(OrderDate), MAX(OrderDate) FROM `order`";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable getOrderMinAndMaxDateForAccembly()
        {
            string sql = "SELECT MIN(OrderDate), MAX(OrderDate) FROM `order` WHERE OrderStatus = 'Outstanding' OR OrderStatus = 'OrderProcessing'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }
        

        public string getOrderDateForDelivery(string orderID)
        {
            string sql = "SELECT OrderDate FROM `order` WHERE OrderID = @orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            Object logID = cmd.ExecuteScalar();
            ServerConnect().Close();
            return logID.ToString();
        }
        public DataTable getOrderMinAndMaxDateForGRN()
        {
            string sql = "SELECT MIN(ReceiveDate), MAX(ReceiveDate) FROM grn";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        
        public DataTable getDNMinAndMaxDate()
        {
            string sql = "SELECT MIN(DeliveryDate), MAX(DeliveryDate) FROM delivery";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }
       
        public DataTable getOutstandingMinAndMaxDate()
        {
            string sql = "SELECT MIN(OutstandingDate), MAX(OutstandingDate) FROM outstandingorder";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }
        
        public DataTable getMinAndMaxDateForPO()
        {
            string sql = "SELECT MIN(Date), MAX(Date) FROM purchaseorder";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }
        
        public DataTable getMinAndMaxDateForInvoice()
        {
            string sql = "SELECT MIN(IssueDate), MAX(IssueDate) FROM invoice";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable getMinAndMaxDateForAuditLog()
        {
            string sql = "SELECT MIN(LogDate), MAX(LogDate) FROM log";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public bool cancelOrder(String orderID)
        {
            try
            {
                string sql = "UPDATE `order` SET OrderStatus='Cancelled' WHERE OrderID=@orderID ";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public DataTable getOutstandingOrder(string outid)
        {
            //string sql = "SELECT dealer.DealerID, dealer.DealerName, dealer.DealerCompanyName, order.DealerContactName, order.DealerContactPhoneNum, order.DeliveryAddress, outstandingorder.*, orderitem.ProductName, Product.UnitPrice FROM outstandingorder, dealer, orderitem `order` WHERE OutstandingOrderID=@outid AND outstandingorder.DealerID=dealer.DealerID AND product.ProductID=outstandingorder.ProductID AND outstandingorder.OrderID = `order`.OrderID";
            string sql = "SELECT dealer.DealerID, dealer.DealerName, dealer.DealerCompanyName, `order`.DealerContactName, `order`.DealerContactPhoneNum, `order`.DeliveryAddress,  `order`.DealerEmailAddress,`order`.OrderDate, `order`.ExpectCompleteDate, outstandingorder.*, orderitem.ProductName, product.UnitPrice FROM outstandingorder, dealer, orderitem ,`order` , product WHERE OutstandingOrderID=@outid AND outstandingorder.DealerID=dealer.DealerID AND product.ProductID=outstandingorder.ProductID AND outstandingorder.OrderID = `order`.OrderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@outid", outid);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public void completeOutstandingOrder(string outID)
        {
            string sql = "UPDATE outstandingorder SET Status='Completed' WHERE OutstandingOrderID=@outID ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@outID", outID);
            cmd.ExecuteNonQuery();
            ServerConnect().Close();
        }

        public DataTable GetProducts(List<string> productIDs)
        {
            //    string sql = "SELECT * FROM product WHERE ProductID = @productID";
            //   MySqlCommand cmd = new MySqlCommand(sql, ServerConnect()); ;
            //    cmd.Parameters.AddWithValue("@productID", productIDs);
            //    MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            //   DataTable dataTable = new DataTable();
            //    adat.Fill(dataTable);
            //    return dataTable;
            string sql = $"SELECT * FROM product WHERE ProductID IN ({string.Join(",", productIDs.Select(id => $"'{id}'"))})";

            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());

            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            adat.Fill(dataTable);

            return dataTable;
        }


        public string getLogID()
        {
            string sql = "SELECT MAX(RIGHT(logID,6)) FROM log";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            Object logID = cmd.ExecuteScalar();
            ServerConnect().Close();
            return logID.ToString();
        }

        public void LogCreateSalesOrder(string logID, string userID, string userName, string orderID)
        {
            DateTime Date = DateTime.Now;
            string Desc = "#" + userID + " " + userName + " Create Order #" + orderID;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate) VALUES(@logID, @userID, @userName, 1, 'Order' , @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", orderID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }

        public void LogCreateProduct(string logID, string userID, string userName, string productID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Create Product#" + productID;
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate)VALUES(@logID, @userID, @userName, 1, 'Product', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", productID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }

        public void LogCreateOutstandingOrder(string logID, string userID, string userName, string orderID, string outID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Create Outstanding Order#" + outID + " at Order Accembly" +  " For Order #" + orderID;
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate, SecondTypeID) VALUES(@logID, @userID, @userName, 1, 'OutstandingOrder', @TypeID,  @Desc,  @Date, @SecondTypeID)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", outID);
            cmd.Parameters.AddWithValue("@SecondTypeID", orderID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }
        public void LogCreatePurchaseOrder(string logID, string userID, string userName, string orderID, string purID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Create Purchase Order#" + purID + " at Order Accembly" + " For Order #" + orderID;
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate, SecondTypeID) VALUES(@logID, @userID, @userName, 1, 'PurchaseOrder', @TypeID,  @Desc,  @Date, @SecondTypeID)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", purID);
            cmd.Parameters.AddWithValue("@SecondTypeID", orderID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }

        public void LogUpdateProduct(string logID, string userID, string userName, string productID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Update Product#" + productID;
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate) VALUES(@logID, @userID, @userName, 2, 'Product', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", productID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }

        public void LogDeleteProduct(string logID, string userID, string userName, string productID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Delete Product#" + productID;
            string sql = "INSERT INTO log(LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate) VALUES(@logID, @userID, @userName, 3, 'Product', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", productID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }



        public void LogCreateDeliveryNote(string logID, string userID, string userName, string deliveryID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Create Delivery#" + deliveryID;
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate)VALUES(@logID, @userID, @userName, 1, 'Delivery', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", deliveryID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }


        public void LogCreateOrderAccembly(string logID, string userID, string userName, string orderID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Assgin Order Accembly For Order#" + orderID;
            string sql = "INSERT INTO log(LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate) VALUES(@logID, @userID, @userName, 1, 'OrderAccembly', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", orderID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.ExecuteNonQuery();
            ServerConnect().Close();
        }

        public void LogAssginProdutIntoAccembly(string logID, string userID, string userName, string orderID)
        {
            DateTime Date = DateTime.Now;
            string Desc = "#" + userID + "Assgin #" + orderID + " by following format #ProductID #" + " #Product Name " + " #Quantity ";
            //string Desc = "#" + userID + " Put #" + productID + " to #" + orderID;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate) VALUES(@logID, @userID, @userName, 1, 'OrderAccembly', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", orderID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.ExecuteNonQuery();
            ServerConnect().Close();
        }

        public void LogUpdateAssginProdutIntoAccembly(string logID, string productID, string productName, string qty)
        {

            string sql = "UPDATE log AS l JOIN (SELECT LogID, Description FROM log WHERE LogID = @logID) AS sub ON l.LogID = sub.LogID SET l.Description = CONCAT(sub.Description, ' [#', @productID, ' #', @productName, ' #', @qty, '] ') WHERE l.LogID = @logID;";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@productName", productName);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.ExecuteNonQuery();
            ServerConnect().Close();
        }

        public void LogCreateDealerContact(string logID, string userID, string userName, string dealerID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Create Dealer Contact#" + dealerID;
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate) VALUES(@logID, @userID, @userName, 1, 'Contact', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", dealerID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }


        public void LogUpdateDealerContact(string logID, string userID, string userName, string dealerID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Update Dealer Contact#" + dealerID;
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate)VALUES(@logID, @userID, @userName, 2, 'Contact', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", dealerID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }

        public void LogDeleteDealerContact(string logID, string userID, string userName, string dealerID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Delete Dealer Contact#" + dealerID;
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate)VALUES(@logID, @userID, @userName, 3, 'Contact', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", dealerID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }

        public void LogCreateSupplierContact(string logID, string userID, string userName, string supplierID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Create Supplier Contact#" + supplierID;
            string sql = "INSERT INTO log(LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate) VALUES(@logID, @userID, @userName, 1, 'Contact', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", supplierID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }

        public void LogUpdateSupplierContact(string logID, string userID, string userName, string supplierID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Update Supplier Contact#" + supplierID;
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate)VALUES(@logID, @userID, @userName, 2, 'Contact', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", supplierID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }

        public void LogDeleteSupplierContact(string logID, string userID, string userName, string supplierID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Delete Supplier Contact#" + supplierID;
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate)VALUES(@logID, @userID, @userName, 3, 'Contact', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", supplierID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }




        public void LogCreateGRN(string logID, string userID, string userName, string grnID, string PurID, string productID, string qty)
        {

            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Create GRN (#" + PurID + ") ProductID #" + productID + " Received " + qty + "quantity";
            string sql = "INSERT INTO log(LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate) VALUES(@logID, @userID, @userName, 1, 'GRN', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", grnID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }



        public void LogCreateInvoice(string logID, string invoiceID, string orderID)
        {

            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = " Create Invoice (#" + invoiceID + ") Order#" + orderID;
            string sql = "INSERT  INTO log(LogID, Action, Type, TypeID, Description, LogDate) VALUES(@logID, 1, 'Invoice', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@TypeID", invoiceID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }

        public void LogCreatetUserAccount(string logID, string userID, string userName, string newUserID, string title)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Create " + title + " (#" + newUserID + ")";
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate)VALUES(@logID, @userID, @userName, 1, 'Account', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", newUserID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }


        public void LogUpdateUserInfo(string logID, string userID, string userName, string affectUserID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Update User#" + affectUserID;
            string sql = "INSERT INTO log(LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate) VALUES(@logID, @userID, @userName, 2, 'Account', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", affectUserID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }

        public void LogEnableUserAccount(string logID, string userID, string userName, string affectUserID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Enable User account #" + affectUserID;
            string sql = "INSERT INTO log(LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate) VALUES(@logID, @userID, @userName, 7, 'Account', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", affectUserID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }


        public void LogDisableUserAccount(string logID, string userID, string userName, string affectUserID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Disable User account #" + affectUserID;
            string sql = "INSERT INTO log(LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate) VALUES(@logID, @userID, @userName, 8, 'Account', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", affectUserID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }



        public void LogUpdateSalesOrder(string logID, string userID, string userName, string orderID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Update Order#" + orderID;
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate)VALUES(@logID, @userID, @userName, 2, 'Order', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", orderID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }


        public void LogCancelSalesOrder(string logID, string userID, string userName, string orderID)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Cancel Order#" + orderID;
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, TypeID,Description,LogDate)VALUES(@logID, @userID, @userName, 3, 'Order', @TypeID,  @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@TypeID", orderID);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }


        public void LogUserLoginAttempt(string logID, string userID, string userName)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Login Successfully at " + Date.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, Description, LogDate) VALUES(@logID, @userID, @userName, 4, 'Account', @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }


        public void LogPrintSalesOrderReportCSV(string logID, string userID, string userName)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " "  + userName + " Print Sales Order Report CSV";
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, Description, LogDate) VALUES(@logID, @userID, @userName, 6, 'Report', @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }

        public void LogPrintStockReportCSV(string logID, string userID, string userName)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Print Stock Report CSV";
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, Description, LogDate) VALUES(@logID, @userID, @userName, 6, 'Report', @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }

        public bool LogFailureLoginTime(string userName)
        {

            string sql = "SELECT COUNT(*) = 5 AS exactly_5_rows FROM log WHERE timestamp >= NOW() - INTERVAL 20 MINUTE";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            return Convert.ToBoolean(cmd.ExecuteScalar());
        }


        public void LogUserLoginFailureAttempt(string logID, string userID, string userName)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Login Failed at " + Date.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO log (LogID, UserID, UserName, Action, Type, Description, LogDate) VALUES(@logID, @userID, @userName, 9, 'Account', @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }


        public int calLoginFailedCount(string userID) 
        {
            string sql = "SELECT COUNT(log.UserID) FROM log,staff WHERE Action = '9'  AND log.UserID = @userID AND LogDate >= NOW() - INTERVAL 20 MINUTE AND LogDate >= staff.LastLoginTime";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@userID", userID);
            object result = cmd.ExecuteScalar();
            int rowCount = Convert.ToInt32(result);
            ServerConnect().Close();
            return rowCount;
        } 

        public void LogUserLogOut(string logID, string userID, string userName)
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd HH:mm:ss");
            string Desc = "#" + userID + " " + userName + " Logout Successfully at " + Date.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO log(LogID, UserID, UserName, Action, Type, Description, LogDate) VALUES(@logID, @userID, @userName, 5, 'Account', @Desc,  @Date)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Date", Date);
            ServerConnect().Close();
            cmd.ExecuteNonQuery();
        }

        public DataTable overallLogInfo()
        {
            string sql = "SELECT LogID, UserID, UserName AS DisplayName, TypeID AS 'Target ID', Description, LogDate FROM log";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable searchLogInfo(string keyword)
        {
            string sql = "SELECT AuditID, UserID, UserName AS DisplayName, TypeID AS 'Target ID', Description, LogDate FROM log WHERE UserID LIKE @keyword OR UsearName LIKE @keyword OR TypeID LIKE @keyword OR SecondTypeID LIKE @keyword";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PurchaseOrderID", "%" + keyword + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        //Test
        public static List<SupplierDetails> GetSuppliers()
        {
            List<SupplierDetails> suppliers = new List<SupplierDetails>();
            string query = "SELECT SupplierID, SupplierCompanyName,SupplierContactPerson,SupplierPhoneNum,SupplierEmail FROM supplier";

            using (MySqlConnection conn = new DataBaseMethod().ServerConnect())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        suppliers.Add(new SupplierDetails
                        {
                            SupplierID = reader.GetString("SupplierID"),
                            SupplierCompanyName = reader.GetString("SupplierCompanyName"),
                            SupplierContactPerson = reader.GetString("SupplierContactPerson"),
                            SupplierPhoneNum = reader.GetString("SupplierPhoneNum"),
                            SupplierEmail = reader.GetString("SupplierEmail")
                        });
                    }
                }
            }
            
            return suppliers;
        }

        public static List<ProductDetails> GetProductsBySupplier(string supplierID)
        {
            List<ProductDetails> products = new List<ProductDetails>();
            string query = "SELECT p.ProductID, p.ProductName, p.CostPrice FROM supplier s " +
                           "LEFT JOIN supplierproducts sp ON s.SupplierID = sp.SupplierID " +
                           "LEFT JOIN product p ON sp.ProductID = p.ProductID " +
                           "WHERE s.SupplierID = @SupplierID " +
                           "ORDER BY s.SupplierID";

            using (MySqlConnection conn = new DataBaseMethod().ServerConnect())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new ProductDetails
                        {
                            ProductID = reader.GetString("ProductID"),
                            ProductName = reader.GetString("ProductName"),
                            CostPrice = reader.GetString("CostPrice")
                        });
                    }
                }
            }

            return products;
        }

        public static ProductDetails GetProductDetails(string productID)
        {
            ProductDetails product = null;
            string query = "SELECT ProductID, ProductName, UnitPrice FROM product WHERE ProductID = @ProductID";

            using (MySqlConnection conn = new DataBaseMethod().ServerConnect())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", productID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        product = new ProductDetails
                        {
                            ProductID = reader.GetString("ProductID"),
                            ProductName = reader.GetString("ProductName"),
                            UnitPrice = reader.GetString("UnitPrice")
                        };
                    }
                }
            }

            return product;
        }

        public static int InsertPurchaseOrder(string supplierID, string userID, DateTime orderDate, string totalPrice, string status)
        {
            int purchaseOrderID;
            string query = "INSERT INTO purchaseorder (SupplierID, UserID, Date, TotalPrice, Status) VALUES (@SupplierID, @UserID, @Date, @TotalPrice, @Status)";

            using (MySqlConnection conn = new DataBaseMethod().ServerConnect())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@Date", orderDate.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                cmd.Parameters.AddWithValue("@Status", status);

                cmd.ExecuteNonQuery();
                purchaseOrderID = (int)cmd.LastInsertedId;
            }

            return purchaseOrderID;
        }

        public static void InsertPurchaseOrderDetail(string purchaseOrderID, string productID, string quantity, string unitPrice)
        {
            string query = "INSERT INTO purchaseorderitem (PurchaseOrderID, ProductID, Quantity, UnitPrice, TotalPrice) VALUES (@PurchaseOrderID, @ProductID, @Quantity, @UnitPrice, @TotalPrice)";

            using (MySqlConnection conn = new DataBaseMethod().ServerConnect())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderID);
                cmd.Parameters.AddWithValue("@ProductID", productID);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                cmd.Parameters.AddWithValue("@TotalPrice", (Int32.Parse(quantity) * Int32.Parse(unitPrice)).ToString(CultureInfo.InvariantCulture));

                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateProductStock(string productID, int newStock)
        {
            string query = "UPDATE product SET Stock = @Stock WHERE ProductID = @ProductID";

            using (MySqlConnection conn = new DataBaseMethod().ServerConnect())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", productID);
                cmd.Parameters.AddWithValue("@Stock", newStock.ToString());

                cmd.ExecuteNonQuery();
            }
        }

        public static string GetUserIDFromStaffInfo(string PhoneNum)
        {
            string userID = null;
            string query = "SELECT UserID FROM staff WHERE PhoneNum = @PhoneNum";

            using (MySqlConnection conn = new DataBaseMethod().ServerConnect())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PhoneNum", PhoneNum);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userID = reader.GetString("UserID");
                    }
                }
            }

            return userID;
        }

        
        public DataTable getOrderStatus()
        {
            string sql = "SELECT DISTINCT Name FROM orderstatus";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        
        public bool getOrderStatusForCompleteOrder(string orderID)
        {
            string sql = "SELECT COUNT(OrderID) FROM `order` WHERE OrderID=@orderID AND OrderStatus='ALLProductPackaged'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@OrderID", orderID);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public DataTable getAuditStatus()
        {
            string sql = "SELECT DISTINCT ActionDetail FROM log_action";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }


        public DataTable getReportCount()
        {
            string sql = "SELECT product.ProductID, MAX(orderitem.OrderedQuantity) AS MaxOrderedQuantity FROM product JOIN orderitem ON orderitem.ProductID = product.ProductID GROUP BY product.ProductID ORDER BY MaxOrderedQuantity DESC;";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }
        
        public DataTable getTopSellingProductReport()
        {
            string sql = "SELECT product.ProductID, SUM(orderitem.OrderedQuantity) AS TotalOrderedQuantity, product.UnitPrice, product.CostPrice FROM product JOIN orderitem ON orderitem.ProductID = product.ProductID GROUP BY product.ProductID, product.UnitPrice, product.CostPrice ORDER BY TotalOrderedQuantity DESC;";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }


        public DataTable getOrderReport()
        {
            string sql = "SELECT  OrderDate, `order`.OrderID, DealerID, OrderStatus,SUM(OrderedQuantity) AS Quantity ,TotalPrice AS 'TotalPrice (CNY¥)' FROM orderitem,`order` WHERE orderitem.OrderID = `order`.OrderID  GROUP BY `order`.OrderID ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable getAllSalesReport()
        {
            string sql = "SELECT product.ProductID, orderitem.OrderedQuantity, product.UnitPrice, product.CostPrice FROM product, orderitem WHERE orderitem.ProductID = product.productID;";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }
        
        public DataTable getStockReportForCategory()
        {
            //string sql = "SELECT (SUM(QuantityInStock) * 100.0 / (SELECT SUM(QuantityInStock) FROM product)) AS Percentage, SUM(QuantityInStock) AS TotalQuantityInStock FROM product GROUP BY ProductCategory ORDER BY ProductCategory";
            string sql = "SELECT ProductCategory, SUM(QuantityInStock) AS TotalQuantityInStock FROM product GROUP BY ProductCategory ORDER BY ProductCategory";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable getStockInAndOut()
        {
            
            string sql = "SELECT SUM(ReceiveQty) AS 'Stock - In' FROM grn ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public string getAllOrderLabel()
        {
            string sql = "SELECT COUNT(*) FROM `order` WHERE OrderStatus != 'Cancelled'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object result = cmd.ExecuteScalar();
            ServerConnect().Close();
            return result.ToString();
        }

        public string getActiveOrder()
        {
            string sql = "SELECT COUNT(*) FROM `order` WHERE OrderStatus != 'Cancelled' AND OrderStatus != 'Completed'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object result = cmd.ExecuteScalar();
            ServerConnect().Close();
            return result.ToString();
        }

        public string getAllCancelOrderLabel()
        {
            string sql = "SELECT COUNT(OrderID) FROM `order` WHERE OrderStatus = 'Cancelled'";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            object result = cmd.ExecuteScalar();
            ServerConnect().Close();
            return result.ToString();
        }

        public string getAllCompletedOrderLabel()
        {
            try
            {
                string sql = "SELECT COUNT(OrderID) FROM `order` WHERE OrderStatus = 'Completed'";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                object result = cmd.ExecuteScalar();
                ServerConnect().Close();
                return result.ToString();

            }
            catch (Exception e)
            {
                return null;
            }
        }


        public string CreatePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            string purchaseOrderId = GetExistingPurchaseOrderID(purchaseOrder.SupplierID, purchaseOrder.Date);

            if (string.IsNullOrEmpty(purchaseOrderId))
            {
                purchaseOrderId = GenerateNewPurchaseOrderID();
            }

            using (MySqlConnection conn = ServerConnect())
            {
                string query = "INSERT INTO purchaseorder (PurchaseOrderID, SupplierID, Date, Status, ProductID, OrderQuantity, UnitPrice, TotalPrice) VALUES (@PurchaseOrderID, @SupplierID, @Date, @Status, @ProductID, @OrderQuantity, @UnitPrice, @TotalPrice)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderId);
                cmd.Parameters.AddWithValue("@SupplierID", purchaseOrder.SupplierID);
                cmd.Parameters.AddWithValue("@Date", purchaseOrder.Date);
                cmd.Parameters.AddWithValue("@Status", purchaseOrder.Status);
                cmd.Parameters.AddWithValue("@ProductID", purchaseOrder.ProductID);
                cmd.Parameters.AddWithValue("@OrderQuantity", purchaseOrder.OrderQuantity);
                cmd.Parameters.AddWithValue("@UnitPrice", purchaseOrder.UnitPrice);
                cmd.Parameters.AddWithValue("@TotalPrice", purchaseOrder.TotalPrice);
                cmd.ExecuteNonQuery();
                ServerConnect().Close();
            }
        

            return purchaseOrderId;
        }


        private string GenerateNewPurchaseOrderID()
        {
            string newID = "PUR000001";

            using (MySqlConnection conn = ServerConnect())
            {
            
                using (MySqlCommand cmd = new MySqlCommand("SELECT PurchaseOrderID FROM purchaseorder WHERE PurchaseOrderID LIKE 'PUR%' ORDER BY PurchaseOrderID DESC LIMIT 1", conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        string maxID = result.ToString();
                        int maxNumber = int.Parse(maxID.Substring(3));
                        newID = "PUR" + (maxNumber + 1).ToString("D6");
                    }
                }
            }

            return newID;
        }
        private string GetExistingPurchaseOrderID(string supplierID, string date)
        {
            using (MySqlConnection conn = ServerConnect())
            {
                string query = "SELECT PurchaseOrderID FROM purchaseorder WHERE SupplierID = @SupplierID AND Date = @Date LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                cmd.Parameters.AddWithValue("@Date", date);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
            }

            return null;
        }

        public void CreatePurchaseOrderItem(PurchaseOrderItem purchaseOrderItem)
        {
            string purchaseOrderItemId = GenerateNewPurchaseOrderItemID();

            using (MySqlConnection conn = ServerConnect())
            {
               
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO purchaseorderitem (PurchaseOrderItemID, PurchaseOrderID, ProductID, Quantity, UnitPrice, TotalPrice) VALUES (@PurchaseOrderItemID, @PurchaseOrderID, @ProductID, @Quantity, @UnitPrice, @TotalPrice)", conn))
                {
                    cmd.Parameters.AddWithValue("@PurchaseOrderItemID", purchaseOrderItemId);
                    cmd.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderItem.PurchaseOrderID);
                    cmd.Parameters.AddWithValue("@ProductID", purchaseOrderItem.ProductID);
                    cmd.Parameters.AddWithValue("@Quantity", purchaseOrderItem.Quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", purchaseOrderItem.UnitPrice);
                    cmd.Parameters.AddWithValue("@TotalPrice", purchaseOrderItem.TotalPrice);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private string GenerateNewPurchaseOrderItemID()
        {
            string newID = "PURI000001";

            using (MySqlConnection conn = ServerConnect())
            {
             
                using (MySqlCommand cmd = new MySqlCommand("SELECT PurchaseOrderItemID FROM purchaseorderitem WHERE PurchaseOrderItemID LIKE 'PURI%' ORDER BY PurchaseOrderItemID DESC LIMIT 1", conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        string maxID = result.ToString();
                        int maxNumber = int.Parse(maxID.Substring(4)); 
                        newID = "PURI" + (maxNumber + 1).ToString("D6");
                    }
                }
            }

            return newID;
        }

        public class PurchaseOrder
        {
            public string PurchaseOrderID { get; set; }
            public string SupplierID { get; set; }
            public string ProductID { get; set; }
            public string OrderQuantity { get; set; }
            public string UnitPrice { get; set; }
            public string TotalPrice { get; set; }
            public string Status { get; set; }
            public string Date { get; set; }
            public string ProductName { get; set; }
            public string SupplierCompanyName { get; set; }
        }

        public class PurchaseOrderItem
        {
            public string PurchaseOrderItemID { get; set; }
            public string PurchaseOrderID { get; set; }
            public string ProductID { get; set; }
            public string Quantity { get; set; }
            public string UnitPrice { get; set; }
            public string TotalPrice { get; set; }
        }

        public List<PurchaseOrder> GetPurchaseOrderItems(string poID)
        {
            List<PurchaseOrder> items = new List<PurchaseOrder>();

            using (MySqlConnection conn = ServerConnect())
            {
                string query = "SELECT * FROM purchaseorder WHERE PurchaseOrderID = @PurchaseOrderID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PurchaseOrderID", poID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PurchaseOrder item = new PurchaseOrder
                        {
                            ProductID = reader["ProductID"].ToString(),
                            OrderQuantity = reader["OrderQuantity"].ToString(),
                            UnitPrice = reader["UnitPrice"].ToString(),
                            TotalPrice = reader["TotalPrice"].ToString()
                        };
                        items.Add(item);
                    }
                }
            }

            return items;
        }


        public PurchaseOrder GetPurchaseOrderDetails(MySqlConnection connection, string purchaseOrderId)
        {
            string query = "SELECT po.PurchaseOrderID, po.SupplierID, po.Date, po.Status, po.ProductID, po.OrderQuantity, po.UnitPrice, po.TotalPrice, p.ProductName, s.SupplierCompanyName FROM purchaseorder po JOIN product p ON po.ProductID = p.ProductID JOIN supplier s ON po.SupplierID = s.SupplierID WHERE po.PurchaseOrderID = @PurchaseOrderID";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderId);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new PurchaseOrder
                    {
                        PurchaseOrderID = reader["PurchaseOrderID"].ToString(),
                        SupplierID = reader["SupplierID"].ToString(),
                        Date = reader.GetDateTime(reader.GetOrdinal("Date")).ToString("yyyy-MM-dd"),
                        Status = reader["Status"].ToString(),
                        ProductID = reader["ProductID"].ToString(),
                        OrderQuantity = reader["OrderQuantity"].ToString(),
                        UnitPrice = reader["UnitPrice"].ToString(),
                        TotalPrice = reader["TotalPrice"].ToString(),
                        ProductName = reader["ProductName"].ToString(),
                        SupplierCompanyName = reader["SupplierCompanyName"].ToString()
                    };
                }
                else
                {
                    throw new Exception("Purchase order not found.");
                }
            }


        }

        
        public DataTable searchPOInformation(string poID)
        {
            //  string sql = "SELECT * FROM staff, department WHERE department.departmentID = staff.DepartmentID AND UserName LIKE @username";
            string sql = "SELECT po.PurchaseOrderID, p.ProductName, po.OrderQuantity, po.UnitPrice, po.TotalPrice, s.SupplierCompanyName, po.Date, po.Status FROM purchaseorder po JOIN product p ON po.ProductID = p.ProductID JOIN supplier s ON po.SupplierID = s.SupplierID WHERE po.PurchaseOrderID LIKE @PurchaseOrderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@PurchaseOrderID", "%" + poID + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable searchGRNinfo(string keyword)
        {
            string sql = "SELECT grnID AS GRNID, ProductID, PurchaseOrderID, ReceiveQty, ReceiveDate, WareHouse FROM grn WHERE grnID LIKE @keyword OR ProductID LIKE @keyword OR PurchaseOrderID LIKE @keyword OR WareHouse LIKE @keyword";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }


        public string getTodayGRNReceiveQty()
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd");
            string sql = "SELECT IFNULL(SUM(ReceiveQty),0) FROM grn WHERE ReceiveDate= @date ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@date", Date);
            object result = cmd.ExecuteScalar();
            ServerConnect().Close();
            return result.ToString();
        }

        public DataTable getDashboardToadyLabel()
        {
            DateTime Date = DateTime.Now;
            Date.ToString("yyyy-MM-dd");
            string sql = "SELECT IFNULL(COUNT(DISTINCT `order`.OrderID),0) AS OrderCount, IFNULL(SUM(orderitem.OrderedQuantity),0) AS TotalOrderedQuantity FROM `order`, orderitem WHERE `order`.OrderID  = orderitem.OrderID AND DATE(`order`.OrderDate) =  @date";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@date", Date);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable getCategoryA7DaysOrderQuantity()
        {
            //string sql = "SELECT `order`.OrderID, `order`.OrderDate AS orderDateA, SUM(orderitem.OrderedQuantity) AS SUMA FROM `order` JOIN orderitem ON `order`.OrderID = orderitem.OrderID WHERE `order`.OrderDate > (NOW() - INTERVAL 7 DAY) AND LEFT(orderitem.ProductID, 1) = 'A' GROUP BY `order`.OrderID, `order`.OrderDate";
            string sql = "SELECT COUNT(*) AS OrderQuantityA, DATE(o.OrderDate) AS orderDateA, SUM(oi.OrderedQuantity) AS SUMA FROM `order` o JOIN orderitem oi ON o.OrderID = oi.OrderID WHERE o.OrderDate > (NOW() - INTERVAL 7 DAY) AND LEFT(oi.ProductID, 1) = 'A' GROUP BY DATE(o.OrderDate) ORDER BY DATE(o.OrderDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable getCategoryB7DaysOrderQuantity()
        {
            string sql = "SELECT COUNT(*) AS OrderQuantityB, DATE(o.OrderDate) AS orderDateB, SUM(oi.OrderedQuantity) AS SUMB FROM `order` o JOIN orderitem oi ON o.OrderID = oi.OrderID WHERE o.OrderDate > (NOW() - INTERVAL 7 DAY) AND LEFT(oi.ProductID, 1) = 'B' GROUP BY DATE(o.OrderDate) ORDER BY DATE(o.OrderDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

        public DataTable getCategoryC7DaysOrderQuantity()
        {
            string sql = "SELECT COUNT(*) AS OrderQuantityC, DATE(o.OrderDate) AS orderDateC, SUM(oi.OrderedQuantity) AS SUMC FROM `order` o JOIN orderitem oi ON o.OrderID = oi.OrderID WHERE o.OrderDate > (NOW() - INTERVAL 7 DAY) AND LEFT(oi.ProductID, 1) = 'C' GROUP BY DATE(o.OrderDate) ORDER BY DATE(o.OrderDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }
        public DataTable getCategoryD7DaysOrderQuantity()
        {
            string sql = "SELECT COUNT(*) AS OrderQuantityD, DATE(o.OrderDate) AS orderDateD, SUM(oi.OrderedQuantity) AS SUMD FROM `order` o JOIN orderitem oi ON o.OrderID = oi.OrderID WHERE o.OrderDate > (NOW() - INTERVAL 7 DAY) AND LEFT(oi.ProductID, 1) = 'D' GROUP BY DATE(o.OrderDate) ORDER BY DATE(o.OrderDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            ServerConnect().Close();
            return dataTable;
        }

    }

}

