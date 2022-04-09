using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; 

namespace Rectangular
{
    public partial class Drawingg : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg,
                                    IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Drawingg()
        {
            InitializeComponent();
        }



        // Making Sharps
        private void DrawingButton_Click(object sender, EventArgs e)
        {
            float x = float.Parse(x_point.Text);
            float y = float.Parse(y_point.Text);

            float height = float.Parse(rect_height.Text);
            float weight = float.Parse(rect_weight.Text);


            DrawRectangle(x, y, weight, height);

        }

        // Create location and size of rectangle.
        //int x = 0;
        //int y = 0;
        //int width = 200;
        //int height = 200;



        // Draw rectangle to screen.
        //e.Graphics.DrawRectangle(blackPen, x, y, width, height);
        public void DrawRectangle(float x, float y, float w, float h )
        {

            //double x1,y1,x2,y2,left,right,top,bottom;
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);
            Bitmap pic = new Bitmap(this.Width, this.Height);

            Graphics g = Graphics.FromImage(pic);

            g.FillRectangle(Brushes.DarkTurquoise, x, y, w, y);



            //e.Graphics.DrawRectangle(blackPen, x, y, width, height);


            PictureDraws.Image = pic;
        }

        private void PictureDraws_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
            }
        }
    }

    
}
