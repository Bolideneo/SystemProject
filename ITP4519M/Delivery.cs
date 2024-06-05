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
    public partial class Delivery : Form
    {

        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        private OperationMode _mode;


        public Delivery(OperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }


        private void Delivery_Load(object sender, EventArgs e)
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

            deliveryOrderidbox.Text = string.Empty;
            deliveryDeliveryidbox.Text = string.Empty;
            deliveryOutstandingbox.Text = string.Empty;
            deliveryQtyfollowbox.Text = string.Empty;
            deliveryQtydeliverdbox.Text = string.Empty;
            deliveryDeliveryaddressbox.Text = string.Empty;
            deliveryDateTimePicker.Value = DateTime.Now;
            deliveryPhoneNumbox.Text = string.Empty;
            deliveryOderedquantitybox.Text = string.Empty;
        }


        private void SetReadOnly(bool readOnly)
        {
            deliveryOrderidbox.ReadOnly = readOnly;
            deliveryDeliveryidbox.ReadOnly = readOnly;
            deliveryOutstandingbox.ReadOnly = readOnly;
            deliveryQtyfollowbox.ReadOnly = readOnly;
            deliveryQtydeliverdbox.ReadOnly = readOnly;
            deliveryDeliveryaddressbox.ReadOnly = readOnly;
            deliveryDateTimePicker.Enabled = readOnly;
            deliveryPhoneNumbox.ReadOnly = readOnly;
            deliveryOderedquantitybox.ReadOnly = readOnly;


            deliveryOrderidbox.ReadOnly = !readOnly;
            deliveryDeliveryidbox.ReadOnly = !readOnly;
            deliveryOutstandingbox.ReadOnly = !readOnly;
            deliveryQtyfollowbox.ReadOnly = !readOnly;
            deliveryQtydeliverdbox.ReadOnly = !readOnly;
            deliveryDeliveryaddressbox.ReadOnly = !readOnly;
            deliveryDateTimePicker.Enabled = !readOnly;
            deliveryPhoneNumbox.ReadOnly = !readOnly;
            deliveryOderedquantitybox.ReadOnly = !readOnly;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void deliveryCreatebtn_Click(object sender, EventArgs e)
        {
            if (deliveryOrderidbox.Text == "" || deliveryOrderidbox.Text == "" )
            {
                //grnerrorlbl.Visible = true;
            }
            //else
            //{
            //    try
            //    {
            //        if (programMethod.createGRN(grnPOIDbox.Text.Trim(), grnProductIDbox.Text.Trim(), grnwarehousebox.Text.Trim(), grnreceivedqtybox.Text.Trim(), grnDateTimePicker.Value.Date.ToString()))
            //        {

            //            programMethod.increaseStock(grnProductIDbox.Text.Trim(), grnreceivedqtybox.Text.Trim());
            //            MessageBox.Show("Good Received Note Saved");
            //            ClearForm();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Purchase ID  Recevied");
            //        }
            //    }
            //    catch
            //    {
            //        //MessageBox.Show("GRN error");
            //    }
            }
        }
    }

