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

        private void SalesOrder_Load(object sender, EventArgs e)
        {


            switch (_mode)
            {
                case OperationMode.View:
                    SetReadOnly(true);
                    break;
                case OperationMode.New:
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
            grnProductIDbox.Text = string.Empty;
            grnwarehousebox.Text = string.Empty;
            grnreceivedqtybox.Text = string.Empty;
            grnDateTimePicker.Value = DateTime.Now;

        }


        private void SetReadOnly(bool readOnly)
        {
            grnPOIDbox.ReadOnly = readOnly;
            grnProductIDbox.ReadOnly = readOnly;
            grnwarehousebox.ReadOnly = readOnly;
            grnreceivedqtybox.ReadOnly = readOnly;
            grnDateTimePicker.Enabled = readOnly;


            grnPOIDbox.ReadOnly = !readOnly;
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

        private void deliveryCreatebtn_Click(object sender, EventArgs e)
        {
            if (grnPOIDbox.Text == "" || grnwarehousebox.Text == "" || grnProductIDbox.Text == "" || grnreceivedqtybox.Text == "")
            {
                grnerrorlbl.Visible = true;
            }
            else
            {
                try
                {
                    if (programMethod.createGRN(grnPOIDbox.Text.Trim(), grnProductIDbox.Text.Trim(), grnwarehousebox.Text.Trim(), grnreceivedqtybox.Text.Trim(), grnDateTimePicker.Value.Date.ToString()))
                    {

                        programMethod.increaseStock(grnProductIDbox.Text.Trim(), grnreceivedqtybox.Text.Trim());
                        MessageBox.Show("Good Received Note Saved");
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Purchase ID  Recevied");
                    }
                }
                catch
                {
                    //MessageBox.Show("GRN error");
                }
            }
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

        }
    }
}
