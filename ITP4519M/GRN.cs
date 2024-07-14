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
using Mysqlx.Crud;
using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Bcpg.OpenPgp;


namespace ITP4519M
{
    public partial class GRN : Form
    {
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        private OperationMode _mode;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private DataTable dt;

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
            this.KeyPreview = true;

            switch (_mode)
            {
                case OperationMode.View:
                    SetReadOnly(true);
                    break;
                case OperationMode.New:
                    grnDateTimePicker.MinDate = DateTime.Now;
                    grnPOIDbox.SelectedIndex = -1;
                    programMethod.GRNSearchAutoComplete(grnPOIDbox);
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                return;
            }
            else
            {

                try
                {
                    string poID = grnPOIDbox.Text;
                    if(errorlbl.Visible == true)
                    {
                        grnerrorlbl.Visible = true;
                        return;
                    }
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
            if (grnPOIDbox.SelectedIndex == -1)
            {
                return;
            }
            if (grnPOIDbox.SelectedItem.ToString() == "------------New Order------------"  || grnPOIDbox.SelectedItem.ToString() == "-----------Outstanding------------")
            {
                grnPOIDbox.SelectedIndex = -1;
                return;
            }
            grnProductData.Rows.Clear();
            grnProductData.Refresh();
            if (grnPOIDbox.SelectedIndex > 0)
            {
                string selectedItem = grnPOIDbox.SelectedItem.ToString();
                Cursor.Current = Cursors.Default;
                dt = programMethod.getPurchaseOrderProductIDAndQty(grnPOIDbox.Text.Trim());
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

        private void GRN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void grnProductData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (int.Parse(grnProductData.Rows[e.RowIndex].Cells[4].Value.ToString()) < 0)
                {
                    Font boldFont = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    grnProductData.Rows[e.RowIndex].Cells[4].Style.ForeColor = Color.Red;
                    errorlbl.Visible = true;
                    return;

                }
                else
                {
                    grnProductData.Rows[e.RowIndex].Cells[4].Style.ForeColor = Color.Black;
                    errorlbl.Visible = false;
                }

                    if (int.Parse(grnProductData.Rows[e.RowIndex].Cells[4].Value.ToString())  > int.Parse(dt.Rows[e.RowIndex]["OrderQuantity"].ToString()))
                    {
                        grnProductData.Rows[e.RowIndex].Cells[4].Style.ForeColor = Color.Red;
                        errorlbl.Visible = true;
                        return;
                    }
                    else
                    {
                    grnProductData.Rows[e.RowIndex].Cells[4].Style.ForeColor = Color.Black;
                        errorlbl.Visible = false;

                    }

                for (int i = 0; grnProductData.Rows.Count > i; i++)
                {
                    if (grnProductData.Rows[i].Cells[4].Style.ForeColor == Color.Red)
                    {
                        errorlbl.Visible = true;
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                grnProductData.Rows[e.RowIndex].Cells[4].Style.ForeColor = Color.Red;
                errorlbl.Visible = true;
            }
        }
    }
}
