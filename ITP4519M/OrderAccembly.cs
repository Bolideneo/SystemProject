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
        private OperationMode _mode;



        public OrderAccembly(OperationMode mode)
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
                    SetReadOnly(true);
                    break;
                case OperationMode.New:
                    productOfOrderdata.Columns.Add("ProductID", "Product ID");
                    productOfOrderdata.Columns.Add("ProductName", "Product Name");
                    productOfOrderdata.Columns.Add("Quantity", "Quantity");
                    productOfOrderdata.Columns.Add("UnitPrice", "Unit Price");
                    saveOrderbtn.Visible = false;
                    ClearForm();
                    SetReadOnly(false);
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
            productOfOrderdata.ReadOnly = readOnly;
            disableFunction(readOnly);



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
            this.orderID = orderID;
            this.dealerID = dealerID;



            try
            {
                DataTable orderDetails = programMethod.getOrderDetails(orderID);
                DataTable dealerDetails = programMethod.getOrderDealerName(orderID, dealerID);
                DataTable orderItemDeatails = programMethod.getOrderItemDetails(orderID);




                if (orderDetails != null)
                {
                    this.orderIDBox.Text = orderID;
                    this.dealerIDBox.Text = dealerID;
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
                    this.orderIDBox.Text = orderID;
                    this.dealerIDBox.Text = dealerID;
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
                productOfOrderdata.CellContentDoubleClick -= productOfOrderdata_CellDoubleClick;
            }
            else { productOfOrderdata.CellContentDoubleClick += productOfOrderdata_CellDoubleClick; }
        }



        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void saveOrderbtn_Click(object sender, EventArgs e)
        {

            programMethod.orderDeleteItem(orderID);
            for (int i = 0; i < productOfOrderdata.Rows.Count; i++)
            {
                programMethod.createOrderItem(orderID, productOfOrderdata.Rows[i].Cells[0].Value.ToString(), productOfOrderdata.Rows[i].Cells[2].Value.ToString());
            }
            MessageBox.Show("Order Edit Save");
        }

        private void productOfOrderdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow orderData = this.productOfOrderdata.CurrentRow;
            if (orderData != null && orderData.Index >= 0 && orderData.Index < productOfOrderdata.Rows.Count)
            {
                this.productOfOrderdata.Rows.Remove(orderData);
            }

            //totalpricelbl.Text = "" + programMethod.calProductTotalAmount(productOfOrderdata);
        }
    }
}
