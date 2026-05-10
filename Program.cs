/*
Group Name: 
Students Names: Michael Roberts, Caleb Perkins, Andy G Mendoza
Final Project
Description:  This is a digital menu.  Customers can interact with it.  It will take them through an ordering and reordering process.  Then to payment, and finally a receipt page where they can save their
receipt.  The program is designed to automatically reset once a customer is done.  Each customer will receive a unique number that will display on the saved txt receipt.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliciosoERistorante
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
