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
        private bool isWrongFormat_username = false;
        private bool isWrongFormat_displayname = false;
        private bool isWrongFormat_password = false;
        private bool isWrongFormat_passwordAgain = false;
        private bool isWrongFormat_mail = false;
        private bool isWrongFormat_phone = false;
        private bool isWrongFormat_title = false;
        private bool isWrongFormat_department = false;
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
                    //case OperationMode.Disable:
                    //    accountEditlbl.Visible = true;
                    //    editAccountbtn.Visible = true;
                    //    createAccountBtn.Visible = false;
                    //    newAccountlabel.Visible = false;
                    //    viewaccountlbl.Visible = false;
                    //    SetReadOnly(false);
                    //    break;


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
                usernameAlertlbl.Visible = true;
                usernameAlertBox.Visible = true;
                isWrongFormat_username = true;
                registerPasswordAgainBox.Focus();
                return;
                //registerUsernameBox.Focus();
                //return;
            }
            else
            {
                usernameAlertlbl.Visible = false;
                usernameAlertBox.Visible = false;
                isWrongFormat_username = false;
                Refresh();
            }

            if (string.IsNullOrEmpty(displayName))
            {
                //MessageBox.Show("Please enter a display name.");
                displaynameAlertlbl.Visible = true;
                isWrongFormat_displayname = true;
                displaynameAlertBox.Visible = true;
                registerDisplaynameBox.Focus();
                // registerUsernameBox.Focus();
                return;
                //return;
            }
            else
            {
                displaynameAlertlbl.Visible = false;
                displaynameAlertBox.Visible = false;
                isWrongFormat_displayname = false;
                Refresh();
            }

            if (string.IsNullOrEmpty(password) || !IsPasswordValid(password))
            {
                passwordNotelbl.ForeColor = Color.Red;
                passwordAlertBox.Visible = true;
                isWrongFormat_password = true;
                registerPasswordBox.Focus();
                return;
            }
            else
            {
                passwordAlertBox.Visible = false;
                isWrongFormat_password = false;
                Refresh();
            }

            if (string.IsNullOrEmpty(confirmPassword) || !IsPasswordValid(confirmPassword))
            {
                passwordNotelbl.ForeColor = Color.Red;
                passwordAgainAlertBox.Visible = true;
                isWrongFormat_passwordAgain = true;
                registerPasswordAgainBox.Focus();
                return;
            }
            else
            {
                if (password != confirmPassword)
                {
                    passwordNotelbl.Text = "Passwords do not match!";
                    passwordAgainAlertBox.Visible = true;
                    passwordNotelbl.ForeColor = Color.Red;
                    isWrongFormat_passwordAgain = true;
                    registerPasswordAgainBox.Focus();
                    Refresh();
                }
                else
                {
                    passwordAgainAlertBox.Visible = false;
                    isWrongFormat_passwordAgain = false;
                    Refresh();
                }
            }
            if (string.IsNullOrEmpty(email) || !IsValidEmail(email))
            {
                emailAlertlbl.ForeColor = Color.Red;
                mailAlertBox.Visible = true;
                isWrongFormat_mail = true;
                mailBox.Focus();
                return;
            }
            else
            {
                emailAlertlbl.Visible = false;
                isWrongFormat_mail = false;
                Refresh();
            }
            if (string.IsNullOrEmpty(phoneNum) || !IsValidPhoneNumber(phoneNum))
            {
                phoneAlertlbl.ForeColor = Color.Red;
                phoneAlertBox.Visible = true;
                isWrongFormat_phone = true;
                phoneNumBox.Focus();
                return;
            }
            else
            {
                phoneAlertlbl.Visible = false;
                isWrongFormat_phone = false;
                Refresh();
            }
            if (string.IsNullOrEmpty(title))
            {
                titleAlertlbl.Visible = true;
                titleAlertBox.Visible = true;
                isWrongFormat_title = true;
                titleBox.Focus();
                Refresh();
            }
            else
            {
                titleAlertlbl.Visible = false;
                isWrongFormat_title = false;
                Refresh();
            }

            if (string.IsNullOrEmpty(department))
            {
                departBox.BorderColor = Color.Red;
                departAlertlbl.Visible = true;
                isWrongFormat_department = true;
                departBox.Focus();
                return;
            }
            else
            {
                departBox.BorderColor = Color.SteelBlue;
                departAlertlbl.Visible = false;
                isWrongFormat_department = false;
                departBox.Focus();
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
                //MessageBox.Show("Please enter a username.");
                usernameAlertlbl.Visible = true;
                usernameAlertBox.Visible = true;
                isWrongFormat_username = true;
                registerPasswordAgainBox.Focus();
                return;
                //registerUsernameBox.Focus();
                //return;
            }
            else
            {
                usernameAlertlbl.Visible = false;
                usernameAlertBox.Visible = false;
                isWrongFormat_username = false;
                Refresh();
            }

            if (string.IsNullOrEmpty(displayName))
            {
                //MessageBox.Show("Please enter a display name.");
                displaynameAlertlbl.Visible = true;
                isWrongFormat_displayname = true;
                displaynameAlertBox.Visible = true;
                registerDisplaynameBox.Focus();
                // registerUsernameBox.Focus();
                return;
                //return;
            }
            else
            {
                displaynameAlertlbl.Visible = false;
                displaynameAlertBox.Visible = false;
                isWrongFormat_displayname = false;
                Refresh();
            }

            if (string.IsNullOrEmpty(password) || !IsPasswordValid(password))
            {
                passwordNotelbl.ForeColor = Color.Red;
                passwordAlertBox.Visible = true;
                isWrongFormat_password = true;
                registerPasswordBox.Focus();
                return;
            }
            else
            {
                passwordAlertBox.Visible = false;
                isWrongFormat_password = false;
                Refresh();
            }

            if (string.IsNullOrEmpty(confirmPassword) || !IsPasswordValid(confirmPassword))
            {
                passwordNotelbl.ForeColor = Color.Red;
                passwordAgainAlertBox.Visible = true;
                isWrongFormat_passwordAgain = true;
                registerPasswordAgainBox.Focus();
                return;
            }
            else
            {
                if (password != confirmPassword)
                {
                    passwordNotelbl.Text = "Passwords do not match!";
                    passwordAgainAlertBox.Visible = true;
                    passwordNotelbl.ForeColor = Color.Red;
                    isWrongFormat_passwordAgain = true;
                    registerPasswordAgainBox.Focus();
                    Refresh();
                }
                else
                {
                    passwordAgainAlertBox.Visible = false;
                    isWrongFormat_passwordAgain = false;
                    Refresh();
                }
            }
            if (string.IsNullOrEmpty(email) || !IsValidEmail(email))
            {
                emailAlertlbl.ForeColor = Color.Red;
                mailAlertBox.Visible = true;
                isWrongFormat_mail = true;
                mailBox.Focus();
                return;
            }
            else
            {
                emailAlertlbl.Visible = false;
                isWrongFormat_mail = false;
                Refresh();
            }
            if (string.IsNullOrEmpty(phoneNum) || !IsValidPhoneNumber(phoneNum))
            {
                phoneAlertlbl.ForeColor = Color.Red;
                phoneAlertBox.Visible = true;
                isWrongFormat_phone = true;
                phoneNumBox.Focus();
                return;
            }
            else
            {
                phoneAlertlbl.Visible = false;
                isWrongFormat_phone = false;
                Refresh();
            }
            if (string.IsNullOrEmpty(title))
            {
                titleAlertlbl.Visible = true;
                titleAlertBox.Visible = true;
                isWrongFormat_title = true;
                titleBox.Focus();
                Refresh();
            }
            else
            {
                titleAlertlbl.Visible = false;
                isWrongFormat_title = false;
                Refresh();
            }

            if (string.IsNullOrEmpty(department))
            {
                departBox.BorderColor = Color.Red;
                departAlertlbl.Visible = true;
                isWrongFormat_department = true;
                departBox.Focus();
                return;
            }
            else
            {
                departBox.BorderColor = Color.SteelBlue;
                departAlertlbl.Visible = false;
                isWrongFormat_department = false;
                departBox.Focus();
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

        private void usernamepnl_Paint(object sender, PaintEventArgs e)
        {
            if (isWrongFormat_username)
            {
                ControlPaint.DrawBorder(e.Graphics, this.usernamepnl.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, this.usernamepnl.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            }
        }

        private void displaynamepnl_Paint(object sender, PaintEventArgs e)
        {

            if (isWrongFormat_displayname)
            {
                ControlPaint.DrawBorder(e.Graphics, this.displaynamepnl.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, this.displaynamepnl.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            }
        }//passwordpnl

        private void passwordpnl_Paint(object sender, PaintEventArgs e)
        {
            if (isWrongFormat_password)
            {
                ControlPaint.DrawBorder(e.Graphics, this.passwordpnl.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, this.passwordpnl.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            }
        }

        private void passwordAgainpnl_Paint(object sender, PaintEventArgs e)
        {
            if (isWrongFormat_passwordAgain)
            {
                ControlPaint.DrawBorder(e.Graphics, this.passwordAgainpnl.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, this.passwordAgainpnl.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            }
        }

        private void mailpnl_Paint(object sender, PaintEventArgs e)
        {
            if (isWrongFormat_mail)
            {
                ControlPaint.DrawBorder(e.Graphics, this.mailpnl.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, this.mailpnl.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            }
        }

        private void phonepnl_Paint(object sender, PaintEventArgs e)
        {
            if (isWrongFormat_phone)
            {
                ControlPaint.DrawBorder(e.Graphics, this.phonepnl.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, this.phonepnl.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            }
        }

        private void titilepnl_Paint(object sender, PaintEventArgs e)
        {
            if (isWrongFormat_title)
            {
                ControlPaint.DrawBorder(e.Graphics, this.titilepnl.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, this.titilepnl.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            }
        }
    }
}
