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

        private void createDealerBtn_Click(object sender, EventArgs e)

        {
            if (programMethod.createDealer(dealerNameBox.Text.Trim(), dealerCompanyNameBox.Text.Trim(), dealerMailBox.Text.Trim(), DealerPhoneNumBox.Text.Trim(), dealerAddressBox.Text.Trim()))
            {
                MessageBox.Show("User Successfully Created");
                dealerNameBox.Text = "";
                dealerCompanyNameBox.Text = "";
                dealerMailBox.Text = "";
                DealerPhoneNumBox.Text = "";
                dealerAddressBox.Text = "";
            }
            else {
                MessageBox.Show("Please input correct information");
            }
        }

        private void editDealerbtn_Click(object sender, EventArgs e)
        {
            var dealerDetails = programMethod.getDealerDetails(dealerID);
            string dealerid = dealerDetails.DealerID;

            if (programMethod.updateDealerInfo(dealerid, dealerNameBox.Text.Trim(), dealerCompanyNameBox.Text.Trim(), dealerMailBox.Text.Trim(), DealerPhoneNumBox.Text.Trim(), dealerAddressBox.Text.Trim()))
            {

                MessageBox.Show("Saved");
            }
            else
            {

                MessageBox.Show("Please input correct information");
            }
        }

        public void dealerEdit(string dealerID)
        {

            this.dealerID = dealerID;

            try
            {

                var dealerDetails = programMethod.getDealerDetails(dealerID);
                if (dealerDetails != null)
                {
                    this.dealerNameBox.Text = dealerDetails.DealerName;
                    this.dealerCompanyNameBox.Text = dealerDetails.DealerCompanyName;
                    this.dealerMailBox.Text = dealerDetails.DealerEmailAddress;
                    this.DealerPhoneNumBox.Text = dealerDetails.DealerPhoneNum;
                    this.dealerAddressBox.Text = "STELLAR BEAUTY BIOTECH CO, LTD"; //dealerDetails.DealerEmailAddress;

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
