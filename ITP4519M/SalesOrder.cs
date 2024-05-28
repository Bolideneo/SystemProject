using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4519M
{
    public partial class SalesOrder : Form
    {
        private OperationMode _mode;
        public SalesOrder(OperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                case OperationMode.Edit:
                    SetReadOnly(false);
                    break;
            }
        }

        private void ClearForm()
        {

            goodsAddressBox.Text = string.Empty;
            invoiceAddressBox.Text = string.Empty;
            orderCompleteDateBox.Text = string.Empty;
            orderIDBox.Text = string.Empty;
            orderStatusBox.Text = string.Empty;
            orderDateBox.Text = string.Empty;
            dealerIDBox.Text = string.Empty;
            dealerNameBox.Text = string.Empty;
            dealerCompanyBox.Text = string.Empty;
            phoneNumBox.Text = string.Empty;

        }

        private void SetReadOnly(bool readOnly)
        {

            goodsAddressBox.ReadOnly = readOnly;
            invoiceAddressBox.ReadOnly = readOnly;
            orderCompleteDateBox.ReadOnly = readOnly;
            orderIDBox.ReadOnly = readOnly;
            orderStatusBox.ReadOnly = readOnly;
            orderDateBox.ReadOnly = readOnly;
            dealerIDBox.ReadOnly = readOnly;
            dealerNameBox.ReadOnly = readOnly;
            dealerCompanyBox.ReadOnly = readOnly;
            phoneNumBox.ReadOnly = readOnly;

            goodsAddressBox.Enabled = !readOnly;
            invoiceAddressBox.Enabled = !readOnly;
            orderCompleteDateBox.Enabled = !readOnly;
            orderIDBox.Enabled = !readOnly;
            orderStatusBox.Enabled = !readOnly;
            orderDateBox.Enabled = !readOnly;
            dealerIDBox.Enabled = !readOnly;
            dealerNameBox.Enabled = !readOnly;
            dealerCompanyBox.Enabled = !readOnly;
            phoneNumBox.Enabled = !readOnly;
        }
    }
}
