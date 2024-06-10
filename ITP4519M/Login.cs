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
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Reflection.Metadata;

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
            DeleteObject(handle);
            DoubleBuffered = true;

        }

        class RoundTextBox : TextBox
        {
            [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect, // X-coordinate of upper-left corner or padding at start
                int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
                int nRightRect, // X-coordinate of lower-right corner or Width of the object
                int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                                //RADIUS, 
                int nheightRect, //height of ellipse 
                int nweightRect //width of ellipse
            );

            protected override void OnResize(EventArgs e)
            {
                base.OnResize(e);
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 30, 30)); 
            }
        }


            class RoundedButton : Button
        {
            public int rdus = 30;
            System.Drawing.Drawing2D.GraphicsPath GetRoundPath(RectangleF Rect, int radius)
            {
                float r2 = radius / 2f;
                System.Drawing.Drawing2D.GraphicsPath GraphPath = new System.Drawing.Drawing2D.GraphicsPath();
                GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
                GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
                GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
                GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
                GraphPath.AddArc(Rect.X + Rect.Width - radius,
                        Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
                GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
                GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
                GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
                GraphPath.CloseFigure();
                return GraphPath;
            }
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
                using (System.Drawing.Drawing2D.GraphicsPath GraphPath = GetRoundPath(Rect, rdus))
                {
                    this.Region = new Region(GraphPath);
                    using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
                    {
                        pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                        e.Graphics.DrawPath(pen, GraphPath);
                    }
                }
            }
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
                string[] permisson = programMethod.getPermission(usernameBox.Text.Trim());
                dashboard.ButtonLocation(permisson[0], permisson[1]);
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

        private void loginbtn_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30);
            button1.Region = Region.FromHrgn(ptr);
            DeleteObject(ptr);

        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            //IntPtr ptr = CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30);
            //button2.Region = Region.FromHrgn(ptr);
            //DeleteObject(ptr);
        }
    }
}
