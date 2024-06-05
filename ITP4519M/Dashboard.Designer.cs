using Org.BouncyCastle.Asn1.Crmf;
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
            listpnl = new Panel();
            deliverybtn = new Button();
            log_logo = new ImageList(components);
            GRNbtn = new Button();
            outstandingOrderbtn = new Button();
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
            orderdata = new DataGridView();
            viewOrderbtn = new Button();
            newOrderbtn = new Button();
            ordlerlbl = new Label();
            saleReportbtn = new Button();
            editOrdersbtn = new Button();
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
            stockData = new DataGridView();
            viewProductbtn = new Button();
            accountSearchBtn = new Button();
            accountSearchBox = new TextBox();
            contactpnl = new Panel();
            supplersbtn = new Button();
            dealersbtn = new Button();
            contactsdata = new DataGridView();
            settingpnl = new Panel();
            settinglbl = new Label();
            userspnl = new Panel();
            enableAccountbtn = new Button();
            disableAccountbtn = new Button();
            newAccountbtn = new Button();
            viewAccountbtn = new Button();
            editAccountbtn = new Button();
            userData = new DataGridView();
            userslbl = new Label();
            inventorypnl = new Panel();
            delProductbtn = new Button();
            stockSearchBox = new TextBox();
            dashboardpnl = new Panel();
            label1 = new Label();
            logpnl = new Panel();
            button1 = new Button();
            button2 = new Button();
            loglbl = new Label();
            logData = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            outstandingOrderpnl = new Panel();
            outstandingOrderlbl = new Label();
            GRNpnl = new Panel();
            panel1 = new Panel();
            grnDatePicker1 = new DateTimePicker();
            grnAddNoteBtn = new Button();
            grnlbl1 = new Label();
            grnclearBtn = new Button();
            grnDatePicker2 = new DateTimePicker();
            grnSearchBtn = new Button();
            grnlbl2 = new Label();
            grndata = new DataGridView();
            GRNlbl = new Label();
            deliverypnl = new Panel();
            deliverylbl = new Label();
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
            ((System.ComponentModel.ISupportInitialize)contactsdata).BeginInit();
            settingpnl.SuspendLayout();
            userspnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userData).BeginInit();
            inventorypnl.SuspendLayout();
            dashboardpnl.SuspendLayout();
            logpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logData).BeginInit();
            outstandingOrderpnl.SuspendLayout();
            GRNpnl.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grndata).BeginInit();
            deliverypnl.SuspendLayout();
            SuspendLayout();
            // 
            // listpnl
            // 
            listpnl.BackColor = SystemColors.MenuText;
            listpnl.BackgroundImageLayout = ImageLayout.Stretch;
            listpnl.Controls.Add(deliverybtn);
            listpnl.Controls.Add(GRNbtn);
            listpnl.Controls.Add(outstandingOrderbtn);
            listpnl.Controls.Add(Logbtn);
            listpnl.Controls.Add(contactsbtn);
            listpnl.Controls.Add(settingbtn);
            listpnl.Controls.Add(usersbtn);
            listpnl.Controls.Add(stockbtn);
            listpnl.Controls.Add(orderbtn);
            listpnl.Controls.Add(usertypelbl);
            listpnl.Controls.Add(namelbl);
            listpnl.Controls.Add(avatarbox);
            listpnl.Location = new Point(0, 2);
            listpnl.Name = "listpnl";
            listpnl.Size = new Size(175, 657);
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
            deliverybtn.Location = new Point(22, 435);
            deliverybtn.Name = "deliverybtn";
            deliverybtn.Size = new Size(145, 38);
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
            GRNbtn.Location = new Point(22, 382);
            GRNbtn.Name = "GRNbtn";
            GRNbtn.Size = new Size(145, 38);
            GRNbtn.TabIndex = 10;
            GRNbtn.Text = "Delivery    ";
            GRNbtn.UseVisualStyleBackColor = true;
            GRNbtn.Click += GRNbtn_Click;
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
            outstandingOrderbtn.Location = new Point(22, 278);
            outstandingOrderbtn.Name = "outstandingOrderbtn";
            outstandingOrderbtn.Size = new Size(150, 48);
            outstandingOrderbtn.TabIndex = 9;
            outstandingOrderbtn.Text = "         Outstanding\r\n         Order ";
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
            Logbtn.Location = new Point(22, 540);
            Logbtn.Name = "Logbtn";
            Logbtn.Size = new Size(145, 38);
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
            contactsbtn.Location = new Point(22, 330);
            contactsbtn.Name = "contactsbtn";
            contactsbtn.Size = new Size(145, 48);
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
            settingbtn.Location = new Point(22, 592);
            settingbtn.Name = "settingbtn";
            settingbtn.Size = new Size(145, 38);
            settingbtn.TabIndex = 6;
            settingbtn.Text = "  Setting  ";
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
            usersbtn.Location = new Point(22, 488);
            usersbtn.Name = "usersbtn";
            usersbtn.Size = new Size(145, 38);
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
            stockbtn.Location = new Point(22, 225);
            stockbtn.Name = "stockbtn";
            stockbtn.Size = new Size(145, 42);
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
            orderbtn.Location = new Point(22, 172);
            orderbtn.Name = "orderbtn";
            orderbtn.Size = new Size(145, 43);
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
            usertypelbl.Location = new Point(43, 124);
            usertypelbl.Name = "usertypelbl";
            usertypelbl.Size = new Size(92, 23);
            usertypelbl.TabIndex = 2;
            usertypelbl.Text = "Type";
            usertypelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // namelbl
            // 
            namelbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namelbl.ForeColor = Color.White;
            namelbl.Location = new Point(40, 102);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(102, 22);
            namelbl.TabIndex = 1;
            namelbl.Text = "UserName";
            namelbl.TextAlign = ContentAlignment.MiddleCenter;
            namelbl.Click += namelbl_Click;
            // 
            // avatarbox
            // 
            avatarbox.BackgroundImage = Properties.Resources.users_logo;
            avatarbox.BackgroundImageLayout = ImageLayout.Stretch;
            avatarbox.Location = new Point(47, 28);
            avatarbox.Name = "avatarbox";
            avatarbox.Size = new Size(82, 70);
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
            closebtn.Location = new Point(1275, 2);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(35, 38);
            closebtn.TabIndex = 15;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += CloseButton_Click;
            // 
            // orderpnl
            // 
            orderpnl.Controls.Add(orderdata);
            orderpnl.Controls.Add(viewOrderbtn);
            orderpnl.Controls.Add(newOrderbtn);
            orderpnl.Controls.Add(ordlerlbl);
            orderpnl.Controls.Add(saleReportbtn);
            orderpnl.Controls.Add(editOrdersbtn);
            orderpnl.Location = new Point(176, 2);
            orderpnl.Name = "orderpnl";
            orderpnl.Size = new Size(1094, 656);
            orderpnl.TabIndex = 16;
            orderpnl.Visible = false;
            // 
            // orderdata
            // 
            orderdata.AllowUserToAddRows = false;
            orderdata.AllowUserToDeleteRows = false;
            orderdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderdata.Location = new Point(10, 70);
            orderdata.Name = "orderdata";
            orderdata.RowHeadersWidth = 51;
            orderdata.Size = new Size(1078, 514);
            orderdata.TabIndex = 27;
            orderdata.CellClick += orderdata_CellClick;
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
            viewOrderbtn.Location = new Point(929, 590);
            viewOrderbtn.Name = "viewOrderbtn";
            viewOrderbtn.Size = new Size(162, 42);
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
            newOrderbtn.Location = new Point(762, 590);
            newOrderbtn.Name = "newOrderbtn";
            newOrderbtn.Size = new Size(162, 42);
            newOrderbtn.TabIndex = 24;
            newOrderbtn.Text = "New Orders";
            newOrderbtn.UseVisualStyleBackColor = false;
            newOrderbtn.Click += newOrderbtn_Click;
            // 
            // ordlerlbl
            // 
            ordlerlbl.AutoSize = true;
            ordlerlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ordlerlbl.Location = new Point(16, 18);
            ordlerlbl.Name = "ordlerlbl";
            ordlerlbl.Size = new Size(236, 25);
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
            saleReportbtn.Location = new Point(961, 16);
            saleReportbtn.Name = "saleReportbtn";
            saleReportbtn.Size = new Size(130, 37);
            saleReportbtn.TabIndex = 21;
            saleReportbtn.Text = "Sale Reports";
            saleReportbtn.UseVisualStyleBackColor = false;
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
            editOrdersbtn.Location = new Point(595, 590);
            editOrdersbtn.Name = "editOrdersbtn";
            editOrdersbtn.Size = new Size(162, 42);
            editOrdersbtn.TabIndex = 20;
            editOrdersbtn.Text = "Edit Orders";
            editOrdersbtn.UseVisualStyleBackColor = false;
            editOrdersbtn.Click += editOrdersbtn_Click;
            // 
            // stocklbl
            // 
            stocklbl.AutoSize = true;
            stocklbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stocklbl.Location = new Point(18, 9);
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
            stockSummarypnl.Location = new Point(18, 51);
            stockSummarypnl.Name = "stockSummarypnl";
            stockSummarypnl.Size = new Size(1073, 162);
            stockSummarypnl.TabIndex = 26;
            // 
            // stockDatapanel3
            // 
            stockDatapanel3.Controls.Add(stocklbl3);
            stockDatapanel3.Controls.Add(stockProductDatalbl3);
            stockDatapanel3.Location = new Point(761, 16);
            stockDatapanel3.Name = "stockDatapanel3";
            stockDatapanel3.Size = new Size(266, 140);
            stockDatapanel3.TabIndex = 28;
            // 
            // stocklbl3
            // 
            stocklbl3.AutoSize = true;
            stocklbl3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stocklbl3.Location = new Point(40, 109);
            stocklbl3.Name = "stocklbl3";
            stocklbl3.Size = new Size(191, 30);
            stocklbl3.TabIndex = 5;
            stocklbl3.Text = "Total DemandStock";
            // 
            // stockProductDatalbl3
            // 
            stockProductDatalbl3.AutoSize = true;
            stockProductDatalbl3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockProductDatalbl3.Location = new Point(41, 43);
            stockProductDatalbl3.Name = "stockProductDatalbl3";
            stockProductDatalbl3.Size = new Size(196, 50);
            stockProductDatalbl3.TabIndex = 4;
            stockProductDatalbl3.Text = "LabelData";
            // 
            // stockDatapanel1
            // 
            stockDatapanel1.Controls.Add(stocklbl1);
            stockDatapanel1.Controls.Add(stockProductDatalbl1);
            stockDatapanel1.Location = new Point(57, 16);
            stockDatapanel1.Name = "stockDatapanel1";
            stockDatapanel1.Size = new Size(266, 140);
            stockDatapanel1.TabIndex = 0;
            // 
            // stocklbl1
            // 
            stocklbl1.AutoSize = true;
            stocklbl1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stocklbl1.Location = new Point(18, 109);
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
            stockProductDatalbl1.Location = new Point(18, 43);
            stockProductDatalbl1.Name = "stockProductDatalbl1";
            stockProductDatalbl1.Size = new Size(196, 50);
            stockProductDatalbl1.TabIndex = 0;
            stockProductDatalbl1.Text = "LabelData";
            stockProductDatalbl1.Click += label1_Click;
            // 
            // stockDatapanel2
            // 
            stockDatapanel2.Controls.Add(stockProductDatalbl2);
            stockDatapanel2.Controls.Add(stocklbl2);
            stockDatapanel2.Location = new Point(402, 16);
            stockDatapanel2.Name = "stockDatapanel2";
            stockDatapanel2.Size = new Size(266, 140);
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
            stocklbl2.Location = new Point(40, 109);
            stocklbl2.Name = "stocklbl2";
            stocklbl2.Size = new Size(143, 30);
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
            editProductbtn.Location = new Point(10, 221);
            editProductbtn.Name = "editProductbtn";
            editProductbtn.Size = new Size(162, 42);
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
            newProductbtn.Location = new Point(939, 14);
            newProductbtn.Name = "newProductbtn";
            newProductbtn.Size = new Size(152, 36);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            stockData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            stockData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            stockData.DefaultCellStyle = dataGridViewCellStyle2;
            stockData.Location = new Point(10, 269);
            stockData.Name = "stockData";
            stockData.ReadOnly = true;
            stockData.RowHeadersWidth = 51;
            stockData.RowTemplate.Height = 24;
            stockData.Size = new Size(1081, 351);
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
            viewProductbtn.Location = new Point(192, 221);
            viewProductbtn.Name = "viewProductbtn";
            viewProductbtn.Size = new Size(162, 42);
            viewProductbtn.TabIndex = 29;
            viewProductbtn.Text = "View Product";
            viewProductbtn.UseVisualStyleBackColor = false;
            viewProductbtn.Click += viewProductbtn_Click;
            // 
            // accountSearchBtn
            // 
            accountSearchBtn.AutoSize = true;
            accountSearchBtn.BackColor = SystemColors.HighlightText;
            accountSearchBtn.FlatAppearance.BorderColor = Color.Gray;
            accountSearchBtn.FlatStyle = FlatStyle.System;
            accountSearchBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountSearchBtn.ForeColor = Color.Black;
            accountSearchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            accountSearchBtn.ImageIndex = 0;
            accountSearchBtn.Location = new Point(920, 62);
            accountSearchBtn.Name = "accountSearchBtn";
            accountSearchBtn.Size = new Size(155, 32);
            accountSearchBtn.TabIndex = 27;
            accountSearchBtn.Text = "Search";
            accountSearchBtn.UseVisualStyleBackColor = false;
            accountSearchBtn.Click += accountSearchBtn_Click;
            // 
            // accountSearchBox
            // 
            accountSearchBox.Location = new Point(705, 70);
            accountSearchBox.Name = "accountSearchBox";
            accountSearchBox.PlaceholderText = "Search Username";
            accountSearchBox.Size = new Size(197, 23);
            accountSearchBox.TabIndex = 26;
            // 
            // contactpnl
            // 
            contactpnl.Controls.Add(supplersbtn);
            contactpnl.Controls.Add(dealersbtn);
            contactpnl.Controls.Add(contactsdata);
            contactpnl.Location = new Point(176, 2);
            contactpnl.Name = "contactpnl";
            contactpnl.Size = new Size(1094, 656);
            contactpnl.TabIndex = 1;
            contactpnl.Visible = false;
            contactpnl.Paint += contactpnl_Paint;
            // 
            // supplersbtn
            // 
            supplersbtn.AutoSize = true;
            supplersbtn.BackColor = SystemColors.HighlightText;
            supplersbtn.FlatAppearance.BorderColor = Color.Gray;
            supplersbtn.FlatStyle = FlatStyle.System;
            supplersbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplersbtn.ForeColor = Color.Black;
            supplersbtn.ImageAlign = ContentAlignment.MiddleLeft;
            supplersbtn.ImageIndex = 0;
            supplersbtn.Location = new Point(220, 14);
            supplersbtn.Name = "supplersbtn";
            supplersbtn.Size = new Size(200, 42);
            supplersbtn.TabIndex = 18;
            supplersbtn.Text = "Supplers information";
            supplersbtn.UseVisualStyleBackColor = false;
            supplersbtn.Click += supplersbtn_Click_1;
            // 
            // dealersbtn
            // 
            dealersbtn.AutoSize = true;
            dealersbtn.BackColor = SystemColors.HighlightText;
            dealersbtn.FlatAppearance.BorderColor = Color.Gray;
            dealersbtn.FlatStyle = FlatStyle.System;
            dealersbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dealersbtn.ForeColor = Color.Black;
            dealersbtn.ImageAlign = ContentAlignment.MiddleLeft;
            dealersbtn.ImageIndex = 0;
            dealersbtn.Location = new Point(10, 14);
            dealersbtn.Name = "dealersbtn";
            dealersbtn.Size = new Size(205, 42);
            dealersbtn.TabIndex = 17;
            dealersbtn.Text = "Dealers information";
            dealersbtn.UseVisualStyleBackColor = false;
            dealersbtn.Click += dealersbtn_Click;
            // 
            // contactsdata
            // 
            contactsdata.AllowUserToAddRows = false;
            contactsdata.AllowUserToDeleteRows = false;
            contactsdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            contactsdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            contactsdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            contactsdata.DefaultCellStyle = dataGridViewCellStyle4;
            contactsdata.Location = new Point(10, 62);
            contactsdata.Name = "contactsdata";
            contactsdata.RowHeadersWidth = 51;
            contactsdata.RowTemplate.Height = 24;
            contactsdata.Size = new Size(1081, 522);
            contactsdata.TabIndex = 19;
            // 
            // settingpnl
            // 
            settingpnl.Controls.Add(settinglbl);
            settingpnl.Location = new Point(176, 2);
            settingpnl.Name = "settingpnl";
            settingpnl.Size = new Size(1094, 656);
            settingpnl.TabIndex = 5;
            settingpnl.Visible = false;
            // 
            // settinglbl
            // 
            settinglbl.AutoSize = true;
            settinglbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settinglbl.Location = new Point(16, 18);
            settinglbl.Name = "settinglbl";
            settinglbl.Size = new Size(76, 25);
            settinglbl.TabIndex = 6;
            settinglbl.Text = "Setting";
            // 
            // userspnl
            // 
            userspnl.Controls.Add(enableAccountbtn);
            userspnl.Controls.Add(disableAccountbtn);
            userspnl.Controls.Add(accountSearchBtn);
            userspnl.Controls.Add(accountSearchBox);
            userspnl.Controls.Add(newAccountbtn);
            userspnl.Controls.Add(viewAccountbtn);
            userspnl.Controls.Add(editAccountbtn);
            userspnl.Controls.Add(userData);
            userspnl.Controls.Add(userslbl);
            userspnl.Location = new Point(176, 2);
            userspnl.Name = "userspnl";
            userspnl.Size = new Size(1094, 656);
            userspnl.TabIndex = 3;
            userspnl.Visible = false;
            // 
            // enableAccountbtn
            // 
            enableAccountbtn.AccessibleRole = AccessibleRole.None;
            enableAccountbtn.BackColor = Color.LimeGreen;
            enableAccountbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enableAccountbtn.ForeColor = Color.White;
            enableAccountbtn.Location = new Point(444, 62);
            enableAccountbtn.Margin = new Padding(4);
            enableAccountbtn.Name = "enableAccountbtn";
            enableAccountbtn.Size = new Size(80, 35);
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
            disableAccountbtn.Location = new Point(523, 62);
            disableAccountbtn.Margin = new Padding(4);
            disableAccountbtn.Name = "disableAccountbtn";
            disableAccountbtn.Size = new Size(80, 35);
            disableAccountbtn.TabIndex = 28;
            disableAccountbtn.Text = "Disable";
            disableAccountbtn.UseVisualStyleBackColor = false;
            disableAccountbtn.Click += disableAccountbtn_Click;
            // 
            // newAccountbtn
            // 
            newAccountbtn.AccessibleRole = AccessibleRole.None;
            newAccountbtn.BackColor = SystemColors.Menu;
            newAccountbtn.FlatStyle = FlatStyle.System;
            newAccountbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newAccountbtn.ForeColor = Color.Black;
            newAccountbtn.Location = new Point(10, 62);
            newAccountbtn.Margin = new Padding(4);
            newAccountbtn.Name = "newAccountbtn";
            newAccountbtn.Size = new Size(139, 35);
            newAccountbtn.TabIndex = 24;
            newAccountbtn.Text = "New Account";
            newAccountbtn.UseVisualStyleBackColor = false;
            newAccountbtn.Click += newAccountbtn_Click;
            // 
            // viewAccountbtn
            // 
            viewAccountbtn.AccessibleRole = AccessibleRole.None;
            viewAccountbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewAccountbtn.Location = new Point(297, 62);
            viewAccountbtn.Margin = new Padding(4);
            viewAccountbtn.Name = "viewAccountbtn";
            viewAccountbtn.Size = new Size(139, 35);
            viewAccountbtn.TabIndex = 23;
            viewAccountbtn.Text = "View Account";
            viewAccountbtn.UseVisualStyleBackColor = true;
            viewAccountbtn.Click += viewAccountbtn_Click;
            // 
            // editAccountbtn
            // 
            editAccountbtn.AccessibleRole = AccessibleRole.None;
            editAccountbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editAccountbtn.Location = new Point(153, 62);
            editAccountbtn.Margin = new Padding(4);
            editAccountbtn.Name = "editAccountbtn";
            editAccountbtn.Size = new Size(139, 35);
            editAccountbtn.TabIndex = 22;
            editAccountbtn.Text = "Eidt Account";
            editAccountbtn.UseVisualStyleBackColor = true;
            editAccountbtn.Click += editAccountbtn_Click;
            // 
            // userData
            // 
            userData.AllowUserToAddRows = false;
            userData.AllowUserToDeleteRows = false;
            userData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            userData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            userData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            userData.DefaultCellStyle = dataGridViewCellStyle6;
            userData.Location = new Point(10, 102);
            userData.Name = "userData";
            userData.ReadOnly = true;
            userData.RowHeadersWidth = 51;
            userData.RowTemplate.Height = 24;
            userData.Size = new Size(1081, 530);
            userData.TabIndex = 1;
            userData.CellClick += userData_CellClick;
            // 
            // userslbl
            // 
            userslbl.AutoSize = true;
            userslbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userslbl.Location = new Point(16, 18);
            userslbl.Name = "userslbl";
            userslbl.Size = new Size(183, 25);
            userslbl.TabIndex = 0;
            userslbl.Text = "Users Management";
            // 
            // inventorypnl
            // 
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
            inventorypnl.Size = new Size(1091, 656);
            inventorypnl.TabIndex = 16;
            inventorypnl.Visible = false;
            // 
            // delProductbtn
            // 
            delProductbtn.BackColor = Color.Red;
            delProductbtn.FlatAppearance.BorderSize = 0;
            delProductbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            delProductbtn.ForeColor = Color.White;
            delProductbtn.Location = new Point(371, 221);
            delProductbtn.Name = "delProductbtn";
            delProductbtn.Size = new Size(162, 42);
            delProductbtn.TabIndex = 31;
            delProductbtn.Text = "Delete Product";
            delProductbtn.UseVisualStyleBackColor = false;
            delProductbtn.Click += delProductbtn_Click;
            // 
            // stockSearchBox
            // 
            stockSearchBox.Location = new Point(779, 231);
            stockSearchBox.Name = "stockSearchBox";
            stockSearchBox.PlaceholderText = "Search";
            stockSearchBox.Size = new Size(250, 23);
            stockSearchBox.TabIndex = 30;
            // 
            // dashboardpnl
            // 
            dashboardpnl.BackgroundImage = Properties.Resources.dashboard_background;
            dashboardpnl.BackgroundImageLayout = ImageLayout.Stretch;
            dashboardpnl.Controls.Add(label1);
            dashboardpnl.Location = new Point(176, 2);
            dashboardpnl.Name = "dashboardpnl";
            dashboardpnl.Size = new Size(1134, 657);
            dashboardpnl.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Calibri", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 87);
            label1.Name = "label1";
            label1.Size = new Size(512, 39);
            label1.TabIndex = 2;
            label1.Text = "Welcome to the LM Company System";
            // 
            // logpnl
            // 
            logpnl.Controls.Add(button1);
            logpnl.Controls.Add(button2);
            logpnl.Controls.Add(loglbl);
            logpnl.Controls.Add(logData);
            logpnl.Controls.Add(button3);
            logpnl.Controls.Add(button4);
            logpnl.Location = new Point(176, 2);
            logpnl.Name = "logpnl";
            logpnl.Size = new Size(1094, 656);
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
            button1.Location = new Point(929, 590);
            button1.Name = "button1";
            button1.Size = new Size(162, 42);
            button1.TabIndex = 25;
            button1.Text = "View Orders";
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
            button2.Location = new Point(762, 590);
            button2.Name = "button2";
            button2.Size = new Size(162, 42);
            button2.TabIndex = 24;
            button2.Text = "New Orders";
            button2.UseVisualStyleBackColor = false;
            // 
            // loglbl
            // 
            loglbl.AutoSize = true;
            loglbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loglbl.Location = new Point(16, 14);
            loglbl.Name = "loglbl";
            loglbl.Size = new Size(169, 25);
            loglbl.TabIndex = 23;
            loglbl.Text = "Log Management";
            // 
            // logData
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            logData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            logData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            logData.DefaultCellStyle = dataGridViewCellStyle8;
            logData.Location = new Point(10, 62);
            logData.Name = "logData";
            logData.RowHeadersWidth = 51;
            logData.RowTemplate.Height = 24;
            logData.Size = new Size(1081, 522);
            logData.TabIndex = 22;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = SystemColors.HighlightText;
            button3.FlatAppearance.BorderColor = Color.Gray;
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 0;
            button3.Location = new Point(961, 16);
            button3.Name = "button3";
            button3.Size = new Size(130, 37);
            button3.TabIndex = 21;
            button3.Text = "Sale Reports";
            button3.UseVisualStyleBackColor = false;
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
            button4.Location = new Point(595, 590);
            button4.Name = "button4";
            button4.Size = new Size(162, 42);
            button4.TabIndex = 20;
            button4.Text = "Edit Orders";
            button4.UseVisualStyleBackColor = false;
            // 
            // outstandingOrderpnl
            // 
            outstandingOrderpnl.Controls.Add(outstandingOrderlbl);
            outstandingOrderpnl.Location = new Point(176, 2);
            outstandingOrderpnl.Name = "outstandingOrderpnl";
            outstandingOrderpnl.Size = new Size(1094, 656);
            outstandingOrderpnl.TabIndex = 7;
            outstandingOrderpnl.Visible = false;
            // 
            // outstandingOrderlbl
            // 
            outstandingOrderlbl.AutoSize = true;
            outstandingOrderlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outstandingOrderlbl.Location = new Point(16, 18);
            outstandingOrderlbl.Name = "outstandingOrderlbl";
            outstandingOrderlbl.Size = new Size(180, 25);
            outstandingOrderlbl.TabIndex = 6;
            outstandingOrderlbl.Text = "Outstanding Order";
            // 
            // GRNpnl
            // 
            GRNpnl.Controls.Add(panel1);
            GRNpnl.Controls.Add(grndata);
            GRNpnl.Controls.Add(GRNlbl);
            GRNpnl.Location = new Point(176, 2);
            GRNpnl.Name = "GRNpnl";
            GRNpnl.Size = new Size(1094, 656);
            GRNpnl.TabIndex = 8;
            GRNpnl.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(grnDatePicker1);
            panel1.Controls.Add(grnAddNoteBtn);
            panel1.Controls.Add(grnlbl1);
            panel1.Controls.Add(grnclearBtn);
            panel1.Controls.Add(grnDatePicker2);
            panel1.Controls.Add(grnSearchBtn);
            panel1.Controls.Add(grnlbl2);
            panel1.Location = new Point(16, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 145);
            panel1.TabIndex = 15;
            // 
            // grnDatePicker1
            // 
            grnDatePicker1.Location = new Point(34, 48);
            grnDatePicker1.Name = "grnDatePicker1";
            grnDatePicker1.Size = new Size(200, 23);
            grnDatePicker1.TabIndex = 8;
            // 
            // grnAddNoteBtn
            // 
            grnAddNoteBtn.Location = new Point(327, 109);
            grnAddNoteBtn.Name = "grnAddNoteBtn";
            grnAddNoteBtn.Size = new Size(75, 23);
            grnAddNoteBtn.TabIndex = 14;
            grnAddNoteBtn.Text = "Add";
            grnAddNoteBtn.UseVisualStyleBackColor = true;
            grnAddNoteBtn.Click += grnAddNoteBtn_Click;
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
            // grnclearBtn
            // 
            grnclearBtn.Location = new Point(174, 109);
            grnclearBtn.Name = "grnclearBtn";
            grnclearBtn.Size = new Size(75, 23);
            grnclearBtn.TabIndex = 13;
            grnclearBtn.Text = "Clear";
            grnclearBtn.UseVisualStyleBackColor = true;
            grnclearBtn.Click += grnclearBtn_Click;
            // 
            // grnDatePicker2
            // 
            grnDatePicker2.Location = new Point(315, 48);
            grnDatePicker2.Name = "grnDatePicker2";
            grnDatePicker2.Size = new Size(200, 23);
            grnDatePicker2.TabIndex = 9;
            // 
            // grnSearchBtn
            // 
            grnSearchBtn.Location = new Point(34, 109);
            grnSearchBtn.Name = "grnSearchBtn";
            grnSearchBtn.Size = new Size(75, 23);
            grnSearchBtn.TabIndex = 12;
            grnSearchBtn.Text = "grnSearchBtn";
            grnSearchBtn.UseVisualStyleBackColor = true;
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
            // grndata
            // 
            grndata.AllowUserToAddRows = false;
            grndata.AllowUserToDeleteRows = false;
            grndata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grndata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grndata.Location = new Point(16, 260);
            grndata.Name = "grndata";
            grndata.Size = new Size(1000, 355);
            grndata.TabIndex = 7;
            // 
            // GRNlbl
            // 
            GRNlbl.AutoSize = true;
            GRNlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GRNlbl.Location = new Point(16, 18);
            GRNlbl.Name = "GRNlbl";
            GRNlbl.Size = new Size(194, 25);
            GRNlbl.TabIndex = 6;
            GRNlbl.Text = "Good Received Note";
            // 
            // deliverypnl
            // 
            deliverypnl.Controls.Add(deliverylbl);
            deliverypnl.Location = new Point(176, 2);
            deliverypnl.Name = "deliverypnl";
            deliverypnl.Size = new Size(1094, 656);
            deliverypnl.TabIndex = 9;
            deliverypnl.Visible = false;
            // 
            // deliverylbl
            // 
            deliverylbl.AutoSize = true;
            deliverylbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliverylbl.Location = new Point(16, 18);
            deliverylbl.Name = "deliverylbl";
            deliverylbl.Size = new Size(85, 25);
            deliverylbl.TabIndex = 6;
            deliverylbl.Text = "Delivery";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1312, 656);
            Controls.Add(GRNpnl);
            Controls.Add(closebtn);
            Controls.Add(listpnl);
            Controls.Add(inventorypnl);
            Controls.Add(logpnl);
            Controls.Add(deliverypnl);
            Controls.Add(contactpnl);
            Controls.Add(outstandingOrderpnl);
            Controls.Add(dashboardpnl);
            Controls.Add(orderpnl);
            Controls.Add(settingpnl);
            Controls.Add(userspnl);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Padding = new Padding(0, 0, 9, 0);
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
            outstandingOrderpnl.ResumeLayout(false);
            outstandingOrderpnl.PerformLayout();
            GRNpnl.ResumeLayout(false);
            GRNpnl.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grndata).EndInit();
            deliverypnl.ResumeLayout(false);
            deliverypnl.PerformLayout();
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
        private System.Windows.Forms.DataGridView contactsdata;
        private System.Windows.Forms.Button saleReportbtn;
        private System.Windows.Forms.Button editOrdersbtn;
        private System.Windows.Forms.DataGridView userData;
        private System.Windows.Forms.Button viewAccountbtn;
        private System.Windows.Forms.Button editAccountbtn;
        private System.Windows.Forms.DataGridView stockData;
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
        private System.Windows.Forms.DataGridView logData;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private TextBox accountSearchBox;
        private Button accountSearchBtn;
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
        private DataGridView orderdata;
        private Button outstandingOrderbtn;
        private Panel outstandingOrderpnl;
        private Label outstandingOrderlbl;
        private Button GRNbtn;
        private Panel GRNpnl;
        private Label GRNlbl;
        private Button deliverybtn;
        private Panel deliverypnl;
        private Label deliverylbl;
        private DataGridView grndata;
        private Label grnlbl2;
        private Label grnlbl1;
        private DateTimePicker grnDatePicker2;
        private DateTimePicker grnDatePicker1;
        private Button grnSearchBtn;
        private Panel panel1;
        private Button grnAddNoteBtn;
        private Button grnclearBtn;
    }
}