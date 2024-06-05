namespace ITP4519M
{
    partial class Delivery
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            deliveryCreatebtn = new Button();
            deliveryOrderidbox = new TextBox();
            deliveryDeliveryidbox = new TextBox();
            deliveryOutstandingbox = new TextBox();
            deliveryQtyfollowbox = new TextBox();
            deliveryQtydeliverdbox = new TextBox();
            deliveryOderedquantitybox = new TextBox();
            deliveryPerviousqtybtn = new TextBox();
            deliveryDeliveryAddressBox1 = new TextBox();
            deliveryPhoneNo = new TextBox();
            deliveryClearbtn = new Button();
            deliveryDateTimePicker = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(145, 24);
            label1.TabIndex = 0;
            label1.Text = "Delivery Notes";
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
            label3.Location = new Point(69, 106);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Order ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 197);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 3;
            label4.Text = "OutStanding ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 320);
            label5.Name = "label5";
            label5.Size = new Size(132, 40);
            label5.TabIndex = 4;
            label5.Text = "Pervious Quantity\r\nUnder Delivered :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(54, 148);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 5;
            label6.Text = "Delivery ID :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 246);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 6;
            label7.Text = "Quantity Follow :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 287);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 7;
            label8.Text = "Quantity Deliverd :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(321, 247);
            label9.Name = "label9";
            label9.Size = new Size(134, 20);
            label9.TabIndex = 8;
            label9.Text = "OrderedQuantity :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(321, 106);
            label10.Name = "label10";
            label10.Size = new Size(135, 20);
            label10.TabIndex = 9;
            label10.Text = "Delivery Address :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(321, 197);
            label11.Name = "label11";
            label11.Size = new Size(123, 20);
            label11.TabIndex = 10;
            label11.Text = "Phone Number :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(321, 148);
            label12.Name = "label12";
            label12.Size = new Size(111, 20);
            label12.TabIndex = 11;
            label12.Text = "Delivery Date :";
            // 
            // deliveryCreatebtn
            // 
            deliveryCreatebtn.BackColor = Color.FromArgb(0, 192, 0);
            deliveryCreatebtn.Font = new Font("Microsoft Sans Serif", 12F);
            deliveryCreatebtn.ForeColor = Color.White;
            deliveryCreatebtn.Location = new Point(22, 388);
            deliveryCreatebtn.Margin = new Padding(5, 4, 5, 4);
            deliveryCreatebtn.Name = "deliveryCreatebtn";
            deliveryCreatebtn.Size = new Size(171, 39);
            deliveryCreatebtn.TabIndex = 12;
            deliveryCreatebtn.Text = "Create";
            deliveryCreatebtn.UseVisualStyleBackColor = false;
            deliveryCreatebtn.Click += deliveryCreatebtn_Click;
            // 
            // deliveryOrderidbox
            // 
            deliveryOrderidbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryOrderidbox.Location = new Point(155, 106);
            deliveryOrderidbox.Margin = new Padding(5, 4, 5, 4);
            deliveryOrderidbox.Name = "deliveryOrderidbox";
            deliveryOrderidbox.Size = new Size(149, 23);
            deliveryOrderidbox.TabIndex = 18;
            // 
            // deliveryDeliveryidbox
            // 
            deliveryDeliveryidbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryDeliveryidbox.Location = new Point(155, 149);
            deliveryDeliveryidbox.Margin = new Padding(5, 4, 5, 4);
            deliveryDeliveryidbox.Name = "deliveryDeliveryidbox";
            deliveryDeliveryidbox.Size = new Size(149, 23);
            deliveryDeliveryidbox.TabIndex = 19;
            // 
            // deliveryOutstandingbox
            // 
            deliveryOutstandingbox.Location = new Point(157, 196);
            deliveryOutstandingbox.Name = "deliveryOutstandingbox";
            deliveryOutstandingbox.Size = new Size(147, 23);
            deliveryOutstandingbox.TabIndex = 34;
            // 
            // deliveryQtyfollowbox
            // 
            deliveryQtyfollowbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryQtyfollowbox.Location = new Point(155, 246);
            deliveryQtyfollowbox.Margin = new Padding(5, 4, 5, 4);
            deliveryQtyfollowbox.Name = "deliveryQtyfollowbox";
            deliveryQtyfollowbox.Size = new Size(149, 23);
            deliveryQtyfollowbox.TabIndex = 21;
            // 
            // deliveryQtydeliverdbox
            // 
            deliveryQtydeliverdbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryQtydeliverdbox.Location = new Point(155, 287);
            deliveryQtydeliverdbox.Margin = new Padding(5, 4, 5, 4);
            deliveryQtydeliverdbox.Name = "deliveryQtydeliverdbox";
            deliveryQtydeliverdbox.Size = new Size(149, 23);
            deliveryQtydeliverdbox.TabIndex = 22;
            // 
            // deliveryOderedquantitybox
            // 
            deliveryOderedquantitybox.Location = new Point(465, 246);
            deliveryOderedquantitybox.Name = "deliveryOderedquantitybox";
            deliveryOderedquantitybox.Size = new Size(147, 23);
            deliveryOderedquantitybox.TabIndex = 33;
            // 
            // deliveryPerviousqtybtn
            // 
            deliveryPerviousqtybtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryPerviousqtybtn.Location = new Point(155, 337);
            deliveryPerviousqtybtn.Margin = new Padding(4, 3, 4, 3);
            deliveryPerviousqtybtn.Name = "deliveryPerviousqtybtn";
            deliveryPerviousqtybtn.Size = new Size(149, 23);
            deliveryPerviousqtybtn.TabIndex = 24;
            // 
            // deliveryDeliveryAddressBox1
            // 
            deliveryDeliveryAddressBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryDeliveryAddressBox1.Location = new Point(461, 106);
            deliveryDeliveryAddressBox1.Margin = new Padding(4, 3, 4, 3);
            deliveryDeliveryAddressBox1.Name = "deliveryDeliveryAddressBox1";
            deliveryDeliveryAddressBox1.Size = new Size(151, 23);
            deliveryDeliveryAddressBox1.TabIndex = 25;
            // 
            // deliveryPhoneNo
            // 
            deliveryPhoneNo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryPhoneNo.Location = new Point(461, 194);
            deliveryPhoneNo.Margin = new Padding(4, 3, 4, 3);
            deliveryPhoneNo.Name = "deliveryPhoneNo";
            deliveryPhoneNo.Size = new Size(150, 23);
            deliveryPhoneNo.TabIndex = 26;
            // 
            // deliveryClearbtn
            // 
            deliveryClearbtn.BackColor = Color.Red;
            deliveryClearbtn.Font = new Font("Microsoft Sans Serif", 12F);
            deliveryClearbtn.ForeColor = Color.White;
            deliveryClearbtn.Location = new Point(244, 393);
            deliveryClearbtn.Margin = new Padding(4, 3, 4, 3);
            deliveryClearbtn.Name = "deliveryClearbtn";
            deliveryClearbtn.Size = new Size(150, 29);
            deliveryClearbtn.TabIndex = 27;
            deliveryClearbtn.Text = "Clear";
            deliveryClearbtn.UseVisualStyleBackColor = false;
            // 
            // deliveryDateTimePicker
            // 
            deliveryDateTimePicker.Location = new Point(461, 149);
            deliveryDateTimePicker.Name = "deliveryDateTimePicker";
            deliveryDateTimePicker.Size = new Size(151, 23);
            deliveryDateTimePicker.TabIndex = 28;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(427, 393);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(181, 29);
            button1.TabIndex = 35;
            button1.Text = "View Delivery Order";
            button1.UseVisualStyleBackColor = false;
            // 
            // Delivery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(630, 461);
            Controls.Add(button1);
            Controls.Add(deliveryDateTimePicker);
            Controls.Add(deliveryClearbtn);
            Controls.Add(deliveryPhoneNo);
            Controls.Add(deliveryDeliveryAddressBox1);
            Controls.Add(deliveryPerviousqtybtn);
            Controls.Add(deliveryOderedquantitybox);
            Controls.Add(deliveryQtydeliverdbox);
            Controls.Add(deliveryQtyfollowbox);
            Controls.Add(deliveryOutstandingbox);
            Controls.Add(deliveryDeliveryidbox);
            Controls.Add(deliveryOrderidbox);
            Controls.Add(deliveryCreatebtn);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Delivery";
            Text = "Delivery";
            Load += Delivery_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button deliveryCreatebtn;
        private TextBox deliveryOrderidbox;
        private TextBox deliveryDeliveryidbox;
        private TextBox deliveryOutstandingbox;
        private TextBox deliveryQtyfollowbox;
        private TextBox deliveryQtydeliverdbox;
        private TextBox deliveryOderedquantitybox;
        private TextBox deliveryPerviousqtybtn;

        private TextBox deliveryDeliveryAddressBox1;
        private TextBox deliveryPhoneNo;
        private Button deliveryClearbtn;
        private DateTimePicker deliveryDateTimePicker;

        private TextBox deliveryDeliveryaddressbox;
        private TextBox deliveryPhoneNumbox;
        private Button button1;
    }
}