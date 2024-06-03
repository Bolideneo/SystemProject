using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Mysqlx.Crud;
using ProgramMethod;

namespace ITP4519M
{
    public partial class SalesOrder : Form
    {
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
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
                    SetReadOnly(true);
                    break;
                case OperationMode.New:
                    ClearForm();
                    SetReadOnly(false);
                    break;
                case OperationMode.Edit:
                    SetReadOnly(false);
                    break;
            }
        }

        private void ClearForm()
        {

            goodsAddressBox.Text = string.Empty;
            invoiceAddressBox.Text = string.Empty;
            orderCompleteDateBox.Text = string.Empty;
            orderIDBox.Text = string.Empty;
            orderStatusBox.Text = string.Empty;
            orderDateBox.Text = string.Empty;
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
            orderIDBox.ReadOnly = readOnly;
            orderStatusBox.ReadOnly = readOnly;
            orderDateBox.ReadOnly = readOnly;
            dealerIDBox.ReadOnly = readOnly;
            dealerNameBox.ReadOnly = readOnly;
            dealerCompanyBox.ReadOnly = readOnly;
            phoneNumBox.ReadOnly = readOnly;

            goodsAddressBox.Enabled = !readOnly;
            invoiceAddressBox.Enabled = !readOnly;
            orderCompleteDateBox.Enabled = !readOnly;
            orderIDBox.Enabled = !readOnly;
            orderStatusBox.Enabled = !readOnly;
            orderDateBox.Enabled = !readOnly;
            dealerIDBox.Enabled = !readOnly;
            dealerNameBox.Enabled = !readOnly;
            dealerCompanyBox.Enabled = !readOnly;
            phoneNumBox.Enabled = !readOnly;
        }

        private void orderIDBox_TextChanged(object sender, EventArgs e)
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
            productpricebox.Text = productpricebox.Text.Substring(0, 12) + programMethod.calProductTotalAmount(productOfOrderdata);

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
            else if (productSearchbox.Text == "")
            {
                MessageBox.Show("Please Input Product ID ");
            }


            if (productOfOrderdata.RowCount == 0)
            {
                MessageBox.Show("Please Select atleast one product");
            }


            ArrayList checkList = new ArrayList();

            for (int i = 0; i < productOfOrderdata.Rows.Count; i++)
            {
                if (int.Parse(productOfOrderdata.Rows[i].Cells[2].Value.ToString()) > 0)
                    checkList.Add(true);
                else
                    checkList.Add(false);
            }
            if (checkList.Contains(false))
                MessageBox.Show("Product quantity should not be 0");


            string orderID;
            orderID = programMethod.createSalesOrder(dealerIDBox.Text.Trim(), dealerNameBox.Text.Trim(), phoneNumBox.Text.Trim(), goodsAddressBox.Text.Trim(), productOfOrderdata);
            ClearForm();



        }

        private void productOfOrderdata_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow orderData = this.productOfOrderdata.CurrentRow;
            this.productOfOrderdata.Rows.Remove(orderData);
            productpricebox.Text = productpricebox.Text.Substring(0, 12) + programMethod.calProductTotalAmount(productOfOrderdata);

        }

 
    }
}
