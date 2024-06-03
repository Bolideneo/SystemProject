namespace ITP4519M
{
    partial class SalesOrder
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
            CloseButton = new Button();
            label3 = new Label();
            label11 = new Label();
            dealerNameBox = new TextBox();
            label10 = new Label();
            invoiceAddressBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            goodsAddressBox = new TextBox();
            label1 = new Label();
            dealerIDBox = new TextBox();
            label2 = new Label();
            orderIDBox = new TextBox();
            label7 = new Label();
            orderStatusBox = new TextBox();
            label8 = new Label();
            dealerCompanyBox = new TextBox();
            productOfOrderdata = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            orderDateBox = new TextBox();
            label12 = new Label();
            orderCompleteDateBox = new TextBox();
            phoneNumBox = new TextBox();
            createOrderbtn = new Button();
            productSearchbox = new TextBox();
            productpricebox = new TextBox();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)productOfOrderdata).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(551, 7);
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
            label3.Location = new Point(10, 8);
            label3.Name = "label3";
            label3.Size = new Size(209, 30);
            label3.TabIndex = 16;
            label3.Text = "Sales Order Details";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(216, 188);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(91, 17);
            label11.TabIndex = 54;
            label11.Text = "Dealer Name";
            // 
            // dealerNameBox
            // 
            dealerNameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerNameBox.Location = new Point(219, 210);
            dealerNameBox.Margin = new Padding(4);
            dealerNameBox.Name = "dealerNameBox";
            dealerNameBox.Size = new Size(164, 23);
            dealerNameBox.TabIndex = 53;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(25, 565);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(108, 17);
            label10.TabIndex = 52;
            label10.Text = "Invoice Address";
            // 
            // invoiceAddressBox
            // 
            invoiceAddressBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invoiceAddressBox.Location = new Point(25, 598);
            invoiceAddressBox.Margin = new Padding(4);
            invoiceAddressBox.Name = "invoiceAddressBox";
            invoiceAddressBox.Size = new Size(553, 23);
            invoiceAddressBox.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 306);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 49;
            label6.Text = "Products";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 250);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 17);
            label5.TabIndex = 48;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 501);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(161, 17);
            label4.TabIndex = 46;
            label4.Text = "Goods Delivery Address";
            // 
            // goodsAddressBox
            // 
            goodsAddressBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goodsAddressBox.Location = new Point(20, 531);
            goodsAddressBox.Margin = new Padding(4);
            goodsAddressBox.Name = "goodsAddressBox";
            goodsAddressBox.Size = new Size(554, 23);
            goodsAddressBox.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 188);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 44;
            label1.Text = "Dealer ID";
            // 
            // dealerIDBox
            // 
            dealerIDBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerIDBox.Location = new Point(17, 210);
            dealerIDBox.Margin = new Padding(4);
            dealerIDBox.Name = "dealerIDBox";
            dealerIDBox.Size = new Size(164, 23);
            dealerIDBox.TabIndex = 43;
            dealerIDBox.KeyDown += dealerIDBox_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 61);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 42;
            label2.Text = "Order ID";
            // 
            // orderIDBox
            // 
            orderIDBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderIDBox.Location = new Point(18, 83);
            orderIDBox.Margin = new Padding(4);
            orderIDBox.Name = "orderIDBox";
            orderIDBox.Size = new Size(162, 23);
            orderIDBox.TabIndex = 41;
            orderIDBox.TextChanged += orderIDBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(216, 61);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 17);
            label7.TabIndex = 58;
            label7.Text = "Order Status";
            // 
            // orderStatusBox
            // 
            orderStatusBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderStatusBox.Location = new Point(217, 83);
            orderStatusBox.Margin = new Padding(4);
            orderStatusBox.Name = "orderStatusBox";
            orderStatusBox.Size = new Size(121, 23);
            orderStatusBox.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(220, 250);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(113, 17);
            label8.TabIndex = 60;
            label8.Text = "Dealer Company";
            // 
            // dealerCompanyBox
            // 
            dealerCompanyBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerCompanyBox.Location = new Point(217, 273);
            dealerCompanyBox.Margin = new Padding(4);
            dealerCompanyBox.Name = "dealerCompanyBox";
            dealerCompanyBox.Size = new Size(235, 23);
            dealerCompanyBox.TabIndex = 59;
            // 
            // productOfOrderdata
            // 
            productOfOrderdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productOfOrderdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productOfOrderdata.AllowUserToAddRows = false;
            productOfOrderdata.Columns.AddRange(new DataGridViewColumn[] { new DataGridViewTextBoxColumn() { HeaderText = "Product ID", Name = "ProductID" }, new DataGridViewTextBoxColumn() { HeaderText = "Product Name", Name = "ProductName" }, new DataGridViewTextBoxColumn() { HeaderText = "Quantity", Name = "Quantity" }, new DataGridViewTextBoxColumn() { HeaderText = "Unit Price", Name = "UnitPrice" } });
            productOfOrderdata.Location = new Point(16, 332);
            productOfOrderdata.Name = "productOfOrderdata";
            productOfOrderdata.RowHeadersWidth = 51;
            productOfOrderdata.RowTemplate.Height = 24;
            productOfOrderdata.Size = new Size(555, 135);
            productOfOrderdata.TabIndex = 61;
            productOfOrderdata.CellContentDoubleClick += productOfOrderdata_CellContentDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(216, 122);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(79, 17);
            label9.TabIndex = 63;
            label9.Text = "Order Date";
            // 
            // orderDateBox
            // 
            orderDateBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderDateBox.Location = new Point(217, 144);
            orderDateBox.Margin = new Padding(4);
            orderDateBox.Name = "orderDateBox";
            orderDateBox.Size = new Size(162, 23);
            orderDateBox.TabIndex = 62;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(17, 122);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(142, 17);
            label12.TabIndex = 65;
            label12.Text = "Order Complete Date";
            // 
            // orderCompleteDateBox
            // 
            orderCompleteDateBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderCompleteDateBox.Location = new Point(18, 144);
            orderCompleteDateBox.Margin = new Padding(4);
            orderCompleteDateBox.Name = "orderCompleteDateBox";
            orderCompleteDateBox.Size = new Size(162, 23);
            orderCompleteDateBox.TabIndex = 64;
            // 
            // phoneNumBox
            // 
            phoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumBox.Location = new Point(18, 273);
            phoneNumBox.Margin = new Padding(4);
            phoneNumBox.Name = "phoneNumBox";
            phoneNumBox.Size = new Size(164, 23);
            phoneNumBox.TabIndex = 66;
            // 
            // createOrderbtn
            // 
            createOrderbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createOrderbtn.Location = new Point(422, 625);
            createOrderbtn.Name = "createOrderbtn";
            createOrderbtn.Size = new Size(150, 40);
            createOrderbtn.TabIndex = 68;
            createOrderbtn.Text = "Save";
            createOrderbtn.UseVisualStyleBackColor = true;
            createOrderbtn.Click += createOrderbtn_Click;
            // 
            // productSearchbox
            // 
            productSearchbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productSearchbox.Location = new Point(94, 302);
            productSearchbox.Margin = new Padding(4);
            productSearchbox.Name = "productSearchbox";
            productSearchbox.PlaceholderText = "Search";
            productSearchbox.Size = new Size(162, 23);
            productSearchbox.TabIndex = 69;
            productSearchbox.TextChanged += productSearchbox_TextChanged;
            productSearchbox.KeyDown += productSearchbox_KeyDown;
            // 
            // productpricebox
            // 
            productpricebox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productpricebox.Location = new Point(410, 471);
            productpricebox.Margin = new Padding(4);
            productpricebox.Name = "productpricebox";
            productpricebox.PlaceholderText = "Total";
            productpricebox.Size = new Size(162, 23);
            productpricebox.TabIndex = 70;
            // 
            // SalesOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(589, 694);
            Controls.Add(productpricebox);
            Controls.Add(productSearchbox);
            Controls.Add(createOrderbtn);
            Controls.Add(phoneNumBox);
            Controls.Add(label12);
            Controls.Add(orderCompleteDateBox);
            Controls.Add(label9);
            Controls.Add(orderDateBox);
            Controls.Add(productOfOrderdata);
            Controls.Add(label8);
            Controls.Add(dealerCompanyBox);
            Controls.Add(label7);
            Controls.Add(orderStatusBox);
            Controls.Add(label11);
            Controls.Add(dealerNameBox);
            Controls.Add(label10);
            Controls.Add(invoiceAddressBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(goodsAddressBox);
            Controls.Add(label1);
            Controls.Add(dealerIDBox);
            Controls.Add(label2);
            Controls.Add(orderIDBox);
            Controls.Add(label3);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalesOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesOrder";
            Load += SalesOrder_Load;
            ((System.ComponentModel.ISupportInitialize)productOfOrderdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dealerNameBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox invoiceAddressBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox goodsAddressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dealerIDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderIDBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox orderStatusBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dealerCompanyBox;
        private System.Windows.Forms.DataGridView productOfOrderdata;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox orderDateBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox orderCompleteDateBox;
        private System.Windows.Forms.TextBox phoneNumBox;
        private System.Windows.Forms.Button createOrderbtn;
        private TextBox productSearchbox;
        private TextBox productpricebox;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}