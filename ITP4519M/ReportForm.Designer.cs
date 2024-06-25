namespace ITP4519M
{
    partial class ReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            DelFormTopic = new Label();
            panel1 = new Panel();
            TodayTotalSales = new Label();
            panel2 = new Panel();
            TodayTotalOrder = new Label();
            panel3 = new Panel();
            MonthlyTotalSales = new Label();
            panel4 = new Panel();
            MonthlyTotalOrder = new Label();
            TodayTotalSalesValue = new Label();
            TodayTotalOrderValue = new Label();
            MonthlyTotalSalesValue = new Label();
            MonthlyTotalOrderValue = new Label();
            label1 = new Label();
            InvoiceFormData = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Order_Date = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            InvoiceLine1 = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            CloseButton = new Button();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InvoiceFormData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // DelFormTopic
            // 
            DelFormTopic.AutoSize = true;
            DelFormTopic.Font = new Font("Haettenschweiler", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelFormTopic.ForeColor = Color.DarkOrange;
            DelFormTopic.Location = new Point(27, 21);
            DelFormTopic.Name = "DelFormTopic";
            DelFormTopic.Size = new Size(123, 50);
            DelFormTopic.TabIndex = 10;
            DelFormTopic.Text = "Report";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(TodayTotalSalesValue);
            panel1.Controls.Add(TodayTotalSales);
            panel1.Location = new Point(27, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 105);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // TodayTotalSales
            // 
            TodayTotalSales.AutoSize = true;
            TodayTotalSales.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TodayTotalSales.Location = new Point(15, 11);
            TodayTotalSales.Name = "TodayTotalSales";
            TodayTotalSales.Size = new Size(177, 24);
            TodayTotalSales.TabIndex = 12;
            TodayTotalSales.Text = "Today Total Sales";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TodayTotalOrderValue);
            panel2.Controls.Add(TodayTotalOrder);
            panel2.Location = new Point(268, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 105);
            panel2.TabIndex = 13;
            // 
            // TodayTotalOrder
            // 
            TodayTotalOrder.AutoSize = true;
            TodayTotalOrder.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TodayTotalOrder.Location = new Point(12, 11);
            TodayTotalOrder.Name = "TodayTotalOrder";
            TodayTotalOrder.Size = new Size(180, 24);
            TodayTotalOrder.TabIndex = 12;
            TodayTotalOrder.Text = "Today Total Order";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(MonthlyTotalSalesValue);
            panel3.Controls.Add(MonthlyTotalSales);
            panel3.Location = new Point(503, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 105);
            panel3.TabIndex = 13;
            // 
            // MonthlyTotalSales
            // 
            MonthlyTotalSales.AutoSize = true;
            MonthlyTotalSales.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MonthlyTotalSales.Location = new Point(14, 11);
            MonthlyTotalSales.Name = "MonthlyTotalSales";
            MonthlyTotalSales.Size = new Size(192, 24);
            MonthlyTotalSales.TabIndex = 12;
            MonthlyTotalSales.Text = "Monthly Total Sales";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(MonthlyTotalOrderValue);
            panel4.Controls.Add(MonthlyTotalOrder);
            panel4.Location = new Point(750, 97);
            panel4.Name = "panel4";
            panel4.Size = new Size(217, 105);
            panel4.TabIndex = 14;
            // 
            // MonthlyTotalOrder
            // 
            MonthlyTotalOrder.AutoSize = true;
            MonthlyTotalOrder.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MonthlyTotalOrder.Location = new Point(9, 11);
            MonthlyTotalOrder.Name = "MonthlyTotalOrder";
            MonthlyTotalOrder.Size = new Size(195, 24);
            MonthlyTotalOrder.TabIndex = 12;
            MonthlyTotalOrder.Text = "Monthly Total Order";
            // 
            // TodayTotalSalesValue
            // 
            TodayTotalSalesValue.AutoSize = true;
            TodayTotalSalesValue.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            TodayTotalSalesValue.Location = new Point(31, 63);
            TodayTotalSalesValue.Name = "TodayTotalSalesValue";
            TodayTotalSalesValue.Size = new Size(139, 17);
            TodayTotalSalesValue.TabIndex = 15;
            TodayTotalSalesValue.Text = "TodayTotalSalesValue";
            // 
            // TodayTotalOrderValue
            // 
            TodayTotalOrderValue.AutoSize = true;
            TodayTotalOrderValue.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            TodayTotalOrderValue.Location = new Point(32, 63);
            TodayTotalOrderValue.Name = "TodayTotalOrderValue";
            TodayTotalOrderValue.Size = new Size(145, 17);
            TodayTotalOrderValue.TabIndex = 16;
            TodayTotalOrderValue.Text = "TodayTotalOrderValue";
            // 
            // MonthlyTotalSalesValue
            // 
            MonthlyTotalSalesValue.AutoSize = true;
            MonthlyTotalSalesValue.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            MonthlyTotalSalesValue.Location = new Point(34, 63);
            MonthlyTotalSalesValue.Name = "MonthlyTotalSalesValue";
            MonthlyTotalSalesValue.Size = new Size(154, 17);
            MonthlyTotalSalesValue.TabIndex = 17;
            MonthlyTotalSalesValue.Text = "MonthlyTotalSalesValue";
            // 
            // MonthlyTotalOrderValue
            // 
            MonthlyTotalOrderValue.AutoSize = true;
            MonthlyTotalOrderValue.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            MonthlyTotalOrderValue.Location = new Point(27, 63);
            MonthlyTotalOrderValue.Name = "MonthlyTotalOrderValue";
            MonthlyTotalOrderValue.Size = new Size(160, 17);
            MonthlyTotalOrderValue.TabIndex = 18;
            MonthlyTotalOrderValue.Text = "MonthlyTotalOrderValue";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 622);
            label1.Name = "label1";
            label1.Size = new Size(195, 24);
            label1.TabIndex = 16;
            label1.Text = "Top Selling Product";
            // 
            // InvoiceFormData
            // 
            InvoiceFormData.AllowUserToAddRows = false;
            InvoiceFormData.AllowUserToDeleteRows = false;
            InvoiceFormData.BackgroundColor = SystemColors.Window;
            InvoiceFormData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvoiceFormData.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, Qty, Order_Date, Customer, Status, Price, Action });
            InvoiceFormData.Location = new Point(38, 667);
            InvoiceFormData.Name = "InvoiceFormData";
            InvoiceFormData.ReadOnly = true;
            InvoiceFormData.RowHeadersVisible = false;
            InvoiceFormData.RowHeadersWidth = 51;
            InvoiceFormData.Size = new Size(929, 233);
            InvoiceFormData.TabIndex = 71;
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
            // Order_Date
            // 
            Order_Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Order_Date.FillWeight = 130F;
            Order_Date.HeaderText = "Order Date";
            Order_Date.MinimumWidth = 6;
            Order_Date.Name = "Order_Date";
            Order_Date.ReadOnly = true;
            // 
            // Customer
            // 
            Customer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Customer.HeaderText = "Customer";
            Customer.MinimumWidth = 6;
            Customer.Name = "Customer";
            Customer.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.Name = "Action";
            Action.ReadOnly = true;
            // 
            // InvoiceLine1
            // 
            InvoiceLine1.BackColor = SystemColors.ControlDark;
            InvoiceLine1.BorderStyle = BorderStyle.Fixed3D;
            InvoiceLine1.ForeColor = SystemColors.ControlText;
            InvoiceLine1.Location = new Point(27, 598);
            InvoiceLine1.Name = "InvoiceLine1";
            InvoiceLine1.Size = new Size(940, 5);
            InvoiceLine1.TabIndex = 72;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart1.Legends.Add(legend3);
            chart1.Location = new Point(43, 236);
            chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Order";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Sales";
            chart1.Series.Add(series5);
            chart1.Series.Add(series6);
            chart1.Size = new Size(422, 318);
            chart1.TabIndex = 73;
            chart1.Text = "chart1";
            title3.Alignment = ContentAlignment.TopLeft;
            title3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title3.Name = "Sales Overview";
            title3.Text = "Order Statistics";
            chart1.Titles.Add(title3);
            chart1.Click += chart1_Click;
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(956, 11);
            CloseButton.Margin = new Padding(2);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(38, 46);
            CloseButton.TabIndex = 74;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chart2.Legends.Add(legend4);
            chart2.Location = new Point(538, 236);
            chart2.Name = "chart2";
            chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.LabelBackColor = Color.White;
            series7.Legend = "Legend1";
            series7.MarkerBorderColor = Color.White;
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series7.Name = "Total Income";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series8.Name = "Expenses";
            chart2.Series.Add(series7);
            chart2.Series.Add(series8);
            chart2.Size = new Size(414, 318);
            chart2.TabIndex = 75;
            chart2.Text = "chart2";
            title4.Alignment = ContentAlignment.TopLeft;
            title4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title4.Name = "Sales Overview";
            title4.Text = "Sales Overview";
            chart2.Titles.Add(title4);
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 943);
            Controls.Add(chart2);
            Controls.Add(CloseButton);
            Controls.Add(chart1);
            Controls.Add(InvoiceLine1);
            Controls.Add(InvoiceFormData);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DelFormTopic);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportForm";
            Text = "ReportForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InvoiceFormData).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DelFormTopic;
        private Panel panel1;
        private Label TodayTotalSales;
        private Panel panel2;
        private Label TodayTotalOrder;
        private Panel panel3;
        private Label MonthlyTotalSales;
        private Panel panel4;
        private Label MonthlyTotalOrder;
        private Label TodayTotalSalesValue;
        private Label TodayTotalOrderValue;
        private Label MonthlyTotalSalesValue;
        private Label MonthlyTotalOrderValue;
        private Label label1;
        private DataGridView InvoiceFormData;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Order_Date;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Action;
        private Panel InvoiceLine1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button CloseButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}