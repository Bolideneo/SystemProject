﻿using System;
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
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@username", username);
            ServerConnect().Close();
            object displayName = cmd.ExecuteScalar();
            if (displayName != null)
            {
                return displayName.ToString();
            }
            else
            {
                return "displayName not found.";
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
            string sql = "SELECT UserID, UserName, Password, department.DepartmentName, Title FROM staff, department WHERE department.departmentID = staff.DepartmentID AND UserName=@username OR UserID=@username";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@username", username);
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

        public bool createNewProduct(string productID, string productname , string productcategory, string binlocation, String sn, string unitprice, string costprice, string weight, string autoOrder, string quantitystock, string reorderlevel, string demandstock, string dangerlevel, string description, string status )
        {
            try
            {
                string sql = "INSERT INTO product(ProductID, ProdductName, SerialNumber, ProductCategory, BinLocation, Weight, UnitPrice, CostPrice, autoOrder, QuantityInStock, DemandStock, ReOrderQty, DangerQty, Description, Status) VALUES(@pid, @pName, @sn, @pCategory, @binLocation, @weight, @uniPrice, @costPrice, @autoOrder, @quantityStock, @demandStock, @reorderLevel, @dangerLevel, @description, @status)";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@pid", productID);
                cmd.Parameters.AddWithValue("@pName", productname);
                cmd.Parameters.AddWithValue("@sn", sn);
                cmd.Parameters.AddWithValue("@pCategory",productcategory);
                cmd.Parameters.AddWithValue("@binLocation", binlocation);
                cmd.Parameters.AddWithValue("@weight", weight);
                cmd.Parameters.AddWithValue("@unitPrice", unitprice);
                cmd.Parameters.AddWithValue("@costPrice", costprice);
                cmd.Parameters.AddWithValue("@autoOrder", autoOrder);
                cmd.Parameters.AddWithValue("@quantityStock", quantitystock);
                cmd.Parameters.AddWithValue("@demandStock", demandstock);
                cmd.Parameters.AddWithValue("@reorderLevel", reorderlevel);
                cmd.Parameters.AddWithValue("@dangerLevel", dangerlevel);
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
        //productID, productName, productCategory, wareHouse, sn, unitPrice, costPrice, weight, autoOrder, quantityInStock, reOrderLevel, dangerLevel, demand, description, status
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
  //              cmd.Parameters.AddWithValue("@reorderLevel", reorderlevel);
    //            cmd.Parameters.AddWithValue("@dangerLevel", dangerlevel);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@status", status);
            //    int result = cmd.ExecuteNonQuery();
                // 使用 GetFullSqlString 函数生成完整的 SQL 语句
                string fullSql = GetFullSqlString(cmd);

                // 在 MessageBox 中显示完整的 SQL 语句
                MessageBox.Show(fullSql);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
            return false;
        }

        public string GetFullSqlString(MySqlCommand cmd)
        {
            string sql = cmd.CommandText;
            foreach (MySqlParameter param in cmd.Parameters)
            {
                string paramValue = param.Value == null ? "NULL" : param.Value.ToString();

                // If the parameter is a string, add single quotes around it
                if (param.DbType == System.Data.DbType.String || param.DbType == System.Data.DbType.DateTime)
                {
                    paramValue = $"'{paramValue}'";
                }

                sql = sql.Replace(param.ParameterName, paramValue);
            }
            return sql;
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
            orderDate.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO order (OrderID, DealerID, OrderStatusID, OrderDate) VALUES(@orderID, @dearlerID, @orderStatusID, @orderDate)";
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


    }

}
