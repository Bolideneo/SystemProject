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
using static ProgramMethod.ProgramMethod;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITP4519M
{
    public partial class OrderDetails : Form
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
        private bool modifyProduct;
        private OperationMode _mode;
        private bool DealerInfo;



        public OrderDetails(OperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }


        public void CurrentUserIDAndName(string userID, string userName)
        {
            this.userID = userID;
            this.userName = userName;
        }

        void assistant_Idled(object sender, EventArgs e)
        {
            this.Invoke(
            new MethodInvoker(() =>
            {
                try
                {  //Enable This
                   // coll.Clear();

                    DataTable result = programMethod.searchDealerDetail(comboBox1.Text.Trim());

                    if (result.Rows.Count > 0)
                    {

                        foreach (DataRow row in result.Rows)
                        {
                            coll.Add(row["DealerName"].ToString());

                        }
                    }
                    dealerinfoBox.AutoCompleteCustomSource = coll;
                    dealerIDBox.Text = result.Rows[0]["DealerID"].ToString();
                    dealerNameBox.Text = result.Rows[0]["DealerName"].ToString();
                    phoneNumBox.Text = result.Rows[0]["DealerPhoneNum"].ToString();
                    dealerCompanyBox.Text = result.Rows[0]["DealerCompanyName"].ToString();
                    invoiceAddressBox.Text = result.Rows[0]["DealerCompanyAddress"].ToString();
                    goodsAddressBox.Text = result.Rows[0]["DealerCompanyAddress"].ToString();
                    orderEmailAddressbox.Text = result.Rows[0]["DealerEmailAddress"].ToString();

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Name not found");
                    //}


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));
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
            assistant = new TypeAssistant();
            assistant.Idled += assistant_Idled;
            comboBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;

            switch (_mode)
            {
                case OperationMode.View:
                    SetReadOnly(true);
                    break;
                case OperationMode.New:
                    orderDateBox.MinDate = DateTime.Today;
                    orderDateBox.MaxDate = DateTime.Today;
                    ClearForm();
                    SetReadOnly(false);
                    break;
                case OperationMode.Edit:
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
                    // SetReadOnly(true);
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rect = new Rectangle(dealerinfoBox.Location.X,
            dealerinfoBox.Location.Y, dealerinfoBox.ClientSize.Width, dealerinfoBox.ClientSize.Height);

            rect.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rect,
            Color.DeepSkyBlue, ButtonBorderStyle.Solid);
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
                    this.productOfOrderdata.Rows.Add(result.Rows[0]["ProductID"].ToString(), result.Rows[0]["ProductName"].ToString(), 0, result.Rows[0]["UnitPrice"], "100");
                    productSearchbox.Text = "";
                }
            }
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
                    // this.orderStatuslbl.Text = orderDetails.Rows[0]["OrderStatus"].ToString();
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
                    this.ordertotallbl.Text = orderDetails.Rows[0]["TotalPrice"].ToString();
                    this.orderStatusLabel.Text = orderDetails.Rows[0]["OrderStatus"].ToString();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            assistant.TextChanged();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                DataTable result = programMethod.searchDealerDetail(comboBox2.Text.Trim());
                //  comboBox2.Items.Insert(0, new ListItem("Select here...", string.Empty));

                //MessageBox.Show("Enter pressed", "KeyPress Event");

                if (result.Rows.Count > 0)
                {
                    comboBox2.DroppedDown = true;
                    //    foreach (DataRow row in result.Rows)
                    //    {
                    //        coll.Add(row["DealerName"].ToString());

                    //    }
                }
                else
                {
                    comboBox2.DroppedDown = false;
                    return;
                }
                DataRow row2 = result.NewRow();
                row2.ItemArray = new object[] { 0, "--Close Suggestion--" };
                result.Rows.InsertAt(row2, 0);
                comboBox2.DisplayMember = "DealerName";
                comboBox2.DataSource = result;




                //dealerinfoBox.AutoCompleteCustomSource = coll;

                dealerIDBox.Text = result.Rows[0]["DealerID"].ToString();
                dealerNameBox.Text = result.Rows[0]["DealerName"].ToString();
                phoneNumBox.Text = result.Rows[0]["DealerPhoneNum"].ToString();
                dealerCompanyBox.Text = result.Rows[0]["DealerCompanyName"].ToString();
                goodsAddressBox.Text = result.Rows[0]["DealerRegionNum"].ToString();
                comboBox2.PreviewKeyDown += new PreviewKeyDownEventHandler(comboBox2_PreviewKeyDown);



            }
        }

        private void comboBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            comboBox2.PreviewKeyDown -= comboBox2_PreviewKeyDown;
            if (comboBox2.DroppedDown) comboBox2.Focus();

        }

        private void usernamepnl_Paint(object sender, PaintEventArgs e)
        {
            if (isWrongFormat)
            {
                ControlPaint.DrawBorder(e.Graphics, this.usernamepnl.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
                return;
            }
            ControlPaint.DrawBorder(e.Graphics, this.usernamepnl.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
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

        private void saveOrderbtn_Click(object sender, EventArgs e)
        {

        }
    }


}