﻿using static ProgramMethod.ProgramMethod;

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
            grnDateTimePicker = new BorderDateTimePicker();
            CloseButton = new Button();
            grnerrorlbl = new Label();
            grnProductData = new DataGridView();
            SupplierID = new DataGridViewTextBoxColumn();
            ProductID = new DataGridViewTextBoxColumn();
            OrderQuantity = new DataGridViewTextBoxColumn();
            WareHouse = new DataGridViewTextBoxColumn();
            ReceivedQty = new DataGridViewTextBoxColumn();
            grnPOIDbox = new ComboBox();
            errorlbl = new Label();
            orderDate = new Label();
            ((System.ComponentModel.ISupportInitialize)grnProductData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(154, 29);
            label1.TabIndex = 0;
            label1.Text = "Create GRN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 88);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 1;
            label2.Text = "Notes Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(137, 153);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 2;
            label3.Text = "* PO ID :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(109, 510);
            label12.Name = "label12";
            label12.Size = new Size(152, 25);
            label12.TabIndex = 11;
            label12.Text = "* Receive Date :";
            // 
            // grnCreatebtn
            // 
            grnCreatebtn.BackColor = Color.FromArgb(0, 192, 0);
            grnCreatebtn.Font = new Font("Microsoft Sans Serif", 12F);
            grnCreatebtn.ForeColor = Color.White;
            grnCreatebtn.Location = new Point(234, 654);
            grnCreatebtn.Margin = new Padding(6, 5, 6, 5);
            grnCreatebtn.Name = "grnCreatebtn";
            grnCreatebtn.Size = new Size(195, 52);
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
            deliveryClearbtn.Location = new Point(455, 659);
            deliveryClearbtn.Margin = new Padding(5, 4, 5, 4);
            deliveryClearbtn.Name = "deliveryClearbtn";
            deliveryClearbtn.Size = new Size(74, 43);
            deliveryClearbtn.TabIndex = 27;
            deliveryClearbtn.Text = "Clear";
            deliveryClearbtn.UseVisualStyleBackColor = false;
            deliveryClearbtn.Click += deliveryClearbtn_Click;
            // 
            // grnDateTimePicker
            // 
            grnDateTimePicker.BorderColor = Color.Black;
            grnDateTimePicker.Location = new Point(271, 510);
            grnDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            grnDateTimePicker.Name = "grnDateTimePicker";
            grnDateTimePicker.Size = new Size(265, 27);
            grnDateTimePicker.TabIndex = 28;
            grnDateTimePicker.ValueChanged += grnDateTimePicker_ValueChanged;
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(649, 4);
            CloseButton.Margin = new Padding(2, 3, 2, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(40, 49);
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
            grnerrorlbl.Location = new Point(234, 579);
            grnerrorlbl.Name = "grnerrorlbl";
            grnerrorlbl.RightToLeft = RightToLeft.No;
            grnerrorlbl.Size = new Size(243, 28);
            grnerrorlbl.TabIndex = 31;
            grnerrorlbl.Text = "* column cannot be empty";
            grnerrorlbl.Visible = false;
            // 
            // grnProductData
            // 
            grnProductData.AllowUserToAddRows = false;
            grnProductData.AllowUserToDeleteRows = false;
            grnProductData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grnProductData.BackgroundColor = SystemColors.ButtonFace;
            grnProductData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grnProductData.Columns.AddRange(new DataGridViewColumn[] { SupplierID, ProductID, OrderQuantity, WareHouse, ReceivedQty });
            grnProductData.Location = new Point(11, 228);
            grnProductData.Margin = new Padding(3, 5, 3, 5);
            grnProductData.Name = "grnProductData";
            grnProductData.RowHeadersVisible = false;
            grnProductData.RowHeadersWidth = 51;
            grnProductData.RowTemplate.Height = 24;
            grnProductData.Size = new Size(667, 268);
            grnProductData.TabIndex = 62;
            grnProductData.CellEndEdit += grnProductData_CellEndEdit;
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
            WareHouse.HeaderText = "* WareHouse";
            WareHouse.MinimumWidth = 6;
            WareHouse.Name = "WareHouse";
            // 
            // ReceivedQty
            // 
            ReceivedQty.HeaderText = "* Received Qty";
            ReceivedQty.MinimumWidth = 6;
            ReceivedQty.Name = "ReceivedQty";
            // 
            // grnPOIDbox
            // 
            grnPOIDbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            grnPOIDbox.AutoCompleteSource = AutoCompleteSource.ListItems;
            grnPOIDbox.FormattingEnabled = true;
            grnPOIDbox.Location = new Point(251, 149);
            grnPOIDbox.Name = "grnPOIDbox";
            grnPOIDbox.Size = new Size(226, 28);
            grnPOIDbox.TabIndex = 104;
            grnPOIDbox.SelectedIndexChanged += grnPOIDbox_SelectedIndexChanged;
            // 
            // errorlbl
            // 
            errorlbl.AutoSize = true;
            errorlbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorlbl.ForeColor = Color.Red;
            errorlbl.Location = new Point(455, 203);
            errorlbl.Margin = new Padding(5, 0, 5, 0);
            errorlbl.Name = "errorlbl";
            errorlbl.Size = new Size(221, 20);
            errorlbl.TabIndex = 105;
            errorlbl.Text = "Please enter a valid number.";
            errorlbl.Visible = false;
            // 
            // orderDate
            // 
            orderDate.AutoSize = true;
            orderDate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderDate.ForeColor = Color.Red;
            orderDate.Location = new Point(271, 543);
            orderDate.Margin = new Padding(5, 0, 5, 0);
            orderDate.Name = "orderDate";
            orderDate.Size = new Size(204, 20);
            orderDate.TabIndex = 106;
            orderDate.Text = "Please select a valid date.";
            orderDate.Visible = false;
            // 
            // GRN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(690, 771);
            Controls.Add(orderDate);
            Controls.Add(errorlbl);
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
            Margin = new Padding(3, 5, 3, 5);
            Name = "GRN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GRN";
            Load += GRN_Load;
            KeyDown += GRN_KeyDown;
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
        private ProgramMethod.ProgramMethod.BorderDateTimePicker grnDateTimePicker;
        private Button CloseButton;
        private Label grnerrorlbl;
        private DataGridView grnProductData;
        private ComboBox grnPOIDbox;
        private Label errorlbl;
        private DataGridViewTextBoxColumn SupplierID;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn OrderQuantity;
        private DataGridViewTextBoxColumn WareHouse;
        private DataGridViewTextBoxColumn ReceivedQty;
        private Label orderDate;
    }
}