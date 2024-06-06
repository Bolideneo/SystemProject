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
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(154, 29);
            label1.TabIndex = 0;
            label1.Text = "Create GRN";
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
            label3.Location = new Point(79, 141);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 2;
            label3.Text = "* PO ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 339);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 3;
            label4.Text = "* Received Qty :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(59, 209);
            label6.Name = "label6";
            label6.Size = new Size(122, 25);
            label6.TabIndex = 5;
            label6.Text = "* Product ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(45, 277);
            label7.Name = "label7";
            label7.Size = new Size(141, 25);
            label7.TabIndex = 6;
            label7.Text = "* WareHouse :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(45, 397);
            label12.Name = "label12";
            label12.Size = new Size(139, 25);
            label12.TabIndex = 11;
            label12.Text = "Receive Date :";
            // 
            // grnCreatebtn
            // 
            grnCreatebtn.BackColor = Color.FromArgb(0, 192, 0);
            grnCreatebtn.Font = new Font("Microsoft Sans Serif", 12F);
            grnCreatebtn.ForeColor = Color.White;
            grnCreatebtn.Location = new Point(137, 533);
            grnCreatebtn.Margin = new Padding(6, 5, 6, 5);
            grnCreatebtn.Name = "grnCreatebtn";
            grnCreatebtn.Size = new Size(195, 52);
            grnCreatebtn.TabIndex = 12;
            grnCreatebtn.Text = "Create";
            grnCreatebtn.UseVisualStyleBackColor = false;
            grnCreatebtn.Click += grnCreatebtn_Click;
            // 
            // grnPOIDbox
            // 
            grnPOIDbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grnPOIDbox.Location = new Point(193, 140);
            grnPOIDbox.Margin = new Padding(6, 5, 6, 5);
            grnPOIDbox.Name = "grnPOIDbox";
            grnPOIDbox.Size = new Size(180, 27);
            grnPOIDbox.TabIndex = 18;
            // 
            // grnProductIDbox
            // 
            grnProductIDbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grnProductIDbox.Location = new Point(193, 208);
            grnProductIDbox.Margin = new Padding(6, 5, 6, 5);
            grnProductIDbox.Name = "grnProductIDbox";
            grnProductIDbox.Size = new Size(180, 27);
            grnProductIDbox.TabIndex = 19;
            // 
            // grnwarehousebox
            // 
            grnwarehousebox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grnwarehousebox.Location = new Point(193, 273);
            grnwarehousebox.Margin = new Padding(6, 5, 6, 5);
            grnwarehousebox.Name = "grnwarehousebox";
            grnwarehousebox.Size = new Size(180, 27);
            grnwarehousebox.TabIndex = 20;
            // 
            // grnreceivedqtybox
            // 
            grnreceivedqtybox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grnreceivedqtybox.Location = new Point(193, 339);
            grnreceivedqtybox.Margin = new Padding(6, 5, 6, 5);
            grnreceivedqtybox.Name = "grnreceivedqtybox";
            grnreceivedqtybox.Size = new Size(180, 27);
            grnreceivedqtybox.TabIndex = 21;
            // 
            // deliveryClearbtn
            // 
            deliveryClearbtn.BackColor = Color.Red;
            deliveryClearbtn.Font = new Font("Microsoft Sans Serif", 12F);
            deliveryClearbtn.ForeColor = Color.White;
            deliveryClearbtn.Location = new Point(382, 538);
            deliveryClearbtn.Margin = new Padding(5, 4, 5, 4);
            deliveryClearbtn.Name = "deliveryClearbtn";
            deliveryClearbtn.Size = new Size(106, 43);
            deliveryClearbtn.TabIndex = 27;
            deliveryClearbtn.Text = "Clear";
            deliveryClearbtn.UseVisualStyleBackColor = false;
            deliveryClearbtn.Click += deliveryClearbtn_Click;
            // 
            // grnDateTimePicker
            // 
            grnDateTimePicker.Location = new Point(193, 395);
            grnDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            grnDateTimePicker.Name = "grnDateTimePicker";
            grnDateTimePicker.Size = new Size(242, 27);
            grnDateTimePicker.TabIndex = 28;
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(479, 7);
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
            grnerrorlbl.Location = new Point(169, 449);
            grnerrorlbl.Name = "grnerrorlbl";
            grnerrorlbl.RightToLeft = RightToLeft.No;
            grnerrorlbl.Size = new Size(243, 28);
            grnerrorlbl.TabIndex = 31;
            grnerrorlbl.Text = "* column cannot be empty";
            grnerrorlbl.Visible = false;
            grnerrorlbl.Click += grnerrorlbl_Click;
            // 
            // GRN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(521, 637);
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
            Margin = new Padding(3, 5, 3, 5);
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