using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Student_Management_System
{
    public partial class MainMenuForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public MainMenuForm()
        {
            InitializeComponent();
            this.pictureBox1.BackColor = Color.Transparent;
            this.TitleLbl.BackColor= Color.Transparent;
            this.label1.BackColor= Color.Transparent;
            this.label2.BackColor= Color.Transparent;
            this.label3.BackColor= Color.Transparent;
            this.StudentPbox.BackColor= Color.Transparent;
            this.SubjPbox.BackColor= Color.Transparent;
            this.SchedPbox.BackColor = Color.Transparent;
            this.EnrPbox.BackColor = Color.Transparent;
            this.label4.BackColor= Color.Transparent;
            this.label5.BackColor= Color.Transparent;
            this.label6.BackColor= Color.Transparent;
            this.label7.BackColor= Color.Transparent;
            this.label8.BackColor= Color.Transparent;
            this.label8.Font = new Font("Microsoft Sans Serif", 5, FontStyle.Bold);
            this.label9.BackColor= Color.Transparent;
            this.pictureBox2.BackColor = Color.Transparent;
        }

        //Draggable Panel 
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        ///Button Functions EXIT and MINIMIZE
        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Picturebox Function for each form

        /// <summary>
        ///PictureBox Click Method for Student Entry form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StdEntry_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentEntryForm StudEntry = new StudentEntryForm();
            StudEntry.Show();
        }

        /// <summary>
        /// PictureBox Click Method for Subject Entry form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubjEntry_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubjectEntryForm SubjEntry = new SubjectEntryForm();
            SubjEntry.Show();
        }

        /// <summary>
        /// PictureBox Click Method for Subject Schedule Entry form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubjSchedEntry_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubjectScheduleEntryForm SubjSched = new SubjectScheduleEntryForm();
            SubjSched.Show();

        }

        /// <summary>
        /// PictureBox Click Method for Student Enrollment Entry Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentEnrollmentEntryForm StudEnrollForm = new StudentEnrollmentEntryForm();
            StudEnrollForm.Show();

        }

        /// <summary>
        /// PictureBox Click Method for About the Dev
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dev_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutDev dev = new AboutDev();
            dev.Show();

        }
    }
}
