using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using CuoreUI.Controls;
using System.Data.SqlClient;
using System.Text;
using System.Data;



namespace LoginSystem
{
    public partial class MainMenuForm: Form
    {
        // dragging form
        private bool _mouseDown;
        private Point _lastLocation;

        private string filePath = "userdata.txt";

        private Dictionary<cuiButton, Panel> buttonBGButtonMap;
        private Dictionary<cuiButton, Panel> buttonMenuPanelMap;

        private string connectionString = "Data Source=LAPTOP-R9RSTS0G\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;";



        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void PersonalInformationProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentDBDataSet.Students);

            this.Panel_Title.MouseDown += this.MouseDown;
            this.Panel_Title.MouseMove += this.MouseMove;
            this.Panel_Title.MouseUp += this.MouseUp;

            this.panel_MenuTop.MouseDown += this.MouseDown;
            this.panel_MenuTop.MouseMove += this.MouseMove;
            this.panel_MenuTop.MouseUp += this.MouseUp;

            textBox_AD_FullName.TextChanged += HideErrorMsg;
            textBox_AD_Age.TextChanged += HideErrorMsg;
            comboBox_AD_Gender.TextChanged += HideErrorMsg;

            textBox_FM_StudentID.TextChanged += HideErrorMsg;
            textBox_FM_FirstName.TextChanged += HideErrorMsg;
            textBox_FM_LastName.TextChanged += HideErrorMsg;
            textBox_FM_Course.TextChanged += HideErrorMsg;
            textBox_FM_Age.TextChanged += HideErrorMsg;

            // Show Account Details panel by default
            //panel_Menu_AccountDetails.Height = 292;             panel_Menu_AccountDetails.Width = 722;
            //panel_Menu_AccountDetails.Visible = true;           panel_Menu_AccountDetails.Show();

            panel_bg_StorePreferences.BackColor = Color.FromArgb(27, 40, 56);
            panel_bg_FamilyManagement.BackColor = Color.FromArgb(27, 40, 56);
            panel_bg_LanguagePreferences.BackColor = Color.FromArgb(27, 40, 56);
            panel_bg_CookiesBrowsing.BackColor = Color.FromArgb(27, 40, 56);
            panel_bg_NotificationSetting.BackColor = Color.FromArgb(27, 40, 56);



