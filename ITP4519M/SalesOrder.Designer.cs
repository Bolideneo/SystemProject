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
            productIDColumn = new DataGridViewTextBoxColumn();
            productNameColumn = new DataGridViewTextBoxColumn();
            quantityColumn = new DataGridViewTextBoxColumn();
            unitPriceColumn = new DataGridViewTextBoxColumn();
            orderDateBox = new TextBox();
            label12 = new Label();
            orderCompleteDateBox = new TextBox();
            phoneNumBox = new TextBox();
            label13 = new Label();
            saveOrderbtn = new Button();
            productSearchbox = new TextBox();
            label6 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)productOfOrderdata).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(630, 9);
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
            label3.Location = new Point(11, 11);
            label3.Name = "label3";
            label3.Size = new Size(264, 38);
            label3.TabIndex = 16;
            label3.Text = "Sales Order Details";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(247, 251);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(108, 20);
            label11.TabIndex = 54;
            label11.Text = "Dealer Name";
            // 
            // dealerNameBox
            // 
            dealerNameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerNameBox.Location = new Point(247, 289);
            dealerNameBox.Margin = new Padding(6, 7, 6, 7);
            dealerNameBox.Name = "dealerNameBox";
            dealerNameBox.Size = new Size(187, 27);
            dealerNameBox.TabIndex = 53;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(19, 759);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(128, 20);
            label10.TabIndex = 52;
            label10.Text = "Invoice Address";
            // 
            // invoiceAddressBox
            // 
            invoiceAddressBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invoiceAddressBox.Location = new Point(19, 800);
            invoiceAddressBox.Margin = new Padding(6, 7, 6, 7);
            invoiceAddressBox.Name = "invoiceAddressBox";
            invoiceAddressBox.Size = new Size(631, 27);
            invoiceAddressBox.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 333);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 48;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 687);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(191, 20);
            label4.TabIndex = 46;
            label4.Text = "Goods Delivery Address";
            // 
            // goodsAddressBox
            // 
            goodsAddressBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goodsAddressBox.Location = new Point(22, 714);
            goodsAddressBox.Margin = new Padding(6, 7, 6, 7);
            goodsAddressBox.Name = "goodsAddressBox";
            goodsAddressBox.Size = new Size(633, 27);
            goodsAddressBox.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 251);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 44;
            label1.Text = "Dealer ID";
            // 
            // dealerIDBox
            // 
            dealerIDBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerIDBox.Location = new Point(24, 289);
            dealerIDBox.Margin = new Padding(6, 7, 6, 7);
            dealerIDBox.Name = "dealerIDBox";
            dealerIDBox.Size = new Size(187, 27);
            dealerIDBox.TabIndex = 43;
            dealerIDBox.KeyDown += dealerIDBox_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 81);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 42;
            label2.Text = "Order ID";
            // 
            // orderIDBox
            // 
            orderIDBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderIDBox.Location = new Point(19, 108);
            orderIDBox.Margin = new Padding(6, 7, 6, 7);
            orderIDBox.Name = "orderIDBox";
            orderIDBox.Size = new Size(185, 27);
            orderIDBox.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(247, 81);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 58;
            label7.Text = "Order Status";
            // 
            // orderStatusBox
            // 
            orderStatusBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderStatusBox.Location = new Point(247, 108);
            orderStatusBox.Margin = new Padding(6, 7, 6, 7);
            orderStatusBox.Name = "orderStatusBox";
            orderStatusBox.Size = new Size(138, 27);
            orderStatusBox.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(251, 333);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 60;
            label8.Text = "Dealer Company";
            // 
            // dealerCompanyBox
            // 
            dealerCompanyBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerCompanyBox.Location = new Point(251, 376);
            dealerCompanyBox.Margin = new Padding(6, 7, 6, 7);
            dealerCompanyBox.Name = "dealerCompanyBox";
            dealerCompanyBox.Size = new Size(268, 27);
            dealerCompanyBox.TabIndex = 59;
            // 
            // productOfOrderdata
            // 
            productOfOrderdata.AllowUserToAddRows = false;
            productOfOrderdata.AllowUserToDeleteRows = false;
            productOfOrderdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productOfOrderdata.BackgroundColor = SystemColors.ButtonFace;
            productOfOrderdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productOfOrderdata.Location = new Point(18, 486);
            productOfOrderdata.Margin = new Padding(3, 5, 3, 5);
            productOfOrderdata.Name = "productOfOrderdata";
            productOfOrderdata.RowHeadersWidth = 51;
            productOfOrderdata.RowTemplate.Height = 24;
            productOfOrderdata.Size = new Size(638, 180);
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
            // orderDateBox
            // 
            orderDateBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderDateBox.Location = new Point(247, 203);
            orderDateBox.Margin = new Padding(6, 7, 6, 7);
            orderDateBox.Name = "orderDateBox";
            orderDateBox.Size = new Size(185, 27);
            orderDateBox.TabIndex = 62;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(22, 163);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(169, 20);
            label12.TabIndex = 65;
            label12.Text = "Order Complete Date";
            // 
            // orderCompleteDateBox
            // 
            orderCompleteDateBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderCompleteDateBox.Location = new Point(19, 203);
            orderCompleteDateBox.Margin = new Padding(6, 7, 6, 7);
            orderCompleteDateBox.Name = "orderCompleteDateBox";
            orderCompleteDateBox.Size = new Size(185, 27);
            orderCompleteDateBox.TabIndex = 64;
            // 
            // phoneNumBox
            // 
            phoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumBox.Location = new Point(24, 376);
            phoneNumBox.Margin = new Padding(6, 7, 6, 7);
            phoneNumBox.Name = "phoneNumBox";
            phoneNumBox.Size = new Size(187, 27);
            phoneNumBox.TabIndex = 66;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(247, 163);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(93, 20);
            label13.TabIndex = 70;
            label13.Text = "Order Date";
            label13.Click += label13_Click;
            // 
            // saveOrderbtn
            // 
            saveOrderbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveOrderbtn.Location = new Point(485, 859);
            saveOrderbtn.Margin = new Padding(3, 4, 3, 4);
            saveOrderbtn.Name = "saveOrderbtn";
            saveOrderbtn.Size = new Size(171, 53);
            saveOrderbtn.TabIndex = 71;
            saveOrderbtn.Text = "Save";
            saveOrderbtn.UseVisualStyleBackColor = true;
            saveOrderbtn.Click += saveOrderbtn_Click;
            // 
            // productSearchbox
            // 
            productSearchbox.BackColor = SystemColors.ButtonFace;
            productSearchbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productSearchbox.Location = new Point(24, 425);
            productSearchbox.Margin = new Padding(6, 7, 6, 7);
            productSearchbox.MaximumSize = new Size(300, 60);
            productSearchbox.Name = "productSearchbox";
            productSearchbox.PlaceholderText = "Search Product ID or Name";
            productSearchbox.Size = new Size(255, 49);
            productSearchbox.TabIndex = 72;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(303, 425);
            label6.Name = "label6";
            label6.Size = new Size(358, 23);
            label6.TabIndex = 73;
            label6.Text = "Left click Quantity column to change quantity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(310, 451);
            label9.Name = "label9";
            label9.Size = new Size(345, 23);
            label9.TabIndex = 74;
            label9.Text = "Double click Cell to remove unwant product";
            // 
            // SalesOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(673, 925);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(productSearchbox);
            Controls.Add(saveOrderbtn);
            Controls.Add(goodsAddressBox);
            Controls.Add(invoiceAddressBox);
            Controls.Add(label13);
            Controls.Add(phoneNumBox);
            Controls.Add(label12);
            Controls.Add(orderCompleteDateBox);
            Controls.Add(orderDateBox);
            Controls.Add(productOfOrderdata);
            Controls.Add(label8);
            Controls.Add(dealerCompanyBox);
            Controls.Add(label7);
            Controls.Add(orderStatusBox);
            Controls.Add(label11);
            Controls.Add(dealerNameBox);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dealerIDBox);
            Controls.Add(label2);
            Controls.Add(orderIDBox);
            Controls.Add(label3);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label13;
        private Button saveOrderbtn;
        private TextBox productSearchbox;
        private Label label6;
    }
}