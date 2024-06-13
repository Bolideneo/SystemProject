namespace ITP4519M
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
            label1 = new Label();
            productWarehousebox = new TextBox();
            productDemandlbl = new Label();
            productdemandbox = new TextBox();
            productClosebtn = new Button();
            label2 = new Label();
            productUnitpricebox = new TextBox();
            stockEditProuctbtn = new Button();
            productOutofStockbox = new TextBox();
            SuspendLayout();
            // 
            // prudctCategorylbl
            // 
            prudctCategorylbl.AutoSize = true;
            prudctCategorylbl.Font = new Font("Microsoft Sans Serif", 12F);
            prudctCategorylbl.Location = new Point(15, 146);
            prudctCategorylbl.Margin = new Padding(4, 0, 4, 0);
            prudctCategorylbl.Name = "prudctCategorylbl";
            prudctCategorylbl.Size = new Size(175, 25);
            prudctCategorylbl.TabIndex = 0;
            prudctCategorylbl.Text = "Product Category :";
            prudctCategorylbl.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(15, 90);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 3;
            label3.Text = "Product Name :";
            // 
            // productNamebox
            // 

            productNamebox.Location = new Point(154, 91);
            productNamebox.Margin = new Padding(4, 3, 4, 3);
            productNamebox.Name = "productNamebox";
            productNamebox.Size = new Size(117, 23);
            productNamebox.TabIndex = 4;
            // 
            // productCostlbl
            // 
            productCostlbl.AutoSize = true;
            productCostlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productCostlbl.Location = new Point(15, 369);
            productCostlbl.Margin = new Padding(4, 0, 4, 0);
            productCostlbl.Name = "productCostlbl";
            productCostlbl.Size = new Size(113, 25);
            productCostlbl.TabIndex = 5;
            productCostlbl.Text = "Cost Price :";
            // 
            // stockAddProuctbtn
            // 
            stockAddProuctbtn.BackColor = Color.FromArgb(0, 192, 0);
            stockAddProuctbtn.Font = new Font("Microsoft Sans Serif", 12F);
            stockAddProuctbtn.ForeColor = Color.White;
            stockAddProuctbtn.Location = new Point(64, 494);
            stockAddProuctbtn.Margin = new Padding(4, 3, 4, 3);
            stockAddProuctbtn.Name = "stockAddProuctbtn";
            stockAddProuctbtn.Size = new Size(171, 39);
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
            productStatusbox.Location = new Point(439, 426);
            productStatusbox.Margin = new Padding(4, 3, 4, 3);
            productStatusbox.Name = "productStatusbox";
            productStatusbox.Size = new Size(118, 24);
            productStatusbox.TabIndex = 18;
            // 
            // productDescriptionlbl
            // 
            productDescriptionlbl.AutoSize = true;
            productDescriptionlbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productDescriptionlbl.Location = new Point(289, 369);
            productDescriptionlbl.Margin = new Padding(4, 0, 4, 0);
            productDescriptionlbl.Name = "productDescriptionlbl";
            productDescriptionlbl.Size = new Size(120, 25);
            productDescriptionlbl.TabIndex = 11;
            productDescriptionlbl.Text = "Description :";
            productDescriptionlbl.Click += label4_Click;
            // 
            // productSeriallbl
            // 
            productSeriallbl.AutoSize = true;
            productSeriallbl.Font = new Font("Microsoft Sans Serif", 12F);
            productSeriallbl.Location = new Point(13, 256);
            productSeriallbl.Margin = new Padding(4, 0, 4, 0);
            productSeriallbl.Name = "productSeriallbl";
            productSeriallbl.Size = new Size(147, 25);
            productSeriallbl.TabIndex = 12;
            productSeriallbl.Text = "Serial Number :";
            // 
            // productserialbox
            // 
            productserialbox.Location = new Point(154, 256);
            productserialbox.Margin = new Padding(4, 3, 4, 3);
            productserialbox.Name = "productserialbox";
            productserialbox.Size = new Size(117, 23);
            productserialbox.TabIndex = 8;
            // 
            // productCostbox
            // 
            productCostbox.Location = new Point(154, 370);
            productCostbox.Margin = new Padding(4, 3, 4, 3);
            productCostbox.Name = "productCostbox";
            productCostbox.Size = new Size(117, 23);
            productCostbox.TabIndex = 10;
            // 
            // productWeightlbl
            // 
            productWeightlbl.AutoSize = true;
            productWeightlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productWeightlbl.Location = new Point(15, 424);
            productWeightlbl.Margin = new Padding(4, 0, 4, 0);
            productWeightlbl.Name = "productWeightlbl";
            productWeightlbl.Size = new Size(85, 25);
            productWeightlbl.TabIndex = 15;
            productWeightlbl.Text = "Weight :";
            // 
            // productStatuslbl
            // 
            productStatuslbl.AutoSize = true;
            productStatuslbl.Font = new Font("Microsoft Sans Serif", 12F);
            productStatuslbl.Location = new Point(289, 425);
            productStatuslbl.Margin = new Padding(4, 0, 4, 0);
            productStatuslbl.Name = "productStatuslbl";
            productStatuslbl.Size = new Size(79, 25);
            productStatuslbl.TabIndex = 16;
            productStatuslbl.Text = "Status :";
            // 
            // productWeightbox
            // 

            productWeightbox.Location = new Point(154, 425);
            productWeightbox.Margin = new Padding(4, 3, 4, 3);
            productWeightbox.Name = "productWeightbox";
            productWeightbox.Size = new Size(117, 23);
            productWeightbox.TabIndex = 11;
            // 
            // productInStocklbl
            // 
            productInStocklbl.AutoSize = true;
            productInStocklbl.Font = new Font("Microsoft Sans Serif", 12F);
            productInStocklbl.Location = new Point(289, 146);
            productInStocklbl.Margin = new Padding(4, 0, 4, 0);
            productInStocklbl.Name = "productInStocklbl";
            productInStocklbl.Size = new Size(172, 25);
            productInStocklbl.TabIndex = 18;
            productInStocklbl.Text = "Quantity In Stock :";
            // 
            // productInStockbox
            // 
            productInStockbox.Location = new Point(439, 147);
            productInStockbox.Margin = new Padding(4, 3, 4, 3);
            productInStockbox.Name = "productInStockbox";
            productInStockbox.Size = new Size(118, 23);
            productInStockbox.TabIndex = 13;
            // 
            // productReOrderbox
            // 
            productReOrderbox.Enabled = false;
            productReOrderbox.Location = new Point(439, 202);
            productReOrderbox.Margin = new Padding(4, 3, 4, 3);
            productReOrderbox.Name = "productReOrderbox";
            productReOrderbox.ReadOnly = true;
            productReOrderbox.Size = new Size(118, 23);
            productReOrderbox.TabIndex = 14;
            // 
            // productReOrderlbl
            // 
            productReOrderlbl.AutoSize = true;
            productReOrderlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productReOrderlbl.Location = new Point(289, 201);
            productReOrderlbl.Margin = new Padding(4, 0, 4, 0);
            productReOrderlbl.Name = "productReOrderlbl";
            productReOrderlbl.Size = new Size(182, 25);
            productReOrderlbl.TabIndex = 23;
            productReOrderlbl.Text = "Re-Order Quantity :";
            // 
            // productDangerlbl
            // 
            productDangerlbl.AutoSize = true;
            productDangerlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productDangerlbl.Location = new Point(289, 256);
            productDangerlbl.Margin = new Padding(4, 0, 4, 0);
            productDangerlbl.Name = "productDangerlbl";
            productDangerlbl.Size = new Size(165, 25);
            productDangerlbl.TabIndex = 24;
            productDangerlbl.Text = "Danger Quantity :";
            // 
            // productDescriptionbox
            // 

            productDescriptionbox.Location = new Point(439, 370);
            productDescriptionbox.Margin = new Padding(4, 3, 4, 3);
            productDescriptionbox.Name = "productDescriptionbox";
            productDescriptionbox.Size = new Size(118, 23);
            productDescriptionbox.TabIndex = 17;
            // 
            // productDangerbox
            // 
            productDangerbox.Enabled = false;
            productDangerbox.Location = new Point(439, 257);
            productDangerbox.Margin = new Padding(4, 3, 4, 3);
            productDangerbox.Name = "productDangerbox";
            productDangerbox.ReadOnly = true;
            productDangerbox.Size = new Size(118, 23);
            productDangerbox.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Desktop;
            label12.Location = new Point(15, 24);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(178, 29);
            label12.TabIndex = 27;
            label12.Text = "Product Detail";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(942, 11);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(40, 49);
            button3.TabIndex = 34;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            // 
            // productCategorybox
            // 
            productCategorybox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            productCategorybox.FormattingEnabled = true;
            productCategorybox.Items.AddRange(new object[] { "A - Sheet Metal", "B - Major Assemblies", "C - Light Components", "D - Accessories" });
            productCategorybox.Location = new Point(154, 147);
            productCategorybox.Margin = new Padding(4, 3, 4, 3);
            productCategorybox.Name = "productCategorybox";
            productCategorybox.Size = new Size(117, 24);
            productCategorybox.TabIndex = 5;
            // 
            // productAutoOrderlbl
            // 
            productAutoOrderlbl.AutoSize = true;
            productAutoOrderlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productAutoOrderlbl.Location = new Point(289, 90);
            productAutoOrderlbl.Margin = new Padding(4, 0, 4, 0);
            productAutoOrderlbl.Name = "productAutoOrderlbl";
            productAutoOrderlbl.Size = new Size(214, 25);
            productAutoOrderlbl.TabIndex = 38;
            productAutoOrderlbl.Text = "Out Of Stock Quantity :";
            productAutoOrderlbl.Click += label9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(15, 200);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 40;
            label1.Text = "WareHouse :";
            // 
            // productWarehousebox
            // 
            productWarehousebox.Location = new Point(154, 201);
            productWarehousebox.Margin = new Padding(4, 3, 4, 3);
            productWarehousebox.Name = "productWarehousebox";
            productWarehousebox.Size = new Size(117, 23);
            productWarehousebox.TabIndex = 7;
            // 
            // productDemandlbl
            // 
            productDemandlbl.AutoSize = true;
            productDemandlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productDemandlbl.Location = new Point(289, 311);
            productDemandlbl.Margin = new Padding(4, 0, 4, 0);
            productDemandlbl.Name = "productDemandlbl";
            productDemandlbl.Size = new Size(97, 25);
            productDemandlbl.TabIndex = 42;
            productDemandlbl.Text = "Demand :";
            productDemandlbl.Click += productDemandlbl_Click;
            // 
            // productdemandbox
            // 
            productdemandbox.Location = new Point(439, 312);
            productdemandbox.Margin = new Padding(4, 3, 4, 3);
            productdemandbox.Name = "productdemandbox";
            productdemandbox.Size = new Size(118, 23);
            productdemandbox.TabIndex = 16;
            // 
            // productClosebtn
            // 
            productClosebtn.FlatAppearance.BorderSize = 0;
            productClosebtn.FlatStyle = FlatStyle.Flat;
            productClosebtn.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productClosebtn.Location = new Point(517, 15);
            productClosebtn.Margin = new Padding(2);
            productClosebtn.Name = "productClosebtn";
            productClosebtn.Size = new Size(40, 49);
            productClosebtn.TabIndex = 44;
            productClosebtn.Text = "X";
            productClosebtn.UseVisualStyleBackColor = true;
            productClosebtn.Click += productClosebtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(15, 311);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 45;
            label2.Text = "Unit Price :";
            // 
            // productUnitpricebox
            // 
            productUnitpricebox.Location = new Point(154, 312);
            productUnitpricebox.Margin = new Padding(4, 3, 4, 3);
            productUnitpricebox.Name = "productUnitpricebox";
            productUnitpricebox.Size = new Size(117, 23);
            productUnitpricebox.TabIndex = 9;
            // 
            // stockEditProuctbtn
            // 
            stockEditProuctbtn.BackColor = SystemColors.ButtonHighlight;
            stockEditProuctbtn.Font = new Font("Microsoft Sans Serif", 12F);
            stockEditProuctbtn.ForeColor = Color.Black;
            stockEditProuctbtn.Location = new Point(330, 494);
            stockEditProuctbtn.Margin = new Padding(4, 3, 4, 3);
            stockEditProuctbtn.Name = "stockEditProuctbtn";
            stockEditProuctbtn.Size = new Size(171, 39);
            stockEditProuctbtn.TabIndex = 47;
            stockEditProuctbtn.Text = "Edit";
            stockEditProuctbtn.UseVisualStyleBackColor = false;
            stockEditProuctbtn.Click += stockEditProuctbtn_Click;
            // 
            // productOutofStockbox
            // 
            productOutofStockbox.Enabled = false;
            productOutofStockbox.Location = new Point(240, 633);
            productOutofStockbox.Margin = new Padding(5, 4, 5, 4);
            productOutofStockbox.Name = "productOutofStockbox";
            productOutofStockbox.ReadOnly = true;
            productOutofStockbox.Size = new Size(210, 27);
            productOutofStockbox.TabIndex = 48;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(570, 570);
            Controls.Add(productOutofStockbox);
            Controls.Add(productUnitpricebox);
            Controls.Add(label2);
            Controls.Add(productClosebtn);
            Controls.Add(productdemandbox);
            Controls.Add(productDemandlbl);
            Controls.Add(productWarehousebox);
            Controls.Add(label1);
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
            Margin = new Padding(5, 4, 5, 4);
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
        private Label label1;
        private TextBox productWarehousebox;
        private Label productDemandlbl;
        private TextBox productdemandbox;
        private Button productClosebtn;
        private Label label2;
        private TextBox productUnitpricebox;
        private Button stockEditProuctbtn;
        private TextBox productOutofStockbox;
    }
}

