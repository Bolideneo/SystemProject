using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using ProgramMethod;
using Org.BouncyCastle.Asn1.Cmp;
using System.Reflection.Metadata.Ecma335;
using System.Reflection;
using ITP4519M;


namespace ITP4519M
{
    public enum OperationMode
    {
        View,
        New,
        Edit,
        Disable
    }
    public partial class Dashboard : Form
    {

        private ProgramMethod.ProgramMethod programMethod;
        private Button currentButton;
        private string userID;
        private string productID;
        private string orderID;
        private string dealerID;
        private int index = -1;
        private int index2 = -1;
        private Button lastClickedButton = null;
        private Button[] buttons = new Button[2];
        private bool isFormDragging = false;
        private Point formStartPoint;


        public Dashboard()
        {

            InitializeComponent();
            ShowPanel(dashboardpnl);



        }

        private void InitializeButtons()
        {
            buttons[0] = usersbtn;
            buttons[1] = stockbtn;
            buttons[2] = orderbtn;
            buttons[3] = contactsbtn;
            buttons[4] = Logbtn;
            buttons[5] = settingbtn;

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            programMethod = new ProgramMethod.ProgramMethod();
            closebtn.BringToFront();
        }


        private void ShowPanel(Panel panelToShow)
        {
            orderpnl.Visible = false;
            inventorypnl.Visible = false;
            userspnl.Visible = false;
            settingpnl.Visible = false;
            dashboardpnl.Visible = false;
            contactpnl.Visible = false;
            logpnl.Visible = false;
            outstandingOrderpnl.Visible = false;
            GRNpnl.Visible = false;
            deliverypnl.Visible = false;
            panelToShow.Visible = true;

        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(orderpnl);
            orderdata.DataSource = programMethod.overallOrderinfo();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {

            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(inventorypnl);
            stockData.DataSource = programMethod.overviewStockinfo();
            productOverallLabel();

        }

        private void usersbtn_Click(object sender, EventArgs e)
        {

            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;


            ShowPanel(userspnl);
            userData.DataSource = programMethod.overviewUserinfo();

        }



        private void settingbtn_Click(object sender, EventArgs e)
        {


            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(settingpnl);

        }

        private void outstandingOrderbtn_Click(object sender, EventArgs e)
        {


            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(outstandingOrderpnl);

        }

        private void contactsbtn_Click(object sender, EventArgs e)
        {

            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(contactpnl);
            contactsdata.DataSource = programMethod.overviewDealerinfo();
        }



        private void dealersbtn_Click(object sender, EventArgs e)
        {

        }

        private void supplersbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void contactpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newAccountbtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(OperationMode.New);
            registerForm.ShowDialog();
        }

        private void viewOrderbtn_Click(object sender, EventArgs e)
        {
            if (index2 == -1)
            {
                MessageBox.Show("Please Select One Order");
            }
            else
            {
                SalesOrder salesOrder = new SalesOrder(OperationMode.View);
                salesOrder.orderView(orderID, dealerID);
                salesOrder.ShowDialog();

            }


        }

        private void newOrderbtn_Click(object sender, EventArgs e)
        {
            SalesOrder salesOrder = new SalesOrder(OperationMode.New);
            salesOrder.ShowDialog();
        }

        private void editOrdersbtn_Click(object sender, EventArgs e)
        {
            SalesOrder salesOrder = new SalesOrder(OperationMode.Edit);
            salesOrder.ShowDialog();
        }




