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
            DeliverydateTimePicker1.MinDate = DateTime.Today;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }


        private void Delivery_Load(object sender, EventArgs e)
        {

            deliveryOrderidbox.SelectedIndex = -1;
            deliveryOrderidbox.Text = "Select an item";
            deliveryOrderidbox.DataSource = programMethod.getOrderForDelivery();
            deliveryOrderidbox.ValueMember = "OrderID";

            //deliveryOutstandingbox.SelectedIndex = -1;
            //deliveryOutstandingbox.Text = "Select an item";
            //deliveryOutstandingbox.DataSource = programMethod.getOrderForOutstanding();
            //deliveryOutstandingbox.ValueMember = "OutstandingOrderID";

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




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void deliveryCreatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(deliveryOrderidbox.Text))
            {
                orderIDAlertlbl.Visible = true;

                deliveryOrderidbox.Focus();
                Refresh();
            }
            else
            {
                orderIDAlertlbl.Visible = false;
                Refresh();
            }


            try
            {
                if (programMethod.createDelivery(deliveryOrderidbox.Text.Trim(), DeliverydateTimePicker1.Value.Date.ToString()))
                {
                    MessageBox.Show("Create Successfully");
                    OperationCompleted?.Invoke(sender, e);

                }
                else
                {
                    MessageBox.Show("Order ID is wrong!");
                }
            }
            catch
            {
                MessageBox.Show("Delivery Error");
            }
        }

        private void deliveryDeliveryidbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deliveryOutstandingbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deliveryOrderidbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeliverydateTimePicker1.MinDate = DateTime.Parse("2024-01-01");
            DeliverydateTimePicker1.MaxDate = DateTime.Now.AddDays(1);
            string[] dateTime = programMethod.getOrderDateForDelivery(deliveryOrderidbox.Text.Trim());
            DeliverydateTimePicker1.MinDate = DateTime.Parse(dateTime[0]);
            DeliverydateTimePicker1.MaxDate = DateTime.Parse(dateTime[1]);

            //if (DeliverydateTimePicker1.Text.Contains("Saturday"))
            //{
            //    DeliverydateTimePicker1.Text = DeliverydateTimePicker1.Value.AddDays(2).ToString();
            //}
            //else if (DeliverydateTimePicker1.Text.Contains("Sunday"))
            //{
            //    DeliverydateTimePicker1.Text = DeliverydateTimePicker1.Value.AddDays(1).ToString();
            //}

        }


        private static bool IsWeekend(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday
                || date.DayOfWeek == DayOfWeek.Sunday;
        }


        private static DateTime GetNextWorkingDay(DateTime date)
        {
            do
            {
                date = date.AddDays(1);
            } while (IsWeekend(date));

            return date;
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

