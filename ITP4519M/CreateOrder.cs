using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
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
using System.Web;
using System.Windows.Forms;
using ZstdSharp.Unsafe;
using static ProgramMethod.ProgramMethod;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITP4519M
{
    public partial class CreateOrder : Form
    {
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        TypeAssistant assistant;
        private string orderID;
        private string dealerID;
        private string userID;
        private string userName;
        private bool isWrongFormat;
        private bool isWrongFormat2;
        private bool isWrongFormat3;
        private OperationMode _mode;
        private bool DealerInfo;
        private string value;



        public CreateOrder(OperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }


        public void CurrentUserIDAndName(string userID, string userName)
        {
            this.userID = userID;
            this.userName = userName;
        }

        private void dealerinfoBox_TextChanged(object sender, EventArgs e)
        {
            assistant.TextChanged();
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
                    //programMethod.productSearchAutoComplete(orderAccemblyAssignbox);
                    orderDateBox.MinDate = DateTime.Today;
                    orderDateBox.MaxDate = DateTime.Today.AddDays(7);
                    productOfOrderdata.Columns.Add("ProductID", "Product ID");
                    productOfOrderdata.Columns.Add("ProductName", "Product Name");
                    productOfOrderdata.Columns.Add("Quantity", "Quantity");
                    productOfOrderdata.Columns.Add("UnitPrice", "Unit Price");
                    productOfOrderdata.Columns.Add("Discount", "Discount (%)");
                    createOrderbtn.Visible = true;
                    ClearForm();
                    SetReadOnly(false);
                    break;
                case OperationMode.Edit:
                    // SetReadOnly(true);
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ClearForm()
        {

            goodsAddressBox.Text = string.Empty;
            orderDateBox.Text = string.Empty;
            dealerIDBox.Text = string.Empty;
            dealerNameBox.Text = string.Empty;
            dealerCompanyBox.Text = string.Empty;
            phoneNumBox.Text = string.Empty;
            dealerInfobox.Text = string.Empty;
            orderContactNamebox.Text = string.Empty;
            OrderContactPhonebox.Text = string.Empty;
            ordertotallbl.Text = string.Empty;
            orderEmailAddressbox.Text  = string .Empty;
            invoiceAddressBox.Text = string.Empty;
            productSearchbox.Text = string .Empty;
            productOfOrderdata.Rows.Clear();
        }

        private void SetReadOnly(bool readOnly)
        {

            //goodsAddressBox.ReadOnly = readOnly;
            //dealerIDBox.ReadOnly = readOnly;
            //dealerNameBox.ReadOnly = readOnly;
            // dealerCompanyBox.ReadOnly = readOnly;
            // phoneNumBox.ReadOnly = readOnly;
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
                    dealerIDBox.Text = result.Rows[0]["DealerID"].ToString();
                    dealerNameBox.Text = result.Rows[0]["DealerName"].ToString();
                    phoneNumBox.Text = result.Rows[0]["DealerPhoneNum"].ToString();
                    dealerCompanyBox.Text = result.Rows[0]["DealerCompanyName"].ToString();
                    invoiceAddressBox.Text = result.Rows[0]["DealerCompanyAddress"].ToString();
                    goodsAddressBox.Text = result.Rows[0]["DealerCompanyAddress"].ToString();
                    orderEmailAddressbox.Text = result.Rows[0]["DealerEmailAddress"].ToString();
                }
                else
                {
                    dealerNameBox.Text = "";
                    phoneNumBox.Text = "";
                    invoiceAddressBox.Text = "";
                    dealerCompanyBox.Text = "";
                    goodsAddressBox.Text = "";
                    orderEmailAddressbox.Text = "";

                }

            }
        }


        private void productSearchbox_TextChanged(object sender, EventArgs e)
        {

        }



        private void createOrderbtn_Click(object sender, EventArgs e)
        {


            if (dealerInfobox.Text == "")
            {
                isWrongFormat = true;
                usernameAlertBox.Visible = true;
                usernameAlertlbl.Visible = true;
                dealerInfobox.BorderColor = Color.Red;
                Refresh();
            }
            else
            {
                isWrongFormat = false;
                usernameAlertBox.Visible = false;
                usernameAlertlbl.Visible = false;
                dealerInfobox.BorderColor = Color.Black;
                Refresh();

            }
            if (orderContactNamebox.Text == "")
            {
                isWrongFormat2 = true;
                label1.Visible = true;
                pictureBox1.Visible = true;
                Refresh();

            }
            else
            {

                isWrongFormat2 = false;
                label1.Visible = false;
                pictureBox1.Visible = false;
                Refresh();
            }

            if (OrderContactPhonebox.Text == "")
            {
                isWrongFormat3 = true;
                label2.Visible = true;
                pictureBox2.Visible = true;
                Refresh();

            }
            else
            {
                isWrongFormat3 = false;
                label2.Visible = false;
                pictureBox2.Visible = false;
                Refresh();

            }

            if (orderDateBox.Text == "")
            {
                orderDateBox.BorderColor = Color.Red;
                label11.Visible = true;
            }
            else
            {
                label11.Visible = false;
                orderDateBox.BorderColor = Color.Black;
            }
            
            if(productSearchbox.Text  == "")
            {
                productSearchbox.BorderColor = Color.Red;
                pictureBox3.Visible = true;
            }
            else
            {
                productSearchbox.BorderColor = Color.Black;
                pictureBox3.Visible = false;
            }

            if (productOfOrderdata.RowCount == 0)
            {
                label17.Visible = true;
                return;

            }
            else
            {
                label17.Visible = false;
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
            string address;
            if (orderDifferentDeliverybox.Text == "")
            {
                address = goodsAddressBox.Text.Trim();
            }
            else
            {
                address = orderDifferentDeliverybox.Text.Trim();
            }

            string orderID;
            orderID = programMethod.createSalesOrder(dealerIDBox.Text.Trim(), dealerNameBox.Text.Trim(), orderContactNamebox.Text.Trim(), OrderContactPhonebox.Text.Trim(), phoneNumBox.Text.Trim(), goodsAddressBox.Text.Trim(), address, orderDateBox.Value.ToString(), ordertotallbl.Text.ToString(), productOfOrderdata);
            if (orderID != null)
            {
                programMethod.LogCreateSalesOrder(this.userID, this.userName, orderID);
            }

          
            MessageBox.Show("Order Create Successfully " + "Order ID: " + orderID);
            ClearForm();

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

            ordertotallbl.Text = "" + programMethod.calProductTotalAmount(productOfOrderdata);

        }

        private void ordertotallbl_TextChanged(object sender, EventArgs e)
        {
            ordertotallbl.Text = "" + programMethod.calProductTotalAmount(productOfOrderdata);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (this.productOfOrderdata.ContainsFocus)
                {
                    this.productOfOrderdata.EndEdit();
                    if (this.productOfOrderdata.CurrentRow.IsNewRow && this.productOfOrderdata.Rows.Count > 1)
                        this.productOfOrderdata.CurrentCell = this.productOfOrderdata.Rows[this.productOfOrderdata.Rows.Count - 1].Cells[2];
                    ordertotallbl.Text = "" + programMethod.calProductTotalAmount(productOfOrderdata);
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        public class TypeAssistant
        {
            public event EventHandler Idled = delegate { };
            public int WaitingMilliSeconds { get; set; }
            System.Threading.Timer waitingTimer;

            public TypeAssistant(int waitingMilliSeconds = 800)
            {
                WaitingMilliSeconds = waitingMilliSeconds;
                waitingTimer = new System.Threading.Timer(p =>
                {
                    Idled(this, EventArgs.Empty);
                });
            }
            public void TextChanged()
            {
                waitingTimer.Change(WaitingMilliSeconds, System.Threading.Timeout.Infinite);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {  //&& dealerInfobox.Text.Trim().Length != 0
            //dealerInfobox.Focus();
            string text = dealerInfobox.Text.Trim();
            //dealerInfobox.DroppedDown = false;
            if (e.KeyCode == Keys.Enter)
            {
                programMethod.DealerSearchAutoComplete(dealerInfobox, dealerInfobox.Text.Trim());
                if (dealerInfobox.Items.Count > 0)
                {

                    dealerInfobox.DroppedDown = true;
                    dealerInfobox.IntegralHeight = true;
                    dealerInfobox.SelectedIndex = -1;
                    dealerInfobox.SelectionStart = dealerInfobox.Text.Trim().Length;
                    dealerInfobox.SelectionLength = 0;
                }
                Cursor.Current = Cursors.Default;
            }
            //  dealerInfobox.SelectedIndex = -1;
            dealerInfobox.Text = text;
            dealerInfobox.SelectionStart = dealerInfobox.Text.Length;
        }


        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {
            if (isWrongFormat2)
            {
                ControlPaint.DrawBorder(e.Graphics, this.panel5.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
                return;
            }

            ControlPaint.DrawBorder(e.Graphics, this.panel5.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            if (isWrongFormat3)
            {
                ControlPaint.DrawBorder(e.Graphics, this.panel7.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
                return;
            }
            ControlPaint.DrawBorder(e.Graphics, this.panel7.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dealerInfobox.SelectedItem == "-------------------")
            {
                return;
            }
            if (dealerInfobox.SelectedItem != null)
            {
                string selectedItem = dealerInfobox.SelectedItem.ToString();
                Cursor.Current = Cursors.Default;
                DataTable result = programMethod.searchDealerDetail(selectedItem);
                dealerIDBox.Text = result.Rows[0]["DealerID"].ToString();
                dealerNameBox.Text = result.Rows[0]["DealerName"].ToString();
                phoneNumBox.Text = result.Rows[0]["DealerPhoneNum"].ToString();
                dealerCompanyBox.Text = result.Rows[0]["DealerCompanyName"].ToString();
                goodsAddressBox.Text = result.Rows[0]["DealerCompanyAddress"].ToString();
                orderEmailAddressbox.Text = result.Rows[0]["DealerEmailAddress"].ToString();
                invoiceAddressBox.Text = result.Rows[0]["DealerCompanyAddress"].ToString();
            }
        }

        private void dealerInfobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.dealerInfobox.DroppedDown = false;

        }

        private void productSearchbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productSearchbox.SelectedItem == "-------------------")
            {
                return;
            }
            if (productSearchbox.SelectedItem != null)
            {
                string selectedItem = productSearchbox.SelectedItem.ToString();
                Cursor.Current = Cursors.Default;

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
                this.productOfOrderdata.Rows.Add(result.Rows[0]["ProductID"].ToString(), result.Rows[0]["ProductName"].ToString(), 0, result.Rows[0]["UnitPrice"], "100");
              //  productSearchbox1.Text = "";

            }
        }

        private void productSearchbox_KeyDown_1(object sender, KeyEventArgs e)
        {
            string text = productSearchbox.Text.Trim();
            if (e.KeyCode == Keys.Enter)
            {
                programMethod.ProductSearchAutoComplete(productSearchbox, productSearchbox.Text.Trim());
                if (productSearchbox.Items.Count > 0)
                {

                    productSearchbox.DroppedDown = true;
                    productSearchbox.IntegralHeight = true;
                    productSearchbox.SelectedIndex = -1;
                    productSearchbox.SelectionStart = productSearchbox.Text.Trim().Length;
                    productSearchbox.SelectionLength = 0;
                }
                Cursor.Current = Cursors.Default;
            }
            //  dealerInfobox.SelectedIndex = -1;
            productSearchbox.Text = text;
            productSearchbox.SelectionStart = productSearchbox.Text.Length;
        }

        private void productSearchbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.productSearchbox.DroppedDown = false;
        }
    }


}