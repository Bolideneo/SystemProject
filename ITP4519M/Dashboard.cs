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


namespace ITP4519M
{

    public enum OperationMode
    {
        View,
        New,
        Edit
    }
    public partial class Dashboard : Form
    {

        private ProgramMethod.ProgramMethod programMethod;
        private string userID;
        private int index = -1;

        public Dashboard()
        {
            InitializeComponent();
            ShowPanel(dashboardpnl);


        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            programMethod = new ProgramMethod.ProgramMethod();
            //namelbl.Text = programMethod.getUserDisplayName(username);
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
            panelToShow.Visible = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowPanel(orderpnl);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
            ShowPanel(inventorypnl);

        }

        private void usersbtn_Click(object sender, EventArgs e)
        {
            ShowPanel(userspnl);
            userData.DataSource = programMethod.overviewUserinfo();
            
        }

        private void settingbtn_Click(object sender, EventArgs e)
        {
            ShowPanel(settingpnl);

        }

        private void contactsbtn_Click(object sender, EventArgs e)
        {
            ShowPanel(contactpnl);

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
            SalesOrder salesOrder = new SalesOrder(OperationMode.View);
            salesOrder.ShowDialog();
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
            registerForm.ShowDialog();
        }

        private void Logbtn_Click(object sender, EventArgs e)
        {
            ShowPanel(logpnl);
        }

        private void namelbl_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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
            try
            {
                index = e.RowIndex;  
                DataGridViewRow selectRow = this.userData.Rows[index];
                userID = selectRow.Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Unable to obtained Index");
            }
        }

    }
}
