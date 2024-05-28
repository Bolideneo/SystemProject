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
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            CloseButton = new Button();
            button2 = new Button();
            accountPanel = new Panel();
            usernameBox = new TextBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            passwordBox = new TextBox();
            pictureBox4 = new PictureBox();
            loginbtn = new Button();
            pictureBox1 = new PictureBox();
            errolabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuText;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 497);
            panel1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(35, 279);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 27);
            label5.TabIndex = 3;
            label5.Text = "System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(35, 241);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(157, 27);
            label4.TabIndex = 2;
            label4.Text = "LM Company ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(35, 201);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(175, 27);
            label3.TabIndex = 1;
            label3.Text = "Welcome to the ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(2, 73);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(226, 83);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
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
            // button2
            // 
            button2.BackColor = SystemColors.Menu;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(457, 350);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(170, 33);
            button2.TabIndex = 16;
            button2.Text = "Forget Password";
            button2.UseVisualStyleBackColor = false;
            // 
            // accountPanel
            // 
            accountPanel.BackColor = SystemColors.HighlightText;
            accountPanel.Controls.Add(usernameBox);
            accountPanel.Controls.Add(pictureBox3);
            accountPanel.Location = new Point(233, 194);
            accountPanel.Margin = new Padding(2);
            accountPanel.Name = "accountPanel";
            accountPanel.Size = new Size(422, 43);
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
            usernameBox.Size = new Size(324, 20);
            usernameBox.TabIndex = 20;
            usernameBox.TextChanged += accountBox_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(5, 2);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 37);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HighlightText;
            panel3.Controls.Add(passwordBox);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(233, 243);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(422, 43);
            panel3.TabIndex = 18;
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(48, 9);
            passwordBox.Margin = new Padding(2);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(324, 20);
            passwordBox.TabIndex = 21;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(5, 2);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 37);
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.Location = new Point(281, 346);
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
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(398, 68);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 88);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // errolabel
            // 
            errolabel.AutoSize = true;
            errolabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errolabel.ForeColor = Color.Red;
            errolabel.Location = new Point(306, 303);
            errolabel.Name = "errolabel";
            errolabel.Size = new Size(265, 21);
            errolabel.TabIndex = 20;
            errolabel.Text = "Username or password is not correct";
            errolabel.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(656, 497);
            Controls.Add(errolabel);
            Controls.Add(loginbtn);
            Controls.Add(panel3);
            Controls.Add(accountPanel);
            Controls.Add(button2);
            Controls.Add(CloseButton);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            accountPanel.ResumeLayout(false);
            accountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button loginbtn;
        private Label errolabel;
    }
}

