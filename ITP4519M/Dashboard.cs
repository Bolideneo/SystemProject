using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
//using ProgramMethod;
using ProgramMethod;
using Org.BouncyCastle.Asn1.Cmp;
using System.Reflection.Metadata.Ecma335;
using System.Reflection;
using ITP4519M;
using System.Linq.Expressions;
using Google.Protobuf.WellKnownTypes;
using System.Xml.Linq;
using Org.BouncyCastle.Asn1.Sec;
using System.Runtime.InteropServices;
using System.Diagnostics;
using MySqlX.XDevAPI.Common;


namespace ITP4519M
{
    public enum OperationMode
    {
        View,
        New,
        Edit,
        Disable
    }
    public partial class Dashboard : Form
    {

        private ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        //Account datagrid paging
        private int PgSize = 10;
        private int CurrentPageIndex = 1;
        private int TotalPage = 0;
        //Paging

        //Stock datagrid paging
        private int StockPgSize = 15;
        private int StockPageIndex = 1;
        private int StockTotalPage = 0;
        //Paging

        //outstadning datagrid paging
        private int outstandingPgSize = 15;
        private int outstandingPageIndex = 1;
        private int outstandingTotalPage = 0;
        //Paging


        //DealerContact datagrid paging
        private int DealerPgSize = 10;
        private int DealerPageIndex = 1;
        private int DealerTotalPage = 0;
        //Paging

        //SupplierContact datagrid paging
        private int SupplierPgSize = 10;
        private int SupplierPageIndex = 1;
        private int SupplierTotalPage = 0;
        //Paging

        private Button currentButton;
        TypeAssistant assistant;
        private string userID;
        private string productID;
        private string orderID;
        private string grnID;
        private string dealerID;
        private string deliveryID;
        private string DeliverydeliveryID;
        private string DeliveryorderID;
        private string contactID;
        private string outstandingOrderID;
        private string orderAccemblyOrderID;
        private string orderAccemblyDealerID;
        private bool isDealerDVG;
        private int PageSize = 5;
        private int index = -1;
        private int index2 = -1;
        private int orderindex = -1;
        private int userindex = -1;
        private int grnindex = -1;
        private int deliveryindex = -1;
        private int dealerindex = -1;
        private int supplierindex = -1;
        private int stockindex = -1;
        private int orderAceemblyindex = -1;
        private int outstandingIndex = -1;
        private int outstandingTotalIndex = -1;
        private string currentDataSourceType = "";
        private Button lastClickedButton = null;
        private Button[] buttons = new Button[2];
        private bool isFormDragging = false;
        private Point formStartPoint;
        private int[] buttonLocationIndex = [229, 300, 371, 440, 509, 580, 651, 720, 789];



        public Dashboard()
        {

            InitializeComponent();
            ShowPanel(dashboardpnl);
            closebtn.BringToFront();
            this.StartPosition = FormStartPosition.CenterParent;
        }



        private void InitializeButtons()
        {
            buttons[0] = usersbtn;
            buttons[1] = stockbtn;
            buttons[2] = orderbtn;
            buttons[3] = contactsbtn;
            buttons[4] = Logbtn;
            buttons[5] = settingbtn;

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            programMethod = new ProgramMethod.ProgramMethod();
            closebtn.BringToFront();

            if (Owner != null)
                Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2,
                    Owner.Location.Y + Owner.Height / 2 - Height / 2);
        }

        //        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //        private static extern IntPtr CreateRoundRectRgn
        // (
        //    int nLeftRect,     // x-coordinate of upper-left corner
        //    int nTopRect,      // y-coordinate of upper-left corner
        //    int nRightRect,    // x-coordinate of lower-right corner
        //    int nBottomRect,   // y-coordinate of lower-right corner
        //    int nWidthEllipse, // height of ellipse
        //    int nHeightEllipse // width of ellipse
        //);

        //        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        //        private static extern bool DeleteObject(System.IntPtr hObject);


        //        class RoundTextBox : TextBox
        //        {
        //            [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //            private static extern IntPtr CreateRoundRectRgn
        //            (
        //                int nLeftRect, // X-coordinate of upper-left corner or padding at start
        //                int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
        //                int nRightRect, // X-coordinate of lower-right corner or Width of the object
        //                int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
        //                                //RADIUS, 
        //                int nheightRect, //height of ellipse 
        //                int nweightRect //width of ellipse
        //            );

        //            protected override void OnResize(EventArgs e)
        //            {
        //                base.OnResize(e);
        //                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 30, 30));
        //            }
        //        }



        //        class RoundedButton : Button
        //        {
        //            public int rdus = 30;
        //            System.Drawing.Drawing2D.GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        //            {
        //                float r2 = radius / 2f;
        //                System.Drawing.Drawing2D.GraphicsPath GraphPath = new System.Drawing.Drawing2D.GraphicsPath();
        //                GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
        //                GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
        //                GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
        //                GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
        //                GraphPath.AddArc(Rect.X + Rect.Width - radius,
        //                        Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
        //                GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
        //                GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
        //                GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
        //                GraphPath.CloseFigure();
        //                return GraphPath;
        //            }
        //            protected override void OnPaint(PaintEventArgs e)
        //            {
        //                base.OnPaint(e);
        //                RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
        //                using (System.Drawing.Drawing2D.GraphicsPath GraphPath = GetRoundPath(Rect, rdus))
        //                {
        //                    this.Region = new Region(GraphPath);
        //                    using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
        //                    {
        //                        pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
        //                        e.Graphics.DrawPath(pen, GraphPath);
        //                    }
        //                }
        //            }
        //        }

