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
    public partial class LoginForm: Form
    {
        // dragging form
        private bool mouseDown;
        private Point lastLocation;

        private string accountName = "admin";
        private string password = "1234";

        //private bool forgotPassword = false;





        public LoginForm()
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

        public void cuiButton_SignIn_Click(object sender, EventArgs e)
        {
            

            if (textBox_AccountName.Text == accountName && textBox_Password.Text == password)
            {
                //MessageBox.Show("Login successful!");
                
                this.Hide(); 
                MainMenuForm profileForm = new MainMenuForm();
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

        private void cuiButton_CantSignIn_Click(object sender, EventArgs e)
        {
            // TODO: Implement forgot password functionality

            //password = textBox_Password.Text;

            if (textBox_AccountName.Text == accountName)
                MessageBox.Show("Password: " + password);
            else
                MessageBox.Show("Invalid account name.");
        }










        private void HideErrorMsg(object sender, EventArgs e)
        {
            panel_ErrorAccountName.Visible = false;
            panel_ErrorPassword.Visible = false;
            label_ErrorMsg.Visible = false;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '<' && e.KeyChar != '>')
            {
                e.Handled = true; // Block the key press
            }
        }





        private new void MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private new void MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private new void MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

    }
}
