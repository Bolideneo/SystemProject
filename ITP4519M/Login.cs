using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ProgramMethod;
using MySql.Data.MySqlClient;

namespace ITP4519M
{
    public partial class Login : Form
    {

        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        public Point mouseLocation;


        public Login()
        {
            InitializeComponent();
        }



        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accountBox_TextChanged(object sender, EventArgs e)
        {
            usernameBox.BackColor = Color.White;
            accountPanel.BackColor = Color.White;

        }

        private void accountPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (programMethod.verifyUser(usernameBox.Text.Trim(), passwordBox.Text.Trim()))
            {
                errolabel.Visible = false;
                var userDisplayName = programMethod.getUserDisplayName(usernameBox.Text.Trim());
                var userDepartment = programMethod.getUserDepartment(usernameBox.Text.Trim());
                Dashboard dashboard = new Dashboard();
                dashboard.ButtonLocation(programMethod.getPermission(usernameBox.Text.Trim()));
                dashboard.currentUserDisplayName(userDisplayName, userDepartment);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                errolabel.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
