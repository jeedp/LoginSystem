using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }





        private void button_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
