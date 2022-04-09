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
    public partial class MainMenu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, 
                                    IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]  
        public static extern bool ReleaseCapture();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Creator(object sender, EventArgs e)
        {
            Created_By creators = new Created_By();
            creators.Show();
        }

        private void InformationRect(object sender, EventArgs e)
        {

        }

        private void DrawingShape(object sender, EventArgs e)
        {
            Drawingg rectangdraw = new Drawingg();
            rectangdraw.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        

        private void TitleBars_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
            }
        }
    }
}
