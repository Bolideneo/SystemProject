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


      //  createUserAccount(username, password, passwordAgain, displayName, title, phoneNum, email, department)
        public bool createUserAccount(string username, string password, string passwordagain, string dispalynanme, string title, string phonenum, string email, string department)
        {

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



        public bool createProductinfo(string productName, string productCategory, string wareHouse, string sn, string unitPrice, string costPrice, string weight, string outofStockQty, string quantityInStock, string productReOrder, string productDanger,  string demand, string description, string status)
        {
            string productID = productCategory[0] + (int.Parse(dataBaseMethod.getProductID(productCategory[0]).Substring(1)) + 1).ToString("00000");

            while (!dataBaseMethod.createNewProduct(productID, productName, productCategory, wareHouse, sn, unitPrice, costPrice, weight, outofStockQty, quantityInStock, productReOrder, productDanger, demand, description, status))
            {

                return false;

            }
            MessageBox.Show("Create new product successfully" );
            return true;
        }
        //productID, productName, productCategory, productWarehouse, productSerial, productUnitPrice, productCost, productWeight, productOutOfStock, productInStock, productReOrder, productDanger, productDemand, productDescription, productStatus
        public bool updateProductinfo(string productID, string productName, string productCategory, string wareHouse, string sn, string unitPrice, string costPrice, string weight, string quantityOutStock, string quantityInStock, string productReOrder, string productDanger, string demand, string description, string status)
        {


            if (dataBaseMethod.updateProductinfo(productID, productName, productCategory, wareHouse, sn, unitPrice, costPrice, weight, quantityOutStock, quantityInStock,  productReOrder,  productDanger, demand, description, status))
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

        public DataTable getOrderItemDetailForDelivery(string orderID)
        {
            return dataBaseMethod.getOrderItemDetailForDelivery(orderID);
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

        public int getAccountRowCount()
        {
            return dataBaseMethod.getAccountRowCount();
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
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 30, 30));
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
                // To be explicit...
                SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
                this.DoubleBuffered = false;
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                Size = new Size(100, 40);
                BackColor = Color.CadetBlue;
               // BackColor2 = Color.Tomato;
                ButtonBorderColor = Color.White;
                //ButtonHighlightColor = Color.Orange;
                //ButtonHighlightColor2 = Color.OrangeRed;
                ButtonHighlightForeColor = Color.Black;

                ButtonPressedColor = Color.BlueViolet;
                ButtonPressedColor2 = Color.Maroon;
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

        public DataTable getOrderEachItemDetail(string itemID, string orderID)
        {
            return dataBaseMethod.getOrderEachItemDetail(itemID, orderID);
        }

        public DataTable getOrderItemDetail(string orderID)
        {
            return dataBaseMethod.getOrderItemDetailforAsb(orderID);
        }

        public bool createOrderAsswmbly(DataGridView orderAccemblyActualdata, DataGridView orderAccemblyOrderItemdata, string orderID)
        {

            for (int i = 0; i < orderAccemblyActualdata.Rows.Count; i++)
            {
                if (int.Parse(dataBaseMethod.getPrdocutQuantityInStock(orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString())) > int.Parse(dataBaseMethod.getProdcutDangerQty((orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString()))))
                {
                    dataBaseMethod.updateProductStatus(orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString(), "Available");
                }
                if (int.Parse(dataBaseMethod.getPrdocutQuantityInStock(orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString())) <= (int.Parse(dataBaseMethod.getProdcutDangerQty((orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString())))))
                {
                    dataBaseMethod.updateProductStatus(orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString(), "Re-order");
                }

                if (int.Parse(dataBaseMethod.getPrdocutQuantityInStock(orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString())) <= (int.Parse(dataBaseMethod.getProdcutDangerQty((orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString())))))
                {
                    dataBaseMethod.updateProductStatus(orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString(), "Danger");
                }
                if (int.Parse(dataBaseMethod.getPrdocutQuantityInStock(orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString())) == 0)
                {
                    dataBaseMethod.updateProductStatus(orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString(), "Out-Of-Stock");
                }





                if (int.Parse(orderAccemblyActualdata.Rows[i].Cells[2].Value.ToString()) < int.Parse(orderAccemblyActualdata.Rows[i].Cells[3].Value.ToString()))
                {
                    string sum = ((int.Parse(orderAccemblyActualdata.Rows[i].Cells[3].Value.ToString()) - (int.Parse(orderAccemblyActualdata.Rows[i].Cells[2].Value.ToString())))).ToString();


                    string oustID = "OUT" + (int.Parse(dataBaseMethod.getOutStandingID()) + 1).ToString("000000");
                    while (!dataBaseMethod.createOutstandingOrder(oustID, orderID, orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString(), dataBaseMethod.getOrderOfDealerID(orderID), sum))
                    {
                        oustID = "OUT" + (int.Parse(dataBaseMethod.getOutStandingID()) + 1).ToString("000000");
                    }

                    if (int.Parse(dataBaseMethod.getPrdocutQuantityInStock(orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString())) < 0)
                        dataBaseMethod.setDefualtInStock(orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString());
                }
                //if (int.Parse(dataBaseMethod.getPrdocutQuantityInStock(orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString())) < int.Parse(dataBaseMethod.getItemReorderLev(orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString())))
                //{
                //    if (int.Parse(dataBaseMethod.searchPurchasesItem(orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString())) < 1)
                //    {
                //        string PurID = "PUR" + (int.Parse(dataBaseMethod.getPurchasesID()) + 1).ToString("000000");
                //        while (!dataBaseMethod.createPurchaseOrder(PurID, orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString(), dataBaseMethod.getItemAutoPur(orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString()), "In Procurement"))
                //        {
                //            PurID = "PUR" + (int.Parse(dataBaseMethod.getPurchasesOrderID()) + 1).ToString("000000");
                //        }
                //    }
                //}
                dataBaseMethod.updateOrderItemDemand(orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString(), int.Parse(orderAccemblyActualdata.Rows[i].Cells[2].Value.ToString()));
                dataBaseMethod.updateOrderItem(orderID, orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString(), orderAccemblyActualdata.Rows[i].Cells[2].Value.ToString());
            }
            if (orderAccemblyActualdata.RowCount != 0)
            { 
                string invoiceID = "INV" + (int.Parse(dataBaseMethod.getInvoiceID()) + 1).ToString("000000");
                while (!dataBaseMethod.createInvoice(invoiceID, orderID, dataBaseMethod.getOrderOfDealerID(orderID)))
                {
                    invoiceID = "INV" + (int.Parse(dataBaseMethod.getInvoiceID()) + 1).ToString("000000");
                }
            }
            Debug.WriteLine(orderAccemblyActualdata.RowCount);
            Debug.WriteLine(orderAccemblyOrderItemdata.RowCount);
            if (orderAccemblyActualdata.RowCount == 0)
            {

                for (int j = 0; j < orderAccemblyOrderItemdata.RowCount; j++)
                {
                    Debug.WriteLine("TEST");
                    string oustID = "OUT" + (int.Parse(dataBaseMethod.getOutStandingID()) + 1).ToString("000000");
                    while (!dataBaseMethod.createOutstandingOrder(oustID, orderID, orderAccemblyOrderItemdata.Rows[j].Cells[0].Value.ToString(), orderAccemblyOrderItemdata.Rows[j].Cells[3].Value.ToString(), dataBaseMethod.getOrderOfDealerID(orderID)))
                    {
                        oustID = "OUT" + (int.Parse(dataBaseMethod.getOutStandingID()) + 1).ToString("000000");
                    }
                }

            }
            else if (orderAccemblyActualdata.RowCount < orderAccemblyOrderItemdata.RowCount)
            {
                Debug.WriteLine("Test01");
                for (int i = 0; i < orderAccemblyOrderItemdata.RowCount; i++)
                {
                    Debug.WriteLine("Test02");
                    int count = 0;
                    for (int j = 0; j < orderAccemblyActualdata.RowCount; j++)
                    {
                        Debug.WriteLine("Test03");
                        if (orderAccemblyOrderItemdata.Rows[i].Cells[0].Value.ToString() != orderAccemblyActualdata.Rows[j].Cells[0].Value.ToString())
                        {
                            count++;
                        }
                        if (count == orderAccemblyActualdata.RowCount - 1)
                        {
                            Debug.WriteLine("Test03");
                            string oustID = "OUT" + (int.Parse(dataBaseMethod.getOutStandingID()) + 1).ToString("000000");
                            while (!dataBaseMethod.createOutstandingOrder(oustID, orderID, orderAccemblyActualdata.Rows[i].Cells[0].Value.ToString(), orderAccemblyActualdata.Rows[i].Cells[3].Value.ToString(), dataBaseMethod.getOrderOfDealerID(orderID)))
                            {
                                oustID = "OUT" + (int.Parse(dataBaseMethod.getOutStandingID()) + 1).ToString("000000");
                            }
                            break;
                        }
                    }

                }
            }
            int countNotMatch = 0;
            for (int i = 0; i < orderAccemblyActualdata.RowCount; i++)
            {
                if (int.Parse(orderAccemblyActualdata.Rows[i].Cells[2].Value.ToString()) < int.Parse(orderAccemblyActualdata.Rows[i].Cells[3].Value.ToString()))
                    countNotMatch++;
            }
            if (countNotMatch == orderAccemblyActualdata.RowCount)
                dataBaseMethod.updateOrderStatus("Outstanding", orderID);
            else
                dataBaseMethod.updateOrderStatus("Packaged", orderID);
            return true;
        }
    }
    }

    
    
