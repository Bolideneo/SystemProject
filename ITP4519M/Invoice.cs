﻿using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private System.Drawing.Printing.PrintDocument printDocument1;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        ProgramMethod.ProgramMethod programMethod;
        public Invoice(string invoiceID, string orderID, string dealerID, string deliveryID, string issueDate)
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

            try
            {
                programMethod = new ProgramMethod.ProgramMethod();
                DataTable OrderItem = programMethod.getOrderItemDetailforDeliveryANDInvoice(deliveryID);
                DataTable orderDetails = programMethod.getOrderDetails(orderID);
                InvoiceInvoiceDatelbl.Text = IssueDate;
                InvoiceOrderIDlbl.Text = orderID;
                InvoiceDealerIDlbl.Text = dealerID;
                InvoiceLabel1.Text = "Invoice #" + invoiceID;
                invoicesalespersonlbl.Text = programMethod.getInvoiceSalesPerson(invoiceID);

                InvoiceBillingAddresslbl.Text = orderDetails.Rows[0]["InvoiceAddress"].ToString();
                InvoiceAddresslbl.Text = orderDetails.Rows[0]["DeliveryAddress"].ToString();
                InvoiceOrderDatelbl.Text = orderDetails.Rows[0]["OrderDate"].ToString();
                InvoiceDeliveryDatelbl.Text = OrderItem.Rows[0]["DeliveryDate"].ToString();

                for (int i = 0; i < OrderItem.Rows.Count; i++)
                {

                    float temp = float.Parse(OrderItem.Rows[i]["Price"].ToString()) / float.Parse(OrderItem.Rows[i]["OrderedQuantity"].ToString()) * float.Parse(OrderItem.Rows[i]["DeliveryQuantity"].ToString());

                    float unitprice;
                    if ((int.Parse(OrderItem.Rows[0]["Discount"].ToString())) == 100)
                    {
                        unitprice = temp / int.Parse(OrderItem.Rows[i]["DeliveryQuantity"].ToString());
                    }
                    else
                    {
                        unitprice = temp / float.Parse(OrderItem.Rows[i]["DeliveryQuantity"].ToString()) * 100 / (100 - int.Parse(OrderItem.Rows[0]["Discount"].ToString()));
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
            }catch (Exception ex) { 
                    
                
            }
           
        }

        private void invoiceExitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void invoicePrintbtn_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }


        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Control.MousePosition;
            dragFormPoint = this.Location;
        }

        private void Dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Control.MousePosition, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
    }
}
