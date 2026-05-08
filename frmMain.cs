// rename class and constructor to frmMain - Mike

using System;                                      // using System namespace
using System.Windows.Forms;                        // using Windows Forms namespace

namespace DeliciosoERistorante                     // project namespace
{
    public partial class frmMain : Form          // frmMain class
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
