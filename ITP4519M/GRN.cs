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


namespace ITP4519M
{
    public partial class GRN : Form
    {
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        private OperationMode _mode;

        public GRN(OperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }

        private void GRN_Load(object sender, EventArgs e)
        {
            

            switch (_mode)
            {
                case OperationMode.View:
                    SetReadOnly(true);
                    break;
                case OperationMode.New:
                    grnDateTimePicker.MinDate = DateTime.Now;
                    //DataTable dt = programMethod.grnAllPOID();
                    //for (int i = 0; i < dt.Rows.Count; i++)
                    //{
                    //    comboBox1.Items.Add(dt.Rows[i]["PurchaseOrderID"].ToString());
                    //}
                    comboBox1.DataSource = programMethod.grnAllPOID();
                    comboBox1.ValueMember = "PurchaseOrderID";
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

            grnPOIDbox1.Text = string.Empty;
            grnProductIDbox.Text = string.Empty;
            grnwarehousebox.Text = string.Empty;
            grnreceivedqtybox.Text = string.Empty;
            grnDateTimePicker.Value = DateTime.Now;

        }


        private void SetReadOnly(bool readOnly)
        {
            grnPOIDbox1.ReadOnly = readOnly;
            grnProductIDbox.ReadOnly = readOnly;
            grnwarehousebox.ReadOnly = readOnly;
            grnreceivedqtybox.ReadOnly = readOnly;
            grnDateTimePicker.Enabled = readOnly;


            grnPOIDbox1.ReadOnly = !readOnly;
            grnProductIDbox.ReadOnly = !readOnly;
            grnwarehousebox.ReadOnly = !readOnly;
            grnreceivedqtybox.ReadOnly = !readOnly;
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
            if (grnPOIDbox1.Text == "" || grnwarehousebox.Text == "" || grnProductIDbox.Text == "" || grnreceivedqtybox.Text == "")
            {
                grnerrorlbl.Visible = true;
            }
            else
            {
                try
                {
                    if (programMethod.createGRN(grnPOIDbox1.Text.Trim(), grnProductIDbox.Text.Trim(), grnwarehousebox.Text.Trim(), grnreceivedqtybox.Text.Trim(), grnDateTimePicker.Value.Date.ToString()))
                    {
                        programMethod.increaseStock(grnProductIDbox.Text.Trim(), grnreceivedqtybox.Text.Trim());
                        MessageBox.Show("Good Received Note Created Successfully");
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Please try again!");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void grnPOIDbox_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable dt = programMethod.getPurchaseOrderProductIDAndQty(grnPOIDbox1.Text.Trim());
            for(int i = 0; i < dt.Rows.Count; i++) {
                grnProductData.Rows.Add(dt.Rows[i]["SupplierID"].ToString(), dt.Rows[i]["ProductID"].ToString(), dt.Rows[i]["OrderQuantity"].ToString(), 0, 0);
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
