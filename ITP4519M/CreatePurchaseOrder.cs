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
using System.Windows.Forms.DataVisualization.Charting;
using static ITP4519M.DataBaseMethod;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using static ProgramMethod.ProgramMethod;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ITP4519M
{
    public partial class CreatePurchaseOrder : Form
    {
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        private string poID;
        private OperationMode _mode;
        public event EventHandler OperationCompleted;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private DataTable dt;


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
                if (purchaseOrderItemsListView.Items.Count <= 0)
                {
                    errorlbl1.Visible = true;
                    return;
                }
                else
                {
                    errorlbl1.Visible = false;
                }

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

                MessageBox.Show("Purchase Order " + purID + " Saved Successfully");
                OperationCompleted?.Invoke(sender, e);
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
            
            panel1.Visible = true;
            POCaculatorbtn.Visible = true;
            errorlbl1.Visible = false;
            polbl2.Visible = true;
            dt = programMethod.getOutstandingProductQuantityForPO();
            POProductData.DataSource = dt;
            Font boldFont = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poalertlbl.Visible = true ;
            foreach (DataGridViewRow row in POProductData.Rows)
            {
                row.Cells["PO_Quantity"].Style.Font = boldFont;
                DataGridViewCell QuantityCell = row.Cells["FollowUpQuantity"];
                string qty = QuantityCell.Value?.ToString();
                DataGridViewCell QISCell = row.Cells["QuantityInStock"];
                string QIS = QISCell.Value?.ToString();
                DataGridViewCell ReOrderCell = row.Cells["ReOrderQty"];
                DataGridViewCell POQuantityCell = row.Cells["PO_Quantity"];

                string reOrderQty = ReOrderCell.Value?.ToString();
                double result = double.Parse(reOrderQty) * 0.001;
                int resultInt = (int)result;
                if(resultInt >= 0 && resultInt <= 1)
                {
                    resultInt = 1;
                }
                
                if( int.Parse(QIS) >= int.Parse(reOrderQty) - resultInt && int.Parse(QIS) < int.Parse(reOrderQty))
                {
                    QuantityCell.Style.ForeColor = Color.Blue;
                    QuantityCell.Style.Font = boldFont;
                    POQuantityCell.Style.ForeColor = Color.Blue;
                    POQuantityCell.Style.Font = boldFont;
                    continue;
                }


                if (qty != null)
                {
                    switch (qty)
                    {
                        case "0":
                            QuantityCell.Style.ForeColor = Color.Red;
                            QuantityCell.Style.Font = boldFont;
                            POQuantityCell.Style.ForeColor = Color.Red;
                            POQuantityCell.Style.Font = boldFont;
                            break;
                        default:
                            break;
                    }
                }

            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (keyData == Keys.Enter)
                {
                    if (this.POProductData.ContainsFocus)
                    {
                        this.POProductData.EndEdit();
                        this.POProductData.CurrentRow.Cells["PO_Quantity"].Value = int.Parse(this.POProductData.CurrentRow.Cells["PO_Quantity"].Value.ToString()) + int.Parse(this.POProductData.CurrentRow.Cells["FollowUpQuantity"].Value.ToString());
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                //   POProductData.CurrentRow.Cells["FollowUpQuantity"].Style.ForeColor = Color.Black;
                errorlbl.Visible = true;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void CreatePurchaseOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void POCaculatorbtn_Click(object sender, EventArgs e)
        {
            string purID = "";
            string FirstAndLastID = "";
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (i != dt.Rows.Count - 1)
            //    {
            //        if(i != 0)
            //        {
            //            if (dt.Rows[i]["SupplierID"].ToString() == dt.Rows[i + 1]["SupplierID"].ToString())
            //            {
            //                purID = programMethod.CreatePurchaseOrder(purID, dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["Total"].ToString());
            //            }
            //            else
            //            {
            //                programMethod.CreatePurchaseOrder("", dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["Total"].ToString());
            //            }

            //        }
            //        else
            //        {
            //            if (dt.Rows[i]["SupplierID"].ToString() == dt.Rows[i + 1]["SupplierID"].ToString())
            //            {
            //                purID = programMethod.CreatePurchaseOrder(purID, dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["Total"].ToString());
            //                FirstAndLastID = purID;

            //            }
            //            else 
            //            {
            //                FirstAndLastID = programMethod.CreatePurchaseOrder("", dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["Total"].ToString());
            //            }
            //        }

            //    }
            //    else
            //    {
            //        //Last Time
            //        if (dt.Rows[i]["SupplierID"].ToString() == dt.Rows[i - 1]["SupplierID"].ToString())
            //        {
            //            FirstAndLastID = FirstAndLastID + " To " + programMethod.CreatePurchaseOrder(purID, dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["Total"].ToString());
            //           // purID = "";


            //        }
            //        else
            //        {
            //            FirstAndLastID = FirstAndLastID + " To " + programMethod.CreatePurchaseOrder("", dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["Total"].ToString());
            //        }
            //    }
            //}

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i != dt.Rows.Count - 1)
                {
                    if (dt.Rows[i]["SupplierID"].ToString() == dt.Rows[i + 1]["SupplierID"].ToString())
                    {
                        purID = programMethod.CreatePurchaseOrder(purID, dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["PO_Quantity"].ToString());

                    }
                    else if (i != 0)
                    {
                        if (dt.Rows[i]["SupplierID"].ToString() == dt.Rows[i - 1]["SupplierID"].ToString())
                        {
                            programMethod.CreatePurchaseOrder(purID, dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["PO_Quantity"].ToString());
                            purID = "";
                        }
                        else
                        {
                            programMethod.CreatePurchaseOrder("", dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["PO_Quantity"].ToString());
                        }

                    }
                    else
                    {
                        FirstAndLastID = programMethod.CreatePurchaseOrder("", dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["PO_Quantity"].ToString());

                    }

                }
                else
                {
                    //Last Time
                    if (dt.Rows[i]["SupplierID"].ToString() == dt.Rows[i - 1]["SupplierID"].ToString())
                    {
                        FirstAndLastID = FirstAndLastID + " To " + programMethod.CreatePurchaseOrder(purID, dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["PO_Quantity"].ToString());
                        // purID = "";
                    }
                    else
                    {
                        FirstAndLastID = FirstAndLastID + " To " + programMethod.CreatePurchaseOrder("", dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["PO_Quantity"].ToString());
                    }
                }
            }
            MessageBox.Show("Purchase Order Sucessfully Created # " + FirstAndLastID);
        }

        private void POProductData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (int.Parse(POProductData.Rows[e.RowIndex].Cells[5].Value.ToString()) < 0)
                {
                    Font boldFont = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);

                    POProductData.Rows[e.RowIndex].Cells[5].Style.ForeColor = Color.Red;
                    errorlbl.Visible = true;
                    return;

                }
                else
                {
                    POProductData.Rows[e.RowIndex].Cells[5].Style.ForeColor = Color.Black;
                    errorlbl.Visible = false;
                }

            }
            catch (Exception ex)
            {
                POProductData.Rows[e.RowIndex].Cells[5].Style.ForeColor = Color.Red;
                errorlbl.Visible = true;
            }
        }

        private void POProductData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (POProductData.Columns[e.ColumnIndex].Name != "FollowUpQuantity")
            {
                POProductData.Columns[e.ColumnIndex].ReadOnly = true;
            }
        }

        private void POProductData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Data = this.POProductData.CurrentRow;
            if (Data != null && Data.Index >= 0 && Data.Index < POProductData.Rows.Count)
            {
                this.POProductData.Rows.Remove(Data);
            }
            dt.AcceptChanges();
            Font boldFont = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foreach (DataGridViewRow row in POProductData.Rows)
            {
                row.Cells["PO_Quantity"].Style.Font = boldFont;
                DataGridViewCell QuantityCell = row.Cells["FollowUpQuantity"];
                string qty = QuantityCell.Value?.ToString();
                DataGridViewCell QISCell = row.Cells["QuantityInStock"];
                string QIS = QISCell.Value?.ToString();
                DataGridViewCell ReOrderCell = row.Cells["ReOrderQty"];
                DataGridViewCell POQuantityCell = row.Cells["PO_Quantity"];

                string reOrderQty = ReOrderCell.Value?.ToString();
                double result = double.Parse(reOrderQty) * 0.001;
                int resultInt = (int)result;
                if (resultInt >= 0 && resultInt <= 1)
                {
                    resultInt = 1;
                }

                if (int.Parse(QIS) >= int.Parse(reOrderQty) - resultInt && int.Parse(QIS) < int.Parse(reOrderQty))
                {
                    QuantityCell.Style.ForeColor = Color.Blue;
                    QuantityCell.Style.Font = boldFont;
                    POQuantityCell.Style.ForeColor = Color.Blue;
                    POQuantityCell.Style.Font = boldFont;
                    continue;
                }


                if (qty != null)
                {
                    switch (qty)
                    {
                        case "0":
                            QuantityCell.Style.ForeColor = Color.Red;
                            QuantityCell.Style.Font = boldFont;
                            POQuantityCell.Style.ForeColor = Color.Red;
                            POQuantityCell.Style.Font = boldFont;
                            break;
                        default:
                            break;
                    }
                }

            }
            SetRowHeights(POProductData, 12);


        }

        private void pobackbtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            poalertlbl.Visible = false;
            POCaculatorbtn.Visible = false;
            polbl2.Visible = false;
        }

        private void POProductData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            POProductData.Columns[1].Width = 70;
            POProductData.Columns[3].Width = 120;
            POProductData.Columns[5].Width = 120;
            SetRowHeights(POProductData,12);
            if (POProductData.Rows.Count > 0)
            {
                POProductData.Rows[0].Selected = false;
            }
        }

        public void SetRowHeights(DataGridView Data, int pageSize)
        {
            foreach (DataGridViewRow row in Data.Rows)
            {
                row.Height = (Data.ClientRectangle.Height - Data.ColumnHeadersHeight) / pageSize;
            }
        }
    }
}
