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
            label2 = new Label();
            supplierContactBox = new TextBox();
            suppliedProductData = new DataGridView();
            stockcheckColumn = new DataGridViewCheckBoxColumn();
            label3 = new Label();
            companyNameAlert = new Label();
            mailAlert = new Label();
            contactPersonAlert = new Label();
            phoneAlertlbl = new Label();
            addressAlert = new Label();
            productSelectAlert = new Label();
            ((System.ComponentModel.ISupportInitialize)suppliedProductData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 220);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 88;
            label1.Text = "Address";
            // 
            // editSupplierbtn
            // 
            editSupplierbtn.AccessibleRole = AccessibleRole.None;
            editSupplierbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSupplierbtn.Location = new Point(288, 494);
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
            button1.Location = new Point(452, 9);
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
            phoneNumlbl.Location = new Point(259, 149);
            phoneNumlbl.Margin = new Padding(4, 0, 4, 0);
            phoneNumlbl.Name = "phoneNumlbl";
            phoneNumlbl.Size = new Size(108, 18);
            phoneNumlbl.TabIndex = 81;
            phoneNumlbl.Text = "Phone Number";
            // 
            // SupplierPhoneNumBox
            // 
            SupplierPhoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SupplierPhoneNumBox.Location = new Point(259, 170);
            SupplierPhoneNumBox.Margin = new Padding(4, 3, 4, 3);
            SupplierPhoneNumBox.Name = "SupplierPhoneNumBox";
            SupplierPhoneNumBox.Size = new Size(219, 23);
            SupplierPhoneNumBox.TabIndex = 80;
            // 
            // maillbl
            // 
            maillbl.AutoSize = true;
            maillbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maillbl.Location = new Point(10, 149);
            maillbl.Margin = new Padding(4, 0, 4, 0);
            maillbl.Name = "maillbl";
            maillbl.Size = new Size(45, 18);
            maillbl.TabIndex = 79;
            maillbl.Text = "Email";
            // 
            // SupplierMailBox
            // 
            SupplierMailBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SupplierMailBox.Location = new Point(12, 170);
            SupplierMailBox.Margin = new Padding(4, 3, 4, 3);
            SupplierMailBox.Name = "SupplierMailBox";
            SupplierMailBox.Size = new Size(238, 23);
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
            supplierInfolabel.Size = new Size(289, 26);
            supplierInfolabel.TabIndex = 77;
            supplierInfolabel.Text = "Supplier Information Form";
            supplierInfolabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // createSupplierBtn
            // 
            createSupplierBtn.AccessibleRole = AccessibleRole.None;
            createSupplierBtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createSupplierBtn.Location = new Point(288, 494);
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
            suppliernamelbl.Size = new Size(173, 18);
            suppliernamelbl.TabIndex = 73;
            suppliernamelbl.Text = "Supplier Company Name";
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
            supplierAddressBox.Location = new Point(11, 246);
            supplierAddressBox.Margin = new Padding(4, 3, 4, 3);
            supplierAddressBox.Name = "supplierAddressBox";
            supplierAddressBox.Size = new Size(465, 23);
            supplierAddressBox.TabIndex = 89;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(259, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 18);
            label2.TabIndex = 91;
            label2.Text = "Contact Person";
            // 
            // supplierContactBox
            // 
            supplierContactBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplierContactBox.Location = new Point(261, 101);
            supplierContactBox.Margin = new Padding(4, 3, 4, 3);
            supplierContactBox.Name = "supplierContactBox";
            supplierContactBox.Size = new Size(221, 23);
            supplierContactBox.TabIndex = 90;
            // 
            // suppliedProductData
            // 
            suppliedProductData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            suppliedProductData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suppliedProductData.Columns.AddRange(new DataGridViewColumn[] { stockcheckColumn });
            suppliedProductData.Location = new Point(11, 343);
            suppliedProductData.Margin = new Padding(3, 2, 3, 2);
            suppliedProductData.Name = "suppliedProductData";
            suppliedProductData.RowHeadersWidth = 51;
            suppliedProductData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            suppliedProductData.Size = new Size(465, 139);
            suppliedProductData.TabIndex = 92;
            suppliedProductData.CellContentClick += suppliedProductData_CellContentClick;
            // 
            // stockcheckColumn
            // 
            stockcheckColumn.FillWeight = 50F;
            stockcheckColumn.HeaderText = "Select";
            stockcheckColumn.MinimumWidth = 40;
            stockcheckColumn.Name = "stockcheckColumn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 314);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 18);
            label3.TabIndex = 93;
            label3.Text = "Products supplied";
            // 
            // companyNameAlert
            // 
            companyNameAlert.AutoSize = true;
            companyNameAlert.ForeColor = Color.Red;
            companyNameAlert.Location = new Point(12, 124);
            companyNameAlert.Name = "companyNameAlert";
            companyNameAlert.Size = new Size(207, 15);
            companyNameAlert.TabIndex = 94;
            companyNameAlert.Text = "Please input Supplier Company Name";
            // 
            // mailAlert
            // 
            mailAlert.AutoSize = true;
            mailAlert.ForeColor = Color.SteelBlue;
            mailAlert.Location = new Point(12, 194);
            mailAlert.Name = "mailAlert";
            mailAlert.Size = new Size(135, 15);
            mailAlert.TabIndex = 95;
            mailAlert.Text = "example@example.com";
            // 
            // contactPersonAlert
            // 
            contactPersonAlert.AutoSize = true;
            contactPersonAlert.ForeColor = Color.Red;
            contactPersonAlert.Location = new Point(259, 124);
            contactPersonAlert.Name = "contactPersonAlert";
            contactPersonAlert.Size = new Size(190, 15);
            contactPersonAlert.TabIndex = 96;
            contactPersonAlert.Text = "Please input Contact Person Name";
            // 
            // phoneAlertlbl
            // 
            phoneAlertlbl.AutoSize = true;
            phoneAlertlbl.Font = new Font("Segoe UI", 9F);
            phoneAlertlbl.ForeColor = Color.SteelBlue;
            phoneAlertlbl.Location = new Point(259, 194);
            phoneAlertlbl.Name = "phoneAlertlbl";
            phoneAlertlbl.Size = new Size(92, 15);
            phoneAlertlbl.TabIndex = 97;
            phoneAlertlbl.Text = "6 to 13 numbers";
            // 
            // addressAlert
            // 
            addressAlert.AutoSize = true;
            addressAlert.ForeColor = Color.Red;
            addressAlert.Location = new Point(12, 269);
            addressAlert.Name = "addressAlert";
            addressAlert.Size = new Size(116, 15);
            addressAlert.TabIndex = 98;
            addressAlert.Text = "Please input Address";
            // 
            // productSelectAlert
            // 
            productSelectAlert.AutoSize = true;
            productSelectAlert.ForeColor = Color.Red;
            productSelectAlert.Location = new Point(181, 316);
            productSelectAlert.Name = "productSelectAlert";
            productSelectAlert.Size = new Size(161, 15);
            productSelectAlert.TabIndex = 99;
            productSelectAlert.Text = "Select at least one product！ ";
            // 
            // SupplierContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 547);
            Controls.Add(productSelectAlert);
            Controls.Add(addressAlert);
            Controls.Add(phoneAlertlbl);
            Controls.Add(contactPersonAlert);
            Controls.Add(mailAlert);
            Controls.Add(companyNameAlert);
            Controls.Add(label3);
            Controls.Add(suppliedProductData);
            Controls.Add(label2);
            Controls.Add(supplierContactBox);
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
            MouseDown += Dashboard_MouseDown;
            MouseMove += Dashboard_MouseMove;
            MouseUp += Dashboard_MouseUp;
            ((System.ComponentModel.ISupportInitialize)suppliedProductData).EndInit();
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
        private Label label2;
        private TextBox supplierContactBox;
        private DataGridView suppliedProductData;
        private Label label3;
        private DataGridViewCheckBoxColumn stockcheckColumn;
        private Label companyNameAlert;
        private Label mailAlert;
        private Label contactPersonAlert;
        private Label phoneAlertlbl;
        private Label addressAlert;
        private Label productSelectAlert;
    }
}