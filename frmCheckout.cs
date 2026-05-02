using System;                                      // using System namespace
using System.Collections.Generic;                  // using generic collections
using System.Windows.Forms;                        // using Windows Forms namespace

namespace DeliciosoERistorante                     // project namespace
{
    public partial class frmCheckout : Form       // frmCheckout class
    {
        private List<OrderItem> orderList;         // list of ordered items
        private const double TaxRate = 0.095;      // constant tax rate
        private static int receiptCounter = 1;     // static receipt counter

        private double subtotal;                   // subtotal field
        private double taxAmount;                  // tax amount field
        private double totalBeforeTip;             // total before tip field
        private double tipAmount;                  // tip amount field
        private double grandTotal;                 // grand total field

        public frmCheckout(List<OrderItem> order) // constructor
        {
            InitializeComponent();                 // initialize form components
            this.WindowState = FormWindowState.Maximized;   // maximize form window
            orderList = order;                     // assign order list
            CalculateSubtotal();                   // calculate subtotal
            DisplayInitialTotals();                // display initial totals
        }

        private void CalculateSubtotal()           // method to calculate subtotal
        {
            subtotal = 0;                          // reset subtotal

            foreach (OrderItem item in orderList)  // loop through order items
            {
                subtotal += item.LineTotal();      // add line total to subtotal
            }
        }

        private void DisplayInitialTotals()        // method to display initial totals
        {
            lblSubtotal.Text = subtotal.ToString("C");   // display subtotal
            lblTax.Text = "";                     // clear tax label
            lblTotalBeforeTip.Text = "";          // clear total before tip label
            lblTipAmount.Text = "";               // clear tip label
            lblGrandTotal.Text = "";              // clear grand total label
        }

        private void btnRequestCheck_Click(object sender, EventArgs e)   // request check click event
        {
            try                                     // try block
            {
                CalculateTax();                     // calculate tax
                CalculateTip();                     // calculate tip
                CalculateGrandTotal();              // calculate grand total
                DisplayTotals();                    // display totals
            }
            catch (Exception ex)                    // catch block
            {
                MessageBox.Show("Error calculating check: " + ex.Message);   // show error message
            }
        }

        private void CalculateTax()                // method to calculate tax
        {
            taxAmount = subtotal * TaxRate;        // calculate tax amount
            totalBeforeTip = subtotal + taxAmount; // calculate total before tip
        }

        private void CalculateTip()                // method to calculate tip
        {
            double tipPercent = 0;                 // tip percent variable

            if (!string.IsNullOrWhiteSpace(txtTip.Text))   // check if tip entered
            {
                if (!double.TryParse(txtTip.Text, out tipPercent))   // try parse tip
                {
                    MessageBox.Show("Please enter a valid numeric tip percentage.");   // show message
                    return;                        // exit method
                }

                if (tipPercent < 0)                // check negative tip
                {
                    MessageBox.Show("Tip percentage cannot be negative.");   // show message
                    return;                        // exit method
                }
            }

            tipPercent = tipPercent / 100.0;       // convert percent to decimal
            tipAmount = totalBeforeTip * tipPercent;   // calculate tip amount
        }

        private void CalculateGrandTotal()         // method to calculate grand total
        {
            grandTotal = totalBeforeTip + tipAmount;   // calculate grand total
        }

        private void DisplayTotals()               // method to display totals
        {
            lblTax.Text = taxAmount.ToString("C");         // display tax
            lblTotalBeforeTip.Text = totalBeforeTip.ToString("C");   // display total before tip
            lblTipAmount.Text = tipAmount.ToString("C");   // display tip
            lblGrandTotal.Text = grandTotal.ToString("C"); // display grand total
        }

