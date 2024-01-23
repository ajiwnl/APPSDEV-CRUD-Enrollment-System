using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Student_Management_System
{
    public partial class AboutDev : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public AboutDev()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(28, 44, 139);
        }

        private void ExBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm MenuForm = new MainMenuForm();
            MenuForm.Show();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void FB_Click(object sender, EventArgs e)
        {
            string fbUrl = "https://www.facebook.com/aggressiveplayer09";

            Process.Start(fbUrl);
        }

        private void IG_Click(object sender, EventArgs e)
        {
            string igUrl = "https://www.instagram.com/whyiamhated/";
            Process.Start(igUrl);
        }

        private void YT_Click(object sender, EventArgs e)
        {
            string ytUrl = "https://www.youtube.com/channel/UCViAO96J0aDStZLotrG71Dw";
            Process.Start(ytUrl);
        }
    }
}
