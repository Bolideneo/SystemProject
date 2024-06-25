using System.Windows.Forms;

namespace ITP4519M
{
    partial class CreateOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrder));
            CloseButton = new Button();
            label3 = new Label();
            productOfOrderdata = new DataGridView();
            productIDColumn = new DataGridViewTextBoxColumn();
            productNameColumn = new DataGridViewTextBoxColumn();
            quantityColumn = new DataGridViewTextBoxColumn();
            unitPriceColumn = new DataGridViewTextBoxColumn();
            createOrderbtn = new Button();
            productSearchbox = new ProgramMethod.ProgramMethod.RoundedTextBox();
            panel1 = new Panel();
            OrderContactPhonebox = new TextBox();
            orderlbl = new Label();
            orderContactNamebox = new TextBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel5 = new Panel();
            dealerinfoBox = new TextBox();
            pictureBox1 = new PictureBox();
            InvoiceLine1 = new Panel();
            dealerNameBox1 = new Label();
            dealerIDBox1 = new Label();
            label12 = new Label();
            orderDateBox = new DateTimePicker();
            ordertotallbl = new Label();
            label9 = new Label();
            label10 = new Label();
            label7 = new Label();
            label11 = new Label();
            dealerIDBox = new TextBox();
            dealerNameBox = new TextBox();
            phoneNumBox = new TextBox();
            dealerCompanyBox = new TextBox();
            label8 = new Label();
            label1 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            orderEmailAddressbox = new TextBox();
            avatarbox = new PictureBox();
            label15 = new Label();
            label4 = new Label();
            CustomerName = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label14 = new Label();
            label13 = new Label();
            panel3 = new Panel();
            invoiceAddressBox = new Label();
            panel6 = new Panel();
            goodsAddressBox = new Label();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)productOfOrderdata).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatarbox).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(1102, -3);
            CloseButton.Margin = new Padding(3, 4, 3, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(40, 51);
            CloseButton.TabIndex = 15;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(34, 21);
            label3.Name = "label3";
            label3.Size = new Size(184, 38);
            label3.TabIndex = 16;
            label3.Text = "Create Order";
            // 
            // productOfOrderdata
            // 
            productOfOrderdata.AllowUserToAddRows = false;
            productOfOrderdata.AllowUserToDeleteRows = false;
            productOfOrderdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productOfOrderdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productOfOrderdata.Location = new Point(24, 496);
            productOfOrderdata.Margin = new Padding(3, 5, 3, 5);
            productOfOrderdata.Name = "productOfOrderdata";
            productOfOrderdata.RowHeadersWidth = 51;
            productOfOrderdata.RowTemplate.Height = 24;
            productOfOrderdata.Size = new Size(720, 291);
            productOfOrderdata.TabIndex = 61;
            productOfOrderdata.CellDoubleClick += productOfOrderdata_CellDoubleClick;
            // 
            // productIDColumn
            // 
            productIDColumn.HeaderText = "ProductID";
            productIDColumn.MinimumWidth = 6;
            productIDColumn.Name = "productIDColumn";
            productIDColumn.Width = 125;
            // 
            // productNameColumn
            // 
            productNameColumn.HeaderText = "ProductName";
            productNameColumn.MinimumWidth = 6;
            productNameColumn.Name = "productNameColumn";
            productNameColumn.Width = 125;
            // 
            // quantityColumn
            // 
            quantityColumn.HeaderText = "Quantity";
            quantityColumn.MinimumWidth = 6;
            quantityColumn.Name = "quantityColumn";
            quantityColumn.Width = 125;
            // 
            // unitPriceColumn
            // 
            unitPriceColumn.HeaderText = "UnitPrice";
            unitPriceColumn.MinimumWidth = 6;
            unitPriceColumn.Name = "unitPriceColumn";
            unitPriceColumn.Width = 125;
            // 
            // createOrderbtn
            // 
            createOrderbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createOrderbtn.Location = new Point(573, 826);
            createOrderbtn.Margin = new Padding(3, 4, 3, 4);
            createOrderbtn.Name = "createOrderbtn";
            createOrderbtn.Size = new Size(171, 53);
            createOrderbtn.TabIndex = 68;
            createOrderbtn.Text = "Create";
            createOrderbtn.UseVisualStyleBackColor = true;
            createOrderbtn.Click += createOrderbtn_Click;
            // 
            // productSearchbox
            // 
            productSearchbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productSearchbox.Location = new Point(43, 445);
            productSearchbox.Margin = new Padding(3, 5, 3, 5);
            productSearchbox.MaximumSize = new Size(300, 60);
            productSearchbox.Multiline = true;
            productSearchbox.Name = "productSearchbox";
            productSearchbox.PlaceholderText = "Search Product";
            productSearchbox.Size = new Size(300, 41);
            productSearchbox.TabIndex = 92;
            productSearchbox.TextChanged += productSearchbox_TextChanged;
            productSearchbox.KeyDown += productSearchbox_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(OrderContactPhonebox);
            panel1.Controls.Add(orderlbl);
            panel1.Controls.Add(orderContactNamebox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(InvoiceLine1);
            panel1.Controls.Add(createOrderbtn);
            panel1.Controls.Add(dealerNameBox1);
            panel1.Controls.Add(dealerIDBox1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(orderDateBox);
            panel1.Controls.Add(ordertotallbl);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(productSearchbox);
            panel1.Controls.Add(productOfOrderdata);
            panel1.Location = new Point(34, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 893);
            panel1.TabIndex = 72;
            panel1.Paint += panel1_Paint;
            // 
            // OrderContactPhonebox
            // 
            OrderContactPhonebox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderContactPhonebox.Location = new Point(263, 187);
            OrderContactPhonebox.Margin = new Padding(5, 0, 5, 0);
            OrderContactPhonebox.Name = "OrderContactPhonebox";
            OrderContactPhonebox.Size = new Size(180, 27);
            OrderContactPhonebox.TabIndex = 91;
            OrderContactPhonebox.Text = "textBox3";
            // 
            // orderlbl
            // 
            orderlbl.AutoSize = true;
            orderlbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderlbl.ForeColor = Color.Black;
            orderlbl.Location = new Point(94, 190);
            orderlbl.Margin = new Padding(5, 0, 5, 0);
            orderlbl.Name = "orderlbl";
            orderlbl.Size = new Size(159, 24);
            orderlbl.TabIndex = 90;
            orderlbl.Text = "Contact Phone :";
            // 
            // orderContactNamebox
            // 
            orderContactNamebox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderContactNamebox.Location = new Point(262, 149);
            orderContactNamebox.Margin = new Padding(5, 0, 5, 0);
            orderContactNamebox.Name = "orderContactNamebox";
            orderContactNamebox.Size = new Size(180, 27);
            orderContactNamebox.TabIndex = 89;
            orderContactNamebox.Text = "textBox3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(100, 152);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(153, 24);
            label6.TabIndex = 89;
            label6.Text = "Contact Name :";
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(519, 46);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(225, 28);
            comboBox2.TabIndex = 88;
            comboBox2.KeyDown += comboBox2_KeyDown;
            comboBox2.PreviewKeyDown += comboBox2_PreviewKeyDown;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(274, 46);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 28);
            comboBox1.TabIndex = 77;
            comboBox1.TextChanged += comboBox1_TextChanged;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.Controls.Add(dealerinfoBox);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(262, 97);
            panel5.Name = "panel5";
            panel5.Size = new Size(256, 35);
            panel5.TabIndex = 85;
            // 
            // dealerinfoBox
            // 
            dealerinfoBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            dealerinfoBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            dealerinfoBox.BorderStyle = BorderStyle.None;
            dealerinfoBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerinfoBox.Location = new Point(1, 8);
            dealerinfoBox.Margin = new Padding(6, 7, 6, 7);
            dealerinfoBox.Name = "dealerinfoBox";
            dealerinfoBox.Size = new Size(249, 20);
            dealerinfoBox.TabIndex = 86;
            dealerinfoBox.TextChanged += dealerinfoBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(216, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // InvoiceLine1
            // 
            InvoiceLine1.BackColor = SystemColors.ControlDark;
            InvoiceLine1.BorderStyle = BorderStyle.Fixed3D;
            InvoiceLine1.ForeColor = SystemColors.ControlText;
            InvoiceLine1.Location = new Point(136, 373);
            InvoiceLine1.Margin = new Padding(3, 4, 3, 4);
            InvoiceLine1.Name = "InvoiceLine1";
            InvoiceLine1.Size = new Size(506, 5);
            InvoiceLine1.TabIndex = 81;
            // 
            // dealerNameBox1
            // 
            dealerNameBox1.AutoSize = true;
            dealerNameBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerNameBox1.Location = new Point(616, 206);
            dealerNameBox1.Margin = new Padding(7, 9, 7, 9);
            dealerNameBox1.Name = "dealerNameBox1";
            dealerNameBox1.Size = new Size(128, 20);
            dealerNameBox1.TabIndex = 44;
            dealerNameBox1.Text = "dealerNameBox";
            // 
            // dealerIDBox1
            // 
            dealerIDBox1.AutoSize = true;
            dealerIDBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerIDBox1.ForeColor = Color.Black;
            dealerIDBox1.Location = new Point(654, 168);
            dealerIDBox1.Margin = new Padding(7, 9, 7, 9);
            dealerIDBox1.Name = "dealerIDBox1";
            dealerIDBox1.Size = new Size(101, 20);
            dealerIDBox1.TabIndex = 43;
            dealerIDBox1.Text = "dealerIDBox";
            dealerIDBox1.KeyDown += dealerIDBox_KeyDown;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(-3, 239);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(250, 22);
            label12.TabIndex = 65;
            label12.Text = "Order Except Complete Date :";
            // 
            // orderDateBox
            // 
            orderDateBox.Location = new Point(256, 239);
            orderDateBox.MinDate = new DateTime(2010, 7, 27, 0, 0, 0, 0);
            orderDateBox.Name = "orderDateBox";
            orderDateBox.Size = new Size(285, 27);
            orderDateBox.TabIndex = 70;
            // 
            // ordertotallbl
            // 
            ordertotallbl.AutoSize = true;
            ordertotallbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordertotallbl.Location = new Point(24, 802);
            ordertotallbl.Name = "ordertotallbl";
            ordertotallbl.Size = new Size(123, 28);
            ordertotallbl.TabIndex = 73;
            ordertotallbl.Text = "Total: CNY¥0";
            ordertotallbl.TextChanged += ordertotallbl_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.WindowText;
            label9.Location = new Point(6, 16);
            label9.Name = "label9";
            label9.Size = new Size(156, 29);
            label9.TabIndex = 74;
            label9.Text = "Order Detail";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(109, 105);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(155, 24);
            label10.TabIndex = 74;
            label10.Text = " * Dealer Info :  ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Menu;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(370, 394);
            label7.Name = "label7";
            label7.Size = new Size(358, 46);
            label7.TabIndex = 72;
            label7.Text = "Left click Quantity column to change quantity\r\nDouble click Cell to remove unwant product\r\n";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(600, 235);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(144, 24);
            label11.TabIndex = 54;
            label11.Text = "Dealer Name :";
            // 
            // dealerIDBox
            // 
            dealerIDBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerIDBox.Location = new Point(10, 83);
            dealerIDBox.Margin = new Padding(5, 0, 5, 0);
            dealerIDBox.Name = "dealerIDBox";
            dealerIDBox.Size = new Size(131, 27);
            dealerIDBox.TabIndex = 87;
            dealerIDBox.Text = "textBox2";
            // 
            // dealerNameBox
            // 
            dealerNameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerNameBox.Location = new Point(10, 144);
            dealerNameBox.Margin = new Padding(5, 0, 5, 0);
            dealerNameBox.Name = "dealerNameBox";
            dealerNameBox.Size = new Size(131, 27);
            dealerNameBox.TabIndex = 86;
            dealerNameBox.Text = "textBox2";
            // 
            // phoneNumBox
            // 
            phoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumBox.Location = new Point(30, 42);
            phoneNumBox.Margin = new Padding(5, 0, 5, 0);
            phoneNumBox.Name = "phoneNumBox";
            phoneNumBox.Size = new Size(155, 27);
            phoneNumBox.TabIndex = 80;
            phoneNumBox.Text = "phoneNumBox";
            // 
            // dealerCompanyBox
            // 
            dealerCompanyBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerCompanyBox.Location = new Point(30, 111);
            dealerCompanyBox.Margin = new Padding(5, 0, 5, 0);
            dealerCompanyBox.Name = "dealerCompanyBox";
            dealerCompanyBox.Size = new Size(180, 27);
            dealerCompanyBox.TabIndex = 82;
            dealerCompanyBox.Text = "dealerCompanyBox";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(25, 76);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(177, 24);
            label8.TabIndex = 60;
            label8.Text = "Dealer Company :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(10, 45);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 24);
            label1.TabIndex = 44;
            label1.Text = "Dealer ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(24, 8);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(164, 24);
            label5.TabIndex = 48;
            label5.Text = "Phone Number :";
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(orderEmailAddressbox);
            panel2.Controls.Add(dealerIDBox);
            panel2.Controls.Add(avatarbox);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dealerNameBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(CustomerName);
            panel2.Location = new Point(819, 88);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 244);
            panel2.TabIndex = 83;
            // 
            // orderEmailAddressbox
            // 
            orderEmailAddressbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderEmailAddressbox.Location = new Point(166, 149);
            orderEmailAddressbox.Margin = new Padding(5, 0, 5, 0);
            orderEmailAddressbox.Name = "orderEmailAddressbox";
            orderEmailAddressbox.Size = new Size(131, 27);
            orderEmailAddressbox.TabIndex = 89;
            orderEmailAddressbox.Text = "textBox2";
            // 
            // avatarbox
            // 
            avatarbox.BackgroundImage = (Image)resources.GetObject("avatarbox.BackgroundImage");
            avatarbox.BackgroundImageLayout = ImageLayout.Stretch;
            avatarbox.BorderStyle = BorderStyle.Fixed3D;
            avatarbox.Location = new Point(257, 16);
            avatarbox.Margin = new Padding(3, 4, 3, 4);
            avatarbox.Name = "avatarbox";
            avatarbox.Size = new Size(58, 53);
            avatarbox.TabIndex = 84;
            avatarbox.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(166, 105);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(123, 20);
            label15.TabIndex = 88;
            label15.Text = "Email Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(23, 0);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 83;
            label4.Text = "Customer Info";
            // 
            // CustomerName
            // 
            CustomerName.AutoSize = true;
            CustomerName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerName.Location = new Point(9, 109);
            CustomerName.Margin = new Padding(5, 0, 5, 0);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(126, 20);
            CustomerName.TabIndex = 82;
            CustomerName.Text = "CustomerName";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(18, 611);
            textBox1.Margin = new Padding(6, 7, 6, 7);
            textBox1.MaximumSize = new Size(300, 60);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search customer";
            textBox1.Size = new Size(283, 27);
            textBox1.TabIndex = 82;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(20, 580);
            label2.Name = "label2";
            label2.Size = new Size(239, 25);
            label2.TabIndex = 82;
            label2.Text = "Find or create customer";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(9, 470);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(167, 25);
            label14.TabIndex = 87;
            label14.Text = "Invoice Address";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(18, 271);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(245, 25);
            label13.TabIndex = 85;
            label13.Text = "Goods Delivery Address";
            // 
            // panel3
            // 
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(invoiceAddressBox);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(phoneNumBox);
            panel3.Controls.Add(goodsAddressBox);
            panel3.Controls.Add(dealerCompanyBox);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(819, 334);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 648);
            panel3.TabIndex = 84;
            // 
            // invoiceAddressBox
            // 
            invoiceAddressBox.AutoSize = true;
            invoiceAddressBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invoiceAddressBox.Location = new Point(12, 504);
            invoiceAddressBox.Margin = new Padding(5, 0, 5, 0);
            invoiceAddressBox.Name = "invoiceAddressBox";
            invoiceAddressBox.Size = new Size(173, 24);
            invoiceAddressBox.TabIndex = 88;
            invoiceAddressBox.Text = "invoiceAddressBox";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDark;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.ForeColor = SystemColors.ControlText;
            panel6.Location = new Point(9, 452);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(291, 5);
            panel6.TabIndex = 83;
            // 
            // goodsAddressBox
            // 
            goodsAddressBox.AutoSize = true;
            goodsAddressBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goodsAddressBox.Location = new Point(19, 323);
            goodsAddressBox.Margin = new Padding(5, 0, 5, 0);
            goodsAddressBox.Name = "goodsAddressBox";
            goodsAddressBox.Size = new Size(166, 24);
            goodsAddressBox.TabIndex = 86;
            goodsAddressBox.Text = "goodsAddressBox";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.ForeColor = SystemColors.ControlText;
            panel4.Location = new Point(9, 242);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(291, 5);
            panel4.TabIndex = 82;
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1176, 997);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderForm1";
            Load += SalesOrder_Load;
            ((System.ComponentModel.ISupportInitialize)productOfOrderdata).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatarbox).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView productOfOrderdata;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button createOrderbtn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn productIDColumn;
        private DataGridViewTextBoxColumn productNameColumn;
        private DataGridViewTextBoxColumn quantityColumn;
        private DataGridViewTextBoxColumn unitPriceColumn;
        private Panel panel1;
        private Label label7;
        private Label ordertotallbl;
        private Label label10;
        private DateTimePicker orderDateBox;
        private Label label1;
        private Label label11;
        private Label label12;
        private Label label5;
        private Label label8;
        private TextBox dealerCompanyBox;
        private Label label14;
        private Label label13;
        private ComboBox comboBox1;
        private Label dealerNameBox1;
        private Label dealerIDBox1;
        private Panel InvoiceLine1;
        private Panel panel2;
        private TextBox textBox1;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Label CustomerName;
        private Label label4;
        private PictureBox avatarbox;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Panel panel6;
        private Label goodsAddressBox;
        private Label invoiceAddressBox;
        private TextBox dealerinfoBox;
        private TextBox phoneNumBox;
        private TextBox dealerNameBox;
        private TextBox dealerIDBox;
        private ComboBox comboBox2;
        private Label orderlbl;
        private TextBox orderContactNamebox;
        private Label label6;
        private TextBox OrderContactPhonebox;
        private TextBox orderEmailAddressbox;
        private Label label15;
        private ProgramMethod.ProgramMethod.RoundedTextBox productSearchbox;
    }
}