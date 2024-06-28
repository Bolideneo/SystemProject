using System;
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
            {   //delivery, orderitem
                DataTable deliveryDetails = programMethod.getDeliveryDetails(deliveryID);
                //DataTable orderDetails = programMethod.getOrderDetails(orderID);
                DataTable deliveryNoteItem = programMethod.getDeliveryNoteItem(deliveryID);
                int orderCount = programMethod.getMaxUpdateCount(orderID);
                DataTable orderItemDeatails = programMethod.getOrderItemDetailForDelivery(orderID, orderCount);

                if (deliveryDetails != null)
                {
                    this.deliveryOrderidbox.Text = orderID;
                    this.deliveryIDbox.Text = deliveryID;
                    this.deliveryDatebox.Text = deliveryDetails.Rows[0]["DeliveryDate"].ToString();
                    if (orderItemDeatails.Rows.Count > 0)
                    {
                        for (int i = 0; i < deliveryNoteItem.Rows.Count; i++)
                        {
                            string productID = orderItemDeatails.Rows[i]["ProductID"]?.ToString() ?? string.Empty;
                            string productName = orderItemDeatails.Rows[i]["ProductName"]?.ToString() ?? string.Empty;
                            string PreQtyDelivered = deliveryNoteItem.Rows[i]["PreQtyDelivered"]?.ToString() ?? string.Empty;
                            string quantityFollow = deliveryNoteItem.Rows[i]["QuantityToFollow"]?.ToString() ?? string.Empty;
                            string deliveryQuantity = deliveryNoteItem.Rows[i]["DeliveryQuantity"]?.ToString() ?? string.Empty;

                            this.deliveryformData.Rows.Add(productID, productName, PreQtyDelivered, quantityFollow, deliveryQuantity);
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


        private void btn_print_Click(object sender, EventArgs e)
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

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deliveryQuantityDeliverdbox_Click(object sender, EventArgs e)
        {

        }

        private void deliveryIDbox_Click(object sender, EventArgs e)
        {

        }
    }
}

