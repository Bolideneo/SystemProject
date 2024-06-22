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
            panel1 = new Panel();
            DelFormTopic = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            DelFormOrderID = new Label();
            panel5 = new Panel();
            deliveryOrderidbox = new TextBox();
            panel6 = new Panel();
            deliveryIDbox = new TextBox();
            panel7 = new Panel();
            DelFormDeliveryID = new Label();
            panel8 = new Panel();
            deliveryWeightBox = new TextBox();
            panel9 = new Panel();
            DelFormTotalOfWeight = new Label();
            panel10 = new Panel();
            deliveryDatebox = new TextBox();
            panel11 = new Panel();
            DelFormDeliveryDate = new Label();
            panel12 = new Panel();
            deliveryPhoneBox = new TextBox();
            DelFormOurEmail = new Label();
            DelFormOurFax = new Label();
            DelFormOurTel = new Label();
            DelFormOurAddress = new Label();
            DelFormPhone = new Label();
            DelFormToContactUs = new Label();
            DelFormDeliveryAddress = new Label();
            panel14 = new Panel();
            deliveryAddressbox = new TextBox();
            panel15 = new Panel();
            deliveryQuantityDeliverdbox = new TextBox();
            panel16 = new Panel();
            DelFormPS = new Label();
            panel17 = new Panel();
            DelFormQtyDelivered = new Label();
            panel18 = new PanelEx();
            deliveryPreQtyBox = new TextBox();
            panel19 = new PanelEx();
            DelFormPerQty = new Label();
            panel20 = new Panel();
            deliveryQuqntiyFollow = new TextBox();
            panel21 = new Panel();
            DelFormQtyFollow = new Label();
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
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deliveryformData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(DelFormTopic);
            panel1.Cursor = Cursors.No;
            panel1.Location = new Point(42, 44);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 66);
            panel1.TabIndex = 0;
            // 
            // DelFormTopic
            // 
            DelFormTopic.AutoSize = true;
            DelFormTopic.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            DelFormTopic.Location = new Point(86, 16);
            DelFormTopic.Name = "DelFormTopic";
            DelFormTopic.Size = new Size(191, 31);
            DelFormTopic.TabIndex = 9;
            DelFormTopic.Text = "Delivery Note";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Cursor = Cursors.No;
            panel2.Location = new Point(461, 44);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 66);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(DelFormOrderID);
            panel4.Cursor = Cursors.No;
            panel4.Location = new Point(42, 109);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(154, 46);
            panel4.TabIndex = 1;
            // 
            // DelFormOrderID
            // 
            DelFormOrderID.AutoSize = true;
            DelFormOrderID.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelFormOrderID.Location = new Point(69, 11);
            DelFormOrderID.Name = "DelFormOrderID";
            DelFormOrderID.Size = new Size(91, 24);
            DelFormOrderID.TabIndex = 9;
            DelFormOrderID.Text = "Order ID :";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(deliveryOrderidbox);
            panel5.Cursor = Cursors.No;
            panel5.Location = new Point(197, 109);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(263, 46);
            panel5.TabIndex = 2;
            // 
            // deliveryOrderidbox
            // 
            deliveryOrderidbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryOrderidbox.Location = new Point(14, 7);
            deliveryOrderidbox.Margin = new Padding(6, 5, 6, 5);
            deliveryOrderidbox.Name = "deliveryOrderidbox";
            deliveryOrderidbox.ReadOnly = true;
            deliveryOrderidbox.Size = new Size(223, 27);
            deliveryOrderidbox.TabIndex = 19;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(deliveryIDbox);
            panel6.Cursor = Cursors.No;
            panel6.Location = new Point(197, 153);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(263, 45);
            panel6.TabIndex = 4;
            // 
            // deliveryIDbox
            // 
            deliveryIDbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryIDbox.Location = new Point(14, 7);
            deliveryIDbox.Margin = new Padding(6, 5, 6, 5);
            deliveryIDbox.Name = "deliveryIDbox";
            deliveryIDbox.ReadOnly = true;
            deliveryIDbox.Size = new Size(223, 27);
            deliveryIDbox.TabIndex = 19;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(DelFormDeliveryID);
            panel7.Cursor = Cursors.No;
            panel7.Location = new Point(42, 153);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(154, 45);
            panel7.TabIndex = 3;
            // 
            // DelFormDeliveryID
            // 
            DelFormDeliveryID.AutoSize = true;
            DelFormDeliveryID.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelFormDeliveryID.Location = new Point(54, 11);
            DelFormDeliveryID.Name = "DelFormDeliveryID";
            DelFormDeliveryID.Size = new Size(109, 24);
            DelFormDeliveryID.TabIndex = 9;
            DelFormDeliveryID.Text = "Delivery ID :";
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(deliveryWeightBox);
            panel8.Cursor = Cursors.No;
            panel8.Location = new Point(197, 240);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(263, 46);
            panel8.TabIndex = 8;
            // 
            // deliveryWeightBox
            // 
            deliveryWeightBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryWeightBox.Location = new Point(14, 7);
            deliveryWeightBox.Margin = new Padding(6, 5, 6, 5);
            deliveryWeightBox.Name = "deliveryWeightBox";
            deliveryWeightBox.ReadOnly = true;
            deliveryWeightBox.Size = new Size(223, 27);
            deliveryWeightBox.TabIndex = 19;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(DelFormTotalOfWeight);
            panel9.Cursor = Cursors.No;
            panel9.Location = new Point(42, 240);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(154, 46);
            panel9.TabIndex = 7;
            // 
            // DelFormTotalOfWeight
            // 
            DelFormTotalOfWeight.AutoSize = true;
            DelFormTotalOfWeight.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelFormTotalOfWeight.Location = new Point(14, 9);
            DelFormTotalOfWeight.Name = "DelFormTotalOfWeight";
            DelFormTotalOfWeight.Size = new Size(145, 24);
            DelFormTotalOfWeight.TabIndex = 17;
            DelFormTotalOfWeight.Text = "Total of Weight :";
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(deliveryDatebox);
            panel10.Cursor = Cursors.No;
            panel10.Location = new Point(197, 197);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(263, 45);
            panel10.TabIndex = 6;
            // 
            // deliveryDatebox
            // 
            deliveryDatebox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryDatebox.Location = new Point(14, 7);
            deliveryDatebox.Margin = new Padding(6, 5, 6, 5);
            deliveryDatebox.Name = "deliveryDatebox";
            deliveryDatebox.ReadOnly = true;
            deliveryDatebox.Size = new Size(223, 27);
            deliveryDatebox.TabIndex = 19;
            // 
            // panel11
            // 
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(DelFormDeliveryDate);
            panel11.Cursor = Cursors.No;
            panel11.Location = new Point(42, 197);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(154, 45);
            panel11.TabIndex = 5;
            // 
            // DelFormDeliveryDate
            // 
            DelFormDeliveryDate.AutoSize = true;
            DelFormDeliveryDate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelFormDeliveryDate.Location = new Point(35, 8);
            DelFormDeliveryDate.Name = "DelFormDeliveryDate";
            DelFormDeliveryDate.Size = new Size(130, 24);
            DelFormDeliveryDate.TabIndex = 12;
            DelFormDeliveryDate.Text = "Delivery Date :";
            // 
            // panel12
            // 
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(deliveryPhoneBox);
            panel12.Controls.Add(DelFormOurEmail);
            panel12.Controls.Add(DelFormOurFax);
            panel12.Controls.Add(DelFormOurTel);
            panel12.Controls.Add(DelFormOurAddress);
            panel12.Controls.Add(DelFormPhone);
            panel12.Controls.Add(DelFormToContactUs);
            panel12.Cursor = Cursors.No;
            panel12.Location = new Point(461, 109);
            panel12.Margin = new Padding(3, 4, 3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(341, 455);
            panel12.TabIndex = 3;
            // 
            // deliveryPhoneBox
            // 
            deliveryPhoneBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryPhoneBox.Location = new Point(109, 371);
            deliveryPhoneBox.Margin = new Padding(6, 5, 6, 5);
            deliveryPhoneBox.Name = "deliveryPhoneBox";
            deliveryPhoneBox.ReadOnly = true;
            deliveryPhoneBox.Size = new Size(170, 27);
            deliveryPhoneBox.TabIndex = 30;
            // 
            // DelFormOurEmail
            // 
            DelFormOurEmail.AutoSize = true;
            DelFormOurEmail.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            DelFormOurEmail.Location = new Point(106, 187);
            DelFormOurEmail.Name = "DelFormOurEmail";
            DelFormOurEmail.Size = new Size(174, 17);
            DelFormOurEmail.TabIndex = 24;
            DelFormOurEmail.Text = "Email: cs-dilwl@vtc.edu.hk";
            // 
            // DelFormOurFax
            // 
            DelFormOurFax.AutoSize = true;
            DelFormOurFax.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            DelFormOurFax.Location = new Point(106, 151);
            DelFormOurFax.Name = "DelFormOurFax";
            DelFormOurFax.Size = new Size(106, 17);
            DelFormOurFax.TabIndex = 23;
            DelFormOurFax.Text = "Fax: 3928 2024";
            // 
            // DelFormOurTel
            // 
            DelFormOurTel.AutoSize = true;
            DelFormOurTel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            DelFormOurTel.Location = new Point(106, 113);
            DelFormOurTel.Name = "DelFormOurTel";
            DelFormOurTel.Size = new Size(104, 17);
            DelFormOurTel.TabIndex = 22;
            DelFormOurTel.Text = "Tel: 3928 2000";
            // 
            // DelFormOurAddress
            // 
            DelFormOurAddress.AutoSize = true;
            DelFormOurAddress.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            DelFormOurAddress.Location = new Point(106, 56);
            DelFormOurAddress.Name = "DelFormOurAddress";
            DelFormOurAddress.Size = new Size(234, 34);
            DelFormOurAddress.TabIndex = 21;
            DelFormOurAddress.Text = "3 King Ling Road, Tseung Kwan O, \r\nNew Territories, Hong Kong, China";
            // 
            // DelFormPhone
            // 
            DelFormPhone.AutoSize = true;
            DelFormPhone.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            DelFormPhone.Location = new Point(109, 329);
            DelFormPhone.Name = "DelFormPhone";
            DelFormPhone.Size = new Size(187, 24);
            DelFormPhone.TabIndex = 20;
            DelFormPhone.Text = "Customer Contact :";
            // 
            // DelFormToContactUs
            // 
            DelFormToContactUs.AutoSize = true;
            DelFormToContactUs.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            DelFormToContactUs.Location = new Point(106, 21);
            DelFormToContactUs.Name = "DelFormToContactUs";
            DelFormToContactUs.Size = new Size(151, 24);
            DelFormToContactUs.TabIndex = 19;
            DelFormToContactUs.Text = "To Contact us :";
            // 
            // DelFormDeliveryAddress
            // 
            DelFormDeliveryAddress.AutoSize = true;
            DelFormDeliveryAddress.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            DelFormDeliveryAddress.Location = new Point(7, 8);
            DelFormDeliveryAddress.Name = "DelFormDeliveryAddress";
            DelFormDeliveryAddress.Size = new Size(180, 24);
            DelFormDeliveryAddress.TabIndex = 18;
            DelFormDeliveryAddress.Text = "Delivery Address :";
            // 
            // panel14
            // 
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(deliveryAddressbox);
            panel14.Cursor = Cursors.No;
            panel14.Location = new Point(42, 468);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(417, 97);
            panel14.TabIndex = 16;
            // 
            // deliveryAddressbox
            // 
            deliveryAddressbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryAddressbox.Location = new Point(7, 12);
            deliveryAddressbox.Margin = new Padding(6, 5, 6, 5);
            deliveryAddressbox.Name = "deliveryAddressbox";
            deliveryAddressbox.ReadOnly = true;
            deliveryAddressbox.Size = new Size(331, 27);
            deliveryAddressbox.TabIndex = 28;
            // 
            // panel15
            // 
            panel15.BorderStyle = BorderStyle.FixedSingle;
            panel15.Controls.Add(deliveryQuantityDeliverdbox);
            panel15.Cursor = Cursors.No;
            panel15.Location = new Point(197, 329);
            panel15.Margin = new Padding(3, 4, 3, 4);
            panel15.Name = "panel15";
            panel15.Size = new Size(263, 45);
            panel15.TabIndex = 12;
            // 
            // deliveryQuantityDeliverdbox
            // 
            deliveryQuantityDeliverdbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryQuantityDeliverdbox.Location = new Point(14, 7);
            deliveryQuantityDeliverdbox.Margin = new Padding(6, 5, 6, 5);
            deliveryQuantityDeliverdbox.Name = "deliveryQuantityDeliverdbox";
            deliveryQuantityDeliverdbox.ReadOnly = true;
            deliveryQuantityDeliverdbox.Size = new Size(223, 27);
            deliveryQuantityDeliverdbox.TabIndex = 19;
            // 
            // panel16
            // 
            panel16.BorderStyle = BorderStyle.FixedSingle;
            panel16.Controls.Add(DelFormPS);
            panel16.Controls.Add(DelFormDeliveryAddress);
            panel16.Cursor = Cursors.No;
            panel16.Location = new Point(42, 431);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(417, 41);
            panel16.TabIndex = 15;
            // 
            // DelFormPS
            // 
            DelFormPS.AutoSize = true;
            DelFormPS.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DelFormPS.Location = new Point(80, 4);
            DelFormPS.Name = "DelFormPS";
            DelFormPS.Size = new Size(0, 25);
            DelFormPS.TabIndex = 17;
            // 
            // panel17
            // 
            panel17.BorderStyle = BorderStyle.FixedSingle;
            panel17.Controls.Add(DelFormQtyDelivered);
            panel17.Cursor = Cursors.No;
            panel17.Location = new Point(42, 329);
            panel17.Margin = new Padding(3, 4, 3, 4);
            panel17.Name = "panel17";
            panel17.Size = new Size(154, 45);
            panel17.TabIndex = 11;
            // 
            // DelFormQtyDelivered
            // 
            DelFormQtyDelivered.AutoSize = true;
            DelFormQtyDelivered.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelFormQtyDelivered.Location = new Point(-1, 7);
            DelFormQtyDelivered.Name = "DelFormQtyDelivered";
            DelFormQtyDelivered.Size = new Size(162, 24);
            DelFormQtyDelivered.TabIndex = 17;
            DelFormQtyDelivered.Text = "Quantity Deliverd :";
            // 
            // panel18
            // 
            panel18.BorderStyle = BorderStyle.FixedSingle;
            panel18.Controls.Add(deliveryPreQtyBox);
            panel18.Cursor = Cursors.No;
            panel18.Location = new Point(197, 371);
            panel18.Margin = new Padding(3, 4, 3, 4);
            panel18.Name = "panel18";
            panel18.Size = new Size(263, 62);
            panel18.TabIndex = 14;
            // 
            // deliveryPreQtyBox
            // 
            deliveryPreQtyBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryPreQtyBox.Location = new Point(14, 15);
            deliveryPreQtyBox.Margin = new Padding(6, 5, 6, 5);
            deliveryPreQtyBox.Name = "deliveryPreQtyBox";
            deliveryPreQtyBox.ReadOnly = true;
            deliveryPreQtyBox.Size = new Size(223, 27);
            deliveryPreQtyBox.TabIndex = 19;
            // 
            // panel19
            // 
            panel19.BorderStyle = BorderStyle.FixedSingle;
            panel19.Controls.Add(DelFormPerQty);
            panel19.Cursor = Cursors.No;
            panel19.Location = new Point(42, 371);
            panel19.Margin = new Padding(3, 4, 3, 4);
            panel19.Name = "panel19";
            panel19.Size = new Size(154, 62);
            panel19.TabIndex = 13;
            // 
            // DelFormPerQty
            // 
            DelFormPerQty.AutoSize = true;
            DelFormPerQty.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelFormPerQty.Location = new Point(3, 5);
            DelFormPerQty.Name = "DelFormPerQty";
            DelFormPerQty.Size = new Size(157, 48);
            DelFormPerQty.TabIndex = 17;
            DelFormPerQty.Text = "Pervious Quantity\r\nUnder Delivered :";
            DelFormPerQty.Click += label5_Click;
            // 
            // panel20
            // 
            panel20.BorderStyle = BorderStyle.FixedSingle;
            panel20.Controls.Add(deliveryQuqntiyFollow);
            panel20.Cursor = Cursors.No;
            panel20.Location = new Point(197, 285);
            panel20.Margin = new Padding(3, 4, 3, 4);
            panel20.Name = "panel20";
            panel20.Size = new Size(263, 45);
            panel20.TabIndex = 10;
            // 
            // deliveryQuqntiyFollow
            // 
            deliveryQuqntiyFollow.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryQuqntiyFollow.Location = new Point(14, 7);
            deliveryQuqntiyFollow.Margin = new Padding(6, 5, 6, 5);
            deliveryQuqntiyFollow.Name = "deliveryQuqntiyFollow";
            deliveryQuqntiyFollow.ReadOnly = true;
            deliveryQuqntiyFollow.Size = new Size(223, 27);
            deliveryQuqntiyFollow.TabIndex = 19;
            // 
            // panel21
            // 
            panel21.BorderStyle = BorderStyle.FixedSingle;
            panel21.Controls.Add(DelFormQtyFollow);
            panel21.Cursor = Cursors.No;
            panel21.Location = new Point(42, 285);
            panel21.Margin = new Padding(3, 4, 3, 4);
            panel21.Name = "panel21";
            panel21.Size = new Size(154, 45);
            panel21.TabIndex = 9;
            // 
            // DelFormQtyFollow
            // 
            DelFormQtyFollow.AutoSize = true;
            DelFormQtyFollow.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelFormQtyFollow.Location = new Point(11, 7);
            DelFormQtyFollow.Name = "DelFormQtyFollow";
            DelFormQtyFollow.Size = new Size(149, 24);
            DelFormQtyFollow.TabIndex = 17;
            DelFormQtyFollow.Text = "Quantity Follow :";
            // 
            // deliveryformData
            // 
            deliveryformData.AllowUserToAddRows = false;
            deliveryformData.AllowUserToDeleteRows = false;
            deliveryformData.BackgroundColor = SystemColors.Window;
            deliveryformData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            deliveryformData.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, PrevQtyunderDelivered, QuantityToFollow, QuantityDeliverd });
            deliveryformData.Location = new Point(42, 557);
            deliveryformData.Margin = new Padding(3, 4, 3, 4);
            deliveryformData.Name = "deliveryformData";
            deliveryformData.ReadOnly = true;
            deliveryformData.RowHeadersVisible = false;
            deliveryformData.RowHeadersWidth = 51;
            deliveryformData.Size = new Size(760, 355);
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
            label13.Location = new Point(397, 969);
            label13.Name = "label13";
            label13.Size = new Size(240, 26);
            label13.TabIndex = 18;
            label13.Text = "Signature : _______________";
            // 
            // deliveryPrintbtn
            // 
            deliveryPrintbtn.BackColor = Color.Green;
            deliveryPrintbtn.Font = new Font("Microsoft Sans Serif", 12F);
            deliveryPrintbtn.ForeColor = Color.White;
            deliveryPrintbtn.Location = new Point(42, 959);
            deliveryPrintbtn.Margin = new Padding(5, 4, 5, 4);
            deliveryPrintbtn.Name = "deliveryPrintbtn";
            deliveryPrintbtn.Size = new Size(121, 39);
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
            deliveryExitbtn.Location = new Point(237, 959);
            deliveryExitbtn.Margin = new Padding(5, 4, 5, 4);
            deliveryExitbtn.Name = "deliveryExitbtn";
            deliveryExitbtn.Size = new Size(107, 39);
            deliveryExitbtn.TabIndex = 31;
            deliveryExitbtn.Text = "Exit";
            deliveryExitbtn.UseVisualStyleBackColor = false;
            deliveryExitbtn.Click += deliveryExitbtn_Click;
            // 
            // DeliveryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(837, 1035);
            Controls.Add(deliveryExitbtn);
            Controls.Add(deliveryPrintbtn);
            Controls.Add(label13);
            Controls.Add(deliveryformData);
            Controls.Add(panel14);
            Controls.Add(panel16);
            Controls.Add(panel12);
            Controls.Add(panel15);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel17);
            Controls.Add(panel9);
            Controls.Add(panel18);
            Controls.Add(panel7);
            Controls.Add(panel19);
            Controls.Add(panel10);
            Controls.Add(panel20);
            Controls.Add(panel21);
            Controls.Add(panel11);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DeliveryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeliveryForm";
            Load += DeliveryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)deliveryformData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Label DelFormOrderID;
        private Label DelFormDeliveryID;
        private Label DelFormTopic;
        private Panel panel12;
        private Label DelFormDeliveryDate;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private Label DelFormTotalOfWeight;
        private Label DelFormQtyFollow;
        private Label DelFormQtyDelivered;
        private Label DelFormPerQty;
        private Label DelFormDeliveryAddress;
        private Label DelFormPS;
        private Label DelFormPhone;
        private Label DelFormToContactUs;
        private Label DelFormOurTel;
        private Label DelFormOurAddress;
        private Label DelFormOurEmail;
        private Label DelFormOurFax;
        private DataGridView deliveryformData;
        private Label label13;
        private Button deliveryPrintbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printPreviewDialog1;
        private Button deliveryExitbtn;
        private TextBox deliveryOrderidbox;
        private TextBox deliveryIDbox;
        private TextBox deliveryWeightBox;
        private TextBox deliveryDatebox;
        private TextBox deliveryPhoneBox;
        private TextBox deliveryAddressbox;
        private TextBox deliveryQuantityDeliverdbox;
        private TextBox deliveryPreQtyBox;
        private TextBox deliveryQuqntiyFollow;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn PrevQtyunderDelivered;
        private DataGridViewTextBoxColumn QuantityToFollow;
        private DataGridViewTextBoxColumn QuantityDeliverd;
    }
}