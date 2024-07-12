using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramMethod;
using static ITP4519M.DataBaseMethod;
using MySqlX.XDevAPI.Common;
using Mysqlx.Session;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;


namespace ITP4519M
{
    public partial class GRN : Form
    {
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        private OperationMode _mode;
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
    int nWidthEllipse, // height of ellipse
    int nHeightEllipse // width of ellipse
);

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(System.IntPtr hObject);


        public GRN(OperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
            IntPtr handle = CreateRoundRectRgn(0, 0, Width, Height, 40, 40);
            Region = System.Drawing.Region.FromHrgn(handle);
            DoubleBuffered = true;
        }

        private void GRN_Load(object sender, EventArgs e)
        {
            grnDateTimePicker.Value = DateTime.Now;

            switch (_mode)
            {
                case OperationMode.View:
                    SetReadOnly(true);
                    break;
                case OperationMode.New:
                    grnDateTimePicker.MinDate = DateTime.Now;
                    grnPOIDbox.SelectedIndex = -1;
                    grnPOIDbox.Text = "Select an item";
                    grnPOIDbox.DataSource = programMethod.grnAllPOID();
                    grnPOIDbox.ValueMember = "PurchaseOrderID";
                    ClearForm();
                    SetReadOnly(false);
                    break;
                    //case OperationMode.Edit:
                    //    SetReadOnly(false);
                    //    break;
            }
        }

        private void ClearForm()
        {

            grnPOIDbox.Text = string.Empty;
            grnProductData.Rows.Clear();

        }


        private void SetReadOnly(bool readOnly)
        {
            //grnPOIDbox.ReadOnly = readOnly;
            grnDateTimePicker.Enabled = readOnly;


          //  grnPOIDbox.ReadOnly = !readOnly;
            grnDateTimePicker.Enabled = !readOnly;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grnerrorlbl_Click(object sender, EventArgs e)
        {

        }

        private void deliveryClearbtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void grnCreatebtn_Click(object sender, EventArgs e)
        {
            if (grnPOIDbox.Text == "")
            {
                grnerrorlbl.Visible = true;
            }
            else
            {

                try
                {
                    string poID = grnPOIDbox.Text;
                    programMethod.createGRN(poID, grnProductData, grnDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));

                        for (int i = 0; i < grnProductData.Rows.Count; i++)
                       {

                       
                        programMethod.increaseStock(grnProductData.Rows[i].Cells[1].Value.ToString(), grnProductData.Rows[i].Cells[4].Value.ToString());
                        
                       }
                        MessageBox.Show("Good Received Note Created Successfully");
                        ClearForm();
                        //MessageBox.Show("Please try again!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void grnPOIDbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            grnProductData.Rows.Clear();
            grnProductData.Refresh();
            if (grnPOIDbox.SelectedIndex > 0 )
            {
                string selectedItem = grnPOIDbox.SelectedItem.ToString();
                Cursor.Current = Cursors.Default;
                DataTable dt = programMethod.getPurchaseOrderProductIDAndQty(grnPOIDbox.Text.Trim());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    grnProductData.Rows.Add(dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["OrderQuantity"].ToString(), "", 0);
                }
            }
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

        /*
        private void grnCreatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(grnPOIDbox.Text) || string.IsNullOrWhiteSpace(grnwarehousebox.Text))
            {
                grnerrorlbl.Visible = true;
            }
            else
            {
                try
                {
                    string purchaseOrderId = grnPOIDbox.Text.Trim();
                    string productid="";
                    string quantity="";
                    List<PurchaseOrderItem> items = programMethod.GetPurchaseOrderItems(purchaseOrderId);
                    foreach (var item in items)
                    {
                        bool grnCreated = programMethod.createGRN(
                            purchaseOrderId,
                            productid= item.ProductID.ToString(),
                            grnwarehousebox.Text.Trim(),
                           quantity=  item.Quantity.ToString(), 
                            grnDateTimePicker.Value.Date.ToString());

                        if (grnCreated)
                        {
                            programMethod.increaseStock(item.ProductID, item.Quantity);
                        }
                        else
                        {
                            MessageBox.Show($"Failed to create GRN for ProductID: {item.ProductID}");
                        }
                    }
                    MessageBox.Show(productid);
                    MessageBox.Show(quantity);
                    MessageBox.Show("Good Received Note Created Successfully");
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        */
    }
}
