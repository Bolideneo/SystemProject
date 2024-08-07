﻿using Microsoft.VisualBasic.ApplicationServices;
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
        public event EventHandler OperationCompleted;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

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
            dealerNamebtn.Visible = false;
            companyNameAlert.Visible = false;

            addressAlert.Visible = false;
            regionAlert.Visible = false;
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
            string dealerRegionNum = regionNumBox.Text.Trim();
            if (string.IsNullOrEmpty(dealername))
            {
                dealerNamebtn.Visible = true;
                dealerNameBox.Focus();
                return;
            }
            else
            {
                dealerNamebtn.Visible = false;
                Refresh();
            }
            if (string.IsNullOrEmpty(dealerCompany))
            {
                companyNameAlert.Visible = true;
                dealerCompanyNameBox.Focus();
                return;
            }
            else
            {
                companyNameAlert.Visible = false;
                Refresh();
            }
            if (string.IsNullOrEmpty(dealerMail) || !IsValidEmail(dealerMail))
            {
                mailAlert.ForeColor = Color.Red;
                dealerMailBox.Focus();
                return;
            }
            else
            {
                mailAlert.ForeColor = Color.SteelBlue;
                Refresh();
            }
            if (string.IsNullOrEmpty(dealerPhoneNum) || !IsValidPhoneNumber(dealerPhoneNum))
            {
                phoneAlertlbl.ForeColor = Color.Red;
                DealerPhoneNumBox.Focus();
                return;
            }
            else
            {
                phoneAlertlbl.ForeColor = Color.SteelBlue;
                Refresh();
            }
            if (string.IsNullOrEmpty(dealerRegionNum))
            {
                regionAlert.Visible = true;
                regionNumBox.Focus();
                return;

            }
            else
            {
                regionAlert.Visible = false;
                Refresh();

            }
            if (string.IsNullOrEmpty(dealerAddress))
            {
                addressAlert.Visible = true;
                dealerAddressBox.Focus();
                return;
            }
            else
            {
                addressAlert.Visible = false;
                Refresh();
            }

            if (programMethod.createDealer(dealername, dealerCompany, dealerMail, dealerPhoneNum, dealerRegionNum, dealerAddress))
            {
                MessageBox.Show("Dealer contract Successfully Added");
                dealerNameBox.Text = "";
                dealerCompanyNameBox.Text = "";
                dealerMailBox.Text = "";
                DealerPhoneNumBox.Text = "";
                dealerAddressBox.Text = "";
                OperationCompleted?.Invoke(this, new EventArgs());
                this.Close();
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
            string dealerRegionNum = regionNumBox.Text.Trim();
            if (string.IsNullOrEmpty(dealername))
            {
                dealerNamebtn.Visible = true;
                dealerNameBox.Focus();
                return;
            }
            else
            {
                dealerNamebtn.Visible = false;
                Refresh();
            }
            if (string.IsNullOrEmpty(dealerCompany))
            {
                companyNameAlert.Visible = true;
                dealerCompanyNameBox.Focus();
                return;
            }
            else
            {
                companyNameAlert.Visible = false;
                Refresh();
            }
            if (string.IsNullOrEmpty(dealerMail) || !IsValidEmail(dealerMail))
            {
                mailAlert.ForeColor = Color.Red;
                dealerMailBox.Focus();
                return;
            }
            else
            {
                mailAlert.ForeColor = Color.SteelBlue;
                Refresh();
            }
            if (string.IsNullOrEmpty(dealerPhoneNum) || !IsValidPhoneNumber(dealerPhoneNum))
            {
                phoneAlertlbl.ForeColor = Color.Red;
                DealerPhoneNumBox.Focus();
                return;
            }
            else
            {
                phoneAlertlbl.ForeColor = Color.SteelBlue;
                Refresh();
            }
            if (string.IsNullOrEmpty(dealerRegionNum))
            {
                regionAlert.Visible = true;
                regionNumBox.Focus();
                return;

            }
            else
            {
                regionAlert.Visible = false;
                Refresh();

            }
            if (string.IsNullOrEmpty(dealerAddress))
            {
                addressAlert.Visible = true;
                dealerAddressBox.Focus();
                return;
            }
            else
            {
                addressAlert.Visible = false;
                Refresh();
            }

            if (programMethod.updateDealerInfo(dealerid, dealername, dealerCompany, dealerMail, dealerPhoneNum, dealerRegionNum, dealerAddress))
            {

                MessageBox.Show("Saved");
                OperationCompleted?.Invoke(this, new EventArgs());
                this.Close();
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
                    this.regionNumBox.Text = dealerDetails.DealerRegionNum;
                    this.dealerAddressBox.Text = dealerDetails.DealerCompanyAddress; //dealerDetails.DealerEmailAddress;

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

    }
}
