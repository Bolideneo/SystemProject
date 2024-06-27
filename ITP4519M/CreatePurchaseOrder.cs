using Microsoft.VisualBasic.ApplicationServices;
using Mysqlx.Crud;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using ProgramMethod;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static ITP4519M.DataBaseMethod;
using static ProgramMethod.ProgramMethod;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITP4519M
{
    public partial class CreatePurchaseOrder : Form
    {
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        string SupplierID;
        public CreatePurchaseOrder()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {

            List<SupplierDetails> suppliers = programMethod.GetSuppliers();
            supplierBox.DataSource = suppliers;
            supplierBox.DisplayMember = "SupplierCompanyName";
            supplierBox.ValueMember = "SupplierID";
        }
        private void CreatePurchaseOrder_Load(object sender, EventArgs e)
        {

        }

        private void UpdateSupplierDetails(SupplierDetails supplier)
        {
            supplierContactPersonBox.Text = supplier.SupplierContactPerson;
            supplierMailBox.Text = supplier.SupplierEmail;
            supplierPhoneBox.Text = supplier.SupplierPhoneNum;
        }

        private void supplierBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (supplierBox.SelectedItem != null)
            {
                SupplierDetails selectedSupplier = (SupplierDetails)supplierBox.SelectedItem;
                LoadProductsBySupplier(selectedSupplier.SupplierID);
                UpdateSupplierDetails(selectedSupplier);
            }
        }



        private void LoadProductsBySupplier(string supplierID)
        {
            List<ProductDetails> products = programMethod.GetProductsBySupplier(supplierID);
            supplierProductBox.DataSource = products;
            supplierProductBox.DisplayMember = "ProductName";
            supplierProductBox.ValueMember = "ProductID";
       
        }
        private void supplierProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (supplierProductBox.SelectedItem != null)
            {
                ProductDetails selectedProduct = (ProductDetails)supplierProductBox.SelectedItem;
                costPriceBox.Text = selectedProduct.CostPrice.ToString();
            }
            UpdateTotalAmount();
        }

        private void createOrderbtn_Click(object sender, EventArgs e)
        {

        }

        private void quanBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }
        private void UpdateTotalAmount()
        {
            if (decimal.TryParse(costPriceBox.Text, out decimal costPrice) && int.TryParse(quanBox.Text, out int quantity))
            {
                decimal totalAmount = costPrice * quantity;
                amountDatalbl.Text = totalAmount.ToString();
            }
            else
            {
                amountDatalbl.Text = "Invalid input";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
