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
            label6 = new Label();
            label10 = new Label();
            deliveryCreatebtn = new Button();
            deliveryOrderidbox = new TextBox();
            deliveryDeliveryidbox = new TextBox();
            deliveryOutstandingbox = new TextBox();
            deliveryInvoiceIDbox = new TextBox();
            deliveryClearbtn = new Button();
            panel1 = new Panel();
            deliveryerrorlbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(184, 29);
            label1.TabIndex = 0;
            label1.Text = "Delivery Notes";
            label1.Click += label1_Click;
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
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(113, 44);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 2;
            label3.Text = "*Order ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 209);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 3;
            label4.Text = "OutStanding ID :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(93, 99);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 5;
            label6.Text = "*Delivery ID :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(93, 151);
            label10.Name = "label10";
            label10.Size = new Size(117, 25);
            label10.TabIndex = 9;
            label10.Text = "*Invoice ID :";
            label10.Click += label10_Click;
            // 
            // deliveryCreatebtn
            // 
            deliveryCreatebtn.BackColor = Color.FromArgb(0, 192, 0);
            deliveryCreatebtn.Font = new Font("Microsoft Sans Serif", 12F);
            deliveryCreatebtn.ForeColor = Color.White;
            deliveryCreatebtn.Location = new Point(192, 320);
            deliveryCreatebtn.Margin = new Padding(6, 5, 6, 5);
            deliveryCreatebtn.Name = "deliveryCreatebtn";
            deliveryCreatebtn.Size = new Size(224, 52);
            deliveryCreatebtn.TabIndex = 12;
            deliveryCreatebtn.Text = "Create";
            deliveryCreatebtn.UseVisualStyleBackColor = false;
            deliveryCreatebtn.Click += deliveryCreatebtn_Click;
            // 
            // deliveryOrderidbox
            // 
            deliveryOrderidbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryOrderidbox.Location = new Point(246, 45);
            deliveryOrderidbox.Margin = new Padding(6, 5, 6, 5);
            deliveryOrderidbox.Name = "deliveryOrderidbox";
            deliveryOrderidbox.Size = new Size(170, 27);
            deliveryOrderidbox.TabIndex = 18;
            // 
            // deliveryDeliveryidbox
            // 
            deliveryDeliveryidbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryDeliveryidbox.Location = new Point(246, 100);
            deliveryDeliveryidbox.Margin = new Padding(6, 5, 6, 5);
            deliveryDeliveryidbox.Name = "deliveryDeliveryidbox";
            deliveryDeliveryidbox.Size = new Size(170, 27);
            deliveryDeliveryidbox.TabIndex = 19;
            deliveryDeliveryidbox.TextChanged += deliveryDeliveryidbox_TextChanged;
            // 
            // deliveryOutstandingbox
            // 
            deliveryOutstandingbox.Location = new Point(246, 210);
            deliveryOutstandingbox.Margin = new Padding(3, 4, 3, 4);
            deliveryOutstandingbox.Name = "deliveryOutstandingbox";
            deliveryOutstandingbox.Size = new Size(167, 27);
            deliveryOutstandingbox.TabIndex = 34;
            deliveryOutstandingbox.TextChanged += deliveryOutstandingbox_TextChanged;
            // 
            // deliveryInvoiceIDbox
            // 
            deliveryInvoiceIDbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryInvoiceIDbox.Location = new Point(249, 151);
            deliveryInvoiceIDbox.Margin = new Padding(5, 4, 5, 4);
            deliveryInvoiceIDbox.Name = "deliveryInvoiceIDbox";
            deliveryInvoiceIDbox.Size = new Size(167, 27);
            deliveryInvoiceIDbox.TabIndex = 25;
            // 
            // deliveryClearbtn
            // 
            deliveryClearbtn.BackColor = Color.Red;
            deliveryClearbtn.Font = new Font("Microsoft Sans Serif", 12F);
            deliveryClearbtn.ForeColor = Color.White;
            deliveryClearbtn.Location = new Point(453, 329);
            deliveryClearbtn.Margin = new Padding(5, 4, 5, 4);
            deliveryClearbtn.Name = "deliveryClearbtn";
            deliveryClearbtn.Size = new Size(132, 35);
            deliveryClearbtn.TabIndex = 27;
            deliveryClearbtn.Text = "Clear";
            deliveryClearbtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(deliveryerrorlbl);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(deliveryClearbtn);
            panel1.Controls.Add(deliveryOrderidbox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(deliveryCreatebtn);
            panel1.Controls.Add(deliveryInvoiceIDbox);
            panel1.Controls.Add(deliveryDeliveryidbox);
            panel1.Controls.Add(deliveryOutstandingbox);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(5, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(613, 439);
            panel1.TabIndex = 36;
            // 
            // deliveryerrorlbl
            // 
            deliveryerrorlbl.AutoSize = true;
            deliveryerrorlbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryerrorlbl.ForeColor = Color.Red;
            deliveryerrorlbl.Location = new Point(192, 268);
            deliveryerrorlbl.Name = "deliveryerrorlbl";
            deliveryerrorlbl.RightToLeft = RightToLeft.No;
            deliveryerrorlbl.Size = new Size(243, 28);
            deliveryerrorlbl.TabIndex = 35;
            deliveryerrorlbl.Text = "* column cannot be empty";
            deliveryerrorlbl.Visible = false;
            // 
            // Delivery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(630, 615);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 5, 3, 5);
            Name = "Delivery";
            Text = "Delivery";
            Load += Delivery_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label10;
        private Button deliveryCreatebtn;
        private TextBox deliveryOrderidbox;
        private TextBox deliveryDeliveryidbox;
        private TextBox deliveryOutstandingbox;

        private TextBox deliveryInvoiceIDbox;
        private Button deliveryClearbtn;

        private TextBox deliveryDeliveryaddressbox;
        private TextBox deliveryPhoneNumbox;
        private Panel panel1;
        private Label deliveryerrorlbl;
    }
}