using System.Windows.Forms;
using static ProgramMethod.ProgramMethod;

namespace ITP4519M
{
    partial class OrderDetailsForViewAndEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailsForViewAndEdit));
            CloseButton = new Button();
            productOfOrderdata = new DataGridView();
            productIDColumn = new DataGridViewTextBoxColumn();
            productNameColumn = new DataGridViewTextBoxColumn();
            quantityColumn = new DataGridViewTextBoxColumn();
            unitPriceColumn = new DataGridViewTextBoxColumn();
            createOrderbtn = new Button();
            panel1 = new Panel();
            orderstatuslbl = new Label();
            pictureBox3 = new PictureBox();
            productSearchbox = new BorderComboBox();
            label3 = new Label();
            orderDatelbl = new Label();
            usernameAlertBox = new PictureBox();
            dealerInfobox = new BorderComboBox();
            ordertotallbl = new Label();
            label11 = new Label();
            label2 = new Label();
            label1 = new Label();
            usernameAlertlbl = new Label();
            panel7 = new Panel();
            OrderContactPhonebox = new TextBox();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            orderContactNamebox = new TextBox();
            pictureBox1 = new PictureBox();
            orderlbl = new Label();
            label6 = new Label();
            InvoiceLine1 = new Panel();
            label12 = new Label();
            orderDateBox = new BorderDateTimePicker();
            ordertotallbl1 = new Label();
            label10 = new Label();
            label7 = new Label();
            dealerIDBox = new TextBox();
            dealerNameBox = new TextBox();
            phoneNumBox = new TextBox();
            dealerCompanyBox = new TextBox();
            label8 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label16 = new Label();
            orderEmailAddressbox = new TextBox();
            avatarbox = new PictureBox();
            label15 = new Label();
            label4 = new Label();
            CustomerName = new Label();
            label14 = new Label();
            label13 = new Label();
            panel3 = new Panel();
            orderDifferentDeliverybox = new TextBox();
            invoiceAddressBox = new Label();
            panel6 = new Panel();
            goodsAddressBox = new Label();
            panel4 = new Panel();
            orderLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)productOfOrderdata).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usernameAlertBox).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            CloseButton.Location = new Point(1139, 11);
            CloseButton.Margin = new Padding(3, 4, 3, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(40, 51);
            CloseButton.TabIndex = 15;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // productOfOrderdata
            // 
            productOfOrderdata.AllowUserToAddRows = false;
            productOfOrderdata.AllowUserToDeleteRows = false;
            productOfOrderdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productOfOrderdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productOfOrderdata.Location = new Point(24, 465);
            productOfOrderdata.Margin = new Padding(3, 5, 3, 5);
            productOfOrderdata.Name = "productOfOrderdata";
            productOfOrderdata.RowHeadersWidth = 51;
            productOfOrderdata.RowTemplate.Height = 24;
            productOfOrderdata.Size = new Size(746, 353);
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
            createOrderbtn.Location = new Point(599, 832);
            createOrderbtn.Margin = new Padding(3, 4, 3, 4);
            createOrderbtn.Name = "createOrderbtn";
            createOrderbtn.Size = new Size(171, 53);
            createOrderbtn.TabIndex = 68;
            createOrderbtn.Text = "Create";
            createOrderbtn.UseVisualStyleBackColor = true;
            createOrderbtn.Click += createOrderbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(orderstatuslbl);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(productSearchbox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(orderDatelbl);
            panel1.Controls.Add(usernameAlertBox);
            panel1.Controls.Add(dealerInfobox);
            panel1.Controls.Add(ordertotallbl);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(usernameAlertlbl);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(orderlbl);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(InvoiceLine1);
            panel1.Controls.Add(createOrderbtn);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(orderDateBox);
            panel1.Controls.Add(ordertotallbl1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(productOfOrderdata);
            panel1.Location = new Point(34, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 893);
            panel1.TabIndex = 72;
            panel1.Paint += panel1_Paint;
            // 
            // orderstatuslbl
            // 
            orderstatuslbl.AutoSize = true;
            orderstatuslbl.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderstatuslbl.ForeColor = Color.DarkOrange;
            orderstatuslbl.Location = new Point(10, 45);
            orderstatuslbl.Name = "orderstatuslbl";
            orderstatuslbl.Size = new Size(151, 32);
            orderstatuslbl.TabIndex = 111;
            orderstatuslbl.Text = "Order Status";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.red_alert;
            pictureBox3.Location = new Point(718, 388);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 110;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // productSearchbox
            // 
            productSearchbox.AutoCompleteMode = AutoCompleteMode.Suggest;
            productSearchbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            productSearchbox.BorderColor = Color.Black;
            productSearchbox.ForeColor = SystemColors.WindowText;
            productSearchbox.FormattingEnabled = true;
            productSearchbox.Location = new Point(490, 385);
            productSearchbox.Name = "productSearchbox";
            productSearchbox.Size = new Size(281, 28);
            productSearchbox.TabIndex = 109;
            productSearchbox.SelectedIndexChanged += productSearchbox_SelectedIndexChanged;
            productSearchbox.KeyDown += productSearchbox_KeyDown_1;
            productSearchbox.KeyPress += productSearchbox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Menu;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(490, 427);
            label3.Name = "label3";
            label3.Size = new Size(267, 23);
            label3.TabIndex = 108;
            label3.Text = "Please Select at least one product";
            label3.Visible = false;
            // 
            // orderDatelbl
            // 
            orderDatelbl.AutoSize = true;
            orderDatelbl.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderDatelbl.ForeColor = Color.DarkSalmon;
            orderDatelbl.Location = new Point(10, 3);
            orderDatelbl.Name = "orderDatelbl";
            orderDatelbl.Size = new Size(68, 35);
            orderDatelbl.TabIndex = 94;
            orderDatelbl.Text = "Date";
            // 
            // usernameAlertBox
            // 
            usernameAlertBox.Image = Properties.Resources.red_alert;
            usernameAlertBox.Location = new Point(528, 92);
            usernameAlertBox.Name = "usernameAlertBox";
            usernameAlertBox.Size = new Size(26, 23);
            usernameAlertBox.SizeMode = PictureBoxSizeMode.StretchImage;
            usernameAlertBox.TabIndex = 105;
            usernameAlertBox.TabStop = false;
            usernameAlertBox.Visible = false;
            // 
            // dealerInfobox
            // 
            dealerInfobox.AutoCompleteMode = AutoCompleteMode.Suggest;
            dealerInfobox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            dealerInfobox.BorderColor = Color.Black;
            dealerInfobox.ForeColor = SystemColors.WindowText;
            dealerInfobox.FormattingEnabled = true;
            dealerInfobox.Location = new Point(315, 88);
            dealerInfobox.Name = "dealerInfobox";
            dealerInfobox.Size = new Size(263, 28);
            dealerInfobox.TabIndex = 102;
            dealerInfobox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            dealerInfobox.KeyDown += comboBox2_KeyDown;
            dealerInfobox.KeyPress += dealerInfobox_KeyPress;
            // 
            // ordertotallbl
            // 
            ordertotallbl.AutoSize = true;
            ordertotallbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordertotallbl.Location = new Point(130, 824);
            ordertotallbl.Name = "ordertotallbl";
            ordertotallbl.Size = new Size(27, 32);
            ordertotallbl.TabIndex = 100;
            ordertotallbl.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(315, 327);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(165, 20);
            label11.TabIndex = 99;
            label11.Text = "Please select a date.";
            label11.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(315, 256);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(271, 20);
            label2.TabIndex = 98;
            label2.Text = "Please enter a valid phone number.";
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(315, 195);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 20);
            label1.TabIndex = 97;
            label1.Text = "Please enter a valid dealername.";
            label1.Visible = false;
            // 
            // usernameAlertlbl
            // 
            usernameAlertlbl.AutoSize = true;
            usernameAlertlbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameAlertlbl.ForeColor = Color.Red;
            usernameAlertlbl.Location = new Point(315, 121);
            usernameAlertlbl.Margin = new Padding(5, 0, 5, 0);
            usernameAlertlbl.Name = "usernameAlertlbl";
            usernameAlertlbl.Size = new Size(239, 20);
            usernameAlertlbl.TabIndex = 96;
            usernameAlertlbl.Text = "Please enter a valid username.";
            usernameAlertlbl.Visible = false;
            // 
            // panel7
            // 
            panel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel7.BackColor = SystemColors.Window;
            panel7.Controls.Add(OrderContactPhonebox);
            panel7.Controls.Add(pictureBox2);
            panel7.Location = new Point(315, 227);
            panel7.Name = "panel7";
            panel7.Size = new Size(261, 28);
            panel7.TabIndex = 95;
            panel7.Paint += panel7_Paint;
            // 
            // OrderContactPhonebox
            // 
            OrderContactPhonebox.BackColor = SystemColors.Window;
            OrderContactPhonebox.BorderStyle = BorderStyle.None;
            OrderContactPhonebox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderContactPhonebox.Location = new Point(5, 4);
            OrderContactPhonebox.Margin = new Padding(5, 4, 5, 4);
            OrderContactPhonebox.Name = "OrderContactPhonebox";
            OrderContactPhonebox.Size = new Size(181, 20);
            OrderContactPhonebox.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.red_alert;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(233, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 76;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // panel5
            // 
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.BackColor = SystemColors.Window;
            panel5.Controls.Add(orderContactNamebox);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(315, 164);
            panel5.Name = "panel5";
            panel5.Size = new Size(263, 28);
            panel5.TabIndex = 94;
            panel5.Paint += panel5_Paint_1;
            // 
            // orderContactNamebox
            // 
            orderContactNamebox.BackColor = SystemColors.Window;
            orderContactNamebox.BorderStyle = BorderStyle.None;
            orderContactNamebox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderContactNamebox.Location = new Point(5, 4);
            orderContactNamebox.Margin = new Padding(5, 4, 5, 4);
            orderContactNamebox.Name = "orderContactNamebox";
            orderContactNamebox.Size = new Size(181, 20);
            orderContactNamebox.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.red_alert;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(235, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // orderlbl
            // 
            orderlbl.AutoSize = true;
            orderlbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderlbl.ForeColor = Color.Black;
            orderlbl.Location = new Point(130, 228);
            orderlbl.Margin = new Padding(5, 0, 5, 0);
            orderlbl.Name = "orderlbl";
            orderlbl.Size = new Size(173, 24);
            orderlbl.TabIndex = 90;
            orderlbl.Text = "* Contact Phone :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(135, 164);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(167, 24);
            label6.TabIndex = 89;
            label6.Text = "* Contact Name :";
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(25, 295);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(290, 24);
            label12.TabIndex = 65;
            label12.Text = "Order Expect Complete Date :";
            // 
            // orderDateBox
            // 
            orderDateBox.BorderColor = Color.Black;
            orderDateBox.Location = new Point(315, 293);
            orderDateBox.MinDate = new DateTime(2024, 6, 26, 0, 0, 0, 0);
            orderDateBox.Name = "orderDateBox";
            orderDateBox.Size = new Size(269, 27);
            orderDateBox.TabIndex = 70;
            // 
            // ordertotallbl1
            // 
            ordertotallbl1.AutoSize = true;
            ordertotallbl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordertotallbl1.Location = new Point(25, 824);
            ordertotallbl1.Name = "ordertotallbl1";
            ordertotallbl1.Size = new Size(112, 28);
            ordertotallbl1.TabIndex = 73;
            ordertotallbl1.Text = "Total: CNY¥";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(162, 92);
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
            label7.ForeColor = Color.DarkOrange;
            label7.Location = new Point(25, 395);
            label7.Name = "label7";
            label7.Size = new Size(358, 46);
            label7.TabIndex = 72;
            label7.Text = "Left click Quantity column to change quantity\r\nDouble click Cell to remove unwant product\r\n";
            // 
            // dealerIDBox
            // 
            dealerIDBox.BackColor = SystemColors.Menu;
            dealerIDBox.BorderStyle = BorderStyle.None;
            dealerIDBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerIDBox.Location = new Point(135, 79);
            dealerIDBox.Margin = new Padding(5, 0, 5, 0);
            dealerIDBox.Name = "dealerIDBox";
            dealerIDBox.ReadOnly = true;
            dealerIDBox.Size = new Size(114, 20);
            dealerIDBox.TabIndex = 87;
            // 
            // dealerNameBox
            // 
            dealerNameBox.BackColor = SystemColors.Menu;
            dealerNameBox.BorderStyle = BorderStyle.None;
            dealerNameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerNameBox.Location = new Point(135, 125);
            dealerNameBox.Margin = new Padding(5, 0, 5, 0);
            dealerNameBox.Name = "dealerNameBox";
            dealerNameBox.Size = new Size(131, 20);
            dealerNameBox.TabIndex = 86;
            // 
            // phoneNumBox
            // 
            phoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumBox.Location = new Point(11, 149);
            phoneNumBox.Margin = new Padding(5, 0, 5, 0);
            phoneNumBox.Name = "phoneNumBox";
            phoneNumBox.Size = new Size(179, 27);
            phoneNumBox.TabIndex = 80;
            phoneNumBox.Text = "phoneNumBox";
            // 
            // dealerCompanyBox
            // 
            dealerCompanyBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerCompanyBox.Location = new Point(11, 49);
            dealerCompanyBox.Margin = new Padding(5, 0, 5, 0);
            dealerCompanyBox.Name = "dealerCompanyBox";
            dealerCompanyBox.Size = new Size(302, 27);
            dealerCompanyBox.TabIndex = 82;
            dealerCompanyBox.Text = "dealerCompanyBox";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(9, 13);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(157, 24);
            label8.TabIndex = 60;
            label8.Text = "Company  Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(11, 111);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 24);
            label5.TabIndex = 48;
            label5.Text = "Phone Number :";
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label16);
            panel2.Controls.Add(orderEmailAddressbox);
            panel2.Controls.Add(dealerIDBox);
            panel2.Controls.Add(avatarbox);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dealerNameBox);
            panel2.Controls.Add(CustomerName);
            panel2.Location = new Point(819, 88);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 244);
            panel2.TabIndex = 83;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(34, 77);
            label16.Margin = new Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new Size(86, 20);
            label16.TabIndex = 90;
            label16.Text = "Dealer ID:";
            // 
            // orderEmailAddressbox
            // 
            orderEmailAddressbox.BackColor = SystemColors.Menu;
            orderEmailAddressbox.BorderStyle = BorderStyle.None;
            orderEmailAddressbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderEmailAddressbox.Location = new Point(135, 179);
            orderEmailAddressbox.Margin = new Padding(5, 0, 5, 0);
            orderEmailAddressbox.Name = "orderEmailAddressbox";
            orderEmailAddressbox.Size = new Size(179, 20);
            orderEmailAddressbox.TabIndex = 89;
            // 
            // avatarbox
            // 
            avatarbox.BackgroundImage = (Image)resources.GetObject("avatarbox.BackgroundImage");
            avatarbox.BackgroundImageLayout = ImageLayout.Stretch;
            avatarbox.BorderStyle = BorderStyle.Fixed3D;
            avatarbox.Location = new Point(256, 4);
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
            label15.Location = new Point(5, 183);
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
            label4.Location = new Point(18, 16);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 83;
            label4.Text = "Dealer Info";
            // 
            // CustomerName
            // 
            CustomerName.AutoSize = true;
            CustomerName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerName.Location = new Point(11, 129);
            CustomerName.Margin = new Padding(5, 0, 5, 0);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(108, 20);
            CustomerName.TabIndex = 82;
            CustomerName.Text = "DealerName:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(18, 471);
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
            label13.Location = new Point(18, 269);
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
            panel3.Controls.Add(orderDifferentDeliverybox);
            panel3.Controls.Add(invoiceAddressBox);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(phoneNumBox);
            panel3.Controls.Add(goodsAddressBox);
            panel3.Controls.Add(dealerCompanyBox);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(819, 333);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 648);
            panel3.TabIndex = 84;
            // 
            // orderDifferentDeliverybox
            // 
            orderDifferentDeliverybox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderDifferentDeliverybox.Location = new Point(24, 347);
            orderDifferentDeliverybox.Margin = new Padding(5, 0, 5, 0);
            orderDifferentDeliverybox.Name = "orderDifferentDeliverybox";
            orderDifferentDeliverybox.PlaceholderText = "If deferent";
            orderDifferentDeliverybox.Size = new Size(276, 27);
            orderDifferentDeliverybox.TabIndex = 89;
            // 
            // invoiceAddressBox
            // 
            invoiceAddressBox.AutoSize = true;
            invoiceAddressBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invoiceAddressBox.Location = new Point(18, 515);
            invoiceAddressBox.Margin = new Padding(5, 0, 5, 0);
            invoiceAddressBox.Name = "invoiceAddressBox";
            invoiceAddressBox.Size = new Size(130, 24);
            invoiceAddressBox.TabIndex = 88;
            invoiceAddressBox.Text = "                        ";
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
            goodsAddressBox.Location = new Point(24, 309);
            goodsAddressBox.Margin = new Padding(5, 0, 5, 0);
            goodsAddressBox.Name = "goodsAddressBox";
            goodsAddressBox.Size = new Size(140, 24);
            goodsAddressBox.TabIndex = 86;
            goodsAddressBox.Text = "                          ";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.ForeColor = SystemColors.ControlText;
            panel4.Location = new Point(9, 243);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(291, 5);
            panel4.TabIndex = 82;
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderLabel.ForeColor = SystemColors.WindowText;
            orderLabel.Location = new Point(34, 21);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(92, 38);
            orderLabel.TabIndex = 93;
            orderLabel.Text = "Order";
            orderLabel.Click += orderLabel_Click;
            // 
            // OrderDetailsForViewAndEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1187, 1024);
            Controls.Add(orderLabel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderDetailsForViewAndEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderForm1";
            Load += SalesOrder_Load;
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)productOfOrderdata).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)usernameAlertBox).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private System.Windows.Forms.DataGridView productOfOrderdata;
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
        private Label ordertotallbl1;
        private Label label10;
        private BorderDateTimePicker orderDateBox;
        private Label label12;
        private Label label5;
        private Label label8;
        private TextBox dealerCompanyBox;
        private Label label14;
        private Label label13;
        private Panel InvoiceLine1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label CustomerName;
        private Label label4;
        private PictureBox avatarbox;
        private Panel panel6;
        private Label goodsAddressBox;
        private Label invoiceAddressBox;
        private TextBox phoneNumBox;
        private TextBox dealerNameBox;
        private TextBox dealerIDBox;
        private Label orderlbl;
        private Label label6;
        private TextBox orderEmailAddressbox;
        private Label label15;
        private Label label16;
        private TextBox orderDifferentDeliverybox;
        private Panel panel5;
        private TextBox orderContactNamebox;
        private PictureBox pictureBox1;
        private Panel panel7;
        private TextBox OrderContactPhonebox;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Label usernameAlertlbl;
        private Label label11;
        private Label ordertotallbl;
        private BorderComboBox dealerInfobox;
        private PictureBox usernameAlertBox;
        private Label orderLabel;
        private Label orderDatelbl;
        private PictureBox pictureBox3;
        private BorderComboBox productSearchbox;
        private Label label3;
        private Label orderstatuslbl;
    }
}