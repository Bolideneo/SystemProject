﻿using Microsoft.VisualBasic.ApplicationServices;
using Mysqlx.Crud;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using ProgramMethod;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4519M
{
    public partial class OrderAccembly : Form
    {
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        private string orderID;
        private string dealerID;
        private DataTable dt;
        private DataTable dt1;
        private bool isReadOnly;
        private string QuantityFollow;
        private int orderitemIndex = -1;
        private int SelectColumnIndex = 0;
        private OperationMode _mode;



        public OrderAccembly(OperationMode mode, string orderID, string dealerID)
        {
            InitializeComponent();
            _mode = mode;
            this.orderID = orderID;
            this.dealerID = dealerID;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderAccembly_Load(object sender, EventArgs e)
        {

            // Define the points in the polygonal path for a downward arrow with reduced width and height.
            Point[] pts = {
        new Point(30, 10),  // Top left corner
        new Point(70, 10),  // Top right corner
        new Point(70, 40),  // Right point of the arrow's base
        new Point(90, 40),  // Right point of the arrow's head
        new Point(50, 90),  // Bottom point of the arrow
        new Point(10, 40),  // Left point of the arrow's head
        new Point(30, 40)   // Left point of the arrow's base
    };

            // Make the GraphicsPath.
            GraphicsPath polygon_path = new GraphicsPath(FillMode.Winding);
            polygon_path.AddPolygon(pts);

            // Convert the GraphicsPath into a Region.
            Region polygon_region = new Region(polygon_path);

            // Constrain the button to the region.
            checkboxSelectedbtn.Region = polygon_region;

            // Make the button big enough to hold the whole region.
            checkboxSelectedbtn.SetBounds(
            checkboxSelectedbtn.Location.X,
            checkboxSelectedbtn.Location.Y,
                pts[3].X + 5, // Width based on the rightmost point
                pts[4].Y + 5  // Height based on the lowest point
            );

            switch (_mode)
            {
                case OperationMode.View:
                    isReadOnly = true;
                    SetReadOnly(isReadOnly);
                    disableFunction(isReadOnly);
                    orderAccemblyOrderItemdata.Columns["check"].Visible = false;
                    orderIDBox.Text = orderID;
                    dealerIDBox.Text = dealerID;
                    dt1 = programMethod.getOrderDealerName(orderID, dealerID);
                    dealerNameBox.Text = dt1.Rows[0]["DealerName"].ToString();
                    phoneNumBox.Text = dt1.Rows[0]["DealerPhoneNum"].ToString();
                    dealerCompanyBox.Text = dt1.Rows[0]["DealerCompanyName"].ToString();
                    orderAccemblyOrderItemdata.DataSource = programMethod.getOrderItemDetailsForOrderAccembly(orderID);
                    orderItemdata.DataSource = programMethod.getOrderItemDetailsForAcutalDespatch(orderID);
                    break;
                case OperationMode.New:
                    isReadOnly = false;
                    SetReadOnly(true);
                    disableFunction(false);
                    programMethod.productSearchAutoComplete(orderAccemblyAssignbox, orderID);
                    checkboxSelectedbtn.Visible = true;
                    orderAccemblyAssignbox.Visible = true;
                    orderAccemblyAssignbtn.Visible = true;
                    orderAccemblyOrderItemdata.ReadOnly = false;
                    orderItemdata.ReadOnly = false;
                    orderAccemblyOrderItemdata.Columns["check"].Visible = true;
                    saveOrderbtn.Visible = true;
                    dt = programMethod.getOrderDetails(orderID);
                    dt1 = programMethod.getOrderDealerName(orderID, dealerID);
                    orderIDBox.Text = orderID;
                    dealerIDBox.Text = dealerID;
                    dealerNameBox.Text = dt1.Rows[0]["DealerName"].ToString();
                    phoneNumBox.Text = dt1.Rows[0]["DealerPhoneNum"].ToString();
                    dealerCompanyBox.Text = dt1.Rows[0]["DealerCompanyName"].ToString();
                    orderAccemblyOrderItemdata.DataSource = programMethod.getOrderItemDetailsForOrderAccembly(orderID);
                    //dealerAddressBox.Text = dt1.Rows[0]["DealerRegionNum"].ToString();
                    orderItemdata.Columns.Add("ProductID", "Product ID");
                    orderItemdata.Columns.Add("ProductName", "Product Name");
                    orderItemdata.Columns.Add("Quantity", "Quantity");
                    orderItemdata.Columns.Add("FollowQuantity", "FollowQuantity");
                    orderAccemblyOrderItemdata.Rows[0].Selected = false;
                    // ClearForm();
                    break;
                case OperationMode.Edit:
                    // SetReadOnly(true);
                    break;


            }
        }

        private void ClearForm()
        {

            orderIDBox.Text = string.Empty;
            dealerIDBox.Text = string.Empty;
            dealerNameBox.Text = string.Empty;
            dealerCompanyBox.Text = string.Empty;
            phoneNumBox.Text = string.Empty;

        }

        private void SetReadOnly(bool readOnly)
        {

            orderIDBox.ReadOnly = readOnly;
            dealerIDBox.ReadOnly = readOnly;
            dealerNameBox.ReadOnly = readOnly;
            phoneNumBox.ReadOnly = readOnly;
            dealerCompanyBox.ReadOnly = readOnly;
            dealerAddressBox.ReadOnly = readOnly;
            orderAccemblyOrderItemdata.ReadOnly = readOnly;
            orderItemdata.ReadOnly = readOnly;
            saveOrderbtn.Visible = !readOnly;
            checkboxSelectedbtn.Visible = !readOnly;
            orderAccemblyAssignbox.Visible = !readOnly;
            orderAccemblyAssignbtn.Visible = !readOnly;
        }


        private void dealerIDBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                if (programMethod.searchDealerID(dealerIDBox.Text.Trim()))
                {
                    DataTable result = programMethod.searchDealerDetail(dealerIDBox.Text.Trim());
                    dealerNameBox.Text = result.Rows[0]["DealerName"].ToString();
                    phoneNumBox.Text = result.Rows[0]["DealerPhoneNum"].ToString();
                    dealerCompanyBox.Text = result.Rows[0]["DealerCompanyName"].ToString();
                }
                else
                {
                    dealerNameBox.Text = "";
                    phoneNumBox.Text = "";
                    dealerCompanyBox.Text = "";

                }
            }
        }


        private void disableFunction(bool readOnly)
        {
            if (readOnly)
            {
                orderItemdata.RowsAdded -= orderItemdata_RowsAdded;
                orderItemdata.CellContentDoubleClick -= productOfOrderdata_CellDoubleClick;
                orderAccemblyOrderItemdata.CellContentDoubleClick -= orderAccemblyOrderItemdata_CellDoubleClick;
            }
            else
            {
                orderItemdata.CellContentDoubleClick += productOfOrderdata_CellDoubleClick;
                orderItemdata.RowsAdded += orderItemdata_RowsAdded;
                orderAccemblyOrderItemdata.CellContentDoubleClick += orderAccemblyOrderItemdata_CellDoubleClick;
            }
        }



        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void saveOrderbtn_Click(object sender, EventArgs e)
        {
            if (programMethod.createOrderAssembly(orderItemdata, orderAccemblyOrderItemdata, orderID))
            {
                MessageBox.Show("Save");
                this.Close();
            }


        }

        private void productOfOrderdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (isReadOnly)
            {
                return;
            }
            DataGridViewRow orderData = this.orderItemdata.CurrentRow;
            if (orderData != null && orderData.Index >= 0 && orderData.Index < orderItemdata.Rows.Count)
            {
                this.orderItemdata.Rows.Remove(orderData);
            }
            orderitemIndex--;
        }

        private void orderAccemblyAssignbtn_Click(object sender, EventArgs e)
        {
            orderitemIndex++;
            if (programMethod.searchOrderEachItemDetail(orderAccemblyAssignbox.Text.Trim(), orderID))
            {
                for (int i = 0; i < orderItemdata.Rows.Count; i++)
                {
                    if (orderItemdata.Rows[i].Cells[0].Value.ToString() == orderAccemblyAssignbox.Text.Trim() && (int.Parse(orderItemdata.Rows[i].Cells[3].Value.ToString())) < 1)
                    {
                        MessageBox.Show(orderAccemblyAssignbox.Text.Trim() + " is Out-Of-Stock");
                        return;
                    }
                }
                DataTable result = programMethod.getOrderEachItemDetail(orderAccemblyAssignbox.Text.Trim(), orderID);
                orderAccemblyOrderItemdata.DataSource = programMethod.getOrderItemDetail(orderID);
                this.orderItemdata.Rows.Add(result.Rows[0]["ProductID"].ToString(), result.Rows[0]["ProductName"].ToString(), 0, QuantityFollow);


                if (orderItemdata.Rows.Count > 1)
                {
                    for (int i = 0; i < orderItemdata.Rows.Count; i++)
                    {
                        int count = 0;
                        for (int j = 1; j < orderItemdata.Rows.Count; j++)
                        {

                            if (i == j)
                                continue;
                            if (orderItemdata.Rows[i].Cells[0].Value.ToString() == orderItemdata.Rows[j].Cells[0].Value.ToString())
                            {
                                DataGridViewRow dgvDelRow = orderItemdata.Rows[j];
                                orderItemdata.Rows.Remove(dgvDelRow);
                                count++;
                            }

                        }
                        orderItemdata.Rows[i].Cells[2].Value = (int.Parse(orderItemdata.Rows[i].Cells[2].Value.ToString()) + count);
                    }
                }
                orderAccemblyAssignbox.Text = "";
            }
            else
            {
                MessageBox.Show("Proudct not contain in order");
            }
        }

        private void phoneNumBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void orderItemdata_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                QuantityFollow = programMethod.calOrderItemQuantityFollow(orderItemdata, orderID);
                orderItemdata["FollowQuantity", e.RowIndex].Value = QuantityFollow;
                QuantityFollow = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void orderItemdata_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //int.Parse(orderItemdata["FollowQuantity", e.RowIndex].Value.ToString());
            int quantityFollow = int.Parse(programMethod.getOrderItemFollowQuantity(orderID, orderItemdata.Rows[e.RowIndex].Cells[0].Value.ToString()));
            int result = quantityFollow - int.Parse(orderItemdata.Rows[e.RowIndex].Cells[2].Value.ToString());
            orderItemdata.Rows[e.RowIndex].Cells[3].Value = result.ToString();
        }

        private void orderAccemblyOrderItemdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else if (isReadOnly)
            {
                return;
            }
            orderitemIndex++;
            DataTable result = programMethod.getOrderEachItemDetail(orderAccemblyOrderItemdata.Rows[e.RowIndex].Cells[1].Value.ToString(), orderID);
            orderAccemblyOrderItemdata.DataSource = programMethod.getOrderItemDetail(orderID);
            this.orderItemdata.Rows.Add(result.Rows[0]["ProductID"].ToString(), result.Rows[0]["ProductName"].ToString(), 0, QuantityFollow);

        }

        private void checkboxSelectedbtn_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < orderAccemblyOrderItemdata.Rows.Count; i++)
            {
                // Refresh cause uncheck box
                if (orderAccemblyOrderItemdata.Rows[i].Cells[0].Value != null && Convert.ToBoolean(orderAccemblyOrderItemdata.Rows[i].Cells[0].Value) == true)
                {

                    orderitemIndex++;
                    DataTable result = programMethod.getOrderEachItemDetail(orderAccemblyOrderItemdata.Rows[i].Cells[1].Value.ToString(), orderID);
                    orderItemdata.Rows.Add(result.Rows[0]["ProductID"].ToString(), result.Rows[0]["ProductName"].ToString(), 0, QuantityFollow);
                }
            }

            orderAccemblyOrderItemdata.DataSource = programMethod.getOrderItemDetail(orderID);
            orderAccemblyOrderItemdata.Rows[0].Selected = false;

            if (orderItemdata.Rows.Count > 1)
            {
                for (int i = 0; i < orderItemdata.Rows.Count; i++)
                {
                    int count = 0;
                    for (int j = 1; j < orderItemdata.Rows.Count; j++)
                    {
                        //  MessageBox.Show(j.ToString());
                        if (i == j)
                            continue;
                        if (orderItemdata.Rows[i].Cells[0].Value.ToString() == orderItemdata.Rows[j].Cells[0].Value.ToString())
                        {
                            DataGridViewRow dgvDelRow = orderItemdata.Rows[j];
                            orderItemdata.Rows.Remove(dgvDelRow);
                            count++;
                        }

                    }
                    //orderItemdata.Rows[i].Cells[2].Value = (int.Parse(orderItemdata.Rows[i].Cells[2].Value.ToString()) + count);
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
