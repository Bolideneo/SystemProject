using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ITP4519M
{

    public partial class Login : Form
    {

        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        public Point mouseLocation;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(System.IntPtr hObject);



        public Login()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            IntPtr handle = CreateRoundRectRgn(0, 0, Width, Height, 40, 40);
            Region = System.Drawing.Region.FromHrgn(handle);
            DoubleBuffered = true;

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
                string userDisplayName = programMethod.getUserDisplayName(usernameBox.Text.Trim());
                string userDepartment = programMethod.getUserDepartment(usernameBox.Text.Trim());
                Dashboard dashboard = new Dashboard();
                string[] permisson = programMethod.getPermission(usernameBox.Text.Trim());
                dashboard.ButtonLocation(permisson[0], permisson[1]);
                dashboard.currentUserDisplayName(userDisplayName, userDepartment, programMethod.getUserID(usernameBox.Text.Trim()), userDisplayName);
                dashboard.StartPosition = FormStartPosition.CenterParent;
                dashboard.Show(this);
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
            string contactInfo = "If you forgot your password, please contact the IT department:\n\n" +
                     "Email: it_support@example.com\n" +
                     "Phone: (123) 456-7890\n" +
                     "Office Hours: 9 AM - 5 PM";

            MessageBox.Show(contactInfo, "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button2_Paint(object sender, PaintEventArgs e)
        {
        }

    }
}

