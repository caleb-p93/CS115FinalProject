namespace DeliciosoERistorante
{
    partial class frmCheckout
    {
        private System.ComponentModel.IContainer components = null;    // component container

        protected override void Dispose(bool disposing)               // dispose method
        {
            if (disposing && (components != null))                    // check components
                components.Dispose();                                 // dispose components

            base.Dispose(disposing);                                   // call base dispose
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()                             // initialize components
        {
            System.ComponentModel.ComponentResourceManager resources = 
                new System.ComponentModel.ComponentResourceManager(typeof(frmCheckout));   // resource manager

            this.lblYourBill = new System.Windows.Forms.Label();       // label Your Bill
            this.gbxItemizedBill = new System.Windows.Forms.GroupBox(); // groupbox itemized bill
            this.btnCalcTotal = new System.Windows.Forms.Button();     // button calculate total
            this.txtTotal = new System.Windows.Forms.TextBox();        // textbox total
            this.txtTax = new System.Windows.Forms.TextBox();          // textbox tax
            this.lblTotal = new System.Windows.Forms.Label();          // label total
            this.lblNoTaxTip = new System.Windows.Forms.Label();       // label no tax on tip
            this.txtSubtotal = new System.Windows.Forms.TextBox();     // textbox subtotal
            this.txtTip = new System.Windows.Forms.TextBox();          // textbox tip
            this.lblTax = new System.Windows.Forms.Label();            // label tax
            this.lblTip = new System.Windows.Forms.Label();            // label tip
            this.lblSubtotal = new System.Windows.Forms.Label();       // label subtotal
            this.lstItemizedBill = new System.Windows.Forms.ListBox(); // listbox itemized bill

            this.gbxPayment = new System.Windows.Forms.GroupBox();     // groupbox payment
            this.txtCustName = new System.Windows.Forms.TextBox();     // textbox customer name
            this.lblCustName = new System.Windows.Forms.Label();       // label customer name
            this.btnPayment = new System.Windows.Forms.Button();       // button submit payment
            this.txtPin = new System.Windows.Forms.TextBox();          // textbox pin
            this.lblPin = new System.Windows.Forms.Label();            // label pin
            this.txtExpireDate = new System.Windows.Forms.TextBox();   // textbox expiration date
            this.lblExpireDate = new System.Windows.Forms.Label();     // label expiration date
            this.txtCardNumber = new System.Windows.Forms.TextBox();   // textbox card number
            this.lblCardNumber = new System.Windows.Forms.Label();     // label card number
            this.radDebitCard = new System.Windows.Forms.RadioButton(); // radio debit card
            this.radCreditCard = new System.Windows.Forms.RadioButton(); // radio credit card
            this.label1 = new System.Windows.Forms.Label();            // label payment method
            this.radCash = new System.Windows.Forms.RadioButton();     // radio cash

            this.gbxItemizedBill.SuspendLayout();                      // suspend itemized bill layout
            this.gbxPayment.SuspendLayout();                           // suspend payment layout
            this.SuspendLayout();                                      // suspend form layout

            // lblYourBill
            this.lblYourBill.AutoSize = true;                          // autosize
            this.lblYourBill.BackColor = System.Drawing.Color.OldLace; // background color
            this.lblYourBill.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold); // font
            this.lblYourBill.Location = new System.Drawing.Point(550, 24); // location
            this.lblYourBill.Name = "lblYourBill";                     // name
            this.lblYourBill.Size = new System.Drawing.Size(146, 44);  // size
            this.lblYourBill.TabIndex = 4;                             // tab index
            this.lblYourBill.Text = "Your Bill";                      // text

            // gbxItemizedBill
            this.gbxItemizedBill.BackColor = System.Drawing.Color.OldLace; // background
            this.gbxItemizedBill.Controls.Add(this.btnCalcTotal);      // add button
            this.gbxItemizedBill.Controls.Add(this.txtTotal);          // add total textbox
            this.gbxItemizedBill.Controls.Add(this.txtTax);            // add tax textbox
            this.gbxItemizedBill.Controls.Add(this.lblTotal);          // add total label
            this.gbxItemizedBill.Controls.Add(this.lblNoTaxTip);       // add no tax label
            this.gbxItemizedBill.Controls.Add(this.txtSubtotal);       // add subtotal textbox
            this.gbxItemizedBill.Controls.Add(this.txtTip);            // add tip textbox
            this.gbxItemizedBill.Controls.Add(this.lblTax);            // add tax label
            this.gbxItemizedBill.Controls.Add(this.lblTip);            // add tip label
            this.gbxItemizedBill.Controls.Add(this.lblSubtotal);       // add subtotal label
            this.gbxItemizedBill.Controls.Add(this.lstItemizedBill);   // add listbox
            this.gbxItemizedBill.Location = new System.Drawing.Point(166, 103); // location
            this.gbxItemizedBill.Name = "gbxItemizedBill";             // name
            this.gbxItemizedBill.Size = new System.Drawing.Size(451, 510); // size
            this.gbxItemizedBill.TabIndex = 6;                         // tab index
            this.gbxItemizedBill.TabStop = false;                      // tab stop
            this.gbxItemizedBill.Text = "Itemized Bill";               // text

            // btnCalcTotal
            this.btnCalcTotal.BackColor = System.Drawing.Color.Wheat;  // background
            this.btnCalcTotal.Location = new System.Drawing.Point(242, 411); // location
            this.btnCalcTotal.Name = "btnCalcTotal";                   // name
            this.btnCalcTotal.Size = new System.Drawing.Size(112, 30); // size
            this.btnCalcTotal.TabIndex = 22;                           // tab index
            this.btnCalcTotal.Text = "Calculate Total"; // text
            this.btnCalcTotal.UseVisualStyleBackColor = false;         // use style
            this.btnCalcTotal.Click += new System.EventHandler(this.btnCalcTotal_Click); // FIXED EVENT HOOKUP

            // txtTotal
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window; // background
            this.txtTotal.Location = new System.Drawing.Point(287, 463); // location
            this.txtTotal.Name = "txtTotal";                           // name
            this.txtTotal.ReadOnly = true;                             // readonly
            this.txtTotal.Size = new System.Drawing.Size(100, 22);     // size
            this.txtTotal.TabIndex = 7;                                // tab index

            // txtTax
            this.txtTax.BackColor = System.Drawing.SystemColors.Window; // background
            this.txtTax.Location = new System.Drawing.Point(287, 299); // location
            this.txtTax.Name = "txtTax";                              // name
            this.txtTax.ReadOnly = true;                              // readonly
            this.txtTax.Size = new System.Drawing.Size(100, 22);      // size
            this.txtTax.TabIndex = 6;                                 // tab index

            // lblTotal
            this.lblTotal.AutoSize = true;                            // autosize
            this.lblTotal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold); // font
            this.lblTotal.Location = new System.Drawing.Point(160, 461); // location
            this.lblTotal.Name = "lblTotal";                          // name
            this.lblTotal.Size = new System.Drawing.Size(105, 22);    // size
            this.lblTotal.TabIndex = 4;                               // tab index
            this.lblTotal.Text = "Grand Total:";   // text

            // lblNoTaxTip
            this.lblNoTaxTip.AutoSize = true;                         // autosize
            this.lblNoTaxTip.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold); // font
            this.lblNoTaxTip.Location = new System.Drawing.Point(230, 379); // location
            this.lblNoTaxTip.Name = "lblNoTaxTip";                    // name
            this.lblNoTaxTip.Size = new System.Drawing.Size(161, 18); // size
            this.lblNoTaxTip.TabIndex = 9;                            // tab index
            this.lblNoTaxTip.Text = "(No Tax Applied To Tips)"; // text

            // txtSubtotal
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.Window; // background
            this.txtSubtotal.Location = new System.Drawing.Point(287, 257); // location
            this.txtSubtotal.Name = "txtSubtotal";                    // name
            this.txtSubtotal.ReadOnly = true;                        // readonly
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22); // size
            this.txtSubtotal.TabIndex = 5;                           // tab index

            // txtTip
            this.txtTip.Location = new System.Drawing.Point(287, 345); // location
            this.txtTip.Name = "txtTip";                              // name
            this.txtTip.Size = new System.Drawing.Size(100, 22);      // size
            this.txtTip.TabIndex = 8;                                 // tab index

            // lblTax
            this.lblTax.AutoSize = true;                             // autosize
            this.lblTax.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold); // font
            this.lblTax.Location = new System.Drawing.Point(199, 299); // location
            this.lblTax.Name = "lblTax";                             // name
            this.lblTax.Size = new System.Drawing.Size(66, 18);      // size
            this.lblTax.TabIndex = 3;                                // tab index
            this.lblTax.Text = "Tax 9.5%:"; // text

            // lblTip
            this.lblTip.AutoSize = true;                             // autosize
            this.lblTip.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold); // font
            this.lblTip.Location = new System.Drawing.Point(172, 349); // location
            this.lblTip.Name = "lblTip";                             // name
            this.lblTip.Size = new System.Drawing.Size(96, 18);      // size
            this.lblTip.TabIndex = 3;                                // tab index
            this.lblTip.Text = "Tip Amount $:"; // text

            // lblSubtotal
            this.lblSubtotal.AutoSize = true;                        // autosize
            this.lblSubtotal.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold); // font
            this.lblSubtotal.Location = new System.Drawing.Point(202, 257); // location
            this.lblSubtotal.Name = "lblSubtotal";                   // name
            this.lblSubtotal.Size = new System.Drawing.Size(63, 18); // size
            this.lblSubtotal.TabIndex = 2;                           // tab index
            this.lblSubtotal.Text = "Subtotal:"; // text

            // lstItemizedBill
            this.lstItemizedBill.BorderStyle = System.Windows.Forms.BorderStyle.None; // border
            this.lstItemizedBill.FormattingEnabled = true;             // formatting enabled
            this.lstItemizedBill.ItemHeight = 16;                      // item height
            this.lstItemizedBill.Location = new System.Drawing.Point(49, 30); // location
            this.lstItemizedBill.Name = "lstItemizedBill";             // name
            this.lstItemizedBill.Size = new System.Drawing.Size(338, 208); // size
            this.lstItemizedBill.TabIndex = 1;                         // tab index

            // gbxPayment
            this.gbxPayment.BackColor = System.Drawing.Color.OldLace;  // background
            this.gbxPayment.Controls.Add(this.txtCustName);            // add textbox
            this.gbxPayment.Controls.Add(this.lblCustName);            // add label
            this.gbxPayment.Controls.Add(this.btnPayment);             // add button
            this.gbxPayment.Controls.Add(this.txtPin);                 // add pin textbox
            this.gbxPayment.Controls.Add(this.lblPin);                 // add pin label
            this.gbxPayment.Controls.Add(this.txtExpireDate);          // add expire textbox
            this.gbxPayment.Controls.Add(this.lblExpireDate);          // add expire label
            this.gbxPayment.Controls.Add(this.txtCardNumber);          // add card textbox
            this.gbxPayment.Controls.Add(this.lblCardNumber);          // add card label
            this.gbxPayment.Controls.Add(this.radDebitCard);           // add debit radio
            this.gbxPayment.Controls.Add(this.radCreditCard);          // add credit radio
            this.gbxPayment.Controls.Add(this.label1);                 // add label
            this.gbxPayment.Controls.Add(this.radCash);                // add cash radio
            this.gbxPayment.Location = new System.Drawing.Point(677, 103); // location
            this.gbxPayment.Name = "gbxPayment";                       // name
            this.gbxPayment.Size = new System.Drawing.Size(451, 441);  // size
            this.gbxPayment.TabIndex = 10;                             // tab index
            this.gbxPayment.TabStop = false;                           // tab stop
            this.gbxPayment.Text = "Payment";                         // text

            // txtCustName
            this.txtCustName.BackColor = System.Drawing.SystemColors.Window; // background
            this.txtCustName.Location = new System.Drawing.Point(67, 193); // location
            this.txtCustName.Name = "txtCustName";                   // name
            this.txtCustName.Size = new System.Drawing.Size(298, 22); // size
            this.txtCustName.TabIndex = 21;                          // tab index

            // lblCustName
            this.lblCustName.AutoSize = true;                        // autosize
            this.lblCustName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold); // font
            this.lblCustName.Location = new System.Drawing.Point(63, 168); // location
            this.lblCustName.Name = "lblCustName";                   // name
            this.lblCustName.Size = new System.Drawing.Size(126, 22); // size
            this.lblCustName.TabIndex = 20;                          // tab index
            this.lblCustName.Text = "Name On Card:"; // text

            // btnPayment
            this.btnPayment.BackColor = System.Drawing.Color.Wheat;  // background
            this.btnPayment.Location = new System.Drawing.Point(164, 371); // location
            this.btnPayment.Name = "btnPayment";                     // name
            this.btnPayment.Size = new System.Drawing.Size(128, 36); // size
            this.btnPayment.TabIndex = 19;                           // tab index
            this.btnPayment.Text = "Submit Payment"; // text
            this.btnPayment.UseVisualStyleBackColor = false;         // use style
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click); // FIXED EVENT HOOKUP

            // txtPin
            this.txtPin.Location = new System.Drawing.Point(230, 321); // location
            this.txtPin.Name = "txtPin";                              // name
            this.txtPin.Size = new System.Drawing.Size(91, 22);       // size
            this.txtPin.TabIndex = 18;                                // tab index

            // lblPin
            this.lblPin.AutoSize = true;                              // autosize
            this.lblPin.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold); // font
            this.lblPin.Location = new System.Drawing.Point(226, 295); // location
            this.lblPin.Name = "lblPin";                              // name
            this.lblPin.Size = new System.Drawing.Size(43, 22);       // size
            this.lblPin.TabIndex = 17;                                // tab index
            this.lblPin.Text = "PIN:"; // text

            // txtExpireDate
            this.txtExpireDate.Location = new System.Drawing.Point(67, 321); // location
            this.txtExpireDate.Name = "txtExpireDate";                 // name
            this.txtExpireDate.Size = new System.Drawing.Size(91, 22); // size
            this.txtExpireDate.TabIndex = 16;                          // tab index
            this.txtExpireDate.Text = "MM/YY";                         // default text

            // lblExpireDate
            this.lblExpireDate.AutoSize = true;                        // autosize
            this.lblExpireDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold); // font
            this.lblExpireDate.Location = new System.Drawing.Point(63, 295); // location
            this.lblExpireDate.Name = "lblExpireDate";                // name
            this.lblExpireDate.Size = new System.Drawing.Size(131, 22); // size
            this.lblExpireDate.TabIndex = 15;                         // tab index
            this.lblExpireDate.Text = "Expiration Date:"; // text

            // txtCardNumber
            this.txtCardNumber.Location = new System.Drawing.Point(67, 253); // location
            this.txtCardNumber.Name = "txtCardNumber";                // name
            this.txtCardNumber.Size = new System.Drawing.Size(298, 22); // size
            this.txtCardNumber.TabIndex = 14;                         // tab index

            // lblCardNumber
            this.lblCardNumber.AutoSize = true;                       // autosize
            this.lblCardNumber.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold); // font
            this.lblCardNumber.Location = new System.Drawing.Point(63, 228); // location
            this.lblCardNumber.Name = "lblCardNumber";                // name
            this.lblCardNumber.Size = new System.Drawing.Size(118, 22); // size
            this.lblCardNumber.TabIndex = 13;                         // tab index
            this.lblCardNumber.Text = "Card Number:"; // text

            // radDebitCard
            this.radDebitCard.AutoSize = true;                        // autosize
            this.radDebitCard.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold); // font
            this.radDebitCard.Location = new System.Drawing.Point(135, 127); // location
            this.radDebitCard.Name = "radDebitCard";                  // name
            this.radDebitCard.Size = new System.Drawing.Size(111, 26); // size
            this.radDebitCard.TabIndex = 12;                          // tab index
            this.radDebitCard.TabStop = true;                         // tab stop
            this.radDebitCard.Text = "Debit Card";                   // text
            this.radDebitCard.UseVisualStyleBackColor = true;         // use style

            // radCreditCard
            this.radCreditCard.AutoSize = true;                       // autosize
            this.radCreditCard.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold); // font
            this.radCreditCard.Location = new System.Drawing.Point(135, 95); // location
            this.radCreditCard.Name = "radCreditCard";                // name
            this.radCreditCard.Size = new System.Drawing.Size(117, 26); // size
            this.radCreditCard.TabIndex = 11;                         // tab index
            this.radCreditCard.TabStop = true;                        // tab stop
            this.radCreditCard.Text = "Credit Card";                 // text
            this.radCreditCard.UseVisualStyleBackColor = true;        // use style

            // label1
            this.label1.AutoSize = true;                              // autosize
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold); // font
            this.label1.Location = new System.Drawing.Point(83, 30);  // location
            this.label1.Name = "label1";                              // name
            this.label1.Size = new System.Drawing.Size(282, 26);      // size
            this.label1.TabIndex = 10;                                // tab index
            this.label1.Text = "Select your payment method:"; // text

            // radCash
            this.radCash.AutoSize = true;                             // autosize
            this.radCash.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold); // font
            this.radCash.Location = new System.Drawing.Point(135, 63); // location
            this.radCash.Name = "radCash";                            // name
            this.radCash.Size = new System.Drawing.Size(65, 26);      // size
            this.radCash.TabIndex = 5;                                // tab index
            this.radCash.TabStop = true;                              // tab stop
            this.radCash.Text = "Cash";                               // text
            this.radCash.UseVisualStyleBackColor = true;              // use style

            // frmCheckout
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F); // autoscale dimensions
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // autoscale mode
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;   // background color
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage"))); // background image
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch; // stretch background
            this.ClientSize = new System.Drawing.Size(1284, 749);       // form size
            this.Controls.Add(this.gbxPayment);                         // add payment groupbox
            this.Controls.Add(this.gbxItemizedBill);                    // add itemized bill groupbox
            this.Controls.Add(this.lblYourBill);                        // add label
            this.DoubleBuffered = true;                                 // enable double buffering
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold); // font
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // borderless form
            this.Margin = new System.Windows.Forms.Padding(4);          // margin
            this.Name = "frmCheckout";                                  // name
            this.Text = "Checkout";                                     // text

            this.gbxItemizedBill.ResumeLayout(false);                   // resume itemized bill layout
            this.gbxItemizedBill.PerformLayout();                       // perform layout
            this.gbxPayment.ResumeLayout(false);                        // resume payment layout
            this.gbxPayment.PerformLayout();                            // perform layout
            this.ResumeLayout(false);                                   // resume form layout
            this.PerformLayout();                                       // perform layout
        }

        #endregion

        private System.Windows.Forms.Label lblYourBill;                // label Your Bill
        private System.Windows.Forms.GroupBox gbxItemizedBill;         // groupbox itemized bill
        private System.Windows.Forms.Label lblTax;                     // label tax
        private System.Windows.Forms.Label lblSubtotal;                // label subtotal
        private System.Windows.Forms.ListBox lstItemizedBill;          // listbox itemized bill
        private System.Windows.Forms.TextBox txtTotal;                 // textbox total
        private System.Windows.Forms.TextBox txtTax;                   // textbox tax
        private System.Windows.Forms.TextBox txtSubtotal;              // textbox subtotal
        private System.Windows.Forms.Label lblTotal;                   // label total
        private System.Windows.Forms.Label lblNoTaxTip;                // label no tax on tip
        private System.Windows.Forms.TextBox txtTip;                   // textbox tip
        private System.Windows.Forms.Label lblTip;                     // label tip
        private System.Windows.Forms.GroupBox gbxPayment;              // groupbox payment
        private System.Windows.Forms.RadioButton radDebitCard;         // radio debit card
        private System.Windows.Forms.RadioButton radCreditCard;        // radio credit card
        private System.Windows.Forms.Label label1;                     // label payment method
        private System.Windows.Forms.RadioButton radCash;              // radio cash
        private System.Windows.Forms.Button btnPayment;                // button submit payment
        private System.Windows.Forms.TextBox txtPin;                   // textbox pin
        private System.Windows.Forms.Label lblPin;                     // label pin
        private System.Windows.Forms.TextBox txtExpireDate;            // textbox expiration date
        private System.Windows.Forms.Label lblExpireDate;              // label expiration date
        private System.Windows.Forms.TextBox txtCardNumber;            // textbox card number
        private System.Windows.Forms.Label lblCardNumber;              // label card number
        private System.Windows.Forms.TextBox txtCustName;              // textbox customer name
        private System.Windows.Forms.Label lblCustName;                // label customer name
        private System.Windows.Forms.Button btnCalcTotal;              // button calculate total
    }
}
