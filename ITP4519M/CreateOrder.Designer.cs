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
            label6 = new Label();
            productOfOrderdata = new DataGridView();
            productIDColumn = new DataGridViewTextBoxColumn();
            productNameColumn = new DataGridViewTextBoxColumn();
            quantityColumn = new DataGridViewTextBoxColumn();
            unitPriceColumn = new DataGridViewTextBoxColumn();
            createOrderbtn = new Button();
            productSearchbox = new TextBox();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            dealerinfoBox = new TextBox();
            label10 = new Label();
            label7 = new Label();
            label2 = new Label();
            orderDateBox = new DateTimePicker();
            dealerIDBox = new TextBox();
            label1 = new Label();
            goodsAddressBox = new TextBox();
            label11 = new Label();
            label12 = new Label();
            dealerNameBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            phoneNumBox = new TextBox();
            label8 = new Label();
            dealerCompanyBox = new TextBox();
            label14 = new Label();
            label13 = new Label();
            ordertotallbl = new Label();
            ((System.ComponentModel.ISupportInitialize)productOfOrderdata).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(766, 5);
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
            label3.Size = new Size(251, 38);
            label3.TabIndex = 16;
            label3.Text = "Create New Order";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(456, 600);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 49;
            label6.Text = "Search Product";
            // 
            // productOfOrderdata
            // 
            productOfOrderdata.AllowUserToAddRows = false;
            productOfOrderdata.AllowUserToDeleteRows = false;
            productOfOrderdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productOfOrderdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productOfOrderdata.Location = new Point(9, 495);
            productOfOrderdata.Margin = new Padding(3, 5, 3, 5);
            productOfOrderdata.Name = "productOfOrderdata";
            productOfOrderdata.RowHeadersWidth = 51;
            productOfOrderdata.RowTemplate.Height = 24;
            productOfOrderdata.Size = new Size(760, 245);
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
            createOrderbtn.Location = new Point(624, 916);
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
            productSearchbox.BackColor = SystemColors.ButtonFace;
            productSearchbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productSearchbox.Location = new Point(190, 456);
            productSearchbox.Margin = new Padding(6, 7, 6, 7);
            productSearchbox.MaximumSize = new Size(300, 60);
            productSearchbox.Name = "productSearchbox";
            productSearchbox.PlaceholderText = "Search Product ID or Name";
            productSearchbox.Size = new Size(300, 27);
            productSearchbox.TabIndex = 48;
            productSearchbox.TextChanged += productSearchbox_TextChanged;
            productSearchbox.KeyDown += productSearchbox_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(orderDateBox);
            panel1.Controls.Add(dealerIDBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(goodsAddressBox);
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
            panel1.Location = new Point(11, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 823);
            panel1.TabIndex = 72;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(537, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 28);
            comboBox1.TabIndex = 77;
            comboBox1.TextChanged += comboBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(dealerinfoBox);
            panel2.Location = new Point(257, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 33);
            panel2.TabIndex = 76;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(231, 5);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // dealerinfoBox
            // 
            dealerinfoBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            dealerinfoBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            dealerinfoBox.BorderStyle = BorderStyle.None;
            dealerinfoBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerinfoBox.Location = new Point(6, 6);
            dealerinfoBox.Margin = new Padding(6, 7, 6, 7);
            dealerinfoBox.Name = "dealerinfoBox";
            dealerinfoBox.Size = new Size(210, 20);
            dealerinfoBox.TabIndex = 75;
            dealerinfoBox.TextChanged += dealerinfoBox_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(71, 17);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(127, 20);
            label10.TabIndex = 74;
            label10.Text = " * Dealer Info :  ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(418, 400);
            label7.Name = "label7";
            label7.Size = new Size(358, 23);
            label7.TabIndex = 72;
            label7.Text = "Left click Quantity column to change quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(418, 426);
            label2.Name = "label2";
            label2.Size = new Size(345, 23);
            label2.TabIndex = 71;
            label2.Text = "Double click Cell to remove unwant product";
            // 
            // orderDateBox
            // 
            orderDateBox.Location = new Point(257, 331);
            orderDateBox.MinDate = new DateTime(2010, 7, 27, 0, 0, 0, 0);
            orderDateBox.Name = "orderDateBox";
            orderDateBox.Size = new Size(250, 27);
            orderDateBox.TabIndex = 70;
            // 
            // dealerIDBox
            // 
            dealerIDBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerIDBox.Location = new Point(258, 76);
            dealerIDBox.Margin = new Padding(6, 7, 6, 7);
            dealerIDBox.Name = "dealerIDBox";
            dealerIDBox.Size = new Size(249, 27);
            dealerIDBox.TabIndex = 43;
            dealerIDBox.KeyDown += dealerIDBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 76);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 44;
            label1.Text = "Dealer ID :";
            // 
            // goodsAddressBox
            // 
            goodsAddressBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goodsAddressBox.Location = new Point(257, 277);
            goodsAddressBox.Margin = new Padding(6, 7, 6, 7);
            goodsAddressBox.Name = "goodsAddressBox";
            goodsAddressBox.Size = new Size(250, 27);
            goodsAddressBox.TabIndex = 47;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(67, 124);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(118, 20);
            label11.TabIndex = 54;
            label11.Text = "Dealer Name :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(9, 337);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(179, 20);
            label12.TabIndex = 65;
            label12.Text = "Order Complete Date :";
            // 
            // dealerNameBox
            // 
            dealerNameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerNameBox.Location = new Point(258, 124);
            dealerNameBox.Margin = new Padding(6, 7, 6, 7);
            dealerNameBox.Name = "dealerNameBox";
            dealerNameBox.Size = new Size(249, 27);
            dealerNameBox.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 279);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 46;
            label4.Text = "Delivery Address :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 233);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 48;
            label5.Text = "Phone Number :";
            // 
            // phoneNumBox
            // 
            phoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumBox.Location = new Point(257, 233);
            phoneNumBox.Margin = new Padding(6, 7, 6, 7);
            phoneNumBox.Name = "phoneNumBox";
            phoneNumBox.Size = new Size(250, 27);
            phoneNumBox.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(43, 173);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(144, 20);
            label8.TabIndex = 60;
            label8.Text = "Dealer Company :";
            // 
            // dealerCompanyBox
            // 
            dealerCompanyBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerCompanyBox.Location = new Point(257, 173);
            dealerCompanyBox.Margin = new Padding(6, 7, 6, 7);
            dealerCompanyBox.Name = "dealerCompanyBox";
            dealerCompanyBox.Size = new Size(249, 27);
            dealerCompanyBox.TabIndex = 45;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(55, 69);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(91, 20);
            label14.TabIndex = 79;
            label14.Text = "Dealer ID :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(136, 48);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(91, 20);
            label13.TabIndex = 78;
            label13.Text = "Dealer ID :";
            // 
            // ordertotallbl
            // 
            ordertotallbl.AutoSize = true;
            ordertotallbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordertotallbl.Location = new Point(22, 904);
            ordertotallbl.Name = "ordertotallbl";
            ordertotallbl.Size = new Size(112, 28);
            ordertotallbl.TabIndex = 73;
            ordertotallbl.Text = "Total: CN¥0";
            ordertotallbl.TextChanged += ordertotallbl_TextChanged;
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(835, 984);
            Controls.Add(panel1);
            Controls.Add(createOrderbtn);
            Controls.Add(label3);
            Controls.Add(ordertotallbl);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
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
        private Label label2;
        private Label label7;
        private Label ordertotallbl;
        private Label label10;
        private TextBox dealerinfoBox;
        private Panel panel2;
        private PictureBox pictureBox1;
        private DateTimePicker orderDateBox;
        private TextBox dealerIDBox;
        private Label label1;
        private TextBox goodsAddressBox;
        private Label label11;
        private Label label12;
        private TextBox dealerNameBox;
        private Label label4;
        private Label label5;
        private TextBox phoneNumBox;
        private Label label8;
        private TextBox dealerCompanyBox;
        private SplitContainer splitContainer1;
        private Label label14;
        private Label label13;
        private ComboBox comboBox1;
    }
}