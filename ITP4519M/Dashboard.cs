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
using System.Security.Policy;
using System.Net.NetworkInformation;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using ZstdSharp.Unsafe;



namespace ITP4519M
{
    public enum OperationMode
    {
        View,
        New,
        Edit,
    }
    public partial class Dashboard : Form
    {

        private ProgramMethod.ProgramMethod programMethod;

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


        //PO datagrid paging
        private int POPgSize = 15;
        private int POPageIndex = 1;
        private int POTotalPage = 0;
        //Paging

        //Invoice datagrid paging
        private int InvoicePgSize = 15;
        private int InvoicePageIndex = 1;
        private int InvoiceTotalPage = 0;
        //Paging

        //Invoice datagrid paging
        private int GRNPgSize = 10;
        private int GRNPageIndex = 1;
        private int GRNTotalPage = 0;
        //Paging

        //Invoice datagrid paging
        private int DespatchPgSize = 10;
        private int DespatchPageIndex = 1;
        private int DespatchTotalPage = 0;
        //Paging

        //Order datagrid paging
        private int OrderPgSize = 15;
        private int OrderPageIndex = 1;
        private int OrderTotalPage = 0;
        //Paging
        private bool IsZoomIN = false;
        private Button currentButton;
        private string userID;
        private string LoginUserID;
        private string LoginUserName;
        private string productID;
        private string stockproductID;
        private string orderID;
        private string grnID;
        private string dealerID;
        private string deliveryID;
        private string DeliverydeliveryID;
        private string DeliveryorderID;
        private string contactID;
        private string outstandingOrderID;
        private string outOrderID;
        private string outproductID;
        private string orderAccemblyOrderID;
        private string orderAccemblyDealerID;
        private string invoiceID;
        private string invoiceOrderID;
        private string invoiceDealerID;
        private string invoiceDeliveryID;
        private string invoiceDate;
        private string poID;
        private string[] array;
        private bool isDealerDVG;
        private bool isOrderFilter = false;
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
        private int POIndex = -1;
        private int orderAceemblyindex = -1;
        private int outstandingIndex = -1;
        private int outstandingTotalIndex = -1;
        private int invoiceIndex = -1;
        private string currentDataSourceType = "";
        private int OutstandingRowCount;
        private int AccountRowCount;
        private int SupplierRowCount;

        private int DealerRowCount;
        private int PORowCount;
        private int DeliveryRowCount;
        private int OrderRowCount;
        private int GRNRowCount;
        private int OrderAccemblyRowCount;
        private int InvoiceRowCount;
        private int StockRowCount;
        private Button lastClickedButton = null;
        private Button[] buttons = new Button[2];
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private int[] buttonLocationIndex = [229, 300, 371, 440, 509, 580, 651, 720, 789];

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Dashboard()
        {

            InitializeComponent();
            ShowPanel(dashboardpnl);

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

        }



        private void InitializeButtons()
        {
            buttons[0] = usersbtn;
            buttons[1] = stockbtn;
            buttons[2] = orderbtn;
            buttons[3] = contactsbtn;
            buttons[4] = Logbtn;
            buttons[5] = logoutbtn;

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            DoubleBuffered = true;
            programMethod = new ProgramMethod.ProgramMethod();
            IntPtr handle = CreateRoundRectRgn(0, 0, Width, Height, 40, 40);
            Region = System.Drawing.Region.FromHrgn(handle);
            DoubleBuffered = true;

            programMethod.CurrentUserIDAndName(LoginUserID, LoginUserName);
            OrderAccemblybtn.Size = new System.Drawing.Size(166, 56);
            contactsbtn.Size = new System.Drawing.Size(166, 56);
            namelbl.Size = new System.Drawing.Size(194, 33);
            usertypelbl.Size = new System.Drawing.Size(191, 33);
            outstandingOrderbtn.Size = new System.Drawing.Size(166, 56);
            PObtn.Size = new System.Drawing.Size(166, 56);
            string[] array = programMethod.getDashboardToadyLabel();
            dashOrderlbl.Text = array[0];
            dashOutlbl.Text = array[1];
            dashInlbl.Text = array[2];
            DataTable CategoryAOrderQuantity = programMethod.getCategoryAOrderQuantity();
            DataTable CategoryBOrderQuantity = programMethod.getCategoryBOrderQuantity();
            DataTable CategoryCOrderQuantity = programMethod.getCategoryCOrderQuantity();
            DataTable CategoryDOrderQuantity = programMethod.getCategoryDOrderQuantity();
            DataTable dataTable = new DataTable();

            // Assuming you have DataTables for each category
            DataTable unifiedTable = new DataTable();
            unifiedTable.Columns.Add("orderDate", typeof(DateTime));
            unifiedTable.Columns.Add("Category", typeof(string));
            unifiedTable.Columns.Add("OrderQuantity", typeof(int));
            unifiedTable.Columns.Add("SUM", typeof(int));

            void AddCategoryData(DataTable sourceTable, string category, string dateColumn, string quantityColumn, string sumColumn)
            {
                foreach (DataRow row in sourceTable.Rows)
                {
                    DataRow newRow = unifiedTable.NewRow();
                    newRow["orderDate"] = row[dateColumn];
                    newRow["Category"] = category;
                    newRow["OrderQuantity"] = row[quantityColumn];
                    newRow["SUM"] = row[sumColumn];
                    unifiedTable.Rows.Add(newRow);
                }
            }

            // Add data from each category table
            AddCategoryData(CategoryAOrderQuantity, "A-Sheet Metal", "orderDateA", "OrderQuantityA", "SUMA");
            AddCategoryData(CategoryBOrderQuantity, "B-Major Assemblies", "orderDateB", "OrderQuantityB", "SUMB");
            AddCategoryData(CategoryCOrderQuantity, "C-Light Components", "orderDateC", "OrderQuantityC", "SUMC");
            AddCategoryData(CategoryDOrderQuantity, "D-Accessories", "orderDateD", "OrderQuantityD", "SUMD");

            // Set chart data source
            dashordervalueChart.DataSource = null; // Clear any existing data source

            // Add series to the chart manually
            void AddSeriesToChart(Chart chart, string seriesName, SeriesChartType chartType, Color color, AxisType yAxisType)
            {
                Series series = new Series(seriesName)
                {
                    ChartType = chartType,
                    Color = color,
                    XValueType = ChartValueType.DateTime,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8,
                    YAxisType = yAxisType
                };
                chart.Series.Add(series);
            }

            // Add series to the chart
            AddSeriesToChart(dashordervalueChart, "A-Sheet Metal Quantity", SeriesChartType.Line, Color.Black, AxisType.Primary);
            AddSeriesToChart(dashordervalueChart, "B-Major Assemblies Quantity", SeriesChartType.Line, Color.Blue, AxisType.Primary);
            AddSeriesToChart(dashordervalueChart, "C-Light Components Quantity", SeriesChartType.Line, Color.Brown, AxisType.Primary);
            AddSeriesToChart(dashordervalueChart, "D-Accessories Quantity", SeriesChartType.Line, Color.Red, AxisType.Primary);

            AddSeriesToChart(dashordervalueChart, "A-Sheet Metal Sum", SeriesChartType.Line, Color.DarkGray, AxisType.Secondary);
            AddSeriesToChart(dashordervalueChart, "B-Major Assemblies Sum", SeriesChartType.Line, Color.LightBlue, AxisType.Secondary);
            AddSeriesToChart(dashordervalueChart, "C-Light Components Sum", SeriesChartType.Line, Color.SandyBrown, AxisType.Secondary);
            AddSeriesToChart(dashordervalueChart, "D-Accessories Sum", SeriesChartType.Line, Color.Pink, AxisType.Secondary);

            // Manually add data points to each series
            foreach (DataRow row in unifiedTable.Rows)
            {
                DateTime date = (DateTime)row["orderDate"];
                int orderQuantity = (int)row["OrderQuantity"];
                int sum = (int)row["SUM"];
                string category = row["Category"].ToString();

                // Add data points to the correct series
                dashordervalueChart.Series[category + " Quantity"].Points.AddXY(date, orderQuantity);
                dashordervalueChart.Series[category + " Sum"].Points.AddXY(date, sum);
            }

            // Customize chart area
            ChartArea chartArea = dashordervalueChart.ChartAreas[0];
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Days;
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.Title = "Date";

            // Customize primary Y-axis (OrderQuantity)
            chartArea.AxisY.Interval = 50;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = 300;
            chartArea.AxisY.Title = "Order Quantity";

            // Customize secondary Y-axis (SUM)
            chartArea.AxisY2.Enabled = AxisEnabled.True;
            chartArea.AxisY2.Interval = 100;
            chartArea.AxisY2.Minimum = 0;
            chartArea.AxisY2.Maximum = 1000;
            chartArea.AxisY2.MajorGrid.Enabled = false; // Disable gridlines for clarity

            chartArea.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea.AxisY.ScaleBreakStyle.BreakLineStyle = BreakLineStyle.Wave;
            chartArea.AxisY.ScaleBreakStyle.CollapsibleSpaceThreshold = 50;
            chartArea.AxisY.ScaleBreakStyle.Spacing = 2; // Spacing between the scale breaks



            // Apply axis breaks to emphasize the 0-100 range on the
            if (Owner != null)
                Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2,
                    Owner.Location.Y + Owner.Height / 2 - Height / 2);
        }


