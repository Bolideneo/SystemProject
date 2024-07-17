using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
using MySqlX.XDevAPI.Common;
using ProgramMethod;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITP4519M
{
    public partial class Delivery : Form
    {

        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        private OperationMode _mode;
        public event EventHandler OperationCompleted;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private string[] dateTime;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );


        public Delivery(OperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
            DeliverydateTimePicker.Value = DateTime.Today;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }


        private void Delivery_Load(object sender, EventArgs e)
        {

            programMethod.DeliverySearchAutoComplete(deliveryOrderidbox);
            deliveryOrderidbox.ValueMember = "OrderID";
            deliveryOrderidbox.SelectedIndex = -1;
            deliveryOrderidbox.Text = "";
            this.KeyPreview = true;

            //switch (_mode)
            //{
            //    case OperationMode.View:
            //        SetReadOnly(true);
            //        break;
            //    case OperationMode.New:
            //        ClearForm();
            //        SetReadOnly(false);
            //        break;
            //    case OperationMode.Edit:
            //        SetReadOnly(false);
            //        break;
            //}

            orderIDAlertlbl.Visible = false;
        }


        private void ClearForm()
        {

            deliveryOrderidbox.Text = string.Empty;
            deliveryDeliveryaddressbox.Text = string.Empty;
            deliveryPhoneNumbox.Text = string.Empty;
        }


        private void SetReadOnly(bool readOnly)
        {
            deliveryDeliveryaddressbox.ReadOnly = readOnly;
            deliveryPhoneNumbox.ReadOnly = readOnly;


            deliveryDeliveryaddressbox.ReadOnly = !readOnly;
            deliveryPhoneNumbox.ReadOnly = !readOnly;



        }


        private void deliveryCreatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(deliveryOrderidbox.Text) )
            {
                orderIDAlertlbl.Visible = true;

                deliveryOrderidbox.Focus();
                Refresh();
                return;
            }
            else
            {
                orderIDAlertlbl.Visible = false;
                Refresh();
            }

            if( orderDate.Visible == true)
            {
                DeliverydateTimePicker.BorderColor = Color.Red;
                orderDate.Visible = true;
                return;
            }

            try
            {
               
                if (programMethod.createDelivery(deliveryOrderidbox.Text.Trim(), DeliverydateTimePicker.Value.Date.ToString()))
                {
                    MessageBox.Show("Create Successfully");
                    OperationCompleted?.Invoke(sender, e);

                }
            }
            catch
            {
                MessageBox.Show("Delivery Error");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deliveryOrderidbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deliveryOrderidbox.SelectedIndex == -1)
            {
                return;
            }
            if (deliveryOrderidbox.SelectedItem.ToString() == "---------ALLPackaged----------" || deliveryOrderidbox.SelectedItem.ToString() == "------PartiallyPackaged--------")
            {
                deliveryOrderidbox.SelectedIndex = -1;
                return;
            }

            if (deliveryOrderidbox.Text == "")
            {
                return;
            }
             DeliverydateTimePicker.MinDate = DateTime.Parse("2024-01-01");
             DeliverydateTimePicker.MaxDate = DateTime.Parse("2025-01-01");
            //DeliverydateTimePicker.MaxDate = DateTime.Now.AddDays(1);
            dateTime = programMethod.getOrderDateForDelivery(deliveryOrderidbox.Text.Trim()); 
            DeliverydateTimePicker.MinDate = DateTime.Parse(dateTime[0]);
            DeliverydateTimePicker.MaxDate = DateTime.Parse(dateTime[1]);


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

        private void deliveryOrderidbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void DeliverydateTimePicker_ValueChanged(object sender, EventArgs e)
        {

            try
            {

                if (DeliverydateTimePicker.Value.DayOfWeek == DayOfWeek.Saturday || DeliverydateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    DeliverydateTimePicker.BorderColor = Color.Red;
                    orderDate.Visible = true;
                    // DeliverydateTimePicker.Value = DateTime.Parse(dateTime[0]);

                }
                else
                {
                    orderDate.Visible = false;
                    DeliverydateTimePicker.BorderColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                DeliverydateTimePicker.BorderColor = Color.Red;
                orderDate.Visible = true;
            }

        }

    }
}

