using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Runtime.InteropServices;



namespace ITP4519M
{

    public partial class DeliveryForm : Form
    {




        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void DeliveryForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void deliveryPrintbtn_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            Close();
        }


        private void btn_print_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

    }
}

