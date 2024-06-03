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
        private bool isFormDragging = false;
        private Point formStartPoint;


        public RegisterForm(OperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }


        private void label6_Click(object sender, EventArgs e)
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
                    viewaccountlbl.Visible = true;
                    passwordAgainlbl.Visible = false;
                    passwordlbl.Visible = false;
                    registerPasswordAgainBox.Visible = false;
                    registerPasswordBox.Visible = false;
                    registerClearBtn.Visible = false;
                    newAccountlabel.Visible = false;
                    createAccountBtn.Visible = false;
                    editAccountbtn.Visible = false;
                    SetReadOnly(true);
                    break;
                case OperationMode.New:
                    newAccountlabel.Visible = true;
                    accountEditlbl.Visible = false;
                    viewaccountlbl.Visible = false;
                    editAccountbtn.Visible = false;
                    ClearForm();
                    SetReadOnly(false);
                    break;
                case OperationMode.Edit:
                    accountEditlbl.Visible = true;
                    editAccountbtn.Visible = true;
                    createAccountBtn.Visible = false;
                    newAccountlabel.Visible = false;
                    viewaccountlbl.Visible = false;
                    SetReadOnly(false);
                    break;
                case OperationMode.Disable:
                    accountEditlbl.Visible = true;
                    editAccountbtn.Visible = true;
                    createAccountBtn.Visible = false;
                    newAccountlabel.Visible = false;
                    viewaccountlbl.Visible = false;
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
            titleBox.Text = string.Empty;


        }

        private void SetReadOnly(bool readOnly)
        {

            registerUsernameBox.ReadOnly = readOnly;
            registerDisplaynameBox.ReadOnly = readOnly;
            registerPasswordBox.ReadOnly = readOnly;
            registerPasswordAgainBox.ReadOnly = readOnly;
            mailBox.ReadOnly = readOnly;
            phoneNumBox.ReadOnly = readOnly;
            titleBox.ReadOnly = readOnly;


            registerUsernameBox.Enabled = !readOnly;
            registerDisplaynameBox.Enabled = !readOnly;
            registerPasswordBox.Enabled = !readOnly;
            registerPasswordAgainBox.Enabled = !readOnly;
            mailBox.Enabled = !readOnly;
            phoneNumBox.Enabled = !readOnly;
            departBox.Enabled = true;
            titleBox.Enabled = !readOnly;

        }

        private void departBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        //public bool createUserAccount(string username, string password, string passwordagain, string dispalynanme, string title, string phonenum, string email, string department)

        private void createAccountBtn_Click(object sender, EventArgs e)

        {

            if (programMethod.createUserAccount(registerUsernameBox.Text.Trim(), registerPasswordBox.Text.Trim(), registerPasswordAgainBox.Text.Trim(), registerDisplaynameBox.Text.Trim(), titleBox.Text.Trim(), phoneNumBox.Text.Trim(), mailBox.Text.Trim(), departBox.GetItemText(this.departBox.SelectedItem)))
            {
                MessageBox.Show("User Successfully Created");
                registerUsernameBox.Text = "";
                registerPasswordBox.Text = "";
                registerPasswordAgainBox.Text = "";
                titleBox.Text = "";
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
                    this.departBox.SelectedItem = userDetails.Department;
                    this.titleBox.Text = userDetails.Title;
                    this.registerDisplaynameBox.Text = userDetails.DisplayName;

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
        //String userName, string password, string passwordagain, string dispalyName, string department, string title, string phonenum, string email

        private void editAccountbtn_Click(object sender, EventArgs e)
        {
            var userDetails = programMethod.getUserDetails(userID);
            string userid = userDetails.UserID;

            if (programMethod.updateUserInfor(userid, registerUsernameBox.Text.Trim(), registerPasswordBox.Text.Trim(), registerPasswordAgainBox.Text.Trim(), registerDisplaynameBox.Text.Trim(), departBox.GetItemText(this.departBox.SelectedItem), titleBox.Text.Trim(), phoneNumBox.Text.Trim(), mailBox.Text.Trim()))
            {

                MessageBox.Show("Saved");
            }
            else
            {

                MessageBox.Show("Please input same password");
            }
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isFormDragging = true;
                formStartPoint = e.Location;
            }
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isFormDragging)
            {
                int deltaX = e.X - formStartPoint.X;
                int deltaY = e.Y - formStartPoint.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void RegisterForm_MouseUp(object sender, MouseEventArgs e)
        {
            isFormDragging = false;
        }
    }
}
