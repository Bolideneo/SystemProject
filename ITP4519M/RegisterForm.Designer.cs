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
            label1 = new Label();
            registerDisplaynameBox = new TextBox();
            createAccountBtn = new Button();
            label2 = new Label();
            newAccountlabel = new Label();
            label4 = new Label();
            mailBox = new TextBox();
            label5 = new Label();
            phoneNumBox = new TextBox();
            label6 = new Label();
            departBox = new ComboBox();
            button1 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            registerUsernameBox = new TextBox();
            registerPasswordBox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            registerPasswordAgainBox = new TextBox();
            label12 = new Label();
            positionBox = new TextBox();
            registerClearBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(455, 103);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 22;
            label1.Text = "DisplayName";
            // 
            // registerDisplaynameBox
            // 
            registerDisplaynameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerDisplaynameBox.Location = new Point(457, 126);
            registerDisplaynameBox.Margin = new Padding(4, 3, 4, 3);
            registerDisplaynameBox.Name = "registerDisplaynameBox";
            registerDisplaynameBox.Size = new Size(164, 23);
            registerDisplaynameBox.TabIndex = 21;
            registerDisplaynameBox.TextChanged += PasswordBox_TextChanged;
            // 
            // createAccountBtn
            // 
            createAccountBtn.AccessibleRole = AccessibleRole.None;
            createAccountBtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            createAccountBtn.Location = new Point(335, 405);
            createAccountBtn.Margin = new Padding(4, 3, 4, 3);
=======
            createAccountBtn.Location = new Point(381, 498);
            createAccountBtn.Margin = new Padding(5, 4, 5, 4);
>>>>>>> 45938bea4439c7074efa7e4b7914a66503aa7737
            createAccountBtn.Name = "createAccountBtn";
            createAccountBtn.Size = new Size(217, 36);
            createAccountBtn.TabIndex = 20;
            createAccountBtn.Text = "Create Account";
            createAccountBtn.UseVisualStyleBackColor = true;
            createAccountBtn.Click += createAccountBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(280, 103);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 19;
            label2.Text = "UserName";
            label2.Click += label2_Click;
            // 
            // newAccountlabel
            // 
            newAccountlabel.AutoSize = true;
            newAccountlabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newAccountlabel.ForeColor = Color.Black;
            newAccountlabel.Location = new Point(322, 42);
            newAccountlabel.Margin = new Padding(2, 0, 2, 0);
            newAccountlabel.Name = "newAccountlabel";
            newAccountlabel.Size = new Size(230, 26);
            newAccountlabel.TabIndex = 25;
            newAccountlabel.Text = "Create New Account";
            newAccountlabel.TextAlign = ContentAlignment.MiddleCenter;
            newAccountlabel.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(281, 231);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 27;
            label4.Text = "Mail Address";
            // 
            // mailBox
            // 
            mailBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mailBox.Location = new Point(284, 253);
            mailBox.Margin = new Padding(4, 3, 4, 3);
            mailBox.Name = "mailBox";
            mailBox.Size = new Size(163, 23);
            mailBox.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(455, 231);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 17);
            label5.TabIndex = 29;
            label5.Text = "Phone Number";
            // 
            // phoneNumBox
            // 
            phoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumBox.Location = new Point(458, 253);
            phoneNumBox.Margin = new Padding(4, 3, 4, 3);
            phoneNumBox.Name = "phoneNumBox";
            phoneNumBox.Size = new Size(163, 23);
            phoneNumBox.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            label6.Location = new Point(280, 306);
            label6.Margin = new Padding(4, 0, 4, 0);
=======
            label6.Location = new Point(320, 402);
            label6.Margin = new Padding(5, 0, 5, 0);
>>>>>>> 45938bea4439c7074efa7e4b7914a66503aa7737
            label6.Name = "label6";
            label6.Size = new Size(82, 17);
            label6.TabIndex = 31;
            label6.Text = "Department";
            label6.Click += label6_Click;
            // 
            // departBox
            // 
            departBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departBox.FormattingEnabled = true;
            departBox.Items.AddRange(new object[] { "IT", "Sales", "Account", "WareHouse" });
<<<<<<< HEAD
            departBox.Location = new Point(280, 334);
            departBox.Margin = new Padding(2, 2, 2, 2);
            departBox.Name = "departBox";
            departBox.Size = new Size(163, 25);
=======
            departBox.Location = new Point(326, 436);
            departBox.Margin = new Padding(2, 3, 2, 3);
            departBox.Name = "departBox";
            departBox.Size = new Size(185, 28);
>>>>>>> 45938bea4439c7074efa7e4b7914a66503aa7737
            departBox.TabIndex = 32;
            departBox.SelectedIndexChanged += departBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(621, 0);
            button1.Margin = new Padding(2, 2, 2, 2);
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
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
<<<<<<< HEAD
            panel1.Size = new Size(230, 497);
