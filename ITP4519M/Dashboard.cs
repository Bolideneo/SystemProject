﻿using Microsoft.VisualBasic.ApplicationServices;
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
using System.Linq.Expressions;
using Google.Protobuf.WellKnownTypes;
using System.Xml.Linq;


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
        private string grnID;
        private string dealerID;
        private string deliveryID;
        private string contactID;

        private int index = -1;
        private int index2 = -1;
        private int orderindex = -1;
        private int userindex = -1;
        private int grnindex = -1;
        private int deliveryindex = -1;
        private int contactindex = -1;
        private int stockindex = -1;
        private Button lastClickedButton = null;
        private Button[] buttons = new Button[2];
        private bool isFormDragging = false;
        private Point formStartPoint;
        private int[] buttonLocationIndex = [229, 300, 371, 440, 509, 580, 651, 720, 789];


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

        public void ButtonLocation(string departmentID)
        {

            switch(departmentID){
                //IT
               case "001":
               ShowButton(!false);
               usersbtn.Visible = true;
               settingbtn.Visible = true;
               
               usersbtn.Location = new Point(25, buttonLocationIndex[0]);
               settingbtn.Location = new Point(25, buttonLocationIndex[8]);
               break;


                //WareHouse
                case "002":
                ShowButton(!false);
                stockbtn.Location = new Point(25, buttonLocationIndex[0]);
                outstandingOrderbtn.Location = new Point(25, buttonLocationIndex[1]);
                GRNbtn.Location = new Point(25, buttonLocationIndex[2]);
                deliverybtn.Location = new Point(25, buttonLocationIndex[3]);
                settingbtn.Location = new Point(25, buttonLocationIndex[8]);
                break;

                //Sales Manager
                case "003":
                editOrdersbtn.Visible = false;
                break;


                //Purcahsing
                case "004":
                stockbtn.Location = new Point(25, buttonLocationIndex[0]);
                contactsbtn.Location = new Point(25, buttonLocationIndex[1]);
                settingbtn.Location = new Point(25, buttonLocationIndex[8]);
                break;
            }

        }

        private void ShowButton(bool ReadyOnly)
        {
            usersbtn.Visible = ReadyOnly;
            stockbtn.Visible = ReadyOnly;
            outstandingOrderbtn.Visible = ReadyOnly;
            orderbtn.Visible = ReadyOnly;
            contactsbtn.Visible = ReadyOnly;
            GRNbtn.Visible = ReadyOnly;
            deliverybtn.Visible = ReadyOnly;
            Logbtn.Visible = ReadyOnly;
            settingbtn.Visible = ReadyOnly;


            usersbtn.Visible = !ReadyOnly;
            stockbtn.Visible = !ReadyOnly;
            outstandingOrderbtn.Visible = !ReadyOnly;
            orderbtn.Visible = !ReadyOnly;
            contactsbtn.Visible = !ReadyOnly;
            GRNbtn.Visible = !ReadyOnly;
            deliverybtn.Visible = !ReadyOnly;
            Logbtn.Visible = !ReadyOnly;
            settingbtn.Visible = !ReadyOnly;
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
            orderdata.Rows[0].Selected = false;
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
            stockData.Rows[0].Selected = false;

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
            contactsdata.Rows[0].Selected = false;
            newSupplierbtn.Visible = false;
            editSupplierbtn.Visible = false;
            newDealerbtn.Visible = true;
            editDealerbtn.Visible = true;
            searchSupplierbtn.Visible = false;
            searchDealerbtn.Visible = true;

        }



        private void dealersbtn_Click(object sender, EventArgs e)
        {
            contactsdata.DataSource = programMethod.overviewDealerinfo();
            newSupplierbtn.Visible = false;
            editSupplierbtn.Visible = false;
            newDealerbtn.Visible = true;
            editDealerbtn.Visible = true;
            searchSupplierbtn.Visible = false;
            searchDealerbtn.Visible = true;

        }

        private void supplersbtn_Click(object sender, EventArgs e)
        {
            contactsdata.DataSource = programMethod.overviewSupplierinfo();
            newDealerbtn.Visible = false;
            editDealerbtn.Visible = false;
            newSupplierbtn.Visible = true;
            editSupplierbtn.Visible = true;
            searchSupplierbtn.Visible = true;
            searchDealerbtn.Visible = false;
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
            if (orderindex == -1)
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
            CreateOrder createOrder = new CreateOrder(OperationMode.New);
            createOrder.ShowDialog();
        }

        private void editOrdersbtn_Click(object sender, EventArgs e)
        {
            if (orderindex == -1)
            {
                MessageBox.Show("Please Select One User");
            }
            else
            {
                SalesOrder salesOrder = new SalesOrder(OperationMode.Edit);
                salesOrder.orderEdit(orderID, dealerID);
                salesOrder.ShowDialog();
            }


        }


        private void editAccountbtn_Click(object sender, EventArgs e)
        {
            if (userindex == -1)
            {
                MessageBox.Show("Please Select One User");
            }
            else
            {
                RegisterForm registerForm = new RegisterForm(OperationMode.Edit);
                registerForm.OperationCompleted += registerFormOperationCompleted;
                registerForm.accountEdit(userID);
                registerForm.ShowDialog();
            }
        }

        private void registerFormOperationCompleted(object sender, EventArgs e)
        {
            userData.DataSource = programMethod.overviewUserinfo();
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

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.userData.Rows[e.RowIndex].Cells["usercheckColumn"].Value = true;
                userindex = e.RowIndex;
                DataGridViewRow selectRow = this.userData.Rows[userindex];
                userID = selectRow.Cells[1].Value.ToString();
               // dealerID = selectRow.Cells[2].Value.ToString();

                foreach (DataGridViewRow row in userData.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["usercheckColumn"].Value = !Convert.ToBoolean(row.Cells["usercheckColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["usercheckColumn"].Value = false;
                    }
                }
            }

        }

        //Show datagridView of stock Data
        private void stockData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.stockData.Rows[e.RowIndex].Cells["stockcheckColumn"].Value = true;
                stockindex = e.RowIndex;
                DataGridViewRow selectRow = this.stockData.Rows[stockindex];
                productID = selectRow.Cells[1].Value.ToString();
              //  dealerID = selectRow.Cells[2].Value.ToString();

                foreach (DataGridViewRow row in stockData.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["stockcheckColumn"].Value = !Convert.ToBoolean(row.Cells["stockcheckColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["stockcheckColumn"].Value = false;
                    }
                }
            }

        }
        private void contactsdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.contactsdata.Rows[e.RowIndex].Cells["contactcheckColumn"].Value = true;
                contactindex = e.RowIndex;
                DataGridViewRow selectRow = this.contactsdata.Rows[contactindex];
                contactID = selectRow.Cells[1].Value.ToString();
                //dealerID = selectRow.Cells[2].Value.ToString();

                foreach (DataGridViewRow row in contactsdata.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["contactcheckColumn"].Value = !Convert.ToBoolean(row.Cells["contactcheckColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["contactcheckColumn"].Value = false;
                    }
                }
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

        public void currentUserDisplayName(string displayName, string department)
        {
            namelbl.Text = displayName;
            usertypelbl.Text = department;
        }

        public void currentUserDepartment(string department)
        {
            usertypelbl.Text = department;
        }

        private void editProductbtn_Click(object sender, EventArgs e)
        {
            if (stockindex == -1)
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
            grndata.DataSource = programMethod.overallGRNinfo();
            grndata.Rows[0].Selected = false;

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
            deliveryData.DataSource = programMethod.overallDeliveryinfo();
            deliveryData.Rows[0].Selected = false;
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

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.orderdata.Rows[e.RowIndex].Cells["ordercheckColumn"].Value = true;
                orderindex = e.RowIndex;
                DataGridViewRow selectRow = this.orderdata.Rows[orderindex];
                orderID = selectRow.Cells[1].Value.ToString();
                dealerID = selectRow.Cells[2].Value.ToString();

                foreach (DataGridViewRow row in orderdata.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["ordercheckColumn"].Value = !Convert.ToBoolean(row.Cells["ordercheckColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["ordercheckColumn"].Value = false;
                    }
                }
            }

        }




        private void grnSearchBtn_Click(object sender, EventArgs e)
        {
            string formDate = grnDatePicker1.Value.Date.ToString("yyyy-MM-dd");
            string toDate = grnDatePicker2.Value.Date.ToString("yyyy-MM-dd");
            grndata.DataSource = programMethod.searchGRNDate(formDate, toDate);

        }

        private void grnclearBtn_Click(object sender, EventArgs e)
        {
            grndata.DataSource = programMethod.overallGRNinfo();


        }

        private void grnAddNoteBtn_Click(object sender, EventArgs e)
        {
            GRN grn = new GRN(OperationMode.New);
            grn.ShowDialog();
        }
        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            stockData.DataSource = programMethod.searchProductInformation(stockSearchBox.Text.Trim());
        }


        private void orderdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deliverySearchDatebtn_Click(object sender, EventArgs e)
        {
            string formDate = deliverydateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            string toDate = deliverydateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            deliveryData.DataSource = programMethod.searchDeliveryDate(formDate, toDate);
        }

        private void newDealerbtn_Click(object sender, EventArgs e)
        {

            DealerContactForm dealerContactForm = new DealerContactForm(OperationMode.New);
            dealerContactForm.ShowDialog();

        }

        private void editDealerbtn_Click(object sender, EventArgs e)
        {
            if (contactindex == -1)
            {
                MessageBox.Show("Please Select One Option");
            }
            else
            {

                DealerContactForm dealerContactForm = new DealerContactForm(OperationMode.Edit);
                dealerContactForm.dealerEdit(contactID);
                dealerContactForm.ShowDialog();
            }
        }

        private void contactsdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void delContactbtn_Click(object sender, EventArgs e)
        {


            if (index == -1)
            {
                MessageBox.Show("Please Select One Option");
            }
            else
            {
                programMethod.contactDel(contactID);

            }
        }

        private void newSupplierbtn_Click(object sender, EventArgs e)
        {
            SupplierContactForm supplierContactForm = new SupplierContactForm(OperationMode.New);
            supplierContactForm.ShowDialog();
        }

        private void editSupplierbtn_Click(object sender, EventArgs e)
        {
            if (contactindex == -1)
            {
                MessageBox.Show("Please Select One Option");
            }
            else
            {

                SupplierContactForm supplierContactForm = new SupplierContactForm(OperationMode.Edit);
                supplierContactForm.supplierEdit(contactID);
                supplierContactForm.ShowDialog();
            }
        }

        private void searchDealerbtn_Click(object sender, EventArgs e)
        {
            contactsdata.DataSource = programMethod.searchDealerInformation(searchContactbtn.Text.Trim());
        }

        private void searchSupplierbtn_Click(object sender, EventArgs e)
        {
            contactsdata.DataSource = programMethod.searchSupplierInformation(searchContactbtn.Text.Trim());
        }

        private void deliveryclearbtn_Click(object sender, EventArgs e)
        {
            deliveryData.DataSource = programMethod.overallDeliveryinfo();
        }

        private void deliveryAddbtn_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery(OperationMode.New);
            delivery.ShowDialog();
        }

        private void deliverySearchIDbtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void deliverySearchIDbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                deliveryData.DataSource = programMethod.getDeliveryDetails(deliverySearchIDbox.Text.Trim());
            }
        }

        private void deliveryclearbtn_Click_1(object sender, EventArgs e)
        {
            deliveryData.DataSource = programMethod.overallDeliveryinfo();
        }

        private void deliveryAddbtn_Click_1(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery(OperationMode.New);
            delivery.ShowDialog();
        }

        private void deliveryData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeliveryForm deliveryForm = new DeliveryForm();
            deliveryForm.ShowDialog();
        }

        private void grndata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.grndata.Rows[e.RowIndex].Cells["grncheckColumn"].Value = true;
                grnindex = e.RowIndex;
                DataGridViewRow selectRow = this.grndata.Rows[grnindex];
                grnID = selectRow.Cells[1].Value.ToString();
                productID = selectRow.Cells[2].Value.ToString();

                foreach (DataGridViewRow row in grndata.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["grncheckColumn"].Value = !Convert.ToBoolean(row.Cells["grncheckColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["grncheckColumn"].Value = false;
                    }
                }
            }
        }

        private void deliveryData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                this.deliveryData.Rows[e.RowIndex].Cells["deliverycheckColumn"].Value = true;
                deliveryindex = e.RowIndex;
                DataGridViewRow selectRow = this.deliveryData.Rows[deliveryindex];
                deliveryID = selectRow.Cells[1].Value.ToString();
                // deliveryID = selectRow.Cells[2].Value.ToString();

                foreach (DataGridViewRow row in deliveryData.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["deliverycheckColumn"].Value = !Convert.ToBoolean(row.Cells["deliverycheckColumn"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["deliverycheckColumn"].Value = false;
                    }
                }
            }
        }

        private void userData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
