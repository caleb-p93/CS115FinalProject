/*
Group Name: Foundational Devs
Students Names: Michael Roberts, Caleb Perkins, Andy G Mendoza
Final Project
Description:  This is the receipt page.  Once payment is submitted on the checkout form, the customer will be brought here.  It will display customer information on the left and order details with pricing on the
right.  Customer can save this to a txt file. Once saved, the program goes back the splash page ready for the next customer.  
*/

using System;                                      // using System namespace
using System.Collections.Generic;                  // using generic collections
using System.IO;                                   // using IO namespace
using System.Windows.Forms;                        // using Windows Forms namespace

namespace DeliciosoERistorante                     // project namespace
{
    public partial class frmReceipt : Form         // class name
    {
        private int receiptNumber;                 // receipt number field
        private string customerName;               // customer name field
        private string paymentMethod;              // payment method field
        private List<OrderItem> orderList;         // list of ordered items
        private double subtotal;                   // subtotal field
        private double taxAmount;                  // tax amount field
        private double totalBeforeTip;             // total before tip field
        private double tipAmount;                  // tip amount field
        private double grandTotal;                 // grand total field

        public frmReceipt(int receiptNumber, string customerName, string paymentMethod,
                           List<OrderItem> orderList, double subtotal, double taxAmount,
                           double totalBeforeTip, double tipAmount, double grandTotal)   // constructor
        {
            InitializeComponent();                 // initialize form components
            this.WindowState = FormWindowState.Maximized;   // maximize form window

            this.receiptNumber = receiptNumber;    // assign receipt number
            this.customerName = customerName;      // assign customer name
            this.paymentMethod = paymentMethod;    // assign payment method
            this.orderList = orderList;            // assign order list
            this.subtotal = subtotal;              // assign subtotal
            this.taxAmount = taxAmount;            // assign tax amount
            this.totalBeforeTip = totalBeforeTip;  // assign total before tip
            this.tipAmount = tipAmount;            // assign tip amount
            this.grandTotal = grandTotal;          // assign grand total

            btnSaveReceipt.Click += btnSaveReceipt_Click;   // wire save receipt button

            DisplayReceipt();                      // display receipt details
        }

        private void DisplayReceipt()              // method to display receipt
        {
            txtReceiptNum.Text = receiptNumber.ToString();   // display receipt number
            txtCustName.Text = customerName;      // display customer name
            txtPaymentMethod.Text = paymentMethod; // display payment method
            txtDateTime.Text = DateTime.Now.ToString();   // display date and time

            lstOrderSummary.Items.Clear();         // clear order summary listbox

            foreach (OrderItem item in orderList)  // loop through ordered items
            {
                lstOrderSummary.Items.Add(
                    $"{item.Name} x{item.Quantity} - {item.LineTotal():C}");   // add item line
            }

            txtSubtotalReceipt.Text = subtotal.ToString("C");        // display subtotal
            txtTaxReceipt.Text = taxAmount.ToString("C");            // display tax
            txtTipReceipt.Text = tipAmount.ToString("C");            // display tip
            txtTotalReceipt.Text = grandTotal.ToString("C");         // display grand total
        }

        private void btnSaveReceipt_Click(object sender, EventArgs e)   // save receipt click event
        {
            try                                                         // try block
            {
                if (saveReceiptFile.ShowDialog() == DialogResult.OK)    // show save dialog
                {
                    string filePath = saveReceiptFile.FileName;         // get file path

                    using (StreamWriter writer = new StreamWriter(filePath))   // create writer
                    {
                        writer.WriteLine("----- Delicioso E-Ristorante -----");   // header
                        writer.WriteLine($"Receipt #: {receiptNumber}");         // receipt number
                        writer.WriteLine($"Customer: {customerName}");           // customer name
                        writer.WriteLine($"Payment: {paymentMethod}");           // payment method
                        writer.WriteLine($"Date/Time: {DateTime.Now}");          // date and time
                        writer.WriteLine("");                                    // blank line
                        writer.WriteLine("Items Ordered:");                      // items header

                        foreach (OrderItem item in orderList)                    // loop items
                        {
                            writer.WriteLine(
                                $"{item.Name} x{item.Quantity} @ {item.UnitPrice:C} = {item.LineTotal():C}");
                        }

                        writer.WriteLine("----------------------------------");   // divider
                        writer.WriteLine($"Subtotal: {subtotal:C}");             // subtotal
                        writer.WriteLine($"Tax (9.5%): {taxAmount:C}");          // tax
                        writer.WriteLine($"Total Before Tip: {totalBeforeTip:C}"); // total before tip
                        writer.WriteLine($"Tip: {tipAmount:C}");                 // tip
                        writer.WriteLine($"Grand Total: {grandTotal:C}");        // grand total
                        writer.WriteLine("----------------------------------");   // divider
                        writer.WriteLine("Thank you for dining with us!");       // thank you line
                    }

                    MessageBox.Show("Receipt saved successfully!");   // success message

                    frmMain splash = new frmMain();               // create splash form
                    splash.Show();                                    // show splash form
                    this.Hide();                                      // hide receipt form
                }
            }
            catch (Exception ex)                                      // catch block
            {
                MessageBox.Show("Error saving receipt: " + ex.Message); // show error message
            }
        }
    }
}