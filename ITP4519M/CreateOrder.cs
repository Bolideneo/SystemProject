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
    public partial class CreateOrder : Form
    {
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        private string orderID;
        private string dealerID;
        private OperationMode _mode;



        public CreateOrder(OperationMode mode)
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
                    createOrderbtn.Visible = false;
                    SetReadOnly(true);
                    break;
                case OperationMode.New:
                    orderDateBox.MinDate = DateTime.Today;
                    orderDateBox.MaxDate = DateTime.Today;
                    productOfOrderdata.Columns.Add("ProductID", "Product ID");
                    productOfOrderdata.Columns.Add("ProductName", "Product Name");
                    productOfOrderdata.Columns.Add("Quantity", "Quantity");
                    productOfOrderdata.Columns.Add("UnitPrice", "Unit Price");
                    createOrderbtn.Visible = true;
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

            goodsAddressBox.Text = string.Empty;
            orderDateBox.Text = string.Empty;
            dealerIDBox.Text = string.Empty;
            dealerNameBox.Text = string.Empty;
            dealerCompanyBox.Text = string.Empty;
            phoneNumBox.Text = string.Empty;
            productOfOrderdata.Rows.Clear();
        }

        private void SetReadOnly(bool readOnly)
        {

            goodsAddressBox.ReadOnly = readOnly;
            dealerIDBox.ReadOnly = readOnly;
            dealerNameBox.ReadOnly = readOnly;
            dealerCompanyBox.ReadOnly = readOnly;
            phoneNumBox.ReadOnly = readOnly;
            productOfOrderdata.ReadOnly = readOnly;
            disableFunction(readOnly);




            goodsAddressBox.Enabled = !readOnly;
            orderDateBox.Enabled = !readOnly;
            dealerIDBox.Enabled = !readOnly;
            dealerNameBox.Enabled = !readOnly;
            dealerCompanyBox.Enabled = !readOnly;
            phoneNumBox.Enabled = !readOnly;


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
                    this.productOfOrderdata.Rows.Add(result.Rows[0]["ProductID"].ToString(), result.Rows[0]["ProductName"].ToString(), 0, result.Rows[0]["UnitPrice"]);
                    productSearchbox.Text = "";
                }
            }
        }

        private void createOrderbtn_Click(object sender, EventArgs e)
        {
            if (dealerIDBox.Text == "")
                MessageBox.Show("Please input Dealer ID");
            else if (dealerNameBox.Text == "")
            {
                MessageBox.Show("Please input Dealer Name");
            }
            //else if (productSearchbox.Text == "")
            //{
            //    MessageBox.Show("Please Input Product ID ");
            //}

            if (productOfOrderdata.RowCount == 0)
            {
                MessageBox.Show("Please Select atleast one product");
            }


            List<bool> checkList = new List<bool>();

            for (int i = 0; i < productOfOrderdata.Rows.Count; i++)
            {
                int quantity = Convert.ToInt32(productOfOrderdata.Rows[i].Cells[2].Value);

                bool isGreaterThanZero = (quantity > 0);
                checkList.Add(isGreaterThanZero);
            }

            if (checkList.Contains(false))
            {
                MessageBox.Show("Product quantity should not be 0");
            }

            string orderID;
            orderID = programMethod.createSalesOrder(dealerIDBox.Text.Trim(), dealerNameBox.Text.Trim(), phoneNumBox.Text.Trim(), goodsAddressBox.Text.Trim(), productOfOrderdata);
            ClearForm();
            MessageBox.Show("Order Create Successfully " + "Order ID: " + orderID);


        }


        private void disableFunction(bool readOnly)
        {
            if (readOnly)
            {
                productOfOrderdata.CellContentDoubleClick -= productOfOrderdata_CellDoubleClick;
            }
            else { productOfOrderdata.CellContentDoubleClick += productOfOrderdata_CellDoubleClick; }
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
