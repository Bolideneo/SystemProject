﻿namespace ITP4519M
{
    partial class ProductForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            prudctCategorylbl = new Label();
            label3 = new Label();
            productNamebox = new TextBox();
            productCostlbl = new Label();
            stockAddProuctbtn = new Button();
            productStatusbox = new ComboBox();
            productDescriptionlbl = new Label();
            productSeriallbl = new Label();
            productserialbox = new TextBox();
            productCostbox = new TextBox();
            productWeightlbl = new Label();
            productStatuslbl = new Label();
            productWeightbox = new TextBox();
            productInStocklbl = new Label();
            productInStockbox = new TextBox();
            productReOrderbox = new TextBox();
            productReOrderlbl = new Label();
            productDangerlbl = new Label();
            productDescriptionbox = new TextBox();
            productDangerbox = new TextBox();
            label12 = new Label();
            button3 = new Button();
            productCategorybox = new ComboBox();
            productAutoOrderlbl = new Label();
            productAutoOrderbox = new TextBox();
            label1 = new Label();
            productWarehousebox = new TextBox();
            productDemandlbl = new Label();
            productdemandbox = new TextBox();
            productClosebtn = new Button();
            label2 = new Label();
            productUnitpricebox = new TextBox();
            stockEditProuctbtn = new Button();
            SuspendLayout();
            // 
            // prudctCategorylbl
            // 
            prudctCategorylbl.AutoSize = true;
            prudctCategorylbl.Font = new Font("Microsoft Sans Serif", 12F);
            prudctCategorylbl.Location = new Point(35, 98);
            prudctCategorylbl.Margin = new Padding(4, 0, 4, 0);
            prudctCategorylbl.Name = "prudctCategorylbl";
            prudctCategorylbl.Size = new Size(140, 20);
            prudctCategorylbl.TabIndex = 0;
            prudctCategorylbl.Text = "Product Category :";
            prudctCategorylbl.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(35, 60);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 3;
            label3.Text = "Product Name :";
            // 
            // productNamebox
            // 
            productNamebox.Location = new Point(210, 60);
            productNamebox.Margin = new Padding(4, 3, 4, 3);
            productNamebox.Name = "productNamebox";
            productNamebox.Size = new Size(184, 23);
            productNamebox.TabIndex = 4;
            // 
            // productCostlbl
            // 
            productCostlbl.AutoSize = true;
            productCostlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productCostlbl.Location = new Point(35, 248);
            productCostlbl.Margin = new Padding(4, 0, 4, 0);
            productCostlbl.Name = "productCostlbl";
            productCostlbl.Size = new Size(89, 20);
            productCostlbl.TabIndex = 5;
            productCostlbl.Text = "Cost Price :";
            // 
            // stockAddProuctbtn
            // 
            stockAddProuctbtn.BackColor = Color.FromArgb(0, 192, 0);
            stockAddProuctbtn.Font = new Font("Microsoft Sans Serif", 12F);
            stockAddProuctbtn.ForeColor = Color.White;
            stockAddProuctbtn.Location = new Point(143, 588);
            stockAddProuctbtn.Margin = new Padding(4, 3, 4, 3);
            stockAddProuctbtn.Name = "stockAddProuctbtn";
            stockAddProuctbtn.Size = new Size(150, 29);
            stockAddProuctbtn.TabIndex = 7;
            stockAddProuctbtn.Text = "Add";
            stockAddProuctbtn.UseVisualStyleBackColor = false;
            stockAddProuctbtn.Click += stockAddProductbtn_Click;
            // 
            // productStatusbox
            // 
            productStatusbox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            productStatusbox.FormattingEnabled = true;
            productStatusbox.Items.AddRange(new object[] { "Available", "Re-Order", "Danger", "Out Of Stock" });
            productStatusbox.Location = new Point(210, 548);
            productStatusbox.Margin = new Padding(4, 3, 4, 3);
            productStatusbox.Name = "productStatusbox";
            productStatusbox.Size = new Size(184, 24);
            productStatusbox.TabIndex = 18;
            // 
            // productDescriptionlbl
            // 
            productDescriptionlbl.AutoSize = true;
            productDescriptionlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productDescriptionlbl.Location = new Point(35, 510);
            productDescriptionlbl.Margin = new Padding(4, 0, 4, 0);
            productDescriptionlbl.Name = "productDescriptionlbl";
            productDescriptionlbl.Size = new Size(97, 20);
            productDescriptionlbl.TabIndex = 11;
            productDescriptionlbl.Text = "Description :";
            productDescriptionlbl.Click += label4_Click;
            // 
            // productSeriallbl
            // 
            productSeriallbl.AutoSize = true;
            productSeriallbl.Font = new Font("Microsoft Sans Serif", 12F);
            productSeriallbl.Location = new Point(35, 172);
            productSeriallbl.Margin = new Padding(4, 0, 4, 0);
            productSeriallbl.Name = "productSeriallbl";
            productSeriallbl.Size = new Size(117, 20);
            productSeriallbl.TabIndex = 12;
            productSeriallbl.Text = "Serial Number :";
            // 
            // productserialbox
            // 
            productserialbox.Location = new Point(210, 172);
            productserialbox.Margin = new Padding(4, 3, 4, 3);
            productserialbox.Name = "productserialbox";
            productserialbox.Size = new Size(184, 23);
            productserialbox.TabIndex = 8;
            // 
            // productCostbox
            // 
            productCostbox.Location = new Point(210, 248);
            productCostbox.Margin = new Padding(4, 3, 4, 3);
            productCostbox.Name = "productCostbox";
            productCostbox.Size = new Size(184, 23);
            productCostbox.TabIndex = 10;
            // 
            // productWeightlbl
            // 
            productWeightlbl.AutoSize = true;
            productWeightlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productWeightlbl.Location = new Point(35, 285);
            productWeightlbl.Margin = new Padding(4, 0, 4, 0);
            productWeightlbl.Name = "productWeightlbl";
            productWeightlbl.Size = new Size(67, 20);
            productWeightlbl.TabIndex = 15;
            productWeightlbl.Text = "Weight :";
            // 
            // productStatuslbl
            // 
            productStatuslbl.AutoSize = true;
            productStatuslbl.Font = new Font("Microsoft Sans Serif", 12F);
            productStatuslbl.Location = new Point(35, 548);
            productStatuslbl.Margin = new Padding(4, 0, 4, 0);
            productStatuslbl.Name = "productStatuslbl";
            productStatuslbl.Size = new Size(64, 20);
            productStatuslbl.TabIndex = 16;
            productStatuslbl.Text = "Status :";
            // 
            // productWeightbox
            // 
            productWeightbox.Location = new Point(210, 285);
            productWeightbox.Margin = new Padding(4, 3, 4, 3);
            productWeightbox.Name = "productWeightbox";
            productWeightbox.Size = new Size(184, 23);
            productWeightbox.TabIndex = 11;
            // 
            // productInStocklbl
            // 
            productInStocklbl.AutoSize = true;
            productInStocklbl.Font = new Font("Microsoft Sans Serif", 12F);
            productInStocklbl.Location = new Point(35, 360);
            productInStocklbl.Margin = new Padding(4, 0, 4, 0);
            productInStocklbl.Name = "productInStocklbl";
            productInStocklbl.Size = new Size(139, 20);
            productInStocklbl.TabIndex = 18;
            productInStocklbl.Text = "Quantity In Stock :";
            // 
            // productInStockbox
            // 
            productInStockbox.Location = new Point(210, 360);
            productInStockbox.Margin = new Padding(4, 3, 4, 3);
            productInStockbox.Name = "productInStockbox";
            productInStockbox.Size = new Size(184, 23);
            productInStockbox.TabIndex = 13;
            // 
            // productReOrderbox
            // 
            productReOrderbox.Enabled = false;
            productReOrderbox.Location = new Point(210, 398);
            productReOrderbox.Margin = new Padding(4, 3, 4, 3);
            productReOrderbox.Name = "productReOrderbox";
            productReOrderbox.ReadOnly = true;
            productReOrderbox.Size = new Size(184, 23);
            productReOrderbox.TabIndex = 14;
            // 
            // productReOrderlbl
            // 
            productReOrderlbl.AutoSize = true;
            productReOrderlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productReOrderlbl.Location = new Point(35, 398);
            productReOrderlbl.Margin = new Padding(4, 0, 4, 0);
            productReOrderlbl.Name = "productReOrderlbl";
            productReOrderlbl.Size = new Size(146, 20);
            productReOrderlbl.TabIndex = 23;
            productReOrderlbl.Text = "Re-Order Quantity :";
            // 
            // productDangerlbl
            // 
            productDangerlbl.AutoSize = true;
            productDangerlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productDangerlbl.Location = new Point(35, 435);
            productDangerlbl.Margin = new Padding(4, 0, 4, 0);
            productDangerlbl.Name = "productDangerlbl";
            productDangerlbl.Size = new Size(133, 20);
            productDangerlbl.TabIndex = 24;
            productDangerlbl.Text = "Danger Quantity :";
            // 
            // productDescriptionbox
            // 
            productDescriptionbox.Location = new Point(210, 510);
            productDescriptionbox.Margin = new Padding(4, 3, 4, 3);
            productDescriptionbox.Name = "productDescriptionbox";
            productDescriptionbox.Size = new Size(184, 23);
            productDescriptionbox.TabIndex = 17;
            // 
            // productDangerbox
            // 
            productDangerbox.Enabled = false;
            productDangerbox.Location = new Point(210, 435);
            productDangerbox.Margin = new Padding(4, 3, 4, 3);
            productDangerbox.Name = "productDangerbox";
            productDangerbox.ReadOnly = true;
            productDangerbox.Size = new Size(184, 23);
            productDangerbox.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Desktop;
            label12.Location = new Point(34, 10);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(140, 24);
            label12.TabIndex = 27;
            label12.Text = "Product Detail";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(942, 11);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(35, 37);
            button3.TabIndex = 34;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            // 
            // productCategorybox
            // 
            productCategorybox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            productCategorybox.FormattingEnabled = true;
            productCategorybox.Items.AddRange(new object[] { "A - Sheet Metal", "B - Major Assemblies", "C - Light Components", "D - Accessories" });
            productCategorybox.Location = new Point(210, 98);
            productCategorybox.Margin = new Padding(4, 3, 4, 3);
            productCategorybox.Name = "productCategorybox";
            productCategorybox.Size = new Size(184, 24);
            productCategorybox.TabIndex = 5;
            // 
            // productAutoOrderlbl
            // 
            productAutoOrderlbl.AutoSize = true;
            productAutoOrderlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productAutoOrderlbl.Location = new Point(35, 322);
            productAutoOrderlbl.Margin = new Padding(4, 0, 4, 0);
            productAutoOrderlbl.Name = "productAutoOrderlbl";
            productAutoOrderlbl.Size = new Size(95, 20);
            productAutoOrderlbl.TabIndex = 38;
            productAutoOrderlbl.Text = "AutoOrder : ";
            productAutoOrderlbl.Click += label9_Click;
            // 
            // productAutoOrderbox
            // 
            productAutoOrderbox.Location = new Point(210, 322);
            productAutoOrderbox.Margin = new Padding(4, 3, 4, 3);
            productAutoOrderbox.Name = "productAutoOrderbox";
            productAutoOrderbox.Size = new Size(184, 23);
            productAutoOrderbox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(35, 135);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 40;
            label1.Text = "WareHouse :";
            // 
            // productWarehousebox
            // 
            productWarehousebox.Location = new Point(210, 135);
            productWarehousebox.Margin = new Padding(4, 3, 4, 3);
            productWarehousebox.Name = "productWarehousebox";
            productWarehousebox.Size = new Size(184, 23);
            productWarehousebox.TabIndex = 7;
            // 
            // productDemandlbl
            // 
            productDemandlbl.AutoSize = true;
            productDemandlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productDemandlbl.Location = new Point(35, 472);
            productDemandlbl.Margin = new Padding(4, 0, 4, 0);
            productDemandlbl.Name = "productDemandlbl";
            productDemandlbl.Size = new Size(78, 20);
            productDemandlbl.TabIndex = 42;
            productDemandlbl.Text = "Demand :";
            productDemandlbl.Click += productDemandlbl_Click;
            // 
            // productdemandbox
            // 
            productdemandbox.Location = new Point(210, 472);
            productdemandbox.Margin = new Padding(4, 3, 4, 3);
            productdemandbox.Name = "productdemandbox";
            productdemandbox.Size = new Size(184, 23);
            productdemandbox.TabIndex = 16;
            // 
            // productClosebtn
            // 
            productClosebtn.FlatAppearance.BorderSize = 0;
            productClosebtn.FlatStyle = FlatStyle.Flat;
            productClosebtn.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productClosebtn.Location = new Point(416, 1);
            productClosebtn.Margin = new Padding(2, 2, 2, 2);
            productClosebtn.Name = "productClosebtn";
            productClosebtn.Size = new Size(35, 37);
            productClosebtn.TabIndex = 44;
            productClosebtn.Text = "X";
            productClosebtn.UseVisualStyleBackColor = true;
            productClosebtn.Click += productClosebtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(35, 210);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 45;
            label2.Text = "Unit Price :";
            // 
            // productUnitpricebox
            // 
            productUnitpricebox.Location = new Point(210, 210);
            productUnitpricebox.Margin = new Padding(4, 3, 4, 3);
            productUnitpricebox.Name = "productUnitpricebox";
            productUnitpricebox.Size = new Size(184, 23);
            productUnitpricebox.TabIndex = 9;
            // 
            // stockEditProuctbtn
            // 
            stockEditProuctbtn.BackColor = SystemColors.ButtonHighlight;
            stockEditProuctbtn.Font = new Font("Microsoft Sans Serif", 12F);
            stockEditProuctbtn.ForeColor = Color.Black;
            stockEditProuctbtn.Location = new Point(143, 588);
            stockEditProuctbtn.Margin = new Padding(4, 3, 4, 3);
            stockEditProuctbtn.Name = "stockEditProuctbtn";
            stockEditProuctbtn.Size = new Size(150, 29);
            stockEditProuctbtn.TabIndex = 47;
            stockEditProuctbtn.Text = "Edit";
            stockEditProuctbtn.UseVisualStyleBackColor = false;
            stockEditProuctbtn.Click += stockEditProuctbtn_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(457, 636);
            Controls.Add(productUnitpricebox);
            Controls.Add(label2);
            Controls.Add(productClosebtn);
            Controls.Add(productdemandbox);
            Controls.Add(productDemandlbl);
            Controls.Add(productWarehousebox);
            Controls.Add(label1);
            Controls.Add(productAutoOrderbox);
            Controls.Add(productAutoOrderlbl);
            Controls.Add(productCategorybox);
            Controls.Add(button3);
            Controls.Add(label12);
            Controls.Add(productDangerbox);
            Controls.Add(productDescriptionbox);
            Controls.Add(productDangerlbl);
            Controls.Add(productReOrderlbl);
            Controls.Add(productReOrderbox);
            Controls.Add(productInStockbox);
            Controls.Add(productInStocklbl);
            Controls.Add(productWeightbox);
            Controls.Add(productStatuslbl);
            Controls.Add(productWeightlbl);
            Controls.Add(productCostbox);
            Controls.Add(productserialbox);
            Controls.Add(productSeriallbl);
            Controls.Add(productDescriptionlbl);
            Controls.Add(productStatusbox);
            Controls.Add(stockAddProuctbtn);
            Controls.Add(productCostlbl);
            Controls.Add(productNamebox);
            Controls.Add(label3);
            Controls.Add(prudctCategorylbl);
            Controls.Add(stockEditProuctbtn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += productForm_Load;
            MouseDown += ProductForm_MouseDown;
            MouseMove += ProductForm_MouseMove;
            MouseUp += ProductForm_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label prudctCategorylbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productNamebox;
        private System.Windows.Forms.Label productCostlbl;
        private System.Windows.Forms.Button stockAddProuctbtn;
        private System.Windows.Forms.ComboBox productStatusbox;
        private System.Windows.Forms.Label productDescriptionlbl;
        private System.Windows.Forms.Label productSeriallbl;
        private System.Windows.Forms.TextBox productserialbox;
        private System.Windows.Forms.TextBox productCostbox;
        private System.Windows.Forms.Label productWeightlbl;
        private System.Windows.Forms.Label productStatuslbl;
        private System.Windows.Forms.TextBox productWeightbox;
        private System.Windows.Forms.Label productInStocklbl;
        private System.Windows.Forms.TextBox productInStockbox;
        private System.Windows.Forms.TextBox productReOrderbox;
        private System.Windows.Forms.Label productReOrderlbl;
        private System.Windows.Forms.Label productDangerlbl;
        private System.Windows.Forms.TextBox productDescriptionbox;
        private System.Windows.Forms.TextBox productDangerbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button X;
        private Button button3;
        private ComboBox productCategorybox;
        private Label productAutoOrderlbl;
        private TextBox productAutoOrderbox;
        private Label label1;
        private TextBox productWarehousebox;
        private Label productDemandlbl;
        private TextBox productdemandbox;
        private Button productClosebtn;
        private Label label2;
        private TextBox productUnitpricebox;
        private Button stockEditProuctbtn;
    }
}

