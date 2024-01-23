using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class StudentEnrollmentEntryForm : Form
    {
        //For draggable panel declarations
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public StudentEnrollmentEntryForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(28, 44, 139);
        }

        //SQL Connection method
        private static string connection()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alvin\source\repos\Finals\Student Management System\APPSDEV22.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        //Methods for Save, Exit, Minimize, Back button
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //Checks if the IdNumTB and EncoderTB textboxes
            //are not empty and if there are rows available in the SubjInDGView data
            if (string.IsNullOrEmpty(IdNumTB.Text.Trim()) || string.IsNullOrEmpty(EncoderTB.Text.Trim()) || SubjInDGView.Rows.Count == 0)
            {
                MessageBox.Show("Please fill in all required fields.", "Student Enrollment: Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Initializes the connection string variable and other data member
            string connectionString = connection();
            string studId = IdNumTB.Text.Trim();
            string encoder = EncoderTB.Text.Trim();
            string dateEnroll = DateTime.Now.ToString("MM/dd/yy hh:mm:ss");
            int totalUnits;

            // This statement will validate if the total units is <= 6
            //Executes the block if the condition is true
            //if false display a messagebox error
            if (int.TryParse(UnitsLbl.Text.Trim(), out totalUnits) && totalUnits <= 6 || totalUnits <= 29)
            {
                //SQL query string for the query of saving the entries to its respectives table 

                //For HeaderFile
                string insertHeaderQuery = "INSERT INTO EnrollmentHeaderFile " +
                    "(ENRHFSTUDID, ENRHFSTUDDATEENROLL, ENRHFSTUDSCHOOLYR, ENRHFSTUDENCODER, ENRHFSTUDTOTALUNITS, ENRHFSTUDSTATUS) " +
                    "VALUES (@studId, @dateEnroll, @schoolYear, @encoder, @totalUnits, @status)";

                //For DetailFile
                string insertDetailQuery = "INSERT INTO EnrollmentDetailFile " +
                    "(ENRDFSTUDID, ENRDFSTUDSUBJCODE, ENRDFSTUDEDPCODE, ENRDFSTUDSTATUS) " +
                    "VALUES (@studId, @subjCode, @edpcode, @statusdet)";

                //Update Classs Size
                string updateClassSizeQuery = "UPDATE SubjectSchedFile SET SSFCLASSSIZE = SSFCLASSSIZE + 1 WHERE SSFSUBJCODE = @subjCode AND SSFEDPCODE = @edpcode";

                //Query to check if the class size reach the limit
                string chkSizeQuery = "SELECT SSFCLASSSIZE FROM SubjectSchedFile WHERE SSFSUBJCODE = @subjCode AND SSFEDPCODE = @edpcode";


                //Intialize the SQL connection and commands for executing the queries of
                //Header file, detailed file, and Updating the class size of the SubjectSchedFile table
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand headerCommand = new SqlCommand(insertHeaderQuery, connection);
                    headerCommand.Parameters.AddWithValue("@studId", studId);
                    headerCommand.Parameters.AddWithValue("@dateEnroll", dateEnroll);
                    headerCommand.Parameters.AddWithValue("@schoolYear", "20XX-20XX"); //auto-entry for schol year
                    headerCommand.Parameters.AddWithValue("@encoder", encoder);
                    headerCommand.Parameters.AddWithValue("@totalUnits", totalUnits);
                    headerCommand.Parameters.AddWithValue("@status", "EN"); // automatically set the status entry to EN

                    SqlCommand detailCommand = new SqlCommand(insertDetailQuery, connection);
                    detailCommand.Parameters.AddWithValue("@studId", studId);
                    detailCommand.Parameters.Add("@subjCode", SqlDbType.VarChar);
                    detailCommand.Parameters.Add("@edpcode", SqlDbType.VarChar);
                    detailCommand.Parameters.AddWithValue("@statusdet", "AC");

                    SqlCommand updateClassSizeCommand = new SqlCommand(updateClassSizeQuery, connection);
                    updateClassSizeCommand.Parameters.Add("@subjCode", SqlDbType.VarChar);
                    updateClassSizeCommand.Parameters.Add("@edpcode", SqlDbType.VarChar);

                    SqlCommand checkClassSizeCommand = new SqlCommand(chkSizeQuery, connection);
                    checkClassSizeCommand.Parameters.Add("@subjCode", SqlDbType.VarChar);
                    checkClassSizeCommand.Parameters.Add("@edpcode", SqlDbType.VarChar);

                    // Generate TRY-CATCH execute the codes inside the try and catches any error that may occur
                    //It will dusplay an error message box if an exception is shown
                    try
                    {
                        connection.Open();
                        int rowsAffected = headerCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // This Loop will loop through on each row in the SubjInDGView data grid view and
                            // gets the subject code and EDP code values
                            //Sets the parameters for the detail command and executes the SQL command for inserting
                            //the enrollment detail information
                            //Sets the parameters for the class size update command and executes the SQL command
                            //for updating the class size

                            //This line of code creates a reference to the list of rows in the DataGridView
                            //using the IList to access and manipulate elements in the list.
                            System.Collections.IList list = SubjInDGView.Rows;
                            for (int i = 0; i < list.Count; i++)
                            {
                                DataGridViewRow row = (DataGridViewRow)list[i];
                                string subjCode = row.Cells[1].Value.ToString();
                                string edpCode = row.Cells[0].Value.ToString();

                                detailCommand.Parameters["@subjCode"].Value = subjCode;
                                detailCommand.Parameters["@edpcode"].Value = edpCode;
                                detailCommand.ExecuteNonQuery();

                                updateClassSizeCommand.Parameters["@subjCode"].Value = subjCode;
                                updateClassSizeCommand.Parameters["@edpcode"].Value = edpCode;
                                updateClassSizeCommand.ExecuteNonQuery();

                                checkClassSizeCommand.Parameters["@subjCode"].Value = subjCode;
                                checkClassSizeCommand.Parameters["@edpcode"].Value = edpCode;

                                int classSize = (int)checkClassSizeCommand.ExecuteScalar();
                                if (classSize >= 40)
                                {
                                    MessageBox.Show($"Student limit for {subjCode}-{edpCode} has reached the limit of 40. Enrollment cannot proceed.", "Student Enrollment: Class Size Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    ClearFld();
                                    return;
                                }
                            }

                            MessageBox.Show("Enrollment saved successfully!", "Student Enrollment: Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            ClearFld();
                        }
                        else
                        {
                            MessageBox.Show("Enrollment not saved. Please try again.", "Student Enrollment: Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while saving the enrollment: " + ex.Message, "Student Enrollment: DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Total units should be 6 above.", "Student Enrollment: Unit counts validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        // This code is executed when the Enter key is pressed in a text box with the name "IdNumTB".
        private void IdNumTB_KeyPressed(object sender, KeyPressEventArgs e)
        {
            // It  will retrieves student data from the database using the student ID entered in the "IdNumTB" text box.
            if (e.KeyChar == (char)Keys.Enter)
            {
                string connectionString = connection();
                string studId = IdNumTB.Text.Trim();


                // The student's full name, course, and year level are retrieved using separate SQL queries.
                string nameRetQuery = "SELECT STFSTUDLNAME + ', ' + STFSTUDFNAME + ' ' + STFSTUDMNAME AS FullName FROM StudentFile WHERE STFSTUDID = @studID";
                string courseretQuery = "SELECT STFSTUDCOURSE FROM StudentFile WHERE STFSTUDID = @studID";
                string yearRetQuery = "SELECT STFSTUDYEAR FROM StudentFile WHERE STFSTUDID = @studID";

                // The "using" statement is used to ensure that the SqlConnection object is properly disposed of after it is used.
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand nameRetCmd = new SqlCommand(nameRetQuery, connection);
                        nameRetCmd.Parameters.AddWithValue("@studID", studId);
                        string nameRet = nameRetCmd.ExecuteScalar()?.ToString();

                        SqlCommand courseRetCmd = new SqlCommand(courseretQuery, connection);
                        courseRetCmd.Parameters.AddWithValue("@studID", studId);
                        string courseRet = courseRetCmd.ExecuteScalar()?.ToString();

                        SqlCommand yearRetCmd = new SqlCommand(yearRetQuery, connection);
                        yearRetCmd.Parameters.AddWithValue("@StudID", studId);
                        string yearRet = yearRetCmd.ExecuteScalar()?.ToString();

                        if (nameRet == null)
                        {
                            // If the student data is not found in the database, an error message is displayed in a message box.
                            MessageBox.Show("Student Data Not Found!", "Student Enrollment: Student data doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // The retrieved data is displayed in the "NameTB", "CourseTB", and "YearTB" textboxes.
                            NameTB.Text = nameRet;
                            CourseTB.Text = courseRet;
                            YearTB.Text = yearRet;
                        }
                    }
                    // If an exception occurs while retrieving the data, an error message is displayed in a message box with details about the error.
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while retrieving student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //This block of code will ensure that the SqlConnection object will be closed whether an exception is thrown or not
                    finally
                    {
                        connection.Close();
                    }
                }


            }

        }

        //This code is executed when the Enter key is pressed in a text box with the name "EDPCodeTB".
        private void EDPCodeTB_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string connectionString = connection();
                string edpCode = EDPCodeTB.Text.Trim();

                string retQuery = "SELECT SSFEDPCODE, SSFSUBJCODE, SSFSTARTTIME, SSFENDTIME, SSFDAYS, SSFROOM, SFSUBJUNITS " +
                   "FROM SubjectSchedFile " +
                   "INNER JOIN SubjectFile ON SubjectSchedFile.SSFSUBJCODE = SubjectFile.SFSUBJCODE " +
                   "WHERE SSFEDPCODE = '" + edpCode + "'";


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(retQuery, connection);
                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            // Check if the row already exists
                            bool rowExists = false;
                            foreach (DataGridViewRow dgvRow in SubjInDGView.Rows)
                            {
                                if (dgvRow.Cells[0].Value != null && dgvRow.Cells[0].Value.ToString() == edpCode)
                                {
                                    rowExists = true;
                                    break;
                                }
                            }

                            if (rowExists)
                            {
                                MessageBox.Show("EDP Code: Already Exists, cannot add the subject!", "Student Enrollment: Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                // Check for schedule conflict before adding row to DataGridView
                                bool hasConflict = false;
                                while (reader.Read())
                                {
                                    string[] row = {
                                    reader.GetString(0),
                                    reader.GetString(1),
                                    reader.GetDateTime(2).ToString("HH:mm"),
                                    reader.GetDateTime(3).ToString("HH:mm"),
                                    reader.GetString(4),
                                    reader.GetString(5),
                                    reader.GetInt32(6).ToString()
                                    };

                                    if (IsSchedConflict(reader.GetString(0), reader.GetString(1), reader.GetDateTime(2).TimeOfDay, reader.GetDateTime(3).TimeOfDay, reader.GetString(4)))
                                    {
                                        hasConflict = true;
                                        break;
                                    }
                                    else
                                    {
                                        SubjInDGView.Rows.Add(row);
                                    }
                                }

                                if (hasConflict)
                                {
                                    MessageBox.Show("Cannot add subject, Schedule conflict.", "Student Enrollment: Schedule Conflict Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    // Compute total units
                                    int totalUnits = 0;
                                    System.Collections.IList list = SubjInDGView.Rows;
                                    for (int i = 0; i < list.Count; i++)
                                    {
                                        DataGridViewRow dgvRow = (DataGridViewRow)list[i];
                                        if (dgvRow.Cells[6].Value != null)
                                        {
                                            int units = Int32.Parse(dgvRow.Cells[6].Value.ToString());
                                            totalUnits += units;
                                        }
                                    }

                                    UnitsLbl.Text = totalUnits.ToString();

                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Subject and EDP Code doesn't exist", "Student Enrollment: EDP Code Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        reader.Close();
                    }
                    // If an exception occurs while retrieving the data, an error message is displayed in a message box with details about the error.
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while retrieving student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // To delete a selected row in the DataGridView
        private void SubjInDGView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (SubjInDGView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = SubjInDGView.SelectedRows[0];

                    // Get the units of the selected row
                    if (selectedRow.Cells[6].Value != null)
                    {
                        int unitsToDelete = Convert.ToInt32(selectedRow.Cells[6].Value);
                        SubjInDGView.Rows.Remove(selectedRow);

                        // Decrement the total units count
                        int totalUnits = Convert.ToInt32(UnitsLbl.Text);
                        totalUnits -= unitsToDelete;
                        UnitsLbl.Text = totalUnits.ToString();
                    }
                }
            }
        }
        //Validation and Other Methods
        private bool IsSchedConflict(string edpCode, string subjCode, TimeSpan startTime, TimeSpan endTime, string days)
        {
            for (int i = 0; i < SubjInDGView.Rows.Count; i++)
            {
                //This statement will check if all the necessary columns in the row are not empty.
                //It will check the values of the EDP code, subject code, start time, end time, and days.
                //As for Cells[0] it refers to the first column which is the EDP code, so and so forth.
                DataGridViewRow row = SubjInDGView.Rows[i];
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() != edpCode &&
                    row.Cells[1].Value != null && row.Cells[1].Value.ToString() != subjCode &&
                    row.Cells[2].Value != null && row.Cells[3].Value != null &&
                    row.Cells[4].Value != null && row.Cells[2].Value.ToString() != "" &&
                    row.Cells[3].Value.ToString() != "" && row.Cells[4].Value.ToString() != "")
                {
                    string rowDays = row.Cells[4].Value.ToString();
                    TimeSpan rowStartTime = TimeSpan.Parse(row.Cells[2].Value.ToString());
                    TimeSpan rowEndTime = TimeSpan.Parse(row.Cells[3].Value.ToString());

                    // Check for day conflict
                    //It checks if the schedule being checked has the same day as the row it's being compared to.
                    // Any() method is used to iterate each character in the string 'days'.
                    if (days.Any(day => rowDays.Contains(day)))
                    {
                        // Check for time overlap
                        //1st condition - start time of the current schedule is between the start and end time of the row being compared to.
                        //2nd condition - the end time of the current schedule is between the start and end time of the row being compared to
                        //Lastly, the current schedule completely overlaps with the row being compared to.
                        if ((startTime >= rowStartTime && startTime < rowEndTime) ||
                            (endTime > rowStartTime && endTime <= rowEndTime) ||
                            (startTime <= rowStartTime && endTime >= rowEndTime))
                        {
                            // Conflict found
                            return true;
                        }
                    }
                }
            }

            //This line of code returns false if there is no conflict inside the DataGrid View rows being compared to.
            return false;
        }

        //Clear fields method
        private void ClearFld()
        {
            // Clear all textboxes
            IdNumTB.Clear();
            DTimePicker.Value = DateTime.Now;
            EncoderTB.Clear();
            EDPCodeTB.Clear();
            NameTB.Clear();
            CourseTB.Clear();
            YearTB.Clear();
            UnitsLbl.Text = String.Empty;

            // Clear the DataGridView
            SubjInDGView.Rows.Clear();
            SubjInDGView.Refresh();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ClearFld();
        }
    }
}
