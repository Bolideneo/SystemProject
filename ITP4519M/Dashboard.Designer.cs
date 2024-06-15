using Org.BouncyCastle.Asn1.Crmf;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle46 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle47 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle48 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle49 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle50 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle51 = new DataGridViewCellStyle();
            listpnl = new Panel();
            deliverybtn = new Button();
            log_logo = new ImageList(components);
            GRNbtn = new Button();
            OrderAccemblybtn = new Button();
            Order_logo = new ImageList(components);
            Logbtn = new Button();
            contactsbtn = new Button();
            contact_logo = new ImageList(components);
            settingbtn = new Button();
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
            orderCancelbtn = new Button();
            orderPendingbtn = new Button();
            orderActivebtn = new Button();
            orderoverallBtn = new Button();
            viewOrderbtn = new Button();
            newOrderbtn = new Button();
            ordlerlbl = new Label();
            saleReportbtn = new Button();
            editOrdersbtn = new Button();
            orderdata = new CustomDataGridView();
            ordercheckColumn = new DataGridViewCheckBoxColumn();
            grncheckColumn = new DataGridViewCheckBoxColumn();
            deliverycheckColumn = new DataGridViewCheckBoxColumn();
            contactcheckColumn = new DataGridViewCheckBoxColumn();
            usercheckColumn = new DataGridViewCheckBoxColumn();
            stockcheckColumn = new DataGridViewCheckBoxColumn();
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
            contactGroupBox = new GroupBox();
            supplersbtn = new Button();
            dealersbtn = new Button();
            delContactbtn = new Button();
            searchContactbtn = new TextBox();
            contactsdata = new CustomDataGridView();
            newSupplierbtn = new Button();
            editSupplierbtn = new Button();
            newDealerbtn = new Button();
            editDealerbtn = new Button();
            searchSupplierbtn = new Button();
            searchDealerbtn = new Button();
            label2 = new Label();
            settingpnl = new Panel();
            settinglbl = new Label();
            userspnl = new Panel();
            roundedButton2 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton1 = new ProgramMethod.ProgramMethod.RoundedButton();
            label4 = new Label();
            accountPageSizeComboBox = new ComboBox();
            accountPaginglbl = new Label();
            accountbtnLastPage = new ProgramMethod.ProgramMethod.RoundedButton();
            accountbtnPrevPage = new ProgramMethod.ProgramMethod.RoundedButton();
            accountbtnNxtPage = new ProgramMethod.ProgramMethod.RoundedButton();
            accountbtnFirstPage = new ProgramMethod.ProgramMethod.RoundedButton();
            enableAccountbtn = new Button();
            disableAccountbtn = new Button();
            accountSearchBox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            newAccountbtn = new Button();
            viewAccountbtn = new Button();
            editAccountbtn = new Button();
            userData = new CustomDataGridView();
            userslbl = new Label();
            inventorypnl = new Panel();
            productSearchBtn = new Button();
            delProductbtn = new Button();
            stockSearchBox = new TextBox();
            dashboardpnl = new Panel();
            label1 = new Label();
            logpnl = new Panel();
            button1 = new Button();
            button2 = new Button();
            loglbl = new Label();
            logData = new CustomDataGridView();
            accountPageSizeBtn = new Button();
            button4 = new Button();
            OrderAccemblypnl = new Panel();
            accemblyCreatebtn = new Button();
            orderAccemblyData = new DataGridView();
            orderAccemblylbl = new Label();
            GRNpnl = new Panel();
            panel1 = new Panel();
            grnDatePicker1 = new DateTimePicker();
            grnlbl1 = new Label();
            grnclearBtn = new Button();
            grnDatePicker2 = new DateTimePicker();
            grnSearchBtn = new Button();
            grnlbl2 = new Label();
            grnAddNoteBtn = new Button();
            grndata = new CustomDataGridView();
            GRNlbl = new Label();
            deliverypnl = new Panel();
            panel2 = new Panel();
            deliveryViewDNbtn = new Button();
            deliverydateTimePicker1 = new DateTimePicker();
            deliverySearchIDbox = new TextBox();
            deliverySearchDatebtn = new Button();
            label3 = new Label();
            deliveryclearbtn = new Button();
            deliverydateTimePicker2 = new DateTimePicker();
            deliveryData = new CustomDataGridView();
            deliveryAddbtn = new Button();
            deliverylbl = new Label();
            orderaccemblySearchpnl = new Panel();
            orderAccemblydateTimePicker = new DateTimePicker();
            label5 = new Label();
            orderAccemblydateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            orderAccemblySearchbox = new TextBox();
            orderAccemblyClearbtn = new Button();
            orderAccemblySearchbtn = new Button();
            listpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatarbox).BeginInit();
            orderpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderdata).BeginInit();
            stockSummarypnl.SuspendLayout();
            stockDatapanel3.SuspendLayout();
            stockDatapanel1.SuspendLayout();
            stockDatapanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockData).BeginInit();
            contactpnl.SuspendLayout();
            contactGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contactsdata).BeginInit();
            settingpnl.SuspendLayout();
            userspnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userData).BeginInit();
            inventorypnl.SuspendLayout();
            dashboardpnl.SuspendLayout();
            logpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logData).BeginInit();
            OrderAccemblypnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderAccemblyData).BeginInit();
            GRNpnl.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grndata).BeginInit();
            deliverypnl.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deliveryData).BeginInit();
            orderaccemblySearchpnl.SuspendLayout();
            SuspendLayout();
            // 
            // listpnl
            // 
            listpnl.BackColor = SystemColors.MenuText;
            listpnl.BackgroundImageLayout = ImageLayout.Stretch;
            listpnl.Controls.Add(deliverybtn);
            listpnl.Controls.Add(GRNbtn);
            listpnl.Controls.Add(OrderAccemblybtn);
            listpnl.Controls.Add(Logbtn);
            listpnl.Controls.Add(contactsbtn);
            listpnl.Controls.Add(settingbtn);
            listpnl.Controls.Add(usersbtn);
            listpnl.Controls.Add(stockbtn);
            listpnl.Controls.Add(orderbtn);
            listpnl.Controls.Add(usertypelbl);
            listpnl.Controls.Add(namelbl);
            listpnl.Controls.Add(avatarbox);
            listpnl.Location = new Point(0, 1);
            listpnl.Margin = new Padding(3, 4, 3, 4);
            listpnl.Name = "listpnl";
            listpnl.Size = new Size(200, 876);
            listpnl.TabIndex = 14;
            listpnl.Paint += listpnl_Paint;
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
            deliverybtn.Location = new Point(25, 580);
            deliverybtn.Margin = new Padding(3, 4, 3, 4);
            deliverybtn.Name = "deliverybtn";
            deliverybtn.Size = new Size(166, 51);
            deliverybtn.TabIndex = 11;
            deliverybtn.Text = "  Delivery";
            deliverybtn.UseVisualStyleBackColor = true;
            deliverybtn.Click += deliverybtn_Click;
            // 
            // log_logo
            // 
            log_logo.ColorDepth = ColorDepth.Depth24Bit;
            log_logo.ImageStream = (ImageListStreamer)resources.GetObject("log_logo.ImageStream");
            log_logo.TransparentColor = Color.Transparent;
            log_logo.Images.SetKeyName(0, "log_logo.png");
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
            GRNbtn.Location = new Point(25, 509);
            GRNbtn.Margin = new Padding(3, 4, 3, 4);
            GRNbtn.Name = "GRNbtn";
            GRNbtn.Size = new Size(166, 51);
            GRNbtn.TabIndex = 10;
            GRNbtn.Text = "GRN   ";
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
            OrderAccemblybtn.Location = new Point(25, 371);
            OrderAccemblybtn.Margin = new Padding(3, 4, 3, 4);
            OrderAccemblybtn.Name = "OrderAccemblybtn";
            OrderAccemblybtn.Size = new Size(240, 56);
            OrderAccemblybtn.TabIndex = 9;
            OrderAccemblybtn.Text = "         OrderAccembly ";
            OrderAccemblybtn.TextAlign = ContentAlignment.MiddleLeft;
            OrderAccemblybtn.UseVisualStyleBackColor = true;
            OrderAccemblybtn.Click += outstandingOrderbtn_Click;
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
            Logbtn.Location = new Point(25, 720);
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
            contactsbtn.Location = new Point(25, 440);
            contactsbtn.Margin = new Padding(3, 4, 3, 4);
            contactsbtn.Name = "contactsbtn";
            contactsbtn.Size = new Size(166, 56);
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
            // settingbtn
            // 
            settingbtn.AutoSize = true;
            settingbtn.FlatAppearance.BorderSize = 0;
            settingbtn.FlatStyle = FlatStyle.Flat;
            settingbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingbtn.ForeColor = Color.White;
            settingbtn.ImageAlign = ContentAlignment.MiddleLeft;
            settingbtn.ImageIndex = 0;
            settingbtn.ImageList = setting_logo;
            settingbtn.Location = new Point(25, 789);
            settingbtn.Margin = new Padding(3, 4, 3, 4);
            settingbtn.Name = "settingbtn";
            settingbtn.Size = new Size(166, 51);
            settingbtn.TabIndex = 6;
            settingbtn.Text = "Log Out";
            settingbtn.UseVisualStyleBackColor = true;
            settingbtn.Click += settingbtn_Click;
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
            usersbtn.Location = new Point(25, 651);
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
            stockbtn.Location = new Point(25, 300);
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
            orderbtn.Location = new Point(25, 229);
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
            avatarbox.Location = new Point(3, 49);
            avatarbox.Margin = new Padding(3, 4, 3, 4);
            avatarbox.Name = "avatarbox";
            avatarbox.Size = new Size(197, 83);
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
            closebtn.Location = new Point(1457, 3);
            closebtn.Margin = new Padding(3, 4, 3, 4);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(40, 51);
            closebtn.TabIndex = 15;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += CloseButton_Click;
            // 
            // orderpnl
            // 
            orderpnl.Controls.Add(orderCancelbtn);
            orderpnl.Controls.Add(orderPendingbtn);
            orderpnl.Controls.Add(orderActivebtn);
            orderpnl.Controls.Add(orderoverallBtn);
            orderpnl.Controls.Add(viewOrderbtn);
            orderpnl.Controls.Add(newOrderbtn);
            orderpnl.Controls.Add(ordlerlbl);
            orderpnl.Controls.Add(saleReportbtn);
            orderpnl.Controls.Add(editOrdersbtn);
            orderpnl.Controls.Add(orderdata);
            orderpnl.Location = new Point(201, 3);
            orderpnl.Margin = new Padding(3, 4, 3, 4);
            orderpnl.Name = "orderpnl";
            orderpnl.Size = new Size(1250, 875);
            orderpnl.TabIndex = 16;
            orderpnl.Visible = false;
            // 
            // orderCancelbtn
            // 
            orderCancelbtn.AutoSize = true;
            orderCancelbtn.BackColor = SystemColors.HighlightText;
            orderCancelbtn.FlatAppearance.BorderColor = Color.Gray;
            orderCancelbtn.FlatStyle = FlatStyle.System;
            orderCancelbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderCancelbtn.ForeColor = Color.Black;
            orderCancelbtn.ImageAlign = ContentAlignment.TopCenter;
            orderCancelbtn.ImageIndex = 0;
            orderCancelbtn.Location = new Point(723, 123);
            orderCancelbtn.Margin = new Padding(3, 4, 3, 4);
            orderCancelbtn.Name = "orderCancelbtn";
            orderCancelbtn.Size = new Size(185, 56);
            orderCancelbtn.TabIndex = 31;
            orderCancelbtn.Text = "Cancelled Orders";
            orderCancelbtn.UseVisualStyleBackColor = false;
            // 
            // orderPendingbtn
            // 
            orderPendingbtn.AutoSize = true;
            orderPendingbtn.BackColor = SystemColors.HighlightText;
            orderPendingbtn.FlatAppearance.BorderColor = Color.Gray;
            orderPendingbtn.FlatStyle = FlatStyle.System;
            orderPendingbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderPendingbtn.ForeColor = Color.Black;
            orderPendingbtn.ImageAlign = ContentAlignment.TopCenter;
            orderPendingbtn.ImageIndex = 0;
            orderPendingbtn.Location = new Point(483, 123);
            orderPendingbtn.Margin = new Padding(3, 4, 3, 4);
            orderPendingbtn.Name = "orderPendingbtn";
            orderPendingbtn.Size = new Size(185, 56);
            orderPendingbtn.TabIndex = 30;
            orderPendingbtn.Text = "Pending Orders";
            orderPendingbtn.UseVisualStyleBackColor = false;
            // 
            // orderActivebtn
            // 
            orderActivebtn.AutoSize = true;
            orderActivebtn.BackColor = SystemColors.HighlightText;
            orderActivebtn.FlatAppearance.BorderColor = Color.Gray;
            orderActivebtn.FlatStyle = FlatStyle.System;
            orderActivebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderActivebtn.ForeColor = Color.Black;
            orderActivebtn.ImageAlign = ContentAlignment.TopCenter;
            orderActivebtn.ImageIndex = 0;
            orderActivebtn.Location = new Point(242, 123);
            orderActivebtn.Margin = new Padding(3, 4, 3, 4);
            orderActivebtn.Name = "orderActivebtn";
            orderActivebtn.Size = new Size(185, 56);
            orderActivebtn.TabIndex = 29;
            orderActivebtn.Text = "Active Orders";
            orderActivebtn.UseVisualStyleBackColor = false;
            // 
            // orderoverallBtn
            // 
            orderoverallBtn.AutoSize = true;
            orderoverallBtn.BackColor = SystemColors.HighlightText;
            orderoverallBtn.FlatAppearance.BorderColor = Color.Gray;
            orderoverallBtn.FlatStyle = FlatStyle.System;
            orderoverallBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderoverallBtn.ForeColor = Color.Black;
            orderoverallBtn.ImageAlign = ContentAlignment.MiddleLeft;
            orderoverallBtn.ImageIndex = 0;
            orderoverallBtn.Location = new Point(16, 121);
            orderoverallBtn.Margin = new Padding(3, 4, 3, 4);
            orderoverallBtn.Name = "orderoverallBtn";
            orderoverallBtn.Size = new Size(185, 56);
            orderoverallBtn.TabIndex = 28;
            orderoverallBtn.Text = "All Orders";
            orderoverallBtn.UseVisualStyleBackColor = false;
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
            viewOrderbtn.Location = new Point(1059, 781);
            viewOrderbtn.Margin = new Padding(3, 4, 3, 4);
            viewOrderbtn.Name = "viewOrderbtn";
            viewOrderbtn.Size = new Size(185, 56);
            viewOrderbtn.TabIndex = 25;
            viewOrderbtn.Text = "View Orders";
            viewOrderbtn.UseVisualStyleBackColor = false;
            viewOrderbtn.Click += viewOrderbtn_Click;
            // 
            // newOrderbtn
            // 
            newOrderbtn.AutoSize = true;
            newOrderbtn.BackColor = SystemColors.HighlightText;
            newOrderbtn.FlatAppearance.BorderColor = Color.Gray;
            newOrderbtn.FlatStyle = FlatStyle.System;
            newOrderbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newOrderbtn.ForeColor = Color.Black;
            newOrderbtn.ImageAlign = ContentAlignment.MiddleLeft;
            newOrderbtn.ImageIndex = 0;
            newOrderbtn.Location = new Point(1051, 33);
            newOrderbtn.Margin = new Padding(3, 4, 3, 4);
            newOrderbtn.Name = "newOrderbtn";
            newOrderbtn.Size = new Size(185, 56);
            newOrderbtn.TabIndex = 24;
            newOrderbtn.Text = "New Orders";
            newOrderbtn.UseVisualStyleBackColor = false;
            newOrderbtn.Click += newOrderbtn_Click;
            // 
            // ordlerlbl
            // 
            ordlerlbl.AutoSize = true;
            ordlerlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ordlerlbl.Location = new Point(18, 24);
            ordlerlbl.Name = "ordlerlbl";
            ordlerlbl.Size = new Size(283, 31);
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
            saleReportbtn.Location = new Point(13, 795);
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
            editOrdersbtn.Location = new Point(832, 781);
            editOrdersbtn.Margin = new Padding(3, 4, 3, 4);
            editOrdersbtn.Name = "editOrdersbtn";
            editOrdersbtn.Size = new Size(185, 56);
            editOrdersbtn.TabIndex = 20;
            editOrdersbtn.Text = "Edit Orders";
            editOrdersbtn.UseVisualStyleBackColor = false;
            editOrdersbtn.Click += editOrdersbtn_Click;
            // 
            // orderdata
            // 
            orderdata.AllowUserToAddRows = false;
            orderdata.AllowUserToDeleteRows = false;
            orderdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = SystemColors.Control;
            dataGridViewCellStyle35.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle35.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = DataGridViewTriState.True;
            orderdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            orderdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderdata.Columns.AddRange(new DataGridViewColumn[] { ordercheckColumn });
            dataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = SystemColors.Window;
            dataGridViewCellStyle36.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle36.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle36.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = DataGridViewTriState.False;
            orderdata.DefaultCellStyle = dataGridViewCellStyle36;
            orderdata.Location = new Point(11, 217);
            orderdata.Margin = new Padding(3, 4, 3, 4);
            orderdata.MultiSelect = false;
            orderdata.Name = "orderdata";
            orderdata.RowHeadersVisible = false;
            orderdata.RowHeadersWidth = 51;
            orderdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderdata.Size = new Size(1232, 501);
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
            // grncheckColumn
            // 
            grncheckColumn.FillWeight = 50F;
            grncheckColumn.HeaderText = "Select";
            grncheckColumn.MinimumWidth = 35;
            grncheckColumn.Name = "grncheckColumn";
            // 
            // deliverycheckColumn
            // 
            deliverycheckColumn.FillWeight = 35F;
            deliverycheckColumn.HeaderText = "Select";
            deliverycheckColumn.MinimumWidth = 35;
            deliverycheckColumn.Name = "deliverycheckColumn";
            // 
            // contactcheckColumn
            // 
            contactcheckColumn.FillWeight = 45F;
            contactcheckColumn.HeaderText = "Select";
            contactcheckColumn.MinimumWidth = 45;
            contactcheckColumn.Name = "contactcheckColumn";
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
            stockSummarypnl.Location = new Point(21, 68);
            stockSummarypnl.Margin = new Padding(3, 4, 3, 4);
            stockSummarypnl.Name = "stockSummarypnl";
            stockSummarypnl.Size = new Size(1226, 216);
            stockSummarypnl.TabIndex = 26;
            // 
            // stockDatapanel3
            // 
            stockDatapanel3.Controls.Add(stocklbl3);
            stockDatapanel3.Controls.Add(stockProductDatalbl3);
            stockDatapanel3.Location = new Point(870, 21);
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
            stockDatapanel1.Location = new Point(65, 21);
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
            stockDatapanel2.Location = new Point(459, 21);
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
            editProductbtn.Location = new Point(11, 295);
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
            newProductbtn.Location = new Point(1073, 19);
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
            stockData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle37.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = SystemColors.Control;
            dataGridViewCellStyle37.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle37.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = DataGridViewTriState.True;
            stockData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            stockData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stockData.Columns.AddRange(new DataGridViewColumn[] { stockcheckColumn });
            dataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = SystemColors.Window;
            dataGridViewCellStyle38.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle38.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = DataGridViewTriState.False;
            stockData.DefaultCellStyle = dataGridViewCellStyle38;
            stockData.Location = new Point(5, 371);
            stockData.Margin = new Padding(3, 5, 3, 5);
            stockData.Name = "stockData";
            stockData.RowHeadersVisible = false;
            stockData.RowHeadersWidth = 51;
            stockData.RowTemplate.Height = 24;
            stockData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stockData.Size = new Size(1235, 468);
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
            viewProductbtn.Location = new Point(219, 295);
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
            accountSearchBtn.Location = new Point(971, 144);
            accountSearchBtn.Margin = new Padding(3, 4, 3, 4);
            accountSearchBtn.Name = "accountSearchBtn";
            accountSearchBtn.Size = new Size(177, 44);
            accountSearchBtn.TabIndex = 27;
            accountSearchBtn.Text = "Search";
            accountSearchBtn.Click += accountSearchBtn_Click;
            // 
            // contactpnl
            // 
            contactpnl.Controls.Add(contactGroupBox);
            contactpnl.Controls.Add(delContactbtn);
            contactpnl.Controls.Add(searchContactbtn);
            contactpnl.Controls.Add(contactsdata);
            contactpnl.Controls.Add(newSupplierbtn);
            contactpnl.Controls.Add(editSupplierbtn);
            contactpnl.Controls.Add(newDealerbtn);
            contactpnl.Controls.Add(editDealerbtn);
            contactpnl.Controls.Add(searchSupplierbtn);
            contactpnl.Controls.Add(searchDealerbtn);
            contactpnl.Location = new Point(201, 3);
            contactpnl.Margin = new Padding(3, 4, 3, 4);
            contactpnl.Name = "contactpnl";
            contactpnl.Size = new Size(1240, 875);
            contactpnl.TabIndex = 1;
            contactpnl.Visible = false;
            contactpnl.Paint += contactpnl_Paint;
            // 
            // contactGroupBox
            // 
            contactGroupBox.Controls.Add(supplersbtn);
            contactGroupBox.Controls.Add(dealersbtn);
            contactGroupBox.Location = new Point(13, 12);
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
            delContactbtn.Location = new Point(349, 113);
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
            searchContactbtn.Location = new Point(806, 125);
            searchContactbtn.Margin = new Padding(3, 4, 3, 4);
            searchContactbtn.Name = "searchContactbtn";
            searchContactbtn.PlaceholderText = "Search Name";
            searchContactbtn.Size = new Size(225, 27);
            searchContactbtn.TabIndex = 32;
            // 
            // contactsdata
            // 
            contactsdata.AllowUserToAddRows = false;
            contactsdata.AllowUserToDeleteRows = false;
            contactsdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = SystemColors.Control;
            dataGridViewCellStyle39.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle39.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = DataGridViewTriState.True;
            contactsdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle39;
            contactsdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contactsdata.Columns.AddRange(new DataGridViewColumn[] { contactcheckColumn });
            dataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = SystemColors.Window;
            dataGridViewCellStyle40.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle40.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle40.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = DataGridViewTriState.False;
            contactsdata.DefaultCellStyle = dataGridViewCellStyle40;
            contactsdata.Location = new Point(11, 181);
            contactsdata.Margin = new Padding(3, 5, 3, 5);
            contactsdata.Name = "contactsdata";
            contactsdata.RowHeadersVisible = false;
            contactsdata.RowHeadersWidth = 51;
            contactsdata.RowTemplate.Height = 24;
            contactsdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            contactsdata.Size = new Size(1216, 639);
            contactsdata.TabIndex = 19;
            contactsdata.CellClick += contactsdata_CellClick;
            contactsdata.CellContentClick += contactsdata_CellContentClick;
            // 
            // newSupplierbtn
            // 
            newSupplierbtn.AccessibleRole = AccessibleRole.None;
            newSupplierbtn.BackColor = SystemColors.Menu;
            newSupplierbtn.FlatStyle = FlatStyle.System;
            newSupplierbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newSupplierbtn.ForeColor = Color.Black;
            newSupplierbtn.Location = new Point(21, 113);
            newSupplierbtn.Margin = new Padding(5);
            newSupplierbtn.Name = "newSupplierbtn";
            newSupplierbtn.Size = new Size(154, 47);
            newSupplierbtn.TabIndex = 37;
            newSupplierbtn.Text = "New Supplier";
            newSupplierbtn.UseVisualStyleBackColor = false;
            newSupplierbtn.Click += newSupplierbtn_Click;
            // 
            // editSupplierbtn
            // 
            editSupplierbtn.AccessibleRole = AccessibleRole.None;
            editSupplierbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSupplierbtn.Location = new Point(185, 113);
            editSupplierbtn.Margin = new Padding(5);
            editSupplierbtn.Name = "editSupplierbtn";
            editSupplierbtn.Size = new Size(154, 47);
            editSupplierbtn.TabIndex = 36;
            editSupplierbtn.Text = "Edit Supplier";
            editSupplierbtn.UseVisualStyleBackColor = true;
            editSupplierbtn.Click += editSupplierbtn_Click;
            // 
            // newDealerbtn
            // 
            newDealerbtn.AccessibleRole = AccessibleRole.None;
            newDealerbtn.BackColor = SystemColors.Menu;
            newDealerbtn.FlatStyle = FlatStyle.System;
            newDealerbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newDealerbtn.ForeColor = Color.Black;
            newDealerbtn.Location = new Point(21, 113);
            newDealerbtn.Margin = new Padding(5);
            newDealerbtn.Name = "newDealerbtn";
            newDealerbtn.Size = new Size(154, 47);
            newDealerbtn.TabIndex = 31;
            newDealerbtn.Text = "New Dealer";
            newDealerbtn.UseVisualStyleBackColor = false;
            newDealerbtn.Click += newDealerbtn_Click;
            // 
            // editDealerbtn
            // 
            editDealerbtn.AccessibleRole = AccessibleRole.None;
            editDealerbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editDealerbtn.Location = new Point(185, 113);
            editDealerbtn.Margin = new Padding(5);
            editDealerbtn.Name = "editDealerbtn";
            editDealerbtn.Size = new Size(154, 47);
            editDealerbtn.TabIndex = 29;
            editDealerbtn.Text = "Edit Dealer";
            editDealerbtn.UseVisualStyleBackColor = true;
            editDealerbtn.Click += editDealerbtn_Click;
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
            searchSupplierbtn.Location = new Point(1051, 117);
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
            searchDealerbtn.Location = new Point(1051, 117);
            searchDealerbtn.Margin = new Padding(3, 4, 3, 4);
            searchDealerbtn.Name = "searchDealerbtn";
            searchDealerbtn.Size = new Size(177, 43);
            searchDealerbtn.TabIndex = 33;
            searchDealerbtn.Text = "Search";
            searchDealerbtn.UseVisualStyleBackColor = false;
            searchDealerbtn.Click += searchDealerbtn_Click;
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
            settingpnl.Controls.Add(settinglbl);
            settingpnl.Location = new Point(201, 3);
            settingpnl.Margin = new Padding(3, 4, 3, 4);
            settingpnl.Name = "settingpnl";
            settingpnl.Size = new Size(1250, 875);
            settingpnl.TabIndex = 5;
            settingpnl.Visible = false;
            // 
            // settinglbl
            // 
            settinglbl.AutoSize = true;
            settinglbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settinglbl.Location = new Point(18, 24);
            settinglbl.Name = "settinglbl";
            settinglbl.Size = new Size(92, 31);
            settinglbl.TabIndex = 6;
            settinglbl.Text = "Setting";
            // 
            // userspnl
            // 
            userspnl.Controls.Add(roundedButton2);
            userspnl.Controls.Add(roundedButton1);
            userspnl.Controls.Add(label4);
            userspnl.Controls.Add(accountPageSizeComboBox);
            userspnl.Controls.Add(accountPaginglbl);
            userspnl.Controls.Add(accountbtnLastPage);
            userspnl.Controls.Add(accountbtnPrevPage);
            userspnl.Controls.Add(accountbtnNxtPage);
            userspnl.Controls.Add(accountbtnFirstPage);
            userspnl.Controls.Add(enableAccountbtn);
            userspnl.Controls.Add(disableAccountbtn);
            userspnl.Controls.Add(accountSearchBtn);
            userspnl.Controls.Add(accountSearchBox);
            userspnl.Controls.Add(newAccountbtn);
            userspnl.Controls.Add(viewAccountbtn);
            userspnl.Controls.Add(editAccountbtn);
            userspnl.Controls.Add(userData);
            userspnl.Controls.Add(userslbl);
            userspnl.Location = new Point(201, 3);
            userspnl.Margin = new Padding(3, 4, 3, 4);
            userspnl.Name = "userspnl";
            userspnl.Size = new Size(1250, 875);
            userspnl.TabIndex = 3;
            userspnl.Visible = false;
            // 
            // roundedButton2
            // 
            roundedButton2.AccessibleRole = AccessibleRole.None;
            roundedButton2.BackColor = SystemColors.Menu;
            roundedButton2.BackColor2 = Color.White;
            roundedButton2.BorderColor = Color.Tomato;
            roundedButton2.BorderSize = 2;
            roundedButton2.ButtonBorderColor = Color.Gray;
            roundedButton2.ButtonHighlightColor = Color.Empty;
            roundedButton2.ButtonHighlightColor2 = Color.Empty;
            roundedButton2.ButtonHighlightForeColor = Color.Black;
            roundedButton2.ButtonPressedColor = Color.White;
            roundedButton2.ButtonPressedColor2 = Color.Empty;
            roundedButton2.ButtonPressedForeColor = Color.Gray;
            roundedButton2.ButtonRoundRadius = 15;
            roundedButton2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton2.ForeColor = Color.Black;
            roundedButton2.Location = new Point(963, 759);
            roundedButton2.Margin = new Padding(3, 4, 3, 4);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(72, 44);
            roundedButton2.TabIndex = 39;
            roundedButton2.Text = "2";
            // 
            // roundedButton1
            // 
            roundedButton1.AccessibleRole = AccessibleRole.None;
            roundedButton1.BackColor = SystemColors.Menu;
            roundedButton1.BackColor2 = Color.White;
            roundedButton1.BorderColor = Color.Tomato;
            roundedButton1.BorderSize = 2;
            roundedButton1.ButtonBorderColor = Color.Gray;
            roundedButton1.ButtonHighlightColor = Color.Empty;
            roundedButton1.ButtonHighlightColor2 = Color.Empty;
            roundedButton1.ButtonHighlightForeColor = Color.Black;
            roundedButton1.ButtonPressedColor = Color.White;
            roundedButton1.ButtonPressedColor2 = Color.Empty;
            roundedButton1.ButtonPressedForeColor = Color.Gray;
            roundedButton1.ButtonRoundRadius = 15;
            roundedButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.Black;
            roundedButton1.Location = new Point(885, 759);
            roundedButton1.Margin = new Padding(3, 4, 3, 4);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(72, 44);
            roundedButton1.TabIndex = 38;
            roundedButton1.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 763);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 37;
            label4.Text = "Show Ent";
            // 
            // accountPageSizeComboBox
            // 
            accountPageSizeComboBox.FormattingEnabled = true;
            accountPageSizeComboBox.Items.AddRange(new object[] { "10", "15", "25" });
            accountPageSizeComboBox.Location = new Point(1103, 209);
            accountPageSizeComboBox.Margin = new Padding(3, 4, 3, 4);
            accountPageSizeComboBox.Name = "accountPageSizeComboBox";
            accountPageSizeComboBox.Size = new Size(46, 28);
            accountPageSizeComboBox.TabIndex = 36;
            // 
            // accountPaginglbl
            // 
            accountPaginglbl.AutoSize = true;
            accountPaginglbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountPaginglbl.Location = new Point(963, 207);
            accountPaginglbl.Name = "accountPaginglbl";
            accountPaginglbl.Size = new Size(144, 28);
            accountPaginglbl.TabIndex = 35;
            accountPaginglbl.Text = "Rows per page:";
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
            accountbtnLastPage.Location = new Point(1135, 759);
            accountbtnLastPage.Margin = new Padding(3, 4, 3, 4);
            accountbtnLastPage.Name = "accountbtnLastPage";
            accountbtnLastPage.Size = new Size(75, 44);
            accountbtnLastPage.TabIndex = 34;
            accountbtnLastPage.Text = "Last";
            accountbtnLastPage.Click += accountbtnLastPage_Click;
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
            accountbtnPrevPage.Location = new Point(806, 759);
            accountbtnPrevPage.Margin = new Padding(3, 4, 3, 4);
            accountbtnPrevPage.Name = "accountbtnPrevPage";
            accountbtnPrevPage.Size = new Size(72, 44);
            accountbtnPrevPage.TabIndex = 33;
            accountbtnPrevPage.Text = "Prev";
            accountbtnPrevPage.Click += accountbtnPrevPage_Click;
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
            accountbtnNxtPage.Location = new Point(1040, 759);
            accountbtnNxtPage.Margin = new Padding(3, 4, 3, 4);
            accountbtnNxtPage.Name = "accountbtnNxtPage";
            accountbtnNxtPage.Size = new Size(88, 44);
            accountbtnNxtPage.TabIndex = 32;
            accountbtnNxtPage.Text = "Next";
            accountbtnNxtPage.Click += accountbtnNxtPage_Click;
            // 
            // accountbtnFirstPage
            // 
            accountbtnFirstPage.BackColor = Color.CadetBlue;
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
            accountbtnFirstPage.Location = new Point(705, 759);
            accountbtnFirstPage.Margin = new Padding(3, 4, 3, 4);
            accountbtnFirstPage.Name = "accountbtnFirstPage";
            accountbtnFirstPage.Size = new Size(79, 44);
            accountbtnFirstPage.TabIndex = 31;
            accountbtnFirstPage.Text = "First";
            accountbtnFirstPage.Click += accountbtnFirstPage_Click;
            // 
            // enableAccountbtn
            // 
            enableAccountbtn.AccessibleRole = AccessibleRole.None;
            enableAccountbtn.BackColor = Color.LimeGreen;
            enableAccountbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enableAccountbtn.ForeColor = Color.White;
            enableAccountbtn.Location = new Point(507, 83);
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
            disableAccountbtn.Location = new Point(598, 83);
            disableAccountbtn.Margin = new Padding(5);
            disableAccountbtn.Name = "disableAccountbtn";
            disableAccountbtn.Size = new Size(91, 47);
            disableAccountbtn.TabIndex = 28;
            disableAccountbtn.Text = "Disable";
            disableAccountbtn.UseVisualStyleBackColor = false;
            disableAccountbtn.Click += disableAccountbtn_Click;
            // 
            // accountSearchBox
            // 
            accountSearchBox.BorderStyle = BorderStyle.None;
            accountSearchBox.Location = new Point(16, 144);
            accountSearchBox.Name = "accountSearchBox";
            accountSearchBox.PlaceholderText = "   Search";
            accountSearchBox.Size = new Size(847, 20);
            accountSearchBox.TabIndex = 30;
            accountSearchBox.TextChanged += accountSearchBox_TextChanged;
            // 
            // newAccountbtn
            // 
            newAccountbtn.AccessibleRole = AccessibleRole.None;
            newAccountbtn.BackColor = SystemColors.Menu;
            newAccountbtn.FlatStyle = FlatStyle.System;
            newAccountbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newAccountbtn.ForeColor = Color.Black;
            newAccountbtn.Location = new Point(13, 83);
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
            viewAccountbtn.Location = new Point(339, 83);
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
            editAccountbtn.Location = new Point(175, 83);
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
            dataGridViewCellStyle41.BackColor = Color.Gainsboro;
            dataGridViewCellStyle41.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle41.ForeColor = Color.Black;
            dataGridViewCellStyle41.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = Color.Black;
            userData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            userData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle42.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle42.ForeColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle42.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = DataGridViewTriState.True;
            userData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            userData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userData.Columns.AddRange(new DataGridViewColumn[] { usercheckColumn });
            dataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = SystemColors.Window;
            dataGridViewCellStyle43.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle43.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle43.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = DataGridViewTriState.True;
            userData.DefaultCellStyle = dataGridViewCellStyle43;
            userData.GridColor = SystemColors.WindowText;
            userData.Location = new Point(19, 260);
            userData.Margin = new Padding(3, 5, 3, 5);
            userData.Name = "userData";
            dataGridViewCellStyle44.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = SystemColors.Control;
            dataGridViewCellStyle44.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle44.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle44.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = DataGridViewTriState.True;
            userData.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            userData.RowHeadersVisible = false;
            userData.RowHeadersWidth = 51;
            dataGridViewCellStyle45.WrapMode = DataGridViewTriState.True;
            userData.RowsDefaultCellStyle = dataGridViewCellStyle45;
            userData.RowTemplate.Height = 24;
            userData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userData.Size = new Size(1191, 489);
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
            inventorypnl.Controls.Add(productSearchBtn);
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
            inventorypnl.Size = new Size(1247, 875);
            inventorypnl.TabIndex = 16;
            inventorypnl.Visible = false;
            // 
            // productSearchBtn
            // 
            productSearchBtn.AutoSize = true;
            productSearchBtn.BackColor = SystemColors.HighlightText;
            productSearchBtn.FlatAppearance.BorderColor = Color.Gray;
            productSearchBtn.FlatStyle = FlatStyle.System;
            productSearchBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productSearchBtn.ForeColor = Color.Black;
            productSearchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            productSearchBtn.ImageIndex = 0;
            productSearchBtn.Location = new Point(1085, 300);
            productSearchBtn.Margin = new Padding(3, 5, 3, 5);
            productSearchBtn.Name = "productSearchBtn";
            productSearchBtn.Size = new Size(143, 51);
            productSearchBtn.TabIndex = 32;
            productSearchBtn.Text = "Search";
            productSearchBtn.UseVisualStyleBackColor = false;
            productSearchBtn.Click += productSearchBtn_Click;
            // 
            // delProductbtn
            // 
            delProductbtn.BackColor = Color.Red;
            delProductbtn.FlatAppearance.BorderSize = 0;
            delProductbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            delProductbtn.ForeColor = Color.White;
            delProductbtn.Location = new Point(424, 295);
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
            stockSearchBox.Location = new Point(806, 316);
            stockSearchBox.Margin = new Padding(3, 5, 3, 5);
            stockSearchBox.Name = "stockSearchBox";
            stockSearchBox.PlaceholderText = "Search Product Name";
            stockSearchBox.Size = new Size(260, 27);
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
            dashboardpnl.Size = new Size(1296, 876);
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
            logpnl.Controls.Add(button1);
            logpnl.Controls.Add(button2);
            logpnl.Controls.Add(loglbl);
            logpnl.Controls.Add(logData);
            logpnl.Controls.Add(accountPageSizeBtn);
            logpnl.Controls.Add(button4);
            logpnl.Location = new Point(201, 3);
            logpnl.Margin = new Padding(3, 4, 3, 4);
            logpnl.Name = "logpnl";
            logpnl.Size = new Size(1250, 875);
            logpnl.TabIndex = 26;
            logpnl.Visible = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = SystemColors.HighlightText;
            button1.FlatAppearance.BorderColor = Color.Gray;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 0;
            button1.Location = new Point(1105, 812);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(142, 45);
            button1.TabIndex = 25;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = SystemColors.HighlightText;
            button2.FlatAppearance.BorderColor = Color.Gray;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageIndex = 0;
            button2.Location = new Point(914, 812);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(142, 45);
            button2.TabIndex = 24;
            button2.Text = "New";
            button2.UseVisualStyleBackColor = false;
            // 
            // loglbl
            // 
            loglbl.AutoSize = true;
            loglbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loglbl.Location = new Point(18, 19);
            loglbl.Name = "loglbl";
            loglbl.Size = new Size(202, 31);
            loglbl.TabIndex = 23;
            loglbl.Text = "Log Management";
            // 
            // logData
            // 
            dataGridViewCellStyle46.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = SystemColors.Control;
            dataGridViewCellStyle46.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle46.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle46.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = DataGridViewTriState.True;
            logData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            logData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle47.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = SystemColors.Window;
            dataGridViewCellStyle47.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle47.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle47.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = DataGridViewTriState.False;
            logData.DefaultCellStyle = dataGridViewCellStyle47;
            logData.Location = new Point(13, 111);
            logData.Margin = new Padding(3, 5, 3, 5);
            logData.Name = "logData";
            logData.RowHeadersWidth = 51;
            logData.RowTemplate.Height = 24;
            logData.Size = new Size(1235, 696);
            logData.TabIndex = 22;
            // 
            // accountPageSizeBtn
            // 
            accountPageSizeBtn.AutoSize = true;
            accountPageSizeBtn.BackColor = SystemColors.HighlightText;
            accountPageSizeBtn.FlatAppearance.BorderColor = Color.Gray;
            accountPageSizeBtn.FlatStyle = FlatStyle.System;
            accountPageSizeBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountPageSizeBtn.ForeColor = Color.Black;
            accountPageSizeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            accountPageSizeBtn.ImageIndex = 0;
            accountPageSizeBtn.Location = new Point(1098, 21);
            accountPageSizeBtn.Margin = new Padding(3, 4, 3, 4);
            accountPageSizeBtn.Name = "accountPageSizeBtn";
            accountPageSizeBtn.Size = new Size(149, 49);
            accountPageSizeBtn.TabIndex = 21;
            accountPageSizeBtn.Text = "Sale Reports";
            accountPageSizeBtn.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = SystemColors.HighlightText;
            button4.FlatAppearance.BorderColor = Color.Gray;
            button4.FlatStyle = FlatStyle.System;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImageIndex = 0;
            button4.Location = new Point(723, 812);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(142, 45);
            button4.TabIndex = 20;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = false;
            // 
            // OrderAccemblypnl
            // 
            OrderAccemblypnl.Controls.Add(orderaccemblySearchpnl);
            OrderAccemblypnl.Controls.Add(orderAccemblyData);
            OrderAccemblypnl.Controls.Add(orderAccemblylbl);
            OrderAccemblypnl.Location = new Point(201, 3);
            OrderAccemblypnl.Margin = new Padding(3, 4, 3, 4);
            OrderAccemblypnl.Name = "OrderAccemblypnl";
            OrderAccemblypnl.Size = new Size(1250, 875);
            OrderAccemblypnl.TabIndex = 7;
            OrderAccemblypnl.Visible = false;
            // 
            // accemblyCreatebtn
            // 
            accemblyCreatebtn.Location = new Point(903, 13);
            accemblyCreatebtn.Name = "accemblyCreatebtn";
            accemblyCreatebtn.Size = new Size(177, 51);
            accemblyCreatebtn.TabIndex = 8;
            accemblyCreatebtn.Text = "Create";
            accemblyCreatebtn.UseVisualStyleBackColor = true;
            // 
            // orderAccemblyData
            // 
            orderAccemblyData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderAccemblyData.Location = new Point(22, 291);
            orderAccemblyData.Name = "orderAccemblyData";
            orderAccemblyData.RowHeadersWidth = 51;
            orderAccemblyData.Size = new Size(1183, 539);
            orderAccemblyData.TabIndex = 7;
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
            // GRNpnl
            // 
            GRNpnl.Controls.Add(panel1);
            GRNpnl.Controls.Add(grnAddNoteBtn);
            GRNpnl.Controls.Add(grndata);
            GRNpnl.Controls.Add(GRNlbl);
            GRNpnl.Location = new Point(201, 3);
            GRNpnl.Margin = new Padding(3, 4, 3, 4);
            GRNpnl.Name = "GRNpnl";
            GRNpnl.Size = new Size(1250, 875);
            GRNpnl.TabIndex = 8;
            GRNpnl.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(grnDatePicker1);
            panel1.Controls.Add(grnlbl1);
            panel1.Controls.Add(grnclearBtn);
            panel1.Controls.Add(grnDatePicker2);
            panel1.Controls.Add(grnSearchBtn);
            panel1.Controls.Add(grnlbl2);
            panel1.Location = new Point(18, 72);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 193);
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
            grnAddNoteBtn.Location = new Point(1018, 6);
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
            dataGridViewCellStyle48.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = SystemColors.Control;
            dataGridViewCellStyle48.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle48.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle48.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle48.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = DataGridViewTriState.True;
            grndata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle48;
            grndata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grndata.Columns.AddRange(new DataGridViewColumn[] { grncheckColumn });
            dataGridViewCellStyle49.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = SystemColors.Window;
            dataGridViewCellStyle49.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle49.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle49.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle49.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle49.WrapMode = DataGridViewTriState.False;
            grndata.DefaultCellStyle = dataGridViewCellStyle49;
            grndata.Location = new Point(18, 347);
            grndata.Margin = new Padding(3, 4, 3, 4);
            grndata.MultiSelect = false;
            grndata.Name = "grndata";
            grndata.RowHeadersVisible = false;
            grndata.RowHeadersWidth = 51;
            grndata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grndata.Size = new Size(1143, 473);
            grndata.TabIndex = 7;
            grndata.CellContentClick += grndata_CellContentClick;
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
            deliverypnl.Controls.Add(panel2);
            deliverypnl.Controls.Add(deliveryData);
            deliverypnl.Controls.Add(deliveryAddbtn);
            deliverypnl.Controls.Add(deliverylbl);
            deliverypnl.Location = new Point(201, 3);
            deliverypnl.Margin = new Padding(3, 4, 3, 4);
            deliverypnl.Name = "deliverypnl";
            deliverypnl.Size = new Size(1250, 875);
            deliverypnl.TabIndex = 9;
            deliverypnl.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(deliveryViewDNbtn);
            panel2.Controls.Add(deliverydateTimePicker1);
            panel2.Controls.Add(deliverySearchIDbox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(deliverySearchDatebtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(deliveryclearbtn);
            panel2.Controls.Add(deliverydateTimePicker2);
            panel2.Location = new Point(22, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(1161, 225);
            panel2.TabIndex = 16;
            // 
            // deliveryViewDNbtn
            // 
            deliveryViewDNbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryViewDNbtn.Location = new Point(445, 131);
            deliveryViewDNbtn.Name = "deliveryViewDNbtn";
            deliveryViewDNbtn.Size = new Size(161, 44);
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
            // deliverySearchIDbox
            // 
            deliverySearchIDbox.Location = new Point(702, 141);
            deliverySearchIDbox.Name = "deliverySearchIDbox";
            deliverySearchIDbox.PlaceholderText = "Search ID";
            deliverySearchIDbox.Size = new Size(275, 27);
            deliverySearchIDbox.TabIndex = 14;
            deliverySearchIDbox.TextChanged += deliverySearchIDbtn_TextChanged;
            deliverySearchIDbox.KeyDown += deliverySearchIDbox_KeyDown;
            // 
            // deliverySearchDatebtn
            // 
            deliverySearchDatebtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliverySearchDatebtn.Location = new Point(24, 131);
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
            deliveryclearbtn.Location = new Point(222, 131);
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
            dataGridViewCellStyle50.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = SystemColors.Control;
            dataGridViewCellStyle50.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle50.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle50.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle50.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = DataGridViewTriState.True;
            deliveryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle50;
            deliveryData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            deliveryData.Columns.AddRange(new DataGridViewColumn[] { deliverycheckColumn });
            dataGridViewCellStyle51.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = SystemColors.Window;
            dataGridViewCellStyle51.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle51.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle51.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle51.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle51.WrapMode = DataGridViewTriState.False;
            deliveryData.DefaultCellStyle = dataGridViewCellStyle51;
            deliveryData.Location = new Point(22, 299);
            deliveryData.Name = "deliveryData";
            deliveryData.RowHeadersVisible = false;
            deliveryData.RowHeadersWidth = 51;
            deliveryData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            deliveryData.Size = new Size(1166, 504);
            deliveryData.TabIndex = 7;
            deliveryData.CellClick += deliveryData_CellClick;
            deliveryData.CellContentClick += deliveryData_CellContentClick;
            // 
            // deliveryAddbtn
            // 
            deliveryAddbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryAddbtn.Location = new Point(1006, 7);
            deliveryAddbtn.Name = "deliveryAddbtn";
            deliveryAddbtn.Size = new Size(177, 61);
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
            // orderaccemblySearchpnl
            // 
            orderaccemblySearchpnl.Controls.Add(orderAccemblySearchbtn);
            orderaccemblySearchpnl.Controls.Add(orderAccemblyClearbtn);
            orderaccemblySearchpnl.Controls.Add(orderAccemblySearchbox);
            orderaccemblySearchpnl.Controls.Add(orderAccemblydateTimePicker);
            orderaccemblySearchpnl.Controls.Add(accemblyCreatebtn);
            orderaccemblySearchpnl.Controls.Add(label5);
            orderaccemblySearchpnl.Controls.Add(orderAccemblydateTimePicker2);
            orderaccemblySearchpnl.Controls.Add(label6);
            orderaccemblySearchpnl.Location = new Point(27, 58);
            orderaccemblySearchpnl.Margin = new Padding(3, 4, 3, 4);
            orderaccemblySearchpnl.Name = "orderaccemblySearchpnl";
            orderaccemblySearchpnl.Size = new Size(1134, 193);
            orderaccemblySearchpnl.TabIndex = 16;
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
            // orderAccemblySearchbox
            // 
            orderAccemblySearchbox.Location = new Point(661, 150);
            orderAccemblySearchbox.Name = "orderAccemblySearchbox";
            orderAccemblySearchbox.Size = new Size(440, 27);
            orderAccemblySearchbox.TabIndex = 17;
            // 
            // orderAccemblyClearbtn
            // 
            orderAccemblyClearbtn.Location = new Point(210, 130);
            orderAccemblyClearbtn.Name = "orderAccemblyClearbtn";
            orderAccemblyClearbtn.Size = new Size(138, 43);
            orderAccemblyClearbtn.TabIndex = 18;
            orderAccemblyClearbtn.Text = "Clear";
            orderAccemblyClearbtn.UseVisualStyleBackColor = true;
            // 
            // orderAccemblySearchbtn
            // 
            orderAccemblySearchbtn.Location = new Point(39, 130);
            orderAccemblySearchbtn.Name = "orderAccemblySearchbtn";
            orderAccemblySearchbtn.Size = new Size(130, 43);
            orderAccemblySearchbtn.TabIndex = 19;
            orderAccemblySearchbtn.Text = "Create";
            orderAccemblySearchbtn.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1499, 875);
            Controls.Add(OrderAccemblypnl);
            Controls.Add(GRNpnl);
            Controls.Add(userspnl);
            Controls.Add(orderpnl);
            Controls.Add(closebtn);
            Controls.Add(listpnl);
            Controls.Add(logpnl);
            Controls.Add(contactpnl);
            Controls.Add(dashboardpnl);
            Controls.Add(settingpnl);
            Controls.Add(inventorypnl);
            Controls.Add(deliverypnl);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Padding = new Padding(0, 0, 10, 0);
            StartPosition = FormStartPosition.CenterScreen;
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
            contactGroupBox.ResumeLayout(false);
            contactGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contactsdata).EndInit();
            settingpnl.ResumeLayout(false);
            settingpnl.PerformLayout();
            userspnl.ResumeLayout(false);
            userspnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userData).EndInit();
            inventorypnl.ResumeLayout(false);
            inventorypnl.PerformLayout();
            dashboardpnl.ResumeLayout(false);
            dashboardpnl.PerformLayout();
            logpnl.ResumeLayout(false);
            logpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logData).EndInit();
            OrderAccemblypnl.ResumeLayout(false);
            OrderAccemblypnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderAccemblyData).EndInit();
            GRNpnl.ResumeLayout(false);
            GRNpnl.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grndata).EndInit();
            deliverypnl.ResumeLayout(false);
            deliverypnl.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)deliveryData).EndInit();
            orderaccemblySearchpnl.ResumeLayout(false);
            orderaccemblySearchpnl.PerformLayout();
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
        private System.Windows.Forms.Button settingbtn;
        private System.Windows.Forms.ImageList setting_logo;
        private System.Windows.Forms.Panel orderpnl;
        private System.Windows.Forms.Panel inventorypnl;
        private System.Windows.Forms.Panel userspnl;
        private System.Windows.Forms.Label stocklbl;
        private System.Windows.Forms.Panel settingpnl;
        private System.Windows.Forms.Label settinglbl;
        private System.Windows.Forms.Label userslbl;
        private System.Windows.Forms.Panel dashboardpnl;
        private System.Windows.Forms.Button contactsbtn;
        private System.Windows.Forms.Panel contactpnl;
        private System.Windows.Forms.Button supplersbtn;
        private System.Windows.Forms.Button dealersbtn;
        private CustomDataGridView contactsdata;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label loglbl;
        private CustomDataGridView logData;
        private System.Windows.Forms.Button accountPageSizeBtn;
        private System.Windows.Forms.Button button4;
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
        private TextBox stockSearchBox;
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
        private Button productSearchBtn;
        private CustomDataGridView deliveryData;
        private DateTimePicker deliverydateTimePicker1;
        private TextBox deliverySearchIDbox;
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
        private DataGridViewCheckBoxColumn contactcheckColumn;
        private DataGridViewCheckBoxColumn usercheckColumn;
        private DataGridViewCheckBoxColumn stockcheckColumn;
        private Button searchSupplierbtn;
        private Button orderCancelbtn;
        private Button orderPendingbtn;
        private Button orderActivebtn;
        private Button orderoverallBtn;
        private CustomDataGridView userData;
        private ProgramMethod.ProgramMethod.RoundedButton accountbtnLastPage;
        private ProgramMethod.ProgramMethod.RoundedButton accountbtnPrevPage;
        private ProgramMethod.ProgramMethod.RoundedButton accountbtnNxtPage;
        private ProgramMethod.ProgramMethod.RoundedButton accountbtnFirstPage;
        private ProgramMethod.ProgramMethod.RoundedTextBox accountSearchBox;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton2;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton1;
        private Label label4;
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
    }
}