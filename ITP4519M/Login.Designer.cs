
using System.Drawing.Drawing2D;


namespace ITP4519M
{
    partial class Login
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            CloseButton = new Button();
            accountPanel = new Panel();
            usernameBox = new TextBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            passwordBox = new TextBox();
            pictureBox4 = new PictureBox();
            loginbtn = new Button();
            pictureBox1 = new PictureBox();
            errolabel = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 13.8F);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(33, 340);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 3;
            label5.Text = "System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 13.8F);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(33, 289);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 28);
            label4.TabIndex = 2;
            label4.Text = "LM Company ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 13.8F);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(33, 236);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(182, 28);
            label3.TabIndex = 1;
            label3.Text = "Welcome to the ";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.company_logo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(2, 97);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(229, 81);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(69, 34);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(40, 332);
            textBox1.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(620, 1);
            CloseButton.Margin = new Padding(2);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 37);
            CloseButton.TabIndex = 14;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // accountPanel
            // 
            accountPanel.BackColor = SystemColors.HighlightText;
            accountPanel.Controls.Add(usernameBox);
            accountPanel.Controls.Add(pictureBox3);
            accountPanel.Location = new Point(207, 165);
            accountPanel.Margin = new Padding(2);
            accountPanel.Name = "accountPanel";
            accountPanel.Size = new Size(447, 38);
            accountPanel.TabIndex = 17;
            accountPanel.Paint += accountPanel_Paint;
            // 
            // usernameBox
            // 
            usernameBox.BorderStyle = BorderStyle.None;
            usernameBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameBox.Location = new Point(48, 9);
            usernameBox.Margin = new Padding(2);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(344, 20);
            usernameBox.TabIndex = 20;
            usernameBox.TextChanged += accountBox_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.user_logo;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(5, 2);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 34);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HighlightText;
            panel3.Controls.Add(passwordBox);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(207, 214);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(447, 38);
            panel3.TabIndex = 18;
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(48, 9);
            passwordBox.Margin = new Padding(2);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(344, 20);
            passwordBox.TabIndex = 21;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.password_logo;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(5, 2);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 34);
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.Location = new Point(254, 317);
            loginbtn.Margin = new Padding(2);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(149, 40);
            loginbtn.TabIndex = 19;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.login_logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(377, 53);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 82);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // errolabel
            // 
            errolabel.AutoSize = true;
            errolabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errolabel.ForeColor = Color.Red;
            errolabel.Location = new Point(281, 269);
            errolabel.Name = "errolabel";
            errolabel.Size = new Size(265, 21);
            errolabel.TabIndex = 20;
            errolabel.Text = "Username or password is not correct";
            errolabel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(464, 332);
            label1.Name = "label1";
            label1.Size = new Size(110, 18);
            label1.TabIndex = 21;
            label1.Text = "Forget Password";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuText;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox5);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 412);
            panel1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(19, 251);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 3;
            label2.Text = "System";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(19, 213);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 2;
            label6.Text = "LM Company ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(19, 173);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(155, 25);
            label7.TabIndex = 1;
            label7.Text = "Welcome to the ";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.company_logo;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(2, 73);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(200, 61);
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(656, 412);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(errolabel);
            Controls.Add(loginbtn);
            Controls.Add(panel3);
            Controls.Add(accountPanel);
            Controls.Add(CloseButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "s";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            accountPanel.ResumeLayout(false);
            accountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button loginbtn;
        private Label errolabel;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private Label label2;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox5;
    }
}

