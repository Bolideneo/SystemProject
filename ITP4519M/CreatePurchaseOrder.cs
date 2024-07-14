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
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static ITP4519M.DataBaseMethod;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using static ProgramMethod.ProgramMethod;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITP4519M
{
    public partial class CreatePurchaseOrder : Form
    {
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        string SupplierID;
        private string poID;
        private OperationMode _mode;
        private string ProductID;
        private string OrderQuantity;
        public event EventHandler OperationCompleted;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
 (
    int nLeftRect,     // x-coordinate of upper-left corner
    int nTopRect,      // y-coordinate of upper-left corner
    int nRightRect,    // x-coordinate of lower-right corner
    int nBottomRect,   // y-coordinate of lower-right corner
    int nWidthEllipse, // height of ellipse
    int nHeightEllipse // width of ellipse
);

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(System.IntPtr hObject);

        public CreatePurchaseOrder(OperationMode mode)
        {

            InitializeComponent();
            LoadSuppliers();
            _mode = mode;
            KeyPreview = true;
            supplierBox.SelectedIndex = -1;
            supplierBox.Text = "Select a supplier";
            supplierProductBox.SelectedIndex = -1;
            supplierProductBox.Text = "Select a product";
            purchaseOrderItemsListView.Columns.Add("Product ID", 90);
            purchaseOrderItemsListView.Columns.Add("Product Name", 200);
            purchaseOrderItemsListView.Columns.Add("Quantity", 70);
            purchaseOrderItemsListView.Columns.Add("Cost Price", 100);
            purchaseOrderItemsListView.Columns.Add("Total Price", 100);
            clearForm();

        }

        private void LoadSuppliers()
        {

            List<SupplierDetails> suppliers = programMethod.GetSuppliers();
            supplierBox.DataSource = suppliers;
            supplierBox.DisplayMember = "SupplierCompanyName";
            supplierBox.ValueMember = "SupplierID";
            quantityAlertlbl.Visible = false;
            
        }
        private void CreatePurchaseOrder_Load(object sender, EventArgs e)
        {
            IntPtr handle = CreateRoundRectRgn(0, 0, Width, Height, 40, 40);
            Region = System.Drawing.Region.FromHrgn(handle);

            switch (_mode)
            {
                case OperationMode.View:

                    SetReadOnly(true);
                    break;
                case OperationMode.New:

                    SetReadOnly(true);
                    break;
                case OperationMode.Edit:

                    SetReadOnly(false);
                    break;
            }
        }

        private void SetReadOnly(bool readOnly)
        {


            supplierContactPersonBox.ReadOnly = readOnly;
            supplierMailBox.ReadOnly = readOnly;
            supplierPhoneBox.ReadOnly = readOnly;
            costPriceBox.ReadOnly = readOnly;


            supplierContactPersonBox.Enabled = !readOnly;
            supplierMailBox.Enabled = !readOnly;
            supplierPhoneBox.Enabled = !readOnly;
            costPriceBox.Enabled = !readOnly;

        }

        private void clearForm()
        {
            supplierBox.SelectedIndex = -1;
            supplierBox.Text = "Select a supplier";
            supplierProductBox.SelectedIndex = -1;
            supplierProductBox.Text = "Select a product";
            quanBox.Text = "";
            costPriceBox.Text = "";
            supplierContactPersonBox.Text = "";
            supplierMailBox.Text = "";
            supplierPhoneBox.Text = "";
            purchaseOrderItemsListView.Items.Clear();
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
                purchaseOrderItemsListView.Items.Clear();

            }
        }

        /* public void purchaseOrderView(string poID)
         {
             this.poID = poID;

             try
             {
                 // 获取采购订单详细信息
                 var orderDetails = programMethod.GetPurchaseOrderDetails(poID);
                 if (orderDetails != null)
                 {
                     // 填充订单基本信息
                     supplierBox.Text = orderDetails.SupplierCompanyName;
                     SupplierID = orderDetails.SupplierID;
                     supplierProductBox.Text = orderDetails.ProductName;
                     quanBox.Text = orderDetails.OrderQuantity;
                     costPriceBox.Text = orderDetails.TotalPrice;

                     // 清空现有的 ListView 项
                     purchaseOrderItemsListView.Items.Clear();

                     // 获取采购订单项
                     var purchaseOrderItems = programMethod.GetPurchaseOrderItems(poID);

                     // 添加新的 ListView 项
                     foreach (var item in purchaseOrderItems)
                     {
                         // 获取产品详细信息
                         var productDetails = programMethod.getProductDetails(item.ProductID);

                         ListViewItem listViewItem = new ListViewItem(new string[]
                         {
                     item.ProductID,
                     productDetails.ProductName,
                     item.OrderQuantity.ToString(),
                     item.UnitPrice.ToString("F2"),
                     item.TotalPrice.ToString("F2")
                         });
                         purchaseOrderItemsListView.Items.Add(listViewItem);
                     }
                 }
                 else
                 {
                     MessageBox.Show("Order details not found.");
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("An error occurred: " + ex.Message);
             }
         }*/



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
            try
            {
                // Collect ProductID, OrderQuantity, UnitPrice, and TotalPrice from ListView
                List<PurchaseOrder> orders = new List<PurchaseOrder>();
                foreach (ListViewItem item in purchaseOrderItemsListView.Items)
                {
                    var newOrder = new PurchaseOrder
                    {
                        SupplierID = supplierBox.SelectedValue.ToString(),
                        Date = DateTime.Now.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture).ToUpper(),
                        Status = "Pending",
                        ProductID = item.SubItems[0].Text,
                        OrderQuantity = item.SubItems[2].Text,
                        UnitPrice = item.SubItems[3].Text,
                        TotalPrice = item.SubItems[4].Text
                    };
                    orders.Add(newOrder);
                }

                string purID = null;
                // Save each PurchaseOrder
                foreach (var order in orders)
                {
                     purID = programMethod.CreatePurchaseOrder(order);
                }

                MessageBox.Show("Purchase Order " + purID +  " Saved Successfully");
                clearForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void quanBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }
        private void UpdateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (ListViewItem item in purchaseOrderItemsListView.Items)
            {
                if (decimal.TryParse(item.SubItems[4].Text, out decimal rowTotal))
                {
                    totalAmount += rowTotal;
                }
            }

            amountDatalbl.Text = totalAmount.ToString("F2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addProductbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(quanBox.Text))
            {
                quantityAlertlbl.Visible = true;
                quanBox.Focus();
                return;
            }

            quantityAlertlbl.Visible = false;

            if (supplierProductBox.SelectedItem != null && int.TryParse(quanBox.Text, out int quantity))
            {
                ProductDetails selectedProduct = (ProductDetails)supplierProductBox.SelectedItem;

                // Convert CostPrice from string to decimal
                if (decimal.TryParse(selectedProduct.CostPrice, out decimal unitPrice))
                {
                    decimal totalPrice = unitPrice * quantity;

                    // Check if the product already exists in the ListView
                    bool productExists = false;
                    foreach (ListViewItem item in purchaseOrderItemsListView.Items)
                    {
                        if (item.SubItems[0].Text == selectedProduct.ProductID)
                        {
                            // Update existing product
                            item.SubItems[2].Text = quantity.ToString();
                            item.SubItems[3].Text = unitPrice.ToString("F2");
                            item.SubItems[4].Text = totalPrice.ToString("F2");
                            productExists = true;
                            break;
                        }
                    }

                    if (!productExists)
                    {
                        // Add new product
                        ListViewItem item = new ListViewItem(selectedProduct.ProductID);
                        //item.SubItems.Add(selectedProduct.ProductID);
                        item.SubItems.Add(selectedProduct.ProductName);
                        item.SubItems.Add(quantity.ToString());
                        item.SubItems.Add(unitPrice.ToString("F2"));
                        item.SubItems.Add(totalPrice.ToString("F2"));

                        purchaseOrderItemsListView.Items.Add(item);
                    }

                    UpdateTotalAmount();
                }
                else
                {
                    MessageBox.Show("Invalid unit price for the selected product.");
                }
            }
        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Control.MousePosition;
            dragFormPoint = this.Location;
        }

        private void Dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Control.MousePosition, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void caculatorbtn_Click(object sender, EventArgs e)
        {

            DataTable dt = programMethod.getOutstandingProductQuantityForPO();
            string text = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                text = text + dt.Rows[i]["SupplierID"].ToString() + " " + dt.Rows[i]["ProductID"].ToString() + " " + dt.Rows[i]["FollowUpQuantity"].ToString() + "\n";
            }


            MessageBox.Show(text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string purID = "";


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i != dt.Rows.Count - 1)
                {
                    if (dt.Rows[i]["SupplierID"].ToString() == dt.Rows[i + 1]["SupplierID"].ToString())
                    {
                        purID = programMethod.CreatePurchaseOrder(purID, dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["FollowUpQuantity"].ToString());
                    }
                    else if (i != 0)
                    {
                        if (dt.Rows[i]["SupplierID"].ToString() == dt.Rows[i - 1]["SupplierID"].ToString())
                        {
                            programMethod.CreatePurchaseOrder(purID, dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["FollowUpQuantity"].ToString());
                            purID = "";
                        }
                        else
                        {
                            programMethod.CreatePurchaseOrder("", dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["FollowUpQuantity"].ToString());
                        }
                         
                    }
                    else
                    {
                        programMethod.CreatePurchaseOrder("", dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["FollowUpQuantity"].ToString());
                    }

                }
                else
                {
                    //Last Time
                    if (dt.Rows[i]["SupplierID"].ToString() == dt.Rows[i - 1]["SupplierID"].ToString() && i != 0)
                    {
                        programMethod.CreatePurchaseOrder(purID, dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["FollowUpQuantity"].ToString());
                        purID = "";

                    }
                }
            } 
        } 
        
        

        private void CreatePurchaseOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
