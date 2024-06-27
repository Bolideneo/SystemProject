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
            label2 = new Label();
            panel2 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            panelBorderColor1 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            panelBorderColor2 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            panelBorderColor3 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            panelBorderColor4 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            InvoiceLine1 = new Panel();
            panelBorderColor5 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            panelBorderColor6 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            ((System.ComponentModel.ISupportInitialize)productOfOrderdata).BeginInit();
            panel2.SuspendLayout();
            panelBorderColor1.SuspendLayout();
            panelBorderColor2.SuspendLayout();
            panelBorderColor3.SuspendLayout();
            panelBorderColor4.SuspendLayout();
            panelBorderColor5.SuspendLayout();
            panelBorderColor6.SuspendLayout();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(641, 8);
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
            label11.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(273, 99);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(106, 18);
            label11.TabIndex = 54;
            label11.Text = "Dealer Name";
            // 
            // dealerNameBox
            // 
            dealerNameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerNameBox.Location = new Point(13, 15);
            dealerNameBox.Margin = new Padding(4);
            dealerNameBox.Name = "dealerNameBox";
            dealerNameBox.Size = new Size(107, 23);
            dealerNameBox.TabIndex = 53;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(404, 596);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(127, 18);
            label10.TabIndex = 52;
            label10.Text = "Invoice Address";
            // 
            // invoiceAddressBox
            // 
            invoiceAddressBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invoiceAddressBox.Location = new Point(18, 19);
            invoiceAddressBox.Margin = new Padding(4);
            invoiceAddressBox.Name = "invoiceAddressBox";
            invoiceAddressBox.Size = new Size(217, 23);
            invoiceAddressBox.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(68, 191);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 18);
            label5.TabIndex = 48;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 596);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(190, 18);
            label4.TabIndex = 46;
            label4.Text = "Goods Delivery Address";
            // 
            // goodsAddressBox
            // 
            goodsAddressBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goodsAddressBox.Location = new Point(23, 19);
            goodsAddressBox.Margin = new Padding(4);
            goodsAddressBox.Name = "goodsAddressBox";
            goodsAddressBox.Size = new Size(199, 23);
            goodsAddressBox.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 99);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 18);
            label1.TabIndex = 44;
            label1.Text = "Dealer ID";
            // 
            // dealerIDBox
            // 
            dealerIDBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerIDBox.Location = new Point(12, 15);
            dealerIDBox.Margin = new Padding(4);
            dealerIDBox.Name = "dealerIDBox";
            dealerIDBox.Size = new Size(114, 23);
            dealerIDBox.TabIndex = 43;
            dealerIDBox.KeyDown += dealerIDBox_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(268, 191);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(133, 18);
            label8.TabIndex = 60;
            label8.Text = "Dealer Company";
            // 
            // dealerCompanyBox
            // 
            dealerCompanyBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerCompanyBox.Location = new Point(13, 15);
            dealerCompanyBox.Margin = new Padding(4);
            dealerCompanyBox.Name = "dealerCompanyBox";
            dealerCompanyBox.Size = new Size(107, 23);
            dealerCompanyBox.TabIndex = 59;
            // 
            // productOfOrderdata
            // 
            productOfOrderdata.AllowUserToAddRows = false;
            productOfOrderdata.AllowUserToDeleteRows = false;
            productOfOrderdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productOfOrderdata.BackgroundColor = SystemColors.ButtonFace;
            productOfOrderdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productOfOrderdata.Location = new Point(17, 380);
            productOfOrderdata.Margin = new Padding(3, 4, 3, 4);
            productOfOrderdata.Name = "productOfOrderdata";
            productOfOrderdata.RowHeadersWidth = 51;
            productOfOrderdata.RowTemplate.Height = 24;
            productOfOrderdata.Size = new Size(601, 198);
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
            label12.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(465, 99);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(168, 18);
            label12.TabIndex = 65;
            label12.Text = "Order Complete Date";
            label12.Visible = false;
            // 
            // orderCompleteDateBox
            // 
            orderCompleteDateBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderCompleteDateBox.Location = new Point(20, 16);
            orderCompleteDateBox.Margin = new Padding(4);
            orderCompleteDateBox.Name = "orderCompleteDateBox";
            orderCompleteDateBox.Size = new Size(145, 23);
            orderCompleteDateBox.TabIndex = 64;
            orderCompleteDateBox.Visible = false;
            orderCompleteDateBox.TextChanged += orderCompleteDateBox_TextChanged;
            // 
            // phoneNumBox
            // 
            phoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumBox.Location = new Point(10, 15);
            phoneNumBox.Margin = new Padding(4);
            phoneNumBox.Name = "phoneNumBox";
            phoneNumBox.Size = new Size(114, 23);
            phoneNumBox.TabIndex = 66;
            // 
            // saveOrderbtn
            // 
            saveOrderbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveOrderbtn.Location = new Point(521, 714);
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
            productSearchbox.Location = new Point(20, 337);
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
            label6.Location = new Point(257, 319);
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
            label9.Location = new Point(257, 341);
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
            orderStatuslbl.Location = new Point(18, 299);
            orderStatuslbl.Name = "orderStatuslbl";
            orderStatuslbl.Size = new Size(116, 25);
            orderStatuslbl.TabIndex = 75;
            orderStatuslbl.Text = "Order Status";
            // 
            // ordertotallbl
            // 
            ordertotallbl.AutoSize = true;
            ordertotallbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordertotallbl.Location = new Point(29, 706);
            ordertotallbl.Name = "ordertotallbl";
            ordertotallbl.Size = new Size(87, 21);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 706);
            label2.Name = "label2";
            label2.Size = new Size(19, 21);
            label2.TabIndex = 78;
            label2.Text = "0";
            // 
            // panel2
            // 
            panel2.BorderColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.BorderWidth = 3;
            panel2.Controls.Add(dealerNameBox);
            panel2.Location = new Point(257, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(154, 60);
            panel2.TabIndex = 79;
            panel2.Paint += panel2_Paint;
            // 
            // panelBorderColor1
            // 
            panelBorderColor1.BorderColor = Color.Black;
            panelBorderColor1.BorderStyle = BorderStyle.FixedSingle;
            panelBorderColor1.BorderWidth = 3;
            panelBorderColor1.Controls.Add(dealerIDBox);
            panelBorderColor1.Location = new Point(53, 108);
            panelBorderColor1.Name = "panelBorderColor1";
            panelBorderColor1.Size = new Size(146, 60);
            panelBorderColor1.TabIndex = 80;
            // 
            // panelBorderColor2
            // 
            panelBorderColor2.BorderColor = Color.Black;
            panelBorderColor2.BorderStyle = BorderStyle.FixedSingle;
            panelBorderColor2.BorderWidth = 3;
            panelBorderColor2.Controls.Add(orderCompleteDateBox);
            panelBorderColor2.Location = new Point(457, 107);
            panelBorderColor2.Name = "panelBorderColor2";
            panelBorderColor2.Size = new Size(187, 61);
            panelBorderColor2.TabIndex = 80;
            // 
            // panelBorderColor3
            // 
            panelBorderColor3.BorderColor = Color.Black;
            panelBorderColor3.BorderStyle = BorderStyle.FixedSingle;
            panelBorderColor3.BorderWidth = 3;
            panelBorderColor3.Controls.Add(phoneNumBox);
            panelBorderColor3.Location = new Point(53, 200);
            panelBorderColor3.Name = "panelBorderColor3";
            panelBorderColor3.Size = new Size(146, 60);
            panelBorderColor3.TabIndex = 81;
            // 
            // panelBorderColor4
            // 
            panelBorderColor4.BorderColor = Color.Black;
            panelBorderColor4.BorderStyle = BorderStyle.FixedSingle;
            panelBorderColor4.BorderWidth = 3;
            panelBorderColor4.Controls.Add(dealerCompanyBox);
            panelBorderColor4.Location = new Point(257, 200);
            panelBorderColor4.Name = "panelBorderColor4";
            panelBorderColor4.Size = new Size(154, 60);
            panelBorderColor4.TabIndex = 82;
            // 
            // InvoiceLine1
            // 
            InvoiceLine1.BackColor = SystemColors.ControlDark;
            InvoiceLine1.BorderStyle = BorderStyle.Fixed3D;
            InvoiceLine1.ForeColor = SystemColors.ControlText;
            InvoiceLine1.Location = new Point(18, 279);
            InvoiceLine1.Name = "InvoiceLine1";
            InvoiceLine1.Size = new Size(650, 5);
            InvoiceLine1.TabIndex = 83;
            // 
            // panelBorderColor5
            // 
            panelBorderColor5.BorderColor = Color.Black;
            panelBorderColor5.BorderStyle = BorderStyle.FixedSingle;
            panelBorderColor5.BorderWidth = 3;
            panelBorderColor5.Controls.Add(goodsAddressBox);
            panelBorderColor5.Location = new Point(40, 605);
            panelBorderColor5.Name = "panelBorderColor5";
            panelBorderColor5.Size = new Size(249, 70);
            panelBorderColor5.TabIndex = 81;
            // 
            // panelBorderColor6
            // 
            panelBorderColor6.BorderColor = Color.Black;
            panelBorderColor6.BorderStyle = BorderStyle.FixedSingle;
            panelBorderColor6.BorderWidth = 3;
            panelBorderColor6.Controls.Add(invoiceAddressBox);
            panelBorderColor6.Location = new Point(351, 605);
            panelBorderColor6.Name = "panelBorderColor6";
            panelBorderColor6.Size = new Size(249, 70);
            panelBorderColor6.TabIndex = 82;
            // 
            // SalesOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(697, 768);
            Controls.Add(label10);
            Controls.Add(panelBorderColor6);
            Controls.Add(label4);
            Controls.Add(InvoiceLine1);
            Controls.Add(label12);
            Controls.Add(panelBorderColor2);
            Controls.Add(label1);
            Controls.Add(panelBorderColor1);
            Controls.Add(label11);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(orderStatusLabel);
            Controls.Add(ordertotallbl);
            Controls.Add(orderStatuslbl);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(productSearchbox);
            Controls.Add(saveOrderbtn);
            Controls.Add(productOfOrderdata);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(orderLabel);
            Controls.Add(CloseButton);
            Controls.Add(panelBorderColor3);
            Controls.Add(panelBorderColor4);
            Controls.Add(panelBorderColor5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalesOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesOrder";
            Load += SalesOrder_Load;
            ((System.ComponentModel.ISupportInitialize)productOfOrderdata).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelBorderColor1.ResumeLayout(false);
            panelBorderColor1.PerformLayout();
            panelBorderColor2.ResumeLayout(false);
            panelBorderColor2.PerformLayout();
            panelBorderColor3.ResumeLayout(false);
            panelBorderColor3.PerformLayout();
            panelBorderColor4.ResumeLayout(false);
            panelBorderColor4.PerformLayout();
            panelBorderColor5.ResumeLayout(false);
            panelBorderColor5.PerformLayout();
            panelBorderColor6.ResumeLayout(false);
            panelBorderColor6.PerformLayout();
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
        private Label label2;
        private ProgramMethod.ProgramMethod.PanelBorderColor panel2;
        private ProgramMethod.ProgramMethod.PanelBorderColor panelBorderColor1;
        private ProgramMethod.ProgramMethod.PanelBorderColor panelBorderColor2;
        private ProgramMethod.ProgramMethod.PanelBorderColor panelBorderColor3;
        private ProgramMethod.ProgramMethod.PanelBorderColor panelBorderColor4;
        private Panel InvoiceLine1;
        private ProgramMethod.ProgramMethod.PanelBorderColor panelBorderColor5;
        private ProgramMethod.ProgramMethod.PanelBorderColor panelBorderColor6;
    }
}