namespace ITP4519M
{
    partial class CreatePurchaseOrder
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
            button1 = new Button();
            supplierlbl = new Label();
            label4 = new Label();
            supplierBox = new ComboBox();
            supplierProductBox = new ComboBox();
            supplierProductlbl = new Label();
            quanBox = new TextBox();
            quantityBox = new Label();
            totalAmountlbl = new Label();
            amountDatalbl = new Label();
            supplierPhoneBox = new TextBox();
            supplierMailBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            supplierContactPersonBox = new TextBox();
            createOrderbtn = new Button();
            CostPrice = new Label();
            costPriceBox = new TextBox();
            purchaseOrderItemsListView = new ListView();
            addProductbtn = new Button();
            quantityAlertlbl = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(533, 9);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(35, 37);
            button1.TabIndex = 34;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // supplierlbl
            // 
            supplierlbl.AutoSize = true;
            supplierlbl.Font = new Font("Microsoft Sans Serif", 10.2F);
            supplierlbl.Location = new Point(28, 85);
            supplierlbl.Name = "supplierlbl";
            supplierlbl.Size = new Size(64, 17);
            supplierlbl.TabIndex = 36;
            supplierlbl.Text = "Supplier ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(122, 17);
            label4.Name = "label4";
            label4.Size = new Size(301, 30);
            label4.TabIndex = 93;
            label4.Text = "Create New Purchase Order";
            // 
            // supplierBox
            // 
            supplierBox.FormattingEnabled = true;
            supplierBox.Location = new Point(28, 102);
            supplierBox.Margin = new Padding(3, 2, 3, 2);
            supplierBox.Name = "supplierBox";
            supplierBox.Size = new Size(133, 23);
            supplierBox.TabIndex = 94;
            supplierBox.SelectedIndexChanged += supplierBox_SelectedIndexChanged;
            // 
            // supplierProductBox
            // 
            supplierProductBox.FormattingEnabled = true;
            supplierProductBox.Location = new Point(176, 102);
            supplierProductBox.Margin = new Padding(3, 2, 3, 2);
            supplierProductBox.Name = "supplierProductBox";
            supplierProductBox.Size = new Size(153, 23);
            supplierProductBox.TabIndex = 95;
            supplierProductBox.SelectedIndexChanged += supplierProductBox_SelectedIndexChanged;
            // 
            // supplierProductlbl
            // 
            supplierProductlbl.AutoSize = true;
            supplierProductlbl.Font = new Font("Microsoft Sans Serif", 10.2F);
            supplierProductlbl.Location = new Point(176, 85);
            supplierProductlbl.Name = "supplierProductlbl";
            supplierProductlbl.Size = new Size(113, 17);
            supplierProductlbl.TabIndex = 96;
            supplierProductlbl.Text = "Supplier Product";
            // 
            // quanBox
            // 
            quanBox.Location = new Point(342, 102);
            quanBox.Margin = new Padding(3, 2, 3, 2);
            quanBox.Name = "quanBox";
            quanBox.Size = new Size(86, 23);
            quanBox.TabIndex = 97;
            quanBox.TextChanged += quanBox_TextChanged;
            // 
            // quantityBox
            // 
            quantityBox.AutoSize = true;
            quantityBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            quantityBox.Location = new Point(342, 85);
            quantityBox.Name = "quantityBox";
            quantityBox.Size = new Size(61, 17);
            quantityBox.TabIndex = 98;
            quantityBox.Text = "Quantity";
            // 
            // totalAmountlbl
            // 
            totalAmountlbl.AutoSize = true;
            totalAmountlbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalAmountlbl.Location = new Point(28, 304);
            totalAmountlbl.Name = "totalAmountlbl";
            totalAmountlbl.Size = new Size(102, 20);
            totalAmountlbl.TabIndex = 99;
            totalAmountlbl.Text = "Total Amount:";
            // 
            // amountDatalbl
            // 
            amountDatalbl.AutoSize = true;
            amountDatalbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountDatalbl.Location = new Point(143, 304);
            amountDatalbl.Name = "amountDatalbl";
            amountDatalbl.Size = new Size(94, 20);
            amountDatalbl.TabIndex = 100;
            amountDatalbl.Text = "AmountData";
            // 
            // supplierPhoneBox
            // 
            supplierPhoneBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplierPhoneBox.Location = new Point(413, 381);
            supplierPhoneBox.Margin = new Padding(4, 3, 4, 3);
            supplierPhoneBox.Name = "supplierPhoneBox";
            supplierPhoneBox.ReadOnly = true;
            supplierPhoneBox.Size = new Size(142, 23);
            supplierPhoneBox.TabIndex = 107;
            // 
            // supplierMailBox
            // 
            supplierMailBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplierMailBox.Location = new Point(197, 381);
            supplierMailBox.Margin = new Padding(4, 3, 4, 3);
            supplierMailBox.Name = "supplierMailBox";
            supplierMailBox.ReadOnly = true;
            supplierMailBox.Size = new Size(187, 23);
            supplierMailBox.TabIndex = 106;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(413, 364);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 17);
            label1.TabIndex = 109;
            label1.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 364);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 108;
            label2.Text = "Mail Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(29, 364);
            label5.Name = "label5";
            label5.Size = new Size(105, 17);
            label5.TabIndex = 110;
            label5.Text = "Contact Person";
            // 
            // supplierContactPersonBox
            // 
            supplierContactPersonBox.Location = new Point(29, 381);
            supplierContactPersonBox.Margin = new Padding(3, 2, 3, 2);
            supplierContactPersonBox.Name = "supplierContactPersonBox";
            supplierContactPersonBox.ReadOnly = true;
            supplierContactPersonBox.Size = new Size(146, 23);
            supplierContactPersonBox.TabIndex = 111;
            // 
            // createOrderbtn
            // 
            createOrderbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createOrderbtn.Location = new Point(229, 439);
            createOrderbtn.Name = "createOrderbtn";
            createOrderbtn.Size = new Size(109, 35);
            createOrderbtn.TabIndex = 112;
            createOrderbtn.Text = "Create";
            createOrderbtn.UseVisualStyleBackColor = true;
            createOrderbtn.Click += createOrderbtn_Click;
            // 
            // CostPrice
            // 
            CostPrice.AutoSize = true;
            CostPrice.Font = new Font("Microsoft Sans Serif", 10.2F);
            CostPrice.Location = new Point(445, 85);
            CostPrice.Name = "CostPrice";
            CostPrice.Size = new Size(72, 17);
            CostPrice.TabIndex = 114;
            CostPrice.Text = "Cost Price";
            // 
            // costPriceBox
            // 
            costPriceBox.Location = new Point(445, 102);
            costPriceBox.Margin = new Padding(3, 2, 3, 2);
            costPriceBox.Name = "costPriceBox";
            costPriceBox.ReadOnly = true;
            costPriceBox.Size = new Size(110, 23);
            costPriceBox.TabIndex = 113;
            // 
            // purchaseOrderItemsListView
            // 
            purchaseOrderItemsListView.FullRowSelect = true;
            purchaseOrderItemsListView.GridLines = true;
            purchaseOrderItemsListView.Location = new Point(28, 143);
            purchaseOrderItemsListView.Margin = new Padding(3, 2, 3, 2);
            purchaseOrderItemsListView.Name = "purchaseOrderItemsListView";
            purchaseOrderItemsListView.Size = new Size(527, 149);
            purchaseOrderItemsListView.TabIndex = 115;
            purchaseOrderItemsListView.UseCompatibleStateImageBehavior = false;
            purchaseOrderItemsListView.View = View.Details;
            // 
            // addProductbtn
            // 
            addProductbtn.Location = new Point(413, 296);
            addProductbtn.Margin = new Padding(3, 2, 3, 2);
            addProductbtn.Name = "addProductbtn";
            addProductbtn.Size = new Size(142, 26);
            addProductbtn.TabIndex = 116;
            addProductbtn.Text = "Add Product";
            addProductbtn.UseVisualStyleBackColor = true;
            addProductbtn.Click += addProductbtn_Click;
            // 
            // quantityAlertlbl
            // 
            quantityAlertlbl.AutoSize = true;
            quantityAlertlbl.Font = new Font("Microsoft Sans Serif", 10.2F);
            quantityAlertlbl.ForeColor = Color.Red;
            quantityAlertlbl.Location = new Point(342, 124);
            quantityAlertlbl.Name = "quantityAlertlbl";
            quantityAlertlbl.Size = new Size(120, 17);
            quantityAlertlbl.TabIndex = 117;
            quantityAlertlbl.Text = "Quantity is empty!";
            // 
            // CreatePurchaseOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(578, 493);
            Controls.Add(quantityAlertlbl);
            Controls.Add(addProductbtn);
            Controls.Add(purchaseOrderItemsListView);
            Controls.Add(CostPrice);
            Controls.Add(costPriceBox);
            Controls.Add(createOrderbtn);
            Controls.Add(supplierContactPersonBox);
            Controls.Add(label5);
            Controls.Add(supplierPhoneBox);
            Controls.Add(supplierMailBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(amountDatalbl);
            Controls.Add(totalAmountlbl);
            Controls.Add(quantityBox);
            Controls.Add(quanBox);
            Controls.Add(supplierProductlbl);
            Controls.Add(supplierProductBox);
            Controls.Add(supplierBox);
            Controls.Add(label4);
            Controls.Add(supplierlbl);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CreatePurchaseOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreatePurchaseOrder";
            Load += CreatePurchaseOrder_Load;
            MouseDown += Dashboard_MouseDown;
            MouseMove += Dashboard_MouseMove;
            MouseUp += Dashboard_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label supplierlbl;
        private Label label3;
        private Label label4;
        private ComboBox supplierBox;
        private ComboBox supplierProductBox;
        private Label supplierProductlbl;
        private TextBox quanBox;
        private Label quantityBox;
        private Label totalAmountlbl;
        private Label amountDatalbl;
        private ComboBox staffBox;
        private TextBox phoneNumBox;
        private TextBox mailBox;
        private TextBox registerDisplaynameBox;
        private TextBox registerUsernameBox;
        private Label phoneNumlbl;
        private Label maillbl;
        private Label displaynamelbl;
        private Label usernamelbl;
        private TextBox supplierPhoneBox;
        private TextBox supplierMailBox;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox supplierContactPersonBox;
        private Button createOrderbtn;
        private Label CostPrice;
        private TextBox costPriceBox;
        private ListView purchaseOrderItemsListView;
        private Button addProductbtn;
        private Label quantityAlertlbl;
    }
}