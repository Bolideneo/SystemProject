using System.Diagnostics;

namespace ITP4519M
{
    partial class DeliveryForm
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
            DelFormOrderID = new Label();
            DelFormDeliveryID = new Label();
            DelFormTotalOfWeight = new Label();
            DelFormDeliveryDate = new Label();
            DelFormDeliveryAddress = new Label();
            deliveryformData = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            PrevQtyunderDelivered = new DataGridViewTextBoxColumn();
            QuantityToFollow = new DataGridViewTextBoxColumn();
            QuantityDeliverd = new DataGridViewTextBoxColumn();
            label13 = new Label();
            deliveryPrintbtn = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintDialog();
            deliveryExitbtn = new Button();
            DelFormPhone = new Label();
            DelFormTopic = new Label();
            DelFormLabel1 = new Label();
            label1 = new Label();
            deliveryAddressbox = new Label();
            pictureBox5 = new PictureBox();
            deliveryPhoneBox = new Label();
            InvoiceLine1 = new Panel();
            deliveryIDbox = new Label();
            deliveryDatebox = new Label();
            deliveryOrderidbox = new Label();
            deliveryWeightBox = new Label();
            ((System.ComponentModel.ISupportInitialize)deliveryformData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // DelFormOrderID
            // 
            DelFormOrderID.AutoSize = true;
            DelFormOrderID.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelFormOrderID.ForeColor = Color.DarkOrange;
            DelFormOrderID.Location = new Point(433, 171);
            DelFormOrderID.Name = "DelFormOrderID";
            DelFormOrderID.Size = new Size(96, 18);
            DelFormOrderID.TabIndex = 9;
            DelFormOrderID.Text = "# Order ID :";
            // 
            // DelFormDeliveryID
            // 
            DelFormDeliveryID.AutoSize = true;
            DelFormDeliveryID.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelFormDeliveryID.ForeColor = Color.DarkOrange;
            DelFormDeliveryID.Location = new Point(430, 205);
            DelFormDeliveryID.Name = "DelFormDeliveryID";
            DelFormDeliveryID.Size = new Size(99, 18);
            DelFormDeliveryID.TabIndex = 9;
            DelFormDeliveryID.Text = "Delivery ID :";
            // 
            // DelFormTotalOfWeight
            // 
            DelFormTotalOfWeight.AutoSize = true;
            DelFormTotalOfWeight.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelFormTotalOfWeight.ForeColor = Color.DarkOrange;
            DelFormTotalOfWeight.Location = new Point(396, 278);
            DelFormTotalOfWeight.Name = "DelFormTotalOfWeight";
            DelFormTotalOfWeight.Size = new Size(133, 18);
            DelFormTotalOfWeight.TabIndex = 17;
            DelFormTotalOfWeight.Text = "Total of Weight :";
            // 
            // DelFormDeliveryDate
            // 
            DelFormDeliveryDate.AutoSize = true;
            DelFormDeliveryDate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelFormDeliveryDate.ForeColor = Color.DarkOrange;
            DelFormDeliveryDate.Location = new Point(411, 238);
            DelFormDeliveryDate.Name = "DelFormDeliveryDate";
            DelFormDeliveryDate.Size = new Size(118, 18);
            DelFormDeliveryDate.TabIndex = 12;
            DelFormDeliveryDate.Text = "Delivery Date :";
            // 
            // DelFormDeliveryAddress
            // 
            DelFormDeliveryAddress.AutoSize = true;
            DelFormDeliveryAddress.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelFormDeliveryAddress.ForeColor = Color.DarkOrange;
            DelFormDeliveryAddress.Location = new Point(51, 205);
            DelFormDeliveryAddress.Name = "DelFormDeliveryAddress";
            DelFormDeliveryAddress.Size = new Size(128, 24);
            DelFormDeliveryAddress.TabIndex = 18;
            DelFormDeliveryAddress.Text = "Delivery To :";
            // 
            // deliveryformData
            // 
            deliveryformData.AllowUserToAddRows = false;
            deliveryformData.AllowUserToDeleteRows = false;
            deliveryformData.BackgroundColor = SystemColors.Window;
            deliveryformData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            deliveryformData.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, PrevQtyunderDelivered, QuantityToFollow, QuantityDeliverd });
            deliveryformData.Location = new Point(25, 387);
            deliveryformData.Name = "deliveryformData";
            deliveryformData.ReadOnly = true;
            deliveryformData.RowHeadersVisible = false;
            deliveryformData.RowHeadersWidth = 51;
            deliveryformData.Size = new Size(665, 266);
            deliveryformData.TabIndex = 17;
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
            // PrevQtyunderDelivered
            // 
            PrevQtyunderDelivered.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PrevQtyunderDelivered.FillWeight = 130F;
            PrevQtyunderDelivered.HeaderText = "PrevQtyDelivered";
            PrevQtyunderDelivered.MinimumWidth = 6;
            PrevQtyunderDelivered.Name = "PrevQtyunderDelivered";
            PrevQtyunderDelivered.ReadOnly = true;
            // 
            // QuantityToFollow
            // 
            QuantityToFollow.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QuantityToFollow.FillWeight = 130F;
            QuantityToFollow.HeaderText = "QuantityToFollow";
            QuantityToFollow.MinimumWidth = 6;
            QuantityToFollow.Name = "QuantityToFollow";
            QuantityToFollow.ReadOnly = true;
            // 
            // QuantityDeliverd
            // 
            QuantityDeliverd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QuantityDeliverd.HeaderText = "QuantityDeliverd";
            QuantityDeliverd.MinimumWidth = 6;
            QuantityDeliverd.Name = "QuantityDeliverd";
            QuantityDeliverd.ReadOnly = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(503, 713);
            label13.Name = "label13";
            label13.Size = new Size(187, 21);
            label13.TabIndex = 18;
            label13.Text = "Signature : _____________\r\n";
            // 
            // deliveryPrintbtn
            // 
            deliveryPrintbtn.BackColor = Color.Green;
            deliveryPrintbtn.Font = new Font("Microsoft Sans Serif", 12F);
            deliveryPrintbtn.ForeColor = Color.White;
            deliveryPrintbtn.Location = new Point(230, 706);
            deliveryPrintbtn.Margin = new Padding(4, 3, 4, 3);
            deliveryPrintbtn.Name = "deliveryPrintbtn";
            deliveryPrintbtn.Size = new Size(115, 32);
            deliveryPrintbtn.TabIndex = 30;
            deliveryPrintbtn.Text = "Print";
            deliveryPrintbtn.UseVisualStyleBackColor = false;
            deliveryPrintbtn.Click += deliveryPrintbtn_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.UseEXDialog = true;
            // 
            // deliveryExitbtn
            // 
            deliveryExitbtn.BackColor = Color.DarkGray;
            deliveryExitbtn.Font = new Font("Microsoft Sans Serif", 12F);
            deliveryExitbtn.ForeColor = Color.White;
            deliveryExitbtn.Location = new Point(372, 706);
            deliveryExitbtn.Margin = new Padding(4, 3, 4, 3);
            deliveryExitbtn.Name = "deliveryExitbtn";
            deliveryExitbtn.Size = new Size(115, 32);
            deliveryExitbtn.TabIndex = 31;
            deliveryExitbtn.Text = "Exit";
            deliveryExitbtn.UseVisualStyleBackColor = false;
            deliveryExitbtn.Click += deliveryExitbtn_Click;
            // 
            // DelFormPhone
            // 
            DelFormPhone.AutoSize = true;
            DelFormPhone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelFormPhone.ForeColor = Color.DarkOrange;
            DelFormPhone.Location = new Point(51, 278);
            DelFormPhone.Name = "DelFormPhone";
            DelFormPhone.Size = new Size(164, 20);
            DelFormPhone.TabIndex = 20;
            DelFormPhone.Text = "Customer Contact :";
            // 
            // DelFormTopic
            // 
            DelFormTopic.AutoSize = true;
            DelFormTopic.Font = new Font("Haettenschweiler", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelFormTopic.ForeColor = Color.DarkOrange;
            DelFormTopic.Location = new Point(37, 38);
            DelFormTopic.Name = "DelFormTopic";
            DelFormTopic.Size = new Size(221, 50);
            DelFormTopic.TabIndex = 9;
            DelFormTopic.Text = "Delivery Note";
            // 
            // DelFormLabel1
            // 
            DelFormLabel1.AutoSize = true;
            DelFormLabel1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelFormLabel1.Location = new Point(51, 120);
            DelFormLabel1.Name = "DelFormLabel1";
            DelFormLabel1.Size = new Size(241, 24);
            DelFormLabel1.TabIndex = 78;
            DelFormLabel1.Text = "Legend MOTOR Co. Ltd.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 160);
            label1.Name = "label1";
            label1.Size = new Size(252, 16);
            label1.TabIndex = 79;
            label1.Text = "SMLC District, Tienhou, Guangzhou.";
            // 
            // deliveryAddressbox
            // 
            deliveryAddressbox.AutoSize = true;
            deliveryAddressbox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryAddressbox.Location = new Point(51, 238);
            deliveryAddressbox.Name = "deliveryAddressbox";
            deliveryAddressbox.Size = new Size(128, 16);
            deliveryAddressbox.TabIndex = 80;
            deliveryAddressbox.Text = "deliveryAddressbox";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ActiveCaptionText;
            pictureBox5.BackgroundImage = Properties.Resources.company_logo;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(25, 685);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(176, 59);
            pictureBox5.TabIndex = 81;
            pictureBox5.TabStop = false;
            // 
            // deliveryPhoneBox
            // 
            deliveryPhoneBox.AutoSize = true;
            deliveryPhoneBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryPhoneBox.Location = new Point(51, 314);
            deliveryPhoneBox.Name = "deliveryPhoneBox";
            deliveryPhoneBox.Size = new Size(117, 16);
            deliveryPhoneBox.TabIndex = 82;
            deliveryPhoneBox.Text = "deliveryPhoneBox";
            // 
            // InvoiceLine1
            // 
            InvoiceLine1.BackColor = SystemColors.ControlDark;
            InvoiceLine1.BorderStyle = BorderStyle.Fixed3D;
            InvoiceLine1.ForeColor = SystemColors.ControlText;
            InvoiceLine1.Location = new Point(20, 360);
            InvoiceLine1.Name = "InvoiceLine1";
            InvoiceLine1.Size = new Size(670, 5);
            InvoiceLine1.TabIndex = 83;
            // 
            // deliveryIDbox
            // 
            deliveryIDbox.AutoSize = true;
            deliveryIDbox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryIDbox.Location = new Point(540, 205);
            deliveryIDbox.Name = "deliveryIDbox";
            deliveryIDbox.Size = new Size(90, 16);
            deliveryIDbox.TabIndex = 84;
            deliveryIDbox.Text = "deliveryIDbox";
            // 
            // deliveryDatebox
            // 
            deliveryDatebox.AutoSize = true;
            deliveryDatebox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryDatebox.Location = new Point(540, 236);
            deliveryDatebox.Name = "deliveryDatebox";
            deliveryDatebox.Size = new Size(106, 16);
            deliveryDatebox.TabIndex = 85;
            deliveryDatebox.Text = "deliveryDatebox";
            // 
            // deliveryOrderidbox
            // 
            deliveryOrderidbox.AutoSize = true;
            deliveryOrderidbox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryOrderidbox.Location = new Point(538, 171);
            deliveryOrderidbox.Name = "deliveryOrderidbox";
            deliveryOrderidbox.Size = new Size(122, 16);
            deliveryOrderidbox.TabIndex = 86;
            deliveryOrderidbox.Text = "deliveryOrderidbox";
            // 
            // deliveryWeightBox
            // 
            deliveryWeightBox.AutoSize = true;
            deliveryWeightBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryWeightBox.Location = new Point(538, 278);
            deliveryWeightBox.Name = "deliveryWeightBox";
            deliveryWeightBox.Size = new Size(120, 16);
            deliveryWeightBox.TabIndex = 87;
            deliveryWeightBox.Text = "deliveryWeightBox";
            // 
            // DeliveryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(732, 776);
            Controls.Add(deliveryWeightBox);
            Controls.Add(deliveryOrderidbox);
            Controls.Add(deliveryDatebox);
            Controls.Add(deliveryIDbox);
            Controls.Add(InvoiceLine1);
            Controls.Add(deliveryPhoneBox);
            Controls.Add(pictureBox5);
            Controls.Add(deliveryAddressbox);
            Controls.Add(label1);
            Controls.Add(DelFormLabel1);
            Controls.Add(DelFormTopic);
            Controls.Add(DelFormPhone);
            Controls.Add(DelFormOrderID);
            Controls.Add(DelFormDeliveryID);
            Controls.Add(DelFormDeliveryDate);
            Controls.Add(DelFormTotalOfWeight);
            Controls.Add(DelFormDeliveryAddress);
            Controls.Add(deliveryExitbtn);
            Controls.Add(deliveryPrintbtn);
            Controls.Add(label13);
            Controls.Add(deliveryformData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeliveryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeliveryForm";
            Load += DeliveryForm_Load;
            MouseDown += Dashboard_MouseDown;
            MouseMove += Dashboard_MouseMove;
            MouseUp += Dashboard_MouseUp;
            ((System.ComponentModel.ISupportInitialize)deliveryformData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label DelFormOrderID;
        private Label DelFormDeliveryID;
        private Label DelFormDeliveryDate;
        private Label DelFormTotalOfWeight;
        private Label DelFormDeliveryAddress;
        private DataGridView deliveryformData;
        private Label label13;
        private Button deliveryPrintbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printPreviewDialog1;
        private Button deliveryExitbtn;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn PrevQtyunderDelivered;
        private DataGridViewTextBoxColumn QuantityToFollow;
        private DataGridViewTextBoxColumn QuantityDeliverd;
        private Label DelFormPhone;
        private Label DelFormTopic;
        private Label DelFormLabel1;
        private Label label1;
        private Label deliveryAddressbox;
        private PictureBox pictureBox5;
        private Label deliveryPhoneBox;
        private Panel InvoiceLine1;
        private Label deliveryIDbox;
        private Label deliveryDatebox;
        private Label deliveryOrderidbox;
        private Label deliveryWeightBox;
    }
}