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
            string dealername = dealerNameBox.Text.Trim();
            string dealerCompany = dealerCompanyNameBox.Text.Trim();
            string dealerMail = dealerMailBox.Text.Trim();
            string dealerPhoneNum = DealerPhoneNumBox.Text.Trim();
            string dealerAddress = dealerAddressBox.Text.Trim();
            if (string.IsNullOrEmpty(dealername))
            {
                MessageBox.Show("Please enter a dealer name.");
                dealerNameBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dealerCompany))
            {
                MessageBox.Show("Please enter a dealer company.");
                dealerCompanyNameBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dealerMail))
            {
                MessageBox.Show("Please enter a dealer mail address.");
                dealerMailBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dealerPhoneNum))
            {
                MessageBox.Show("Please enter a dealer phone number.");
                DealerPhoneNumBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dealerAddress))
            {
                MessageBox.Show("Please enter a dealer address.");
                dealerAddressBox.Focus();
                return;
            }
                        if (!IsValidEmail(dealerMail))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (!IsValidPhoneNumber(dealerPhoneNum))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }
            if (programMethod.createDealer(dealername, dealerCompany, dealerMail, dealerPhoneNum, dealerAddress))
            {
                MessageBox.Show("Dealer Successfully Created");
                dealerNameBox.Text = "";
                dealerCompanyNameBox.Text = "";
                dealerMailBox.Text = "";
                DealerPhoneNumBox.Text = "";
                dealerAddressBox.Text = "";
            }
            else {

            }
        }

        private void editDealerbtn_Click(object sender, EventArgs e)
        {
            var dealerDetails = programMethod.getDealerDetails(dealerID);
            string dealerid = dealerDetails.DealerID;
            string dealername = dealerNameBox.Text.Trim();
            string dealerCompany = dealerCompanyNameBox.Text.Trim();
            string dealerMail = dealerMailBox.Text.Trim();
            string dealerPhoneNum = DealerPhoneNumBox.Text.Trim();
            string dealerAddress = dealerAddressBox.Text.Trim();
            if (string.IsNullOrEmpty(dealername))
            {
                MessageBox.Show("Please enter a dealer name.");
                dealerNameBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dealerCompany))
            {
                MessageBox.Show("Please enter a dealer company.");
                dealerCompanyNameBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dealerMail))
            {
                MessageBox.Show("Please enter a dealer mail address.");
                dealerMailBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dealerPhoneNum))
            {
                MessageBox.Show("Please enter a dealer phone number.");
                DealerPhoneNumBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dealerAddress))
            {
                MessageBox.Show("Please enter a dealer address.");
                dealerAddressBox.Focus();
                return;
            }
            if (!IsValidEmail(dealerMail))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (!IsValidPhoneNumber(dealerPhoneNum))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }

            if (programMethod.updateDealerInfo(dealerid, dealername, dealerCompany, dealerMail, dealerPhoneNum, dealerAddress))
            {

                MessageBox.Show("Saved");
            }
            else
            {

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
                    MessageBox.Show("Dealer details not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNum)
        {
            return phoneNum.Length >= 6 && phoneNum.Length <= 13;
        }

    }
}
