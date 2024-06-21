﻿using Org.BouncyCastle.Asn1.Crmf;
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
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            listpnl = new Panel();
            invoicebtn = new Button();
            log_logo = new ImageList(components);
            outstandingOrderbtn = new Button();
            PObtn = new Button();
            deliverybtn = new Button();
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
            panel11 = new Panel();
            roundedButton1 = new ProgramMethod.ProgramMethod.RoundedButton();
            label15 = new Label();
            roundedButton2 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton3 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton4 = new ProgramMethod.ProgramMethod.RoundedButton();
            panel10 = new Panel();
            orderStatusCombox = new ComboBox();
            label18 = new Label();
            label13 = new Label();
            orderdateTimePicker1 = new DateTimePicker();
            orderSearchbtn = new Button();
            orderdateTimePicker2 = new DateTimePicker();
            label14 = new Label();
            button8 = new Button();
            orderSearchbox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            panel9 = new Panel();
            orderoverallBtn = new Label();
            button6 = new Button();
            orderoverallBtn1 = new Button();
            label11 = new Label();
            label8 = new Label();
            button5 = new Button();
            button3 = new Button();
            label10 = new Label();
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
            contactGroupBox = new GroupBox();
            supplersbtn = new Button();
            dealersbtn = new Button();
            delContactbtn = new Button();
            searchContactbtn = new TextBox();
            contactsdata = new CustomDataGridView();
            newDealerbtn = new Button();
            editDealerbtn = new Button();
            searchSupplierbtn = new Button();
            searchDealerbtn = new Button();
            editSupplierbtn = new Button();
            newSupplierbtn = new Button();
            label2 = new Label();
            settingpnl = new Panel();
            settinglbl = new Label();
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
            panel8 = new Panel();
            stockFirstPagebtn = new ProgramMethod.ProgramMethod.RoundedButton();
            pageNumlbl = new Label();
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
            customDataGridView3 = new CustomDataGridView();
            dataGridViewCheckBoxColumn3 = new DataGridViewCheckBoxColumn();
            button19 = new Button();
            loglbl = new Label();
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
            panel16 = new Panel();
            roundedButton17 = new ProgramMethod.ProgramMethod.RoundedButton();
            label24 = new Label();
            roundedButton18 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton19 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton20 = new ProgramMethod.ProgramMethod.RoundedButton();
            panel17 = new Panel();
            button13 = new Button();
            roundedTextBox2 = new ProgramMethod.ProgramMethod.RoundedTextBox();
            button14 = new Button();
            dateTimePicker3 = new DateTimePicker();
            label25 = new Label();
            button15 = new Button();
            label26 = new Label();
            button16 = new Button();
            dateTimePicker4 = new DateTimePicker();
            customDataGridView2 = new CustomDataGridView();
            dataGridViewCheckBoxColumn2 = new DataGridViewCheckBoxColumn();
            button17 = new Button();
            POlbl = new Label();
            outstandingOrderpnl = new Panel();
            outstandingOrderlbl = new Label();
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
            customDataGridView1 = new CustomDataGridView();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            button12 = new Button();
            invoicelbl = new Label();
            panel20 = new Panel();
            roundedButton25 = new ProgramMethod.ProgramMethod.RoundedButton();
            label30 = new Label();
            roundedButton26 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton27 = new ProgramMethod.ProgramMethod.RoundedButton();
            roundedButton28 = new ProgramMethod.ProgramMethod.RoundedButton();
            panel21 = new Panel();
            button20 = new Button();
            roundedTextBox4 = new ProgramMethod.ProgramMethod.RoundedTextBox();
            button21 = new Button();
            dateTimePicker7 = new DateTimePicker();
            label31 = new Label();
            button22 = new Button();
            label32 = new Label();
            button23 = new Button();
            dateTimePicker8 = new DateTimePicker();
            customDataGridView4 = new CustomDataGridView();
            dataGridViewCheckBoxColumn4 = new DataGridViewCheckBoxColumn();
            button24 = new Button();
            listpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatarbox).BeginInit();
            orderpnl.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)customDataGridView3).BeginInit();
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
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customDataGridView2).BeginInit();
            outstandingOrderpnl.SuspendLayout();
            invoicepnl.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customDataGridView1).BeginInit();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customDataGridView4).BeginInit();
            SuspendLayout();
            // 
            // listpnl
            // 
            listpnl.BackColor = SystemColors.MenuText;
            listpnl.BackgroundImageLayout = ImageLayout.Stretch;
            listpnl.Controls.Add(invoicebtn);
            listpnl.Controls.Add(outstandingOrderbtn);
            listpnl.Controls.Add(PObtn);
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
            listpnl.Name = "listpnl";
            listpnl.Size = new Size(175, 750);
            listpnl.TabIndex = 14;
            listpnl.Paint += listpnl_Paint;
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
            invoicebtn.Location = new Point(22, 550);
            invoicebtn.Name = "invoicebtn";
            invoicebtn.Size = new Size(145, 42);
            invoicebtn.TabIndex = 14;
            invoicebtn.Text = "Invoice";
            invoicebtn.UseVisualStyleBackColor = true;
            invoicebtn.Click += invoicebtn_Click;
            // 
            // log_logo
            // 
            log_logo.ColorDepth = ColorDepth.Depth24Bit;
            log_logo.ImageStream = (ImageListStreamer)resources.GetObject("log_logo.ImageStream");
            log_logo.TransparentColor = Color.Transparent;
            log_logo.Images.SetKeyName(0, "log_logo.png");
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
            outstandingOrderbtn.Location = new Point(22, 502);
            outstandingOrderbtn.Name = "outstandingOrderbtn";
            outstandingOrderbtn.Size = new Size(165, 56);
            outstandingOrderbtn.TabIndex = 13;
            outstandingOrderbtn.Text = "         Outstanding\r\n         Order";
            outstandingOrderbtn.TextAlign = ContentAlignment.MiddleLeft;
            outstandingOrderbtn.UseVisualStyleBackColor = true;
            outstandingOrderbtn.Click += outstandingOrderbtn_Click_1;
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
            PObtn.Location = new Point(22, 454);
            PObtn.Name = "PObtn";
            PObtn.Size = new Size(145, 42);
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
            deliverybtn.Location = new Point(22, 406);
            deliverybtn.Name = "deliverybtn";
            deliverybtn.Size = new Size(145, 42);
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
            GRNbtn.Location = new Point(22, 358);
            GRNbtn.Name = "GRNbtn";
            GRNbtn.Size = new Size(145, 42);
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
            OrderAccemblybtn.Location = new Point(22, 262);
            OrderAccemblybtn.Name = "OrderAccemblybtn";
            OrderAccemblybtn.Size = new Size(148, 56);
            OrderAccemblybtn.TabIndex = 9;
            OrderAccemblybtn.Text = "         Order\r\n         Accembly ";
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
            Logbtn.Location = new Point(22, 642);
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
            contactsbtn.Location = new Point(22, 310);
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
            settingbtn.Location = new Point(22, 686);
            settingbtn.Name = "settingbtn";
            settingbtn.Size = new Size(145, 38);
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
            usersbtn.Location = new Point(22, 598);
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
            stockbtn.Location = new Point(22, 214);
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
            orderbtn.Location = new Point(22, 165);
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
            avatarbox.Location = new Point(3, 37);
            avatarbox.Name = "avatarbox";
            avatarbox.Size = new Size(172, 62);
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
            orderpnl.Controls.Add(panel11);
            orderpnl.Controls.Add(panel10);
            orderpnl.Controls.Add(button8);
            orderpnl.Controls.Add(orderSearchbox);
            orderpnl.Controls.Add(panel9);
            orderpnl.Controls.Add(viewOrderbtn);
            orderpnl.Controls.Add(newOrderbtn);
            orderpnl.Controls.Add(ordlerlbl);
            orderpnl.Controls.Add(saleReportbtn);
            orderpnl.Controls.Add(editOrdersbtn);
            orderpnl.Controls.Add(orderdata);
            orderpnl.Location = new Point(176, 2);
            orderpnl.Name = "orderpnl";
            orderpnl.Size = new Size(1094, 750);
            orderpnl.TabIndex = 16;
            orderpnl.Visible = false;
            // 
            // panel11
            // 
            panel11.Controls.Add(roundedButton1);
            panel11.Controls.Add(label15);
            panel11.Controls.Add(roundedButton2);
            panel11.Controls.Add(roundedButton3);
            panel11.Controls.Add(roundedButton4);
            panel11.Location = new Point(570, 685);
            panel11.Name = "panel11";
            panel11.Size = new Size(495, 50);
            panel11.TabIndex = 47;
            // 
            // roundedButton1
            // 
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
            roundedButton1.Location = new Point(61, 7);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(69, 33);
            roundedButton1.TabIndex = 31;
            roundedButton1.Text = "First";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(220, 16);
            label15.Name = "label15";
            label15.Size = new Size(79, 20);
            label15.TabIndex = 3;
            label15.Text = "LabelData";
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
            roundedButton2.Location = new Point(146, 7);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(63, 33);
            roundedButton2.TabIndex = 33;
            roundedButton2.Text = "Prev";
            // 
            // roundedButton3
            // 
            roundedButton3.BackColor = SystemColors.Menu;
            roundedButton3.BackColor2 = Color.White;
            roundedButton3.BorderColor = Color.White;
            roundedButton3.BorderSize = 2;
            roundedButton3.ButtonBorderColor = Color.Gray;
            roundedButton3.ButtonHighlightColor = Color.Empty;
            roundedButton3.ButtonHighlightColor2 = Color.Empty;
            roundedButton3.ButtonHighlightForeColor = Color.Black;
            roundedButton3.ButtonPressedColor = Color.White;
            roundedButton3.ButtonPressedColor2 = Color.Empty;
            roundedButton3.ButtonPressedForeColor = Color.Gray;
            roundedButton3.ButtonRoundRadius = 15;
            roundedButton3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton3.ForeColor = Color.Black;
            roundedButton3.Location = new Point(397, 7);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(66, 33);
            roundedButton3.TabIndex = 34;
            roundedButton3.Text = "Last";
            // 
            // roundedButton4
            // 
            roundedButton4.BackColor = SystemColors.HighlightText;
            roundedButton4.BackColor2 = Color.White;
            roundedButton4.BorderColor = Color.Tomato;
            roundedButton4.BorderSize = 2;
            roundedButton4.ButtonBorderColor = Color.Gray;
            roundedButton4.ButtonHighlightColor = Color.Empty;
            roundedButton4.ButtonHighlightColor2 = Color.Empty;
            roundedButton4.ButtonHighlightForeColor = Color.Black;
            roundedButton4.ButtonPressedColor = Color.White;
            roundedButton4.ButtonPressedColor2 = Color.Empty;
            roundedButton4.ButtonPressedForeColor = Color.Gray;
            roundedButton4.ButtonRoundRadius = 15;
            roundedButton4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton4.ForeColor = Color.Black;
            roundedButton4.Location = new Point(310, 7);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Size = new Size(77, 33);
            roundedButton4.TabIndex = 32;
            roundedButton4.Text = "Next";
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
            orderStatusCombox.Click += orderSearchbtn_Click;
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
            orderdateTimePicker1.Location = new Point(11, 49);
            orderdateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            orderdateTimePicker1.Name = "orderdateTimePicker1";
            orderdateTimePicker1.Size = new Size(219, 23);
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
            orderSearchbtn.Location = new Point(728, 33);
            orderSearchbtn.Name = "orderSearchbtn";
            orderSearchbtn.Size = new Size(116, 37);
            orderSearchbtn.TabIndex = 39;
            orderSearchbtn.Text = "Search";
            orderSearchbtn.UseVisualStyleBackColor = false;
            // 
            // orderdateTimePicker2
            // 
            orderdateTimePicker2.Location = new Point(286, 49);
            orderdateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            orderdateTimePicker2.Name = "orderdateTimePicker2";
            orderdateTimePicker2.Size = new Size(219, 23);
            orderdateTimePicker2.TabIndex = 41;
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
            // button8
            // 
            button8.AutoSize = true;
            button8.BackColor = Color.Red;
            button8.FlatAppearance.BorderColor = Color.Gray;
            button8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Transparent;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.ImageIndex = 0;
            button8.Location = new Point(380, 218);
            button8.Name = "button8";
            button8.Size = new Size(148, 36);
            button8.TabIndex = 45;
            button8.Text = "Cancel Order";
            button8.UseVisualStyleBackColor = false;
            // 
            // orderSearchbox
            // 
            orderSearchbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderSearchbox.Location = new Point(620, 224);
            orderSearchbox.Margin = new Padding(3, 4, 3, 4);
            orderSearchbox.Multiline = true;
            orderSearchbox.Name = "orderSearchbox";
            orderSearchbox.PlaceholderText = "Search Order";
            orderSearchbox.Size = new Size(443, 32);
            orderSearchbox.TabIndex = 44;
            orderSearchbox.TextChanged += orderSearchbox_TextChanged;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(orderoverallBtn);
            panel9.Controls.Add(button6);
            panel9.Controls.Add(orderoverallBtn1);
            panel9.Controls.Add(label11);
            panel9.Controls.Add(label8);
            panel9.Controls.Add(button5);
            panel9.Controls.Add(button3);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(31, 156);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(1038, 52);
            panel9.TabIndex = 39;
            // 
            // orderoverallBtn
            // 
            orderoverallBtn.AutoSize = true;
            orderoverallBtn.BackColor = SystemColors.Menu;
            orderoverallBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderoverallBtn.Location = new Point(3, 18);
            orderoverallBtn.Name = "orderoverallBtn";
            orderoverallBtn.Size = new Size(85, 21);
            orderoverallBtn.TabIndex = 32;
            orderoverallBtn.Text = "All Orders";
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.BackColor = SystemColors.HighlightText;
            button6.CausesValidation = false;
            button6.FlatAppearance.BorderColor = Color.Gray;
            button6.FlatStyle = FlatStyle.System;
            button6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.ImageIndex = 0;
            button6.Location = new Point(755, 15);
            button6.Name = "button6";
            button6.Size = new Size(60, 32);
            button6.TabIndex = 38;
            button6.Text = "8800";
            button6.UseVisualStyleBackColor = false;
            // 
            // orderoverallBtn1
            // 
            orderoverallBtn1.AutoSize = true;
            orderoverallBtn1.BackColor = SystemColors.HighlightText;
            orderoverallBtn1.CausesValidation = false;
            orderoverallBtn1.FlatAppearance.BorderColor = Color.Gray;
            orderoverallBtn1.FlatStyle = FlatStyle.System;
            orderoverallBtn1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderoverallBtn1.ForeColor = Color.Black;
            orderoverallBtn1.ImageAlign = ContentAlignment.MiddleLeft;
            orderoverallBtn1.ImageIndex = 0;
            orderoverallBtn1.Location = new Point(89, 18);
            orderoverallBtn1.Name = "orderoverallBtn1";
            orderoverallBtn1.Size = new Size(60, 32);
            orderoverallBtn1.TabIndex = 28;
            orderoverallBtn1.Text = "8800";
            orderoverallBtn1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Menu;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(599, 16);
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
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = SystemColors.HighlightText;
            button5.CausesValidation = false;
            button5.FlatAppearance.BorderColor = Color.Gray;
            button5.FlatStyle = FlatStyle.System;
            button5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.ImageIndex = 0;
            button5.Location = new Point(518, 16);
            button5.Name = "button5";
            button5.Size = new Size(60, 32);
            button5.TabIndex = 36;
            button5.Text = "8800";
            button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = SystemColors.HighlightText;
            button3.CausesValidation = false;
            button3.FlatAppearance.BorderColor = Color.Gray;
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 0;
            button3.Location = new Point(292, 16);
            button3.Name = "button3";
            button3.Size = new Size(60, 32);
            button3.TabIndex = 34;
            button3.Text = "8800";
            button3.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Menu;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(378, 16);
            label10.Name = "label10";
            label10.Size = new Size(128, 21);
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
            viewOrderbtn.Location = new Point(204, 218);
            viewOrderbtn.Name = "viewOrderbtn";
            viewOrderbtn.Size = new Size(151, 37);
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
            newOrderbtn.ForeColor = Color.Black;
            newOrderbtn.ImageAlign = ContentAlignment.MiddleLeft;
            newOrderbtn.ImageIndex = 0;
            newOrderbtn.Location = new Point(899, 24);
            newOrderbtn.Name = "newOrderbtn";
            newOrderbtn.Size = new Size(162, 42);
            newOrderbtn.TabIndex = 24;
            newOrderbtn.Text = "+ New Orders";
            newOrderbtn.UseVisualStyleBackColor = false;
            newOrderbtn.Click += newOrderbtn_Click;
            // 
            // ordlerlbl
            // 
            ordlerlbl.AutoSize = true;
            ordlerlbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ordlerlbl.Location = new Point(16, 18);
            ordlerlbl.Name = "ordlerlbl";
            ordlerlbl.Size = new Size(276, 30);
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
            saleReportbtn.Location = new Point(24, 698);
            saleReportbtn.Name = "saleReportbtn";
            saleReportbtn.Size = new Size(130, 37);
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
            editOrdersbtn.Location = new Point(30, 218);
            editOrdersbtn.Name = "editOrdersbtn";
            editOrdersbtn.Size = new Size(163, 38);
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
            orderdata.Location = new Point(18, 264);
            orderdata.MultiSelect = false;
            orderdata.Name = "orderdata";
            orderdata.RowHeadersVisible = false;
            orderdata.RowHeadersWidth = 51;
            orderdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderdata.Size = new Size(1067, 413);
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
            stockSummarypnl.Location = new Point(38, 51);
            stockSummarypnl.Name = "stockSummarypnl";
            stockSummarypnl.Size = new Size(1050, 162);
            stockSummarypnl.TabIndex = 26;
            // 
            // stockDatapanel3
            // 
            stockDatapanel3.Controls.Add(stocklbl3);
            stockDatapanel3.Controls.Add(stockProductDatalbl3);
            stockDatapanel3.Location = new Point(746, 16);
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
            stockDatapanel1.Location = new Point(42, 16);
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
            stockDatapanel2.Location = new Point(387, 16);
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
            editProductbtn.Location = new Point(37, 221);
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
            newProductbtn.Location = new Point(934, 14);
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
            stockData.Location = new Point(18, 276);
            stockData.Margin = new Padding(3, 4, 3, 4);
            stockData.Name = "stockData";
            stockData.RowHeadersVisible = false;
            stockData.RowHeadersWidth = 51;
            stockData.RowTemplate.Height = 24;
            stockData.ScrollBars = ScrollBars.None;
            stockData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stockData.Size = new Size(1050, 392);
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
            viewProductbtn.Location = new Point(219, 221);
            viewProductbtn.Name = "viewProductbtn";
            viewProductbtn.Size = new Size(162, 42);
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
            accountSearchBtn.Location = new Point(673, 290);
            accountSearchBtn.Name = "accountSearchBtn";
            accountSearchBtn.Size = new Size(155, 33);
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
            contactpnl.Controls.Add(newDealerbtn);
            contactpnl.Controls.Add(editDealerbtn);
            contactpnl.Controls.Add(searchSupplierbtn);
            contactpnl.Controls.Add(searchDealerbtn);
            contactpnl.Controls.Add(editSupplierbtn);
            contactpnl.Controls.Add(newSupplierbtn);
            contactpnl.Location = new Point(176, 2);
            contactpnl.Margin = new Padding(3, 4, 3, 4);
            contactpnl.Name = "contactpnl";
            contactpnl.Size = new Size(1094, 750);
            contactpnl.TabIndex = 1;
            contactpnl.Visible = false;
            contactpnl.Paint += contactpnl_Paint;
            // 
            // contactGroupBox
            // 
            contactGroupBox.Controls.Add(supplersbtn);
            contactGroupBox.Controls.Add(dealersbtn);
            contactGroupBox.Location = new Point(32, 9);
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
            supplersbtn.AutoSize = true;
            supplersbtn.BackColor = SystemColors.HighlightText;
            supplersbtn.FlatAppearance.BorderColor = Color.Gray;
            supplersbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplersbtn.ForeColor = Color.Black;
            supplersbtn.ImageAlign = ContentAlignment.MiddleLeft;
            supplersbtn.ImageIndex = 0;
            supplersbtn.Location = new Point(189, 18);
            supplersbtn.Name = "supplersbtn";
            supplersbtn.Size = new Size(196, 39);
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
            dealersbtn.Location = new Point(7, 18);
            dealersbtn.Name = "dealersbtn";
            dealersbtn.Size = new Size(180, 39);
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
            delContactbtn.Location = new Point(326, 85);
            delContactbtn.Margin = new Padding(4);
            delContactbtn.Name = "delContactbtn";
            delContactbtn.Size = new Size(80, 35);
            delContactbtn.TabIndex = 34;
            delContactbtn.Text = "Delete";
            delContactbtn.UseVisualStyleBackColor = false;
            delContactbtn.Click += delContactbtn_Click;
            // 
            // searchContactbtn
            // 
            searchContactbtn.Location = new Point(705, 94);
            searchContactbtn.Name = "searchContactbtn";
            searchContactbtn.PlaceholderText = "Search Name";
            searchContactbtn.Size = new Size(197, 23);
            searchContactbtn.TabIndex = 32;
            // 
            // contactsdata
            // 
            contactsdata.AllowUserToAddRows = false;
            contactsdata.AllowUserToDeleteRows = false;
            contactsdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            contactsdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            contactsdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contactsdata.Columns.AddRange(new DataGridViewColumn[] { contactcheckColumn });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            contactsdata.DefaultCellStyle = dataGridViewCellStyle8;
            contactsdata.Location = new Point(38, 136);
            contactsdata.Margin = new Padding(3, 4, 3, 4);
            contactsdata.Name = "contactsdata";
            contactsdata.RowHeadersVisible = false;
            contactsdata.RowHeadersWidth = 51;
            contactsdata.RowTemplate.Height = 24;
            contactsdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            contactsdata.Size = new Size(1050, 562);
            contactsdata.TabIndex = 19;
            contactsdata.CellClick += contactsdata_CellClick;
            contactsdata.CellContentClick += contactsdata_CellContentClick;
            // 
            // newDealerbtn
            // 
            newDealerbtn.AccessibleRole = AccessibleRole.None;
            newDealerbtn.BackColor = SystemColors.Menu;
            newDealerbtn.FlatStyle = FlatStyle.System;
            newDealerbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newDealerbtn.ForeColor = Color.Black;
            newDealerbtn.Location = new Point(38, 85);
            newDealerbtn.Margin = new Padding(4);
            newDealerbtn.Name = "newDealerbtn";
            newDealerbtn.Size = new Size(135, 35);
            newDealerbtn.TabIndex = 31;
            newDealerbtn.Text = "New Dealer";
            newDealerbtn.UseVisualStyleBackColor = false;
            newDealerbtn.Click += newDealerbtn_Click;
            // 
            // editDealerbtn
            // 
            editDealerbtn.AccessibleRole = AccessibleRole.None;
            editDealerbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editDealerbtn.Location = new Point(182, 85);
            editDealerbtn.Margin = new Padding(4);
            editDealerbtn.Name = "editDealerbtn";
            editDealerbtn.Size = new Size(135, 35);
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
            searchSupplierbtn.Location = new Point(920, 88);
            searchSupplierbtn.Name = "searchSupplierbtn";
            searchSupplierbtn.Size = new Size(155, 32);
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
            searchDealerbtn.Location = new Point(920, 88);
            searchDealerbtn.Name = "searchDealerbtn";
            searchDealerbtn.Size = new Size(155, 32);
            searchDealerbtn.TabIndex = 33;
            searchDealerbtn.Text = "Search";
            searchDealerbtn.UseVisualStyleBackColor = false;
            searchDealerbtn.Click += searchDealerbtn_Click;
            // 
            // editSupplierbtn
            // 
            editSupplierbtn.AccessibleRole = AccessibleRole.None;
            editSupplierbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSupplierbtn.Location = new Point(182, 85);
            editSupplierbtn.Margin = new Padding(5);
            editSupplierbtn.Name = "editSupplierbtn";
            editSupplierbtn.Size = new Size(135, 35);
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
            newSupplierbtn.Location = new Point(38, 85);
            newSupplierbtn.Margin = new Padding(4);
            newSupplierbtn.Name = "newSupplierbtn";
            newSupplierbtn.Size = new Size(135, 35);
            newSupplierbtn.TabIndex = 37;
            newSupplierbtn.Text = "New Supplier";
            newSupplierbtn.UseVisualStyleBackColor = false;
            newSupplierbtn.Click += newSupplierbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 12);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 10;
            label2.Text = "From";
            // 
            // settingpnl
            // 
            settingpnl.Controls.Add(settinglbl);
            settingpnl.Location = new Point(176, 2);
            settingpnl.Name = "settingpnl";
            settingpnl.Size = new Size(1094, 750);
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
            userspnl.Location = new Point(176, 2);
            userspnl.Name = "userspnl";
            userspnl.Size = new Size(1094, 750);
            userspnl.TabIndex = 3;
            userspnl.Visible = false;
            // 
            // accountSearchBox
            // 
            accountSearchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountSearchBox.Location = new Point(31, 292);
            accountSearchBox.Margin = new Padding(3, 4, 3, 4);
            accountSearchBox.Multiline = true;
            accountSearchBox.Name = "accountSearchBox";
            accountSearchBox.PlaceholderText = "   Search Username";
            accountSearchBox.Size = new Size(629, 32);
            accountSearchBox.TabIndex = 41;
            // 
            // panel7
            // 
            panel7.Controls.Add(accountbtnFirstPage);
            panel7.Controls.Add(accountIndexlbl);
            panel7.Controls.Add(accountbtnPrevPage);
            panel7.Controls.Add(accountbtnLastPage);
            panel7.Controls.Add(accountbtnNxtPage);
            panel7.Location = new Point(578, 672);
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
            accountbtnFirstPage.ButtonRoundRadius = 15;
            accountbtnFirstPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountbtnFirstPage.ForeColor = Color.Black;
            accountbtnFirstPage.Location = new Point(18, 11);
            accountbtnFirstPage.Margin = new Padding(3, 4, 3, 4);
            accountbtnFirstPage.Name = "accountbtnFirstPage";
            accountbtnFirstPage.Size = new Size(69, 33);
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
            accountbtnPrevPage.ButtonRoundRadius = 15;
            accountbtnPrevPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountbtnPrevPage.ForeColor = Color.Black;
            accountbtnPrevPage.Location = new Point(108, 11);
            accountbtnPrevPage.Margin = new Padding(3, 4, 3, 4);
            accountbtnPrevPage.Name = "accountbtnPrevPage";
            accountbtnPrevPage.Size = new Size(69, 33);
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
            accountbtnLastPage.Location = new Point(408, 11);
            accountbtnLastPage.Margin = new Padding(3, 4, 3, 4);
            accountbtnLastPage.Name = "accountbtnLastPage";
            accountbtnLastPage.Size = new Size(69, 33);
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
            accountbtnNxtPage.Location = new Point(317, 11);
            accountbtnNxtPage.Margin = new Padding(3, 4, 3, 4);
            accountbtnNxtPage.Name = "accountbtnNxtPage";
            accountbtnNxtPage.Size = new Size(69, 33);
            accountbtnNxtPage.TabIndex = 32;
            accountbtnNxtPage.Text = "Next";
            accountbtnNxtPage.Click += accountbtnNxtPage_Click;
            // 
            // accountPaginationpnl
            // 
            accountPaginationpnl.Location = new Point(31, 678);
            accountPaginationpnl.Name = "accountPaginationpnl";
            accountPaginationpnl.Size = new Size(526, 46);
            accountPaginationpnl.TabIndex = 29;
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
            // accountPageSizeComboBox
            // 
            accountPageSizeComboBox.FormattingEnabled = true;
            accountPageSizeComboBox.Items.AddRange(new object[] { "10", "15", "25" });
            accountPageSizeComboBox.Location = new Point(1009, 297);
            accountPageSizeComboBox.Name = "accountPageSizeComboBox";
            accountPageSizeComboBox.Size = new Size(41, 23);
            accountPageSizeComboBox.TabIndex = 36;
            // 
            // accountPaginglbl
            // 
            accountPaginglbl.AutoSize = true;
            accountPaginglbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountPaginglbl.Location = new Point(885, 295);
            accountPaginglbl.Name = "accountPaginglbl";
            accountPaginglbl.Size = new Size(116, 21);
            accountPaginglbl.TabIndex = 35;
            accountPaginglbl.Text = "Rows per page:";
            // 
            // enableAccountbtn
            // 
            enableAccountbtn.AccessibleRole = AccessibleRole.None;
            enableAccountbtn.BackColor = Color.LimeGreen;
            enableAccountbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enableAccountbtn.ForeColor = Color.White;
            enableAccountbtn.Location = new Point(337, 237);
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
            disableAccountbtn.Location = new Point(431, 237);
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
            newAccountbtn.BackColor = Color.LimeGreen;
            newAccountbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newAccountbtn.ForeColor = Color.White;
            newAccountbtn.Location = new Point(903, 8);
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
            viewAccountbtn.Location = new Point(182, 237);
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
            editAccountbtn.Location = new Point(31, 237);
            editAccountbtn.Margin = new Padding(4);
            editAccountbtn.Name = "editAccountbtn";
            editAccountbtn.Size = new Size(139, 35);
            editAccountbtn.TabIndex = 22;
            editAccountbtn.Text = "Edit Account";
            editAccountbtn.UseVisualStyleBackColor = true;
            editAccountbtn.Click += editAccountbtn_Click;
            // 
            // userData
            // 
            userData.AllowUserToAddRows = false;
            userData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = Color.Gainsboro;
            dataGridViewCellStyle9.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            userData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            userData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            userData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            userData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userData.Columns.AddRange(new DataGridViewColumn[] { usercheckColumn });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            userData.DefaultCellStyle = dataGridViewCellStyle11;
            userData.GridColor = SystemColors.WindowText;
            userData.Location = new Point(24, 332);
            userData.Margin = new Padding(3, 4, 3, 4);
            userData.Name = "userData";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            userData.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            userslbl.Location = new Point(16, 18);
            userslbl.Name = "userslbl";
            userslbl.Size = new Size(183, 25);
            userslbl.TabIndex = 0;
            userslbl.Text = "Users Management";
            // 
            // inventorypnl
            // 
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
            inventorypnl.Size = new Size(1091, 750);
            inventorypnl.TabIndex = 16;
            inventorypnl.Visible = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(stockFirstPagebtn);
            panel8.Controls.Add(pageNumlbl);
            panel8.Controls.Add(sotckPrevPagebtn);
            panel8.Controls.Add(sotckLastPagebtn);
            panel8.Controls.Add(sotckNextPagebtn);
            panel8.Location = new Point(555, 675);
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
            stockFirstPagebtn.ButtonRoundRadius = 15;
            stockFirstPagebtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockFirstPagebtn.ForeColor = Color.Black;
            stockFirstPagebtn.Location = new Point(61, 7);
            stockFirstPagebtn.Name = "stockFirstPagebtn";
            stockFirstPagebtn.Size = new Size(69, 33);
            stockFirstPagebtn.TabIndex = 31;
            stockFirstPagebtn.Text = "First";
            stockFirstPagebtn.Click += stockFirstPagebtn_Click;
            // 
            // pageNumlbl
            // 
            pageNumlbl.AutoSize = true;
            pageNumlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageNumlbl.Location = new Point(217, 16);
            pageNumlbl.Name = "pageNumlbl";
            pageNumlbl.Size = new Size(79, 20);
            pageNumlbl.TabIndex = 3;
            pageNumlbl.Text = "LabelData";
            pageNumlbl.Click += pageNumlbl_Click;
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
            sotckPrevPagebtn.Location = new Point(146, 7);
            sotckPrevPagebtn.Name = "sotckPrevPagebtn";
            sotckPrevPagebtn.Size = new Size(63, 33);
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
            sotckLastPagebtn.Location = new Point(397, 7);
            sotckLastPagebtn.Name = "sotckLastPagebtn";
            sotckLastPagebtn.Size = new Size(66, 33);
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
            sotckNextPagebtn.Location = new Point(310, 7);
            sotckNextPagebtn.Name = "sotckNextPagebtn";
            sotckNextPagebtn.Size = new Size(77, 33);
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
            delProductbtn.Location = new Point(398, 221);
            delProductbtn.Name = "delProductbtn";
            delProductbtn.Size = new Size(162, 42);
            delProductbtn.TabIndex = 31;
            delProductbtn.Text = "Delete Product";
            delProductbtn.UseVisualStyleBackColor = false;
            delProductbtn.Click += delProductbtn_Click;
            // 
            // stockSearchBox
            // 
            stockSearchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockSearchBox.Location = new Point(629, 226);
            stockSearchBox.Margin = new Padding(3, 4, 3, 4);
            stockSearchBox.Multiline = true;
            stockSearchBox.Name = "stockSearchBox";
            stockSearchBox.PlaceholderText = "Search Product Name or ID";
            stockSearchBox.Size = new Size(446, 32);
            stockSearchBox.TabIndex = 30;
            stockSearchBox.TextChanged += stockSearchBox_TextChanged;
            // 
            // dashboardpnl
            // 
            dashboardpnl.BackgroundImage = Properties.Resources.dashboard_background;
            dashboardpnl.BackgroundImageLayout = ImageLayout.Stretch;
            dashboardpnl.Controls.Add(label1);
            dashboardpnl.Location = new Point(176, 2);
            dashboardpnl.Name = "dashboardpnl";
            dashboardpnl.Size = new Size(1138, 750);
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
            logpnl.Controls.Add(panel18);
            logpnl.Controls.Add(panel19);
            logpnl.Controls.Add(customDataGridView3);
            logpnl.Controls.Add(button19);
            logpnl.Controls.Add(loglbl);
            logpnl.Location = new Point(176, 2);
            logpnl.Name = "logpnl";
            logpnl.Size = new Size(1094, 750);
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
            panel18.Location = new Point(570, 681);
            panel18.Name = "panel18";
            panel18.Size = new Size(495, 50);
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
            roundedButton21.Location = new Point(61, 7);
            roundedButton21.Name = "roundedButton21";
            roundedButton21.Size = new Size(69, 33);
            roundedButton21.TabIndex = 31;
            roundedButton21.Text = "First";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(220, 16);
            label27.Name = "label27";
            label27.Size = new Size(79, 20);
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
            roundedButton22.Location = new Point(146, 7);
            roundedButton22.Name = "roundedButton22";
            roundedButton22.Size = new Size(63, 33);
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
            roundedButton23.Location = new Point(397, 7);
            roundedButton23.Name = "roundedButton23";
            roundedButton23.Size = new Size(66, 33);
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
            roundedButton24.Location = new Point(310, 7);
            roundedButton24.Name = "roundedButton24";
            roundedButton24.Size = new Size(77, 33);
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
            panel19.Location = new Point(32, 66);
            panel19.Margin = new Padding(3, 2, 3, 2);
            panel19.Name = "panel19";
            panel19.Size = new Size(1026, 147);
            panel19.TabIndex = 37;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(378, 102);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 32;
            button1.Text = "Complete";
            button1.UseVisualStyleBackColor = true;
            // 
            // roundedTextBox3
            // 
            roundedTextBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox3.Location = new Point(575, 104);
            roundedTextBox3.Margin = new Padding(3, 4, 3, 4);
            roundedTextBox3.Multiline = true;
            roundedTextBox3.Name = "roundedTextBox3";
            roundedTextBox3.PlaceholderText = "Search";
            roundedTextBox3.Size = new Size(446, 32);
            roundedTextBox3.TabIndex = 31;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(244, 102);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(102, 34);
            button2.TabIndex = 17;
            button2.Text = "View";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Location = new Point(21, 48);
            dateTimePicker5.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(212, 23);
            dateTimePicker5.TabIndex = 8;
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
            // button4
            // 
            button4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(16, 99);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(88, 35);
            button4.TabIndex = 25;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
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
            // button18
            // 
            button18.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.Location = new Point(123, 100);
            button18.Margin = new Padding(3, 2, 3, 2);
            button18.Name = "button18";
            button18.Size = new Size(88, 35);
            button18.TabIndex = 15;
            button18.Text = "Clear";
            button18.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Location = new Point(278, 48);
            dateTimePicker6.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(220, 23);
            dateTimePicker6.TabIndex = 9;
            // 
            // customDataGridView3
            // 
            customDataGridView3.AllowUserToAddRows = false;
            customDataGridView3.AllowUserToDeleteRows = false;
            customDataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            customDataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            customDataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customDataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn3 });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            customDataGridView3.DefaultCellStyle = dataGridViewCellStyle14;
            customDataGridView3.Location = new Point(27, 219);
            customDataGridView3.Margin = new Padding(3, 2, 3, 2);
            customDataGridView3.Name = "customDataGridView3";
            customDataGridView3.RowHeadersVisible = false;
            customDataGridView3.RowHeadersWidth = 51;
            customDataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customDataGridView3.Size = new Size(1040, 453);
            customDataGridView3.TabIndex = 35;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            dataGridViewCheckBoxColumn3.FillWeight = 35F;
            dataGridViewCheckBoxColumn3.HeaderText = "Select";
            dataGridViewCheckBoxColumn3.MinimumWidth = 35;
            dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // button19
            // 
            button19.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button19.Location = new Point(856, 19);
            button19.Margin = new Padding(3, 2, 3, 2);
            button19.Name = "button19";
            button19.Size = new Size(141, 42);
            button19.TabIndex = 36;
            button19.Text = "Add";
            button19.UseVisualStyleBackColor = true;
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
            // OrderAccemblypnl
            // 
            OrderAccemblypnl.Controls.Add(orderaccemblySearchpnl);
            OrderAccemblypnl.Controls.Add(orderAccemblyData);
            OrderAccemblypnl.Controls.Add(orderAccemblylbl);
            OrderAccemblypnl.Controls.Add(accemblyCreatebtn);
            OrderAccemblypnl.Location = new Point(176, 2);
            OrderAccemblypnl.Name = "OrderAccemblypnl";
            OrderAccemblypnl.Size = new Size(1094, 750);
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
            orderaccemblySearchpnl.Location = new Point(38, 49);
            orderaccemblySearchpnl.Name = "orderaccemblySearchpnl";
            orderaccemblySearchpnl.Size = new Size(1050, 145);
            orderaccemblySearchpnl.TabIndex = 16;
            // 
            // orderAccemblyViewbtn
            // 
            orderAccemblyViewbtn.Location = new Point(359, 98);
            orderAccemblyViewbtn.Margin = new Padding(3, 2, 3, 2);
            orderAccemblyViewbtn.Name = "orderAccemblyViewbtn";
            orderAccemblyViewbtn.Size = new Size(114, 32);
            orderAccemblyViewbtn.TabIndex = 20;
            orderAccemblyViewbtn.Text = "View";
            orderAccemblyViewbtn.UseVisualStyleBackColor = true;
            orderAccemblyViewbtn.Click += orderAccemblyViewbtn_Click;
            // 
            // orderAccemblySearchbtn
            // 
            orderAccemblySearchbtn.Location = new Point(34, 98);
            orderAccemblySearchbtn.Margin = new Padding(3, 2, 3, 2);
            orderAccemblySearchbtn.Name = "orderAccemblySearchbtn";
            orderAccemblySearchbtn.Size = new Size(114, 32);
            orderAccemblySearchbtn.TabIndex = 19;
            orderAccemblySearchbtn.Text = "Search";
            orderAccemblySearchbtn.UseVisualStyleBackColor = true;
            orderAccemblySearchbtn.Click += orderAccemblySearchbtn_Click;
            // 
            // orderAccemblyClearbtn
            // 
            orderAccemblyClearbtn.Location = new Point(184, 98);
            orderAccemblyClearbtn.Margin = new Padding(3, 2, 3, 2);
            orderAccemblyClearbtn.Name = "orderAccemblyClearbtn";
            orderAccemblyClearbtn.Size = new Size(121, 32);
            orderAccemblyClearbtn.TabIndex = 18;
            orderAccemblyClearbtn.Text = "Clear";
            orderAccemblyClearbtn.UseVisualStyleBackColor = true;
            // 
            // orderAccemblySearchbox
            // 
            orderAccemblySearchbox.Location = new Point(578, 112);
            orderAccemblySearchbox.Margin = new Padding(3, 2, 3, 2);
            orderAccemblySearchbox.Name = "orderAccemblySearchbox";
            orderAccemblySearchbox.Size = new Size(386, 23);
            orderAccemblySearchbox.TabIndex = 17;
            // 
            // orderAccemblydateTimePicker
            // 
            orderAccemblydateTimePicker.Location = new Point(34, 48);
            orderAccemblydateTimePicker.Name = "orderAccemblydateTimePicker";
            orderAccemblydateTimePicker.Size = new Size(233, 23);
            orderAccemblydateTimePicker.TabIndex = 8;
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
            orderAccemblyData.Location = new Point(38, 201);
            orderAccemblyData.Margin = new Padding(3, 2, 3, 2);
            orderAccemblyData.Name = "orderAccemblyData";
            orderAccemblyData.RowHeadersWidth = 51;
            orderAccemblyData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderAccemblyData.Size = new Size(1050, 495);
            orderAccemblyData.TabIndex = 7;
            orderAccemblyData.CellClick += orderAccemblyData_CellClick;
            // 
            // orderAccemblylbl
            // 
            orderAccemblylbl.AutoSize = true;
            orderAccemblylbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderAccemblylbl.Location = new Point(16, 18);
            orderAccemblylbl.Name = "orderAccemblylbl";
            orderAccemblylbl.Size = new Size(154, 25);
            orderAccemblylbl.TabIndex = 6;
            orderAccemblylbl.Text = "Order Accembly";
            // 
            // accemblyCreatebtn
            // 
            accemblyCreatebtn.Location = new Point(932, 3);
            accemblyCreatebtn.Margin = new Padding(3, 2, 3, 2);
            accemblyCreatebtn.Name = "accemblyCreatebtn";
            accemblyCreatebtn.Size = new Size(155, 38);
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
            GRNpnl.Location = new Point(176, 2);
            GRNpnl.Name = "GRNpnl";
            GRNpnl.Size = new Size(1094, 750);
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
            panel12.Location = new Point(579, 686);
            panel12.Name = "panel12";
            panel12.Size = new Size(495, 50);
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
            roundedButton5.Location = new Point(61, 7);
            roundedButton5.Name = "roundedButton5";
            roundedButton5.Size = new Size(69, 33);
            roundedButton5.TabIndex = 31;
            roundedButton5.Text = "First";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(220, 16);
            label16.Name = "label16";
            label16.Size = new Size(79, 20);
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
            roundedButton6.Location = new Point(146, 7);
            roundedButton6.Name = "roundedButton6";
            roundedButton6.Size = new Size(63, 33);
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
            roundedButton7.Location = new Point(397, 7);
            roundedButton7.Name = "roundedButton7";
            roundedButton7.Size = new Size(66, 33);
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
            roundedButton8.Location = new Point(310, 7);
            roundedButton8.Name = "roundedButton8";
            roundedButton8.Size = new Size(77, 33);
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
            panel1.Location = new Point(38, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(1031, 145);
            panel1.TabIndex = 15;
            // 
            // grnDatePicker1
            // 
            grnDatePicker1.Location = new Point(34, 48);
            grnDatePicker1.Name = "grnDatePicker1";
            grnDatePicker1.Size = new Size(233, 23);
            grnDatePicker1.TabIndex = 8;
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
            grnclearBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grnclearBtn.Location = new Point(192, 109);
            grnclearBtn.Margin = new Padding(3, 2, 3, 2);
            grnclearBtn.Name = "grnclearBtn";
            grnclearBtn.Size = new Size(88, 34);
            grnclearBtn.TabIndex = 15;
            grnclearBtn.Text = "Clear";
            grnclearBtn.UseVisualStyleBackColor = true;
            grnclearBtn.Click += grnclearBtn_Click;
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
            grnSearchBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grnSearchBtn.Location = new Point(30, 109);
            grnSearchBtn.Margin = new Padding(3, 2, 3, 2);
            grnSearchBtn.Name = "grnSearchBtn";
            grnSearchBtn.Size = new Size(88, 34);
            grnSearchBtn.TabIndex = 15;
            grnSearchBtn.Text = "Search";
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
            // grnAddNoteBtn
            // 
            grnAddNoteBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grnAddNoteBtn.Location = new Point(930, 4);
            grnAddNoteBtn.Margin = new Padding(3, 2, 3, 2);
            grnAddNoteBtn.Name = "grnAddNoteBtn";
            grnAddNoteBtn.Size = new Size(155, 44);
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
            grndata.Location = new Point(31, 239);
            grndata.MultiSelect = false;
            grndata.Name = "grndata";
            grndata.RowHeadersVisible = false;
            grndata.RowHeadersWidth = 51;
            grndata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grndata.Size = new Size(1038, 434);
            grndata.TabIndex = 7;
            grndata.CellContentClick += grndata_CellContentClick;
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
            deliverypnl.Controls.Add(panel13);
            deliverypnl.Controls.Add(panel2);
            deliverypnl.Controls.Add(deliveryData);
            deliverypnl.Controls.Add(deliveryAddbtn);
            deliverypnl.Controls.Add(deliverylbl);
            deliverypnl.Location = new Point(176, 2);
            deliverypnl.Name = "deliverypnl";
            deliverypnl.Size = new Size(1094, 750);
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
            panel13.Location = new Point(576, 686);
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
            roundedButton9.ButtonPressedForeColor = Color.Gray;
            roundedButton9.ButtonRoundRadius = 15;
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
            label17.Location = new Point(220, 16);
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
            roundedButton10.ButtonRoundRadius = 15;
            roundedButton10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton10.ForeColor = Color.Black;
            roundedButton10.Location = new Point(146, 7);
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
            roundedButton11.ButtonRoundRadius = 15;
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
            roundedButton12.ButtonRoundRadius = 15;
            roundedButton12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton12.ForeColor = Color.Black;
            roundedButton12.Location = new Point(310, 7);
            roundedButton12.Name = "roundedButton12";
            roundedButton12.Size = new Size(77, 33);
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
            panel2.Location = new Point(38, 71);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1026, 147);
            panel2.TabIndex = 16;
            // 
            // deliverycompletedeliverybtn
            // 
            deliverycompletedeliverybtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliverycompletedeliverybtn.Location = new Point(378, 102);
            deliverycompletedeliverybtn.Margin = new Padding(3, 2, 3, 2);
            deliverycompletedeliverybtn.Name = "deliverycompletedeliverybtn";
            deliverycompletedeliverybtn.Size = new Size(94, 37);
            deliverycompletedeliverybtn.TabIndex = 32;
            deliverycompletedeliverybtn.Text = "Complete";
            deliverycompletedeliverybtn.UseVisualStyleBackColor = true;
            deliverycompletedeliverybtn.Click += deliverycompletedeliverybtn_Click;
            // 
            // deliverySearchIDbox
            // 
            deliverySearchIDbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliverySearchIDbox.Location = new Point(575, 104);
            deliverySearchIDbox.Margin = new Padding(3, 4, 3, 4);
            deliverySearchIDbox.Multiline = true;
            deliverySearchIDbox.Name = "deliverySearchIDbox";
            deliverySearchIDbox.PlaceholderText = "Search";
            deliverySearchIDbox.Size = new Size(446, 32);
            deliverySearchIDbox.TabIndex = 31;
            // 
            // deliveryViewDNbtn
            // 
            deliveryViewDNbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryViewDNbtn.Location = new Point(244, 102);
            deliveryViewDNbtn.Margin = new Padding(3, 2, 3, 2);
            deliveryViewDNbtn.Name = "deliveryViewDNbtn";
            deliveryViewDNbtn.Size = new Size(102, 34);
            deliveryViewDNbtn.TabIndex = 17;
            deliveryViewDNbtn.Text = "View";
            deliveryViewDNbtn.UseVisualStyleBackColor = true;
            deliveryViewDNbtn.Click += deliveryViewDNbtn_Click;
            // 
            // deliverydateTimePicker1
            // 
            deliverydateTimePicker1.Location = new Point(21, 48);
            deliverydateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            deliverydateTimePicker1.Name = "deliverydateTimePicker1";
            deliverydateTimePicker1.Size = new Size(212, 23);
            deliverydateTimePicker1.TabIndex = 8;
            // 
            // deliverySearchDatebtn
            // 
            deliverySearchDatebtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliverySearchDatebtn.Location = new Point(16, 99);
            deliverySearchDatebtn.Margin = new Padding(3, 2, 3, 2);
            deliverySearchDatebtn.Name = "deliverySearchDatebtn";
            deliverySearchDatebtn.Size = new Size(88, 35);
            deliverySearchDatebtn.TabIndex = 25;
            deliverySearchDatebtn.Text = "Search";
            deliverySearchDatebtn.UseVisualStyleBackColor = true;
            deliverySearchDatebtn.Click += deliverySearchDatebtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(275, 12);
            label3.Name = "label3";
            label3.Size = new Size(31, 25);
            label3.TabIndex = 11;
            label3.Text = "To";
            // 
            // deliveryclearbtn
            // 
            deliveryclearbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryclearbtn.Location = new Point(123, 100);
            deliveryclearbtn.Margin = new Padding(3, 2, 3, 2);
            deliveryclearbtn.Name = "deliveryclearbtn";
            deliveryclearbtn.Size = new Size(88, 35);
            deliveryclearbtn.TabIndex = 15;
            deliveryclearbtn.Text = "Clear";
            deliveryclearbtn.UseVisualStyleBackColor = true;
            deliveryclearbtn.Click += deliveryclearbtn_Click_1;
            // 
            // deliverydateTimePicker2
            // 
            deliverydateTimePicker2.Location = new Point(278, 48);
            deliverydateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            deliverydateTimePicker2.Name = "deliverydateTimePicker2";
            deliverydateTimePicker2.Size = new Size(220, 23);
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
            deliveryData.Location = new Point(33, 224);
            deliveryData.Margin = new Padding(3, 2, 3, 2);
            deliveryData.Name = "deliveryData";
            deliveryData.RowHeadersVisible = false;
            deliveryData.RowHeadersWidth = 51;
            deliveryData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            deliveryData.Size = new Size(1040, 453);
            deliveryData.TabIndex = 7;
            deliveryData.CellClick += deliveryData_CellClick;
            deliveryData.CellContentClick += deliveryData_CellContentClick;
            // 
            // deliveryAddbtn
            // 
            deliveryAddbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryAddbtn.Location = new Point(862, 24);
            deliveryAddbtn.Margin = new Padding(3, 2, 3, 2);
            deliveryAddbtn.Name = "deliveryAddbtn";
            deliveryAddbtn.Size = new Size(141, 42);
            deliveryAddbtn.TabIndex = 15;
            deliveryAddbtn.Text = "Add";
            deliveryAddbtn.UseVisualStyleBackColor = true;
            deliveryAddbtn.Click += deliveryAddbtn_Click_1;
            // 
            // deliverylbl
            // 
            deliverylbl.AutoSize = true;
            deliverylbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliverylbl.Location = new Point(16, 18);
            deliverylbl.Name = "deliverylbl";
            deliverylbl.Size = new Size(134, 25);
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
            deliveryCompletepnl.Location = new Point(186, 16);
            deliveryCompletepnl.Name = "deliveryCompletepnl";
            deliveryCompletepnl.Size = new Size(1063, 717);
            deliveryCompletepnl.TabIndex = 35;
            deliveryCompletepnl.Visible = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(195, 147);
            label19.Name = "label19";
            label19.Size = new Size(119, 25);
            label19.TabIndex = 26;
            label19.Text = "Shipped on ";
            // 
            // DeliverydeliveredDate
            // 
            DeliverydeliveredDate.Location = new Point(264, 219);
            DeliverydeliveredDate.Name = "DeliverydeliveredDate";
            DeliverydeliveredDate.Size = new Size(200, 23);
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
            POpnl.Controls.Add(panel16);
            POpnl.Controls.Add(panel17);
            POpnl.Controls.Add(customDataGridView2);
            POpnl.Controls.Add(button17);
            POpnl.Controls.Add(POlbl);
            POpnl.Location = new Point(176, 2);
            POpnl.Margin = new Padding(3, 2, 3, 2);
            POpnl.Name = "POpnl";
            POpnl.Size = new Size(1094, 750);
            POpnl.TabIndex = 32;
            // 
            // panel16
            // 
            panel16.Controls.Add(roundedButton17);
            panel16.Controls.Add(label24);
            panel16.Controls.Add(roundedButton18);
            panel16.Controls.Add(roundedButton19);
            panel16.Controls.Add(roundedButton20);
            panel16.Location = new Point(570, 681);
            panel16.Name = "panel16";
            panel16.Size = new Size(495, 50);
            panel16.TabIndex = 38;
            // 
            // roundedButton17
            // 
            roundedButton17.BackColor = SystemColors.Menu;
            roundedButton17.BackColor2 = Color.White;
            roundedButton17.BorderColor = Color.Tomato;
            roundedButton17.BorderSize = 2;
            roundedButton17.ButtonBorderColor = Color.Gray;
            roundedButton17.ButtonHighlightColor = Color.Empty;
            roundedButton17.ButtonHighlightColor2 = Color.Empty;
            roundedButton17.ButtonHighlightForeColor = Color.Black;
            roundedButton17.ButtonPressedColor = Color.White;
            roundedButton17.ButtonPressedColor2 = Color.Empty;
            roundedButton17.ButtonPressedForeColor = Color.Gray;
            roundedButton17.ButtonRoundRadius = 15;
            roundedButton17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton17.ForeColor = Color.Black;
            roundedButton17.Location = new Point(61, 7);
            roundedButton17.Name = "roundedButton17";
            roundedButton17.Size = new Size(69, 33);
            roundedButton17.TabIndex = 31;
            roundedButton17.Text = "First";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(220, 16);
            label24.Name = "label24";
            label24.Size = new Size(79, 20);
            label24.TabIndex = 3;
            label24.Text = "LabelData";
            // 
            // roundedButton18
            // 
            roundedButton18.AccessibleRole = AccessibleRole.None;
            roundedButton18.BackColor = SystemColors.Menu;
            roundedButton18.BackColor2 = Color.White;
            roundedButton18.BorderColor = Color.Tomato;
            roundedButton18.BorderSize = 2;
            roundedButton18.ButtonBorderColor = Color.Gray;
            roundedButton18.ButtonHighlightColor = Color.Empty;
            roundedButton18.ButtonHighlightColor2 = Color.Empty;
            roundedButton18.ButtonHighlightForeColor = Color.Black;
            roundedButton18.ButtonPressedColor = Color.White;
            roundedButton18.ButtonPressedColor2 = Color.Empty;
            roundedButton18.ButtonPressedForeColor = Color.Gray;
            roundedButton18.ButtonRoundRadius = 15;
            roundedButton18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton18.ForeColor = Color.Black;
            roundedButton18.Location = new Point(146, 7);
            roundedButton18.Name = "roundedButton18";
            roundedButton18.Size = new Size(63, 33);
            roundedButton18.TabIndex = 33;
            roundedButton18.Text = "Prev";
            // 
            // roundedButton19
            // 
            roundedButton19.BackColor = SystemColors.Menu;
            roundedButton19.BackColor2 = Color.White;
            roundedButton19.BorderColor = Color.White;
            roundedButton19.BorderSize = 2;
            roundedButton19.ButtonBorderColor = Color.Gray;
            roundedButton19.ButtonHighlightColor = Color.Empty;
            roundedButton19.ButtonHighlightColor2 = Color.Empty;
            roundedButton19.ButtonHighlightForeColor = Color.Black;
            roundedButton19.ButtonPressedColor = Color.White;
            roundedButton19.ButtonPressedColor2 = Color.Empty;
            roundedButton19.ButtonPressedForeColor = Color.Gray;
            roundedButton19.ButtonRoundRadius = 15;
            roundedButton19.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton19.ForeColor = Color.Black;
            roundedButton19.Location = new Point(397, 7);
            roundedButton19.Name = "roundedButton19";
            roundedButton19.Size = new Size(66, 33);
            roundedButton19.TabIndex = 34;
            roundedButton19.Text = "Last";
            // 
            // roundedButton20
            // 
            roundedButton20.BackColor = SystemColors.HighlightText;
            roundedButton20.BackColor2 = Color.White;
            roundedButton20.BorderColor = Color.Tomato;
            roundedButton20.BorderSize = 2;
            roundedButton20.ButtonBorderColor = Color.Gray;
            roundedButton20.ButtonHighlightColor = Color.Empty;
            roundedButton20.ButtonHighlightColor2 = Color.Empty;
            roundedButton20.ButtonHighlightForeColor = Color.Black;
            roundedButton20.ButtonPressedColor = Color.White;
            roundedButton20.ButtonPressedColor2 = Color.Empty;
            roundedButton20.ButtonPressedForeColor = Color.Gray;
            roundedButton20.ButtonRoundRadius = 15;
            roundedButton20.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton20.ForeColor = Color.Black;
            roundedButton20.Location = new Point(310, 7);
            roundedButton20.Name = "roundedButton20";
            roundedButton20.Size = new Size(77, 33);
            roundedButton20.TabIndex = 32;
            roundedButton20.Text = "Next";
            // 
            // panel17
            // 
            panel17.Controls.Add(button13);
            panel17.Controls.Add(roundedTextBox2);
            panel17.Controls.Add(button14);
            panel17.Controls.Add(dateTimePicker3);
            panel17.Controls.Add(label25);
            panel17.Controls.Add(button15);
            panel17.Controls.Add(label26);
            panel17.Controls.Add(button16);
            panel17.Controls.Add(dateTimePicker4);
            panel17.Location = new Point(32, 66);
            panel17.Margin = new Padding(3, 2, 3, 2);
            panel17.Name = "panel17";
            panel17.Size = new Size(1026, 147);
            panel17.TabIndex = 37;
            // 
            // button13
            // 
            button13.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.Location = new Point(378, 102);
            button13.Margin = new Padding(3, 2, 3, 2);
            button13.Name = "button13";
            button13.Size = new Size(94, 37);
            button13.TabIndex = 32;
            button13.Text = "Complete";
            button13.UseVisualStyleBackColor = true;
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox2.Location = new Point(575, 104);
            roundedTextBox2.Margin = new Padding(3, 4, 3, 4);
            roundedTextBox2.Multiline = true;
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.PlaceholderText = "Search";
            roundedTextBox2.Size = new Size(446, 32);
            roundedTextBox2.TabIndex = 31;
            // 
            // button14
            // 
            button14.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.Location = new Point(244, 102);
            button14.Margin = new Padding(3, 2, 3, 2);
            button14.Name = "button14";
            button14.Size = new Size(102, 34);
            button14.TabIndex = 17;
            button14.Text = "View";
            button14.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(21, 48);
            dateTimePicker3.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(212, 23);
            dateTimePicker3.TabIndex = 8;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(21, 12);
            label25.Name = "label25";
            label25.Size = new Size(55, 25);
            label25.TabIndex = 10;
            label25.Text = "From";
            // 
            // button15
            // 
            button15.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.Location = new Point(16, 99);
            button15.Margin = new Padding(3, 2, 3, 2);
            button15.Name = "button15";
            button15.Size = new Size(88, 35);
            button15.TabIndex = 25;
            button15.Text = "Search";
            button15.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(275, 12);
            label26.Name = "label26";
            label26.Size = new Size(31, 25);
            label26.TabIndex = 11;
            label26.Text = "To";
            // 
            // button16
            // 
            button16.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.Location = new Point(123, 100);
            button16.Margin = new Padding(3, 2, 3, 2);
            button16.Name = "button16";
            button16.Size = new Size(88, 35);
            button16.TabIndex = 15;
            button16.Text = "Clear";
            button16.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(278, 48);
            dateTimePicker4.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(220, 23);
            dateTimePicker4.TabIndex = 9;
            // 
            // customDataGridView2
            // 
            customDataGridView2.AllowUserToAddRows = false;
            customDataGridView2.AllowUserToDeleteRows = false;
            customDataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = SystemColors.Control;
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle21.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            customDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            customDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customDataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn2 });
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = SystemColors.Window;
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle22.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.False;
            customDataGridView2.DefaultCellStyle = dataGridViewCellStyle22;
            customDataGridView2.Location = new Point(27, 219);
            customDataGridView2.Margin = new Padding(3, 2, 3, 2);
            customDataGridView2.Name = "customDataGridView2";
            customDataGridView2.RowHeadersVisible = false;
            customDataGridView2.RowHeadersWidth = 51;
            customDataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customDataGridView2.Size = new Size(1040, 453);
            customDataGridView2.TabIndex = 35;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            dataGridViewCheckBoxColumn2.FillWeight = 35F;
            dataGridViewCheckBoxColumn2.HeaderText = "Select";
            dataGridViewCheckBoxColumn2.MinimumWidth = 35;
            dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // button17
            // 
            button17.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.Location = new Point(856, 19);
            button17.Margin = new Padding(3, 2, 3, 2);
            button17.Name = "button17";
            button17.Size = new Size(141, 42);
            button17.TabIndex = 36;
            button17.Text = "Add";
            button17.UseVisualStyleBackColor = true;
            // 
            // POlbl
            // 
            POlbl.AutoSize = true;
            POlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            POlbl.Location = new Point(10, 8);
            POlbl.Name = "POlbl";
            POlbl.Size = new Size(38, 25);
            POlbl.TabIndex = 0;
            POlbl.Text = "PO";
            // 
            // outstandingOrderpnl
            // 
            outstandingOrderpnl.Controls.Add(panel20);
            outstandingOrderpnl.Controls.Add(panel21);
            outstandingOrderpnl.Controls.Add(customDataGridView4);
            outstandingOrderpnl.Controls.Add(button24);
            outstandingOrderpnl.Controls.Add(outstandingOrderlbl);
            outstandingOrderpnl.Location = new Point(176, 2);
            outstandingOrderpnl.Margin = new Padding(3, 2, 3, 2);
            outstandingOrderpnl.Name = "outstandingOrderpnl";
            outstandingOrderpnl.Size = new Size(1094, 750);
            outstandingOrderpnl.TabIndex = 33;
            // 
            // outstandingOrderlbl
            // 
            outstandingOrderlbl.AutoSize = true;
            outstandingOrderlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            outstandingOrderlbl.Location = new Point(10, 8);
            outstandingOrderlbl.Name = "outstandingOrderlbl";
            outstandingOrderlbl.Size = new Size(180, 25);
            outstandingOrderlbl.TabIndex = 0;
            outstandingOrderlbl.Text = "Outstanding Order";
            // 
            // invoicepnl
            // 
            invoicepnl.Controls.Add(panel14);
            invoicepnl.Controls.Add(panel15);
            invoicepnl.Controls.Add(customDataGridView1);
            invoicepnl.Controls.Add(button12);
            invoicepnl.Controls.Add(invoicelbl);
            invoicepnl.Location = new Point(176, 2);
            invoicepnl.Margin = new Padding(3, 2, 3, 2);
            invoicepnl.Name = "invoicepnl";
            invoicepnl.Size = new Size(1094, 750);
            invoicepnl.TabIndex = 33;
            // 
            // panel14
            // 
            panel14.Controls.Add(roundedButton13);
            panel14.Controls.Add(label21);
            panel14.Controls.Add(roundedButton14);
            panel14.Controls.Add(roundedButton15);
            panel14.Controls.Add(roundedButton16);
            panel14.Location = new Point(570, 681);
            panel14.Name = "panel14";
            panel14.Size = new Size(495, 50);
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
            roundedButton13.Location = new Point(61, 7);
            roundedButton13.Name = "roundedButton13";
            roundedButton13.Size = new Size(69, 33);
            roundedButton13.TabIndex = 31;
            roundedButton13.Text = "First";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(220, 16);
            label21.Name = "label21";
            label21.Size = new Size(79, 20);
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
            roundedButton14.Location = new Point(146, 7);
            roundedButton14.Name = "roundedButton14";
            roundedButton14.Size = new Size(63, 33);
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
            roundedButton15.Location = new Point(397, 7);
            roundedButton15.Name = "roundedButton15";
            roundedButton15.Size = new Size(66, 33);
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
            roundedButton16.Location = new Point(310, 7);
            roundedButton16.Name = "roundedButton16";
            roundedButton16.Size = new Size(77, 33);
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
            panel15.Location = new Point(32, 66);
            panel15.Margin = new Padding(3, 2, 3, 2);
            panel15.Name = "panel15";
            panel15.Size = new Size(1026, 147);
            panel15.TabIndex = 37;
            // 
            // button7
            // 
            button7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(378, 102);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(94, 37);
            button7.TabIndex = 32;
            button7.Text = "Complete";
            button7.UseVisualStyleBackColor = true;
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox1.Location = new Point(575, 104);
            roundedTextBox1.Margin = new Padding(3, 4, 3, 4);
            roundedTextBox1.Multiline = true;
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.PlaceholderText = "Search";
            roundedTextBox1.Size = new Size(446, 32);
            roundedTextBox1.TabIndex = 31;
            // 
            // button9
            // 
            button9.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(244, 102);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(102, 34);
            button9.TabIndex = 17;
            button9.Text = "View";
            button9.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(21, 48);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 23);
            dateTimePicker1.TabIndex = 8;
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
            // button10
            // 
            button10.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(16, 99);
            button10.Margin = new Padding(3, 2, 3, 2);
            button10.Name = "button10";
            button10.Size = new Size(88, 35);
            button10.TabIndex = 25;
            button10.Text = "Search";
            button10.UseVisualStyleBackColor = true;
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
            // button11
            // 
            button11.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(123, 100);
            button11.Margin = new Padding(3, 2, 3, 2);
            button11.Name = "button11";
            button11.Size = new Size(88, 35);
            button11.TabIndex = 15;
            button11.Text = "Clear";
            button11.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(278, 48);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(220, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // customDataGridView1
            // 
            customDataGridView1.AllowUserToAddRows = false;
            customDataGridView1.AllowUserToDeleteRows = false;
            customDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = SystemColors.Control;
            dataGridViewCellStyle25.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle25.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
            customDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            customDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customDataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn1 });
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = SystemColors.Window;
            dataGridViewCellStyle26.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle26.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.False;
            customDataGridView1.DefaultCellStyle = dataGridViewCellStyle26;
            customDataGridView1.Location = new Point(27, 219);
            customDataGridView1.Margin = new Padding(3, 2, 3, 2);
            customDataGridView1.Name = "customDataGridView1";
            customDataGridView1.RowHeadersVisible = false;
            customDataGridView1.RowHeadersWidth = 51;
            customDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customDataGridView1.Size = new Size(1040, 453);
            customDataGridView1.TabIndex = 35;
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
            button12.Location = new Point(856, 19);
            button12.Margin = new Padding(3, 2, 3, 2);
            button12.Name = "button12";
            button12.Size = new Size(141, 42);
            button12.TabIndex = 36;
            button12.Text = "Add";
            button12.UseVisualStyleBackColor = true;
            // 
            // invoicelbl
            // 
            invoicelbl.AutoSize = true;
            invoicelbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            invoicelbl.Location = new Point(10, 8);
            invoicelbl.Name = "invoicelbl";
            invoicelbl.Size = new Size(76, 25);
            invoicelbl.TabIndex = 0;
            invoicelbl.Text = "Invoice";
            // 
            // panel20
            // 
            panel20.Controls.Add(roundedButton25);
            panel20.Controls.Add(label30);
            panel20.Controls.Add(roundedButton26);
            panel20.Controls.Add(roundedButton27);
            panel20.Controls.Add(roundedButton28);
            panel20.Location = new Point(570, 681);
            panel20.Name = "panel20";
            panel20.Size = new Size(495, 50);
            panel20.TabIndex = 38;
            // 
            // roundedButton25
            // 
            roundedButton25.BackColor = SystemColors.Menu;
            roundedButton25.BackColor2 = Color.White;
            roundedButton25.BorderColor = Color.Tomato;
            roundedButton25.BorderSize = 2;
            roundedButton25.ButtonBorderColor = Color.Gray;
            roundedButton25.ButtonHighlightColor = Color.Empty;
            roundedButton25.ButtonHighlightColor2 = Color.Empty;
            roundedButton25.ButtonHighlightForeColor = Color.Black;
            roundedButton25.ButtonPressedColor = Color.White;
            roundedButton25.ButtonPressedColor2 = Color.Empty;
            roundedButton25.ButtonPressedForeColor = Color.Gray;
            roundedButton25.ButtonRoundRadius = 15;
            roundedButton25.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton25.ForeColor = Color.Black;
            roundedButton25.Location = new Point(61, 7);
            roundedButton25.Name = "roundedButton25";
            roundedButton25.Size = new Size(69, 33);
            roundedButton25.TabIndex = 31;
            roundedButton25.Text = "First";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(220, 16);
            label30.Name = "label30";
            label30.Size = new Size(79, 20);
            label30.TabIndex = 3;
            label30.Text = "LabelData";
            // 
            // roundedButton26
            // 
            roundedButton26.AccessibleRole = AccessibleRole.None;
            roundedButton26.BackColor = SystemColors.Menu;
            roundedButton26.BackColor2 = Color.White;
            roundedButton26.BorderColor = Color.Tomato;
            roundedButton26.BorderSize = 2;
            roundedButton26.ButtonBorderColor = Color.Gray;
            roundedButton26.ButtonHighlightColor = Color.Empty;
            roundedButton26.ButtonHighlightColor2 = Color.Empty;
            roundedButton26.ButtonHighlightForeColor = Color.Black;
            roundedButton26.ButtonPressedColor = Color.White;
            roundedButton26.ButtonPressedColor2 = Color.Empty;
            roundedButton26.ButtonPressedForeColor = Color.Gray;
            roundedButton26.ButtonRoundRadius = 15;
            roundedButton26.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton26.ForeColor = Color.Black;
            roundedButton26.Location = new Point(146, 7);
            roundedButton26.Name = "roundedButton26";
            roundedButton26.Size = new Size(63, 33);
            roundedButton26.TabIndex = 33;
            roundedButton26.Text = "Prev";
            // 
            // roundedButton27
            // 
            roundedButton27.BackColor = SystemColors.Menu;
            roundedButton27.BackColor2 = Color.White;
            roundedButton27.BorderColor = Color.White;
            roundedButton27.BorderSize = 2;
            roundedButton27.ButtonBorderColor = Color.Gray;
            roundedButton27.ButtonHighlightColor = Color.Empty;
            roundedButton27.ButtonHighlightColor2 = Color.Empty;
            roundedButton27.ButtonHighlightForeColor = Color.Black;
            roundedButton27.ButtonPressedColor = Color.White;
            roundedButton27.ButtonPressedColor2 = Color.Empty;
            roundedButton27.ButtonPressedForeColor = Color.Gray;
            roundedButton27.ButtonRoundRadius = 15;
            roundedButton27.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton27.ForeColor = Color.Black;
            roundedButton27.Location = new Point(397, 7);
            roundedButton27.Name = "roundedButton27";
            roundedButton27.Size = new Size(66, 33);
            roundedButton27.TabIndex = 34;
            roundedButton27.Text = "Last";
            // 
            // roundedButton28
            // 
            roundedButton28.BackColor = SystemColors.HighlightText;
            roundedButton28.BackColor2 = Color.White;
            roundedButton28.BorderColor = Color.Tomato;
            roundedButton28.BorderSize = 2;
            roundedButton28.ButtonBorderColor = Color.Gray;
            roundedButton28.ButtonHighlightColor = Color.Empty;
            roundedButton28.ButtonHighlightColor2 = Color.Empty;
            roundedButton28.ButtonHighlightForeColor = Color.Black;
            roundedButton28.ButtonPressedColor = Color.White;
            roundedButton28.ButtonPressedColor2 = Color.Empty;
            roundedButton28.ButtonPressedForeColor = Color.Gray;
            roundedButton28.ButtonRoundRadius = 15;
            roundedButton28.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton28.ForeColor = Color.Black;
            roundedButton28.Location = new Point(310, 7);
            roundedButton28.Name = "roundedButton28";
            roundedButton28.Size = new Size(77, 33);
            roundedButton28.TabIndex = 32;
            roundedButton28.Text = "Next";
            // 
            // panel21
            // 
            panel21.Controls.Add(button20);
            panel21.Controls.Add(roundedTextBox4);
            panel21.Controls.Add(button21);
            panel21.Controls.Add(dateTimePicker7);
            panel21.Controls.Add(label31);
            panel21.Controls.Add(button22);
            panel21.Controls.Add(label32);
            panel21.Controls.Add(button23);
            panel21.Controls.Add(dateTimePicker8);
            panel21.Location = new Point(32, 66);
            panel21.Margin = new Padding(3, 2, 3, 2);
            panel21.Name = "panel21";
            panel21.Size = new Size(1026, 147);
            panel21.TabIndex = 37;
            // 
            // button20
            // 
            button20.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button20.Location = new Point(378, 102);
            button20.Margin = new Padding(3, 2, 3, 2);
            button20.Name = "button20";
            button20.Size = new Size(94, 37);
            button20.TabIndex = 32;
            button20.Text = "Complete";
            button20.UseVisualStyleBackColor = true;
            // 
            // roundedTextBox4
            // 
            roundedTextBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox4.Location = new Point(575, 104);
            roundedTextBox4.Margin = new Padding(3, 4, 3, 4);
            roundedTextBox4.Multiline = true;
            roundedTextBox4.Name = "roundedTextBox4";
            roundedTextBox4.PlaceholderText = "Search";
            roundedTextBox4.Size = new Size(446, 32);
            roundedTextBox4.TabIndex = 31;
            // 
            // button21
            // 
            button21.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button21.Location = new Point(244, 102);
            button21.Margin = new Padding(3, 2, 3, 2);
            button21.Name = "button21";
            button21.Size = new Size(102, 34);
            button21.TabIndex = 17;
            button21.Text = "View";
            button21.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker7
            // 
            dateTimePicker7.Location = new Point(21, 48);
            dateTimePicker7.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker7.Name = "dateTimePicker7";
            dateTimePicker7.Size = new Size(212, 23);
            dateTimePicker7.TabIndex = 8;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.Location = new Point(21, 12);
            label31.Name = "label31";
            label31.Size = new Size(55, 25);
            label31.TabIndex = 10;
            label31.Text = "From";
            // 
            // button22
            // 
            button22.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button22.Location = new Point(16, 99);
            button22.Margin = new Padding(3, 2, 3, 2);
            button22.Name = "button22";
            button22.Size = new Size(88, 35);
            button22.TabIndex = 25;
            button22.Text = "Search";
            button22.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label32.Location = new Point(275, 12);
            label32.Name = "label32";
            label32.Size = new Size(31, 25);
            label32.TabIndex = 11;
            label32.Text = "To";
            // 
            // button23
            // 
            button23.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button23.Location = new Point(123, 100);
            button23.Margin = new Padding(3, 2, 3, 2);
            button23.Name = "button23";
            button23.Size = new Size(88, 35);
            button23.TabIndex = 15;
            button23.Text = "Clear";
            button23.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker8
            // 
            dateTimePicker8.Location = new Point(278, 48);
            dateTimePicker8.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker8.Name = "dateTimePicker8";
            dateTimePicker8.Size = new Size(220, 23);
            dateTimePicker8.TabIndex = 9;
            // 
            // customDataGridView4
            // 
            customDataGridView4.AllowUserToAddRows = false;
            customDataGridView4.AllowUserToDeleteRows = false;
            customDataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = SystemColors.Control;
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle23.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            customDataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            customDataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customDataGridView4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn4 });
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = SystemColors.Window;
            dataGridViewCellStyle24.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle24.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.False;
            customDataGridView4.DefaultCellStyle = dataGridViewCellStyle24;
            customDataGridView4.Location = new Point(27, 219);
            customDataGridView4.Margin = new Padding(3, 2, 3, 2);
            customDataGridView4.Name = "customDataGridView4";
            customDataGridView4.RowHeadersVisible = false;
            customDataGridView4.RowHeadersWidth = 51;
            customDataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customDataGridView4.Size = new Size(1040, 453);
            customDataGridView4.TabIndex = 35;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            dataGridViewCheckBoxColumn4.FillWeight = 35F;
            dataGridViewCheckBoxColumn4.HeaderText = "Select";
            dataGridViewCheckBoxColumn4.MinimumWidth = 35;
            dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            // 
            // button24
            // 
            button24.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button24.Location = new Point(856, 19);
            button24.Margin = new Padding(3, 2, 3, 2);
            button24.Name = "button24";
            button24.Size = new Size(141, 42);
            button24.TabIndex = 36;
            button24.Text = "Add";
            button24.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1312, 750);
            Controls.Add(outstandingOrderpnl);
            Controls.Add(logpnl);
            Controls.Add(POpnl);
            Controls.Add(invoicepnl);
            Controls.Add(deliverypnl);
            Controls.Add(listpnl);
            Controls.Add(closebtn);
            Controls.Add(orderpnl);
            Controls.Add(inventorypnl);
            Controls.Add(GRNpnl);
            Controls.Add(userspnl);
            Controls.Add(contactpnl);
            Controls.Add(dashboardpnl);
            Controls.Add(settingpnl);
            Controls.Add(OrderAccemblypnl);
            Controls.Add(deliveryCompletepnl);
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
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)customDataGridView3).EndInit();
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
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customDataGridView2).EndInit();
            outstandingOrderpnl.ResumeLayout(false);
            outstandingOrderpnl.PerformLayout();
            invoicepnl.ResumeLayout(false);
            invoicepnl.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customDataGridView1).EndInit();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customDataGridView4).EndInit();
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
        private DataGridViewCheckBoxColumn contactcheckColumn;
        private DataGridViewCheckBoxColumn usercheckColumn;
        private DataGridViewCheckBoxColumn stockcheckColumn;
        private DataGridViewCheckBoxColumn orderAccemblyColumn;
        private Button searchSupplierbtn;
        private Button orderoverallBtn1;
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
        private Label pageNumlbl;
        private ProgramMethod.ProgramMethod.RoundedButton sotckPrevPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton sotckLastPagebtn;
        private ProgramMethod.ProgramMethod.RoundedButton sotckNextPagebtn;
        private ProgramMethod.ProgramMethod.RoundedTextBox accountSearchBox;
        private Label orderoverallBtn;
        private Button button6;
        private Label label11;
        private Button button5;
        private Label label10;
        private Button button3;
        private Label label8;
        private Panel panel9;
        private Button orderSearchbtn;
        private Label label14;
        private Label label13;
        private DateTimePicker orderdateTimePicker2;
        private DateTimePicker orderdateTimePicker1;
        private ProgramMethod.ProgramMethod.RoundedTextBox orderSearchbox;
        private Button button8;
        private Panel panel10;
        private Panel panel11;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton1;
        private Label label15;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton2;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton3;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton4;
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
        private CustomDataGridView customDataGridView1;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Button button12;
        private Panel panel16;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton17;
        private Label label24;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton18;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton19;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton20;
        private Panel panel17;
        private Button button13;
        private ProgramMethod.ProgramMethod.RoundedTextBox roundedTextBox2;
        private Button button14;
        private DateTimePicker dateTimePicker3;
        private Label label25;
        private Button button15;
        private Label label26;
        private Button button16;
        private DateTimePicker dateTimePicker4;
        private CustomDataGridView customDataGridView2;
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
        private CustomDataGridView customDataGridView3;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private Button button19;
        private Panel panel20;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton25;
        private Label label30;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton26;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton27;
        private ProgramMethod.ProgramMethod.RoundedButton roundedButton28;
        private Panel panel21;
        private Button button20;
        private ProgramMethod.ProgramMethod.RoundedTextBox roundedTextBox4;
        private Button button21;
        private DateTimePicker dateTimePicker7;
        private Label label31;
        private Button button22;
        private Label label32;
        private Button button23;
        private DateTimePicker dateTimePicker8;
        private CustomDataGridView customDataGridView4;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private Button button24;
    }
}