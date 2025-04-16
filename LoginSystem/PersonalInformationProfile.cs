using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using CuoreUI.Controls;


namespace LoginSystem
{
    public partial class PersonalInformationProfile: Form
    {
        // dragging form
        private bool _mouseDown;
        private Point _lastLocation;

        private string filePath = "userdata.txt";
        private Dictionary<cuiButton, Panel> buttonPanelMap;



        public PersonalInformationProfile()
        {
            InitializeComponent();
        }

        private void PersonalInformationProfile_Load(object sender, EventArgs e)
        {
            this.Panel_Title.MouseDown += this.MouseDown;
            this.Panel_Title.MouseMove += this.MouseMove;
            this.Panel_Title.MouseUp += this.MouseUp;

            this.panel_MenuTop.MouseDown += this.MouseDown;
            this.panel_MenuTop.MouseMove += this.MouseMove;
            this.panel_MenuTop.MouseUp += this.MouseUp;

            textBox_FullName.TextChanged += HideErrorMsg;
            textBox_Age.TextChanged += HideErrorMsg;
            comboBox_Gender.TextChanged += HideErrorMsg;

            //panel_bg_AccountDetails.BackColor = Color.FromArgb(27, 40, 56);
            //panel_bg_AccountDetails.BackColor = Color.FromArgb(27, 40, 56);

            panel_bg_StorePreferences.BackColor = Color.FromArgb(27, 40, 56);
            panel_bg_StorePreferences.BackColor = Color.FromArgb(27, 40, 56);

            panel_bg_FamilyManagement.BackColor = Color.FromArgb(27, 40, 56);
            panel_bg_FamilyManagement.BackColor = Color.FromArgb(27, 40, 56);

            panel_bg_LanguagePreferences.BackColor = Color.FromArgb(27, 40, 56);
            panel_bg_LanguagePreferences.BackColor = Color.FromArgb(27, 40, 56);

            panel_bg_CookiesBrowsing.BackColor = Color.FromArgb(27, 40, 56);
            panel_bg_CookiesBrowsing.BackColor = Color.FromArgb(27, 40, 56);

            panel_bg_NotificationSetting.BackColor = Color.FromArgb(27, 40, 56);
            panel_bg_NotificationSetting.BackColor = Color.FromArgb(27, 40, 56);





            if (File.Exists(filePath))
            {
                //string savedData = File.ReadAllText(filePath);
                textBox_Output.Text = File.ReadAllText(filePath);
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










        // ACCOUNT DETAILS

        private void textBox_FullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Age_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(textBox_Age.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    textBox_Age.Text = System.Text.RegularExpressions.Regex.Replace(textBox_Age.Text, "[^0-9]", "");
            //    textBox_Age.SelectionStart = textBox_Age.Text.Length;
            //}
        }

        private void textBox_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits and backspace only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the key press
            }
        }
        
        private void cuiButton_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_FullName.Text) &&
                !string.IsNullOrWhiteSpace(textBox_Age.Text) &&
                comboBox_Gender.SelectedItem != null)
            {
               label_SavedSuccessfully.Visible = true;
               label_SavedSuccessfully.Show();


                // saving 
                string username = textBox_FullName.Text.Trim();
                string age = textBox_Age.Text.Trim();
                string gender = comboBox_Gender.SelectedItem?.ToString() ?? "Not selected";

                string userInfo = $"Username: {username}, \nAge: {age}, \nGender: {gender}";

                // Show in textBox_Output
                textBox_Output.Text = "";

                textBox_Output.AppendText(username + Environment.NewLine);
                //textBox_OutputAge.AppendText(age + Environment.NewLine);
                //textBox_OutputGender.AppendText(gender + Environment.NewLine);

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
                    string savedData = File.ReadAllText(filePath);
                    textBox_Output.Text = savedData;
                }
            }
            else
            {
                label_ErrorMsg.Visible = true;
                label_ErrorMsg.Show();

                panel_ErrorFullName.Visible = true;
                panel_ErrorFullName.Show();

                panel_ErrorAge.Visible = true;
                panel_ErrorAge.Show();

                panel_ErrorGender.Visible = true;
                panel_ErrorGender.Show();
            }
        }




        // FAMILY MANAGEMENT

        private void cuiButton_AccountDetails_Click(object sender, EventArgs e)
        {
            HighlightButtonAndPanel(cuiButton_AccountDetails);
        }

        private void cuiButton_StorePreferences_Click(object sender, EventArgs e)
        {
            HighlightButtonAndPanel(cuiButton_StorePreferences);
        }

        private void cuiButton_FamilyManagement_Click(object sender, EventArgs e)
        {
            HighlightButtonAndPanel(cuiButton_FamilyManagement);
        }

        private void cuiButton_LanguagePreferences_Click(object sender, EventArgs e)
        {
            HighlightButtonAndPanel(cuiButton_LanguagePreferences);
        }

        private void cuiButton_CookiesBrowsing_Click(object sender, EventArgs e)
        {
            HighlightButtonAndPanel(cuiButton_CookiesBrowsing);
        }

        private void cuiButton_NotificationSetting_Click(object sender, EventArgs e)
        {
            HighlightButtonAndPanel(cuiButton_NotificationSetting);
        }









        // HELPER METHODS

        private void HideErrorMsg(object sender, EventArgs e)
        {
            panel_ErrorFullName.Visible = false;
            panel_ErrorGender.Visible = false;
            panel_ErrorAge.Visible = false;
            label_ErrorMsg.Visible = false;
            label_SavedSuccessfully.Visible = false;
        }

        private void HighlightButtonAndPanel(cuiButton activeButton)
        {
            buttonPanelMap = new Dictionary<cuiButton, Panel>
            {
                { cuiButton_AccountDetails, panel_bg_AccountDetails },
                { cuiButton_StorePreferences, panel_bg_StorePreferences },
                { cuiButton_FamilyManagement, panel_bg_FamilyManagement },
                { cuiButton_LanguagePreferences, panel_bg_LanguagePreferences },
                { cuiButton_CookiesBrowsing, panel_bg_CookiesBrowsing },
                { cuiButton_NotificationSetting, panel_bg_NotificationSetting }
            };

            foreach (var pair in buttonPanelMap)
            {
                pair.Key.NormalBackground = (pair.Key == activeButton)
                    ? Color.FromArgb(33, 60, 88)
                    : Color.FromArgb(27, 40, 56);
                pair.Value.BackColor = (pair.Key == activeButton)
                    ? Color.FromArgb(26, 159, 255)
                    : Color.FromArgb(27, 40, 56);
            }
        }

        







        

    }
}
