namespace ITP4519M
{
    partial class GRN
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label12 = new Label();
            grnCreatebtn = new Button();
            deliveryClearbtn = new Button();
            grnDateTimePicker = new DateTimePicker();
            CloseButton = new Button();
            grnerrorlbl = new Label();
            grnProductData = new DataGridView();
            SupplierID = new DataGridViewTextBoxColumn();
            ProductID = new DataGridViewTextBoxColumn();
            OrderQuantity = new DataGridViewTextBoxColumn();
            WareHouse = new DataGridViewTextBoxColumn();
            ReceivedQty = new DataGridViewTextBoxColumn();
            grnPOIDbox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)grnProductData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 18);
            label1.Name = "label1";
            label1.Size = new Size(121, 24);
            label1.TabIndex = 0;
            label1.Text = "Create GRN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 66);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 1;
            label2.Text = "Notes Information";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(83, 128);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "* PO ID :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(41, 386);
            label12.Name = "label12";
            label12.Size = new Size(123, 20);
            label12.TabIndex = 11;
            label12.Text = "* Receive Date :";
            // 
            // grnCreatebtn
            // 
            grnCreatebtn.BackColor = Color.FromArgb(0, 192, 0);
            grnCreatebtn.Font = new Font("Microsoft Sans Serif", 12F);
            grnCreatebtn.ForeColor = Color.White;
            grnCreatebtn.Location = new Point(166, 487);
            grnCreatebtn.Margin = new Padding(5, 4, 5, 4);
            grnCreatebtn.Name = "grnCreatebtn";
            grnCreatebtn.Size = new Size(171, 39);
            grnCreatebtn.TabIndex = 12;
            grnCreatebtn.Text = "Create";
            grnCreatebtn.UseVisualStyleBackColor = false;
            grnCreatebtn.Click += grnCreatebtn_Click;
            // 
            // deliveryClearbtn
            // 
            deliveryClearbtn.BackColor = Color.Red;
            deliveryClearbtn.Font = new Font("Microsoft Sans Serif", 12F);
            deliveryClearbtn.ForeColor = Color.White;
            deliveryClearbtn.Location = new Point(361, 494);
            deliveryClearbtn.Margin = new Padding(4, 3, 4, 3);
            deliveryClearbtn.Name = "deliveryClearbtn";
            deliveryClearbtn.Size = new Size(83, 32);
            deliveryClearbtn.TabIndex = 27;
            deliveryClearbtn.Text = "Clear";
            deliveryClearbtn.UseVisualStyleBackColor = false;
            deliveryClearbtn.Click += deliveryClearbtn_Click;
            // 
            // grnDateTimePicker
            // 
            grnDateTimePicker.Location = new Point(183, 386);
            grnDateTimePicker.Name = "grnDateTimePicker";
            grnDateTimePicker.Size = new Size(212, 23);
            grnDateTimePicker.TabIndex = 28;
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(513, 3);
            CloseButton.Margin = new Padding(2);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 37);
            CloseButton.TabIndex = 30;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // grnerrorlbl
            // 
            grnerrorlbl.AutoSize = true;
            grnerrorlbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grnerrorlbl.ForeColor = Color.Red;
            grnerrorlbl.Location = new Point(144, 440);
            grnerrorlbl.Name = "grnerrorlbl";
            grnerrorlbl.RightToLeft = RightToLeft.No;
            grnerrorlbl.Size = new Size(193, 21);
            grnerrorlbl.TabIndex = 31;
            grnerrorlbl.Text = "* column cannot be empty";
            grnerrorlbl.Visible = false;
            grnerrorlbl.Click += grnerrorlbl_Click;
            // 
            // grnProductData
            // 
            grnProductData.AllowUserToAddRows = false;
            grnProductData.AllowUserToDeleteRows = false;
            grnProductData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grnProductData.BackgroundColor = SystemColors.ButtonFace;
            grnProductData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grnProductData.Columns.AddRange(new DataGridViewColumn[] { SupplierID, ProductID, OrderQuantity, WareHouse, ReceivedQty });
            grnProductData.Location = new Point(10, 171);
            grnProductData.Margin = new Padding(3, 4, 3, 4);
            grnProductData.Name = "grnProductData";
            grnProductData.RowHeadersVisible = false;
            grnProductData.RowHeadersWidth = 51;
            grnProductData.RowTemplate.Height = 24;
            grnProductData.Size = new Size(542, 172);
            grnProductData.TabIndex = 62;
            // 
            // SupplierID
            // 
            SupplierID.HeaderText = "SupplierID";
            SupplierID.MinimumWidth = 6;
            SupplierID.Name = "SupplierID";
            // 
            // ProductID
            // 
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            // 
            // OrderQuantity
            // 
            OrderQuantity.HeaderText = "OrderQuantity";
            OrderQuantity.MinimumWidth = 6;
            OrderQuantity.Name = "OrderQuantity";
            // 
            // WareHouse
            // 
            WareHouse.HeaderText = "WareHouse";
            WareHouse.MinimumWidth = 6;
            WareHouse.Name = "WareHouse";
            // 
            // ReceivedQty
            // 
            ReceivedQty.HeaderText = "Received Qty";
            ReceivedQty.MinimumWidth = 6;
            ReceivedQty.Name = "ReceivedQty";
            // 
            // grnPOIDbox
            // 
            grnPOIDbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            grnPOIDbox.AutoCompleteSource = AutoCompleteSource.ListItems;
            grnPOIDbox.FormattingEnabled = true;
            grnPOIDbox.Location = new Point(183, 125);
            grnPOIDbox.Margin = new Padding(3, 2, 3, 2);
            grnPOIDbox.Name = "grnPOIDbox";
            grnPOIDbox.Size = new Size(198, 23);
            grnPOIDbox.TabIndex = 104;
            grnPOIDbox.SelectedIndexChanged += grnPOIDbox_SelectedIndexChanged;
            // 
            // GRN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(557, 578);
            Controls.Add(grnPOIDbox);
            Controls.Add(grnProductData);
            Controls.Add(grnerrorlbl);
            Controls.Add(CloseButton);
            Controls.Add(grnDateTimePicker);
            Controls.Add(deliveryClearbtn);
            Controls.Add(grnCreatebtn);
            Controls.Add(label12);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "GRN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GRN";
            Load += GRN_Load;
            MouseDown += Dashboard_MouseDown;
            MouseMove += Dashboard_MouseMove;
            MouseUp += Dashboard_MouseUp;
            ((System.ComponentModel.ISupportInitialize)grnProductData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label12;
        private Button grnCreatebtn;
        private Button deliveryClearbtn;
        private DateTimePicker grnDateTimePicker;
        private Button CloseButton;
        private Label grnerrorlbl;
        private DataGridView grnProductData;
        private DataGridViewTextBoxColumn SupplierID;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn OrderQuantity;
        private DataGridViewTextBoxColumn WareHouse;
        private DataGridViewTextBoxColumn ReceivedQty;
        private ComboBox grnPOIDbox;
    }
}