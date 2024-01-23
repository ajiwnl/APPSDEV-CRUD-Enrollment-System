using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient; //for Microsoft database server
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class StudentEntryForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public StudentEntryForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(28, 44, 139);

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

        //Button Functions SAVE, CANCEL, EXIT, MINIMIZE, BACK
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!FieldValidation())
            {
                return;
            }
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alvin\source\repos\Finals\Student Management System\APPSDEV22.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection
            SqlConnection = new SqlConnection(connectionString);
            string sql = "Select *From StudentFile WHERE STFSTUDID = @id";

            SqlDataAdapter thisAdapater = new SqlDataAdapter(sql, SqlConnection);
            thisAdapater.SelectCommand.Parameters.AddWithValue("@id", Convert.ToInt64(IdTxtbox.Text));
            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapater);
            DataSet thisDataSet = new DataSet();
            thisAdapater.Fill(thisDataSet, "StudentFile");

            if (thisDataSet.Tables["StudentFile"].Rows.Count > 0)
            {
                MessageBox.Show("Can't save data, Data already  exists.", "Student Entry: Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow thisRow = thisDataSet.Tables["StudentFile"].NewRow();
            thisRow["STFSTUDID"] = Convert.ToInt64(IdTxtbox.Text);
            thisRow["STFSTUDFNAME"] = FNameTxtbox.Text;
            thisRow["STFSTUDLNAME"] = LNameTxtbox.Text;
            thisRow["STFSTUDMNAME"] = MITxtbox.Text;
            thisRow["STFSTUDCOURSE"] = CourseTxtbox.Text;
            thisRow["STFSTUDYEAR"] = YrChkbox.Text;
            thisRow["STFSTUDREMARKS"] = RemarksChkbox.Text;
            thisRow["STFSTUDSTATUS"] = "AC";

            //TO DO
            thisDataSet.Tables["StudentFile"].Rows.Add(thisRow);
            thisAdapater.Update(thisDataSet, "StudentFile");

            MessageBox.Show("Entry, Successfully Recorded!", "Student Entry: SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ClearFld();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ClearFld();
        }
        private void ExBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you really want to close the application?\nThis action will result in the termination of the entire application.";

            if (MessageBox.Show(message, "Exit Message", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            Application.Exit();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm MenuForm = new MainMenuForm();
            MenuForm.Show();
        }

        //Methods for clearing the fields
        private void ClearFld()
        {
            IdTxtbox.Text = "";
            FNameTxtbox.Text = "";
            LNameTxtbox.Text = "";
            MITxtbox.Text = "";
            CourseTxtbox.Text = "";
            YrChkbox.SelectedIndex = -1;
            RemarksChkbox.SelectedIndex = -1;
        }

        //Method for input validation method if the fields has no inputs
        private bool FieldValidation()
        {
            List<string> missingFields = new List<string>();
            string[] fieldNames = { "Id Number", "First Name", "Middle Name", "Last Name", "Course", "Year", "Remarks" };

            for (int i = 0; i < fieldNames.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (string.IsNullOrEmpty(IdTxtbox.Text))
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                        break;
                    case 1:
                        if (string.IsNullOrEmpty(FNameTxtbox.Text))
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                        break;
                    case 2:
                        if (string.IsNullOrEmpty(MITxtbox.Text))
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                        break;
                    case 3:
                        if (string.IsNullOrEmpty(LNameTxtbox.Text))
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                        break;
                    case 4:
                        if (string.IsNullOrEmpty(CourseTxtbox.Text))
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                        break;
                    case 5:
                        if (YrChkbox.SelectedIndex == -1)
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                        break;
                    case 6:
                        if (RemarksChkbox.SelectedIndex == -1)
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                        break;
                    default:
                        break;
                }
            }

            if (missingFields.Count > 0)
            {
                string fields = string.Join(", ", missingFields);
                string message = $"The following fields are missing: {fields}";
                MessageBox.Show(message, "Student Entry: Missing Fields Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
    }
}