        public void ButtonLocation(string departmentID, string title)
        {
            switch (departmentID)
            {
                //IT
                case "001":
                    ShowButton(false);
                    usersbtn.Visible = true;
                    settingbtn.Visible = true;
                    usersbtn.Location = new Point(25, buttonLocationIndex[0]);
                    settingbtn.Location = new Point(25, buttonLocationIndex[8]);
                    break;


                //Account



                //Sales Manager
                case "003":
                    if (title.ToString() == "Sales Manager" || title.ToString() == "Area Manager")
                    {
                        break;
                    }
                    else if (title.ToString() == "Sales Office Clerk")
                    {
                        ShowButton(false);
                        orderbtn.Visible = true;
                        OrderAccemblybtn.Visible = true;
                        settingbtn.Visible = true;
                        orderbtn.Location = new Point(25, buttonLocationIndex[0]);
                        OrderAccemblybtn.Location = new Point(25, buttonLocationIndex[1]);
                        settingbtn.Location = new Point(25, buttonLocationIndex[8]);

                        newOrderbtn.Visible = true;
                        viewOrderbtn.Visible = true;
                        editOrdersbtn.Visible = true;
                        break;

                    }
                    else //Order Processing Clerk
                    {
                        ShowButton(false);
                        orderbtn.Visible = true;
                        settingbtn.Visible = true;
                        orderbtn.Location = new Point(25, buttonLocationIndex[0]);
                        settingbtn.Location = new Point(25, buttonLocationIndex[8]);

                        newOrderbtn.Visible = true;
                        viewOrderbtn.Visible = true;
                        editOrdersbtn.Visible = true;
                        break;
                    }




                //WareHouse
                case "004":
                    ShowButton(!false);
                    stockbtn.Location = new Point(25, buttonLocationIndex[0]);
                    OrderAccemblybtn.Location = new Point(25, buttonLocationIndex[1]);
                    GRNbtn.Location = new Point(25, buttonLocationIndex[2]);
                    deliverybtn.Location = new Point(25, buttonLocationIndex[3]);
                    settingbtn.Location = new Point(25, buttonLocationIndex[8]);
                    break;




                //Purcahsing
                case "005":
                    stockbtn.Location = new Point(25, buttonLocationIndex[0]);
                    contactsbtn.Location = new Point(25, buttonLocationIndex[1]);
                    settingbtn.Location = new Point(25, buttonLocationIndex[8]);
                    break;


                //Invoice
                case "006":
                    break;

            }

        }

        private void ShowPannelButton(bool Readonly)
        {
            //Order
            newOrderbtn.Visible = Readonly;
            viewOrderbtn.Visible = Readonly;
            editOrdersbtn.Visible = Readonly;


        }

        private void ShowButton(bool ReadyOnly)
        {
            usersbtn.Visible = ReadyOnly;
            stockbtn.Visible = ReadyOnly;
            OrderAccemblybtn.Visible = ReadyOnly;
            orderbtn.Visible = ReadyOnly;
            contactsbtn.Visible = ReadyOnly;
            GRNbtn.Visible = ReadyOnly;
            deliverybtn.Visible = ReadyOnly;
            Logbtn.Visible = ReadyOnly;
            settingbtn.Visible = ReadyOnly;

            //Enabled

            //usersbtn.Visible = !ReadyOnly;
            //stockbtn.Visible = !ReadyOnly;
            //outstandingOrderbtn.Visible = !ReadyOnly;
            //orderbtn.Visible = !ReadyOnly;
            //contactsbtn.Visible = !ReadyOnly;
            //GRNbtn.Visible = !ReadyOnly;
            //deliverybtn.Visible = !ReadyOnly;
            //Logbtn.Visible = !ReadyOnly;
            //settingbtn.Visible = !ReadyOnly;
        }

        private void ShowPanel(Panel panelToShow)
        {
            orderpnl.Visible = false;
            inventorypnl.Visible = false;
            userspnl.Visible = false;
            settingpnl.Visible = false;
            dashboardpnl.Visible = false;
            contactpnl.Visible = false;
            logpnl.Visible = false;
            OrderAccemblypnl.Visible = false;
            GRNpnl.Visible = false;
            deliverypnl.Visible = false;
            POpnl.Visible = false;
            outstandingOrderpnl.Visible = false;
            invoicepnl.Visible = false;
            panelToShow.Visible = true;

        }


        //// Round Corner TextBox
        //class round : TextBox
        //{
        //    [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //    private static extern IntPtr CreateRoundRectRgn
        //    (
        //        int nLeftRect, // X-coordinate of upper-left corner or padding at start
        //        int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
        //        int nRightRect, // X-coordinate of lower-right corner or Width of the object
        //        int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
        //                        //RADIUS, how round do you want it to be?
        //        int nheightRect, //height of ellipse 
        //        int nweightRect //width of ellipse
        //    );



        //    protected override void OnResize(EventArgs e)
        //    {
        //        base.OnResize(e);
        //        this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15)); //play with these values till you are happy
        //    }

        //}



        public class TypeAssistant
        {
            public event EventHandler Idled = delegate { };
            public int WaitingMilliSeconds { get; set; }
            System.Threading.Timer waitingTimer;

