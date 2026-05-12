/*
Group Name: Foundational Devs
Students Names: Michael Roberts, Caleb Perkins, Andy G Mendoza
Final Project
Description:  This is the main splash page for the menu.  You will see the name of the restaraunt and can press a button to enter the menu.
*/

using System;                                      // using System namespace
using System.Windows.Forms;                        // using Windows Forms namespace

namespace DeliciosoERistorante                     // project namespace
{
    public partial class frmMain : Form          // frmSplash class
    {
        public frmMain()                         // constructor
        {
            InitializeComponent();                 // initialize form components
            MaximizeSplashForm();                  // call method to maximize form
        }

        private void MaximizeSplashForm()          // method to maximize splash form
        {
            this.WindowState = FormWindowState.Maximized;   // set window state to maximized
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