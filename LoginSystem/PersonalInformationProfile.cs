using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace LoginSystem
{
    public partial class PersonalInformationProfile: Form
    {
        // dragging form
        private bool mouseDown;
        private Point lastLocation;

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

            //panel_AccountDetails.MouseEnter += PanelMouseHoverEnter;
            //panel_AccountDetails.MouseLeave += PanelMouseHoverLeave;

            //panel5.MouseEnter += PanelMouseHoverEnter;
            //panel5.MouseLeave += PanelMouseHoverLeave;

            //panel6.MouseEnter += PanelMouseHoverEnter;
            //panel6.MouseLeave += PanelMouseHoverLeave;

            //panel7.MouseEnter += PanelMouseHoverEnter;
            //panel7.MouseLeave += PanelMouseHoverLeave;

            //panel8.MouseEnter += PanelMouseHoverEnter;
            //panel8.MouseLeave += PanelMouseHoverLeave;

            //panel9.MouseEnter += PanelMouseHoverEnter;
            //panel9.MouseLeave += PanelMouseHoverLeave;

            string filePath = "userdata.txt";

            if (File.Exists(filePath))
            {
                string savedData = File.ReadAllText(filePath);
                textBox_Output.Text = savedData;
            }
        }





        private void button_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        






        private void HideErrorMsg(object sender, EventArgs e)
        {
            panel_ErrorFullName.Visible = false;
            panel_ErrorGender.Visible = false;
            panel_ErrorAge.Visible = false;
            label_ErrorMsg.Visible = false;
            label_SavedSuccessfully.Visible = false;
        }








        private void PanelMouseHoverEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(26, 159, 255); // Or any color you like
        }

        private void PanelMouseHoverLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(27, 40, 56); // Resets to default
        }









        private void MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

    }
}
