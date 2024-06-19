using Microsoft.VisualBasic.ApplicationServices;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using ProgramMethod;
using System;
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

namespace ITP4519M
{
    public partial class OrderAccembly : Form
    {
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        private string orderID;
        private string dealerID;
        private DataTable dt;
        private DataTable dt1;
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

        private void SalesOrder_Load(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case OperationMode.View:
                    saveOrderbtn.Visible = false;
                    SetReadOnly(true);
                    break;
                case OperationMode.New:
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
                    createOrderAccembly();
                    saveOrderbtn.Visible = true;
                    // ClearForm();
                    //SetReadOnly(false);
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

            dealerIDBox.ReadOnly = readOnly;
            dealerNameBox.ReadOnly = readOnly;
            dealerCompanyBox.ReadOnly = readOnly;
            phoneNumBox.ReadOnly = readOnly;
            orderItemdata.ReadOnly = readOnly;
            disableFunction(readOnly);



            dealerIDBox.Enabled = !readOnly;
            dealerNameBox.Enabled = !readOnly;
            dealerCompanyBox.Enabled = !readOnly;
            phoneNumBox.Enabled = !readOnly;


        }

        private void orderIDBox_TextChanged(object sender, EventArgs e)
        {

        }


        public void orderView(string orderID)
        {

            //try
            //{
            //    DataTable orderDetails = programMethod.getOrderDetails(orderID);
            //    DataTable dealerDetails = programMethod.getOrderDealerName(orderID, dealerID);
            //    DataTable orderItemDeatails = programMethod.getOrderItemDetails(orderID);




            //    if (orderDetails != null)
            //    {
            //        this.orderIDBox.Text = orderID;
            //        this.dealerIDBox.Text = dealerID;
            //        this.dealerNameBox.Text = dealerDetails.Rows[0]["DealerName"].ToString();
            //        this.phoneNumBox.Text = dealerDetails.Rows[0]["DealerPhoneNum"].ToString();
            //        this.dealerCompanyBox.Text = dealerDetails.Rows[0]["DealerCompanyName"].ToString();
            //        orderItemdata.DataSource = orderItemDeatails;

            //    }
            //    else
            //    {
            //        MessageBox.Show("User details not found.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        public void createOrderAccembly()
        {



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


        private void productSearchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productSearchbox_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Question

            //totalpricelbl.Text = "" +  programMethod.calProductTotalAmount(productOfOrderdata);

        }

        //private void productSearchbox_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {

        //        if (programMethod.getValidProduct(productSearchbox.Text.Trim()))
        //        {

        //            for (int i = 0; i < productOfOrderdata.Rows.Count; i++)
        //            {

        //                if (productOfOrderdata.Rows[i].Cells[0].Value.ToString() == productSearchbox.Text.Trim() || productOfOrderdata.Rows[i].Cells[1].Value.ToString() == productSearchbox.Text.Trim())
        //                {
        //                    productSearchbox.Text = "";
        //                    MessageBox.Show("Product is Added");
        //                    return;
        //                }
        //                if (int.Parse(productOfOrderdata.Rows[i].Cells[2].Value.ToString()) == 0)
        //                {
        //                    productSearchbox.Text = "";
        //                    MessageBox.Show("Please Add One quantity");
        //                    return;
        //                }
        //            }
        //            DataTable result = programMethod.searchOrderItemDetail(productSearchbox.Text.Trim());
        //            this.productOfOrderdata.Rows.Add(result.Rows[0]["ProductID"].ToString(), result.Rows[0]["ProductName"].ToString(), 0, result.Rows[0]["UnitPrice"]);
        //            productSearchbox.Text = "";
        //        }
        //    }
        //}



        private void disableFunction(bool readOnly)
        {
            if (readOnly)
            {
                orderItemdata.CellContentDoubleClick -= productOfOrderdata_CellDoubleClick;
            }
            else { orderItemdata.CellContentDoubleClick += productOfOrderdata_CellDoubleClick; }
        }



        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void saveOrderbtn_Click(object sender, EventArgs e)
        {
            if (programMethod.createOrderAsswmbly(orderItemdata, orderAccemblyOrderItemdata, orderID))
            {
                MessageBox.Show("Save");
                this.Close();
            }


        }

        private void productOfOrderdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow orderData = this.orderItemdata.CurrentRow;
            if (orderData != null && orderData.Index >= 0 && orderData.Index < orderItemdata.Rows.Count)
            {
                this.orderItemdata.Rows.Remove(orderData);
            }
        }

        private void orderAccemblyAssignbtn_Click(object sender, EventArgs e)
        {
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
              //  programMethod.ReduceStock(orderAccemblyAssignbox.Text.Trim(), "1");
                orderAccemblyOrderItemdata.DataSource = programMethod.getOrderItemDetail(orderID);
                //this.orderItemdata.Rows.Add(result.Rows[0]["ProductID"].ToString(), result.Rows[0]["ProductName"].ToString(), 0, result.Rows[0]["OrderedQuantity"]);
                this.orderItemdata.Rows.Add(result.Rows[0]["ProductID"].ToString(), result.Rows[0]["ProductName"].ToString(), 0, 0);
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
                MessageBox.Show("Item Not contain in order");
            }
        }

        private void phoneNumBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
