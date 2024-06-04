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
using Mysqlx.Crud;


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



        public bool createUserAccount(string username, string password, string passwordagain, string dispalynanme, string title, string phonenum, string email, string department)
        {
            if (password != passwordagain)
            {
                return false;
            }

            string deptID = dataBaseMethod.getDeptID(department);
            string userID = (int.Parse(dataBaseMethod.getUserID()) + 1).ToString("000");
            if (dataBaseMethod.createUser(userID, username, password, dispalynanme, deptID, title, phonenum, email, department))
            {
                return true;
            }
            else
                return false;

        }

        //Disable account
        public bool disableUserAccount(string userID)
        {

            if (dataBaseMethod.disableUser(userID))
            {
                return true;
            }
            else
                return false;

        }

        //enable account
        public bool enableUserAccount(string userID)
        {

            if (dataBaseMethod.enableUser(userID))
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

        public DataTable overviewDealerinfo()
        {
            return dataBaseMethod.overviewDealerinfo();
        }

        public DataTable overviewStockinfo()
        {
            return dataBaseMethod.overallStockinfo();
        }

        public DataTable overallOrderinfo()
        {
            return dataBaseMethod.overallOrderinfo();
        }

        public bool updateUserInfor(string userid, String userName, string password, string passwordagain, string dispalyName, string department, string title, string phonenum, string email)
        {
            string departmentID = dataBaseMethod.getDepartmentIDByDepartName(department);


            if (password != passwordagain)
            {
                return false;
            }

            if (dataBaseMethod.updateUserInfor(userid, userName, password, dispalyName, departmentID, title, phonenum, email, department)) {
                return true;
            }
            else
                return false;

        }

        public string[] getStockLabelinfo(DataGridView stockData)
        {
            int qty = 0;
            int demanqty = 0;
            String[] data = new String[2];

            for (int i = 0; i < stockData.RowCount; i++)
            {
                qty += int.Parse(stockData.Rows[i].Cells["QuantityInStock"].Value.ToString());
                demanqty += int.Parse(stockData.Rows[i].Cells["DemandStock"].Value.ToString());

            }
            data[0] = qty.ToString();
            data[1] = demanqty.ToString();

            return data;
        }



        public bool createProductinfo(string productName, string productCategory, string wareHouse, string sn, string unitPrice, string costPrice, string weight, string autoOrder, string quantityInStock, string reOrderLevel, string dangerLevel, string demand, string description, string status)
        {
            string productID = productCategory[0] + (int.Parse(dataBaseMethod.getProductID(productCategory[0]).Substring(1)) + 1).ToString("00000");

            while (!dataBaseMethod.createNewProduct(productID, productName, productCategory, wareHouse, sn, unitPrice, costPrice, weight, autoOrder, quantityInStock, reOrderLevel, dangerLevel, demand, description, status))
            {
                MessageBox.Show("something wrong");
                productID = productCategory[0] + (int.Parse(dataBaseMethod.getProductID(productCategory[0]).Substring(1)) + 1).ToString("00000");
                break;

            }
            return true;
        }

        public bool updateProductinfo(string productID, string productName, string productCategory, string wareHouse, string sn, string unitPrice, string costPrice, string weight, string autoOrder, string quantityInStock,  string demand, string description, string status)
        {
            

            if (dataBaseMethod.updateProductinfo(productID, productName, productCategory, wareHouse, sn, unitPrice, costPrice, weight, autoOrder, quantityInStock,  demand, description, status))
            {
                return true;

            }
            else 
                return false;
        }


        public bool productDel(string productID)
        {

            if (dataBaseMethod.delProduct(productID))
            {
                MessageBox.Show("Delete successfully");
                return true;
            }
            else
                return false;

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

        public ProductDetails getProductDetails(string productid)
        {
            using (var connection = dataBaseMethod.ServerConnect())
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {

                    return dataBaseMethod.GetProductDetails(connection, productid);
                }
                else
                {
                    throw new Exception("Database connection failed.");
                }
            }
        }

        //Search DealerID
        public bool searchDealerID(string dearlerID)
        {
            if (dataBaseMethod.searchDealerID(dearlerID) == dearlerID)
                return true;
            else
                return false;
        }

        public DataTable searchDealerDetail(string dealerID)
        {
            return dataBaseMethod.searchDealerDetail(dealerID);
        }

        public bool getValidProduct(string keyword)
        {
            if (dataBaseMethod.searchProductIDofOrder(keyword) == keyword || dataBaseMethod.searchProductNameOrder(keyword) == keyword)
                return true;
            else
                return false;
        }

        public DataTable searchOrderItemDetail(string keyword)
        {
            return dataBaseMethod.searchOrderItemDetail(keyword);
        }

        public float calProductTotalAmount(DataGridView productOfOrder)
        {
            float sum = 0;
            try
            {

                for (int i = 0; i < productOfOrder.Rows.Count; i++)
                {
                    sum += (int.Parse(productOfOrder.Rows[i].Cells[2].Value.ToString())) * (float.Parse(productOfOrder.Rows[i].Cells[3].Value.ToString()));
                }
            }
            catch
            {
                MessageBox.Show("Please input number");
                return 0;
            }
            return sum;
        }

        public DataTable getOrderDetails(string orderID)
        {
            return dataBaseMethod.getOrderDetails(orderID);
        }

        public DataTable getOrderItemDetails(string orderID)
        {
            return dataBaseMethod.getOrderItemDetails(orderID);
        }

        public DataTable getOrderItemProductDeatails(string orderID, string productID)
        {
            return dataBaseMethod.getOrderItemProductDeatails(orderID, productID);
        }

        public string createSalesOrder(string dealerID, string dealerName, string phoneNumber, string Address, DataGridView Order)
        {
    
            //dealerID = "D" + (((int.Parse(dataBaseMethod.getDealerID()) + 1).ToString("0000")));
            string orderID = "ORD" + (int.Parse(dataBaseMethod.getOrderID()) + 1).ToString("000000");
            while (!dataBaseMethod.createSalesOrder(orderID, dealerID, "OST001"))
            {
                orderID = "ORD" + (int.Parse(dataBaseMethod.getOrderID()) + 1).ToString("000000");
            }


            for (int i = 0; i < Order.Rows.Count; i++)
            {
                dataBaseMethod.createOrderItem(orderID, Order.Rows[i].Cells[0].Value.ToString(), Order.Rows[i].Cells[2].Value.ToString());
                dataBaseMethod.updateOrderItemDemand(Order.Rows[i].Cells[0].Value.ToString(), (int.Parse(Order.Rows[i].Cells[2].Value.ToString())));
            }


            return orderID;
        }

       public DataTable getOrderDealerName(string orderID, string dealerID)
        {
            return dataBaseMethod.getOrderDealerName(orderID, dealerID);
        }

        public bool searchOrderID(string orderID)
        {

            if (dataBaseMethod.searchOrderID(orderID) == orderID)
                return true;
            else
                return false;
        }
    }
}
    