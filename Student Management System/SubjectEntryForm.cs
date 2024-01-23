using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class SubjectEntryForm : Form
    {

        //For draggable panel declarations
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        public SubjectEntryForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(28, 44, 139);
        }

        //It performs an action which ensures that the DataGridView is empty when the form is loaded.
        private void SubjectEntryForm_Load(object sender, EventArgs e)
        {
            SubjDGView.Rows.Clear();
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
        private static string connection()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alvin\source\repos\Finals\Student Management System\APPSDEV22.mdf;Integrated Security=True;Connect Timeout=30";
        }
        //Button Functions SAVE, CANCEL, EXIT, MINIMIZE, BACK
        private void SaveBtn_Click(object sender, EventArgs e)
        {

            //Establishes connection to database
            string connectionString = connection();
            SqlConnection SqlConnection = new SqlConnection(connectionString);
            SqlConnection.Open();

                if (!SubjEntryValidation())
                { // If the method returns false, exit the SaveBtn_Click method
                    return;

                }

                // Retrieve data from the SubjectFile table
                string sql = "Select *From SubjectFile";
                SqlDataAdapter thisAdapater = new SqlDataAdapter(sql, SqlConnection);
                SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapater);
                DataSet thisDataSet = new DataSet();
                thisAdapater.Fill(thisDataSet, "SubjectFile");

                // Define primary keys for the SubjectFile table
                DataColumn[] pkeys = new DataColumn[2];
                pkeys[0] = thisDataSet.Tables["SubjectFile"].Columns["SFSUBJCODE"];
                pkeys[1] = thisDataSet.Tables["SubjectFile"].Columns["SFSUBJCOURSECODE"];
                thisDataSet.Tables["SubjectFile"].PrimaryKey = pkeys;

                // Search for the input data in the SubjectFile table
                String[] valuesToSearch = new string[2];
                valuesToSearch[0] = SubjCodeTxtbox.Text;
                valuesToSearch[1] = CourseCodeCmbbox.Text;
                DataRow findRow = thisDataSet.Tables["SubjectFile"].Rows.Find(valuesToSearch);

                // If the input data does not exist in the SubjectFile table, add a new row to the table
                if (findRow == null)
                {
                    DataRow thisRow = thisDataSet.Tables["SubjectFile"].NewRow();
                    thisRow["SFSUBJCODE"] = SubjCodeTxtbox.Text;
                    thisRow["SFSUBJDESC"] = DescripTxtbox.Text;
                    thisRow["SFSUBJUNITS"] = Int16.Parse(UnitTxtbox.Text);
                    thisRow["SFSUBJREFOFRG"] = Int16.Parse(OfrgCmbbox.Text);
                    thisRow["SFSUBJCATEGORY"] = CatCmbbox.Text;
                    thisRow["SFSUBJCOURSECODE"] = CourseCodeCmbbox.Text;
                    thisRow["SFSUBJSTATUS"] = "AC";
                    thisRow["SFSUBJCURRCODE"] = CurYrTxtbox.Text;
                    //TO DO
                    thisDataSet.Tables["SubjectFile"].Rows.Add(thisRow);
                    thisAdapater.Update(thisDataSet, "SubjectFile");

                    MessageBox.Show("Subject Entries Recorded!","Subject Entry: Success!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFld(excludeSubjCodeTxtbox: true);

                }
                else
                {
                    // If the input data already exists in the SubjectFile table, clear the input fields and disable certain fields and displays a messagebox
                    MessageBox.Show("Can't save data, Data already exists.", "Subject Entry: Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFld();
                }

        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ClearFld() ;
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

        //Method for Requisite Information part that retrieves and save the value of a subject if it is co or pre-req
        private void ReqSubjCodeTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Establish connection to database
            string connectionString = connection();

            if (e.KeyChar == (char)Keys.Enter)
            {
              
                if (!ReqInfoValidation())
                { // If the method returns false, exit the SaveBtn_Click method
                    return;

                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve data from the SubjPreqFile table
                    string prequery = "Select * From SubjPreqFile";
                    using (SqlDataAdapter newAdapter = new SqlDataAdapter(prequery, connection))
                    {
                        using (SqlCommandBuilder newBuilder = new SqlCommandBuilder(newAdapter))
                        {
                            using (DataSet newDataSet = new DataSet())
                            {
                                newAdapter.Fill(newDataSet, "SubjPreqFile");

                                // Define primary keys for the SubjPreqFile table
                                DataColumn[] pkeys = new DataColumn[2];
                                pkeys[0] = newDataSet.Tables["SubjPreqFile"].Columns["SUBJCODE"];
                                pkeys[1] = newDataSet.Tables["SubjPreqFile"].Columns["SUBJPRECODE"];
                                newDataSet.Tables["SubjPreqFile"].PrimaryKey = pkeys;

                                // Define values to search for in the SubjPreqFile table
                                String[] valuesToSearch = new string[2];
                                valuesToSearch[0] = SubjCodeTxtbox.Text;
                                valuesToSearch[1] = ReqSubjCodeTxtbox.Text.Trim();

                                // Search for the row that matches the values to search for
                                DataRow findRow = newDataSet.Tables["SubjPreqFile"].Rows.Find(valuesToSearch);

                                // If the input data does not exist in the SubjPreqFile table, add a new row to the table
                                if (findRow == null)
                                {
                                    DataRow newRow = newDataSet.Tables["SubjPreqFile"].NewRow();
                                    newRow["SUBJCODE"] = SubjCodeTxtbox.Text;
                                    newRow["SUBJPRECODE"] = ReqSubjCodeTxtbox.Text.Trim();

                                    if (PreRadBtn.Checked == true)
                                    {
                                        newRow["SUBJCATEGORY"] = "PR";
                                    }

                                    if (CoRadBtn.Checked == true)
                                    {
                                        newRow["SUBJCATEGORY"] = "CO";
                                    }

                                    newDataSet.Tables["SubjPreqFile"].Rows.Add(newRow);
                                    newAdapter.Update(newDataSet, "SubjPreqFile");

                                    MessageBox.Show("Requiste Entries Recorded", "Subject Entry: Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Show the data in the datagridview
                                    SubjDGView.Rows.Clear();
                                    foreach (DataRow row in newDataSet.Tables["SubjPreqFile"].Rows)
                                    {
                                        string subjCode = row["SUBJCODE"].ToString();
                                        string subjPreCode = row["SUBJPRECODE"].ToString();
                                        string subjCategory = row["SUBJCATEGORY"].ToString();
                                        SubjDGView.Rows.Insert(0, subjCode, subjPreCode, subjCategory);
                                    }

                                }
                                else // If the input data already exists in the SubjPreqFile table, show it in the datagridview
                                {
                                    // Show the data in the datagridview
                                    SubjDGView.Rows.Clear();
                                    foreach (DataRow row in newDataSet.Tables["SubjPreqFile"].Rows)
                                    {
                                        string subjCode = row["SUBJCODE"].ToString();
                                        string subjPreCode = row["SUBJPRECODE"].ToString();
                                        string subjCategory = row["SUBJCATEGORY"].ToString();
                                        SubjDGView.Rows.Insert(0, subjCode, subjPreCode, subjCategory);
                                    }


                                    MessageBox.Show("Subject Found", "Subject Entry: Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
        }
        //Clear fields method
        private void ClearFld(bool excludeSubjCodeTxtbox = false)
        {
            DescripTxtbox.Clear();
            UnitTxtbox.Clear();
            OfrgCmbbox.SelectedIndex = -1;
            CatCmbbox.SelectedIndex = -1;
            CourseCodeCmbbox.SelectedIndex = -1;
            CurYrTxtbox.Clear();
            ReqSubjCodeTxtbox.Clear();

            if (!excludeSubjCodeTxtbox)
            {
                SubjCodeTxtbox.Clear();
            }

            if (PreRadBtn.Checked)
            {
                ReqSubjCodeTxtbox.Clear();
            }

            PreRadBtn.Checked = false;
            CoRadBtn.Checked = false;
        }


        //Method for input subject entry validation if the fields has inputs
        private bool SubjEntryValidation()
        {
            List<string> missingFields = new List<string>();
            Dictionary<string, Control> fields = new Dictionary<string, Control>()
    {
        { "Subject Code", SubjCodeTxtbox },
        { "Description", DescripTxtbox },
        { "Unit", UnitTxtbox },
        { "Offering", OfrgCmbbox },
        { "Category", CatCmbbox },
        { "Course Code", CourseCodeCmbbox },
        { "Curriculum Year", CurYrTxtbox }
    };

            foreach (KeyValuePair<string, Control> field in fields)
            {
                if (field.Value is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    missingFields.Add(field.Key);
                }
                else if (field.Value is ComboBox comboBox && comboBox.SelectedIndex == -1)
                {
                    missingFields.Add(field.Key);
                }
            }

            if (missingFields.Count > 0)
            {
                string fld = string.Join(", ", missingFields);
                string message = $"The following fields are missing: {fld}";
                MessageBox.Show(message, "Subject Entry: Input file Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //Method for input requisite information entry validation if the fields has inputs
        private bool ReqInfoValidation()
        {
            // Check if all fields are filled out
            if (string.IsNullOrEmpty(SubjCodeTxtbox.Text) ||
                string.IsNullOrEmpty(ReqSubjCodeTxtbox.Text) ||
                (!PreRadBtn.Checked && !CoRadBtn.Checked))
            {
                MessageBox.Show("Please fill out all fields.", "Subject Entry: Input file Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // If all fields are filled out, return true
            return true;
        }
    }


}
