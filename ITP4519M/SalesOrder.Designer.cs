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
            this.CloseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dealerNameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.invoiceAddressBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.goodsAddressBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dealerIDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderIDBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.orderStatusBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dealerCompanyBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.orderDateBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.orderCompleteDateBox = new System.Windows.Forms.TextBox();
            this.phoneNumBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(630, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 38);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sales Order Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(247, 200);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Dealer Name";
            // 
            // dealerNameBox
            // 
            this.dealerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerNameBox.Location = new System.Drawing.Point(250, 224);
            this.dealerNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.dealerNameBox.Name = "dealerNameBox";
            this.dealerNameBox.Size = new System.Drawing.Size(187, 27);
            this.dealerNameBox.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 566);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Invoice Address";
            // 
            // invoiceAddressBox
            // 
            this.invoiceAddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceAddressBox.Location = new System.Drawing.Point(22, 590);
            this.invoiceAddressBox.Margin = new System.Windows.Forms.Padding(4);
            this.invoiceAddressBox.Name = "invoiceAddressBox";
            this.invoiceAddressBox.Size = new System.Drawing.Size(631, 27);
            this.invoiceAddressBox.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Products";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 505);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Goods Delivery Address";
            // 
            // goodsAddressBox
            // 
            this.goodsAddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsAddressBox.Location = new System.Drawing.Point(23, 529);
            this.goodsAddressBox.Margin = new System.Windows.Forms.Padding(4);
            this.goodsAddressBox.Name = "goodsAddressBox";
            this.goodsAddressBox.PasswordChar = '*';
            this.goodsAddressBox.Size = new System.Drawing.Size(633, 27);
            this.goodsAddressBox.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Dealer ID";
            // 
            // dealerIDBox
            // 
            this.dealerIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerIDBox.Location = new System.Drawing.Point(19, 224);
            this.dealerIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.dealerIDBox.Name = "dealerIDBox";
            this.dealerIDBox.PasswordChar = '*';
            this.dealerIDBox.Size = new System.Drawing.Size(187, 27);
            this.dealerIDBox.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Order ID";
            // 
            // orderIDBox
            // 
            this.orderIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDBox.Location = new System.Drawing.Point(20, 89);
            this.orderIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderIDBox.Name = "orderIDBox";
            this.orderIDBox.Size = new System.Drawing.Size(185, 27);
            this.orderIDBox.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(247, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "Order Status";
            // 
            // orderStatusBox
            // 
            this.orderStatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderStatusBox.Location = new System.Drawing.Point(248, 89);
            this.orderStatusBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderStatusBox.Name = "orderStatusBox";
            this.orderStatusBox.Size = new System.Drawing.Size(138, 27);
            this.orderStatusBox.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 267);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Dealer Company";
            // 
            // dealerCompanyBox
            // 
            this.dealerCompanyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerCompanyBox.Location = new System.Drawing.Point(248, 291);
            this.dealerCompanyBox.Margin = new System.Windows.Forms.Padding(4);
            this.dealerCompanyBox.Name = "dealerCompanyBox";
            this.dealerCompanyBox.Size = new System.Drawing.Size(268, 27);
            this.dealerCompanyBox.TabIndex = 59;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(634, 135);
            this.dataGridView1.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(247, 130);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 63;
            this.label9.Text = "Order Date";
            // 
            // orderDateBox
            // 
            this.orderDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateBox.Location = new System.Drawing.Point(248, 154);
            this.orderDateBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderDateBox.Name = "orderDateBox";
            this.orderDateBox.Size = new System.Drawing.Size(185, 27);
            this.orderDateBox.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 130);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 20);
            this.label12.TabIndex = 65;
            this.label12.Text = "Order Complete Date";
            // 
            // orderCompleteDateBox
            // 
            this.orderCompleteDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCompleteDateBox.Location = new System.Drawing.Point(21, 154);
            this.orderCompleteDateBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderCompleteDateBox.Name = "orderCompleteDateBox";
            this.orderCompleteDateBox.Size = new System.Drawing.Size(185, 27);
            this.orderCompleteDateBox.TabIndex = 64;
            // 
            // phoneNumBox
            // 
            this.phoneNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumBox.Location = new System.Drawing.Point(20, 291);
            this.phoneNumBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumBox.Name = "phoneNumBox";
            this.phoneNumBox.Size = new System.Drawing.Size(187, 27);
            this.phoneNumBox.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(482, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 43);
            this.button1.TabIndex = 68;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(673, 690);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phoneNumBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.orderCompleteDateBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.orderDateBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dealerCompanyBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.orderStatusBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dealerNameBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.invoiceAddressBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goodsAddressBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dealerIDBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderIDBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesOrder";
            this.Text = "SalesOrder";
            this.Load += new System.EventHandler(this.SalesOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox orderDateBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox orderCompleteDateBox;
        private System.Windows.Forms.TextBox phoneNumBox;
        private System.Windows.Forms.Button button1;
    }
}