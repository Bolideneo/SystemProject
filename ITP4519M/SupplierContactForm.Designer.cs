namespace ITP4519M
{
    partial class SupplierContactForm
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
            editSupplierbtn = new Button();
            button1 = new Button();
            phoneNumlbl = new Label();
            SupplierPhoneNumBox = new TextBox();
            maillbl = new Label();
            SupplierMailBox = new TextBox();
            supplierInfolabel = new Label();
            createSupplierBtn = new Button();
            suppliernamelbl = new Label();
            suppliernameBox = new TextBox();
            supplierAddressBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 275);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 88;
            label1.Text = "Address";
            // 
            // editSupplierbtn
            // 
            editSupplierbtn.AccessibleRole = AccessibleRole.None;
            editSupplierbtn.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSupplierbtn.Location = new Point(210, 351);
            editSupplierbtn.Margin = new Padding(4, 3, 4, 3);
            editSupplierbtn.Name = "editSupplierbtn";
            editSupplierbtn.Size = new Size(160, 36);
            editSupplierbtn.TabIndex = 86;
            editSupplierbtn.Text = "Edit Supplier";
            editSupplierbtn.UseVisualStyleBackColor = true;
            editSupplierbtn.Click += editSupplierbtn_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(361, 16);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(35, 37);
            button1.TabIndex = 82;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // phoneNumlbl
            // 
            phoneNumlbl.AutoSize = true;
            phoneNumlbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumlbl.Location = new Point(11, 209);
            phoneNumlbl.Margin = new Padding(4, 0, 4, 0);
            phoneNumlbl.Name = "phoneNumlbl";
            phoneNumlbl.Size = new Size(108, 18);
            phoneNumlbl.TabIndex = 81;
            phoneNumlbl.Text = "Phone Number";
            // 
            // SupplierPhoneNumBox
            // 
            SupplierPhoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SupplierPhoneNumBox.Location = new Point(11, 231);
            SupplierPhoneNumBox.Margin = new Padding(4, 3, 4, 3);
            SupplierPhoneNumBox.Name = "SupplierPhoneNumBox";
            SupplierPhoneNumBox.Size = new Size(219, 23);
            SupplierPhoneNumBox.TabIndex = 80;
            // 
            // maillbl
            // 
            maillbl.AutoSize = true;
            maillbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maillbl.Location = new Point(10, 143);
            maillbl.Margin = new Padding(4, 0, 4, 0);
            maillbl.Name = "maillbl";
            maillbl.Size = new Size(93, 18);
            maillbl.TabIndex = 79;
            maillbl.Text = "Mail Address";
            // 
            // SupplierMailBox
            // 
            SupplierMailBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SupplierMailBox.Location = new Point(10, 165);
            SupplierMailBox.Margin = new Padding(4, 3, 4, 3);
            SupplierMailBox.Name = "SupplierMailBox";
            SupplierMailBox.Size = new Size(219, 23);
            SupplierMailBox.TabIndex = 78;
            // 
            // supplierInfolabel
            // 
            supplierInfolabel.AutoSize = true;
            supplierInfolabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplierInfolabel.ForeColor = Color.Black;
            supplierInfolabel.Location = new Point(11, 22);
            supplierInfolabel.Margin = new Padding(2, 0, 2, 0);
            supplierInfolabel.Name = "supplierInfolabel";
            supplierInfolabel.Size = new Size(227, 26);
            supplierInfolabel.TabIndex = 77;
            supplierInfolabel.Text = "Supplier Information";
            supplierInfolabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // createSupplierBtn
            // 
            createSupplierBtn.AccessibleRole = AccessibleRole.None;
            createSupplierBtn.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createSupplierBtn.Location = new Point(13, 351);
            createSupplierBtn.Margin = new Padding(4, 3, 4, 3);
            createSupplierBtn.Name = "createSupplierBtn";
            createSupplierBtn.Size = new Size(160, 36);
            createSupplierBtn.TabIndex = 74;
            createSupplierBtn.Text = "Create Supplier";
            createSupplierBtn.UseVisualStyleBackColor = true;
            createSupplierBtn.Click += createSupplierBtn_Click;
            // 
            // suppliernamelbl
            // 
            suppliernamelbl.AutoSize = true;
            suppliernamelbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            suppliernamelbl.Location = new Point(10, 78);
            suppliernamelbl.Margin = new Padding(4, 0, 4, 0);
            suppliernamelbl.Name = "suppliernamelbl";
            suppliernamelbl.Size = new Size(105, 18);
            suppliernamelbl.TabIndex = 73;
            suppliernamelbl.Text = "Supplier Name";
            // 
            // suppliernameBox
            // 
            suppliernameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            suppliernameBox.Location = new Point(11, 101);
            suppliernameBox.Margin = new Padding(4, 3, 4, 3);
            suppliernameBox.Name = "suppliernameBox";
            suppliernameBox.Size = new Size(221, 23);
            suppliernameBox.TabIndex = 72;
            // 
            // supplierAddressBox
            // 
            supplierAddressBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplierAddressBox.Location = new Point(11, 301);
            supplierAddressBox.Margin = new Padding(4, 3, 4, 3);
            supplierAddressBox.Name = "supplierAddressBox";
            supplierAddressBox.Size = new Size(318, 23);
            supplierAddressBox.TabIndex = 89;
            // 
            // SupplierContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 414);
            Controls.Add(supplierAddressBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(phoneNumlbl);
            Controls.Add(SupplierPhoneNumBox);
            Controls.Add(maillbl);
            Controls.Add(SupplierMailBox);
            Controls.Add(suppliernamelbl);
            Controls.Add(suppliernameBox);
            Controls.Add(supplierInfolabel);
            Controls.Add(createSupplierBtn);
            Controls.Add(editSupplierbtn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SupplierContactForm";
            Text = "SupplierContactForm";
            Load += SupplierContactForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button editSupplierbtn;
        private Button button1;
        private Label phoneNumlbl;
        private TextBox SupplierPhoneNumBox;
        private Label maillbl;
        private TextBox SupplierMailBox;
        private Label supplierInfolabel;
        private Label dealerCompanyNamelbl;
        private TextBox registerDisplaynameBox;
        private Button createSupplierBtn;
        private Label suppliernamelbl;
        private TextBox suppliernameBox;
        private TextBox supplierAddressBox;
    }
}