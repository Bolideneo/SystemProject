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

        public class PanelEx : Panel
        {
            public PanelEx()
            {
                BorderStyle = BorderStyle.FixedSingle;
            }
            private Color borderColor = Color.Blue;
            [DefaultValue(typeof(Color), "Blue")]
            public Color BorderColor
            {
                get { return borderColor; }
                set
                {
                    if (borderColor != value)
                    {
                        borderColor = value;
                        Redraw();
                    }
                }
            }
            private int borderWidth = 5;
            [DefaultValue(16)]
            public int BorderWidth
            {
                get { return borderWidth; }
                set
                {
                    if (value == 0)
                        throw new ArgumentException("The value should be greater than 0");
                    if (borderWidth != value)
                    {
                        borderWidth = value;
                        RecalculateClientSize();
                    }
                }
            }

            protected override void WndProc(ref Message m)
            {
                if (BorderStyle != BorderStyle.FixedSingle)
                {
                    base.WndProc(ref m);
                    return;
                }
                if (m.Msg == Win32Helpers.WM_NCPAINT)
                {
                    base.WndProc(ref m);
                    WmNCPaint(ref m);
                }
                else if (m.Msg == Win32Helpers.WM_NCCALCSIZE)
                {
                    base.WndProc(ref m);
                    WmNCCalcSize(ref m);
                }
                else if (m.Msg == Win32Helpers.WM_NCHITTEST)
                {
                    base.WndProc(ref m);
                    WmNCHitTest(ref m);
                }
                else
                    base.WndProc(ref m);

            }
            protected override void OnSizeChanged(EventArgs e)
            {
                base.OnSizeChanged(e);
                Redraw();
            }
            private void Redraw()
            {
                Win32Helpers.RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                   Win32Helpers.RDW_FRAME | Win32Helpers.RDW_INVALIDATE | Win32Helpers.RDW_UPDATENOW);
            }
            private void RecalculateClientSize()
            {
                Win32Helpers.SetWindowPos(this.Handle, IntPtr.Zero, 0, 0, 0, 0,
                    Win32Helpers.SWP_NOSIZE | Win32Helpers.SWP_NOMOVE | Win32Helpers.SWP_FRAMECHANGED | Win32Helpers.SWP_NOZOORDER);
            }
            private void WmNCCalcSize(ref Message m)
            {
                if (BorderStyle != BorderStyle.FixedSingle)
                    return;

                if (m.WParam != IntPtr.Zero)
                {
                    var nccsp = (Win32Helpers.NCCALCSIZE_PARAMS)Marshal.PtrToStructure(m.LParam, typeof(Win32Helpers.NCCALCSIZE_PARAMS));
                    nccsp.rgrc[0].top += borderWidth - 1;
                    nccsp.rgrc[0].bottom -= borderWidth - 1;
                    nccsp.rgrc[0].left += borderWidth - 1;
                    nccsp.rgrc[0].right -= borderWidth - 1;
                    Marshal.StructureToPtr(nccsp, m.LParam, true);
                    Win32Helpers.InvalidateRect(this.Handle, nccsp.rgrc[0], true);
                    m.Result = IntPtr.Zero;
                }
                else
                {
                    var clnRect = (Win32Helpers.RECT)Marshal.PtrToStructure(m.LParam, typeof(Win32Helpers.RECT));
                    clnRect.top += borderWidth - 1;
                    clnRect.bottom -= borderWidth - 1;
                    clnRect.left += borderWidth - 1;
                    clnRect.right -= borderWidth - 1;
                    Marshal.StructureToPtr(clnRect, m.LParam, true);
                    m.Result = IntPtr.Zero;
                }
            }
            private void WmNCPaint(ref Message m)
            {
                var dc = Win32Helpers.GetWindowDC(Handle);
                using (var g = Graphics.FromHdc(dc))
                {
                    using (var p = new Pen(BorderColor, borderWidth) { Alignment = PenAlignment.Inset })
                    {
                        if (VScroll && HScroll)
                        {
                            Rectangle bottomCornerRectangle = new Rectangle(
                                Width - SystemInformation.VerticalScrollBarWidth - borderWidth,
                                Height - SystemInformation.HorizontalScrollBarHeight - borderWidth,
                                SystemInformation.VerticalScrollBarWidth,
                                SystemInformation.HorizontalScrollBarHeight);
                            if (RightToLeft == RightToLeft.Yes)
                            {
                                bottomCornerRectangle.X = Width - bottomCornerRectangle.Right;
                            }
                            g.FillRectangle(SystemBrushes.Control, bottomCornerRectangle);
                        }
                        var adjustment = borderWidth == 1 ? 1 : 0;
                        g.DrawRectangle(p, 0, 0, Width - adjustment, Height - adjustment);
                    }
                }
                Win32Helpers.ReleaseDC(Handle, dc);
                m.Result = IntPtr.Zero;
            }
            private void WmNCHitTest(ref Message m)
            {
                var pt = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                var rect = Parent.RectangleToScreen(Bounds);
                if (((pt.X >= rect.Left && pt.X <= rect.Left + borderWidth) ||
                    (pt.X >= rect.Right - borderWidth && pt.X <= rect.Right)) ||
                    ((pt.Y >= rect.Top && pt.Y <= rect.Top + borderWidth) ||
                    (pt.Y >= rect.Bottom - borderWidth && pt.Y <= rect.Bottom)))
                    m.Result = (IntPtr)Win32Helpers.HTBORDER;
            }
        }

        public static class Win32Helpers
        {
            public const int WM_NCPAINT = 0x85;
            public const int RDW_INVALIDATE = 0x0001,
                RDW_ERASE = 0x0004,
                RDW_ALLCHILDREN = 0x0080,
                RDW_ERASENOW = 0x0200,
                RDW_UPDATENOW = 0x0100,
                RDW_FRAME = 0x0400;
            public const int WM_NCCALCSIZE = 0x0083;
            public const int SWP_FRAMECHANGED = 0x0020,
                SWP_NOMOVE = 0x0002,
                SWP_NOSIZE = 0x0001,
                SWP_NOZOORDER = 0x0004;


            public const int WM_NCHITTEST = 0x0084;
            public const int HTBORDER = 18;
            public const int HTHSCROLL = 6;
            public const int HTVSCROLL = 7;
            public const int HTCLIENT = 1;

            [StructLayout(LayoutKind.Sequential)]
            public struct RECT
            {
                public int left, top, right, bottom;
            }
            [StructLayout(LayoutKind.Sequential)]
            public struct NCCALCSIZE_PARAMS
            {
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
                public RECT[] rgrc;
                public WINDOWPOS lppos;
            }
            [StructLayout(LayoutKind.Sequential)]
            public struct WINDOWPOS
            {
                public IntPtr hwnd;
                public IntPtr hwndInsertAfter;
                public int x;
                public int y;
                public int cx;
                public int cy;
                public uint flags;
            }
            public const int NM_FIRST = 0;
            public const int NM_CLICK = NM_FIRST - 2;
            public const int WM_REFLECT = 0x2000;
            public const int WM_NOFITY = 0x004e;
            public const int WM_CTLCOLORSCROLLBAR = 0x0137;
            [StructLayout(LayoutKind.Sequential)]
            public struct NMHDR
            {
                public IntPtr hwndFrom;
                public IntPtr idFrom;
                public int code;
            }
            [DllImport("user32.dll")]
            public static extern bool InvalidateRect(IntPtr hWnd, RECT lpRect, bool bErase);
            [DllImport("user32.dll")]
            public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
            [DllImport("user32")]
            public static extern IntPtr GetWindowDC(IntPtr hwnd);
            [DllImport("user32.dll")]
            public static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, int flags);
            [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
            public static extern IntPtr SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
        }


        public void viewDeliveryNote(string deliveryID, String orderID)
        {

            try
            {   //delivery, orderitem
                DataTable deliveryDetails = programMethod.getDeliveryDetails(deliveryID);
                //DataTable orderDetails = programMethod.getOrderDetails(orderID);
                DataTable deliveryNoteItem = programMethod.getDeliveryNoteItem(deliveryID);
                DataTable orderItemDeatails = programMethod.getOrderItemDetailForDelivery(orderID);

                //int temp1 = 0;
                //int temp2 = 0;
                //int temp3 = 0;

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
            deliveryOrderidbox.ReadOnly = readOnly;
            deliveryIDbox.ReadOnly = readOnly;
            deliveryDatebox.ReadOnly = readOnly;
            deliveryWeightBox.ReadOnly = readOnly;
            deliveryQuqntiyFollow.ReadOnly = readOnly;
            deliveryQuantityDeliverdbox.ReadOnly = readOnly;
            deliveryPreQtyBox.ReadOnly = readOnly;
            deliveryAddressbox.ReadOnly = readOnly;
            deliveryPhoneBox.ReadOnly = readOnly;
            deliveryformData.ReadOnly = readOnly;


            deliveryOrderidbox.ReadOnly = !readOnly;
            deliveryIDbox.ReadOnly = !readOnly;
            deliveryDatebox.ReadOnly = !readOnly;
            deliveryWeightBox.ReadOnly = !readOnly;
            deliveryQuqntiyFollow.ReadOnly = !readOnly;
            deliveryQuantityDeliverdbox.ReadOnly = !readOnly;
            deliveryPreQtyBox.ReadOnly = !readOnly;
            deliveryAddressbox.ReadOnly = !readOnly;
            deliveryPhoneBox.ReadOnly = !readOnly;
            deliveryformData.ReadOnly = !readOnly;



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
    }
}