=======
            panel1.Size = new Size(263, 640);
>>>>>>> 45938bea4439c7074efa7e4b7914a66503aa7737
            panel1.TabIndex = 34;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(16, 240);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(177, 23);
            label8.TabIndex = 2;
            label8.Text = "the New Employee";
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
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
<<<<<<< HEAD
            pictureBox2.Size = new Size(225, 78);
=======
            pictureBox2.Size = new Size(257, 98);
>>>>>>> 45938bea4439c7074efa7e4b7914a66503aa7737
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // registerUsernameBox
            // 
            registerUsernameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerUsernameBox.Location = new Point(285, 126);
            registerUsernameBox.Margin = new Padding(4, 3, 4, 3);
            registerUsernameBox.Name = "registerUsernameBox";
            registerUsernameBox.Size = new Size(163, 23);
            registerUsernameBox.TabIndex = 17;
            registerUsernameBox.TextChanged += registerUsernameBox_TextChanged;
            // 
            // registerPasswordBox
            // 
            registerPasswordBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerPasswordBox.Location = new Point(282, 185);
            registerPasswordBox.Margin = new Padding(4, 3, 4, 3);
            registerPasswordBox.Name = "registerPasswordBox";
            registerPasswordBox.PasswordChar = '*';
            registerPasswordBox.Size = new Size(163, 23);
            registerPasswordBox.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(281, 163);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(69, 17);
            label10.TabIndex = 36;
            label10.Text = "Password";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(455, 163);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(109, 17);
            label11.TabIndex = 38;
            label11.Text = "Password Again";
            label11.Click += label11_Click;
            // 
            // registerPasswordAgainBox
            // 
            registerPasswordAgainBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerPasswordAgainBox.Location = new Point(457, 185);
            registerPasswordAgainBox.Margin = new Padding(4, 3, 4, 3);
            registerPasswordAgainBox.Name = "registerPasswordAgainBox";
            registerPasswordAgainBox.PasswordChar = '*';
            registerPasswordAgainBox.Size = new Size(164, 23);
            registerPasswordAgainBox.TabIndex = 37;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            label12.Location = new Point(458, 306);
            label12.Margin = new Padding(4, 0, 4, 0);
=======
            label12.Location = new Point(523, 402);
            label12.Margin = new Padding(5, 0, 5, 0);
>>>>>>> 45938bea4439c7074efa7e4b7914a66503aa7737
            label12.Name = "label12";
            label12.Size = new Size(58, 17);
            label12.TabIndex = 39;
            label12.Text = "Position";
            // 
            // positionBox
            // 
            positionBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            positionBox.Location = new Point(458, 336);
            positionBox.Margin = new Padding(4, 3, 4, 3);
=======
            positionBox.Location = new Point(523, 436);
            positionBox.Margin = new Padding(5, 4, 5, 4);
>>>>>>> 45938bea4439c7074efa7e4b7914a66503aa7737
            positionBox.Name = "positionBox";
            positionBox.Size = new Size(163, 23);
            positionBox.TabIndex = 42;
            // 
            // registerClearBtn
            // 
            registerClearBtn.AccessibleRole = AccessibleRole.None;
            registerClearBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            registerClearBtn.Location = new Point(400, 447);
            registerClearBtn.Margin = new Padding(4, 3, 4, 3);
=======
            registerClearBtn.Location = new Point(454, 564);
            registerClearBtn.Margin = new Padding(5, 4, 5, 4);
>>>>>>> 45938bea4439c7074efa7e4b7914a66503aa7737
            registerClearBtn.Name = "registerClearBtn";
            registerClearBtn.Size = new Size(84, 21);
            registerClearBtn.TabIndex = 43;
            registerClearBtn.Text = "Clear";
            registerClearBtn.UseVisualStyleBackColor = true;
            registerClearBtn.Click += button2_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
<<<<<<< HEAD
            ClientSize = new Size(656, 497);
=======
            ClientSize = new Size(750, 640);
>>>>>>> 45938bea4439c7074efa7e4b7914a66503aa7737
            Controls.Add(registerClearBtn);
            Controls.Add(positionBox);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(registerPasswordAgainBox);
            Controls.Add(label10);
            Controls.Add(registerPasswordBox);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(departBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(phoneNumBox);
            Controls.Add(label4);
            Controls.Add(mailBox);
            Controls.Add(newAccountlabel);
            Controls.Add(label1);
            Controls.Add(registerDisplaynameBox);
            Controls.Add(createAccountBtn);
            Controls.Add(label2);
            Controls.Add(registerUsernameBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox registerDisplaynameBox;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label newAccountlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneNumBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox departBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox registerUsernameBox;
        private System.Windows.Forms.TextBox registerPasswordBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox registerPasswordAgainBox;
        private System.Windows.Forms.Label label12;
        private TextBox positionBox;
        private Button registerClearBtn;
    }
}