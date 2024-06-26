﻿using Microsoft.VisualBasic.ApplicationServices;
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
        private int GRNPgSize = 15;
        private int GRNPageIndex = 1;
        private int GRNTotalPage = 0;
        //Paging


        //Order datagrid paging
        private int OrderPgSize = 15;
        private int OrderPageIndex = 1;
        private int OrderTotalPage = 0;
        //Paging
        private Button currentButton;
        private string userID;
        private string LoginUserID;
        private string LoginUserName;
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
        private string invoiceID;
        private string invoiceOrderID;
        private string invoiceDealerID;
        private string poID;
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



        public Dashboard()
        {

            InitializeComponent();
            ShowPanel(dashboardpnl);
            closebtn.BringToFront();

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
            DoubleBuffered = true;
            programMethod = new ProgramMethod.ProgramMethod();
            programMethod.CurrentUserIDAndName(LoginUserID, LoginUserName);
            closebtn.BringToFront();
            OrderAccemblybtn.Size = new System.Drawing.Size(166, 56);
            contactsbtn.Size = new System.Drawing.Size(166, 56);
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
            //  orderdata.DataSource = programMethod.orderDateFilter("2024-06-03", "2024-06-18");
            // FirstpageBtnClick(orderdata, "Order", OrderPgSize, OrderPageIndex, orderIndexlbl, OrderRowCount);
            orderdata.Rows[0].Selected = false;
            SetRowHeights(orderdata, OrderPgSize);
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
            string[] array = programMethod.orderLabelinfo();
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
            productOverallLabel();
            stockData.Rows[0].Selected = false;
            SetRowHeights(stockData, StockPgSize);
            StockpageNumlbl.Text = "1" + " - " + StockPgSize + " of " + StockRowCount;
            StockLevelBoldAndColor();

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
            accountSearchBox.AutoSize = false;
            userData.Rows[0].Selected = false;
            //string words = userData.Rows[0].Cells["UserID"].Value.ToString();
            //string lastTwoWords = string.Join(" ", words.Skip(words.Length - ));
            //MessageBox.Show(lastTwoWords);
            //int end = int.Parse(lastTwoWords) + 9;
            accountIndexlbl.Text = "01" + "-" + PgSize.ToString() + " of " + programMethod.getAccountRowCount();
            SetRowHeights(userData, PgSize);
            oustandingPagelbl.Text = "01" + "-" + PgSize + " of " + AccountRowCount;




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
            outstandingdata.DataSource = programMethod.GetOutstandingCurrentRecords(outstandingPageIndex, outstandingPgSize);
            outstandingdata.Rows[0].Selected = false;
            SetRowHeights(outstandingdata, outstandingPgSize);
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
            // contactOverallLabel();
            dealerDatalbl.Text = DealerRowCount.ToString();
            supplierDatalbl.Text = SupplierRowCount.ToString();
            SetRowHeights(dealersData, DealerPgSize);


            contactIndexlbl.Text = "01" + "-" + PgSize.ToString() + " of " + programMethod.getDealersRowCount();
            dealersData.Visible = true;
            suppliersData.Visible = false;

        }



        private void dealersbtn_Click(object sender, EventArgs e)
        {
            isDealerDVG = true;
            //CalculateTotalPages("Dealer");
            dealersData.DataSource = programMethod.GetDealerCurrentRecords(DealerPageIndex, DealerPgSize);
            newSupplierbtn.Visible = false;
            editSupplierbtn.Visible = false;
            newDealerbtn.Visible = true;
            editDealerbtn.Visible = true;
            searchSupplierbtn.Visible = false;
            searchDealerbtn.Visible = true;
            currentDataSourceType = "Dealer";
            // contactOverallLabel();
            dealerDatalbl.Text = DealerRowCount.ToString();
            supplierDatalbl.Text = SupplierRowCount.ToString();
            SetRowHeights(dealersData, DealerPgSize);
            contactIndexlbl.Text = "01" + "-" + PgSize.ToString() + " of " + DealerRowCount;
            dealersData.Visible = true;
            suppliersData.Visible = false;


        }

        private void supplersbtn_Click(object sender, EventArgs e)
        {
            isDealerDVG = false;
            // CalculateTotalPages("Supplier");
            suppliersData.DataSource = programMethod.GetSupplierCurrentRecords(SupplierPageIndex, SupplierPgSize);
            newDealerbtn.Visible = false;
            editDealerbtn.Visible = false;
            newSupplierbtn.Visible = true;
            editSupplierbtn.Visible = true;
            searchSupplierbtn.Visible = true;
            searchDealerbtn.Visible = false;
            currentDataSourceType = "Supplier";
            // contactOverallLabel();
            dealerDatalbl.Text = DealerRowCount.ToString();
            supplierDatalbl.Text = SupplierRowCount.ToString();
            SetRowHeights(suppliersData, SupplierPgSize);
            contactIndexlbl.Text = "01" + "-" + PgSize.ToString() + " of " + SupplierRowCount;
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
                OrderDetails salesOrder = new OrderDetails(OperationMode.View);
                salesOrder.orderView(orderID, dealerID);
                salesOrder.ShowDialog();

            }


        }

        private void newOrderbtn_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder(OperationMode.New);
            createOrder.CurrentUserIDAndName(LoginUserID, LoginUserName);
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
                OrderDetails salesOrder = new OrderDetails(OperationMode.Edit);
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
            auditLogdata.DataSource = programMethod.overallLoginfo();
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
            productForm.productEdit(productID);
            productForm.ShowDialog();
        }



        private void orderpnl_Paint(object sender, PaintEventArgs e)
        {

        }





        //Overall of Stock Data Label
        private void productOverallLabel()
        {

            stockProductDatalbl1.Text = StockRowCount.ToString();
            string[] numberofProduct = programMethod.getStockLabelinfo(stockData); ;
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
                contactIndexlbl.Text = (PgSize * DealerPageIndex - (PgSize - 1)) + "-" + DealerRowCount + " of " + DealerRowCount;
            }
            else
            {
                this.SupplierPageIndex = SupplierTotalPage;
                this.suppliersData.DataSource = programMethod.GetSupplierCurrentRecords(this.SupplierPageIndex, SupplierPgSize);
                SetRowHeights(suppliersData, SupplierPgSize);
                contactIndexlbl.Text = (PgSize * SupplierPageIndex - (PgSize - 1)) + "-" + SupplierRowCount + " of " + SupplierRowCount;
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
            grndata.DataSource = programMethod.GetGRNCurrentRecords(GRNPageIndex, GRNPgSize);
            grnPage.Text = "01" + "-" + GRNPgSize.ToString() + " of " + programMethod.getGRNRowCount();
            SetRowHeights(grndata, GRNPgSize);
            oustandingPagelbl.Text = "01" + "-" + GRNPgSize + " of " + GRNRowCount;

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

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(deliverypnl);
            deliveryData.DataSource = programMethod.overallDeliveryinfo();
            deliveryData.Rows[0].Selected = false;


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

        private void stockSearchBox_TextChanged(object sender, EventArgs e)
        {
            stockData.DataSource = programMethod.searchProductInformation(stockSearchBox.Text.Trim());
            SetRowHeights(stockData, StockPgSize);
        }

        private void orderdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deliverySearchDatebtn_Click(object sender, EventArgs e)
        {
            string formDate = deliverydateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            string toDate = deliverydateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            deliveryData.DataSource = programMethod.searchDeliveryDate(formDate, toDate);
            //SetRowHeights(deliveryData, DeliveryStockPgSize);
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
                    dealersbtn_Click(dealersbtn, EventArgs.Empty);
                }
                else if (currentDataSourceType == "Supplier")
                {
                    programMethod.supplierDel(contactID, productID);
                    supplersbtn_Click(supplersbtn, EventArgs.Empty);
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
                    //rowCount = programMethod.getAccountRowCount();
                    //TotalPage = rowCount / PgSize;
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
            accountIndexlbl.Text = (PgSize * CurrentPageIndex - (PgSize - 1)) + "-" + AccountRowCount + " of " + AccountRowCount;
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
                orderdata.DataSource = programMethod.orderAccemblyDateFilter(formDate, toDate);
            else
            {
                string status = orderStatusCombox.Text.ToString();
                //orderdata.DataSource = programMethod.orderDateStatusFilter(formDate, toDate, status);
                orderdata.DataSource = programMethod.overallLoginfo();
                orderdata.Refresh();

            }
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
            CalculateTotalPages("PO");
            ShowPanel(POpnl);
            poData.DataSource = programMethod.GetPOCurrentRecords(POPageIndex, POPgSize);
            poData.Rows[0].Selected = false;
            SetRowHeights(poData, POPgSize);
            poIndexlbl.Text = "01" + "-" + POPgSize.ToString() + " of " + programMethod.getPORowCount();


        }

        private void invoicebtn_Click(object sender, EventArgs e)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;
            CalculateTotalPages("Invoice");
            ShowPanel(invoicepnl);
            invoiceData.DataSource = programMethod.GetInvoiceCurrentRecords(InvoicePageIndex, InvoicePgSize);
            invoiceIndexlbl.Text = "01" + "-" + PgSize.ToString() + " of " + InvoiceRowCount;
            invoiceData.Rows[0].Selected = false;
            SetRowHeights(invoiceData, InvoicePgSize);


        }

        private void sotckLastPagebtn_Click(object sender, EventArgs e)
        {
            this.StockPageIndex = StockTotalPage;
            this.stockData.DataSource = programMethod.GetStockCurrentRecords(this.StockPageIndex, StockPgSize);
            SetRowHeights(stockData, StockPgSize);
            StockpageNumlbl.Text = (StockPgSize * StockPageIndex - (StockPgSize - 1)) + "-" + StockRowCount + " of " + StockRowCount;
            StockLevelBoldAndColor();
            stockData.Rows[0].Selected = false;
        }

        private void sotckNextPagebtn_Click(object sender, EventArgs e)
        {
            if (this.StockPageIndex < this.StockTotalPage)
            {
                this.StockPageIndex++;
                this.stockData.DataSource = programMethod.GetStockCurrentRecords(this.StockPageIndex, StockPgSize);
                SetRowHeights(stockData, StockPgSize);

                if (StockPageIndex != StockTotalPage)
                {
                    StockpageNumlbl.Text = (StockPgSize * StockPageIndex - (StockPgSize - 1)) + "-" + (StockPgSize * StockPageIndex) + " of " + StockRowCount;
                }
                else
                {
                    StockpageNumlbl.Text = (StockPgSize * StockPageIndex - (StockPgSize - 1)) + "-" + StockRowCount + " of " + StockRowCount;
                }
            }
            StockLevelBoldAndColor();
            stockData.Rows[0].Selected = false;
        }

        private void sotckPrevPagebtn_Click(object sender, EventArgs e)
        {
            if (this.StockPageIndex > 1)
            {
                this.StockPageIndex--;
                this.stockData.DataSource = programMethod.GetStockCurrentRecords(this.StockPageIndex, StockPgSize);
                SetRowHeights(stockData, StockPgSize);
                StockpageNumlbl.Text = (StockPgSize * StockPageIndex - (StockPgSize - 1)) + "-" + (StockPgSize * StockPageIndex) + " of " + StockRowCount;

            }
            StockLevelBoldAndColor();
        }

        private void stockFirstPagebtn_Click(object sender, EventArgs e)
        {
            this.StockPageIndex = 1;
            this.stockData.DataSource = programMethod.GetStockCurrentRecords(this.StockPageIndex, StockPgSize);
            SetRowHeights(stockData, StockPgSize);
            StockpageNumlbl.Text = "1" + "-" + StockPgSize + " of " + StockRowCount;
            StockLevelBoldAndColor();
            stockData.Rows[0].Selected = false;
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

            if (orderStatusCombox.SelectedIndex == -1)
                orderdata.DataSource = programMethod.orderDateFilter(formDate, toDate);
            else
            {
                string status = orderStatusCombox.Text.ToString();
                orderdata.DataSource = programMethod.orderDateStatusFilter(formDate, toDate, status);
            }
            SetRowHeights(orderdata, OrderPgSize);
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
            // orderdata.DataSource = programMethod.overallOrderinfo();
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
                outstandingOrderIDlbl1.Text = dt.Rows[0]["OrderID"].ToString();
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
            orderAccemblyData.Rows[0].Selected = false;
            ShowPanel(OrderAccemblypnl);

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
            SetRowHeights(poData, POPgSize);
            poIndexlbl.Text = (POPgSize * POPageIndex - (POPgSize - 1)) + "-" + PORowCount + " of " + PORowCount;
        }

        private void poFirstPageBtn_Click(object sender, EventArgs e)
        {
            this.POPageIndex = 1;
            poData.DataSource = programMethod.GetPOCurrentRecords(POPageIndex, POPgSize);
            SetRowHeights(poData, POPgSize);
            SetRowHeights(poData, POPgSize);
            poIndexlbl.Text = "1" + " - " + POPgSize + " of " + PORowCount;
        }

        private void poPrevPageBtn_Click(object sender, EventArgs e)
        {
            if (this.POPageIndex > 1)
            {
                this.POPageIndex--;
                this.poData.DataSource = programMethod.GetPOCurrentRecords(this.POPageIndex, POPgSize);
            }
            SetRowHeights(poData, POPgSize);
            poIndexlbl.Text = (POPgSize * POPageIndex - (POPgSize - 1)) + " - " + (POPgSize * CurrentPageIndex) + " of " + PORowCount;
        }

        private void poNextPageBtn_Click(object sender, EventArgs e)
        {
            {
                if (this.POPageIndex < this.POTotalPage)
                {
                    this.POPageIndex++;
                    this.poData.DataSource = programMethod.GetPOCurrentRecords(this.POPageIndex, POPgSize);

                }
                SetRowHeights(poData, POPgSize);

                if (POPageIndex != POTotalPage)
                {
                    poIndexlbl.Text = (POPgSize * POPageIndex - (POPgSize - 1)) + " - " + (POPgSize * POPageIndex) + " of " + PORowCount;
                }
                else
                {
                    poIndexlbl.Text = (POPgSize * POPageIndex - (POPgSize - 1)) + " - " + PORowCount + " of " + PORowCount;
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

            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            TodayTotalOrderValue.Text = "";
            MonthlyTotalSalesValue.Text = "";
            MonthlyTotalOrderValue.Text = "";
            orderReportdata.DataSource = programMethod.getTopSellingProductReport();
            DataTable dt = programMethod.getReportCount();
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
            stockData.Location = new Point(13, 35);
            stockData.Size = new Size(1050, 730);
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

        private void invoiceNextPagebtn_Click(object sender, EventArgs e)
        {

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
                Invoice invoice = new Invoice(invoiceID, invoiceOrderID, invoiceDealerID);
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

        private void invoiceLastPagebtn_Click(object sender, EventArgs e)
        {
            this.InvoicePageIndex = InvoiceTotalPage;
            this.invoiceData.DataSource = programMethod.GetInvoiceCurrentRecords(this.InvoicePageIndex, InvoicePgSize);
            SetRowHeights(invoiceData, InvoicePgSize);
            invoiceIndexlbl.Text = (InvoicePgSize * InvoicePageIndex - (InvoicePgSize - 1)) + " - " + InvoiceRowCount + " of " + InvoiceRowCount;
        }

        private void invoicePrevPagebtn_Click(object sender, EventArgs e)
        {
            if (this.InvoicePageIndex > 1)
            {
                this.InvoicePageIndex--;
                this.invoiceData.DataSource = programMethod.GetInvoiceCurrentRecords(this.InvoicePageIndex, InvoicePgSize);
            }
            SetRowHeights(invoiceData, InvoicePgSize);
            invoiceIndexlbl.Text = (InvoicePgSize * InvoicePageIndex - (InvoicePgSize - 1)) + " - " + (InvoicePgSize * InvoicePageIndex) + " of " + InvoiceRowCount;
        }

        private void invoiceFirstPagebtn_Click(object sender, EventArgs e)
        {

        }

        private void reportOrdercsvbtn_Click(object sender, EventArgs e)
        {
            string text = "";
            int countRows = orderReportdata.RowCount;
            int countCells = orderReportdata.Rows[0].Cells.Count;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = path + "\\salesOrderReport.csv";

            for (int row_index = 0; row_index < orderReportdata.RowCount; row_index++)
            {
                for (int cell_index = 0; cell_index < countCells; cell_index++)
                {
                    text = text + orderReportdata.Rows[row_index].Cells[cell_index].Value.ToString() + ", ";
                }
                text += "\r\n";
            }
            System.IO.File.WriteAllText(filepath, text);
            MessageBox.Show("Sales Order Report Saved");
            programMethod.LogPrintSalesOrderReportCSV(LoginUserID, LoginUserName);
        }


        private void reportShowStockbtn_Click(object sender, EventArgs e)
        {
            ShowPanel(StockReportpnl);
            reportStockdata.DataSource = programMethod.getTopSellingProductReport();

            DataTable dt = programMethod.getStockReportForCategory();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                reportStockPie.Series["Stock"].Points.AddXY(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());
            }
        }
        private void reportOrderpdfbtn_Click(object sender, EventArgs e)
        {

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

        /*   private void POViewbtn_Click(object sender, EventArgs e)
           {
               if (POIndex == -1)
               {
                   MessageBox.Show("Please Select One Invoice");
               }
               else
               {
                   CreatePurchaseOrder PurchaseOrderForm = new CreatePurchaseOrder(OperationMode.View);
                   PurchaseOrderForm.purchaseOrderView(poID);
                   PurchaseOrderForm.ShowDialog();

               }
           }*/

        private void poData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
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
            string formDate = grnDatePicker1.Value.Date.ToString("M/d/yyyy");
            string toDate = grnDatePicker2.Value.Date.ToString("M/d/yyyy");
            grndata.DataSource = programMethod.searchPODate(formDate, toDate);
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
            accountIndexlbl.Text = (GRNPgSize * GRNPageIndex - (GRNPgSize - 1)) + " - " + (GRNPgSize * GRNPageIndex) + " of " + GRNRowCount;
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
            grnPage.Text = (GRNPgSize * GRNPageIndex - (GRNPgSize - 1)) + "-" + GRNRowCount + " of " + GRNRowCount;
        }

        private void orderAccemblySearchbox_KeyDown(object sender, KeyEventArgs e)
        {

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
                    //orderdata.DataSource = programMethod.GetorderCurrentRecords(outstandingPageIndex, outstandingPgSize);
                    orderdata.Refresh();
                else
                    orderdata.DataSource = programMethod.searchOrder(orderSearchbox.Text.Trim());
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
    }
}
    