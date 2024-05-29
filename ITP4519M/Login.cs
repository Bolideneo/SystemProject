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
                Dashboard loginForm = new Dashboard();
                loginForm.currentUserDisplayName(usernameBox.Text.Trim());
                loginForm.Show();
                this.Hide();
            }
            else
            {
                errolabel.Visible = true;
            }
        }

<<<<<<< HEAD
        private void Login_Load(object sender, EventArgs e)
=======
        private void label3_Click(object sender, EventArgs e)
>>>>>>> 45938bea4439c7074efa7e4b7914a66503aa7737
        {

        }
    }
}
