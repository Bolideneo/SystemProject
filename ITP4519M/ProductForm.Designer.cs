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
            productOutofStockbox = new TextBox();
            stockEditProuctbtn = new Button();
            productNameAlert = new Label();
            outStockAlert = new Label();
            inStockAlert = new Label();
            warehouseAlert = new Label();
            reorderAlert = new Label();
            serialNumAlert = new Label();
            dangerQuanAlert = new Label();
            unitPriceAlert = new Label();
            demandAlert = new Label();
            costPriceAlert = new Label();
            descriptionAlert = new Label();
            weightAlert = new Label();
            serialNumNote = new Label();
            priceNote2 = new Label();
            priceNote = new Label();
            PativeNote = new Label();
            SuspendLayout();
            // 
            // prudctCategorylbl
            // 
            prudctCategorylbl.AutoSize = true;
            prudctCategorylbl.Font = new Font("Microsoft Sans Serif", 12F);
            prudctCategorylbl.Location = new Point(15, 125);
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
            label3.Location = new Point(15, 74);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 3;
            label3.Text = "Product Name :";
            // 
            // productNamebox
            // 
            productNamebox.Location = new Point(161, 75);
            productNamebox.Margin = new Padding(4, 2, 4, 2);
            productNamebox.Name = "productNamebox";
            productNamebox.Size = new Size(155, 23);
            productNamebox.TabIndex = 4;
            // 
            // productCostlbl
            // 
            productCostlbl.AutoSize = true;
            productCostlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productCostlbl.Location = new Point(15, 324);
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
            stockAddProuctbtn.Location = new Point(275, 502);
            stockAddProuctbtn.Margin = new Padding(4, 2, 4, 2);
            stockAddProuctbtn.Name = "stockAddProuctbtn";
            stockAddProuctbtn.Size = new Size(140, 37);
            stockAddProuctbtn.TabIndex = 7;
            stockAddProuctbtn.Text = "Add";
            stockAddProuctbtn.UseVisualStyleBackColor = false;
            stockAddProuctbtn.Click += stockAddProductbtn_Click;
            // 
            // productStatusbox
            // 
            productStatusbox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            productStatusbox.FormattingEnabled = true;
            productStatusbox.Items.AddRange(new object[] { "Available", "Re-Order", "Danger", "Out-Of-Stock" });
            productStatusbox.Location = new Point(162, 371);
            productStatusbox.Margin = new Padding(4, 2, 4, 2);
            productStatusbox.Name = "productStatusbox";
            productStatusbox.Size = new Size(156, 24);
            productStatusbox.TabIndex = 18;
            // 
            // productDescriptionlbl
            // 
            productDescriptionlbl.AutoSize = true;
            productDescriptionlbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productDescriptionlbl.Location = new Point(15, 413);
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
            productSeriallbl.Location = new Point(14, 224);
            productSeriallbl.Margin = new Padding(4, 0, 4, 0);
            productSeriallbl.Name = "productSeriallbl";
            productSeriallbl.Size = new Size(117, 20);
            productSeriallbl.TabIndex = 12;
            productSeriallbl.Text = "Serial Number :";
            // 
            // productserialbox
            // 
            productserialbox.Location = new Point(162, 225);
            productserialbox.Margin = new Padding(4, 2, 4, 2);
            productserialbox.Name = "productserialbox";
            productserialbox.Size = new Size(155, 23);
            productserialbox.TabIndex = 8;
            // 
            // productCostbox
            // 
            productCostbox.Location = new Point(161, 326);
            productCostbox.Margin = new Padding(4, 2, 4, 2);
            productCostbox.Name = "productCostbox";
            productCostbox.Size = new Size(155, 23);
            productCostbox.TabIndex = 10;
            // 
            // productWeightlbl
            // 
            productWeightlbl.AutoSize = true;
            productWeightlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productWeightlbl.Location = new Point(340, 323);
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
            productStatuslbl.Location = new Point(15, 370);
            productStatuslbl.Margin = new Padding(4, 0, 4, 0);
            productStatuslbl.Name = "productStatuslbl";
            productStatuslbl.Size = new Size(64, 20);
            productStatuslbl.TabIndex = 16;
            productStatuslbl.Text = "Status :";
            // 
            // productWeightbox
            // 
            productWeightbox.Location = new Point(519, 325);
            productWeightbox.Margin = new Padding(4, 2, 4, 2);
            productWeightbox.Name = "productWeightbox";
            productWeightbox.Size = new Size(155, 23);
            productWeightbox.TabIndex = 11;
            // 
            // productInStocklbl
            // 
            productInStocklbl.AutoSize = true;
            productInStocklbl.Font = new Font("Microsoft Sans Serif", 12F);
            productInStocklbl.Location = new Point(340, 126);
            productInStocklbl.Margin = new Padding(4, 0, 4, 0);
            productInStocklbl.Name = "productInStocklbl";
            productInStocklbl.Size = new Size(139, 20);
            productInStocklbl.TabIndex = 18;
            productInStocklbl.Text = "Quantity In Stock :";
            // 
            // productInStockbox
            // 
            productInStockbox.Location = new Point(519, 127);
            productInStockbox.Margin = new Padding(4, 2, 4, 2);
            productInStockbox.Name = "productInStockbox";
            productInStockbox.Size = new Size(156, 23);
            productInStockbox.TabIndex = 13;
            // 
            // productReOrderbox
            // 
            productReOrderbox.Location = new Point(519, 178);
            productReOrderbox.Margin = new Padding(4, 2, 4, 2);
            productReOrderbox.Name = "productReOrderbox";
            productReOrderbox.Size = new Size(156, 23);
            productReOrderbox.TabIndex = 14;
            productReOrderbox.TextChanged += productReOrderbox_TextChanged;
            // 
            // productReOrderlbl
            // 
            productReOrderlbl.AutoSize = true;
            productReOrderlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productReOrderlbl.Location = new Point(340, 176);
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
            productDangerlbl.Location = new Point(340, 225);
            productDangerlbl.Margin = new Padding(4, 0, 4, 0);
            productDangerlbl.Name = "productDangerlbl";
            productDangerlbl.Size = new Size(133, 20);
            productDangerlbl.TabIndex = 24;
            productDangerlbl.Text = "Danger Quantity :";
            // 
            // productDescriptionbox
            // 
            productDescriptionbox.Location = new Point(161, 416);
            productDescriptionbox.Margin = new Padding(4, 2, 4, 2);
            productDescriptionbox.Name = "productDescriptionbox";
            productDescriptionbox.Size = new Size(518, 23);
            productDescriptionbox.TabIndex = 17;
            // 
            // productDangerbox
            // 
            productDangerbox.Location = new Point(520, 227);
            productDangerbox.Margin = new Padding(4, 2, 4, 2);
            productDangerbox.Name = "productDangerbox";
            productDangerbox.Size = new Size(156, 23);
            productDangerbox.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Desktop;
            label12.Location = new Point(13, 18);
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
            button3.Location = new Point(824, 8);
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
            productCategorybox.Location = new Point(161, 126);
            productCategorybox.Margin = new Padding(4, 2, 4, 2);
            productCategorybox.Name = "productCategorybox";
            productCategorybox.Size = new Size(155, 24);
            productCategorybox.TabIndex = 5;
            // 
            // productAutoOrderlbl
            // 
            productAutoOrderlbl.AutoSize = true;
            productAutoOrderlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productAutoOrderlbl.Location = new Point(340, 75);
            productAutoOrderlbl.Margin = new Padding(4, 0, 4, 0);
            productAutoOrderlbl.Name = "productAutoOrderlbl";
            productAutoOrderlbl.Size = new Size(172, 20);
            productAutoOrderlbl.TabIndex = 38;
            productAutoOrderlbl.Text = "Out Of Stock Quantity :";
            productAutoOrderlbl.Click += label9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(15, 174);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 40;
            label1.Text = "WareHouse :";
            // 
            // productWarehousebox
            // 
            productWarehousebox.Location = new Point(161, 176);
            productWarehousebox.Margin = new Padding(4, 2, 4, 2);
            productWarehousebox.Name = "productWarehousebox";
            productWarehousebox.Size = new Size(155, 23);
            productWarehousebox.TabIndex = 7;
            // 
            // productDemandlbl
            // 
            productDemandlbl.AutoSize = true;
            productDemandlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productDemandlbl.Location = new Point(340, 274);
            productDemandlbl.Margin = new Padding(4, 0, 4, 0);
            productDemandlbl.Name = "productDemandlbl";
            productDemandlbl.Size = new Size(78, 20);
            productDemandlbl.TabIndex = 42;
            productDemandlbl.Text = "Demand :";
            productDemandlbl.Click += productDemandlbl_Click;
            // 
            // productdemandbox
            // 
            productdemandbox.Location = new Point(519, 276);
            productdemandbox.Margin = new Padding(4, 2, 4, 2);
            productdemandbox.Name = "productdemandbox";
            productdemandbox.Size = new Size(156, 23);
            productdemandbox.TabIndex = 16;
            // 
            // productClosebtn
            // 
            productClosebtn.FlatAppearance.BorderSize = 0;
            productClosebtn.FlatStyle = FlatStyle.Flat;
            productClosebtn.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productClosebtn.Location = new Point(669, 9);
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
            label2.Location = new Point(15, 273);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 45;
            label2.Text = "Unit Price :";
            // 
            // productUnitpricebox
            // 
            productUnitpricebox.Location = new Point(161, 275);
            productUnitpricebox.Margin = new Padding(4, 2, 4, 2);
            productUnitpricebox.Name = "productUnitpricebox";
            productUnitpricebox.Size = new Size(155, 23);
            productUnitpricebox.TabIndex = 9;
            // 
            // productOutofStockbox
            // 
            productOutofStockbox.Location = new Point(520, 76);
            productOutofStockbox.Margin = new Padding(4, 3, 4, 3);
            productOutofStockbox.Name = "productOutofStockbox";
            productOutofStockbox.Size = new Size(155, 23);
            productOutofStockbox.TabIndex = 48;
            // 
            // stockEditProuctbtn
            // 
            stockEditProuctbtn.BackColor = Color.FromArgb(0, 192, 0);
            stockEditProuctbtn.Font = new Font("Microsoft Sans Serif", 12F);
            stockEditProuctbtn.ForeColor = Color.White;
            stockEditProuctbtn.Location = new Point(275, 502);
            stockEditProuctbtn.Margin = new Padding(4, 2, 4, 2);
            stockEditProuctbtn.Name = "stockEditProuctbtn";
            stockEditProuctbtn.Size = new Size(140, 37);
            stockEditProuctbtn.TabIndex = 49;
            stockEditProuctbtn.Text = "Edit";
            stockEditProuctbtn.UseVisualStyleBackColor = false;
            stockEditProuctbtn.Click += stockEditProuctbtn_Click_1;
            // 
            // productNameAlert
            // 
            productNameAlert.AutoSize = true;
            productNameAlert.ForeColor = Color.Red;
            productNameAlert.Location = new Point(161, 98);
            productNameAlert.Name = "productNameAlert";
            productNameAlert.Size = new Size(132, 15);
            productNameAlert.TabIndex = 50;
            productNameAlert.Text = "Product Name is empty";
            // 
            // outStockAlert
            // 
            outStockAlert.AutoSize = true;
            outStockAlert.ForeColor = Color.Red;
            outStockAlert.Location = new Point(519, 102);
            outStockAlert.Name = "outStockAlert";
            outStockAlert.Size = new Size(172, 15);
            outStockAlert.TabIndex = 51;
            outStockAlert.Text = "Out Of Stock Quantity is empty";
            // 
            // inStockAlert
            // 
            inStockAlert.AutoSize = true;
            inStockAlert.ForeColor = Color.Red;
            inStockAlert.Location = new Point(520, 152);
            inStockAlert.Name = "inStockAlert";
            inStockAlert.Size = new Size(146, 15);
            inStockAlert.TabIndex = 52;
            inStockAlert.Text = "Quantity In Stock is empty";
            // 
            // warehouseAlert
            // 
            warehouseAlert.AutoSize = true;
            warehouseAlert.ForeColor = Color.Red;
            warehouseAlert.Location = new Point(161, 199);
            warehouseAlert.Name = "warehouseAlert";
            warehouseAlert.Size = new Size(116, 15);
            warehouseAlert.TabIndex = 53;
            warehouseAlert.Text = "WareHouse is empty";
            // 
            // reorderAlert
            // 
            reorderAlert.AutoSize = true;
            reorderAlert.ForeColor = Color.Red;
            reorderAlert.Location = new Point(519, 203);
            reorderAlert.Name = "reorderAlert";
            reorderAlert.Size = new Size(152, 15);
            reorderAlert.TabIndex = 54;
            reorderAlert.Text = "Re-Order Quantity is empty";
            // 
            // serialNumAlert
            // 
            serialNumAlert.AutoSize = true;
            serialNumAlert.ForeColor = Color.Red;
            serialNumAlert.Location = new Point(161, 248);
            serialNumAlert.Name = "serialNumAlert";
            serialNumAlert.Size = new Size(130, 15);
            serialNumAlert.TabIndex = 55;
            serialNumAlert.Text = "Serial Number is empty";
            // 
            // dangerQuanAlert
            // 
            dangerQuanAlert.AutoSize = true;
            dangerQuanAlert.ForeColor = Color.Red;
            dangerQuanAlert.Location = new Point(520, 250);
            dangerQuanAlert.Name = "dangerQuanAlert";
            dangerQuanAlert.Size = new Size(142, 15);
            dangerQuanAlert.TabIndex = 56;
            dangerQuanAlert.Text = "Danger Quantity is empty";
            // 
            // unitPriceAlert
            // 
            unitPriceAlert.AutoSize = true;
            unitPriceAlert.ForeColor = Color.Red;
            unitPriceAlert.Location = new Point(162, 298);
            unitPriceAlert.Name = "unitPriceAlert";
            unitPriceAlert.Size = new Size(106, 15);
            unitPriceAlert.TabIndex = 57;
            unitPriceAlert.Text = "Unit Price is empty";
            // 
            // demandAlert
            // 
            demandAlert.AutoSize = true;
            demandAlert.ForeColor = Color.Red;
            demandAlert.Location = new Point(520, 301);
            demandAlert.Name = "demandAlert";
            demandAlert.Size = new Size(100, 15);
            demandAlert.TabIndex = 58;
            demandAlert.Text = "Demand is empty";
            // 
            // costPriceAlert
            // 
            costPriceAlert.AutoSize = true;
            costPriceAlert.ForeColor = Color.Red;
            costPriceAlert.Location = new Point(162, 349);
            costPriceAlert.Name = "costPriceAlert";
            costPriceAlert.Size = new Size(108, 15);
            costPriceAlert.TabIndex = 59;
            costPriceAlert.Text = "Cost Price is empty";
            // 
            // descriptionAlert
            // 
            descriptionAlert.AutoSize = true;
            descriptionAlert.ForeColor = Color.Red;
            descriptionAlert.Location = new Point(162, 441);
            descriptionAlert.Name = "descriptionAlert";
            descriptionAlert.Size = new Size(115, 15);
            descriptionAlert.TabIndex = 60;
            descriptionAlert.Text = "Description is empty";
            // 
            // weightAlert
            // 
            weightAlert.AutoSize = true;
            weightAlert.ForeColor = Color.Red;
            weightAlert.Location = new Point(520, 350);
            weightAlert.Name = "weightAlert";
            weightAlert.Size = new Size(93, 15);
            weightAlert.TabIndex = 61;
            weightAlert.Text = "Weight is empty";
            // 
            // serialNumNote
            // 
            serialNumNote.AutoSize = true;
            serialNumNote.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serialNumNote.ForeColor = Color.Red;
            serialNumNote.Location = new Point(14, 473);
            serialNumNote.Name = "serialNumNote";
            serialNumNote.Size = new Size(656, 20);
            serialNumNote.TabIndex = 62;
            serialNumNote.Text = "Note: Serial number must be less than 7 characters long and can only contain letters and numbers!";
            // 
            // priceNote2
            // 
            priceNote2.AutoSize = true;
            priceNote2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceNote2.ForeColor = Color.Red;
            priceNote2.Location = new Point(184, 473);
            priceNote2.Name = "priceNote2";
            priceNote2.Size = new Size(327, 20);
            priceNote2.TabIndex = 63;
            priceNote2.Text = "Note: Unit price must be greater than cost price!";
            // 
            // priceNote
            // 
            priceNote.AutoSize = true;
            priceNote.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceNote.ForeColor = Color.Red;
            priceNote.Location = new Point(141, 473);
            priceNote.Name = "priceNote";
            priceNote.Size = new Size(425, 20);
            priceNote.TabIndex = 64;
            priceNote.Text = "Note: Unit price and cost price must be valid decimal numbers!";
            // 
            // PativeNote
            // 
            PativeNote.AutoSize = true;
            PativeNote.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PativeNote.ForeColor = Color.Red;
            PativeNote.Location = new Point(406, 380);
            PativeNote.Name = "PativeNote";
            PativeNote.Size = new Size(234, 20);
            PativeNote.TabIndex = 65;
            PativeNote.Text = "Note: Please input Pative Number!";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(714, 556);
            Controls.Add(PativeNote);
            Controls.Add(priceNote);
            Controls.Add(priceNote2);
            Controls.Add(serialNumNote);
            Controls.Add(weightAlert);
            Controls.Add(descriptionAlert);
            Controls.Add(costPriceAlert);
            Controls.Add(demandAlert);
            Controls.Add(unitPriceAlert);
            Controls.Add(dangerQuanAlert);
            Controls.Add(serialNumAlert);
            Controls.Add(reorderAlert);
            Controls.Add(warehouseAlert);
            Controls.Add(inStockAlert);
            Controls.Add(outStockAlert);
            Controls.Add(productNameAlert);
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
            Controls.Add(productCostlbl);
            Controls.Add(productNamebox);
            Controls.Add(label3);
            Controls.Add(prudctCategorylbl);
            Controls.Add(stockEditProuctbtn);
            Controls.Add(stockAddProuctbtn);
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
        private Label label1;
        private TextBox productWarehousebox;
        private Label productDemandlbl;
        private TextBox productdemandbox;
        private Button productClosebtn;
        private Label label2;
        private TextBox productUnitpricebox;
        private TextBox productOutofStockbox;
        private Button stockEditProuctbtn;
        private Label productNameAlert;
        private Label outStockAlert;
        private Label inStockAlert;
        private Label warehouseAlert;
        private Label reorderAlert;
        private Label serialNumAlert;
        private Label dangerQuanAlert;
        private Label unitPriceAlert;
        private Label demandAlert;
        private Label costPriceAlert;
        private Label descriptionAlert;
        private Label weightAlert;
        private Label serialNumNote;
        private Label priceNote2;
        private Label priceNote;
        private Label PativeNote;
    }
}