            if (File.Exists(filePath))
            {
                textBox_AD_Output.Text = File.ReadAllText(filePath);
            }
        }










        // FORM CONTROL

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Form Dragging
        private new void MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private new void MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - _lastLocation.X) + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private new void MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }










        // MENU BUTTONS

        private void cuiButton_AccountDetails_Click(object sender, EventArgs e)
        {
            ShowSelectedButtonAndPanel(cuiButton_AccountDetails);
        }

        private void cuiButton_StorePreferences_Click(object sender, EventArgs e)
        {
            ShowSelectedButtonAndPanel(cuiButton_StorePreferences);
        }

        private void cuiButton_FamilyManagement_Click(object sender, EventArgs e)
        {
            ShowSelectedButtonAndPanel(cuiButton_FamilyManagement);
        }

        private void cuiButton_LanguagePreferences_Click(object sender, EventArgs e)
        {
            ShowSelectedButtonAndPanel(cuiButton_LanguagePreferences);
        }

        private void cuiButton_CookiesBrowsing_Click(object sender, EventArgs e)
        {
            ShowSelectedButtonAndPanel(cuiButton_CookiesBrowsing);
        }

        private void cuiButton_NotificationSetting_Click(object sender, EventArgs e)
        {
            ShowSelectedButtonAndPanel(cuiButton_NotificationSetting);
        }










        // ACCOUNT DETAILS

        private void cuiButton_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_AD_FullName.Text)
                && !string.IsNullOrWhiteSpace(textBox_AD_Age.Text)
                && comboBox_AD_Gender.SelectedItem != null)
            {
               label_AD_SavedSuccessfully.Visible = true;
               label_AD_SavedSuccessfully.Show();

                // saving 
                string username = textBox_AD_FullName.Text.Trim();
                string age = textBox_AD_Age.Text.Trim();
                string gender = comboBox_AD_Gender.SelectedItem?.ToString() ?? "Not selected";

                string userInfo = $"Username: {username}, \nAge: {age}, \nGender: {gender}";

                // Show in textBox_Output
                textBox_AD_Output.Text = "";

                // Save to file
                string filePath = "userdata.txt";

                try
                {
                    File.WriteAllText(filePath, userInfo + Environment.NewLine);
                    MessageBox.Show("User info saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving to file: " + ex.Message);
                }

                if (File.Exists(filePath))
                {
                    textBox_AD_Output.Text = File.ReadAllText(filePath);
                }
            }
            else
            {
                label_AD_Error_Msg.Visible = true;
                label_AD_Error_Msg.Show();

                panel_AD_Error_FullName.Visible = true;
                panel_AD_Error_FullName.Show();

                panel_AD_Error_Age.Visible = true;
                panel_AD_Error_Age.Show();

                panel_AD_Error_Gender.Visible = true;
                panel_AD_Error_Gender.Show();
            }
        }





        // FAMILY MANAGEMENT

        private void button_FM_Expand_Click(object sender, EventArgs e)
        {
            dataGridView_StudentsList.Width = (dataGridView_StudentsList.Width != 722) ? 722 : 350;
        }

        private void cuiButton_FM_Add_Click(object sender, EventArgs e)
        {
            textBox_FM_StudentID.Clear();

            int newStudentId = GetNextCustomStudentID();
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(textBox_FM_FirstName.Text))
            {
                panel_FM_Error_FirstName.Visible = true;
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(textBox_FM_LastName.Text))
            {
                panel_FM_Error_LastName.Visible = true;
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(textBox_FM_Course.Text))
            {
                panel_FM_Error_Course.Visible = true;
                hasError = true;
            }
            else if (!textBox_FM_Course.Text.Contains("BS"))
            {
                panel_FM_Error_Course.Visible = true;
                label_FM_Error_Msg.Visible = true;
                label_FM_Error_Msg.Text = "Please enter a valid course";
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_FM_Age.Text))
            {
                panel_FM_Error_Age.Visible = true;
                hasError = true;
            }

            if (hasError)
            {
                label_FM_Error_Msg.Visible = true;
                label_FM_Error_Msg.Text = "Please fill in all fields";
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Students (StudentID, FirstName, LastName, Age, Course) " +
                               "VALUES (@ID, @FirstName, @LastName, @Age, @Course)";
                SqlCommand cmd = new SqlCommand(query, conn);
                
                cmd.Parameters.AddWithValue("@ID", newStudentId);
                cmd.Parameters.AddWithValue("@FirstName", textBox_FM_FirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", textBox_FM_LastName.Text);
                cmd.Parameters.AddWithValue("@Age", textBox_FM_Age.Text);
                cmd.Parameters.AddWithValue("@Course", textBox_FM_Course.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadStudents();
                    textBox_FM_StudentID.Clear();
                    textBox_FM_FirstName.Clear();
                    textBox_FM_LastName.Clear();
                    textBox_FM_Course.Clear();
                    textBox_FM_Age.Clear();

                    label_FM_UpdatedSuccessfully.Visible = true;
                    label_FM_UpdatedSuccessfully.Text = "Added successfully";
                }
                catch (Exception ex)
                {
                    label_FM_Error_Msg.Visible = true;
                    label_FM_Error_Msg.Text = "Error adding student: " + ex.Message;
                }
            }
        }

        private void cuiButton_FM_Update_Click(object sender, EventArgs e)
        {
            int studentId;
            if (!int.TryParse(textBox_FM_StudentID.Text, out studentId))
            {
                panel_FM_Error_StudentID.Visible = true;
                label_FM_Error_Msg.Visible = true;
                label_FM_Error_Msg.Text = "Please enter a valid Student ID.";
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_FM_FirstName.Text) &&
                string.IsNullOrWhiteSpace(textBox_FM_LastName.Text) &&
                string.IsNullOrWhiteSpace(textBox_FM_Course.Text) &&
                string.IsNullOrWhiteSpace(textBox_FM_Age.Text))
            {
                label_FM_UpdatedSuccessfully.Visible = true;
                label_FM_UpdatedSuccessfully.Text = "No changes were made";
                return;
            }

            // Show confirmation message box
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to update Student ID: {studentId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                StringBuilder queryBuilder = new StringBuilder("UPDATE Students SET ");
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (!string.IsNullOrWhiteSpace(textBox_FM_FirstName.Text))
                {
                    queryBuilder.Append("FirstName = @FirstName, ");
                    parameters.Add(new SqlParameter("@FirstName", textBox_FM_FirstName.Text));
                }

                if (!string.IsNullOrWhiteSpace(textBox_FM_LastName.Text))
                {
                    queryBuilder.Append("LastName = @LastName, ");
                    parameters.Add(new SqlParameter("@LastName", textBox_FM_LastName.Text));
                }

                if (!string.IsNullOrWhiteSpace(textBox_FM_Age.Text))
                {
                    queryBuilder.Append("Age = @Age, ");
                    parameters.Add(new SqlParameter("@Age", int.Parse(textBox_FM_Age.Text)));
                }

                if (!string.IsNullOrWhiteSpace(textBox_FM_Course.Text))
                {
                    queryBuilder.Append("Course = @Course, ");
                    parameters.Add(new SqlParameter("@Course", textBox_FM_Course.Text));
                }

                // Remove the last comma and space from the query
                if (queryBuilder.ToString().EndsWith(", "))
                {
                    queryBuilder.Remove(queryBuilder.Length - 2, 2);
                }

                // Add the WHERE clause
                queryBuilder.Append(" WHERE StudentID = @StudentID");
                parameters.Add(new SqlParameter("@StudentID", studentId));

                // Execute the query if there is any field to update
                if (parameters.Count > 1) // At least one parameter has been added
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), conn);
                        cmd.Parameters.AddRange(parameters.ToArray());

                        try
                        {
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                LoadStudents();
                                textBox_FM_StudentID.Clear();
                                textBox_FM_FirstName.Clear();
                                textBox_FM_LastName.Clear();
                                textBox_FM_Course.Clear();
                                textBox_FM_Age.Clear();

                                label_FM_UpdatedSuccessfully.Visible = true;
                                label_FM_UpdatedSuccessfully.Text = "Updated successfully";
                            }
                            else
                            {
                                label_FM_UpdatedSuccessfully.Visible = true;
                                label_FM_UpdatedSuccessfully.Text = "No changes were made";
                            }
                        }
                        catch (Exception ex)
                        {
                            label_FM_Error_Msg.Visible = true;
                            label_FM_Error_Msg.Text = "Error updating student: " + ex.Message;
                        }
                    }
                }
                else
                {
                    label_FM_UpdatedSuccessfully.Visible = true;
                    label_FM_UpdatedSuccessfully.Text = "No changes were made";
                }
            }
            else
            {
                label_FM_UpdatedSuccessfully.Visible = true;
                label_FM_UpdatedSuccessfully.Text = "Update canceled";
            }
        }

        private void cuiButton_FM_Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_FM_StudentID.Text) &&
                string.IsNullOrWhiteSpace(textBox_FM_FirstName.Text) &&
                string.IsNullOrWhiteSpace(textBox_FM_LastName.Text) &&
                string.IsNullOrWhiteSpace(textBox_FM_Course.Text) &&
                string.IsNullOrWhiteSpace(textBox_FM_Age.Text))
            {
                panel_FM_Error_FirstName.Visible = true;
                panel_FM_Error_LastName.Visible = true;
                panel_FM_Error_Course.Visible = true;
                panel_FM_Error_Age.Visible = true;
                label_FM_Error_Msg.Visible = true;
                label_FM_Error_Msg.Text = "Please enter at least one field to delete";
                return;
            }
            
            if (!string.IsNullOrWhiteSpace(textBox_FM_StudentID.Text) &&
                (!string.IsNullOrWhiteSpace(textBox_FM_FirstName.Text) ||
                !string.IsNullOrWhiteSpace(textBox_FM_LastName.Text) ||
                !string.IsNullOrWhiteSpace(textBox_FM_Course.Text) ||
                !string.IsNullOrWhiteSpace(textBox_FM_Age.Text)))
            {
                panel_FM_Error_FirstName.Visible = true;
                panel_FM_Error_LastName.Visible = true;
                panel_FM_Error_Course.Visible = true;
                panel_FM_Error_Age.Visible = true;
                label_FM_Error_Msg.Visible = true;
                label_FM_Error_Msg.Text = "Fields should be empty when indicating student ID or vice versa";
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the student(s) matching the input?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    List<string> conditions = new List<string>();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (!string.IsNullOrWhiteSpace(textBox_FM_StudentID.Text))
                    {
                        conditions.Add("StudentID = @StudentID");
                        cmd.Parameters.AddWithValue("@StudentID", int.Parse(textBox_FM_StudentID.Text));
                    }

                    if (!string.IsNullOrWhiteSpace(textBox_FM_FirstName.Text))
                    {
                        conditions.Add("FirstName = @FirstName");
                        cmd.Parameters.AddWithValue("@FirstName", textBox_FM_FirstName.Text.Trim());
                    }

                    if (!string.IsNullOrWhiteSpace(textBox_FM_LastName.Text))
                    {
                        conditions.Add("LastName = @LastName");
                        cmd.Parameters.AddWithValue("@LastName", textBox_FM_LastName.Text.Trim());
                    }

                    if (!string.IsNullOrWhiteSpace(textBox_FM_Course.Text))
                    {
                        conditions.Add("Course = @Course");
                        cmd.Parameters.AddWithValue("@Course", textBox_FM_Course.Text.Trim());
                    }

                    if (!string.IsNullOrWhiteSpace(textBox_FM_Age.Text))
                    {
                        if (int.TryParse(textBox_FM_Age.Text, out int age))
                        {
                            DialogResult lesserGreaterOrEqual = MessageBox.Show(
                                "What age do you want to delete? :\n\nYes = Greater than\nNo = Less than\nCancel = Equal to",
                                "Delete by Age Condition",
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Question);

                            switch (lesserGreaterOrEqual)
                            {
                                case DialogResult.Yes:
                                    conditions.Add("Age > @Age");
                                    break;
                                case DialogResult.No:
                                    conditions.Add("Age < @Age");
                                    break;
                                case DialogResult.Cancel:
                                    conditions.Add("Age = @Age");
                                    break;
                                default:
                                    label_FM_UpdatedSuccessfully.Visible = true;
                                    label_FM_UpdatedSuccessfully.Text = "Deletion canceled";
                                    return;
                            }

                            cmd.Parameters.AddWithValue("@Age", age);
                        }
                        else
                        {
                            panel_FM_Error_Age.Visible = true;
                            label_FM_Error_Msg.Visible = true;
                            label_FM_Error_Msg.Text = "Invalid Age value";
                            return;
                        }

                    }

                    string whereClause = string.Join(" AND ", conditions);
                    cmd.CommandText = $"DELETE FROM Students WHERE {whereClause}";

                    textBox_FM_StudentID.Clear();
                    textBox_FM_FirstName.Clear();
                    textBox_FM_LastName.Clear();
                    textBox_FM_Course.Clear();
                    textBox_FM_Age.Clear();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        label_FM_UpdatedSuccessfully.Visible = true;
                        label_FM_UpdatedSuccessfully.Text = $"{rowsAffected} student(s) deleted successfully";
                    }
                    else
                    {
                        label_FM_Error_Msg.Visible = true;
                        label_FM_Error_Msg.Text = "No matching student(s) found to delete";
                    }

                    LoadStudents(); 
                }
            }
            else
            {
                label_FM_UpdatedSuccessfully.Visible = true;
                label_FM_UpdatedSuccessfully.Text = "Deletion canceled";
            }
        }











        // HELPER METHODS

        private void ShowErrorMsg(object sender, EventArgs e)
        {

        }

        private void HideErrorMsg(object sender, EventArgs e)
        {
            // ACCOUNT DETAILS MENU
            panel_AD_Error_FullName.Visible = false;
            panel_AD_Error_Gender.Visible = false;
            panel_AD_Error_Age.Visible = false;
            label_AD_Error_Msg.Visible = false;
            label_AD_SavedSuccessfully.Visible = false;

            // FAMILY MANAGEMENT MENU
            panel_FM_Error_StudentID.Visible = false;
            panel_FM_Error_FirstName.Visible = false;
            panel_FM_Error_LastName.Visible = false;
            panel_FM_Error_Course.Visible = false;
            panel_FM_Error_Age.Visible = false;
            label_FM_Error_Msg.Visible = false;
            label_FM_UpdatedSuccessfully.Visible = false;
        }

        private void ShowSelectedButtonAndPanel(cuiButton activeButton)
        {
            buttonBGButtonMap = new Dictionary<cuiButton, Panel>
            {
                { cuiButton_AccountDetails, panel_bg_AccountDetails },
                { cuiButton_StorePreferences, panel_bg_StorePreferences },
                { cuiButton_FamilyManagement, panel_bg_FamilyManagement },  
                { cuiButton_LanguagePreferences, panel_bg_LanguagePreferences },
                { cuiButton_CookiesBrowsing, panel_bg_CookiesBrowsing },
                { cuiButton_NotificationSetting, panel_bg_NotificationSetting }
            };

            buttonMenuPanelMap = new Dictionary<cuiButton, Panel>
            {
                { cuiButton_AccountDetails, panel_Menu_AccountDetails },
                { cuiButton_StorePreferences, panel_Menu_StorePreferences },
                { cuiButton_FamilyManagement, panel_Menu_FamilyManagement },
                { cuiButton_LanguagePreferences, panel_Menu_LanguagePreferences },
                { cuiButton_CookiesBrowsing, panel_Menu_CookiesBrowsing },
                { cuiButton_NotificationSetting, panel_Menu_NotificationSetting }
            };

            foreach (var pair in buttonBGButtonMap)
            {
                pair.Key.NormalBackground = (pair.Key == activeButton)
                    ? Color.FromArgb(33, 60, 88)
                    : Color.FromArgb(27, 40, 56);
                pair.Value.BackColor = (pair.Key == activeButton)
                    ? Color.FromArgb(26, 159, 255)
                    : Color.FromArgb(27, 40, 56);
            }

            foreach (var panel in buttonMenuPanelMap.Values)
            {
                panel.Height = (buttonMenuPanelMap[activeButton] == panel) ? 292 : 0;
                panel.Width = (buttonMenuPanelMap[activeButton] == panel) ? 722 : 0;
            }

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))// && e.KeyChar != '<' && e.KeyChar != '>')
            {
                e.Handled = true; // Block the key press
            }
        }

        private int GetNextCustomStudentID()
        {
            int nextId = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(StudentID) FROM Students";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        nextId = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        nextId = 23901; // Starting point if no records exist
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error getting next Student ID: " + ex.Message);
                }
            }

            return nextId;
        }

        private void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT StudentID, FirstName, LastName, Age, Course FROM Students";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dataTable);
                    dataGridView_StudentsList.DataSource = dataTable;  // Bind the data to the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student data: " + ex.Message);
                }
            }
        }

    }
}
