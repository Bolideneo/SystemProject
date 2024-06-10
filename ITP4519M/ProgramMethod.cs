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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq.Expressions;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;



namespace ProgramMethod
{
    class ProgramMethod
    {
        DataBaseMethod dataBaseMethod;

        public ProgramMethod()
        {
            dataBaseMethod = new DataBaseMethod();
        }  

        public string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        public string DecodeFrom64(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new string(decoded_char);
            return result;
        }

        public bool verifyUser(string username, string password)
        {
            try
            {
                if (password == DecodeFrom64(dataBaseMethod.getPassword(username)))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public string getUserDisplayName(string username)
        {

            return dataBaseMethod.getUserDisplayName(username);
        }

        public string getUserDepartment(string username)
        {

            return dataBaseMethod.getUserDepartment(username);
        }

        public string[] getPermission(string username)
        {   
            string[] permission = new string[2];
            permission[0] = dataBaseMethod.getDepartmentIDbyUsername(username);
            permission[1] = dataBaseMethod.getUserTitle(username);
            return permission;
        }

        

        public bool createUserAccount(string username, string password, string passwordagain, string dispalynanme, string title, string phonenum, string email, string department)
        {

            if (password != passwordagain)
            {
                return false;
            }

            string deptID = dataBaseMethod.getDeptID(department);
            string userID = (int.Parse(dataBaseMethod.getUserID()) + 1).ToString("0000");
             if (dataBaseMethod.createUser(userID, username, EncodePasswordToBase64(password), dispalynanme, deptID, title, phonenum, email, department))
                {
                    return true;
               
                }
                
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

        //Datatable for product datagridView 
        public DataTable searchProductInformation(string productname)
        {
            return dataBaseMethod.searchProductInfoByName(productname);
        }

        public DataTable searchDealerInformation(string contactname)
        {
            return dataBaseMethod.searchDealerInfoByName(contactname);
        }
        public DataTable searchSupplierInformation(string contactname)
        {
            return dataBaseMethod.searchSupplierInfoByName(contactname);
        }
        public DataTable overviewUserinfo()
        {
            return dataBaseMethod.overallUserInfo();
        }

        public DataTable overviewDealerinfo()
        {
            return dataBaseMethod.overviewDealerinfo();
        }

        public DataTable overviewSupplierinfo()
        {
            return dataBaseMethod.overviewSupplierinfo();
        }

        public DataTable overviewStockinfo()
        {
            return dataBaseMethod.overallStockinfo();
        }

        public DataTable overallOrderinfo()
        {
            return dataBaseMethod.overallOrderinfo();
        }

        public bool updateUserInfor(string userid, string userName, string password, string passwordagain, string dispalyName, string department, string title, string phonenum, string email)
        {
            string departmentID = dataBaseMethod.getDepartmentIDByDepartName(department);


            if (password != passwordagain)
            {
                return false;
            }

            if (dataBaseMethod.updateUserInfor(userid, userName, EncodePasswordToBase64(password), dispalyName, departmentID, title, phonenum, email, department)) {
                return true;
            }
            else
                return false;

        }
        //
        public bool createDealer(string dealername, string dealerCompanyName, string dealerMailBox, string DealerPhoneNumBox, string dealerAddressBox)
        {
            string lastDealerID = dataBaseMethod.getDealerID();
            string letterPart = new string(lastDealerID.TakeWhile(c => !char.IsDigit(c)).ToArray());
            string numericPart = new string(lastDealerID.SkipWhile(c => !char.IsDigit(c)).ToArray());
            int lastDealerIDNum = int.Parse(numericPart);
            int newDealerIDNum = lastDealerIDNum + 1;
            string dealerID = $"{letterPart}{newDealerIDNum:D3}";
            if (dataBaseMethod.createDealer(dealerID, dealername, dealerCompanyName, dealerMailBox, DealerPhoneNumBox, dealerAddressBox))
            {
                return true;
            }
            else
                return false;

        }

        public bool createSupplier(string Suppliername, string SupplierMailBox, string SupplierPhoneNumBox, string SupplierAddressBox)
        {
            string lastSupplierID = dataBaseMethod.getSupplierID();
            string letterPart = new string(lastSupplierID.TakeWhile(c => !char.IsDigit(c)).ToArray());
            string numericPart = new string(lastSupplierID.SkipWhile(c => !char.IsDigit(c)).ToArray());
            int lastSupplierIDNum = int.Parse(numericPart);
            int newSupplierIDNum = lastSupplierIDNum + 1;
            string SupplierID = $"{letterPart}{newSupplierIDNum:D3}";
            if (dataBaseMethod.createSupplier(SupplierID, Suppliername, SupplierMailBox, SupplierPhoneNumBox, SupplierAddressBox))
            {
                return true;
            }
            else
                return false;

        }
        public bool updateDealerInfo(string dealerid, string dealerName, string dealerCompanyName, string dealerMail, string phoneNum, string dealerAddress)
        {


            if (dataBaseMethod.updateDealerInfo(dealerid, dealerName, dealerCompanyName, dealerMail, phoneNum, dealerAddress))
            {
                return true;
            }
            else
                return false;

        }


        public bool updateSupplierInfo(string supplierid, string supplierName, string supplierMail, string supplierPhoneNum, string supplierAddress)
        {


            if (dataBaseMethod.updateSupplierInfo(supplierid, supplierName, supplierMail, supplierPhoneNum, supplierAddress))
            {
                return true;
            }
            else
                return false;

        }

        public bool contactDel(string contactID)
        {

            if (dataBaseMethod.contactDel(contactID))
            {
                MessageBox.Show("Delete successfully");
                return true;
            }
            else
                return false;

        }

        public string[] getStockLabelinfo(DataGridView stockData)
        {
            int qty = 0;
            int demanqty = 0;
            string[] data = new string[2];

            for (int i = 0; i < stockData.RowCount; i++)
            {
                qty += int.Parse(stockData.Rows[i].Cells["QuantityInStock"].Value.ToString());
                demanqty += int.Parse(stockData.Rows[i].Cells["DemandStock"].Value.ToString());

            }
            data[0] = qty.ToString();
            data[1] = demanqty.ToString();

            return data;
        }



        public bool createProductinfo(string productName, string productCategory, string wareHouse, string sn, string unitPrice, string costPrice, string weight, string autoOrder, string quantityInStock, string demand, string description, string status)
        {
            string productID = productCategory[0] + (int.Parse(dataBaseMethod.getProductID(productCategory[0]).Substring(1)) + 1).ToString("00000");

            while (!dataBaseMethod.createNewProduct(productID, productName, productCategory, wareHouse, sn, unitPrice, costPrice, weight, autoOrder, quantityInStock, demand, description, status))
            {
                MessageBox.Show("something wrong");
                productID = productCategory[0] + (int.Parse(dataBaseMethod.getProductID(productCategory[0]).Substring(1)) + 1).ToString("00000");
                break;

            }
            return true;
        }

        public bool updateProductinfo(string productID, string productName, string productCategory, string wareHouse, string sn, string unitPrice, string costPrice, string weight, string autoOrder, string quantityInStock, string demand, string description, string status)
        {


            if (dataBaseMethod.updateProductinfo(productID, productName, productCategory, wareHouse, sn, unitPrice, costPrice, weight, autoOrder, quantityInStock, demand, description, status))
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

        public DealerDetails getDealerDetails(string dealerID)
        {
            using (var connection = dataBaseMethod.ServerConnect())
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    return dataBaseMethod.GetDealerDetails(connection, dealerID); 
                }
                else
                {
                    throw new Exception("Database connection failed.");
                }
            }
        }

        public SupplierDetails getSupplierDetails(string supplierID)
        {
            using (var connection = dataBaseMethod.ServerConnect())
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    return dataBaseMethod.GetSupplierDetails(connection, supplierID);
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
            string orderID = (int.Parse(dataBaseMethod.getOrderID()) + 1).ToString("000000");
            while (!dataBaseMethod.createSalesOrder(orderID, dealerID, "OrderProcessing"))
            {
                orderID = (int.Parse(dataBaseMethod.getOrderID()) + 1).ToString("000000");
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

        public DataTable searchGRNDate(string startDate, string endDate)
        {
            return dataBaseMethod.searchGRNDate(startDate, endDate);
        }

        public DataTable searchDeliveryDate(string startDate, string endDate)
        {
            return dataBaseMethod.searchDeliveryDate(startDate, endDate);
        }

        public DataTable overallGRNinfo()
        {
            return dataBaseMethod.overallGRNinfo();
        }

        public bool createGRN(string POID, string productID, string warehouse, string receiveqty, string receivedate)
        {
            //datatable temp = new datatable();
            if (dataBaseMethod.overallGRNinfo().Rows.Count == 0)
            {
                dataBaseMethod.createGRN("00001", POID, productID, warehouse, receiveqty, receivedate);
                return true;
            }
            string grnID = "G" + (int.Parse(dataBaseMethod.getGRNID('G').Substring(1)) + 1).ToString("000000");

            MessageBox.Show(grnID);
            try { 
            while (!dataBaseMethod.createGRN(grnID, POID, productID, warehouse, receiveqty, receivedate))
            {
                grnID = "G" + (int.Parse(dataBaseMethod.getGRNID('G').Substring(1)) + 1).ToString("000000");
            }
            }catch(Exception e)
            {

            MessageBox.Show(e.ToString()); }
            return true;


        }

        public void increaseStock(string ProductID, string qty)
        {
            int temp = int.Parse(dataBaseMethod.getProductQuantity(ProductID)) + int.Parse(qty);
            dataBaseMethod.increaseStock(ProductID, temp.ToString());

        }

        public string getOrderStatus(string orderID)
        {
            return dataBaseMethod.getOrderStatus(orderID);
        }

        public void orderDeleteItem(string orderID)
        {
            dataBaseMethod.orderDeleteItem(orderID);
        }

        public void  createOrderItem(string orderID, string product, string qty)
        {
            dataBaseMethod.createOrderItem(orderID, product, qty);
        }

        public DataTable overallDeliveryinfo()
        {
            return dataBaseMethod.overallDeliveryinfo();
        }

        public DataTable getInvoiceDetails(string orderID)
        {
            return dataBaseMethod.getInvoiceDetails(orderID);
        }


        public DataTable createDelivery(string orderID, string deliveryDate)
        {

                string deliveryID = "DE" + (int.Parse(dataBaseMethod.getDeliveryID("DE").Substring(1)) + 1).ToString("000000");

                 while (!dataBaseMethod.createDelivery(deliveryID, deliveryDate))
                {
                deliveryID = "DE" + (int.Parse(dataBaseMethod.getDeliveryID("DE").Substring(1)) + 1).ToString("000000");
                }

                //DataTable result = dataBaseMethod.getDelivery(orderID);
                dataBaseMethod.updateOrderStatus("OrderInTransit", orderID);
              //  return result;
            
               return null;
        }

        public DataTable getDeliveryDetails(string deliveryID)
        {
           return dataBaseMethod.getDeliveryDetails(deliveryID);
        }

        public DataTable getDepartmentNameDataSource()
        {
            return dataBaseMethod.getDepartmentNameDataSource();
        }
    }
    }
