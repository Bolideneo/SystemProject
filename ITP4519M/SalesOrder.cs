﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using ProgramMethod;

namespace ITP4519M
{
    public partial class SalesOrder : Form
    {
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        private string orderID;
        private string dealerID;
        private bool modifyProduct;
        private OperationMode _mode;



        public SalesOrder(OperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesOrder_Load(object sender, EventArgs e)
        {


            switch (_mode)
            {
                case OperationMode.View:
                    saveOrderbtn.Visible = false;
                    label6.Visible = false;
                    label9.Visible = false;
                    SetReadOnly(true);
                    break;
                case OperationMode.New:
                    productOfOrderdata.Columns.Add("ProductID", "Product ID");
                    productOfOrderdata.Columns.Add("ProductName", "Product Name");
                    productOfOrderdata.Columns.Add("Quantity", "Quantity");
                    productOfOrderdata.Columns.Add("UnitPrice", "Unit Price");
                    productOfOrderdata.Columns.Add("Discount", "Discount (%)");
                    saveOrderbtn.Visible = false;
                    ClearForm();
                    SetReadOnly(false);
                    break;
                case OperationMode.Edit:
                    // SetReadOnly(true);
                    if (programMethod.getOrderStatus(orderID) == "OrderProcessing")
                    {
                        modifyProduct = true;
                    }
                    else
                    {
                        productSearchbox.Visible = false;
                        modifyProduct = false;
                    }
                    break;
            }
        }

        private void ClearForm()
        {

            goodsAddressBox.Text = string.Empty;
            invoiceAddressBox.Text = string.Empty;
            orderCompleteDateBox.Text = string.Empty;
            dealerIDBox.Text = string.Empty;
            dealerNameBox.Text = string.Empty;
            dealerCompanyBox.Text = string.Empty;
            phoneNumBox.Text = string.Empty;

        }

        private void SetReadOnly(bool readOnly)
        {

            goodsAddressBox.ReadOnly = readOnly;
            invoiceAddressBox.ReadOnly = readOnly;
            orderCompleteDateBox.ReadOnly = readOnly;
            dealerIDBox.ReadOnly = readOnly;
            dealerNameBox.ReadOnly = readOnly;
            dealerCompanyBox.ReadOnly = readOnly;
            phoneNumBox.ReadOnly = readOnly;
            productOfOrderdata.ReadOnly = readOnly;
            disableFunction(readOnly);




            goodsAddressBox.Enabled = !readOnly;
            invoiceAddressBox.Enabled = !readOnly;
            orderCompleteDateBox.Enabled = !readOnly;
            dealerIDBox.Enabled = !readOnly;
            dealerNameBox.Enabled = !readOnly;
            dealerCompanyBox.Enabled = !readOnly;
            phoneNumBox.Enabled = !readOnly;


        }

        private void orderIDBox_TextChanged(object sender, EventArgs e)
        {

        }


        public void orderView(string orderID, string dealerID)
        {
            this.productSearchbox.Visible = false;
            this.orderID = orderID;
            this.dealerID = dealerID;



            try
            {
                DataTable orderDetails = programMethod.getOrderDetails(orderID);
                DataTable dealerDetails = programMethod.getOrderDealerName(orderID, dealerID);
                DataTable orderItemDeatails = programMethod.getOrderItemDetails(orderID);




                if (orderDetails != null)
                {
                    //this.orderIDBox.Text = orderID;
                    orderLabel.Text = "Order #" + orderID;
                    orderStatusLabel.Text = "Placed on " + orderDetails.Rows[0]["OrderDate"].ToString();
                    this.dealerIDBox.Text = dealerID;
                    //this.orderDateBox.Text = orderDetails.Rows[0]["OrderDate"].ToString();
                    //this.orderStatusBox.Text = orderDetails.Rows[0]["OrderStatus"].ToString();
                    this.orderStatuslbl.Text = orderDetails.Rows[0]["OrderStatus"].ToString();
                    this.dealerNameBox.Text = dealerDetails.Rows[0]["DealerName"].ToString();
                    this.phoneNumBox.Text = dealerDetails.Rows[0]["DealerPhoneNum"].ToString();
                    this.dealerCompanyBox.Text = dealerDetails.Rows[0]["DealerCompanyName"].ToString();
                    productOfOrderdata.DataSource = orderItemDeatails;

                }
                else
                {
                    MessageBox.Show("User details not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void orderEdit(string orderID, string dealerID)
        {

            this.orderID = orderID;



            try
            {
                DataTable orderDetails = programMethod.getOrderDetails(orderID);
                DataTable dealerDetails = programMethod.getOrderDealerName(orderID, dealerID);
                DataTable orderItemDeatails = programMethod.getOrderItemDetails(orderID);


                if (orderDetails != null)
                {
                    this.dealerIDBox.Text = dealerID;
                    this.orderLabel.Text = "Order #" + orderID;
                    this.orderStatusLabel.Text = "Placed on " + orderDetails.Rows[0]["OrderDate"].ToString();
                    this.orderStatuslbl.Text = orderDetails.Rows[0]["OrderStatus"].ToString();
                    this.dealerNameBox.Text = dealerDetails.Rows[0]["DealerName"].ToString();
                    this.phoneNumBox.Text = dealerDetails.Rows[0]["DealerPhoneNum"].ToString();
                    this.dealerCompanyBox.Text = dealerDetails.Rows[0]["DealerCompanyName"].ToString();
                    productOfOrderdata.DataSource = orderItemDeatails;

                }
                else
                {
                    MessageBox.Show("User details not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                    goodsAddressBox.Text = result.Rows[0]["DealerRegionNum"].ToString();
                }
                else
                {
                    dealerNameBox.Text = "";
                    phoneNumBox.Text = "";
                    dealerCompanyBox.Text = "";
                    goodsAddressBox.Text = "";

                }
            }
        }


        private void productSearchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productSearchbox_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Question

            //totalpricelbl.Text = "" +  programMethod.calProductTotalAmount(productOfOrderdata);

        }

        private void productSearchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (modifyProduct)
                {
                    if (programMethod.getValidProduct(productSearchbox.Text.Trim()))
                    {

                        for (int i = 0; i < productOfOrderdata.Rows.Count; i++)
                        {

                            if (productOfOrderdata.Rows[i].Cells[0].Value.ToString() == productSearchbox.Text.Trim() || productOfOrderdata.Rows[i].Cells[1].Value.ToString() == productSearchbox.Text.Trim())
                            {
                                productSearchbox.Text = "";
                                MessageBox.Show("Product is Added");
                                return;
                            }
                            if (int.Parse(productOfOrderdata.Rows[i].Cells[2].Value.ToString()) == 0)
                            {
                                productSearchbox.Text = "";
                                MessageBox.Show("Please Add One quantity");
                                return;
                            }
                        }
                        DataTable result = programMethod.searchOrderItemDetail(productSearchbox.Text.Trim());
                        DataTable dt = productOfOrderdata.DataSource as DataTable;
                        dt.Rows.Add(result.Rows[0]["ProductID"].ToString(), result.Rows[0]["ProductName"].ToString(), 0, result.Rows[0]["UnitPrice"]);
                        productOfOrderdata.DataSource = dt;
                        //this.productOfOrderdata.Rows.Add(result.Rows[0]["ProductID"].ToString(), result.Rows[0]["ProductName"].ToString(), 0, result.Rows[0]["UnitPrice"]);




                        productSearchbox.Text = "";
                    }

                }
            }
        }




        private void disableFunction(bool readOnly)
        {
            if (readOnly)
            {
                productOfOrderdata.CellContentDoubleClick -= productOfOrderdata_CellDoubleClick;
            }
            else { productOfOrderdata.CellContentDoubleClick += productOfOrderdata_CellDoubleClick; }
        }



        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void saveOrderbtn_Click(object sender, EventArgs e)
        {

            // programMethod.orderDeleteItem(orderID);
            for (int i = 0; i < productOfOrderdata.Rows.Count; i++)
            {
              //  programMethod.createOrderItem(orderID, productOfOrderdata.Rows[i].Cells[0].Value.ToString(), productOfOrderdata.Rows[i].Cells[2].Value.ToString());
            }
            MessageBox.Show("Order Edit Save");
        }

        private void productOfOrderdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modifyProduct)
            {
                DataGridViewRow orderData = this.productOfOrderdata.CurrentRow;
                if (orderData != null && orderData.Index >= 0 && orderData.Index < productOfOrderdata.Rows.Count)
                {
                    this.productOfOrderdata.Rows.Remove(orderData);
                }

                //totalpricelbl.Text = "" + programMethod.calProductTotalAmount(productOfOrderdata)
            }

        }

        private void orderCompleteDateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
