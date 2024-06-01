using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
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
                        Console.WriteLine("User or Password is Wrong");
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
        public string getDepartmentID(string userName)
        {
            string sql = "SELECT DepartmentID FROM staff WHERE UserName=@userName";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@userName", userName);
            object departmentID = cmd.ExecuteScalar();
            ServerConnect().Close();
            return departmentID.ToString();
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
        public bool createUser(string userID, string username, string displayname, string password, string departmentID, string title)
        {
            try
            {
                string sql = "INSERT INTO staff(UserID, UserName, DisplayName, Password, DepartmentID, Title) VALUES(@userID, @username, @displayname, @password, @departmentID, @title)";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@displayname", displayname);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@departmentID", departmentID);
                cmd.Parameters.AddWithValue("@title", title);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) {
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

        //Update User information
        public bool updateUserInfor(string userID, string userName, string Password, string deptID, string title)
        {
            try
            {
                string sql = "UPDATE staff SET UserName=@userName Password=@password, deptID=@deptID, title=@title WHERE UserID=@userID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@password", Password);
                cmd.Parameters.AddWithValue("@deptID", deptID);
                cmd.Parameters.AddWithValue("@title", title);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    return true;
            }
            catch { return false; }
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


    }
}