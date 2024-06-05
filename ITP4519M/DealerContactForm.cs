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
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace ITP4519M
{
    public partial class DealerContactForm : Form
    {
        private OperationMode _mode;
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        private string dealerID;
        public DealerContactForm(OperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DealerContactForm_Load(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case OperationMode.Edit:
                    createDealerBtn.Visible = false;
                    break;
                case OperationMode.New:
                    editDealerbtn.Visible = false;
                    break;
            }
        }

        private void editDealerbtn_Click(object sender, EventArgs e)
        {
            var dealerDetails = programMethod.getDealerDetails(dealerID);
            string dealerid = dealerDetails.DealerID;

            if (programMethod.updateDealerInfo(dealerid,dealerNameBox.Text.Trim(), dealerCompanyNameBox.Text.Trim(), dealerMailBox.Text.Trim(), DealerPhoneNumBox.Text.Trim(), dealerAddressBox.Text.Trim()))
            {

                MessageBox.Show("Saved");
            }
            else
            {

                MessageBox.Show("Please input same password");
            }
        }

        public void dealerEdit(string dealerID)
        {

            this.dealerID = dealerID;

            try
            {

                var productDetails = programMethod.getDealerDetails(dealerID);
                if (productDetails != null)
                {
                    this.dealerNameBox.Text = productDetails.DealerName;
                    this.dealerCompanyNameBox.Text = productDetails.DealerCompanyName;
                    this.dealerMailBox.Text = productDetails.DealerCompanyName;
                    this.DealerPhoneNumBox.Text = productDetails.DealerPhoneNum;
                    this.dealerAddressBox.Text = productDetails.DealerEmailAddress;

                }
                else
                {
                    MessageBox.Show("Product details not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
