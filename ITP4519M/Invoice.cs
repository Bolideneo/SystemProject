using MySqlX.XDevAPI.Common;
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
        private string deliveryID;
        private string IssueDate;

        ProgramMethod.ProgramMethod programMethod;
        public Invoice(string invoiceID, string orderID, string dealerID , string deliveryID, string issueDate)
        {
            InitializeComponent();
            this.invoiceID = invoiceID;
            this.orderID = orderID;
            this.dealerID = dealerID;
            this.deliveryID = deliveryID;
            this.IssueDate = issueDate;
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            programMethod = new ProgramMethod.ProgramMethod();
            DataTable OrderItem = programMethod.getOrderItemDetailforDeliveryANDInvoice(deliveryID);
            DataTable orderDetails = programMethod.getOrderDetails(orderID);
            InvoiceInvoiceDatelbl.Text = IssueDate;
            InvoiceOrderIDlbl.Text = orderID;
            InvoiceDealerIDlbl.Text = dealerID;
            
            InvoiceBillingAddresslbl.Text = orderDetails.Rows[0]["InvoiceAddress"].ToString();
            InvoiceAddresslbl.Text = orderDetails.Rows[0]["DeliveryAddress"].ToString();
            InvoiceOrderDatelbl.Text = orderDetails.Rows[0]["OrderDate"].ToString();
            InvoiceDeliveryDatelbl.Text = OrderItem.Rows[0]["DeliveryDate"].ToString();
            
            for(int i = 0; i < OrderItem.Rows.Count; i++)
            {

                float temp = float.Parse(OrderItem.Rows[i]["Price"].ToString()) / float.Parse(OrderItem.Rows[i]["OrderedQuantity"].ToString()) * float.Parse(OrderItem.Rows[i]["DeliveryQuantity"].ToString());
                
                float unitprice;
                if((int.Parse(OrderItem.Rows[0]["Discount"].ToString())) == 100)
                {
                    unitprice = temp / int.Parse(OrderItem.Rows[i]["DeliveryQuantity"].ToString());
                }
                else
                {
                    unitprice = temp / float.Parse(OrderItem.Rows[i]["DeliveryQuantity"].ToString()) * 100 / (100-int.Parse(OrderItem.Rows[0]["Discount"].ToString())) ;
                }
                this.InvoiceFormData.Rows.Add(OrderItem.Rows[i]["ProductID"].ToString(), OrderItem.Rows[i]["ProductName"].ToString(), OrderItem.Rows[i]["DeliveryQuantity"].ToString(), unitprice.ToString(), temp.ToString(), OrderItem.Rows[0]["Discount"].ToString());
            }
            
            InvoiceTotalPricelbl.Text = "CNY¥" + orderDetails.Rows[0]["TotalPrice"].ToString();
            float subtoal = 0;
            for (int j = 0; j < InvoiceFormData.Rows.Count; j++)
            {
                subtoal = subtoal + float.Parse(InvoiceFormData.Rows[j].Cells["Total"].Value.ToString());
            }
            InvoicesubTotallbl.Text = "CNY¥" + subtoal.ToString();
        }

        private void invoiceExitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
