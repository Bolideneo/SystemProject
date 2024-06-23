using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using ProgramMethod;

namespace ITP4519M
{
    public partial class RegisterForm : Form
    {
        private Dashboard _Dashboard;
        private OperationMode _mode;
        private string userID;
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        private bool isFormDragging = false;
        private Point formStartPoint;
        private bool isWrongFormat = false;
        private bool isWrongFormat2 = false;
        public event EventHandler OperationCompleted;



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
                    accountreadlbl.Visible = true;
                    accountlbl.Visible = false;
                    //         passwordAgainlbl.Visible = false;
                    accountEditlbl.Visible = false;
                    //       passwordlbl.Visible = false;
                    //        registerPasswordAgainBox.Visible = false;
                    //       registerPasswordBox.Visible = false;
                    registerClearBtn.Visible = false;
                    newAccountlabel.Visible = false;
                    createAccountBtn.Visible = false;
                    editAccountbtn.Visible = false;
                    SetReadOnly(true);
                    break;
                case OperationMode.New:
                    accountlbl.Visible = true;
                    newAccountlabel.Visible = true;
                    accountreadlbl.Visible = false;
                    accountEditlbl.Visible = false;
                    viewaccountlbl.Visible = false;
                    editAccountbtn.Visible = false;
                    ClearForm();
                    SetReadOnly(false);
                    break;
                case OperationMode.Edit:
                    accountreadlbl.Visible = true;
                    accountEditlbl.Visible = true;
                    editAccountbtn.Visible = true;
                    accountlbl.Visible = false;
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


        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            string username = registerUsernameBox.Text.Trim();
            string password = registerPasswordBox.Text.Trim();
            string confirmPassword = registerPasswordAgainBox.Text.Trim();
            string displayName = registerDisplaynameBox.Text.Trim();
            string title = titleBox.Text.Trim();
            string phoneNum = phoneNumBox.Text.Trim();
            string email = mailBox.Text.Trim();
            string department = departBox.GetItemText(this.departBox.SelectedItem);


            if (string.IsNullOrEmpty(username))
            {
                //MessageBox.Show("Please enter a username.");
                label2.Visible = true;
                pictureBox1.Visible = true;
                isWrongFormat = true;
                registerPasswordAgainBox.Focus();
                Refresh(); 
                //registerUsernameBox.Focus();
                //return;
            }
            else
            {
                label2.Visible = false;
                isWrongFormat = false;
                Refresh();
            }

            if (string.IsNullOrEmpty(displayName))
            {
                //MessageBox.Show("Please enter a display name.");
                label3.Visible = true;
                isWrongFormat2 = true;
                pictureBox3.Visible = true;
                registerPasswordAgainBox.Focus();
                // registerUsernameBox.Focus();
                Refresh();
                //return;
            }
            else
            {
                label3.Visible = false;
                isWrongFormat2 = false;
                Refresh();
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                registerPasswordBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please confirm your password.");
                registerPasswordAgainBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a title.");
                titleBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email address.");
                mailBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(phoneNum))
            {
                MessageBox.Show("Please enter a phone number.");
                phoneNumBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(department))
            {
                MessageBox.Show("Please select a department.");
                departBox.Focus();
                return;
            }

            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Password must be at least 8 characters long with uppercase, lowercase, digit, and special character.");
                registerPasswordBox.Text = "";
                registerPasswordAgainBox.Text = "";
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                registerPasswordBox.Text = "";
                registerPasswordAgainBox.Text = "";
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                mailBox.Text = "";
                return;
            }

            if (!IsValidPhoneNumber(phoneNum))
            {
                MessageBox.Show("Please enter a valid phone number.");
                phoneNumBox.Text = "";
                return;
            }

            if (programMethod.createUserAccount(
                username,
                password,
                confirmPassword,
                displayName,
                title,
                phoneNum,
                email,
                department))
            {
                MessageBox.Show("User Successfully Created");
                registerUsernameBox.Text = "";
                registerPasswordBox.Text = "";
                registerPasswordAgainBox.Text = "";
                titleBox.Text = "";
                OperationCompleted?.Invoke(this, new EventArgs());
            }
            else
            {

            }
        }

        private bool IsPasswordValid(string password)
        {

            var passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, passwordPattern);
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
            string username = registerUsernameBox.Text.Trim();
            string password = registerPasswordBox.Text.Trim();
            string confirmPassword = registerPasswordAgainBox.Text.Trim();
            string displayName = registerDisplaynameBox.Text.Trim();
            string title = titleBox.Text.Trim();
            string phoneNum = phoneNumBox.Text.Trim();
            string email = mailBox.Text.Trim();
            string department = departBox.GetItemText(this.departBox.SelectedItem);

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                registerUsernameBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(displayName))
            {
                MessageBox.Show("Please enter a display name.");
                registerPasswordBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                registerPasswordBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please confirm your password.");
                registerPasswordAgainBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a title.");
                titleBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email address.");
                mailBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(phoneNum))
            {
                MessageBox.Show("Please enter a phone number.");
                phoneNumBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(department))
            {
                MessageBox.Show("Please select a department.");
                departBox.Focus();
                return;
            }

            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Password must be at least 8 characters long with uppercase, lowercase, digit, and special character.");
                registerPasswordBox.Text = "";
                registerPasswordAgainBox.Text = "";
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                registerPasswordBox.Text = "";
                registerPasswordAgainBox.Text = "";
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (!IsValidPhoneNumber(phoneNum))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }

            if (programMethod.updateUserInfor(userid, username, password, confirmPassword, displayName, department, title, phoneNum, email))
            {

                MessageBox.Show("Saved");
                OperationCompleted?.Invoke(this, new EventArgs());


            }
            else
            {


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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (isWrongFormat)
            {
                ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

            if (isWrongFormat2)
            {
                ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            }
        }
    }
}
