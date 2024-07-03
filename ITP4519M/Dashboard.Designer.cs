﻿using Org.BouncyCastle.Asn1.Crmf;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static ITP4519M.DeliveryForm;

namespace ITP4519M
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        class CustomDataGridView : DataGridView
        {
            public CustomDataGridView()
            {
                DoubleBuffered = true;
            }
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            DataGridViewCellStyle dataGridViewCellStyle166 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle167 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle168 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle169 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle170 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle171 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle172 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle173 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle174 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle175 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle176 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle177 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle178 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle179 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle180 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle181 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle182 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle183 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            DataGridViewCellStyle dataGridViewCellStyle184 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle185 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle186 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle187 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle188 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle189 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle190 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            DataGridViewCellStyle dataGridViewCellStyle191 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle192 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle193 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle194 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle195 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle196 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle197 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle198 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle199 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle200 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle201 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle202 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle203 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle204 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle205 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle206 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle207 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle208 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle209 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle210 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle211 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle212 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle213 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle214 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle215 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle216 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle217 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            DataGridViewCellStyle dataGridViewCellStyle218 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle219 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle220 = new DataGridViewCellStyle();
            listpnl = new Panel();
            label24 = new Label();
            reportbtn = new Button();
            log_logo = new ImageList(components);
            homebtn = new Button();
            home_logo = new ImageList(components);
            invoicebtn = new Button();
            invoice = new ImageList(components);
            outstandingOrderbtn = new Button();
            Order_logo = new ImageList(components);
            PObtn = new Button();
            deliverybtn = new Button();
            delivery = new ImageList(components);
            GRNbtn = new Button();
            grn = new ImageList(components);
            OrderAccemblybtn = new Button();
            Logbtn = new Button();
            log_new = new ImageList(components);
            contactsbtn = new Button();
            contact_logo = new ImageList(components);
            logoutbtn = new Button();
            setting_logo = new ImageList(components);
            usersbtn = new Button();
            Accounts_logo = new ImageList(components);
            stockbtn = new Button();
            stock_logo = new ImageList(components);
            orderbtn = new Button();
            usertypelbl = new Label();
            namelbl = new Label();
            avatarbox = new PictureBox();
            closebtn = new Button();
            orderpnl = new Panel();
            orderdata = new CustomDataGridView();
            ordercheckColumn = new DataGridViewCheckBoxColumn();
            InvoiceLine1 = new Panel();
            panel11 = new Panel();
            orderFirstPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            orderIndexlbl = new Label();
            orderPrevPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            orderLastPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            orderNextPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            panel10 = new Panel();
            orderStatusCombox = new ComboBox();
            label18 = new Label();
            label13 = new Label();
            orderdateTimePicker1 = new DateTimePicker();
            orderSearchbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            orderdateTimePicker2 = new DateTimePicker();
            label14 = new Label();
            CancelOrderbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            orderSearchbox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            panel9 = new Panel();
            panel26 = new Panel();
            orderAllbox = new TextBox();
            panel27 = new Panel();
            orderActivebox = new TextBox();
            panel30 = new Panel();
            orderCancelbox = new TextBox();
            panel29 = new Panel();
            panel28 = new Panel();
            orderCompletedlbl = new TextBox();
            orderoverallBtn = new Label();
            label11 = new Label();
            label8 = new Label();
            label10 = new Label();
            viewOrderbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            newOrderbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            ordlerlbl = new Label();
            editOrdersbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            contactIndexlbl = new Label();
            outstandingcheckColumn = new DataGridViewCheckBoxColumn();
            deliverycheckColumn = new DataGridViewCheckBoxColumn();
            dealercheckColumn = new DataGridViewCheckBoxColumn();
            suppliercheckColumn = new DataGridViewCheckBoxColumn();
            usercheckColumn = new DataGridViewCheckBoxColumn();
            stockcheckColumn = new DataGridViewCheckBoxColumn();
            pocheckColumn = new DataGridViewCheckBoxColumn();
            orderAccemblyColumn = new DataGridViewCheckBoxColumn();
            stocklbl = new Label();
            stockSummarypnl = new Panel();
            stockDatapanel3 = new Panel();
            stocklbl3 = new Label();
            stockProductDatalbl3 = new Label();
            stockDatapanel1 = new Panel();
            stocklbl1 = new Label();
            stockProductDatalbl1 = new Label();
            stockDatapanel2 = new Panel();
            stockProductDatalbl2 = new Label();
            stocklbl2 = new Label();
            editProductbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            newProductbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            stockData = new CustomDataGridView();
            viewProductbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            accountSearchBtn = new ProgramMethod.ProgramMethod.RoundedButton();
            contactpnl = new Panel();
            contactSupplierCleaerbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            contactDealerclearbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            panel23 = new Panel();
            contactbtnFirstPage = new ProgramMethod.ProgramMethod.RoundedButton();
            contactbtnPrevPage = new ProgramMethod.ProgramMethod.RoundedButton();
            contactbtnLastPage = new ProgramMethod.ProgramMethod.RoundedButton();
            contactbtnNxtPage = new ProgramMethod.ProgramMethod.RoundedButton();
            panel22 = new Panel();
            panel24 = new Panel();
            label35 = new Label();
            dealerDatalbl = new Label();
            panel25 = new Panel();
            supplierDatalbl = new Label();
            label38 = new Label();
            contactGroupBox = new GroupBox();
            supplersbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            dealersbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            delContactbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            searchContactbtn = new TextBox();
            newDealerbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            searchSupplierbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            searchDealerbtn = new Button();
            editSupplierbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            newSupplierbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            suppliersData = new CustomDataGridView();
            dealersData = new CustomDataGridView();
            editDealerbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            dataGridViewCheckBoxColumn5 = new DataGridViewCheckBoxColumn();
            panel43 = new Panel();
            outstandingViewData = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            FollowUp = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            panel42 = new Panel();
            viewoutstandingOrderExecptDatelbl = new Label();
            label58 = new Label();
            viewoutstandingOrderDatelbl = new Label();
            label56 = new Label();
            outstandingOrderIDlbl = new Label();
            outstandingOrderIDlbl2 = new Label();
            oustandingViewDeliverylbl = new Label();
            outstandingViewEmaillbl = new Label();
            outstandingViewPhoneNumlbl = new Label();
            outstandingViewContactNamelbl = new Label();
            outstandingViewDealerNamelbl = new Label();
            outstandingViewDealerIDlbl = new Label();
            outstandingDealerIDlbl = new Label();
            outstandingDealerNamelbl = new Label();
            outstandingDeliveryAddresslbl = new Label();
            outstandingContactNamelbl = new Label();
            outstandingEmaillbl = new Label();
            outstandingPhonelbl = new Label();
            button23 = new Button();
            outstandingCancelbtn = new Button();
            panel44 = new Panel();
            label36 = new Label();
            outstandingIDlbl = new Label();
            outstandingBackbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            label2 = new Label();
            settingpnl = new Panel();
            reportShowStockbtn = new Button();
            reportShowOrderbtn = new Button();
            panel31 = new Panel();
            label15 = new Label();
            orderchart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel33 = new Panel();
            MonthlyTotalOrderValue = new Label();
            MonthlyTotalOrder = new Label();
            panel34 = new Panel();
            MonthlyTotalSalesValue = new Label();
            MonthlyTotalSales = new Label();
            orderchart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel35 = new Panel();
            TodayTotalOrderValue = new Label();
            TodayTotalOrder = new Label();
            panel36 = new Panel();
            reportInvoicelbl = new Label();
            TodayTotalSales = new Label();
            reportOrderpdfbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            panel32 = new Panel();
            dateTimePicker3 = new DateTimePicker();
            label21 = new Label();
            orderReportsearchbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            label30 = new Label();
            orderReportClearbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            dateTimePicker4 = new DateTimePicker();
            orderReportdata = new CustomDataGridView();
            reportOrdercsvbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            reportlbl = new Label();
            userspnl = new Panel();
            groupBox3 = new GroupBox();
            accountSearchBox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            editAccountbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            viewAccountbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            disableAccountbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            enableAccountbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            panel7 = new Panel();
            accountbtnFirstPage = new ProgramMethod.ProgramMethod.RoundedButton();
            accountIndexlbl = new Label();
            accountbtnPrevPage = new ProgramMethod.ProgramMethod.RoundedButton();
            accountbtnLastPage = new ProgramMethod.ProgramMethod.RoundedButton();
            accountbtnNxtPage = new ProgramMethod.ProgramMethod.RoundedButton();
            panel3 = new Panel();
            panel4 = new Panel();
            label7 = new Label();
            accountUserCountlbl3 = new Label();
            panel5 = new Panel();
            label9 = new Label();
            accountUserCountlbl = new Label();
            panel6 = new Panel();
            accountUserCountlbl2 = new Label();
            label12 = new Label();
            newAccountbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            userData = new CustomDataGridView();
            userslbl = new Label();
            inventorypnl = new Panel();
            panel54 = new Panel();
            stockOutofStockbox = new TextBox();
            stockDangerbox = new TextBox();
            stockReOrderbox = new TextBox();
            panel57 = new Panel();
            panel58 = new Panel();
            panel59 = new Panel();
            panel63 = new Panel();
            label37 = new Label();
            label40 = new Label();
            label60 = new Label();
            panel55 = new Panel();
            ZoomProductbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            panel8 = new Panel();
            stockFirstPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            StockpageNumlbl = new Label();
            sotckPrevPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            sotckLastPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            sotckNextPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            delProductbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            stockSearchBox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            dashboardpnl = new Panel();
            dashordervalueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel53 = new Panel();
            panel39 = new Panel();
            dashOrderlbl = new Label();
            label41 = new Label();
            panel40 = new Panel();
            dashRevenuelbl = new Label();
            label43 = new Label();
            panel38 = new Panel();
            dashOutlbl = new Label();
            label39 = new Label();
            panel37 = new Panel();
            dashInlbl = new Label();
            label34 = new Label();
            panel52 = new Panel();
            panel41 = new Panel();
            label57 = new Label();
            label59 = new Label();
            label1 = new Label();
            logpnl = new Panel();
            panel19 = new Panel();
            auditTypeStatusbox = new ComboBox();
            auditlogStatusbox = new ComboBox();
            label62 = new Label();
            label16 = new Label();
            roundedTextBox3 = new ProgramMethod.ProgramMethod.RoundedTextBox();
            logdateTimePicker1 = new DateTimePicker();
            label28 = new Label();
            SeachLogButton = new ProgramMethod.ProgramMethod.RoundedButton();
            label29 = new Label();
            ClearLogButton = new ProgramMethod.ProgramMethod.RoundedButton();
            logdateTimePicker2 = new DateTimePicker();
            auditLogdata = new CustomDataGridView();
            loglbl = new Label();
            dataGridViewCheckBoxColumn3 = new DataGridViewCheckBoxColumn();
            OrderAccemblypnl = new Panel();
            panel18 = new Panel();
            panel60 = new Panel();
            textBox1 = new TextBox();
            panel66 = new Panel();
            textBox2 = new TextBox();
            panel67 = new Panel();
            label19 = new Label();
            label27 = new Label();
            orderaccemblySearchpnl = new Panel();
            orderAccemblySearchbox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            orderAccemblyViewbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            orderAccemblySearchbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            orderAccemblyClearbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            orderAccemblydateTimePicker = new DateTimePicker();
            label5 = new Label();
            orderAccemblydateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            orderAccemblyData = new DataGridView();
            orderAccemblylbl = new Label();
            accemblyCreatebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            GRNpnl = new Panel();
            panel12 = new Panel();
            grnFirstPage = new ProgramMethod.ProgramMethod.RoundedButton();
            grnPage = new Label();
            grnPrevPage = new ProgramMethod.ProgramMethod.RoundedButton();
            grnLastPage = new ProgramMethod.ProgramMethod.RoundedButton();
            grnNextPage = new ProgramMethod.ProgramMethod.RoundedButton();
            panel1 = new Panel();
            grnsearchbox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            grnDatePicker1 = new DateTimePicker();
            grnlbl1 = new Label();
            grncl = new ProgramMethod.ProgramMethod.RoundedButton();
            grnDatePicker2 = new DateTimePicker();
            grnSearchBtn = new ProgramMethod.ProgramMethod.RoundedButton();
            grnlbl2 = new Label();
            grnAddNoteBtn = new ProgramMethod.ProgramMethod.RoundedButton();
            grndata = new CustomDataGridView();
            grncheckColumn = new DataGridViewCheckBoxColumn();
            GRNlbl = new Label();
            deliverypnl = new Panel();
            panel56 = new Panel();
            panel61 = new Panel();
            textBox3 = new TextBox();
            panel62 = new Panel();
            textBox5 = new TextBox();
            panel64 = new Panel();
            panel65 = new Panel();
            textBox7 = new TextBox();
            label42 = new Label();
            label61 = new Label();
            label63 = new Label();
            panel13 = new Panel();
            roundedButton9 = new ProgramMethod.ProgramMethod.RoundedButton();
            label17 = new Label();
            roundedButton10 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton11 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton12 = new ProgramMethod.ProgramMethod.RoundedButton();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            deliverycompletedeliverybtn = new ProgramMethod.ProgramMethod.RoundedButton();
            deliverySearchIDbox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            deliverydateTimePicker2 = new DateTimePicker();
            deliveryViewDNbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            deliveryclearbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            deliverydateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            deliverySearchDatebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            deliveryData = new CustomDataGridView();
            deliveryAddbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            deliverylbl = new Label();
            deliveryCompletepnl = new Panel();
            deliveryShippingdatelbl = new Label();
            DeliverydeliveredDate = new DateTimePicker();
            label20 = new Label();
            deliveryBackbtn = new Button();
            deliveryDeliveryIDlbl = new Label();
            label4 = new Label();
            deliveryCompletebtn = new Button();
            DeliveryCancelbtn = new Button();
            deliveryNextbtn = new Button();
            POpnl = new Panel();
            poData = new CustomDataGridView();
            panel16 = new Panel();
            poFirstPageBtn = new ProgramMethod.ProgramMethod.RoundedButton();
            poIndexlbl = new Label();
            poPrevPageBtn = new ProgramMethod.ProgramMethod.RoundedButton();
            poLastPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            poNextPageBtn = new ProgramMethod.ProgramMethod.RoundedButton();
            AddOrderPoButton = new ProgramMethod.ProgramMethod.RoundedButton();
            POlbl = new Label();
            panel17 = new Panel();
            roundedButton1 = new ProgramMethod.ProgramMethod.RoundedButton();
            groupBox1 = new GroupBox();
            dateFilterbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            label25 = new Label();
            podateTimePicker1 = new DateTimePicker();
            podateTimePicker2 = new DateTimePicker();
            label26 = new Label();
            CompletePoButton = new ProgramMethod.ProgramMethod.RoundedButton();
            poSearchbox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            dataGridViewCheckBoxColumn6 = new DataGridViewCheckBoxColumn();
            dataGridViewCheckBoxColumn2 = new DataGridViewCheckBoxColumn();
            outstandingOrderpnl = new Panel();
            panel20 = new Panel();
            outstandingFirstPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            oustadningPrevPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            outstandingLastPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            outstandingNextPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            oustandingPagelbl = new Label();
            panel21 = new Panel();
            groupBox4 = new GroupBox();
            outstandingDeletebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            outstandingSearchbox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            label31 = new Label();
            outstandingViewbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            outstandingdateTimePicker2 = new DateTimePicker();
            outstandingdateTimePicker1 = new DateTimePicker();
            outstandingClearBtn = new ProgramMethod.ProgramMethod.RoundedButton();
            label32 = new Label();
            outstandingSearchbtn = new ProgramMethod.ProgramMethod.RoundedButton();
            outstandingdata = new CustomDataGridView();
            outstandingOrderlbl = new Label();
            dateTimePicker8 = new DateTimePicker();
            customDataGridView4 = new CustomDataGridView();
            dataGridViewCheckBoxColumn4 = new DataGridViewCheckBoxColumn();
            button24 = new Button();
            invoicepnl = new Panel();
            panel14 = new Panel();
            invoiceFirstPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            invoiceIndexlbl = new Label();
            invoicePrevPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            invoiceLastPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            invoiceNextPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            panel15 = new Panel();
            invoiceCompleteBtn = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedTextBox1 = new ProgramMethod.ProgramMethod.RoundedTextBox();
            invoiceViewBtn = new ProgramMethod.ProgramMethod.RoundedButton();
            InvoicedateTimePicker1 = new DateTimePicker();
            label22 = new Label();
            invoiceSearchBtn = new ProgramMethod.ProgramMethod.RoundedButton();
            label23 = new Label();
            invoiceClearBtn = new ProgramMethod.ProgramMethod.RoundedButton();
            invoicedateTimePicker2 = new DateTimePicker();
            invoiceData = new CustomDataGridView();
            invoicecheckbox = new DataGridViewCheckBoxColumn();
            invoicelbl = new Label();
            outstandingViewpnl = new Panel();
            panel45 = new Panel();
            StockReportpnl = new Panel();
            reportStockPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            StockStockReportButton = new ProgramMethod.ProgramMethod.RoundedButton();
            OrderStockReportButton = new ProgramMethod.ProgramMethod.RoundedButton();
            panel46 = new Panel();
            label44 = new Label();
            panel47 = new Panel();
            label45 = new Label();
            label46 = new Label();
            panel48 = new Panel();
            label47 = new Label();
            label48 = new Label();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel49 = new Panel();
            label49 = new Label();
            label50 = new Label();
            panel50 = new Panel();
            label51 = new Label();
            label52 = new Label();
            PDFStockReportButton = new ProgramMethod.ProgramMethod.RoundedButton();
            panel51 = new Panel();
            dateTimePicker7 = new DateTimePicker();
            label53 = new Label();
            SearchStockReportButton = new ProgramMethod.ProgramMethod.RoundedButton();
            label54 = new Label();
            ClearStockReportButton = new ProgramMethod.ProgramMethod.RoundedButton();
            dateTimePicker9 = new DateTimePicker();
            reportStockdata = new CustomDataGridView();
            CSVStockReportButton = new ProgramMethod.ProgramMethod.RoundedButton();
            label55 = new Label();
            listpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatarbox).BeginInit();
            orderpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderdata).BeginInit();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            panel30.SuspendLayout();
            panel28.SuspendLayout();
            stockSummarypnl.SuspendLayout();
            stockDatapanel3.SuspendLayout();
            stockDatapanel1.SuspendLayout();
            stockDatapanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockData).BeginInit();
            contactpnl.SuspendLayout();
            panel23.SuspendLayout();
            panel22.SuspendLayout();
            panel24.SuspendLayout();
            panel25.SuspendLayout();
            contactGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)suppliersData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealersData).BeginInit();
            panel43.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)outstandingViewData).BeginInit();
            panel42.SuspendLayout();
            panel44.SuspendLayout();
            settingpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderchart2).BeginInit();
            panel33.SuspendLayout();
            panel34.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderchart1).BeginInit();
            panel35.SuspendLayout();
            panel36.SuspendLayout();
            panel32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderReportdata).BeginInit();
            userspnl.SuspendLayout();
            groupBox3.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userData).BeginInit();
            inventorypnl.SuspendLayout();
            panel54.SuspendLayout();
            panel8.SuspendLayout();
            dashboardpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashordervalueChart).BeginInit();
            panel53.SuspendLayout();
            panel39.SuspendLayout();
            panel40.SuspendLayout();
            panel38.SuspendLayout();
            panel37.SuspendLayout();
            panel41.SuspendLayout();
            logpnl.SuspendLayout();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)auditLogdata).BeginInit();
            OrderAccemblypnl.SuspendLayout();
            panel18.SuspendLayout();
            panel60.SuspendLayout();
            panel66.SuspendLayout();
            orderaccemblySearchpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderAccemblyData).BeginInit();
            GRNpnl.SuspendLayout();
            panel12.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grndata).BeginInit();
            deliverypnl.SuspendLayout();
            panel56.SuspendLayout();
            panel61.SuspendLayout();
            panel62.SuspendLayout();
            panel65.SuspendLayout();
            panel13.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deliveryData).BeginInit();
            deliveryCompletepnl.SuspendLayout();
            POpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)poData).BeginInit();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            groupBox1.SuspendLayout();
            outstandingOrderpnl.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)outstandingdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customDataGridView4).BeginInit();
            invoicepnl.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)invoiceData).BeginInit();
            outstandingViewpnl.SuspendLayout();
            StockReportpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reportStockPie).BeginInit();
            panel47.SuspendLayout();
            panel48.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            panel49.SuspendLayout();
            panel50.SuspendLayout();
            panel51.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reportStockdata).BeginInit();
            SuspendLayout();
            // 
            // listpnl
            // 
            listpnl.BackColor = SystemColors.MenuText;
            listpnl.BackgroundImageLayout = ImageLayout.Stretch;
            listpnl.Controls.Add(label24);
            listpnl.Controls.Add(reportbtn);
            listpnl.Controls.Add(homebtn);
            listpnl.Controls.Add(invoicebtn);
            listpnl.Controls.Add(outstandingOrderbtn);
            listpnl.Controls.Add(PObtn);
            listpnl.Controls.Add(deliverybtn);
            listpnl.Controls.Add(GRNbtn);
            listpnl.Controls.Add(OrderAccemblybtn);
            listpnl.Controls.Add(Logbtn);
            listpnl.Controls.Add(contactsbtn);
            listpnl.Controls.Add(logoutbtn);
            listpnl.Controls.Add(usersbtn);
            listpnl.Controls.Add(stockbtn);
            listpnl.Controls.Add(orderbtn);
            listpnl.Controls.Add(usertypelbl);
            listpnl.Controls.Add(namelbl);
            listpnl.Controls.Add(avatarbox);
            listpnl.Location = new Point(0, 1);
            listpnl.Name = "listpnl";
            listpnl.Size = new Size(175, 788);
            listpnl.TabIndex = 14;
            listpnl.Paint += listpnl_Paint;
            listpnl.MouseDown += Dashboard_MouseDown;
            listpnl.MouseMove += Dashboard_MouseMove;
            listpnl.MouseUp += Dashboard_MouseUp;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = SystemColors.Window;
            label24.Location = new Point(45, 762);
            label24.Name = "label24";
            label24.Size = new Size(72, 15);
            label24.TabIndex = 17;
            label24.Text = "Version 2.4.7";
            // 
            // reportbtn
            // 
            reportbtn.AutoSize = true;
            reportbtn.FlatAppearance.BorderSize = 0;
            reportbtn.FlatStyle = FlatStyle.Flat;
            reportbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportbtn.ForeColor = Color.White;
            reportbtn.ImageAlign = ContentAlignment.MiddleLeft;
            reportbtn.ImageIndex = 0;
            reportbtn.ImageList = log_logo;
            reportbtn.Location = new Point(22, 649);
            reportbtn.Name = "reportbtn";
            reportbtn.Size = new Size(145, 38);
            reportbtn.TabIndex = 16;
            reportbtn.Text = "         Reports";
            reportbtn.TextAlign = ContentAlignment.MiddleLeft;
            reportbtn.UseVisualStyleBackColor = true;
            reportbtn.Click += reportbtn_Click;
            // 
            // log_logo
            // 
            log_logo.ColorDepth = ColorDepth.Depth24Bit;
            log_logo.ImageStream = (ImageListStreamer)resources.GetObject("log_logo.ImageStream");
            log_logo.TransparentColor = Color.Transparent;
            log_logo.Images.SetKeyName(0, "log_logo.png");
            // 
            // homebtn
            // 
            homebtn.AutoSize = true;
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homebtn.ForeColor = Color.White;
            homebtn.ImageIndex = 0;
            homebtn.ImageList = home_logo;
            homebtn.Location = new Point(60, 10);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(54, 34);
            homebtn.TabIndex = 15;
            homebtn.TextAlign = ContentAlignment.MiddleRight;
            homebtn.UseVisualStyleBackColor = true;
            homebtn.Click += homebtn_Click;
            // 
            // home_logo
            // 
            home_logo.ColorDepth = ColorDepth.Depth24Bit;
            home_logo.ImageStream = (ImageListStreamer)resources.GetObject("home_logo.ImageStream");
            home_logo.TransparentColor = Color.Transparent;
            home_logo.Images.SetKeyName(0, "home_button.png");
            // 
            // invoicebtn
            // 
            invoicebtn.AutoSize = true;
            invoicebtn.FlatAppearance.BorderSize = 0;
            invoicebtn.FlatStyle = FlatStyle.Flat;
            invoicebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoicebtn.ForeColor = Color.White;
            invoicebtn.ImageAlign = ContentAlignment.MiddleLeft;
            invoicebtn.ImageIndex = 0;
            invoicebtn.ImageList = invoice;
            invoicebtn.Location = new Point(22, 514);
            invoicebtn.Name = "invoicebtn";
            invoicebtn.Size = new Size(145, 42);
            invoicebtn.TabIndex = 14;
            invoicebtn.Text = "         Invoice";
            invoicebtn.TextAlign = ContentAlignment.MiddleLeft;
            invoicebtn.UseVisualStyleBackColor = true;
            invoicebtn.Click += invoicebtn_Click;
            // 
            // invoice
            // 
            invoice.ColorDepth = ColorDepth.Depth32Bit;
            invoice.ImageStream = (ImageListStreamer)resources.GetObject("invoice.ImageStream");
            invoice.TransparentColor = Color.Transparent;
            invoice.Images.SetKeyName(0, "invoice.png");
            // 
            // outstandingOrderbtn
            // 
            outstandingOrderbtn.AutoSize = true;
            outstandingOrderbtn.FlatAppearance.BorderSize = 0;
            outstandingOrderbtn.FlatStyle = FlatStyle.Flat;
            outstandingOrderbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingOrderbtn.ForeColor = Color.White;
            outstandingOrderbtn.ImageAlign = ContentAlignment.MiddleLeft;
            outstandingOrderbtn.ImageIndex = 0;
            outstandingOrderbtn.ImageList = Order_logo;
            outstandingOrderbtn.Location = new Point(22, 469);
            outstandingOrderbtn.Name = "outstandingOrderbtn";
            outstandingOrderbtn.Size = new Size(165, 56);
            outstandingOrderbtn.TabIndex = 13;
            outstandingOrderbtn.Text = "         Outstanding\r\n         Order";
            outstandingOrderbtn.TextAlign = ContentAlignment.MiddleLeft;
            outstandingOrderbtn.UseVisualStyleBackColor = true;
            outstandingOrderbtn.Click += outstandingOrderbtn_Click;
            // 
            // Order_logo
            // 
            Order_logo.ColorDepth = ColorDepth.Depth24Bit;
            Order_logo.ImageStream = (ImageListStreamer)resources.GetObject("Order_logo.ImageStream");
            Order_logo.TransparentColor = Color.Transparent;
            Order_logo.Images.SetKeyName(0, "order_logo.png");
            // 
            // PObtn
            // 
            PObtn.AutoSize = true;
            PObtn.FlatAppearance.BorderSize = 0;
            PObtn.FlatStyle = FlatStyle.Flat;
            PObtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PObtn.ForeColor = Color.White;
            PObtn.ImageAlign = ContentAlignment.MiddleLeft;
            PObtn.ImageIndex = 0;
            PObtn.ImageList = Order_logo;
            PObtn.Location = new Point(22, 424);
            PObtn.Name = "PObtn";
            PObtn.Size = new Size(145, 56);
            PObtn.TabIndex = 12;
            PObtn.Text = "         Purchase\r\n         Order ";
            PObtn.TextAlign = ContentAlignment.MiddleLeft;
            PObtn.UseVisualStyleBackColor = true;
            PObtn.Click += PObtn_Click;
            // 
            // deliverybtn
            // 
            deliverybtn.AutoSize = true;
            deliverybtn.FlatAppearance.BorderSize = 0;
            deliverybtn.FlatStyle = FlatStyle.Flat;
            deliverybtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliverybtn.ForeColor = Color.White;
            deliverybtn.ImageAlign = ContentAlignment.MiddleLeft;
            deliverybtn.ImageIndex = 0;
            deliverybtn.ImageList = delivery;
            deliverybtn.Location = new Point(22, 379);
            deliverybtn.Name = "deliverybtn";
            deliverybtn.Size = new Size(145, 42);
            deliverybtn.TabIndex = 11;
            deliverybtn.Text = "         Delivery";
            deliverybtn.TextAlign = ContentAlignment.MiddleLeft;
            deliverybtn.UseVisualStyleBackColor = true;
            deliverybtn.Click += deliverybtn_Click;
            // 
            // delivery
            // 
            delivery.ColorDepth = ColorDepth.Depth32Bit;
            delivery.ImageStream = (ImageListStreamer)resources.GetObject("delivery.ImageStream");
            delivery.TransparentColor = Color.Transparent;
            delivery.Images.SetKeyName(0, "delivery.png");
            // 
            // GRNbtn
            // 
            GRNbtn.AutoSize = true;
            GRNbtn.FlatAppearance.BorderSize = 0;
            GRNbtn.FlatStyle = FlatStyle.Flat;
            GRNbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GRNbtn.ForeColor = Color.White;
            GRNbtn.ImageAlign = ContentAlignment.MiddleLeft;
            GRNbtn.ImageIndex = 0;
            GRNbtn.ImageList = grn;
            GRNbtn.Location = new Point(22, 334);
            GRNbtn.Name = "GRNbtn";
            GRNbtn.Size = new Size(145, 42);
            GRNbtn.TabIndex = 10;
            GRNbtn.Text = "         GRN    ";
            GRNbtn.TextAlign = ContentAlignment.MiddleLeft;
            GRNbtn.UseVisualStyleBackColor = true;
            GRNbtn.Click += GRNbtn_Click;
            // 
            // grn
            // 
            grn.ColorDepth = ColorDepth.Depth32Bit;
            grn.ImageStream = (ImageListStreamer)resources.GetObject("grn.ImageStream");
            grn.TransparentColor = Color.Transparent;
            grn.Images.SetKeyName(0, "grn.png");
            // 
            // OrderAccemblybtn
            // 
            OrderAccemblybtn.AutoSize = true;
            OrderAccemblybtn.FlatAppearance.BorderSize = 0;
            OrderAccemblybtn.FlatStyle = FlatStyle.Flat;
            OrderAccemblybtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderAccemblybtn.ForeColor = Color.White;
            OrderAccemblybtn.ImageAlign = ContentAlignment.MiddleLeft;
            OrderAccemblybtn.ImageIndex = 0;
            OrderAccemblybtn.ImageList = Order_logo;
            OrderAccemblybtn.Location = new Point(22, 244);
            OrderAccemblybtn.Name = "OrderAccemblybtn";
            OrderAccemblybtn.Size = new Size(148, 56);
            OrderAccemblybtn.TabIndex = 9;
            OrderAccemblybtn.Text = "         Order\r\n         Accembly ";
            OrderAccemblybtn.TextAlign = ContentAlignment.MiddleLeft;
            OrderAccemblybtn.UseVisualStyleBackColor = true;
            OrderAccemblybtn.Click += OrderAccemblybtn_Click;
            // 
            // Logbtn
            // 
            Logbtn.AutoSize = true;
            Logbtn.FlatAppearance.BorderSize = 0;
            Logbtn.FlatStyle = FlatStyle.Flat;
            Logbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logbtn.ForeColor = Color.White;
            Logbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Logbtn.ImageIndex = 0;
            Logbtn.ImageList = log_new;
            Logbtn.Location = new Point(22, 604);
            Logbtn.Name = "Logbtn";
            Logbtn.Size = new Size(145, 38);
            Logbtn.TabIndex = 8;
            Logbtn.Text = "         Audit      ";
            Logbtn.TextAlign = ContentAlignment.MiddleLeft;
            Logbtn.UseVisualStyleBackColor = true;
            Logbtn.Click += Logbtn_Click;
            // 
            // log_new
            // 
            log_new.ColorDepth = ColorDepth.Depth32Bit;
            log_new.ImageStream = (ImageListStreamer)resources.GetObject("log_new.ImageStream");
            log_new.TransparentColor = Color.Transparent;
            log_new.Images.SetKeyName(0, "log.png");
            // 
            // contactsbtn
            // 
            contactsbtn.AutoSize = true;
            contactsbtn.FlatAppearance.BorderSize = 0;
            contactsbtn.FlatStyle = FlatStyle.Flat;
            contactsbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactsbtn.ForeColor = Color.White;
            contactsbtn.ImageAlign = ContentAlignment.MiddleLeft;
            contactsbtn.ImageIndex = 0;
            contactsbtn.ImageList = contact_logo;
            contactsbtn.Location = new Point(22, 289);
            contactsbtn.Name = "contactsbtn";
            contactsbtn.Size = new Size(161, 56);
            contactsbtn.TabIndex = 7;
            contactsbtn.Text = "         Contacts\r\n         Information";
            contactsbtn.TextAlign = ContentAlignment.MiddleLeft;
            contactsbtn.UseVisualStyleBackColor = true;
            contactsbtn.Click += contactsbtn_Click;
            // 
            // contact_logo
            // 
            contact_logo.ColorDepth = ColorDepth.Depth24Bit;
            contact_logo.ImageStream = (ImageListStreamer)resources.GetObject("contact_logo.ImageStream");
            contact_logo.TransparentColor = Color.Transparent;
            contact_logo.Images.SetKeyName(0, "contact_new.jpg");
            // 
            // logoutbtn
            // 
            logoutbtn.AutoSize = true;
            logoutbtn.FlatAppearance.BorderSize = 0;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutbtn.ForeColor = Color.White;
            logoutbtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutbtn.ImageIndex = 0;
            logoutbtn.ImageList = setting_logo;
            logoutbtn.Location = new Point(22, 694);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(145, 38);
            logoutbtn.TabIndex = 6;
            logoutbtn.Text = "         Sign Out";
            logoutbtn.TextAlign = ContentAlignment.MiddleLeft;
            logoutbtn.UseVisualStyleBackColor = true;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // setting_logo
            // 
            setting_logo.ColorDepth = ColorDepth.Depth24Bit;
            setting_logo.ImageStream = (ImageListStreamer)resources.GetObject("setting_logo.ImageStream");
            setting_logo.TransparentColor = Color.Transparent;
            setting_logo.Images.SetKeyName(0, "system_logo.png");
            // 
            // usersbtn
            // 
            usersbtn.AutoSize = true;
            usersbtn.BackColor = Color.Black;
            usersbtn.FlatAppearance.BorderSize = 0;
            usersbtn.FlatStyle = FlatStyle.Flat;
            usersbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usersbtn.ForeColor = Color.White;
            usersbtn.ImageAlign = ContentAlignment.MiddleLeft;
            usersbtn.ImageIndex = 0;
            usersbtn.ImageList = Accounts_logo;
            usersbtn.Location = new Point(22, 559);
            usersbtn.Name = "usersbtn";
            usersbtn.Size = new Size(145, 38);
            usersbtn.TabIndex = 5;
            usersbtn.Text = "         Account";
            usersbtn.TextAlign = ContentAlignment.MiddleLeft;
            usersbtn.UseVisualStyleBackColor = true;
            usersbtn.Click += usersbtn_Click;
            usersbtn.MouseEnter += userbtn_MouseEnter;
            // 
            // Accounts_logo
            // 
            Accounts_logo.ColorDepth = ColorDepth.Depth24Bit;
            Accounts_logo.ImageStream = (ImageListStreamer)resources.GetObject("Accounts_logo.ImageStream");
            Accounts_logo.TransparentColor = Color.Transparent;
            Accounts_logo.Images.SetKeyName(0, "accounts_logo.png");
            // 
            // stockbtn
            // 
            stockbtn.AutoSize = true;
            stockbtn.FlatAppearance.BorderSize = 0;
            stockbtn.FlatStyle = FlatStyle.Flat;
            stockbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockbtn.ForeColor = Color.White;
            stockbtn.ImageAlign = ContentAlignment.MiddleLeft;
            stockbtn.ImageIndex = 0;
            stockbtn.ImageList = stock_logo;
            stockbtn.Location = new Point(22, 199);
            stockbtn.Name = "stockbtn";
            stockbtn.Size = new Size(145, 42);
            stockbtn.TabIndex = 4;
            stockbtn.Text = "         Stock  ";
            stockbtn.TextAlign = ContentAlignment.MiddleLeft;
            stockbtn.UseVisualStyleBackColor = true;
            stockbtn.Click += inventorybtn_Click;
            // 
            // stock_logo
            // 
            stock_logo.ColorDepth = ColorDepth.Depth24Bit;
            stock_logo.ImageStream = (ImageListStreamer)resources.GetObject("stock_logo.ImageStream");
            stock_logo.TransparentColor = Color.Transparent;
            stock_logo.Images.SetKeyName(0, "stock_logo.png");
            // 
            // orderbtn
            // 
            orderbtn.AutoSize = true;
            orderbtn.FlatAppearance.BorderSize = 0;
            orderbtn.FlatStyle = FlatStyle.Flat;
            orderbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderbtn.ForeColor = Color.White;
            orderbtn.ImageAlign = ContentAlignment.MiddleLeft;
            orderbtn.ImageIndex = 0;
            orderbtn.ImageList = Order_logo;
            orderbtn.Location = new Point(22, 154);
            orderbtn.Name = "orderbtn";
            orderbtn.Size = new Size(155, 43);
            orderbtn.TabIndex = 3;
            orderbtn.Text = "         Salse Order  ";
            orderbtn.TextAlign = ContentAlignment.MiddleLeft;
            orderbtn.UseVisualStyleBackColor = true;
            orderbtn.Click += orderbtn_Click;
            // 
            // usertypelbl
            // 
            usertypelbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usertypelbl.ForeColor = Color.White;
            usertypelbl.Location = new Point(43, 124);
            usertypelbl.Name = "usertypelbl";
            usertypelbl.Size = new Size(92, 23);
            usertypelbl.TabIndex = 2;
            usertypelbl.Text = "Type";
            usertypelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namelbl.ForeColor = Color.White;
            namelbl.Location = new Point(32, 100);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(85, 20);
            namelbl.TabIndex = 1;
            namelbl.Text = "UserName";
            namelbl.TextAlign = ContentAlignment.MiddleCenter;
            namelbl.Click += namelbl_Click;
            // 
            // avatarbox
            // 
            avatarbox.BackgroundImage = Properties.Resources.company_logo;
            avatarbox.BackgroundImageLayout = ImageLayout.Stretch;
            avatarbox.Location = new Point(3, 50);
            avatarbox.Name = "avatarbox";
            avatarbox.Size = new Size(172, 49);
            avatarbox.TabIndex = 0;
            avatarbox.TabStop = false;
            // 
            // closebtn
            // 
            closebtn.BackColor = SystemColors.Menu;
            closebtn.Cursor = Cursors.Hand;
            closebtn.FlatAppearance.BorderSize = 0;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.Location = new Point(1268, 2);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(44, 40);
            closebtn.TabIndex = 15;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += CloseButton_Click;
            // 
            // orderpnl
            // 
            orderpnl.Controls.Add(orderdata);
            orderpnl.Controls.Add(InvoiceLine1);
            orderpnl.Controls.Add(panel11);
            orderpnl.Controls.Add(panel10);
            orderpnl.Controls.Add(CancelOrderbtn);
            orderpnl.Controls.Add(orderSearchbox);
            orderpnl.Controls.Add(panel9);
            orderpnl.Controls.Add(viewOrderbtn);
            orderpnl.Controls.Add(newOrderbtn);
            orderpnl.Controls.Add(ordlerlbl);
            orderpnl.Controls.Add(editOrdersbtn);
            orderpnl.Location = new Point(176, 2);
            orderpnl.Name = "orderpnl";
            orderpnl.Size = new Size(1094, 788);
            orderpnl.TabIndex = 16;
            orderpnl.Visible = false;
            orderpnl.MouseDown += Dashboard_MouseDown;
            orderpnl.MouseMove += Dashboard_MouseMove;
            orderpnl.MouseUp += Dashboard_MouseUp;
            // 
            // orderdata
            // 
            orderdata.AllowUserToAddRows = false;
            orderdata.AllowUserToDeleteRows = false;
            orderdata.AllowUserToResizeRows = false;
            dataGridViewCellStyle166.BackColor = Color.Gainsboro;
            orderdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle166;
            orderdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle167.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle167.BackColor = SystemColors.Control;
            dataGridViewCellStyle167.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle167.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle167.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle167.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle167.WrapMode = DataGridViewTriState.True;
            orderdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle167;
            orderdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderdata.Columns.AddRange(new DataGridViewColumn[] { ordercheckColumn });
            dataGridViewCellStyle168.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle168.BackColor = SystemColors.Window;
            dataGridViewCellStyle168.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle168.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle168.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle168.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle168.WrapMode = DataGridViewTriState.False;
            orderdata.DefaultCellStyle = dataGridViewCellStyle168;
            orderdata.Location = new Point(29, 265);
            orderdata.Margin = new Padding(3, 2, 3, 2);
            orderdata.Name = "orderdata";
            dataGridViewCellStyle169.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle169.BackColor = SystemColors.Control;
            dataGridViewCellStyle169.Font = new Font("Segoe UI Semibold", 10.2F);
            dataGridViewCellStyle169.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle169.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle169.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle169.WrapMode = DataGridViewTriState.True;
            orderdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle169;
            orderdata.RowHeadersVisible = false;
            orderdata.RowHeadersWidth = 51;
            orderdata.ScrollBars = ScrollBars.Vertical;
            orderdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderdata.Size = new Size(1048, 429);
            orderdata.TabIndex = 52;
            orderdata.CellClick += orderdata_CellClick;
            orderdata.CellContentClick += orderdata_CellContentClick;
            // 
            // ordercheckColumn
            // 
            ordercheckColumn.FillWeight = 35F;
            ordercheckColumn.HeaderText = "Select";
            ordercheckColumn.MinimumWidth = 35;
            ordercheckColumn.Name = "ordercheckColumn";
            // 
            // InvoiceLine1
            // 
            InvoiceLine1.BackColor = SystemColors.ControlDark;
            InvoiceLine1.BorderStyle = BorderStyle.Fixed3D;
            InvoiceLine1.ForeColor = SystemColors.ControlText;
            InvoiceLine1.Location = new Point(40, 208);
            InvoiceLine1.Name = "InvoiceLine1";
            InvoiceLine1.Size = new Size(765, 5);
            InvoiceLine1.TabIndex = 51;
            // 
            // panel11
            // 
            panel11.Controls.Add(orderFirstPagebtn);
            panel11.Controls.Add(orderIndexlbl);
            panel11.Controls.Add(orderPrevPagebtn);
            panel11.Controls.Add(orderLastPagebtn);
            panel11.Controls.Add(orderNextPagebtn);
            panel11.Location = new Point(577, 700);
            panel11.Name = "panel11";
            panel11.Size = new Size(495, 50);
            panel11.TabIndex = 47;
            // 
            // orderFirstPagebtn
            // 
            orderFirstPagebtn.BackColor = SystemColors.Menu;
            orderFirstPagebtn.BackColor2 = Color.White;
            orderFirstPagebtn.BorderColor = Color.Tomato;
            orderFirstPagebtn.BorderSize = 2;
            orderFirstPagebtn.ButtonBorderColor = Color.Gray;
            orderFirstPagebtn.ButtonHighlightColor = Color.Empty;
            orderFirstPagebtn.ButtonHighlightColor2 = Color.Empty;
            orderFirstPagebtn.ButtonHighlightForeColor = Color.Black;
            orderFirstPagebtn.ButtonPressedColor = Color.White;
            orderFirstPagebtn.ButtonPressedColor2 = Color.Empty;
            orderFirstPagebtn.ButtonPressedForeColor = Color.Gray;
            orderFirstPagebtn.ButtonRoundRadius = 30;
            orderFirstPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderFirstPagebtn.ForeColor = Color.Black;
            orderFirstPagebtn.Location = new Point(57, 7);
            orderFirstPagebtn.Name = "orderFirstPagebtn";
            orderFirstPagebtn.Size = new Size(69, 40);
            orderFirstPagebtn.TabIndex = 31;
            orderFirstPagebtn.Text = "First";
            // 
            // orderIndexlbl
            // 
            orderIndexlbl.AutoSize = true;
            orderIndexlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderIndexlbl.Location = new Point(220, 16);
            orderIndexlbl.Name = "orderIndexlbl";
            orderIndexlbl.Size = new Size(79, 20);
            orderIndexlbl.TabIndex = 3;
            orderIndexlbl.Text = "LabelData";
            // 
            // orderPrevPagebtn
            // 
            orderPrevPagebtn.AccessibleRole = AccessibleRole.None;
            orderPrevPagebtn.BackColor = SystemColors.Menu;
            orderPrevPagebtn.BackColor2 = Color.White;
            orderPrevPagebtn.BorderColor = Color.Tomato;
            orderPrevPagebtn.BorderSize = 2;
            orderPrevPagebtn.ButtonBorderColor = Color.Gray;
            orderPrevPagebtn.ButtonHighlightColor = Color.Empty;
            orderPrevPagebtn.ButtonHighlightColor2 = Color.Empty;
            orderPrevPagebtn.ButtonHighlightForeColor = Color.Black;
            orderPrevPagebtn.ButtonPressedColor = Color.White;
            orderPrevPagebtn.ButtonPressedColor2 = Color.Empty;
            orderPrevPagebtn.ButtonPressedForeColor = Color.Gray;
            orderPrevPagebtn.ButtonRoundRadius = 30;
            orderPrevPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderPrevPagebtn.ForeColor = Color.Black;
            orderPrevPagebtn.Location = new Point(139, 7);
            orderPrevPagebtn.Name = "orderPrevPagebtn";
            orderPrevPagebtn.Size = new Size(70, 40);
            orderPrevPagebtn.TabIndex = 33;
            orderPrevPagebtn.Text = "Prev";
            // 
            // orderLastPagebtn
            // 
            orderLastPagebtn.BackColor = SystemColors.Menu;
            orderLastPagebtn.BackColor2 = Color.White;
            orderLastPagebtn.BorderColor = Color.White;
            orderLastPagebtn.BorderSize = 2;
            orderLastPagebtn.ButtonBorderColor = Color.Gray;
            orderLastPagebtn.ButtonHighlightColor = Color.Empty;
            orderLastPagebtn.ButtonHighlightColor2 = Color.Empty;
            orderLastPagebtn.ButtonHighlightForeColor = Color.Black;
            orderLastPagebtn.ButtonPressedColor = Color.White;
            orderLastPagebtn.ButtonPressedColor2 = Color.Empty;
            orderLastPagebtn.ButtonPressedForeColor = Color.Gray;
            orderLastPagebtn.ButtonRoundRadius = 30;
            orderLastPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderLastPagebtn.ForeColor = Color.Black;
            orderLastPagebtn.Location = new Point(395, 7);
            orderLastPagebtn.Name = "orderLastPagebtn";
            orderLastPagebtn.Size = new Size(68, 36);
            orderLastPagebtn.TabIndex = 34;
            orderLastPagebtn.Text = "Last";
            // 
            // orderNextPagebtn
            // 
            orderNextPagebtn.BackColor = SystemColors.HighlightText;
            orderNextPagebtn.BackColor2 = Color.White;
            orderNextPagebtn.BorderColor = Color.Tomato;
            orderNextPagebtn.BorderSize = 2;
            orderNextPagebtn.ButtonBorderColor = Color.Gray;
            orderNextPagebtn.ButtonHighlightColor = Color.Empty;
            orderNextPagebtn.ButtonHighlightColor2 = Color.Empty;
            orderNextPagebtn.ButtonHighlightForeColor = Color.Black;
            orderNextPagebtn.ButtonPressedColor = Color.White;
            orderNextPagebtn.ButtonPressedColor2 = Color.Empty;
            orderNextPagebtn.ButtonPressedForeColor = Color.Gray;
            orderNextPagebtn.ButtonRoundRadius = 30;
            orderNextPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderNextPagebtn.ForeColor = Color.Black;
            orderNextPagebtn.Location = new Point(322, 7);
            orderNextPagebtn.Name = "orderNextPagebtn";
            orderNextPagebtn.Size = new Size(65, 39);
            orderNextPagebtn.TabIndex = 32;
            orderNextPagebtn.Text = "Next";
            // 
            // panel10
            // 
            panel10.Controls.Add(orderStatusCombox);
            panel10.Controls.Add(label18);
            panel10.Controls.Add(label13);
            panel10.Controls.Add(orderdateTimePicker1);
            panel10.Controls.Add(orderSearchbtn);
            panel10.Controls.Add(orderdateTimePicker2);
            panel10.Controls.Add(label14);
            panel10.Location = new Point(33, 57);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(860, 81);
            panel10.TabIndex = 46;
            // 
            // orderStatusCombox
            // 
            orderStatusCombox.FormattingEnabled = true;
            orderStatusCombox.Location = new Point(562, 46);
            orderStatusCombox.Margin = new Padding(3, 2, 3, 2);
            orderStatusCombox.Name = "orderStatusCombox";
            orderStatusCombox.Size = new Size(133, 23);
            orderStatusCombox.TabIndex = 48;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(563, 19);
            label18.Name = "label18";
            label18.Size = new Size(55, 21);
            label18.TabIndex = 44;
            label18.Text = "Status";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(11, 19);
            label13.Name = "label13";
            label13.Size = new Size(48, 21);
            label13.TabIndex = 42;
            label13.Text = "From";
            // 
            // orderdateTimePicker1
            // 
            orderdateTimePicker1.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderdateTimePicker1.Location = new Point(15, 46);
            orderdateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            orderdateTimePicker1.Name = "orderdateTimePicker1";
            orderdateTimePicker1.Size = new Size(219, 23);
            orderdateTimePicker1.TabIndex = 40;
            orderdateTimePicker1.ValueChanged += orderdateTimePicker1_ValueChanged;
            // 
            // orderSearchbtn
            // 
            orderSearchbtn.BackColor = SystemColors.Menu;
            orderSearchbtn.BackColor2 = Color.White;
            orderSearchbtn.BorderColor = Color.White;
            orderSearchbtn.BorderSize = 2;
            orderSearchbtn.ButtonBorderColor = Color.Gray;
            orderSearchbtn.ButtonHighlightColor = Color.Empty;
            orderSearchbtn.ButtonHighlightColor2 = Color.Empty;
            orderSearchbtn.ButtonHighlightForeColor = Color.Black;
            orderSearchbtn.ButtonPressedColor = Color.White;
            orderSearchbtn.ButtonPressedColor2 = Color.Empty;
            orderSearchbtn.ButtonPressedForeColor = Color.Gray;
            orderSearchbtn.ButtonRoundRadius = 30;
            orderSearchbtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderSearchbtn.ForeColor = Color.Black;
            orderSearchbtn.Location = new Point(734, 32);
            orderSearchbtn.Name = "orderSearchbtn";
            orderSearchbtn.Size = new Size(116, 37);
            orderSearchbtn.TabIndex = 39;
            orderSearchbtn.Text = "Search";
            orderSearchbtn.Click += orderSearchbtn_Click;
            // 
            // orderdateTimePicker2
            // 
            orderdateTimePicker2.Location = new Point(286, 46);
            orderdateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            orderdateTimePicker2.Name = "orderdateTimePicker2";
            orderdateTimePicker2.Size = new Size(219, 23);
            orderdateTimePicker2.TabIndex = 41;
            orderdateTimePicker2.ValueChanged += orderdateTimePicker2_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(286, 19);
            label14.Name = "label14";
            label14.Size = new Size(27, 21);
            label14.TabIndex = 43;
            label14.Text = "To";
            // 
            // CancelOrderbtn
            // 
            CancelOrderbtn.BackColor = Color.Red;
            CancelOrderbtn.BackColor2 = Color.IndianRed;
            CancelOrderbtn.BorderColor = Color.White;
            CancelOrderbtn.BorderSize = 2;
            CancelOrderbtn.ButtonBorderColor = Color.Gray;
            CancelOrderbtn.ButtonHighlightColor = Color.Empty;
            CancelOrderbtn.ButtonHighlightColor2 = Color.Empty;
            CancelOrderbtn.ButtonHighlightForeColor = Color.Black;
            CancelOrderbtn.ButtonPressedColor = Color.White;
            CancelOrderbtn.ButtonPressedColor2 = Color.Empty;
            CancelOrderbtn.ButtonPressedForeColor = Color.Gray;
            CancelOrderbtn.ButtonRoundRadius = 30;
            CancelOrderbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelOrderbtn.ForeColor = Color.White;
            CancelOrderbtn.Location = new Point(380, 218);
            CancelOrderbtn.Name = "CancelOrderbtn";
            CancelOrderbtn.Size = new Size(151, 38);
            CancelOrderbtn.TabIndex = 45;
            CancelOrderbtn.Text = "Cancel Order";
            CancelOrderbtn.Click += orderCancelbtn_Click;
            // 
            // orderSearchbox
            // 
            orderSearchbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderSearchbox.Location = new Point(563, 223);
            orderSearchbox.Margin = new Padding(3, 4, 3, 4);
            orderSearchbox.Multiline = true;
            orderSearchbox.Name = "orderSearchbox";
            orderSearchbox.PlaceholderText = "Search Order";
            orderSearchbox.Size = new Size(517, 33);
            orderSearchbox.TabIndex = 44;
            orderSearchbox.KeyDown += orderSearchbox_KeyDown;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel26);
            panel9.Controls.Add(panel27);
            panel9.Controls.Add(panel30);
            panel9.Controls.Add(panel29);
            panel9.Controls.Add(panel28);
            panel9.Controls.Add(orderoverallBtn);
            panel9.Controls.Add(label11);
            panel9.Controls.Add(label8);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(33, 148);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(1038, 52);
            panel9.TabIndex = 39;
            panel9.Paint += panel9_Paint;
            // 
            // panel26
            // 
            panel26.AutoSize = true;
            panel26.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel26.Controls.Add(orderAllbox);
            panel26.Location = new Point(95, 17);
            panel26.Margin = new Padding(3, 2, 3, 2);
            panel26.Name = "panel26";
            panel26.Size = new Size(34, 25);
            panel26.TabIndex = 52;
            panel26.Paint += panel26_Paint;
            // 
            // orderAllbox
            // 
            orderAllbox.BackColor = SystemColors.Menu;
            orderAllbox.BorderStyle = BorderStyle.None;
            orderAllbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderAllbox.Location = new Point(5, 4);
            orderAllbox.Margin = new Padding(3, 2, 3, 2);
            orderAllbox.Name = "orderAllbox";
            orderAllbox.ReadOnly = true;
            orderAllbox.Size = new Size(26, 19);
            orderAllbox.TabIndex = 48;
            orderAllbox.Text = "880";
            // 
            // panel27
            // 
            panel27.AutoSize = true;
            panel27.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel27.Controls.Add(orderActivebox);
            panel27.Location = new Point(297, 18);
            panel27.Margin = new Padding(3, 2, 3, 2);
            panel27.Name = "panel27";
            panel27.Size = new Size(36, 24);
            panel27.TabIndex = 52;
            panel27.Paint += panel27_Paint;
            // 
            // orderActivebox
            // 
            orderActivebox.BackColor = SystemColors.Menu;
            orderActivebox.BorderStyle = BorderStyle.None;
            orderActivebox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderActivebox.Location = new Point(7, 3);
            orderActivebox.Margin = new Padding(3, 2, 3, 2);
            orderActivebox.Name = "orderActivebox";
            orderActivebox.ReadOnly = true;
            orderActivebox.Size = new Size(26, 19);
            orderActivebox.TabIndex = 48;
            orderActivebox.Text = "880";
            // 
            // panel30
            // 
            panel30.AutoSize = true;
            panel30.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel30.Controls.Add(orderCancelbox);
            panel30.Location = new Point(777, 14);
            panel30.Margin = new Padding(3, 2, 3, 2);
            panel30.Name = "panel30";
            panel30.Size = new Size(38, 24);
            panel30.TabIndex = 51;
            panel30.Paint += panel30_Paint;
            // 
            // orderCancelbox
            // 
            orderCancelbox.BackColor = SystemColors.Menu;
            orderCancelbox.BorderStyle = BorderStyle.None;
            orderCancelbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderCancelbox.Location = new Point(9, 3);
            orderCancelbox.Margin = new Padding(3, 2, 3, 2);
            orderCancelbox.Name = "orderCancelbox";
            orderCancelbox.ReadOnly = true;
            orderCancelbox.Size = new Size(26, 19);
            orderCancelbox.TabIndex = 48;
            orderCancelbox.Text = "880";
            // 
            // panel29
            // 
            panel29.AutoSize = true;
            panel29.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel29.Location = new Point(777, 14);
            panel29.Margin = new Padding(3, 2, 3, 2);
            panel29.Name = "panel29";
            panel29.Size = new Size(0, 0);
            panel29.TabIndex = 50;
            panel29.Paint += panel29_Paint;
            // 
            // panel28
            // 
            panel28.AutoSize = true;
            panel28.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel28.Controls.Add(orderCompletedlbl);
            panel28.Location = new Point(536, 16);
            panel28.Margin = new Padding(3, 2, 3, 2);
            panel28.Name = "panel28";
            panel28.Size = new Size(36, 24);
            panel28.TabIndex = 50;
            panel28.Paint += panel28_Paint;
            // 
            // orderCompletedlbl
            // 
            orderCompletedlbl.BackColor = SystemColors.Menu;
            orderCompletedlbl.BorderStyle = BorderStyle.None;
            orderCompletedlbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderCompletedlbl.Location = new Point(7, 3);
            orderCompletedlbl.Margin = new Padding(3, 2, 3, 2);
            orderCompletedlbl.Name = "orderCompletedlbl";
            orderCompletedlbl.ReadOnly = true;
            orderCompletedlbl.Size = new Size(26, 19);
            orderCompletedlbl.TabIndex = 48;
            orderCompletedlbl.Text = "880";
            // 
            // orderoverallBtn
            // 
            orderoverallBtn.AutoSize = true;
            orderoverallBtn.BackColor = SystemColors.Menu;
            orderoverallBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderoverallBtn.Location = new Point(2, 17);
            orderoverallBtn.Name = "orderoverallBtn";
            orderoverallBtn.Size = new Size(85, 21);
            orderoverallBtn.TabIndex = 32;
            orderoverallBtn.Text = "All Orders";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Menu;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(630, 14);
            label11.Name = "label11";
            label11.Size = new Size(139, 21);
            label11.TabIndex = 37;
            label11.Text = "Cancelled Orders";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Menu;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(173, 18);
            label8.Name = "label8";
            label8.Size = new Size(112, 21);
            label8.TabIndex = 33;
            label8.Text = "Active Orders";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Menu;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(378, 16);
            label10.Name = "label10";
            label10.Size = new Size(148, 21);
            label10.TabIndex = 35;
            label10.Text = "Completed Orders";
            label10.Click += label10_Click;
            // 
            // viewOrderbtn
            // 
            viewOrderbtn.BackColor = SystemColors.Menu;
            viewOrderbtn.BackColor2 = Color.White;
            viewOrderbtn.BorderColor = Color.White;
            viewOrderbtn.BorderSize = 2;
            viewOrderbtn.ButtonBorderColor = Color.Gray;
            viewOrderbtn.ButtonHighlightColor = Color.Empty;
            viewOrderbtn.ButtonHighlightColor2 = Color.Empty;
            viewOrderbtn.ButtonHighlightForeColor = Color.Black;
            viewOrderbtn.ButtonPressedColor = Color.White;
            viewOrderbtn.ButtonPressedColor2 = Color.Empty;
            viewOrderbtn.ButtonPressedForeColor = Color.Gray;
            viewOrderbtn.ButtonRoundRadius = 30;
            viewOrderbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewOrderbtn.ForeColor = Color.Black;
            viewOrderbtn.Location = new Point(214, 218);
            viewOrderbtn.Name = "viewOrderbtn";
            viewOrderbtn.Size = new Size(151, 38);
            viewOrderbtn.TabIndex = 25;
            viewOrderbtn.Text = "View Order";
            viewOrderbtn.Click += viewOrderbtn_Click;
            // 
            // newOrderbtn
            // 
            newOrderbtn.BackColor = Color.LimeGreen;
            newOrderbtn.BackColor2 = Color.Lime;
            newOrderbtn.BorderColor = Color.White;
            newOrderbtn.BorderSize = 2;
            newOrderbtn.ButtonBorderColor = Color.Gray;
            newOrderbtn.ButtonHighlightColor = Color.Empty;
            newOrderbtn.ButtonHighlightColor2 = Color.Empty;
            newOrderbtn.ButtonHighlightForeColor = Color.Black;
            newOrderbtn.ButtonPressedColor = Color.White;
            newOrderbtn.ButtonPressedColor2 = Color.Empty;
            newOrderbtn.ButtonPressedForeColor = Color.Gray;
            newOrderbtn.ButtonRoundRadius = 30;
            newOrderbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newOrderbtn.ForeColor = Color.White;
            newOrderbtn.Location = new Point(902, 15);
            newOrderbtn.Name = "newOrderbtn";
            newOrderbtn.Size = new Size(162, 42);
            newOrderbtn.TabIndex = 24;
            newOrderbtn.Text = "+ New Orders";
            newOrderbtn.Click += newOrderbtn_Click;
            // 
            // ordlerlbl
            // 
            ordlerlbl.AutoSize = true;
            ordlerlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ordlerlbl.Location = new Point(33, 8);
            ordlerlbl.Name = "ordlerlbl";
            ordlerlbl.Size = new Size(236, 25);
            ordlerlbl.TabIndex = 23;
            ordlerlbl.Text = "Sales Order Management";
            // 
            // editOrdersbtn
            // 
            editOrdersbtn.BackColor = SystemColors.Menu;
            editOrdersbtn.BackColor2 = Color.White;
            editOrdersbtn.BorderColor = Color.White;
            editOrdersbtn.BorderSize = 2;
            editOrdersbtn.ButtonBorderColor = Color.Gray;
            editOrdersbtn.ButtonHighlightColor = Color.Empty;
            editOrdersbtn.ButtonHighlightColor2 = Color.Empty;
            editOrdersbtn.ButtonHighlightForeColor = Color.Black;
            editOrdersbtn.ButtonPressedColor = Color.White;
            editOrdersbtn.ButtonPressedColor2 = Color.Empty;
            editOrdersbtn.ButtonPressedForeColor = Color.Gray;
            editOrdersbtn.ButtonRoundRadius = 30;
            editOrdersbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editOrdersbtn.ForeColor = Color.Black;
            editOrdersbtn.Location = new Point(30, 218);
            editOrdersbtn.Name = "editOrdersbtn";
            editOrdersbtn.Size = new Size(163, 38);
            editOrdersbtn.TabIndex = 20;
            editOrdersbtn.Text = "Edit Order";
            editOrdersbtn.Click += editOrdersbtn_Click;
            // 
            // contactIndexlbl
            // 
            contactIndexlbl.AutoSize = true;
            contactIndexlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactIndexlbl.Location = new Point(199, 20);
            contactIndexlbl.Name = "contactIndexlbl";
            contactIndexlbl.Size = new Size(79, 20);
            contactIndexlbl.TabIndex = 3;
            contactIndexlbl.Text = "LabelData";
            // 
            // outstandingcheckColumn
            // 
            outstandingcheckColumn.FillWeight = 35F;
            outstandingcheckColumn.HeaderText = "Select";
            outstandingcheckColumn.MinimumWidth = 35;
            outstandingcheckColumn.Name = "outstandingcheckColumn";
            // 
            // deliverycheckColumn
            // 
            deliverycheckColumn.FillWeight = 35F;
            deliverycheckColumn.HeaderText = "Select";
            deliverycheckColumn.MinimumWidth = 35;
            deliverycheckColumn.Name = "deliverycheckColumn";
            // 
            // dealercheckColumn
            // 
            dealercheckColumn.FillWeight = 45F;
            dealercheckColumn.HeaderText = "Select";
            dealercheckColumn.MinimumWidth = 45;
            dealercheckColumn.Name = "dealercheckColumn";
            // 
            // suppliercheckColumn
            // 
            suppliercheckColumn.FillWeight = 45F;
            suppliercheckColumn.HeaderText = "Select";
            suppliercheckColumn.MinimumWidth = 45;
            suppliercheckColumn.Name = "suppliercheckColumn";
            // 
            // usercheckColumn
            // 
            usercheckColumn.FillWeight = 66F;
            usercheckColumn.HeaderText = "Select";
            usercheckColumn.MinimumWidth = 50;
            usercheckColumn.Name = "usercheckColumn";
            // 
            // stockcheckColumn
            // 
            stockcheckColumn.FillWeight = 50F;
            stockcheckColumn.HeaderText = "Select";
            stockcheckColumn.MinimumWidth = 40;
            stockcheckColumn.Name = "stockcheckColumn";
            // 
            // pocheckColumn
            // 
            pocheckColumn.FillWeight = 50F;
            pocheckColumn.HeaderText = "Select";
            pocheckColumn.MinimumWidth = 40;
            pocheckColumn.Name = "pocheckColumn";
            // 
            // orderAccemblyColumn
            // 
            orderAccemblyColumn.FillWeight = 66F;
            orderAccemblyColumn.HeaderText = "Select";
            orderAccemblyColumn.MinimumWidth = 50;
            orderAccemblyColumn.Name = "orderAccemblyColumn";
            // 
            // stocklbl
            // 
            stocklbl.AutoSize = true;
            stocklbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stocklbl.Location = new Point(19, 8);
            stocklbl.Name = "stocklbl";
            stocklbl.Size = new Size(185, 25);
            stocklbl.TabIndex = 2;
            stocklbl.Text = "Stock Management";
            stocklbl.Click += inventorylbl_Click;
            // 
            // stockSummarypnl
            // 
            stockSummarypnl.Controls.Add(stockDatapanel3);
            stockSummarypnl.Controls.Add(stockDatapanel1);
            stockSummarypnl.Controls.Add(stockDatapanel2);
            stockSummarypnl.Location = new Point(24, 51);
            stockSummarypnl.Name = "stockSummarypnl";
            stockSummarypnl.Size = new Size(1053, 144);
            stockSummarypnl.TabIndex = 26;
            // 
            // stockDatapanel3
            // 
            stockDatapanel3.Controls.Add(stocklbl3);
            stockDatapanel3.Controls.Add(stockProductDatalbl3);
            stockDatapanel3.Location = new Point(746, 4);
            stockDatapanel3.Name = "stockDatapanel3";
            stockDatapanel3.Size = new Size(266, 134);
            stockDatapanel3.TabIndex = 28;
            // 
            // stocklbl3
            // 
            stocklbl3.AutoSize = true;
            stocklbl3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stocklbl3.Location = new Point(23, 102);
            stocklbl3.Name = "stocklbl3";
            stocklbl3.Size = new Size(191, 30);
            stocklbl3.TabIndex = 5;
            stocklbl3.Text = "Total DemandStock";
            // 
            // stockProductDatalbl3
            // 
            stockProductDatalbl3.AutoSize = true;
            stockProductDatalbl3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockProductDatalbl3.Location = new Point(30, 36);
            stockProductDatalbl3.Name = "stockProductDatalbl3";
            stockProductDatalbl3.Size = new Size(196, 50);
            stockProductDatalbl3.TabIndex = 4;
            stockProductDatalbl3.Text = "LabelData";
            // 
            // stockDatapanel1
            // 
            stockDatapanel1.Controls.Add(stocklbl1);
            stockDatapanel1.Controls.Add(stockProductDatalbl1);
            stockDatapanel1.Location = new Point(44, 5);
            stockDatapanel1.Name = "stockDatapanel1";
            stockDatapanel1.Size = new Size(266, 134);
            stockDatapanel1.TabIndex = 0;
            // 
            // stocklbl1
            // 
            stocklbl1.AutoSize = true;
            stocklbl1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stocklbl1.Location = new Point(21, 102);
            stocklbl1.Name = "stocklbl1";
            stocklbl1.Size = new Size(192, 30);
            stocklbl1.TabIndex = 1;
            stocklbl1.Text = "Number of Product";
            stocklbl1.Click += stocklbl1_Click;
            // 
            // stockProductDatalbl1
            // 
            stockProductDatalbl1.AutoSize = true;
            stockProductDatalbl1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockProductDatalbl1.Location = new Point(24, 47);
            stockProductDatalbl1.Name = "stockProductDatalbl1";
            stockProductDatalbl1.Size = new Size(196, 50);
            stockProductDatalbl1.TabIndex = 0;
            stockProductDatalbl1.Text = "LabelData";
            // 
            // stockDatapanel2
            // 
            stockDatapanel2.Controls.Add(stockProductDatalbl2);
            stockDatapanel2.Controls.Add(stocklbl2);
            stockDatapanel2.Location = new Point(388, 4);
            stockDatapanel2.Name = "stockDatapanel2";
            stockDatapanel2.Size = new Size(266, 136);
            stockDatapanel2.TabIndex = 27;
            // 
            // stockProductDatalbl2
            // 
            stockProductDatalbl2.AutoSize = true;
            stockProductDatalbl2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockProductDatalbl2.Location = new Point(29, 43);
            stockProductDatalbl2.Name = "stockProductDatalbl2";
            stockProductDatalbl2.Size = new Size(196, 50);
            stockProductDatalbl2.TabIndex = 2;
            stockProductDatalbl2.Text = "LabelData";
            // 
            // stocklbl2
            // 
            stocklbl2.AutoSize = true;
            stocklbl2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stocklbl2.Location = new Point(48, 104);
            stocklbl2.Name = "stocklbl2";
            stocklbl2.Size = new Size(143, 30);
            stocklbl2.TabIndex = 2;
            stocklbl2.Text = "Total Quantity";
            // 
            // editProductbtn
            // 
            editProductbtn.BackColor = SystemColors.Menu;
            editProductbtn.BackColor2 = Color.White;
            editProductbtn.BorderColor = Color.White;
            editProductbtn.BorderSize = 2;
            editProductbtn.ButtonBorderColor = Color.Gray;
            editProductbtn.ButtonHighlightColor = Color.Empty;
            editProductbtn.ButtonHighlightColor2 = Color.Empty;
            editProductbtn.ButtonHighlightForeColor = Color.Black;
            editProductbtn.ButtonPressedColor = Color.White;
            editProductbtn.ButtonPressedColor2 = Color.Empty;
            editProductbtn.ButtonPressedForeColor = Color.Gray;
            editProductbtn.ButtonRoundRadius = 30;
            editProductbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editProductbtn.ForeColor = Color.Black;
            editProductbtn.Location = new Point(31, 255);
            editProductbtn.Name = "editProductbtn";
            editProductbtn.Size = new Size(162, 42);
            editProductbtn.TabIndex = 27;
            editProductbtn.Text = "Edit Product";
            editProductbtn.Click += editProductbtn_Click;
            // 
            // newProductbtn
            // 
            newProductbtn.BackColor = Color.LimeGreen;
            newProductbtn.BackColor2 = Color.Lime;
            newProductbtn.BorderColor = Color.White;
            newProductbtn.BorderSize = 2;
            newProductbtn.ButtonBorderColor = Color.Gray;
            newProductbtn.ButtonHighlightColor = Color.Empty;
            newProductbtn.ButtonHighlightColor2 = Color.Empty;
            newProductbtn.ButtonHighlightForeColor = Color.Black;
            newProductbtn.ButtonPressedColor = Color.White;
            newProductbtn.ButtonPressedColor2 = Color.Empty;
            newProductbtn.ButtonPressedForeColor = Color.Gray;
            newProductbtn.ButtonRoundRadius = 30;
            newProductbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newProductbtn.ForeColor = Color.White;
            newProductbtn.Location = new Point(902, 8);
            newProductbtn.Name = "newProductbtn";
            newProductbtn.Size = new Size(128, 42);
            newProductbtn.TabIndex = 28;
            newProductbtn.Text = "New Product";
            newProductbtn.Click += newProductbtn_Click;
            // 
            // stockData
            // 
            stockData.AllowUserToAddRows = false;
            stockData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle170.BackColor = Color.Gainsboro;
            stockData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle170;
            stockData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle171.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle171.BackColor = SystemColors.Control;
            dataGridViewCellStyle171.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle171.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle171.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle171.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle171.WrapMode = DataGridViewTriState.True;
            stockData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle171;
            stockData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stockData.Columns.AddRange(new DataGridViewColumn[] { stockcheckColumn });
            dataGridViewCellStyle172.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle172.BackColor = SystemColors.Window;
            dataGridViewCellStyle172.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle172.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle172.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle172.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle172.WrapMode = DataGridViewTriState.False;
            stockData.DefaultCellStyle = dataGridViewCellStyle172;
            stockData.Location = new Point(29, 302);
            stockData.Margin = new Padding(3, 4, 3, 4);
            stockData.Name = "stockData";
            dataGridViewCellStyle173.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle173.BackColor = SystemColors.Control;
            dataGridViewCellStyle173.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle173.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle173.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle173.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle173.WrapMode = DataGridViewTriState.True;
            stockData.RowHeadersDefaultCellStyle = dataGridViewCellStyle173;
            stockData.RowHeadersVisible = false;
            stockData.RowHeadersWidth = 51;
            stockData.RowTemplate.Height = 24;
            stockData.ScrollBars = ScrollBars.None;
            stockData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stockData.Size = new Size(1045, 405);
            stockData.TabIndex = 3;
            stockData.CellClick += stockData_CellClick;
            stockData.CellContentClick += stockData_CellContentClick;
            // 
            // viewProductbtn
            // 
            viewProductbtn.BackColor = SystemColors.Menu;
            viewProductbtn.BackColor2 = Color.White;
            viewProductbtn.BorderColor = Color.White;
            viewProductbtn.BorderSize = 2;
            viewProductbtn.ButtonBorderColor = Color.Gray;
            viewProductbtn.ButtonHighlightColor = Color.Empty;
            viewProductbtn.ButtonHighlightColor2 = Color.Empty;
            viewProductbtn.ButtonHighlightForeColor = Color.Black;
            viewProductbtn.ButtonPressedColor = Color.White;
            viewProductbtn.ButtonPressedColor2 = Color.Empty;
            viewProductbtn.ButtonPressedForeColor = Color.Gray;
            viewProductbtn.ButtonRoundRadius = 30;
            viewProductbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewProductbtn.ForeColor = Color.Black;
            viewProductbtn.Location = new Point(225, 255);
            viewProductbtn.Name = "viewProductbtn";
            viewProductbtn.Size = new Size(162, 42);
            viewProductbtn.TabIndex = 29;
            viewProductbtn.Text = "View Product";
            viewProductbtn.Click += viewProductbtn_Click;
            // 
            // accountSearchBtn
            // 
            accountSearchBtn.BackColor = SystemColors.HighlightText;
            accountSearchBtn.BackColor2 = Color.White;
            accountSearchBtn.BorderColor = Color.Tomato;
            accountSearchBtn.BorderSize = 2;
            accountSearchBtn.ButtonBorderColor = Color.Gray;
            accountSearchBtn.ButtonHighlightColor = Color.Empty;
            accountSearchBtn.ButtonHighlightColor2 = Color.Empty;
            accountSearchBtn.ButtonHighlightForeColor = Color.Black;
            accountSearchBtn.ButtonPressedColor = Color.White;
            accountSearchBtn.ButtonPressedColor2 = Color.Empty;
            accountSearchBtn.ButtonPressedForeColor = Color.Gray;
            accountSearchBtn.ButtonRoundRadius = 30;
            accountSearchBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountSearchBtn.ForeColor = Color.Black;
            accountSearchBtn.Location = new Point(884, 79);
            accountSearchBtn.Name = "accountSearchBtn";
            accountSearchBtn.Size = new Size(160, 37);
            accountSearchBtn.TabIndex = 27;
            accountSearchBtn.Text = "Search";
            accountSearchBtn.Click += accountSearchBtn_Click;
            // 
            // contactpnl
            // 
            contactpnl.Controls.Add(contactSupplierCleaerbtn);
            contactpnl.Controls.Add(contactDealerclearbtn);
            contactpnl.Controls.Add(panel23);
            contactpnl.Controls.Add(panel22);
            contactpnl.Controls.Add(contactGroupBox);
            contactpnl.Controls.Add(delContactbtn);
            contactpnl.Controls.Add(searchContactbtn);
            contactpnl.Controls.Add(newDealerbtn);
            contactpnl.Controls.Add(searchSupplierbtn);
            contactpnl.Controls.Add(searchDealerbtn);
            contactpnl.Controls.Add(editSupplierbtn);
            contactpnl.Controls.Add(newSupplierbtn);
            contactpnl.Controls.Add(suppliersData);
            contactpnl.Controls.Add(dealersData);
            contactpnl.Controls.Add(editDealerbtn);
            contactpnl.Location = new Point(176, 2);
            contactpnl.Margin = new Padding(3, 4, 3, 4);
            contactpnl.Name = "contactpnl";
            contactpnl.Size = new Size(1094, 788);
            contactpnl.TabIndex = 1;
            contactpnl.Visible = false;
            contactpnl.Paint += contactpnl_Paint;
            contactpnl.MouseDown += Dashboard_MouseDown;
            contactpnl.MouseMove += Dashboard_MouseMove;
            contactpnl.MouseUp += Dashboard_MouseUp;
            // 
            // contactSupplierCleaerbtn
            // 
            contactSupplierCleaerbtn.BackColor = SystemColors.Menu;
            contactSupplierCleaerbtn.BackColor2 = Color.White;
            contactSupplierCleaerbtn.BorderColor = Color.White;
            contactSupplierCleaerbtn.BorderSize = 2;
            contactSupplierCleaerbtn.ButtonBorderColor = Color.Gray;
            contactSupplierCleaerbtn.ButtonHighlightColor = Color.Empty;
            contactSupplierCleaerbtn.ButtonHighlightColor2 = Color.Empty;
            contactSupplierCleaerbtn.ButtonHighlightForeColor = Color.Black;
            contactSupplierCleaerbtn.ButtonPressedColor = Color.White;
            contactSupplierCleaerbtn.ButtonPressedColor2 = Color.Empty;
            contactSupplierCleaerbtn.ButtonPressedForeColor = Color.Gray;
            contactSupplierCleaerbtn.ButtonRoundRadius = 30;
            contactSupplierCleaerbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactSupplierCleaerbtn.ForeColor = Color.Black;
            contactSupplierCleaerbtn.Location = new Point(505, 204);
            contactSupplierCleaerbtn.Name = "contactSupplierCleaerbtn";
            contactSupplierCleaerbtn.Size = new Size(95, 37);
            contactSupplierCleaerbtn.TabIndex = 43;
            contactSupplierCleaerbtn.Text = "Clear";
            contactSupplierCleaerbtn.Click += contactSupplierCleaerbtn_Click;
            // 
            // contactDealerclearbtn
            // 
            contactDealerclearbtn.BackColor = SystemColors.Menu;
            contactDealerclearbtn.BackColor2 = Color.White;
            contactDealerclearbtn.BorderColor = Color.White;
            contactDealerclearbtn.BorderSize = 2;
            contactDealerclearbtn.ButtonBorderColor = Color.Gray;
            contactDealerclearbtn.ButtonHighlightColor = Color.Empty;
            contactDealerclearbtn.ButtonHighlightColor2 = Color.Empty;
            contactDealerclearbtn.ButtonHighlightForeColor = Color.Black;
            contactDealerclearbtn.ButtonPressedColor = Color.White;
            contactDealerclearbtn.ButtonPressedColor2 = Color.Empty;
            contactDealerclearbtn.ButtonPressedForeColor = Color.Gray;
            contactDealerclearbtn.ButtonRoundRadius = 30;
            contactDealerclearbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactDealerclearbtn.ForeColor = Color.Black;
            contactDealerclearbtn.Location = new Point(505, 204);
            contactDealerclearbtn.Name = "contactDealerclearbtn";
            contactDealerclearbtn.Size = new Size(95, 37);
            contactDealerclearbtn.TabIndex = 42;
            contactDealerclearbtn.Text = "Clear";
            contactDealerclearbtn.Click += contactDealerclearbtn_Click;
            // 
            // panel23
            // 
            panel23.Controls.Add(contactbtnFirstPage);
            panel23.Controls.Add(contactIndexlbl);
            panel23.Controls.Add(contactbtnPrevPage);
            panel23.Controls.Add(contactbtnLastPage);
            panel23.Controls.Add(contactbtnNxtPage);
            panel23.Location = new Point(582, 696);
            panel23.Name = "panel23";
            panel23.Size = new Size(495, 53);
            panel23.TabIndex = 40;
            // 
            // contactbtnFirstPage
            // 
            contactbtnFirstPage.BackColor = SystemColors.Menu;
            contactbtnFirstPage.BackColor2 = Color.White;
            contactbtnFirstPage.BorderColor = Color.Tomato;
            contactbtnFirstPage.BorderSize = 2;
            contactbtnFirstPage.ButtonBorderColor = Color.Gray;
            contactbtnFirstPage.ButtonHighlightColor = Color.Empty;
            contactbtnFirstPage.ButtonHighlightColor2 = Color.Empty;
            contactbtnFirstPage.ButtonHighlightForeColor = Color.Black;
            contactbtnFirstPage.ButtonPressedColor = Color.White;
            contactbtnFirstPage.ButtonPressedColor2 = Color.Empty;
            contactbtnFirstPage.ButtonPressedForeColor = Color.Gray;
            contactbtnFirstPage.ButtonRoundRadius = 30;
            contactbtnFirstPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactbtnFirstPage.ForeColor = Color.Black;
            contactbtnFirstPage.Location = new Point(18, 11);
            contactbtnFirstPage.Margin = new Padding(3, 4, 3, 4);
            contactbtnFirstPage.Name = "contactbtnFirstPage";
            contactbtnFirstPage.Size = new Size(69, 36);
            contactbtnFirstPage.TabIndex = 31;
            contactbtnFirstPage.Text = "First";
            contactbtnFirstPage.Click += contactbtnFirstPage_Click;
            // 
            // contactbtnPrevPage
            // 
            contactbtnPrevPage.AccessibleRole = AccessibleRole.None;
            contactbtnPrevPage.BackColor = SystemColors.Menu;
            contactbtnPrevPage.BackColor2 = Color.White;
            contactbtnPrevPage.BorderColor = Color.Tomato;
            contactbtnPrevPage.BorderSize = 2;
            contactbtnPrevPage.ButtonBorderColor = Color.Gray;
            contactbtnPrevPage.ButtonHighlightColor = Color.Empty;
            contactbtnPrevPage.ButtonHighlightColor2 = Color.Empty;
            contactbtnPrevPage.ButtonHighlightForeColor = Color.Black;
            contactbtnPrevPage.ButtonPressedColor = Color.White;
            contactbtnPrevPage.ButtonPressedColor2 = Color.Empty;
            contactbtnPrevPage.ButtonPressedForeColor = Color.Gray;
            contactbtnPrevPage.ButtonRoundRadius = 30;
            contactbtnPrevPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactbtnPrevPage.ForeColor = Color.Black;
            contactbtnPrevPage.Location = new Point(108, 11);
            contactbtnPrevPage.Margin = new Padding(3, 4, 3, 4);
            contactbtnPrevPage.Name = "contactbtnPrevPage";
            contactbtnPrevPage.Size = new Size(72, 36);
            contactbtnPrevPage.TabIndex = 33;
            contactbtnPrevPage.Text = "Prev";
            contactbtnPrevPage.Click += contactbtnPrevPage_Click;
            // 
            // contactbtnLastPage
            // 
            contactbtnLastPage.BackColor = SystemColors.Menu;
            contactbtnLastPage.BackColor2 = Color.White;
            contactbtnLastPage.BorderColor = Color.White;
            contactbtnLastPage.BorderSize = 2;
            contactbtnLastPage.ButtonBorderColor = Color.Gray;
            contactbtnLastPage.ButtonHighlightColor = Color.Empty;
            contactbtnLastPage.ButtonHighlightColor2 = Color.Empty;
            contactbtnLastPage.ButtonHighlightForeColor = Color.Black;
            contactbtnLastPage.ButtonPressedColor = Color.White;
            contactbtnLastPage.ButtonPressedColor2 = Color.Empty;
            contactbtnLastPage.ButtonPressedForeColor = Color.Gray;
            contactbtnLastPage.ButtonRoundRadius = 30;
            contactbtnLastPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactbtnLastPage.ForeColor = Color.Black;
            contactbtnLastPage.Location = new Point(408, 11);
            contactbtnLastPage.Margin = new Padding(3, 4, 3, 4);
            contactbtnLastPage.Name = "contactbtnLastPage";
            contactbtnLastPage.Size = new Size(76, 38);
            contactbtnLastPage.TabIndex = 34;
            contactbtnLastPage.Text = "Last";
            contactbtnLastPage.Click += contactbtnLastPage_Click;
            // 
            // contactbtnNxtPage
            // 
            contactbtnNxtPage.BackColor = SystemColors.HighlightText;
            contactbtnNxtPage.BackColor2 = Color.White;
            contactbtnNxtPage.BorderColor = Color.Tomato;
            contactbtnNxtPage.BorderSize = 2;
            contactbtnNxtPage.ButtonBorderColor = Color.Gray;
            contactbtnNxtPage.ButtonHighlightColor = Color.Empty;
            contactbtnNxtPage.ButtonHighlightColor2 = Color.Empty;
            contactbtnNxtPage.ButtonHighlightForeColor = Color.Black;
            contactbtnNxtPage.ButtonPressedColor = Color.White;
            contactbtnNxtPage.ButtonPressedColor2 = Color.Empty;
            contactbtnNxtPage.ButtonPressedForeColor = Color.Gray;
            contactbtnNxtPage.ButtonRoundRadius = 30;
            contactbtnNxtPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactbtnNxtPage.ForeColor = Color.Black;
            contactbtnNxtPage.Location = new Point(317, 11);
            contactbtnNxtPage.Margin = new Padding(3, 4, 3, 4);
            contactbtnNxtPage.Name = "contactbtnNxtPage";
            contactbtnNxtPage.Size = new Size(70, 40);
            contactbtnNxtPage.TabIndex = 32;
            contactbtnNxtPage.Text = "Next";
            contactbtnNxtPage.Click += contactbtnNxtPage_Click;
            // 
            // panel22
            // 
            panel22.Controls.Add(panel24);
            panel22.Controls.Add(panel25);
            panel22.Location = new Point(514, 51);
            panel22.Name = "panel22";
            panel22.Size = new Size(575, 143);
            panel22.TabIndex = 39;
            // 
            // panel24
            // 
            panel24.Controls.Add(label35);
            panel24.Controls.Add(dealerDatalbl);
            panel24.Location = new Point(15, 11);
            panel24.Name = "panel24";
            panel24.Size = new Size(266, 120);
            panel24.TabIndex = 0;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label35.Location = new Point(24, 80);
            label35.Name = "label35";
            label35.Size = new Size(180, 30);
            label35.TabIndex = 1;
            label35.Text = "Number of Dealer";
            // 
            // dealerDatalbl
            // 
            dealerDatalbl.AutoSize = true;
            dealerDatalbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dealerDatalbl.Location = new Point(24, 14);
            dealerDatalbl.Name = "dealerDatalbl";
            dealerDatalbl.Size = new Size(196, 50);
            dealerDatalbl.TabIndex = 0;
            dealerDatalbl.Text = "LabelData";
            dealerDatalbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel25
            // 
            panel25.Controls.Add(supplierDatalbl);
            panel25.Controls.Add(label38);
            panel25.Location = new Point(300, 11);
            panel25.Name = "panel25";
            panel25.Size = new Size(266, 120);
            panel25.TabIndex = 27;
            // 
            // supplierDatalbl
            // 
            supplierDatalbl.AutoSize = true;
            supplierDatalbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplierDatalbl.Location = new Point(32, 14);
            supplierDatalbl.Name = "supplierDatalbl";
            supplierDatalbl.Size = new Size(196, 50);
            supplierDatalbl.TabIndex = 2;
            supplierDatalbl.Text = "LabelData";
            supplierDatalbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label38.Location = new Point(26, 80);
            label38.Name = "label38";
            label38.Size = new Size(195, 30);
            label38.TabIndex = 2;
            label38.Text = "Number of Supplier";
            // 
            // contactGroupBox
            // 
            contactGroupBox.Controls.Add(supplersbtn);
            contactGroupBox.Controls.Add(dealersbtn);
            contactGroupBox.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            contactGroupBox.Location = new Point(38, 59);
            contactGroupBox.Margin = new Padding(3, 2, 3, 2);
            contactGroupBox.Name = "contactGroupBox";
            contactGroupBox.Padding = new Padding(3, 2, 3, 2);
            contactGroupBox.Size = new Size(403, 68);
            contactGroupBox.TabIndex = 35;
            contactGroupBox.TabStop = false;
            contactGroupBox.Text = "Change to Contact information";
            // 
            // supplersbtn
            // 
            supplersbtn.BackColor = SystemColors.Menu;
            supplersbtn.BackColor2 = Color.White;
            supplersbtn.BorderColor = Color.White;
            supplersbtn.BorderSize = 2;
            supplersbtn.ButtonBorderColor = Color.Gray;
            supplersbtn.ButtonHighlightColor = Color.Empty;
            supplersbtn.ButtonHighlightColor2 = Color.Empty;
            supplersbtn.ButtonHighlightForeColor = Color.Black;
            supplersbtn.ButtonPressedColor = Color.White;
            supplersbtn.ButtonPressedColor2 = Color.Empty;
            supplersbtn.ButtonPressedForeColor = Color.Gray;
            supplersbtn.ButtonRoundRadius = 15;
            supplersbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplersbtn.ForeColor = Color.Black;
            supplersbtn.Location = new Point(195, 18);
            supplersbtn.Name = "supplersbtn";
            supplersbtn.Size = new Size(196, 39);
            supplersbtn.TabIndex = 18;
            supplersbtn.Text = "Suppliers information";
            supplersbtn.Click += supplersbtn_Click;
            // 
            // dealersbtn
            // 
            dealersbtn.BackColor = SystemColors.Menu;
            dealersbtn.BackColor2 = Color.White;
            dealersbtn.BorderColor = Color.White;
            dealersbtn.BorderSize = 2;
            dealersbtn.ButtonBorderColor = Color.Gray;
            dealersbtn.ButtonHighlightColor = Color.Empty;
            dealersbtn.ButtonHighlightColor2 = Color.Empty;
            dealersbtn.ButtonHighlightForeColor = Color.Black;
            dealersbtn.ButtonPressedColor = Color.White;
            dealersbtn.ButtonPressedColor2 = Color.Empty;
            dealersbtn.ButtonPressedForeColor = Color.Gray;
            dealersbtn.ButtonRoundRadius = 15;
            dealersbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dealersbtn.ForeColor = Color.Black;
            dealersbtn.Location = new Point(7, 18);
            dealersbtn.Name = "dealersbtn";
            dealersbtn.Size = new Size(180, 39);
            dealersbtn.TabIndex = 17;
            dealersbtn.Text = "Dealers information";
            dealersbtn.Click += dealersbtn_Click;
            // 
            // delContactbtn
            // 
            delContactbtn.BackColor = Color.Red;
            delContactbtn.BackColor2 = Color.IndianRed;
            delContactbtn.BorderColor = Color.White;
            delContactbtn.BorderSize = 2;
            delContactbtn.ButtonBorderColor = Color.Gray;
            delContactbtn.ButtonHighlightColor = Color.Empty;
            delContactbtn.ButtonHighlightColor2 = Color.Empty;
            delContactbtn.ButtonHighlightForeColor = Color.Black;
            delContactbtn.ButtonPressedColor = Color.White;
            delContactbtn.ButtonPressedColor2 = Color.Empty;
            delContactbtn.ButtonPressedForeColor = Color.Gray;
            delContactbtn.ButtonRoundRadius = 30;
            delContactbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delContactbtn.ForeColor = Color.White;
            delContactbtn.Location = new Point(344, 197);
            delContactbtn.Margin = new Padding(4);
            delContactbtn.Name = "delContactbtn";
            delContactbtn.Size = new Size(139, 41);
            delContactbtn.TabIndex = 34;
            delContactbtn.Text = "Delete";
            delContactbtn.Click += delContactbtn_Click;
            // 
            // searchContactbtn
            // 
            searchContactbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchContactbtn.Location = new Point(704, 212);
            searchContactbtn.Name = "searchContactbtn";
            searchContactbtn.PlaceholderText = "Search Name";
            searchContactbtn.Size = new Size(197, 29);
            searchContactbtn.TabIndex = 32;
            // 
            // newDealerbtn
            // 
            newDealerbtn.BackColor = SystemColors.Menu;
            newDealerbtn.BackColor2 = Color.White;
            newDealerbtn.BorderColor = Color.White;
            newDealerbtn.BorderSize = 2;
            newDealerbtn.ButtonBorderColor = Color.Gray;
            newDealerbtn.ButtonHighlightColor = Color.Empty;
            newDealerbtn.ButtonHighlightColor2 = Color.Empty;
            newDealerbtn.ButtonHighlightForeColor = Color.Black;
            newDealerbtn.ButtonPressedColor = Color.White;
            newDealerbtn.ButtonPressedColor2 = Color.Empty;
            newDealerbtn.ButtonPressedForeColor = Color.Gray;
            newDealerbtn.ButtonRoundRadius = 30;
            newDealerbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newDealerbtn.ForeColor = Color.Black;
            newDealerbtn.Location = new Point(36, 193);
            newDealerbtn.Margin = new Padding(4);
            newDealerbtn.Name = "newDealerbtn";
            newDealerbtn.Size = new Size(144, 46);
            newDealerbtn.TabIndex = 31;
            newDealerbtn.Text = "New Dealer";
            newDealerbtn.Click += newDealerbtn_Click;
            // 
            // searchSupplierbtn
            // 
            searchSupplierbtn.BackColor = SystemColors.Menu;
            searchSupplierbtn.BackColor2 = Color.White;
            searchSupplierbtn.BorderColor = Color.White;
            searchSupplierbtn.BorderSize = 2;
            searchSupplierbtn.ButtonBorderColor = Color.Gray;
            searchSupplierbtn.ButtonHighlightColor = Color.Empty;
            searchSupplierbtn.ButtonHighlightColor2 = Color.Empty;
            searchSupplierbtn.ButtonHighlightForeColor = Color.Black;
            searchSupplierbtn.ButtonPressedColor = Color.White;
            searchSupplierbtn.ButtonPressedColor2 = Color.Empty;
            searchSupplierbtn.ButtonPressedForeColor = Color.Gray;
            searchSupplierbtn.ButtonRoundRadius = 30;
            searchSupplierbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchSupplierbtn.ForeColor = Color.Black;
            searchSupplierbtn.Location = new Point(910, 208);
            searchSupplierbtn.Name = "searchSupplierbtn";
            searchSupplierbtn.Size = new Size(166, 37);
            searchSupplierbtn.TabIndex = 38;
            searchSupplierbtn.Text = "Search";
            searchSupplierbtn.Click += searchSupplierbtn_Click;
            // 
            // searchDealerbtn
            // 
            searchDealerbtn.AutoSize = true;
            searchDealerbtn.BackColor = SystemColors.HighlightText;
            searchDealerbtn.FlatAppearance.BorderColor = Color.Gray;
            searchDealerbtn.FlatStyle = FlatStyle.System;
            searchDealerbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchDealerbtn.ForeColor = Color.Black;
            searchDealerbtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchDealerbtn.ImageIndex = 0;
            searchDealerbtn.Location = new Point(921, 208);
            searchDealerbtn.Name = "searchDealerbtn";
            searchDealerbtn.Size = new Size(155, 32);
            searchDealerbtn.TabIndex = 33;
            searchDealerbtn.Text = "Search";
            searchDealerbtn.UseVisualStyleBackColor = false;
            searchDealerbtn.Click += searchDealerbtn_Click;
            // 
            // editSupplierbtn
            // 
            editSupplierbtn.BackColor = SystemColors.Menu;
            editSupplierbtn.BackColor2 = Color.White;
            editSupplierbtn.BorderColor = Color.White;
            editSupplierbtn.BorderSize = 2;
            editSupplierbtn.ButtonBorderColor = Color.Gray;
            editSupplierbtn.ButtonHighlightColor = Color.Empty;
            editSupplierbtn.ButtonHighlightColor2 = Color.Empty;
            editSupplierbtn.ButtonHighlightForeColor = Color.Black;
            editSupplierbtn.ButtonPressedColor = Color.Empty;
            editSupplierbtn.ButtonPressedColor2 = Color.Empty;
            editSupplierbtn.ButtonPressedForeColor = Color.White;
            editSupplierbtn.ButtonRoundRadius = 30;
            editSupplierbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSupplierbtn.ForeColor = Color.Black;
            editSupplierbtn.Location = new Point(191, 196);
            editSupplierbtn.Margin = new Padding(5);
            editSupplierbtn.Name = "editSupplierbtn";
            editSupplierbtn.Size = new Size(144, 44);
            editSupplierbtn.TabIndex = 36;
            editSupplierbtn.Text = "Edit Supplier";
            editSupplierbtn.Click += editSupplierbtn_Click;
            // 
            // newSupplierbtn
            // 
            newSupplierbtn.AccessibleRole = AccessibleRole.None;
            newSupplierbtn.BackColor = SystemColors.Menu;
            newSupplierbtn.BackColor2 = Color.White;
            newSupplierbtn.BorderColor = Color.White;
            newSupplierbtn.BorderSize = 2;
            newSupplierbtn.ButtonBorderColor = Color.Gray;
            newSupplierbtn.ButtonHighlightColor = Color.Empty;
            newSupplierbtn.ButtonHighlightColor2 = Color.Empty;
            newSupplierbtn.ButtonHighlightForeColor = Color.Black;
            newSupplierbtn.ButtonPressedColor = Color.Empty;
            newSupplierbtn.ButtonPressedColor2 = Color.Empty;
            newSupplierbtn.ButtonPressedForeColor = Color.White;
            newSupplierbtn.ButtonRoundRadius = 30;
            newSupplierbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newSupplierbtn.ForeColor = Color.Black;
            newSupplierbtn.Location = new Point(36, 193);
            newSupplierbtn.Margin = new Padding(4);
            newSupplierbtn.Name = "newSupplierbtn";
            newSupplierbtn.Size = new Size(146, 43);
            newSupplierbtn.TabIndex = 37;
            newSupplierbtn.Text = "New Supplier";
            newSupplierbtn.Click += newSupplierbtn_Click;
            // 
            // suppliersData
            // 
            suppliersData.AllowUserToAddRows = false;
            suppliersData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle174.BackColor = Color.Gainsboro;
            suppliersData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle174;
            suppliersData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle175.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle175.BackColor = SystemColors.Control;
            dataGridViewCellStyle175.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle175.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle175.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle175.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle175.WrapMode = DataGridViewTriState.True;
            suppliersData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle175;
            suppliersData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suppliersData.Columns.AddRange(new DataGridViewColumn[] { suppliercheckColumn });
            dataGridViewCellStyle176.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle176.BackColor = SystemColors.Window;
            dataGridViewCellStyle176.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle176.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle176.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle176.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle176.WrapMode = DataGridViewTriState.False;
            suppliersData.DefaultCellStyle = dataGridViewCellStyle176;
            suppliersData.Location = new Point(38, 248);
            suppliersData.Margin = new Padding(3, 4, 3, 4);
            suppliersData.Name = "suppliersData";
            dataGridViewCellStyle177.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle177.BackColor = SystemColors.Control;
            dataGridViewCellStyle177.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle177.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle177.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle177.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle177.WrapMode = DataGridViewTriState.True;
            suppliersData.RowHeadersDefaultCellStyle = dataGridViewCellStyle177;
            suppliersData.RowHeadersVisible = false;
            suppliersData.RowHeadersWidth = 51;
            suppliersData.RowTemplate.Height = 24;
            suppliersData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            suppliersData.Size = new Size(1051, 417);
            suppliersData.TabIndex = 41;
            suppliersData.CellContentClick += suppliersdata_CellClick;
            // 
            // dealersData
            // 
            dealersData.AllowUserToAddRows = false;
            dealersData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle178.BackColor = Color.Gainsboro;
            dealersData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle178;
            dealersData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle179.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle179.BackColor = SystemColors.Control;
            dataGridViewCellStyle179.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle179.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle179.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle179.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle179.WrapMode = DataGridViewTriState.True;
            dealersData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle179;
            dealersData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dealersData.Columns.AddRange(new DataGridViewColumn[] { dealercheckColumn });
            dataGridViewCellStyle180.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle180.BackColor = SystemColors.Window;
            dataGridViewCellStyle180.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle180.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle180.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle180.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle180.WrapMode = DataGridViewTriState.False;
            dealersData.DefaultCellStyle = dataGridViewCellStyle180;
            dealersData.Location = new Point(38, 248);
            dealersData.Margin = new Padding(3, 4, 3, 4);
            dealersData.Name = "dealersData";
            dataGridViewCellStyle181.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle181.BackColor = SystemColors.Control;
            dataGridViewCellStyle181.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle181.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle181.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle181.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle181.WrapMode = DataGridViewTriState.True;
            dealersData.RowHeadersDefaultCellStyle = dataGridViewCellStyle181;
            dealersData.RowHeadersVisible = false;
            dealersData.RowHeadersWidth = 51;
            dealersData.RowTemplate.Height = 24;
            dealersData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dealersData.Size = new Size(1050, 417);
            dealersData.TabIndex = 19;
            dealersData.CellClick += dealersdata_CellClick;
            dealersData.CellContentClick += contactsdata_CellContentClick;
            // 
            // editDealerbtn
            // 
            editDealerbtn.AccessibleRole = AccessibleRole.None;
            editDealerbtn.BackColor2 = Color.White;
            editDealerbtn.BorderColor = Color.White;
            editDealerbtn.BorderSize = 2;
            editDealerbtn.ButtonBorderColor = Color.Gray;
            editDealerbtn.ButtonHighlightColor = Color.Empty;
            editDealerbtn.ButtonHighlightColor2 = Color.Empty;
            editDealerbtn.ButtonHighlightForeColor = Color.Black;
            editDealerbtn.ButtonPressedColor = Color.Empty;
            editDealerbtn.ButtonPressedColor2 = Color.Empty;
            editDealerbtn.ButtonPressedForeColor = Color.White;
            editDealerbtn.ButtonRoundRadius = 30;
            editDealerbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editDealerbtn.Location = new Point(188, 197);
            editDealerbtn.Margin = new Padding(4);
            editDealerbtn.Name = "editDealerbtn";
            editDealerbtn.Size = new Size(146, 40);
            editDealerbtn.TabIndex = 29;
            editDealerbtn.Text = "Edit Dealer";
            editDealerbtn.Click += editDealerbtn_Click;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            dataGridViewCheckBoxColumn5.FillWeight = 45F;
            dataGridViewCheckBoxColumn5.HeaderText = "Select";
            dataGridViewCheckBoxColumn5.MinimumWidth = 45;
            dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            dataGridViewCheckBoxColumn5.Width = 125;
            // 
            // panel43
            // 
            panel43.BackColor = SystemColors.Menu;
            panel43.Controls.Add(outstandingViewData);
            panel43.Controls.Add(panel42);
            panel43.Controls.Add(button23);
            panel43.Controls.Add(outstandingCancelbtn);
            panel43.Location = new Point(0, 123);
            panel43.Margin = new Padding(3, 2, 3, 2);
            panel43.Name = "panel43";
            panel43.Size = new Size(1067, 602);
            panel43.TabIndex = 32;
            // 
            // outstandingViewData
            // 
            outstandingViewData.AllowUserToAddRows = false;
            outstandingViewData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle182.BackColor = Color.Gainsboro;
            outstandingViewData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle182;
            outstandingViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            outstandingViewData.BackgroundColor = SystemColors.ButtonHighlight;
            outstandingViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            outstandingViewData.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, FollowUp, UnitPrice });
            outstandingViewData.Location = new Point(63, 229);
            outstandingViewData.Margin = new Padding(3, 4, 3, 4);
            outstandingViewData.Name = "outstandingViewData";
            outstandingViewData.ReadOnly = true;
            dataGridViewCellStyle183.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle183.BackColor = SystemColors.Control;
            dataGridViewCellStyle183.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle183.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle183.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle183.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle183.WrapMode = DataGridViewTriState.True;
            outstandingViewData.RowHeadersDefaultCellStyle = dataGridViewCellStyle183;
            outstandingViewData.RowHeadersWidth = 51;
            outstandingViewData.RowTemplate.Height = 24;
            outstandingViewData.Size = new Size(834, 284);
            outstandingViewData.TabIndex = 62;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // FollowUp
            // 
            FollowUp.HeaderText = "FollowUp";
            FollowUp.MinimumWidth = 6;
            FollowUp.Name = "FollowUp";
            FollowUp.ReadOnly = true;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            // 
            // panel42
            // 
            panel42.BackColor = Color.White;
            panel42.Controls.Add(viewoutstandingOrderExecptDatelbl);
            panel42.Controls.Add(label58);
            panel42.Controls.Add(viewoutstandingOrderDatelbl);
            panel42.Controls.Add(label56);
            panel42.Controls.Add(outstandingOrderIDlbl);
            panel42.Controls.Add(outstandingOrderIDlbl2);
            panel42.Controls.Add(oustandingViewDeliverylbl);
            panel42.Controls.Add(outstandingViewEmaillbl);
            panel42.Controls.Add(outstandingViewPhoneNumlbl);
            panel42.Controls.Add(outstandingViewContactNamelbl);
            panel42.Controls.Add(outstandingViewDealerNamelbl);
            panel42.Controls.Add(outstandingViewDealerIDlbl);
            panel42.Controls.Add(outstandingDealerIDlbl);
            panel42.Controls.Add(outstandingDealerNamelbl);
            panel42.Controls.Add(outstandingDeliveryAddresslbl);
            panel42.Controls.Add(outstandingContactNamelbl);
            panel42.Controls.Add(outstandingEmaillbl);
            panel42.Controls.Add(outstandingPhonelbl);
            panel42.Location = new Point(63, 3);
            panel42.Name = "panel42";
            panel42.Size = new Size(835, 213);
            panel42.TabIndex = 33;
            // 
            // viewoutstandingOrderExecptDatelbl
            // 
            viewoutstandingOrderExecptDatelbl.AutoSize = true;
            viewoutstandingOrderExecptDatelbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewoutstandingOrderExecptDatelbl.Location = new Point(586, 91);
            viewoutstandingOrderExecptDatelbl.Name = "viewoutstandingOrderExecptDatelbl";
            viewoutstandingOrderExecptDatelbl.Size = new Size(87, 21);
            viewoutstandingOrderExecptDatelbl.TabIndex = 42;
            viewoutstandingOrderExecptDatelbl.Text = "OrderDate";
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label58.Location = new Point(387, 93);
            label58.Name = "label58";
            label58.Size = new Size(152, 21);
            label58.TabIndex = 41;
            label58.Text = "Order Execpt Date :";
            // 
            // viewoutstandingOrderDatelbl
            // 
            viewoutstandingOrderDatelbl.AutoSize = true;
            viewoutstandingOrderDatelbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewoutstandingOrderDatelbl.Location = new Point(591, 53);
            viewoutstandingOrderDatelbl.Name = "viewoutstandingOrderDatelbl";
            viewoutstandingOrderDatelbl.Size = new Size(87, 21);
            viewoutstandingOrderDatelbl.TabIndex = 40;
            viewoutstandingOrderDatelbl.Text = "OrderDate";
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label56.Location = new Point(444, 54);
            label56.Name = "label56";
            label56.Size = new Size(99, 21);
            label56.TabIndex = 39;
            label56.Text = "Order Date :";
            // 
            // outstandingOrderIDlbl
            // 
            outstandingOrderIDlbl.AutoSize = true;
            outstandingOrderIDlbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingOrderIDlbl.Location = new Point(592, 21);
            outstandingOrderIDlbl.Name = "outstandingOrderIDlbl";
            outstandingOrderIDlbl.Size = new Size(69, 21);
            outstandingOrderIDlbl.TabIndex = 38;
            outstandingOrderIDlbl.Text = "OrderID";
            // 
            // outstandingOrderIDlbl2
            // 
            outstandingOrderIDlbl2.AutoSize = true;
            outstandingOrderIDlbl2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingOrderIDlbl2.Location = new Point(466, 21);
            outstandingOrderIDlbl2.Name = "outstandingOrderIDlbl2";
            outstandingOrderIDlbl2.Size = new Size(81, 21);
            outstandingOrderIDlbl2.TabIndex = 32;
            outstandingOrderIDlbl2.Text = "Order ID :";
            // 
            // oustandingViewDeliverylbl
            // 
            oustandingViewDeliverylbl.AutoSize = true;
            oustandingViewDeliverylbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oustandingViewDeliverylbl.Location = new Point(416, 162);
            oustandingViewDeliverylbl.Name = "oustandingViewDeliverylbl";
            oustandingViewDeliverylbl.Size = new Size(130, 21);
            oustandingViewDeliverylbl.TabIndex = 37;
            oustandingViewDeliverylbl.Text = "DeliveryAddress";
            // 
            // outstandingViewEmaillbl
            // 
            outstandingViewEmaillbl.AutoSize = true;
            outstandingViewEmaillbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingViewEmaillbl.Location = new Point(204, 162);
            outstandingViewEmaillbl.Name = "outstandingViewEmaillbl";
            outstandingViewEmaillbl.Size = new Size(108, 21);
            outstandingViewEmaillbl.TabIndex = 36;
            outstandingViewEmaillbl.Text = "EmailAddress";
            // 
            // outstandingViewPhoneNumlbl
            // 
            outstandingViewPhoneNumlbl.AutoSize = true;
            outstandingViewPhoneNumlbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingViewPhoneNumlbl.Location = new Point(206, 129);
            outstandingViewPhoneNumlbl.Name = "outstandingViewPhoneNumlbl";
            outstandingViewPhoneNumlbl.Size = new Size(91, 21);
            outstandingViewPhoneNumlbl.TabIndex = 35;
            outstandingViewPhoneNumlbl.Text = "PhoneNum";
            // 
            // outstandingViewContactNamelbl
            // 
            outstandingViewContactNamelbl.AutoSize = true;
            outstandingViewContactNamelbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingViewContactNamelbl.Location = new Point(205, 95);
            outstandingViewContactNamelbl.Name = "outstandingViewContactNamelbl";
            outstandingViewContactNamelbl.Size = new Size(110, 21);
            outstandingViewContactNamelbl.TabIndex = 34;
            outstandingViewContactNamelbl.Text = "ContactName";
            // 
            // outstandingViewDealerNamelbl
            // 
            outstandingViewDealerNamelbl.AutoSize = true;
            outstandingViewDealerNamelbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingViewDealerNamelbl.Location = new Point(207, 62);
            outstandingViewDealerNamelbl.Name = "outstandingViewDealerNamelbl";
            outstandingViewDealerNamelbl.Size = new Size(100, 21);
            outstandingViewDealerNamelbl.TabIndex = 33;
            outstandingViewDealerNamelbl.Text = "DealerName";
            // 
            // outstandingViewDealerIDlbl
            // 
            outstandingViewDealerIDlbl.AutoSize = true;
            outstandingViewDealerIDlbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingViewDealerIDlbl.Location = new Point(212, 23);
            outstandingViewDealerIDlbl.Name = "outstandingViewDealerIDlbl";
            outstandingViewDealerIDlbl.Size = new Size(73, 21);
            outstandingViewDealerIDlbl.TabIndex = 32;
            outstandingViewDealerIDlbl.Text = "DealerID";
            // 
            // outstandingDealerIDlbl
            // 
            outstandingDealerIDlbl.AutoSize = true;
            outstandingDealerIDlbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingDealerIDlbl.Location = new Point(95, 24);
            outstandingDealerIDlbl.Name = "outstandingDealerIDlbl";
            outstandingDealerIDlbl.Size = new Size(89, 21);
            outstandingDealerIDlbl.TabIndex = 24;
            outstandingDealerIDlbl.Text = "Dealer ID : ";
            // 
            // outstandingDealerNamelbl
            // 
            outstandingDealerNamelbl.AutoSize = true;
            outstandingDealerNamelbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingDealerNamelbl.Location = new Point(65, 61);
            outstandingDealerNamelbl.Name = "outstandingDealerNamelbl";
            outstandingDealerNamelbl.Size = new Size(116, 21);
            outstandingDealerNamelbl.TabIndex = 27;
            outstandingDealerNamelbl.Text = "Dealer Name : ";
            // 
            // outstandingDeliveryAddresslbl
            // 
            outstandingDeliveryAddresslbl.AutoSize = true;
            outstandingDeliveryAddresslbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingDeliveryAddresslbl.Location = new Point(392, 131);
            outstandingDeliveryAddresslbl.Name = "outstandingDeliveryAddresslbl";
            outstandingDeliveryAddresslbl.Size = new Size(146, 21);
            outstandingDeliveryAddresslbl.TabIndex = 31;
            outstandingDeliveryAddresslbl.Text = "Delivery Address : ";
            // 
            // outstandingContactNamelbl
            // 
            outstandingContactNamelbl.AutoSize = true;
            outstandingContactNamelbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingContactNamelbl.Location = new Point(58, 96);
            outstandingContactNamelbl.Name = "outstandingContactNamelbl";
            outstandingContactNamelbl.Size = new Size(126, 21);
            outstandingContactNamelbl.TabIndex = 28;
            outstandingContactNamelbl.Text = "Contact Name : ";
            // 
            // outstandingEmaillbl
            // 
            outstandingEmaillbl.AutoSize = true;
            outstandingEmaillbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingEmaillbl.Location = new Point(60, 163);
            outstandingEmaillbl.Name = "outstandingEmaillbl";
            outstandingEmaillbl.Size = new Size(124, 21);
            outstandingEmaillbl.TabIndex = 30;
            outstandingEmaillbl.Text = "Email Address : ";
            // 
            // outstandingPhonelbl
            // 
            outstandingPhonelbl.AutoSize = true;
            outstandingPhonelbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingPhonelbl.Location = new Point(53, 130);
            outstandingPhonelbl.Name = "outstandingPhonelbl";
            outstandingPhonelbl.Size = new Size(132, 21);
            outstandingPhonelbl.TabIndex = 29;
            outstandingPhonelbl.Text = "Phone Number : ";
            // 
            // button23
            // 
            button23.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button23.Location = new Point(696, 532);
            button23.Margin = new Padding(3, 2, 3, 2);
            button23.Name = "button23";
            button23.Size = new Size(138, 38);
            button23.TabIndex = 18;
            button23.Text = "Next";
            button23.UseVisualStyleBackColor = true;
            // 
            // outstandingCancelbtn
            // 
            outstandingCancelbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingCancelbtn.Location = new Point(105, 530);
            outstandingCancelbtn.Margin = new Padding(3, 2, 3, 2);
            outstandingCancelbtn.Name = "outstandingCancelbtn";
            outstandingCancelbtn.Size = new Size(138, 38);
            outstandingCancelbtn.TabIndex = 19;
            outstandingCancelbtn.Text = "Cancel";
            outstandingCancelbtn.UseVisualStyleBackColor = true;
            // 
            // panel44
            // 
            panel44.BackColor = Color.White;
            panel44.Controls.Add(label36);
            panel44.Controls.Add(outstandingIDlbl);
            panel44.Controls.Add(outstandingBackbtn);
            panel44.Location = new Point(0, 4);
            panel44.Margin = new Padding(3, 2, 3, 2);
            panel44.Name = "panel44";
            panel44.Size = new Size(1067, 100);
            panel44.TabIndex = 33;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label36.Location = new Point(39, 1);
            label36.Name = "label36";
            label36.Size = new Size(180, 25);
            label36.TabIndex = 24;
            label36.Text = "Outstanding Order";
            // 
            // outstandingIDlbl
            // 
            outstandingIDlbl.AutoSize = true;
            outstandingIDlbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingIDlbl.Location = new Point(333, 22);
            outstandingIDlbl.Name = "outstandingIDlbl";
            outstandingIDlbl.Size = new Size(194, 30);
            outstandingIDlbl.TabIndex = 22;
            outstandingIDlbl.Text = "Outstanding ID : #";
            // 
            // outstandingBackbtn
            // 
            outstandingBackbtn.BackColor2 = Color.White;
            outstandingBackbtn.BorderColor = Color.White;
            outstandingBackbtn.BorderSize = 2;
            outstandingBackbtn.ButtonBorderColor = Color.Gray;
            outstandingBackbtn.ButtonHighlightColor = Color.Empty;
            outstandingBackbtn.ButtonHighlightColor2 = Color.Empty;
            outstandingBackbtn.ButtonHighlightForeColor = Color.Black;
            outstandingBackbtn.ButtonPressedColor = Color.Empty;
            outstandingBackbtn.ButtonPressedColor2 = Color.Empty;
            outstandingBackbtn.ButtonPressedForeColor = Color.White;
            outstandingBackbtn.ButtonRoundRadius = 30;
            outstandingBackbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingBackbtn.Location = new Point(760, 10);
            outstandingBackbtn.Margin = new Padding(3, 2, 3, 2);
            outstandingBackbtn.Name = "outstandingBackbtn";
            outstandingBackbtn.Size = new Size(138, 38);
            outstandingBackbtn.TabIndex = 23;
            outstandingBackbtn.Text = "Back";
            outstandingBackbtn.Click += outstandingBackbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 17);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 10;
            label2.Text = "From";
            // 
            // settingpnl
            // 
            settingpnl.Controls.Add(reportShowStockbtn);
            settingpnl.Controls.Add(reportShowOrderbtn);
            settingpnl.Controls.Add(panel31);
            settingpnl.Controls.Add(label15);
            settingpnl.Controls.Add(orderchart2);
            settingpnl.Controls.Add(panel33);
            settingpnl.Controls.Add(panel34);
            settingpnl.Controls.Add(orderchart1);
            settingpnl.Controls.Add(panel35);
            settingpnl.Controls.Add(panel36);
            settingpnl.Controls.Add(reportOrderpdfbtn);
            settingpnl.Controls.Add(panel32);
            settingpnl.Controls.Add(orderReportdata);
            settingpnl.Controls.Add(reportOrdercsvbtn);
            settingpnl.Controls.Add(reportlbl);
            settingpnl.Location = new Point(176, 2);
            settingpnl.Name = "settingpnl";
            settingpnl.Size = new Size(1094, 788);
            settingpnl.TabIndex = 5;
            settingpnl.Visible = false;
            settingpnl.MouseDown += Dashboard_MouseDown;
            settingpnl.MouseMove += Dashboard_MouseMove;
            settingpnl.MouseUp += Dashboard_MouseUp;
            // 
            // reportShowStockbtn
            // 
            reportShowStockbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportShowStockbtn.Location = new Point(348, 10);
            reportShowStockbtn.Margin = new Padding(3, 2, 3, 2);
            reportShowStockbtn.Name = "reportShowStockbtn";
            reportShowStockbtn.Size = new Size(141, 42);
            reportShowStockbtn.TabIndex = 81;
            reportShowStockbtn.Text = "Stock";
            reportShowStockbtn.UseVisualStyleBackColor = true;
            reportShowStockbtn.Click += reportShowStockbtn_Click;
            // 
            // reportShowOrderbtn
            // 
            reportShowOrderbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportShowOrderbtn.Location = new Point(183, 11);
            reportShowOrderbtn.Margin = new Padding(3, 2, 3, 2);
            reportShowOrderbtn.Name = "reportShowOrderbtn";
            reportShowOrderbtn.Size = new Size(141, 42);
            reportShowOrderbtn.TabIndex = 80;
            reportShowOrderbtn.Text = "Order";
            reportShowOrderbtn.UseVisualStyleBackColor = true;
            // 
            // panel31
            // 
            panel31.BackColor = SystemColors.ControlDark;
            panel31.BorderStyle = BorderStyle.Fixed3D;
            panel31.ForeColor = SystemColors.ControlText;
            panel31.Location = new Point(48, 557);
            panel31.Name = "panel31";
            panel31.Size = new Size(940, 5);
            panel31.TabIndex = 79;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(15, 538);
            label15.Name = "label15";
            label15.Size = new Size(195, 24);
            label15.TabIndex = 78;
            label15.Text = "Top Selling Product";
            // 
            // orderchart2
            // 
            chartArea16.Name = "ChartArea1";
            orderchart2.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            orderchart2.Legends.Add(legend16);
            orderchart2.Location = new Point(552, 287);
            orderchart2.Margin = new Padding(3, 4, 3, 4);
            orderchart2.Name = "orderchart2";
            orderchart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.LabelBackColor = Color.White;
            series16.Legend = "Legend1";
            series16.MarkerBorderColor = Color.White;
            series16.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series16.Name = "Total Income";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series17.Legend = "Legend1";
            series17.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series17.Name = "Expenses";
            orderchart2.Series.Add(series16);
            orderchart2.Series.Add(series17);
            orderchart2.Size = new Size(486, 258);
            orderchart2.TabIndex = 77;
            orderchart2.Text = "chart2";
            title10.Alignment = ContentAlignment.TopLeft;
            title10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title10.Name = "Sales Overview";
            title10.Text = "Sales Overview";
            orderchart2.Titles.Add(title10);
            // 
            // panel33
            // 
            panel33.BorderStyle = BorderStyle.FixedSingle;
            panel33.Controls.Add(MonthlyTotalOrderValue);
            panel33.Controls.Add(MonthlyTotalOrder);
            panel33.Location = new Point(793, 62);
            panel33.Name = "panel33";
            panel33.Size = new Size(218, 89);
            panel33.TabIndex = 48;
            // 
            // MonthlyTotalOrderValue
            // 
            MonthlyTotalOrderValue.AutoSize = true;
            MonthlyTotalOrderValue.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            MonthlyTotalOrderValue.Location = new Point(27, 63);
            MonthlyTotalOrderValue.Name = "MonthlyTotalOrderValue";
            MonthlyTotalOrderValue.Size = new Size(160, 17);
            MonthlyTotalOrderValue.TabIndex = 18;
            MonthlyTotalOrderValue.Text = "MonthlyTotalOrderValue";
            // 
            // MonthlyTotalOrder
            // 
            MonthlyTotalOrder.AutoSize = true;
            MonthlyTotalOrder.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MonthlyTotalOrder.Location = new Point(2, 8);
            MonthlyTotalOrder.Name = "MonthlyTotalOrder";
            MonthlyTotalOrder.Size = new Size(195, 24);
            MonthlyTotalOrder.TabIndex = 12;
            MonthlyTotalOrder.Text = "Monthly Total Order";
            // 
            // panel34
            // 
            panel34.BorderStyle = BorderStyle.FixedSingle;
            panel34.Controls.Add(MonthlyTotalSalesValue);
            panel34.Controls.Add(MonthlyTotalSales);
            panel34.Location = new Point(532, 62);
            panel34.Name = "panel34";
            panel34.Size = new Size(224, 89);
            panel34.TabIndex = 46;
            // 
            // MonthlyTotalSalesValue
            // 
            MonthlyTotalSalesValue.AutoSize = true;
            MonthlyTotalSalesValue.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            MonthlyTotalSalesValue.Location = new Point(34, 63);
            MonthlyTotalSalesValue.Name = "MonthlyTotalSalesValue";
            MonthlyTotalSalesValue.Size = new Size(154, 17);
            MonthlyTotalSalesValue.TabIndex = 17;
            MonthlyTotalSalesValue.Text = "MonthlyTotalSalesValue";
            // 
            // MonthlyTotalSales
            // 
            MonthlyTotalSales.AutoSize = true;
            MonthlyTotalSales.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MonthlyTotalSales.Location = new Point(14, 11);
            MonthlyTotalSales.Name = "MonthlyTotalSales";
            MonthlyTotalSales.Size = new Size(192, 24);
            MonthlyTotalSales.TabIndex = 12;
            MonthlyTotalSales.Text = "Monthly Total Sales";
            // 
            // orderchart1
            // 
            chartArea17.Name = "ChartArea1";
            orderchart1.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            orderchart1.Legends.Add(legend17);
            orderchart1.Location = new Point(48, 282);
            orderchart1.Name = "orderchart1";
            series18.ChartArea = "ChartArea1";
            series18.IsXValueIndexed = true;
            series18.Legend = "Legend1";
            series18.Name = "Order";
            orderchart1.Series.Add(series18);
            orderchart1.Size = new Size(463, 258);
            orderchart1.TabIndex = 76;
            orderchart1.Text = "chart1";
            title11.Alignment = ContentAlignment.TopLeft;
            title11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title11.Name = "Sales Overview";
            title11.Text = "Order Statistics";
            orderchart1.Titles.Add(title11);
            // 
            // panel35
            // 
            panel35.BorderStyle = BorderStyle.FixedSingle;
            panel35.Controls.Add(TodayTotalOrderValue);
            panel35.Controls.Add(TodayTotalOrder);
            panel35.Location = new Point(299, 62);
            panel35.Name = "panel35";
            panel35.Size = new Size(207, 89);
            panel35.TabIndex = 47;
            // 
            // TodayTotalOrderValue
            // 
            TodayTotalOrderValue.AutoSize = true;
            TodayTotalOrderValue.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            TodayTotalOrderValue.Location = new Point(16, 62);
            TodayTotalOrderValue.Name = "TodayTotalOrderValue";
            TodayTotalOrderValue.Size = new Size(145, 17);
            TodayTotalOrderValue.TabIndex = 16;
            TodayTotalOrderValue.Text = "TodayTotalOrderValue";
            // 
            // TodayTotalOrder
            // 
            TodayTotalOrder.AutoSize = true;
            TodayTotalOrder.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TodayTotalOrder.Location = new Point(3, 8);
            TodayTotalOrder.Name = "TodayTotalOrder";
            TodayTotalOrder.Size = new Size(180, 24);
            TodayTotalOrder.TabIndex = 12;
            TodayTotalOrder.Text = "Today Total Order";
            // 
            // panel36
            // 
            panel36.BorderStyle = BorderStyle.FixedSingle;
            panel36.Controls.Add(reportInvoicelbl);
            panel36.Controls.Add(TodayTotalSales);
            panel36.Location = new Point(64, 62);
            panel36.Name = "panel36";
            panel36.Size = new Size(207, 89);
            panel36.TabIndex = 45;
            // 
            // reportInvoicelbl
            // 
            reportInvoicelbl.AutoSize = true;
            reportInvoicelbl.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            reportInvoicelbl.Location = new Point(31, 63);
            reportInvoicelbl.Name = "reportInvoicelbl";
            reportInvoicelbl.Size = new Size(139, 17);
            reportInvoicelbl.TabIndex = 15;
            reportInvoicelbl.Text = "TodayTotalSalesValue";
            // 
            // TodayTotalSales
            // 
            TodayTotalSales.AutoSize = true;
            TodayTotalSales.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TodayTotalSales.Location = new Point(5, 10);
            TodayTotalSales.Name = "TodayTotalSales";
            TodayTotalSales.Size = new Size(177, 24);
            TodayTotalSales.TabIndex = 12;
            TodayTotalSales.Text = "Today Total Sales";
            // 
            // reportOrderpdfbtn
            // 
            reportOrderpdfbtn.BackColor = SystemColors.Menu;
            reportOrderpdfbtn.BackColor2 = Color.White;
            reportOrderpdfbtn.BorderColor = Color.White;
            reportOrderpdfbtn.BorderSize = 2;
            reportOrderpdfbtn.ButtonBorderColor = Color.Gray;
            reportOrderpdfbtn.ButtonHighlightColor = Color.Empty;
            reportOrderpdfbtn.ButtonHighlightColor2 = Color.Empty;
            reportOrderpdfbtn.ButtonHighlightForeColor = Color.Black;
            reportOrderpdfbtn.ButtonPressedColor = Color.Empty;
            reportOrderpdfbtn.ButtonPressedColor2 = Color.Empty;
            reportOrderpdfbtn.ButtonPressedForeColor = Color.White;
            reportOrderpdfbtn.ButtonRoundRadius = 30;
            reportOrderpdfbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportOrderpdfbtn.Location = new Point(923, 9);
            reportOrderpdfbtn.Margin = new Padding(3, 2, 3, 2);
            reportOrderpdfbtn.Name = "reportOrderpdfbtn";
            reportOrderpdfbtn.Size = new Size(141, 42);
            reportOrderpdfbtn.TabIndex = 44;
            reportOrderpdfbtn.Text = "Download PDF";
            reportOrderpdfbtn.Click += reportOrderpdfbtn_Click;
            // 
            // panel32
            // 
            panel32.Controls.Add(dateTimePicker3);
            panel32.Controls.Add(label21);
            panel32.Controls.Add(orderReportsearchbtn);
            panel32.Controls.Add(label30);
            panel32.Controls.Add(orderReportClearbtn);
            panel32.Controls.Add(dateTimePicker4);
            panel32.Location = new Point(43, 168);
            panel32.Margin = new Padding(3, 2, 3, 2);
            panel32.Name = "panel32";
            panel32.Size = new Size(1011, 108);
            panel32.TabIndex = 42;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(21, 48);
            dateTimePicker3.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(212, 23);
            dateTimePicker3.TabIndex = 8;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(23, 4);
            label21.Name = "label21";
            label21.Size = new Size(55, 25);
            label21.TabIndex = 10;
            label21.Text = "From";
            // 
            // orderReportsearchbtn
            // 
            orderReportsearchbtn.BackColor2 = Color.White;
            orderReportsearchbtn.BorderColor = Color.White;
            orderReportsearchbtn.BorderSize = 2;
            orderReportsearchbtn.ButtonBorderColor = Color.Gray;
            orderReportsearchbtn.ButtonHighlightColor = Color.Empty;
            orderReportsearchbtn.ButtonHighlightColor2 = Color.Empty;
            orderReportsearchbtn.ButtonHighlightForeColor = Color.Black;
            orderReportsearchbtn.ButtonPressedColor = Color.Empty;
            orderReportsearchbtn.ButtonPressedColor2 = Color.Empty;
            orderReportsearchbtn.ButtonPressedForeColor = Color.White;
            orderReportsearchbtn.ButtonRoundRadius = 30;
            orderReportsearchbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderReportsearchbtn.Location = new Point(525, 46);
            orderReportsearchbtn.Margin = new Padding(3, 2, 3, 2);
            orderReportsearchbtn.Name = "orderReportsearchbtn";
            orderReportsearchbtn.Size = new Size(95, 39);
            orderReportsearchbtn.TabIndex = 25;
            orderReportsearchbtn.Text = "Search";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.Location = new Point(282, 4);
            label30.Name = "label30";
            label30.Size = new Size(31, 25);
            label30.TabIndex = 11;
            label30.Text = "To";
            // 
            // orderReportClearbtn
            // 
            orderReportClearbtn.BackColor2 = Color.White;
            orderReportClearbtn.BorderColor = Color.White;
            orderReportClearbtn.BorderSize = 2;
            orderReportClearbtn.ButtonBorderColor = Color.Gray;
            orderReportClearbtn.ButtonHighlightColor = Color.Empty;
            orderReportClearbtn.ButtonHighlightColor2 = Color.Empty;
            orderReportClearbtn.ButtonHighlightForeColor = Color.Black;
            orderReportClearbtn.ButtonPressedColor = Color.Empty;
            orderReportClearbtn.ButtonPressedColor2 = Color.Empty;
            orderReportClearbtn.ButtonPressedForeColor = Color.White;
            orderReportClearbtn.ButtonRoundRadius = 30;
            orderReportClearbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderReportClearbtn.Location = new Point(647, 46);
            orderReportClearbtn.Margin = new Padding(3, 2, 3, 2);
            orderReportClearbtn.Name = "orderReportClearbtn";
            orderReportClearbtn.Size = new Size(89, 40);
            orderReportClearbtn.TabIndex = 15;
            orderReportClearbtn.Text = "Clear";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(278, 48);
            dateTimePicker4.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(220, 23);
            dateTimePicker4.TabIndex = 9;
            // 
            // orderReportdata
            // 
            orderReportdata.AllowUserToAddRows = false;
            orderReportdata.AllowUserToDeleteRows = false;
            dataGridViewCellStyle184.BackColor = Color.Gainsboro;
            orderReportdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle184;
            orderReportdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle185.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle185.BackColor = SystemColors.Control;
            dataGridViewCellStyle185.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle185.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle185.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle185.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle185.WrapMode = DataGridViewTriState.True;
            orderReportdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle185;
            orderReportdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle186.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle186.BackColor = SystemColors.Window;
            dataGridViewCellStyle186.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle186.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle186.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle186.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle186.WrapMode = DataGridViewTriState.False;
            orderReportdata.DefaultCellStyle = dataGridViewCellStyle186;
            orderReportdata.Location = new Point(27, 573);
            orderReportdata.Margin = new Padding(3, 2, 3, 2);
            orderReportdata.Name = "orderReportdata";
            orderReportdata.RowHeadersVisible = false;
            orderReportdata.RowHeadersWidth = 51;
            orderReportdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderReportdata.Size = new Size(1040, 195);
            orderReportdata.TabIndex = 40;
            // 
            // reportOrdercsvbtn
            // 
            reportOrdercsvbtn.BackColor2 = Color.White;
            reportOrdercsvbtn.BorderColor = Color.White;
            reportOrdercsvbtn.BorderSize = 2;
            reportOrdercsvbtn.ButtonBorderColor = Color.Gray;
            reportOrdercsvbtn.ButtonHighlightColor = Color.Empty;
            reportOrdercsvbtn.ButtonHighlightColor2 = Color.Empty;
            reportOrdercsvbtn.ButtonHighlightForeColor = Color.Black;
            reportOrdercsvbtn.ButtonPressedColor = Color.Empty;
            reportOrdercsvbtn.ButtonPressedColor2 = Color.Empty;
            reportOrdercsvbtn.ButtonPressedForeColor = Color.White;
            reportOrdercsvbtn.ButtonRoundRadius = 30;
            reportOrdercsvbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportOrdercsvbtn.Location = new Point(751, 9);
            reportOrdercsvbtn.Margin = new Padding(3, 2, 3, 2);
            reportOrdercsvbtn.Name = "reportOrdercsvbtn";
            reportOrdercsvbtn.Size = new Size(141, 42);
            reportOrdercsvbtn.TabIndex = 41;
            reportOrdercsvbtn.Text = "Download CSV";
            reportOrdercsvbtn.Click += reportOrdercsvbtn_Click;
            // 
            // reportlbl
            // 
            reportlbl.AutoSize = true;
            reportlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportlbl.Location = new Point(16, 18);
            reportlbl.Name = "reportlbl";
            reportlbl.Size = new Size(139, 25);
            reportlbl.TabIndex = 6;
            reportlbl.Text = "Order Reports";
            // 
            // userspnl
            // 
            userspnl.Controls.Add(groupBox3);
            userspnl.Controls.Add(panel7);
            userspnl.Controls.Add(panel3);
            userspnl.Controls.Add(newAccountbtn);
            userspnl.Controls.Add(userData);
            userspnl.Controls.Add(userslbl);
            userspnl.Location = new Point(176, 2);
            userspnl.Name = "userspnl";
            userspnl.Size = new Size(1094, 788);
            userspnl.TabIndex = 3;
            userspnl.Visible = false;
            userspnl.MouseDown += Dashboard_MouseDown;
            userspnl.MouseMove += Dashboard_MouseMove;
            userspnl.MouseUp += Dashboard_MouseUp;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(accountSearchBtn);
            groupBox3.Controls.Add(accountSearchBox);
            groupBox3.Controls.Add(editAccountbtn);
            groupBox3.Controls.Add(viewAccountbtn);
            groupBox3.Controls.Add(disableAccountbtn);
            groupBox3.Controls.Add(enableAccountbtn);
            groupBox3.Location = new Point(15, 218);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(1060, 130);
            groupBox3.TabIndex = 42;
            groupBox3.TabStop = false;
            // 
            // accountSearchBox
            // 
            accountSearchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountSearchBox.Location = new Point(16, 86);
            accountSearchBox.Margin = new Padding(3, 4, 3, 4);
            accountSearchBox.Multiline = true;
            accountSearchBox.Name = "accountSearchBox";
            accountSearchBox.PlaceholderText = "   Search Username";
            accountSearchBox.Size = new Size(749, 32);
            accountSearchBox.TabIndex = 41;
            // 
            // editAccountbtn
            // 
            editAccountbtn.BackColor = SystemColors.Menu;
            editAccountbtn.BackColor2 = Color.White;
            editAccountbtn.BorderColor = Color.White;
            editAccountbtn.BorderSize = 2;
            editAccountbtn.ButtonBorderColor = Color.Gray;
            editAccountbtn.ButtonHighlightColor = Color.Empty;
            editAccountbtn.ButtonHighlightColor2 = Color.Empty;
            editAccountbtn.ButtonHighlightForeColor = Color.Black;
            editAccountbtn.ButtonPressedColor = Color.White;
            editAccountbtn.ButtonPressedColor2 = Color.Empty;
            editAccountbtn.ButtonPressedForeColor = Color.Gray;
            editAccountbtn.ButtonRoundRadius = 30;
            editAccountbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editAccountbtn.ForeColor = Color.Black;
            editAccountbtn.Location = new Point(19, 34);
            editAccountbtn.Margin = new Padding(4);
            editAccountbtn.Name = "editAccountbtn";
            editAccountbtn.Size = new Size(128, 42);
            editAccountbtn.TabIndex = 22;
            editAccountbtn.Text = "Edit Account";
            editAccountbtn.Click += editAccountbtn_Click;
            // 
            // viewAccountbtn
            // 
            viewAccountbtn.BackColor = SystemColors.Menu;
            viewAccountbtn.BackColor2 = Color.White;
            viewAccountbtn.BorderColor = Color.White;
            viewAccountbtn.BorderSize = 2;
            viewAccountbtn.ButtonBorderColor = Color.Gray;
            viewAccountbtn.ButtonHighlightColor = Color.Empty;
            viewAccountbtn.ButtonHighlightColor2 = Color.Empty;
            viewAccountbtn.ButtonHighlightForeColor = Color.Black;
            viewAccountbtn.ButtonPressedColor = Color.White;
            viewAccountbtn.ButtonPressedColor2 = Color.Empty;
            viewAccountbtn.ButtonPressedForeColor = Color.Gray;
            viewAccountbtn.ButtonRoundRadius = 30;
            viewAccountbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewAccountbtn.ForeColor = Color.Black;
            viewAccountbtn.Location = new Point(171, 34);
            viewAccountbtn.Margin = new Padding(4);
            viewAccountbtn.Name = "viewAccountbtn";
            viewAccountbtn.Size = new Size(121, 44);
            viewAccountbtn.TabIndex = 23;
            viewAccountbtn.Text = "View Account";
            viewAccountbtn.Click += viewAccountbtn_Click;
            // 
            // disableAccountbtn
            // 
            disableAccountbtn.BackColor = Color.Red;
            disableAccountbtn.BackColor2 = Color.IndianRed;
            disableAccountbtn.BorderColor = Color.White;
            disableAccountbtn.BorderSize = 2;
            disableAccountbtn.ButtonBorderColor = Color.Gray;
            disableAccountbtn.ButtonHighlightColor = Color.Empty;
            disableAccountbtn.ButtonHighlightColor2 = Color.Empty;
            disableAccountbtn.ButtonHighlightForeColor = Color.Black;
            disableAccountbtn.ButtonPressedColor = Color.White;
            disableAccountbtn.ButtonPressedColor2 = Color.Empty;
            disableAccountbtn.ButtonPressedForeColor = Color.Gray;
            disableAccountbtn.ButtonRoundRadius = 30;
            disableAccountbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            disableAccountbtn.ForeColor = Color.White;
            disableAccountbtn.Location = new Point(420, 34);
            disableAccountbtn.Margin = new Padding(4);
            disableAccountbtn.Name = "disableAccountbtn";
            disableAccountbtn.Size = new Size(95, 42);
            disableAccountbtn.TabIndex = 28;
            disableAccountbtn.Text = "Disable";
            disableAccountbtn.Click += disableAccountbtn_Click;
            // 
            // enableAccountbtn
            // 
            enableAccountbtn.BackColor = Color.LimeGreen;
            enableAccountbtn.BackColor2 = Color.Lime;
            enableAccountbtn.BorderColor = Color.White;
            enableAccountbtn.BorderSize = 2;
            enableAccountbtn.ButtonBorderColor = Color.Gray;
            enableAccountbtn.ButtonHighlightColor = Color.Empty;
            enableAccountbtn.ButtonHighlightColor2 = Color.Empty;
            enableAccountbtn.ButtonHighlightForeColor = Color.Black;
            enableAccountbtn.ButtonPressedColor = Color.White;
            enableAccountbtn.ButtonPressedColor2 = Color.Empty;
            enableAccountbtn.ButtonPressedForeColor = Color.Gray;
            enableAccountbtn.ButtonRoundRadius = 30;
            enableAccountbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enableAccountbtn.ForeColor = Color.White;
            enableAccountbtn.Location = new Point(326, 34);
            enableAccountbtn.Margin = new Padding(4);
            enableAccountbtn.Name = "enableAccountbtn";
            enableAccountbtn.Size = new Size(86, 41);
            enableAccountbtn.TabIndex = 29;
            enableAccountbtn.Text = "Enable";
            enableAccountbtn.Click += enableAccountbtn_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(accountbtnFirstPage);
            panel7.Controls.Add(accountIndexlbl);
            panel7.Controls.Add(accountbtnPrevPage);
            panel7.Controls.Add(accountbtnLastPage);
            panel7.Controls.Add(accountbtnNxtPage);
            panel7.Location = new Point(578, 705);
            panel7.Name = "panel7";
            panel7.Size = new Size(495, 53);
            panel7.TabIndex = 30;
            // 
            // accountbtnFirstPage
            // 
            accountbtnFirstPage.BackColor = SystemColors.Menu;
            accountbtnFirstPage.BackColor2 = Color.White;
            accountbtnFirstPage.BorderColor = Color.Tomato;
            accountbtnFirstPage.BorderSize = 2;
            accountbtnFirstPage.ButtonBorderColor = Color.Gray;
            accountbtnFirstPage.ButtonHighlightColor = Color.Empty;
            accountbtnFirstPage.ButtonHighlightColor2 = Color.Empty;
            accountbtnFirstPage.ButtonHighlightForeColor = Color.Black;
            accountbtnFirstPage.ButtonPressedColor = Color.White;
            accountbtnFirstPage.ButtonPressedColor2 = Color.Empty;
            accountbtnFirstPage.ButtonPressedForeColor = Color.Gray;
            accountbtnFirstPage.ButtonRoundRadius = 30;
            accountbtnFirstPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountbtnFirstPage.ForeColor = Color.Black;
            accountbtnFirstPage.Location = new Point(18, 11);
            accountbtnFirstPage.Margin = new Padding(3, 4, 3, 4);
            accountbtnFirstPage.Name = "accountbtnFirstPage";
            accountbtnFirstPage.Size = new Size(75, 38);
            accountbtnFirstPage.TabIndex = 31;
            accountbtnFirstPage.Text = "First";
            accountbtnFirstPage.Click += accountbtnFirstPage_Click;
            // 
            // accountIndexlbl
            // 
            accountIndexlbl.AutoSize = true;
            accountIndexlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountIndexlbl.Location = new Point(199, 20);
            accountIndexlbl.Name = "accountIndexlbl";
            accountIndexlbl.Size = new Size(79, 20);
            accountIndexlbl.TabIndex = 3;
            accountIndexlbl.Text = "LabelData";
            // 
            // accountbtnPrevPage
            // 
            accountbtnPrevPage.AccessibleRole = AccessibleRole.None;
            accountbtnPrevPage.BackColor = SystemColors.Menu;
            accountbtnPrevPage.BackColor2 = Color.White;
            accountbtnPrevPage.BorderColor = Color.Tomato;
            accountbtnPrevPage.BorderSize = 2;
            accountbtnPrevPage.ButtonBorderColor = Color.Gray;
            accountbtnPrevPage.ButtonHighlightColor = Color.Empty;
            accountbtnPrevPage.ButtonHighlightColor2 = Color.Empty;
            accountbtnPrevPage.ButtonHighlightForeColor = Color.Black;
            accountbtnPrevPage.ButtonPressedColor = Color.White;
            accountbtnPrevPage.ButtonPressedColor2 = Color.Empty;
            accountbtnPrevPage.ButtonPressedForeColor = Color.Gray;
            accountbtnPrevPage.ButtonRoundRadius = 30;
            accountbtnPrevPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountbtnPrevPage.ForeColor = Color.Black;
            accountbtnPrevPage.Location = new Point(108, 11);
            accountbtnPrevPage.Margin = new Padding(3, 4, 3, 4);
            accountbtnPrevPage.Name = "accountbtnPrevPage";
            accountbtnPrevPage.Size = new Size(69, 38);
            accountbtnPrevPage.TabIndex = 33;
            accountbtnPrevPage.Text = "Prev";
            accountbtnPrevPage.Click += accountbtnPrevPage_Click;
            // 
            // accountbtnLastPage
            // 
            accountbtnLastPage.BackColor = SystemColors.Menu;
            accountbtnLastPage.BackColor2 = Color.White;
            accountbtnLastPage.BorderColor = Color.White;
            accountbtnLastPage.BorderSize = 2;
            accountbtnLastPage.ButtonBorderColor = Color.Gray;
            accountbtnLastPage.ButtonHighlightColor = Color.Empty;
            accountbtnLastPage.ButtonHighlightColor2 = Color.Empty;
            accountbtnLastPage.ButtonHighlightForeColor = Color.Black;
            accountbtnLastPage.ButtonPressedColor = Color.White;
            accountbtnLastPage.ButtonPressedColor2 = Color.Empty;
            accountbtnLastPage.ButtonPressedForeColor = Color.Gray;
            accountbtnLastPage.ButtonRoundRadius = 30;
            accountbtnLastPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountbtnLastPage.ForeColor = Color.Black;
            accountbtnLastPage.Location = new Point(408, 11);
            accountbtnLastPage.Margin = new Padding(3, 4, 3, 4);
            accountbtnLastPage.Name = "accountbtnLastPage";
            accountbtnLastPage.Size = new Size(70, 40);
            accountbtnLastPage.TabIndex = 34;
            accountbtnLastPage.Text = "Last";
            accountbtnLastPage.Click += accountbtnLastPage_Click;
            // 
            // accountbtnNxtPage
            // 
            accountbtnNxtPage.BackColor = SystemColors.Menu;
            accountbtnNxtPage.BackColor2 = Color.White;
            accountbtnNxtPage.BorderColor = Color.Tomato;
            accountbtnNxtPage.BorderSize = 2;
            accountbtnNxtPage.ButtonBorderColor = Color.Gray;
            accountbtnNxtPage.ButtonHighlightColor = Color.Empty;
            accountbtnNxtPage.ButtonHighlightColor2 = Color.Empty;
            accountbtnNxtPage.ButtonHighlightForeColor = Color.Black;
            accountbtnNxtPage.ButtonPressedColor = Color.White;
            accountbtnNxtPage.ButtonPressedColor2 = Color.Empty;
            accountbtnNxtPage.ButtonPressedForeColor = Color.Gray;
            accountbtnNxtPage.ButtonRoundRadius = 30;
            accountbtnNxtPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountbtnNxtPage.ForeColor = Color.Black;
            accountbtnNxtPage.Location = new Point(317, 11);
            accountbtnNxtPage.Margin = new Padding(3, 4, 3, 4);
            accountbtnNxtPage.Name = "accountbtnNxtPage";
            accountbtnNxtPage.Size = new Size(71, 38);
            accountbtnNxtPage.TabIndex = 32;
            accountbtnNxtPage.Text = "Next";
            accountbtnNxtPage.Click += accountbtnNxtPage_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(24, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(1050, 153);
            panel3.TabIndex = 40;
            // 
            // panel4
            // 
            panel4.Controls.Add(label7);
            panel4.Controls.Add(accountUserCountlbl3);
            panel4.Location = new Point(746, 16);
            panel4.Name = "panel4";
            panel4.Size = new Size(259, 130);
            panel4.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 93);
            label7.Name = "label7";
            label7.Size = new Size(111, 30);
            label7.TabIndex = 5;
            label7.Text = "New Users";
            // 
            // accountUserCountlbl3
            // 
            accountUserCountlbl3.AutoSize = true;
            accountUserCountlbl3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountUserCountlbl3.Location = new Point(40, 31);
            accountUserCountlbl3.Name = "accountUserCountlbl3";
            accountUserCountlbl3.Size = new Size(196, 50);
            accountUserCountlbl3.TabIndex = 4;
            accountUserCountlbl3.Text = "LabelData";
            // 
            // panel5
            // 
            panel5.Controls.Add(label9);
            panel5.Controls.Add(accountUserCountlbl);
            panel5.Location = new Point(42, 16);
            panel5.Name = "panel5";
            panel5.Size = new Size(253, 132);
            panel5.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 88);
            label9.Name = "label9";
            label9.Size = new Size(113, 30);
            label9.TabIndex = 1;
            label9.Text = "Total Users";
            // 
            // accountUserCountlbl
            // 
            accountUserCountlbl.AutoSize = true;
            accountUserCountlbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountUserCountlbl.Location = new Point(27, 28);
            accountUserCountlbl.Name = "accountUserCountlbl";
            accountUserCountlbl.Size = new Size(196, 50);
            accountUserCountlbl.TabIndex = 0;
            accountUserCountlbl.Text = "LabelData";
            // 
            // panel6
            // 
            panel6.Controls.Add(accountUserCountlbl2);
            panel6.Controls.Add(label12);
            panel6.Location = new Point(387, 16);
            panel6.Name = "panel6";
            panel6.Size = new Size(258, 130);
            panel6.TabIndex = 27;
            // 
            // accountUserCountlbl2
            // 
            accountUserCountlbl2.AutoSize = true;
            accountUserCountlbl2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountUserCountlbl2.Location = new Point(33, 30);
            accountUserCountlbl2.Name = "accountUserCountlbl2";
            accountUserCountlbl2.Size = new Size(196, 50);
            accountUserCountlbl2.TabIndex = 2;
            accountUserCountlbl2.Text = "LabelData";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(42, 88);
            label12.Name = "label12";
            label12.Size = new Size(126, 30);
            label12.TabIndex = 2;
            label12.Text = "Active Users";
            // 
            // newAccountbtn
            // 
            newAccountbtn.BackColor = Color.LimeGreen;
            newAccountbtn.BackColor2 = Color.Lime;
            newAccountbtn.BorderColor = Color.White;
            newAccountbtn.BorderSize = 2;
            newAccountbtn.ButtonBorderColor = Color.Gray;
            newAccountbtn.ButtonHighlightColor = Color.Empty;
            newAccountbtn.ButtonHighlightColor2 = Color.Empty;
            newAccountbtn.ButtonHighlightForeColor = Color.Black;
            newAccountbtn.ButtonPressedColor = Color.White;
            newAccountbtn.ButtonPressedColor2 = Color.Empty;
            newAccountbtn.ButtonPressedForeColor = Color.Gray;
            newAccountbtn.ButtonRoundRadius = 30;
            newAccountbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newAccountbtn.ForeColor = Color.White;
            newAccountbtn.Location = new Point(902, 8);
            newAccountbtn.Margin = new Padding(4);
            newAccountbtn.Name = "newAccountbtn";
            newAccountbtn.Size = new Size(140, 37);
            newAccountbtn.TabIndex = 24;
            newAccountbtn.Text = "New Account";
            newAccountbtn.Click += newAccountbtn_Click;
            // 
            // userData
            // 
            userData.AllowUserToAddRows = false;
            userData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle187.BackColor = Color.Gainsboro;
            dataGridViewCellStyle187.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle187.ForeColor = Color.Black;
            dataGridViewCellStyle187.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle187.SelectionForeColor = Color.Black;
            userData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle187;
            userData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle188.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle188.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle188.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle188.ForeColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle188.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle188.SelectionForeColor = SystemColors.HighlightText;
            userData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle188;
            userData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userData.Columns.AddRange(new DataGridViewColumn[] { usercheckColumn });
            dataGridViewCellStyle189.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle189.BackColor = SystemColors.Window;
            dataGridViewCellStyle189.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle189.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle189.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle189.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle189.WrapMode = DataGridViewTriState.False;
            userData.DefaultCellStyle = dataGridViewCellStyle189;
            userData.GridColor = SystemColors.WindowText;
            userData.Location = new Point(13, 366);
            userData.Margin = new Padding(3, 4, 3, 4);
            userData.Name = "userData";
            dataGridViewCellStyle190.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle190.BackColor = SystemColors.Control;
            dataGridViewCellStyle190.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle190.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle190.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle190.SelectionForeColor = SystemColors.HighlightText;
            userData.RowHeadersDefaultCellStyle = dataGridViewCellStyle190;
            userData.RowHeadersVisible = false;
            userData.RowHeadersWidth = 51;
            userData.RowTemplate.Height = 24;
            userData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userData.Size = new Size(1063, 326);
            userData.TabIndex = 1;
            userData.CellClick += userData_CellClick;
            userData.CellContentClick += userData_CellContentClick;
            // 
            // userslbl
            // 
            userslbl.AutoSize = true;
            userslbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userslbl.Location = new Point(24, 7);
            userslbl.Name = "userslbl";
            userslbl.Size = new Size(183, 25);
            userslbl.TabIndex = 0;
            userslbl.Text = "Users Management";
            // 
            // inventorypnl
            // 
            inventorypnl.Controls.Add(panel54);
            inventorypnl.Controls.Add(panel55);
            inventorypnl.Controls.Add(ZoomProductbtn);
            inventorypnl.Controls.Add(panel8);
            inventorypnl.Controls.Add(delProductbtn);
            inventorypnl.Controls.Add(stockSearchBox);
            inventorypnl.Controls.Add(stocklbl);
            inventorypnl.Controls.Add(stockData);
            inventorypnl.Controls.Add(editProductbtn);
            inventorypnl.Controls.Add(newProductbtn);
            inventorypnl.Controls.Add(viewProductbtn);
            inventorypnl.Controls.Add(stockSummarypnl);
            inventorypnl.Location = new Point(176, 2);
            inventorypnl.Name = "inventorypnl";
            inventorypnl.Size = new Size(1091, 788);
            inventorypnl.TabIndex = 16;
            inventorypnl.Visible = false;
            inventorypnl.MouseDown += Dashboard_MouseDown;
            inventorypnl.MouseMove += Dashboard_MouseMove;
            inventorypnl.MouseUp += Dashboard_MouseUp;
            // 
            // panel54
            // 
            panel54.Controls.Add(stockOutofStockbox);
            panel54.Controls.Add(stockDangerbox);
            panel54.Controls.Add(stockReOrderbox);
            panel54.Controls.Add(panel57);
            panel54.Controls.Add(panel58);
            panel54.Controls.Add(panel59);
            panel54.Controls.Add(panel63);
            panel54.Controls.Add(label37);
            panel54.Controls.Add(label40);
            panel54.Controls.Add(label60);
            panel54.Location = new Point(46, 200);
            panel54.Margin = new Padding(3, 2, 3, 2);
            panel54.Name = "panel54";
            panel54.Size = new Size(1003, 42);
            panel54.TabIndex = 40;
            // 
            // stockOutofStockbox
            // 
            stockOutofStockbox.BackColor = SystemColors.Menu;
            stockOutofStockbox.BorderStyle = BorderStyle.None;
            stockOutofStockbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockOutofStockbox.Location = new Point(744, 10);
            stockOutofStockbox.Margin = new Padding(3, 2, 3, 2);
            stockOutofStockbox.Name = "stockOutofStockbox";
            stockOutofStockbox.ReadOnly = true;
            stockOutofStockbox.Size = new Size(26, 19);
            stockOutofStockbox.TabIndex = 48;
            stockOutofStockbox.Text = "880";
            // 
            // stockDangerbox
            // 
            stockDangerbox.BackColor = SystemColors.Menu;
            stockDangerbox.BorderStyle = BorderStyle.None;
            stockDangerbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockDangerbox.Location = new Point(490, 14);
            stockDangerbox.Margin = new Padding(3, 2, 3, 2);
            stockDangerbox.Name = "stockDangerbox";
            stockDangerbox.ReadOnly = true;
            stockDangerbox.Size = new Size(26, 19);
            stockDangerbox.TabIndex = 48;
            stockDangerbox.Text = "880";
            // 
            // stockReOrderbox
            // 
            stockReOrderbox.BackColor = SystemColors.Menu;
            stockReOrderbox.BorderStyle = BorderStyle.None;
            stockReOrderbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockReOrderbox.Location = new Point(251, 14);
            stockReOrderbox.Margin = new Padding(3, 2, 3, 2);
            stockReOrderbox.Name = "stockReOrderbox";
            stockReOrderbox.ReadOnly = true;
            stockReOrderbox.Size = new Size(26, 19);
            stockReOrderbox.TabIndex = 48;
            stockReOrderbox.Text = "880";
            // 
            // panel57
            // 
            panel57.AutoSize = true;
            panel57.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel57.Location = new Point(256, 11);
            panel57.Margin = new Padding(3, 2, 3, 2);
            panel57.Name = "panel57";
            panel57.Size = new Size(0, 0);
            panel57.TabIndex = 52;
            panel57.Paint += panel26_Paint;
            // 
            // panel58
            // 
            panel58.AutoSize = true;
            panel58.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel58.Location = new Point(754, 10);
            panel58.Margin = new Padding(3, 2, 3, 2);
            panel58.Name = "panel58";
            panel58.Size = new Size(0, 0);
            panel58.TabIndex = 51;
            panel58.Paint += panel26_Paint;
            // 
            // panel59
            // 
            panel59.AutoSize = true;
            panel59.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel59.Location = new Point(808, 14);
            panel59.Margin = new Padding(3, 2, 3, 2);
            panel59.Name = "panel59";
            panel59.Size = new Size(0, 0);
            panel59.TabIndex = 50;
            // 
            // panel63
            // 
            panel63.AutoSize = true;
            panel63.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel63.Location = new Point(492, 11);
            panel63.Margin = new Padding(3, 2, 3, 2);
            panel63.Name = "panel63";
            panel63.Size = new Size(0, 0);
            panel63.TabIndex = 50;
            panel63.Paint += panel26_Paint;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.BackColor = SystemColors.Menu;
            label37.Cursor = Cursors.Hand;
            label37.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label37.Location = new Point(638, 10);
            label37.Name = "label37";
            label37.Size = new Size(108, 21);
            label37.TabIndex = 37;
            label37.Text = "Out-Of-Stock";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.BackColor = SystemColors.Menu;
            label40.Cursor = Cursors.Hand;
            label40.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label40.Location = new Point(173, 12);
            label40.Name = "label40";
            label40.Size = new Size(78, 21);
            label40.TabIndex = 33;
            label40.Text = "Re-Order";
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.BackColor = SystemColors.Menu;
            label60.Cursor = Cursors.Hand;
            label60.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label60.Location = new Point(424, 12);
            label60.Name = "label60";
            label60.Size = new Size(66, 21);
            label60.TabIndex = 35;
            label60.Text = "Danger";
            // 
            // panel55
            // 
            panel55.BackColor = SystemColors.ControlDark;
            panel55.BorderStyle = BorderStyle.Fixed3D;
            panel55.ForeColor = SystemColors.ControlText;
            panel55.Location = new Point(30, 247);
            panel55.Name = "panel55";
            panel55.Size = new Size(765, 5);
            panel55.TabIndex = 52;
            // 
            // ZoomProductbtn
            // 
            ZoomProductbtn.BackColor = SystemColors.Menu;
            ZoomProductbtn.BackColor2 = Color.White;
            ZoomProductbtn.BorderColor = Color.White;
            ZoomProductbtn.BorderSize = 2;
            ZoomProductbtn.ButtonBorderColor = Color.Gray;
            ZoomProductbtn.ButtonHighlightColor = Color.Empty;
            ZoomProductbtn.ButtonHighlightColor2 = Color.Empty;
            ZoomProductbtn.ButtonHighlightForeColor = Color.Black;
            ZoomProductbtn.ButtonPressedColor = Color.White;
            ZoomProductbtn.ButtonPressedColor2 = Color.Empty;
            ZoomProductbtn.ButtonPressedForeColor = Color.Gray;
            ZoomProductbtn.ButtonRoundRadius = 30;
            ZoomProductbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ZoomProductbtn.ForeColor = Color.Black;
            ZoomProductbtn.Location = new Point(744, 8);
            ZoomProductbtn.Name = "ZoomProductbtn";
            ZoomProductbtn.Size = new Size(128, 42);
            ZoomProductbtn.TabIndex = 34;
            ZoomProductbtn.Text = "Zoom In/Out";
            ZoomProductbtn.Click += button8_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(stockFirstPagebtn);
            panel8.Controls.Add(StockpageNumlbl);
            panel8.Controls.Add(sotckPrevPagebtn);
            panel8.Controls.Add(sotckLastPagebtn);
            panel8.Controls.Add(sotckNextPagebtn);
            panel8.Location = new Point(563, 718);
            panel8.Name = "panel8";
            panel8.Size = new Size(495, 50);
            panel8.TabIndex = 33;
            // 
            // stockFirstPagebtn
            // 
            stockFirstPagebtn.BackColor = SystemColors.Menu;
            stockFirstPagebtn.BackColor2 = Color.White;
            stockFirstPagebtn.BorderColor = Color.Tomato;
            stockFirstPagebtn.BorderSize = 2;
            stockFirstPagebtn.ButtonBorderColor = Color.Gray;
            stockFirstPagebtn.ButtonHighlightColor = Color.Empty;
            stockFirstPagebtn.ButtonHighlightColor2 = Color.Empty;
            stockFirstPagebtn.ButtonHighlightForeColor = Color.Black;
            stockFirstPagebtn.ButtonPressedColor = Color.White;
            stockFirstPagebtn.ButtonPressedColor2 = Color.Empty;
            stockFirstPagebtn.ButtonPressedForeColor = Color.Gray;
            stockFirstPagebtn.ButtonRoundRadius = 30;
            stockFirstPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockFirstPagebtn.ForeColor = Color.Black;
            stockFirstPagebtn.Location = new Point(56, 7);
            stockFirstPagebtn.Name = "stockFirstPagebtn";
            stockFirstPagebtn.Size = new Size(69, 36);
            stockFirstPagebtn.TabIndex = 31;
            stockFirstPagebtn.Text = "First";
            stockFirstPagebtn.Click += stockFirstPagebtn_Click;
            // 
            // StockpageNumlbl
            // 
            StockpageNumlbl.AutoSize = true;
            StockpageNumlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StockpageNumlbl.Location = new Point(200, 14);
            StockpageNumlbl.Name = "StockpageNumlbl";
            StockpageNumlbl.Size = new Size(79, 20);
            StockpageNumlbl.TabIndex = 3;
            StockpageNumlbl.Text = "LabelData";
            StockpageNumlbl.Click += pageNumlbl_Click;
            // 
            // sotckPrevPagebtn
            // 
            sotckPrevPagebtn.AccessibleRole = AccessibleRole.None;
            sotckPrevPagebtn.BackColor = SystemColors.Menu;
            sotckPrevPagebtn.BackColor2 = Color.White;
            sotckPrevPagebtn.BorderColor = Color.Tomato;
            sotckPrevPagebtn.BorderSize = 2;
            sotckPrevPagebtn.ButtonBorderColor = Color.Gray;
            sotckPrevPagebtn.ButtonHighlightColor = Color.Empty;
            sotckPrevPagebtn.ButtonHighlightColor2 = Color.Empty;
            sotckPrevPagebtn.ButtonHighlightForeColor = Color.Black;
            sotckPrevPagebtn.ButtonPressedColor = Color.White;
            sotckPrevPagebtn.ButtonPressedColor2 = Color.Empty;
            sotckPrevPagebtn.ButtonPressedForeColor = Color.Gray;
            sotckPrevPagebtn.ButtonRoundRadius = 30;
            sotckPrevPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sotckPrevPagebtn.ForeColor = Color.Black;
            sotckPrevPagebtn.Location = new Point(131, 6);
            sotckPrevPagebtn.Name = "sotckPrevPagebtn";
            sotckPrevPagebtn.Size = new Size(68, 37);
            sotckPrevPagebtn.TabIndex = 33;
            sotckPrevPagebtn.Text = "Prev";
            sotckPrevPagebtn.Click += sotckPrevPagebtn_Click;
            // 
            // sotckLastPagebtn
            // 
            sotckLastPagebtn.BackColor = SystemColors.Menu;
            sotckLastPagebtn.BackColor2 = Color.White;
            sotckLastPagebtn.BorderColor = Color.White;
            sotckLastPagebtn.BorderSize = 2;
            sotckLastPagebtn.ButtonBorderColor = Color.Gray;
            sotckLastPagebtn.ButtonHighlightColor = Color.Empty;
            sotckLastPagebtn.ButtonHighlightColor2 = Color.Empty;
            sotckLastPagebtn.ButtonHighlightForeColor = Color.Black;
            sotckLastPagebtn.ButtonPressedColor = Color.White;
            sotckLastPagebtn.ButtonPressedColor2 = Color.Empty;
            sotckLastPagebtn.ButtonPressedForeColor = Color.Gray;
            sotckLastPagebtn.ButtonRoundRadius = 30;
            sotckLastPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sotckLastPagebtn.ForeColor = Color.Black;
            sotckLastPagebtn.Location = new Point(398, 7);
            sotckLastPagebtn.Name = "sotckLastPagebtn";
            sotckLastPagebtn.Size = new Size(70, 39);
            sotckLastPagebtn.TabIndex = 34;
            sotckLastPagebtn.Text = "Last";
            sotckLastPagebtn.Click += sotckLastPagebtn_Click;
            // 
            // sotckNextPagebtn
            // 
            sotckNextPagebtn.BackColor = SystemColors.HighlightText;
            sotckNextPagebtn.BackColor2 = Color.White;
            sotckNextPagebtn.BorderColor = Color.Tomato;
            sotckNextPagebtn.BorderSize = 2;
            sotckNextPagebtn.ButtonBorderColor = Color.Gray;
            sotckNextPagebtn.ButtonHighlightColor = Color.Empty;
            sotckNextPagebtn.ButtonHighlightColor2 = Color.Empty;
            sotckNextPagebtn.ButtonHighlightForeColor = Color.Black;
            sotckNextPagebtn.ButtonPressedColor = Color.White;
            sotckNextPagebtn.ButtonPressedColor2 = Color.Empty;
            sotckNextPagebtn.ButtonPressedForeColor = Color.Gray;
            sotckNextPagebtn.ButtonRoundRadius = 30;
            sotckNextPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sotckNextPagebtn.ForeColor = Color.Black;
            sotckNextPagebtn.Location = new Point(324, 6);
            sotckNextPagebtn.Name = "sotckNextPagebtn";
            sotckNextPagebtn.Size = new Size(70, 40);
            sotckNextPagebtn.TabIndex = 32;
            sotckNextPagebtn.Text = "Next";
            sotckNextPagebtn.Click += sotckNextPagebtn_Click;
            // 
            // delProductbtn
            // 
            delProductbtn.BackColor = Color.Red;
            delProductbtn.BackColor2 = Color.IndianRed;
            delProductbtn.BorderColor = Color.White;
            delProductbtn.BorderSize = 2;
            delProductbtn.ButtonBorderColor = Color.Gray;
            delProductbtn.ButtonHighlightColor = Color.Empty;
            delProductbtn.ButtonHighlightColor2 = Color.Empty;
            delProductbtn.ButtonHighlightForeColor = Color.Black;
            delProductbtn.ButtonPressedColor = Color.White;
            delProductbtn.ButtonPressedColor2 = Color.Empty;
            delProductbtn.ButtonPressedForeColor = Color.Gray;
            delProductbtn.ButtonRoundRadius = 30;
            delProductbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            delProductbtn.ForeColor = Color.White;
            delProductbtn.Location = new Point(417, 255);
            delProductbtn.Name = "delProductbtn";
            delProductbtn.Size = new Size(162, 42);
            delProductbtn.TabIndex = 31;
            delProductbtn.Text = "Delete Product";
            delProductbtn.Click += delProductbtn_Click;
            // 
            // stockSearchBox
            // 
            stockSearchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockSearchBox.Location = new Point(619, 266);
            stockSearchBox.Margin = new Padding(3, 4, 3, 4);
            stockSearchBox.Multiline = true;
            stockSearchBox.Name = "stockSearchBox";
            stockSearchBox.PlaceholderText = "   Search Product Name or ID";
            stockSearchBox.Size = new Size(456, 32);
            stockSearchBox.TabIndex = 30;
            stockSearchBox.TextChanged += stockSearchBox_TextChanged;
            // 
            // dashboardpnl
            // 
            dashboardpnl.BackColor = Color.Gainsboro;
            dashboardpnl.BackgroundImageLayout = ImageLayout.Stretch;
            dashboardpnl.BorderStyle = BorderStyle.Fixed3D;
            dashboardpnl.Controls.Add(dashordervalueChart);
            dashboardpnl.Controls.Add(panel53);
            dashboardpnl.Controls.Add(panel52);
            dashboardpnl.Controls.Add(panel41);
            dashboardpnl.Controls.Add(label59);
            dashboardpnl.Controls.Add(label1);
            dashboardpnl.Location = new Point(176, 2);
            dashboardpnl.Name = "dashboardpnl";
            dashboardpnl.Size = new Size(1139, 789);
            dashboardpnl.TabIndex = 1;
            dashboardpnl.MouseDown += Dashboard_MouseDown;
            dashboardpnl.MouseMove += Dashboard_MouseMove;
            dashboardpnl.MouseUp += Dashboard_MouseUp;
            // 
            // dashordervalueChart
            // 
            dashordervalueChart.BackColor = Color.Transparent;
            chartArea18.Name = "ChartArea1";
            dashordervalueChart.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            dashordervalueChart.Legends.Add(legend18);
            dashordervalueChart.Location = new Point(3, 188);
            dashordervalueChart.Name = "dashordervalueChart";
            dashordervalueChart.Size = new Size(1118, 468);
            dashordervalueChart.TabIndex = 53;
            dashordervalueChart.Text = "chart1";
            // 
            // panel53
            // 
            panel53.BorderStyle = BorderStyle.Fixed3D;
            panel53.Controls.Add(panel39);
            panel53.Controls.Add(panel40);
            panel53.Controls.Add(panel38);
            panel53.Controls.Add(panel37);
            panel53.Location = new Point(2, 58);
            panel53.Margin = new Padding(3, 2, 3, 2);
            panel53.Name = "panel53";
            panel53.Size = new Size(1132, 122);
            panel53.TabIndex = 57;
            // 
            // panel39
            // 
            panel39.BorderStyle = BorderStyle.FixedSingle;
            panel39.Controls.Add(dashOrderlbl);
            panel39.Controls.Add(label41);
            panel39.Location = new Point(275, 16);
            panel39.Name = "panel39";
            panel39.Size = new Size(207, 89);
            panel39.TabIndex = 51;
            // 
            // dashOrderlbl
            // 
            dashOrderlbl.AutoSize = true;
            dashOrderlbl.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dashOrderlbl.Location = new Point(62, 58);
            dashOrderlbl.Name = "dashOrderlbl";
            dashOrderlbl.Size = new Size(52, 17);
            dashOrderlbl.TabIndex = 16;
            dashOrderlbl.Text = "label40";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label41.Location = new Point(24, 9);
            label41.Name = "label41";
            label41.Size = new Size(143, 24);
            label41.TabIndex = 12;
            label41.Text = "Today's Order";
            // 
            // panel40
            // 
            panel40.BorderStyle = BorderStyle.FixedSingle;
            panel40.Controls.Add(dashRevenuelbl);
            panel40.Controls.Add(label43);
            panel40.Location = new Point(39, 16);
            panel40.Name = "panel40";
            panel40.Size = new Size(207, 89);
            panel40.TabIndex = 49;
            // 
            // dashRevenuelbl
            // 
            dashRevenuelbl.AutoSize = true;
            dashRevenuelbl.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dashRevenuelbl.Location = new Point(61, 58);
            dashRevenuelbl.Name = "dashRevenuelbl";
            dashRevenuelbl.Size = new Size(52, 17);
            dashRevenuelbl.TabIndex = 15;
            dashRevenuelbl.Text = "label42";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label43.ImageAlign = ContentAlignment.MiddleRight;
            label43.Location = new Point(22, 9);
            label43.Name = "label43";
            label43.Size = new Size(158, 24);
            label43.TabIndex = 12;
            label43.Text = "Today Revenue";
            // 
            // panel38
            // 
            panel38.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel38.BackColor = Color.Transparent;
            panel38.BorderStyle = BorderStyle.FixedSingle;
            panel38.Controls.Add(dashOutlbl);
            panel38.Controls.Add(label39);
            panel38.Location = new Point(508, 16);
            panel38.Name = "panel38";
            panel38.Size = new Size(244, 89);
            panel38.TabIndex = 50;
            // 
            // dashOutlbl
            // 
            dashOutlbl.AutoSize = true;
            dashOutlbl.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dashOutlbl.Location = new Point(98, 61);
            dashOutlbl.Name = "dashOutlbl";
            dashOutlbl.Size = new Size(52, 17);
            dashOutlbl.TabIndex = 17;
            dashOutlbl.Text = "label37";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label39.Location = new Point(-1, 7);
            label39.Name = "label39";
            label39.Size = new Size(231, 20);
            label39.TabIndex = 12;
            label39.Text = "Today Quantity Despatched";
            // 
            // panel37
            // 
            panel37.BorderStyle = BorderStyle.FixedSingle;
            panel37.Controls.Add(dashInlbl);
            panel37.Controls.Add(label34);
            panel37.Location = new Point(773, 16);
            panel37.Name = "panel37";
            panel37.Size = new Size(227, 89);
            panel37.TabIndex = 52;
            // 
            // dashInlbl
            // 
            dashInlbl.AutoSize = true;
            dashInlbl.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dashInlbl.Location = new Point(79, 58);
            dashInlbl.Name = "dashInlbl";
            dashInlbl.Size = new Size(52, 17);
            dashInlbl.TabIndex = 18;
            dashInlbl.Text = "label33";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.Location = new Point(7, 4);
            label34.Name = "label34";
            label34.Size = new Size(173, 24);
            label34.TabIndex = 12;
            label34.Text = "Today Quantity In";
            // 
            // panel52
            // 
            panel52.BorderStyle = BorderStyle.Fixed3D;
            panel52.Location = new Point(35, 858);
            panel52.Name = "panel52";
            panel52.Size = new Size(1246, 115);
            panel52.TabIndex = 55;
            // 
            // panel41
            // 
            panel41.BackColor = SystemColors.WindowFrame;
            panel41.Controls.Add(label57);
            panel41.Location = new Point(0, 742);
            panel41.Margin = new Padding(3, 2, 3, 2);
            panel41.Name = "panel41";
            panel41.Size = new Size(1133, 40);
            panel41.TabIndex = 53;
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label57.ForeColor = SystemColors.ButtonHighlight;
            label57.Location = new Point(10, 14);
            label57.Name = "label57";
            label57.Size = new Size(344, 21);
            label57.TabIndex = 54;
            label57.Text = "Copyright © 2024 Legend Motor (LC) Limited ®";
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label59.Location = new Point(19, 13);
            label59.Name = "label59";
            label59.Size = new Size(111, 24);
            label59.TabIndex = 16;
            label59.Text = "Dashboard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Calibri", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 20);
            label1.Name = "label1";
            label1.Size = new Size(512, 39);
            label1.TabIndex = 2;
            label1.Text = "Welcome to the LM Company System";
            // 
            // logpnl
            // 
            logpnl.Controls.Add(panel19);
            logpnl.Controls.Add(auditLogdata);
            logpnl.Controls.Add(loglbl);
            logpnl.Location = new Point(176, 2);
            logpnl.Name = "logpnl";
            logpnl.Size = new Size(1094, 783);
            logpnl.TabIndex = 26;
            logpnl.Visible = false;
            logpnl.MouseDown += Dashboard_MouseDown;
            logpnl.MouseMove += Dashboard_MouseMove;
            logpnl.MouseUp += Dashboard_MouseUp;
            // 
            // panel19
            // 
            panel19.Controls.Add(auditTypeStatusbox);
            panel19.Controls.Add(auditlogStatusbox);
            panel19.Controls.Add(label62);
            panel19.Controls.Add(label16);
            panel19.Controls.Add(roundedTextBox3);
            panel19.Controls.Add(logdateTimePicker1);
            panel19.Controls.Add(label28);
            panel19.Controls.Add(SeachLogButton);
            panel19.Controls.Add(label29);
            panel19.Controls.Add(ClearLogButton);
            panel19.Controls.Add(logdateTimePicker2);
            panel19.Location = new Point(38, 57);
            panel19.Margin = new Padding(3, 2, 3, 2);
            panel19.Name = "panel19";
            panel19.Size = new Size(1046, 169);
            panel19.TabIndex = 37;
            panel19.Paint += panel19_Paint;
            // 
            // auditTypeStatusbox
            // 
            auditTypeStatusbox.FormattingEnabled = true;
            auditTypeStatusbox.Items.AddRange(new object[] { "Order", "OutstandingOrder", "Stock", "OrderAccembly", "Contact", "GRN", "Delivery", "PurchaseOrder", "Invoice", "Account", "Report" });
            auditTypeStatusbox.Location = new Point(708, 48);
            auditTypeStatusbox.Margin = new Padding(3, 2, 3, 2);
            auditTypeStatusbox.Name = "auditTypeStatusbox";
            auditTypeStatusbox.Size = new Size(133, 23);
            auditTypeStatusbox.TabIndex = 52;
            // 
            // auditlogStatusbox
            // 
            auditlogStatusbox.FormattingEnabled = true;
            auditlogStatusbox.Location = new Point(549, 47);
            auditlogStatusbox.Margin = new Padding(3, 2, 3, 2);
            auditlogStatusbox.Name = "auditlogStatusbox";
            auditlogStatusbox.Size = new Size(133, 23);
            auditlogStatusbox.TabIndex = 50;
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label62.Location = new Point(711, 17);
            label62.Name = "label62";
            label62.Size = new Size(55, 21);
            label62.TabIndex = 51;
            label62.Text = "Status";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(550, 20);
            label16.Name = "label16";
            label16.Size = new Size(55, 21);
            label16.TabIndex = 49;
            label16.Text = "Status";
            // 
            // roundedTextBox3
            // 
            roundedTextBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox3.Location = new Point(575, 119);
            roundedTextBox3.Margin = new Padding(3, 4, 3, 4);
            roundedTextBox3.Multiline = true;
            roundedTextBox3.Name = "roundedTextBox3";
            roundedTextBox3.PlaceholderText = "Search";
            roundedTextBox3.Size = new Size(446, 32);
            roundedTextBox3.TabIndex = 31;
            // 
            // logdateTimePicker1
            // 
            logdateTimePicker1.Location = new Point(21, 48);
            logdateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            logdateTimePicker1.Name = "logdateTimePicker1";
            logdateTimePicker1.Size = new Size(212, 23);
            logdateTimePicker1.TabIndex = 8;
            logdateTimePicker1.ValueChanged += logdateTimePicker1_ValueChanged;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.Location = new Point(21, 12);
            label28.Name = "label28";
            label28.Size = new Size(55, 25);
            label28.TabIndex = 10;
            label28.Text = "From";
            // 
            // SeachLogButton
            // 
            SeachLogButton.BackColor = SystemColors.Menu;
            SeachLogButton.BackColor2 = Color.White;
            SeachLogButton.BorderColor = Color.White;
            SeachLogButton.BorderSize = 2;
            SeachLogButton.ButtonBorderColor = Color.Gray;
            SeachLogButton.ButtonHighlightColor = Color.Empty;
            SeachLogButton.ButtonHighlightColor2 = Color.Empty;
            SeachLogButton.ButtonHighlightForeColor = Color.Black;
            SeachLogButton.ButtonPressedColor = Color.White;
            SeachLogButton.ButtonPressedColor2 = Color.Empty;
            SeachLogButton.ButtonPressedForeColor = Color.Gray;
            SeachLogButton.ButtonRoundRadius = 30;
            SeachLogButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SeachLogButton.ForeColor = Color.Black;
            SeachLogButton.Location = new Point(875, 39);
            SeachLogButton.Margin = new Padding(3, 2, 3, 2);
            SeachLogButton.Name = "SeachLogButton";
            SeachLogButton.Size = new Size(90, 38);
            SeachLogButton.TabIndex = 25;
            SeachLogButton.Text = "Filter";
            SeachLogButton.Click += SeachLogButton_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.Location = new Point(275, 12);
            label29.Name = "label29";
            label29.Size = new Size(31, 25);
            label29.TabIndex = 11;
            label29.Text = "To";
            // 
            // ClearLogButton
            // 
            ClearLogButton.BackColor = SystemColors.Menu;
            ClearLogButton.BackColor2 = Color.White;
            ClearLogButton.BorderColor = Color.White;
            ClearLogButton.BorderSize = 2;
            ClearLogButton.ButtonBorderColor = Color.Gray;
            ClearLogButton.ButtonHighlightColor = Color.Empty;
            ClearLogButton.ButtonHighlightColor2 = Color.Empty;
            ClearLogButton.ButtonHighlightForeColor = Color.Black;
            ClearLogButton.ButtonPressedColor = Color.White;
            ClearLogButton.ButtonPressedColor2 = Color.Empty;
            ClearLogButton.ButtonPressedForeColor = Color.Gray;
            ClearLogButton.ButtonRoundRadius = 30;
            ClearLogButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearLogButton.ForeColor = Color.Black;
            ClearLogButton.Location = new Point(22, 115);
            ClearLogButton.Margin = new Padding(3, 2, 3, 2);
            ClearLogButton.Name = "ClearLogButton";
            ClearLogButton.Size = new Size(93, 41);
            ClearLogButton.TabIndex = 30;
            ClearLogButton.Text = "Clear";
            // 
            // logdateTimePicker2
            // 
            logdateTimePicker2.Location = new Point(278, 48);
            logdateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            logdateTimePicker2.Name = "logdateTimePicker2";
            logdateTimePicker2.Size = new Size(220, 23);
            logdateTimePicker2.TabIndex = 9;
            // 
            // auditLogdata
            // 
            auditLogdata.AllowUserToAddRows = false;
            auditLogdata.AllowUserToDeleteRows = false;
            dataGridViewCellStyle191.BackColor = Color.Gainsboro;
            auditLogdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle191;
            auditLogdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            auditLogdata.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            auditLogdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle192.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle192.BackColor = SystemColors.Window;
            dataGridViewCellStyle192.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle192.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle192.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle192.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle192.WrapMode = DataGridViewTriState.True;
            auditLogdata.DefaultCellStyle = dataGridViewCellStyle192;
            auditLogdata.Location = new Point(37, 233);
            auditLogdata.Margin = new Padding(3, 2, 3, 2);
            auditLogdata.Name = "auditLogdata";
            dataGridViewCellStyle193.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle193.BackColor = SystemColors.Control;
            dataGridViewCellStyle193.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle193.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle193.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle193.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle193.WrapMode = DataGridViewTriState.True;
            auditLogdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle193;
            auditLogdata.RowHeadersVisible = false;
            auditLogdata.RowHeadersWidth = 51;
            auditLogdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            auditLogdata.Size = new Size(1046, 518);
            auditLogdata.TabIndex = 39;
            // 
            // loglbl
            // 
            loglbl.AutoSize = true;
            loglbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loglbl.Location = new Point(35, 2);
            loglbl.Name = "loglbl";
            loglbl.Size = new Size(100, 25);
            loglbl.TabIndex = 23;
            loglbl.Text = "Audit Log";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            dataGridViewCheckBoxColumn3.MinimumWidth = 6;
            dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            dataGridViewCheckBoxColumn3.Width = 125;
            // 
            // OrderAccemblypnl
            // 
            OrderAccemblypnl.Controls.Add(panel18);
            OrderAccemblypnl.Controls.Add(orderaccemblySearchpnl);
            OrderAccemblypnl.Controls.Add(orderAccemblyData);
            OrderAccemblypnl.Controls.Add(orderAccemblylbl);
            OrderAccemblypnl.Controls.Add(accemblyCreatebtn);
            OrderAccemblypnl.Location = new Point(176, 2);
            OrderAccemblypnl.Name = "OrderAccemblypnl";
            OrderAccemblypnl.Size = new Size(1094, 788);
            OrderAccemblypnl.TabIndex = 7;
            OrderAccemblypnl.Visible = false;
            OrderAccemblypnl.MouseDown += Dashboard_MouseDown;
            OrderAccemblypnl.MouseMove += Dashboard_MouseMove;
            OrderAccemblypnl.MouseUp += Dashboard_MouseUp;
            // 
            // panel18
            // 
            panel18.Controls.Add(panel60);
            panel18.Controls.Add(panel66);
            panel18.Controls.Add(panel67);
            panel18.Controls.Add(label19);
            panel18.Controls.Add(label27);
            panel18.Location = new Point(24, 233);
            panel18.Margin = new Padding(3, 2, 3, 2);
            panel18.Name = "panel18";
            panel18.Size = new Size(1038, 52);
            panel18.TabIndex = 41;
            // 
            // panel60
            // 
            panel60.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel60.Controls.Add(textBox1);
            panel60.Location = new Point(334, 16);
            panel60.Margin = new Padding(3, 2, 3, 2);
            panel60.Name = "panel60";
            panel60.Size = new Size(40, 28);
            panel60.TabIndex = 52;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(9, 4);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(26, 19);
            textBox1.TabIndex = 48;
            textBox1.Text = "880";
            // 
            // panel66
            // 
            panel66.AutoSize = true;
            panel66.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel66.Controls.Add(textBox2);
            panel66.Location = new Point(761, 16);
            panel66.Margin = new Padding(3, 2, 3, 2);
            panel66.Name = "panel66";
            panel66.Size = new Size(38, 24);
            panel66.TabIndex = 51;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(9, 3);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(26, 19);
            textBox2.TabIndex = 48;
            textBox2.Text = "880";
            // 
            // panel67
            // 
            panel67.AutoSize = true;
            panel67.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel67.Location = new Point(777, 14);
            panel67.Margin = new Padding(3, 2, 3, 2);
            panel67.Name = "panel67";
            panel67.Size = new Size(0, 0);
            panel67.TabIndex = 50;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = SystemColors.Menu;
            label19.Cursor = Cursors.Hand;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(672, 18);
            label19.Name = "label19";
            label19.Size = new Size(94, 21);
            label19.TabIndex = 37;
            label19.Text = "Completed";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = SystemColors.Menu;
            label27.Cursor = Cursors.Hand;
            label27.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(265, 17);
            label27.Name = "label27";
            label27.Size = new Size(74, 21);
            label27.TabIndex = 33;
            label27.Text = "Partially";
            // 
            // orderaccemblySearchpnl
            // 
            orderaccemblySearchpnl.Controls.Add(orderAccemblySearchbox);
            orderaccemblySearchpnl.Controls.Add(orderAccemblyViewbtn);
            orderaccemblySearchpnl.Controls.Add(orderAccemblySearchbtn);
            orderaccemblySearchpnl.Controls.Add(orderAccemblyClearbtn);
            orderaccemblySearchpnl.Controls.Add(orderAccemblydateTimePicker);
            orderaccemblySearchpnl.Controls.Add(label5);
            orderaccemblySearchpnl.Controls.Add(orderAccemblydateTimePicker2);
            orderaccemblySearchpnl.Controls.Add(label6);
            orderaccemblySearchpnl.Location = new Point(26, 80);
            orderaccemblySearchpnl.Name = "orderaccemblySearchpnl";
            orderaccemblySearchpnl.Size = new Size(1050, 145);
            orderaccemblySearchpnl.TabIndex = 16;
            // 
            // orderAccemblySearchbox
            // 
            orderAccemblySearchbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderAccemblySearchbox.Location = new Point(587, 104);
            orderAccemblySearchbox.Margin = new Padding(3, 4, 3, 4);
            orderAccemblySearchbox.Multiline = true;
            orderAccemblySearchbox.Name = "orderAccemblySearchbox";
            orderAccemblySearchbox.PlaceholderText = "    Search";
            orderAccemblySearchbox.Size = new Size(446, 32);
            orderAccemblySearchbox.TabIndex = 32;
            orderAccemblySearchbox.KeyDown += orderAccemblySearchbox_KeyDown;
            // 
            // orderAccemblyViewbtn
            // 
            orderAccemblyViewbtn.BackColor = SystemColors.Menu;
            orderAccemblyViewbtn.BackColor2 = Color.White;
            orderAccemblyViewbtn.BorderColor = Color.White;
            orderAccemblyViewbtn.BorderSize = 2;
            orderAccemblyViewbtn.ButtonBorderColor = Color.Gray;
            orderAccemblyViewbtn.ButtonHighlightColor = Color.Empty;
            orderAccemblyViewbtn.ButtonHighlightColor2 = Color.Empty;
            orderAccemblyViewbtn.ButtonHighlightForeColor = Color.Black;
            orderAccemblyViewbtn.ButtonPressedColor = Color.White;
            orderAccemblyViewbtn.ButtonPressedColor2 = Color.Empty;
            orderAccemblyViewbtn.ButtonPressedForeColor = Color.Gray;
            orderAccemblyViewbtn.ButtonRoundRadius = 30;
            orderAccemblyViewbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderAccemblyViewbtn.ForeColor = Color.Black;
            orderAccemblyViewbtn.Location = new Point(359, 98);
            orderAccemblyViewbtn.Margin = new Padding(3, 2, 3, 2);
            orderAccemblyViewbtn.Name = "orderAccemblyViewbtn";
            orderAccemblyViewbtn.Size = new Size(126, 41);
            orderAccemblyViewbtn.TabIndex = 20;
            orderAccemblyViewbtn.Text = "View";
            orderAccemblyViewbtn.Click += orderAccemblyViewbtn_Click;
            // 
            // orderAccemblySearchbtn
            // 
            orderAccemblySearchbtn.BackColor = SystemColors.Menu;
            orderAccemblySearchbtn.BackColor2 = Color.White;
            orderAccemblySearchbtn.BorderColor = Color.White;
            orderAccemblySearchbtn.BorderSize = 2;
            orderAccemblySearchbtn.ButtonBorderColor = Color.Gray;
            orderAccemblySearchbtn.ButtonHighlightColor = Color.Empty;
            orderAccemblySearchbtn.ButtonHighlightColor2 = Color.Empty;
            orderAccemblySearchbtn.ButtonHighlightForeColor = Color.Black;
            orderAccemblySearchbtn.ButtonPressedColor = Color.White;
            orderAccemblySearchbtn.ButtonPressedColor2 = Color.Empty;
            orderAccemblySearchbtn.ButtonPressedForeColor = Color.Gray;
            orderAccemblySearchbtn.ButtonRoundRadius = 30;
            orderAccemblySearchbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderAccemblySearchbtn.ForeColor = Color.Black;
            orderAccemblySearchbtn.Location = new Point(34, 98);
            orderAccemblySearchbtn.Margin = new Padding(3, 2, 3, 2);
            orderAccemblySearchbtn.Name = "orderAccemblySearchbtn";
            orderAccemblySearchbtn.Size = new Size(121, 38);
            orderAccemblySearchbtn.TabIndex = 19;
            orderAccemblySearchbtn.Text = "Filter";
            orderAccemblySearchbtn.Click += orderAccemblySearchbtn_Click;
            // 
            // orderAccemblyClearbtn
            // 
            orderAccemblyClearbtn.BackColor = SystemColors.Menu;
            orderAccemblyClearbtn.BackColor2 = Color.White;
            orderAccemblyClearbtn.BorderColor = Color.White;
            orderAccemblyClearbtn.BorderSize = 2;
            orderAccemblyClearbtn.ButtonBorderColor = Color.Gray;
            orderAccemblyClearbtn.ButtonHighlightColor = Color.Empty;
            orderAccemblyClearbtn.ButtonHighlightColor2 = Color.Empty;
            orderAccemblyClearbtn.ButtonHighlightForeColor = Color.Black;
            orderAccemblyClearbtn.ButtonPressedColor = Color.White;
            orderAccemblyClearbtn.ButtonPressedColor2 = Color.Empty;
            orderAccemblyClearbtn.ButtonPressedForeColor = Color.Gray;
            orderAccemblyClearbtn.ButtonRoundRadius = 30;
            orderAccemblyClearbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderAccemblyClearbtn.ForeColor = Color.Black;
            orderAccemblyClearbtn.Location = new Point(195, 98);
            orderAccemblyClearbtn.Margin = new Padding(3, 2, 3, 2);
            orderAccemblyClearbtn.Name = "orderAccemblyClearbtn";
            orderAccemblyClearbtn.Size = new Size(125, 38);
            orderAccemblyClearbtn.TabIndex = 18;
            orderAccemblyClearbtn.Text = "Clear";
            // 
            // orderAccemblydateTimePicker
            // 
            orderAccemblydateTimePicker.Location = new Point(34, 48);
            orderAccemblydateTimePicker.Name = "orderAccemblydateTimePicker";
            orderAccemblydateTimePicker.Size = new Size(233, 23);
            orderAccemblydateTimePicker.TabIndex = 8;
            orderAccemblydateTimePicker.ValueChanged += orderAccemblydateTimePicker_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 8);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 10;
            label5.Text = "From";
            // 
            // orderAccemblydateTimePicker2
            // 
            orderAccemblydateTimePicker2.Location = new Point(315, 48);
            orderAccemblydateTimePicker2.Name = "orderAccemblydateTimePicker2";
            orderAccemblydateTimePicker2.Size = new Size(238, 23);
            orderAccemblydateTimePicker2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(316, 10);
            label6.Name = "label6";
            label6.Size = new Size(31, 25);
            label6.TabIndex = 11;
            label6.Text = "To";
            // 
            // orderAccemblyData
            // 
            orderAccemblyData.AllowUserToAddRows = false;
            orderAccemblyData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle194.BackColor = Color.Gainsboro;
            orderAccemblyData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle194;
            orderAccemblyData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle195.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle195.BackColor = SystemColors.Control;
            dataGridViewCellStyle195.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle195.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle195.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle195.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle195.WrapMode = DataGridViewTriState.True;
            orderAccemblyData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle195;
            orderAccemblyData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderAccemblyData.Columns.AddRange(new DataGridViewColumn[] { orderAccemblyColumn });
            dataGridViewCellStyle196.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle196.BackColor = SystemColors.Window;
            dataGridViewCellStyle196.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle196.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle196.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle196.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle196.WrapMode = DataGridViewTriState.False;
            orderAccemblyData.DefaultCellStyle = dataGridViewCellStyle196;
            orderAccemblyData.Location = new Point(21, 296);
            orderAccemblyData.Margin = new Padding(3, 2, 3, 2);
            orderAccemblyData.Name = "orderAccemblyData";
            dataGridViewCellStyle197.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle197.BackColor = SystemColors.Control;
            dataGridViewCellStyle197.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle197.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle197.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle197.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle197.WrapMode = DataGridViewTriState.True;
            orderAccemblyData.RowHeadersDefaultCellStyle = dataGridViewCellStyle197;
            orderAccemblyData.RowHeadersVisible = false;
            orderAccemblyData.RowHeadersWidth = 51;
            orderAccemblyData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderAccemblyData.Size = new Size(1050, 449);
            orderAccemblyData.TabIndex = 7;
            orderAccemblyData.CellClick += orderAccemblyData_CellClick;
            // 
            // orderAccemblylbl
            // 
            orderAccemblylbl.AutoSize = true;
            orderAccemblylbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderAccemblylbl.Location = new Point(24, 8);
            orderAccemblylbl.Name = "orderAccemblylbl";
            orderAccemblylbl.Size = new Size(154, 25);
            orderAccemblylbl.TabIndex = 6;
            orderAccemblylbl.Text = "Order Accembly";
            // 
            // accemblyCreatebtn
            // 
            accemblyCreatebtn.BackColor = Color.LimeGreen;
            accemblyCreatebtn.BackColor2 = Color.Lime;
            accemblyCreatebtn.BorderColor = Color.White;
            accemblyCreatebtn.BorderSize = 2;
            accemblyCreatebtn.ButtonBorderColor = Color.Gray;
            accemblyCreatebtn.ButtonHighlightColor = Color.Empty;
            accemblyCreatebtn.ButtonHighlightColor2 = Color.Empty;
            accemblyCreatebtn.ButtonHighlightForeColor = Color.Black;
            accemblyCreatebtn.ButtonPressedColor = Color.White;
            accemblyCreatebtn.ButtonPressedColor2 = Color.Empty;
            accemblyCreatebtn.ButtonPressedForeColor = Color.Gray;
            accemblyCreatebtn.ButtonRoundRadius = 30;
            accemblyCreatebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accemblyCreatebtn.ForeColor = Color.White;
            accemblyCreatebtn.Location = new Point(884, 28);
            accemblyCreatebtn.Margin = new Padding(3, 2, 3, 2);
            accemblyCreatebtn.Name = "accemblyCreatebtn";
            accemblyCreatebtn.Size = new Size(155, 38);
            accemblyCreatebtn.TabIndex = 8;
            accemblyCreatebtn.Text = "Create";
            accemblyCreatebtn.Click += accemblyCreatebtn_Click;
            // 
            // GRNpnl
            // 
            GRNpnl.Controls.Add(panel12);
            GRNpnl.Controls.Add(panel1);
            GRNpnl.Controls.Add(grnAddNoteBtn);
            GRNpnl.Controls.Add(grndata);
            GRNpnl.Controls.Add(GRNlbl);
            GRNpnl.Location = new Point(176, 2);
            GRNpnl.Name = "GRNpnl";
            GRNpnl.Size = new Size(1094, 788);
            GRNpnl.TabIndex = 8;
            GRNpnl.Visible = false;
            GRNpnl.MouseDown += Dashboard_MouseDown;
            GRNpnl.MouseMove += Dashboard_MouseMove;
            GRNpnl.MouseUp += Dashboard_MouseUp;
            // 
            // panel12
            // 
            panel12.Controls.Add(grnFirstPage);
            panel12.Controls.Add(grnPage);
            panel12.Controls.Add(grnPrevPage);
            panel12.Controls.Add(grnLastPage);
            panel12.Controls.Add(grnNextPage);
            panel12.Location = new Point(574, 711);
            panel12.Name = "panel12";
            panel12.Size = new Size(495, 50);
            panel12.TabIndex = 34;
            // 
            // grnFirstPage
            // 
            grnFirstPage.BackColor = SystemColors.Menu;
            grnFirstPage.BackColor2 = Color.White;
            grnFirstPage.BorderColor = Color.Tomato;
            grnFirstPage.BorderSize = 2;
            grnFirstPage.ButtonBorderColor = Color.Gray;
            grnFirstPage.ButtonHighlightColor = Color.Empty;
            grnFirstPage.ButtonHighlightColor2 = Color.Empty;
            grnFirstPage.ButtonHighlightForeColor = Color.Black;
            grnFirstPage.ButtonPressedColor = Color.White;
            grnFirstPage.ButtonPressedColor2 = Color.Empty;
            grnFirstPage.ButtonPressedForeColor = Color.Gray;
            grnFirstPage.ButtonRoundRadius = 30;
            grnFirstPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grnFirstPage.ForeColor = Color.Black;
            grnFirstPage.Location = new Point(45, 6);
            grnFirstPage.Name = "grnFirstPage";
            grnFirstPage.Size = new Size(71, 37);
            grnFirstPage.TabIndex = 31;
            grnFirstPage.Text = "First";
            grnFirstPage.Click += grnFirstPage_Click;
            // 
            // grnPage
            // 
            grnPage.AutoSize = true;
            grnPage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grnPage.Location = new Point(205, 16);
            grnPage.Name = "grnPage";
            grnPage.Size = new Size(79, 20);
            grnPage.TabIndex = 3;
            grnPage.Text = "LabelData";
            // 
            // grnPrevPage
            // 
            grnPrevPage.AccessibleRole = AccessibleRole.None;
            grnPrevPage.BackColor = SystemColors.Menu;
            grnPrevPage.BackColor2 = Color.White;
            grnPrevPage.BorderColor = Color.Tomato;
            grnPrevPage.BorderSize = 2;
            grnPrevPage.ButtonBorderColor = Color.Gray;
            grnPrevPage.ButtonHighlightColor = Color.Empty;
            grnPrevPage.ButtonHighlightColor2 = Color.Empty;
            grnPrevPage.ButtonHighlightForeColor = Color.Black;
            grnPrevPage.ButtonPressedColor = Color.White;
            grnPrevPage.ButtonPressedColor2 = Color.Empty;
            grnPrevPage.ButtonPressedForeColor = Color.Gray;
            grnPrevPage.ButtonRoundRadius = 30;
            grnPrevPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grnPrevPage.ForeColor = Color.Black;
            grnPrevPage.Location = new Point(122, 6);
            grnPrevPage.Name = "grnPrevPage";
            grnPrevPage.Size = new Size(73, 38);
            grnPrevPage.TabIndex = 33;
            grnPrevPage.Text = "Prev";
            grnPrevPage.Click += grnPrevPage_Click;
            // 
            // grnLastPage
            // 
            grnLastPage.BackColor = SystemColors.Menu;
            grnLastPage.BackColor2 = Color.White;
            grnLastPage.BorderColor = Color.White;
            grnLastPage.BorderSize = 2;
            grnLastPage.ButtonBorderColor = Color.Gray;
            grnLastPage.ButtonHighlightColor = Color.Empty;
            grnLastPage.ButtonHighlightColor2 = Color.Empty;
            grnLastPage.ButtonHighlightForeColor = Color.Black;
            grnLastPage.ButtonPressedColor = Color.White;
            grnLastPage.ButtonPressedColor2 = Color.Empty;
            grnLastPage.ButtonPressedForeColor = Color.Gray;
            grnLastPage.ButtonRoundRadius = 30;
            grnLastPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grnLastPage.ForeColor = Color.Black;
            grnLastPage.Location = new Point(397, 7);
            grnLastPage.Name = "grnLastPage";
            grnLastPage.Size = new Size(71, 39);
            grnLastPage.TabIndex = 34;
            grnLastPage.Text = "Last";
            grnLastPage.Click += grnLastPage_Click;
            // 
            // grnNextPage
            // 
            grnNextPage.BackColor = SystemColors.HighlightText;
            grnNextPage.BackColor2 = Color.White;
            grnNextPage.BorderColor = Color.Tomato;
            grnNextPage.BorderSize = 2;
            grnNextPage.ButtonBorderColor = Color.Gray;
            grnNextPage.ButtonHighlightColor = Color.Empty;
            grnNextPage.ButtonHighlightColor2 = Color.Empty;
            grnNextPage.ButtonHighlightForeColor = Color.Black;
            grnNextPage.ButtonPressedColor = Color.White;
            grnNextPage.ButtonPressedColor2 = Color.Empty;
            grnNextPage.ButtonPressedForeColor = Color.Gray;
            grnNextPage.ButtonRoundRadius = 30;
            grnNextPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grnNextPage.ForeColor = Color.Black;
            grnNextPage.Location = new Point(310, 7);
            grnNextPage.Name = "grnNextPage";
            grnNextPage.Size = new Size(71, 40);
            grnNextPage.TabIndex = 32;
            grnNextPage.Text = "Next";
            grnNextPage.Click += grnNextPage_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(grnsearchbox);
            panel1.Controls.Add(grnDatePicker1);
            panel1.Controls.Add(grnlbl1);
            panel1.Controls.Add(grncl);
            panel1.Controls.Add(grnDatePicker2);
            panel1.Controls.Add(grnSearchBtn);
            panel1.Controls.Add(grnlbl2);
            panel1.Location = new Point(31, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(1031, 145);
            panel1.TabIndex = 15;
            // 
            // grnsearchbox
            // 
            grnsearchbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grnsearchbox.Location = new Point(575, 109);
            grnsearchbox.Margin = new Padding(3, 4, 3, 4);
            grnsearchbox.Multiline = true;
            grnsearchbox.Name = "grnsearchbox";
            grnsearchbox.PlaceholderText = "    Search";
            grnsearchbox.Size = new Size(446, 32);
            grnsearchbox.TabIndex = 33;
            // 
            // grnDatePicker1
            // 
            grnDatePicker1.Location = new Point(34, 48);
            grnDatePicker1.Name = "grnDatePicker1";
            grnDatePicker1.Size = new Size(233, 23);
            grnDatePicker1.TabIndex = 8;
            grnDatePicker1.ValueChanged += grnDatePicker1_ValueChanged;
            // 
            // grnlbl1
            // 
            grnlbl1.AutoSize = true;
            grnlbl1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grnlbl1.Location = new Point(28, 8);
            grnlbl1.Name = "grnlbl1";
            grnlbl1.Size = new Size(55, 25);
            grnlbl1.TabIndex = 10;
            grnlbl1.Text = "From";
            // 
            // grncl
            // 
            grncl.BackColor = SystemColors.Menu;
            grncl.BackColor2 = Color.White;
            grncl.BorderColor = Color.White;
            grncl.BorderSize = 2;
            grncl.ButtonBorderColor = Color.Gray;
            grncl.ButtonHighlightColor = Color.Empty;
            grncl.ButtonHighlightColor2 = Color.Empty;
            grncl.ButtonHighlightForeColor = Color.Black;
            grncl.ButtonPressedColor = Color.White;
            grncl.ButtonPressedColor2 = Color.Empty;
            grncl.ButtonPressedForeColor = Color.Gray;
            grncl.ButtonRoundRadius = 30;
            grncl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grncl.ForeColor = Color.Black;
            grncl.Location = new Point(21, 97);
            grncl.Margin = new Padding(3, 2, 3, 2);
            grncl.Name = "grncl";
            grncl.Size = new Size(123, 41);
            grncl.TabIndex = 15;
            grncl.Text = "Clear";
            grncl.Click += grnclearBtn_Click;
            // 
            // grnDatePicker2
            // 
            grnDatePicker2.Location = new Point(315, 48);
            grnDatePicker2.Name = "grnDatePicker2";
            grnDatePicker2.Size = new Size(238, 23);
            grnDatePicker2.TabIndex = 9;
            // 
            // grnSearchBtn
            // 
            grnSearchBtn.BackColor = SystemColors.Menu;
            grnSearchBtn.BackColor2 = Color.White;
            grnSearchBtn.BorderColor = Color.White;
            grnSearchBtn.BorderSize = 2;
            grnSearchBtn.ButtonBorderColor = Color.Gray;
            grnSearchBtn.ButtonHighlightColor = Color.Empty;
            grnSearchBtn.ButtonHighlightColor2 = Color.Empty;
            grnSearchBtn.ButtonHighlightForeColor = Color.Black;
            grnSearchBtn.ButtonPressedColor = Color.White;
            grnSearchBtn.ButtonPressedColor2 = Color.Empty;
            grnSearchBtn.ButtonPressedForeColor = Color.Gray;
            grnSearchBtn.ButtonRoundRadius = 30;
            grnSearchBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grnSearchBtn.ForeColor = Color.Black;
            grnSearchBtn.Location = new Point(578, 41);
            grnSearchBtn.Margin = new Padding(3, 2, 3, 2);
            grnSearchBtn.Name = "grnSearchBtn";
            grnSearchBtn.Size = new Size(129, 42);
            grnSearchBtn.TabIndex = 15;
            grnSearchBtn.Text = "Search";
            grnSearchBtn.Click += grnSearchBtn_Click;
            // 
            // grnlbl2
            // 
            grnlbl2.AutoSize = true;
            grnlbl2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grnlbl2.Location = new Point(316, 10);
            grnlbl2.Name = "grnlbl2";
            grnlbl2.Size = new Size(31, 25);
            grnlbl2.TabIndex = 11;
            grnlbl2.Text = "To";
            // 
            // grnAddNoteBtn
            // 
            grnAddNoteBtn.BackColor = Color.LimeGreen;
            grnAddNoteBtn.BackColor2 = Color.Lime;
            grnAddNoteBtn.BorderColor = Color.Black;
            grnAddNoteBtn.BorderSize = 2;
            grnAddNoteBtn.ButtonBorderColor = Color.Gray;
            grnAddNoteBtn.ButtonHighlightColor = Color.Empty;
            grnAddNoteBtn.ButtonHighlightColor2 = Color.Empty;
            grnAddNoteBtn.ButtonHighlightForeColor = Color.Black;
            grnAddNoteBtn.ButtonPressedColor = Color.White;
            grnAddNoteBtn.ButtonPressedColor2 = Color.Empty;
            grnAddNoteBtn.ButtonPressedForeColor = Color.Gray;
            grnAddNoteBtn.ButtonRoundRadius = 30;
            grnAddNoteBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grnAddNoteBtn.ForeColor = Color.White;
            grnAddNoteBtn.Location = new Point(887, 34);
            grnAddNoteBtn.Margin = new Padding(3, 2, 3, 2);
            grnAddNoteBtn.Name = "grnAddNoteBtn";
            grnAddNoteBtn.Size = new Size(139, 42);
            grnAddNoteBtn.TabIndex = 15;
            grnAddNoteBtn.Text = "Add";
            grnAddNoteBtn.Click += grnAddNoteBtn_Click;
            // 
            // grndata
            // 
            grndata.AllowUserToAddRows = false;
            grndata.AllowUserToDeleteRows = false;
            dataGridViewCellStyle198.BackColor = Color.Gainsboro;
            grndata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle198;
            grndata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle199.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle199.BackColor = SystemColors.Control;
            dataGridViewCellStyle199.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle199.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle199.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle199.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle199.WrapMode = DataGridViewTriState.True;
            grndata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle199;
            grndata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grndata.Columns.AddRange(new DataGridViewColumn[] { grncheckColumn });
            dataGridViewCellStyle200.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle200.BackColor = SystemColors.Window;
            dataGridViewCellStyle200.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle200.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle200.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle200.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle200.WrapMode = DataGridViewTriState.False;
            grndata.DefaultCellStyle = dataGridViewCellStyle200;
            grndata.Location = new Point(34, 251);
            grndata.MultiSelect = false;
            grndata.Name = "grndata";
            dataGridViewCellStyle201.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle201.BackColor = SystemColors.Control;
            dataGridViewCellStyle201.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle201.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle201.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle201.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle201.WrapMode = DataGridViewTriState.True;
            grndata.RowHeadersDefaultCellStyle = dataGridViewCellStyle201;
            grndata.RowHeadersVisible = false;
            grndata.RowHeadersWidth = 51;
            grndata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grndata.Size = new Size(1038, 434);
            grndata.TabIndex = 7;
            grndata.CellContentClick += grndata_CellContentClick;
            // 
            // grncheckColumn
            // 
            grncheckColumn.FillWeight = 50F;
            grncheckColumn.HeaderText = "Select";
            grncheckColumn.MinimumWidth = 35;
            grncheckColumn.Name = "grncheckColumn";
            // 
            // GRNlbl
            // 
            GRNlbl.AutoSize = true;
            GRNlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GRNlbl.Location = new Point(31, 8);
            GRNlbl.Name = "GRNlbl";
            GRNlbl.Size = new Size(194, 25);
            GRNlbl.TabIndex = 6;
            GRNlbl.Text = "Good Received Note";
            // 
            // deliverypnl
            // 
            deliverypnl.Controls.Add(panel56);
            deliverypnl.Controls.Add(panel13);
            deliverypnl.Controls.Add(panel2);
            deliverypnl.Controls.Add(deliveryData);
            deliverypnl.Controls.Add(deliveryAddbtn);
            deliverypnl.Controls.Add(deliverylbl);
            deliverypnl.Location = new Point(176, 2);
            deliverypnl.Name = "deliverypnl";
            deliverypnl.Size = new Size(1094, 788);
            deliverypnl.TabIndex = 9;
            deliverypnl.Visible = false;
            deliverypnl.Paint += deliverypnl_Paint;
            deliverypnl.MouseDown += Dashboard_MouseDown;
            deliverypnl.MouseMove += Dashboard_MouseMove;
            deliverypnl.MouseUp += Dashboard_MouseUp;
            // 
            // panel56
            // 
            panel56.Controls.Add(panel61);
            panel56.Controls.Add(panel62);
            panel56.Controls.Add(panel64);
            panel56.Controls.Add(panel65);
            panel56.Controls.Add(label42);
            panel56.Controls.Add(label61);
            panel56.Controls.Add(label63);
            panel56.Location = new Point(37, 242);
            panel56.Margin = new Padding(3, 2, 3, 2);
            panel56.Name = "panel56";
            panel56.Size = new Size(1038, 52);
            panel56.TabIndex = 40;
            panel56.Paint += panel56_Paint_1;
            // 
            // panel61
            // 
            panel61.AutoSize = true;
            panel61.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel61.Controls.Add(textBox3);
            panel61.Location = new Point(486, 20);
            panel61.Margin = new Padding(3, 2, 3, 2);
            panel61.Name = "panel61";
            panel61.Size = new Size(36, 24);
            panel61.TabIndex = 52;
            panel61.Paint += panel26_Paint;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(7, 3);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(26, 19);
            textBox3.TabIndex = 48;
            textBox3.Text = "880";
            // 
            // panel62
            // 
            panel62.AutoSize = true;
            panel62.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel62.Controls.Add(textBox5);
            panel62.Location = new Point(776, 19);
            panel62.Margin = new Padding(3, 2, 3, 2);
            panel62.Name = "panel62";
            panel62.Size = new Size(38, 24);
            panel62.TabIndex = 51;
            panel62.Paint += panel26_Paint;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Menu;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(9, 3);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(26, 19);
            textBox5.TabIndex = 48;
            textBox5.Text = "880";
            // 
            // panel64
            // 
            panel64.AutoSize = true;
            panel64.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel64.Location = new Point(777, 14);
            panel64.Margin = new Padding(3, 2, 3, 2);
            panel64.Name = "panel64";
            panel64.Size = new Size(0, 0);
            panel64.TabIndex = 50;
            // 
            // panel65
            // 
            panel65.AutoSize = true;
            panel65.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel65.Controls.Add(textBox7);
            panel65.Location = new Point(178, 20);
            panel65.Margin = new Padding(3, 2, 3, 2);
            panel65.Name = "panel65";
            panel65.Size = new Size(36, 24);
            panel65.TabIndex = 50;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Menu;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(7, 3);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(26, 19);
            textBox7.TabIndex = 48;
            textBox7.Text = "44";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BackColor = SystemColors.Menu;
            label42.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label42.Location = new Point(679, 20);
            label42.Name = "label42";
            label42.Size = new Size(94, 21);
            label42.TabIndex = 37;
            label42.Text = "Completed";
            // 
            // label61
            // 
            label61.AutoSize = true;
            label61.BackColor = SystemColors.Menu;
            label61.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label61.Location = new Point(407, 19);
            label61.Name = "label61";
            label61.Size = new Size(74, 21);
            label61.TabIndex = 33;
            label61.Text = "Partially";
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.BackColor = SystemColors.Menu;
            label63.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label63.Location = new Point(133, 18);
            label63.Name = "label63";
            label63.Size = new Size(45, 21);
            label63.TabIndex = 35;
            label63.Text = "New";
            // 
            // panel13
            // 
            panel13.Controls.Add(roundedButton9);
            panel13.Controls.Add(label17);
            panel13.Controls.Add(roundedButton10);
            panel13.Controls.Add(roundedButton11);
            panel13.Controls.Add(roundedButton12);
            panel13.Location = new Point(576, 714);
            panel13.Name = "panel13";
            panel13.Size = new Size(495, 50);
            panel13.TabIndex = 34;
            // 
            // roundedButton9
            // 
            roundedButton9.BackColor = SystemColors.Menu;
            roundedButton9.BackColor2 = Color.White;
            roundedButton9.BorderColor = Color.Tomato;
            roundedButton9.BorderSize = 2;
            roundedButton9.ButtonBorderColor = Color.Gray;
            roundedButton9.ButtonHighlightColor = Color.Empty;
            roundedButton9.ButtonHighlightColor2 = Color.Empty;
            roundedButton9.ButtonHighlightForeColor = Color.Black;
            roundedButton9.ButtonPressedColor = Color.White;
            roundedButton9.ButtonPressedColor2 = Color.Empty;
            roundedButton9.ButtonPressedForeColor = SystemColors.GrayText;
            roundedButton9.ButtonRoundRadius = 30;
            roundedButton9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton9.ForeColor = Color.Black;
            roundedButton9.Location = new Point(61, 7);
            roundedButton9.Name = "roundedButton9";
            roundedButton9.Size = new Size(69, 33);
            roundedButton9.TabIndex = 31;
            roundedButton9.Text = "First";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(214, 16);
            label17.Name = "label17";
            label17.Size = new Size(79, 20);
            label17.TabIndex = 3;
            label17.Text = "LabelData";
            // 
            // roundedButton10
            // 
            roundedButton10.AccessibleRole = AccessibleRole.None;
            roundedButton10.BackColor = SystemColors.Menu;
            roundedButton10.BackColor2 = Color.White;
            roundedButton10.BorderColor = Color.Tomato;
            roundedButton10.BorderSize = 2;
            roundedButton10.ButtonBorderColor = Color.Gray;
            roundedButton10.ButtonHighlightColor = Color.Empty;
            roundedButton10.ButtonHighlightColor2 = Color.Empty;
            roundedButton10.ButtonHighlightForeColor = Color.Black;
            roundedButton10.ButtonPressedColor = Color.White;
            roundedButton10.ButtonPressedColor2 = Color.Empty;
            roundedButton10.ButtonPressedForeColor = Color.Gray;
            roundedButton10.ButtonRoundRadius = 30;
            roundedButton10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton10.ForeColor = Color.Black;
            roundedButton10.Location = new Point(136, 8);
            roundedButton10.Name = "roundedButton10";
            roundedButton10.Size = new Size(63, 33);
            roundedButton10.TabIndex = 33;
            roundedButton10.Text = "Prev";
            // 
            // roundedButton11
            // 
            roundedButton11.BackColor = SystemColors.Menu;
            roundedButton11.BackColor2 = Color.White;
            roundedButton11.BorderColor = Color.White;
            roundedButton11.BorderSize = 2;
            roundedButton11.ButtonBorderColor = Color.Gray;
            roundedButton11.ButtonHighlightColor = Color.Empty;
            roundedButton11.ButtonHighlightColor2 = Color.Empty;
            roundedButton11.ButtonHighlightForeColor = Color.Black;
            roundedButton11.ButtonPressedColor = Color.White;
            roundedButton11.ButtonPressedColor2 = Color.Empty;
            roundedButton11.ButtonPressedForeColor = Color.Gray;
            roundedButton11.ButtonRoundRadius = 30;
            roundedButton11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton11.ForeColor = Color.Black;
            roundedButton11.Location = new Point(397, 7);
            roundedButton11.Name = "roundedButton11";
            roundedButton11.Size = new Size(66, 33);
            roundedButton11.TabIndex = 34;
            roundedButton11.Text = "Last";
            // 
            // roundedButton12
            // 
            roundedButton12.BackColor = SystemColors.HighlightText;
            roundedButton12.BackColor2 = Color.White;
            roundedButton12.BorderColor = Color.Tomato;
            roundedButton12.BorderSize = 2;
            roundedButton12.ButtonBorderColor = Color.Gray;
            roundedButton12.ButtonHighlightColor = Color.Empty;
            roundedButton12.ButtonHighlightColor2 = Color.Empty;
            roundedButton12.ButtonHighlightForeColor = Color.Black;
            roundedButton12.ButtonPressedColor = Color.White;
            roundedButton12.ButtonPressedColor2 = Color.Empty;
            roundedButton12.ButtonPressedForeColor = Color.Gray;
            roundedButton12.ButtonRoundRadius = 30;
            roundedButton12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton12.ForeColor = Color.Black;
            roundedButton12.Location = new Point(318, 6);
            roundedButton12.Name = "roundedButton12";
            roundedButton12.Size = new Size(71, 33);
            roundedButton12.TabIndex = 32;
            roundedButton12.Text = "Next";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(28, 55);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1052, 181);
            panel2.TabIndex = 16;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(deliverycompletedeliverybtn);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(deliverySearchIDbox);
            groupBox2.Controls.Add(deliverydateTimePicker2);
            groupBox2.Controls.Add(deliveryViewDNbtn);
            groupBox2.Controls.Add(deliveryclearbtn);
            groupBox2.Controls.Add(deliverydateTimePicker1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(deliverySearchDatebtn);
            groupBox2.Location = new Point(8, 5);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1012, 163);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            // 
            // deliverycompletedeliverybtn
            // 
            deliverycompletedeliverybtn.BackColor = SystemColors.Menu;
            deliverycompletedeliverybtn.BackColor2 = Color.White;
            deliverycompletedeliverybtn.BorderColor = Color.White;
            deliverycompletedeliverybtn.BorderSize = 2;
            deliverycompletedeliverybtn.ButtonBorderColor = Color.Gray;
            deliverycompletedeliverybtn.ButtonHighlightColor = Color.Empty;
            deliverycompletedeliverybtn.ButtonHighlightColor2 = Color.Empty;
            deliverycompletedeliverybtn.ButtonHighlightForeColor = Color.Black;
            deliverycompletedeliverybtn.ButtonPressedColor = Color.White;
            deliverycompletedeliverybtn.ButtonPressedColor2 = Color.Empty;
            deliverycompletedeliverybtn.ButtonPressedForeColor = Color.Gray;
            deliverycompletedeliverybtn.ButtonRoundRadius = 30;
            deliverycompletedeliverybtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliverycompletedeliverybtn.ForeColor = Color.Black;
            deliverycompletedeliverybtn.Location = new Point(153, 117);
            deliverycompletedeliverybtn.Margin = new Padding(3, 2, 3, 2);
            deliverycompletedeliverybtn.Name = "deliverycompletedeliverybtn";
            deliverycompletedeliverybtn.Size = new Size(108, 38);
            deliverycompletedeliverybtn.TabIndex = 32;
            deliverycompletedeliverybtn.Text = "Complete";
            deliverycompletedeliverybtn.Click += deliverycompletedeliverybtn_Click;
            // 
            // deliverySearchIDbox
            // 
            deliverySearchIDbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliverySearchIDbox.Location = new Point(555, 123);
            deliverySearchIDbox.Margin = new Padding(3, 4, 3, 4);
            deliverySearchIDbox.Multiline = true;
            deliverySearchIDbox.Name = "deliverySearchIDbox";
            deliverySearchIDbox.PlaceholderText = "    Search in here";
            deliverySearchIDbox.Size = new Size(446, 32);
            deliverySearchIDbox.TabIndex = 31;
            // 
            // deliverydateTimePicker2
            // 
            deliverydateTimePicker2.Location = new Point(271, 53);
            deliverydateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            deliverydateTimePicker2.Name = "deliverydateTimePicker2";
            deliverydateTimePicker2.Size = new Size(220, 23);
            deliverydateTimePicker2.TabIndex = 9;
            // 
            // deliveryViewDNbtn
            // 
            deliveryViewDNbtn.BackColor = SystemColors.Menu;
            deliveryViewDNbtn.BackColor2 = Color.White;
            deliveryViewDNbtn.BorderColor = Color.White;
            deliveryViewDNbtn.BorderSize = 2;
            deliveryViewDNbtn.ButtonBorderColor = Color.Gray;
            deliveryViewDNbtn.ButtonHighlightColor = Color.Empty;
            deliveryViewDNbtn.ButtonHighlightColor2 = Color.Empty;
            deliveryViewDNbtn.ButtonHighlightForeColor = Color.Black;
            deliveryViewDNbtn.ButtonPressedColor = Color.White;
            deliveryViewDNbtn.ButtonPressedColor2 = Color.Empty;
            deliveryViewDNbtn.ButtonPressedForeColor = Color.Gray;
            deliveryViewDNbtn.ButtonRoundRadius = 30;
            deliveryViewDNbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryViewDNbtn.ForeColor = Color.Black;
            deliveryViewDNbtn.Location = new Point(16, 117);
            deliveryViewDNbtn.Margin = new Padding(3, 2, 3, 2);
            deliveryViewDNbtn.Name = "deliveryViewDNbtn";
            deliveryViewDNbtn.Size = new Size(108, 38);
            deliveryViewDNbtn.TabIndex = 17;
            deliveryViewDNbtn.Text = "View";
            deliveryViewDNbtn.Click += deliveryViewDNbtn_Click;
            // 
            // deliveryclearbtn
            // 
            deliveryclearbtn.BackColor = SystemColors.Menu;
            deliveryclearbtn.BackColor2 = Color.White;
            deliveryclearbtn.BorderColor = Color.White;
            deliveryclearbtn.BorderSize = 2;
            deliveryclearbtn.ButtonBorderColor = Color.Gray;
            deliveryclearbtn.ButtonHighlightColor = Color.Empty;
            deliveryclearbtn.ButtonHighlightColor2 = Color.Empty;
            deliveryclearbtn.ButtonHighlightForeColor = Color.Black;
            deliveryclearbtn.ButtonPressedColor = Color.White;
            deliveryclearbtn.ButtonPressedColor2 = Color.Empty;
            deliveryclearbtn.ButtonPressedForeColor = Color.Gray;
            deliveryclearbtn.ButtonRoundRadius = 30;
            deliveryclearbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryclearbtn.ForeColor = Color.Black;
            deliveryclearbtn.Location = new Point(288, 116);
            deliveryclearbtn.Margin = new Padding(3, 2, 3, 2);
            deliveryclearbtn.Name = "deliveryclearbtn";
            deliveryclearbtn.Size = new Size(108, 38);
            deliveryclearbtn.TabIndex = 30;
            deliveryclearbtn.Text = "Clear";
            deliveryclearbtn.Click += deliveryclearbtn_Click_1;
            // 
            // deliverydateTimePicker1
            // 
            deliverydateTimePicker1.Location = new Point(14, 53);
            deliverydateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            deliverydateTimePicker1.Name = "deliverydateTimePicker1";
            deliverydateTimePicker1.Size = new Size(212, 23);
            deliverydateTimePicker1.TabIndex = 8;
            deliverydateTimePicker1.ValueChanged += deliverydateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(268, 17);
            label3.Name = "label3";
            label3.Size = new Size(31, 25);
            label3.TabIndex = 11;
            label3.Text = "To";
            // 
            // deliverySearchDatebtn
            // 
            deliverySearchDatebtn.BackColor = SystemColors.Menu;
            deliverySearchDatebtn.BackColor2 = Color.White;
            deliverySearchDatebtn.BorderColor = Color.White;
            deliverySearchDatebtn.BorderSize = 2;
            deliverySearchDatebtn.ButtonBorderColor = Color.Gray;
            deliverySearchDatebtn.ButtonHighlightColor = Color.Empty;
            deliverySearchDatebtn.ButtonHighlightColor2 = Color.Empty;
            deliverySearchDatebtn.ButtonHighlightForeColor = Color.Black;
            deliverySearchDatebtn.ButtonPressedColor = Color.White;
            deliverySearchDatebtn.ButtonPressedColor2 = Color.Empty;
            deliverySearchDatebtn.ButtonPressedForeColor = Color.Gray;
            deliverySearchDatebtn.ButtonRoundRadius = 30;
            deliverySearchDatebtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliverySearchDatebtn.ForeColor = Color.Black;
            deliverySearchDatebtn.Location = new Point(514, 44);
            deliverySearchDatebtn.Margin = new Padding(3, 2, 3, 2);
            deliverySearchDatebtn.Name = "deliverySearchDatebtn";
            deliverySearchDatebtn.Size = new Size(97, 38);
            deliverySearchDatebtn.TabIndex = 25;
            deliverySearchDatebtn.Text = "Filter";
            deliverySearchDatebtn.Click += deliverySearchDatebtn_Click;
            // 
            // deliveryData
            // 
            deliveryData.AllowUserToAddRows = false;
            deliveryData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle202.BackColor = Color.Gainsboro;
            deliveryData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle202;
            deliveryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle203.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle203.BackColor = SystemColors.Control;
            dataGridViewCellStyle203.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle203.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle203.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle203.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle203.WrapMode = DataGridViewTriState.True;
            deliveryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle203;
            deliveryData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            deliveryData.Columns.AddRange(new DataGridViewColumn[] { deliverycheckColumn });
            dataGridViewCellStyle204.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle204.BackColor = SystemColors.Window;
            dataGridViewCellStyle204.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle204.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle204.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle204.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle204.WrapMode = DataGridViewTriState.False;
            deliveryData.DefaultCellStyle = dataGridViewCellStyle204;
            deliveryData.Location = new Point(32, 302);
            deliveryData.Margin = new Padding(3, 2, 3, 2);
            deliveryData.Name = "deliveryData";
            dataGridViewCellStyle205.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle205.BackColor = SystemColors.Control;
            dataGridViewCellStyle205.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle205.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle205.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle205.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle205.WrapMode = DataGridViewTriState.True;
            deliveryData.RowHeadersDefaultCellStyle = dataGridViewCellStyle205;
            deliveryData.RowHeadersVisible = false;
            deliveryData.RowHeadersWidth = 51;
            deliveryData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            deliveryData.Size = new Size(1040, 400);
            deliveryData.TabIndex = 7;
            deliveryData.CellClick += deliveryData_CellClick;
            deliveryData.CellContentClick += deliveryData_CellContentClick;
            // 
            // deliveryAddbtn
            // 
            deliveryAddbtn.BackColor = Color.LimeGreen;
            deliveryAddbtn.BackColor2 = Color.Lime;
            deliveryAddbtn.BorderColor = Color.White;
            deliveryAddbtn.BorderSize = 2;
            deliveryAddbtn.ButtonBorderColor = Color.Gray;
            deliveryAddbtn.ButtonHighlightColor = Color.Empty;
            deliveryAddbtn.ButtonHighlightColor2 = Color.Empty;
            deliveryAddbtn.ButtonHighlightForeColor = Color.Black;
            deliveryAddbtn.ButtonPressedColor = Color.White;
            deliveryAddbtn.ButtonPressedColor2 = Color.Empty;
            deliveryAddbtn.ButtonPressedForeColor = Color.Gray;
            deliveryAddbtn.ButtonRoundRadius = 30;
            deliveryAddbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryAddbtn.ForeColor = Color.White;
            deliveryAddbtn.Location = new Point(860, 8);
            deliveryAddbtn.Margin = new Padding(3, 2, 3, 2);
            deliveryAddbtn.Name = "deliveryAddbtn";
            deliveryAddbtn.Size = new Size(141, 42);
            deliveryAddbtn.TabIndex = 15;
            deliveryAddbtn.Text = "Add";
            deliveryAddbtn.Click += deliveryAddbtn_Click_1;
            // 
            // deliverylbl
            // 
            deliverylbl.AutoSize = true;
            deliverylbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliverylbl.Location = new Point(36, 8);
            deliverylbl.Name = "deliverylbl";
            deliverylbl.Size = new Size(134, 25);
            deliverylbl.TabIndex = 6;
            deliverylbl.Text = "Delivery Note";
            // 
            // deliveryCompletepnl
            // 
            deliveryCompletepnl.Controls.Add(deliveryShippingdatelbl);
            deliveryCompletepnl.Controls.Add(DeliverydeliveredDate);
            deliveryCompletepnl.Controls.Add(label20);
            deliveryCompletepnl.Controls.Add(deliveryBackbtn);
            deliveryCompletepnl.Controls.Add(deliveryDeliveryIDlbl);
            deliveryCompletepnl.Controls.Add(label4);
            deliveryCompletepnl.Controls.Add(deliveryCompletebtn);
            deliveryCompletepnl.Controls.Add(DeliveryCancelbtn);
            deliveryCompletepnl.Controls.Add(deliveryNextbtn);
            deliveryCompletepnl.Location = new Point(186, 16);
            deliveryCompletepnl.Name = "deliveryCompletepnl";
            deliveryCompletepnl.Size = new Size(1063, 717);
            deliveryCompletepnl.TabIndex = 35;
            deliveryCompletepnl.Visible = false;
            // 
            // deliveryShippingdatelbl
            // 
            deliveryShippingdatelbl.AutoSize = true;
            deliveryShippingdatelbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryShippingdatelbl.Location = new Point(228, 148);
            deliveryShippingdatelbl.Name = "deliveryShippingdatelbl";
            deliveryShippingdatelbl.Size = new Size(119, 25);
            deliveryShippingdatelbl.TabIndex = 26;
            deliveryShippingdatelbl.Text = "Shipped on ";
            // 
            // DeliverydeliveredDate
            // 
            DeliverydeliveredDate.Location = new Point(264, 219);
            DeliverydeliveredDate.Name = "DeliverydeliveredDate";
            DeliverydeliveredDate.Size = new Size(237, 23);
            DeliverydeliveredDate.TabIndex = 25;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(83, 217);
            label20.Name = "label20";
            label20.Size = new Size(157, 25);
            label20.TabIndex = 24;
            label20.Text = "Delivered Date : ";
            // 
            // deliveryBackbtn
            // 
            deliveryBackbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryBackbtn.Location = new Point(529, 15);
            deliveryBackbtn.Margin = new Padding(3, 2, 3, 2);
            deliveryBackbtn.Name = "deliveryBackbtn";
            deliveryBackbtn.Size = new Size(138, 38);
            deliveryBackbtn.TabIndex = 23;
            deliveryBackbtn.Text = "Back";
            deliveryBackbtn.UseVisualStyleBackColor = true;
            deliveryBackbtn.Click += deliveryBackbtn_Click;
            // 
            // deliveryDeliveryIDlbl
            // 
            deliveryDeliveryIDlbl.AutoSize = true;
            deliveryDeliveryIDlbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryDeliveryIDlbl.Location = new Point(277, 77);
            deliveryDeliveryIDlbl.Name = "deliveryDeliveryIDlbl";
            deliveryDeliveryIDlbl.Size = new Size(151, 30);
            deliveryDeliveryIDlbl.TabIndex = 22;
            deliveryDeliveryIDlbl.Text = "Delivery ID : #";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 2);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 21;
            label4.Text = "Delivery Note";
            // 
            // deliveryCompletebtn
            // 
            deliveryCompletebtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryCompletebtn.Location = new Point(287, 347);
            deliveryCompletebtn.Margin = new Padding(3, 2, 3, 2);
            deliveryCompletebtn.Name = "deliveryCompletebtn";
            deliveryCompletebtn.Size = new Size(138, 38);
            deliveryCompletebtn.TabIndex = 20;
            deliveryCompletebtn.Text = "Complete";
            deliveryCompletebtn.UseVisualStyleBackColor = true;
            deliveryCompletebtn.Click += deliveryCompletebtn_Click;
            // 
            // DeliveryCancelbtn
            // 
            DeliveryCancelbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeliveryCancelbtn.Location = new Point(33, 347);
            DeliveryCancelbtn.Margin = new Padding(3, 2, 3, 2);
            DeliveryCancelbtn.Name = "DeliveryCancelbtn";
            DeliveryCancelbtn.Size = new Size(138, 38);
            DeliveryCancelbtn.TabIndex = 19;
            DeliveryCancelbtn.Text = "Cancel";
            DeliveryCancelbtn.UseVisualStyleBackColor = true;
            // 
            // deliveryNextbtn
            // 
            deliveryNextbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryNextbtn.Location = new Point(529, 347);
            deliveryNextbtn.Margin = new Padding(3, 2, 3, 2);
            deliveryNextbtn.Name = "deliveryNextbtn";
            deliveryNextbtn.Size = new Size(138, 38);
            deliveryNextbtn.TabIndex = 18;
            deliveryNextbtn.Text = "Next";
            deliveryNextbtn.UseVisualStyleBackColor = true;
            // 
            // POpnl
            // 
            POpnl.Controls.Add(poData);
            POpnl.Controls.Add(panel16);
            POpnl.Controls.Add(AddOrderPoButton);
            POpnl.Controls.Add(POlbl);
            POpnl.Controls.Add(panel17);
            POpnl.Location = new Point(176, 2);
            POpnl.Margin = new Padding(3, 2, 3, 2);
            POpnl.Name = "POpnl";
            POpnl.Size = new Size(1094, 788);
            POpnl.TabIndex = 32;
            POpnl.MouseDown += Dashboard_MouseDown;
            POpnl.MouseMove += Dashboard_MouseMove;
            POpnl.MouseUp += Dashboard_MouseUp;
            // 
            // poData
            // 
            poData.AllowUserToAddRows = false;
            poData.AllowUserToDeleteRows = false;
            poData.AllowUserToResizeRows = false;
            dataGridViewCellStyle206.BackColor = Color.Gainsboro;
            poData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle206;
            poData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            poData.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle207.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle207.BackColor = SystemColors.Control;
            dataGridViewCellStyle207.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle207.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle207.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle207.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle207.WrapMode = DataGridViewTriState.True;
            poData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle207;
            poData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            poData.Columns.AddRange(new DataGridViewColumn[] { pocheckColumn });
            dataGridViewCellStyle208.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle208.BackColor = SystemColors.Window;
            dataGridViewCellStyle208.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle208.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle208.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle208.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle208.WrapMode = DataGridViewTriState.False;
            poData.DefaultCellStyle = dataGridViewCellStyle208;
            poData.Location = new Point(39, 266);
            poData.Margin = new Padding(3, 2, 3, 2);
            poData.Name = "poData";
            dataGridViewCellStyle209.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle209.BackColor = SystemColors.Control;
            dataGridViewCellStyle209.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle209.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle209.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle209.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle209.WrapMode = DataGridViewTriState.True;
            poData.RowHeadersDefaultCellStyle = dataGridViewCellStyle209;
            poData.RowHeadersVisible = false;
            poData.RowHeadersWidth = 51;
            poData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poData.Size = new Size(1033, 444);
            poData.TabIndex = 39;
            poData.CellContentClick += poData_CellContentClick;
            // 
            // panel16
            // 
            panel16.Controls.Add(poFirstPageBtn);
            panel16.Controls.Add(poIndexlbl);
            panel16.Controls.Add(poPrevPageBtn);
            panel16.Controls.Add(poLastPagebtn);
            panel16.Controls.Add(poNextPageBtn);
            panel16.Location = new Point(567, 717);
            panel16.Name = "panel16";
            panel16.Size = new Size(495, 50);
            panel16.TabIndex = 38;
            // 
            // poFirstPageBtn
            // 
            poFirstPageBtn.BackColor = SystemColors.Menu;
            poFirstPageBtn.BackColor2 = Color.White;
            poFirstPageBtn.BorderColor = Color.Tomato;
            poFirstPageBtn.BorderSize = 2;
            poFirstPageBtn.ButtonBorderColor = Color.Gray;
            poFirstPageBtn.ButtonHighlightColor = Color.Empty;
            poFirstPageBtn.ButtonHighlightColor2 = Color.Empty;
            poFirstPageBtn.ButtonHighlightForeColor = Color.Black;
            poFirstPageBtn.ButtonPressedColor = Color.White;
            poFirstPageBtn.ButtonPressedColor2 = Color.Empty;
            poFirstPageBtn.ButtonPressedForeColor = Color.Gray;
            poFirstPageBtn.ButtonRoundRadius = 30;
            poFirstPageBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poFirstPageBtn.ForeColor = Color.Black;
            poFirstPageBtn.Location = new Point(42, 7);
            poFirstPageBtn.Name = "poFirstPageBtn";
            poFirstPageBtn.Size = new Size(68, 40);
            poFirstPageBtn.TabIndex = 31;
            poFirstPageBtn.Text = "First";
            poFirstPageBtn.Click += poFirstPageBtn_Click;
            // 
            // poIndexlbl
            // 
            poIndexlbl.AutoSize = true;
            poIndexlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poIndexlbl.Location = new Point(199, 15);
            poIndexlbl.Name = "poIndexlbl";
            poIndexlbl.Size = new Size(79, 20);
            poIndexlbl.TabIndex = 3;
            poIndexlbl.Text = "LabelData";
            // 
            // poPrevPageBtn
            // 
            poPrevPageBtn.AccessibleRole = AccessibleRole.None;
            poPrevPageBtn.BackColor = SystemColors.Menu;
            poPrevPageBtn.BackColor2 = Color.White;
            poPrevPageBtn.BorderColor = Color.Tomato;
            poPrevPageBtn.BorderSize = 2;
            poPrevPageBtn.ButtonBorderColor = Color.Gray;
            poPrevPageBtn.ButtonHighlightColor = Color.Empty;
            poPrevPageBtn.ButtonHighlightColor2 = Color.Empty;
            poPrevPageBtn.ButtonHighlightForeColor = Color.Black;
            poPrevPageBtn.ButtonPressedColor = Color.White;
            poPrevPageBtn.ButtonPressedColor2 = Color.Empty;
            poPrevPageBtn.ButtonPressedForeColor = Color.Gray;
            poPrevPageBtn.ButtonRoundRadius = 30;
            poPrevPageBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poPrevPageBtn.ForeColor = Color.Black;
            poPrevPageBtn.Location = new Point(127, 7);
            poPrevPageBtn.Name = "poPrevPageBtn";
            poPrevPageBtn.Size = new Size(62, 40);
            poPrevPageBtn.TabIndex = 33;
            poPrevPageBtn.Text = "Prev";
            poPrevPageBtn.Click += poPrevPageBtn_Click;
            // 
            // poLastPagebtn
            // 
            poLastPagebtn.BackColor = SystemColors.Menu;
            poLastPagebtn.BackColor2 = Color.White;
            poLastPagebtn.BorderColor = Color.White;
            poLastPagebtn.BorderSize = 2;
            poLastPagebtn.ButtonBorderColor = Color.Gray;
            poLastPagebtn.ButtonHighlightColor = Color.Empty;
            poLastPagebtn.ButtonHighlightColor2 = Color.Empty;
            poLastPagebtn.ButtonHighlightForeColor = Color.Black;
            poLastPagebtn.ButtonPressedColor = Color.White;
            poLastPagebtn.ButtonPressedColor2 = Color.Empty;
            poLastPagebtn.ButtonPressedForeColor = Color.Gray;
            poLastPagebtn.ButtonRoundRadius = 30;
            poLastPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poLastPagebtn.ForeColor = Color.Black;
            poLastPagebtn.Location = new Point(397, 7);
            poLastPagebtn.Name = "poLastPagebtn";
            poLastPagebtn.Size = new Size(62, 37);
            poLastPagebtn.TabIndex = 34;
            poLastPagebtn.Text = "Last";
            poLastPagebtn.Click += poLastPagebtn_Click;
            // 
            // poNextPageBtn
            // 
            poNextPageBtn.BackColor = SystemColors.Menu;
            poNextPageBtn.BackColor2 = Color.White;
            poNextPageBtn.BorderColor = Color.Tomato;
            poNextPageBtn.BorderSize = 2;
            poNextPageBtn.ButtonBorderColor = Color.Gray;
            poNextPageBtn.ButtonHighlightColor = Color.Empty;
            poNextPageBtn.ButtonHighlightColor2 = Color.Empty;
            poNextPageBtn.ButtonHighlightForeColor = Color.Black;
            poNextPageBtn.ButtonPressedColor = Color.White;
            poNextPageBtn.ButtonPressedColor2 = Color.Empty;
            poNextPageBtn.ButtonPressedForeColor = Color.Gray;
            poNextPageBtn.ButtonRoundRadius = 30;
            poNextPageBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poNextPageBtn.ForeColor = Color.Black;
            poNextPageBtn.Location = new Point(310, 7);
            poNextPageBtn.Name = "poNextPageBtn";
            poNextPageBtn.Size = new Size(68, 37);
            poNextPageBtn.TabIndex = 32;
            poNextPageBtn.Text = "Next";
            poNextPageBtn.Click += poNextPageBtn_Click;
            // 
            // AddOrderPoButton
            // 
            AddOrderPoButton.BackColor = Color.LimeGreen;
            AddOrderPoButton.BackColor2 = Color.Lime;
            AddOrderPoButton.BorderColor = Color.White;
            AddOrderPoButton.BorderSize = 2;
            AddOrderPoButton.ButtonBorderColor = Color.Gray;
            AddOrderPoButton.ButtonHighlightColor = Color.Empty;
            AddOrderPoButton.ButtonHighlightColor2 = Color.Empty;
            AddOrderPoButton.ButtonHighlightForeColor = Color.Black;
            AddOrderPoButton.ButtonPressedColor = Color.White;
            AddOrderPoButton.ButtonPressedColor2 = Color.Empty;
            AddOrderPoButton.ButtonPressedForeColor = Color.Gray;
            AddOrderPoButton.ButtonRoundRadius = 30;
            AddOrderPoButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddOrderPoButton.ForeColor = Color.White;
            AddOrderPoButton.Location = new Point(910, 7);
            AddOrderPoButton.Name = "AddOrderPoButton";
            AddOrderPoButton.Size = new Size(138, 42);
            AddOrderPoButton.TabIndex = 36;
            AddOrderPoButton.Text = "Add Order";
            AddOrderPoButton.Click += button17_Click;
            // 
            // POlbl
            // 
            POlbl.AutoSize = true;
            POlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            POlbl.Location = new Point(31, 7);
            POlbl.Name = "POlbl";
            POlbl.Size = new Size(149, 25);
            POlbl.TabIndex = 0;
            POlbl.Text = "Purchase Order";
            // 
            // panel17
            // 
            panel17.Controls.Add(roundedButton1);
            panel17.Controls.Add(groupBox1);
            panel17.Controls.Add(CompletePoButton);
            panel17.Controls.Add(poSearchbox);
            panel17.Location = new Point(32, 51);
            panel17.Name = "panel17";
            panel17.Size = new Size(1040, 202);
            panel17.TabIndex = 37;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = SystemColors.Menu;
            roundedButton1.BackColor2 = Color.White;
            roundedButton1.BorderColor = Color.White;
            roundedButton1.BorderSize = 2;
            roundedButton1.ButtonBorderColor = Color.Gray;
            roundedButton1.ButtonHighlightColor = Color.Empty;
            roundedButton1.ButtonHighlightColor2 = Color.Empty;
            roundedButton1.ButtonHighlightForeColor = Color.Black;
            roundedButton1.ButtonPressedColor = Color.White;
            roundedButton1.ButtonPressedColor2 = Color.Empty;
            roundedButton1.ButtonPressedForeColor = Color.Gray;
            roundedButton1.ButtonRoundRadius = 30;
            roundedButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.Black;
            roundedButton1.Location = new Point(405, 150);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(112, 38);
            roundedButton1.TabIndex = 34;
            roundedButton1.Text = "Clear";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateFilterbtn);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(podateTimePicker1);
            groupBox1.Controls.Add(podateTimePicker2);
            groupBox1.Controls.Add(label26);
            groupBox1.Location = new Point(13, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1019, 110);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter by Date";
            // 
            // dateFilterbtn
            // 
            dateFilterbtn.BackColor = SystemColors.Menu;
            dateFilterbtn.BackColor2 = Color.White;
            dateFilterbtn.BorderColor = Color.White;
            dateFilterbtn.BorderSize = 2;
            dateFilterbtn.ButtonBorderColor = Color.Gray;
            dateFilterbtn.ButtonHighlightColor = Color.Empty;
            dateFilterbtn.ButtonHighlightColor2 = Color.Empty;
            dateFilterbtn.ButtonHighlightForeColor = Color.Black;
            dateFilterbtn.ButtonPressedColor = Color.White;
            dateFilterbtn.ButtonPressedColor2 = Color.Empty;
            dateFilterbtn.ButtonPressedForeColor = Color.Gray;
            dateFilterbtn.ButtonRoundRadius = 30;
            dateFilterbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateFilterbtn.ForeColor = Color.Black;
            dateFilterbtn.Location = new Point(597, 68);
            dateFilterbtn.Name = "dateFilterbtn";
            dateFilterbtn.Size = new Size(112, 38);
            dateFilterbtn.TabIndex = 33;
            dateFilterbtn.Text = "Filter";
            dateFilterbtn.Click += dateFilterbtn_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(32, 29);
            label25.Name = "label25";
            label25.Size = new Size(55, 25);
            label25.TabIndex = 10;
            label25.Text = "From";
            // 
            // podateTimePicker1
            // 
            podateTimePicker1.Location = new Point(32, 77);
            podateTimePicker1.Name = "podateTimePicker1";
            podateTimePicker1.Size = new Size(242, 23);
            podateTimePicker1.TabIndex = 8;
            podateTimePicker1.ValueChanged += podateTimePicker1_ValueChanged;
            // 
            // podateTimePicker2
            // 
            podateTimePicker2.Location = new Point(326, 77);
            podateTimePicker2.Name = "podateTimePicker2";
            podateTimePicker2.Size = new Size(251, 23);
            podateTimePicker2.TabIndex = 9;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(322, 29);
            label26.Name = "label26";
            label26.Size = new Size(31, 25);
            label26.TabIndex = 11;
            label26.Text = "To";
            // 
            // CompletePoButton
            // 
            CompletePoButton.BackColor = SystemColors.Menu;
            CompletePoButton.BackColor2 = Color.White;
            CompletePoButton.BorderColor = Color.White;
            CompletePoButton.BorderSize = 2;
            CompletePoButton.ButtonBorderColor = Color.Gray;
            CompletePoButton.ButtonHighlightColor = Color.Empty;
            CompletePoButton.ButtonHighlightColor2 = Color.Empty;
            CompletePoButton.ButtonHighlightForeColor = Color.Black;
            CompletePoButton.ButtonPressedColor = Color.White;
            CompletePoButton.ButtonPressedColor2 = Color.Empty;
            CompletePoButton.ButtonPressedForeColor = Color.Gray;
            CompletePoButton.ButtonRoundRadius = 30;
            CompletePoButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompletePoButton.ForeColor = Color.Black;
            CompletePoButton.Location = new Point(49, 148);
            CompletePoButton.Margin = new Padding(3, 2, 3, 2);
            CompletePoButton.Name = "CompletePoButton";
            CompletePoButton.Size = new Size(121, 37);
            CompletePoButton.TabIndex = 32;
            CompletePoButton.Text = "Complete";
            // 
            // poSearchbox
            // 
            poSearchbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            poSearchbox.Location = new Point(544, 154);
            poSearchbox.Margin = new Padding(3, 5, 3, 5);
            poSearchbox.Multiline = true;
            poSearchbox.Name = "poSearchbox";
            poSearchbox.PlaceholderText = "    Search";
            poSearchbox.Size = new Size(473, 32);
            poSearchbox.TabIndex = 31;
            // 
            // dataGridViewCheckBoxColumn6
            // 
            dataGridViewCheckBoxColumn6.FillWeight = 35F;
            dataGridViewCheckBoxColumn6.HeaderText = "Select";
            dataGridViewCheckBoxColumn6.MinimumWidth = 35;
            dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            dataGridViewCheckBoxColumn6.Width = 125;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            dataGridViewCheckBoxColumn2.FillWeight = 35F;
            dataGridViewCheckBoxColumn2.HeaderText = "Select";
            dataGridViewCheckBoxColumn2.MinimumWidth = 35;
            dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            dataGridViewCheckBoxColumn2.Width = 125;
            // 
            // outstandingOrderpnl
            // 
            outstandingOrderpnl.Controls.Add(panel20);
            outstandingOrderpnl.Controls.Add(panel21);
            outstandingOrderpnl.Controls.Add(outstandingdata);
            outstandingOrderpnl.Controls.Add(outstandingOrderlbl);
            outstandingOrderpnl.Location = new Point(176, 2);
            outstandingOrderpnl.Margin = new Padding(3, 2, 3, 2);
            outstandingOrderpnl.Name = "outstandingOrderpnl";
            outstandingOrderpnl.Size = new Size(1094, 788);
            outstandingOrderpnl.TabIndex = 33;
            outstandingOrderpnl.MouseDown += Dashboard_MouseDown;
            outstandingOrderpnl.MouseMove += Dashboard_MouseMove;
            outstandingOrderpnl.MouseUp += Dashboard_MouseUp;
            // 
            // panel20
            // 
            panel20.Controls.Add(outstandingFirstPagebtn);
            panel20.Controls.Add(oustadningPrevPagebtn);
            panel20.Controls.Add(outstandingLastPagebtn);
            panel20.Controls.Add(outstandingNextPagebtn);
            panel20.Controls.Add(oustandingPagelbl);
            panel20.Location = new Point(569, 714);
            panel20.Name = "panel20";
            panel20.Size = new Size(495, 50);
            panel20.TabIndex = 38;
            // 
            // outstandingFirstPagebtn
            // 
            outstandingFirstPagebtn.BackColor = SystemColors.Menu;
            outstandingFirstPagebtn.BackColor2 = Color.White;
            outstandingFirstPagebtn.BorderColor = Color.Tomato;
            outstandingFirstPagebtn.BorderSize = 2;
            outstandingFirstPagebtn.ButtonBorderColor = Color.Gray;
            outstandingFirstPagebtn.ButtonHighlightColor = Color.Empty;
            outstandingFirstPagebtn.ButtonHighlightColor2 = Color.Empty;
            outstandingFirstPagebtn.ButtonHighlightForeColor = Color.Black;
            outstandingFirstPagebtn.ButtonPressedColor = Color.White;
            outstandingFirstPagebtn.ButtonPressedColor2 = Color.Empty;
            outstandingFirstPagebtn.ButtonPressedForeColor = Color.Gray;
            outstandingFirstPagebtn.ButtonRoundRadius = 30;
            outstandingFirstPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingFirstPagebtn.ForeColor = Color.Black;
            outstandingFirstPagebtn.Location = new Point(51, 6);
            outstandingFirstPagebtn.Name = "outstandingFirstPagebtn";
            outstandingFirstPagebtn.Size = new Size(70, 38);
            outstandingFirstPagebtn.TabIndex = 31;
            outstandingFirstPagebtn.Text = "First";
            outstandingFirstPagebtn.Click += outstandingFirstPagebtn_Click;
            // 
            // oustadningPrevPagebtn
            // 
            oustadningPrevPagebtn.AccessibleRole = AccessibleRole.None;
            oustadningPrevPagebtn.BackColor = SystemColors.Menu;
            oustadningPrevPagebtn.BackColor2 = Color.White;
            oustadningPrevPagebtn.BorderColor = Color.Tomato;
            oustadningPrevPagebtn.BorderSize = 2;
            oustadningPrevPagebtn.ButtonBorderColor = Color.Gray;
            oustadningPrevPagebtn.ButtonHighlightColor = Color.Empty;
            oustadningPrevPagebtn.ButtonHighlightColor2 = Color.Empty;
            oustadningPrevPagebtn.ButtonHighlightForeColor = Color.Black;
            oustadningPrevPagebtn.ButtonPressedColor = Color.White;
            oustadningPrevPagebtn.ButtonPressedColor2 = Color.Empty;
            oustadningPrevPagebtn.ButtonPressedForeColor = Color.Gray;
            oustadningPrevPagebtn.ButtonRoundRadius = 30;
            oustadningPrevPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oustadningPrevPagebtn.ForeColor = Color.Black;
            oustadningPrevPagebtn.Location = new Point(135, 7);
            oustadningPrevPagebtn.Name = "oustadningPrevPagebtn";
            oustadningPrevPagebtn.Size = new Size(67, 37);
            oustadningPrevPagebtn.TabIndex = 33;
            oustadningPrevPagebtn.Text = "Prev";
            oustadningPrevPagebtn.Click += outstandingPrevPagebtn_Click;
            // 
            // outstandingLastPagebtn
            // 
            outstandingLastPagebtn.BackColor = SystemColors.Menu;
            outstandingLastPagebtn.BackColor2 = Color.White;
            outstandingLastPagebtn.BorderColor = Color.White;
            outstandingLastPagebtn.BorderSize = 2;
            outstandingLastPagebtn.ButtonBorderColor = Color.Gray;
            outstandingLastPagebtn.ButtonHighlightColor = Color.Empty;
            outstandingLastPagebtn.ButtonHighlightColor2 = Color.Empty;
            outstandingLastPagebtn.ButtonHighlightForeColor = Color.Black;
            outstandingLastPagebtn.ButtonPressedColor = Color.White;
            outstandingLastPagebtn.ButtonPressedColor2 = Color.Empty;
            outstandingLastPagebtn.ButtonPressedForeColor = Color.Gray;
            outstandingLastPagebtn.ButtonRoundRadius = 30;
            outstandingLastPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingLastPagebtn.ForeColor = Color.Black;
            outstandingLastPagebtn.Location = new Point(403, 7);
            outstandingLastPagebtn.Name = "outstandingLastPagebtn";
            outstandingLastPagebtn.Size = new Size(70, 37);
            outstandingLastPagebtn.TabIndex = 34;
            outstandingLastPagebtn.Text = "Last";
            outstandingLastPagebtn.Click += outstandingLastPagebtn_Click;
            // 
            // outstandingNextPagebtn
            // 
            outstandingNextPagebtn.BackColor = SystemColors.Menu;
            outstandingNextPagebtn.BackColor2 = Color.White;
            outstandingNextPagebtn.BorderColor = Color.Tomato;
            outstandingNextPagebtn.BorderSize = 2;
            outstandingNextPagebtn.ButtonBorderColor = Color.Gray;
            outstandingNextPagebtn.ButtonHighlightColor = Color.Empty;
            outstandingNextPagebtn.ButtonHighlightColor2 = Color.Empty;
            outstandingNextPagebtn.ButtonHighlightForeColor = Color.Black;
            outstandingNextPagebtn.ButtonPressedColor = Color.White;
            outstandingNextPagebtn.ButtonPressedColor2 = Color.Empty;
            outstandingNextPagebtn.ButtonPressedForeColor = Color.Gray;
            outstandingNextPagebtn.ButtonRoundRadius = 30;
            outstandingNextPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingNextPagebtn.ForeColor = Color.Black;
            outstandingNextPagebtn.Location = new Point(319, 7);
            outstandingNextPagebtn.Name = "outstandingNextPagebtn";
            outstandingNextPagebtn.Size = new Size(71, 37);
            outstandingNextPagebtn.TabIndex = 32;
            outstandingNextPagebtn.Text = "Next";
            outstandingNextPagebtn.Click += outstandingNextPagebtn_Click;
            // 
            // oustandingPagelbl
            // 
            oustandingPagelbl.AutoSize = true;
            oustandingPagelbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oustandingPagelbl.Location = new Point(207, 15);
            oustandingPagelbl.Name = "oustandingPagelbl";
            oustandingPagelbl.Size = new Size(79, 20);
            oustandingPagelbl.TabIndex = 3;
            oustandingPagelbl.Text = "LabelData";
            // 
            // panel21
            // 
            panel21.Controls.Add(groupBox4);
            panel21.Location = new Point(32, 49);
            panel21.Margin = new Padding(3, 2, 3, 2);
            panel21.Name = "panel21";
            panel21.Size = new Size(1047, 177);
            panel21.TabIndex = 37;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(outstandingDeletebtn);
            groupBox4.Controls.Add(outstandingSearchbox);
            groupBox4.Controls.Add(label31);
            groupBox4.Controls.Add(outstandingViewbtn);
            groupBox4.Controls.Add(outstandingdateTimePicker2);
            groupBox4.Controls.Add(outstandingdateTimePicker1);
            groupBox4.Controls.Add(outstandingClearBtn);
            groupBox4.Controls.Add(label32);
            groupBox4.Controls.Add(outstandingSearchbtn);
            groupBox4.Location = new Point(12, 13);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(1021, 153);
            groupBox4.TabIndex = 32;
            groupBox4.TabStop = false;
            // 
            // outstandingDeletebtn
            // 
            outstandingDeletebtn.BackColor = SystemColors.Menu;
            outstandingDeletebtn.BackColor2 = Color.White;
            outstandingDeletebtn.BorderColor = Color.White;
            outstandingDeletebtn.BorderSize = 2;
            outstandingDeletebtn.ButtonBorderColor = Color.Gray;
            outstandingDeletebtn.ButtonHighlightColor = Color.Empty;
            outstandingDeletebtn.ButtonHighlightColor2 = Color.Empty;
            outstandingDeletebtn.ButtonHighlightForeColor = Color.Black;
            outstandingDeletebtn.ButtonPressedColor = Color.White;
            outstandingDeletebtn.ButtonPressedColor2 = Color.Empty;
            outstandingDeletebtn.ButtonPressedForeColor = Color.Gray;
            outstandingDeletebtn.ButtonRoundRadius = 30;
            outstandingDeletebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingDeletebtn.ForeColor = Color.Black;
            outstandingDeletebtn.Location = new Point(337, 114);
            outstandingDeletebtn.Margin = new Padding(3, 2, 3, 2);
            outstandingDeletebtn.Name = "outstandingDeletebtn";
            outstandingDeletebtn.Size = new Size(128, 38);
            outstandingDeletebtn.TabIndex = 32;
            outstandingDeletebtn.Text = "Delete";
            // 
            // outstandingSearchbox
            // 
            outstandingSearchbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outstandingSearchbox.Location = new Point(567, 110);
            outstandingSearchbox.Margin = new Padding(3, 4, 3, 4);
            outstandingSearchbox.Multiline = true;
            outstandingSearchbox.Name = "outstandingSearchbox";
            outstandingSearchbox.PlaceholderText = "    Search";
            outstandingSearchbox.Size = new Size(446, 32);
            outstandingSearchbox.TabIndex = 31;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.Location = new Point(13, 17);
            label31.Name = "label31";
            label31.Size = new Size(55, 25);
            label31.TabIndex = 10;
            label31.Text = "From";
            // 
            // outstandingViewbtn
            // 
            outstandingViewbtn.BackColor2 = Color.White;
            outstandingViewbtn.BorderColor = Color.Gray;
            outstandingViewbtn.BorderSize = 2;
            outstandingViewbtn.ButtonBorderColor = Color.Gray;
            outstandingViewbtn.ButtonHighlightColor = Color.Empty;
            outstandingViewbtn.ButtonHighlightColor2 = Color.Empty;
            outstandingViewbtn.ButtonHighlightForeColor = Color.Black;
            outstandingViewbtn.ButtonPressedColor = Color.Empty;
            outstandingViewbtn.ButtonPressedColor2 = Color.Empty;
            outstandingViewbtn.ButtonPressedForeColor = Color.White;
            outstandingViewbtn.ButtonRoundRadius = 30;
            outstandingViewbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingViewbtn.ForeColor = Color.Black;
            outstandingViewbtn.Location = new Point(10, 114);
            outstandingViewbtn.Margin = new Padding(3, 2, 3, 2);
            outstandingViewbtn.Name = "outstandingViewbtn";
            outstandingViewbtn.Size = new Size(124, 37);
            outstandingViewbtn.TabIndex = 17;
            outstandingViewbtn.Text = "View";
            outstandingViewbtn.Click += outstandingViewbtn_Click;
            // 
            // outstandingdateTimePicker2
            // 
            outstandingdateTimePicker2.Location = new Point(270, 53);
            outstandingdateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            outstandingdateTimePicker2.Name = "outstandingdateTimePicker2";
            outstandingdateTimePicker2.Size = new Size(239, 23);
            outstandingdateTimePicker2.TabIndex = 9;
            // 
            // outstandingdateTimePicker1
            // 
            outstandingdateTimePicker1.Location = new Point(13, 53);
            outstandingdateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            outstandingdateTimePicker1.Name = "outstandingdateTimePicker1";
            outstandingdateTimePicker1.Size = new Size(237, 23);
            outstandingdateTimePicker1.TabIndex = 8;
            outstandingdateTimePicker1.ValueChanged += outstandingdateTimePicker1_ValueChanged;
            // 
            // outstandingClearBtn
            // 
            outstandingClearBtn.BackColor = SystemColors.Menu;
            outstandingClearBtn.BackColor2 = Color.White;
            outstandingClearBtn.BorderColor = Color.White;
            outstandingClearBtn.BorderSize = 2;
            outstandingClearBtn.ButtonBorderColor = Color.Gray;
            outstandingClearBtn.ButtonHighlightColor = Color.Empty;
            outstandingClearBtn.ButtonHighlightColor2 = Color.Empty;
            outstandingClearBtn.ButtonHighlightForeColor = Color.Black;
            outstandingClearBtn.ButtonPressedColor = Color.White;
            outstandingClearBtn.ButtonPressedColor2 = Color.Empty;
            outstandingClearBtn.ButtonPressedForeColor = Color.Gray;
            outstandingClearBtn.ButtonRoundRadius = 30;
            outstandingClearBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingClearBtn.ForeColor = Color.Black;
            outstandingClearBtn.Location = new Point(170, 113);
            outstandingClearBtn.Margin = new Padding(3, 2, 3, 2);
            outstandingClearBtn.Name = "outstandingClearBtn";
            outstandingClearBtn.Size = new Size(128, 38);
            outstandingClearBtn.TabIndex = 15;
            outstandingClearBtn.Text = "Clear";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label32.Location = new Point(267, 17);
            label32.Name = "label32";
            label32.Size = new Size(31, 25);
            label32.TabIndex = 11;
            label32.Text = "To";
            // 
            // outstandingSearchbtn
            // 
            outstandingSearchbtn.BackColor = SystemColors.Menu;
            outstandingSearchbtn.BackColor2 = Color.White;
            outstandingSearchbtn.BorderColor = Color.White;
            outstandingSearchbtn.BorderSize = 2;
            outstandingSearchbtn.ButtonBorderColor = Color.Gray;
            outstandingSearchbtn.ButtonHighlightColor = Color.Empty;
            outstandingSearchbtn.ButtonHighlightColor2 = Color.Empty;
            outstandingSearchbtn.ButtonHighlightForeColor = Color.Black;
            outstandingSearchbtn.ButtonPressedColor = Color.White;
            outstandingSearchbtn.ButtonPressedColor2 = Color.Empty;
            outstandingSearchbtn.ButtonPressedForeColor = Color.Gray;
            outstandingSearchbtn.ButtonRoundRadius = 30;
            outstandingSearchbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingSearchbtn.ForeColor = Color.Black;
            outstandingSearchbtn.Location = new Point(556, 45);
            outstandingSearchbtn.Margin = new Padding(3, 2, 3, 2);
            outstandingSearchbtn.Name = "outstandingSearchbtn";
            outstandingSearchbtn.Size = new Size(121, 41);
            outstandingSearchbtn.TabIndex = 25;
            outstandingSearchbtn.Text = "Filter";
            outstandingSearchbtn.Click += outstandingSearchbtn_Click;
            // 
            // outstandingdata
            // 
            outstandingdata.AllowUserToAddRows = false;
            outstandingdata.AllowUserToDeleteRows = false;
            outstandingdata.AllowUserToResizeRows = false;
            dataGridViewCellStyle210.BackColor = Color.Gainsboro;
            outstandingdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle210;
            outstandingdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle211.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle211.BackColor = SystemColors.Control;
            dataGridViewCellStyle211.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle211.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle211.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle211.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle211.WrapMode = DataGridViewTriState.True;
            outstandingdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle211;
            outstandingdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            outstandingdata.Columns.AddRange(new DataGridViewColumn[] { outstandingcheckColumn });
            dataGridViewCellStyle212.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle212.BackColor = SystemColors.Window;
            dataGridViewCellStyle212.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle212.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle212.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle212.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle212.WrapMode = DataGridViewTriState.False;
            outstandingdata.DefaultCellStyle = dataGridViewCellStyle212;
            outstandingdata.Location = new Point(37, 241);
            outstandingdata.Margin = new Padding(3, 2, 3, 2);
            outstandingdata.Name = "outstandingdata";
            dataGridViewCellStyle213.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle213.BackColor = SystemColors.Control;
            dataGridViewCellStyle213.Font = new Font("Segoe UI Semibold", 10.2F);
            dataGridViewCellStyle213.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle213.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle213.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle213.WrapMode = DataGridViewTriState.True;
            outstandingdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle213;
            outstandingdata.RowHeadersVisible = false;
            outstandingdata.RowHeadersWidth = 51;
            outstandingdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            outstandingdata.Size = new Size(1040, 453);
            outstandingdata.TabIndex = 35;
            outstandingdata.CellClick += outstandingdata_CellClick;
            outstandingdata.CellContentClick += outstandingdata_CellContentClick;
            // 
            // outstandingOrderlbl
            // 
            outstandingOrderlbl.AutoSize = true;
            outstandingOrderlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            outstandingOrderlbl.Location = new Point(31, 8);
            outstandingOrderlbl.Name = "outstandingOrderlbl";
            outstandingOrderlbl.Size = new Size(180, 25);
            outstandingOrderlbl.TabIndex = 0;
            outstandingOrderlbl.Text = "Outstanding Order";
            // 
            // dateTimePicker8
            // 
            dateTimePicker8.Location = new Point(0, 0);
            dateTimePicker8.Name = "dateTimePicker8";
            dateTimePicker8.Size = new Size(200, 23);
            dateTimePicker8.TabIndex = 0;
            // 
            // customDataGridView4
            // 
            customDataGridView4.ColumnHeadersHeight = 29;
            customDataGridView4.Location = new Point(0, 0);
            customDataGridView4.Name = "customDataGridView4";
            customDataGridView4.RowHeadersWidth = 51;
            customDataGridView4.Size = new Size(240, 150);
            customDataGridView4.TabIndex = 0;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            dataGridViewCheckBoxColumn4.MinimumWidth = 6;
            dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            dataGridViewCheckBoxColumn4.Width = 125;
            // 
            // button24
            // 
            button24.Location = new Point(0, 0);
            button24.Name = "button24";
            button24.Size = new Size(75, 23);
            button24.TabIndex = 0;
            // 
            // invoicepnl
            // 
            invoicepnl.Controls.Add(panel14);
            invoicepnl.Controls.Add(panel15);
            invoicepnl.Controls.Add(invoiceData);
            invoicepnl.Controls.Add(invoicelbl);
            invoicepnl.Location = new Point(176, 2);
            invoicepnl.Margin = new Padding(3, 2, 3, 2);
            invoicepnl.Name = "invoicepnl";
            invoicepnl.Size = new Size(1094, 788);
            invoicepnl.TabIndex = 33;
            invoicepnl.MouseDown += Dashboard_MouseDown;
            invoicepnl.MouseMove += Dashboard_MouseMove;
            invoicepnl.MouseUp += Dashboard_MouseUp;
            // 
            // panel14
            // 
            panel14.Controls.Add(invoiceFirstPagebtn);
            panel14.Controls.Add(invoiceIndexlbl);
            panel14.Controls.Add(invoicePrevPagebtn);
            panel14.Controls.Add(invoiceLastPagebtn);
            panel14.Controls.Add(invoiceNextPagebtn);
            panel14.Location = new Point(574, 699);
            panel14.Name = "panel14";
            panel14.Size = new Size(495, 50);
            panel14.TabIndex = 38;
            // 
            // invoiceFirstPagebtn
            // 
            invoiceFirstPagebtn.BackColor = SystemColors.Menu;
            invoiceFirstPagebtn.BackColor2 = Color.White;
            invoiceFirstPagebtn.BorderColor = Color.Tomato;
            invoiceFirstPagebtn.BorderSize = 2;
            invoiceFirstPagebtn.ButtonBorderColor = Color.Gray;
            invoiceFirstPagebtn.ButtonHighlightColor = Color.Empty;
            invoiceFirstPagebtn.ButtonHighlightColor2 = Color.Empty;
            invoiceFirstPagebtn.ButtonHighlightForeColor = Color.Black;
            invoiceFirstPagebtn.ButtonPressedColor = Color.White;
            invoiceFirstPagebtn.ButtonPressedColor2 = Color.Empty;
            invoiceFirstPagebtn.ButtonPressedForeColor = Color.Gray;
            invoiceFirstPagebtn.ButtonRoundRadius = 30;
            invoiceFirstPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceFirstPagebtn.ForeColor = Color.Black;
            invoiceFirstPagebtn.Location = new Point(60, 7);
            invoiceFirstPagebtn.Name = "invoiceFirstPagebtn";
            invoiceFirstPagebtn.Size = new Size(70, 38);
            invoiceFirstPagebtn.TabIndex = 31;
            invoiceFirstPagebtn.Text = "First";
            invoiceFirstPagebtn.Click += invoiceFirstPagebtn_Click;
            // 
            // invoiceIndexlbl
            // 
            invoiceIndexlbl.AutoSize = true;
            invoiceIndexlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceIndexlbl.Location = new Point(220, 16);
            invoiceIndexlbl.Name = "invoiceIndexlbl";
            invoiceIndexlbl.Size = new Size(79, 20);
            invoiceIndexlbl.TabIndex = 3;
            invoiceIndexlbl.Text = "LabelData";
            // 
            // invoicePrevPagebtn
            // 
            invoicePrevPagebtn.AccessibleRole = AccessibleRole.None;
            invoicePrevPagebtn.BackColor = SystemColors.Menu;
            invoicePrevPagebtn.BackColor2 = Color.White;
            invoicePrevPagebtn.BorderColor = Color.Tomato;
            invoicePrevPagebtn.BorderSize = 2;
            invoicePrevPagebtn.ButtonBorderColor = Color.Gray;
            invoicePrevPagebtn.ButtonHighlightColor = Color.Empty;
            invoicePrevPagebtn.ButtonHighlightColor2 = Color.Empty;
            invoicePrevPagebtn.ButtonHighlightForeColor = Color.Black;
            invoicePrevPagebtn.ButtonPressedColor = Color.White;
            invoicePrevPagebtn.ButtonPressedColor2 = Color.Empty;
            invoicePrevPagebtn.ButtonPressedForeColor = Color.Gray;
            invoicePrevPagebtn.ButtonRoundRadius = 30;
            invoicePrevPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoicePrevPagebtn.ForeColor = Color.Black;
            invoicePrevPagebtn.Location = new Point(142, 7);
            invoicePrevPagebtn.Name = "invoicePrevPagebtn";
            invoicePrevPagebtn.Size = new Size(67, 38);
            invoicePrevPagebtn.TabIndex = 33;
            invoicePrevPagebtn.Text = "Prev";
            invoicePrevPagebtn.Click += invoicePrevPagebtn_Click;
            // 
            // invoiceLastPagebtn
            // 
            invoiceLastPagebtn.BackColor = SystemColors.Menu;
            invoiceLastPagebtn.BackColor2 = Color.White;
            invoiceLastPagebtn.BorderColor = Color.White;
            invoiceLastPagebtn.BorderSize = 2;
            invoiceLastPagebtn.ButtonBorderColor = Color.Gray;
            invoiceLastPagebtn.ButtonHighlightColor = Color.Empty;
            invoiceLastPagebtn.ButtonHighlightColor2 = Color.Empty;
            invoiceLastPagebtn.ButtonHighlightForeColor = Color.Black;
            invoiceLastPagebtn.ButtonPressedColor = Color.White;
            invoiceLastPagebtn.ButtonPressedColor2 = Color.Empty;
            invoiceLastPagebtn.ButtonPressedForeColor = Color.Gray;
            invoiceLastPagebtn.ButtonRoundRadius = 30;
            invoiceLastPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceLastPagebtn.ForeColor = Color.Black;
            invoiceLastPagebtn.Location = new Point(397, 7);
            invoiceLastPagebtn.Name = "invoiceLastPagebtn";
            invoiceLastPagebtn.Size = new Size(64, 37);
            invoiceLastPagebtn.TabIndex = 34;
            invoiceLastPagebtn.Text = "Last";
            invoiceLastPagebtn.Click += invoiceLastPagebtn_Click;
            // 
            // invoiceNextPagebtn
            // 
            invoiceNextPagebtn.BackColor = SystemColors.Menu;
            invoiceNextPagebtn.BackColor2 = Color.White;
            invoiceNextPagebtn.BorderColor = Color.Tomato;
            invoiceNextPagebtn.BorderSize = 2;
            invoiceNextPagebtn.ButtonBorderColor = Color.Gray;
            invoiceNextPagebtn.ButtonHighlightColor = Color.Empty;
            invoiceNextPagebtn.ButtonHighlightColor2 = Color.Empty;
            invoiceNextPagebtn.ButtonHighlightForeColor = Color.Black;
            invoiceNextPagebtn.ButtonPressedColor = Color.White;
            invoiceNextPagebtn.ButtonPressedColor2 = Color.Empty;
            invoiceNextPagebtn.ButtonPressedForeColor = Color.Gray;
            invoiceNextPagebtn.ButtonRoundRadius = 30;
            invoiceNextPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceNextPagebtn.ForeColor = Color.Black;
            invoiceNextPagebtn.Location = new Point(310, 7);
            invoiceNextPagebtn.Name = "invoiceNextPagebtn";
            invoiceNextPagebtn.Size = new Size(71, 37);
            invoiceNextPagebtn.TabIndex = 32;
            invoiceNextPagebtn.Text = "Next";
            invoiceNextPagebtn.Click += invoiceNextPagebtn_Click;
            // 
            // panel15
            // 
            panel15.Controls.Add(invoiceCompleteBtn);
            panel15.Controls.Add(roundedTextBox1);
            panel15.Controls.Add(invoiceViewBtn);
            panel15.Controls.Add(InvoicedateTimePicker1);
            panel15.Controls.Add(label22);
            panel15.Controls.Add(invoiceSearchBtn);
            panel15.Controls.Add(label23);
            panel15.Controls.Add(invoiceClearBtn);
            panel15.Controls.Add(invoicedateTimePicker2);
            panel15.Location = new Point(32, 66);
            panel15.Margin = new Padding(3, 2, 3, 2);
            panel15.Name = "panel15";
            panel15.Size = new Size(1026, 147);
            panel15.TabIndex = 37;
            // 
            // invoiceCompleteBtn
            // 
            invoiceCompleteBtn.BackColor = SystemColors.Menu;
            invoiceCompleteBtn.BackColor2 = Color.White;
            invoiceCompleteBtn.BorderColor = Color.White;
            invoiceCompleteBtn.BorderSize = 2;
            invoiceCompleteBtn.ButtonBorderColor = Color.Gray;
            invoiceCompleteBtn.ButtonHighlightColor = Color.Empty;
            invoiceCompleteBtn.ButtonHighlightColor2 = Color.Empty;
            invoiceCompleteBtn.ButtonHighlightForeColor = Color.Black;
            invoiceCompleteBtn.ButtonPressedColor = Color.White;
            invoiceCompleteBtn.ButtonPressedColor2 = Color.Empty;
            invoiceCompleteBtn.ButtonPressedForeColor = Color.Gray;
            invoiceCompleteBtn.ButtonRoundRadius = 30;
            invoiceCompleteBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceCompleteBtn.ForeColor = Color.Black;
            invoiceCompleteBtn.Location = new Point(162, 104);
            invoiceCompleteBtn.Margin = new Padding(3, 2, 3, 2);
            invoiceCompleteBtn.Name = "invoiceCompleteBtn";
            invoiceCompleteBtn.Size = new Size(125, 38);
            invoiceCompleteBtn.TabIndex = 32;
            invoiceCompleteBtn.Text = "Complete";
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox1.Location = new Point(575, 104);
            roundedTextBox1.Margin = new Padding(3, 4, 3, 4);
            roundedTextBox1.Multiline = true;
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.PlaceholderText = "    Search";
            roundedTextBox1.Size = new Size(446, 32);
            roundedTextBox1.TabIndex = 31;
            // 
            // invoiceViewBtn
            // 
            invoiceViewBtn.BackColor = SystemColors.Menu;
            invoiceViewBtn.BackColor2 = Color.White;
            invoiceViewBtn.BorderColor = Color.White;
            invoiceViewBtn.BorderSize = 2;
            invoiceViewBtn.ButtonBorderColor = Color.Gray;
            invoiceViewBtn.ButtonHighlightColor = Color.Empty;
            invoiceViewBtn.ButtonHighlightColor2 = Color.Empty;
            invoiceViewBtn.ButtonHighlightForeColor = Color.Black;
            invoiceViewBtn.ButtonPressedColor = Color.White;
            invoiceViewBtn.ButtonPressedColor2 = Color.Empty;
            invoiceViewBtn.ButtonPressedForeColor = Color.Gray;
            invoiceViewBtn.ButtonRoundRadius = 30;
            invoiceViewBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceViewBtn.ForeColor = Color.Black;
            invoiceViewBtn.Location = new Point(21, 104);
            invoiceViewBtn.Margin = new Padding(3, 2, 3, 2);
            invoiceViewBtn.Name = "invoiceViewBtn";
            invoiceViewBtn.Size = new Size(127, 40);
            invoiceViewBtn.TabIndex = 17;
            invoiceViewBtn.Text = "View";
            invoiceViewBtn.Click += invoiceViewBtn_Click;
            // 
            // InvoicedateTimePicker1
            // 
            InvoicedateTimePicker1.Location = new Point(21, 48);
            InvoicedateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            InvoicedateTimePicker1.Name = "InvoicedateTimePicker1";
            InvoicedateTimePicker1.Size = new Size(212, 23);
            InvoicedateTimePicker1.TabIndex = 8;
            InvoicedateTimePicker1.ValueChanged += InvoicedateTimePicker1_ValueChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(21, 12);
            label22.Name = "label22";
            label22.Size = new Size(55, 25);
            label22.TabIndex = 10;
            label22.Text = "From";
            // 
            // invoiceSearchBtn
            // 
            invoiceSearchBtn.BackColor = SystemColors.Menu;
            invoiceSearchBtn.BackColor2 = Color.White;
            invoiceSearchBtn.BorderColor = Color.White;
            invoiceSearchBtn.BorderSize = 2;
            invoiceSearchBtn.ButtonBorderColor = Color.Gray;
            invoiceSearchBtn.ButtonHighlightColor = Color.Empty;
            invoiceSearchBtn.ButtonHighlightColor2 = Color.Empty;
            invoiceSearchBtn.ButtonHighlightForeColor = Color.Black;
            invoiceSearchBtn.ButtonPressedColor = Color.White;
            invoiceSearchBtn.ButtonPressedColor2 = Color.Empty;
            invoiceSearchBtn.ButtonPressedForeColor = Color.Gray;
            invoiceSearchBtn.ButtonRoundRadius = 30;
            invoiceSearchBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceSearchBtn.ForeColor = Color.Black;
            invoiceSearchBtn.Location = new Point(520, 40);
            invoiceSearchBtn.Margin = new Padding(3, 2, 3, 2);
            invoiceSearchBtn.Name = "invoiceSearchBtn";
            invoiceSearchBtn.Size = new Size(126, 37);
            invoiceSearchBtn.TabIndex = 25;
            invoiceSearchBtn.Text = "Filter";
            invoiceSearchBtn.Click += invoiceSearchBtn_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(275, 12);
            label23.Name = "label23";
            label23.Size = new Size(31, 25);
            label23.TabIndex = 11;
            label23.Text = "To";
            // 
            // invoiceClearBtn
            // 
            invoiceClearBtn.BackColor = SystemColors.Menu;
            invoiceClearBtn.BackColor2 = Color.White;
            invoiceClearBtn.BorderColor = Color.White;
            invoiceClearBtn.BorderSize = 2;
            invoiceClearBtn.ButtonBorderColor = Color.Gray;
            invoiceClearBtn.ButtonHighlightColor = Color.Empty;
            invoiceClearBtn.ButtonHighlightColor2 = Color.Empty;
            invoiceClearBtn.ButtonHighlightForeColor = Color.Black;
            invoiceClearBtn.ButtonPressedColor = Color.White;
            invoiceClearBtn.ButtonPressedColor2 = Color.Empty;
            invoiceClearBtn.ButtonPressedForeColor = Color.Gray;
            invoiceClearBtn.ButtonRoundRadius = 30;
            invoiceClearBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceClearBtn.ForeColor = Color.Black;
            invoiceClearBtn.Location = new Point(428, 100);
            invoiceClearBtn.Margin = new Padding(3, 2, 3, 2);
            invoiceClearBtn.Name = "invoiceClearBtn";
            invoiceClearBtn.Size = new Size(124, 38);
            invoiceClearBtn.TabIndex = 15;
            invoiceClearBtn.Text = "Clear";
            // 
            // invoicedateTimePicker2
            // 
            invoicedateTimePicker2.Location = new Point(278, 48);
            invoicedateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            invoicedateTimePicker2.Name = "invoicedateTimePicker2";
            invoicedateTimePicker2.Size = new Size(220, 23);
            invoicedateTimePicker2.TabIndex = 9;
            // 
            // invoiceData
            // 
            invoiceData.AllowUserToAddRows = false;
            invoiceData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle214.BackColor = Color.Gainsboro;
            invoiceData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle214;
            invoiceData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle215.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle215.BackColor = SystemColors.Control;
            dataGridViewCellStyle215.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle215.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle215.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle215.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle215.WrapMode = DataGridViewTriState.True;
            invoiceData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle215;
            invoiceData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invoiceData.Columns.AddRange(new DataGridViewColumn[] { invoicecheckbox });
            dataGridViewCellStyle216.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle216.BackColor = SystemColors.Window;
            dataGridViewCellStyle216.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle216.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle216.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle216.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle216.WrapMode = DataGridViewTriState.False;
            invoiceData.DefaultCellStyle = dataGridViewCellStyle216;
            invoiceData.Location = new Point(27, 219);
            invoiceData.Margin = new Padding(3, 2, 3, 2);
            invoiceData.Name = "invoiceData";
            dataGridViewCellStyle217.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle217.BackColor = SystemColors.Control;
            dataGridViewCellStyle217.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle217.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle217.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle217.WrapMode = DataGridViewTriState.True;
            invoiceData.RowHeadersDefaultCellStyle = dataGridViewCellStyle217;
            invoiceData.RowHeadersVisible = false;
            invoiceData.RowHeadersWidth = 51;
            invoiceData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            invoiceData.Size = new Size(1040, 461);
            invoiceData.TabIndex = 35;
            invoiceData.CellClick += invoiceData_CellClick;
            // 
            // invoicecheckbox
            // 
            invoicecheckbox.FillWeight = 35F;
            invoicecheckbox.HeaderText = "Select";
            invoicecheckbox.MinimumWidth = 35;
            invoicecheckbox.Name = "invoicecheckbox";
            // 
            // invoicelbl
            // 
            invoicelbl.AutoSize = true;
            invoicelbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            invoicelbl.Location = new Point(31, 7);
            invoicelbl.Name = "invoicelbl";
            invoicelbl.Size = new Size(76, 25);
            invoicelbl.TabIndex = 0;
            invoicelbl.Text = "Invoice";
            // 
            // outstandingViewpnl
            // 
            outstandingViewpnl.Controls.Add(panel43);
            outstandingViewpnl.Controls.Add(panel44);
            outstandingViewpnl.Location = new Point(184, 11);
            outstandingViewpnl.Name = "outstandingViewpnl";
            outstandingViewpnl.Size = new Size(1066, 725);
            outstandingViewpnl.TabIndex = 39;
            outstandingViewpnl.Visible = false;
            // 
            // panel45
            // 
            panel45.Location = new Point(0, 0);
            panel45.Name = "panel45";
            panel45.Size = new Size(200, 100);
            panel45.TabIndex = 0;
            // 
            // StockReportpnl
            // 
            StockReportpnl.Controls.Add(reportStockPie);
            StockReportpnl.Controls.Add(StockStockReportButton);
            StockReportpnl.Controls.Add(OrderStockReportButton);
            StockReportpnl.Controls.Add(panel46);
            StockReportpnl.Controls.Add(label44);
            StockReportpnl.Controls.Add(panel47);
            StockReportpnl.Controls.Add(panel48);
            StockReportpnl.Controls.Add(chart2);
            StockReportpnl.Controls.Add(panel49);
            StockReportpnl.Controls.Add(panel50);
            StockReportpnl.Controls.Add(PDFStockReportButton);
            StockReportpnl.Controls.Add(panel51);
            StockReportpnl.Controls.Add(reportStockdata);
            StockReportpnl.Controls.Add(CSVStockReportButton);
            StockReportpnl.Controls.Add(label55);
            StockReportpnl.Location = new Point(175, 3);
            StockReportpnl.Name = "StockReportpnl";
            StockReportpnl.Size = new Size(1094, 788);
            StockReportpnl.TabIndex = 82;
            StockReportpnl.Visible = false;
            StockReportpnl.MouseDown += Dashboard_MouseDown;
            StockReportpnl.MouseMove += Dashboard_MouseMove;
            StockReportpnl.MouseUp += Dashboard_MouseUp;
            // 
            // reportStockPie
            // 
            chartArea19.Name = "ChartArea1";
            reportStockPie.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            reportStockPie.Legends.Add(legend19);
            reportStockPie.Location = new Point(556, 302);
            reportStockPie.Name = "reportStockPie";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series19.Font = new Font("Microsoft YaHei", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            series19.IsXValueIndexed = true;
            series19.Legend = "Legend1";
            series19.Name = "Stock";
            reportStockPie.Series.Add(series19);
            reportStockPie.Size = new Size(435, 249);
            reportStockPie.TabIndex = 82;
            reportStockPie.Text = "dashordervalueChart";
            // 
            // StockStockReportButton
            // 
            StockStockReportButton.BackColor = SystemColors.Menu;
            StockStockReportButton.BackColor2 = Color.White;
            StockStockReportButton.BorderColor = Color.White;
            StockStockReportButton.BorderSize = 2;
            StockStockReportButton.ButtonBorderColor = Color.Gray;
            StockStockReportButton.ButtonHighlightColor = Color.Empty;
            StockStockReportButton.ButtonHighlightColor2 = Color.Empty;
            StockStockReportButton.ButtonHighlightForeColor = Color.Black;
            StockStockReportButton.ButtonPressedColor = Color.White;
            StockStockReportButton.ButtonPressedColor2 = Color.Empty;
            StockStockReportButton.ButtonPressedForeColor = Color.Gray;
            StockStockReportButton.ButtonRoundRadius = 30;
            StockStockReportButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StockStockReportButton.ForeColor = Color.Black;
            StockStockReportButton.Location = new Point(359, 10);
            StockStockReportButton.Margin = new Padding(3, 2, 3, 2);
            StockStockReportButton.Name = "StockStockReportButton";
            StockStockReportButton.Size = new Size(141, 42);
            StockStockReportButton.TabIndex = 81;
            StockStockReportButton.Text = "Stock";
            // 
            // OrderStockReportButton
            // 
            OrderStockReportButton.BackColor = SystemColors.Menu;
            OrderStockReportButton.BackColor2 = Color.White;
            OrderStockReportButton.BorderColor = Color.White;
            OrderStockReportButton.BorderSize = 2;
            OrderStockReportButton.ButtonBorderColor = Color.Gray;
            OrderStockReportButton.ButtonHighlightColor = Color.Empty;
            OrderStockReportButton.ButtonHighlightColor2 = Color.Empty;
            OrderStockReportButton.ButtonHighlightForeColor = Color.Black;
            OrderStockReportButton.ButtonPressedColor = Color.White;
            OrderStockReportButton.ButtonPressedColor2 = Color.Empty;
            OrderStockReportButton.ButtonPressedForeColor = Color.Gray;
            OrderStockReportButton.ButtonRoundRadius = 30;
            OrderStockReportButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderStockReportButton.ForeColor = Color.Black;
            OrderStockReportButton.Location = new Point(178, 8);
            OrderStockReportButton.Margin = new Padding(3, 2, 3, 2);
            OrderStockReportButton.Name = "OrderStockReportButton";
            OrderStockReportButton.Size = new Size(141, 42);
            OrderStockReportButton.TabIndex = 80;
            OrderStockReportButton.Text = "Order";
            // 
            // panel46
            // 
            panel46.BackColor = SystemColors.ControlDark;
            panel46.BorderStyle = BorderStyle.Fixed3D;
            panel46.ForeColor = SystemColors.ControlText;
            panel46.Location = new Point(48, 557);
            panel46.Name = "panel46";
            panel46.Size = new Size(940, 5);
            panel46.TabIndex = 79;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label44.Location = new Point(16, 559);
            label44.Name = "label44";
            label44.Size = new Size(195, 24);
            label44.TabIndex = 78;
            label44.Text = "Top Selling Product";
            // 
            // panel47
            // 
            panel47.BorderStyle = BorderStyle.FixedSingle;
            panel47.Controls.Add(label45);
            panel47.Controls.Add(label46);
            panel47.Location = new Point(793, 62);
            panel47.Name = "panel47";
            panel47.Size = new Size(218, 89);
            panel47.TabIndex = 48;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label45.Location = new Point(27, 63);
            label45.Name = "label45";
            label45.Size = new Size(52, 17);
            label45.TabIndex = 18;
            label45.Text = "label45";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label46.Location = new Point(2, 8);
            label46.Name = "label46";
            label46.Size = new Size(195, 24);
            label46.TabIndex = 12;
            label46.Text = "Monthly Total Order";
            // 
            // panel48
            // 
            panel48.BorderStyle = BorderStyle.FixedSingle;
            panel48.Controls.Add(label47);
            panel48.Controls.Add(label48);
            panel48.Location = new Point(532, 62);
            panel48.Name = "panel48";
            panel48.Size = new Size(224, 89);
            panel48.TabIndex = 46;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label47.Location = new Point(34, 63);
            label47.Name = "label47";
            label47.Size = new Size(52, 17);
            label47.TabIndex = 17;
            label47.Text = "label47";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label48.Location = new Point(14, 11);
            label48.Name = "label48";
            label48.Size = new Size(192, 24);
            label48.TabIndex = 12;
            label48.Text = "Monthly Total Sales";
            // 
            // chart2
            // 
            chartArea20.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            chart2.Legends.Add(legend20);
            chart2.Location = new Point(48, 286);
            chart2.Margin = new Padding(3, 4, 3, 4);
            chart2.Name = "chart2";
            series20.ChartArea = "ChartArea1";
            series20.IsXValueIndexed = true;
            series20.Legend = "Legend1";
            series20.Name = "Order";
            chart2.Series.Add(series20);
            chart2.Size = new Size(454, 246);
            chart2.TabIndex = 76;
            chart2.Text = "chart1";
            title12.Alignment = ContentAlignment.TopLeft;
            title12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title12.Name = "Sales Overview";
            title12.Text = "Order Statistics";
            chart2.Titles.Add(title12);
            // 
            // panel49
            // 
            panel49.BorderStyle = BorderStyle.FixedSingle;
            panel49.Controls.Add(label49);
            panel49.Controls.Add(label50);
            panel49.Location = new Point(299, 62);
            panel49.Name = "panel49";
            panel49.Size = new Size(207, 89);
            panel49.TabIndex = 47;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label49.Location = new Point(32, 63);
            label49.Name = "label49";
            label49.Size = new Size(52, 17);
            label49.TabIndex = 16;
            label49.Text = "label49";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label50.Location = new Point(3, 8);
            label50.Name = "label50";
            label50.Size = new Size(180, 24);
            label50.TabIndex = 12;
            label50.Text = "Today Total Order";
            // 
            // panel50
            // 
            panel50.BorderStyle = BorderStyle.FixedSingle;
            panel50.Controls.Add(label51);
            panel50.Controls.Add(label52);
            panel50.Location = new Point(64, 62);
            panel50.Name = "panel50";
            panel50.Size = new Size(207, 89);
            panel50.TabIndex = 45;
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label51.Location = new Point(31, 63);
            label51.Name = "label51";
            label51.Size = new Size(139, 17);
            label51.TabIndex = 15;
            label51.Text = "TodayTotalSalesValue";
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label52.Location = new Point(5, 10);
            label52.Name = "label52";
            label52.Size = new Size(177, 24);
            label52.TabIndex = 12;
            label52.Text = "Today Total Sales";
            // 
            // PDFStockReportButton
            // 
            PDFStockReportButton.BackColor = SystemColors.Menu;
            PDFStockReportButton.BackColor2 = Color.White;
            PDFStockReportButton.BorderColor = Color.White;
            PDFStockReportButton.BorderSize = 2;
            PDFStockReportButton.ButtonBorderColor = Color.Gray;
            PDFStockReportButton.ButtonHighlightColor = Color.Empty;
            PDFStockReportButton.ButtonHighlightColor2 = Color.Empty;
            PDFStockReportButton.ButtonHighlightForeColor = Color.Black;
            PDFStockReportButton.ButtonPressedColor = Color.White;
            PDFStockReportButton.ButtonPressedColor2 = Color.Empty;
            PDFStockReportButton.ButtonPressedForeColor = Color.Gray;
            PDFStockReportButton.ButtonRoundRadius = 30;
            PDFStockReportButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PDFStockReportButton.ForeColor = Color.Black;
            PDFStockReportButton.Location = new Point(923, 9);
            PDFStockReportButton.Margin = new Padding(3, 2, 3, 2);
            PDFStockReportButton.Name = "PDFStockReportButton";
            PDFStockReportButton.Size = new Size(141, 42);
            PDFStockReportButton.TabIndex = 44;
            PDFStockReportButton.Text = "Download PDF";
            // 
            // panel51
            // 
            panel51.Controls.Add(dateTimePicker7);
            panel51.Controls.Add(label53);
            panel51.Controls.Add(SearchStockReportButton);
            panel51.Controls.Add(label54);
            panel51.Controls.Add(ClearStockReportButton);
            panel51.Controls.Add(dateTimePicker9);
            panel51.Location = new Point(43, 168);
            panel51.Margin = new Padding(3, 2, 3, 2);
            panel51.Name = "panel51";
            panel51.Size = new Size(1011, 108);
            panel51.TabIndex = 42;
            // 
            // dateTimePicker7
            // 
            dateTimePicker7.Location = new Point(21, 48);
            dateTimePicker7.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker7.Name = "dateTimePicker7";
            dateTimePicker7.Size = new Size(212, 23);
            dateTimePicker7.TabIndex = 8;
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label53.Location = new Point(23, 4);
            label53.Name = "label53";
            label53.Size = new Size(55, 25);
            label53.TabIndex = 10;
            label53.Text = "From";
            // 
            // SearchStockReportButton
            // 
            SearchStockReportButton.BackColor = SystemColors.Menu;
            SearchStockReportButton.BackColor2 = Color.White;
            SearchStockReportButton.BorderColor = Color.White;
            SearchStockReportButton.BorderSize = 2;
            SearchStockReportButton.ButtonBorderColor = Color.Gray;
            SearchStockReportButton.ButtonHighlightColor = Color.Empty;
            SearchStockReportButton.ButtonHighlightColor2 = Color.Empty;
            SearchStockReportButton.ButtonHighlightForeColor = Color.Black;
            SearchStockReportButton.ButtonPressedColor = Color.White;
            SearchStockReportButton.ButtonPressedColor2 = Color.Empty;
            SearchStockReportButton.ButtonPressedForeColor = Color.Gray;
            SearchStockReportButton.ButtonRoundRadius = 30;
            SearchStockReportButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchStockReportButton.ForeColor = Color.Black;
            SearchStockReportButton.Location = new Point(525, 41);
            SearchStockReportButton.Margin = new Padding(3, 2, 3, 2);
            SearchStockReportButton.Name = "SearchStockReportButton";
            SearchStockReportButton.Size = new Size(90, 38);
            SearchStockReportButton.TabIndex = 25;
            SearchStockReportButton.Text = "Search";
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label54.Location = new Point(282, 4);
            label54.Name = "label54";
            label54.Size = new Size(31, 25);
            label54.TabIndex = 11;
            label54.Text = "To";
            // 
            // ClearStockReportButton
            // 
            ClearStockReportButton.BackColor = SystemColors.Menu;
            ClearStockReportButton.BackColor2 = Color.White;
            ClearStockReportButton.BorderColor = Color.White;
            ClearStockReportButton.BorderSize = 2;
            ClearStockReportButton.ButtonBorderColor = Color.Gray;
            ClearStockReportButton.ButtonHighlightColor = Color.Empty;
            ClearStockReportButton.ButtonHighlightColor2 = Color.Empty;
            ClearStockReportButton.ButtonHighlightForeColor = Color.Black;
            ClearStockReportButton.ButtonPressedColor = Color.White;
            ClearStockReportButton.ButtonPressedColor2 = Color.Empty;
            ClearStockReportButton.ButtonPressedForeColor = Color.Gray;
            ClearStockReportButton.ButtonRoundRadius = 30;
            ClearStockReportButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearStockReportButton.ForeColor = Color.Black;
            ClearStockReportButton.Location = new Point(647, 41);
            ClearStockReportButton.Margin = new Padding(3, 2, 3, 2);
            ClearStockReportButton.Name = "ClearStockReportButton";
            ClearStockReportButton.Size = new Size(89, 39);
            ClearStockReportButton.TabIndex = 15;
            ClearStockReportButton.Text = "Clear";
            // 
            // dateTimePicker9
            // 
            dateTimePicker9.Location = new Point(278, 48);
            dateTimePicker9.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker9.Name = "dateTimePicker9";
            dateTimePicker9.Size = new Size(220, 23);
            dateTimePicker9.TabIndex = 9;
            // 
            // reportStockdata
            // 
            reportStockdata.AllowUserToAddRows = false;
            reportStockdata.AllowUserToDeleteRows = false;
            dataGridViewCellStyle218.BackColor = Color.Gainsboro;
            reportStockdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle218;
            reportStockdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle219.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle219.BackColor = SystemColors.Control;
            dataGridViewCellStyle219.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle219.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle219.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle219.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle219.WrapMode = DataGridViewTriState.True;
            reportStockdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle219;
            reportStockdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle220.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle220.BackColor = SystemColors.Window;
            dataGridViewCellStyle220.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle220.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle220.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle220.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle220.WrapMode = DataGridViewTriState.False;
            reportStockdata.DefaultCellStyle = dataGridViewCellStyle220;
            reportStockdata.Location = new Point(27, 573);
            reportStockdata.Margin = new Padding(3, 2, 3, 2);
            reportStockdata.Name = "reportStockdata";
            reportStockdata.RowHeadersVisible = false;
            reportStockdata.RowHeadersWidth = 51;
            reportStockdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reportStockdata.Size = new Size(1040, 195);
            reportStockdata.TabIndex = 40;
            // 
            // CSVStockReportButton
            // 
            CSVStockReportButton.BackColor = SystemColors.Menu;
            CSVStockReportButton.BackColor2 = Color.White;
            CSVStockReportButton.BorderColor = Color.White;
            CSVStockReportButton.BorderSize = 2;
            CSVStockReportButton.ButtonBorderColor = Color.Gray;
            CSVStockReportButton.ButtonHighlightColor = Color.Empty;
            CSVStockReportButton.ButtonHighlightColor2 = Color.Empty;
            CSVStockReportButton.ButtonHighlightForeColor = Color.Black;
            CSVStockReportButton.ButtonPressedColor = Color.White;
            CSVStockReportButton.ButtonPressedColor2 = Color.Empty;
            CSVStockReportButton.ButtonPressedForeColor = Color.Gray;
            CSVStockReportButton.ButtonRoundRadius = 30;
            CSVStockReportButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CSVStockReportButton.ForeColor = Color.Black;
            CSVStockReportButton.Location = new Point(751, 9);
            CSVStockReportButton.Margin = new Padding(3, 2, 3, 2);
            CSVStockReportButton.Name = "CSVStockReportButton";
            CSVStockReportButton.Size = new Size(141, 42);
            CSVStockReportButton.TabIndex = 41;
            CSVStockReportButton.Text = "Download CSV";
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label55.Location = new Point(16, 18);
            label55.Name = "label55";
            label55.Size = new Size(129, 25);
            label55.TabIndex = 6;
            label55.Text = "Stock Report";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1318, 759);
            Controls.Add(listpnl);
            Controls.Add(closebtn);
            Controls.Add(contactpnl);
            Controls.Add(outstandingOrderpnl);
            Controls.Add(inventorypnl);
            Controls.Add(orderpnl);
            Controls.Add(deliverypnl);
            Controls.Add(outstandingViewpnl);
            Controls.Add(deliveryCompletepnl);
            Controls.Add(StockReportpnl);
            Controls.Add(settingpnl);
            Controls.Add(dashboardpnl);
            Controls.Add(logpnl);
            Controls.Add(userspnl);
            Controls.Add(invoicepnl);
            Controls.Add(POpnl);
            Controls.Add(GRNpnl);
            Controls.Add(OrderAccemblypnl);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Padding = new Padding(0, 0, 9, 0);
            StartPosition = FormStartPosition.CenterParent;
            Text = "SalesOrder";
            Load += Dashboard_Load;
            MouseDown += Dashboard_MouseDown;
            MouseMove += Dashboard_MouseMove;
            MouseUp += Dashboard_MouseUp;
            listpnl.ResumeLayout(false);
            listpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatarbox).EndInit();
            orderpnl.ResumeLayout(false);
            orderpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderdata).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel30.ResumeLayout(false);
            panel30.PerformLayout();
            panel28.ResumeLayout(false);
            panel28.PerformLayout();
            stockSummarypnl.ResumeLayout(false);
            stockDatapanel3.ResumeLayout(false);
            stockDatapanel3.PerformLayout();
            stockDatapanel1.ResumeLayout(false);
            stockDatapanel1.PerformLayout();
            stockDatapanel2.ResumeLayout(false);
            stockDatapanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockData).EndInit();
            contactpnl.ResumeLayout(false);
            contactpnl.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            panel22.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            contactGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)suppliersData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealersData).EndInit();
            panel43.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)outstandingViewData).EndInit();
            panel42.ResumeLayout(false);
            panel42.PerformLayout();
            panel44.ResumeLayout(false);
            panel44.PerformLayout();
            settingpnl.ResumeLayout(false);
            settingpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderchart2).EndInit();
            panel33.ResumeLayout(false);
            panel33.PerformLayout();
            panel34.ResumeLayout(false);
            panel34.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderchart1).EndInit();
            panel35.ResumeLayout(false);
            panel35.PerformLayout();
            panel36.ResumeLayout(false);
            panel36.PerformLayout();
            panel32.ResumeLayout(false);
            panel32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderReportdata).EndInit();
            userspnl.ResumeLayout(false);
            userspnl.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userData).EndInit();
            inventorypnl.ResumeLayout(false);
            inventorypnl.PerformLayout();
            panel54.ResumeLayout(false);
            panel54.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            dashboardpnl.ResumeLayout(false);
            dashboardpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashordervalueChart).EndInit();
            panel53.ResumeLayout(false);
            panel39.ResumeLayout(false);
            panel39.PerformLayout();
            panel40.ResumeLayout(false);
            panel40.PerformLayout();
            panel38.ResumeLayout(false);
            panel38.PerformLayout();
            panel37.ResumeLayout(false);
            panel37.PerformLayout();
            panel41.ResumeLayout(false);
            panel41.PerformLayout();
            logpnl.ResumeLayout(false);
            logpnl.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)auditLogdata).EndInit();
            OrderAccemblypnl.ResumeLayout(false);
            OrderAccemblypnl.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel60.ResumeLayout(false);
            panel60.PerformLayout();
            panel66.ResumeLayout(false);
            panel66.PerformLayout();
            orderaccemblySearchpnl.ResumeLayout(false);
            orderaccemblySearchpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderAccemblyData).EndInit();
            GRNpnl.ResumeLayout(false);
            GRNpnl.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grndata).EndInit();
            deliverypnl.ResumeLayout(false);
            deliverypnl.PerformLayout();
            panel56.ResumeLayout(false);
            panel56.PerformLayout();
            panel61.ResumeLayout(false);
            panel61.PerformLayout();
            panel62.ResumeLayout(false);
            panel62.PerformLayout();
            panel65.ResumeLayout(false);
            panel65.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)deliveryData).EndInit();
            deliveryCompletepnl.ResumeLayout(false);
            deliveryCompletepnl.PerformLayout();
            POpnl.ResumeLayout(false);
            POpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)poData).EndInit();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            outstandingOrderpnl.ResumeLayout(false);
            outstandingOrderpnl.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel21.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)outstandingdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)customDataGridView4).EndInit();
            invoicepnl.ResumeLayout(false);
            invoicepnl.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)invoiceData).EndInit();
            outstandingViewpnl.ResumeLayout(false);
            StockReportpnl.ResumeLayout(false);
            StockReportpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reportStockPie).EndInit();
            panel47.ResumeLayout(false);
            panel47.PerformLayout();
            panel48.ResumeLayout(false);
            panel48.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            panel49.ResumeLayout(false);
            panel49.PerformLayout();
            panel50.ResumeLayout(false);
            panel50.PerformLayout();
            panel51.ResumeLayout(false);
            panel51.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reportStockdata).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel listpnl;
        private System.Windows.Forms.PictureBox avatarbox;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label usertypelbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Button orderbtn;
        public System.Windows.Forms.ImageList Order_logo;
        private System.Windows.Forms.Button stockbtn;
        private System.Windows.Forms.ImageList stock_logo;
        private System.Windows.Forms.Button usersbtn;
        private System.Windows.Forms.ImageList Accounts_logo;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.ImageList setting_logo;
        private System.Windows.Forms.Panel orderpnl;
        private System.Windows.Forms.Panel inventorypnl;
        private System.Windows.Forms.Panel userspnl;
        private System.Windows.Forms.Label stocklbl;
        private System.Windows.Forms.Panel settingpnl;
        private System.Windows.Forms.Label reportlbl;
        private System.Windows.Forms.Label userslbl;
        private System.Windows.Forms.Panel dashboardpnl;
        private System.Windows.Forms.Button contactsbtn;
        private System.Windows.Forms.Panel contactpnl;
        private ProgramMethod.ProgramMethod.RoundedButton supplersbtn;
        private ProgramMethod.ProgramMethod.RoundedButton dealersbtn;
        private CustomDataGridView dealersData;
        private ProgramMethod.ProgramMethod.RoundedButton editOrdersbtn;
        private ProgramMethod.ProgramMethod.RoundedButton viewAccountbtn;
        private ProgramMethod.ProgramMethod.RoundedButton editAccountbtn;
        private CustomDataGridView stockData;
        private ProgramMethod.ProgramMethod.RoundedButton viewOrderbtn;
        private ProgramMethod.ProgramMethod.RoundedButton newOrderbtn;
        private System.Windows.Forms.Label ordlerlbl;
        private ProgramMethod.ProgramMethod.RoundedButton newAccountbtn;
        private System.Windows.Forms.ImageList contact_logo;
        private System.Windows.Forms.Button Logbtn;
        private System.Windows.Forms.ImageList log_logo;
        private System.Windows.Forms.Panel logpnl;
        private System.Windows.Forms.Label loglbl;
        private ProgramMethod.ProgramMethod.RoundedButton accountSearchBtn;
        private Panel stockSummarypnl;
        private Panel stockDatapanel3;
        private Panel stockDatapanel2;
        private Panel stockDatapanel1;
        private Label stockProductDatalbl1;
        private Label stockProductDatalbl2;
        private Label stocklbl1;
        private Label stockProductDatalbl3;
        private Label stocklbl2;
        private ProgramMethod.ProgramMethod.RoundedButton viewProductbtn;
        private ProgramMethod.ProgramMethod.RoundedButton newProductbtn;
        private ProgramMethod.ProgramMethod.RoundedButton editProductbtn;
        private Label stocklbl3;
        private ProgramMethod.ProgramMethod.RoundedTextBox stockSearchBox;
        private ProgramMethod.ProgramMethod.RoundedButton delProductbtn;
        private ProgramMethod.ProgramMethod.RoundedButton disableAccountbtn;
        private Label label1;
        private ProgramMethod.ProgramMethod.RoundedButton enableAccountbtn;
        private Button OrderAccemblybtn;
        private Panel OrderAccemblypnl;
        private Label orderAccemblylbl;
        private Button GRNbtn;
        private Panel GRNpnl;
        private Label GRNlbl;
        private Button deliverybtn;
        private Panel deliverypnl;
        private Label deliverylbl;
        private CustomDataGridView grndata;
        private Label grnlbl2;
        private Label grnlbl1;
        private DateTimePicker grnDatePicker2;
        private DateTimePicker grnDatePicker1;
        private ProgramMethod.ProgramMethod.RoundedButton grnSearchBtn;
        private Panel panel1;
        private ProgramMethod.ProgramMethod.RoundedButton grnAddNoteBtn;
        private ProgramMethod.ProgramMethod.RoundedButton grncl;
        private CustomDataGridView deliveryData;
        private DateTimePicker deliverydateTimePicker1;
        private ProgramMethod.ProgramMethod.RoundedButton deliveryclearbtn;
        private ProgramMethod.ProgramMethod.RoundedButton deliverySearchDatebtn;
        private Label label3;
        private Label label2;
        private DateTimePicker deliverydateTimePicker2;
        private ProgramMethod.ProgramMethod.RoundedButton deliveryAddbtn;
        private Panel panel2;
        private ProgramMethod.ProgramMethod.RoundedButton delContactbtn;
        private Button searchDealerbtn;
        private TextBox searchContactbtn;
        private ProgramMethod.ProgramMethod.RoundedButton newDealerbtn;
        private ProgramMethod.ProgramMethod.RoundedButton editDealerbtn;
        private GroupBox contactGroupBox;
        private ProgramMethod.ProgramMethod.RoundedButton newSupplierbtn;
        private ProgramMethod.ProgramMethod.RoundedButton editSupplierbtn;
        private DataGridViewCheckBoxColumn grncheckColumn;
        private DataGridViewCheckBoxColumn deliverycheckColumn;
        private DataGridViewCheckBoxColumn dealercheckColumn;
        private DataGridViewCheckBoxColumn suppliercheckColumn;
        private DataGridViewCheckBoxColumn usercheckColumn;
        private DataGridViewCheckBoxColumn stockcheckColumn;
        private DataGridViewCheckBoxColumn pocheckColumn;
        private DataGridViewCheckBoxColumn orderAccemblyColumn;
        private ProgramMethod.ProgramMethod.RoundedButton searchSupplierbtn;
        private CustomDataGridView userData;
        private ProgramMethod.ProgramMethod.RoundedButton accountbtnLastPage;
        private ProgramMethod.ProgramMethod.RoundedButton accountbtnPrevPage;
        private ProgramMethod.ProgramMethod.RoundedButton accountbtnNxtPage;
        private ProgramMethod.ProgramMethod.RoundedButton accountbtnFirstPage;
        private ProgramMethod.ProgramMethod.RoundedButton deliveryViewDNbtn;
        private DataGridView orderAccemblyData;
        private ProgramMethod.ProgramMethod.RoundedButton accemblyCreatebtn;
        private Panel orderaccemblySearchpnl;
        private ProgramMethod.ProgramMethod.RoundedButton orderAccemblySearchbtn;
        private ProgramMethod.ProgramMethod.RoundedButton orderAccemblyClearbtn;
        private TextBox orderAccemblySearchbox1;
        private DateTimePicker orderAccemblydateTimePicker;
        private Label label5;
        private DateTimePicker orderAccemblydateTimePicker2;
        private Label label6;
        private ProgramMethod.ProgramMethod.RoundedButton orderAccemblyViewbtn;
        private Button invoicebtn;
        private Button outstandingOrderbtn;
        private Button PObtn;
        private Panel POpnl;
        private Label POlbl;
        private Panel invoicepnl;
        private Label invoicelbl;
        private Panel outstandingOrderpnl;
        private Label outstandingOrderlbl;
        private Panel panel3;
        private Panel panel4;
        private Label label7;
        private Label accountUserCountlbl3;
        private Panel panel5;
        private Label label9;
        private Label accountUserCountlbl;
        private Panel panel6;
        private Label accountUserCountlbl2;
        private Label label12;
        private Label accountIndexlbl;
        private Panel panel7;
        private Panel panel8;
        private ProgramMethod.ProgramMethod.RoundedButton stockFirstPagebtn;
        private Label StockpageNumlbl;
        private ProgramMethod.ProgramMethod.RoundedButton sotckPrevPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton sotckLastPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton sotckNextPagebtn;
        private ProgramMethod.ProgramMethod.RoundedTextBox accountSearchBox;
        private Label orderoverallBtn;
        private Label label11;
        private Label label10;
        private Label label8;
        private Panel panel9;
        private ProgramMethod.ProgramMethod.RoundedButton orderSearchbtn;
        private Label label14;
        private Label label13;
        private DateTimePicker orderdateTimePicker2;
        private DateTimePicker orderdateTimePicker1;
        private ProgramMethod.ProgramMethod.RoundedTextBox orderSearchbox;
        private ProgramMethod.ProgramMethod.RoundedButton CancelOrderbtn;
        private Panel panel10;
        private Panel panel11;
        private ProgramMethod.ProgramMethod.RoundedButton orderFirstPagebtn;
        private Label orderIndexlbl;
        private ProgramMethod.ProgramMethod.RoundedButton orderPrevPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton orderLastPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton orderNextPagebtn;
        private Panel panel12;
        private ProgramMethod.ProgramMethod.RoundedButton grnFirstPage;
        private Label grnPage;
        private ProgramMethod.ProgramMethod.RoundedButton grnPrevPage;
        private ProgramMethod.ProgramMethod.RoundedButton grnLastPage;
        private ProgramMethod.ProgramMethod.RoundedButton grnNextPage;
        private Panel panel13;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton9;
        private Label label17;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton10;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton11;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton12;
        private ProgramMethod.ProgramMethod.RoundedTextBox deliverySearchIDbox;
        private ComboBox orderStatusCombox;
        private Label label18;
        private Panel deliveryCompletepnl;
        private Button deliveryCompletebtn;
        private Button DeliveryCancelbtn;
        private Button deliveryNextbtn;
        private Label label4;
        private Label deliveryDeliveryIDlbl;
        private Button deliveryBackbtn;
        private DateTimePicker DeliverydeliveredDate;
        private Label label20;
        private Label deliveryShippingdatelbl;
        private ProgramMethod.ProgramMethod.RoundedButton deliverycompletedeliverybtn;
        private Panel panel14;
        private ProgramMethod.ProgramMethod.RoundedButton invoiceFirstPagebtn;
        private Label invoiceIndexlbl;
        private ProgramMethod.ProgramMethod.RoundedButton invoicePrevPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton invoiceLastPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton invoiceNextPagebtn;
        private Panel panel15;
        private ProgramMethod.ProgramMethod.RoundedButton invoiceCompleteBtn;
        private ProgramMethod.ProgramMethod.RoundedTextBox roundedTextBox1;
        private ProgramMethod.ProgramMethod.RoundedButton invoiceViewBtn;
        private DateTimePicker InvoicedateTimePicker1;
        private Label label22;
        private ProgramMethod.ProgramMethod.RoundedButton invoiceSearchBtn;
        private Label label23;
        private ProgramMethod.ProgramMethod.RoundedButton invoiceClearBtn;
        private DateTimePicker invoicedateTimePicker2;
        private CustomDataGridView invoiceData;
        private Panel panel16;
        private ProgramMethod.ProgramMethod.RoundedButton poFirstPageBtn;
        private Label poIndexlbl;
        private ProgramMethod.ProgramMethod.RoundedButton poPrevPageBtn;
        private ProgramMethod.ProgramMethod.RoundedButton poLastPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton poNextPageBtn;
        private Panel panel17;
        private ProgramMethod.ProgramMethod.RoundedButton CompletePoButton;
        private ProgramMethod.ProgramMethod.RoundedTextBox poSearchbox;
        private DateTimePicker podateTimePicker1;
        private Label label25;
        private Label label26;
        private DateTimePicker podateTimePicker2;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private ProgramMethod.ProgramMethod.RoundedButton AddOrderPoButton;
        private Panel panel19;
        private ProgramMethod.ProgramMethod.RoundedTextBox roundedTextBox3;
        private DateTimePicker logdateTimePicker1;
        private Label label28;
        private ProgramMethod.ProgramMethod.RoundedButton SeachLogButton;
        private Label label29;
        private ProgramMethod.ProgramMethod.RoundedButton ClearLogButton;
        private DateTimePicker logdateTimePicker2;
        private CustomDataGridView auditLogdata;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private Panel panel20;
        private ProgramMethod.ProgramMethod.RoundedButton outstandingFirstPagebtn;
        private Label oustandingPagelbl;
        private ProgramMethod.ProgramMethod.RoundedButton oustadningPrevPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton outstandingLastPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton outstandingNextPagebtn;
        private Panel panel21;
        private ProgramMethod.ProgramMethod.RoundedTextBox outstandingSearchbox;
        private ProgramMethod.ProgramMethod.RoundedButton outstandingViewbtn;
        private DateTimePicker outstandingdateTimePicker1;
        private Label label31;
        private ProgramMethod.ProgramMethod.RoundedButton outstandingSearchbtn;
        private Label label32;
        private ProgramMethod.ProgramMethod.RoundedButton outstandingClearBtn;
        private DateTimePicker outstandingdateTimePicker2;
        private CustomDataGridView outstandingdata;
        private DataGridViewCheckBoxColumn outstandingcheckColumn;
        private DataGridViewCheckBoxColumn orderaccemblycheckColumn;
        private Panel outstandingViewpnl;
        private Label contactIndexlbl;
        private Label outstandingDealerIDlbl;
        private ProgramMethod.ProgramMethod.RoundedButton outstandingBackbtn;
        private Label outstandingIDlbl;
        private Button outstandingCancelbtn;
        private Button button23;
        private Label outstandingEmaillbl;
        private Label outstandingPhonelbl;
        private Label outstandingContactNamelbl;
        private Label outstandingDealerNamelbl;
        private Label outstandingOrderIDlbl2;
        private Label outstandingDeliveryAddresslbl;
        private Panel panel22;
        private Panel panel23;
        private DataGridView outstandingViewData;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn FollowUp;
        private DataGridViewTextBoxColumn UnitPrice;
        private DateTimePicker dateTimePicker8;
        private CustomDataGridView customDataGridView4;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private Button button24;
        private Panel panel24;
        private Label label35;
        private Label dealerDatalbl;
        private Panel panel25;
        private Label supplierDatalbl;
        private Label label38;
        private ProgramMethod.ProgramMethod.RoundedButton contactbtnFirstPage;
        private Panel panel42;
        private Panel panel43;
        private Panel panel44;
        private Panel panel45;
        private Panel panel46;
        private ProgramMethod.ProgramMethod.RoundedButton contactbtnPrevPage;
        private ProgramMethod.ProgramMethod.RoundedButton contactbtnLastPage;
        private ProgramMethod.ProgramMethod.RoundedButton contactbtnNxtPage;
        private CustomDataGridView suppliersData;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private CustomDataGridView poData;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private Button homebtn;
        public ImageList home_logo;
        private Button reportbtn;
        private ProgramMethod.ProgramMethod.RoundedButton ZoomProductbtn;
        private Panel panel29;
        private Panel panel28;
        private TextBox orderCompletedlbl;
        private Panel InvoiceLine1;
        private DataGridViewCheckBoxColumn invoicecheckbox;
        private Panel panel26;
        private TextBox orderAllbox;
        private Panel panel27;
        private TextBox orderActivebox;
        private Panel panel30;
        private TextBox orderCancelbox;
        private Panel panel32;
        private DateTimePicker dateTimePicker3;
        private Label label21;
        private ProgramMethod.ProgramMethod.RoundedButton orderReportsearchbtn;
        private Label label30;
        private ProgramMethod.ProgramMethod.RoundedButton orderReportClearbtn;
        private DateTimePicker dateTimePicker4;
        private CustomDataGridView orderReportdata;
        private ProgramMethod.ProgramMethod.RoundedButton reportOrderpdfbtn;
        private ProgramMethod.ProgramMethod.RoundedButton reportOrdercsvbtn;
        private Panel panel33;
        private Label MonthlyTotalOrderValue;
        private Label MonthlyTotalOrder;
        private Panel panel34;
        private Label MonthlyTotalSalesValue;
        private Label MonthlyTotalSales;
        private Panel panel35;
        private Label TodayTotalOrderValue;
        private Label TodayTotalOrder;
        private Panel panel36;
        private Label reportInvoicelbl;
        private Label TodayTotalSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart orderchart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart orderchart1;
        private Panel panel31;
        private Label label15;
        private Panel panel38;
        private Label dashOutlbl;
        private Label label39;
        private Panel panel39;
        private Label dashOrderlbl;
        private Label label41;
        private Panel panel40;
        private Label dashRevenuelbl;
        private Label label43;
        private Button reportShowStockbtn;
        private Button reportShowOrderbtn;
        private Panel StockReportpnl;
        private ProgramMethod.ProgramMethod.RoundedButton StockStockReportButton;
        private ProgramMethod.ProgramMethod.RoundedButton OrderStockReportButton;
        private Label label44;
        private Panel panel47;
        private Label label45;
        private Label label46;
        private Panel panel48;
        private Label label47;
        private Label label48;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Panel panel49;
        private Label label49;
        private Label label50;
        private Panel panel50;
        private Label label51;
        private Label label52;
        private ProgramMethod.ProgramMethod.RoundedButton PDFStockReportButton;
        private Panel panel51;
        private DateTimePicker dateTimePicker7;
        private Label label53;
        private ProgramMethod.ProgramMethod.RoundedButton SearchStockReportButton;
        private Label label54;
        private ProgramMethod.ProgramMethod.RoundedButton ClearStockReportButton;
        private DateTimePicker dateTimePicker9;
        private CustomDataGridView reportStockdata;
        private ProgramMethod.ProgramMethod.RoundedButton CSVStockReportButton;
        private Label label55;
        private System.Windows.Forms.DataVisualization.Charting.Chart reportStockPie;
        private Label outstandingViewEmaillbl;
        private Label outstandingViewPhoneNumlbl;
        private Label outstandingViewContactNamelbl;
        private Label outstandingViewDealerNamelbl;
        private Label outstandingViewDealerIDlbl;
        private Label oustandingViewDeliverylbl;
        private Label outstandingOrderIDlbl;
        private Label viewoutstandingOrderDatelbl;
        private Label label56;
        private Label viewoutstandingOrderExecptDatelbl;
        private Label label58;
        private GroupBox groupBox1;
        private ProgramMethod.ProgramMethod.RoundedButton dateFilterbtn;
        private Label label24;
        private ImageList log_new;
        private ImageList invoice;
        private ImageList delivery;
        private ImageList grn;
        private Panel panel41;
        private Label label57;
        private Panel panel37;
        private Label dashInlbl;
        private Label label34;
        private Label label59;
        private Panel panel52;
        private Panel panel53;
        private System.Windows.Forms.DataVisualization.Charting.Chart dashordervalueChart;
        private ProgramMethod.ProgramMethod.RoundedTextBox orderAccemblySearchbox;
        private Panel panel55;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton1;
        private ProgramMethod.ProgramMethod.RoundedTextBox grnsearchbox;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ComboBox auditlogStatusbox;
        private Label label16;
        private ComboBox auditTypeStatusbox;
        private Label label62;
        private Panel panel54;
        private Panel panel57;
        private TextBox stockReOrderbox;
        private Panel panel58;
        private TextBox stockOutofStockbox;
        private Panel panel59;
        private Panel panel63;
        private TextBox stockDangerbox;
        private Label label37;
        private Label label40;
        private Label label60;
        private Panel panel56;
        private Panel panel61;
        private TextBox textBox3;
        private Panel panel62;
        private TextBox textBox5;
        private Panel panel64;
        private Panel panel65;
        private TextBox textBox7;
        private Label label42;
        private Label label61;
        private Label label63;
        private Label label36;
        private Panel panel18;
        private Panel panel60;
        private TextBox textBox1;
        private Panel panel66;
        private TextBox textBox2;
        private Panel panel67;
        private Label label19;
        private Label label27;
        private ProgramMethod.ProgramMethod.RoundedButton outstandingDeletebtn;
        private CustomDataGridView orderdata;
        private DataGridViewCheckBoxColumn ordercheckColumn;
        private ProgramMethod.ProgramMethod.RoundedButton contactSupplierCleaerbtn;
        private ProgramMethod.ProgramMethod.RoundedButton contactDealerclearbtn;
    }
}