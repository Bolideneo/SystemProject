namespace ITP4519M
{
    partial class Invoice
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
            InvoiceLabel1 = new Label();
            InvoiceLabel2 = new Label();
            InvoiceLabel3 = new Label();
            InvoiceLabel4 = new Label();
            InvoiceLabel5 = new Label();
            InvoiceLabel6 = new Label();
            InvoiceLabel7 = new Label();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            InvoiceLine1 = new Panel();
            panel3 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            InvoiceValue8 = new Label();
            panel4 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            InvoiceValue9 = new Label();
            panel5 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            InvoiceValue7 = new Label();
            InvoiceLabel8 = new Label();
            InvoiceLabel9 = new Label();
            InvoiceLabel10 = new Label();
            InvoiceLabel11 = new Label();
            panel2 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            InvoiceValue10 = new Label();
            InvoiceLabel16 = new Label();
            panel9 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            InvoiceValue15 = new Label();
            InvoiceLabel15 = new Label();
            panel10 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            InvoiceValue14 = new Label();
            InvoiceLabel13 = new Label();
            InvoiceLabel14 = new Label();
            InvoiceLabel12 = new Label();
            panel11 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            InvoiceValue11 = new Label();
            panel12 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            InvoiceValue13 = new Label();
            panel13 = new ProgramMethod.ProgramMethod.PanelBorderColor();
            InvoiceValue12 = new Label();
            panel14 = new Panel();
            InvoiceFormData = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Unit_Price = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            InvoiceLabel21 = new Label();
            InvoiceLabel17 = new Label();
            pictureBox5 = new PictureBox();
            InvoiceLabel19 = new Label();
            InvoiceLabel18 = new Label();
            InvoiceLabel20 = new Label();
            InvoiceValue1 = new Label();
            InvoiceValue2 = new Label();
            InvoiceValue3 = new Label();
            InvoiceValue4 = new Label();
            InvoiceValue5 = new Label();
            InvoiceValue6 = new Label();
            invoicePrintbtn = new Button();
            invoiceExitbtn = new Button();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InvoiceFormData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // InvoiceLabel1
            // 
            InvoiceLabel1.AutoSize = true;
            InvoiceLabel1.BackColor = SystemColors.ButtonFace;
            InvoiceLabel1.Font = new Font("Haettenschweiler", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InvoiceLabel1.ForeColor = Color.DarkOrange;
            InvoiceLabel1.Location = new Point(66, 40);
            InvoiceLabel1.Name = "InvoiceLabel1";
            InvoiceLabel1.Size = new Size(124, 50);
            InvoiceLabel1.TabIndex = 0;
            InvoiceLabel1.Text = "lnvoice";
            // 
            // InvoiceLabel2
            // 
            InvoiceLabel2.AutoSize = true;
            InvoiceLabel2.BackColor = SystemColors.ButtonFace;
            InvoiceLabel2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel2.ForeColor = Color.Black;
            InvoiceLabel2.Location = new Point(277, 41);
            InvoiceLabel2.Name = "InvoiceLabel2";
            InvoiceLabel2.Size = new Size(119, 24);
            InvoiceLabel2.TabIndex = 1;
            InvoiceLabel2.Text = "Date issued";
            InvoiceLabel2.Click += InvoiceLabel2_Click;
            // 
            // InvoiceLabel3
            // 
            InvoiceLabel3.AutoSize = true;
            InvoiceLabel3.BackColor = SystemColors.ButtonFace;
            InvoiceLabel3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel3.ForeColor = Color.Black;
            InvoiceLabel3.Location = new Point(488, 41);
            InvoiceLabel3.Name = "InvoiceLabel3";
            InvoiceLabel3.Size = new Size(81, 24);
            InvoiceLabel3.TabIndex = 2;
            InvoiceLabel3.Text = "Order #";
            // 
            // InvoiceLabel4
            // 
            InvoiceLabel4.AutoSize = true;
            InvoiceLabel4.BackColor = SystemColors.ButtonFace;
            InvoiceLabel4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel4.ForeColor = Color.Black;
            InvoiceLabel4.Location = new Point(673, 40);
            InvoiceLabel4.Name = "InvoiceLabel4";
            InvoiceLabel4.Size = new Size(124, 24);
            InvoiceLabel4.TabIndex = 3;
            InvoiceLabel4.Text = "Customer ID";
            // 
            // InvoiceLabel5
            // 
            InvoiceLabel5.AutoSize = true;
            InvoiceLabel5.BackColor = SystemColors.ButtonFace;
            InvoiceLabel5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel5.ForeColor = Color.Black;
            InvoiceLabel5.Location = new Point(68, 154);
            InvoiceLabel5.Name = "InvoiceLabel5";
            InvoiceLabel5.Size = new Size(117, 24);
            InvoiceLabel5.TabIndex = 4;
            InvoiceLabel5.Text = "Issued by : ";
            // 
            // InvoiceLabel6
            // 
            InvoiceLabel6.AutoSize = true;
            InvoiceLabel6.BackColor = SystemColors.ButtonFace;
            InvoiceLabel6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel6.ForeColor = Color.Black;
            InvoiceLabel6.Location = new Point(408, 154);
            InvoiceLabel6.Name = "InvoiceLabel6";
            InvoiceLabel6.Size = new Size(73, 24);
            InvoiceLabel6.TabIndex = 5;
            InvoiceLabel6.Text = "Bill to :";
            // 
            // InvoiceLabel7
            // 
            InvoiceLabel7.AutoSize = true;
            InvoiceLabel7.BackColor = SystemColors.ButtonFace;
            InvoiceLabel7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel7.ForeColor = Color.Black;
            InvoiceLabel7.Location = new Point(675, 154);
            InvoiceLabel7.Name = "InvoiceLabel7";
            InvoiceLabel7.Size = new Size(87, 24);
            InvoiceLabel7.TabIndex = 6;
            InvoiceLabel7.Text = "Ship to :";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // InvoiceLine1
            // 
            InvoiceLine1.BackColor = SystemColors.ControlDark;
            InvoiceLine1.BorderStyle = BorderStyle.Fixed3D;
            InvoiceLine1.ForeColor = SystemColors.ControlText;
            InvoiceLine1.Location = new Point(55, 130);
            InvoiceLine1.Name = "InvoiceLine1";
            InvoiceLine1.Size = new Size(765, 5);
            InvoiceLine1.TabIndex = 44;
            // 
            // panel3
            // 
            panel3.BorderColor = Color.DarkOrange;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.BorderWidth = 3;
            panel3.Controls.Add(InvoiceValue8);
            panel3.Location = new Point(283, 252);
            panel3.Name = "panel3";
            panel3.Size = new Size(149, 48);
            panel3.TabIndex = 46;
            // 
            // InvoiceValue8
            // 
            InvoiceValue8.AutoSize = true;
            InvoiceValue8.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            InvoiceValue8.Location = new Point(6, 16);
            InvoiceValue8.Name = "InvoiceValue8";
            InvoiceValue8.Size = new Size(96, 17);
            InvoiceValue8.TabIndex = 84;
            InvoiceValue8.Text = "InvoiceValue8";
            // 
            // panel4
            // 
            panel4.BorderColor = Color.DarkOrange;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.BorderWidth = 3;
            panel4.Controls.Add(InvoiceValue9);
            panel4.Location = new Point(430, 252);
            panel4.Name = "panel4";
            panel4.Size = new Size(226, 48);
            panel4.TabIndex = 47;
            // 
            // InvoiceValue9
            // 
            InvoiceValue9.AutoSize = true;
            InvoiceValue9.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            InvoiceValue9.Location = new Point(10, 16);
            InvoiceValue9.Name = "InvoiceValue9";
            InvoiceValue9.Size = new Size(96, 17);
            InvoiceValue9.TabIndex = 85;
            InvoiceValue9.Text = "InvoiceValue9";
            // 
            // panel5
            // 
            panel5.BorderColor = Color.DarkOrange;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.BorderWidth = 3;
            panel5.Controls.Add(InvoiceValue7);
            panel5.Cursor = Cursors.No;
            panel5.Location = new Point(59, 252);
            panel5.Name = "panel5";
            panel5.Size = new Size(227, 48);
            panel5.TabIndex = 48;
            // 
            // InvoiceValue7
            // 
            InvoiceValue7.AutoSize = true;
            InvoiceValue7.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            InvoiceValue7.Location = new Point(7, 16);
            InvoiceValue7.Name = "InvoiceValue7";
            InvoiceValue7.Size = new Size(96, 17);
            InvoiceValue7.TabIndex = 83;
            InvoiceValue7.Text = "InvoiceValue7";
            // 
            // InvoiceLabel8
            // 
            InvoiceLabel8.AutoSize = true;
            InvoiceLabel8.BackColor = SystemColors.ButtonFace;
            InvoiceLabel8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel8.ForeColor = Color.Black;
            InvoiceLabel8.Location = new Point(69, 242);
            InvoiceLabel8.Name = "InvoiceLabel8";
            InvoiceLabel8.Size = new Size(98, 20);
            InvoiceLabel8.TabIndex = 49;
            InvoiceLabel8.Text = "Sales Date";
            // 
            // InvoiceLabel9
            // 
            InvoiceLabel9.AutoSize = true;
            InvoiceLabel9.BackColor = SystemColors.ButtonFace;
            InvoiceLabel9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel9.ForeColor = Color.Black;
            InvoiceLabel9.Location = new Point(294, 241);
            InvoiceLabel9.Name = "InvoiceLabel9";
            InvoiceLabel9.Size = new Size(58, 20);
            InvoiceLabel9.TabIndex = 50;
            InvoiceLabel9.Text = "P.O. #";
            // 
            // InvoiceLabel10
            // 
            InvoiceLabel10.AutoSize = true;
            InvoiceLabel10.BackColor = SystemColors.ButtonFace;
            InvoiceLabel10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel10.ForeColor = Color.Black;
            InvoiceLabel10.Location = new Point(443, 241);
            InvoiceLabel10.Name = "InvoiceLabel10";
            InvoiceLabel10.Size = new Size(109, 20);
            InvoiceLabel10.TabIndex = 51;
            InvoiceLabel10.Text = "Salesperson";
            // 
            // InvoiceLabel11
            // 
            InvoiceLabel11.AutoSize = true;
            InvoiceLabel11.BackColor = SystemColors.ButtonFace;
            InvoiceLabel11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel11.ForeColor = Color.Black;
            InvoiceLabel11.Location = new Point(662, 241);
            InvoiceLabel11.Name = "InvoiceLabel11";
            InvoiceLabel11.Size = new Size(116, 20);
            InvoiceLabel11.TabIndex = 57;
            InvoiceLabel11.Text = "Delivery Date";
            // 
            // panel2
            // 
            panel2.BorderColor = Color.DarkOrange;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.BorderWidth = 3;
            panel2.Controls.Add(InvoiceValue10);
            panel2.Location = new Point(652, 252);
            panel2.Name = "panel2";
            panel2.Size = new Size(169, 48);
            panel2.TabIndex = 53;
            // 
            // InvoiceValue10
            // 
            InvoiceValue10.AutoSize = true;
            InvoiceValue10.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            InvoiceValue10.Location = new Point(12, 16);
            InvoiceValue10.Name = "InvoiceValue10";
            InvoiceValue10.Size = new Size(104, 17);
            InvoiceValue10.TabIndex = 86;
            InvoiceValue10.Text = "InvoiceValue10";
            // 
            // InvoiceLabel16
            // 
            InvoiceLabel16.AutoSize = true;
            InvoiceLabel16.BackColor = SystemColors.ButtonFace;
            InvoiceLabel16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel16.ForeColor = Color.Black;
            InvoiceLabel16.Location = new Point(675, 592);
            InvoiceLabel16.Name = "InvoiceLabel16";
            InvoiceLabel16.Size = new Size(49, 20);
            InvoiceLabel16.TabIndex = 69;
            InvoiceLabel16.Text = "Total";
            // 
            // panel9
            // 
            panel9.BorderColor = Color.DarkOrange;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.BorderWidth = 3;
            panel9.Controls.Add(InvoiceValue15);
            panel9.Location = new Point(667, 603);
            panel9.Name = "panel9";
            panel9.Size = new Size(142, 48);
            panel9.TabIndex = 64;
            // 
            // InvoiceValue15
            // 
            InvoiceValue15.AutoSize = true;
            InvoiceValue15.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            InvoiceValue15.Location = new Point(5, 16);
            InvoiceValue15.Name = "InvoiceValue15";
            InvoiceValue15.Size = new Size(104, 17);
            InvoiceValue15.TabIndex = 88;
            InvoiceValue15.Text = "InvoiceValue15";
            // 
            // InvoiceLabel15
            // 
            InvoiceLabel15.AutoSize = true;
            InvoiceLabel15.BackColor = SystemColors.ButtonFace;
            InvoiceLabel15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel15.ForeColor = Color.Black;
            InvoiceLabel15.Location = new Point(531, 592);
            InvoiceLabel15.Name = "InvoiceLabel15";
            InvoiceLabel15.Size = new Size(99, 20);
            InvoiceLabel15.TabIndex = 68;
            InvoiceLabel15.Text = "Other Fees";
            // 
            // panel10
            // 
            panel10.BorderColor = Color.DarkOrange;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.BorderWidth = 3;
            panel10.Controls.Add(InvoiceValue14);
            panel10.Location = new Point(521, 603);
            panel10.Name = "panel10";
            panel10.Size = new Size(154, 48);
            panel10.TabIndex = 62;
            // 
            // InvoiceValue14
            // 
            InvoiceValue14.AutoSize = true;
            InvoiceValue14.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            InvoiceValue14.Location = new Point(7, 16);
            InvoiceValue14.Name = "InvoiceValue14";
            InvoiceValue14.Size = new Size(104, 17);
            InvoiceValue14.TabIndex = 87;
            InvoiceValue14.Text = "InvoiceValue14";
            // 
            // InvoiceLabel13
            // 
            InvoiceLabel13.AutoSize = true;
            InvoiceLabel13.BackColor = SystemColors.ButtonFace;
            InvoiceLabel13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel13.ForeColor = Color.Black;
            InvoiceLabel13.Location = new Point(233, 592);
            InvoiceLabel13.Name = "InvoiceLabel13";
            InvoiceLabel13.Size = new Size(89, 20);
            InvoiceLabel13.TabIndex = 66;
            InvoiceLabel13.Text = "Discounts";
            // 
            // InvoiceLabel14
            // 
            InvoiceLabel14.AutoSize = true;
            InvoiceLabel14.BackColor = SystemColors.ButtonFace;
            InvoiceLabel14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel14.ForeColor = Color.Black;
            InvoiceLabel14.Location = new Point(391, 592);
            InvoiceLabel14.Name = "InvoiceLabel14";
            InvoiceLabel14.Size = new Size(76, 20);
            InvoiceLabel14.TabIndex = 67;
            InvoiceLabel14.Text = "Handing";
            // 
            // InvoiceLabel12
            // 
            InvoiceLabel12.AutoSize = true;
            InvoiceLabel12.BackColor = SystemColors.ButtonFace;
            InvoiceLabel12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel12.ForeColor = Color.Black;
            InvoiceLabel12.Location = new Point(61, 592);
            InvoiceLabel12.Name = "InvoiceLabel12";
            InvoiceLabel12.Size = new Size(77, 20);
            InvoiceLabel12.TabIndex = 65;
            InvoiceLabel12.Text = "Subtotal";
            // 
            // panel11
            // 
            panel11.BorderColor = Color.DarkOrange;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.BorderWidth = 3;
            panel11.Controls.Add(InvoiceValue11);
            panel11.Cursor = Cursors.No;
            panel11.Location = new Point(50, 603);
            panel11.Name = "panel11";
            panel11.Size = new Size(169, 48);
            panel11.TabIndex = 63;
            // 
            // InvoiceValue11
            // 
            InvoiceValue11.AutoSize = true;
            InvoiceValue11.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            InvoiceValue11.Location = new Point(13, 16);
            InvoiceValue11.Name = "InvoiceValue11";
            InvoiceValue11.Size = new Size(104, 17);
            InvoiceValue11.TabIndex = 84;
            InvoiceValue11.Text = "InvoiceValue11";
            // 
            // panel12
            // 
            panel12.BorderColor = Color.DarkOrange;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.BorderWidth = 3;
            panel12.Controls.Add(InvoiceValue13);
            panel12.Location = new Point(379, 603);
            panel12.Name = "panel12";
            panel12.Size = new Size(146, 48);
            panel12.TabIndex = 61;
            // 
            // InvoiceValue13
            // 
            InvoiceValue13.AutoSize = true;
            InvoiceValue13.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            InvoiceValue13.Location = new Point(9, 16);
            InvoiceValue13.Name = "InvoiceValue13";
            InvoiceValue13.Size = new Size(104, 17);
            InvoiceValue13.TabIndex = 86;
            InvoiceValue13.Text = "InvoiceValue13";
            // 
            // panel13
            // 
            panel13.BorderColor = Color.DarkOrange;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.BorderWidth = 3;
            panel13.Controls.Add(InvoiceValue12);
            panel13.Location = new Point(218, 603);
            panel13.Name = "panel13";
            panel13.Size = new Size(165, 48);
            panel13.TabIndex = 60;
            // 
            // InvoiceValue12
            // 
            InvoiceValue12.AutoSize = true;
            InvoiceValue12.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            InvoiceValue12.Location = new Point(12, 16);
            InvoiceValue12.Name = "InvoiceValue12";
            InvoiceValue12.Size = new Size(104, 17);
            InvoiceValue12.TabIndex = 85;
            InvoiceValue12.Text = "InvoiceValue12";
            // 
            // panel14
            // 
            panel14.BackColor = SystemColors.ControlDark;
            panel14.BorderStyle = BorderStyle.Fixed3D;
            panel14.ForeColor = SystemColors.ControlText;
            panel14.Location = new Point(46, 687);
            panel14.Name = "panel14";
            panel14.Size = new Size(765, 5);
            panel14.TabIndex = 45;
            // 
            // InvoiceFormData
            // 
            InvoiceFormData.AllowUserToAddRows = false;
            InvoiceFormData.AllowUserToDeleteRows = false;
            InvoiceFormData.BackgroundColor = SystemColors.Window;
            InvoiceFormData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvoiceFormData.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, Qty, Unit_Price, Discount });
            InvoiceFormData.Location = new Point(53, 325);
            InvoiceFormData.Name = "InvoiceFormData";
            InvoiceFormData.ReadOnly = true;
            InvoiceFormData.RowHeadersVisible = false;
            InvoiceFormData.RowHeadersWidth = 51;
            InvoiceFormData.Size = new Size(767, 233);
            InvoiceFormData.TabIndex = 70;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductID.FillWeight = 70F;
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.FillWeight = 130F;
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Qty
            // 
            Qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Qty.FillWeight = 130F;
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 6;
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            // 
            // Unit_Price
            // 
            Unit_Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Unit_Price.FillWeight = 130F;
            Unit_Price.HeaderText = "Unit Price";
            Unit_Price.MinimumWidth = 6;
            Unit_Price.Name = "Unit_Price";
            Unit_Price.ReadOnly = true;
            // 
            // Discount
            // 
            Discount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Discount.HeaderText = "Discount";
            Discount.MinimumWidth = 6;
            Discount.Name = "Discount";
            Discount.ReadOnly = true;
            // 
            // InvoiceLabel21
            // 
            InvoiceLabel21.AutoSize = true;
            InvoiceLabel21.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            InvoiceLabel21.Location = new Point(352, 766);
            InvoiceLabel21.Name = "InvoiceLabel21";
            InvoiceLabel21.Size = new Size(118, 13);
            InvoiceLabel21.TabIndex = 71;
            InvoiceLabel21.Text = "Tel: 133 808 12345";
            // 
            // InvoiceLabel17
            // 
            InvoiceLabel17.AutoSize = true;
            InvoiceLabel17.BackColor = SystemColors.ButtonFace;
            InvoiceLabel17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel17.ForeColor = Color.Black;
            InvoiceLabel17.Location = new Point(352, 709);
            InvoiceLabel17.Name = "InvoiceLabel17";
            InvoiceLabel17.Size = new Size(173, 20);
            InvoiceLabel17.TabIndex = 72;
            InvoiceLabel17.Text = "For Billing Inquiries :";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ActiveCaptionText;
            pictureBox5.BackgroundImage = Properties.Resources.company_logo;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(53, 709);
            pictureBox5.Margin = new Padding(2, 2, 2, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(220, 80);
            pictureBox5.TabIndex = 73;
            pictureBox5.TabStop = false;
            // 
            // InvoiceLabel19
            // 
            InvoiceLabel19.AutoSize = true;
            InvoiceLabel19.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            InvoiceLabel19.Location = new Point(352, 746);
            InvoiceLabel19.Name = "InvoiceLabel19";
            InvoiceLabel19.Size = new Size(214, 13);
            InvoiceLabel19.TabIndex = 74;
            InvoiceLabel19.Text = "SMLC District, Tienhou, Guangzhou.";
            // 
            // InvoiceLabel18
            // 
            InvoiceLabel18.AutoSize = true;
            InvoiceLabel18.BackColor = SystemColors.ButtonFace;
            InvoiceLabel18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceLabel18.ForeColor = Color.Black;
            InvoiceLabel18.Location = new Point(600, 709);
            InvoiceLabel18.Name = "InvoiceLabel18";
            InvoiceLabel18.Size = new Size(211, 20);
            InvoiceLabel18.TabIndex = 75;
            InvoiceLabel18.Text = "Make checks payable to :";
            // 
            // InvoiceLabel20
            // 
            InvoiceLabel20.AutoSize = true;
            InvoiceLabel20.BackColor = SystemColors.ButtonFace;
            InvoiceLabel20.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            InvoiceLabel20.ForeColor = Color.Black;
            InvoiceLabel20.Location = new Point(599, 743);
            InvoiceLabel20.Name = "InvoiceLabel20";
            InvoiceLabel20.Size = new Size(174, 16);
            InvoiceLabel20.TabIndex = 76;
            InvoiceLabel20.Text = "Legend MOTOR Co. Ltd.";
            InvoiceLabel20.Click += label7_Click;
            // 
            // InvoiceValue1
            // 
            InvoiceValue1.AutoSize = true;
            InvoiceValue1.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            InvoiceValue1.Location = new Point(277, 80);
            InvoiceValue1.Name = "InvoiceValue1";
            InvoiceValue1.Size = new Size(96, 17);
            InvoiceValue1.TabIndex = 77;
            InvoiceValue1.Text = "InvoiceValue1";
            // 
            // InvoiceValue2
            // 
            InvoiceValue2.AutoSize = true;
            InvoiceValue2.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            InvoiceValue2.Location = new Point(493, 80);
            InvoiceValue2.Name = "InvoiceValue2";
            InvoiceValue2.Size = new Size(96, 17);
            InvoiceValue2.TabIndex = 78;
            InvoiceValue2.Text = "InvoiceValue2";
            // 
            // InvoiceValue3
            // 
            InvoiceValue3.AutoSize = true;
            InvoiceValue3.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            InvoiceValue3.Location = new Point(673, 80);
            InvoiceValue3.Name = "InvoiceValue3";
            InvoiceValue3.Size = new Size(96, 17);
            InvoiceValue3.TabIndex = 79;
            InvoiceValue3.Text = "InvoiceValue3";
            // 
            // InvoiceValue4
            // 
            InvoiceValue4.AutoSize = true;
            InvoiceValue4.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            InvoiceValue4.Location = new Point(72, 191);
            InvoiceValue4.Name = "InvoiceValue4";
            InvoiceValue4.Size = new Size(96, 17);
            InvoiceValue4.TabIndex = 80;
            InvoiceValue4.Text = "InvoiceValue4";
            // 
            // InvoiceValue5
            // 
            InvoiceValue5.AutoSize = true;
            InvoiceValue5.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            InvoiceValue5.Location = new Point(408, 191);
            InvoiceValue5.Name = "InvoiceValue5";
            InvoiceValue5.Size = new Size(96, 17);
            InvoiceValue5.TabIndex = 81;
            InvoiceValue5.Text = "InvoiceValue5";
            // 
            // InvoiceValue6
            // 
            InvoiceValue6.AutoSize = true;
            InvoiceValue6.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            InvoiceValue6.Location = new Point(675, 191);
            InvoiceValue6.Name = "InvoiceValue6";
            InvoiceValue6.Size = new Size(96, 17);
            InvoiceValue6.TabIndex = 82;
            InvoiceValue6.Text = "InvoiceValue6";
            // 
            // invoicePrintbtn
            // 
            invoicePrintbtn.BackColor = Color.Green;
            invoicePrintbtn.Font = new Font("Microsoft Sans Serif", 12F);
            invoicePrintbtn.ForeColor = Color.White;
            invoicePrintbtn.Location = new Point(342, 789);
            invoicePrintbtn.Margin = new Padding(4, 3, 4, 3);
            invoicePrintbtn.Name = "invoicePrintbtn";
            invoicePrintbtn.Size = new Size(115, 32);
            invoicePrintbtn.TabIndex = 83;
            invoicePrintbtn.Text = "Print";
            invoicePrintbtn.UseVisualStyleBackColor = false;
            // 
            // invoiceExitbtn
            // 
            invoiceExitbtn.BackColor = Color.DarkGray;
            invoiceExitbtn.Font = new Font("Microsoft Sans Serif", 12F);
            invoiceExitbtn.ForeColor = Color.White;
            invoiceExitbtn.Location = new Point(506, 789);
            invoiceExitbtn.Margin = new Padding(4, 3, 4, 3);
            invoiceExitbtn.Name = "invoiceExitbtn";
            invoiceExitbtn.Size = new Size(115, 32);
            invoiceExitbtn.TabIndex = 84;
            invoiceExitbtn.Text = "Exit";
            invoiceExitbtn.UseVisualStyleBackColor = false;
            invoiceExitbtn.Click += invoiceExitbtn_Click;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 825);
            Controls.Add(invoiceExitbtn);
            Controls.Add(invoicePrintbtn);
            Controls.Add(InvoiceValue6);
            Controls.Add(InvoiceValue5);
            Controls.Add(InvoiceValue4);
            Controls.Add(InvoiceValue3);
            Controls.Add(InvoiceValue2);
            Controls.Add(InvoiceValue1);
            Controls.Add(InvoiceLabel20);
            Controls.Add(InvoiceLabel18);
            Controls.Add(InvoiceLabel19);
            Controls.Add(pictureBox5);
            Controls.Add(InvoiceLabel17);
            Controls.Add(InvoiceLabel21);
            Controls.Add(InvoiceFormData);
            Controls.Add(panel14);
            Controls.Add(InvoiceLabel16);
            Controls.Add(panel9);
            Controls.Add(InvoiceLabel15);
            Controls.Add(panel10);
            Controls.Add(InvoiceLabel13);
            Controls.Add(InvoiceLabel14);
            Controls.Add(InvoiceLabel12);
            Controls.Add(panel11);
            Controls.Add(panel12);
            Controls.Add(panel13);
            Controls.Add(InvoiceLabel11);
            Controls.Add(panel2);
            Controls.Add(InvoiceLabel9);
            Controls.Add(InvoiceLabel10);
            Controls.Add(InvoiceLabel8);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(InvoiceLine1);
            Controls.Add(InvoiceLabel7);
            Controls.Add(InvoiceLabel6);
            Controls.Add(InvoiceLabel5);
            Controls.Add(InvoiceLabel4);
            Controls.Add(InvoiceLabel3);
            Controls.Add(InvoiceLabel2);
            Controls.Add(InvoiceLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Invoice";
            Text = "InvoiceForm";
            TopMost = true;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InvoiceFormData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InvoiceLabel1;
        private Label InvoiceLabel2;
        private Label InvoiceLabel3;
        private Label InvoiceLabel4;
        private Label InvoiceLabel5;
        private Label InvoiceLabel6;
        private Label InvoiceLabel7;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private Panel InvoiceLine1;
        private Label InvoiceLabel8;
        private Label InvoiceLabel9;
        private Label InvoiceLabel10;
        private Label InvoiceLabel11;
        private TextBox textBox6;
        private TextBox textBox7;
        private DateTimePicker dateTimePicker1;
        private Label InvoiceLabel16;
        private TextBox textBox12;
        private Label InvoiceLabel15;
        private TextBox textBox13;
        private Label InvoiceLabel13;
        private Label InvoiceLabel14;
        private Label InvoiceLabel12;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private Panel panel14;
        private DataGridView InvoiceFormData;
        private TextBox textBox17;
        private Label InvoiceLabel21;
        private Label InvoiceLabel17;
        private PictureBox pictureBox5;
        private Label InvoiceLabel19;
        private Label InvoiceLabel18;
        private Label InvoiceLabel20;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Unit_Price;
        private DataGridViewTextBoxColumn Discount;
        private Label InvoiceValue1;
        private Label InvoiceValue2;
        private Label InvoiceValue8;
        private Label InvoiceValue9;
        private Label InvoiceValue7;
        private Label InvoiceValue10;
        private Label InvoiceValue15;
        private Label InvoiceValue14;
        private Label InvoiceValue11;
        private Label InvoiceValue13;
        private Label InvoiceValue12;
        private Label InvoiceValue3;
        private Label InvoiceValue4;
        private Label InvoiceValue5;
        private Label InvoiceValue6;
        private ProgramMethod.ProgramMethod.PanelBorderColor panel5;
        private ProgramMethod.ProgramMethod.PanelBorderColor panel3;
        private ProgramMethod.ProgramMethod.PanelBorderColor panel4;
        private ProgramMethod.ProgramMethod.PanelBorderColor panel2;
        private ProgramMethod.ProgramMethod.PanelBorderColor panel11;
        private ProgramMethod.ProgramMethod.PanelBorderColor panel13;
        private ProgramMethod.ProgramMethod.PanelBorderColor panel12;
        private ProgramMethod.ProgramMethod.PanelBorderColor panel10;
        private ProgramMethod.ProgramMethod.PanelBorderColor panel9;
        private Button invoicePrintbtn;
        private Button invoiceExitbtn;
    }
}