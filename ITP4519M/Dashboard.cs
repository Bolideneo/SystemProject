using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using ProgramMethod;


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

        ProgramMethod.ProgramMethod programMethod;
        string username;
        public Dashboard()
        {
            InitializeComponent();
            ShowPanel(dashboardpnl);
            

        }
        
        public Dashboard(string username)
        {
            username = this.username;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            programMethod = new ProgramMethod.ProgramMethod();
            namelbl.Text = programMethod.getUserDisplayName(username);
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
            RegisterForm registerForm = new RegisterForm(OperationMode.Edit);
            registerForm.ShowDialog();
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
    }
}
