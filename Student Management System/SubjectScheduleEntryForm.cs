using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class SubjectScheduleEntryForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public SubjectScheduleEntryForm()
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

        //SQL Connection method
        private static string connection()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alvin\source\repos\Finals\Student Management System\APPSDEV22.mdf;Integrated Security=True;Connect Timeout=30";
        }

        //Button Functions SAVE, CLEAR, EXIT, MINIMIZE, BACK
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!FieldValidation())
            {
                return;
            }
           if (string.IsNullOrEmpty(DescriptionLbl.Text))
            {
                MessageBox.Show("Please enter a valid subject code.", "Subject Schedule Entry: Invalid Subject Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int maxsize = 40;
            string connectionString = connection();
            SqlConnection
            SqlConnection = new SqlConnection(connectionString);
            SqlConnection.Open();

            string edpCode = EDPTxtbox.Text.Trim();

            // Check if the EDP code already exists
            string duplicateQuery = "SELECT COUNT(*) FROM SubjectSchedFile WHERE SSFEDPCODE = @edpcode";
            SqlCommand duplicateCmd = new SqlCommand(duplicateQuery, SqlConnection);
            duplicateCmd.Parameters.AddWithValue("@edpcode", Convert.ToInt64(edpCode));

            int duplicateCount = (int)duplicateCmd.ExecuteScalar();

            if (duplicateCount > 0)
            {
                MessageBox.Show("Can't save data, EDP Code: "+ edpCode+" already  exists.", "Subject Schedule Entry: Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "Select *From SubjectSchedFile WHERE SSFEDPCODE = @edpcode";
            
            SqlDataAdapter thisAdapater = new SqlDataAdapter(query, SqlConnection);
            thisAdapater.SelectCommand.Parameters.AddWithValue("@edpcode", Convert.ToInt64(EDPTxtbox.Text));
            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapater);
            DataSet thisDataSet = new DataSet();
            thisAdapater.Fill(thisDataSet, "SubjectSchedFile");

                  // Input Validation if the SSFSTARTTIME AND SSFENDTIME are in the wrong format
        if (!TimeSpan.TryParseExact(TimeInTxtbox.Text, "hh\\:mm", CultureInfo.InvariantCulture, out TimeSpan startTime))
        {
            MessageBox.Show("Invalid start time format. Please enter a valid time in HH:MM format.", "Subject Schedule Entry: Invalid Time Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!TimeSpan.TryParseExact(TimeOutTxtbox.Text, "hh\\:mm", CultureInfo.InvariantCulture, out TimeSpan endTime))
        {
            MessageBox.Show("Invalid end time format. Please enter a valid time in HH:MM format.", "Subject Schedule Entry: Invalid Time Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Convert the TimeSpan values to DateTime for storing in the database
        DateTime startDateTime = DateTime.Today.Add(startTime);
        DateTime endDateTime = DateTime.Today.Add(endTime);

        // Query the database for existing entries that have the same room, days, and overlapping schedule time
        string queryOverlap = @"SELECT COUNT(*) FROM SubjectSchedFile 
                                WHERE SSFROOM = @room 
                                AND SSFDAYS = @days 
                                AND ((SSFSTARTTIME <= @endDateTime) 
                                AND (SSFENDTIME >= @startDateTime))";

        SqlCommand cmdOverlap = new SqlCommand(queryOverlap, SqlConnection);
        cmdOverlap.Parameters.AddWithValue("@room", RoomTxtbox.Text.Trim());
        cmdOverlap.Parameters.AddWithValue("@days", DaysTxtbox.Text.Trim());
        cmdOverlap.Parameters.AddWithValue("@startDateTime", startDateTime);
        cmdOverlap.Parameters.AddWithValue("@endDateTime", endDateTime);

        int overlappingEntriesCount = (int)cmdOverlap.ExecuteScalar();

        // Check if there are overlapping entries
        if (overlappingEntriesCount > 0)
        {
            MessageBox.Show("There is an overlapping schedule with the same room and days.", "Subject Schedule Entry: Time, Schedule, & Room Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

            DataRow thisRow = thisDataSet.Tables["SubjectSchedFile"].NewRow();
            thisRow["SSFEDPCODE"] = Convert.ToInt64(EDPTxtbox.Text);
            thisRow["SSFSUBJCODE"] = SubjCodeTxtbox.Text;
            thisRow["SSFSTARTTIME"] = startDateTime;
            thisRow["SSFENDTIME"] = endDateTime;
            thisRow["SSFDAYS"] = DaysTxtbox.Text.Trim();
            thisRow["SSFROOM"] = RoomTxtbox.Text.Trim();
            thisRow["SSFMAXSIZE"] = maxsize;
            thisRow["SSFCLASSSIZE"] = 0; 
            thisRow["SSFSTATUS"] = "AC";
            if (TimeCmbbox.SelectedIndex == 0) {
                thisRow["SSFXM"] = "AM";
            }
            if (TimeCmbbox.SelectedIndex == 1) {
                thisRow["SSFXM"] = "PM";
            }
            thisRow["SSFSECTION"] = SecTxtbox.Text.Trim();
            thisRow["SSFSCHOOLYEAR"] = Int16.Parse(SYTxtbox.Text);

            //TO DO
            thisDataSet.Tables["SubjectSchedFile"].Rows.Add(thisRow);
            thisAdapater.Update(thisDataSet, "SubjectSchedFile");

            MessageBox.Show("Entry, Successfully Recorded!", "Subject Schedule Entry: Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ClearFld();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFld();
        }

        private void ExBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you really want to close the application?\nThis action will result in the termination of the entire application.";

            if (MessageBox.Show(message, "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        //SubjCodeTextbox_KeyPressed Method
        //for every Subject Code that has been inputted, it will read the data from SubjectFile
        //if that Subject Code has a corresponding description.
        private void SubjCodeTxtbox_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string connectionString = connection();
                using (SqlConnection SqlConnection = new SqlConnection(connectionString))
                {
                    // the line of code below will perform a query where it will remove spaces from the database
                    // and the input in the textbox, to comapre the subject codes disregarding the spaces
                    //In-order to match the subject code in the database.
                    string subjDescQuery = "SELECT SFSUBJDESC FROM SubjectFile WHERE SFSUBJCODE = @subjCode";
                    SqlCommand subjDescCmd = new SqlCommand(subjDescQuery, SqlConnection);
                    subjDescCmd.Parameters.AddWithValue("@subjCode", SubjCodeTxtbox.Text.Trim());
                    SqlConnection.Open();
                    string subjDesc = subjDescCmd.ExecuteScalar()?.ToString();
                    SqlConnection.Close();
                    if (subjDesc == null)
                    {
                        MessageBox.Show("Subject not found!", "Subject Schedule Entry: Subject Not Found", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DescriptionLbl.Text = subjDesc;
                    }
                }

            }
        }


        //Other Methods

        //Clear Fields method
        private void ClearFld()
        {
        EDPTxtbox.Clear();
        SubjCodeTxtbox.Clear();
        DescriptionLbl.Text = string.Empty;
        TimeInTxtbox.Clear();
        TimeOutTxtbox.Clear();
        DaysTxtbox.Clear();
        SecTxtbox.Clear();
        RoomTxtbox.Clear();
        SYTxtbox.Clear();
        TimeCmbbox.SelectedIndex = -1;   
        }

        //Field Validation Method if the fields has inputs
        private bool FieldValidation()
        {
            List<string> missingFields = new List<string>();
            string[] fieldNames = { "EDP Code", "Subject Code", "Time In", "Time Out", 
            "Days", "Section", "Room", "School Year", "Schedule" };

            for (int i = 0; i < fieldNames.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (string.IsNullOrEmpty(EDPTxtbox.Text))
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                        break;
                    case 1:
                        if (string.IsNullOrEmpty(SubjCodeTxtbox.Text))
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                        break;
                    case 2:
                        if (string.IsNullOrEmpty(TimeInTxtbox.Text))
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                        break;
                    case 3:
                        if (string.IsNullOrEmpty(TimeOutTxtbox.Text))
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                        break;
                    case 4:
                        if (string.IsNullOrEmpty(DaysTxtbox.Text))
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                        break;
                    case 5:
                        if (string.IsNullOrEmpty(SecTxtbox.Text))
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                        break;
                    case 6:
                        if (string.IsNullOrEmpty(RoomTxtbox.Text))
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                        break;
                    case 7:
                        if (string.IsNullOrEmpty(SYTxtbox.Text))
                        {
                            missingFields.Add(fieldNames[i]);
                        }
                        break;
                    case 8:
                        if (TimeCmbbox.SelectedIndex == -1)
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
                MessageBox.Show(message, "Subject Schedule Entry: Input fields missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }
    }

}
