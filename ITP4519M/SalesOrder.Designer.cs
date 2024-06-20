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
            orderLabel = new Label();
            label11 = new Label();
            dealerNameBox = new TextBox();
            label10 = new Label();
            invoiceAddressBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            goodsAddressBox = new TextBox();
            label1 = new Label();
            dealerIDBox = new TextBox();
            label8 = new Label();
            dealerCompanyBox = new TextBox();
            productOfOrderdata = new DataGridView();
            productIDColumn = new DataGridViewTextBoxColumn();
            productNameColumn = new DataGridViewTextBoxColumn();
            quantityColumn = new DataGridViewTextBoxColumn();
            unitPriceColumn = new DataGridViewTextBoxColumn();
            label12 = new Label();
            orderCompleteDateBox = new TextBox();
            phoneNumBox = new TextBox();
            saveOrderbtn = new Button();
            productSearchbox = new TextBox();
            label6 = new Label();
            label9 = new Label();
            orderStatuslbl = new Label();
            ordertotallbl = new Label();
            orderStatusLabel = new Label();
            orderStatusBox = new TextBox();
            label3 = new Label();
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
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderLabel.ForeColor = SystemColors.WindowText;
            orderLabel.Location = new Point(18, 16);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(74, 30);
            orderLabel.TabIndex = 16;
            orderLabel.Text = "Order";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(262, 172);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(95, 18);
            label11.TabIndex = 54;
            label11.Text = "Dealer Name";
            // 
            // dealerNameBox
            // 
            dealerNameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerNameBox.Location = new Point(262, 194);
            dealerNameBox.Margin = new Padding(4);
            dealerNameBox.Name = "dealerNameBox";
            dealerNameBox.Size = new Size(164, 23);
            dealerNameBox.TabIndex = 53;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(18, 603);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(112, 18);
            label10.TabIndex = 52;
            label10.Text = "Invoice Address";
            // 
            // invoiceAddressBox
            // 
            invoiceAddressBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invoiceAddressBox.Location = new Point(18, 625);
            invoiceAddressBox.Margin = new Padding(4);
            invoiceAddressBox.Name = "invoiceAddressBox";
            invoiceAddressBox.Size = new Size(553, 23);
            invoiceAddressBox.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 236);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 18);
            label5.TabIndex = 48;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 545);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 18);
            label4.TabIndex = 46;
            label4.Text = "Goods Delivery Address";
            // 
            // goodsAddressBox
            // 
            goodsAddressBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goodsAddressBox.Location = new Point(17, 567);
            goodsAddressBox.Margin = new Padding(4);
            goodsAddressBox.Name = "goodsAddressBox";
            goodsAddressBox.Size = new Size(554, 23);
            goodsAddressBox.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 172);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 44;
            label1.Text = "Dealer ID";
            // 
            // dealerIDBox
            // 
            dealerIDBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerIDBox.Location = new Point(23, 194);
            dealerIDBox.Margin = new Padding(4);
            dealerIDBox.Name = "dealerIDBox";
            dealerIDBox.Size = new Size(164, 23);
            dealerIDBox.TabIndex = 43;
            dealerIDBox.KeyDown += dealerIDBox_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(262, 230);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(119, 18);
            label8.TabIndex = 60;
            label8.Text = "Dealer Company";
            // 
            // dealerCompanyBox
            // 
            dealerCompanyBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerCompanyBox.Location = new Point(262, 258);
            dealerCompanyBox.Margin = new Padding(4);
            dealerCompanyBox.Name = "dealerCompanyBox";
            dealerCompanyBox.Size = new Size(235, 23);
            dealerCompanyBox.TabIndex = 59;
            // 
            // productOfOrderdata
            // 
            productOfOrderdata.AllowUserToAddRows = false;
            productOfOrderdata.AllowUserToDeleteRows = false;
            productOfOrderdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productOfOrderdata.BackgroundColor = SystemColors.ButtonFace;
            productOfOrderdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productOfOrderdata.Location = new Point(22, 368);
            productOfOrderdata.Margin = new Padding(3, 4, 3, 4);
            productOfOrderdata.Name = "productOfOrderdata";
            productOfOrderdata.RowHeadersWidth = 51;
            productOfOrderdata.RowTemplate.Height = 24;
            productOfOrderdata.Size = new Size(558, 165);
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(25, 109);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(149, 18);
            label12.TabIndex = 65;
            label12.Text = "Order Complete Date";
            label12.Visible = false;
            // 
            // orderCompleteDateBox
            // 
            orderCompleteDateBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderCompleteDateBox.Location = new Point(25, 130);
            orderCompleteDateBox.Margin = new Padding(4);
            orderCompleteDateBox.Name = "orderCompleteDateBox";
            orderCompleteDateBox.Size = new Size(204, 23);
            orderCompleteDateBox.TabIndex = 64;
            orderCompleteDateBox.Visible = false;
            // 
            // phoneNumBox
            // 
            phoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumBox.Location = new Point(22, 258);
            phoneNumBox.Margin = new Padding(4);
            phoneNumBox.Name = "phoneNumBox";
            phoneNumBox.Size = new Size(164, 23);
            phoneNumBox.TabIndex = 66;
            // 
            // saveOrderbtn
            // 
            saveOrderbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveOrderbtn.Location = new Point(437, 677);
            saveOrderbtn.Name = "saveOrderbtn";
            saveOrderbtn.Size = new Size(150, 40);
            saveOrderbtn.TabIndex = 71;
            saveOrderbtn.Text = "Save";
            saveOrderbtn.UseVisualStyleBackColor = true;
            saveOrderbtn.Click += saveOrderbtn_Click;
            // 
            // productSearchbox
            // 
            productSearchbox.BackColor = SystemColors.ButtonFace;
            productSearchbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productSearchbox.Location = new Point(25, 325);
            productSearchbox.Margin = new Padding(4);
            productSearchbox.MaximumSize = new Size(231, 60);
            productSearchbox.Name = "productSearchbox";
            productSearchbox.PlaceholderText = "Search Product ID or Name";
            productSearchbox.Size = new Size(224, 23);
            productSearchbox.TabIndex = 72;
            productSearchbox.KeyDown += productSearchbox_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(262, 307);
            label6.Name = "label6";
            label6.Size = new Size(361, 19);
            label6.TabIndex = 73;
            label6.Text = "Left-click on the Quantity column to change the quantity.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(262, 329);
            label9.Name = "label9";
            label9.Size = new Size(362, 19);
            label9.TabIndex = 74;
            label9.Text = "Double-click on the cell to remove the unwanted product.";
            // 
            // orderStatuslbl
            // 
            orderStatuslbl.AutoSize = true;
            orderStatuslbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderStatuslbl.ForeColor = Color.Brown;
            orderStatuslbl.Location = new Point(23, 291);
            orderStatuslbl.Name = "orderStatuslbl";
            orderStatuslbl.Size = new Size(116, 25);
            orderStatuslbl.TabIndex = 75;
            orderStatuslbl.Text = "Order Status";
            // 
            // ordertotallbl
            // 
            ordertotallbl.AutoSize = true;
            ordertotallbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordertotallbl.Location = new Point(17, 670);
            ordertotallbl.Name = "ordertotallbl";
            ordertotallbl.Size = new Size(108, 25);
            ordertotallbl.TabIndex = 76;
            ordertotallbl.Text = "Total Price: ";
            // 
            // orderStatusLabel
            // 
            orderStatusLabel.AutoSize = true;
            orderStatusLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderStatusLabel.ForeColor = Color.Black;
            orderStatusLabel.Location = new Point(24, 58);
            orderStatusLabel.Name = "orderStatusLabel";
            orderStatusLabel.Size = new Size(102, 21);
            orderStatusLabel.TabIndex = 77;
            orderStatusLabel.Text = "Order Status";
            // 
            // orderStatusBox
            // 
            orderStatusBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderStatusBox.Location = new Point(262, 130);
            orderStatusBox.Margin = new Padding(4);
            orderStatusBox.Name = "orderStatusBox";
            orderStatusBox.Size = new Size(164, 23);
            orderStatusBox.TabIndex = 78;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(262, 100);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 18);
            label3.TabIndex = 79;
            label3.Text = "Order Status";
            // 
            // SalesOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(621, 740);
            Controls.Add(label3);
            Controls.Add(orderStatusBox);
            Controls.Add(orderStatusLabel);
            Controls.Add(ordertotallbl);
            Controls.Add(orderStatuslbl);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(productSearchbox);
            Controls.Add(saveOrderbtn);
            Controls.Add(goodsAddressBox);
            Controls.Add(invoiceAddressBox);
            Controls.Add(phoneNumBox);
            Controls.Add(label12);
            Controls.Add(orderCompleteDateBox);
            Controls.Add(productOfOrderdata);
            Controls.Add(label8);
            Controls.Add(dealerCompanyBox);
            Controls.Add(label11);
            Controls.Add(dealerNameBox);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dealerIDBox);
            Controls.Add(orderLabel);
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
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dealerNameBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox invoiceAddressBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox goodsAddressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dealerIDBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dealerCompanyBox;
        private System.Windows.Forms.DataGridView productOfOrderdata;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox orderCompleteDateBox;
        private System.Windows.Forms.TextBox phoneNumBox;
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
        private Button saveOrderbtn;
        private TextBox productSearchbox;
        private Label label6;
        private Label orderStatuslbl;
        private Label ordertotallbl;
        private Label orderStatusLabel;
        private TextBox orderStatusBox;
        private Label label3;
    }
}