        private void editAccountbtn_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Please Select One User");
            }
            else
            {
                RegisterForm registerForm = new RegisterForm(OperationMode.Edit);
                registerForm.accountEdit(userID);
                registerForm.ShowDialog();

            }
        }

        private void viewAccountbtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(OperationMode.View);
            registerForm.accountEdit(userID);
            registerForm.ShowDialog();
        }

        private void Logbtn_Click(object sender, EventArgs e)

        {

            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(logpnl);
        }

        private void namelbl_Click(object sender, EventArgs e)
        {

        }


        //Account dataGridView
        private void accountSearchBtn_Click(object sender, EventArgs e)
        {
            userData.DataSource = programMethod.searchUserInformation(accountSearchBox.Text.Trim());
        }

        //Account selected dataGridView row
        private void userData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                index = e.RowIndex;
                DataGridViewRow selectRow = this.userData.Rows[index];
                userID = selectRow.Cells[0].Value.ToString();
            }
            //stockData

        }

        //Show datagridView of stock Data
        private void stockData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                index = e.RowIndex;
                DataGridViewRow selectRow = this.stockData.Rows[index];
                productID = selectRow.Cells[0].Value.ToString();
            }


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stocklbl1_Click(object sender, EventArgs e)
        {

        }

        private void viewProductbtn_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(OperationMode.View);
            productForm.productEdit(productID);
            productForm.ShowDialog();
        }



        private void orderpnl_Paint(object sender, PaintEventArgs e)
        {

        }





        //Overall of Stock Data Label
        private void productOverallLabel()
        {
            int temp = stockData.Rows.Count;
            stockProductDatalbl1.Text = temp.ToString();
            string[] numberofProduct = programMethod.getStockLabelinfo(stockData);
            stockProductDatalbl2.Text = numberofProduct[0];
            stockProductDatalbl3.Text = numberofProduct[1];
        }

        private void inventorylbl_Click(object sender, EventArgs e)
        {

        }

        private void newProductbtn_Click(object sender, EventArgs e)
        {


            ProductForm productForm = new ProductForm(OperationMode.New);
            productForm.StartPosition = FormStartPosition.CenterScreen;
            productForm.ShowDialog();

        }

        private void userbtn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void stockData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_LostFocus(object sender, EventArgs e)
        {

            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = SystemColors.Control;
            }
        }

        private void listpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isFormDragging = true;
                formStartPoint = e.Location;
            }
        }

        private void Dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            isFormDragging = false;

        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (isFormDragging)
            {
                int deltaX = e.X - formStartPoint.X;
                int deltaY = e.Y - formStartPoint.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void disableAccountbtn_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Please Select One User");
            }
            else
            {

                programMethod.disableUserAccount(userID);
                MessageBox.Show("This account disabled");
            }
        }

        private void enableAccountbtn_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Please Select One User");
            }
            else
            {

                programMethod.enableUserAccount(userID);
                MessageBox.Show("This account enabled");
            }
        }

        public void currentUserDisplayName(string displayName)
        {
            namelbl.Text = displayName;
        }

        private void editProductbtn_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Please Select One Option");
            }
            else
            {
                ProductForm ProductForm = new ProductForm(OperationMode.Edit);
                ProductForm.productEdit(productID);
                ProductForm.ShowDialog();

            }
        }

        private void GRNbtn_Click(object sender, EventArgs e)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(GRNpnl);
        }

        private void deliverybtn_Click(object sender, EventArgs e)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.ForeColor = Color.White;
            }

            lastClickedButton = (Button)sender;
            lastClickedButton.ForeColor = Color.Gray;

            ShowPanel(deliverypnl);
        }

        private void delProductbtn_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Please Select One Option");
            }
            else
            {

                programMethod.productDel(productID);

            }
        }

        private void orderdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1 && e.RowIndex < orderdata.Rows.Count)
            {
                index2 = e.RowIndex;
                MessageBox.Show(index2.ToString());
                DataGridViewRow selectRow = this.orderdata.Rows[index2];

                if (selectRow.Cells.Count >= 2)
                {
                    orderID = selectRow.Cells[0].Value.ToString();
                    dealerID = selectRow.Cells[1].Value.ToString();
                }
                //orderID = selectRow.Cells[0].Value.ToString();
                //dealerID = selectRow.Cells[1].Value.ToString();

            }
        }

        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            stockData.DataSource = programMethod.searchProductInformation(stockSearchBox.Text.Trim());
        }
    }
}

