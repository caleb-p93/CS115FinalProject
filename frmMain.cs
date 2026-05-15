/*
Group Name: Foundational Devs
Students Names: Michael Roberts, Caleb Perkins, Andy G Mendoza
Final Project
Description:  This is the main splash page for the menu.  You will see the name of the restaraunt and can press a button to enter the menu.
*/

using System;                                      // using System namespace
using System.Windows.Forms;                        // using Windows Forms namespace
using System.Drawing;                              // using drawing namespace for Rectangle and Size
using System.Collections.Generic;                  // using collection name space for dictionary

namespace DeliciosoERistorante                     // project namespace
{
    public partial class frmMain : Form            // frmSplash class
    {
        private Dictionary<Control, Rectangle> originalBounds = new Dictionary<Control, Rectangle>(); // dictionary for proportional resizing
        private Size originalFormSize;             // store original form size for scaling

        public frmMain()                           // constructor
        {
            InitializeComponent();                 // initialize form components
            MaximizeSplashForm();                  // call method to maximize form
        }

        private void MaximizeSplashForm()          // method to maximize splash form
        {
            this.WindowState = FormWindowState.Maximized;   // set window state to maximized
        }

        private void frmMain_Load(object sender, EventArgs e)   // load event for proportional resizing
        {
            originalFormSize = this.Size;          // store original form size

            foreach (Control c in this.Controls)   // loop through controls
                originalBounds[c] = c.Bounds;      // store original bounds
        }

        private void frmMain_Resize(object sender, EventArgs e) // resize event for proportional scaling
        {
            if (originalFormSize.Width == 0 || originalFormSize.Height == 0)   // prevent divide by zero
                return;                                  // exit if invalid

            float xRatio = (float)this.Width / originalFormSize.Width;   // compute width ratio
            float yRatio = (float)this.Height / originalFormSize.Height; // compute height ratio

            foreach (Control c in this.Controls)         // loop through controls
            {
                Rectangle r = originalBounds[c];         // get original bounds

                c.SetBounds(                             // set new proportional bounds
                    (int)(r.X * xRatio),                 // new X
                    (int)(r.Y * yRatio),                 // new Y
                    (int)(r.Width * xRatio),             // new Width
                    (int)(r.Height * yRatio)             // new Height
                );
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)   // menu button click event
        {
            OpenfrmMenu();                         // call method to open menu form
        }

        private void OpenfrmMenu()                 // method to open menu form
        {
            frmMenu menu = new frmMenu();          // create new instance of frmMenu
            menu.Show();                           // show menu form
            this.Hide();                           // hide splash form
        }
    }
}