        public void ButtonLocation(string departmentID, string title)
        {
            switch (departmentID)
            {
                //IT
                case "001":
                    ShowButton(false);
                    usersbtn.Visible = true;
                    logoutbtn.Visible = true;
                    usersbtn.Location = new Point(25, buttonLocationIndex[0]);
                    logoutbtn.Location = new Point(25, buttonLocationIndex[8]);
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
                        logoutbtn.Visible = true;
                        orderbtn.Location = new Point(25, buttonLocationIndex[0]);
                        OrderAccemblybtn.Location = new Point(25, buttonLocationIndex[1]);
                        logoutbtn.Location = new Point(25, buttonLocationIndex[8]);

                        newOrderbtn.Visible = true;
                        viewOrderbtn.Visible = true;
                        editOrdersbtn.Visible = true;
                        break;

                    }
                    else //Order Processing Clerk
                    {
                        ShowButton(false);
                        orderbtn.Visible = true;
                        logoutbtn.Visible = true;
                        orderbtn.Location = new Point(25, buttonLocationIndex[0]);
                        logoutbtn.Location = new Point(25, buttonLocationIndex[8]);

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
                    logoutbtn.Location = new Point(25, buttonLocationIndex[8]);
                    break;




                //Purcahsing
                case "005":
                    stockbtn.Location = new Point(25, buttonLocationIndex[0]);
                    contactsbtn.Location = new Point(25, buttonLocationIndex[1]);
                    logoutbtn.Location = new Point(25, buttonLocationIndex[8]);
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
            logoutbtn.Visible = ReadyOnly;

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

        private void orderbtn_Click(object sender, EventArgs e)
        {

            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;
            orderStatusCombox.DataSource = programMethod.getOrerStatus();
            orderStatusCombox.DisplayMember = "Name";

            CalculateTotalPages("Order");
            ShowPanel(orderpnl);
            orderdata.DataSource = programMethod.GetCurrentRecords("Order", OrderPageIndex, OrderPgSize);
            orderStatusCombox.SelectedIndex = -1;
            string[] MinDate = programMethod.getOrderMinAndMaxDate();
            orderdateTimePicker1.MinDate = DateTime.Parse(MinDate[0]);
            orderdateTimePicker1.MaxDate = DateTime.Parse(MinDate[1]);
            orderdateTimePicker1.Value = DateTime.Parse(MinDate[0]);
            orderdateTimePicker2.MinDate = DateTime.Parse(MinDate[0]);
            orderdateTimePicker2.MaxDate = DateTime.Parse(MinDate[1]);
            orderdateTimePicker2.Value = DateTime.Parse(MinDate[1]);
            orderLabelinfo();
        }

        private void orderLabelinfo()
        {
            array = programMethod.orderLabelinfo();
            orderAllbox.Text = array[0];
            orderCompletedlbl.Text = array[1];
            orderCancelbox.Text = array[2];
            orderActivebox.Text = array[3];
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
            string[] LabelResult = programMethod.getStockLevelLabel();
            stockOutofStockbox.Text = LabelResult[0];
            stockDangerbox.Text = LabelResult[1];
            stockReOrderbox.Text = LabelResult[2];
            productOverallLabel();
            stockData.Rows[0].Selected = false;
            SetRowHeights(stockData, StockPgSize);
            StockpageNumlbl.Text = "1" + " - " + StockPgSize + " of " + StockRowCount;

        }

        private void StockLevelBoldAndColor()
        {

            if (stockData.Rows.Count > 0)
            {
                Font boldFont = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);

                foreach (DataGridViewRow row in stockData.Rows)
                {
                    DataGridViewCell statusCell = row.Cells["Status"];
                    string status = statusCell.Value?.ToString();

                    if (status != null)
                    {
                        switch (status)
                        {
                            case "Out-Of-Stock":
                                statusCell.Style.ForeColor = Color.Red;
                                statusCell.Style.Font = boldFont;
                                break;
                            case "Danger":
                                statusCell.Style.ForeColor = Color.DarkOrange;
                                statusCell.Style.Font = boldFont;
                                break;
                            case "Re-Order":
                                statusCell.Style.ForeColor = Color.Green;
                                statusCell.Style.Font = boldFont;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
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
            userData.Rows[0].Selected = false;
            //string words = userData.Rows[0].Cells["UserID"].Value.ToString();
            //string lastTwoWords = string.Join(" ", words.Skip(words.Length - ));
            //MessageBox.Show(lastTwoWords);
            //int end = int.Parse(lastTwoWords) + 9;
            accountIndexlbl.Text = "01" + " - " + PgSize.ToString() + " of " + programMethod.getAccountRowCount();
            SetRowHeights(userData, PgSize);
            oustandingPagelbl.Text = "01" + " - " + PgSize + " of " + AccountRowCount;




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

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            programMethod.LogUserLogOut(LoginUserID, LoginUserName);
            Login loginForm = new Login();
            loginForm.Show(this);

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
            outstandingdata.DataSource = programMethod.GetOutstandingCurrentRecords(outstandingPageIndex, outstandingPgSize); ;
            oustandingPagelbl.Text = (outstandingPgSize * outstandingPageIndex - (outstandingPgSize - 1)) + " - " + (outstandingPgSize * outstandingPageIndex) + " of " + OutstandingRowCount;



            string[] MinDate = programMethod.getOutstandingMinAndMaxDate();
            outstandingdateTimePicker1.MinDate = DateTime.Parse(MinDate[0]);
            outstandingdateTimePicker1.MaxDate = DateTime.Parse(MinDate[1]);
            outstandingdateTimePicker1.Value = DateTime.Parse(MinDate[0]);
            outstandingdateTimePicker2.MinDate = DateTime.Parse(MinDate[0]);
            outstandingdateTimePicker2.MaxDate = DateTime.Parse(MinDate[1]);
            outstandingdateTimePicker2.Value = DateTime.Parse(MinDate[1]);


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
            CalculateTotalPages("Supplier");
            ShowPanel(contactpnl);
            dealersData.DataSource = programMethod.GetDealerCurrentRecords(DealerPageIndex, DealerPgSize);
            dealersData.Rows[0].Selected = false;
            newSupplierbtn.Visible = false;
            editSupplierbtn.Visible = false;
            newDealerbtn.Visible = true;
            editDealerbtn.Visible = true;
            searchSupplierbtn.Visible = false;
            searchDealerbtn.Visible = true;
            contactDealerclearbtn.Visible = true;
            contactSupplierCleaerbtn.Visible = false;
            currentDataSourceType = "Dealer";
            dealerDatalbl.Text = DealerRowCount.ToString();
            supplierDatalbl.Text = SupplierRowCount.ToString();
            SetRowHeights(dealersData, DealerPgSize);


            contactIndexlbl.Text = "01" + " - " + PgSize.ToString() + " of " + programMethod.getDealersRowCount();
            dealersData.Visible = true;
            suppliersData.Visible = false;

        }



        private void dealersbtn_Click(object sender, EventArgs e)
        {
            isDealerDVG = true;
            dealersData.DataSource = programMethod.GetDealerCurrentRecords(DealerPageIndex, DealerPgSize);
            newSupplierbtn.Visible = false;
            editSupplierbtn.Visible = false;
            newDealerbtn.Visible = true;
            editDealerbtn.Visible = true;
            searchSupplierbtn.Visible = false;
            searchDealerbtn.Visible = true;
            contactDealerclearbtn.Visible = true;
            contactSupplierCleaerbtn.Visible = false;
            currentDataSourceType = "Dealer";
            dealerDatalbl.Text = DealerRowCount.ToString();
            supplierDatalbl.Text = SupplierRowCount.ToString();
            contactIndexlbl.Text = "01" + " - " + PgSize.ToString() + " of " + DealerRowCount;
            dealersData.Visible = true;
            suppliersData.Visible = false;


        }

        private void supplersbtn_Click(object sender, EventArgs e)
        {
            isDealerDVG = false;
            suppliersData.DataSource = programMethod.GetSupplierCurrentRecords(SupplierPageIndex, SupplierPgSize);
            newDealerbtn.Visible = false;
            editDealerbtn.Visible = false;
            newSupplierbtn.Visible = true;
            editSupplierbtn.Visible = true;
            searchSupplierbtn.Visible = true;
            searchDealerbtn.Visible = false;
            contactDealerclearbtn.Visible = false;
            contactSupplierCleaerbtn.Visible = true;
            suppliersData.Columns[2].Visible = false;
            currentDataSourceType = "Supplier";
            dealerDatalbl.Text = DealerRowCount.ToString();
            supplierDatalbl.Text = SupplierRowCount.ToString();
            contactIndexlbl.Text = "01" + " - " + PgSize.ToString() + " of " + SupplierRowCount;
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
                OrderDetailsForViewAndEdit salesOrder = new OrderDetailsForViewAndEdit(OperationMode.View);
                salesOrder.orderView(orderID, dealerID);
                salesOrder.ShowDialog();

            }


        }

        private void newOrderbtn_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder(OperationMode.New);
            createOrder.CurrentUserIDAndName(LoginUserID, LoginUserName);
            createOrder.OperationCompleted += CreateOrderFormOperationCompleted;
            createOrder.ShowDialog();
        }

        private void editOrdersbtn_Click(object sender, EventArgs e)
        {

            if (orderindex == -1)
            {
                MessageBox.Show("Please Select One User");
            }
            else if (orderdata.Rows[orderindex].Cells[3].Value.ToString() == "OrderProcessing")
            {
                OrderDetailsForViewAndEdit salesOrder = new OrderDetailsForViewAndEdit(OperationMode.Edit);
                salesOrder.orderEdit(orderID, dealerID);
                salesOrder.OperationCompleted += CreateOrderFormOperationCompleted;
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

            auditlogStatusbox.DataSource = programMethod.getAuditStatus();
            auditlogStatusbox.DisplayMember = "ActionDetail";

            ShowPanel(logpnl);
            auditLogdata.DataSource = programMethod.overallLoginfo();
            auditTypeStatusbox.SelectedIndex = -1;
            auditlogStatusbox.SelectedIndex = -1;

            string[] MinDate = programMethod.getMinAndMaxDateForAuditLog();
            logdateTimePicker1.MinDate = DateTime.Parse(MinDate[0]);
            logdateTimePicker1.MaxDate = DateTime.Parse(MinDate[1]);
            logdateTimePicker1.Value = DateTime.Parse(MinDate[0]);
            logdateTimePicker2.MinDate = DateTime.Parse(MinDate[0]);
            logdateTimePicker2.MaxDate = DateTime.Parse(MinDate[1]);
            logdateTimePicker2.Value = DateTime.Parse(MinDate[1]);


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
                stockproductID = selectRow.Cells[1].Value.ToString();
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
                productID = selectRow.Cells[2].Value.ToString();

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

        private void stocklbl1_Click(object sender, EventArgs e)
        {

        }

        private void viewProductbtn_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(OperationMode.View);
            productForm.productEdit(stockproductID);
            productForm.ShowDialog();
        }



        private void orderpnl_Paint(object sender, PaintEventArgs e)
        {

        }





        //Overall of Stock Data Label
        private void productOverallLabel()
        {

            stockProductDatalbl1.Text = StockRowCount.ToString();
            string[] numberofProduct = programMethod.getStockLabelinfo(stockData);
            stockProductDatalbl2.Text = String.Format("{0:n0}", numberofProduct[0]);
            stockProductDatalbl3.Text = String.Format("{0:n0}", numberofProduct[1]);
        }

        private void contactOverallLabel()
        {
            dealerDatalbl.Text = programMethod.GetDealerCount().ToString();
            supplierDatalbl.Text = programMethod.GetSupplierNum().ToString();
        }

        private void contactbtnFirstPage_Click(object sender, EventArgs e)
        {
            if (isDealerDVG)
            {
                this.DealerPageIndex = 1;
                this.dealersData.DataSource = programMethod.GetDealerCurrentRecords(DealerPageIndex, DealerPgSize);
                SetRowHeights(dealersData, DealerPgSize);
                contactIndexlbl.Text = "1" + " - " + PgSize + " of " + DealerRowCount;
            }

            else
            {
                this.SupplierPageIndex = 1;
                this.suppliersData.DataSource = programMethod.GetSupplierCurrentRecords(SupplierPageIndex, SupplierPgSize);
                SetRowHeights(suppliersData, SupplierPgSize);
                contactIndexlbl.Text = "1" + " - " + PgSize + " of " + SupplierRowCount;
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
                if (DealerPageIndex != DealerTotalPage)
                {
                    contactIndexlbl.Text = (PgSize * DealerPageIndex - (PgSize - 1)) + " - " + (PgSize * DealerPageIndex) + " of " + DealerRowCount;
                }
                else
                {
                    contactIndexlbl.Text = (PgSize * DealerPageIndex - (PgSize - 1)) + " - " + DealerRowCount + " of " + DealerRowCount;
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
                if (SupplierPageIndex != SupplierTotalPage)
                {
                    contactIndexlbl.Text = (PgSize * SupplierPageIndex - (PgSize - 1)) + " - " + (PgSize * SupplierPageIndex) + " of " + SupplierRowCount;
                }
                else
                {
                    contactIndexlbl.Text = (PgSize * SupplierPageIndex - (PgSize - 1)) + " - " + SupplierRowCount + " of " + SupplierRowCount;
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
                contactIndexlbl.Text = (PgSize * DealerPageIndex - (PgSize - 1)) + " - " + (PgSize * DealerPageIndex) + " of " + DealerRowCount;
            }
            else
            {
                if (this.SupplierPageIndex > 1)
                {
                    this.SupplierPageIndex--;
                    this.suppliersData.DataSource = programMethod.GetSupplierCurrentRecords(this.SupplierPageIndex, SupplierPgSize);
                    SetRowHeights(suppliersData, SupplierPgSize);
                }
                contactIndexlbl.Text = (PgSize * SupplierPageIndex - (PgSize - 1)) + " - " + (PgSize * SupplierPageIndex) + " of " + SupplierRowCount;
            }
        }

        private void contactbtnLastPage_Click(object sender, EventArgs e)
        {
            if (isDealerDVG)
            {
                this.DealerPageIndex = DealerTotalPage;
                this.dealersData.DataSource = programMethod.GetDealerCurrentRecords(this.DealerPageIndex, DealerPgSize);
                SetRowHeights(dealersData, DealerPgSize);
                contactIndexlbl.Text = (PgSize * DealerPageIndex - (PgSize - 1)) + " - " + DealerRowCount + " of " + DealerRowCount;
            }
            else
            {
                this.SupplierPageIndex = SupplierTotalPage;
                this.suppliersData.DataSource = programMethod.GetSupplierCurrentRecords(this.SupplierPageIndex, SupplierPgSize);
                SetRowHeights(suppliersData, SupplierPgSize);
                contactIndexlbl.Text = (PgSize * SupplierPageIndex - (PgSize - 1)) + " - " + SupplierRowCount + " of " + SupplierRowCount;
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
            stockbtn.PerformClick();
        }

        private void userbtn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void stockData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stockData.Columns[e.ColumnIndex].Name != "stockcheckColumn")
            {
                stockData.Columns[e.ColumnIndex].ReadOnly = true;

            }
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
            dragging = true;
            dragCursorPoint = Control.MousePosition;
            dragFormPoint = this.Location;
        }

        private void Dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Control.MousePosition, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
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

        public void currentUserDisplayName(string displayName, string department, string userID, string userName)
        {
            namelbl.Text = displayName;
            usertypelbl.Text = department;
            this.LoginUserID = userID;
            this.LoginUserName = userName;
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
                ProductForm.productEdit(stockproductID);
                ProductForm.ShowDialog();

            }
            stockbtn.PerformClick();

        }

        private void GRNbtn_Click(object sender, EventArgs e)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;
            CalculateTotalPages("GRN");
            ShowPanel(GRNpnl);
            grndata.DataSource = programMethod.GetGRNCurrentRecords(GRNPageIndex, GRNPgSize);
            grndata.Rows[0].Selected = false;
            grnPage.Text = "01" + " - " + GRNPgSize.ToString() + " of " + GRNRowCount;
            SetRowHeights(grndata, GRNPgSize);


            string[] MinDate = programMethod.getOrderMinAndMaxDateForGRN();
            grnDatePicker1.MinDate = DateTime.Parse(MinDate[0]);
            grnDatePicker1.MaxDate = DateTime.Parse(MinDate[1]);
            grnDatePicker1.Value = DateTime.Parse(MinDate[0]);
            grnDatePicker2.MinDate = DateTime.Parse(MinDate[0]);
            grnDatePicker2.MaxDate = DateTime.Parse(MinDate[1]);
            grnDatePicker2.Value = DateTime.Parse(MinDate[1]);

        }

        private void deliverybtn_Click(object sender, EventArgs e)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            DataTable dt = programMethod.getDeliveryStatusAndLableinfo();
            deliveryStatusbox.DataSource = dt;
            deliveryStatusbox.ValueMember = "DeliveryStatus";
            deliveryStatusbox.SelectedIndex = -1;

            deliveryShippinglbl.Text = dt.Rows[1]["Quantity"].ToString();
            deliverydeliveredlbl.Text = dt.Rows[0]["Quantity"].ToString();

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;
            CalculateTotalPages("Delivery");
            ShowPanel(deliverypnl);
            deliveryData.DataSource = programMethod.GetDeliveryCurrentRecords(DespatchPageIndex, DespatchPgSize);

            string[] MinDate = programMethod.getDNMinAndMaxDate();
            deliverydateTimePicker1.MinDate = DateTime.Parse(MinDate[0]);
            deliverydateTimePicker1.MaxDate = DateTime.Parse(MinDate[1]);
            deliverydateTimePicker1.Value = DateTime.Parse(MinDate[0]);
            deliverydateTimePicker2.MinDate = DateTime.Parse(MinDate[0]);
            deliverydateTimePicker2.MaxDate = DateTime.Parse(MinDate[1]);
            deliverydateTimePicker2.Value = DateTime.Parse(MinDate[1]);
        }

        private void delProductbtn_Click(object sender, EventArgs e)
        {
            if (stockindex == -1)
            {
                MessageBox.Show("Please Select One Option");
            }
            else
            {

                DialogResult box = MessageBox.Show("Do you want to Delete #" + stockproductID + " ?", "Delete Product", MessageBoxButtons.YesNo);
                switch (box)
                {

                    case DialogResult.Yes:
                        programMethod.productDel(stockproductID);
                        break;
                    case DialogResult.No:
                        break;
                }
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
            SetRowHeights(grndata, GRNPgSize);

        }

        private void grnclearBtn_Click(object sender, EventArgs e)
        {
            grndata.DataSource = programMethod.overallGRNinfo();
            SetRowHeights(grndata, GRNPgSize);
        }

        private void grnAddNoteBtn_Click(object sender, EventArgs e)
        {
            GRN grn = new GRN(OperationMode.New);
            grn.OperationCompleted += GRNFormOperationCompleted;
            grn.ShowDialog();
        }

        private void DeliveryFormOperationCompleted(object sender, EventArgs e)
        {

            deliverybtn_Click(deliverybtn, EventArgs.Empty);
        }


        private void CreateOrderFormOperationCompleted(object sender, EventArgs e)
        {

            orderbtn_Click(orderbtn, EventArgs.Empty);
        }



        private void GRNFormOperationCompleted(object sender, EventArgs e)
        {
            GRNbtn_Click(GRNbtn, EventArgs.Empty);
        }

        private void OrderAccemblyFormOperationCompleted(object sender, EventArgs e)
        {
            OrderAccemblybtn_Click(OrderAccemblybtn, EventArgs.Empty);
        }

        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            stockData.DataSource = programMethod.searchProductInformation(stockSearchBox.Text.Trim());
        }

        private void orderdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deliverySearchDatebtn_Click(object sender, EventArgs e)
        {
            string formDate = deliverydateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            string toDate = deliverydateTimePicker2.Value.Date.ToString("yyyy-MM-dd");

            if (deliveryStatusbox.SelectedIndex == -1)
                deliveryData.DataSource = programMethod.searchDeliveryDate(formDate, toDate);
            else
            {
                string status = deliveryStatusbox.Text.ToString();
                deliveryData.DataSource = programMethod.searchDeliveryDate(formDate, toDate, status);
            }


        }

        private void newDealerbtn_Click(object sender, EventArgs e)
        {

            DealerContactForm dealerContactForm = new DealerContactForm(OperationMode.New);
            dealerContactForm.OperationCompleted += dealerContactFormOperationCompleted;
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
                dealerContactForm.OperationCompleted += dealerContactFormOperationCompleted;
                dealerContactForm.dealerEdit(contactID);
                dealerContactForm.ShowDialog();
            }
        }

        private void dealerContactFormOperationCompleted(object sender, EventArgs e)
        {
            dealersData.DataSource = programMethod.GetDealerCurrentRecords(CurrentPageIndex, PgSize);
            dealersbtn_Click(dealersbtn, EventArgs.Empty);
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
                    DialogResult box = MessageBox.Show("Do you want to Delete Dealer#" + contactID + " ?", "Delete Dealer", MessageBoxButtons.YesNo);
                    switch (box)
                    {

                        case DialogResult.Yes:
                            programMethod.dealerDel(contactID);
                            dealersbtn_Click(dealersbtn, EventArgs.Empty);
                            break;
                        case DialogResult.No:
                            break;
                    }

                }
                else if (currentDataSourceType == "Supplier")
                {
                    DialogResult box = MessageBox.Show("Do you want to Delete Supplier" +
                        "#" + contactID + " ?", "Delete Supplier", MessageBoxButtons.YesNo);
                    switch (box)
                    {

                        case DialogResult.Yes:
                            programMethod.supplierDel(contactID, productID);
                            supplersbtn_Click(supplersbtn, EventArgs.Empty);
                            break;
                        case DialogResult.No:
                            break;
                    }


                }

            }

        }


        private void newSupplierbtn_Click(object sender, EventArgs e)
        {
            SupplierContactForm supplierContactForm = new SupplierContactForm(OperationMode.New);
            supplierContactForm.OperationCompleted += supplierContactFormOperationCompleted;
            supplierContactForm.ShowDialog();
        }

        private void supplierContactFormOperationCompleted(object sender, EventArgs e)
        {
            suppliersData.DataSource = programMethod.GetSupplierCurrentRecords(CurrentPageIndex, PgSize);
            supplersbtn_Click(supplersbtn, EventArgs.Empty);
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
                supplierContactForm.OperationCompleted += supplierContactFormOperationCompleted;
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
            suppliersData.DataSource = programMethod.searchSupplierInformation(searchContactbtn.Text.Trim());
        }


        private void deliveryclearbtn_Click_1(object sender, EventArgs e)
        {

            //string[] MinDate = programMethod.getDNMinAndMaxDate();
            //deliverydateTimePicker1.MinDate = DateTime.Parse(MinDate[0]);
            //deliverydateTimePicker1.MaxDate = DateTime.Parse(MinDate[1]);
            //deliverydateTimePicker1.Value = DateTime.Parse(MinDate[0]);
            //deliverydateTimePicker2.MinDate = DateTime.Parse(MinDate[0]);
            //deliverydateTimePicker2.MaxDate = DateTime.Parse(MinDate[1]);
            //deliverydateTimePicker2.Value = DateTime.Parse(MinDate[1]);

            //deliveryData.DataSource = programMethod.overallDeliveryinfo();
            deliverybtn_Click(deliverybtn, EventArgs.Empty);
        }

        private void deliveryAddbtn_Click_1(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery(OperationMode.New);
            delivery.OperationCompleted += DeliveryFormOperationCompleted;
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



        private void CalculateTotalPages(string function)
        {
            int rowCount = 0;
            switch (function)
            {
                case "Stock":
                    rowCount = programMethod.getStockRowCount();
                    StockRowCount = rowCount;
                    StockTotalPage = rowCount / StockPgSize;
                    if (rowCount % StockPgSize > 0)
                        StockTotalPage += 1;
                    break;

                case "Outstanding":

                    rowCount = programMethod.getOutstandingRowCount();
                    OutstandingRowCount = rowCount;
                    outstandingTotalPage = rowCount / outstandingPgSize;
                    if (rowCount % outstandingPgSize > 0)
                        outstandingTotalPage += 1;
                    break;

                case "Order":
                    rowCount = programMethod.getOrderRowCount();
                    OrderRowCount = rowCount;
                    OrderTotalPage = rowCount / OrderPgSize;
                    if (rowCount % OrderPgSize > 0)
                        OrderTotalPage += 1;
                    break;

                case "Account":
                    rowCount = programMethod.getAccountRowCount();
                    AccountRowCount = rowCount;
                    TotalPage = rowCount / PgSize;
                    if (rowCount % PgSize > 0)
                        TotalPage += 1;
                    break;

                case "Delivery":
                    rowCount = programMethod.getDeliveryRowCount();
                    DeliveryRowCount = rowCount;
                    DespatchTotalPage = rowCount / PgSize;
                    if (rowCount % DespatchPgSize > 0)
                        DespatchTotalPage += 1;
                    break;


                case "GRN":
                    rowCount = programMethod.getGRNRowCount();
                    GRNRowCount = rowCount;
                    GRNTotalPage = rowCount / GRNPgSize;
                    if (rowCount % GRNPgSize > 0)
                        GRNTotalPage += 1;
                    break;

                case "OrderAccembly":
                    //rowCount = programMethod.getAccountRowCount();
                    //TotalPage = rowCount / PgSize;
                    break;


                case "Dealer":
                    rowCount = programMethod.GetDealerCount();
                    DealerRowCount = rowCount;
                    DealerTotalPage = rowCount / DealerPgSize;
                    if (rowCount % DealerPgSize > 0)
                        DealerTotalPage += 1;
                    break;


                case "Supplier":
                    rowCount = programMethod.GetSupplierCount();
                    SupplierRowCount = rowCount;
                    SupplierTotalPage = rowCount / SupplierPgSize;
                    if (rowCount % SupplierPgSize > 0)
                        SupplierTotalPage += 1;
                    break;

                case "PO":
                    rowCount = programMethod.GetPOCount();
                    PORowCount = rowCount;
                    POTotalPage = rowCount / POPgSize;
                    if (rowCount % POPgSize > 0)
                        POTotalPage += 1;
                    break;

                case "Invoice":
                    rowCount = programMethod.GetInvoiceCount();
                    InvoiceRowCount = rowCount;
                    InvoiceTotalPage = rowCount / InvoicePgSize;
                    if (rowCount % InvoicePgSize > 0)
                        InvoiceTotalPage += 1;
                    break;

            }
        }

        private void accountbtnFirstPage_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = 1;
            this.userData.DataSource = programMethod.GetAccountCurrentRecords(this.CurrentPageIndex, PgSize);
            SetRowHeights(userData, PgSize);

            accountIndexlbl.Text = "1" + " - " + PgSize + " of " + AccountRowCount;
        }

        private void accountbtnNxtPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex < this.TotalPage)
            {
                this.CurrentPageIndex++;
                this.userData.DataSource = programMethod.GetAccountCurrentRecords(this.CurrentPageIndex, PgSize);

            }
            SetRowHeights(userData, PgSize);

            if (CurrentPageIndex != TotalPage)
            {
                accountIndexlbl.Text = (PgSize * CurrentPageIndex - (PgSize - 1)) + " - " + (PgSize * CurrentPageIndex) + " of " + AccountRowCount;
            }
            else
            {
                accountIndexlbl.Text = (PgSize * CurrentPageIndex - (PgSize - 1)) + " - " + AccountRowCount + " of " + AccountRowCount;
            }
        }



        private void accountbtnPrevPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
                this.userData.DataSource = programMethod.GetAccountCurrentRecords(this.CurrentPageIndex, PgSize);
            }
            SetRowHeights(userData, PgSize);
            accountIndexlbl.Text = (PgSize * CurrentPageIndex - (PgSize - 1)) + " - " + (PgSize * CurrentPageIndex) + " of " + AccountRowCount;
        }

        private void accountbtnLastPage_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = TotalPage;
            this.userData.DataSource = programMethod.GetAccountCurrentRecords(this.CurrentPageIndex, PgSize);
            SetRowHeights(userData, PgSize);
            accountIndexlbl.Text = (PgSize * CurrentPageIndex - (PgSize - 1)) + " - " + AccountRowCount + " of " + AccountRowCount;
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
            string formDate = orderAccemblydateTimePicker.Value.Date.ToString("yyyy-MM-dd");
            string toDate = orderAccemblydateTimePicker2.Value.Date.ToString("yyyy-MM-dd");


            if (orderStatusCombox.SelectedIndex == -1)
                orderAccemblyData.DataSource = programMethod.orderAccemblyDateFilter(formDate, toDate);
            else
            {
                //string status = orderStatusCombox.Text.ToString();
                orderAccemblyData.DataSource = programMethod.orderAccemblyDateFilter(formDate, toDate);
                // orderAccemblyData.DataSource = programMethod.overallLoginfo();
                SetRowHeights(orderAccemblyData, 15);

            }
        }

        private void accemblyCreatebtn_Click(object sender, EventArgs e)
        {
            if (orderAceemblyindex == -1)
            {
                MessageBox.Show("Please Select One Order");
            }
            else if (orderAccemblyData.Rows[orderAceemblyindex].Cells[3].Value.ToString() != "ALLProductPackaged")
            {
                OrderAccembly orderAccembly = new OrderAccembly(OperationMode.New, orderAccemblyOrderID, orderAccemblyDealerID);
                orderAccembly.OperationCompleted += OrderAccemblyFormOperationCompleted;
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
            CalculateTotalPages("PO");
            ShowPanel(POpnl);
            poData.DataSource = programMethod.GetPOCurrentRecords(POPageIndex, POPgSize);


            string[] MinDate = programMethod.getMinAndMaxDateForPO();
            podateTimePicker1.MinDate = DateTime.Parse(MinDate[0]);
            podateTimePicker1.MaxDate = DateTime.Parse(MinDate[1]);
            podateTimePicker1.Value = DateTime.Parse(MinDate[0]);
            podateTimePicker2.MinDate = DateTime.Parse(MinDate[0]);
            podateTimePicker2.MaxDate = DateTime.Parse(MinDate[1]);
            podateTimePicker2.Value = DateTime.Parse(MinDate[1]);

        }

        private void invoicebtn_Click(object sender, EventArgs e)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;
            CalculateTotalPages("Invoice");
            ShowPanel(invoicepnl);
            invoiceData.DataSource = programMethod.GetInvoiceCurrentRecords(InvoicePageIndex, InvoicePgSize);
            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;
            //Question
            invoiceIndexlbl.Text = "01" + " - " + PgSize.ToString() + " of " + InvoiceRowCount;
            invoiceData.Rows[0].Selected = false;
            SetRowHeights(invoiceData, InvoicePgSize);


            string[] MinDate = programMethod.getMinAndMaxDateForInvoice();
            InvoicedateTimePicker1.MinDate = DateTime.Parse(MinDate[0]);
            InvoicedateTimePicker1.MaxDate = DateTime.Parse(MinDate[1]);
            InvoicedateTimePicker1.Value = DateTime.Parse(MinDate[0]);
            invoicedateTimePicker2.MinDate = DateTime.Parse(MinDate[0]);
            invoicedateTimePicker2.MaxDate = DateTime.Parse(MinDate[1]);
            invoicedateTimePicker2.Value = DateTime.Parse(MinDate[1]);

        }

        private void sotckLastPagebtn_Click(object sender, EventArgs e)
        {
            this.StockPageIndex = StockTotalPage;
            this.stockData.DataSource = programMethod.GetStockCurrentRecords(this.StockPageIndex, StockPgSize);

            StockpageNumlbl.Text = (StockPgSize * StockPageIndex - (StockPgSize - 1)) + " - " + StockRowCount + " of " + StockRowCount;
        }

        private void sotckNextPagebtn_Click(object sender, EventArgs e)
        {
            if (this.StockPageIndex < this.StockTotalPage)
            {
                this.StockPageIndex++;
                this.stockData.DataSource = programMethod.GetStockCurrentRecords(this.StockPageIndex, StockPgSize);

                if (StockPageIndex != StockTotalPage)
                {
                    StockpageNumlbl.Text = (StockPgSize * StockPageIndex - (StockPgSize - 1)) + " - " + (StockPgSize * StockPageIndex) + " of " + StockRowCount;
                }
                else
                {
                    StockpageNumlbl.Text = (StockPgSize * StockPageIndex - (StockPgSize - 1)) + " - " + StockRowCount + " of " + StockRowCount;
                }
            }
        }

        private void sotckPrevPagebtn_Click(object sender, EventArgs e)
        {
            if (this.StockPageIndex > 1)
            {
                this.StockPageIndex--;
                this.stockData.DataSource = programMethod.GetStockCurrentRecords(this.StockPageIndex, StockPgSize);
                StockpageNumlbl.Text = (StockPgSize * StockPageIndex - (StockPgSize - 1)) + " - " + (StockPgSize * StockPageIndex) + " of " + StockRowCount;

            }
        }

        private void stockFirstPagebtn_Click(object sender, EventArgs e)
        {
            this.StockPageIndex = 1;
            this.stockData.DataSource = programMethod.GetStockCurrentRecords(this.StockPageIndex, StockPgSize);
            StockpageNumlbl.Text = "1" + " - " + StockPgSize + " of " + StockRowCount;
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
            oustandingPagelbl.Text = (outstandingPgSize * outstandingPageIndex - (outstandingPgSize - 1)) + " - " + OutstandingRowCount + " of " + OutstandingRowCount;
        }

        private void outstandingNextPagebtn_Click(object sender, EventArgs e)
        {
            if (this.outstandingPageIndex < this.outstandingTotalPage)
            {
                this.outstandingPageIndex++;
                this.outstandingdata.DataSource = programMethod.GetOutstandingCurrentRecords(this.outstandingPageIndex, outstandingPgSize);
                SetRowHeights(outstandingdata, outstandingPgSize);
            }

            if (outstandingPageIndex != outstandingTotalPage)
            {
                oustandingPagelbl.Text = (outstandingPgSize * outstandingPageIndex - (outstandingPgSize - 1)) + " - " + (outstandingPgSize * outstandingPageIndex) + " of " + OutstandingRowCount;
            }
            else
            {
                oustandingPagelbl.Text = (outstandingPgSize * outstandingPageIndex - (outstandingPgSize - 1)) + " - " + OutstandingRowCount + " of " + OutstandingRowCount;
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
            oustandingPagelbl.Text = (outstandingPgSize * outstandingPageIndex - (outstandingPgSize - 1)) + " - " + (outstandingPgSize * outstandingPageIndex) + " of " + OutstandingRowCount;
        }

        private void outstandingFirstPagebtn_Click(object sender, EventArgs e)
        {
            this.outstandingPageIndex = 1;
            this.outstandingdata.DataSource = programMethod.GetOutstandingCurrentRecords(this.outstandingPageIndex, outstandingPgSize);
            SetRowHeights(outstandingdata, outstandingPgSize);
            oustandingPagelbl.Text = "1" + " - " + outstandingPgSize + " of " + OutstandingRowCount;
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
            string toDate = orderdateTimePicker2.Value.Date.ToString("yyyy-MM-dd");


            isOrderFilter = true;
            OrderPageIndex = 1;

            switch (orderStatusCombox.SelectedIndex)
            {
                case 0:
                    OrderRowCount = int.Parse(array[5]);
                    OrderTotalPage = int.Parse(array[5]) / OrderPgSize;
                    if (OrderRowCount % OrderPgSize > 0)
                        OrderTotalPage += 1;
                    break;

                case 1:
                    OrderRowCount = int.Parse(array[4]);
                    OrderTotalPage = int.Parse(array[4]) / OrderPgSize;
                    if (OrderRowCount % OrderPgSize > 0)
                        OrderTotalPage += 1;
                    break;

                case 2:
                    OrderRowCount = int.Parse(array[6]);
                    OrderTotalPage = int.Parse(array[6]) / OrderPgSize;
                    if (OrderRowCount % OrderPgSize > 0)
                        OrderTotalPage += 1;
                    break;

                case 3:
                    OrderRowCount = int.Parse(array[2]);
                    OrderTotalPage = int.Parse(array[2]) / OrderPgSize;
                    if (OrderRowCount % OrderPgSize > 0)
                        OrderTotalPage += 1;
                    break;

                case 4:
                    OrderRowCount = int.Parse(array[1]);
                    OrderTotalPage = int.Parse(array[1]) / OrderPgSize;
                    if (OrderRowCount % OrderPgSize > 0)
                        OrderTotalPage += 1;
                    break;
            }

            if (orderStatusCombox.SelectedIndex == -1)
                orderdata.DataSource = programMethod.orderDateFilter(formDate, toDate);
            else
            {
                string status = orderStatusCombox.Text.ToString();
                orderdata.DataSource = programMethod.orderDateStatusFilterPagination(formDate, toDate, status, OrderPageIndex, OrderPgSize);
            }
        }

        private void orderClearbtn_Click(object sender, EventArgs e)
        {
            orderdata.DataSource = programMethod.overallOrderinfo();
        }

        private void orderCancelbtn_Click(object sender, EventArgs e)
        {
            if (orderdata.Rows[orderindex].Cells[3].Value.ToString() == "OrderProcessing")
            {

                DialogResult box = MessageBox.Show("Do you want to cancel Order #" + orderID + " ?", "Cancel Order", MessageBoxButtons.YesNo);
                switch (box)
                {
                    case DialogResult.Yes:
                        if (programMethod.cancelOrder(orderID))
                            orderbtn_Click(orderbtn, EventArgs.Empty);
                        break;
                    case DialogResult.No:
                        break;
                }
            }

        }

        private void deliveryCompletebtn_Click(object sender, EventArgs e)
        {
            string deliveredDate = DeliverydeliveredDate.Value.Date.ToString("yyyy-MM-dd");

            if (deliveryindex == -1 || orderDate.Visible == true)
            {
                orderDate.Visible = true;
                return;
            }
            else
            {
                programMethod.updateDeliveryStatus(DeliveryorderID, DeliverydeliveryID, deliveredDate);
                MessageBox.Show("Delivery ID #" + DeliverydeliveryID + " delivered successfully");
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
                deliveryShippingdatelbl.Text = "Placed on " + programMethod.getDeliveryDate(deliveryID);
                DeliverydeliveredDate.MinDate = DateTime.Now.Date;
                string[] dateTime = programMethod.getOrderDateForDelivery(DeliveryorderID);
                //DeliverydeliveredDate.MinDate = DateTime.Parse(dateTime[0]);
                DeliverydeliveredDate.MaxDate = DateTime.Parse(dateTime[1]);

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
                outstandingViewData.Rows.Clear();
                outstandingViewData.Refresh();
                //deliveryDeliveryIDlbl.Text = "Delivery ID : # " + DeliverydeliveryID.ToString();
                DataTable dt = programMethod.getOutstandingOrder(outstandingOrderID);
                outstandingIDlbl.Text = "Outstanding ID : #" + outstandingOrderID;
                outstandingOrderIDlbl.Text = dt.Rows[0]["OrderID"].ToString();
                viewoutstandingOrderDatelbl.Text = dt.Rows[0]["OrderDate"].ToString();
                viewoutstandingOrderExecptDatelbl.Text = dt.Rows[0]["ExpectCompleteDate"].ToString();
                outstandingViewDealerIDlbl.Text = dt.Rows[0]["DealerID"].ToString();
                outstandingViewDealerNamelbl.Text = dt.Rows[0]["DealerName"].ToString();
                outstandingViewContactNamelbl.Text = dt.Rows[0]["DealerContactName"].ToString();
                outstandingViewPhoneNumlbl.Text = dt.Rows[0]["DealerContactPhoneNum"].ToString();
                outstandingViewEmaillbl.Text = dt.Rows[0]["DealerEmailAddress"].ToString();
                oustandingViewDeliverylbl.Text = dt.Rows[0]["DeliveryAddress"].ToString();
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
                outOrderID = selectRow.Cells[2].Value.ToString();
                outproductID = selectRow.Cells[3].Value.ToString();

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
            orderAccemblyData.Rows[0].Selected = false;

            string[] result = programMethod.orderAccemblyLabelinfo();
            orderaccemblybox.Text = result[0];
            orderaccemblyPartiallylbl.Text = result[1];
            orderaccemblycompletedbox.Text = result[2];

            string[] MinDate = programMethod.getOrderMinAndMaxDateForOrderAccembly();
            orderAccemblydateTimePicker.MinDate = DateTime.Parse(MinDate[0]);
            orderAccemblydateTimePicker.MaxDate = DateTime.Parse(MinDate[1]);
            orderAccemblydateTimePicker.Value = DateTime.Parse(MinDate[0]);
            orderAccemblydateTimePicker2.MinDate = DateTime.Parse(MinDate[0]);
            orderAccemblydateTimePicker2.MaxDate = DateTime.Parse(MinDate[1]);
            orderAccemblydateTimePicker2.Value = DateTime.Parse(MinDate[1]);
        }

        private void poLastPagebtn_Click(object sender, EventArgs e)
        {
            this.POPageIndex = POTotalPage;
            this.poData.DataSource = programMethod.GetPOCurrentRecords(this.POPageIndex, POPgSize);

        }

        private void poFirstPageBtn_Click(object sender, EventArgs e)
        {
            this.POPageIndex = 1;
            poData.DataSource = programMethod.GetPOCurrentRecords(POPageIndex, POPgSize);

        }

        private void poPrevPageBtn_Click(object sender, EventArgs e)
        {
            if (this.POPageIndex > 1)
            {
                this.POPageIndex--;
                this.poData.DataSource = programMethod.GetPOCurrentRecords(this.POPageIndex, POPgSize);
            }
        }

        private void poNextPageBtn_Click(object sender, EventArgs e)
        {
            {
                if (this.POPageIndex < this.POTotalPage)
                {
                    this.POPageIndex++;
                    this.poData.DataSource = programMethod.GetPOCurrentRecords(this.POPageIndex, POPgSize);

                }
            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(dashboardpnl);
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            reportOrderProductCategorybox.DataSource = null;
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;
            reportOrderProductbox.DataSource = programMethod.getProductID();
            reportOrderProductbox.DisplayMember = "ProductID";
            reportOrderProductCategorybox.DataSource = programMethod.getProductCategory();
            reportOrderProductCategorybox.DisplayMember = "ProductCategory";
            orderReportdata.DataSource = programMethod.getOrderReport();
            DataTable dt = programMethod.getTopSellingProductReport();
            foreach (var series in orderchart1.Series)
            {
                series.Points.Clear();
            }
            for (int i = 0; i < 5; i++)
            {
                orderchart1.Series["Order"].Points.AddXY(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());
            }

            ShowPanel(settingpnl);

        }

        private void CancelOrderbtn_Click(object sender, EventArgs e)
        {
            DialogResult mesBox = MessageBox.Show("Do you want to delete #" + orderID + " ?", "Cancel Order", MessageBoxButtons.YesNo);
            switch (mesBox)
            {
                case DialogResult.Yes:
                    if (programMethod.cancelOrder(orderID))
                        ShowPanel(orderpnl);
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (!IsZoomIN)
            {   //Zoom IN
                stockData.Location = new Point(19, 73);
                stockData.Size = new Size(1204, 953);
                IsZoomIN = true;
                stockSummarypnl.Visible = false;
                panel54.Visible = false;
                editProductbtn.Visible = false;
                viewProductbtn.Visible = false;
                delProductbtn.Visible = false;
                stockSearchBox.Visible = false;
                panel8.Visible = false;
                panel55.Visible = false;
                stockData.DataSource = programMethod.overviewStockinfo();
                stockData.ScrollBars = ScrollBars.Both;

            }
            else
            {
                stockData.Location = new Point(23, 408);
                stockData.Size = new Size(1194, 540);
                IsZoomIN = false;

                stockSummarypnl.Visible = true;
                panel54.Visible = true;
                editProductbtn.Visible = true;
                viewProductbtn.Visible = true;
                delProductbtn.Visible = true;
                stockSearchBox.Visible = true;
                panel8.Visible = true;
                panel55.Visible = true;
                stockbtn.PerformClick();

            }

        }

        private void FirstpageBtnClick(DataGridView data, string type, int PgSize, int PageIndex, Label lbl, int rowCount)
        {
            data.DataSource = programMethod.GetCurrentRecords(type, PageIndex, PgSize);
            SetRowHeights(data, PgSize);
            SetRowHeights(data, PgSize);
            lbl.Text = "1" + " - " + PgSize + " of " + rowCount;

        }
        private void NextpageBtnClick(DataGridView data, string type, int PgSize, int PageIndex, Label lbl, int TotalPage, int rowCount)
        {
            if (PageIndex < TotalPage)
            {
                PageIndex++;
                MessageBox.Show(PageIndex++.ToString());
                MessageBox.Show(OrderPageIndex.ToString());
                data.DataSource = programMethod.GetCurrentRecords(type, PageIndex, PgSize);
                SetRowHeights(data, PgSize);
            }

            if (PageIndex != TotalPage)
            {
                lbl.Text = (PgSize * PageIndex - (PgSize - 1)) + " - " + (PgSize * PageIndex) + " of " + rowCount;
            }
            else
            {
                lbl.Text = (PgSize * PageIndex - (PgSize - 1)) + " - " + rowCount + " of " + rowCount;
            }

        }

        private void orderFirstPagebtn_Click(object sender, EventArgs e)
        {
            this.OrderPageIndex = 1;
            FirstpageBtnClick(orderdata, "Order", OrderPgSize, OrderPageIndex, orderIndexlbl, OrderRowCount);

        }

        private void orderPrevPagebtn_Click(object sender, EventArgs e)
        {

        }

        private void orderNextPagebtn_Click(object sender, EventArgs e)
        {
            NextpageBtnClick(orderdata, "Order", OrderPgSize, OrderPageIndex, orderIndexlbl, OrderTotalPage, OrderRowCount);
        }

        private void orderLastPagebtn_Click(object sender, EventArgs e)
        {

        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel26.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel27.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel28.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel29.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);

        }



        private void invoiceData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.invoiceData.Rows[e.RowIndex].Cells["invoicecheckbox"].Value = true;
                invoiceIndex = e.RowIndex;
                DataGridViewRow selectRow = this.invoiceData.Rows[invoiceIndex];
                invoiceID = selectRow.Cells[1].Value.ToString();
                invoiceOrderID = selectRow.Cells[2].Value.ToString();
                invoiceDealerID = selectRow.Cells[3].Value.ToString();
                invoiceDate = selectRow.Cells[4].Value.ToString();
                invoiceDeliveryID = selectRow.Cells[5].Value.ToString();


                foreach (DataGridViewRow row in invoiceData.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["invoicecheckbox"].Value = !Convert.ToBoolean(row.Cells["invoicecheckbox"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["invoicecheckbox"].Value = false;
                    }
                }
            }
        }

        private void invoiceViewBtn_Click(object sender, EventArgs e)
        {
            if (invoiceIndex == -1)
            {
                MessageBox.Show("Please Select One Invoice");
            }
            else
            {
                Invoice invoice = new Invoice(invoiceID, invoiceOrderID, invoiceDealerID, invoiceDeliveryID, invoiceDate);
                invoice.ShowDialog();

            }
        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel30.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void orderdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            orderdateTimePicker2.MinDate = orderdateTimePicker1.Value;
        }



        private void reportOrdercsvbtn_Click(object sender, EventArgs e)
        {
            string text = "";
            int countRows = orderReportdata.RowCount;
            int countCells = orderReportdata.Rows[0].Cells.Count;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = Path.Combine(path, "SalesOrderReport.csv");

            int fileCount = 1;
            while (File.Exists(filepath))
            {
                filepath = Path.Combine(path, $"SalesOrderReport ({fileCount}).csv");
                fileCount++;
            }

            for (int i = 0; i < countCells; i++)
            {
                text += orderReportdata.Columns[i].HeaderText + ", ";
            }
            text = text.TrimEnd(',', ' ');
            text += "\r\n";

            for (int row_index = 0; row_index < countRows; row_index++)
            {
                for (int i = 0; i < countCells; i++)
                {
                    text += orderReportdata.Rows[row_index].Cells[i].Value.ToString() + ", ";
                }
                text = text.TrimEnd(',', ' ');
                text += "\r\n";
            }

            File.WriteAllText(filepath, text);
            MessageBox.Show("Sales Order Report Saved At Your Desktop!");
            programMethod.LogPrintSalesOrderReportCSV(LoginUserID, LoginUserName);
        }


        private void reportShowStockbtn_Click(object sender, EventArgs e)
        {
            foreach (var series in reportStockPie.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in stockInAndOutchart.Series)
            {
                series.Points.Clear();
            }
            ShowPanel(StockReportpnl);
            reportStockdata.DataSource = programMethod.getTopSellingProductReport();
            stockReportCategorybox.DataSource = programMethod.getProductCategory();
            stockReportCategorybox.DisplayMember = "ProductCategory";

            DataTable dataTable = programMethod.getStockInAndOut();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                stockInAndOutchart.Series["Stock"].Points.AddXY("Sotck - In", dataTable.Rows[i][0].ToString());
            }


            DataTable dt = programMethod.getStockReportForCategory();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reportStockPie.Series["Stock"].Points.AddXY(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CreatePurchaseOrder CreatePurchaseForm = new CreatePurchaseOrder(OperationMode.New);
            CreatePurchaseForm.OperationCompleted += CreatePurchaseOrderOperationCompleted;
            CreatePurchaseForm.ShowDialog();
        }

        private void CreatePurchaseOrderOperationCompleted(object sender, EventArgs e)
        {
            poData.DataSource = programMethod.GetPOCurrentRecords(CurrentPageIndex, PgSize);
            PObtn.PerformClick();
        }

        private void viewOutstandingCompletebtn_Click(object sender, EventArgs e)
        {
            programMethod.completeOutstandingOrder(outstandingOrderID);
        }


        private void poData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                try
                {

                    this.poData.Rows[e.RowIndex].Cells["pocheckColumn"].Value = true;
                    POIndex = e.RowIndex;
                    DataGridViewRow selectRow = this.poData.Rows[POIndex];
                    poID = selectRow.Cells[1].Value.ToString();
                    //  dealerID = selectRow.Cells[2].Value.ToString();

                    foreach (DataGridViewRow row in stockData.Rows)
                    {
                        if (row.Index == e.RowIndex)
                        {
                            row.Cells["pocheckColumn"].Value = !Convert.ToBoolean(row.Cells["pocheckColumn"].EditedFormattedValue);
                        }
                        else
                        {
                            row.Cells["pocheckColumn"].Value = false;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Please try again!");
                }

            }
        }

        private void poSearchbtn_Click(object sender, EventArgs e)
        {
            poData.DataSource = programMethod.searchPOInformation(poSearchbox.Text.Trim());
        }

        private void grnDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            grnDatePicker2.MinDate = grnDatePicker1.Value;
        }

        private void dateFilterbtn_Click(object sender, EventArgs e)
        {
            string formDate = podateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            string toDate = podateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            poData.DataSource = programMethod.searchPODate(formDate, toDate);

        }

        private void orderdateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grnPrevPage_Click(object sender, EventArgs e)
        {
            if (this.GRNPageIndex > 1)
            {
                this.GRNPageIndex--;
                this.grndata.DataSource = programMethod.GetGRNCurrentRecords(this.GRNPageIndex, GRNPgSize);
            }
            SetRowHeights(grndata, GRNPgSize);
            grnPage.Text = (GRNPgSize * GRNPageIndex - (GRNPgSize - 1)) + " - " + (GRNPgSize * GRNPageIndex) + " of " + GRNRowCount;
        }

        private void grnFirstPage_Click(object sender, EventArgs e)
        {
            this.GRNPageIndex = 1;
            this.grndata.DataSource = programMethod.GetGRNCurrentRecords(this.GRNPageIndex, GRNPgSize);
            SetRowHeights(grndata, GRNPgSize);

            grnPage.Text = "1" + " - " + GRNPgSize + " of " + GRNRowCount;
        }

        private void grnNextPage_Click(object sender, EventArgs e)
        {
            if (this.GRNPageIndex < this.GRNTotalPage)
            {

                this.GRNPageIndex++;
                this.grndata.DataSource = programMethod.GetGRNCurrentRecords(this.GRNPageIndex, GRNPgSize);

            }
            SetRowHeights(grndata, GRNPgSize);

            if (GRNPageIndex != GRNTotalPage)
            {

                grnPage.Text = (GRNPgSize * GRNPageIndex - (GRNPgSize - 1)) + " - " + (GRNPgSize * GRNPageIndex) + " of " + GRNRowCount;
            }
            else
            {

                grnPage.Text = (GRNPgSize * GRNPageIndex - (GRNPgSize - 1)) + " - " + GRNRowCount + " of " + GRNRowCount;
            }
        }

        private void grnLastPage_Click(object sender, EventArgs e)
        {
            this.GRNPageIndex = GRNTotalPage;
            this.grndata.DataSource = programMethod.GetGRNCurrentRecords(this.GRNPageIndex, GRNPgSize);
            SetRowHeights(grndata, GRNPgSize);
            grnPage.Text = (GRNPgSize * GRNPageIndex - (GRNPgSize - 1)) + " - " + GRNRowCount + " of " + GRNRowCount;
        }

        private void orderAccemblySearchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                orderAccemblyData.DataSource = programMethod.searchOrderAccembly(orderAccemblySearchbox.Text.Trim());
                orderAccemblySearchbox.Clear();
                SetRowHeights(orderAccemblyData, 15);
            }
        }

        private void orderAccemblydateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            orderAccemblydateTimePicker2.MinDate = orderAccemblydateTimePicker.Value;
        }

        private void orderSearchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (orderSearchbox.Text.Trim() == "")
                {
                    orderdata.DataSource = programMethod.GetCurrentRecords("Order", OrderPageIndex, OrderPgSize);
                    SetRowHeights(orderdata, OrderPgSize);
                }
                else
                    orderdata.DataSource = programMethod.searchOrder(orderSearchbox.Text.Trim());
                SetRowHeights(orderdata, OrderPgSize);
                orderSearchbox.Clear();
            }
        }

        private void deliverydateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            deliverydateTimePicker2.MinDate = deliverydateTimePicker1.Value;
        }

        private void outstandingdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            outstandingdateTimePicker2.MinDate = outstandingdateTimePicker1.Value;
        }

        private void outstandingSearchbtn_Click(object sender, EventArgs e)
        {
            string formDate = outstandingdateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            string toDate = outstandingdateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            outstandingdata.DataSource = programMethod.getOutstandingDateFilter(formDate, toDate);
            SetRowHeights(outstandingdata, outstandingPgSize);
        }

        private void panel56_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel26.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void podateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            podateTimePicker2.MinDate = podateTimePicker1.Value;
        }

        private void InvoicedateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            invoicedateTimePicker2.MinDate = InvoicedateTimePicker1.Value;
        }

        private void invoiceSearchBtn_Click(object sender, EventArgs e)
        {
            string formDate = InvoicedateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            string toDate = invoicedateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            invoiceData.DataSource = programMethod.getInvoiceDateFilter(formDate, toDate);
            SetRowHeights(invoiceData, InvoicePgSize);
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            logdateTimePicker2.MinDate = logdateTimePicker1.Value;
        }

        private void SeachLogButton_Click(object sender, EventArgs e)
        {
            string formDate = logdateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            string toDate = logdateTimePicker2.Value.Date.ToString("yyyy-MM-dd");



            //SetRowHeights(auditLogdata, InvoicePgSize);


            if (auditlogStatusbox.SelectedIndex == -1)
                auditLogdata.DataSource = programMethod.getAuditLogDateFilter(formDate, toDate);
            else
            {
                string status = auditlogStatusbox.Text.ToString();
                string type = auditTypeStatusbox.Text.ToString();
                auditLogdata.DataSource = programMethod.auditLogDateStatusFilter(formDate, toDate, type, status);
            }

        }



        private void contactSupplierCleaerbtn_Click(object sender, EventArgs e)
        {
            suppliersData.DataSource = programMethod.GetSupplierCurrentRecords(SupplierPageIndex, SupplierPgSize);
            SetRowHeights(suppliersData, SupplierPgSize);
        }

        private void contactDealerclearbtn_Click(object sender, EventArgs e)
        {
            dealersData.DataSource = programMethod.GetDealerCurrentRecords(DealerPageIndex, DealerPgSize);
            SetRowHeights(dealersData, DealerPgSize);
        }

        private void stockSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            string text = stockSearchBox.Text.Trim();
            if (e.KeyCode == Keys.Enter)
            {
                stockData.DataSource = programMethod.searchProductInformation(stockSearchBox.Text.Trim());
                SetRowHeights(stockData, StockPgSize);
                stockSearchBox.Clear();
            }


        }

        private void orderNextPagebtn_Click_1(object sender, EventArgs e)
        {
            if (this.OrderPageIndex < this.OrderTotalPage)
            {
                this.OrderPageIndex++;
                if (isOrderFilter)
                {
                    string formDate = orderdateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                    string toDate = orderdateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
                    string status = orderStatusCombox.Text.ToString();
                    orderdata.DataSource = programMethod.orderDateStatusFilterPagination(formDate, toDate, status, OrderPageIndex, OrderPgSize);
                }
                else
                {
                    this.orderdata.DataSource = programMethod.GetCurrentRecords("Order", this.OrderPageIndex, OrderPgSize);
                }
            }
        }

        private void orderLastPagebtn_Click_1(object sender, EventArgs e)
        {
            this.OrderPageIndex = OrderTotalPage;

            if (isOrderFilter)
            {
                string formDate = orderdateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                string toDate = orderdateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
                string status = orderStatusCombox.Text.ToString();
                orderdata.DataSource = programMethod.orderDateStatusFilterPagination(formDate, toDate, status, OrderPageIndex, OrderPgSize);
            }
            else
            {
                this.orderdata.DataSource = programMethod.GetCurrentRecords("Order", this.OrderPageIndex, OrderPgSize);
            }

        }

        private void orderPrevPagebtn_Click_1(object sender, EventArgs e)
        {
            if (this.OrderPageIndex > 1)
            {
                this.OrderPageIndex--;
                if (isOrderFilter)
                {
                    string formDate = orderdateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                    string toDate = orderdateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
                    string status = orderStatusCombox.Text.ToString();
                    orderdata.DataSource = programMethod.orderDateStatusFilterPagination(formDate, toDate, status, OrderPageIndex, OrderPgSize);
                }
                else
                {
                    this.orderdata.DataSource = programMethod.GetCurrentRecords("Order", this.OrderPageIndex, OrderPgSize);
                }
            }
        }

        private void orderFirstPagebtn_Click_1(object sender, EventArgs e)
        {
            this.OrderPageIndex = 1;
            if (isOrderFilter)
            {
                string formDate = orderdateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                string toDate = orderdateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
                string status = orderStatusCombox.Text.ToString();
                orderdata.DataSource = programMethod.orderDateStatusFilterPagination(formDate, toDate, status, OrderPageIndex, OrderPgSize);
            }
            else
            {
                this.orderdata.DataSource = programMethod.GetCurrentRecords("Order", this.OrderPageIndex, OrderPgSize);
            }
        }

        private void stockReOrderlbl_Click(object sender, EventArgs e)
        {
            stockData.DataSource = programMethod.getStockReOrderInfo();
            if (stockData.Rows.Count > 0)
            {
                stockData.Rows[0].Selected = false;
            }
            SetRowHeights(stockData, StockPgSize);
            StockLevelBoldAndColor();
        }

        private void stockDangerlbl_Click(object sender, EventArgs e)
        {
            stockData.DataSource = programMethod.getStockDangerInfo();
            if (stockData != null)
            {

                stockData.Rows[0].Selected = false;
                SetRowHeights(stockData, StockPgSize);
                StockLevelBoldAndColor();
            }

        }

        private void stockOutOfStocklbl_Click(object sender, EventArgs e)
        {
            stockData.DataSource = programMethod.getStockOutOfStockInfo();
            stockData.Rows[0].Selected = false;
            SetRowHeights(stockData, StockPgSize);
            StockLevelBoldAndColor();
        }

        private void stockClearbtn_Click(object sender, EventArgs e)
        {
            stockData.DataSource = programMethod.GetStockCurrentRecords(StockPageIndex, StockPgSize);
            stockData.Rows[0].Selected = false;
            SetRowHeights(stockData, StockPgSize);
            StockLevelBoldAndColor();
        }

        private void orderClearbtn_Click_1(object sender, EventArgs e)
        {
            isOrderFilter = false;
            OrderPageIndex = 1;
            orderStatusCombox.SelectedIndex = -1;
            OrderRowCount = int.Parse(array[0]);
            OrderTotalPage = OrderRowCount / OrderPgSize;
            if (OrderRowCount % OrderPgSize > 0)
                OrderTotalPage += 1;
            orderdata.DataSource = programMethod.GetCurrentRecords("Order", OrderPageIndex, OrderPgSize);

        }

        private void orderAccemblyClearbtn_Click(object sender, EventArgs e)
        {
            string[] MinDate = programMethod.getOrderMinAndMaxDateForOrderAccembly();
            orderAccemblydateTimePicker.MinDate = DateTime.Parse(MinDate[0]);
            orderAccemblydateTimePicker.MaxDate = DateTime.Parse(MinDate[1]);
            orderAccemblydateTimePicker.Value = DateTime.Parse(MinDate[0]);
            orderAccemblydateTimePicker2.MinDate = DateTime.Parse(MinDate[0]);
            orderAccemblydateTimePicker2.MaxDate = DateTime.Parse(MinDate[1]);
            orderAccemblydateTimePicker2.Value = DateTime.Parse(MinDate[1]);

            orderAccemblyData.DataSource = programMethod.overallOrderinfo();
            orderAccemblyData.Rows[0].Selected = false;
            ShowPanel(OrderAccemblypnl);
        }

        private void deliverySearchIDbox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                deliveryData.DataSource = programMethod.searchDeliveryNote(deliverySearchIDbox.Text.Trim());
                deliverySearchIDbox.Clear();
                //SetRowHeights(deliveryData, DelivePgSize);
            }
        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            string[] MinDate = programMethod.getMinAndMaxDateForAuditLog();
            logdateTimePicker1.MinDate = DateTime.Parse(MinDate[0]);
            logdateTimePicker1.MaxDate = DateTime.Parse(MinDate[1]);
            logdateTimePicker1.Value = DateTime.Parse(MinDate[0]);
            logdateTimePicker2.MinDate = DateTime.Parse(MinDate[0]);
            logdateTimePicker2.MaxDate = DateTime.Parse(MinDate[1]);
            logdateTimePicker2.Value = DateTime.Parse(MinDate[1]);
            auditTypeStatusbox.SelectedIndex = -1;
            auditlogStatusbox.SelectedIndex = -1;


            auditLogdata.Columns[0].Width = 90;
            auditLogdata.Columns[1].Width = 70;
            auditLogdata.Columns[2].Width = 110;
            auditLogdata.Columns[3].Width = 80;
            auditLogdata.Columns[4].Width = 580;

        }

        private void auditsearchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                auditLogdata.DataSource = programMethod.searchLoginfo(auditsearchbox.Text.Trim());
                auditsearchbox.Clear();

                string[] MinDate = programMethod.getMinAndMaxDateForAuditLog();
                logdateTimePicker1.MinDate = DateTime.Parse(MinDate[0]);
                logdateTimePicker1.MaxDate = DateTime.Parse(MinDate[1]);
                logdateTimePicker1.Value = DateTime.Parse(MinDate[0]);
                logdateTimePicker2.MinDate = DateTime.Parse(MinDate[0]);
                logdateTimePicker2.MaxDate = DateTime.Parse(MinDate[1]);
                logdateTimePicker2.Value = DateTime.Parse(MinDate[1]);

                auditLogdata.Columns[0].Width = 90;
                auditLogdata.Columns[1].Width = 70;
                auditLogdata.Columns[2].Width = 110;
                auditLogdata.Columns[3].Width = 80;
                auditLogdata.Columns[4].Width = 580;
            }

        }

        private void accountSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                userData.DataSource = programMethod.searchUserInformation(accountSearchBox.Text.Trim());
                accountSearchBox.Clear();
            }
        }

        private void accountClearbtn_Click(object sender, EventArgs e)
        {
            userData.DataSource = programMethod.GetAccountCurrentRecords(CurrentPageIndex, PgSize);
            userData.Rows[0].Selected = false;
        }

        private void invoiceClearBtn_Click(object sender, EventArgs e)
        {

            invoiceData.DataSource = programMethod.GetInvoiceCurrentRecords(InvoicePageIndex, InvoicePgSize);
            invoiceData.Rows[0].Selected = false;
            SetRowHeights(invoiceData, InvoicePgSize);


            string[] MinDate = programMethod.getMinAndMaxDateForInvoice();
            InvoicedateTimePicker1.MinDate = DateTime.Parse(MinDate[0]);
            InvoicedateTimePicker1.MaxDate = DateTime.Parse(MinDate[1]);
            InvoicedateTimePicker1.Value = DateTime.Parse(MinDate[0]);
            invoicedateTimePicker2.MinDate = DateTime.Parse(MinDate[0]);
            invoicedateTimePicker2.MaxDate = DateTime.Parse(MinDate[1]);
            invoicedateTimePicker2.Value = DateTime.Parse(MinDate[1]);

        }

        private void invoiceSearchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                invoiceData.DataSource = programMethod.searchInvoiceInfo(invoiceSearchbox.Text.Trim());
                invoiceData.Rows[0].Selected = false;
                SetRowHeights(invoiceData, InvoicePgSize);
                invoiceSearchbox.Clear();
            }
        }

        private void poSearchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                poData.DataSource = programMethod.searchPOInformation(poSearchbox.Text.Trim());
                poSearchbox.Clear();
            }
        }


        private void poClearbtn_Click(object sender, EventArgs e)
        {
            poData.DataSource = programMethod.GetPOCurrentRecords(POPageIndex, POPgSize);
            poData.Rows[0].Selected = false;
            SetRowHeights(poData, POPgSize);


            string[] MinDate = programMethod.getMinAndMaxDateForPO();
            podateTimePicker1.MinDate = DateTime.Parse(MinDate[0]);
            podateTimePicker1.MaxDate = DateTime.Parse(MinDate[1]);
            podateTimePicker1.Value = DateTime.Parse(MinDate[0]);
            podateTimePicker2.MinDate = DateTime.Parse(MinDate[0]);
            podateTimePicker2.MaxDate = DateTime.Parse(MinDate[1]);
            podateTimePicker2.Value = DateTime.Parse(MinDate[1]);
        }

        private void grnsearchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(grnsearchbox.Text);
                poData.DataSource = programMethod.searchGRNinfo(grnsearchbox.Text.Trim());
                SetRowHeights(poData, POPgSize);
                grnsearchbox.Clear();
            }
        }

        private void auditTypeStatusbox_SelectedValueChanged(object sender, EventArgs e)
        {
            var log = new List<string>
                {
                    "Create/Save",
                    "Update",
                    "Cancel/Delete",
                    "Login",
                    "Logout",
                    "Print",
                    "Enable",
                    "Disable",
                    "LoginFailed",
                    "Notification",
                    "Complete",
               };

            if (auditTypeStatusbox.Text == "Account")
            {


                auditlogStatusbox.DataSource = log.Where(item => item == "Create/Save" || item == "Update" || item == "Login" || item == "Logout" || item == "Enable" || item == "Disable" || item == "LoginFailed").ToList();

            }

            if (auditTypeStatusbox.Text == "Order")
            {
                auditlogStatusbox.DataSource = log.Where(item => item == "Create/Save" || item == "Update" || item == "Cancel/Delete" || item == "Notification").ToList();
            }

            if (auditTypeStatusbox.Text == "OrderAccembly")
            {
                auditlogStatusbox.DataSource = log.Where(item => item == "Create/Save").ToList();
            }


            if (auditTypeStatusbox.Text == "Contact")
            {
                auditlogStatusbox.DataSource = log.Where(item => item == "Create/Save" || item == "Update" || item == "Cancel/Delete").ToList();
            }

            if (auditTypeStatusbox.Text == "Product")
            {
                auditlogStatusbox.DataSource = log.Where(item => item == "Create/Save" || item == "Update" || item == "Cancel/Delete").ToList();
            }

            if (auditTypeStatusbox.Text == "GRN")
            {
                auditlogStatusbox.DataSource = log.Where(item => item == "Create/Save").ToList();
            }

            if (auditTypeStatusbox.Text == "OutstandingOrder")
            {
                auditlogStatusbox.DataSource = log.Where(item => item == "Create/Save" || item == "Cancel/Delete").ToList();
            }

            if (auditTypeStatusbox.Text == "Delivery")
            {
                auditlogStatusbox.DataSource = log.Where(item => item == "Create/Save" || item == "Complete" || item == "Print").ToList();
            }

            if (auditTypeStatusbox.Text == "PurchaseOrder")
            {
                auditlogStatusbox.DataSource = log.Where(item => item == "Create/Save").ToList();
            }

            if (auditTypeStatusbox.Text == "Invoice")
            {
                auditlogStatusbox.DataSource = log.Where(item => item == "Create/Save" || item == "Print").ToList();
            }

            if (auditTypeStatusbox.Text == "Report")
            {
                auditlogStatusbox.DataSource = log.Where(item => item == "Print").ToList();
            }
        }

        private void CSVStockReportButton_Click(object sender, EventArgs e)
        {
            string text = "";
            int countRows = reportStockdata.RowCount;
            int countCells = reportStockdata.Rows[0].Cells.Count;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = Path.Combine(path, "StockReport.csv");

            int fileCount = 1;
            while (File.Exists(filepath))
            {
                filepath = Path.Combine(path, $"StockReport ({fileCount}).csv");
                fileCount++;
            }

            for (int i = 0; i < countCells; i++)
            {
                text += reportStockdata.Columns[i].HeaderText + ", ";
            }
            text = text.TrimEnd(',', ' ');
            text += "\r\n";

            for (int row_index = 0; row_index < countRows; row_index++)
            {
                for (int i = 0; i < countCells; i++)
                {
                    text += reportStockdata.Rows[row_index].Cells[i].Value.ToString() + ", ";
                }
                text = text.TrimEnd(',', ' ');
                text += "\r\n";
            }

            File.WriteAllText(filepath, text);
            MessageBox.Show("Stock Report Saved At Your Desktop!");
            programMethod.LogPrintStockReportCSV(LoginUserID, LoginUserName);
        }

        private void orderReportsearchbtn_Click(object sender, EventArgs e)
        {
            string formDate = reportOrderdateTimePicker.Value.Date.ToString("yyyy-MM-dd");
            string toDate = reportOrderdateTimePicker2.Value.Date.ToString("yyyy-MM-dd");

            if (reportOrderProductCategorybox.SelectedIndex == -1 && reportOrderProductbox.SelectedIndex > -1)
            {
                orderReportdata.DataSource = programMethod.reportFilterByDateAndProductID(formDate, toDate, reportOrderProductbox.Text);
            }
            else if (reportOrderProductbox.SelectedIndex == -1 && reportOrderProductCategorybox.SelectedIndex > -1)
            {
                orderReportdata.DataSource = programMethod.reportFilterByDateAndCategory(formDate, toDate, reportOrderProductCategorybox.Text);

            }
            else if (reportOrderProductbox.SelectedIndex > -1 && reportOrderProductCategorybox.SelectedIndex > -1)
            {
                orderReportdata.DataSource = programMethod.reportFilterByDateAndCategoryANDProductID(formDate, toDate, reportOrderProductbox.Text, reportOrderProductCategorybox.Text);
            }
        }
        private void despatchFirstbtn_Click(object sender, EventArgs e)
        {
            this.DespatchPageIndex = 1;
            this.deliveryData.DataSource = programMethod.GetDeliveryCurrentRecords(this.DespatchPageIndex, DespatchPgSize);

        }

        private void despatchPrevbtn_Click(object sender, EventArgs e)
        {
            if (this.DespatchPageIndex > 1)
            {
                this.DespatchPageIndex--;
                this.deliveryData.DataSource = programMethod.GetDeliveryCurrentRecords(this.DespatchPageIndex, DespatchPgSize);
            }
        }

        private void despatchNextbtn_Click(object sender, EventArgs e)
        {
            if (this.DespatchPageIndex < this.DespatchTotalPage)
            {
                this.DespatchPageIndex++;
                this.deliveryData.DataSource = programMethod.GetDeliveryCurrentRecords(this.DespatchPageIndex, DespatchPgSize);

            }
        }

        private void despatchLastbtn_Click(object sender, EventArgs e)
        {
            this.DespatchPageIndex = DespatchTotalPage;
            this.deliveryData.DataSource = programMethod.GetDeliveryCurrentRecords(this.DespatchPageIndex, DespatchPgSize);
        }

        private void invoiceLastPagebtn_Click(object sender, EventArgs e)
        {
            this.InvoicePageIndex = InvoiceTotalPage;
            this.invoiceData.DataSource = programMethod.GetInvoiceCurrentRecords(this.InvoicePageIndex, InvoicePgSize);
        }

        private void invoicePrevPagebtn_Click(object sender, EventArgs e)
        {
            if (this.InvoicePageIndex > 1)
            {
                this.InvoicePageIndex--;
                this.invoiceData.DataSource = programMethod.GetInvoiceCurrentRecords(this.InvoicePageIndex, InvoicePgSize);
            }
        }

        private void invoiceFirstPagebtn_Click(object sender, EventArgs e)
        {
            this.InvoicePageIndex = 1;
            this.invoiceData.DataSource = programMethod.GetInvoiceCurrentRecords(this.InvoicePageIndex, InvoicePgSize);

        }

        private void invoiceNextPagebtn_Click(object sender, EventArgs e)
        {
            if (this.InvoicePageIndex < this.InvoiceTotalPage)
            {
                this.InvoicePageIndex++;
                this.invoiceData.DataSource = programMethod.GetInvoiceCurrentRecords(this.InvoicePageIndex, InvoicePgSize);

            }
        }

        private void OrderStockReportButton_Click(object sender, EventArgs e)
        {
            ShowPanel(settingpnl);
        }

        private void StockStockReportButton_Click(object sender, EventArgs e)
        {
            ShowPanel(StockReportpnl);
        }

        private void SearchStockReportButton_Click(object sender, EventArgs e)
        {

            if (stockReportCategorybox.SelectedIndex > -1)
            {
                reportStockdata.DataSource = programMethod.reportStockFilterByDateAndCategory(stockReportCategorybox.Text);


            }

        }

        private void outstandingDeletebtn_Click(object sender, EventArgs e)
        {
            if (outstandingIndex == -1)
            {
                MessageBox.Show("Please Select One Option");
            }
            else
            {

                DialogResult box = MessageBox.Show("Do you want to Delete #" + outstandingOrderID + " ?", "Delete OutstandingOrder", MessageBoxButtons.YesNo);
                switch (box)
                {

                    case DialogResult.Yes:
                        programMethod.DeleteOutstandingOrder(outstandingOrderID, outOrderID, outproductID);
                        outstandingdata.DataSource = programMethod.GetOutstandingCurrentRecords(outstandingPageIndex, outstandingPgSize);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void orderaccemblyNewbtn_Click(object sender, EventArgs e)
        {
            orderAccemblyData.DataSource = programMethod.getOrderAccemblyNewOrder();
            if (orderAccemblyData != null)
            {
                orderAccemblyData.Rows[0].Selected = false;
            }

        }

        private void orderaccemblyPartiallybtn_Click(object sender, EventArgs e)
        {
            orderAccemblyData.DataSource = programMethod.getOrderAccemblyPartially();
            if (orderAccemblyData != null)
            {
                orderAccemblyData.Rows[0].Selected = false;
            }
        }

        private void orderaccemblycompletedlbl_Click(object sender, EventArgs e)
        {
            orderAccemblyData.DataSource = programMethod.getOrderAccemblyComplete();
            if (orderAccemblyData != null)
            {
                orderAccemblyData.Rows[0].Selected = false;
            }
        }

        private void outstandingdata_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (outstandingdata != null)
            {
                outstandingdata.Rows[0].Selected = false;
                SetRowHeights(outstandingdata, outstandingPgSize);
            }



        }

        private void stockData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (stockData.Rows.Count > 0)
            {

                SetRowHeights(stockData, StockPgSize);
                StockLevelBoldAndColor();
                stockData.Rows[0].Selected = false;
            }

        }

        private void orderdata_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            if (orderdata.Rows.Count > 0)
            {
                orderdata.Rows[0].Selected = false;
                SetRowHeights(orderdata, OrderPgSize);
                orderIndexlbl.Text = (OrderPgSize * (OrderPageIndex - 1) + 1) + " - " + ((OrderPageIndex - 1) * OrderPgSize + orderdata.RowCount) + " of " + OrderRowCount;
            }

        }

        private void deliveryData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            if (deliveryData.Rows.Count > 0)
            {
                deliveryData.Rows[0].Selected = false;
                SetRowHeights(deliveryData, DespatchPgSize);
                despatchPage.Text = (DespatchPgSize * (DespatchPageIndex - 1) + 1) + " - " + ((DespatchPageIndex - 1) * DespatchPgSize + deliveryData.RowCount) + " of " + DeliveryRowCount;
            }
        }

        private void outstandingViewData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            if (outstandingViewData.Rows.Count > 0)
            {
                outstandingViewData.Rows[0].Selected = false;
            }
        }

        private void userData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {



            if (userData.Rows.Count > 0)
            {
                userData.Rows[0].Selected = false;
            }
        }

        private void invoiceData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {


            if (invoiceData.Rows.Count > 0)
            {
                invoiceData.Rows[0].Selected = false;
                SetRowHeights(invoiceData, InvoicePgSize);
            }
        }


        private void poData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (poData.Rows.Count > 0)
            {
                poData.Rows[0].Selected = false;
                SetRowHeights(poData, POPgSize);
                poIndexlbl.Text = (POPgSize * (POPageIndex - 1) + 1) + " - " + ((POPageIndex - 1) * POPgSize + poData.Rows.Count) + " of " + PORowCount;
            }

            poData.Columns[0].Width = 70;
            poData.Columns[1].Width = 155;
            poData.Columns[2].Width = 140;
            poData.Columns[3].Width = 140;
            poData.Columns[4].Width = 110;
            poData.Columns[5].Width = 110;
            poData.Columns[6].Width = 220;
            poData.Columns[7].Width = 110;
            poData.Columns[8].Width = 200;
        }

        private void grndata_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (grndata.Rows.Count > 0)
            {
                grndata.Rows[0].Selected = false;
            }

        }

        private void orderAccemblyData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {


            if (orderAccemblyData.Rows.Count > 0)
            {
                orderAccemblyData.Rows[0].Selected = false;
            }
        }

        private void suppliersData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {


            if (suppliersData.Rows.Count > 0)
            {
                suppliersData.Rows[0].Selected = false;
            }

            SetRowHeights(suppliersData, SupplierPgSize);
        }

        private void dealersData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dealersData.Rows.Count > 0)
            {
                dealersData.Rows[0].Selected = false;
            }

            SetRowHeights(dealersData, DealerPgSize);

        }

        private void auditLogdata_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (auditLogdata.Rows.Count > 0)
            {
                auditLogdata.Rows[0].Selected = false;
            }

            auditLogdata.Columns[0].Width = 90;
            auditLogdata.Columns[1].Width = 70;
            auditLogdata.Columns[2].Width = 130;
            auditLogdata.Columns[3].Width = 130;
            auditLogdata.Columns[4].Width = 510;
            auditLogdata.Columns[5].Width = 130;

        }
        private void stockSearchBox_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = stockSearchBox.SelectionStart;
            int originalTextLength = stockSearchBox.Text.Length;
            stockSearchBox.Text = new string(stockSearchBox.Text.Distinct().ToArray());
            int lengthDif = originalTextLength - stockSearchBox.Text.Length;
            stockSearchBox.Select(selectionStart - lengthDif, 0);
        }

        private void orderReportdata_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (orderReportdata != null)
            {

                orderReportdata.Rows[0].Selected = false;
            }


        }

        private void DeliverydeliveredDate_ValueChanged(object sender, EventArgs e)
        {

            try
            {

                if (DeliverydeliveredDate.Value.DayOfWeek == DayOfWeek.Saturday || DeliverydeliveredDate.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    DeliverydeliveredDate.BorderColor = Color.Red;
                    orderDate.Visible = true;

                }
                else
                {
                    orderDate.Visible = false;
                    DeliverydeliveredDate.BorderColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                DeliverydeliveredDate.BorderColor = Color.Red;
                orderDate.Visible = true;
            }
        }
    }
}
    