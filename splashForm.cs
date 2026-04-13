using System;                                      // using System namespace
using System.Windows.Forms;                        // using Windows Forms namespace

namespace DeliciosoERistorante                     // project namespace
{
    public partial class SplashForm : Form         // SplashForm class
    {
        public SplashForm()                        // constructor
        {
            InitializeComponent();                 // initialize form components
            MaximizeSplashForm();                  // call method to maximize form
        }

        private void MaximizeSplashForm()          // method to maximize splash form
        {
            this.WindowState = FormWindowState.Maximized;   // set window state to maximized
        }

        private void btnEnter_Click(object sender, EventArgs e)   // enter button click event
        {
            OpenMenuForm();                        // call method to open menu form
        }

        private void OpenMenuForm()                // method to open menu form
        {
            MenuForm menu = new MenuForm();        // create new instance of MenuForm
            menu.Show();                           // show menu form
            this.Hide();                           // hide splash form
        }
    }
}
