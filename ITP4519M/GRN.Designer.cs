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
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label12 = new Label();
            grnCreatebtn = new Button();
            grnPOIDbox = new TextBox();
            grnProductIDbox = new TextBox();
            grnwarehousebox = new TextBox();
            grnreceivedqtybox = new TextBox();
            deliveryClearbtn = new Button();
            grnDateTimePicker = new DateTimePicker();
            CloseButton = new Button();
            grnerrorlbl = new Label();
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
            label3.Location = new Point(69, 106);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "* PO ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 254);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 3;
            label4.Text = "* Received Qty :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 157);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 5;
            label6.Text = "* Product ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(39, 208);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 6;
            label7.Text = "* WareHouse :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(39, 298);
            label12.Name = "label12";
            label12.Size = new Size(113, 20);
            label12.TabIndex = 11;
            label12.Text = "Receive Date :";
            // 
            // grnCreatebtn
            // 
            grnCreatebtn.BackColor = Color.FromArgb(0, 192, 0);
            grnCreatebtn.Font = new Font("Microsoft Sans Serif", 12F);
            grnCreatebtn.ForeColor = Color.White;
            grnCreatebtn.Location = new Point(120, 400);
            grnCreatebtn.Margin = new Padding(5, 4, 5, 4);
            grnCreatebtn.Name = "grnCreatebtn";
            grnCreatebtn.Size = new Size(171, 39);
            grnCreatebtn.TabIndex = 12;
            grnCreatebtn.Text = "Create";
            grnCreatebtn.UseVisualStyleBackColor = false;
            grnCreatebtn.Click += deliveryCreatebtn_Click;
            // 
            // grnPOIDbox
            // 
            grnPOIDbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grnPOIDbox.Location = new Point(169, 105);
            grnPOIDbox.Margin = new Padding(5, 4, 5, 4);
            grnPOIDbox.Name = "grnPOIDbox";
            grnPOIDbox.Size = new Size(158, 23);
            grnPOIDbox.TabIndex = 18;
            // 
            // grnProductIDbox
            // 
            grnProductIDbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grnProductIDbox.Location = new Point(169, 156);
            grnProductIDbox.Margin = new Padding(5, 4, 5, 4);
            grnProductIDbox.Name = "grnProductIDbox";
            grnProductIDbox.Size = new Size(158, 23);
            grnProductIDbox.TabIndex = 19;
            // 
            // grnwarehousebox
            // 
            grnwarehousebox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grnwarehousebox.Location = new Point(169, 205);
            grnwarehousebox.Margin = new Padding(5, 4, 5, 4);
            grnwarehousebox.Name = "grnwarehousebox";
            grnwarehousebox.Size = new Size(158, 23);
            grnwarehousebox.TabIndex = 20;
            // 
            // grnreceivedqtybox
            // 
            grnreceivedqtybox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grnreceivedqtybox.Location = new Point(169, 254);
            grnreceivedqtybox.Margin = new Padding(5, 4, 5, 4);
            grnreceivedqtybox.Name = "grnreceivedqtybox";
            grnreceivedqtybox.Size = new Size(158, 23);
            grnreceivedqtybox.TabIndex = 21;
            // 
            // deliveryClearbtn
            // 
            deliveryClearbtn.BackColor = Color.Red;
            deliveryClearbtn.Font = new Font("Microsoft Sans Serif", 12F);
            deliveryClearbtn.ForeColor = Color.White;
            deliveryClearbtn.Location = new Point(327, 407);
            deliveryClearbtn.Margin = new Padding(4, 3, 4, 3);
            deliveryClearbtn.Name = "deliveryClearbtn";
            deliveryClearbtn.Size = new Size(93, 32);
            deliveryClearbtn.TabIndex = 27;
            deliveryClearbtn.Text = "Clear";
            deliveryClearbtn.UseVisualStyleBackColor = false;
            deliveryClearbtn.Click += deliveryClearbtn_Click;
            // 
            // grnDateTimePicker
            // 
            grnDateTimePicker.Location = new Point(169, 296);
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
            CloseButton.Location = new Point(419, 5);
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
            grnerrorlbl.Location = new Point(148, 337);
            grnerrorlbl.Name = "grnerrorlbl";
            grnerrorlbl.RightToLeft = RightToLeft.No;
            grnerrorlbl.Size = new Size(193, 21);
            grnerrorlbl.TabIndex = 31;
            grnerrorlbl.Text = "* column cannot be empty";
            grnerrorlbl.Visible = false;
            grnerrorlbl.Click += grnerrorlbl_Click;
            // 
            // GRN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(456, 478);
            Controls.Add(grnerrorlbl);
            Controls.Add(CloseButton);
            Controls.Add(grnDateTimePicker);
            Controls.Add(deliveryClearbtn);
            Controls.Add(grnreceivedqtybox);
            Controls.Add(grnwarehousebox);
            Controls.Add(grnProductIDbox);
            Controls.Add(grnPOIDbox);
            Controls.Add(grnCreatebtn);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "GRN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GRN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label12;
        private Button grnCreatebtn;
        private TextBox grnPOIDbox;
        private TextBox grnProductIDbox;
        private TextBox grnwarehousebox;
        private TextBox grnreceivedqtybox;
        private Button deliveryClearbtn;
        private DateTimePicker grnDateTimePicker;
        private Button CloseButton;
        private Label grnerrorlbl;
    }
}