using System;                                      // using System namespace
using System.Collections.Generic;                  // using generic collections
using System.Windows.Forms;                        // using Windows Forms namespace

namespace DeliciosoERistorante                     // project namespace
{
    public partial class frmCheckout : Form        // frmCheckout class
    {
        private List<OrderItem> orderList;         // list of ordered items
        private const double TaxRate = 0.095;      // constant tax rate
        private static int receiptCounter = 1;     // static receipt counter

        private double subtotal;                   // subtotal field
        private double taxAmount;                  // tax amount field
        private double totalBeforeTip;             // total before tip field
        private double tipAmount;                  // tip amount field
        private double grandTotal;                 // grand total field

        public frmCheckout(List<OrderItem> order)  // constructor
        {
            InitializeComponent();                 // initialize form components
            this.WindowState = FormWindowState.Maximized;   // maximize window
            orderList = order;                     // assign order list
            CalculateSubtotal();                   // calculate subtotal
            CalculateTax();                        // calculate tax immediately
            DisplayInitialTotals();                // display subtotal and tax
            LoadItemizedBill();                    // load itemized bill list
        }

        private void LoadItemizedBill()            // method to load itemized bill
        {
            lstItemizedBill.Items.Clear();         // clear listbox

            foreach (OrderItem item in orderList)  // loop through items
            {
                lstItemizedBill.Items.Add(item.ToString());   // add item to listbox
            }
        }

        private void CalculateSubtotal()           // method to calculate subtotal
        {
            subtotal = 0;                          // reset subtotal

            foreach (OrderItem item in orderList)  // loop through items
            {
                subtotal += item.LineTotal();      // add line total
            }
        }

        private void CalculateTax()                // method to calculate tax
        {
            taxAmount = subtotal * TaxRate;        // compute tax
            totalBeforeTip = subtotal + taxAmount; // compute total before tip
        }

        private void DisplayInitialTotals()        // method to display initial totals
        {
            txtSubtotal.Text = subtotal.ToString("C");   // display subtotal
            txtTax.Text = taxAmount.ToString("C");       // display tax immediately
            txtTotal.Text = "";                          // clear grand total textbox
        }

        private void btnCalcTotal_Click(object sender, EventArgs e)   // calculate total click
        {
            try                                     // try block
            {
                CalculateTip();                     // calculate tip (dollar amount)
                CalculateGrandTotal();              // calculate grand total
                DisplayTotals();                    // display totals
            }
            catch (Exception ex)                    // catch block
            {
                MessageBox.Show("Error calculating total: " + ex.Message);   // show error
            }
        }

        private void CalculateTip()                // method to calculate tip
        {
            tipAmount = 0;                         // reset tip amount

            if (!string.IsNullOrWhiteSpace(txtTip.Text))   // check if tip entered
            {
                if (!double.TryParse(txtTip.Text, out tipAmount))   // try parse tip amount
                {
                    MessageBox.Show("Please enter a valid numeric tip amount.");   // show error
                    tipAmount = 0;                     // reset on error
                    return;                            // exit method
                }

                if (tipAmount < 0)                     // check negative tip
                {
                    MessageBox.Show("Tip amount cannot be negative.");   // show error
                    tipAmount = 0;                     // reset on error
                    return;                            // exit method
                }
            }
        }

        private void CalculateGrandTotal()         // method to calculate grand total
        {
            grandTotal = totalBeforeTip + tipAmount;   // compute grand total
        }

        private void DisplayTotals()               // method to display totals
        {
            txtTax.Text = taxAmount.ToString("C");         // display tax
            txtTotal.Text = grandTotal.ToString("C");      // display grand total
        }

        private void btnPayment_Click(object sender, EventArgs e)   // payment click event
        {
            try                                             // try block
            {
                if (!ValidateBeforePayment())               // validate before payment
                    return;                                 // exit if invalid

                string customerName = txtCustName.Text.Trim();   // get customer name
                string paymentMethod = GetSelectedPaymentMethod();   // get payment method

                if (!ValidatePaymentDetails(paymentMethod))   // validate payment details
                    return;                                   // exit if invalid

                ShowPaymentMessage(paymentMethod);            // show payment message

                int currentReceiptNumber = receiptCounter;    // store receipt number
                receiptCounter++;                             // increment counter

                frmReceipt receiptForm = new frmReceipt(      // create receipt form
                    currentReceiptNumber,                     // pass receipt number
                    customerName,                             // pass customer name
                    paymentMethod,                            // pass payment method
                    orderList,                                // pass order list
                    subtotal,                                 // pass subtotal
                    taxAmount,                                // pass tax amount
                    totalBeforeTip,                           // pass total before tip
                    tipAmount,                                // pass tip amount
                    grandTotal                                // pass grand total
                );

                receiptForm.Show();                           // show receipt form
                this.Hide();                                  // hide checkout form
            }
            catch (Exception ex)                              // catch block
            {
                MessageBox.Show("Error processing payment: " + ex.Message);   // show error
            }
        }

        private bool ValidateBeforePayment()                  // validate before payment
        {
            if (orderList.Count == 0)                         // check empty order
            {
                MessageBox.Show("No items in the order.");    // show error
                return false;                                 // return false
            }

            if (grandTotal <= 0)                              // check if total calculated
            {
                MessageBox.Show("Please calculate the total before paying.");   // show error
                return false;                                 // return false
            }

            if (string.IsNullOrWhiteSpace(txtCustName.Text))  // check customer name
            {
                MessageBox.Show("Please enter the customer name.");   // show error
                return false;                                 // return false
            }

            return true;                                      // return true
        }

        private string GetSelectedPaymentMethod()             // get payment method
        {
            if (radCash.Checked)                              // cash selected
                return "Cash";                                // return cash

            if (radDebitCard.Checked)                         // debit selected
                return "Debit Card";                          // return debit

            if (radCreditCard.Checked)                        // credit selected
                return "Credit Card";                         // return credit

            return null;                                      // return null if none selected
        }

        private bool ValidatePaymentDetails(string paymentMethod)   // validate payment details
        {
            if (paymentMethod == null)                        // check null
            {
                MessageBox.Show("Please select a method of payment.");   // show error
                return false;                                 // return false
            }

            if (paymentMethod == "Cash")                      // cash case
                return true;                                  // no details needed

            if (string.IsNullOrWhiteSpace(txtCardNumber.Text))   // check card number
            {
                MessageBox.Show("Please enter the card number.");   // show error
                return false;                                 // return false
            }

            if (string.IsNullOrWhiteSpace(txtExpireDate.Text))   // check expiration
            {
                MessageBox.Show("Please enter the expiration date.");   // show error
                return false;                                 // return false
            }

            if (paymentMethod == "Debit Card")                // debit case
            {
                if (string.IsNullOrWhiteSpace(txtPin.Text))   // check pin
                {
                    MessageBox.Show("Please enter the PIN.");   // show error
                    return false;                             // return false
                }
            }

            return true;                                      // return true
        }

        private void ShowPaymentMessage(string paymentMethod) // show payment message
        {
            switch (paymentMethod)                            // switch on method
            {
                case "Cash":                                  // cash case
                    MessageBox.Show("Please wait for the waiter to collect the cash at the table.");   // message
                    break;                                    // break

                case "Debit Card":                            // debit case
                    MessageBox.Show("Your debit card will be processed electronically.");   // message
                    break;                                    // break

                case "Credit Card":                           // credit case
                    MessageBox.Show("Your credit card will be processed electronically.");   // message
                    break;                                    // break
            }
        }
    }
}
