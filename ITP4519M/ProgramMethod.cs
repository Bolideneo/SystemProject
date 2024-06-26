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
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using Org.BouncyCastle.Asn1.X509;
using static ProgramMethod.ProgramMethod.Win32Helpers;
using System.Windows.Forms.DataVisualization.Charting;



namespace ProgramMethod
{
    class ProgramMethod
    {
        DataBaseMethod dataBaseMethod;
        private string LoginUserID;
        private string LoginUserName;

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
                if (!dataBaseMethod.getUserName(username)){
                    return false;
                }
                else if (password == DecodeFrom64(dataBaseMethod.getPassword(username)))
                {
                    LogUserLoginAttempt(dataBaseMethod.getUserID(username), dataBaseMethod.getUserDisplayName(username));
                    return true;
                }
                LogUserLoginFailureAttempt(dataBaseMethod.getUserID(username),dataBaseMethod.getUserDisplayName(username));  
              
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public void CurrentUserIDAndName(string userID, string userName)
        {
          this.LoginUserID = userID;
          this.LoginUserName = userName;
        }

        public string getUserDisplayName(string username)
        {

            return dataBaseMethod.getUserDisplayName(username);
        }

        public string getUserID(string username)
        {

            return dataBaseMethod.getUserID(username);
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


        //  createUserAccount(username, password, passwordAgain, displayName, title, phoneNum, email, department)
        public bool createUserAccount(string username, string password, string passwordagain, string dispalynanme, string title, string phonenum, string email, string department)
        {

            string deptID = dataBaseMethod.getDeptID(department);

            string userID = (int.Parse(dataBaseMethod.getUserID()) + 1).ToString("0000");
            if (dataBaseMethod.createUser(userID, username, EncodePasswordToBase64(password), dispalynanme, deptID, title, phonenum, email, department))
            {
                LogCreatetUserAccount(LoginUserID, LoginUserName, userID, title);
                return true;

            }

            return false;

        }

        //Disable account
        public bool disableUserAccount(string userID)
        {

            if (dataBaseMethod.disableUser(userID))
            {
                LogDisableUserAccount(LoginUserID, LoginUserName, userID);
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
                LogEnableUserAccount(LoginUserID,LoginUserName,userID);
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
            return dataBaseMethod.searchProductInfo(productname);
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

        public int GetDealerCount()
        {
            return dataBaseMethod.GetDealerCount();
        }

        public int GetSupplierCount()
        {
            return dataBaseMethod.GetSupplierCount();
        }
        public int GetSupplierNum() 
        {
            return dataBaseMethod.GetSupplierNum();
        }



        public int GetPOCount()
        {
            return dataBaseMethod.GetPOCount();
        }

        public int GetInvoiceCount()
        {
            return dataBaseMethod.GetInvoiceCount();
        }

        public int GetOrderCount()
        {
            return dataBaseMethod.GetOrderCount();
        }


        public int GetDeliveryCount()
        {
            return dataBaseMethod.GetDeliveryCount();
        }

        public int GetGRNCount()
        {
            return dataBaseMethod.GetGRNCount();
        }


        public DataTable overviewStockinfo()
        {
            return dataBaseMethod.overallStockinfo();
        }

        public DataTable overallOrderinfo()
        {
            return dataBaseMethod.overallOrderinfo();
        }

        //updateUserInfor(userid, username, password, confirmPassword, displayName, department, title, phoneNum, email)
        public bool updateUserInfor(string userid, string userName, string password, string passwordagain, string dispalyName, string department, string title, string phonenum, string email)
        {
            string departmentID = dataBaseMethod.getDepartmentIDByDepartName(department);


            if (password != passwordagain)
            {
                MessageBox.Show("Please input same password");
                return false;
            }

            if (dataBaseMethod.updateUserInfor(userid, userName, EncodePasswordToBase64(password), dispalyName, departmentID, title, phonenum, email, department))
            {
                LogUpdateUserInfo(LoginUserID, LoginUserName, userid);
                return true;
            }
            else
                return false;

        }
        //
        public bool createDealer(string dealername, string dealerCompanyName, string dealerMailBox, string DealerPhoneNumBox, string dealerRegionNum, string dealerAddressBox)
        {
            string lastDealerID = dataBaseMethod.getDealerID();
            string letterPart = new string(lastDealerID.TakeWhile(c => !char.IsDigit(c)).ToArray());
            string numericPart = new string(lastDealerID.SkipWhile(c => !char.IsDigit(c)).ToArray());
            int lastDealerIDNum = int.Parse(numericPart);
            int newDealerIDNum = lastDealerIDNum + 1;
            string dealerID = $"{letterPart}{newDealerIDNum:D3}";
            if (dataBaseMethod.createDealer(dealerID, dealername, dealerCompanyName, dealerMailBox, DealerPhoneNumBox, dealerRegionNum, dealerAddressBox))
            {
                LogCreateDealerContact(LoginUserID, LoginUserName, dealerID);
                return true;
            }
            else
                return false;

        }

        public bool createSupplier(string Suppliername, string SupplierMailBox, string SupplierPhoneNumBox, string SupplierAddressBox, string SupplierContactNameBox, DataTable products)
        {
            string lastSupplierID = dataBaseMethod.getSupplierID();
            string letterPart = new string(lastSupplierID.TakeWhile(c => !char.IsDigit(c)).ToArray());
            string numericPart = new string(lastSupplierID.SkipWhile(c => !char.IsDigit(c)).ToArray());
            int lastSupplierIDNum = int.Parse(numericPart);
            int newSupplierIDNum = lastSupplierIDNum + 1;
            //string SupplierID = $"{letterPart}{newSupplierIDNum:D3}";
            string SupplierID = $"{letterPart}{newSupplierIDNum.ToString(new string('0', numericPart.Length))}";

            if (dataBaseMethod.createSupplier(SupplierID, Suppliername, SupplierMailBox, SupplierPhoneNumBox, SupplierAddressBox, SupplierContactNameBox, products))
            {
                LogCreateSupplierContact(LoginUserID, LoginUserName, SupplierID);   
                return true;
            }
            else
                return false;

        }
        public bool updateDealerInfo(string dealerid, string dealerName, string dealerCompanyName, string dealerMail, string phoneNum, string dealerRegionNum, string dealerAddress)
        {


            if (dataBaseMethod.updateDealerInfo(dealerid, dealerName, dealerCompanyName, dealerMail, phoneNum, dealerRegionNum, dealerAddress))
            {
                LogUpdateDealerContact(LoginUserID, LoginUserName, dealerid);
                return true;
            }
            else
                return false;

        }


        public bool updateSupplierInfo(string supplierid, string supplierCompanyName, string supplierContactPerson, string supplierMail, string supplierPhoneNum, string supplierAddress, DataTable products)
        {


            if (dataBaseMethod.updateSupplierInfo(supplierid, supplierCompanyName, supplierContactPerson, supplierMail, supplierPhoneNum, supplierAddress, products))
            {
                LogUpdateSupplierContact(LoginUserID, LoginUserName, supplierid);
                return true;
            }
            else
                return false;

        }

        public bool dealerDel(string contactID)
        {

            if (dataBaseMethod.dealerDel(contactID))
            {
                LogDeleteDealerContact(LoginUserID,LoginUserName, contactID);
                MessageBox.Show("Delete successfully");
                return true;
            }
            else
                return false;

        }

        public bool supplierDel(string contactID)
        {

            if (dataBaseMethod.supplierDel(contactID))
            {
                LogDeleteSupplierContact(LoginUserID, LoginUserName, contactID);
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



        public bool createProductinfo(string productName, string productCategory, string wareHouse, string sn, string unitPrice, string costPrice, string weight, string outofStockQty, string quantityInStock, string productReOrder, string productDanger, string demand, string description, string status)
        {
            string productID = productCategory[0] + (int.Parse(dataBaseMethod.getProductID(productCategory[0]).Substring(1)) + 1).ToString("00000");

            while (!dataBaseMethod.createNewProduct(productID, productName, productCategory, wareHouse, sn, unitPrice, costPrice, weight, outofStockQty, quantityInStock, productReOrder, productDanger, demand, description, status))
            {

                return false;
        
            }
            LogCreateProduct(LoginUserID,LoginUserName,productID);
            MessageBox.Show("Create new product successfully");
            return true;
        }
        //productID, productName, productCategory, productWarehouse, productSerial, productUnitPrice, productCost, productWeight, productOutOfStock, productInStock, productReOrder, productDanger, productDemand, productDescription, productStatus
        public bool updateProductinfo(string productID, string productName, string productCategory, string wareHouse, string sn, string unitPrice, string costPrice, string weight, string quantityOutStock, string quantityInStock, string productReOrder, string productDanger, string demand, string description, string status)
        {


            if (dataBaseMethod.updateProductinfo(productID, productName, productCategory, wareHouse, sn, unitPrice, costPrice, weight, quantityOutStock, quantityInStock, productReOrder, productDanger, demand, description, status))
            {
                LogUpdateProduct(LoginUserID, LoginUserName, productID);
                return true;
                
            }
            else
                return false;
        }


        public bool productDel(string productID)
        {

            if (dataBaseMethod.delProduct(productID))
            {
                LogDeleteProduct(LoginUserID, LoginUserName, productID);
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

        public string getProductWeight(string orderID)
        {

            DataTable table = dataBaseMethod.getProductWeight(orderID);
            int temp = 0;
            for (int i = 0; i < table.Rows.Count; i++)

            {
                temp = temp + (int.Parse(table.Rows[i]["Weight"].ToString()) * int.Parse(table.Rows[i]["OrderedQuantity"].ToString()));

            }

            return temp.ToString();
        }

        //Search DealerID
        public bool searchDealerID(string dearlerID)
        {
            if (dataBaseMethod.searchDealerID(dearlerID) == dearlerID)
                return true;
            else
                return false;
        }


        public DataTable searchDealerDetail(string keyword)
        {
            return dataBaseMethod.searchDealerDetail(keyword);
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
                    if (productOfOrder.Rows[i].Cells[4].Value.ToString() == "100")
                    {
                        sum += int.Parse(productOfOrder.Rows[i].Cells[2].Value.ToString()) * float.Parse(productOfOrder.Rows[i].Cells[3].Value.ToString());
                    }
                    else
                    {
                        sum += int.Parse(productOfOrder.Rows[i].Cells[2].Value.ToString()) * float.Parse(productOfOrder.Rows[i].Cells[3].Value.ToString()) * (100 - int.Parse(productOfOrder.Rows[i].Cells[4].Value.ToString())) / 100;
                    }
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

        public DataTable getOrderItemDetailForDelivery(string orderID)
        {
            return dataBaseMethod.getOrderItemDetailForDelivery(orderID);
        }

        public DataTable getOrderItemProductDeatails(string orderID, string productID)
        {
            return dataBaseMethod.getOrderItemProductDeatails(orderID, productID);
        }

        public string createSalesOrder(string dealerID, string dealerName,string dealerContactName, string dealerContactPhone, string phoneNumber, string Address, string CompleteDate,string price, DataGridView Order)
        {


            string orderID = (int.Parse(dataBaseMethod.getOrderID()) + 1).ToString("000000");
            while (!dataBaseMethod.createSalesOrder(orderID, dealerID, "OrderProcessing",Address,dealerContactName,dealerContactPhone,price))
            {
                orderID = (int.Parse(dataBaseMethod.getOrderID()) + 1).ToString("000000");
            }


            for (int i = 0; i < Order.Rows.Count; i++)
            {
                dataBaseMethod.createOrderItem(orderID, Order.Rows[i].Cells[0].Value.ToString(), Order.Rows[i].Cells[1].Value.ToString(), Order.Rows[i].Cells[2].Value.ToString(),Order.Rows[i].Cells[3].Value.ToString(), Order.Rows[i].Cells[4].Value.ToString());
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
            string grnID = "G" + (int.Parse(dataBaseMethod.getGRNID('G').Substring(1)) + 1).ToString("000000");
            try
            {
                if(dataBaseMethod.createGRN(grnID, POID, productID, warehouse, receiveqty, receivedate))
                {
                    LogCreateGRN(LoginUserID, LoginUserName, grnID, POID, productID, receiveqty);
                }

                if (int.Parse(dataBaseMethod.getPurchaseOrderQty(POID)) == int.Parse(receiveqty))
                {

                    if (dataBaseMethod.updatePurchaseOrder(POID, "Recevied"))
                    {
                     //   dataBaseMethod.updateProductStatus(productID, "Available");
                        return true;
                    }
                }
                else
                {
                    if (dataBaseMethod.updatePurchaseOrder(POID, "Outstanding"))
                    {
                       // dataBaseMethod.updateProductStatus(productID, "Available");
                        return true;
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            return true;


        }

        public void increaseStock(string ProductID, string qty)
        {
            int temp = int.Parse(dataBaseMethod.getProductQuantity(ProductID)) + int.Parse(qty);
            dataBaseMethod.increaseStock(ProductID, temp.ToString());


            DataTable ReOrderqty = dataBaseMethod.getProductQuantityLevel(ProductID);
            string ReOrderlevel = ReOrderqty.Rows[0]["ReOrderQty"].ToString();
            string dangerlevel = ReOrderqty.Rows[0]["DangerQty"].ToString();
            string outofStocklevel = ReOrderqty.Rows[0]["OutOfStockQty"].ToString();

            int reOrderLevelInt, dangerLevelInt, outOfStockLevelInt;
            bool isReOrderLevelValid = int.TryParse(ReOrderlevel, out reOrderLevelInt);
            bool isDangerLevelValid = int.TryParse(dangerlevel, out dangerLevelInt);
            bool isOutOfStockLevelValid = int.TryParse(outofStocklevel, out outOfStockLevelInt);

            if (!isReOrderLevelValid || !isDangerLevelValid || !isOutOfStockLevelValid)
            {
                MessageBox.Show("Error: Invalid product levels in database.");
                return;
            }

            if (temp > reOrderLevelInt)
            {
                dataBaseMethod.updateProductStatus(ProductID, "Available");
            }
            else if (temp <= outOfStockLevelInt)
            {
                dataBaseMethod.updateProductStatus(ProductID, "Out of Stock");
            }
            else if (temp > outOfStockLevelInt && temp <= dangerLevelInt)
            {
                dataBaseMethod.updateProductStatus(ProductID, "Danger");
            }
            else
            {
                dataBaseMethod.updateProductStatus(ProductID, "ReOrder");
            }

        }
        public void ReduceStock(string ProductID, string qty)
        {
            int temp = int.Parse(dataBaseMethod.getProductQuantity(ProductID)) - int.Parse(qty);
            dataBaseMethod.increaseStock(ProductID, temp.ToString());


            DataTable ReOrderqty = dataBaseMethod.getProductQuantityLevel(ProductID);
            string ReOrderlevel = ReOrderqty.Rows[0]["ReOrderQty"].ToString();
            string dangerlevel = ReOrderqty.Rows[0]["DangerQty"].ToString();
            string outofStocklevel = ReOrderqty.Rows[0]["OutOfStockQty"].ToString();

            int reOrderLevelInt, dangerLevelInt, outOfStockLevelInt;
            bool isReOrderLevelValid = int.TryParse(ReOrderlevel, out reOrderLevelInt);
            bool isDangerLevelValid = int.TryParse(dangerlevel, out dangerLevelInt);
            bool isOutOfStockLevelValid = int.TryParse(outofStocklevel, out outOfStockLevelInt);

            if (!isReOrderLevelValid || !isDangerLevelValid || !isOutOfStockLevelValid)
            {
                MessageBox.Show("Error: Invalid product levels in database.");
                return;
            }

            if (temp > reOrderLevelInt)
            {
                dataBaseMethod.updateProductStatus(ProductID, "Available");
            }
            else if (temp <= outOfStockLevelInt)
            {
                dataBaseMethod.updateProductStatus(ProductID, "Out of Stock");
            }
            else if (temp > outOfStockLevelInt && temp <= dangerLevelInt)
            {
                dataBaseMethod.updateProductStatus(ProductID, "Danger");
            }
            else
            {
                dataBaseMethod.updateProductStatus(ProductID, "ReOrder");
            }

        }

        public string getOrderStatus(string orderID)
        {
            return dataBaseMethod.getOrderStatus(orderID);
        }

        public void orderDeleteItem(string orderID)
        {
            dataBaseMethod.orderDeleteItem(orderID);
        }

        public void createOrderItem(string orderID, string product, string productName, string qty,string price, string discount)
        {
            //dataBaseMethod.createOrderItem(orderID, product, productName,qty,price,discount);
            LogUpdateSalesOrder(LoginUserID,LoginUserName,orderID);
        }

        public DataTable overallDeliveryinfo()
        {
            return dataBaseMethod.overallDeliveryinfo();
        }

        public DataTable getInvoiceDetails(string orderID)
        {
            return dataBaseMethod.getInvoiceDetails(orderID);
        }


        public bool createDelivery(string orderID, string deliveryDate)
        {
            string deliveryID = "DE" + (int.Parse(dataBaseMethod.getDeliveryID()) + 1).ToString("00000");
            DataTable dt = dataBaseMethod.getOrderItemDetailForDelivery(orderID);
            if (!dataBaseMethod.checkDeliveryOrderIDExist(orderID))
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataBaseMethod.createDeliveryNoteItem(deliveryID, dt.Rows[i]["ProductID"].ToString(), "N/A", dt.Rows[i]["ActualDespatchQuantity"].ToString(), dt.Rows[i]["QuantityFollow"].ToString());
                }
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataBaseMethod.createDeliveryNoteItem(deliveryID, dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["PreQtyDelivered"].ToString(), dt.Rows[i]["ActualDespatchQuantity"].ToString(), dt.Rows[i]["QuantityFollow"].ToString());
                    
                }
             }
            
            if(dataBaseMethod.createDelivery(deliveryID, orderID, deliveryDate, "Shipped"))
            {
               LogCreateDeliveryNote(LoginUserID,LoginUserName,deliveryID);
               return true;
            }
            else
            {
                return false;
            }

        }

        public void updateDeliveryStatus(string deliveryID, string deliveredDate)
        {
            dataBaseMethod.updateDeliveryStatus("Deliverd", deliveryID, deliveredDate);
        }

        public DataTable getDeliveryDetails(string deliveryID)
        {
           return dataBaseMethod.getDeliveryDetails(deliveryID);
        }

        
        public DataTable getDeliveryNoteItem(string deliveryID)
        {
            return dataBaseMethod.getDeliveryNoteItem(deliveryID);
        }

        public DataTable getDepartmentNameDataSource()
        {
            return dataBaseMethod.getDepartmentNameDataSource();
        }

        public int getAccountRowCount()
        {
            return dataBaseMethod.getAccountRowCount();
        }

        public int getDealersRowCount()
        {
            return dataBaseMethod.getDealersRowCount();
        }

        public int getSuppliersRowCount()
        {
            return dataBaseMethod.getSuppliersRowCount();
        }

        public int getStockRowCount()
        {
            return dataBaseMethod.getStockRowCount();
        }

        public int getOutstandingRowCount()
        {
            return dataBaseMethod.getOutstandingRowCount();
        }

        public int getOrderRowCount()
        {
            return dataBaseMethod.getOrderRowCount();
        }

        public string getAccountStatusCount()
        {
            return dataBaseMethod.getAccountStatusCount();
        }

        public string getNewUserName()
        {
            return dataBaseMethod.getNewUserName();
        }

        public DataTable GetAccountCurrentRecords(int page, int pageSize)
        {

            if (page == 1)
            {
                return dataBaseMethod.GetAccountCurrentRecords(page, pageSize);
            }
            else
            { 
               return dataBaseMethod.GetAccountCurrentRecords2(page, pageSize);
            }
        }

        public DataTable GetDealerCurrentRecords(int page, int pageSize)
        {

            if (page == 1)
            {
                return dataBaseMethod.GetDealerCurrentRecords(page, pageSize);
            }
            else
            {
                return dataBaseMethod.GetDealerCurrentRecords2(page, pageSize);
            }
        }

        public DataTable GetSupplierCurrentRecords(int page, int pageSize)
        {

            if (page == 1)
            {
                return dataBaseMethod.GetSupplierCurrentRecords(page, pageSize);
            }
            else
            {
                return dataBaseMethod.GetSupplierCurrentRecords2(page, pageSize);
            }
        }

        public DataTable GetStockCurrentRecords(int page, int pageSize)
        {

            if (page == 1)
            {
                return dataBaseMethod.GetStockCurrentRecords(page, pageSize);
            }
            else
            {
                return dataBaseMethod.GetStockCurrentRecords2(page, pageSize);
            }
        }

        public DataTable GetPOCurrentRecords(int page, int pageSize)
        {

            if (page == 1)
            {
                return dataBaseMethod.GetPOCurrentRecords(page, pageSize);
            }
            else
            {
                return dataBaseMethod.GetPOCurrentRecords2(page, pageSize);
            }
        }

        public DataTable GetInvoiceCurrentRecords(int page, int pageSize)
        {

            if (page == 1)
            {
                return dataBaseMethod.GetInvoiceCurrentRecords(page, pageSize);
            }
            else
            {
                return dataBaseMethod.GetInvoiceCurrentRecords2(page, pageSize);
            }
        }



        public DataTable GetOutstandingCurrentRecords(int page, int pageSize)
        {

            if (page == 1)
            {
                return dataBaseMethod.GetOutstandingCurrentRecords(page, pageSize);
            }
            else
            {
                return dataBaseMethod.GetOutstandingCurrentRecords2(page, pageSize);
            }
        }

        public DataTable GetCurrentRecords(string type, int page, int pageSize)
        {
            switch (type)
            {
                case "Order":
                if (page == 1)
                 {
                        return dataBaseMethod.GetOrderCurrentRecords(page, pageSize);
                 }
                 else
                 {
                        return dataBaseMethod.GetOrderCurrentRecords2(page, pageSize);
                 }

                case "GRN":
                 if (page == 1)
                  {
                        return dataBaseMethod.GetGRNCurrentRecords(page, pageSize);
                  }
                 else
                  {
                        return dataBaseMethod.GetGRNCurrentRecords2(page, pageSize);
                 }

                case "Delivery":

                    if (page == 1)
                    {
                        return dataBaseMethod.GetDeliveryCurrentRecords(page, pageSize);
                    }
                    else
                    {
                        return dataBaseMethod.GetDeliveryCurrentRecords2(page, pageSize);
                    }
            }
            return null;
           
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(System.IntPtr hObject);


        public  class RoundedTextBox : TextBox
        {
            [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect, // X-coordinate of upper-left corner or padding at start
                int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
                int nRightRect, // X-coordinate of lower-right corner or Width of the object
                int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                                //RADIUS, 
                int nheightRect, //height of ellipse 
                int nweightRect //width of ellipse
            );

            protected override void OnResize(EventArgs e)
            {
                base.OnResize(e);
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 40, 40));
            }

            [DllImport("user32")]
            private static extern IntPtr GetWindowDC(IntPtr hwnd);
            private const int WM_NCPAINT = 0x85;
            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);
                if (m.Msg == WM_NCPAINT && this.Focused)
                {
                    var dc = GetWindowDC(Handle);
                    using (Graphics g = Graphics.FromHdc(dc))
                    {
                        g.DrawRectangle(Pens.Red, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }

        //Origninal rounded button

        //public class RoundedButton : Button
        //{
        //    public int rdus = 30;
        //    System.Drawing.Drawing2D.GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        //    {
        //        float r2 = radius / 2f;
        //        System.Drawing.Drawing2D.GraphicsPath GraphPath = new System.Drawing.Drawing2D.GraphicsPath();
        //        GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
        //        GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
        //        GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
        //        GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
        //        GraphPath.AddArc(Rect.X + Rect.Width - radius,
        //                Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
        //        GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
        //        GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
        //        GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
        //        GraphPath.CloseFigure();
        //        return GraphPath;
        //    }
        //    protected override void OnPaint(PaintEventArgs e)
        //    {
        //        base.OnPaint(e);
        //        RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
        //        using (System.Drawing.Drawing2D.GraphicsPath GraphPath = GetRoundPath(Rect, rdus))
        //        {
        //            this.Region = new Region(GraphPath);
        //            using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
        //            {
        //                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
        //                e.Graphics.DrawPath(pen, GraphPath);
        //            }
        //        }
        //    }
        //}


        [DesignerCategory("Code")]
        public class RoundedButton : Control
        {
            private int m_BorderSize = 2;
            private int m_ButtonRoundRadius = 30;

            private bool IsHighlighted = false;
            private bool IsPressed = false;


            
            public RoundedButton()
            {
                SetStyle(ControlStyles.Opaque |
                         ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.ResizeRedraw |
                         ControlStyles.UserPaint, true);
                SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
                this.DoubleBuffered = false;
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                Size = new Size(100, 40);
                //BackColor = Color.CadetBlue;
               // BackColor2 = Color.Tomato;
                ButtonBorderColor = Color.White;
                //ButtonHighlightColor = Color.Orange;
                //ButtonHighlightColor2 = Color.OrangeRed;
                ButtonHighlightForeColor = Color.Black;

               // ButtonPressedColor = Color.BlueViolet;
               // ButtonPressedColor2 = Color.Maroon;
                ButtonPressedForeColor = Color.White;
            }


            protected override CreateParams CreateParams
            {
                get
                {
                    CreateParams cp = base.CreateParams;
                    cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                    return cp;
                }
            }

            // Invalidate(rect) in Design-Mode to refresh the view
            public int BorderSize
            {
                get => m_BorderSize;
                set
                {
                    m_BorderSize = Math.Max(Math.Min(value, 6), 1);
                    RepaintControl();
                }
            }

            // Set Max = 44, Min = 1 to avoid quirks and exceptions
            public int ButtonRoundRadius
            {
                get => m_ButtonRoundRadius;
                set
                {
                    m_ButtonRoundRadius = Math.Max(Math.Min(value, 44), 1);
                    RepaintControl();
                }
            }

            public override string Text
            {
                get => base.Text;

                set
                {
                    base.Text = value;
                    RepaintControl();
                }
            }

           
            public Color BorderColor { get; set; } = Color.White;
            public Color BackColor2 { get; set; } = Color.White;

            public Color ButtonBorderColor { get; set; }
            public Color ButtonHighlightColor { get; set; }
            public Color ButtonHighlightColor2 { get; set; }
            public Color ButtonHighlightForeColor { get; set; }
            public Color ButtonPressedColor { get; set; }
            public Color ButtonPressedColor2 { get; set; }
            public Color ButtonPressedForeColor { get; set; }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;


                var foreColor = IsPressed ? ButtonPressedForeColor : IsHighlighted ? ButtonHighlightForeColor : ForeColor;
                var backColor = IsPressed ? ButtonPressedColor : IsHighlighted ? ButtonHighlightColor : BackColor;
                var backColor2 = IsPressed ? ButtonPressedColor2 : IsHighlighted ? ButtonHighlightColor2 : BackColor2;
                var rect = Path.GetBounds();

                using (var pen = new Pen(ButtonBorderColor, m_BorderSize))
                using (var pathBrush = new LinearGradientBrush(rect, backColor, backColor2, LinearGradientMode.Vertical))
                using (var textBrush = new SolidBrush(foreColor))
                using (var sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    e.Graphics.FillPath(pathBrush, Path);
                    if (m_BorderSize > 0) e.Graphics.DrawPath(pen, Path);

                    rect.Inflate(-4, -4);
                    e.Graphics.DrawString(Text, Font, textBrush, rect, sf);


                }
            }

            protected override void OnMouseEnter(EventArgs e)
            {
                base.OnMouseEnter(e);
                IsHighlighted = true;
                ButtonBorderColor = Color.Blue;
                RepaintControl();
            }

            protected override void OnMouseLeave(EventArgs e)
            {
                base.OnMouseLeave(e);
                IsHighlighted = false;
                IsPressed = false;
                ButtonBorderColor = Color.Gray;
                RepaintControl();
            }

            protected override void OnMouseDown(MouseEventArgs e)
            {
                base.OnMouseDown(e);
                IsPressed = true;
                RepaintControl();
            }

            protected override void OnMouseUp(MouseEventArgs e)
            {
                base.OnMouseUp(e);
                IsPressed = false;
                RepaintControl();
            }

            private void RepaintControl()
            {
                Parent?.Invalidate(this.Bounds, true);
                Invalidate();
            }

            private GraphicsPath Path
            {
                get
                {
                    var rect = ClientRectangle;
                    int scaleOnBorder = -((m_BorderSize / 2) + 2);
                    rect.Inflate(scaleOnBorder, scaleOnBorder);
                    return GetRoundedRectangle(rect, m_ButtonRoundRadius);
                }
            }

            private GraphicsPath GetRoundedRectangle(Rectangle rect, int d)
            {
                var gp = new GraphicsPath();
                gp.StartFigure();
                gp.AddArc(rect.X, rect.Y, d, d, 180, 90);
                gp.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 90);
                gp.AddArc(rect.X + rect.Width - d, rect.Y + rect.Height - d, d, d, 0, 90);
                gp.AddArc(rect.X, rect.Y + rect.Height - d, d, d, 90, 90);
                gp.CloseFigure();
                return gp;
            }

         
        }
        public DataTable getOrderItemDetailsForOrderAccembly(string orderID)
        {
            return dataBaseMethod.getOrderItemDetailsForOrderAccembly(orderID);
        }

        public bool searchOrderEachItemDetail(string productID, string orderID)
        {
            DataTable result = dataBaseMethod.searchOrderEachItemDetail(orderID);
            ArrayList checkList = new ArrayList();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                if (productID == result.Rows[i]["ProductID"].ToString())
                {
                    checkList.Add(true);
                }
            }
            if (checkList.Contains(true))
                return true;
            else
                return false;
        }

        public DataTable getOrderEachItemDetail(string productID, string orderID)
        {
            return dataBaseMethod.getOrderEachItemDetail(productID, orderID);
        }

        public DataTable getOrderItemDetail(string orderID)
        {
            return dataBaseMethod.getOrderItemDetailforAsb(orderID);
        }

        public bool createOrderAssembly(DataGridView ActualDesptchData, DataGridView orderItemData, string orderID)
        {

            for (int i = 0; i < ActualDesptchData.Rows.Count; i++)
            {
                ReduceStock(ActualDesptchData.Rows[i].Cells[0].Value.ToString(), ActualDesptchData.Rows[i].Cells[2].Value.ToString());
                if (int.Parse(dataBaseMethod.getPrdocutQuantityInStock(ActualDesptchData.Rows[i].Cells[0].Value.ToString())) > int.Parse(dataBaseMethod.getProdcutDangerQty((ActualDesptchData.Rows[i].Cells[0].Value.ToString()))))
                {
                    dataBaseMethod.updateProductStatus(ActualDesptchData.Rows[i].Cells[0].Value.ToString(), "Available");
                }
                if (int.Parse(dataBaseMethod.getPrdocutQuantityInStock(ActualDesptchData.Rows[i].Cells[0].Value.ToString())) <= (int.Parse(dataBaseMethod.getProdcutDangerQty((ActualDesptchData.Rows[i].Cells[0].Value.ToString())))))
                {
                    dataBaseMethod.updateProductStatus(ActualDesptchData.Rows[i].Cells[0].Value.ToString(), "Re-order");
                }

                if (int.Parse(dataBaseMethod.getPrdocutQuantityInStock(ActualDesptchData.Rows[i].Cells[0].Value.ToString())) <= (int.Parse(dataBaseMethod.getProdcutDangerQty((ActualDesptchData.Rows[i].Cells[0].Value.ToString())))))
                {
                    dataBaseMethod.updateProductStatus(ActualDesptchData.Rows[i].Cells[0].Value.ToString(), "Danger");
                }
                if (int.Parse(dataBaseMethod.getPrdocutQuantityInStock(ActualDesptchData.Rows[i].Cells[0].Value.ToString())) == 0)
                {
                    dataBaseMethod.updateProductStatus(ActualDesptchData.Rows[i].Cells[0].Value.ToString(), "Out-Of-Stock");
                }


                if (int.Parse(ActualDesptchData.Rows[i].Cells[2].Value.ToString()) < int.Parse(ActualDesptchData.Rows[i].Cells[3].Value.ToString()))
                {
                    string sum = ((int.Parse(ActualDesptchData.Rows[i].Cells[3].Value.ToString()) - (int.Parse(ActualDesptchData.Rows[i].Cells[2].Value.ToString())))).ToString();


                    string oustID = "OUT" + (int.Parse(dataBaseMethod.getOutStandingID()) + 1).ToString("000000");
                    while (!dataBaseMethod.createOutstandingOrder(oustID, orderID, ActualDesptchData.Rows[i].Cells[0].Value.ToString(), dataBaseMethod.getOrderOfDealerID(orderID), sum))
                    {
                        oustID = "OUT" + (int.Parse(dataBaseMethod.getOutStandingID()) + 1).ToString("000000");
                    }

                    if (int.Parse(dataBaseMethod.getPrdocutQuantityInStock(ActualDesptchData.Rows[i].Cells[0].Value.ToString())) < 0)
                        dataBaseMethod.setDefualtInStock(ActualDesptchData.Rows[i].Cells[0].Value.ToString());
                }
                if (int.Parse(dataBaseMethod.getPrdocutQuantityInStock(ActualDesptchData.Rows[i].Cells[0].Value.ToString())) < int.Parse(dataBaseMethod.getProdcutReOrderQty(ActualDesptchData.Rows[i].Cells[0].Value.ToString())))
                {
                    if (dataBaseMethod.checkPurchaseOrderExist(ActualDesptchData.Rows[i].Cells[0].Value.ToString()) < 1)
                    {
                        string PurID = "PUR" + (int.Parse(dataBaseMethod.getPurchasesOrderID()) + 1).ToString("000000");
                        while (!dataBaseMethod.createPurchaseOrder(PurID, ActualDesptchData.Rows[i].Cells[0].Value.ToString(), dataBaseMethod.getProdcutReOrderQty(ActualDesptchData.Rows[i].Cells[0].Value.ToString()), "In Procurement"))
                        {
                            PurID = "PUR" + (int.Parse(dataBaseMethod.getPurchasesOrderID()) + 1).ToString("000000");
                        }
                    }
                }
                dataBaseMethod.updateOrderItemDemand(ActualDesptchData.Rows[i].Cells[0].Value.ToString(), int.Parse(ActualDesptchData.Rows[i].Cells[2].Value.ToString()));
                dataBaseMethod.updateOrderItem(orderID, ActualDesptchData.Rows[i].Cells[0].Value.ToString(), ActualDesptchData.Rows[i].Cells[2].Value.ToString(), ActualDesptchData.Rows[i].Cells[3].Value.ToString(), ActualDesptchData.Rows[i].Cells[2].Value.ToString());
                LogCreateOrderAccembly(LoginUserID, LoginUserName, orderID);

            }
            if (ActualDesptchData.RowCount != 0)
            { 
                string invoiceID = "INV" + (int.Parse(dataBaseMethod.getInvoiceID()) + 1).ToString("000000");
                while (!dataBaseMethod.createInvoice(invoiceID, orderID, dataBaseMethod.getOrderOfDealerID(orderID)))
                {
                    invoiceID = "INV" + (int.Parse(dataBaseMethod.getInvoiceID()) + 1).ToString("000000");
                }
            }
            Debug.WriteLine(ActualDesptchData.RowCount);
            Debug.WriteLine(orderItemData.RowCount);
            if (ActualDesptchData.RowCount == 0)
            {

                for (int j = 0; j < orderItemData.RowCount; j++)
                {
                    Debug.WriteLine("TEST");
                    string oustID = "OUT" + (int.Parse(dataBaseMethod.getOutStandingID()) + 1).ToString("000000");
                    while (!dataBaseMethod.createOutstandingOrder(oustID, orderID, orderItemData.Rows[j].Cells[0].Value.ToString(), dataBaseMethod.getOrderOfDealerID(orderID), orderItemData.Rows[j].Cells[3].Value.ToString()) )
                    {
                        oustID = "OUT" + (int.Parse(dataBaseMethod.getOutStandingID()) + 1).ToString("000000");
                    }
                }

            }
            else if (ActualDesptchData.RowCount < orderItemData.RowCount)
            {
                Debug.WriteLine("TEST ELSE");
                //Bug
                for (int i = 0; i < ActualDesptchData.RowCount; i++)
                {
                    Debug.WriteLine("TEST POIN0");
                    int count = 0;
                    for (int j = 0; j < ActualDesptchData.RowCount; j++)
                    {
                        Debug.WriteLine("TEST POIN1");
                        if (orderItemData.Rows[i].Cells[0].Value.ToString() != ActualDesptchData.Rows[j].Cells[0].Value.ToString())
                        {
                            count++;
                        }
                        if (count == ActualDesptchData.RowCount - 1)
                        {
                            MessageBox.Show(i.ToString());
                            Debug.WriteLine("TEST POIN2");
                            string oustID = "OUT" + (int.Parse(dataBaseMethod.getOutStandingID()) + 1).ToString("000000");
                            while (!dataBaseMethod.createOutstandingOrder(oustID, orderID, ActualDesptchData.Rows[i].Cells[0].Value.ToString(), dataBaseMethod.getOrderOfDealerID(orderID), ActualDesptchData.Rows[i].Cells[3].Value.ToString()))
                            {
                                oustID = "OUT" + (int.Parse(dataBaseMethod.getOutStandingID()) + 1).ToString("000000");
                            }
                            break;
                        }
                    }

                }
            }
            int countNotMatch = 0;
            for (int i = 0; i < ActualDesptchData.RowCount; i++)
            {
                // if (int.Parse(ActualDesptchData.Rows[i].Cells[2].Value.ToString()) < int.Parse(ActualDesptchData.Rows[i].Cells[3].Value.ToString()))
                if (int.Parse(ActualDesptchData.Rows[i].Cells[3].Value.ToString()) > 0)
                {

                    countNotMatch++;
                }
            }
            if (countNotMatch == ActualDesptchData.RowCount)
                dataBaseMethod.updateOrderStatus("Outstanding", orderID);
            else
                dataBaseMethod.updateOrderStatus("ProductPackaged", orderID);
            return true;
        }

        public class BorderTextBox : TextBox
        {
            const int WM_NCPAINT = 0x85;
            const uint RDW_INVALIDATE = 0x1;
            const uint RDW_IUPDATENOW = 0x100;
            const uint RDW_FRAME = 0x400;
            [DllImport("user32.dll")]
            static extern IntPtr GetWindowDC(IntPtr hWnd);
            [DllImport("user32.dll")]
            static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
            [DllImport("user32.dll")]
            static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, uint flags);
            Color borderColor = Color.Red;
            public Color BorderColor
            {
                get { return borderColor; }
                set
                {
                    borderColor = value;
                    RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                        RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
                }
            }
            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);
                if (m.Msg == WM_NCPAINT && BorderColor != Color.Transparent &&
                    BorderStyle == System.Windows.Forms.BorderStyle.Fixed3D)
                {
                    var hdc = GetWindowDC(this.Handle);
                    using (var g = Graphics.FromHdcInternal(hdc))
                    using (var p = new Pen(BorderColor))
                        g.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1));
                    ReleaseDC(this.Handle, hdc);
                }
            }
            protected override void OnSizeChanged(EventArgs e)
            {
                base.OnSizeChanged(e);
                RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                       RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
            }
        }

        public DataTable searchOrder(string keyword)
        {
            return dataBaseMethod.searchOrder(keyword);
        }

        public DataTable orderDateFilter(string fromData, string toDate)
        {
            return dataBaseMethod.orderDateFilter(fromData, toDate);

        }

        public DataTable orderDateStatusFilter(string fromDate, string toDate, string status)
        {
            return dataBaseMethod.orderDateStatusFilter(fromDate, toDate, status);
        }

        public string[] getOrderMinAndMaxDate()
        {
            string[] temp = new string[2];
            DataTable Date = dataBaseMethod.getOrderMinAndMaxDate();
            temp[0] = Date.Rows[0][0].ToString();
            temp[1] = Date.Rows[0][1].ToString();
            return temp;
        }

        public bool cancelOrder(string orderID)
        {
            LogCancelSalesOrder(LoginUserID,LoginUserName,orderID);
            return dataBaseMethod.cancelOrder(orderID);
        }


        public string calOrderItemQuantityFollow(DataGridView orderItemdata, string orderID)
        {
            int qty = 0;
            try
            {
                if (dataBaseMethod.checkOrderItemFollowQuantity(orderID))
                {
                    for (int i = 0; i < orderItemdata.Rows.Count; i++)
                    {
                        string orderedQtyStr = dataBaseMethod.getOrderItemOrderedQuantity(orderID, orderItemdata.Rows[i].Cells[0].Value.ToString());
                        string itemQtyStr = orderItemdata.Rows[i].Cells[2].Value.ToString();

                        int orderedQty, itemQty;
                        if (int.TryParse(orderedQtyStr, out orderedQty) && int.TryParse(itemQtyStr, out itemQty))
                        {
                            qty = orderedQty - itemQty;
                        }
                        else
                        {
                            // Handle the case where conversion was not successful
                            // For example, log an error or set qty to a default value
                            Console.WriteLine("Error: Invalid quantity format.");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < orderItemdata.Rows.Count; i++)
                    {
                        string followQtyStr = dataBaseMethod.getOrderItemFollowQuantity(orderID, orderItemdata.Rows[i].Cells[0].Value.ToString());
                        string itemQtyStr = orderItemdata.Rows[i].Cells[2].Value.ToString();

                        int followQty, itemQty;
                        if (int.TryParse(followQtyStr, out followQty) && int.TryParse(itemQtyStr, out itemQty))
                        {
                            qty = followQty - itemQty;
                        }
                        else
                        {
                            // Handle the case where conversion was not successful
                            // For example, log an error or set qty to a default value
                            Console.WriteLine("Error: Invalid quantity format.");
                        }
                    }
                }

            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.Message);
                MessageBox.Show("Please input number");
            }
            return qty.ToString();
        }

        public string getOrderItemFollowQuantity(string orderID, string productID)
        {
            return dataBaseMethod.getOrderItemFollowQuantity(orderID, productID);
        }


        public DataTable getOutstandingOrder(string outID)
        {
            return dataBaseMethod.getOutstandingOrder(outID);
        }

    

        public class PanelBorderColor : Panel
        {
            public PanelBorderColor()
            {
                BorderStyle = BorderStyle.FixedSingle;
            }
            private Color borderColor = Color.DarkOrange;
            [DefaultValue(typeof(Color), "Blue")]
            public Color BorderColor
            {
                get { return borderColor; }
                set
                {
                    if (borderColor != value)
                    {
                        borderColor = value;
                        Redraw();
                    }
                }
            }
            private int borderWidth = 2;
            [DefaultValue(2)]
            public int BorderWidth
            {
                get { return borderWidth; }
                set
                {
                    if (value == 0)
                        throw new ArgumentException("The value should be greater than 0");
                    if (borderWidth != value)
                    {
                        borderWidth = value;
                        RecalculateClientSize();
                    }
                }
            }

            protected override void WndProc(ref Message m)
            {
                if (BorderStyle != BorderStyle.FixedSingle)
                {
                    base.WndProc(ref m);
                    return;
                }
                if (m.Msg == Win32Helpers.WM_NCPAINT)
                {
                    base.WndProc(ref m);
                    WmNCPaint(ref m);
                }
                else if (m.Msg == Win32Helpers.WM_NCCALCSIZE)
                {
                    base.WndProc(ref m);
                    WmNCCalcSize(ref m);
                }
                else if (m.Msg == Win32Helpers.WM_NCHITTEST)
                {
                    base.WndProc(ref m);
                    WmNCHitTest(ref m);
                }
                else
                    base.WndProc(ref m);

            }
            protected override void OnSizeChanged(EventArgs e)
            {
                base.OnSizeChanged(e);
                Redraw();
            }
            private void Redraw()
            {
                Win32Helpers.RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                   Win32Helpers.RDW_FRAME | Win32Helpers.RDW_INVALIDATE | Win32Helpers.RDW_UPDATENOW);
            }
            private void RecalculateClientSize()
            {
                Win32Helpers.SetWindowPos(this.Handle, IntPtr.Zero, 0, 0, 0, 0,
                    Win32Helpers.SWP_NOSIZE | Win32Helpers.SWP_NOMOVE | Win32Helpers.SWP_FRAMECHANGED | Win32Helpers.SWP_NOZOORDER);
            }
            private void WmNCCalcSize(ref Message m)
            {
                if (BorderStyle != BorderStyle.FixedSingle)
                    return;

                if (m.WParam != IntPtr.Zero)
                {
                    var nccsp = (Win32Helpers.NCCALCSIZE_PARAMS)Marshal.PtrToStructure(m.LParam, typeof(Win32Helpers.NCCALCSIZE_PARAMS));
                    nccsp.rgrc[0].top += borderWidth - 1;
                    nccsp.rgrc[0].bottom -= borderWidth - 1;
                    nccsp.rgrc[0].left += borderWidth - 1;
                    nccsp.rgrc[0].right -= borderWidth - 1;
                    Marshal.StructureToPtr(nccsp, m.LParam, true);
                    Win32Helpers.InvalidateRect(this.Handle, nccsp.rgrc[0], true);
                    m.Result = IntPtr.Zero;
                }
                else
                {
                    var clnRect = (Win32Helpers.RECT)Marshal.PtrToStructure(m.LParam, typeof(Win32Helpers.RECT));
                    clnRect.top += borderWidth - 1;
                    clnRect.bottom -= borderWidth - 1;
                    clnRect.left += borderWidth - 1;
                    clnRect.right -= borderWidth - 1;
                    Marshal.StructureToPtr(clnRect, m.LParam, true);
                    m.Result = IntPtr.Zero;
                }
            }
            private void WmNCPaint(ref Message m)
            {
                var dc = Win32Helpers.GetWindowDC(Handle);
                using (var g = Graphics.FromHdc(dc))
                {
                    using (var p = new Pen(BorderColor, borderWidth) { Alignment = PenAlignment.Inset })
                    {
                        if (VScroll && HScroll)
                        {
                            Rectangle bottomCornerRectangle = new Rectangle(
                                Width - SystemInformation.VerticalScrollBarWidth - borderWidth,
                                Height - SystemInformation.HorizontalScrollBarHeight - borderWidth,
                                SystemInformation.VerticalScrollBarWidth,
                                SystemInformation.HorizontalScrollBarHeight);
                            if (RightToLeft == RightToLeft.Yes)
                            {
                                bottomCornerRectangle.X = Width - bottomCornerRectangle.Right;
                            }
                            g.FillRectangle(SystemBrushes.Control, bottomCornerRectangle);
                        }
                        var adjustment = borderWidth == 1 ? 1 : 0;
                        g.DrawRectangle(p, 0, 0, Width - adjustment, Height - adjustment);
                    }
                }
                Win32Helpers.ReleaseDC(Handle, dc);
                m.Result = IntPtr.Zero;
            }
            private void WmNCHitTest(ref Message m)
            {
                var pt = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                var rect = Parent.RectangleToScreen(Bounds);
                if (((pt.X >= rect.Left && pt.X <= rect.Left + borderWidth) ||
                    (pt.X >= rect.Right - borderWidth && pt.X <= rect.Right)) ||
                    ((pt.Y >= rect.Top && pt.Y <= rect.Top + borderWidth) ||
                    (pt.Y >= rect.Bottom - borderWidth && pt.Y <= rect.Bottom)))
                    m.Result = (IntPtr)Win32Helpers.HTBORDER;
            }
        }

        public static class Win32Helpers
        {
            public const int WM_NCPAINT = 0x85;
            public const int RDW_INVALIDATE = 0x0001,
                RDW_ERASE = 0x0004,
                RDW_ALLCHILDREN = 0x0080,
                RDW_ERASENOW = 0x0200,
                RDW_UPDATENOW = 0x0100,
                RDW_FRAME = 0x0400;
            public const int WM_NCCALCSIZE = 0x0083;
            public const int SWP_FRAMECHANGED = 0x0020,
                SWP_NOMOVE = 0x0002,
                SWP_NOSIZE = 0x0001,
                SWP_NOZOORDER = 0x0004;


            public const int WM_NCHITTEST = 0x0084;
            public const int HTBORDER = 18;
            public const int HTHSCROLL = 6;
            public const int HTVSCROLL = 7;
            public const int HTCLIENT = 1;

            [StructLayout(LayoutKind.Sequential)]
            public struct RECT
            {
                public int left, top, right, bottom;
            }
            [StructLayout(LayoutKind.Sequential)]
            public struct NCCALCSIZE_PARAMS
            {
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
                public RECT[] rgrc;
                public WINDOWPOS lppos;
            }
            [StructLayout(LayoutKind.Sequential)]
            public struct WINDOWPOS
            {
                public IntPtr hwnd;
                public IntPtr hwndInsertAfter;
                public int x;
                public int y;
                public int cx;
                public int cy;
                public uint flags;
            }
            public const int NM_FIRST = 0;
            public const int NM_CLICK = NM_FIRST - 2;
            public const int WM_REFLECT = 0x2000;
            public const int WM_NOFITY = 0x004e;
            public const int WM_CTLCOLORSCROLLBAR = 0x0137;
            [StructLayout(LayoutKind.Sequential)]
            public struct NMHDR
            {
                public IntPtr hwndFrom;
                public IntPtr idFrom;
                public int code;
            }
            [DllImport("user32.dll")]
            public static extern bool InvalidateRect(IntPtr hWnd, RECT lpRect, bool bErase);
            [DllImport("user32.dll")]
            public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
            [DllImport("user32")]
            public static extern IntPtr GetWindowDC(IntPtr hwnd);
            [DllImport("user32.dll")]
            public static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, int flags);
            [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
            public static extern IntPtr SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
        }
        public DataTable GetProducts(List<string> productIDs)
        {
            return dataBaseMethod.GetProducts(productIDs);
        }


        public void LogCreateSalesOrder(string userID,string userName, string orderID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogCreateSalesOrder(logID, userID, userName, orderID);
            }
        }


