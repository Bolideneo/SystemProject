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
            CloseButton = new Button();
            label3 = new Label();
            label11 = new Label();
            dealerNameBox = new TextBox();
            label6 = new Label();
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
            phoneNumBox = new TextBox();
            createOrderbtn = new Button();
            productSearchbox = new TextBox();
            panel1 = new Panel();
            ordertotallbl = new Label();
            label7 = new Label();
            label2 = new Label();
            orderDateBox = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)productOfOrderdata).BeginInit();
            panel1.SuspendLayout();
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
            label3.Size = new Size(201, 30);
            label3.TabIndex = 16;
            label3.Text = "Create New Order";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(60, 80);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(99, 17);
            label11.TabIndex = 54;
            label11.Text = "Dealer Name :";
            // 
            // dealerNameBox
            // 
            dealerNameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerNameBox.Location = new Point(225, 80);
            dealerNameBox.Margin = new Padding(5);
            dealerNameBox.Name = "dealerNameBox";
            dealerNameBox.Size = new Size(218, 23);
            dealerNameBox.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(397, 386);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 17);
            label6.TabIndex = 49;
            label6.Text = "Search Product";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 164);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 17);
            label5.TabIndex = 48;
            label5.Text = "Phone Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 197);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(123, 17);
            label4.TabIndex = 46;
            label4.Text = "Delivery Address :";
            // 
            // goodsAddressBox
            // 
            goodsAddressBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goodsAddressBox.Location = new Point(224, 196);
            goodsAddressBox.Margin = new Padding(5);
            goodsAddressBox.Name = "goodsAddressBox";
            goodsAddressBox.Size = new Size(219, 23);
            goodsAddressBox.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 44;
            label1.Text = "*Dealer ID :";
            // 
            // dealerIDBox
            // 
            dealerIDBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerIDBox.Location = new Point(225, 32);
            dealerIDBox.Margin = new Padding(5);
            dealerIDBox.Name = "dealerIDBox";
            dealerIDBox.Size = new Size(218, 23);
            dealerIDBox.TabIndex = 43;
            dealerIDBox.KeyDown += dealerIDBox_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(38, 120);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(121, 17);
            label8.TabIndex = 60;
            label8.Text = "Dealer Company :";
            // 
            // dealerCompanyBox
            // 
            dealerCompanyBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerCompanyBox.Location = new Point(225, 120);
            dealerCompanyBox.Margin = new Padding(5);
            dealerCompanyBox.Name = "dealerCompanyBox";
            dealerCompanyBox.Size = new Size(218, 23);
            dealerCompanyBox.TabIndex = 45;
            // 
            // productOfOrderdata
            // 
            productOfOrderdata.AllowUserToAddRows = false;
            productOfOrderdata.AllowUserToDeleteRows = false;
            productOfOrderdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productOfOrderdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productOfOrderdata.Location = new Point(3, 333);
            productOfOrderdata.Margin = new Padding(3, 4, 3, 4);
            productOfOrderdata.Name = "productOfOrderdata";
            productOfOrderdata.RowHeadersWidth = 51;
            productOfOrderdata.RowTemplate.Height = 24;
            productOfOrderdata.Size = new Size(580, 184);
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
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(7, 241);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(150, 17);
            label12.TabIndex = 65;
            label12.Text = "Order Complete Date :";
            // 
            // phoneNumBox
            // 
            phoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumBox.Location = new Point(224, 161);
            phoneNumBox.Margin = new Padding(5);
            phoneNumBox.Name = "phoneNumBox";
            phoneNumBox.Size = new Size(219, 23);
            phoneNumBox.TabIndex = 46;
            // 
            // createOrderbtn
            // 
            createOrderbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createOrderbtn.Location = new Point(429, 624);
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
            productSearchbox.Location = new Point(35, 287);
            productSearchbox.Margin = new Padding(5);
            productSearchbox.MaximumSize = new Size(263, 60);
            productSearchbox.Name = "productSearchbox";
            productSearchbox.PlaceholderText = "Search Product ID or Name";
            productSearchbox.Size = new Size(224, 23);
            productSearchbox.TabIndex = 48;
            productSearchbox.TextChanged += productSearchbox_TextChanged;
            productSearchbox.KeyDown += productSearchbox_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(ordertotallbl);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(orderDateBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(goodsAddressBox);
            panel1.Controls.Add(dealerIDBox);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(dealerNameBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(productSearchbox);
            panel1.Controls.Add(productOfOrderdata);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(phoneNumBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dealerCompanyBox);
            panel1.Location = new Point(1, 58);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 553);
            panel1.TabIndex = 72;
            // 
            // ordertotallbl
            // 
            ordertotallbl.AutoSize = true;
            ordertotallbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordertotallbl.Location = new Point(365, 521);
            ordertotallbl.Name = "ordertotallbl";
            ordertotallbl.Size = new Size(108, 25);
            ordertotallbl.TabIndex = 73;
            ordertotallbl.Text = "Total Price: ";
            ordertotallbl.TextChanged += ordertotallbl_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(272, 287);
            label7.Name = "label7";
            label7.Size = new Size(288, 19);
            label7.TabIndex = 72;
            label7.Text = "Left click Quantity column to change quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(272, 307);
            label2.Name = "label2";
            label2.Size = new Size(277, 19);
            label2.TabIndex = 71;
            label2.Text = "Double click Cell to remove unwant product";
            // 
            // orderDateBox
            // 
            orderDateBox.Location = new Point(224, 236);
            orderDateBox.Margin = new Padding(3, 2, 3, 2);
            orderDateBox.MinDate = new DateTime(2010, 7, 27, 0, 0, 0, 0);
            orderDateBox.Name = "orderDateBox";
            orderDateBox.Size = new Size(219, 23);
            orderDateBox.TabIndex = 70;
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(589, 674);
            Controls.Add(panel1);
            Controls.Add(createOrderbtn);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dealerNameBox;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.TextBox phoneNumBox;
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
        private DateTimePicker orderDateBox;
        private Label label2;
        private Label label7;
        private Label ordertotallbl;
    }
}