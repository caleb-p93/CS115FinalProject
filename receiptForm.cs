using System;                                      // using System namespace
using System.Collections.Generic;                  // using generic collections
using System.IO;                                   // using IO namespace
using System.Text;                                 // using StringBuilder
using System.Windows.Forms;                        // using Windows Forms namespace

namespace DeliciosoERistorante                     // project namespace
{
    public partial class ReceiptForm : Form        // ReceiptForm class
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

        public ReceiptForm(int receiptNumber, string customerName, string paymentMethod,
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

            DisplayReceipt();                      // call method to display receipt
        }

        private void DisplayReceipt()              // method to display receipt
        {
            lblReceiptNumber.Text = receiptNumber.ToString();   // display receipt number
            lblCustomerName.Text = customerName;   // display customer name
            lblPaymentMethod.Text = paymentMethod; // display payment method

            StringBuilder receiptBuilder = new StringBuilder(); // create StringBuilder
            receiptBuilder.AppendLine("----- Delicioso E‑Ristorante -----");   // header
            receiptBuilder.AppendLine($"Receipt #: {receiptNumber}");          // receipt number line
            receiptBuilder.AppendLine($"Customer: {customerName}");            // customer name line
            receiptBuilder.AppendLine($"Payment: {paymentMethod}");            // payment method line
            receiptBuilder.AppendLine($"Date/Time: {DateTime.Now}");           // date and time line
            receiptBuilder.AppendLine("");                                     // blank line
            receiptBuilder.AppendLine("Items Ordered:");                       // items header

            foreach (OrderItem item in orderList)                              // loop through items
            {
                receiptBuilder.AppendLine($"{item.Name} x{item.Quantity} @ {item.UnitPrice:C} = {item.LineTotal():C}");   // item line
            }

            receiptBuilder.AppendLine("----------------------------------");   // divider
            receiptBuilder.AppendLine($"Subtotal: {subtotal:C}");              // subtotal line
            receiptBuilder.AppendLine($"Tax (9.5%): {taxAmount:C}");           // tax line
            receiptBuilder.AppendLine($"Total Before Tip: {totalBeforeTip:C}");// total before tip line
            receiptBuilder.AppendLine($"Tip: {tipAmount:C}");                  // tip line
            receiptBuilder.AppendLine($"Grand Total: {grandTotal:C}");         // grand total line
            receiptBuilder.AppendLine("----------------------------------");   // divider
            receiptBuilder.AppendLine("Thank you for dining with us!");        // thank you line

            txtReceiptDisplay.Text = receiptBuilder.ToString();                // display receipt text
        }

        private void btnSaveReceipt_Click(object sender, EventArgs e)          // save receipt button click event
        {
            try                                                                // try block
            {
                if (saveReceiptFile.ShowDialog() == DialogResult.OK)           // show save file dialog
                {
                    string filePath = saveReceiptFile.FileName;                // get file path
                    File.WriteAllText(filePath, txtReceiptDisplay.Text);       // write receipt to file
                    MessageBox.Show("Receipt saved successfully!");            // show success message

                    SplashForm splash = new SplashForm();                      // create new splash form
                    splash.Show();                                             // show splash form
                    this.Hide();                                               // hide receipt form
                }
            }
            catch (Exception ex)                                               // catch block
            {
                MessageBox.Show("Error saving receipt: " + ex.Message);        // show error message
            }
        }
    }
}
