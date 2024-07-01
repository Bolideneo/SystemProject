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
            SuspendLayout();
            // 
            // prudctCategorylbl
            // 
            prudctCategorylbl.AutoSize = true;
            prudctCategorylbl.Font = new Font("Microsoft Sans Serif", 12F);
            prudctCategorylbl.Location = new Point(17, 167);
            prudctCategorylbl.Margin = new Padding(5, 0, 5, 0);
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
            label3.Location = new Point(17, 99);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 3;
            label3.Text = "Product Name :";
            // 
            // productNamebox
            // 
            productNamebox.Location = new Point(184, 100);
            productNamebox.Margin = new Padding(5, 3, 5, 3);
            productNamebox.Name = "productNamebox";
            productNamebox.Size = new Size(177, 27);
            productNamebox.TabIndex = 4;
            // 
            // productCostlbl
            // 
            productCostlbl.AutoSize = true;
            productCostlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productCostlbl.Location = new Point(17, 432);
            productCostlbl.Margin = new Padding(5, 0, 5, 0);
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
            stockAddProuctbtn.Location = new Point(314, 669);
            stockAddProuctbtn.Margin = new Padding(5, 3, 5, 3);
            stockAddProuctbtn.Name = "stockAddProuctbtn";
            stockAddProuctbtn.Size = new Size(160, 49);
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
            productStatusbox.Location = new Point(185, 495);
            productStatusbox.Margin = new Padding(5, 3, 5, 3);
            productStatusbox.Name = "productStatusbox";
            productStatusbox.Size = new Size(178, 28);
            productStatusbox.TabIndex = 18;
            // 
            // productDescriptionlbl
            // 
            productDescriptionlbl.AutoSize = true;
            productDescriptionlbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productDescriptionlbl.Location = new Point(17, 551);
            productDescriptionlbl.Margin = new Padding(5, 0, 5, 0);
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
            productSeriallbl.Location = new Point(16, 299);
            productSeriallbl.Margin = new Padding(5, 0, 5, 0);
            productSeriallbl.Name = "productSeriallbl";
            productSeriallbl.Size = new Size(147, 25);
            productSeriallbl.TabIndex = 12;
            productSeriallbl.Text = "Serial Number :";
            // 
            // productserialbox
            // 
            productserialbox.Location = new Point(185, 300);
            productserialbox.Margin = new Padding(5, 3, 5, 3);
            productserialbox.Name = "productserialbox";
            productserialbox.Size = new Size(177, 27);
            productserialbox.TabIndex = 8;
            // 
            // productCostbox
            // 
            productCostbox.Location = new Point(184, 435);
            productCostbox.Margin = new Padding(5, 3, 5, 3);
            productCostbox.Name = "productCostbox";
            productCostbox.Size = new Size(177, 27);
            productCostbox.TabIndex = 10;
            // 
            // productWeightlbl
            // 
            productWeightlbl.AutoSize = true;
            productWeightlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productWeightlbl.Location = new Point(389, 431);
            productWeightlbl.Margin = new Padding(5, 0, 5, 0);
            productWeightlbl.Name = "productWeightlbl";
            productWeightlbl.Size = new Size(85, 25);
            productWeightlbl.TabIndex = 15;
            productWeightlbl.Text = "Weight :";
            // 
            // productStatuslbl
            // 
            productStatuslbl.AutoSize = true;
            productStatuslbl.Font = new Font("Microsoft Sans Serif", 12F);
            productStatuslbl.Location = new Point(17, 494);
            productStatuslbl.Margin = new Padding(5, 0, 5, 0);
            productStatuslbl.Name = "productStatuslbl";
            productStatuslbl.Size = new Size(79, 25);
            productStatuslbl.TabIndex = 16;
            productStatuslbl.Text = "Status :";
            // 
            // productWeightbox
            // 
            productWeightbox.Location = new Point(593, 433);
            productWeightbox.Margin = new Padding(5, 3, 5, 3);
            productWeightbox.Name = "productWeightbox";
            productWeightbox.Size = new Size(177, 27);
            productWeightbox.TabIndex = 11;
            // 
            // productInStocklbl
            // 
            productInStocklbl.AutoSize = true;
            productInStocklbl.Font = new Font("Microsoft Sans Serif", 12F);
            productInStocklbl.Location = new Point(388, 168);
            productInStocklbl.Margin = new Padding(5, 0, 5, 0);
            productInStocklbl.Name = "productInStocklbl";
            productInStocklbl.Size = new Size(172, 25);
            productInStocklbl.TabIndex = 18;
            productInStocklbl.Text = "Quantity In Stock :";
            // 
            // productInStockbox
            // 
            productInStockbox.Location = new Point(593, 169);
            productInStockbox.Margin = new Padding(5, 3, 5, 3);
            productInStockbox.Name = "productInStockbox";
            productInStockbox.Size = new Size(178, 27);
            productInStockbox.TabIndex = 13;
            // 
            // productReOrderbox
            // 
            productReOrderbox.Location = new Point(593, 237);
            productReOrderbox.Margin = new Padding(5, 3, 5, 3);
            productReOrderbox.Name = "productReOrderbox";
            productReOrderbox.Size = new Size(178, 27);
            productReOrderbox.TabIndex = 14;
            productReOrderbox.TextChanged += productReOrderbox_TextChanged;
            // 
            // productReOrderlbl
            // 
            productReOrderlbl.AutoSize = true;
            productReOrderlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productReOrderlbl.Location = new Point(388, 235);
            productReOrderlbl.Margin = new Padding(5, 0, 5, 0);
            productReOrderlbl.Name = "productReOrderlbl";
            productReOrderlbl.Size = new Size(182, 25);
            productReOrderlbl.TabIndex = 23;
            productReOrderlbl.Text = "Re-Order Quantity :";
            // 
            // productDangerlbl
            // 
            productDangerlbl.AutoSize = true;
            productDangerlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productDangerlbl.Location = new Point(389, 300);
            productDangerlbl.Margin = new Padding(5, 0, 5, 0);
            productDangerlbl.Name = "productDangerlbl";
            productDangerlbl.Size = new Size(165, 25);
            productDangerlbl.TabIndex = 24;
            productDangerlbl.Text = "Danger Quantity :";
            // 
            // productDescriptionbox
            // 
            productDescriptionbox.Location = new Point(184, 554);
            productDescriptionbox.Margin = new Padding(5, 3, 5, 3);
            productDescriptionbox.Name = "productDescriptionbox";
            productDescriptionbox.Size = new Size(591, 27);
            productDescriptionbox.TabIndex = 17;
            // 
            // productDangerbox
            // 
            productDangerbox.Location = new Point(594, 303);
            productDangerbox.Margin = new Padding(5, 3, 5, 3);
            productDangerbox.Name = "productDangerbox";
            productDangerbox.Size = new Size(178, 27);
            productDangerbox.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Desktop;
            label12.Location = new Point(15, 24);
            label12.Margin = new Padding(5, 0, 5, 0);
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
            button3.Margin = new Padding(2, 3, 2, 3);
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
            productCategorybox.Location = new Point(184, 168);
            productCategorybox.Margin = new Padding(5, 3, 5, 3);
            productCategorybox.Name = "productCategorybox";
            productCategorybox.Size = new Size(177, 28);
            productCategorybox.TabIndex = 5;
            // 
            // productAutoOrderlbl
            // 
            productAutoOrderlbl.AutoSize = true;
            productAutoOrderlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productAutoOrderlbl.Location = new Point(388, 100);
            productAutoOrderlbl.Margin = new Padding(5, 0, 5, 0);
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
            label1.Location = new Point(17, 232);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 40;
            label1.Text = "WareHouse :";
            // 
            // productWarehousebox
            // 
            productWarehousebox.Location = new Point(184, 235);
            productWarehousebox.Margin = new Padding(5, 3, 5, 3);
            productWarehousebox.Name = "productWarehousebox";
            productWarehousebox.Size = new Size(177, 27);
            productWarehousebox.TabIndex = 7;
            // 
            // productDemandlbl
            // 
            productDemandlbl.AutoSize = true;
            productDemandlbl.Font = new Font("Microsoft Sans Serif", 12F);
            productDemandlbl.Location = new Point(388, 365);
            productDemandlbl.Margin = new Padding(5, 0, 5, 0);
            productDemandlbl.Name = "productDemandlbl";
            productDemandlbl.Size = new Size(97, 25);
            productDemandlbl.TabIndex = 42;
            productDemandlbl.Text = "Demand :";
            productDemandlbl.Click += productDemandlbl_Click;
            // 
            // productdemandbox
            // 
            productdemandbox.Location = new Point(593, 368);
            productdemandbox.Margin = new Padding(5, 3, 5, 3);
            productdemandbox.Name = "productdemandbox";
            productdemandbox.Size = new Size(178, 27);
            productdemandbox.TabIndex = 16;
            // 
            // productClosebtn
            // 
            productClosebtn.FlatAppearance.BorderSize = 0;
            productClosebtn.FlatStyle = FlatStyle.Flat;
            productClosebtn.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productClosebtn.Location = new Point(765, 12);
            productClosebtn.Margin = new Padding(2, 3, 2, 3);
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
            label2.Location = new Point(17, 364);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 45;
            label2.Text = "Unit Price :";
            // 
            // productUnitpricebox
            // 
            productUnitpricebox.Location = new Point(184, 367);
            productUnitpricebox.Margin = new Padding(5, 3, 5, 3);
            productUnitpricebox.Name = "productUnitpricebox";
            productUnitpricebox.Size = new Size(177, 27);
            productUnitpricebox.TabIndex = 9;
            // 
            // productOutofStockbox
            // 
            productOutofStockbox.Location = new Point(594, 101);
            productOutofStockbox.Margin = new Padding(5, 4, 5, 4);
            productOutofStockbox.Name = "productOutofStockbox";
            productOutofStockbox.Size = new Size(177, 27);
            productOutofStockbox.TabIndex = 48;
            // 
            // stockEditProuctbtn
            // 
            stockEditProuctbtn.BackColor = Color.FromArgb(0, 192, 0);
            stockEditProuctbtn.Font = new Font("Microsoft Sans Serif", 12F);
            stockEditProuctbtn.ForeColor = Color.White;
            stockEditProuctbtn.Location = new Point(314, 669);
            stockEditProuctbtn.Margin = new Padding(5, 3, 5, 3);
            stockEditProuctbtn.Name = "stockEditProuctbtn";
            stockEditProuctbtn.Size = new Size(160, 49);
            stockEditProuctbtn.TabIndex = 49;
            stockEditProuctbtn.Text = "Edit";
            stockEditProuctbtn.UseVisualStyleBackColor = false;
            stockEditProuctbtn.Click += stockEditProuctbtn_Click_1;
            // 
            // productNameAlert
            // 
            productNameAlert.AutoSize = true;
            productNameAlert.ForeColor = Color.Red;
            productNameAlert.Location = new Point(184, 130);
            productNameAlert.Name = "productNameAlert";
            productNameAlert.Size = new Size(164, 20);
            productNameAlert.TabIndex = 50;
            productNameAlert.Text = "Product Name is empty";
            // 
            // outStockAlert
            // 
            outStockAlert.AutoSize = true;
            outStockAlert.ForeColor = Color.Red;
            outStockAlert.Location = new Point(593, 130);
            outStockAlert.Name = "outStockAlert";
            outStockAlert.Size = new Size(213, 20);
            outStockAlert.TabIndex = 51;
            outStockAlert.Text = "Out Of Stock Quantity is empty";
            // 
            // inStockAlert
            // 
            inStockAlert.AutoSize = true;
            inStockAlert.ForeColor = Color.Red;
            inStockAlert.Location = new Point(594, 199);
            inStockAlert.Name = "inStockAlert";
            inStockAlert.Size = new Size(181, 20);
            inStockAlert.TabIndex = 52;
            inStockAlert.Text = "Quantity In Stock is empty";
            // 
            // warehouseAlert
            // 
            warehouseAlert.AutoSize = true;
            warehouseAlert.ForeColor = Color.Red;
            warehouseAlert.Location = new Point(184, 265);
            warehouseAlert.Name = "warehouseAlert";
            warehouseAlert.Size = new Size(145, 20);
            warehouseAlert.TabIndex = 53;
            warehouseAlert.Text = "WareHouse is empty";
            // 
            // reorderAlert
            // 
            reorderAlert.AutoSize = true;
            reorderAlert.ForeColor = Color.Red;
            reorderAlert.Location = new Point(594, 265);
            reorderAlert.Name = "reorderAlert";
            reorderAlert.Size = new Size(190, 20);
            reorderAlert.TabIndex = 54;
            reorderAlert.Text = "Re-Order Quantity is empty";
            // 
            // serialNumAlert
            // 
            serialNumAlert.AutoSize = true;
            serialNumAlert.ForeColor = Color.Red;
            serialNumAlert.Location = new Point(184, 330);
            serialNumAlert.Name = "serialNumAlert";
            serialNumAlert.Size = new Size(164, 20);
            serialNumAlert.TabIndex = 55;
            serialNumAlert.Text = "Serial Number is empty";
            // 
            // dangerQuanAlert
            // 
            dangerQuanAlert.AutoSize = true;
            dangerQuanAlert.ForeColor = Color.Red;
            dangerQuanAlert.Location = new Point(594, 333);
            dangerQuanAlert.Name = "dangerQuanAlert";
            dangerQuanAlert.Size = new Size(178, 20);
            dangerQuanAlert.TabIndex = 56;
            dangerQuanAlert.Text = "Danger Quantity is empty";
            // 
            // unitPriceAlert
            // 
            unitPriceAlert.AutoSize = true;
            unitPriceAlert.ForeColor = Color.Red;
            unitPriceAlert.Location = new Point(185, 397);
            unitPriceAlert.Name = "unitPriceAlert";
            unitPriceAlert.Size = new Size(132, 20);
            unitPriceAlert.TabIndex = 57;
            unitPriceAlert.Text = "Unit Price is empty";
            // 
            // demandAlert
            // 
            demandAlert.AutoSize = true;
            demandAlert.ForeColor = Color.Red;
            demandAlert.Location = new Point(594, 398);
            demandAlert.Name = "demandAlert";
            demandAlert.Size = new Size(126, 20);
            demandAlert.TabIndex = 58;
            demandAlert.Text = "Demand is empty";
            // 
            // costPriceAlert
            // 
            costPriceAlert.AutoSize = true;
            costPriceAlert.ForeColor = Color.Red;
            costPriceAlert.Location = new Point(185, 465);
            costPriceAlert.Name = "costPriceAlert";
            costPriceAlert.Size = new Size(134, 20);
            costPriceAlert.TabIndex = 59;
            costPriceAlert.Text = "Cost Price is empty";
            // 
            // descriptionAlert
            // 
            descriptionAlert.AutoSize = true;
            descriptionAlert.ForeColor = Color.Red;
            descriptionAlert.Location = new Point(183, 584);
            descriptionAlert.Name = "descriptionAlert";
            descriptionAlert.Size = new Size(145, 20);
            descriptionAlert.TabIndex = 60;
            descriptionAlert.Text = "Description is empty";
            // 
            // weightAlert
            // 
            weightAlert.AutoSize = true;
            weightAlert.ForeColor = Color.Red;
            weightAlert.Location = new Point(594, 463);
            weightAlert.Name = "weightAlert";
            weightAlert.Size = new Size(116, 20);
            weightAlert.TabIndex = 61;
            weightAlert.Text = "Weight is empty";
            // 
            // serialNumNote
            // 
            serialNumNote.AutoSize = true;
            serialNumNote.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serialNumNote.ForeColor = Color.Red;
            serialNumNote.Location = new Point(17, 631);
            serialNumNote.Name = "serialNumNote";
            serialNumNote.Size = new Size(774, 25);
            serialNumNote.TabIndex = 62;
            serialNumNote.Text = "Note: Serial number must be exactly 6 characters long and can only contain letters and numbers!";
            // 
            // priceNote2
            // 
            priceNote2.AutoSize = true;
            priceNote2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceNote2.ForeColor = Color.Red;
            priceNote2.Location = new Point(210, 631);
            priceNote2.Name = "priceNote2";
            priceNote2.Size = new Size(392, 25);
            priceNote2.TabIndex = 63;
            priceNote2.Text = "Note: Unit price must be greater than cost price!";
            // 
            // priceNote
            // 
            priceNote.AutoSize = true;
            priceNote.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceNote.ForeColor = Color.Red;
            priceNote.Location = new Point(161, 631);
            priceNote.Name = "priceNote";
            priceNote.Size = new Size(509, 25);
            priceNote.TabIndex = 64;
            priceNote.Text = "Note: Unit price and cost price must be valid decimal numbers!";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(816, 742);
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
            Controls.Add(stockAddProuctbtn);
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
    }
}

