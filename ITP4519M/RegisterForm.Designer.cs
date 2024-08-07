﻿using System.Data;
using static ProgramMethod.ProgramMethod;

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
            departBox = new BorderComboBox();
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
            passwordNotelbl = new Label();
            usernamepnl = new Panel();
            usernameAlertBox = new PictureBox();
            displaynamepnl = new Panel();
            displaynameAlertBox = new PictureBox();
            usernameAlertlbl = new Label();
            displaynameAlertlbl = new Label();
            emailAlertlbl = new Label();
            phoneAlertlbl = new Label();
            passwordpnl = new Panel();
            passwordAlertBox = new PictureBox();
            passwordAgainpnl = new Panel();
            passwordAgainAlertBox = new PictureBox();
            mailpnl = new Panel();
            mailAlertBox = new PictureBox();
            phonepnl = new Panel();
            phoneAlertBox = new PictureBox();
            titilepnl = new Panel();
            titleAlertBox = new PictureBox();
            titleAlertlbl = new Label();
            departAlertlbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            usernamepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usernameAlertBox).BeginInit();
            displaynamepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)displaynameAlertBox).BeginInit();
            passwordpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordAlertBox).BeginInit();
            passwordAgainpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordAgainAlertBox).BeginInit();
            mailpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mailAlertBox).BeginInit();
            phonepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phoneAlertBox).BeginInit();
            titilepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)titleAlertBox).BeginInit();
            SuspendLayout();
            // 
            // displaynamelbl
            // 
            displaynamelbl.AutoSize = true;
            displaynamelbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displaynamelbl.Location = new Point(462, 94);
            displaynamelbl.Margin = new Padding(4, 0, 4, 0);
            displaynamelbl.Name = "displaynamelbl";
            displaynamelbl.Size = new Size(91, 17);
            displaynamelbl.TabIndex = 22;
            displaynamelbl.Text = "DisplayName";
            // 
            // registerDisplaynameBox
            // 
            registerDisplaynameBox.BackColor = SystemColors.Window;
            registerDisplaynameBox.BorderStyle = BorderStyle.None;
            registerDisplaynameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerDisplaynameBox.Location = new Point(4, 3);
            registerDisplaynameBox.Margin = new Padding(4, 3, 4, 3);
            registerDisplaynameBox.Name = "registerDisplaynameBox";
            registerDisplaynameBox.Size = new Size(158, 16);
            registerDisplaynameBox.TabIndex = 21;
            // 
            // createAccountBtn
            // 
            createAccountBtn.AccessibleRole = AccessibleRole.None;
            createAccountBtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createAccountBtn.Location = new Point(353, 403);
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
            usernamelbl.Location = new Point(256, 94);
            usernamelbl.Margin = new Padding(4, 0, 4, 0);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(75, 17);
            usernamelbl.TabIndex = 19;
            usernamelbl.Text = "UserName";
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
            maillbl.Location = new Point(257, 264);
            maillbl.Margin = new Padding(4, 0, 4, 0);
            maillbl.Name = "maillbl";
            maillbl.Size = new Size(89, 17);
            maillbl.TabIndex = 27;
            maillbl.Text = "Mail Address";
            // 
            // mailBox
            // 
            mailBox.BorderStyle = BorderStyle.None;
            mailBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mailBox.Location = new Point(4, 3);
            mailBox.Margin = new Padding(4, 3, 4, 3);
            mailBox.Name = "mailBox";
            mailBox.Size = new Size(192, 16);
            mailBox.TabIndex = 26;
            // 
            // phoneNumlbl
            // 
            phoneNumlbl.AutoSize = true;
            phoneNumlbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumlbl.Location = new Point(491, 264);
            phoneNumlbl.Margin = new Padding(4, 0, 4, 0);
            phoneNumlbl.Name = "phoneNumlbl";
            phoneNumlbl.Size = new Size(103, 17);
            phoneNumlbl.TabIndex = 29;
            phoneNumlbl.Text = "Phone Number";
            // 
            // phoneNumBox
            // 
            phoneNumBox.BorderStyle = BorderStyle.None;
            phoneNumBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumBox.Location = new Point(4, 3);
            phoneNumBox.Margin = new Padding(4, 3, 4, 3);
            phoneNumBox.Name = "phoneNumBox";
            phoneNumBox.Size = new Size(158, 16);
            phoneNumBox.TabIndex = 28;
            // 
            // departlbl
            // 
            departlbl.AutoSize = true;
            departlbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departlbl.Location = new Point(491, 337);
            departlbl.Margin = new Padding(4, 0, 4, 0);
            departlbl.Name = "departlbl";
            departlbl.Size = new Size(82, 17);
            departlbl.TabIndex = 31;
            departlbl.Text = "Department";
            // 
            // departBox
            // 
            departBox.BorderColor = Color.Black;
            departBox.DisplayMember = "DepartmentName";
            departBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departBox.FormattingEnabled = true;
            departBox.Items.AddRange(new object[] { "IT", "Account", "Sales", "WareHouse", "Purchasing", "Invoice" });
            departBox.Location = new Point(491, 357);
            departBox.Margin = new Padding(2, 2, 2, 2);
            departBox.Name = "departBox";
            departBox.Size = new Size(191, 25);
            departBox.TabIndex = 32;
            departBox.ValueMember = "DepartmentName";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(671, 0);
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
            panel1.Controls.Add(accountreadlbl);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(accountlbl);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
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
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(225, 74);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // registerUsernameBox
            // 
            registerUsernameBox.BackColor = SystemColors.Window;
            registerUsernameBox.BorderStyle = BorderStyle.None;
            registerUsernameBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerUsernameBox.Location = new Point(4, 3);
            registerUsernameBox.Margin = new Padding(4, 3, 4, 3);
            registerUsernameBox.Name = "registerUsernameBox";
            registerUsernameBox.Size = new Size(158, 16);
            registerUsernameBox.TabIndex = 17;
            // 
            // registerPasswordBox
            // 
            registerPasswordBox.BorderStyle = BorderStyle.None;
            registerPasswordBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerPasswordBox.Location = new Point(4, 3);
            registerPasswordBox.Margin = new Padding(4, 3, 4, 3);
            registerPasswordBox.Name = "registerPasswordBox";
            registerPasswordBox.PasswordChar = '*';
            registerPasswordBox.Size = new Size(158, 16);
            registerPasswordBox.TabIndex = 35;
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordlbl.Location = new Point(257, 170);
            passwordlbl.Margin = new Padding(4, 0, 4, 0);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(69, 17);
            passwordlbl.TabIndex = 36;
            passwordlbl.Text = "Password";
            // 
            // passwordAgainlbl
            // 
            passwordAgainlbl.AutoSize = true;
            passwordAgainlbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordAgainlbl.Location = new Point(462, 170);
            passwordAgainlbl.Margin = new Padding(4, 0, 4, 0);
            passwordAgainlbl.Name = "passwordAgainlbl";
            passwordAgainlbl.Size = new Size(109, 17);
            passwordAgainlbl.TabIndex = 38;
            passwordAgainlbl.Text = "Password Again";
            // 
            // registerPasswordAgainBox
            // 
            registerPasswordAgainBox.BorderStyle = BorderStyle.None;
            registerPasswordAgainBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerPasswordAgainBox.Location = new Point(4, 3);
            registerPasswordAgainBox.Margin = new Padding(4, 3, 4, 3);
            registerPasswordAgainBox.Name = "registerPasswordAgainBox";
            registerPasswordAgainBox.PasswordChar = '*';
            registerPasswordAgainBox.Size = new Size(158, 16);
            registerPasswordAgainBox.TabIndex = 37;
            // 
            // titlelbl
            // 
            titlelbl.AutoSize = true;
            titlelbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titlelbl.Location = new Point(257, 337);
            titlelbl.Margin = new Padding(4, 0, 4, 0);
            titlelbl.Name = "titlelbl";
            titlelbl.Size = new Size(35, 17);
            titlelbl.TabIndex = 39;
            titlelbl.Text = "Title";
            // 
            // titleBox
            // 
            titleBox.BorderStyle = BorderStyle.None;
            titleBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleBox.Location = new Point(4, 3);
            titleBox.Margin = new Padding(4, 3, 4, 3);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(192, 16);
            titleBox.TabIndex = 42;
            // 
            // registerClearBtn
            // 
            registerClearBtn.AccessibleRole = AccessibleRole.None;
            registerClearBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerClearBtn.Location = new Point(416, 445);
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
            editAccountbtn.Location = new Point(353, 403);
            editAccountbtn.Margin = new Padding(4, 3, 4, 3);
            editAccountbtn.Name = "editAccountbtn";
            editAccountbtn.Size = new Size(217, 36);
            editAccountbtn.TabIndex = 46;
            editAccountbtn.Text = "Edit Account";
            editAccountbtn.UseVisualStyleBackColor = true;
            editAccountbtn.Click += editAccountbtn_Click;
            // 
            // passwordNotelbl
            // 
            passwordNotelbl.AutoSize = true;
            passwordNotelbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordNotelbl.ForeColor = Color.SteelBlue;
            passwordNotelbl.Location = new Point(256, 216);
            passwordNotelbl.Margin = new Padding(4, 0, 4, 0);
            passwordNotelbl.Name = "passwordNotelbl";
            passwordNotelbl.Size = new Size(357, 34);
            passwordNotelbl.TabIndex = 47;
            passwordNotelbl.Text = "Note: Password must be at least 8 characters long with \r\nuppercase, lowercase, digit, and special character.";
            // 
            // usernamepnl
            // 
            usernamepnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            usernamepnl.BackColor = SystemColors.Window;
            usernamepnl.Controls.Add(registerUsernameBox);
            usernamepnl.Controls.Add(usernameAlertBox);
            usernamepnl.Location = new Point(257, 116);
            usernamepnl.Margin = new Padding(3, 2, 3, 2);
            usernamepnl.Name = "usernamepnl";
            usernamepnl.Size = new Size(191, 21);
            usernamepnl.TabIndex = 77;
            usernamepnl.Paint += usernamepnl_Paint;
            // 
            // usernameAlertBox
            // 
            usernameAlertBox.Image = Properties.Resources.red_alert;
            usernameAlertBox.InitialImage = null;
            usernameAlertBox.Location = new Point(166, 2);
            usernameAlertBox.Margin = new Padding(3, 2, 3, 2);
            usernameAlertBox.Name = "usernameAlertBox";
            usernameAlertBox.Size = new Size(21, 18);
            usernameAlertBox.SizeMode = PictureBoxSizeMode.StretchImage;
            usernameAlertBox.TabIndex = 76;
            usernameAlertBox.TabStop = false;
            usernameAlertBox.Visible = false;
            // 
            // displaynamepnl
            // 
            displaynamepnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            displaynamepnl.BackColor = SystemColors.Window;
            displaynamepnl.Controls.Add(displaynameAlertBox);
            displaynamepnl.Controls.Add(registerDisplaynameBox);
            displaynamepnl.Location = new Point(464, 116);
            displaynamepnl.Margin = new Padding(3, 2, 3, 2);
            displaynamepnl.Name = "displaynamepnl";
            displaynamepnl.Size = new Size(191, 21);
            displaynamepnl.TabIndex = 78;
            displaynamepnl.Paint += displaynamepnl_Paint;
            // 
            // displaynameAlertBox
            // 
            displaynameAlertBox.Image = Properties.Resources.red_alert;
            displaynameAlertBox.Location = new Point(166, 2);
            displaynameAlertBox.Margin = new Padding(3, 2, 3, 2);
            displaynameAlertBox.Name = "displaynameAlertBox";
            displaynameAlertBox.Size = new Size(21, 18);
            displaynameAlertBox.SizeMode = PictureBoxSizeMode.StretchImage;
            displaynameAlertBox.TabIndex = 76;
            displaynameAlertBox.TabStop = false;
            displaynameAlertBox.Visible = false;
            // 
            // usernameAlertlbl
            // 
            usernameAlertlbl.AutoSize = true;
            usernameAlertlbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameAlertlbl.ForeColor = Color.Red;
            usernameAlertlbl.Location = new Point(257, 139);
            usernameAlertlbl.Margin = new Padding(4, 0, 4, 0);
            usernameAlertlbl.Name = "usernameAlertlbl";
            usernameAlertlbl.Size = new Size(171, 17);
            usernameAlertlbl.TabIndex = 79;
            usernameAlertlbl.Text = "Please enter a username.";
            usernameAlertlbl.Visible = false;
            // 
            // displaynameAlertlbl
            // 
            displaynameAlertlbl.AutoSize = true;
            displaynameAlertlbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displaynameAlertlbl.ForeColor = Color.Red;
            displaynameAlertlbl.Location = new Point(462, 139);
            displaynameAlertlbl.Margin = new Padding(4, 0, 4, 0);
            displaynameAlertlbl.Name = "displaynameAlertlbl";
            displaynameAlertlbl.Size = new Size(191, 17);
            displaynameAlertlbl.TabIndex = 80;
            displaynameAlertlbl.Text = "Please enter a display name.";
            displaynameAlertlbl.Visible = false;
            // 
            // emailAlertlbl
            // 
            emailAlertlbl.AutoSize = true;
            emailAlertlbl.Font = new Font("Microsoft Sans Serif", 10.2F);
            emailAlertlbl.ForeColor = Color.SteelBlue;
            emailAlertlbl.Location = new Point(257, 309);
            emailAlertlbl.Name = "emailAlertlbl";
            emailAlertlbl.Size = new Size(156, 17);
            emailAlertlbl.TabIndex = 81;
            emailAlertlbl.Text = "example@example.com";
            // 
            // phoneAlertlbl
            // 
            phoneAlertlbl.AutoSize = true;
            phoneAlertlbl.Font = new Font("Microsoft Sans Serif", 10.2F);
            phoneAlertlbl.ForeColor = Color.SteelBlue;
            phoneAlertlbl.Location = new Point(491, 309);
            phoneAlertlbl.Name = "phoneAlertlbl";
            phoneAlertlbl.Size = new Size(111, 17);
            phoneAlertlbl.TabIndex = 82;
            phoneAlertlbl.Text = "6 to 13 numbers";
            // 
            // passwordpnl
            // 
            passwordpnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            passwordpnl.BackColor = SystemColors.Window;
            passwordpnl.Controls.Add(passwordAlertBox);
            passwordpnl.Controls.Add(registerPasswordBox);
            passwordpnl.Location = new Point(257, 193);
            passwordpnl.Margin = new Padding(3, 2, 3, 2);
            passwordpnl.Name = "passwordpnl";
            passwordpnl.Size = new Size(191, 21);
            passwordpnl.TabIndex = 78;
            passwordpnl.Paint += passwordpnl_Paint;
            // 
            // passwordAlertBox
            // 
            passwordAlertBox.Image = Properties.Resources.red_alert;
            passwordAlertBox.InitialImage = null;
            passwordAlertBox.Location = new Point(166, 2);
            passwordAlertBox.Margin = new Padding(3, 2, 3, 2);
            passwordAlertBox.Name = "passwordAlertBox";
            passwordAlertBox.Size = new Size(21, 18);
            passwordAlertBox.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordAlertBox.TabIndex = 76;
            passwordAlertBox.TabStop = false;
            passwordAlertBox.Visible = false;
            // 
            // passwordAgainpnl
            // 
            passwordAgainpnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            passwordAgainpnl.BackColor = SystemColors.Window;
            passwordAgainpnl.Controls.Add(passwordAgainAlertBox);
            passwordAgainpnl.Controls.Add(registerPasswordAgainBox);
            passwordAgainpnl.Location = new Point(464, 193);
            passwordAgainpnl.Margin = new Padding(3, 2, 3, 2);
            passwordAgainpnl.Name = "passwordAgainpnl";
            passwordAgainpnl.Size = new Size(191, 21);
            passwordAgainpnl.TabIndex = 79;
            passwordAgainpnl.Paint += passwordAgainpnl_Paint;
            // 
            // passwordAgainAlertBox
            // 
            passwordAgainAlertBox.Image = Properties.Resources.red_alert;
            passwordAgainAlertBox.Location = new Point(166, 2);
            passwordAgainAlertBox.Margin = new Padding(3, 2, 3, 2);
            passwordAgainAlertBox.Name = "passwordAgainAlertBox";
            passwordAgainAlertBox.Size = new Size(21, 18);
            passwordAgainAlertBox.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordAgainAlertBox.TabIndex = 76;
            passwordAgainAlertBox.TabStop = false;
            passwordAgainAlertBox.Visible = false;
            // 
            // mailpnl
            // 
            mailpnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mailpnl.BackColor = SystemColors.Window;
            mailpnl.Controls.Add(mailAlertBox);
            mailpnl.Controls.Add(mailBox);
            mailpnl.Location = new Point(256, 286);
            mailpnl.Margin = new Padding(3, 2, 3, 2);
            mailpnl.Name = "mailpnl";
            mailpnl.Size = new Size(227, 21);
            mailpnl.TabIndex = 79;
            mailpnl.Paint += mailpnl_Paint;
            // 
            // mailAlertBox
            // 
            mailAlertBox.Image = Properties.Resources.red_alert;
            mailAlertBox.Location = new Point(203, 2);
            mailAlertBox.Margin = new Padding(3, 2, 3, 2);
            mailAlertBox.Name = "mailAlertBox";
            mailAlertBox.Size = new Size(21, 18);
            mailAlertBox.SizeMode = PictureBoxSizeMode.StretchImage;
            mailAlertBox.TabIndex = 76;
            mailAlertBox.TabStop = false;
            mailAlertBox.Visible = false;
            // 
            // phonepnl
            // 
            phonepnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            phonepnl.BackColor = SystemColors.Window;
            phonepnl.Controls.Add(phoneAlertBox);
            phonepnl.Controls.Add(phoneNumBox);
            phonepnl.Location = new Point(491, 286);
            phonepnl.Margin = new Padding(3, 2, 3, 2);
            phonepnl.Name = "phonepnl";
            phonepnl.Size = new Size(191, 21);
            phonepnl.TabIndex = 79;
            phonepnl.Paint += phonepnl_Paint;
            // 
            // phoneAlertBox
            // 
            phoneAlertBox.Image = Properties.Resources.red_alert;
            phoneAlertBox.Location = new Point(166, 2);
            phoneAlertBox.Margin = new Padding(3, 2, 3, 2);
            phoneAlertBox.Name = "phoneAlertBox";
            phoneAlertBox.Size = new Size(21, 18);
            phoneAlertBox.SizeMode = PictureBoxSizeMode.StretchImage;
            phoneAlertBox.TabIndex = 76;
            phoneAlertBox.TabStop = false;
            phoneAlertBox.Visible = false;
            // 
            // titilepnl
            // 
            titilepnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            titilepnl.BackColor = SystemColors.Window;
            titilepnl.Controls.Add(titleAlertBox);
            titilepnl.Controls.Add(titleBox);
            titilepnl.Location = new Point(256, 357);
            titilepnl.Margin = new Padding(3, 2, 3, 2);
            titilepnl.Name = "titilepnl";
            titilepnl.Size = new Size(227, 21);
            titilepnl.TabIndex = 80;
            titilepnl.Paint += titilepnl_Paint;
            // 
            // titleAlertBox
            // 
            titleAlertBox.Image = Properties.Resources.red_alert;
            titleAlertBox.Location = new Point(201, 2);
            titleAlertBox.Margin = new Padding(3, 2, 3, 2);
            titleAlertBox.Name = "titleAlertBox";
            titleAlertBox.Size = new Size(23, 17);
            titleAlertBox.SizeMode = PictureBoxSizeMode.StretchImage;
            titleAlertBox.TabIndex = 76;
            titleAlertBox.TabStop = false;
            titleAlertBox.Visible = false;
            // 
            // titleAlertlbl
            // 
            titleAlertlbl.AutoSize = true;
            titleAlertlbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleAlertlbl.ForeColor = Color.Red;
            titleAlertlbl.Location = new Point(257, 380);
            titleAlertlbl.Margin = new Padding(4, 0, 4, 0);
            titleAlertlbl.Name = "titleAlertlbl";
            titleAlertlbl.Size = new Size(130, 17);
            titleAlertlbl.TabIndex = 83;
            titleAlertlbl.Text = "Please enter a title.";
            titleAlertlbl.Visible = false;
            // 
            // departAlertlbl
            // 
            departAlertlbl.AutoSize = true;
            departAlertlbl.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departAlertlbl.ForeColor = Color.Red;
            departAlertlbl.Location = new Point(491, 384);
            departAlertlbl.Margin = new Padding(4, 0, 4, 0);
            departAlertlbl.Name = "departAlertlbl";
            departAlertlbl.Size = new Size(184, 17);
            departAlertlbl.TabIndex = 84;
            departAlertlbl.Text = "Please select a department.";
            departAlertlbl.Visible = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(706, 480);
            Controls.Add(departAlertlbl);
            Controls.Add(titleAlertlbl);
            Controls.Add(titilepnl);
            Controls.Add(phonepnl);
            Controls.Add(mailpnl);
            Controls.Add(passwordAgainpnl);
            Controls.Add(passwordpnl);
            Controls.Add(phoneAlertlbl);
            Controls.Add(emailAlertlbl);
            Controls.Add(displaynameAlertlbl);
            Controls.Add(usernameAlertlbl);
            Controls.Add(displaynamepnl);
            Controls.Add(usernamepnl);
            Controls.Add(passwordNotelbl);
            Controls.Add(viewaccountlbl);
            Controls.Add(accountEditlbl);
            Controls.Add(registerClearBtn);
            Controls.Add(titlelbl);
            Controls.Add(passwordAgainlbl);
            Controls.Add(passwordlbl);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(departBox);
            Controls.Add(departlbl);
            Controls.Add(phoneNumlbl);
            Controls.Add(maillbl);
            Controls.Add(newAccountlabel);
            Controls.Add(displaynamelbl);
            Controls.Add(createAccountBtn);
            Controls.Add(usernamelbl);
            Controls.Add(editAccountbtn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
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
            usernamepnl.ResumeLayout(false);
            usernamepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usernameAlertBox).EndInit();
            displaynamepnl.ResumeLayout(false);
            displaynamepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)displaynameAlertBox).EndInit();
            passwordpnl.ResumeLayout(false);
            passwordpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordAlertBox).EndInit();
            passwordAgainpnl.ResumeLayout(false);
            passwordAgainpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordAgainAlertBox).EndInit();
            mailpnl.ResumeLayout(false);
            mailpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mailAlertBox).EndInit();
            phonepnl.ResumeLayout(false);
            phonepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)phoneAlertBox).EndInit();
            titilepnl.ResumeLayout(false);
            titilepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)titleAlertBox).EndInit();
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
        private Label passwordNotelbl;
        private Panel usernamepnl;
        private PictureBox usernameAlertBox;
        private Panel displaynamepnl;
        private PictureBox displaynameAlertBox;
        private Label usernameAlertlbl;
        private Label displaynameAlertlbl;
        private Label emailAlertlbl;
        private Label phoneAlertlbl;
        private Panel passwordpnl;
        private PictureBox passwordAlertBox;
        private Panel passwordAgainpnl;
        private PictureBox passwordAgainAlertBox;
        private Panel mailpnl;
        private PictureBox mailAlertBox;
        private Panel phonepnl;
        private PictureBox phoneAlertBox;
        private Panel titilepnl;
        private PictureBox titleAlertBox;
        private Label titleAlertlbl;
        private Label departAlertlbl;
        private BorderComboBox departBox;
    }
}