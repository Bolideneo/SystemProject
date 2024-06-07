using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySqlX.XDevAPI.Common;
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
                    //ClearForm();
                    //SetReadOnly(false);
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
            deliveryDeliveryaddressbox.Text = string.Empty;
            deliveryPhoneNumbox.Text = string.Empty;
        }


        private void SetReadOnly(bool readOnly)
        {
            deliveryOrderidbox.ReadOnly = readOnly;
            deliveryDeliveryidbox.ReadOnly = readOnly;
            deliveryOutstandingbox.ReadOnly = readOnly;
            deliveryDeliveryaddressbox.ReadOnly = readOnly;
            deliveryPhoneNumbox.ReadOnly = readOnly;


            deliveryOrderidbox.ReadOnly = !readOnly;
            deliveryDeliveryidbox.ReadOnly = !readOnly;
            deliveryOutstandingbox.ReadOnly = !readOnly;
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
            try
            {
                DataTable InvoiceDetail = programMethod.getInvoiceDetails(deliveryDeliveryidbox.Text.Trim());

                if (InvoiceDetail.Rows.Count > 0)
                {   
                    deliveryInvoiceIDbox.Text = InvoiceDetail.Rows[0]["InvoiceID"].ToString();
                    deliveryDeliveryidbox.Text = InvoiceDetail.Rows[0]["DeliveryID"].ToString();

                }
                else
                {
                    MessageBox.Show("Please Try again");
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
    }
}