        public void LogCreateProduct(string userID, string userName, string productID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogCreateProduct(logID, userID, userName, productID);
            }
        }

        public void LogUpdateProduct(string userID, string userName, string productID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogUpdateProduct(logID, userID, userName, productID);
            }
        }

        public void LogDeleteProduct(string userID, string userName, string productID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogDeleteProduct(logID, userID, userName, productID);
            }
        }
        

         public void LogCreateDeliveryNote(string userID, string userName, string deliveryID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogCreateDeliveryNote(logID, userID, userName, deliveryID);
            }
        }

        

         public void LogCreateOrderAccembly(string userID, string userName, string orderID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogCreateOrderAccembly(logID, userID, userName, orderID);
            }
        }

       

        public void LogCreateDealerContact(string userID, string userName, string dealerID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogCreateDealerContact(logID, userID, userName, dealerID);
            }
        }
        
        public void LogUpdateDealerContact(string userID, string userName, string dealerID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogUpdateDealerContact(logID, userID, userName, dealerID);
            }
        }
        
        public void LogDeleteDealerContact(string userID, string userName, string dealerID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogDeleteDealerContact(logID, userID, userName, dealerID);
            }
        }
        
        public void LogCreateSupplierContact(string userID, string userName, string supplierID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogCreateSupplierContact(logID, userID, userName, supplierID);
            }
        }

        public void LogUpdateSupplierContact(string userID, string userName, string supplierID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogUpdateSupplierContact(logID, userID, userName, supplierID);
            }
        }
        

        public void LogDeleteSupplierContact(string userID, string userName, string supplierID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogDeleteSupplierContact(logID, userID, userName, supplierID);
            }
        }

        public void LogCreateGRN(string userID, string userName, string grnID, string PurID, string productID, string qty)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogCreateGRN(logID, userID, userName, grnID, PurID, productID, qty);
            }
        }

        public void LogCreateInvoice(string userID,string invoiceID, string orderID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogCreateInvoice(logID,invoiceID, orderID);
            }
        }
                 
        public void LogCreatetUserAccount(string userID, string userName, string newUserID, string title)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogCreatetUserAccount(logID, userID, userName, newUserID,title);
            }
        }

        public void LogUpdateUserInfo(string userID, string userName, string affectUserID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogUpdateUserInfo(logID, userID, userName, affectUserID);
            }
        }

       
         public void LogEnableUserAccount(string userID, string userName, string affectUserID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogEnableUserAccount(logID, userID, userName, affectUserID);
            }
        }

        public void LogDisableUserAccount(string userID, string userName, string affectUserID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogDisableUserAccount(logID, userID, userName, affectUserID);
            }
        }

        public void LogUpdateSalesOrder(string userID, string userName, string orderID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogUpdateSalesOrder(logID, userID, userName, orderID);
            }
        }

        public void LogCancelSalesOrder(string userID, string userName, string orderID)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogCancelSalesOrder(logID, userID, userName, orderID);
            }
        }

        public void LogUserLoginAttempt(string userID, string userName)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogUserLoginAttempt(logID, userID, userName);
            }
        }

        public void LogUserLoginFailureAttempt(string userID, string userName)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");

            if (logID != null)
            {
              dataBaseMethod.LogUserLoginFailureAttempt(logID, userID, userName);
            }
        }

         public void LogUserLogOut(string userID, string userName)
        {
            string logID = "LOG" + (int.Parse(dataBaseMethod.getLogID()) + 1).ToString("000000");
            if (logID != null)
            {
                dataBaseMethod.LogUserLogOut(logID, userID, userName);
            }
        }

        public DataTable overallLoginfo()
        {
            return dataBaseMethod.overallLogInfo();
        }


    }

}

    
    
