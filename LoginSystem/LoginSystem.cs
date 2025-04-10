using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class LoginSystem: Form
    {
        // dragging form
        private bool mouseDown;
        private Point lastLocation;

        private bool hidden = false;

        public LoginSystem()
        {
            InitializeComponent();
        }

        private void LoginSystem_Load(object sender, EventArgs e)
        {
            this.Panel_Title.MouseDown += this.MouseDown;
            this.Panel_Title.MouseMove += this.MouseMove;
            this.Panel_Title.MouseUp += this.MouseUp;

            textBox_AccountName.TextChanged += HideErrorMsg;
            textBox_Password.TextChanged += HideErrorMsg;
        }





        private void button_Exit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Environment.Exit(0);
        }

        private void cuiButton_SignIn_Click(object sender, EventArgs e)
        {
            string accountName = "admin";
            string password = "1234";

            if (textBox_AccountName.Text == accountName && textBox_Password.Text == password)
            {
                //MessageBox.Show("Login successful!");
                
                this.Hide(); 
                PersonalInformationProfile profileForm = new PersonalInformationProfile();
                profileForm.Show(); 
            }
            else
            {
                //MessageBox.Show("Invalid account name or password.");

                label_ErrorMsg.Visible = true;  
                label_ErrorMsg.Show();
                    
                panel_ErrorAccountName.Visible = true;  
                panel_ErrorAccountName.Show(); 
                
                panel_ErrorPassword.Visible = true;
                panel_ErrorPassword.Show();
            }
        }














        

        private void HideErrorMsg(object sender, EventArgs e)
        {
            panel_ErrorAccountName.Visible = false;
            panel_ErrorPassword.Visible = false;
            label_ErrorMsg.Visible = false;
            hidden = true;
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
