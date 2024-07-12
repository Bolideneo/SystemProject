using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            orderItemdata = new DataGridView();
            productIDColumn = new DataGridViewTextBoxColumn();
            productNameColumn = new DataGridViewTextBoxColumn();
            quantityColumn = new DataGridViewTextBoxColumn();
            unitPriceColumn = new DataGridViewTextBoxColumn();
            phoneNumBox = new TextBox();
            saveOrderbtn = new Button();
            orderAccemblyOrderItemdata = new DataGridView();
            check = new DataGridViewCheckBoxColumn();
            orderAccemblyAssignbox = new TextBox();
            orderAccemblyAssignbtn = new Button();
            checkboxSelectedbtn = new Button();
            checkBox = new CheckBox();
            accemblyerrorlbl = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)orderItemdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderAccemblyOrderItemdata).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(799, 4);
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
            label3.Size = new Size(181, 30);
            label3.TabIndex = 16;
            label3.Text = "Order Accembly";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(199, 139);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(99, 17);
            label11.TabIndex = 54;
            label11.Text = "Dealer Name :";
            // 
            // dealerNameBox
            // 
            dealerNameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerNameBox.Location = new Point(351, 139);
            dealerNameBox.Margin = new Padding(6, 7, 6, 7);
            dealerNameBox.Name = "dealerNameBox";
            dealerNameBox.Size = new Size(204, 23);
            dealerNameBox.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(188, 175);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 17);
            label5.TabIndex = 48;
            label5.Text = "Phone Number :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 102);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 44;
            label1.Text = "Dealer ID :";
            // 
            // dealerIDBox
            // 
            dealerIDBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerIDBox.Location = new Point(352, 99);
            dealerIDBox.Margin = new Padding(6, 7, 6, 7);
            dealerIDBox.Name = "dealerIDBox";
            dealerIDBox.Size = new Size(204, 23);
            dealerIDBox.TabIndex = 43;
            dealerIDBox.KeyDown += dealerIDBox_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(228, 62);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 42;
            label2.Text = "Order ID :";
            // 
            // orderIDBox
            // 
            orderIDBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderIDBox.Location = new Point(351, 62);
            orderIDBox.Margin = new Padding(6, 7, 6, 7);
            orderIDBox.Name = "orderIDBox";
            orderIDBox.Size = new Size(204, 23);
            orderIDBox.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(176, 216);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(121, 17);
            label8.TabIndex = 60;
            label8.Text = "Dealer Company :";
            // 
            // dealerCompanyBox
            // 
            dealerCompanyBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dealerCompanyBox.Location = new Point(352, 216);
            dealerCompanyBox.Margin = new Padding(6, 7, 6, 7);
            dealerCompanyBox.Name = "dealerCompanyBox";
            dealerCompanyBox.Size = new Size(200, 23);
            dealerCompanyBox.TabIndex = 59;
            // 
            // orderItemdata
            // 
            orderItemdata.AllowUserToAddRows = false;
            orderItemdata.AllowUserToDeleteRows = false;
            orderItemdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderItemdata.BackgroundColor = SystemColors.ButtonFace;
            orderItemdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            orderItemdata.DefaultCellStyle = dataGridViewCellStyle1;
            orderItemdata.Location = new Point(69, 643);
            orderItemdata.Margin = new Padding(3, 5, 3, 5);
            orderItemdata.Name = "orderItemdata";
            orderItemdata.RowHeadersVisible = false;
            orderItemdata.RowHeadersWidth = 51;
            orderItemdata.RowTemplate.Height = 24;
            orderItemdata.Size = new Size(679, 236);
            orderItemdata.TabIndex = 61;
            orderItemdata.CellClick += orderItemdata_CellClick;
            orderItemdata.CellDoubleClick += productOfOrderdata_CellDoubleClick;
            orderItemdata.CellEndEdit += orderItemdata_CellEndEdit;
            orderItemdata.RowsAdded += orderItemdata_RowsAdded;
            // 
            // productIDColumn
            // 
            productIDColumn.MinimumWidth = 6;
            productIDColumn.Name = "productIDColumn";
            productIDColumn.Width = 125;
            // 
            // productNameColumn
            // 
            productNameColumn.MinimumWidth = 6;
            productNameColumn.Name = "productNameColumn";
            productNameColumn.Width = 125;
            // 
            // quantityColumn
            // 
            quantityColumn.MinimumWidth = 6;
            quantityColumn.Name = "quantityColumn";
            quantityColumn.Width = 125;
            // 
            // unitPriceColumn
            // 
            unitPriceColumn.MinimumWidth = 6;
            unitPriceColumn.Name = "unitPriceColumn";
            unitPriceColumn.Width = 125;
            // 
            // phoneNumBox
            // 
            phoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumBox.Location = new Point(352, 175);
            phoneNumBox.Margin = new Padding(6, 7, 6, 7);
            phoneNumBox.Name = "phoneNumBox";
            phoneNumBox.Size = new Size(200, 23);
            phoneNumBox.TabIndex = 66;
            phoneNumBox.TextChanged += phoneNumBox_TextChanged;
            // 
            // saveOrderbtn
            // 
            saveOrderbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveOrderbtn.Location = new Point(658, 887);
            saveOrderbtn.Name = "saveOrderbtn";
            saveOrderbtn.Size = new Size(150, 40);
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
            orderAccemblyOrderItemdata.Columns.AddRange(new DataGridViewColumn[] { check });
            orderAccemblyOrderItemdata.Location = new Point(69, 310);
            orderAccemblyOrderItemdata.Margin = new Padding(3, 5, 3, 5);
            orderAccemblyOrderItemdata.Name = "orderAccemblyOrderItemdata";
            orderAccemblyOrderItemdata.RowHeadersVisible = false;
            orderAccemblyOrderItemdata.RowHeadersWidth = 51;
            orderAccemblyOrderItemdata.RowTemplate.Height = 24;
            orderAccemblyOrderItemdata.Size = new Size(679, 233);
            orderAccemblyOrderItemdata.TabIndex = 72;
            orderAccemblyOrderItemdata.CellContentClick += orderAccemblyOrderItemdata_CellContentClick;
            orderAccemblyOrderItemdata.CellDoubleClick += orderAccemblyOrderItemdata_CellDoubleClick;
            // 
            // check
            // 
            check.HeaderText = "All";
            check.MinimumWidth = 6;
            check.Name = "check";
            // 
            // orderAccemblyAssignbox
            // 
            orderAccemblyAssignbox.AutoCompleteMode = AutoCompleteMode.Suggest;
            orderAccemblyAssignbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            orderAccemblyAssignbox.Location = new Point(239, 267);
            orderAccemblyAssignbox.Name = "orderAccemblyAssignbox";
            orderAccemblyAssignbox.Size = new Size(285, 23);
            orderAccemblyAssignbox.TabIndex = 75;
            // 
            // orderAccemblyAssignbtn
            // 
            orderAccemblyAssignbtn.Location = new Point(631, 256);
            orderAccemblyAssignbtn.Name = "orderAccemblyAssignbtn";
            orderAccemblyAssignbtn.Size = new Size(117, 46);
            orderAccemblyAssignbtn.TabIndex = 76;
            orderAccemblyAssignbtn.Text = "Assgin";
            orderAccemblyAssignbtn.UseVisualStyleBackColor = true;
            orderAccemblyAssignbtn.Click += orderAccemblyAssignbtn_Click;
            // 
            // checkboxSelectedbtn
            // 
            checkboxSelectedbtn.BackColor = Color.LimeGreen;
            checkboxSelectedbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkboxSelectedbtn.ForeColor = Color.Black;
            checkboxSelectedbtn.Location = new Point(334, 540);
            checkboxSelectedbtn.Name = "checkboxSelectedbtn";
            checkboxSelectedbtn.Size = new Size(116, 46);
            checkboxSelectedbtn.TabIndex = 77;
            checkboxSelectedbtn.Text = "Assgin ↓";
            checkboxSelectedbtn.UseVisualStyleBackColor = false;
            checkboxSelectedbtn.Click += checkboxSelectedbtn_Click;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(120, 317);
            checkBox.Margin = new Padding(3, 2, 3, 2);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(15, 14);
            checkBox.TabIndex = 78;
            checkBox.UseVisualStyleBackColor = true;
            checkBox.Click += checkBox_Click;
            // 
            // accemblyerrorlbl
            // 
            accemblyerrorlbl.AutoSize = true;
            accemblyerrorlbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accemblyerrorlbl.ForeColor = Color.Red;
            accemblyerrorlbl.Location = new Point(487, 621);
            accemblyerrorlbl.Margin = new Padding(4, 0, 4, 0);
            accemblyerrorlbl.Name = "accemblyerrorlbl";
            accemblyerrorlbl.Size = new Size(189, 17);
            accemblyerrorlbl.TabIndex = 81;
            accemblyerrorlbl.Text = "Please enter a valid number.";
            accemblyerrorlbl.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.MenuBar;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(69, 618);
            label4.Name = "label4";
            label4.Size = new Size(300, 20);
            label4.TabIndex = 82;
            label4.Text = "Double click Cell to remove unwant product";
            // 
            // OrderAccembly
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(850, 939);
            Controls.Add(label4);
            Controls.Add(accemblyerrorlbl);
            Controls.Add(checkBox);
            Controls.Add(checkboxSelectedbtn);
            Controls.Add(orderAccemblyAssignbtn);
            Controls.Add(orderAccemblyAssignbox);
            Controls.Add(orderAccemblyOrderItemdata);
            Controls.Add(saveOrderbtn);
            Controls.Add(phoneNumBox);
            Controls.Add(orderItemdata);
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
            Name = "OrderAccembly";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderForm1";
            Load += OrderAccembly_Load;
            MouseDown += Dashboard_MouseDown;
            MouseMove += Dashboard_MouseMove;
            MouseUp += Dashboard_MouseUp;
            ((System.ComponentModel.ISupportInitialize)orderItemdata).EndInit();
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
        private System.Windows.Forms.DataGridView orderItemdata;
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
        private TextBox orderAccemblyAssignbox;
        private Button orderAccemblyAssignbtn;
        private Button checkboxSelectedbtn;
        private CheckBox checkBox;
        private Label accemblyerrorlbl;
        private DataGridViewCheckBoxColumn check;
        private Label label4;
    }
}