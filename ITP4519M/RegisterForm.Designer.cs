namespace ITP4519M
{
    partial class RegisterForm
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
            displaynamelbl = new Label();
            registerDisplaynameBox = new TextBox();
            createAccountBtn = new Button();
            usernamelbl = new Label();
            newAccountlabel = new Label();
            maillbl = new Label();
            mailBox = new TextBox();
            phoneNumlbl = new Label();
            phoneNumBox = new TextBox();
            departlbl = new Label();
            departBox = new ComboBox();
            button1 = new Button();
            panel1 = new Panel();
            accountreadlbl = new Label();
            label7 = new Label();
            accountlbl = new Label();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            registerUsernameBox = new TextBox();
            registerPasswordBox = new TextBox();
            passwordlbl = new Label();
            passwordAgainlbl = new Label();
            registerPasswordAgainBox = new TextBox();
            titlelbl = new Label();
            titleBox = new TextBox();
            registerClearBtn = new Button();
            accountEditlbl = new Label();
            viewaccountlbl = new Label();
            editAccountbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // displaynamelbl
            // 
            displaynamelbl.AutoSize = true;
            displaynamelbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displaynamelbl.Location = new Point(462, 103);
            displaynamelbl.Margin = new Padding(4, 0, 4, 0);
            displaynamelbl.Name = "displaynamelbl";
            displaynamelbl.Size = new Size(91, 17);
            displaynamelbl.TabIndex = 22;
            displaynamelbl.Text = "DisplayName";
            // 
            // registerDisplaynameBox
            // 
            registerDisplaynameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerDisplaynameBox.Location = new Point(464, 126);
            registerDisplaynameBox.Margin = new Padding(4, 3, 4, 3);
            registerDisplaynameBox.Name = "registerDisplaynameBox";
            registerDisplaynameBox.Size = new Size(191, 23);
            registerDisplaynameBox.TabIndex = 21;
            registerDisplaynameBox.TextChanged += PasswordBox_TextChanged;
            // 
            // createAccountBtn
            // 
            createAccountBtn.AccessibleRole = AccessibleRole.None;
            createAccountBtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createAccountBtn.Location = new Point(373, 387);
            createAccountBtn.Margin = new Padding(4, 3, 4, 3);
            createAccountBtn.Name = "createAccountBtn";
            createAccountBtn.Size = new Size(217, 36);
            createAccountBtn.TabIndex = 20;
            createAccountBtn.Text = "Create Account";
            createAccountBtn.UseVisualStyleBackColor = true;
            createAccountBtn.Click += createAccountBtn_Click;
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamelbl.Location = new Point(256, 103);
            usernamelbl.Margin = new Padding(4, 0, 4, 0);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(75, 17);
            usernamelbl.TabIndex = 19;
            usernamelbl.Text = "UserName";
            usernamelbl.Click += label2_Click;
            // 
            // newAccountlabel
            // 
            newAccountlabel.AutoSize = true;
            newAccountlabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newAccountlabel.ForeColor = Color.Black;
            newAccountlabel.Location = new Point(332, 42);
            newAccountlabel.Margin = new Padding(2, 0, 2, 0);
            newAccountlabel.Name = "newAccountlabel";
            newAccountlabel.Size = new Size(230, 26);
            newAccountlabel.TabIndex = 25;
            newAccountlabel.Text = "Create New Account";
            newAccountlabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // maillbl
            // 
            maillbl.AutoSize = true;
            maillbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maillbl.Location = new Point(257, 231);
            maillbl.Margin = new Padding(4, 0, 4, 0);
            maillbl.Name = "maillbl";
            maillbl.Size = new Size(89, 17);
            maillbl.TabIndex = 27;
            maillbl.Text = "Mail Address";
            // 
            // mailBox
            // 
            mailBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mailBox.Location = new Point(257, 253);
            mailBox.Margin = new Padding(4, 3, 4, 3);
            mailBox.Name = "mailBox";
            mailBox.Size = new Size(219, 23);
            mailBox.TabIndex = 26;
            // 
            // phoneNumlbl
            // 
            phoneNumlbl.AutoSize = true;
            phoneNumlbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumlbl.Location = new Point(485, 231);
            phoneNumlbl.Margin = new Padding(4, 0, 4, 0);
            phoneNumlbl.Name = "phoneNumlbl";
            phoneNumlbl.Size = new Size(103, 17);
            phoneNumlbl.TabIndex = 29;
            phoneNumlbl.Text = "Phone Number";
            // 
            // phoneNumBox
            // 
            phoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumBox.Location = new Point(485, 253);
            phoneNumBox.Margin = new Padding(4, 3, 4, 3);
            phoneNumBox.Name = "phoneNumBox";
            phoneNumBox.Size = new Size(170, 23);
            phoneNumBox.TabIndex = 28;
            // 
            // departlbl
            // 
            departlbl.AutoSize = true;
            departlbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departlbl.Location = new Point(485, 295);
            departlbl.Margin = new Padding(4, 0, 4, 0);
            departlbl.Name = "departlbl";
            departlbl.Size = new Size(82, 17);
            departlbl.TabIndex = 31;
            departlbl.Text = "Department";
            departlbl.Click += label6_Click;
            // 
            // departBox
            // 
            departBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departBox.FormattingEnabled = true;
            departBox.Items.AddRange(new object[] { "IT", "Sales", "Account", "WareHouse" });
            departBox.Location = new Point(485, 315);
            departBox.Margin = new Padding(2);
            departBox.Name = "departBox";
            departBox.Size = new Size(170, 25);
            departBox.TabIndex = 32;
            departBox.SelectedIndexChanged += departBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(671, 0);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(35, 37);
            button1.TabIndex = 33;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.MenuText;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(accountreadlbl);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(accountlbl);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 480);
            panel1.TabIndex = 34;
            // 
            // accountreadlbl
            // 
            accountreadlbl.AutoSize = true;
            accountreadlbl.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountreadlbl.ForeColor = SystemColors.Window;
            accountreadlbl.Location = new Point(16, 240);
            accountreadlbl.Margin = new Padding(2, 0, 2, 0);
            accountreadlbl.Name = "accountreadlbl";
            accountreadlbl.Size = new Size(132, 23);
            accountreadlbl.TabIndex = 4;
            accountreadlbl.Text = "the Employee";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(16, 278);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(117, 23);
            label7.TabIndex = 3;
            label7.Text = "Information";
            // 
            // accountlbl
            // 
            accountlbl.AutoSize = true;
            accountlbl.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountlbl.ForeColor = SystemColors.Window;
            accountlbl.Location = new Point(16, 240);
            accountlbl.Margin = new Padding(2, 0, 2, 0);
            accountlbl.Name = "accountlbl";
            accountlbl.Size = new Size(177, 23);
            accountlbl.TabIndex = 2;
            accountlbl.Text = "the New Employee";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(16, 200);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(121, 23);
            label9.TabIndex = 1;
            label9.Text = "Please fill in";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.company_logo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(2, 73);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(225, 74);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // registerUsernameBox
            // 
            registerUsernameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerUsernameBox.Location = new Point(257, 126);
            registerUsernameBox.Margin = new Padding(4, 3, 4, 3);
            registerUsernameBox.Name = "registerUsernameBox";
            registerUsernameBox.Size = new Size(191, 23);
            registerUsernameBox.TabIndex = 17;
            registerUsernameBox.TextChanged += registerUsernameBox_TextChanged;
            // 
            // registerPasswordBox
            // 
            registerPasswordBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerPasswordBox.Location = new Point(257, 185);
            registerPasswordBox.Margin = new Padding(4, 3, 4, 3);
            registerPasswordBox.Name = "registerPasswordBox";
            registerPasswordBox.PasswordChar = '*';
            registerPasswordBox.Size = new Size(191, 23);
            registerPasswordBox.TabIndex = 35;
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordlbl.Location = new Point(257, 163);
            passwordlbl.Margin = new Padding(4, 0, 4, 0);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(69, 17);
            passwordlbl.TabIndex = 36;
            passwordlbl.Text = "Password";
            passwordlbl.Click += label10_Click;
            // 
            // passwordAgainlbl
            // 
            passwordAgainlbl.AutoSize = true;
            passwordAgainlbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordAgainlbl.Location = new Point(462, 163);
            passwordAgainlbl.Margin = new Padding(4, 0, 4, 0);
            passwordAgainlbl.Name = "passwordAgainlbl";
            passwordAgainlbl.Size = new Size(109, 17);
            passwordAgainlbl.TabIndex = 38;
            passwordAgainlbl.Text = "Password Again";
            passwordAgainlbl.Click += label11_Click;
            // 
            // registerPasswordAgainBox
            // 
            registerPasswordAgainBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerPasswordAgainBox.Location = new Point(464, 185);
            registerPasswordAgainBox.Margin = new Padding(4, 3, 4, 3);
            registerPasswordAgainBox.Name = "registerPasswordAgainBox";
            registerPasswordAgainBox.PasswordChar = '*';
            registerPasswordAgainBox.Size = new Size(191, 23);
            registerPasswordAgainBox.TabIndex = 37;
            // 
            // titlelbl
            // 
            titlelbl.AutoSize = true;
            titlelbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titlelbl.Location = new Point(257, 295);
            titlelbl.Margin = new Padding(4, 0, 4, 0);
            titlelbl.Name = "titlelbl";
            titlelbl.Size = new Size(35, 17);
            titlelbl.TabIndex = 39;
            titlelbl.Text = "Title";
            // 
            // titleBox
            // 
            titleBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleBox.Location = new Point(257, 316);
            titleBox.Margin = new Padding(4, 3, 4, 3);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(219, 23);
            titleBox.TabIndex = 42;
            // 
            // registerClearBtn
            // 
            registerClearBtn.AccessibleRole = AccessibleRole.None;
            registerClearBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerClearBtn.Location = new Point(436, 429);
            registerClearBtn.Margin = new Padding(4, 3, 4, 3);
            registerClearBtn.Name = "registerClearBtn";
            registerClearBtn.Size = new Size(84, 21);
            registerClearBtn.TabIndex = 43;
            registerClearBtn.Text = "Clear";
            registerClearBtn.UseVisualStyleBackColor = true;
            registerClearBtn.Click += button2_Click;
            // 
            // accountEditlbl
            // 
            accountEditlbl.AutoSize = true;
            accountEditlbl.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountEditlbl.ForeColor = Color.Black;
            accountEditlbl.Location = new Point(373, 42);
            accountEditlbl.Margin = new Padding(2, 0, 2, 0);
            accountEditlbl.Name = "accountEditlbl";
            accountEditlbl.Size = new Size(147, 26);
            accountEditlbl.TabIndex = 44;
            accountEditlbl.Text = "Edit Account";
            accountEditlbl.TextAlign = ContentAlignment.BottomRight;
            // 
            // viewaccountlbl
            // 
            viewaccountlbl.AutoSize = true;
            viewaccountlbl.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewaccountlbl.ForeColor = Color.Black;
            viewaccountlbl.Location = new Point(373, 42);
            viewaccountlbl.Margin = new Padding(2, 0, 2, 0);
            viewaccountlbl.Name = "viewaccountlbl";
            viewaccountlbl.Size = new Size(157, 26);
            viewaccountlbl.TabIndex = 45;
            viewaccountlbl.Text = "View Account";
            viewaccountlbl.TextAlign = ContentAlignment.BottomRight;
            // 
            // editAccountbtn
            // 
            editAccountbtn.AccessibleRole = AccessibleRole.None;
            editAccountbtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editAccountbtn.Location = new Point(373, 387);
            editAccountbtn.Margin = new Padding(4, 3, 4, 3);
            editAccountbtn.Name = "editAccountbtn";
            editAccountbtn.Size = new Size(217, 36);
            editAccountbtn.TabIndex = 46;
            editAccountbtn.Text = "Edit Account";
            editAccountbtn.UseVisualStyleBackColor = true;
            editAccountbtn.Click += editAccountbtn_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(706, 480);
            Controls.Add(editAccountbtn);
            Controls.Add(viewaccountlbl);
            Controls.Add(accountEditlbl);
            Controls.Add(registerClearBtn);
            Controls.Add(titleBox);
            Controls.Add(titlelbl);
            Controls.Add(passwordAgainlbl);
            Controls.Add(registerPasswordAgainBox);
            Controls.Add(passwordlbl);
            Controls.Add(registerPasswordBox);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(departBox);
            Controls.Add(departlbl);
            Controls.Add(phoneNumlbl);
            Controls.Add(phoneNumBox);
            Controls.Add(maillbl);
            Controls.Add(mailBox);
            Controls.Add(newAccountlabel);
            Controls.Add(displaynamelbl);
            Controls.Add(registerDisplaynameBox);
            Controls.Add(createAccountBtn);
            Controls.Add(usernamelbl);
            Controls.Add(registerUsernameBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            MouseDown += RegisterForm_MouseDown;
            MouseMove += RegisterForm_MouseMove;
            MouseUp += RegisterForm_MouseUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label displaynamelbl;
        private System.Windows.Forms.TextBox registerDisplaynameBox;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label newAccountlabel;
        private System.Windows.Forms.Label maillbl;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.Label phoneNumlbl;
        private System.Windows.Forms.TextBox phoneNumBox;
        private System.Windows.Forms.Label departlbl;
        private System.Windows.Forms.ComboBox departBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label accountlbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox registerUsernameBox;
        private System.Windows.Forms.TextBox registerPasswordBox;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label passwordAgainlbl;
        private System.Windows.Forms.TextBox registerPasswordAgainBox;
        private System.Windows.Forms.Label titlelbl;
        private TextBox titleBox;
        private Button registerClearBtn;
        private Label accountEditlbl;
        private Label viewaccountlbl;
        private Button editAccountbtn;
        private Label accountreadlbl;
    }
}