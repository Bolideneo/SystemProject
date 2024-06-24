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
            productSearchbox = new TextBox();
            panel1 = new Panel();
            dealerIDBox = new TextBox();
            dealerNameBox = new TextBox();
            comboBox1 = new ComboBox();
            panel5 = new Panel();
            dealerinfoBox = new TextBox();
            pictureBox1 = new PictureBox();
            InvoiceLine1 = new Panel();
            phoneNumBox = new TextBox();
            dealerCompanyBox = new TextBox();
            dealerNameBox1 = new Label();
            dealerIDBox1 = new Label();
            label12 = new Label();
            orderDateBox = new DateTimePicker();
            ordertotallbl = new Label();
            label9 = new Label();
            label8 = new Label();
            label10 = new Label();
            label7 = new Label();
            label1 = new Label();
            label11 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            label14 = new Label();
            label13 = new Label();
            panel3 = new Panel();
            invoiceAddressBox = new Label();
            panel6 = new Panel();
            goodsAddressBox = new Label();
            avatarbox = new PictureBox();
            panel4 = new Panel();
            CustomerName = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)productOfOrderdata).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatarbox).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(964, -2);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 38);
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
            label3.Location = new Point(30, 16);
            label3.Name = "label3";
            label3.Size = new Size(148, 30);
            label3.TabIndex = 16;
            label3.Text = "Create Order";
            // 
            // productOfOrderdata
            // 
            productOfOrderdata.AllowUserToAddRows = false;
            productOfOrderdata.AllowUserToDeleteRows = false;
            productOfOrderdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productOfOrderdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productOfOrderdata.Location = new Point(21, 372);
            productOfOrderdata.Margin = new Padding(3, 4, 3, 4);
            productOfOrderdata.Name = "productOfOrderdata";
            productOfOrderdata.RowHeadersWidth = 51;
            productOfOrderdata.RowTemplate.Height = 24;
            productOfOrderdata.Size = new Size(630, 218);
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
            createOrderbtn.Location = new Point(484, 602);
            createOrderbtn.Name = "createOrderbtn";
            createOrderbtn.Size = new Size(150, 40);
            createOrderbtn.TabIndex = 68;
            createOrderbtn.Text = "Create";
            createOrderbtn.UseVisualStyleBackColor = true;
            createOrderbtn.Click += createOrderbtn_Click;
            // 
            // productSearchbox
            // 
            productSearchbox.BackColor = SystemColors.ButtonFace;
            productSearchbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productSearchbox.Location = new Point(55, 312);
            productSearchbox.Margin = new Padding(5);
            productSearchbox.MaximumSize = new Size(263, 60);
            productSearchbox.Name = "productSearchbox";
            productSearchbox.PlaceholderText = "Search Product ID or Name";
            productSearchbox.Size = new Size(233, 23);
            productSearchbox.TabIndex = 48;
            productSearchbox.TextChanged += productSearchbox_TextChanged;
            productSearchbox.KeyDown += productSearchbox_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dealerIDBox);
            panel1.Controls.Add(dealerNameBox);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(InvoiceLine1);
            panel1.Controls.Add(phoneNumBox);
            panel1.Controls.Add(dealerCompanyBox);
            panel1.Controls.Add(createOrderbtn);
            panel1.Controls.Add(dealerNameBox1);
            panel1.Controls.Add(dealerIDBox1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(orderDateBox);
            panel1.Controls.Add(ordertotallbl);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(productSearchbox);
            panel1.Controls.Add(productOfOrderdata);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(30, 66);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 671);
            panel1.TabIndex = 72;
            panel1.Paint += panel1_Paint;
            // 
            // dealerIDBox
            // 
            dealerIDBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerIDBox.Location = new Point(213, 85);
            dealerIDBox.Margin = new Padding(4, 0, 4, 0);
            dealerIDBox.Name = "dealerIDBox";
            dealerIDBox.Size = new Size(100, 23);
            dealerIDBox.TabIndex = 87;
            dealerIDBox.Text = "textBox2";
            // 
            // dealerNameBox
            // 
            dealerNameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerNameBox.Location = new Point(213, 116);
            dealerNameBox.Margin = new Padding(4, 0, 4, 0);
            dealerNameBox.Name = "dealerNameBox";
            dealerNameBox.Size = new Size(100, 23);
            dealerNameBox.TabIndex = 86;
            dealerNameBox.Text = "textBox2";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(212, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 23);
            comboBox1.TabIndex = 77;
            comboBox1.TextChanged += comboBox1_TextChanged;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.Controls.Add(dealerinfoBox);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(216, 53);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(224, 27);
            panel5.TabIndex = 85;
            // 
            // dealerinfoBox
            // 
            dealerinfoBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            dealerinfoBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            dealerinfoBox.BorderStyle = BorderStyle.None;
            dealerinfoBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerinfoBox.Location = new Point(1, 6);
            dealerinfoBox.Margin = new Padding(5);
            dealerinfoBox.Name = "dealerinfoBox";
            dealerinfoBox.Size = new Size(218, 16);
            dealerinfoBox.TabIndex = 86;
            dealerinfoBox.TextChanged += dealerinfoBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(189, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 20);
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
            InvoiceLine1.Location = new Point(108, 277);
            InvoiceLine1.Name = "InvoiceLine1";
            InvoiceLine1.Size = new Size(443, 5);
            InvoiceLine1.TabIndex = 81;
            // 
            // phoneNumBox
            // 
            phoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumBox.Location = new Point(213, 151);
            phoneNumBox.Margin = new Padding(4, 0, 4, 0);
            phoneNumBox.Name = "phoneNumBox";
            phoneNumBox.Size = new Size(100, 23);
            phoneNumBox.TabIndex = 80;
            phoneNumBox.Text = "phoneNumBox";
            // 
            // dealerCompanyBox
            // 
            dealerCompanyBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerCompanyBox.Location = new Point(211, 183);
            dealerCompanyBox.Margin = new Padding(4, 0, 4, 0);
            dealerCompanyBox.Name = "dealerCompanyBox";
            dealerCompanyBox.Size = new Size(130, 23);
            dealerCompanyBox.TabIndex = 82;
            dealerCompanyBox.Text = "dealerCompanyBox";
            // 
            // dealerNameBox1
            // 
            dealerNameBox1.AutoSize = true;
            dealerNameBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerNameBox1.Location = new Point(443, 119);
            dealerNameBox1.Margin = new Padding(6, 7, 6, 7);
            dealerNameBox1.Name = "dealerNameBox1";
            dealerNameBox1.Size = new Size(108, 17);
            dealerNameBox1.TabIndex = 44;
            dealerNameBox1.Text = "dealerNameBox";
            // 
            // dealerIDBox1
            // 
            dealerIDBox1.AutoSize = true;
            dealerIDBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerIDBox1.ForeColor = Color.Black;
            dealerIDBox1.Location = new Point(522, 78);
            dealerIDBox1.Margin = new Padding(6, 7, 6, 7);
            dealerIDBox1.Name = "dealerIDBox1";
            dealerIDBox1.Size = new Size(84, 17);
            dealerIDBox1.TabIndex = 43;
            dealerIDBox1.Text = "dealerIDBox";
            dealerIDBox1.KeyDown += dealerIDBox_KeyDown;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkOrange;
            label12.Location = new Point(46, 221);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(150, 17);
            label12.TabIndex = 65;
            label12.Text = "Order Complete Date :";
            label12.Visible = false;
            // 
            // orderDateBox
            // 
            orderDateBox.Location = new Point(213, 217);
            orderDateBox.Margin = new Padding(3, 2, 3, 2);
            orderDateBox.MinDate = new DateTime(2010, 7, 27, 0, 0, 0, 0);
            orderDateBox.Name = "orderDateBox";
            orderDateBox.Size = new Size(250, 23);
            orderDateBox.TabIndex = 70;
            orderDateBox.Visible = false;
            // 
            // ordertotallbl
            // 
            ordertotallbl.AutoSize = true;
            ordertotallbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordertotallbl.Location = new Point(34, 606);
            ordertotallbl.Name = "ordertotallbl";
            ordertotallbl.Size = new Size(89, 21);
            ordertotallbl.TabIndex = 73;
            ordertotallbl.Text = "Total: CN¥0";
            ordertotallbl.TextChanged += ordertotallbl_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.WindowText;
            label9.Location = new Point(10, 11);
            label9.Name = "label9";
            label9.Size = new Size(122, 24);
            label9.TabIndex = 74;
            label9.Text = "Order Detail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkOrange;
            label8.Location = new Point(55, 182);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(143, 18);
            label8.TabIndex = 60;
            label8.Text = "Dealer Company :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkOrange;
            label10.Location = new Point(82, 53);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(127, 18);
            label10.TabIndex = 74;
            label10.Text = " * Dealer Info :  ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Window;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(307, 318);
            label7.Name = "label7";
            label7.Size = new Size(288, 38);
            label7.TabIndex = 72;
            label7.Text = "Left click Quantity column to change quantity\r\nDouble click Cell to remove unwant product\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(108, 87);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 18);
            label1.TabIndex = 44;
            label1.Text = "Dealer ID :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkOrange;
            label11.Location = new Point(82, 118);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(116, 18);
            label11.TabIndex = 54;
            label11.Text = "Dealer Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(68, 151);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 18);
            label5.TabIndex = 48;
            label5.Text = "Phone Number :";
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(717, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 161);
            panel2.TabIndex = 83;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(15, 53);
            textBox1.Margin = new Padding(5);
            textBox1.MaximumSize = new Size(263, 60);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search customer";
            textBox1.Size = new Size(248, 23);
            textBox1.TabIndex = 82;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(13, 15);
            label2.Name = "label2";
            label2.Size = new Size(200, 20);
            label2.TabIndex = 82;
            label2.Text = "Find or create customer";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(27, 343);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(137, 20);
            label14.TabIndex = 87;
            label14.Text = "Invoice Address";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(25, 169);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(201, 20);
            label13.TabIndex = 85;
            label13.Text = "Goods Delivery Address";
            // 
            // panel3
            // 
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(invoiceAddressBox);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(goodsAddressBox);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(avatarbox);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(CustomerName);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(717, 233);
            panel3.Name = "panel3";
            panel3.Size = new Size(282, 504);
            panel3.TabIndex = 84;
            // 
            // invoiceAddressBox
            // 
            invoiceAddressBox.AutoSize = true;
            invoiceAddressBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invoiceAddressBox.Location = new Point(28, 386);
            invoiceAddressBox.Margin = new Padding(4, 0, 4, 0);
            invoiceAddressBox.Name = "invoiceAddressBox";
            invoiceAddressBox.Size = new Size(134, 18);
            invoiceAddressBox.TabIndex = 88;
            invoiceAddressBox.Text = "invoiceAddressBox";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDark;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.ForeColor = SystemColors.ControlText;
            panel6.Location = new Point(14, 315);
            panel6.Name = "panel6";
            panel6.Size = new Size(255, 5);
            panel6.TabIndex = 83;
            // 
            // goodsAddressBox
            // 
            goodsAddressBox.AutoSize = true;
            goodsAddressBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goodsAddressBox.Location = new Point(27, 206);
            goodsAddressBox.Margin = new Padding(4, 0, 4, 0);
            goodsAddressBox.Name = "goodsAddressBox";
            goodsAddressBox.Size = new Size(130, 18);
            goodsAddressBox.TabIndex = 86;
            goodsAddressBox.Text = "goodsAddressBox";
            // 
            // avatarbox
            // 
            avatarbox.BackgroundImage = (Image)resources.GetObject("avatarbox.BackgroundImage");
            avatarbox.BackgroundImageLayout = ImageLayout.Stretch;
            avatarbox.BorderStyle = BorderStyle.Fixed3D;
            avatarbox.Location = new Point(25, 54);
            avatarbox.Name = "avatarbox";
            avatarbox.Size = new Size(51, 41);
            avatarbox.TabIndex = 84;
            avatarbox.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.ForeColor = SystemColors.ControlText;
            panel4.Location = new Point(12, 145);
            panel4.Name = "panel4";
            panel4.Size = new Size(255, 5);
            panel4.TabIndex = 82;
            // 
            // CustomerName
            // 
            CustomerName.AutoSize = true;
            CustomerName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerName.Location = new Point(25, 110);
            CustomerName.Margin = new Padding(4, 0, 4, 0);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(105, 17);
            CustomerName.TabIndex = 82;
            CustomerName.Text = "CustomerName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(14, 15);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 83;
            label4.Text = "Customer Info";
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1029, 748);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatarbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView productOfOrderdata;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button createOrderbtn;
        private TextBox productSearchbox;
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
    }
}