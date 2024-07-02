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
            deliveryCreatebtn = new Button();
            deliveryClearbtn = new Button();
            panel1 = new Panel();
            deliveryOutstandingbox = new ComboBox();
            deliveryOrderidbox = new ComboBox();
            outstandingIDAlertlbl = new Label();
            orderIDAlertlbl = new Label();
            DeliverydateTimePicker1 = new DateTimePicker();
            deliveryerrorlbl = new Label();
            CloseButton = new Button();
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
            label3.Location = new Point(98, 75);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 2;
            label3.Text = "* Order ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 138);
            label4.Name = "label4";
            label4.Size = new Size(170, 25);
            label4.TabIndex = 3;
            label4.Text = "* OutStanding ID :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(61, 207);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 5;
            label6.Text = "* Delivery Date :";
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
            // deliveryClearbtn
            // 
            deliveryClearbtn.BackColor = Color.Red;
            deliveryClearbtn.Font = new Font("Microsoft Sans Serif", 12F);
            deliveryClearbtn.ForeColor = Color.White;
            deliveryClearbtn.Location = new Point(453, 329);
            deliveryClearbtn.Margin = new Padding(5, 4, 5, 4);
            deliveryClearbtn.Name = "deliveryClearbtn";
            deliveryClearbtn.Size = new Size(133, 35);
            deliveryClearbtn.TabIndex = 27;
            deliveryClearbtn.Text = "Clear";
            deliveryClearbtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(deliveryOutstandingbox);
            panel1.Controls.Add(deliveryOrderidbox);
            panel1.Controls.Add(outstandingIDAlertlbl);
            panel1.Controls.Add(orderIDAlertlbl);
            panel1.Controls.Add(DeliverydateTimePicker1);
            panel1.Controls.Add(deliveryerrorlbl);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(deliveryClearbtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(deliveryCreatebtn);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(5, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(613, 439);
            panel1.TabIndex = 36;
            // 
            // deliveryOutstandingbox
            // 
            deliveryOutstandingbox.FormattingEnabled = true;
            deliveryOutstandingbox.Location = new Point(245, 139);
            deliveryOutstandingbox.Name = "deliveryOutstandingbox";
            deliveryOutstandingbox.Size = new Size(190, 28);
            deliveryOutstandingbox.TabIndex = 41;
            // 
            // deliveryOrderidbox
            // 
            deliveryOrderidbox.FormattingEnabled = true;
            deliveryOrderidbox.Location = new Point(245, 71);
            deliveryOrderidbox.Name = "deliveryOrderidbox";
            deliveryOrderidbox.Size = new Size(190, 28);
            deliveryOrderidbox.TabIndex = 40;
            deliveryOrderidbox.SelectedIndexChanged += deliveryOrderidbox_SelectedIndexChanged;
            // 
            // outstandingIDAlertlbl
            // 
            outstandingIDAlertlbl.AutoSize = true;
            outstandingIDAlertlbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outstandingIDAlertlbl.ForeColor = Color.Red;
            outstandingIDAlertlbl.Location = new Point(246, 165);
            outstandingIDAlertlbl.Name = "outstandingIDAlertlbl";
            outstandingIDAlertlbl.RightToLeft = RightToLeft.No;
            outstandingIDAlertlbl.Size = new Size(313, 23);
            outstandingIDAlertlbl.TabIndex = 39;
            outstandingIDAlertlbl.Text = "Please input the correct Outstanding ID";
            outstandingIDAlertlbl.Visible = false;
            // 
            // orderIDAlertlbl
            // 
            orderIDAlertlbl.AutoSize = true;
            orderIDAlertlbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderIDAlertlbl.ForeColor = Color.Red;
            orderIDAlertlbl.Location = new Point(245, 102);
            orderIDAlertlbl.Name = "orderIDAlertlbl";
            orderIDAlertlbl.RightToLeft = RightToLeft.No;
            orderIDAlertlbl.Size = new Size(262, 23);
            orderIDAlertlbl.TabIndex = 38;
            orderIDAlertlbl.Text = "Please input the correct Order ID";
            orderIDAlertlbl.Visible = false;
            // 
            // DeliverydateTimePicker1
            // 
            DeliverydateTimePicker1.Location = new Point(245, 204);
            DeliverydateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            DeliverydateTimePicker1.Name = "DeliverydateTimePicker1";
            DeliverydateTimePicker1.Size = new Size(274, 27);
            DeliverydateTimePicker1.TabIndex = 37;
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
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(577, 7);
            CloseButton.Margin = new Padding(2, 3, 2, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(40, 49);
            CloseButton.TabIndex = 36;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // Delivery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(630, 615);
            Controls.Add(CloseButton);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 5, 3, 5);
            Name = "Delivery";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button deliveryCreatebtn;
        private Button deliveryClearbtn;

        private TextBox deliveryDeliveryaddressbox;
        private TextBox deliveryPhoneNumbox;
        private Panel panel1;
        private Label deliveryerrorlbl;
        private Button CloseButton;
        private DateTimePicker DeliverydateTimePicker1;
        private Label outstandingIDAlertlbl;
        private Label orderIDAlertlbl;
        private ComboBox deliveryOrderidbox;
        private ComboBox deliveryOutstandingbox;
    }
}