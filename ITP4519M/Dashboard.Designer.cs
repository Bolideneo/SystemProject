using Org.BouncyCastle.Asn1.Crmf;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            listpnl = new Panel();
            reportbtn = new Button();
            log_logo = new ImageList(components);
            homebtn = new Button();
            home_logo = new ImageList(components);
            invoicebtn = new Button();
            outstandingOrderbtn = new Button();
            PObtn = new Button();
            deliverybtn = new Button();
            GRNbtn = new Button();
            OrderAccemblybtn = new Button();
            Order_logo = new ImageList(components);
            Logbtn = new Button();
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
            orderSearchbtn = new Button();
            orderdateTimePicker2 = new DateTimePicker();
            label14 = new Label();
            CancelOrderbtn = new Button();
            orderSearchbox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            panel9 = new Panel();
            panel29 = new Panel();
            textBox3 = new TextBox();
            panel28 = new Panel();
            textBox2 = new TextBox();
            panel27 = new Panel();
            textBox1 = new TextBox();
            panel26 = new Panel();
            orderCountbox = new TextBox();
            orderoverallBtn = new Label();
            label11 = new Label();
            label8 = new Label();
            label10 = new Label();
            viewOrderbtn = new Button();
            newOrderbtn = new Button();
            ordlerlbl = new Label();
            saleReportbtn = new Button();
            editOrdersbtn = new Button();
            orderdata = new CustomDataGridView();
            ordercheckColumn = new DataGridViewCheckBoxColumn();
            contactIndexlbl = new Label();
            outstandingcheckColumn = new DataGridViewCheckBoxColumn();
            deliverycheckColumn = new DataGridViewCheckBoxColumn();
            dealercheckColumn = new DataGridViewCheckBoxColumn();
            suppliercheckColumn = new DataGridViewCheckBoxColumn();
            usercheckColumn = new DataGridViewCheckBoxColumn();
            stockcheckColumn = new DataGridViewCheckBoxColumn();
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
            editProductbtn = new Button();
            newProductbtn = new Button();
            stockData = new CustomDataGridView();
            viewProductbtn = new Button();
            accountSearchBtn = new ProgramMethod.ProgramMethod.RoundedButton();
            contactpnl = new Panel();
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
            supplersbtn = new Button();
            dealersbtn = new Button();
            delContactbtn = new Button();
            searchContactbtn = new TextBox();
            newDealerbtn = new Button();
            searchSupplierbtn = new Button();
            searchDealerbtn = new Button();
            editSupplierbtn = new Button();
            newSupplierbtn = new Button();
            suppliersData = new CustomDataGridView();
            dealersData = new CustomDataGridView();
            editDealerbtn = new Button();
            dataGridViewCheckBoxColumn5 = new DataGridViewCheckBoxColumn();
            panel43 = new Panel();
            outstandingViewData = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            FollowUp = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            panel42 = new Panel();
            outstandingDealerIDlbl = new Label();
            outstandingDealerNamelbl = new Label();
            outstandingDeliveryAddresslbl = new Label();
            outstandingContactNamelbl = new Label();
            outstandingEmaillbl = new Label();
            outstandingPhonelbl = new Label();
            button23 = new Button();
            button21 = new Button();
            outstandingCancelbtn = new Button();
            panel44 = new Panel();
            outstandingOrderIDlbl = new Label();
            outstandingIDlbl = new Label();
            label36 = new Label();
            outstandingBackbtn = new Button();
            label2 = new Label();
            settingpnl = new Panel();
            reportlbl = new Label();
            userspnl = new Panel();
            accountSearchBox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            panel7 = new Panel();
            accountbtnFirstPage = new ProgramMethod.ProgramMethod.RoundedButton();
            accountIndexlbl = new Label();
            accountbtnPrevPage = new ProgramMethod.ProgramMethod.RoundedButton();
            accountbtnLastPage = new ProgramMethod.ProgramMethod.RoundedButton();
            accountbtnNxtPage = new ProgramMethod.ProgramMethod.RoundedButton();
            accountPaginationpnl = new Panel();
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
            accountPageSizeComboBox = new ComboBox();
            accountPaginglbl = new Label();
            enableAccountbtn = new Button();
            disableAccountbtn = new Button();
            newAccountbtn = new Button();
            viewAccountbtn = new Button();
            editAccountbtn = new Button();
            userData = new CustomDataGridView();
            userslbl = new Label();
            inventorypnl = new Panel();
            button8 = new Button();
            panel8 = new Panel();
            stockFirstPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            StockpageNumlbl = new Label();
            sotckPrevPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            sotckLastPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            sotckNextPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            delProductbtn = new Button();
            stockSearchBox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            dashboardpnl = new Panel();
            label1 = new Label();
            logpnl = new Panel();
            panel18 = new Panel();
            roundedButton21 = new ProgramMethod.ProgramMethod.RoundedButton();
            label27 = new Label();
            roundedButton22 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton23 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton24 = new ProgramMethod.ProgramMethod.RoundedButton();
            panel19 = new Panel();
            button1 = new Button();
            roundedTextBox3 = new ProgramMethod.ProgramMethod.RoundedTextBox();
            button2 = new Button();
            dateTimePicker5 = new DateTimePicker();
            label28 = new Label();
            button4 = new Button();
            label29 = new Label();
            button18 = new Button();
            dateTimePicker6 = new DateTimePicker();
            auditLogdata = new CustomDataGridView();
            button19 = new Button();
            loglbl = new Label();
            dataGridViewCheckBoxColumn3 = new DataGridViewCheckBoxColumn();
            OrderAccemblypnl = new Panel();
            orderaccemblySearchpnl = new Panel();
            orderAccemblyViewbtn = new Button();
            orderAccemblySearchbtn = new Button();
            orderAccemblyClearbtn = new Button();
            orderAccemblySearchbox = new TextBox();
            orderAccemblydateTimePicker = new DateTimePicker();
            label5 = new Label();
            orderAccemblydateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            orderAccemblyData = new DataGridView();
            orderAccemblylbl = new Label();
            accemblyCreatebtn = new Button();
            GRNpnl = new Panel();
            panel12 = new Panel();
            roundedButton5 = new ProgramMethod.ProgramMethod.RoundedButton();
            label16 = new Label();
            roundedButton6 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton7 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton8 = new ProgramMethod.ProgramMethod.RoundedButton();
            panel1 = new Panel();
            grnDatePicker1 = new DateTimePicker();
            grnlbl1 = new Label();
            grnclearBtn = new Button();
            grnDatePicker2 = new DateTimePicker();
            grnSearchBtn = new Button();
            grnlbl2 = new Label();
            grnAddNoteBtn = new Button();
            grndata = new CustomDataGridView();
            grncheckColumn = new DataGridViewCheckBoxColumn();
            GRNlbl = new Label();
            deliverypnl = new Panel();
            panel13 = new Panel();
            roundedButton9 = new ProgramMethod.ProgramMethod.RoundedButton();
            label17 = new Label();
            roundedButton10 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton11 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton12 = new ProgramMethod.ProgramMethod.RoundedButton();
            panel2 = new Panel();
            deliverycompletedeliverybtn = new Button();
            deliverySearchIDbox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            deliveryViewDNbtn = new Button();
            deliverydateTimePicker1 = new DateTimePicker();
            deliverySearchDatebtn = new Button();
            label3 = new Label();
            deliveryclearbtn = new Button();
            deliverydateTimePicker2 = new DateTimePicker();
            deliveryData = new CustomDataGridView();
            deliveryAddbtn = new Button();
            deliverylbl = new Label();
            deliveryCompletepnl = new Panel();
            label19 = new Label();
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
            dataGridViewCheckBoxColumn6 = new DataGridViewCheckBoxColumn();
            panel16 = new Panel();
            poFirstPageBtn = new ProgramMethod.ProgramMethod.RoundedButton();
            label24 = new Label();
            poPrevPageBtn = new ProgramMethod.ProgramMethod.RoundedButton();
            poLastPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            poNextPageBtn = new ProgramMethod.ProgramMethod.RoundedButton();
            panel17 = new Panel();
            button13 = new Button();
            poSearchbox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            button14 = new Button();
            podateTimePicker1 = new DateTimePicker();
            label25 = new Label();
            poSearchbtn = new Button();
            label26 = new Label();
            poClearbtn = new Button();
            podateTimePicker2 = new DateTimePicker();
            button17 = new Button();
            POlbl = new Label();
            dataGridViewCheckBoxColumn2 = new DataGridViewCheckBoxColumn();
            outstandingOrderpnl = new Panel();
            panel20 = new Panel();
            outstandingFirstPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            oustadningPrevPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            outstandingLastPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            outstandingNextPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            oustandingPagelbl = new Label();
            panel21 = new Panel();
            outstandingSearchbox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            outstandingViewbtn = new Button();
            outstandingdateTimePicker1 = new DateTimePicker();
            label31 = new Label();
            outstandingSearchbtn = new Button();
            label32 = new Label();
            outstandingClearBtn = new Button();
            outstandingdateTimePicker2 = new DateTimePicker();
            outstandingdata = new CustomDataGridView();
            outstandingOrderlbl = new Label();
            dateTimePicker8 = new DateTimePicker();
            customDataGridView4 = new CustomDataGridView();
            dataGridViewCheckBoxColumn4 = new DataGridViewCheckBoxColumn();
            button24 = new Button();
            invoicepnl = new Panel();
            panel14 = new Panel();
            roundedButton13 = new ProgramMethod.ProgramMethod.RoundedButton();
            label21 = new Label();
            roundedButton14 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton15 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton16 = new ProgramMethod.ProgramMethod.RoundedButton();
            panel15 = new Panel();
            button7 = new Button();
            roundedTextBox1 = new ProgramMethod.ProgramMethod.RoundedTextBox();
            button9 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label22 = new Label();
            button10 = new Button();
            label23 = new Label();
            button11 = new Button();
            dateTimePicker2 = new DateTimePicker();
            invoiceData = new CustomDataGridView();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            button12 = new Button();
            invoicelbl = new Label();
            outstandingViewpnl = new Panel();
            panel45 = new Panel();
            listpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatarbox).BeginInit();
            orderpnl.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel29.SuspendLayout();
            panel28.SuspendLayout();
            panel27.SuspendLayout();
            panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderdata).BeginInit();
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
            userspnl.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userData).BeginInit();
            inventorypnl.SuspendLayout();
            panel8.SuspendLayout();
            dashboardpnl.SuspendLayout();
            logpnl.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)auditLogdata).BeginInit();
            OrderAccemblypnl.SuspendLayout();
            orderaccemblySearchpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderAccemblyData).BeginInit();
            GRNpnl.SuspendLayout();
            panel12.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grndata).BeginInit();
            deliverypnl.SuspendLayout();
            panel13.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deliveryData).BeginInit();
            deliveryCompletepnl.SuspendLayout();
            POpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)poData).BeginInit();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            outstandingOrderpnl.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)outstandingdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customDataGridView4).BeginInit();
            invoicepnl.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)invoiceData).BeginInit();
            outstandingViewpnl.SuspendLayout();
            SuspendLayout();
            // 
            // listpnl
            // 
            listpnl.BackColor = SystemColors.MenuText;
            listpnl.BackgroundImageLayout = ImageLayout.Stretch;
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
            listpnl.Margin = new Padding(3, 4, 3, 4);
            listpnl.Name = "listpnl";
            listpnl.Size = new Size(200, 1051);
            listpnl.TabIndex = 14;
            listpnl.Paint += listpnl_Paint;
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
            reportbtn.Location = new Point(25, 905);
            reportbtn.Margin = new Padding(3, 4, 3, 4);
            reportbtn.Name = "reportbtn";
            reportbtn.Size = new Size(166, 51);
            reportbtn.TabIndex = 16;
            reportbtn.Text = "Reports";
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
            homebtn.Location = new Point(58, 12);
            homebtn.Margin = new Padding(3, 4, 3, 4);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(74, 45);
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
            invoicebtn.ImageList = log_logo;
            invoicebtn.Location = new Point(25, 720);
            invoicebtn.Margin = new Padding(3, 4, 3, 4);
            invoicebtn.Name = "invoicebtn";
            invoicebtn.Size = new Size(166, 56);
            invoicebtn.TabIndex = 14;
            invoicebtn.Text = "Invoice";
            invoicebtn.UseVisualStyleBackColor = true;
            invoicebtn.Click += invoicebtn_Click;
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
            outstandingOrderbtn.ImageList = log_logo;
            outstandingOrderbtn.Location = new Point(25, 647);
            outstandingOrderbtn.Margin = new Padding(3, 4, 3, 4);
            outstandingOrderbtn.Name = "outstandingOrderbtn";
            outstandingOrderbtn.Size = new Size(189, 75);
            outstandingOrderbtn.TabIndex = 13;
            outstandingOrderbtn.Text = "         Outstanding\r\n         Order";
            outstandingOrderbtn.TextAlign = ContentAlignment.MiddleLeft;
            outstandingOrderbtn.UseVisualStyleBackColor = true;
            outstandingOrderbtn.Click += outstandingOrderbtn_Click;
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
            PObtn.ImageList = log_logo;
            PObtn.Location = new Point(25, 583);
            PObtn.Margin = new Padding(3, 4, 3, 4);
            PObtn.Name = "PObtn";
            PObtn.Size = new Size(166, 56);
            PObtn.TabIndex = 12;
            PObtn.Text = "PO      ";
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
            deliverybtn.ImageList = log_logo;
            deliverybtn.Location = new Point(25, 519);
            deliverybtn.Margin = new Padding(3, 4, 3, 4);
            deliverybtn.Name = "deliverybtn";
            deliverybtn.Size = new Size(166, 56);
            deliverybtn.TabIndex = 11;
            deliverybtn.Text = "  Delivery";
            deliverybtn.UseVisualStyleBackColor = true;
            deliverybtn.Click += deliverybtn_Click;
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
            GRNbtn.ImageList = log_logo;
            GRNbtn.Location = new Point(25, 455);
            GRNbtn.Margin = new Padding(3, 4, 3, 4);
            GRNbtn.Name = "GRNbtn";
            GRNbtn.Size = new Size(166, 56);
            GRNbtn.TabIndex = 10;
            GRNbtn.Text = "GRN    ";
            GRNbtn.UseVisualStyleBackColor = true;
            GRNbtn.Click += GRNbtn_Click;
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
            OrderAccemblybtn.Location = new Point(25, 327);
            OrderAccemblybtn.Margin = new Padding(3, 4, 3, 4);
            OrderAccemblybtn.Name = "OrderAccemblybtn";
            OrderAccemblybtn.Size = new Size(169, 75);
            OrderAccemblybtn.TabIndex = 9;
            OrderAccemblybtn.Text = "         Order\r\n         Accembly ";
            OrderAccemblybtn.TextAlign = ContentAlignment.MiddleLeft;
            OrderAccemblybtn.UseVisualStyleBackColor = true;
            OrderAccemblybtn.Click += OrderAccemblybtn_Click;
            // 
            // Order_logo
            // 
            Order_logo.ColorDepth = ColorDepth.Depth24Bit;
            Order_logo.ImageStream = (ImageListStreamer)resources.GetObject("Order_logo.ImageStream");
            Order_logo.TransparentColor = Color.Transparent;
            Order_logo.Images.SetKeyName(0, "order_logo.png");
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
            Logbtn.ImageList = log_logo;
            Logbtn.Location = new Point(25, 843);
            Logbtn.Margin = new Padding(3, 4, 3, 4);
            Logbtn.Name = "Logbtn";
            Logbtn.Size = new Size(166, 51);
            Logbtn.TabIndex = 8;
            Logbtn.Text = "Log      ";
            Logbtn.UseVisualStyleBackColor = true;
            Logbtn.Click += Logbtn_Click;
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
            contactsbtn.Location = new Point(25, 391);
            contactsbtn.Margin = new Padding(3, 4, 3, 4);
            contactsbtn.Name = "contactsbtn";
            contactsbtn.Size = new Size(184, 75);
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
            logoutbtn.Location = new Point(25, 975);
            logoutbtn.Margin = new Padding(3, 4, 3, 4);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(166, 51);
            logoutbtn.TabIndex = 6;
            logoutbtn.Text = "Log Out";
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
            usersbtn.Location = new Point(25, 784);
            usersbtn.Margin = new Padding(3, 4, 3, 4);
            usersbtn.Name = "usersbtn";
            usersbtn.Size = new Size(166, 51);
            usersbtn.TabIndex = 5;
            usersbtn.Text = "   Accounts";
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
            stockbtn.Location = new Point(25, 265);
            stockbtn.Margin = new Padding(3, 4, 3, 4);
            stockbtn.Name = "stockbtn";
            stockbtn.Size = new Size(166, 56);
            stockbtn.TabIndex = 4;
            stockbtn.Text = "Stock  ";
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
            orderbtn.Location = new Point(25, 205);
            orderbtn.Margin = new Padding(3, 4, 3, 4);
            orderbtn.Name = "orderbtn";
            orderbtn.Size = new Size(166, 57);
            orderbtn.TabIndex = 3;
            orderbtn.Text = "Salse Order  ";
            orderbtn.TextAlign = ContentAlignment.MiddleRight;
            orderbtn.UseVisualStyleBackColor = true;
            orderbtn.Click += orderbtn_Click;
            // 
            // usertypelbl
            // 
            usertypelbl.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usertypelbl.ForeColor = Color.White;
            usertypelbl.Location = new Point(49, 165);
            usertypelbl.Name = "usertypelbl";
            usertypelbl.Size = new Size(105, 31);
            usertypelbl.TabIndex = 2;
            usertypelbl.Text = "Type";
            usertypelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namelbl.ForeColor = Color.White;
            namelbl.Location = new Point(37, 133);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(105, 25);
            namelbl.TabIndex = 1;
            namelbl.Text = "UserName";
            namelbl.TextAlign = ContentAlignment.MiddleCenter;
            namelbl.Click += namelbl_Click;
            // 
            // avatarbox
            // 
            avatarbox.BackgroundImage = Properties.Resources.company_logo;
            avatarbox.BackgroundImageLayout = ImageLayout.Stretch;
            avatarbox.Location = new Point(3, 67);
            avatarbox.Margin = new Padding(3, 4, 3, 4);
            avatarbox.Name = "avatarbox";
            avatarbox.Size = new Size(197, 65);
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
            closebtn.Location = new Point(1449, 3);
            closebtn.Margin = new Padding(3, 4, 3, 4);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(50, 53);
            closebtn.TabIndex = 15;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += CloseButton_Click;
            // 
            // orderpnl
            // 
            orderpnl.Controls.Add(InvoiceLine1);
            orderpnl.Controls.Add(panel11);
            orderpnl.Controls.Add(panel10);
            orderpnl.Controls.Add(CancelOrderbtn);
            orderpnl.Controls.Add(orderSearchbox);
            orderpnl.Controls.Add(panel9);
            orderpnl.Controls.Add(viewOrderbtn);
            orderpnl.Controls.Add(newOrderbtn);
            orderpnl.Controls.Add(ordlerlbl);
            orderpnl.Controls.Add(saleReportbtn);
            orderpnl.Controls.Add(editOrdersbtn);
            orderpnl.Controls.Add(orderdata);
            orderpnl.Location = new Point(201, 3);
            orderpnl.Margin = new Padding(3, 4, 3, 4);
            orderpnl.Name = "orderpnl";
            orderpnl.Size = new Size(1250, 1051);
            orderpnl.TabIndex = 16;
            orderpnl.Visible = false;
            // 
            // InvoiceLine1
            // 
            InvoiceLine1.BackColor = SystemColors.ControlDark;
            InvoiceLine1.BorderStyle = BorderStyle.Fixed3D;
            InvoiceLine1.ForeColor = SystemColors.ControlText;
            InvoiceLine1.Location = new Point(46, 278);
            InvoiceLine1.Margin = new Padding(3, 4, 3, 4);
            InvoiceLine1.Name = "InvoiceLine1";
            InvoiceLine1.Size = new Size(874, 5);
            InvoiceLine1.TabIndex = 51;
            // 
            // panel11
            // 
            panel11.Controls.Add(orderFirstPagebtn);
            panel11.Controls.Add(orderIndexlbl);
            panel11.Controls.Add(orderPrevPagebtn);
            panel11.Controls.Add(orderLastPagebtn);
            panel11.Controls.Add(orderNextPagebtn);
            panel11.Location = new Point(659, 933);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(566, 67);
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
            orderFirstPagebtn.ButtonRoundRadius = 15;
            orderFirstPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderFirstPagebtn.ForeColor = Color.Black;
            orderFirstPagebtn.Location = new Point(70, 9);
            orderFirstPagebtn.Margin = new Padding(3, 4, 3, 4);
            orderFirstPagebtn.Name = "orderFirstPagebtn";
            orderFirstPagebtn.Size = new Size(79, 44);
            orderFirstPagebtn.TabIndex = 31;
            orderFirstPagebtn.Text = "First";
            orderFirstPagebtn.Click += orderFirstPagebtn_Click;
            // 
            // orderIndexlbl
            // 
            orderIndexlbl.AutoSize = true;
            orderIndexlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderIndexlbl.Location = new Point(251, 21);
            orderIndexlbl.Name = "orderIndexlbl";
            orderIndexlbl.Size = new Size(100, 25);
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
            orderPrevPagebtn.ButtonRoundRadius = 15;
            orderPrevPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderPrevPagebtn.ForeColor = Color.Black;
            orderPrevPagebtn.Location = new Point(167, 9);
            orderPrevPagebtn.Margin = new Padding(3, 4, 3, 4);
            orderPrevPagebtn.Name = "orderPrevPagebtn";
            orderPrevPagebtn.Size = new Size(72, 44);
            orderPrevPagebtn.TabIndex = 33;
            orderPrevPagebtn.Text = "Prev";
            orderPrevPagebtn.Click += orderPrevPagebtn_Click;
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
            orderLastPagebtn.ButtonRoundRadius = 15;
            orderLastPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderLastPagebtn.ForeColor = Color.Black;
            orderLastPagebtn.Location = new Point(454, 9);
            orderLastPagebtn.Margin = new Padding(3, 4, 3, 4);
            orderLastPagebtn.Name = "orderLastPagebtn";
            orderLastPagebtn.Size = new Size(75, 44);
            orderLastPagebtn.TabIndex = 34;
            orderLastPagebtn.Text = "Last";
            orderLastPagebtn.Click += orderLastPagebtn_Click;
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
            orderNextPagebtn.ButtonRoundRadius = 15;
            orderNextPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderNextPagebtn.ForeColor = Color.Black;
            orderNextPagebtn.Location = new Point(371, 9);
            orderNextPagebtn.Margin = new Padding(3, 4, 3, 4);
            orderNextPagebtn.Name = "orderNextPagebtn";
            orderNextPagebtn.Size = new Size(71, 44);
            orderNextPagebtn.TabIndex = 32;
            orderNextPagebtn.Text = "Next";
            orderNextPagebtn.Click += orderNextPagebtn_Click;
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
            panel10.Location = new Point(38, 76);
            panel10.Name = "panel10";
            panel10.Size = new Size(983, 108);
            panel10.TabIndex = 46;
            // 
            // orderStatusCombox
            // 
            orderStatusCombox.FormattingEnabled = true;
            orderStatusCombox.Location = new Point(642, 61);
            orderStatusCombox.Name = "orderStatusCombox";
            orderStatusCombox.Size = new Size(151, 28);
            orderStatusCombox.TabIndex = 48;
            orderStatusCombox.Click += orderSearchbtn_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(643, 25);
            label18.Name = "label18";
            label18.Size = new Size(67, 28);
            label18.TabIndex = 44;
            label18.Text = "Status";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(13, 25);
            label13.Name = "label13";
            label13.Size = new Size(59, 28);
            label13.TabIndex = 42;
            label13.Text = "From";
            // 
            // orderdateTimePicker1
            // 
            orderdateTimePicker1.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderdateTimePicker1.Location = new Point(17, 61);
            orderdateTimePicker1.Name = "orderdateTimePicker1";
            orderdateTimePicker1.Size = new Size(250, 27);
            orderdateTimePicker1.TabIndex = 40;
            // 
            // orderSearchbtn
            // 
            orderSearchbtn.AutoSize = true;
            orderSearchbtn.BackColor = SystemColors.HighlightText;
            orderSearchbtn.CausesValidation = false;
            orderSearchbtn.FlatAppearance.BorderColor = Color.Gray;
            orderSearchbtn.FlatStyle = FlatStyle.System;
            orderSearchbtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderSearchbtn.ForeColor = Color.Black;
            orderSearchbtn.ImageAlign = ContentAlignment.MiddleLeft;
            orderSearchbtn.ImageIndex = 0;
            orderSearchbtn.Location = new Point(832, 44);
            orderSearchbtn.Margin = new Padding(3, 4, 3, 4);
            orderSearchbtn.Name = "orderSearchbtn";
            orderSearchbtn.Size = new Size(133, 49);
            orderSearchbtn.TabIndex = 39;
            orderSearchbtn.Text = "Search";
            orderSearchbtn.UseVisualStyleBackColor = false;
            // 
            // orderdateTimePicker2
            // 
            orderdateTimePicker2.Location = new Point(327, 62);
            orderdateTimePicker2.Name = "orderdateTimePicker2";
            orderdateTimePicker2.Size = new Size(250, 27);
            orderdateTimePicker2.TabIndex = 41;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(327, 25);
            label14.Name = "label14";
            label14.Size = new Size(33, 28);
            label14.TabIndex = 43;
            label14.Text = "To";
            // 
            // CancelOrderbtn
            // 
            CancelOrderbtn.AutoSize = true;
            CancelOrderbtn.BackColor = Color.Red;
            CancelOrderbtn.FlatAppearance.BorderColor = Color.Gray;
            CancelOrderbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelOrderbtn.ForeColor = Color.Transparent;
            CancelOrderbtn.ImageAlign = ContentAlignment.MiddleLeft;
            CancelOrderbtn.ImageIndex = 0;
            CancelOrderbtn.Location = new Point(434, 291);
            CancelOrderbtn.Margin = new Padding(3, 4, 3, 4);
            CancelOrderbtn.Name = "CancelOrderbtn";
            CancelOrderbtn.Size = new Size(169, 48);
            CancelOrderbtn.TabIndex = 45;
            CancelOrderbtn.Text = "Cancel Order";
            CancelOrderbtn.UseVisualStyleBackColor = false;
            CancelOrderbtn.Click += CancelOrderbtn_Click;
            // 
            // orderSearchbox
            // 
            orderSearchbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderSearchbox.Location = new Point(651, 298);
            orderSearchbox.Margin = new Padding(3, 5, 3, 5);
            orderSearchbox.Multiline = true;
            orderSearchbox.Name = "orderSearchbox";
            orderSearchbox.PlaceholderText = "Search Order";
            orderSearchbox.Size = new Size(582, 41);
            orderSearchbox.TabIndex = 44;
            orderSearchbox.TextChanged += orderSearchbox_TextChanged;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel29);
            panel9.Controls.Add(panel28);
            panel9.Controls.Add(panel27);
            panel9.Controls.Add(panel26);
            panel9.Controls.Add(orderoverallBtn);
            panel9.Controls.Add(label11);
            panel9.Controls.Add(label8);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(38, 198);
            panel9.Name = "panel9";
            panel9.Size = new Size(1186, 69);
            panel9.TabIndex = 39;
            // 
            // panel29
            // 
            panel29.AutoSize = true;
            panel29.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel29.Controls.Add(textBox3);
            panel29.Location = new Point(832, 21);
            panel29.Name = "panel29";
            panel29.Size = new Size(43, 30);
            panel29.TabIndex = 50;
            panel29.Paint += panel29_Paint;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(37, 23);
            textBox3.TabIndex = 48;
            textBox3.Text = "880";
            // 
            // panel28
            // 
            panel28.AutoSize = true;
            panel28.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel28.Controls.Add(textBox2);
            panel28.Location = new Point(587, 22);
            panel28.Name = "panel28";
            panel28.Size = new Size(41, 30);
            panel28.TabIndex = 50;
            panel28.Paint += panel28_Paint;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(8, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(30, 23);
            textBox2.TabIndex = 48;
            textBox2.Text = "880";
            // 
            // panel27
            // 
            panel27.AutoSize = true;
            panel27.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel27.Controls.Add(textBox1);
            panel27.Location = new Point(341, 24);
            panel27.Name = "panel27";
            panel27.Size = new Size(44, 31);
            panel27.TabIndex = 49;
            panel27.Paint += panel27_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(5, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(36, 23);
            textBox1.TabIndex = 48;
            textBox1.Text = "880";
            // 
            // panel26
            // 
            panel26.AutoSize = true;
            panel26.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel26.Controls.Add(orderCountbox);
            panel26.Location = new Point(110, 26);
            panel26.Name = "panel26";
            panel26.Size = new Size(51, 30);
            panel26.TabIndex = 35;
            panel26.Paint += panel26_Paint;
            // 
            // orderCountbox
            // 
            orderCountbox.BackColor = SystemColors.Menu;
            orderCountbox.BorderStyle = BorderStyle.None;
            orderCountbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderCountbox.Location = new Point(8, 4);
            orderCountbox.Name = "orderCountbox";
            orderCountbox.Size = new Size(40, 23);
            orderCountbox.TabIndex = 48;
            orderCountbox.Text = "880";
            // 
            // orderoverallBtn
            // 
            orderoverallBtn.AutoSize = true;
            orderoverallBtn.BackColor = SystemColors.Menu;
            orderoverallBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderoverallBtn.Location = new Point(3, 24);
            orderoverallBtn.Name = "orderoverallBtn";
            orderoverallBtn.Size = new Size(107, 28);
            orderoverallBtn.TabIndex = 32;
            orderoverallBtn.Text = "All Orders";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Menu;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(664, 20);
            label11.Name = "label11";
            label11.Size = new Size(172, 28);
            label11.TabIndex = 37;
            label11.Text = "Cancelled Orders";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Menu;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(198, 24);
            label8.Name = "label8";
            label8.Size = new Size(141, 28);
            label8.TabIndex = 33;
            label8.Text = "Active Orders";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Menu;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(432, 21);
            label10.Name = "label10";
            label10.Size = new Size(157, 28);
            label10.TabIndex = 35;
            label10.Text = "Pending Orders";
            label10.Click += label10_Click;
            // 
            // viewOrderbtn
            // 
            viewOrderbtn.AutoSize = true;
            viewOrderbtn.BackColor = SystemColors.HighlightText;
            viewOrderbtn.FlatAppearance.BorderColor = Color.Gray;
            viewOrderbtn.FlatStyle = FlatStyle.System;
            viewOrderbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewOrderbtn.ForeColor = Color.Black;
            viewOrderbtn.ImageAlign = ContentAlignment.MiddleLeft;
            viewOrderbtn.ImageIndex = 0;
            viewOrderbtn.Location = new Point(245, 294);
            viewOrderbtn.Margin = new Padding(3, 4, 3, 4);
            viewOrderbtn.Name = "viewOrderbtn";
            viewOrderbtn.Size = new Size(173, 49);
            viewOrderbtn.TabIndex = 25;
            viewOrderbtn.Text = "View Order";
            viewOrderbtn.UseVisualStyleBackColor = false;
            viewOrderbtn.Click += viewOrderbtn_Click;
            // 
            // newOrderbtn
            // 
            newOrderbtn.AutoSize = true;
            newOrderbtn.BackColor = Color.LimeGreen;
            newOrderbtn.FlatAppearance.BorderColor = Color.Gray;
            newOrderbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newOrderbtn.ForeColor = Color.Transparent;
            newOrderbtn.ImageAlign = ContentAlignment.MiddleLeft;
            newOrderbtn.ImageIndex = 0;
            newOrderbtn.Location = new Point(1039, 32);
            newOrderbtn.Margin = new Padding(3, 4, 3, 4);
            newOrderbtn.Name = "newOrderbtn";
            newOrderbtn.Size = new Size(185, 56);
            newOrderbtn.TabIndex = 24;
            newOrderbtn.Text = "+ New Orders";
            newOrderbtn.UseVisualStyleBackColor = false;
            newOrderbtn.Click += newOrderbtn_Click;
            // 
            // ordlerlbl
            // 
            ordlerlbl.AutoSize = true;
            ordlerlbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ordlerlbl.Location = new Point(18, 24);
            ordlerlbl.Name = "ordlerlbl";
            ordlerlbl.Size = new Size(349, 38);
            ordlerlbl.TabIndex = 23;
            ordlerlbl.Text = "Sales Order Management";
            // 
            // saleReportbtn
            // 
            saleReportbtn.AutoSize = true;
            saleReportbtn.BackColor = SystemColors.HighlightText;
            saleReportbtn.FlatAppearance.BorderColor = Color.Gray;
            saleReportbtn.FlatStyle = FlatStyle.System;
            saleReportbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saleReportbtn.ForeColor = Color.Black;
            saleReportbtn.ImageAlign = ContentAlignment.MiddleLeft;
            saleReportbtn.ImageIndex = 0;
            saleReportbtn.Location = new Point(27, 931);
            saleReportbtn.Margin = new Padding(3, 4, 3, 4);
            saleReportbtn.Name = "saleReportbtn";
            saleReportbtn.Size = new Size(149, 49);
            saleReportbtn.TabIndex = 21;
            saleReportbtn.Text = "Sale Reports";
            saleReportbtn.UseVisualStyleBackColor = false;
            saleReportbtn.Visible = false;
            // 
            // editOrdersbtn
            // 
            editOrdersbtn.AutoSize = true;
            editOrdersbtn.BackColor = SystemColors.HighlightText;
            editOrdersbtn.FlatAppearance.BorderColor = Color.Gray;
            editOrdersbtn.FlatStyle = FlatStyle.System;
            editOrdersbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editOrdersbtn.ForeColor = Color.Black;
            editOrdersbtn.ImageAlign = ContentAlignment.MiddleLeft;
            editOrdersbtn.ImageIndex = 0;
            editOrdersbtn.Location = new Point(34, 291);
            editOrdersbtn.Margin = new Padding(3, 4, 3, 4);
            editOrdersbtn.Name = "editOrdersbtn";
            editOrdersbtn.Size = new Size(186, 51);
            editOrdersbtn.TabIndex = 20;
            editOrdersbtn.Text = "Edit Order";
            editOrdersbtn.UseVisualStyleBackColor = false;
            editOrdersbtn.Click += editOrdersbtn_Click;
            // 
            // orderdata
            // 
            orderdata.AllowUserToAddRows = false;
            orderdata.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            orderdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            orderdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            orderdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            orderdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderdata.Columns.AddRange(new DataGridViewColumn[] { ordercheckColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            orderdata.DefaultCellStyle = dataGridViewCellStyle3;
            orderdata.Location = new Point(21, 352);
            orderdata.Margin = new Padding(3, 4, 3, 4);
            orderdata.MultiSelect = false;
            orderdata.Name = "orderdata";
            orderdata.RowHeadersVisible = false;
            orderdata.RowHeadersWidth = 51;
            orderdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderdata.Size = new Size(1219, 555);
            orderdata.TabIndex = 27;
            orderdata.CellClick += orderdata_CellClick;
            orderdata.CellContentClick += orderdata_CellContentClick;
            // 
            // ordercheckColumn
            // 
            ordercheckColumn.FillWeight = 25F;
            ordercheckColumn.HeaderText = "Select";
            ordercheckColumn.MinimumWidth = 6;
            ordercheckColumn.Name = "ordercheckColumn";
            // 
            // contactIndexlbl
            // 
            contactIndexlbl.AutoSize = true;
            contactIndexlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactIndexlbl.Location = new Point(227, 27);
            contactIndexlbl.Name = "contactIndexlbl";
            contactIndexlbl.Size = new Size(100, 25);
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
            stocklbl.Location = new Point(21, 12);
            stocklbl.Name = "stocklbl";
            stocklbl.Size = new Size(221, 31);
            stocklbl.TabIndex = 2;
            stocklbl.Text = "Stock Management";
            stocklbl.Click += inventorylbl_Click;
            // 
            // stockSummarypnl
            // 
            stockSummarypnl.Controls.Add(stockDatapanel3);
            stockSummarypnl.Controls.Add(stockDatapanel1);
            stockSummarypnl.Controls.Add(stockDatapanel2);
            stockSummarypnl.Location = new Point(27, 68);
            stockSummarypnl.Margin = new Padding(3, 4, 3, 4);
            stockSummarypnl.Name = "stockSummarypnl";
            stockSummarypnl.Size = new Size(1203, 216);
            stockSummarypnl.TabIndex = 26;
            // 
            // stockDatapanel3
            // 
            stockDatapanel3.Controls.Add(stocklbl3);
            stockDatapanel3.Controls.Add(stockProductDatalbl3);
            stockDatapanel3.Location = new Point(853, 21);
            stockDatapanel3.Margin = new Padding(3, 4, 3, 4);
            stockDatapanel3.Name = "stockDatapanel3";
            stockDatapanel3.Size = new Size(304, 187);
            stockDatapanel3.TabIndex = 28;
            // 
            // stocklbl3
            // 
            stocklbl3.AutoSize = true;
            stocklbl3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stocklbl3.Location = new Point(46, 145);
            stocklbl3.Name = "stocklbl3";
            stocklbl3.Size = new Size(245, 37);
            stocklbl3.TabIndex = 5;
            stocklbl3.Text = "Total DemandStock";
            // 
            // stockProductDatalbl3
            // 
            stockProductDatalbl3.AutoSize = true;
            stockProductDatalbl3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockProductDatalbl3.Location = new Point(47, 57);
            stockProductDatalbl3.Name = "stockProductDatalbl3";
            stockProductDatalbl3.Size = new Size(246, 62);
            stockProductDatalbl3.TabIndex = 4;
            stockProductDatalbl3.Text = "LabelData";
            // 
            // stockDatapanel1
            // 
            stockDatapanel1.Controls.Add(stocklbl1);
            stockDatapanel1.Controls.Add(stockProductDatalbl1);
            stockDatapanel1.Location = new Point(48, 21);
            stockDatapanel1.Margin = new Padding(3, 4, 3, 4);
            stockDatapanel1.Name = "stockDatapanel1";
            stockDatapanel1.Size = new Size(304, 187);
            stockDatapanel1.TabIndex = 0;
            // 
            // stocklbl1
            // 
            stocklbl1.AutoSize = true;
            stocklbl1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stocklbl1.Location = new Point(21, 145);
            stocklbl1.Name = "stocklbl1";
            stocklbl1.Size = new Size(244, 37);
            stocklbl1.TabIndex = 1;
            stocklbl1.Text = "Number of Product";
            stocklbl1.Click += stocklbl1_Click;
            // 
            // stockProductDatalbl1
            // 
            stockProductDatalbl1.AutoSize = true;
            stockProductDatalbl1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockProductDatalbl1.Location = new Point(21, 57);
            stockProductDatalbl1.Name = "stockProductDatalbl1";
            stockProductDatalbl1.Size = new Size(246, 62);
            stockProductDatalbl1.TabIndex = 0;
            stockProductDatalbl1.Text = "LabelData";
            stockProductDatalbl1.Click += label1_Click;
            // 
            // stockDatapanel2
            // 
            stockDatapanel2.Controls.Add(stockProductDatalbl2);
            stockDatapanel2.Controls.Add(stocklbl2);
            stockDatapanel2.Location = new Point(442, 21);
            stockDatapanel2.Margin = new Padding(3, 4, 3, 4);
            stockDatapanel2.Name = "stockDatapanel2";
            stockDatapanel2.Size = new Size(304, 187);
            stockDatapanel2.TabIndex = 27;
            // 
            // stockProductDatalbl2
            // 
            stockProductDatalbl2.AutoSize = true;
            stockProductDatalbl2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockProductDatalbl2.Location = new Point(33, 57);
            stockProductDatalbl2.Name = "stockProductDatalbl2";
            stockProductDatalbl2.Size = new Size(246, 62);
            stockProductDatalbl2.TabIndex = 2;
            stockProductDatalbl2.Text = "LabelData";
            // 
            // stocklbl2
            // 
            stocklbl2.AutoSize = true;
            stocklbl2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stocklbl2.Location = new Point(46, 145);
            stocklbl2.Name = "stocklbl2";
            stocklbl2.Size = new Size(183, 37);
            stocklbl2.TabIndex = 2;
            stocklbl2.Text = "Total Quantity";
            // 
            // editProductbtn
            // 
            editProductbtn.AutoSize = true;
            editProductbtn.BackColor = SystemColors.HighlightText;
            editProductbtn.FlatAppearance.BorderColor = Color.Gray;
            editProductbtn.FlatStyle = FlatStyle.System;
            editProductbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editProductbtn.ForeColor = Color.Black;
            editProductbtn.ImageAlign = ContentAlignment.MiddleLeft;
            editProductbtn.ImageIndex = 0;
            editProductbtn.Location = new Point(22, 297);
            editProductbtn.Margin = new Padding(3, 4, 3, 4);
            editProductbtn.Name = "editProductbtn";
            editProductbtn.Size = new Size(185, 56);
            editProductbtn.TabIndex = 27;
            editProductbtn.Text = "Edit Product";
            editProductbtn.UseVisualStyleBackColor = false;
            editProductbtn.Click += editProductbtn_Click;
            // 
            // newProductbtn
            // 
            newProductbtn.AutoSize = true;
            newProductbtn.BackColor = Color.LimeGreen;
            newProductbtn.FlatAppearance.BorderColor = Color.Gray;
            newProductbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newProductbtn.ForeColor = Color.White;
            newProductbtn.ImageAlign = ContentAlignment.MiddleLeft;
            newProductbtn.ImageIndex = 0;
            newProductbtn.Location = new Point(1026, 13);
            newProductbtn.Margin = new Padding(3, 4, 3, 4);
            newProductbtn.Name = "newProductbtn";
            newProductbtn.Size = new Size(174, 48);
            newProductbtn.TabIndex = 28;
            newProductbtn.Text = "New Product";
            newProductbtn.UseVisualStyleBackColor = false;
            newProductbtn.Click += newProductbtn_Click;
            // 
            // stockData
            // 
            stockData.AllowUserToAddRows = false;
            stockData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            stockData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            stockData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            stockData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            stockData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stockData.Columns.AddRange(new DataGridViewColumn[] { stockcheckColumn });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            stockData.DefaultCellStyle = dataGridViewCellStyle6;
            stockData.Location = new Point(21, 368);
            stockData.Margin = new Padding(3, 5, 3, 5);
            stockData.Name = "stockData";
            stockData.RowHeadersVisible = false;
            stockData.RowHeadersWidth = 51;
            stockData.RowTemplate.Height = 24;
            stockData.ScrollBars = ScrollBars.None;
            stockData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stockData.Size = new Size(1194, 540);
            stockData.TabIndex = 3;
            stockData.CellClick += stockData_CellClick;
            stockData.CellContentClick += stockData_CellContentClick;
            // 
            // viewProductbtn
            // 
            viewProductbtn.AutoSize = true;
            viewProductbtn.BackColor = SystemColors.HighlightText;
            viewProductbtn.FlatAppearance.BorderColor = Color.Gray;
            viewProductbtn.FlatStyle = FlatStyle.System;
            viewProductbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewProductbtn.ForeColor = Color.Black;
            viewProductbtn.ImageAlign = ContentAlignment.MiddleLeft;
            viewProductbtn.ImageIndex = 0;
            viewProductbtn.Location = new Point(233, 297);
            viewProductbtn.Margin = new Padding(3, 4, 3, 4);
            viewProductbtn.Name = "viewProductbtn";
            viewProductbtn.Size = new Size(185, 56);
            viewProductbtn.TabIndex = 29;
            viewProductbtn.Text = "View Product";
            viewProductbtn.UseVisualStyleBackColor = false;
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
            accountSearchBtn.ButtonRoundRadius = 15;
            accountSearchBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountSearchBtn.ForeColor = Color.Black;
            accountSearchBtn.Location = new Point(769, 387);
            accountSearchBtn.Margin = new Padding(3, 4, 3, 4);
            accountSearchBtn.Name = "accountSearchBtn";
            accountSearchBtn.Size = new Size(177, 44);
            accountSearchBtn.TabIndex = 27;
            accountSearchBtn.Text = "Search";
            accountSearchBtn.Click += accountSearchBtn_Click;
            // 
            // contactpnl
            // 
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
            contactpnl.Location = new Point(201, 3);
            contactpnl.Margin = new Padding(3, 5, 3, 5);
            contactpnl.Name = "contactpnl";
            contactpnl.Size = new Size(1250, 1000);
            contactpnl.TabIndex = 1;
            contactpnl.Visible = false;
            contactpnl.Paint += contactpnl_Paint;
            // 
            // panel23
            // 
            panel23.Controls.Add(contactbtnFirstPage);
            panel23.Controls.Add(contactIndexlbl);
            panel23.Controls.Add(contactbtnPrevPage);
            panel23.Controls.Add(contactbtnLastPage);
            panel23.Controls.Add(contactbtnNxtPage);
            panel23.Location = new Point(664, 904);
            panel23.Margin = new Padding(3, 4, 3, 4);
            panel23.Name = "panel23";
            panel23.Size = new Size(566, 71);
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
            contactbtnFirstPage.ButtonRoundRadius = 15;
            contactbtnFirstPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactbtnFirstPage.ForeColor = Color.Black;
            contactbtnFirstPage.Location = new Point(21, 15);
            contactbtnFirstPage.Margin = new Padding(3, 5, 3, 5);
            contactbtnFirstPage.Name = "contactbtnFirstPage";
            contactbtnFirstPage.Size = new Size(79, 44);
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
            contactbtnPrevPage.ButtonRoundRadius = 15;
            contactbtnPrevPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactbtnPrevPage.ForeColor = Color.Black;
            contactbtnPrevPage.Location = new Point(123, 15);
            contactbtnPrevPage.Margin = new Padding(3, 5, 3, 5);
            contactbtnPrevPage.Name = "contactbtnPrevPage";
            contactbtnPrevPage.Size = new Size(79, 44);
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
            contactbtnLastPage.ButtonRoundRadius = 15;
            contactbtnLastPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactbtnLastPage.ForeColor = Color.Black;
            contactbtnLastPage.Location = new Point(466, 15);
            contactbtnLastPage.Margin = new Padding(3, 5, 3, 5);
            contactbtnLastPage.Name = "contactbtnLastPage";
            contactbtnLastPage.Size = new Size(79, 44);
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
            contactbtnNxtPage.ButtonRoundRadius = 15;
            contactbtnNxtPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactbtnNxtPage.ForeColor = Color.Black;
            contactbtnNxtPage.Location = new Point(362, 15);
            contactbtnNxtPage.Margin = new Padding(3, 5, 3, 5);
            contactbtnNxtPage.Name = "contactbtnNxtPage";
            contactbtnNxtPage.Size = new Size(79, 44);
            contactbtnNxtPage.TabIndex = 32;
            contactbtnNxtPage.Text = "Next";
            contactbtnNxtPage.Click += contactbtnNxtPage_Click;
            // 
            // panel22
            // 
            panel22.Controls.Add(panel24);
            panel22.Controls.Add(panel25);
            panel22.Location = new Point(587, 68);
            panel22.Margin = new Padding(3, 4, 3, 4);
            panel22.Name = "panel22";
            panel22.Size = new Size(657, 191);
            panel22.TabIndex = 39;
            // 
            // panel24
            // 
            panel24.Controls.Add(label35);
            panel24.Controls.Add(dealerDatalbl);
            panel24.Location = new Point(17, 15);
            panel24.Margin = new Padding(3, 4, 3, 4);
            panel24.Name = "panel24";
            panel24.Size = new Size(304, 160);
            panel24.TabIndex = 0;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label35.Location = new Point(27, 107);
            label35.Name = "label35";
            label35.Size = new Size(229, 37);
            label35.TabIndex = 1;
            label35.Text = "Number of Dealer";
            // 
            // dealerDatalbl
            // 
            dealerDatalbl.AutoSize = true;
            dealerDatalbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dealerDatalbl.Location = new Point(27, 19);
            dealerDatalbl.Name = "dealerDatalbl";
            dealerDatalbl.Size = new Size(246, 62);
            dealerDatalbl.TabIndex = 0;
            dealerDatalbl.Text = "LabelData";
            dealerDatalbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel25
            // 
            panel25.Controls.Add(supplierDatalbl);
            panel25.Controls.Add(label38);
            panel25.Location = new Point(343, 15);
            panel25.Margin = new Padding(3, 4, 3, 4);
            panel25.Name = "panel25";
            panel25.Size = new Size(304, 160);
            panel25.TabIndex = 27;
            // 
            // supplierDatalbl
            // 
            supplierDatalbl.AutoSize = true;
            supplierDatalbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplierDatalbl.Location = new Point(37, 19);
            supplierDatalbl.Name = "supplierDatalbl";
            supplierDatalbl.Size = new Size(246, 62);
            supplierDatalbl.TabIndex = 2;
            supplierDatalbl.Text = "LabelData";
            supplierDatalbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label38.Location = new Point(30, 107);
            label38.Name = "label38";
            label38.Size = new Size(250, 37);
            label38.TabIndex = 2;
            label38.Text = "Number of Supplier";
            // 
            // contactGroupBox
            // 
            contactGroupBox.Controls.Add(supplersbtn);
            contactGroupBox.Controls.Add(dealersbtn);
            contactGroupBox.Location = new Point(43, 79);
            contactGroupBox.Name = "contactGroupBox";
            contactGroupBox.Size = new Size(461, 91);
            contactGroupBox.TabIndex = 35;
            contactGroupBox.TabStop = false;
            contactGroupBox.Text = "Change to Contact information";
            // 
            // supplersbtn
            // 
            supplersbtn.AutoSize = true;
            supplersbtn.BackColor = SystemColors.HighlightText;
            supplersbtn.FlatAppearance.BorderColor = Color.Gray;
            supplersbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplersbtn.ForeColor = Color.Black;
            supplersbtn.ImageAlign = ContentAlignment.MiddleLeft;
            supplersbtn.ImageIndex = 0;
            supplersbtn.Location = new Point(216, 24);
            supplersbtn.Margin = new Padding(3, 4, 3, 4);
            supplersbtn.Name = "supplersbtn";
            supplersbtn.Size = new Size(224, 52);
            supplersbtn.TabIndex = 18;
            supplersbtn.Text = "Suppliers information";
            supplersbtn.UseVisualStyleBackColor = false;
            supplersbtn.Click += supplersbtn_Click;
            // 
            // dealersbtn
            // 
            dealersbtn.AutoSize = true;
            dealersbtn.BackColor = SystemColors.HighlightText;
            dealersbtn.FlatAppearance.BorderColor = Color.Gray;
            dealersbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dealersbtn.ForeColor = Color.Black;
            dealersbtn.ImageAlign = ContentAlignment.MiddleLeft;
            dealersbtn.ImageIndex = 0;
            dealersbtn.Location = new Point(8, 24);
            dealersbtn.Margin = new Padding(3, 4, 3, 4);
            dealersbtn.Name = "dealersbtn";
            dealersbtn.Size = new Size(206, 52);
            dealersbtn.TabIndex = 17;
            dealersbtn.Text = "Dealers information";
            dealersbtn.UseVisualStyleBackColor = false;
            dealersbtn.Click += dealersbtn_Click;
            // 
            // delContactbtn
            // 
            delContactbtn.AccessibleRole = AccessibleRole.None;
            delContactbtn.BackColor = Color.Red;
            delContactbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delContactbtn.ForeColor = Color.White;
            delContactbtn.Location = new Point(379, 263);
            delContactbtn.Margin = new Padding(5);
            delContactbtn.Name = "delContactbtn";
            delContactbtn.Size = new Size(91, 47);
            delContactbtn.TabIndex = 34;
            delContactbtn.Text = "Delete";
            delContactbtn.UseVisualStyleBackColor = false;
            delContactbtn.Click += delContactbtn_Click;
            // 
            // searchContactbtn
            // 
            searchContactbtn.Location = new Point(808, 285);
            searchContactbtn.Margin = new Padding(3, 4, 3, 4);
            searchContactbtn.Name = "searchContactbtn";
            searchContactbtn.PlaceholderText = "Search Name";
            searchContactbtn.Size = new Size(225, 27);
            searchContactbtn.TabIndex = 32;
            // 
            // newDealerbtn
            // 
            newDealerbtn.AccessibleRole = AccessibleRole.None;
            newDealerbtn.BackColor = SystemColors.Menu;
            newDealerbtn.FlatStyle = FlatStyle.System;
            newDealerbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newDealerbtn.ForeColor = Color.Black;
            newDealerbtn.Location = new Point(50, 263);
            newDealerbtn.Margin = new Padding(5);
            newDealerbtn.Name = "newDealerbtn";
            newDealerbtn.Size = new Size(154, 47);
            newDealerbtn.TabIndex = 31;
            newDealerbtn.Text = "New Dealer";
            newDealerbtn.UseVisualStyleBackColor = false;
            newDealerbtn.Click += newDealerbtn_Click;
            // 
            // searchSupplierbtn
            // 
            searchSupplierbtn.AutoSize = true;
            searchSupplierbtn.BackColor = SystemColors.HighlightText;
            searchSupplierbtn.FlatAppearance.BorderColor = Color.Gray;
            searchSupplierbtn.FlatStyle = FlatStyle.System;
            searchSupplierbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchSupplierbtn.ForeColor = Color.Black;
            searchSupplierbtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchSupplierbtn.ImageIndex = 0;
            searchSupplierbtn.Location = new Point(1053, 277);
            searchSupplierbtn.Margin = new Padding(3, 4, 3, 4);
            searchSupplierbtn.Name = "searchSupplierbtn";
            searchSupplierbtn.Size = new Size(177, 43);
            searchSupplierbtn.TabIndex = 38;
            searchSupplierbtn.Text = "Search";
            searchSupplierbtn.UseVisualStyleBackColor = false;
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
            searchDealerbtn.Location = new Point(1053, 277);
            searchDealerbtn.Margin = new Padding(3, 4, 3, 4);
            searchDealerbtn.Name = "searchDealerbtn";
            searchDealerbtn.Size = new Size(177, 43);
            searchDealerbtn.TabIndex = 33;
            searchDealerbtn.Text = "Search";
            searchDealerbtn.UseVisualStyleBackColor = false;
            searchDealerbtn.Click += searchDealerbtn_Click;
            // 
            // editSupplierbtn
            // 
            editSupplierbtn.AccessibleRole = AccessibleRole.None;
            editSupplierbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSupplierbtn.Location = new Point(215, 263);
            editSupplierbtn.Margin = new Padding(6, 7, 6, 7);
            editSupplierbtn.Name = "editSupplierbtn";
            editSupplierbtn.Size = new Size(154, 47);
            editSupplierbtn.TabIndex = 36;
            editSupplierbtn.Text = "Edit Supplier";
            editSupplierbtn.UseVisualStyleBackColor = true;
            editSupplierbtn.Click += editSupplierbtn_Click;
            // 
            // newSupplierbtn
            // 
            newSupplierbtn.AccessibleRole = AccessibleRole.None;
            newSupplierbtn.BackColor = SystemColors.Menu;
            newSupplierbtn.FlatStyle = FlatStyle.System;
            newSupplierbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newSupplierbtn.ForeColor = Color.Black;
            newSupplierbtn.Location = new Point(50, 263);
            newSupplierbtn.Margin = new Padding(5);
            newSupplierbtn.Name = "newSupplierbtn";
            newSupplierbtn.Size = new Size(154, 47);
            newSupplierbtn.TabIndex = 37;
            newSupplierbtn.Text = "New Supplier";
            newSupplierbtn.UseVisualStyleBackColor = false;
            newSupplierbtn.Click += newSupplierbtn_Click;
            // 
            // suppliersData
            // 
            suppliersData.AllowUserToAddRows = false;
            suppliersData.AllowUserToDeleteRows = false;
            suppliersData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            suppliersData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            suppliersData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suppliersData.Columns.AddRange(new DataGridViewColumn[] { suppliercheckColumn });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            suppliersData.DefaultCellStyle = dataGridViewCellStyle8;
            suppliersData.Location = new Point(43, 331);
            suppliersData.Margin = new Padding(3, 5, 3, 5);
            suppliersData.Name = "suppliersData";
            suppliersData.RowHeadersVisible = false;
            suppliersData.RowHeadersWidth = 51;
            suppliersData.RowTemplate.Height = 24;
            suppliersData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            suppliersData.Size = new Size(1200, 556);
            suppliersData.TabIndex = 41;
            suppliersData.CellContentClick += suppliersdata_CellClick;
            // 
            // dealersData
            // 
            dealersData.AllowUserToAddRows = false;
            dealersData.AllowUserToDeleteRows = false;
            dealersData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dealersData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dealersData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dealersData.Columns.AddRange(new DataGridViewColumn[] { dealercheckColumn });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dealersData.DefaultCellStyle = dataGridViewCellStyle10;
            dealersData.Location = new Point(43, 331);
            dealersData.Margin = new Padding(3, 5, 3, 5);
            dealersData.Name = "dealersData";
            dealersData.RowHeadersVisible = false;
            dealersData.RowHeadersWidth = 51;
            dealersData.RowTemplate.Height = 24;
            dealersData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dealersData.Size = new Size(1200, 556);
            dealersData.TabIndex = 19;
            dealersData.CellClick += dealersdata_CellClick;
            dealersData.CellContentClick += contactsdata_CellContentClick;
            // 
            // editDealerbtn
            // 
            editDealerbtn.AccessibleRole = AccessibleRole.None;
            editDealerbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editDealerbtn.Location = new Point(215, 263);
            editDealerbtn.Margin = new Padding(5);
            editDealerbtn.Name = "editDealerbtn";
            editDealerbtn.Size = new Size(154, 47);
            editDealerbtn.TabIndex = 29;
            editDealerbtn.Text = "Edit Dealer";
            editDealerbtn.UseVisualStyleBackColor = true;
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
            panel43.Controls.Add(button21);
            panel43.Controls.Add(outstandingCancelbtn);
            panel43.Location = new Point(0, 164);
            panel43.Name = "panel43";
            panel43.Size = new Size(1219, 803);
            panel43.TabIndex = 32;
            // 
            // outstandingViewData
            // 
            outstandingViewData.AllowUserToAddRows = false;
            outstandingViewData.AllowUserToDeleteRows = false;
            outstandingViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            outstandingViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            outstandingViewData.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, FollowUp, UnitPrice });
            outstandingViewData.Location = new Point(72, 305);
            outstandingViewData.Margin = new Padding(3, 5, 3, 5);
            outstandingViewData.Name = "outstandingViewData";
            outstandingViewData.ReadOnly = true;
            outstandingViewData.RowHeadersWidth = 51;
            outstandingViewData.RowTemplate.Height = 24;
            outstandingViewData.Size = new Size(953, 379);
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
            panel42.Controls.Add(outstandingDealerIDlbl);
            panel42.Controls.Add(outstandingDealerNamelbl);
            panel42.Controls.Add(outstandingDeliveryAddresslbl);
            panel42.Controls.Add(outstandingContactNamelbl);
            panel42.Controls.Add(outstandingEmaillbl);
            panel42.Controls.Add(outstandingPhonelbl);
            panel42.Location = new Point(72, 4);
            panel42.Margin = new Padding(3, 4, 3, 4);
            panel42.Name = "panel42";
            panel42.Size = new Size(954, 284);
            panel42.TabIndex = 33;
            // 
            // outstandingDealerIDlbl
            // 
            outstandingDealerIDlbl.AutoSize = true;
            outstandingDealerIDlbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingDealerIDlbl.Location = new Point(109, 32);
            outstandingDealerIDlbl.Name = "outstandingDealerIDlbl";
            outstandingDealerIDlbl.Size = new Size(113, 28);
            outstandingDealerIDlbl.TabIndex = 24;
            outstandingDealerIDlbl.Text = "Dealer ID : ";
            // 
            // outstandingDealerNamelbl
            // 
            outstandingDealerNamelbl.AutoSize = true;
            outstandingDealerNamelbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingDealerNamelbl.Location = new Point(78, 75);
            outstandingDealerNamelbl.Name = "outstandingDealerNamelbl";
            outstandingDealerNamelbl.Size = new Size(147, 28);
            outstandingDealerNamelbl.TabIndex = 27;
            outstandingDealerNamelbl.Text = "Dealer Name : ";
            // 
            // outstandingDeliveryAddresslbl
            // 
            outstandingDeliveryAddresslbl.AutoSize = true;
            outstandingDeliveryAddresslbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingDeliveryAddresslbl.Location = new Point(509, 32);
            outstandingDeliveryAddresslbl.Name = "outstandingDeliveryAddresslbl";
            outstandingDeliveryAddresslbl.Size = new Size(182, 28);
            outstandingDeliveryAddresslbl.TabIndex = 31;
            outstandingDeliveryAddresslbl.Text = "Delivery Address : ";
            // 
            // outstandingContactNamelbl
            // 
            outstandingContactNamelbl.AutoSize = true;
            outstandingContactNamelbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingContactNamelbl.Location = new Point(66, 128);
            outstandingContactNamelbl.Name = "outstandingContactNamelbl";
            outstandingContactNamelbl.Size = new Size(158, 28);
            outstandingContactNamelbl.TabIndex = 28;
            outstandingContactNamelbl.Text = "Contact Name : ";
            // 
            // outstandingEmaillbl
            // 
            outstandingEmaillbl.AutoSize = true;
            outstandingEmaillbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingEmaillbl.Location = new Point(69, 217);
            outstandingEmaillbl.Name = "outstandingEmaillbl";
            outstandingEmaillbl.Size = new Size(156, 28);
            outstandingEmaillbl.TabIndex = 30;
            outstandingEmaillbl.Text = "Email Address : ";
            // 
            // outstandingPhonelbl
            // 
            outstandingPhonelbl.AutoSize = true;
            outstandingPhonelbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingPhonelbl.Location = new Point(61, 173);
            outstandingPhonelbl.Name = "outstandingPhonelbl";
            outstandingPhonelbl.Size = new Size(169, 28);
            outstandingPhonelbl.TabIndex = 29;
            outstandingPhonelbl.Text = "Phone Number : ";
            // 
            // button23
            // 
            button23.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button23.Location = new Point(795, 709);
            button23.Name = "button23";
            button23.Size = new Size(158, 51);
            button23.TabIndex = 18;
            button23.Text = "Next";
            button23.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button21.Location = new Point(461, 709);
            button21.Name = "button21";
            button21.Size = new Size(158, 51);
            button21.TabIndex = 20;
            button21.Text = "Complete";
            button21.UseVisualStyleBackColor = true;
            // 
            // outstandingCancelbtn
            // 
            outstandingCancelbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingCancelbtn.Location = new Point(120, 707);
            outstandingCancelbtn.Name = "outstandingCancelbtn";
            outstandingCancelbtn.Size = new Size(158, 51);
            outstandingCancelbtn.TabIndex = 19;
            outstandingCancelbtn.Text = "Cancel";
            outstandingCancelbtn.UseVisualStyleBackColor = true;
            // 
            // panel44
            // 
            panel44.BackColor = Color.White;
            panel44.Controls.Add(outstandingOrderIDlbl);
            panel44.Controls.Add(outstandingIDlbl);
            panel44.Controls.Add(label36);
            panel44.Controls.Add(outstandingBackbtn);
            panel44.Location = new Point(0, 5);
            panel44.Name = "panel44";
            panel44.Size = new Size(1219, 133);
            panel44.TabIndex = 33;
            // 
            // outstandingOrderIDlbl
            // 
            outstandingOrderIDlbl.AutoSize = true;
            outstandingOrderIDlbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingOrderIDlbl.Location = new Point(431, 92);
            outstandingOrderIDlbl.Name = "outstandingOrderIDlbl";
            outstandingOrderIDlbl.Size = new Size(125, 28);
            outstandingOrderIDlbl.TabIndex = 32;
            outstandingOrderIDlbl.Text = "Order ID :  #";
            // 
            // outstandingIDlbl
            // 
            outstandingIDlbl.AutoSize = true;
            outstandingIDlbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingIDlbl.Location = new Point(381, 29);
            outstandingIDlbl.Name = "outstandingIDlbl";
            outstandingIDlbl.Size = new Size(249, 37);
            outstandingIDlbl.TabIndex = 22;
            outstandingIDlbl.Text = "Outstanding ID : #";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(22, 11);
            label36.Name = "label36";
            label36.Size = new Size(139, 31);
            label36.TabIndex = 21;
            label36.Text = "Oustanding";
            // 
            // outstandingBackbtn
            // 
            outstandingBackbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingBackbtn.Location = new Point(822, 23);
            outstandingBackbtn.Name = "outstandingBackbtn";
            outstandingBackbtn.Size = new Size(158, 51);
            outstandingBackbtn.TabIndex = 23;
            outstandingBackbtn.Text = "Back";
            outstandingBackbtn.UseVisualStyleBackColor = true;
            outstandingBackbtn.Click += outstandingBackbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 16);
            label2.Name = "label2";
            label2.Size = new Size(69, 32);
            label2.TabIndex = 10;
            label2.Text = "From";
            // 
            // settingpnl
            // 
            settingpnl.Controls.Add(reportlbl);
            settingpnl.Location = new Point(201, 3);
            settingpnl.Margin = new Padding(3, 4, 3, 4);
            settingpnl.Name = "settingpnl";
            settingpnl.Size = new Size(1250, 1051);
            settingpnl.TabIndex = 5;
            settingpnl.Visible = false;
            // 
            // reportlbl
            // 
            reportlbl.AutoSize = true;
            reportlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportlbl.Location = new Point(18, 24);
            reportlbl.Name = "reportlbl";
            reportlbl.Size = new Size(97, 31);
            reportlbl.TabIndex = 6;
            reportlbl.Text = "Reports";
            // 
            // userspnl
            // 
            userspnl.Controls.Add(accountSearchBox);
            userspnl.Controls.Add(panel7);
            userspnl.Controls.Add(accountPaginationpnl);
            userspnl.Controls.Add(panel3);
            userspnl.Controls.Add(accountPageSizeComboBox);
            userspnl.Controls.Add(accountPaginglbl);
            userspnl.Controls.Add(enableAccountbtn);
            userspnl.Controls.Add(disableAccountbtn);
            userspnl.Controls.Add(accountSearchBtn);
            userspnl.Controls.Add(newAccountbtn);
            userspnl.Controls.Add(viewAccountbtn);
            userspnl.Controls.Add(editAccountbtn);
            userspnl.Controls.Add(userData);
            userspnl.Controls.Add(userslbl);
            userspnl.Location = new Point(201, 3);
            userspnl.Margin = new Padding(3, 4, 3, 4);
            userspnl.Name = "userspnl";
            userspnl.Size = new Size(1250, 1051);
            userspnl.TabIndex = 3;
            userspnl.Visible = false;
            // 
            // accountSearchBox
            // 
            accountSearchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountSearchBox.Location = new Point(35, 389);
            accountSearchBox.Margin = new Padding(3, 5, 3, 5);
            accountSearchBox.Multiline = true;
            accountSearchBox.Name = "accountSearchBox";
            accountSearchBox.PlaceholderText = "   Search Username";
            accountSearchBox.Size = new Size(718, 41);
            accountSearchBox.TabIndex = 41;
            // 
            // panel7
            // 
            panel7.Controls.Add(accountbtnFirstPage);
            panel7.Controls.Add(accountIndexlbl);
            panel7.Controls.Add(accountbtnPrevPage);
            panel7.Controls.Add(accountbtnLastPage);
            panel7.Controls.Add(accountbtnNxtPage);
            panel7.Location = new Point(661, 896);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(566, 71);
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
            accountbtnFirstPage.ButtonRoundRadius = 15;
            accountbtnFirstPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountbtnFirstPage.ForeColor = Color.Black;
            accountbtnFirstPage.Location = new Point(21, 15);
            accountbtnFirstPage.Margin = new Padding(3, 5, 3, 5);
            accountbtnFirstPage.Name = "accountbtnFirstPage";
            accountbtnFirstPage.Size = new Size(79, 44);
            accountbtnFirstPage.TabIndex = 31;
            accountbtnFirstPage.Text = "First";
            accountbtnFirstPage.Click += accountbtnFirstPage_Click;
            // 
            // accountIndexlbl
            // 
            accountIndexlbl.AutoSize = true;
            accountIndexlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountIndexlbl.Location = new Point(227, 27);
            accountIndexlbl.Name = "accountIndexlbl";
            accountIndexlbl.Size = new Size(100, 25);
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
            accountbtnPrevPage.ButtonRoundRadius = 15;
            accountbtnPrevPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountbtnPrevPage.ForeColor = Color.Black;
            accountbtnPrevPage.Location = new Point(123, 15);
            accountbtnPrevPage.Margin = new Padding(3, 5, 3, 5);
            accountbtnPrevPage.Name = "accountbtnPrevPage";
            accountbtnPrevPage.Size = new Size(79, 44);
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
            accountbtnLastPage.ButtonRoundRadius = 15;
            accountbtnLastPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountbtnLastPage.ForeColor = Color.Black;
            accountbtnLastPage.Location = new Point(466, 15);
            accountbtnLastPage.Margin = new Padding(3, 5, 3, 5);
            accountbtnLastPage.Name = "accountbtnLastPage";
            accountbtnLastPage.Size = new Size(79, 44);
            accountbtnLastPage.TabIndex = 34;
            accountbtnLastPage.Text = "Last";
            accountbtnLastPage.Click += accountbtnLastPage_Click;
            // 
            // accountbtnNxtPage
            // 
            accountbtnNxtPage.BackColor = SystemColors.HighlightText;
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
            accountbtnNxtPage.ButtonRoundRadius = 15;
            accountbtnNxtPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountbtnNxtPage.ForeColor = Color.Black;
            accountbtnNxtPage.Location = new Point(362, 15);
            accountbtnNxtPage.Margin = new Padding(3, 5, 3, 5);
            accountbtnNxtPage.Name = "accountbtnNxtPage";
            accountbtnNxtPage.Size = new Size(79, 44);
            accountbtnNxtPage.TabIndex = 32;
            accountbtnNxtPage.Text = "Next";
            accountbtnNxtPage.Click += accountbtnNxtPage_Click;
            // 
            // accountPaginationpnl
            // 
            accountPaginationpnl.Location = new Point(35, 904);
            accountPaginationpnl.Margin = new Padding(3, 4, 3, 4);
            accountPaginationpnl.Name = "accountPaginationpnl";
            accountPaginationpnl.Size = new Size(601, 61);
            accountPaginationpnl.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(27, 76);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1200, 204);
            panel3.TabIndex = 40;
            // 
            // panel4
            // 
            panel4.Controls.Add(label7);
            panel4.Controls.Add(accountUserCountlbl3);
            panel4.Location = new Point(853, 21);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(296, 173);
            panel4.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 124);
            label7.Name = "label7";
            label7.Size = new Size(142, 37);
            label7.TabIndex = 5;
            label7.Text = "New Users";
            // 
            // accountUserCountlbl3
            // 
            accountUserCountlbl3.AutoSize = true;
            accountUserCountlbl3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountUserCountlbl3.Location = new Point(46, 41);
            accountUserCountlbl3.Name = "accountUserCountlbl3";
            accountUserCountlbl3.Size = new Size(246, 62);
            accountUserCountlbl3.TabIndex = 4;
            accountUserCountlbl3.Text = "LabelData";
            // 
            // panel5
            // 
            panel5.Controls.Add(label9);
            panel5.Controls.Add(accountUserCountlbl);
            panel5.Location = new Point(48, 21);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(289, 176);
            panel5.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(35, 117);
            label9.Name = "label9";
            label9.Size = new Size(145, 37);
            label9.TabIndex = 1;
            label9.Text = "Total Users";
            // 
            // accountUserCountlbl
            // 
            accountUserCountlbl.AutoSize = true;
            accountUserCountlbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountUserCountlbl.Location = new Point(31, 37);
            accountUserCountlbl.Name = "accountUserCountlbl";
            accountUserCountlbl.Size = new Size(246, 62);
            accountUserCountlbl.TabIndex = 0;
            accountUserCountlbl.Text = "LabelData";
            // 
            // panel6
            // 
            panel6.Controls.Add(accountUserCountlbl2);
            panel6.Controls.Add(label12);
            panel6.Location = new Point(442, 21);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(295, 173);
            panel6.TabIndex = 27;
            // 
            // accountUserCountlbl2
            // 
            accountUserCountlbl2.AutoSize = true;
            accountUserCountlbl2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountUserCountlbl2.Location = new Point(38, 40);
            accountUserCountlbl2.Name = "accountUserCountlbl2";
            accountUserCountlbl2.Size = new Size(246, 62);
            accountUserCountlbl2.TabIndex = 2;
            accountUserCountlbl2.Text = "LabelData";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(48, 117);
            label12.Name = "label12";
            label12.Size = new Size(160, 37);
            label12.TabIndex = 2;
            label12.Text = "Active Users";
            // 
            // accountPageSizeComboBox
            // 
            accountPageSizeComboBox.FormattingEnabled = true;
            accountPageSizeComboBox.Items.AddRange(new object[] { "10", "15", "25" });
            accountPageSizeComboBox.Location = new Point(1153, 396);
            accountPageSizeComboBox.Margin = new Padding(3, 4, 3, 4);
            accountPageSizeComboBox.Name = "accountPageSizeComboBox";
            accountPageSizeComboBox.Size = new Size(46, 28);
            accountPageSizeComboBox.TabIndex = 36;
            // 
            // accountPaginglbl
            // 
            accountPaginglbl.AutoSize = true;
            accountPaginglbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountPaginglbl.Location = new Point(1011, 393);
            accountPaginglbl.Name = "accountPaginglbl";
            accountPaginglbl.Size = new Size(144, 28);
            accountPaginglbl.TabIndex = 35;
            accountPaginglbl.Text = "Rows per page:";
            // 
            // enableAccountbtn
            // 
            enableAccountbtn.AccessibleRole = AccessibleRole.None;
            enableAccountbtn.BackColor = Color.LimeGreen;
            enableAccountbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enableAccountbtn.ForeColor = Color.White;
            enableAccountbtn.Location = new Point(385, 316);
            enableAccountbtn.Margin = new Padding(5);
            enableAccountbtn.Name = "enableAccountbtn";
            enableAccountbtn.Size = new Size(91, 47);
            enableAccountbtn.TabIndex = 29;
            enableAccountbtn.Text = "Enable";
            enableAccountbtn.UseVisualStyleBackColor = false;
            enableAccountbtn.Click += enableAccountbtn_Click;
            // 
            // disableAccountbtn
            // 
            disableAccountbtn.AccessibleRole = AccessibleRole.None;
            disableAccountbtn.BackColor = Color.Red;
            disableAccountbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            disableAccountbtn.ForeColor = Color.White;
            disableAccountbtn.Location = new Point(493, 316);
            disableAccountbtn.Margin = new Padding(5);
            disableAccountbtn.Name = "disableAccountbtn";
            disableAccountbtn.Size = new Size(91, 47);
            disableAccountbtn.TabIndex = 28;
            disableAccountbtn.Text = "Disable";
            disableAccountbtn.UseVisualStyleBackColor = false;
            disableAccountbtn.Click += disableAccountbtn_Click;
            // 
            // newAccountbtn
            // 
            newAccountbtn.AccessibleRole = AccessibleRole.None;
            newAccountbtn.BackColor = Color.LimeGreen;
            newAccountbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newAccountbtn.ForeColor = Color.White;
            newAccountbtn.Location = new Point(1032, 11);
            newAccountbtn.Margin = new Padding(5);
            newAccountbtn.Name = "newAccountbtn";
            newAccountbtn.Size = new Size(159, 47);
            newAccountbtn.TabIndex = 24;
            newAccountbtn.Text = "New Account";
            newAccountbtn.UseVisualStyleBackColor = false;
            newAccountbtn.Click += newAccountbtn_Click;
            // 
            // viewAccountbtn
            // 
            viewAccountbtn.AccessibleRole = AccessibleRole.None;
            viewAccountbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewAccountbtn.Location = new Point(208, 316);
            viewAccountbtn.Margin = new Padding(5);
            viewAccountbtn.Name = "viewAccountbtn";
            viewAccountbtn.Size = new Size(159, 47);
            viewAccountbtn.TabIndex = 23;
            viewAccountbtn.Text = "View Account";
            viewAccountbtn.UseVisualStyleBackColor = true;
            viewAccountbtn.Click += viewAccountbtn_Click;
            // 
            // editAccountbtn
            // 
            editAccountbtn.AccessibleRole = AccessibleRole.None;
            editAccountbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editAccountbtn.Location = new Point(35, 316);
            editAccountbtn.Margin = new Padding(5);
            editAccountbtn.Name = "editAccountbtn";
            editAccountbtn.Size = new Size(159, 47);
            editAccountbtn.TabIndex = 22;
            editAccountbtn.Text = "Edit Account";
            editAccountbtn.UseVisualStyleBackColor = true;
            editAccountbtn.Click += editAccountbtn_Click;
            // 
            // userData
            // 
            userData.AllowUserToAddRows = false;
            userData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = Color.Gainsboro;
            dataGridViewCellStyle11.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            userData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            userData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            userData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            userData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userData.Columns.AddRange(new DataGridViewColumn[] { usercheckColumn });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            userData.DefaultCellStyle = dataGridViewCellStyle13;
            userData.GridColor = SystemColors.WindowText;
            userData.Location = new Point(27, 443);
            userData.Margin = new Padding(3, 5, 3, 5);
            userData.Name = "userData";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            userData.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            userData.RowHeadersVisible = false;
            userData.RowHeadersWidth = 51;
            userData.RowTemplate.Height = 24;
            userData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userData.Size = new Size(1215, 435);
            userData.TabIndex = 1;
            userData.CellClick += userData_CellClick;
            userData.CellContentClick += userData_CellContentClick;
            // 
            // userslbl
            // 
            userslbl.AutoSize = true;
            userslbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userslbl.Location = new Point(18, 24);
            userslbl.Name = "userslbl";
            userslbl.Size = new Size(220, 31);
            userslbl.TabIndex = 0;
            userslbl.Text = "Users Management";
            // 
            // inventorypnl
            // 
            inventorypnl.Controls.Add(button8);
            inventorypnl.Controls.Add(panel8);
            inventorypnl.Controls.Add(delProductbtn);
            inventorypnl.Controls.Add(stockSearchBox);
            inventorypnl.Controls.Add(stocklbl);
            inventorypnl.Controls.Add(stockData);
            inventorypnl.Controls.Add(editProductbtn);
            inventorypnl.Controls.Add(newProductbtn);
            inventorypnl.Controls.Add(viewProductbtn);
            inventorypnl.Controls.Add(stockSummarypnl);
            inventorypnl.Location = new Point(201, 3);
            inventorypnl.Margin = new Padding(3, 4, 3, 4);
            inventorypnl.Name = "inventorypnl";
            inventorypnl.Size = new Size(1247, 1051);
            inventorypnl.TabIndex = 16;
            inventorypnl.Visible = false;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.BackColor = SystemColors.HighlightText;
            button8.FlatAppearance.BorderColor = Color.Gray;
            button8.FlatStyle = FlatStyle.System;
            button8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Black;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.ImageIndex = 0;
            button8.Location = new Point(818, 3);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(146, 56);
            button8.TabIndex = 34;
            button8.Text = "Zoom In/Out";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(stockFirstPagebtn);
            panel8.Controls.Add(StockpageNumlbl);
            panel8.Controls.Add(sotckPrevPagebtn);
            panel8.Controls.Add(sotckLastPagebtn);
            panel8.Controls.Add(sotckNextPagebtn);
            panel8.Location = new Point(634, 924);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(566, 67);
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
            stockFirstPagebtn.ButtonRoundRadius = 15;
            stockFirstPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockFirstPagebtn.ForeColor = Color.Black;
            stockFirstPagebtn.Location = new Point(70, 9);
            stockFirstPagebtn.Margin = new Padding(3, 4, 3, 4);
            stockFirstPagebtn.Name = "stockFirstPagebtn";
            stockFirstPagebtn.Size = new Size(74, 44);
            stockFirstPagebtn.TabIndex = 31;
            stockFirstPagebtn.Text = "First";
            stockFirstPagebtn.Click += stockFirstPagebtn_Click;
            // 
            // StockpageNumlbl
            // 
            StockpageNumlbl.AutoSize = true;
            StockpageNumlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StockpageNumlbl.Location = new Point(229, 19);
            StockpageNumlbl.Name = "StockpageNumlbl";
            StockpageNumlbl.Size = new Size(100, 25);
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
            sotckPrevPagebtn.ButtonRoundRadius = 15;
            sotckPrevPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sotckPrevPagebtn.ForeColor = Color.Black;
            sotckPrevPagebtn.Location = new Point(155, 8);
            sotckPrevPagebtn.Margin = new Padding(3, 4, 3, 4);
            sotckPrevPagebtn.Name = "sotckPrevPagebtn";
            sotckPrevPagebtn.Size = new Size(72, 44);
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
            sotckLastPagebtn.ButtonRoundRadius = 15;
            sotckLastPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sotckLastPagebtn.ForeColor = Color.Black;
            sotckLastPagebtn.Location = new Point(459, 9);
            sotckLastPagebtn.Margin = new Padding(3, 4, 3, 4);
            sotckLastPagebtn.Name = "sotckLastPagebtn";
            sotckLastPagebtn.Size = new Size(75, 44);
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
            sotckNextPagebtn.ButtonRoundRadius = 15;
            sotckNextPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sotckNextPagebtn.ForeColor = Color.Black;
            sotckNextPagebtn.Location = new Point(374, 9);
            sotckNextPagebtn.Margin = new Padding(3, 4, 3, 4);
            sotckNextPagebtn.Name = "sotckNextPagebtn";
            sotckNextPagebtn.Size = new Size(80, 44);
            sotckNextPagebtn.TabIndex = 32;
            sotckNextPagebtn.Text = "Next";
            sotckNextPagebtn.Click += sotckNextPagebtn_Click;
            // 
            // delProductbtn
            // 
            delProductbtn.BackColor = Color.Red;
            delProductbtn.FlatAppearance.BorderSize = 0;
            delProductbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            delProductbtn.ForeColor = Color.White;
            delProductbtn.Location = new Point(455, 295);
            delProductbtn.Margin = new Padding(3, 4, 3, 4);
            delProductbtn.Name = "delProductbtn";
            delProductbtn.Size = new Size(185, 56);
            delProductbtn.TabIndex = 31;
            delProductbtn.Text = "Delete Product";
            delProductbtn.UseVisualStyleBackColor = false;
            delProductbtn.Click += delProductbtn_Click;
            // 
            // stockSearchBox
            // 
            stockSearchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockSearchBox.Location = new Point(719, 301);
            stockSearchBox.Margin = new Padding(3, 5, 3, 5);
            stockSearchBox.Multiline = true;
            stockSearchBox.Name = "stockSearchBox";
            stockSearchBox.PlaceholderText = "Search Product Name or ID";
            stockSearchBox.Size = new Size(509, 41);
            stockSearchBox.TabIndex = 30;
            stockSearchBox.TextChanged += stockSearchBox_TextChanged;
            // 
            // dashboardpnl
            // 
            dashboardpnl.BackgroundImage = Properties.Resources.dashboard_background;
            dashboardpnl.BackgroundImageLayout = ImageLayout.Stretch;
            dashboardpnl.Controls.Add(label1);
            dashboardpnl.Location = new Point(201, 3);
            dashboardpnl.Margin = new Padding(3, 4, 3, 4);
            dashboardpnl.Name = "dashboardpnl";
            dashboardpnl.Size = new Size(1301, 1051);
            dashboardpnl.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Calibri", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 116);
            label1.Name = "label1";
            label1.Size = new Size(636, 49);
            label1.TabIndex = 2;
            label1.Text = "Welcome to the LM Company System";
            // 
            // logpnl
            // 
            logpnl.Controls.Add(panel18);
            logpnl.Controls.Add(panel19);
            logpnl.Controls.Add(auditLogdata);
            logpnl.Controls.Add(button19);
            logpnl.Controls.Add(loglbl);
            logpnl.Location = new Point(201, 3);
            logpnl.Margin = new Padding(3, 4, 3, 4);
            logpnl.Name = "logpnl";
            logpnl.Size = new Size(1250, 1051);
            logpnl.TabIndex = 26;
            logpnl.Visible = false;
            // 
            // panel18
            // 
            panel18.Controls.Add(roundedButton21);
            panel18.Controls.Add(label27);
            panel18.Controls.Add(roundedButton22);
            panel18.Controls.Add(roundedButton23);
            panel18.Controls.Add(roundedButton24);
            panel18.Location = new Point(655, 943);
            panel18.Margin = new Padding(3, 4, 3, 4);
            panel18.Name = "panel18";
            panel18.Size = new Size(566, 67);
            panel18.TabIndex = 38;
            // 
            // roundedButton21
            // 
            roundedButton21.BackColor = SystemColors.Menu;
            roundedButton21.BackColor2 = Color.White;
            roundedButton21.BorderColor = Color.Tomato;
            roundedButton21.BorderSize = 2;
            roundedButton21.ButtonBorderColor = Color.Gray;
            roundedButton21.ButtonHighlightColor = Color.Empty;
            roundedButton21.ButtonHighlightColor2 = Color.Empty;
            roundedButton21.ButtonHighlightForeColor = Color.Black;
            roundedButton21.ButtonPressedColor = Color.White;
            roundedButton21.ButtonPressedColor2 = Color.Empty;
            roundedButton21.ButtonPressedForeColor = Color.Gray;
            roundedButton21.ButtonRoundRadius = 15;
            roundedButton21.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton21.ForeColor = Color.Black;
            roundedButton21.Location = new Point(70, 9);
            roundedButton21.Margin = new Padding(3, 4, 3, 4);
            roundedButton21.Name = "roundedButton21";
            roundedButton21.Size = new Size(79, 44);
            roundedButton21.TabIndex = 31;
            roundedButton21.Text = "First";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(251, 21);
            label27.Name = "label27";
            label27.Size = new Size(100, 25);
            label27.TabIndex = 3;
            label27.Text = "LabelData";
            // 
            // roundedButton22
            // 
            roundedButton22.AccessibleRole = AccessibleRole.None;
            roundedButton22.BackColor = SystemColors.Menu;
            roundedButton22.BackColor2 = Color.White;
            roundedButton22.BorderColor = Color.Tomato;
            roundedButton22.BorderSize = 2;
            roundedButton22.ButtonBorderColor = Color.Gray;
            roundedButton22.ButtonHighlightColor = Color.Empty;
            roundedButton22.ButtonHighlightColor2 = Color.Empty;
            roundedButton22.ButtonHighlightForeColor = Color.Black;
            roundedButton22.ButtonPressedColor = Color.White;
            roundedButton22.ButtonPressedColor2 = Color.Empty;
            roundedButton22.ButtonPressedForeColor = Color.Gray;
            roundedButton22.ButtonRoundRadius = 15;
            roundedButton22.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton22.ForeColor = Color.Black;
            roundedButton22.Location = new Point(167, 9);
            roundedButton22.Margin = new Padding(3, 4, 3, 4);
            roundedButton22.Name = "roundedButton22";
            roundedButton22.Size = new Size(72, 44);
            roundedButton22.TabIndex = 33;
            roundedButton22.Text = "Prev";
            // 
            // roundedButton23
            // 
            roundedButton23.BackColor = SystemColors.Menu;
            roundedButton23.BackColor2 = Color.White;
            roundedButton23.BorderColor = Color.White;
            roundedButton23.BorderSize = 2;
            roundedButton23.ButtonBorderColor = Color.Gray;
            roundedButton23.ButtonHighlightColor = Color.Empty;
            roundedButton23.ButtonHighlightColor2 = Color.Empty;
            roundedButton23.ButtonHighlightForeColor = Color.Black;
            roundedButton23.ButtonPressedColor = Color.White;
            roundedButton23.ButtonPressedColor2 = Color.Empty;
            roundedButton23.ButtonPressedForeColor = Color.Gray;
            roundedButton23.ButtonRoundRadius = 15;
            roundedButton23.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton23.ForeColor = Color.Black;
            roundedButton23.Location = new Point(454, 9);
            roundedButton23.Margin = new Padding(3, 4, 3, 4);
            roundedButton23.Name = "roundedButton23";
            roundedButton23.Size = new Size(75, 44);
            roundedButton23.TabIndex = 34;
            roundedButton23.Text = "Last";
            // 
            // roundedButton24
            // 
            roundedButton24.BackColor = SystemColors.HighlightText;
            roundedButton24.BackColor2 = Color.White;
            roundedButton24.BorderColor = Color.Tomato;
            roundedButton24.BorderSize = 2;
            roundedButton24.ButtonBorderColor = Color.Gray;
            roundedButton24.ButtonHighlightColor = Color.Empty;
            roundedButton24.ButtonHighlightColor2 = Color.Empty;
            roundedButton24.ButtonHighlightForeColor = Color.Black;
            roundedButton24.ButtonPressedColor = Color.White;
            roundedButton24.ButtonPressedColor2 = Color.Empty;
            roundedButton24.ButtonPressedForeColor = Color.Gray;
            roundedButton24.ButtonRoundRadius = 15;
            roundedButton24.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton24.ForeColor = Color.Black;
            roundedButton24.Location = new Point(354, 9);
            roundedButton24.Margin = new Padding(3, 4, 3, 4);
            roundedButton24.Name = "roundedButton24";
            roundedButton24.Size = new Size(88, 44);
            roundedButton24.TabIndex = 32;
            roundedButton24.Text = "Next";
            // 
            // panel19
            // 
            panel19.Controls.Add(button1);
            panel19.Controls.Add(roundedTextBox3);
            panel19.Controls.Add(button2);
            panel19.Controls.Add(dateTimePicker5);
            panel19.Controls.Add(label28);
            panel19.Controls.Add(button4);
            panel19.Controls.Add(label29);
            panel19.Controls.Add(button18);
            panel19.Controls.Add(dateTimePicker6);
            panel19.Location = new Point(37, 88);
            panel19.Name = "panel19";
            panel19.Size = new Size(1173, 196);
            panel19.TabIndex = 37;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(432, 136);
            button1.Name = "button1";
            button1.Size = new Size(107, 49);
            button1.TabIndex = 32;
            button1.Text = "Complete";
            button1.UseVisualStyleBackColor = true;
            // 
            // roundedTextBox3
            // 
            roundedTextBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox3.Location = new Point(657, 139);
            roundedTextBox3.Margin = new Padding(3, 5, 3, 5);
            roundedTextBox3.Multiline = true;
            roundedTextBox3.Name = "roundedTextBox3";
            roundedTextBox3.PlaceholderText = "Search";
            roundedTextBox3.Size = new Size(509, 41);
            roundedTextBox3.TabIndex = 31;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(279, 136);
            button2.Name = "button2";
            button2.Size = new Size(117, 45);
            button2.TabIndex = 17;
            button2.Text = "View";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Location = new Point(24, 64);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(242, 27);
            dateTimePicker5.TabIndex = 8;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.Location = new Point(24, 16);
            label28.Name = "label28";
            label28.Size = new Size(69, 32);
            label28.TabIndex = 10;
            label28.Text = "From";
            // 
            // button4
            // 
            button4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(18, 132);
            button4.Name = "button4";
            button4.Size = new Size(101, 47);
            button4.TabIndex = 25;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.Location = new Point(314, 16);
            label29.Name = "label29";
            label29.Size = new Size(39, 32);
            label29.TabIndex = 11;
            label29.Text = "To";
            // 
            // button18
            // 
            button18.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.Location = new Point(141, 133);
            button18.Name = "button18";
            button18.Size = new Size(101, 47);
            button18.TabIndex = 15;
            button18.Text = "Clear";
            button18.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Location = new Point(318, 64);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(251, 27);
            dateTimePicker6.TabIndex = 9;
            // 
            // auditLogdata
            // 
            auditLogdata.ColumnHeadersHeight = 29;
            auditLogdata.Location = new Point(35, 297);
            auditLogdata.Name = "auditLogdata";
            auditLogdata.RowHeadersWidth = 51;
            auditLogdata.Size = new Size(1174, 639);
            auditLogdata.TabIndex = 39;
            // 
            // button19
            // 
            button19.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button19.Location = new Point(978, 25);
            button19.Name = "button19";
            button19.Size = new Size(161, 56);
            button19.TabIndex = 36;
            button19.Text = "Add";
            button19.UseVisualStyleBackColor = true;
            // 
            // loglbl
            // 
            loglbl.AutoSize = true;
            loglbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loglbl.Location = new Point(18, 19);
            loglbl.Name = "loglbl";
            loglbl.Size = new Size(120, 31);
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
            OrderAccemblypnl.Controls.Add(orderaccemblySearchpnl);
            OrderAccemblypnl.Controls.Add(orderAccemblyData);
            OrderAccemblypnl.Controls.Add(orderAccemblylbl);
            OrderAccemblypnl.Controls.Add(accemblyCreatebtn);
            OrderAccemblypnl.Location = new Point(201, 3);
            OrderAccemblypnl.Margin = new Padding(3, 4, 3, 4);
            OrderAccemblypnl.Name = "OrderAccemblypnl";
            OrderAccemblypnl.Size = new Size(1250, 1051);
            OrderAccemblypnl.TabIndex = 7;
            OrderAccemblypnl.Visible = false;
            // 
            // orderaccemblySearchpnl
            // 
            orderaccemblySearchpnl.Controls.Add(orderAccemblyViewbtn);
            orderaccemblySearchpnl.Controls.Add(orderAccemblySearchbtn);
            orderaccemblySearchpnl.Controls.Add(orderAccemblyClearbtn);
            orderaccemblySearchpnl.Controls.Add(orderAccemblySearchbox);
            orderaccemblySearchpnl.Controls.Add(orderAccemblydateTimePicker);
            orderaccemblySearchpnl.Controls.Add(label5);
            orderaccemblySearchpnl.Controls.Add(orderAccemblydateTimePicker2);
            orderaccemblySearchpnl.Controls.Add(label6);
            orderaccemblySearchpnl.Location = new Point(30, 107);
            orderaccemblySearchpnl.Margin = new Padding(3, 4, 3, 4);
            orderaccemblySearchpnl.Name = "orderaccemblySearchpnl";
            orderaccemblySearchpnl.Size = new Size(1200, 193);
            orderaccemblySearchpnl.TabIndex = 16;
            // 
            // orderAccemblyViewbtn
            // 
            orderAccemblyViewbtn.Location = new Point(410, 131);
            orderAccemblyViewbtn.Name = "orderAccemblyViewbtn";
            orderAccemblyViewbtn.Size = new Size(130, 43);
            orderAccemblyViewbtn.TabIndex = 20;
            orderAccemblyViewbtn.Text = "View";
            orderAccemblyViewbtn.UseVisualStyleBackColor = true;
            orderAccemblyViewbtn.Click += orderAccemblyViewbtn_Click;
            // 
            // orderAccemblySearchbtn
            // 
            orderAccemblySearchbtn.Location = new Point(39, 131);
            orderAccemblySearchbtn.Name = "orderAccemblySearchbtn";
            orderAccemblySearchbtn.Size = new Size(130, 43);
            orderAccemblySearchbtn.TabIndex = 19;
            orderAccemblySearchbtn.Text = "Search";
            orderAccemblySearchbtn.UseVisualStyleBackColor = true;
            orderAccemblySearchbtn.Click += orderAccemblySearchbtn_Click;
            // 
            // orderAccemblyClearbtn
            // 
            orderAccemblyClearbtn.Location = new Point(210, 131);
            orderAccemblyClearbtn.Name = "orderAccemblyClearbtn";
            orderAccemblyClearbtn.Size = new Size(138, 43);
            orderAccemblyClearbtn.TabIndex = 18;
            orderAccemblyClearbtn.Text = "Clear";
            orderAccemblyClearbtn.UseVisualStyleBackColor = true;
            // 
            // orderAccemblySearchbox
            // 
            orderAccemblySearchbox.Location = new Point(661, 149);
            orderAccemblySearchbox.Name = "orderAccemblySearchbox";
            orderAccemblySearchbox.Size = new Size(441, 27);
            orderAccemblySearchbox.TabIndex = 17;
            // 
            // orderAccemblydateTimePicker
            // 
            orderAccemblydateTimePicker.Location = new Point(39, 64);
            orderAccemblydateTimePicker.Margin = new Padding(3, 4, 3, 4);
            orderAccemblydateTimePicker.Name = "orderAccemblydateTimePicker";
            orderAccemblydateTimePicker.Size = new Size(266, 27);
            orderAccemblydateTimePicker.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 11);
            label5.Name = "label5";
            label5.Size = new Size(69, 32);
            label5.TabIndex = 10;
            label5.Text = "From";
            // 
            // orderAccemblydateTimePicker2
            // 
            orderAccemblydateTimePicker2.Location = new Point(360, 64);
            orderAccemblydateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            orderAccemblydateTimePicker2.Name = "orderAccemblydateTimePicker2";
            orderAccemblydateTimePicker2.Size = new Size(271, 27);
            orderAccemblydateTimePicker2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(361, 13);
            label6.Name = "label6";
            label6.Size = new Size(39, 32);
            label6.TabIndex = 11;
            label6.Text = "To";
            // 
            // orderAccemblyData
            // 
            orderAccemblyData.AllowUserToAddRows = false;
            orderAccemblyData.AllowUserToDeleteRows = false;
            orderAccemblyData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            orderAccemblyData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            orderAccemblyData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderAccemblyData.Columns.AddRange(new DataGridViewColumn[] { orderAccemblyColumn });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Window;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle16.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            orderAccemblyData.DefaultCellStyle = dataGridViewCellStyle16;
            orderAccemblyData.Location = new Point(30, 312);
            orderAccemblyData.Name = "orderAccemblyData";
            orderAccemblyData.RowHeadersWidth = 51;
            orderAccemblyData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderAccemblyData.Size = new Size(1200, 660);
            orderAccemblyData.TabIndex = 7;
            orderAccemblyData.CellClick += orderAccemblyData_CellClick;
            // 
            // orderAccemblylbl
            // 
            orderAccemblylbl.AutoSize = true;
            orderAccemblylbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderAccemblylbl.Location = new Point(18, 24);
            orderAccemblylbl.Name = "orderAccemblylbl";
            orderAccemblylbl.Size = new Size(185, 31);
            orderAccemblylbl.TabIndex = 6;
            orderAccemblylbl.Text = "Order Accembly";
            // 
            // accemblyCreatebtn
            // 
            accemblyCreatebtn.Location = new Point(1010, 37);
            accemblyCreatebtn.Name = "accemblyCreatebtn";
            accemblyCreatebtn.Size = new Size(177, 51);
            accemblyCreatebtn.TabIndex = 8;
            accemblyCreatebtn.Text = "Create";
            accemblyCreatebtn.UseVisualStyleBackColor = true;
            accemblyCreatebtn.Click += accemblyCreatebtn_Click;
            // 
            // GRNpnl
            // 
            GRNpnl.Controls.Add(panel12);
            GRNpnl.Controls.Add(panel1);
            GRNpnl.Controls.Add(grnAddNoteBtn);
            GRNpnl.Controls.Add(grndata);
            GRNpnl.Controls.Add(GRNlbl);
            GRNpnl.Location = new Point(201, 3);
            GRNpnl.Margin = new Padding(3, 4, 3, 4);
            GRNpnl.Name = "GRNpnl";
            GRNpnl.Size = new Size(1250, 1051);
            GRNpnl.TabIndex = 8;
            GRNpnl.Visible = false;
            // 
            // panel12
            // 
            panel12.Controls.Add(roundedButton5);
            panel12.Controls.Add(label16);
            panel12.Controls.Add(roundedButton6);
            panel12.Controls.Add(roundedButton7);
            panel12.Controls.Add(roundedButton8);
            panel12.Location = new Point(662, 915);
            panel12.Margin = new Padding(3, 4, 3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(566, 67);
            panel12.TabIndex = 34;
            // 
            // roundedButton5
            // 
            roundedButton5.BackColor = SystemColors.Menu;
            roundedButton5.BackColor2 = Color.White;
            roundedButton5.BorderColor = Color.Tomato;
            roundedButton5.BorderSize = 2;
            roundedButton5.ButtonBorderColor = Color.Gray;
            roundedButton5.ButtonHighlightColor = Color.Empty;
            roundedButton5.ButtonHighlightColor2 = Color.Empty;
            roundedButton5.ButtonHighlightForeColor = Color.Black;
            roundedButton5.ButtonPressedColor = Color.White;
            roundedButton5.ButtonPressedColor2 = Color.Empty;
            roundedButton5.ButtonPressedForeColor = Color.Gray;
            roundedButton5.ButtonRoundRadius = 15;
            roundedButton5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton5.ForeColor = Color.Black;
            roundedButton5.Location = new Point(70, 9);
            roundedButton5.Margin = new Padding(3, 4, 3, 4);
            roundedButton5.Name = "roundedButton5";
            roundedButton5.Size = new Size(79, 44);
            roundedButton5.TabIndex = 31;
            roundedButton5.Text = "First";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(251, 21);
            label16.Name = "label16";
            label16.Size = new Size(100, 25);
            label16.TabIndex = 3;
            label16.Text = "LabelData";
            // 
            // roundedButton6
            // 
            roundedButton6.AccessibleRole = AccessibleRole.None;
            roundedButton6.BackColor = SystemColors.Menu;
            roundedButton6.BackColor2 = Color.White;
            roundedButton6.BorderColor = Color.Tomato;
            roundedButton6.BorderSize = 2;
            roundedButton6.ButtonBorderColor = Color.Gray;
            roundedButton6.ButtonHighlightColor = Color.Empty;
            roundedButton6.ButtonHighlightColor2 = Color.Empty;
            roundedButton6.ButtonHighlightForeColor = Color.Black;
            roundedButton6.ButtonPressedColor = Color.White;
            roundedButton6.ButtonPressedColor2 = Color.Empty;
            roundedButton6.ButtonPressedForeColor = Color.Gray;
            roundedButton6.ButtonRoundRadius = 15;
            roundedButton6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton6.ForeColor = Color.Black;
            roundedButton6.Location = new Point(167, 9);
            roundedButton6.Margin = new Padding(3, 4, 3, 4);
            roundedButton6.Name = "roundedButton6";
            roundedButton6.Size = new Size(72, 44);
            roundedButton6.TabIndex = 33;
            roundedButton6.Text = "Prev";
            // 
            // roundedButton7
            // 
            roundedButton7.BackColor = SystemColors.Menu;
            roundedButton7.BackColor2 = Color.White;
            roundedButton7.BorderColor = Color.White;
            roundedButton7.BorderSize = 2;
            roundedButton7.ButtonBorderColor = Color.Gray;
            roundedButton7.ButtonHighlightColor = Color.Empty;
            roundedButton7.ButtonHighlightColor2 = Color.Empty;
            roundedButton7.ButtonHighlightForeColor = Color.Black;
            roundedButton7.ButtonPressedColor = Color.White;
            roundedButton7.ButtonPressedColor2 = Color.Empty;
            roundedButton7.ButtonPressedForeColor = Color.Gray;
            roundedButton7.ButtonRoundRadius = 15;
            roundedButton7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton7.ForeColor = Color.Black;
            roundedButton7.Location = new Point(454, 9);
            roundedButton7.Margin = new Padding(3, 4, 3, 4);
            roundedButton7.Name = "roundedButton7";
            roundedButton7.Size = new Size(75, 44);
            roundedButton7.TabIndex = 34;
            roundedButton7.Text = "Last";
            // 
            // roundedButton8
            // 
            roundedButton8.BackColor = SystemColors.HighlightText;
            roundedButton8.BackColor2 = Color.White;
            roundedButton8.BorderColor = Color.Tomato;
            roundedButton8.BorderSize = 2;
            roundedButton8.ButtonBorderColor = Color.Gray;
            roundedButton8.ButtonHighlightColor = Color.Empty;
            roundedButton8.ButtonHighlightColor2 = Color.Empty;
            roundedButton8.ButtonHighlightForeColor = Color.Black;
            roundedButton8.ButtonPressedColor = Color.White;
            roundedButton8.ButtonPressedColor2 = Color.Empty;
            roundedButton8.ButtonPressedForeColor = Color.Gray;
            roundedButton8.ButtonRoundRadius = 15;
            roundedButton8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton8.ForeColor = Color.Black;
            roundedButton8.Location = new Point(354, 9);
            roundedButton8.Margin = new Padding(3, 4, 3, 4);
            roundedButton8.Name = "roundedButton8";
            roundedButton8.Size = new Size(88, 44);
            roundedButton8.TabIndex = 32;
            roundedButton8.Text = "Next";
            // 
            // panel1
            // 
            panel1.Controls.Add(grnDatePicker1);
            panel1.Controls.Add(grnlbl1);
            panel1.Controls.Add(grnclearBtn);
            panel1.Controls.Add(grnDatePicker2);
            panel1.Controls.Add(grnSearchBtn);
            panel1.Controls.Add(grnlbl2);
            panel1.Location = new Point(43, 72);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 193);
            panel1.TabIndex = 15;
            // 
            // grnDatePicker1
            // 
            grnDatePicker1.Location = new Point(39, 64);
            grnDatePicker1.Margin = new Padding(3, 4, 3, 4);
            grnDatePicker1.Name = "grnDatePicker1";
            grnDatePicker1.Size = new Size(266, 27);
            grnDatePicker1.TabIndex = 8;
            // 
            // grnlbl1
            // 
            grnlbl1.AutoSize = true;
            grnlbl1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grnlbl1.Location = new Point(32, 11);
            grnlbl1.Name = "grnlbl1";
            grnlbl1.Size = new Size(69, 32);
            grnlbl1.TabIndex = 10;
            grnlbl1.Text = "From";
            // 
            // grnclearBtn
            // 
            grnclearBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grnclearBtn.Location = new Point(219, 145);
            grnclearBtn.Name = "grnclearBtn";
            grnclearBtn.Size = new Size(101, 45);
            grnclearBtn.TabIndex = 15;
            grnclearBtn.Text = "Clear";
            grnclearBtn.UseVisualStyleBackColor = true;
            grnclearBtn.Click += grnclearBtn_Click;
            // 
            // grnDatePicker2
            // 
            grnDatePicker2.Location = new Point(360, 64);
            grnDatePicker2.Margin = new Padding(3, 4, 3, 4);
            grnDatePicker2.Name = "grnDatePicker2";
            grnDatePicker2.Size = new Size(271, 27);
            grnDatePicker2.TabIndex = 9;
            // 
            // grnSearchBtn
            // 
            grnSearchBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grnSearchBtn.Location = new Point(34, 145);
            grnSearchBtn.Name = "grnSearchBtn";
            grnSearchBtn.Size = new Size(101, 45);
            grnSearchBtn.TabIndex = 15;
            grnSearchBtn.Text = "Search";
            grnSearchBtn.UseVisualStyleBackColor = true;
            grnSearchBtn.Click += grnSearchBtn_Click;
            // 
            // grnlbl2
            // 
            grnlbl2.AutoSize = true;
            grnlbl2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grnlbl2.Location = new Point(361, 13);
            grnlbl2.Name = "grnlbl2";
            grnlbl2.Size = new Size(39, 32);
            grnlbl2.TabIndex = 11;
            grnlbl2.Text = "To";
            // 
            // grnAddNoteBtn
            // 
            grnAddNoteBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grnAddNoteBtn.Location = new Point(1063, 5);
            grnAddNoteBtn.Name = "grnAddNoteBtn";
            grnAddNoteBtn.Size = new Size(177, 59);
            grnAddNoteBtn.TabIndex = 15;
            grnAddNoteBtn.Text = "Add";
            grnAddNoteBtn.UseVisualStyleBackColor = true;
            grnAddNoteBtn.Click += grnAddNoteBtn_Click;
            // 
            // grndata
            // 
            grndata.AllowUserToAddRows = false;
            grndata.AllowUserToDeleteRows = false;
            grndata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = SystemColors.Control;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            grndata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            grndata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grndata.Columns.AddRange(new DataGridViewColumn[] { grncheckColumn });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Window;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            grndata.DefaultCellStyle = dataGridViewCellStyle18;
            grndata.Location = new Point(35, 319);
            grndata.Margin = new Padding(3, 4, 3, 4);
            grndata.MultiSelect = false;
            grndata.Name = "grndata";
            grndata.RowHeadersVisible = false;
            grndata.RowHeadersWidth = 51;
            grndata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grndata.Size = new Size(1186, 579);
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
            GRNlbl.Location = new Point(18, 24);
            GRNlbl.Name = "GRNlbl";
            GRNlbl.Size = new Size(231, 31);
            GRNlbl.TabIndex = 6;
            GRNlbl.Text = "Good Received Note";
            // 
            // deliverypnl
            // 
            deliverypnl.Controls.Add(panel13);
            deliverypnl.Controls.Add(panel2);
            deliverypnl.Controls.Add(deliveryData);
            deliverypnl.Controls.Add(deliveryAddbtn);
            deliverypnl.Controls.Add(deliverylbl);
            deliverypnl.Location = new Point(201, 3);
            deliverypnl.Margin = new Padding(3, 4, 3, 4);
            deliverypnl.Name = "deliverypnl";
            deliverypnl.Size = new Size(1250, 1051);
            deliverypnl.TabIndex = 9;
            deliverypnl.Visible = false;
            deliverypnl.Paint += deliverypnl_Paint;
            // 
            // panel13
            // 
            panel13.Controls.Add(roundedButton9);
            panel13.Controls.Add(label17);
            panel13.Controls.Add(roundedButton10);
            panel13.Controls.Add(roundedButton11);
            panel13.Controls.Add(roundedButton12);
            panel13.Location = new Point(658, 915);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(566, 67);
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
            roundedButton9.ButtonPressedForeColor = Color.Gray;
            roundedButton9.ButtonRoundRadius = 15;
            roundedButton9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton9.ForeColor = Color.Black;
            roundedButton9.Location = new Point(70, 9);
            roundedButton9.Margin = new Padding(3, 4, 3, 4);
            roundedButton9.Name = "roundedButton9";
            roundedButton9.Size = new Size(79, 44);
            roundedButton9.TabIndex = 31;
            roundedButton9.Text = "First";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(251, 21);
            label17.Name = "label17";
            label17.Size = new Size(100, 25);
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
            roundedButton10.ButtonRoundRadius = 15;
            roundedButton10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton10.ForeColor = Color.Black;
            roundedButton10.Location = new Point(167, 9);
            roundedButton10.Margin = new Padding(3, 4, 3, 4);
            roundedButton10.Name = "roundedButton10";
            roundedButton10.Size = new Size(72, 44);
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
            roundedButton11.ButtonRoundRadius = 15;
            roundedButton11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton11.ForeColor = Color.Black;
            roundedButton11.Location = new Point(454, 9);
            roundedButton11.Margin = new Padding(3, 4, 3, 4);
            roundedButton11.Name = "roundedButton11";
            roundedButton11.Size = new Size(75, 44);
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
            roundedButton12.ButtonRoundRadius = 15;
            roundedButton12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton12.ForeColor = Color.Black;
            roundedButton12.Location = new Point(354, 9);
            roundedButton12.Margin = new Padding(3, 4, 3, 4);
            roundedButton12.Name = "roundedButton12";
            roundedButton12.Size = new Size(88, 44);
            roundedButton12.TabIndex = 32;
            roundedButton12.Text = "Next";
            // 
            // panel2
            // 
            panel2.Controls.Add(deliverycompletedeliverybtn);
            panel2.Controls.Add(deliverySearchIDbox);
            panel2.Controls.Add(deliveryViewDNbtn);
            panel2.Controls.Add(deliverydateTimePicker1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(deliverySearchDatebtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(deliveryclearbtn);
            panel2.Controls.Add(deliverydateTimePicker2);
            panel2.Location = new Point(43, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(1173, 196);
            panel2.TabIndex = 16;
            // 
            // deliverycompletedeliverybtn
            // 
            deliverycompletedeliverybtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliverycompletedeliverybtn.Location = new Point(432, 136);
            deliverycompletedeliverybtn.Name = "deliverycompletedeliverybtn";
            deliverycompletedeliverybtn.Size = new Size(107, 49);
            deliverycompletedeliverybtn.TabIndex = 32;
            deliverycompletedeliverybtn.Text = "Complete";
            deliverycompletedeliverybtn.UseVisualStyleBackColor = true;
            deliverycompletedeliverybtn.Click += deliverycompletedeliverybtn_Click;
            // 
            // deliverySearchIDbox
            // 
            deliverySearchIDbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliverySearchIDbox.Location = new Point(657, 139);
            deliverySearchIDbox.Margin = new Padding(3, 5, 3, 5);
            deliverySearchIDbox.Multiline = true;
            deliverySearchIDbox.Name = "deliverySearchIDbox";
            deliverySearchIDbox.PlaceholderText = "Search";
            deliverySearchIDbox.Size = new Size(509, 41);
            deliverySearchIDbox.TabIndex = 31;
            // 
            // deliveryViewDNbtn
            // 
            deliveryViewDNbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryViewDNbtn.Location = new Point(279, 136);
            deliveryViewDNbtn.Name = "deliveryViewDNbtn";
            deliveryViewDNbtn.Size = new Size(117, 45);
            deliveryViewDNbtn.TabIndex = 17;
            deliveryViewDNbtn.Text = "View";
            deliveryViewDNbtn.UseVisualStyleBackColor = true;
            deliveryViewDNbtn.Click += deliveryViewDNbtn_Click;
            // 
            // deliverydateTimePicker1
            // 
            deliverydateTimePicker1.Location = new Point(24, 64);
            deliverydateTimePicker1.Name = "deliverydateTimePicker1";
            deliverydateTimePicker1.Size = new Size(242, 27);
            deliverydateTimePicker1.TabIndex = 8;
            // 
            // deliverySearchDatebtn
            // 
            deliverySearchDatebtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliverySearchDatebtn.Location = new Point(18, 132);
            deliverySearchDatebtn.Name = "deliverySearchDatebtn";
            deliverySearchDatebtn.Size = new Size(101, 47);
            deliverySearchDatebtn.TabIndex = 25;
            deliverySearchDatebtn.Text = "Search";
            deliverySearchDatebtn.UseVisualStyleBackColor = true;
            deliverySearchDatebtn.Click += deliverySearchDatebtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(314, 16);
            label3.Name = "label3";
            label3.Size = new Size(39, 32);
            label3.TabIndex = 11;
            label3.Text = "To";
            // 
            // deliveryclearbtn
            // 
            deliveryclearbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryclearbtn.Location = new Point(141, 133);
            deliveryclearbtn.Name = "deliveryclearbtn";
            deliveryclearbtn.Size = new Size(101, 47);
            deliveryclearbtn.TabIndex = 15;
            deliveryclearbtn.Text = "Clear";
            deliveryclearbtn.UseVisualStyleBackColor = true;
            deliveryclearbtn.Click += deliveryclearbtn_Click_1;
            // 
            // deliverydateTimePicker2
            // 
            deliverydateTimePicker2.Location = new Point(318, 64);
            deliverydateTimePicker2.Name = "deliverydateTimePicker2";
            deliverydateTimePicker2.Size = new Size(251, 27);
            deliverydateTimePicker2.TabIndex = 9;
            // 
            // deliveryData
            // 
            deliveryData.AllowUserToAddRows = false;
            deliveryData.AllowUserToDeleteRows = false;
            deliveryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = SystemColors.Control;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            deliveryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            deliveryData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            deliveryData.Columns.AddRange(new DataGridViewColumn[] { deliverycheckColumn });
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = SystemColors.Window;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle20.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            deliveryData.DefaultCellStyle = dataGridViewCellStyle20;
            deliveryData.Location = new Point(38, 299);
            deliveryData.Name = "deliveryData";
            deliveryData.RowHeadersVisible = false;
            deliveryData.RowHeadersWidth = 51;
            deliveryData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            deliveryData.Size = new Size(1189, 604);
            deliveryData.TabIndex = 7;
            deliveryData.CellClick += deliveryData_CellClick;
            deliveryData.CellContentClick += deliveryData_CellContentClick;
            // 
            // deliveryAddbtn
            // 
            deliveryAddbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryAddbtn.Location = new Point(985, 32);
            deliveryAddbtn.Name = "deliveryAddbtn";
            deliveryAddbtn.Size = new Size(161, 56);
            deliveryAddbtn.TabIndex = 15;
            deliveryAddbtn.Text = "Add";
            deliveryAddbtn.UseVisualStyleBackColor = true;
            deliveryAddbtn.Click += deliveryAddbtn_Click_1;
            // 
            // deliverylbl
            // 
            deliverylbl.AutoSize = true;
            deliverylbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliverylbl.Location = new Point(18, 24);
            deliverylbl.Name = "deliverylbl";
            deliverylbl.Size = new Size(162, 31);
            deliverylbl.TabIndex = 6;
            deliverylbl.Text = "Delivery Note";
            // 
            // deliveryCompletepnl
            // 
            deliveryCompletepnl.Controls.Add(label19);
            deliveryCompletepnl.Controls.Add(DeliverydeliveredDate);
            deliveryCompletepnl.Controls.Add(label20);
            deliveryCompletepnl.Controls.Add(deliveryBackbtn);
            deliveryCompletepnl.Controls.Add(deliveryDeliveryIDlbl);
            deliveryCompletepnl.Controls.Add(label4);
            deliveryCompletepnl.Controls.Add(deliveryCompletebtn);
            deliveryCompletepnl.Controls.Add(DeliveryCancelbtn);
            deliveryCompletepnl.Controls.Add(deliveryNextbtn);
            deliveryCompletepnl.Location = new Point(213, 21);
            deliveryCompletepnl.Margin = new Padding(3, 4, 3, 4);
            deliveryCompletepnl.Name = "deliveryCompletepnl";
            deliveryCompletepnl.Size = new Size(1215, 956);
            deliveryCompletepnl.TabIndex = 35;
            deliveryCompletepnl.Visible = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(223, 196);
            label19.Name = "label19";
            label19.Size = new Size(142, 31);
            label19.TabIndex = 26;
            label19.Text = "Shipped on ";
            // 
            // DeliverydeliveredDate
            // 
            DeliverydeliveredDate.Location = new Point(302, 292);
            DeliverydeliveredDate.Margin = new Padding(3, 4, 3, 4);
            DeliverydeliveredDate.Name = "DeliverydeliveredDate";
            DeliverydeliveredDate.Size = new Size(228, 27);
            DeliverydeliveredDate.TabIndex = 25;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(95, 289);
            label20.Name = "label20";
            label20.Size = new Size(190, 31);
            label20.TabIndex = 24;
            label20.Text = "Delivered Date : ";
            // 
            // deliveryBackbtn
            // 
            deliveryBackbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryBackbtn.Location = new Point(605, 20);
            deliveryBackbtn.Name = "deliveryBackbtn";
            deliveryBackbtn.Size = new Size(158, 51);
            deliveryBackbtn.TabIndex = 23;
            deliveryBackbtn.Text = "Back";
            deliveryBackbtn.UseVisualStyleBackColor = true;
            deliveryBackbtn.Click += deliveryBackbtn_Click;
            // 
            // deliveryDeliveryIDlbl
            // 
            deliveryDeliveryIDlbl.AutoSize = true;
            deliveryDeliveryIDlbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryDeliveryIDlbl.Location = new Point(317, 103);
            deliveryDeliveryIDlbl.Name = "deliveryDeliveryIDlbl";
            deliveryDeliveryIDlbl.Size = new Size(198, 37);
            deliveryDeliveryIDlbl.TabIndex = 22;
            deliveryDeliveryIDlbl.Text = "Delivery ID : #";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 3);
            label4.Name = "label4";
            label4.Size = new Size(162, 31);
            label4.TabIndex = 21;
            label4.Text = "Delivery Note";
            // 
            // deliveryCompletebtn
            // 
            deliveryCompletebtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryCompletebtn.Location = new Point(328, 463);
            deliveryCompletebtn.Name = "deliveryCompletebtn";
            deliveryCompletebtn.Size = new Size(158, 51);
            deliveryCompletebtn.TabIndex = 20;
            deliveryCompletebtn.Text = "Complete";
            deliveryCompletebtn.UseVisualStyleBackColor = true;
            deliveryCompletebtn.Click += deliveryCompletebtn_Click;
            // 
            // DeliveryCancelbtn
            // 
            DeliveryCancelbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeliveryCancelbtn.Location = new Point(38, 463);
            DeliveryCancelbtn.Name = "DeliveryCancelbtn";
            DeliveryCancelbtn.Size = new Size(158, 51);
            DeliveryCancelbtn.TabIndex = 19;
            DeliveryCancelbtn.Text = "Cancel";
            DeliveryCancelbtn.UseVisualStyleBackColor = true;
            // 
            // deliveryNextbtn
            // 
            deliveryNextbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryNextbtn.Location = new Point(605, 463);
            deliveryNextbtn.Name = "deliveryNextbtn";
            deliveryNextbtn.Size = new Size(158, 51);
            deliveryNextbtn.TabIndex = 18;
            deliveryNextbtn.Text = "Next";
            deliveryNextbtn.UseVisualStyleBackColor = true;
            // 
            // POpnl
            // 
            POpnl.Controls.Add(poData);
            POpnl.Controls.Add(panel16);
            POpnl.Controls.Add(panel17);
            POpnl.Controls.Add(button17);
            POpnl.Controls.Add(POlbl);
            POpnl.Location = new Point(201, 3);
            POpnl.Name = "POpnl";
            POpnl.Size = new Size(1250, 1051);
            POpnl.TabIndex = 32;
            // 
            // poData
            // 
            poData.AllowUserToAddRows = false;
            poData.AllowUserToDeleteRows = false;
            poData.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = Color.Gainsboro;
            poData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            poData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = SystemColors.Control;
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle22.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            poData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            poData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            poData.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn6 });
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = SystemColors.Window;
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle23.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            poData.DefaultCellStyle = dataGridViewCellStyle23;
            poData.Location = new Point(35, 297);
            poData.Name = "poData";
            poData.RowHeadersVisible = false;
            poData.RowHeadersWidth = 51;
            poData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poData.Size = new Size(1181, 604);
            poData.TabIndex = 39;
            // 
            // dataGridViewCheckBoxColumn6
            // 
            dataGridViewCheckBoxColumn6.FillWeight = 35F;
            dataGridViewCheckBoxColumn6.HeaderText = "Select";
            dataGridViewCheckBoxColumn6.MinimumWidth = 35;
            dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            // 
            // panel16
            // 
            panel16.Controls.Add(poFirstPageBtn);
            panel16.Controls.Add(label24);
            panel16.Controls.Add(poPrevPageBtn);
            panel16.Controls.Add(poLastPagebtn);
            panel16.Controls.Add(poNextPageBtn);
            panel16.Location = new Point(651, 908);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(566, 67);
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
            poFirstPageBtn.ButtonRoundRadius = 15;
            poFirstPageBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poFirstPageBtn.ForeColor = Color.Black;
            poFirstPageBtn.Location = new Point(70, 9);
            poFirstPageBtn.Margin = new Padding(3, 4, 3, 4);
            poFirstPageBtn.Name = "poFirstPageBtn";
            poFirstPageBtn.Size = new Size(79, 44);
            poFirstPageBtn.TabIndex = 31;
            poFirstPageBtn.Text = "First";
            poFirstPageBtn.Click += poFirstPageBtn_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(251, 21);
            label24.Name = "label24";
            label24.Size = new Size(100, 25);
            label24.TabIndex = 3;
            label24.Text = "LabelData";
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
            poPrevPageBtn.ButtonRoundRadius = 15;
            poPrevPageBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poPrevPageBtn.ForeColor = Color.Black;
            poPrevPageBtn.Location = new Point(167, 9);
            poPrevPageBtn.Margin = new Padding(3, 4, 3, 4);
            poPrevPageBtn.Name = "poPrevPageBtn";
            poPrevPageBtn.Size = new Size(72, 44);
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
            poLastPagebtn.ButtonRoundRadius = 15;
            poLastPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poLastPagebtn.ForeColor = Color.Black;
            poLastPagebtn.Location = new Point(454, 9);
            poLastPagebtn.Margin = new Padding(3, 4, 3, 4);
            poLastPagebtn.Name = "poLastPagebtn";
            poLastPagebtn.Size = new Size(75, 44);
            poLastPagebtn.TabIndex = 34;
            poLastPagebtn.Text = "Last";
            poLastPagebtn.Click += poLastPagebtn_Click;
            // 
            // poNextPageBtn
            // 
            poNextPageBtn.BackColor = SystemColors.HighlightText;
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
            poNextPageBtn.ButtonRoundRadius = 15;
            poNextPageBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poNextPageBtn.ForeColor = Color.Black;
            poNextPageBtn.Location = new Point(354, 9);
            poNextPageBtn.Margin = new Padding(3, 4, 3, 4);
            poNextPageBtn.Name = "poNextPageBtn";
            poNextPageBtn.Size = new Size(88, 44);
            poNextPageBtn.TabIndex = 32;
            poNextPageBtn.Text = "Next";
            poNextPageBtn.Click += poNextPageBtn_Click;
            // 
            // panel17
            // 
            panel17.Controls.Add(button13);
            panel17.Controls.Add(poSearchbox);
            panel17.Controls.Add(button14);
            panel17.Controls.Add(podateTimePicker1);
            panel17.Controls.Add(label25);
            panel17.Controls.Add(poSearchbtn);
            panel17.Controls.Add(label26);
            panel17.Controls.Add(poClearbtn);
            panel17.Controls.Add(podateTimePicker2);
            panel17.Location = new Point(37, 88);
            panel17.Name = "panel17";
            panel17.Size = new Size(1173, 196);
            panel17.TabIndex = 37;
            // 
            // button13
            // 
            button13.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.Location = new Point(432, 136);
            button13.Name = "button13";
            button13.Size = new Size(107, 49);
            button13.TabIndex = 32;
            button13.Text = "Complete";
            button13.UseVisualStyleBackColor = true;
            // 
            // poSearchbox
            // 
            poSearchbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            poSearchbox.Location = new Point(657, 139);
            poSearchbox.Margin = new Padding(3, 5, 3, 5);
            poSearchbox.Multiline = true;
            poSearchbox.Name = "poSearchbox";
            poSearchbox.PlaceholderText = "Search";
            poSearchbox.Size = new Size(509, 41);
            poSearchbox.TabIndex = 31;
            // 
            // button14
            // 
            button14.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.Location = new Point(279, 136);
            button14.Name = "button14";
            button14.Size = new Size(117, 45);
            button14.TabIndex = 17;
            button14.Text = "View";
            button14.UseVisualStyleBackColor = true;
            // 
            // podateTimePicker1
            // 
            podateTimePicker1.Location = new Point(24, 64);
            podateTimePicker1.Name = "podateTimePicker1";
            podateTimePicker1.Size = new Size(242, 27);
            podateTimePicker1.TabIndex = 8;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(24, 16);
            label25.Name = "label25";
            label25.Size = new Size(69, 32);
            label25.TabIndex = 10;
            label25.Text = "From";
            // 
            // poSearchbtn
            // 
            poSearchbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poSearchbtn.Location = new Point(18, 132);
            poSearchbtn.Name = "poSearchbtn";
            poSearchbtn.Size = new Size(101, 47);
            poSearchbtn.TabIndex = 25;
            poSearchbtn.Text = "Search";
            poSearchbtn.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(314, 16);
            label26.Name = "label26";
            label26.Size = new Size(39, 32);
            label26.TabIndex = 11;
            label26.Text = "To";
            // 
            // poClearbtn
            // 
            poClearbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poClearbtn.Location = new Point(141, 133);
            poClearbtn.Name = "poClearbtn";
            poClearbtn.Size = new Size(101, 47);
            poClearbtn.TabIndex = 15;
            poClearbtn.Text = "Clear";
            poClearbtn.UseVisualStyleBackColor = true;
            // 
            // podateTimePicker2
            // 
            podateTimePicker2.Location = new Point(318, 64);
            podateTimePicker2.Name = "podateTimePicker2";
            podateTimePicker2.Size = new Size(251, 27);
            podateTimePicker2.TabIndex = 9;
            // 
            // button17
            // 
            button17.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.Location = new Point(978, 25);
            button17.Name = "button17";
            button17.Size = new Size(161, 56);
            button17.TabIndex = 36;
            button17.Text = "Add";
            button17.UseVisualStyleBackColor = true;
            // 
            // POlbl
            // 
            POlbl.AutoSize = true;
            POlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            POlbl.Location = new Point(11, 11);
            POlbl.Name = "POlbl";
            POlbl.Size = new Size(45, 31);
            POlbl.TabIndex = 0;
            POlbl.Text = "PO";
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
            outstandingOrderpnl.Location = new Point(201, 3);
            outstandingOrderpnl.Name = "outstandingOrderpnl";
            outstandingOrderpnl.Size = new Size(1250, 1051);
            outstandingOrderpnl.TabIndex = 33;
            // 
            // panel20
            // 
            panel20.Controls.Add(outstandingFirstPagebtn);
            panel20.Controls.Add(oustadningPrevPagebtn);
            panel20.Controls.Add(outstandingLastPagebtn);
            panel20.Controls.Add(outstandingNextPagebtn);
            panel20.Controls.Add(oustandingPagelbl);
            panel20.Location = new Point(651, 908);
            panel20.Margin = new Padding(3, 4, 3, 4);
            panel20.Name = "panel20";
            panel20.Size = new Size(566, 67);
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
            outstandingFirstPagebtn.ButtonRoundRadius = 15;
            outstandingFirstPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingFirstPagebtn.ForeColor = Color.Black;
            outstandingFirstPagebtn.Location = new Point(65, 9);
            outstandingFirstPagebtn.Margin = new Padding(3, 4, 3, 4);
            outstandingFirstPagebtn.Name = "outstandingFirstPagebtn";
            outstandingFirstPagebtn.Size = new Size(79, 44);
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
            oustadningPrevPagebtn.ButtonRoundRadius = 15;
            oustadningPrevPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oustadningPrevPagebtn.ForeColor = Color.Black;
            oustadningPrevPagebtn.Location = new Point(159, 9);
            oustadningPrevPagebtn.Margin = new Padding(3, 4, 3, 4);
            oustadningPrevPagebtn.Name = "oustadningPrevPagebtn";
            oustadningPrevPagebtn.Size = new Size(72, 44);
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
            outstandingLastPagebtn.ButtonRoundRadius = 15;
            outstandingLastPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingLastPagebtn.ForeColor = Color.Black;
            outstandingLastPagebtn.Location = new Point(461, 9);
            outstandingLastPagebtn.Margin = new Padding(3, 4, 3, 4);
            outstandingLastPagebtn.Name = "outstandingLastPagebtn";
            outstandingLastPagebtn.Size = new Size(75, 44);
            outstandingLastPagebtn.TabIndex = 34;
            outstandingLastPagebtn.Text = "Last";
            outstandingLastPagebtn.Click += outstandingLastPagebtn_Click;
            // 
            // outstandingNextPagebtn
            // 
            outstandingNextPagebtn.BackColor = SystemColors.HighlightText;
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
            outstandingNextPagebtn.ButtonRoundRadius = 15;
            outstandingNextPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingNextPagebtn.ForeColor = Color.Black;
            outstandingNextPagebtn.Location = new Point(365, 9);
            outstandingNextPagebtn.Margin = new Padding(3, 4, 3, 4);
            outstandingNextPagebtn.Name = "outstandingNextPagebtn";
            outstandingNextPagebtn.Size = new Size(77, 44);
            outstandingNextPagebtn.TabIndex = 32;
            outstandingNextPagebtn.Text = "Next";
            outstandingNextPagebtn.Click += outstandingNextPagebtn_Click;
            // 
            // oustandingPagelbl
            // 
            oustandingPagelbl.AutoSize = true;
            oustandingPagelbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oustandingPagelbl.Location = new Point(237, 20);
            oustandingPagelbl.Name = "oustandingPagelbl";
            oustandingPagelbl.Size = new Size(100, 25);
            oustandingPagelbl.TabIndex = 3;
            oustandingPagelbl.Text = "LabelData";
            // 
            // panel21
            // 
            panel21.Controls.Add(outstandingSearchbox);
            panel21.Controls.Add(outstandingViewbtn);
            panel21.Controls.Add(outstandingdateTimePicker1);
            panel21.Controls.Add(label31);
            panel21.Controls.Add(outstandingSearchbtn);
            panel21.Controls.Add(label32);
            panel21.Controls.Add(outstandingClearBtn);
            panel21.Controls.Add(outstandingdateTimePicker2);
            panel21.Location = new Point(37, 88);
            panel21.Name = "panel21";
            panel21.Size = new Size(1173, 196);
            panel21.TabIndex = 37;
            // 
            // outstandingSearchbox
            // 
            outstandingSearchbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outstandingSearchbox.Location = new Point(657, 139);
            outstandingSearchbox.Margin = new Padding(3, 5, 3, 5);
            outstandingSearchbox.Multiline = true;
            outstandingSearchbox.Name = "outstandingSearchbox";
            outstandingSearchbox.PlaceholderText = "Search";
            outstandingSearchbox.Size = new Size(509, 41);
            outstandingSearchbox.TabIndex = 31;
            // 
            // outstandingViewbtn
            // 
            outstandingViewbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingViewbtn.Location = new Point(438, 135);
            outstandingViewbtn.Name = "outstandingViewbtn";
            outstandingViewbtn.Size = new Size(117, 45);
            outstandingViewbtn.TabIndex = 17;
            outstandingViewbtn.Text = "View";
            outstandingViewbtn.UseVisualStyleBackColor = true;
            outstandingViewbtn.Click += outstandingViewbtn_Click;
            // 
            // outstandingdateTimePicker1
            // 
            outstandingdateTimePicker1.Location = new Point(24, 64);
            outstandingdateTimePicker1.Name = "outstandingdateTimePicker1";
            outstandingdateTimePicker1.Size = new Size(242, 27);
            outstandingdateTimePicker1.TabIndex = 8;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.Location = new Point(24, 16);
            label31.Name = "label31";
            label31.Size = new Size(69, 32);
            label31.TabIndex = 10;
            label31.Text = "From";
            // 
            // outstandingSearchbtn
            // 
            outstandingSearchbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingSearchbtn.Location = new Point(27, 136);
            outstandingSearchbtn.Name = "outstandingSearchbtn";
            outstandingSearchbtn.Size = new Size(101, 47);
            outstandingSearchbtn.TabIndex = 25;
            outstandingSearchbtn.Text = "Search";
            outstandingSearchbtn.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label32.Location = new Point(314, 16);
            label32.Name = "label32";
            label32.Size = new Size(39, 32);
            label32.TabIndex = 11;
            label32.Text = "To";
            // 
            // outstandingClearBtn
            // 
            outstandingClearBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingClearBtn.Location = new Point(248, 135);
            outstandingClearBtn.Name = "outstandingClearBtn";
            outstandingClearBtn.Size = new Size(101, 47);
            outstandingClearBtn.TabIndex = 15;
            outstandingClearBtn.Text = "Clear";
            outstandingClearBtn.UseVisualStyleBackColor = true;
            // 
            // outstandingdateTimePicker2
            // 
            outstandingdateTimePicker2.Location = new Point(318, 64);
            outstandingdateTimePicker2.Name = "outstandingdateTimePicker2";
            outstandingdateTimePicker2.Size = new Size(251, 27);
            outstandingdateTimePicker2.TabIndex = 9;
            // 
            // outstandingdata
            // 
            outstandingdata.AllowUserToAddRows = false;
            outstandingdata.AllowUserToDeleteRows = false;
            outstandingdata.AllowUserToResizeRows = false;
            dataGridViewCellStyle24.BackColor = Color.Gainsboro;
            outstandingdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle24;
            outstandingdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = SystemColors.Control;
            dataGridViewCellStyle25.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle25.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
            outstandingdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            outstandingdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            outstandingdata.Columns.AddRange(new DataGridViewColumn[] { outstandingcheckColumn });
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = SystemColors.Window;
            dataGridViewCellStyle26.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle26.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.False;
            outstandingdata.DefaultCellStyle = dataGridViewCellStyle26;
            outstandingdata.Location = new Point(31, 292);
            outstandingdata.Name = "outstandingdata";
            outstandingdata.RowHeadersVisible = false;
            outstandingdata.RowHeadersWidth = 51;
            outstandingdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            outstandingdata.Size = new Size(1189, 604);
            outstandingdata.TabIndex = 35;
            outstandingdata.CellClick += outstandingdata_CellClick;
            outstandingdata.CellContentClick += outstandingdata_CellContentClick;
            // 
            // outstandingOrderlbl
            // 
            outstandingOrderlbl.AutoSize = true;
            outstandingOrderlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            outstandingOrderlbl.Location = new Point(11, 11);
            outstandingOrderlbl.Name = "outstandingOrderlbl";
            outstandingOrderlbl.Size = new Size(215, 31);
            outstandingOrderlbl.TabIndex = 0;
            outstandingOrderlbl.Text = "Outstanding Order";
            // 
            // dateTimePicker8
            // 
            dateTimePicker8.Location = new Point(0, 0);
            dateTimePicker8.Name = "dateTimePicker8";
            dateTimePicker8.Size = new Size(200, 27);
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
            invoicepnl.Controls.Add(button12);
            invoicepnl.Controls.Add(invoicelbl);
            invoicepnl.Location = new Point(201, 3);
            invoicepnl.Name = "invoicepnl";
            invoicepnl.Size = new Size(1250, 1051);
            invoicepnl.TabIndex = 33;
            // 
            // panel14
            // 
            panel14.Controls.Add(roundedButton13);
            panel14.Controls.Add(label21);
            panel14.Controls.Add(roundedButton14);
            panel14.Controls.Add(roundedButton15);
            panel14.Controls.Add(roundedButton16);
            panel14.Location = new Point(651, 908);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(566, 67);
            panel14.TabIndex = 38;
            // 
            // roundedButton13
            // 
            roundedButton13.BackColor = SystemColors.Menu;
            roundedButton13.BackColor2 = Color.White;
            roundedButton13.BorderColor = Color.Tomato;
            roundedButton13.BorderSize = 2;
            roundedButton13.ButtonBorderColor = Color.Gray;
            roundedButton13.ButtonHighlightColor = Color.Empty;
            roundedButton13.ButtonHighlightColor2 = Color.Empty;
            roundedButton13.ButtonHighlightForeColor = Color.Black;
            roundedButton13.ButtonPressedColor = Color.White;
            roundedButton13.ButtonPressedColor2 = Color.Empty;
            roundedButton13.ButtonPressedForeColor = Color.Gray;
            roundedButton13.ButtonRoundRadius = 15;
            roundedButton13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton13.ForeColor = Color.Black;
            roundedButton13.Location = new Point(70, 9);
            roundedButton13.Margin = new Padding(3, 4, 3, 4);
            roundedButton13.Name = "roundedButton13";
            roundedButton13.Size = new Size(79, 44);
            roundedButton13.TabIndex = 31;
            roundedButton13.Text = "First";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(251, 21);
            label21.Name = "label21";
            label21.Size = new Size(100, 25);
            label21.TabIndex = 3;
            label21.Text = "LabelData";
            // 
            // roundedButton14
            // 
            roundedButton14.AccessibleRole = AccessibleRole.None;
            roundedButton14.BackColor = SystemColors.Menu;
            roundedButton14.BackColor2 = Color.White;
            roundedButton14.BorderColor = Color.Tomato;
            roundedButton14.BorderSize = 2;
            roundedButton14.ButtonBorderColor = Color.Gray;
            roundedButton14.ButtonHighlightColor = Color.Empty;
            roundedButton14.ButtonHighlightColor2 = Color.Empty;
            roundedButton14.ButtonHighlightForeColor = Color.Black;
            roundedButton14.ButtonPressedColor = Color.White;
            roundedButton14.ButtonPressedColor2 = Color.Empty;
            roundedButton14.ButtonPressedForeColor = Color.Gray;
            roundedButton14.ButtonRoundRadius = 15;
            roundedButton14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton14.ForeColor = Color.Black;
            roundedButton14.Location = new Point(167, 9);
            roundedButton14.Margin = new Padding(3, 4, 3, 4);
            roundedButton14.Name = "roundedButton14";
            roundedButton14.Size = new Size(72, 44);
            roundedButton14.TabIndex = 33;
            roundedButton14.Text = "Prev";
            // 
            // roundedButton15
            // 
            roundedButton15.BackColor = SystemColors.Menu;
            roundedButton15.BackColor2 = Color.White;
            roundedButton15.BorderColor = Color.White;
            roundedButton15.BorderSize = 2;
            roundedButton15.ButtonBorderColor = Color.Gray;
            roundedButton15.ButtonHighlightColor = Color.Empty;
            roundedButton15.ButtonHighlightColor2 = Color.Empty;
            roundedButton15.ButtonHighlightForeColor = Color.Black;
            roundedButton15.ButtonPressedColor = Color.White;
            roundedButton15.ButtonPressedColor2 = Color.Empty;
            roundedButton15.ButtonPressedForeColor = Color.Gray;
            roundedButton15.ButtonRoundRadius = 15;
            roundedButton15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton15.ForeColor = Color.Black;
            roundedButton15.Location = new Point(454, 9);
            roundedButton15.Margin = new Padding(3, 4, 3, 4);
            roundedButton15.Name = "roundedButton15";
            roundedButton15.Size = new Size(75, 44);
            roundedButton15.TabIndex = 34;
            roundedButton15.Text = "Last";
            // 
            // roundedButton16
            // 
            roundedButton16.BackColor = SystemColors.HighlightText;
            roundedButton16.BackColor2 = Color.White;
            roundedButton16.BorderColor = Color.Tomato;
            roundedButton16.BorderSize = 2;
            roundedButton16.ButtonBorderColor = Color.Gray;
            roundedButton16.ButtonHighlightColor = Color.Empty;
            roundedButton16.ButtonHighlightColor2 = Color.Empty;
            roundedButton16.ButtonHighlightForeColor = Color.Black;
            roundedButton16.ButtonPressedColor = Color.White;
            roundedButton16.ButtonPressedColor2 = Color.Empty;
            roundedButton16.ButtonPressedForeColor = Color.Gray;
            roundedButton16.ButtonRoundRadius = 15;
            roundedButton16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton16.ForeColor = Color.Black;
            roundedButton16.Location = new Point(354, 9);
            roundedButton16.Margin = new Padding(3, 4, 3, 4);
            roundedButton16.Name = "roundedButton16";
            roundedButton16.Size = new Size(88, 44);
            roundedButton16.TabIndex = 32;
            roundedButton16.Text = "Next";
            // 
            // panel15
            // 
            panel15.Controls.Add(button7);
            panel15.Controls.Add(roundedTextBox1);
            panel15.Controls.Add(button9);
            panel15.Controls.Add(dateTimePicker1);
            panel15.Controls.Add(label22);
            panel15.Controls.Add(button10);
            panel15.Controls.Add(label23);
            panel15.Controls.Add(button11);
            panel15.Controls.Add(dateTimePicker2);
            panel15.Location = new Point(37, 88);
            panel15.Name = "panel15";
            panel15.Size = new Size(1173, 196);
            panel15.TabIndex = 37;
            // 
            // button7
            // 
            button7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(432, 136);
            button7.Name = "button7";
            button7.Size = new Size(107, 49);
            button7.TabIndex = 32;
            button7.Text = "Complete";
            button7.UseVisualStyleBackColor = true;
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox1.Location = new Point(657, 139);
            roundedTextBox1.Margin = new Padding(3, 5, 3, 5);
            roundedTextBox1.Multiline = true;
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.PlaceholderText = "Search";
            roundedTextBox1.Size = new Size(509, 41);
            roundedTextBox1.TabIndex = 31;
            // 
            // button9
            // 
            button9.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(279, 136);
            button9.Name = "button9";
            button9.Size = new Size(117, 45);
            button9.TabIndex = 17;
            button9.Text = "View";
            button9.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(24, 64);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(24, 16);
            label22.Name = "label22";
            label22.Size = new Size(69, 32);
            label22.TabIndex = 10;
            label22.Text = "From";
            // 
            // button10
            // 
            button10.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(18, 132);
            button10.Name = "button10";
            button10.Size = new Size(101, 47);
            button10.TabIndex = 25;
            button10.Text = "Search";
            button10.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(314, 16);
            label23.Name = "label23";
            label23.Size = new Size(39, 32);
            label23.TabIndex = 11;
            label23.Text = "To";
            // 
            // button11
            // 
            button11.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(141, 133);
            button11.Name = "button11";
            button11.Size = new Size(101, 47);
            button11.TabIndex = 15;
            button11.Text = "Clear";
            button11.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(318, 64);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(251, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // invoiceData
            // 
            invoiceData.AllowUserToAddRows = false;
            invoiceData.AllowUserToDeleteRows = false;
            invoiceData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = SystemColors.Control;
            dataGridViewCellStyle27.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle27.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.True;
            invoiceData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            invoiceData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invoiceData.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn1 });
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = SystemColors.Window;
            dataGridViewCellStyle28.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle28.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = DataGridViewTriState.False;
            invoiceData.DefaultCellStyle = dataGridViewCellStyle28;
            invoiceData.Location = new Point(31, 292);
            invoiceData.Name = "invoiceData";
            invoiceData.RowHeadersVisible = false;
            invoiceData.RowHeadersWidth = 51;
            invoiceData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            invoiceData.Size = new Size(1189, 604);
            invoiceData.TabIndex = 35;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.FillWeight = 35F;
            dataGridViewCheckBoxColumn1.HeaderText = "Select";
            dataGridViewCheckBoxColumn1.MinimumWidth = 35;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // button12
            // 
            button12.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.Location = new Point(978, 25);
            button12.Name = "button12";
            button12.Size = new Size(161, 56);
            button12.TabIndex = 36;
            button12.Text = "Add";
            button12.UseVisualStyleBackColor = true;
            // 
            // invoicelbl
            // 
            invoicelbl.AutoSize = true;
            invoicelbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            invoicelbl.Location = new Point(11, 11);
            invoicelbl.Name = "invoicelbl";
            invoicelbl.Size = new Size(91, 31);
            invoicelbl.TabIndex = 0;
            invoicelbl.Text = "Invoice";
            // 
            // outstandingViewpnl
            // 
            outstandingViewpnl.Controls.Add(panel43);
            outstandingViewpnl.Controls.Add(panel44);
            outstandingViewpnl.Location = new Point(210, 15);
            outstandingViewpnl.Margin = new Padding(3, 4, 3, 4);
            outstandingViewpnl.Name = "outstandingViewpnl";
            outstandingViewpnl.Size = new Size(1218, 967);
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
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1499, 1051);
            Controls.Add(listpnl);
            Controls.Add(closebtn);
            Controls.Add(orderpnl);
            Controls.Add(outstandingViewpnl);
            Controls.Add(deliveryCompletepnl);
            Controls.Add(GRNpnl);
            Controls.Add(dashboardpnl);
            Controls.Add(settingpnl);
            Controls.Add(OrderAccemblypnl);
            Controls.Add(logpnl);
            Controls.Add(inventorypnl);
            Controls.Add(contactpnl);
            Controls.Add(invoicepnl);
            Controls.Add(POpnl);
            Controls.Add(deliverypnl);
            Controls.Add(userspnl);
            Controls.Add(outstandingOrderpnl);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Padding = new Padding(0, 0, 10, 0);
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
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel29.ResumeLayout(false);
            panel29.PerformLayout();
            panel28.ResumeLayout(false);
            panel28.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderdata).EndInit();
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
            contactGroupBox.PerformLayout();
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
            userspnl.ResumeLayout(false);
            userspnl.PerformLayout();
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
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            dashboardpnl.ResumeLayout(false);
            dashboardpnl.PerformLayout();
            logpnl.ResumeLayout(false);
            logpnl.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)auditLogdata).EndInit();
            OrderAccemblypnl.ResumeLayout(false);
            OrderAccemblypnl.PerformLayout();
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
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
            outstandingOrderpnl.ResumeLayout(false);
            outstandingOrderpnl.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
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
        private System.Windows.Forms.Button supplersbtn;
        private System.Windows.Forms.Button dealersbtn;
        private CustomDataGridView dealersData;
        private System.Windows.Forms.Button saleReportbtn;
        private System.Windows.Forms.Button editOrdersbtn;
        private System.Windows.Forms.Button viewAccountbtn;
        private System.Windows.Forms.Button editAccountbtn;
        private CustomDataGridView stockData;
        private System.Windows.Forms.Button viewOrderbtn;
        private System.Windows.Forms.Button newOrderbtn;
        private System.Windows.Forms.Label ordlerlbl;
        private System.Windows.Forms.Button newAccountbtn;
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
        private Button viewProductbtn;
        private Button newProductbtn;
        private Button editProductbtn;
        private Label stocklbl3;
        private ProgramMethod.ProgramMethod.RoundedTextBox stockSearchBox;
        private Button delProductbtn;
        private Button disableAccountbtn;
        private Label label1;
        private Button enableAccountbtn;
        private CustomDataGridView orderdata;
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
        private Button grnSearchBtn;
        private Panel panel1;
        private Button grnAddNoteBtn;
        private Button grnclearBtn;
        private CustomDataGridView deliveryData;
        private DateTimePicker deliverydateTimePicker1;
        private Button deliveryclearbtn;
        private Button deliverySearchDatebtn;
        private Label label3;
        private Label label2;
        private DateTimePicker deliverydateTimePicker2;
        private Button deliveryAddbtn;
        private Panel panel2;
        private Button delContactbtn;
        private Button searchDealerbtn;
        private TextBox searchContactbtn;
        private Button newDealerbtn;
        private Button editDealerbtn;
        private GroupBox contactGroupBox;
        private Button newSupplierbtn;
        private Button editSupplierbtn;
        private DataGridViewCheckBoxColumn ordercheckColumn;
        private DataGridViewCheckBoxColumn grncheckColumn;
        private DataGridViewCheckBoxColumn deliverycheckColumn;
        private DataGridViewCheckBoxColumn dealercheckColumn;
        private DataGridViewCheckBoxColumn suppliercheckColumn;
        private DataGridViewCheckBoxColumn usercheckColumn;
        private DataGridViewCheckBoxColumn stockcheckColumn;
        private DataGridViewCheckBoxColumn orderAccemblyColumn;
        private Button searchSupplierbtn;
        private CustomDataGridView userData;
        private ProgramMethod.ProgramMethod.RoundedButton accountbtnLastPage;
        private ProgramMethod.ProgramMethod.RoundedButton accountbtnPrevPage;
        private ProgramMethod.ProgramMethod.RoundedButton accountbtnNxtPage;
        private ProgramMethod.ProgramMethod.RoundedButton accountbtnFirstPage;
        private ComboBox accountPageSizeComboBox;
        private Label accountPaginglbl;
        private Button deliveryViewDNbtn;
        private DataGridView orderAccemblyData;
        private Button accemblyCreatebtn;
        private Panel orderaccemblySearchpnl;
        private Button orderAccemblySearchbtn;
        private Button orderAccemblyClearbtn;
        private TextBox orderAccemblySearchbox;
        private DateTimePicker orderAccemblydateTimePicker;
        private Label label5;
        private DateTimePicker orderAccemblydateTimePicker2;
        private Label label6;
        private Button orderAccemblyViewbtn;
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
        private Panel accountPaginationpnl;
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
        private Button orderSearchbtn;
        private Label label14;
        private Label label13;
        private DateTimePicker orderdateTimePicker2;
        private DateTimePicker orderdateTimePicker1;
        private ProgramMethod.ProgramMethod.RoundedTextBox orderSearchbox;
        private Button CancelOrderbtn;
        private Panel panel10;
        private Panel panel11;
        private ProgramMethod.ProgramMethod.RoundedButton orderFirstPagebtn;
        private Label orderIndexlbl;
        private ProgramMethod.ProgramMethod.RoundedButton orderPrevPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton orderLastPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton orderNextPagebtn;
        private Panel panel12;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton5;
        private Label label16;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton6;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton7;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton8;
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
        private Label label19;
        private Button deliverycompletedeliverybtn;
        private Panel panel14;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton13;
        private Label label21;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton14;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton15;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton16;
        private Panel panel15;
        private Button button7;
        private ProgramMethod.ProgramMethod.RoundedTextBox roundedTextBox1;
        private Button button9;
        private DateTimePicker dateTimePicker1;
        private Label label22;
        private Button button10;
        private Label label23;
        private Button button11;
        private DateTimePicker dateTimePicker2;
        private CustomDataGridView invoiceData;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Button button12;
        private Panel panel16;
        private ProgramMethod.ProgramMethod.RoundedButton poFirstPageBtn;
        private Label label24;
        private ProgramMethod.ProgramMethod.RoundedButton poPrevPageBtn;
        private ProgramMethod.ProgramMethod.RoundedButton poLastPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton poNextPageBtn;
        private Panel panel17;
        private Button button13;
        private ProgramMethod.ProgramMethod.RoundedTextBox poSearchbox;
        private Button button14;
        private DateTimePicker podateTimePicker1;
        private Label label25;
        private Button poSearchbtn;
        private Label label26;
        private Button poClearbtn;
        private DateTimePicker podateTimePicker2;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private Button button17;
        private Panel panel18;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton21;
        private Label label27;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton22;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton23;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton24;
        private Panel panel19;
        private Button button1;
        private ProgramMethod.ProgramMethod.RoundedTextBox roundedTextBox3;
        private Button button2;
        private DateTimePicker dateTimePicker5;
        private Label label28;
        private Button button4;
        private Label label29;
        private Button button18;
        private DateTimePicker dateTimePicker6;
        private CustomDataGridView auditLogdata;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private Button button19;
        private Panel panel20;
        private ProgramMethod.ProgramMethod.RoundedButton outstandingFirstPagebtn;
        private Label oustandingPagelbl;
        private ProgramMethod.ProgramMethod.RoundedButton oustadningPrevPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton outstandingLastPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton outstandingNextPagebtn;
        private Panel panel21;
        private ProgramMethod.ProgramMethod.RoundedTextBox outstandingSearchbox;
        private Button outstandingViewbtn;
        private DateTimePicker outstandingdateTimePicker1;
        private Label label31;
        private Button outstandingSearchbtn;
        private Label label32;
        private Button outstandingClearBtn;
        private DateTimePicker outstandingdateTimePicker2;
        private CustomDataGridView outstandingdata;
        private DataGridViewCheckBoxColumn outstandingcheckColumn;
        private DataGridViewCheckBoxColumn orderaccemblycheckColumn;
        private Panel outstandingViewpnl;
        private Label contactIndexlbl;
        private Label outstandingDealerIDlbl;
        private Button outstandingBackbtn;
        private Label outstandingIDlbl;
        private Label label36;
        private Button button21;
        private Button outstandingCancelbtn;
        private Button button23;
        private Label outstandingEmaillbl;
        private Label outstandingPhonelbl;
        private Label outstandingContactNamelbl;
        private Label outstandingDealerNamelbl;
        private Label outstandingOrderIDlbl;
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
        private Button button8;
        private Panel panel26;
        private TextBox orderCountbox;
        private Panel panel27;
        private TextBox textBox1;
        private Panel panel29;
        private TextBox textBox3;
        private Panel panel28;
        private TextBox textBox2;
        private Panel InvoiceLine1;
    }
}