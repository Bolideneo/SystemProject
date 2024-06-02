using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Data.Common;
using ITP4519M;
using System.Web;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics.SymbolStore;
using Org.BouncyCastle.Bcpg.OpenPgp;
using static ITP4519M.DataBaseMethod;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;


namespace ProgramMethod
{
    class ProgramMethod
    {
        DataBaseMethod dataBaseMethod;

        public ProgramMethod()
        {
            dataBaseMethod = new DataBaseMethod();
        }




        public bool verifyUser(string username, string password)
        {
            try
            {
                if (password == dataBaseMethod.getPassword(username))
                {
                    return true;
                }
            }
            catch
            { }
            return false;
        }

        public string getUserDisplayName(string username)
        {
            return dataBaseMethod.getUserDisplayName(username);
        }

        public bool getPermission(string username)
        {
            if (dataBaseMethod.getDepartmentIDByUserName(username).Equals("001"))
                return true;
            else
                return false;
        }



        public bool createUserAccount(string username, string password, string passwordagain, string dispalynanme, string department, string title)
        {
            if (password != passwordagain)
            {
                return false;
            }

            string deptID = dataBaseMethod.getDeptID(department);
            string userID = (int.Parse(dataBaseMethod.getUserID()) + 1).ToString("000");
            if (dataBaseMethod.createUser(userID, username, password, dispalynanme, deptID, title))
            {
                return true;
            }
            else
                return false;

        }

        //Datatable for user datagridView
        public DataTable searchUserInformation(string username)
        {
            return dataBaseMethod.searchUserInfoByName(username);
        }


        public DataTable overviewUserinfo()
        {
            return dataBaseMethod.overallUserInfo();
        }


        public DataTable overviewStockinfo()
        {
            return dataBaseMethod.overallStockinfo();
        }

        public bool updateUserInfor(string userID, String userName, string password, string passwordagain, string dispalyName, string departmentName, string title)
        {
             string departmentID = dataBaseMethod.getDepartmentIDByDepartName(departmentName);
            MessageBox.Show(departmentID);

                if (password != passwordagain)
                { 
                    return false;
                }

            if (dataBaseMethod.updateUserInfor(userID, userName, password, dispalyName, departmentID, title)){ 
                return true;
            }

            return false;
        }

        public string[] getStockLabelinfo(DataGridView stockData)
        {
            int qty = 0;
            int demanqty = 0;
            String[] data = new String[2];

            for (int i = 0; i < stockData.RowCount ; i++)
            {
                qty += int.Parse(stockData.Rows[i].Cells["QuantityInStock"].Value.ToString());
                demanqty += int.Parse(stockData.Rows[i].Cells["DemandStock"].Value.ToString());

            }
            data[0] = qty.ToString();
            data[1] = demanqty.ToString();

            return data;
        }

        

        public bool createProductinfo(string productName, string productCategory, string wareHouse, string sn, string unitPrice, string costPrice, string weight, string  autoOrder, string quantityInStock, string reOrderLevel, string dangerLevel, string demand, string description, string status)
        {
            string productID = productCategory[0] + (int.Parse(dataBaseMethod.getProductID(productCategory[0]).Substring(1)) + 1).ToString("00000");
            MessageBox.Show(productID);

            while (!dataBaseMethod.createNewProduct(productID, productName, productCategory, wareHouse, sn, unitPrice, costPrice, weight, autoOrder, quantityInStock, reOrderLevel, dangerLevel ,demand,  description, status))
            {
                MessageBox.Show("something wrong");
                productID = productCategory[0] + (int.Parse(dataBaseMethod.getProductID(productCategory[0]).Substring(1)) + 1).ToString("00000");
                break;

            }
            return true;
        }

        public UserDetails getUserDetails(string userid)
        {
            using (var connection = dataBaseMethod.ServerConnect())
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    return dataBaseMethod.GetUserDetails(connection, userid);
                }
                else
                {
                    throw new Exception("Database connection failed.");
                }
            }
        }


    }
}