            public TypeAssistant(int waitingMilliSeconds = 600)
            {
                WaitingMilliSeconds = waitingMilliSeconds;
                waitingTimer = new System.Threading.Timer(p =>
                {
                    Idled(this, EventArgs.Empty);
                });
            }
            public void TextChanged()
            {
                waitingTimer.Change(WaitingMilliSeconds, System.Threading.Timeout.Infinite);
            }
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {

            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(orderpnl);
            orderdata.DataSource = programMethod.overallOrderinfo();
            orderdata.Rows[0].Selected = false;
            string[] MinDate = programMethod.getOrderMinAndMaxDate();
            orderdateTimePicker1.MinDate = DateTime.Parse(MinDate[0]);
            orderdateTimePicker1.MaxDate = DateTime.Parse(MinDate[1]);
            orderdateTimePicker1.Value = DateTime.Parse(MinDate[0]);
            orderdateTimePicker2.MinDate = DateTime.Parse(MinDate[0]);
            orderdateTimePicker2.MaxDate = DateTime.Parse(MinDate[1]);
            orderdateTimePicker2.Value = DateTime.Parse(MinDate[1]);
            foreach (DataGridViewRow row in orderdata.Rows)
            {
                row.Height = (orderdata.ClientRectangle.Height - orderdata.ColumnHeadersHeight) / orderdata.Rows.Count;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {

            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;
            CalculateTotalPages("Stock");
            ShowPanel(inventorypnl);
            stockData.DataSource = programMethod.GetStockCurrentRecords(StockPageIndex, StockPgSize);
            productOverallLabel();
            stockData.Rows[0].Selected = false;
            //accountIndexlbl.Text = "01" + "-" + PgSize.ToString() + " of " + programMethod.getAccountRowCount();
            SetRowHeights(stockData, StockPgSize);


        }

        private void usersbtn_Click(object sender, EventArgs e)
        {

            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;
            CalculateTotalPages("Account");

            ShowPanel(userspnl);
            AccountOverallLabel();
            userData.DataSource = programMethod.GetAccountCurrentRecords(CurrentPageIndex, PgSize);
            accountSearchBox.AutoSize = false;
            userData.Rows[0].Selected = false;
            //string words = userData.Rows[0].Cells["UserID"].Value.ToString();
            //string lastTwoWords = string.Join(" ", words.Skip(words.Length - ));
            //MessageBox.Show(lastTwoWords);
            //int end = int.Parse(lastTwoWords) + 9;
            accountIndexlbl.Text = "01" + "-" + PgSize.ToString() + " of " + programMethod.getAccountRowCount();
            SetRowHeights(userData, PgSize);




        }
        //Account Label

        private void AccountOverallLabel()
        {
            int temp = programMethod.getAccountRowCount();
            accountUserCountlbl.Text = temp.ToString();
            string RowCount = programMethod.getAccountStatusCount();
            accountUserCountlbl2.Text = RowCount.ToString();
            string NewUser = programMethod.getNewUserName();
            accountUserCountlbl3.Text = NewUser.ToString();

            //accountUserCountlbl2.Text = RowCount.ToString();
        }

        private void settingbtn_Click(object sender, EventArgs e)
        {


            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(settingpnl);

        }

        private void outstandingOrderbtn_Click(object sender, EventArgs e)
        {

            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }
            CalculateTotalPages("Outstanding");
            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;
            ShowPanel(outstandingOrderpnl);
            outstandingdata.DataSource = programMethod.GetOutstandingCurrentRecords(outstandingPageIndex, outstandingPgSize);
            outstandingdata.Rows[0].Selected = false;
            SetRowHeights(outstandingdata, outstandingPgSize);



        }

        private void contactsbtn_Click(object sender, EventArgs e)
        {
            isDealerDVG = true;
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            CalculateTotalPages("Dealer");
            ShowPanel(contactpnl);
            dealersData.DataSource = programMethod.GetDealerCurrentRecords(DealerPageIndex, DealerPgSize);
            dealersData.Rows[0].Selected = false;
            newSupplierbtn.Visible = false;
            editSupplierbtn.Visible = false;
            newDealerbtn.Visible = true;
            editDealerbtn.Visible = true;
            searchSupplierbtn.Visible = false;
            searchDealerbtn.Visible = true;
            contactOverallLabel();
            SetRowHeights(dealersData, DealerPgSize);
            contactIndexlbl.Text = "01" + "-" + PgSize.ToString() + " of " + programMethod.getDealersRowCount();
            dealersData.Visible = true;
            suppliersData.Visible = false;

        }



        private void dealersbtn_Click(object sender, EventArgs e)
        {
            isDealerDVG = true;
            CalculateTotalPages("Dealer");
            dealersData.DataSource = programMethod.GetDealerCurrentRecords(DealerPageIndex, DealerPgSize);
            newSupplierbtn.Visible = false;
            editSupplierbtn.Visible = false;
            newDealerbtn.Visible = true;
            editDealerbtn.Visible = true;
            searchSupplierbtn.Visible = false;
            searchDealerbtn.Visible = true;
            currentDataSourceType = "Dealer";
            contactOverallLabel();
            SetRowHeights(dealersData, DealerPgSize);
            contactIndexlbl.Text = "01" + "-" + PgSize.ToString() + " of " + programMethod.getDealersRowCount();
            dealersData.Visible = true;
            suppliersData.Visible = false;


        }

        private void supplersbtn_Click(object sender, EventArgs e)
        {
            isDealerDVG = false;
            CalculateTotalPages("Supplier");
            suppliersData.DataSource = programMethod.GetSupplierCurrentRecords(SupplierPageIndex, SupplierPgSize);
            newDealerbtn.Visible = false;
            editDealerbtn.Visible = false;
            newSupplierbtn.Visible = true;
            editSupplierbtn.Visible = true;
            searchSupplierbtn.Visible = true;
            searchDealerbtn.Visible = false;
            currentDataSourceType = "Supplier";
            contactOverallLabel();
            SetRowHeights(suppliersData, SupplierPgSize);
            contactIndexlbl.Text = "01" + "-" + PgSize.ToString() + " of " + programMethod.getSuppliersRowCount();
            dealersData.Visible = false;
            suppliersData.Visible = true;
        }

        private void contactpnl_Paint(object sender, PaintEventArgs e)
        {

        }


        //Create Account button
        private void newAccountbtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(OperationMode.New);
            registerForm.OperationCompleted += registerFormOperationCompleted;
            registerForm.ShowDialog();
        }

        private void viewOrderbtn_Click(object sender, EventArgs e)
        {
            if (orderindex == -1)
            {
                MessageBox.Show("Please Select One Order");
            }
            else
            {
                SalesOrder salesOrder = new SalesOrder(OperationMode.View);
                salesOrder.orderView(orderID, dealerID);
                salesOrder.ShowDialog();

            }


        }

        private void newOrderbtn_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder(OperationMode.New);
            createOrder.ShowDialog();
        }

        private void editOrdersbtn_Click(object sender, EventArgs e)
        {
            if (orderindex == -1)
            {
                MessageBox.Show("Please Select One User");
            }
            else
            {
                SalesOrder salesOrder = new SalesOrder(OperationMode.Edit);
                salesOrder.orderEdit(orderID, dealerID);
                salesOrder.ShowDialog();
            }


        }


        private void editAccountbtn_Click(object sender, EventArgs e)
        {
            if (userindex == -1)
            {
                MessageBox.Show("Please Select One User");
            }
            else
            {
                RegisterForm registerForm = new RegisterForm(OperationMode.Edit);
                registerForm.OperationCompleted += registerFormOperationCompleted;
                registerForm.accountEdit(userID);
                registerForm.ShowDialog();
            }

        }

        private void registerFormOperationCompleted(object sender, EventArgs e)
        {
            userData.DataSource = programMethod.GetAccountCurrentRecords(CurrentPageIndex, PgSize);
            usersbtn.PerformClick();
        }


