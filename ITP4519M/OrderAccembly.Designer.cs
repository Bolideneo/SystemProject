namespace ITP4519M
{
    partial class OrderAccembly
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
            label5 = new Label();
            label1 = new Label();
            dealerIDBox = new TextBox();
            label2 = new Label();
            orderIDBox = new TextBox();
            label8 = new Label();
            dealerCompanyBox = new TextBox();
            productOfOrderdata = new DataGridView();
            productIDColumn = new DataGridViewTextBoxColumn();
            productNameColumn = new DataGridViewTextBoxColumn();
            quantityColumn = new DataGridViewTextBoxColumn();
            unitPriceColumn = new DataGridViewTextBoxColumn();
            phoneNumBox = new TextBox();
            saveOrderbtn = new Button();
            orderAccemblyOrderItemdata = new DataGridView();
            label4 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)productOfOrderdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderAccemblyOrderItemdata).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(862, 5);
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
            label3.Size = new Size(166, 38);
            label3.TabIndex = 16;
            label3.Text = "Sales Order";
            label3.Click += this.label3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(188, 166);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(118, 20);
            label11.TabIndex = 54;
            label11.Text = "Dealer Name :";
            // 
            // dealerNameBox
            // 
            dealerNameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerNameBox.Location = new Point(337, 166);
            dealerNameBox.Margin = new Padding(6, 7, 6, 7);
            dealerNameBox.Name = "dealerNameBox";
            dealerNameBox.Size = new Size(187, 27);
            dealerNameBox.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(176, 222);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 48;
            label5.Text = "Phone Number :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 112);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 44;
            label1.Text = "Dealer ID :";
            // 
            // dealerIDBox
            // 
            dealerIDBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerIDBox.Location = new Point(337, 109);
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
            label2.Location = new Point(232, 58);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 42;
            label2.Text = "Order ID :";
            // 
            // orderIDBox
            // 
            orderIDBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderIDBox.Location = new Point(337, 58);
            orderIDBox.Margin = new Padding(6, 7, 6, 7);
            orderIDBox.Name = "orderIDBox";
            orderIDBox.Size = new Size(185, 27);
            orderIDBox.TabIndex = 41;
            orderIDBox.TextChanged += this.orderIDBox_TextChanged_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(149, 279);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(144, 20);
            label8.TabIndex = 60;
            label8.Text = "Dealer Company :";
            // 
            // dealerCompanyBox
            // 
            dealerCompanyBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerCompanyBox.Location = new Point(324, 279);
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
            productOfOrderdata.Location = new Point(59, 719);
            productOfOrderdata.Margin = new Padding(3, 5, 3, 5);
            productOfOrderdata.Name = "productOfOrderdata";
            productOfOrderdata.RowHeadersWidth = 51;
            productOfOrderdata.RowTemplate.Height = 24;
            productOfOrderdata.Size = new Size(776, 221);
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
            // phoneNumBox
            // 
            phoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumBox.Location = new Point(332, 222);
            phoneNumBox.Margin = new Padding(6, 7, 6, 7);
            phoneNumBox.Name = "phoneNumBox";
            phoneNumBox.Size = new Size(187, 27);
            phoneNumBox.TabIndex = 66;
            // 
            // saveOrderbtn
            // 
            saveOrderbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveOrderbtn.Location = new Point(722, 970);
            saveOrderbtn.Margin = new Padding(3, 4, 3, 4);
            saveOrderbtn.Name = "saveOrderbtn";
            saveOrderbtn.Size = new Size(171, 53);
            saveOrderbtn.TabIndex = 71;
            saveOrderbtn.Text = "Save";
            saveOrderbtn.UseVisualStyleBackColor = true;
            saveOrderbtn.Click += saveOrderbtn_Click;
            // 
            // orderAccemblyOrderItemdata
            // 
            orderAccemblyOrderItemdata.AllowUserToAddRows = false;
            orderAccemblyOrderItemdata.AllowUserToDeleteRows = false;
            orderAccemblyOrderItemdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderAccemblyOrderItemdata.BackgroundColor = SystemColors.ButtonFace;
            orderAccemblyOrderItemdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderAccemblyOrderItemdata.Location = new Point(60, 438);
            orderAccemblyOrderItemdata.Margin = new Padding(3, 5, 3, 5);
            orderAccemblyOrderItemdata.Name = "orderAccemblyOrderItemdata";
            orderAccemblyOrderItemdata.RowHeadersWidth = 51;
            orderAccemblyOrderItemdata.RowTemplate.Height = 24;
            orderAccemblyOrderItemdata.Size = new Size(776, 221);
            orderAccemblyOrderItemdata.TabIndex = 72;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(149, 342);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 73;
            label4.Text = "Dealer Address:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(324, 342);
            textBox1.Margin = new Padding(6, 7, 6, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 27);
            textBox1.TabIndex = 74;
            // 
            // OrderAccembly
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(931, 1036);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(orderAccemblyOrderItemdata);
            Controls.Add(saveOrderbtn);
            Controls.Add(phoneNumBox);
            Controls.Add(productOfOrderdata);
            Controls.Add(label8);
            Controls.Add(dealerCompanyBox);
            Controls.Add(label11);
            Controls.Add(dealerNameBox);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(dealerIDBox);
            Controls.Add(label2);
            Controls.Add(orderIDBox);
            Controls.Add(label3);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderAccembly";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderForm1";
            Load += SalesOrder_Load;
            ((System.ComponentModel.ISupportInitialize)productOfOrderdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderAccemblyOrderItemdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dealerNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dealerIDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderIDBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dealerCompanyBox;
        private System.Windows.Forms.DataGridView productOfOrderdata;
        private System.Windows.Forms.Label label9;
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
        private DataGridView orderAccemblyOrderItemdata;
        private Label label4;
        private TextBox textBox1;
    }
}