using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ProgramMethod;
using MySql.Data.MySqlClient;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ITP4519M
{
    public partial class ProductForm : Form
    {
        private OperationMode _mode;
        private string productID;
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        private bool isFormDragging = false;
        private Point formStartPoint;


        public ProductForm(OperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }
        private void productForm_Load(object sender, EventArgs e)
        {
            programMethod = new ProgramMethod.ProgramMethod();
            switch (_mode)
            {
                case OperationMode.View:
                    stockAddProuctbtn.Visible = false;
                    stockEditProuctbtn.Visible = false;
                    SetReadOnly(true);

                    break;
                case OperationMode.Edit:
                    stockAddProuctbtn.Visible = false;
                    stockEditProuctbtn.Visible = true;

                    break;
                case OperationMode.New:
                    stockAddProuctbtn.Visible = true;
                    stockEditProuctbtn.Visible = false;
                    break;

            }
        }

        public void productEdit(string productID)
        {

            this.productID = productID;

            try
            {

                var productDetails = programMethod.getProductDetails(productID);
                if (productDetails != null)
                {
                    this.productNamebox.Text = productDetails.ProductName;
                    this.productWarehousebox.Text = productDetails.BinLocation;
                    this.productCategorybox.SelectedItem = productDetails.ProductCategory;
                    this.productUnitpricebox.Text = productDetails.UnitPrice;
                    this.productCostbox.Text = productDetails.CostPrice;

                    this.productWeightbox.Text = productDetails.Weight;
                    this.productOutofStockbox.Text = productDetails.OutOfStockQty;
                    this.productInStockbox.Text = productDetails.QuantityInStock;
                    this.productReOrderbox.Text = productDetails.ReOrderQty;
                    this.productDangerbox.Text = productDetails.DangerQty;

                    this.productdemandbox.Text = productDetails.DemandStock;
                    this.productDescriptionbox.Text = productDetails.Description;
                    this.productStatusbox.SelectedItem = productDetails.Status;
                }
                else
                {
                    MessageBox.Show("Product details not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetReadOnly(bool readOnly)
        {

            productNamebox.ReadOnly = readOnly;
            productWarehousebox.ReadOnly = readOnly;
            productserialbox.ReadOnly = readOnly;
            productUnitpricebox.ReadOnly = readOnly;
            productCostbox.ReadOnly = readOnly;
            productWeightbox.ReadOnly = readOnly;
            productOutofStockbox.ReadOnly = readOnly;
            productInStockbox.ReadOnly = readOnly;
            productReOrderbox.ReadOnly = readOnly;
            productDangerbox.ReadOnly = readOnly;
            productDescriptionbox.ReadOnly = readOnly;
            productdemandbox.ReadOnly = readOnly;

            productNamebox.Enabled = !readOnly;
            productWarehousebox.Enabled = !readOnly;
            productserialbox.Enabled = !readOnly;
            productUnitpricebox.Enabled = !readOnly;
            productCostbox.Enabled = !readOnly;
            productWeightbox.Enabled = !readOnly;
            productOutofStockbox.Enabled = !readOnly;
            productInStockbox.Enabled = !readOnly;
            productReOrderbox.Enabled = !readOnly;
            productDangerbox.Enabled = !readOnly;
            productDescriptionbox.Enabled = !readOnly;
            productNamebox.Enabled = !readOnly;
            productWarehousebox.Enabled = !readOnly;
            productdemandbox.Enabled = !readOnly;

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }



        private void productClosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stockAddProductbtn_Click(object sender, EventArgs e)
        {

            string selected = this.productCategorybox.GetItemText(this.productCategorybox.SelectedItem);
            if (programMethod.createProductinfo(productNamebox.Text.Trim(), selected, productWarehousebox.Text.Trim(), productserialbox.Text.Trim(), productUnitpricebox.Text.Trim(), productCostbox.Text.Trim(), productWeightbox.Text.Trim(), productOutofStockbox.Text.Trim(), productInStockbox.Text.Trim(), productdemandbox.Text.Trim(), productDescriptionbox.Text.Trim(), productStatusbox.GetItemText(this.productStatusbox.SelectedItem)))
            {

                productNamebox.Text = "";
                productCategorybox.SelectedItem = null;
                productWarehousebox.Text = "";
                productserialbox.Text = "";
                productUnitpricebox.Text = "";
                productCostbox.Text = "";
                productWeightbox.Text = "";
                productOutofStockbox.Text = "";
                productInStockbox.Text = "";
                productReOrderbox.Text = "";
                productDangerbox.Text = "";
                productdemandbox.Text = "";
                productdemandbox.Text = "";
                productStatusbox.SelectedItem = null;
            }
            
            
        }

        private void ProductForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isFormDragging = true;
                formStartPoint = e.Location;
            }
        }

        private void ProductForm_MouseUp(object sender, MouseEventArgs e)
        {

            isFormDragging = false;
        }

        private void ProductForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isFormDragging)
            {
                int deltaX = e.X - formStartPoint.X;
                int deltaY = e.Y - formStartPoint.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void productDemandlbl_Click(object sender, EventArgs e)
        {

        }

        private void stockEditProuctbtn_Click(object sender, EventArgs e)
        {
            var productDetails = programMethod.getProductDetails(productID);
            string productid = productDetails.ProductID;
            string selected = this.productCategorybox.GetItemText(this.productCategorybox.SelectedItem);
            if (programMethod.updateProductinfo(productid, productNamebox.Text.Trim(), selected, productWarehousebox.Text.Trim(), productserialbox.Text.Trim(), productUnitpricebox.Text.Trim(), productCostbox.Text.Trim(), productWeightbox.Text.Trim(), productOutofStockbox.Text.Trim(), productInStockbox.Text.Trim(),  productdemandbox.Text.Trim(), productDescriptionbox.Text.Trim(), productStatusbox.GetItemText(this.productStatusbox.SelectedItem)))
            {

                MessageBox.Show("Saved");
            }
            else
            {

                MessageBox.Show("Please input xxxxxx");
            }
        }
    }

}
     