        private void btnPay_Click(object sender, EventArgs e)           // pay button click event
        {
            try                                                         // try block
            {
                if (!ValidateBeforePayment())                           // validate before payment
                {
                    return;                                             // exit if invalid
                }

                string customerName = txtCustomerName.Text.Trim();      // get customer name
                string paymentMethod = GetSelectedPaymentMethod();      // get payment method

                if (!ValidatePaymentDetails(paymentMethod))             // validate payment details
                {
                    return;                                             // exit if invalid
                }

                ShowPaymentMessage(paymentMethod);                      // show payment message

                int currentReceiptNumber = receiptCounter;              // store current receipt number
                receiptCounter++;                                       // increment receipt counter

                frmReceipt receiptForm = new frmReceipt(              // create receipt form
                    currentReceiptNumber,                               // pass receipt number
                    customerName,                                       // pass customer name
                    paymentMethod,                                      // pass payment method
                    orderList,                                          // pass order list
                    subtotal,                                           // pass subtotal
                    taxAmount,                                          // pass tax amount
                    totalBeforeTip,                                     // pass total before tip
                    tipAmount,                                          // pass tip amount
                    grandTotal                                          // pass grand total
                );

                receiptForm.Show();                                     // show receipt form
                this.Hide();                                            // hide checkout form
            }
            catch (Exception ex)                                        // catch block
            {
                MessageBox.Show("Error processing payment: " + ex.Message);   // show error message
            }
        }

        private bool ValidateBeforePayment()                            // method to validate before payment
        {
            if (orderList.Count == 0)                                   // check empty order
            {
                MessageBox.Show("No items in the order.");              // show message
                return false;                                           // return false
            }

            if (grandTotal <= 0)                                        // check if check requested
            {
                MessageBox.Show("Please request the check before paying.");   // show message
                return false;                                           // return false
            }

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))        // check customer name
            {
                MessageBox.Show("Please enter the customer name.");     // show message
                return false;                                           // return false
            }

            return true;                                                // return true
        }

        private string GetSelectedPaymentMethod()                       // method to get payment method
        {
            if (rbCash.Checked)                                         // cash selected
            {
                return "Cash";                                          // return cash
            }

            if (rbDebit.Checked)                                        // debit selected
            {
                return "Debit Card";                                    // return debit
            }

            if (rbCredit.Checked)                                       // credit selected
            {
                return "Credit Card";                                   // return credit
            }

            return null;                                                // return null if none selected
        }

        private bool ValidatePaymentDetails(string paymentMethod)       // method to validate payment details
        {
            if (paymentMethod == null)                                  // check null
            {
                MessageBox.Show("Please select a method of payment.");  // show message
                return false;                                           // return false
            }

            if (paymentMethod == "Cash")                                // cash case
            {
                return true;                                            // no details needed
            }

            if (string.IsNullOrWhiteSpace(txtCardNumber.Text))          // check card number
            {
                MessageBox.Show("Please enter the card number.");       // show message
                return false;                                           // return false
            }

            if (string.IsNullOrWhiteSpace(txtExpiration.Text))          // check expiration
            {
                MessageBox.Show("Please enter the expiration date.");   // show message
                return false;                                           // return false
            }

            if (paymentMethod == "Debit Card")                          // debit case
            {
                if (string.IsNullOrWhiteSpace(txtPin.Text))             // check pin
                {
                    MessageBox.Show("Please enter the PIN.");           // show message
                    return false;                                       // return false
                }
            }

            return true;                                                // return true
        }

        private void ShowPaymentMessage(string paymentMethod)           // method to show payment message
        {
            switch (paymentMethod)                                      // switch on payment method
            {
                case "Cash":                                            // cash case
                    MessageBox.Show("Please wait for the waiter to collect the cash at the table.");   // message
                    break;                                              // break

                case "Debit Card":                                      // debit case
                    MessageBox.Show("Your debit card will be processed electronically.");   // message
                    break;                                              // break

                case "Credit Card":                                     // credit case
                    MessageBox.Show("Your credit card will be processed electronically.");   // message
                    break;                                              // break
            }
        }
    }
}
