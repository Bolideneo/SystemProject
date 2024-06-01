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
using ProgramMethod;

namespace ITP4519M
{
    public partial class RegisterForm : Form
    {
        private OperationMode _mode;
        private string userID;
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        
        public RegisterForm(OperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            

            switch (_mode)
            {
                case OperationMode.View:
                    newAccountlabel.Visible = false;
                    SetReadOnly(true);
                    break;
                case OperationMode.New:
                    ClearForm();
                    SetReadOnly(false);
                    break;
                case OperationMode.Edit:
                    accountEditlbl.Visible = true;
                    newAccountlabel.Visible = false;
                    SetReadOnly(false);
                    break;
            }
        }
        private void ClearForm()
        {

            registerUsernameBox.Text = string.Empty;
            registerDisplaynameBox.Text = string.Empty;
            registerPasswordBox.Text = string.Empty;
            registerPasswordAgainBox.Text = string.Empty;
            mailBox.Text = string.Empty;
            phoneNumBox.Text = string.Empty;
            departBox.Text = string.Empty;
            positionBox.Text = string.Empty;


        }

        private void SetReadOnly(bool readOnly)
        {

            registerUsernameBox.ReadOnly = readOnly;
            registerDisplaynameBox.ReadOnly = readOnly;
            registerPasswordBox.ReadOnly = readOnly;
            registerPasswordAgainBox.ReadOnly = readOnly;
            mailBox.ReadOnly = readOnly;
            phoneNumBox.ReadOnly = readOnly;


            registerUsernameBox.Enabled = !readOnly;
            registerDisplaynameBox.Enabled = !readOnly;
            registerPasswordBox.Enabled = !readOnly;
            registerPasswordAgainBox.Enabled = !readOnly;
            mailBox.Enabled = !readOnly;
            phoneNumBox.Enabled = !readOnly;
            departBox.Enabled = true;
            positionBox.Enabled = true;

        }

        private void departBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createAccountBtn_Click(object sender, EventArgs e)

        {
            
            if (programMethod.createUserAccount(registerUsernameBox.Text.Trim(), registerPasswordBox.Text.Trim(), registerPasswordAgainBox.Text.Trim(), registerDisplaynameBox.Text.Trim(), departBox.GetItemText(this.departBox.SelectedItem), positionBox.Text.Trim()))
            {
                MessageBox.Show("User Successfully Created");
                registerUsernameBox.Text = "";
                registerPasswordBox.Text = "";
                registerPasswordAgainBox.Text = "";
                positionBox.Text = "";
            }
            else
            {
                MessageBox.Show("Password is not match!");
                registerPasswordBox.Text = "";
                registerPasswordAgainBox.Text = "";
            }
        }

        private void registerUsernameBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ClearForm();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void accountEdit(string userID)
        {

            this.userID = userID;

            try
            {
                var userDetails = programMethod.getUserDetails(userID);
                if (userDetails != null)
                {
                    this.registerUsernameBox.Text = userDetails.UserName;
                    this.mailBox.Text = userDetails.EmailAddress;
                    this.phoneNumBox.Text = userDetails.PhoneNum;
                    this.departBox.Text = userDetails.DepartmentID;
                    // 填充更多控件...
                }
                else
                {
                    MessageBox.Show("User details not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void udpateUserInfo(object sender,EventArgs e)
        {
            if (programMethod.updateUserInfor(userID, registerUsernameBox.Text.Trim(), registerPasswordBox.Text.Trim(), registerPasswordAgainBox.Text.Trim(), registerDisplaynameBox.Text.Trim(), departBox.GetItemText(this.departBox.SelectedItem), positionBox.Text.Trim()))
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Please input same password");
            }
        }
    }
}