        private void viewAccountbtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(OperationMode.View);
            registerForm.accountEdit(userID);
            registerForm.ShowDialog();
        }

        private void Logbtn_Click(object sender, EventArgs e)

        {

            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(logpnl);
        }

        private void namelbl_Click(object sender, EventArgs e)
        {

        }


        //Account dataGridView
        private void accountSearchBtn_Click(object sender, EventArgs e)
        {
            userData.DataSource = programMethod.searchUserInformation(accountSearchBox.Text.Trim());
        }

        //Account selected dataGridView row
        private void userData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.userData.Rows[e.RowIndex].Cells["usercheckColumn"].Value = true;
                userindex = e.RowIndex;
                DataGridViewRow selectRow = this.userData.Rows[userindex];
                userID = selectRow.Cells[1].Value.ToString();
                // dealerID = selectRow.Cells[2].Value.ToString();

                foreach (DataGridViewRow row in userData.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["usercheckColumn"].Value = !Convert.ToBoolean(row.Cells["usercheckColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["usercheckColumn"].Value = false;
                    }
                }
            }

        }

        //Show datagridView of stock Data
        private void stockData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.stockData.Rows[e.RowIndex].Cells["stockcheckColumn"].Value = true;
                stockindex = e.RowIndex;
                DataGridViewRow selectRow = this.stockData.Rows[stockindex];
                productID = selectRow.Cells[1].Value.ToString();
                //  dealerID = selectRow.Cells[2].Value.ToString();

                foreach (DataGridViewRow row in stockData.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["stockcheckColumn"].Value = !Convert.ToBoolean(row.Cells["stockcheckColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["stockcheckColumn"].Value = false;
                    }
                }
            }

        }
        private void dealersdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.dealersData.Rows[e.RowIndex].Cells["dealercheckColumn"].Value = true;
                dealerindex = e.RowIndex;
                DataGridViewRow selectRow = this.dealersData.Rows[dealerindex];
                contactID = selectRow.Cells[1].Value.ToString();
                //dealerID = selectRow.Cells[2].Value.ToString();

                foreach (DataGridViewRow row in dealersData.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["dealercheckColumn"].Value = !Convert.ToBoolean(row.Cells["dealercheckColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["dealercheckColumn"].Value = false;
                    }
                }
            }
        }

        private void suppliersdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.suppliersData.Rows[e.RowIndex].Cells["suppliercheckColumn"].Value = true;
                supplierindex = e.RowIndex;
                DataGridViewRow selectRow = this.suppliersData.Rows[supplierindex];
                contactID = selectRow.Cells[1].Value.ToString();
                //dealerID = selectRow.Cells[2].Value.ToString();

                foreach (DataGridViewRow row in suppliersData.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["suppliercheckColumn"].Value = !Convert.ToBoolean(row.Cells["suppliercheckColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["suppliercheckColumn"].Value = false;
                    }
                }
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stocklbl1_Click(object sender, EventArgs e)
        {

        }

        private void viewProductbtn_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(OperationMode.View);
            productForm.productEdit(productID);
            productForm.ShowDialog();
        }



        private void orderpnl_Paint(object sender, PaintEventArgs e)
        {

        }





        //Overall of Stock Data Label
        private void productOverallLabel()
        {
            int temp = stockData.Rows.Count;
            stockProductDatalbl1.Text = temp.ToString();
            string[] numberofProduct = programMethod.getStockLabelinfo(stockData);
            stockProductDatalbl2.Text = numberofProduct[0];
            stockProductDatalbl3.Text = numberofProduct[1];
        }

        private void contactOverallLabel()
        {
            dealerDatalbl.Text = programMethod.GetDealerCount().ToString();
            supplierDatalbl.Text = programMethod.GetSupplierCount().ToString();
        }

        private void contactbtnFirstPage_Click(object sender, EventArgs e)
        {
            if (isDealerDVG)
            {
                this.DealerPageIndex = 1;
                this.dealersData.DataSource = programMethod.GetDealerCurrentRecords(DealerPageIndex, DealerPgSize);
                SetRowHeights(dealersData, DealerPgSize);
            }
            else
            {
                this.SupplierPageIndex = 1;
                this.suppliersData.DataSource = programMethod.GetSupplierCurrentRecords(SupplierPageIndex, SupplierPgSize);
                SetRowHeights(suppliersData, SupplierPgSize);
            }
        }

        private void contactbtnNxtPage_Click(object sender, EventArgs e)
        {
            if (isDealerDVG)
            {

                if (this.DealerPageIndex < this.DealerTotalPage)
                {
                    this.DealerPageIndex++;
                    this.dealersData.DataSource = programMethod.GetDealerCurrentRecords(this.DealerPageIndex, DealerPgSize);
                    SetRowHeights(dealersData, DealerPgSize);
                }
            }
            else
            {
                if (this.SupplierPageIndex < this.SupplierTotalPage)
                {
                    this.SupplierPageIndex++;
                    this.suppliersData.DataSource = programMethod.GetSupplierCurrentRecords(this.SupplierPageIndex, SupplierPgSize);
                    SetRowHeights(suppliersData, SupplierPgSize);
                }
            }
        }



        private void contactbtnPrevPage_Click(object sender, EventArgs e)
        {
            if (isDealerDVG)
            {
                if (this.DealerPageIndex > 1)
                {
                    this.DealerPageIndex--;
                    this.dealersData.DataSource = programMethod.GetDealerCurrentRecords(this.DealerPageIndex, DealerPgSize);
                    SetRowHeights(dealersData, DealerPgSize);
                }
            }
            else
            {
                if (this.SupplierPageIndex > 1)
                {
                    this.SupplierPageIndex--;
                    this.suppliersData.DataSource = programMethod.GetSupplierCurrentRecords(this.SupplierPageIndex, SupplierPgSize);
                    SetRowHeights(suppliersData, SupplierPgSize);
                }
            }
        }

        private void contactbtnLastPage_Click(object sender, EventArgs e)
        {
            if (isDealerDVG)
            {
                this.DealerPageIndex = DealerTotalPage;
                this.dealersData.DataSource = programMethod.GetDealerCurrentRecords(this.DealerPageIndex, DealerPgSize);
                SetRowHeights(dealersData, DealerPgSize);

            }
            else
            {
                this.SupplierPageIndex = SupplierTotalPage;
                this.suppliersData.DataSource = programMethod.GetSupplierCurrentRecords(this.SupplierPageIndex, SupplierPgSize);
                SetRowHeights(suppliersData, SupplierPgSize);
            }

        }

        private void inventorylbl_Click(object sender, EventArgs e)
        {

        }

        // Create product button
        private void newProductbtn_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(OperationMode.New);
            productForm.StartPosition = FormStartPosition.CenterScreen;
            productForm.ShowDialog();
        }

        private void userbtn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void stockData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_LostFocus(object sender, EventArgs e)
        {

            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = SystemColors.Control;
            }
        }

        private void listpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isFormDragging = true;
                formStartPoint = e.Location;
            }
        }

        private void Dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            isFormDragging = false;

        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (isFormDragging)
            {
                int deltaX = e.X - formStartPoint.X;
                int deltaY = e.Y - formStartPoint.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void disableAccountbtn_Click(object sender, EventArgs e)
        {
            if (userindex == -1)
            {
                MessageBox.Show("Please Select One User");
            }
            else
            {

                programMethod.disableUserAccount(userID);
                MessageBox.Show("This account disabled");
                usersbtn.PerformClick();
            }
        }

        private void enableAccountbtn_Click(object sender, EventArgs e)
        {
            if (userindex == -1)
            {
                MessageBox.Show("Please Select One User");
            }
            else
            {

                programMethod.enableUserAccount(userID);
                MessageBox.Show("This account enabled");
                usersbtn.PerformClick();
            }
        }

        public void currentUserDisplayName(string displayName, string department)
        {
            namelbl.Text = displayName;
            usertypelbl.Text = department;
        }

        public void currentUserDepartment(string department)
        {
            usertypelbl.Text = department;
        }

        private void editProductbtn_Click(object sender, EventArgs e)
        {
            if (stockindex == -1)
            {
                MessageBox.Show("Please Select One Option");
            }
            else
            {
                ProductForm ProductForm = new ProductForm(OperationMode.Edit);
                ProductForm.productEdit(productID);
                ProductForm.ShowDialog();

            }
        }

        private void GRNbtn_Click(object sender, EventArgs e)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(GRNpnl);
            grndata.DataSource = programMethod.overallGRNinfo();
            grndata.Rows[0].Selected = false;

        }

        private void deliverybtn_Click(object sender, EventArgs e)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(deliverypnl);
            deliveryData.DataSource = programMethod.overallDeliveryinfo();
            deliveryData.Rows[0].Selected = false;
        }

        private void delProductbtn_Click(object sender, EventArgs e)
        {
            if (stockindex == -1)
            {
                MessageBox.Show("Please Select One Option");
            }
            else
            {

                programMethod.productDel(productID);

            }
        }

        private void orderdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.orderdata.Rows[e.RowIndex].Cells["ordercheckColumn"].Value = true;
                orderindex = e.RowIndex;
                DataGridViewRow selectRow = this.orderdata.Rows[orderindex];
                orderID = selectRow.Cells[1].Value.ToString();
                dealerID = selectRow.Cells[2].Value.ToString();

                foreach (DataGridViewRow row in orderdata.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["ordercheckColumn"].Value = !Convert.ToBoolean(row.Cells["ordercheckColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["ordercheckColumn"].Value = false;
                    }
                }
            }

        }




        private void grnSearchBtn_Click(object sender, EventArgs e)
        {
            string formDate = grnDatePicker1.Value.Date.ToString("yyyy-MM-dd");
            string toDate = grnDatePicker2.Value.Date.ToString("yyyy-MM-dd");
            grndata.DataSource = programMethod.searchGRNDate(formDate, toDate);

        }

        private void grnclearBtn_Click(object sender, EventArgs e)
        {
            grndata.DataSource = programMethod.overallGRNinfo();


        }

        private void grnAddNoteBtn_Click(object sender, EventArgs e)
        {
            GRN grn = new GRN(OperationMode.New);
            grn.ShowDialog();
        }
        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            stockData.DataSource = programMethod.searchProductInformation(stockSearchBox.Text.Trim());
        }

        void assistant_Idled(object sender, EventArgs e)
        {
            this.Invoke(
            new System.Windows.Forms.MethodInvoker(() =>
            {
                stockData.DataSource = programMethod.searchProductInformation(stockSearchBox.Text.Trim());
            }));
        }


        private void stockSearchBox_TextChanged(object sender, EventArgs e)
        {
            assistant.TextChanged();
        }

        private void orderdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deliverySearchDatebtn_Click(object sender, EventArgs e)
        {
            string formDate = deliverydateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            string toDate = deliverydateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            deliveryData.DataSource = programMethod.searchDeliveryDate(formDate, toDate);
        }

        private void newDealerbtn_Click(object sender, EventArgs e)
        {

            DealerContactForm dealerContactForm = new DealerContactForm(OperationMode.New);
            dealerContactForm.ShowDialog();

        }

        private void editDealerbtn_Click(object sender, EventArgs e)
        {
            if (dealerindex == -1)
            {
                MessageBox.Show("Please Select One Option");
            }
            else
            {

                DealerContactForm dealerContactForm = new DealerContactForm(OperationMode.Edit);
                dealerContactForm.dealerEdit(contactID);
                dealerContactForm.ShowDialog();
            }
        }

        private void contactsdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void delContactbtn_Click(object sender, EventArgs e)
        {


            if (dealerindex == -1 && supplierindex == -1)
            {
                MessageBox.Show("Please Select One Option");
            }
            else
            {



                if (currentDataSourceType == "Dealer")
                {
                    programMethod.dealerDel(contactID);
                    dealersbtn.PerformClick();
                }
                else if (currentDataSourceType == "Supplier")
                {
                    programMethod.supplierDel(contactID);
                    supplersbtn.PerformClick();
                }

            }


        }


        private void newSupplierbtn_Click(object sender, EventArgs e)
        {
            SupplierContactForm supplierContactForm = new SupplierContactForm(OperationMode.New);
            supplierContactForm.ShowDialog();
        }

        private void editSupplierbtn_Click(object sender, EventArgs e)
        {
            if (supplierindex == -1)
            {
                MessageBox.Show("Please Select One Option");
            }
            else
            {

                SupplierContactForm supplierContactForm = new SupplierContactForm(OperationMode.Edit);
                supplierContactForm.supplierEdit(contactID);
                supplierContactForm.ShowDialog();

            }
        }


        private void searchDealerbtn_Click(object sender, EventArgs e)
        {
            dealersData.DataSource = programMethod.searchDealerInformation(searchContactbtn.Text.Trim());
        }

        private void searchSupplierbtn_Click(object sender, EventArgs e)
        {
            dealersData.DataSource = programMethod.searchSupplierInformation(searchContactbtn.Text.Trim());
        }

        private void deliveryclearbtn_Click(object sender, EventArgs e)
        {
            deliveryData.DataSource = programMethod.overallDeliveryinfo();
        }

        private void deliveryAddbtn_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery(OperationMode.New);
            delivery.ShowDialog();
        }

        private void deliverySearchIDbtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void deliverySearchIDbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                deliveryData.DataSource = programMethod.getDeliveryDetails(deliverySearchIDbox.Text.Trim());
            }
        }

        private void deliveryclearbtn_Click_1(object sender, EventArgs e)
        {
            deliveryData.DataSource = programMethod.overallDeliveryinfo();
        }

        private void deliveryAddbtn_Click_1(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery(OperationMode.New);
            delivery.ShowDialog();
        }

        private void deliveryData_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.deliveryData.Rows[e.RowIndex].Cells["deliverycheckColumn"].Value = true;
                deliveryindex = e.RowIndex;
                DataGridViewRow selectRow = this.deliveryData.Rows[deliveryindex];
                DeliverydeliveryID = selectRow.Cells[1].Value.ToString();
                DeliveryorderID = selectRow.Cells[2].Value.ToString();



                foreach (DataGridViewRow row in deliveryData.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["deliverycheckColumn"].Value = !Convert.ToBoolean(row.Cells["deliverycheckColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["deliverycheckColumn"].Value = false;
                    }
                }
            }
        }

        private void grndata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.grndata.Rows[e.RowIndex].Cells["grncheckColumn"].Value = true;
                grnindex = e.RowIndex;
                DataGridViewRow selectRow = this.grndata.Rows[grnindex];
                grnID = selectRow.Cells[1].Value.ToString();
                productID = selectRow.Cells[2].Value.ToString();

                foreach (DataGridViewRow row in grndata.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["grncheckColumn"].Value = !Convert.ToBoolean(row.Cells["grncheckColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["grncheckColumn"].Value = false;
                    }
                }
            }
        }

        private void deliveryData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.deliveryData.Rows[e.RowIndex].Cells["deliverycheckColumn"].Value = true;
                deliveryindex = e.RowIndex;
                DataGridViewRow selectRow = this.deliveryData.Rows[deliveryindex];
                deliveryID = selectRow.Cells[1].Value.ToString();
                // deliveryID = selectRow.Cells[2].Value.ToString();

                foreach (DataGridViewRow row in deliveryData.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["deliverycheckColumn"].Value = !Convert.ToBoolean(row.Cells["deliverycheckColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["deliverycheckColumn"].Value = false;
                    }
                }
            }
        }

        private void userData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void accountSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateTotalPages(string function)
        {
            int rowCount = 0;
            switch (function)
            {
                case "Stock":
                    rowCount = programMethod.getStockRowCount();
                    StockTotalPage = rowCount / StockPgSize;
                    if (rowCount % StockPgSize > 0)
                        StockTotalPage += 1;
                    break;

                case "Outstanding":
                    rowCount = programMethod.getOutstandingRowCount();
                    outstandingTotalPage = rowCount / outstandingPgSize;
                    if (rowCount % outstandingPgSize > 0)
                        outstandingTotalPage += 1;
                    break;

                case "Order":
                    rowCount = programMethod.getOrderRowCount();
                    //outstandingTotalPage = rowCount / outstandingPgSize;
                    break;

                case "Account":
                    rowCount = programMethod.getAccountRowCount();
                    TotalPage = rowCount / PgSize;
                    if (rowCount % PgSize > 0)
                        TotalPage += 1;
                    break;

                case "Delivery":
                    //rowCount = programMethod.getAccountRowCount();
                    //TotalPage = rowCount / PgSize;
                    break;


                case "GRN":
                    //rowCount = programMethod.getAccountRowCount();
                    //TotalPage = rowCount / PgSize;
                    break;

                case "OrderAccembly":
                    //rowCount = programMethod.getAccountRowCount();
                    //TotalPage = rowCount / PgSize;
                    break;


                case "Dealer":
                    rowCount = programMethod.GetDealerCount();
                    DealerTotalPage = rowCount / DealerPgSize;
                    if (rowCount % DealerPgSize > 0)
                        DealerTotalPage += 1;
                    break;


                case "Supplier":
                    rowCount = programMethod.GetSupplierCount();
                    SupplierTotalPage = rowCount / SupplierPgSize;
                    if (rowCount % SupplierPgSize > 0)
                        SupplierTotalPage += 1;
                    break;

            }
        }

        private void accountbtnFirstPage_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = 1;
            this.userData.DataSource = programMethod.GetAccountCurrentRecords(this.CurrentPageIndex, PgSize);
            SetRowHeights(userData, PgSize);
        }

        private void accountbtnNxtPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex < this.TotalPage)
            {
                this.CurrentPageIndex++;
                this.userData.DataSource = programMethod.GetAccountCurrentRecords(this.CurrentPageIndex, PgSize);

            }
            SetRowHeights(userData, PgSize);
        }



        private void accountbtnPrevPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
                this.userData.DataSource = programMethod.GetAccountCurrentRecords(this.CurrentPageIndex, PgSize);

            }
            SetRowHeights(userData, PgSize);
        }

        private void accountbtnLastPage_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = TotalPage;
            this.userData.DataSource = programMethod.GetAccountCurrentRecords(this.CurrentPageIndex, PgSize);
            SetRowHeights(userData, PgSize);
        }

        private void deliveryViewDNbtn_Click(object sender, EventArgs e)
        {
            if (deliveryindex == -1)
            {
                MessageBox.Show("Please Select One Delivery");
            }
            else
            {
                DeliveryForm deliveryFrom = new DeliveryForm();
                deliveryFrom.viewDeliveryNote(DeliverydeliveryID, DeliveryorderID);
                deliveryFrom.ShowDialog();
            }
        }

        private void orderAccemblyData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.orderAccemblyData.Rows[e.RowIndex].Cells["orderAccemblyColumn"].Value = true;
                orderAceemblyindex = e.RowIndex;
                DataGridViewRow selectRow = this.orderAccemblyData.Rows[orderAceemblyindex];
                orderAccemblyOrderID = selectRow.Cells[1].Value.ToString();
                orderAccemblyDealerID = selectRow.Cells[2].Value.ToString();

                foreach (DataGridViewRow row in orderAccemblyData.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["orderAccemblyColumn"].Value = !Convert.ToBoolean(row.Cells["orderAccemblyColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["orderAccemblyColumn"].Value = false;
                    }
                }
            }
        }

        private void orderAccemblyViewbtn_Click(object sender, EventArgs e)
        {
            if (orderAceemblyindex == -1)
            {
                MessageBox.Show("Please Select One Order");
            }
            else
            {
                OrderAccembly orderAccembly = new OrderAccembly(OperationMode.View, orderAccemblyOrderID, orderAccemblyDealerID);
                orderAccembly.ShowDialog();

            }
        }

        private void orderAccemblySearchbtn_Click(object sender, EventArgs e)
        {

        }

        private void accemblyCreatebtn_Click(object sender, EventArgs e)
        {
            if (orderAceemblyindex == -1)
            {
                MessageBox.Show("Please Select One Order");
            }
            else
            {
                OrderAccembly orderAccembly = new OrderAccembly(OperationMode.New, orderAccemblyOrderID, orderAccemblyDealerID);
                orderAccembly.ShowDialog();

            }
        }

        private void PObtn_Click(object sender, EventArgs e)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(POpnl);

        }

        private void invoicebtn_Click(object sender, EventArgs e)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(invoicepnl);

        }

        private void sotckLastPagebtn_Click(object sender, EventArgs e)
        {
            this.StockPageIndex = StockTotalPage;
            this.stockData.DataSource = programMethod.GetStockCurrentRecords(this.StockPageIndex, StockPgSize);
            SetRowHeights(stockData, StockPgSize);
        }

        private void sotckNextPagebtn_Click(object sender, EventArgs e)
        {
            if (this.StockPageIndex < this.StockTotalPage)
            {
                this.StockPageIndex++;
                this.stockData.DataSource = programMethod.GetStockCurrentRecords(this.StockPageIndex, StockPgSize);
                SetRowHeights(stockData, StockPgSize);
            }
        }

        private void sotckPrevPagebtn_Click(object sender, EventArgs e)
        {
            if (this.StockPageIndex > 1)
            {
                this.StockPageIndex--;
                this.stockData.DataSource = programMethod.GetStockCurrentRecords(this.StockPageIndex, StockPgSize);
                SetRowHeights(stockData, StockPgSize);
            }
        }

        private void stockFirstPagebtn_Click(object sender, EventArgs e)
        {
            this.StockPageIndex = 1;
            this.stockData.DataSource = programMethod.GetStockCurrentRecords(this.StockPageIndex, StockPgSize);
            SetRowHeights(stockData, StockPgSize);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public void SetRowHeights(DataGridView Data, int pageSize)
        {
            foreach (DataGridViewRow row in Data.Rows)
            {
                row.Height = (Data.ClientRectangle.Height - Data.ColumnHeadersHeight) / pageSize;
            }
        }

        private void outstandingLastPagebtn_Click(object sender, EventArgs e)
        {
            this.outstandingPageIndex = outstandingTotalPage;
            this.outstandingdata.DataSource = programMethod.GetOutstandingCurrentRecords(this.outstandingPageIndex, outstandingPgSize);
            SetRowHeights(outstandingdata, outstandingPgSize);
        }

        private void outstandingNextPagebtn_Click(object sender, EventArgs e)
        {
            if (this.outstandingPageIndex < this.outstandingTotalPage)
            {
                this.outstandingPageIndex++;
                this.outstandingdata.DataSource = programMethod.GetOutstandingCurrentRecords(this.outstandingPageIndex, outstandingPgSize);
                SetRowHeights(outstandingdata, outstandingPgSize);
            }
        }

        private void outstandingPrevPagebtn_Click(object sender, EventArgs e)
        {
            if (this.outstandingPageIndex > 1)
            {
                this.outstandingPageIndex--;
                this.outstandingdata.DataSource = programMethod.GetOutstandingCurrentRecords(this.outstandingPageIndex, outstandingPgSize);
                SetRowHeights(outstandingdata, outstandingPgSize);
            }
        }

        private void outstandingFirstPagebtn_Click(object sender, EventArgs e)
        {
            this.outstandingPageIndex = 1;
            this.outstandingdata.DataSource = programMethod.GetOutstandingCurrentRecords(this.outstandingPageIndex, outstandingPgSize);
            SetRowHeights(outstandingdata, outstandingPgSize);
        }


        private void pageNumlbl_Click(object sender, EventArgs e)
        {

        }

        private void orderSearchbox_TextChanged(object sender, EventArgs e)
        {
            orderdata.DataSource = programMethod.searchOrder(orderStatusCombox.Text.Trim());
        }

        private void orderSearchbtn_Click(object sender, EventArgs e)
        {
            string formDate = orderdateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            string toDate = orderdateTimePicker1.Value.Date.ToString("yyyy-MM-dd");


            if (orderStatusCombox.SelectedIndex == -1)
                orderdata.DataSource = programMethod.orderDateFilter(formDate, toDate);
            else
            {
                string status = orderStatusCombox.Text.ToString();
                Debug.WriteLine(orderStatusCombox.Text.ToString());
                orderdata.DataSource = programMethod.orderDateStatusFilter(formDate, toDate, status);
            }
        }

        private void orderClearbtn_Click(object sender, EventArgs e)
        {
            orderdata.DataSource = programMethod.overallOrderinfo();
        }

        private void orderCancelbtn_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Do you want to delete #" + orderID + " ?", "Cancel Order", MessageBoxButtons.YesNo);
            switch (box)
            {
                case DialogResult.Yes:
                    if (programMethod.cancelOrder(orderID))
                        OrderLoad();
                    break;
                case DialogResult.No:
                    break;
            }
        }


        private void OrderLoad()
        {
            orderdata.DataSource = programMethod.overallOrderinfo();
            foreach (DataGridViewRow row in orderdata.Rows)
            {
                row.Height = (orderdata.ClientRectangle.Height - orderdata.ColumnHeadersHeight) / orderdata.Rows.Count;
            }
            orderdata.Rows[0].Selected = false;

        }

        private void deliveryCompletebtn_Click(object sender, EventArgs e)
        {
            string deliveredDate = DeliverydeliveredDate.Value.Date.ToString("yyyy-MM-dd");

            if (deliveryindex == -1)
            {
                MessageBox.Show("Please Select One Delivery");
            }
            else if (deliveredDate == "")
            {
                MessageBox.Show("Please Select Date");
                return;
            }
            else
            {
                programMethod.updateDeliveryStatus(DeliverydeliveryID, deliveredDate);
                MessageBox.Show("Save");
            }
        }

        private void deliveryBackbtn_Click(object sender, EventArgs e)
        {
            ShowPanel(deliverypnl);
            deliveryCompletepnl.Visible = false;
        }

        private void deliverypnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deliverycompletedeliverybtn_Click(object sender, EventArgs e)
        {
            if (deliveryindex == -1)
            {
                MessageBox.Show("Please Select One Delivery");
            }
            else
            {

                ShowPanel(deliveryCompletepnl);
                deliveryDeliveryIDlbl.Text = "Delivery ID : # " + DeliverydeliveryID.ToString();

            }
        }

        private void outstandingViewbtn_Click(object sender, EventArgs e)
        {
            if (outstandingIndex == -1)
            {
                MessageBox.Show("Please Select One Outstanding");
            }
            else
            {

                ShowPanel(outstandingViewpnl);
                //deliveryDeliveryIDlbl.Text = "Delivery ID : # " + DeliverydeliveryID.ToString();
                DataTable dt = programMethod.getOutstandingOrder(outstandingOrderID);
                outstandingIDlbl.Text = "Outstanding ID : #" + outstandingOrderID;
                outstandingOrderIDlbl.Text = "Order ID :  # " + dt.Rows[0]["OrderID"].ToString();
                outstandingDealerIDlbl.Text = "Dealer ID : " + dt.Rows[0]["DealerID"].ToString();
                outstandingDealerNamelbl.Text = "Delaer Name : " + dt.Rows[0]["DealerName"].ToString();
                outstandingViewData.Rows.Add(dt.Rows[0]["ProductID"].ToString(), dt.Rows[0]["ProductName"].ToString(), dt.Rows[0]["FollowUpQuantity"].ToString(), dt.Rows[0]["UnitPrice"].ToString());
            }
        }
        private void outstandingdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                this.outstandingdata.Rows[e.RowIndex].Cells["outstandingcheckColumn"].Value = true;
                outstandingIndex = e.RowIndex;
                DataGridViewRow selectRow = this.outstandingdata.Rows[outstandingIndex];
                outstandingOrderID = selectRow.Cells[1].Value.ToString();

                foreach (DataGridViewRow row in outstandingdata.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["outstandingcheckColumn"].Value = !Convert.ToBoolean(row.Cells["outstandingcheckColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["outstandingcheckColumn"].Value = false;
                    }
                }
            }
        }


        private void outstandingdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (outstandingdata.Columns[e.ColumnIndex].Name != "outstandingcheckColumn")
            {
                outstandingdata.Columns[e.ColumnIndex].ReadOnly = true;

            }
        }

        private void outstandingBackbtn_Click(object sender, EventArgs e)
        {
            ShowPanel(outstandingOrderpnl);
            outstandingViewpnl.Visible = false;
        }

        private void suppliersData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderAccemblybtn_Click(object sender, EventArgs e)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            orderAccemblyData.DataSource = programMethod.overallOrderinfo();

            ShowPanel(OrderAccemblypnl);
        }

        private void poLastPagebtn_Click(object sender, EventArgs e)
        {

        }

        private void poFirstPageBtn_Click(object sender, EventArgs e)
        {

        }

        private void poPrevPageBtn_Click(object sender, EventArgs e)
        {

        }

        private void poNextPageBtn_Click(object sender, EventArgs e)
        {

        }






        //    private void PopulatePager(int recordCount, int currentPage)
        //    {
        //        List<Page> pages = new List<Page>();
        //        int startIndex, endIndex;
        //        int pagerSpan = 10;

        //        //Calculate the Start and End Index of pages to be displayed.
        //        double dblPageCount = (double)((decimal)recordCount / Convert.ToDecimal(PageSize));
        //        int pageCount = (int)Math.Ceiling(dblPageCount);
        //        //startIndex = currentPage > 1 && currentPage + pagerSpan - 1 < pagerSpan ? currentPage : 1;
        //        //endIndex = pageCount > pagerSpan ? pagerSpan : pageCount;
        //        startIndex = currentPage > pagerSpan / 2 && currentPage + pagerSpan / 2 < pageCount ? currentPage - pagerSpan / 2 : 1;
        //        endIndex = Math.Min(startIndex + pagerSpan - 1, pageCount);
        //        if (currentPage > pagerSpan % 2)
        //        {
        //            //if (currentPage == 2)
        //            //{
        //            //    endIndex = 2;
        //            //}
        //            //else
        //            //{
        //            //    endIndex = currentPage + 2;
        //            //}
        //        }
        //        else
        //        {
        //            endIndex = (pagerSpan - currentPage) + 1;
        //        }

        //        if (endIndex - (pagerSpan - 1) > startIndex)
        //        {
        //            startIndex = endIndex - (pagerSpan - 1);
        //        }

        //        if (endIndex > pageCount)
        //        {
        //            endIndex = pageCount;
        //            startIndex = ((endIndex - pagerSpan) + 1) > 0 ? (endIndex - pagerSpan) + 1 : 1;
        //        }

        //        //Add the First Page Button.
        //        if (currentPage > 1)
        //        {
        //            pages.Add(new Page { Text = "First", Value = "1" });
        //        }

        //        //Add the Previous Button.
        //        if (currentPage > 1)
        //        {
        //            pages.Add(new Page { Text = "<<", Value = (currentPage - 1).ToString() });
        //        }

        //        for (int i = startIndex; i < endIndex; i++)
        //        {
        //            pages.Add(new Page { Text = i.ToString(), Value = i.ToString(), Selected = i == currentPage });
        //        }

        //        //Add the Next Button.
        //        if (currentPage < pageCount)
        //        {
        //            pages.Add(new Page { Text = ">>", Value = (currentPage + 1).ToString() });
        //        }

        //        //Add the Last Button.
        //        if (currentPage != pageCount)
        //        {
        //            pages.Add(new Page { Text = "Last", Value = pageCount.ToString() });
        //        }

        //        //Clear existing Pager Buttons.
        //        accountPaginationpnl.Controls.Clear();

        //        //Loop and add Buttons for Pager.
        //        int count = 0;
        //        foreach (Page page in pages)
        //        {
        //            ProgramMethod.ProgramMethod.RoundedButton btnPage = new ProgramMethod.ProgramMethod.RoundedButton();
        //            btnPage.Location = new System.Drawing.Point(60 * count, 5);
        //            btnPage.Size = new System.Drawing.Size(63, 33);
        //            btnPage.Name = page.Value;
        //            btnPage.Text = page.Text;
        //            btnPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        //           // btnPage.Enabled = !page.Selected;
        //            btnPage.BackColor = SystemColors.Menu;
        //            btnPage.BackColor2 = Color.White;
        //            btnPage.BorderColor = Color.Tomato;
        //            btnPage.BorderSize = 2;
        //            btnPage.ButtonBorderColor = Color.Gray;
        //            btnPage.ButtonHighlightColor = Color.Empty;
        //            btnPage.ButtonHighlightColor2 = Color.Empty;
        //            btnPage.ButtonHighlightForeColor = Color.Black;
        //            btnPage.ButtonPressedColor = Color.White;
        //            btnPage.ButtonPressedColor2 = Color.Empty;
        //            btnPage.ButtonPressedForeColor = Color.Gray;
        //            btnPage.ButtonRoundRadius = 15;
        //            btnPage.Click += new System.EventHandler(this.Page_Click);
        //            accountPaginationpnl.Controls.Add(btnPage);
        //            count++;
        //        }
        //    }

        //    private void Page_Click(object sender, EventArgs e)
        //    {
        //        ProgramMethod.ProgramMethod.RoundedButton btnPager = (sender as ProgramMethod.ProgramMethod.RoundedButton);
        //        this.BindGrid(int.Parse(btnPager.Name));
        //    }

        //    public class Page
        //    {
        //        public string Text { get; set; }
        //        public string Value { get; set; }
        //        public bool Selected { get; set; }
        //    }






        //    private void BindGrid(int pageIndex)
        //    {
        //        this.userData.DataSource = programMethod.GetAccountCurrentRecords(pageIndex, PgSize2);
        //        int rowCount = programMethod.getAccountRowCount();
        //        this.PopulatePager(rowCount, CurrentPageIndex2);
        //    }

        //    private int PgSize2 = 10;
        //    private int CurrentPageIndex2 = 1;
        //    private int TotalPage2 = 0;

        //}
    }
}
    