using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ITP4519M
{
    public partial class Invoice : Form
    {

        private string invoiceID;
        private string orderID;
        private string dealerID;
        ProgramMethod.ProgramMethod programMethod;
        public Invoice(string invoiceID, string orderID, string dealerID)
        {
            InitializeComponent();
            this.invoiceID = invoiceID;
            this.orderID = orderID;
            this.dealerID = dealerID;
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            programMethod = new ProgramMethod.ProgramMethod();
            DataTable result = programMethod.getInvoiceDetails(orderID);
            DataTable OrderItem = programMethod.getOrderItemDetail(orderID);
            DataTable orderDetails = programMethod.getOrderDetails(orderID);
            InvoiceInvoiceDatelbl.Text = result.Rows[0]["IssueDate"].ToString();
            InvoiceOrderIDlbl.Text = orderID;
            InvoiceDealerIDlbl.Text = dealerID;
            InvoiceBillingAddresslbl.Text = orderDetails.Rows[0]["InvoiceAddress"].ToString();
            InvoiceAddresslbl.Text = orderDetails.Rows[0]["DeliveryAddress"].ToString();
            InvoiceOrderDatelbl.Text = orderDetails.Rows[0]["OrderDate"].ToString();
            //Delivery Date //InvoiceDeliveryDatelbl.Text 

            InvoiceFormData.DataSource = OrderItem;

        }

        private void invoiceExitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
