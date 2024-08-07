﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using ProgramMethod;
using Mysqlx.Crud;
using System.Web;
using MySqlX.XDevAPI.Common;
using System.Drawing.Drawing2D;


namespace ITP4519M
{

    public partial class DeliveryForm : Form
    {

        private OperationMode _mode;
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void DeliveryForm_Load(object sender, EventArgs e)
        {
        }


        public DeliveryForm(OperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
            //DeliverydateTimePicker1.MinDate = DateTime.Today;
        }


        private void Delivery_Load(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case OperationMode.View:
                    SetReadOnly(true);
                    break;
                case OperationMode.New:
                    //ClearForm();
                    //SetReadOnly(false);
                    break;
                    //case OperationMode.Edit:
                    //    SetReadOnly(false);
                    //    break;
            }
        }


        public void viewDeliveryNote(string deliveryID, String orderID)
        {

            try
            {  
                DataTable deliveryOrderDetails = programMethod.getDeliveryOfOrderDetails(deliveryID);
                int orderCount = programMethod.getMaxUpdateCount(orderID);
                DataTable deliveryNoteItem = programMethod.getOrderItemDetailforDeliveryANDInvoice(deliveryID);


                if (deliveryOrderDetails != null)
                {
                    this.deliveryOrderidbox.Text = orderID;
                    this.deliveryIDbox.Text = deliveryID;
                    this.deliveryDatebox.Text = deliveryOrderDetails.Rows[0]["DeliveryDate"].ToString();
                    this.deliveryAddressbox.Text = deliveryOrderDetails.Rows[0]["DeliveryAddress"].ToString();
                    this.deliveryPhoneBox.Text = deliveryOrderDetails.Rows[0]["DealerContactPhoneNum"].ToString();
                    this.deliveryWeightBox.Text = programMethod.GetProductWeight(orderID);

                   // this.deliveryPhoneBox.Text = orderDetails.Rows[0]["DealerContactPhoneNum"].ToString();


                    if (deliveryNoteItem.Rows.Count > 0)
                    {
                        for (int i = 0; i < deliveryNoteItem.Rows.Count; i++)

                        {
                            string productID = deliveryNoteItem.Rows[i]["ProductID"]?.ToString() ?? string.Empty;
                            string PreQtyDelivered = deliveryNoteItem.Rows[i]["PreQtyDelivered"]?.ToString() ?? string.Empty;
                            string quantityFollow = deliveryNoteItem.Rows[i]["QuantityToFollow"]?.ToString() ?? string.Empty;
                            string deliveryQuantity = deliveryNoteItem.Rows[i]["DeliveryQuantity"]?.ToString() ?? string.Empty;

                            this.deliveryformData.Rows.Add(productID, deliveryNoteItem.Rows[i]["ProductName"].ToString(), PreQtyDelivered, quantityFollow, deliveryQuantity);
                           
                        }
                    }

                }


                else
                {
                    MessageBox.Show("Deliery Details not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetReadOnly(bool readOnly)
        {
        //    deliveryOrderidbox.ReadOnly = readOnly;
        //    deliveryIDbox.ReadOnly = readOnly;
        //    deliveryDatebox.ReadOnly = readOnly;
        //    deliveryWeightBox.ReadOnly = readOnly;
        //    deliveryQuqntiyFollow.ReadOnly = readOnly;
        //    deliveryQuantityDeliverdbox.ReadOnly = readOnly;
        //    deliveryPreQtyBox.ReadOnly = readOnly;
        //    deliveryAddressbox.ReadOnly = readOnly;
        //    deliveryPhoneBox.ReadOnly = readOnly;
        //    deliveryformData.ReadOnly = readOnly;


        //    deliveryOrderidbox.ReadOnly = !readOnly;
        //    deliveryIDbox.ReadOnly = !readOnly;
        //    deliveryDatebox.ReadOnly = !readOnly;
        //    deliveryWeightBox.ReadOnly = !readOnly;
        //    deliveryQuqntiyFollow.ReadOnly = !readOnly;
        //    deliveryQuantityDeliverdbox.ReadOnly = !readOnly;
        //    deliveryPreQtyBox.ReadOnly = !readOnly;
        //    deliveryAddressbox.ReadOnly = !readOnly;
        //    deliveryPhoneBox.ReadOnly = !readOnly;
        //    deliveryformData.ReadOnly = !readOnly;



        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void deliveryPrintbtn_Click(object sender, EventArgs e)
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

        private void deliveryExitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

