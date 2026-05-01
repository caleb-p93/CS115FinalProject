namespace FinalProject
{
    partial class frmCheckout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckout));
            this.lblYourBill = new System.Windows.Forms.Label();
            this.gbxItemizedBill = new System.Windows.Forms.GroupBox();
            this.btnCalcTotal = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNoTaxTip = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lstItemizedBill = new System.Windows.Forms.ListBox();
            this.gbxPayment = new System.Windows.Forms.GroupBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtExpireDate = new System.Windows.Forms.TextBox();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.radDebitCard = new System.Windows.Forms.RadioButton();
            this.radCreditCard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.gbxItemizedBill.SuspendLayout();
            this.gbxPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYourBill
            // 
            this.lblYourBill.AutoSize = true;
            this.lblYourBill.BackColor = System.Drawing.Color.OldLace;
            this.lblYourBill.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourBill.Location = new System.Drawing.Point(550, 24);
            this.lblYourBill.Name = "lblYourBill";
            this.lblYourBill.Size = new System.Drawing.Size(146, 44);
            this.lblYourBill.TabIndex = 4;
            this.lblYourBill.Text = "Your Bill";
            // 
            // gbxItemizedBill
            // 
            this.gbxItemizedBill.BackColor = System.Drawing.Color.OldLace;
            this.gbxItemizedBill.Controls.Add(this.btnCalcTotal);
            this.gbxItemizedBill.Controls.Add(this.txtTotal);
            this.gbxItemizedBill.Controls.Add(this.txtTax);
            this.gbxItemizedBill.Controls.Add(this.lblTotal);
            this.gbxItemizedBill.Controls.Add(this.lblNoTaxTip);
            this.gbxItemizedBill.Controls.Add(this.txtSubtotal);
            this.gbxItemizedBill.Controls.Add(this.txtTip);
            this.gbxItemizedBill.Controls.Add(this.lblTax);
            this.gbxItemizedBill.Controls.Add(this.lblTip);
            this.gbxItemizedBill.Controls.Add(this.lblSubtotal);
            this.gbxItemizedBill.Controls.Add(this.lstItemizedBill);
            this.gbxItemizedBill.Location = new System.Drawing.Point(166, 103);
            this.gbxItemizedBill.Name = "gbxItemizedBill";
            this.gbxItemizedBill.Size = new System.Drawing.Size(451, 510);
            this.gbxItemizedBill.TabIndex = 6;
            this.gbxItemizedBill.TabStop = false;
            this.gbxItemizedBill.Text = "Itemized Bill";
            // 
            // btnCalcTotal
            // 
            this.btnCalcTotal.BackColor = System.Drawing.Color.Wheat;
            this.btnCalcTotal.Location = new System.Drawing.Point(242, 411);
            this.btnCalcTotal.Name = "btnCalcTotal";
            this.btnCalcTotal.Size = new System.Drawing.Size(112, 30);
            this.btnCalcTotal.TabIndex = 22;
            this.btnCalcTotal.Text = "Calculate Total";
            this.btnCalcTotal.UseVisualStyleBackColor = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.Location = new System.Drawing.Point(287, 463);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 7;
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.Window;
            this.txtTax.Location = new System.Drawing.Point(287, 299);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 22);
            this.txtTax.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(160, 461);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(105, 22);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Grand Total:";
            // 
            // lblNoTaxTip
            // 
            this.lblNoTaxTip.AutoSize = true;
            this.lblNoTaxTip.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTaxTip.Location = new System.Drawing.Point(230, 379);
            this.lblNoTaxTip.Name = "lblNoTaxTip";
            this.lblNoTaxTip.Size = new System.Drawing.Size(161, 18);
            this.lblNoTaxTip.TabIndex = 9;
            this.lblNoTaxTip.Text = "(No Tax Applied To Tips)";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubtotal.Location = new System.Drawing.Point(287, 257);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 5;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(287, 345);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(100, 22);
            this.txtTip.TabIndex = 8;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(199, 299);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(66, 18);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "Tax 9.5%:";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(172, 349);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(96, 18);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "Tip Amount $:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(202, 257);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(63, 18);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lstItemizedBill
            // 
            this.lstItemizedBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstItemizedBill.FormattingEnabled = true;
            this.lstItemizedBill.ItemHeight = 16;
            this.lstItemizedBill.Location = new System.Drawing.Point(49, 30);
            this.lstItemizedBill.Name = "lstItemizedBill";
            this.lstItemizedBill.Size = new System.Drawing.Size(338, 208);
            this.lstItemizedBill.TabIndex = 1;
            // 
            // gbxPayment
            // 
            this.gbxPayment.BackColor = System.Drawing.Color.OldLace;
            this.gbxPayment.Controls.Add(this.txtCustName);
            this.gbxPayment.Controls.Add(this.lblCustName);
            this.gbxPayment.Controls.Add(this.btnPayment);
            this.gbxPayment.Controls.Add(this.txtPin);
            this.gbxPayment.Controls.Add(this.lblPin);
            this.gbxPayment.Controls.Add(this.txtExpireDate);
            this.gbxPayment.Controls.Add(this.lblExpireDate);
            this.gbxPayment.Controls.Add(this.txtCardNumber);
            this.gbxPayment.Controls.Add(this.lblCardNumber);
            this.gbxPayment.Controls.Add(this.radDebitCard);
            this.gbxPayment.Controls.Add(this.radCreditCard);
            this.gbxPayment.Controls.Add(this.label1);
            this.gbxPayment.Controls.Add(this.radCash);
            this.gbxPayment.Location = new System.Drawing.Point(677, 103);
            this.gbxPayment.Name = "gbxPayment";
            this.gbxPayment.Size = new System.Drawing.Size(451, 441);
            this.gbxPayment.TabIndex = 10;
            this.gbxPayment.TabStop = false;
            this.gbxPayment.Text = "Payment";
            // 
            // txtCustName
            // 
            this.txtCustName.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustName.Location = new System.Drawing.Point(67, 193);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(298, 22);
            this.txtCustName.TabIndex = 21;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(63, 168);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(126, 22);
            this.lblCustName.TabIndex = 20;
            this.lblCustName.Text = "Name On Card:";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Wheat;
            this.btnPayment.Location = new System.Drawing.Point(164, 371);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(128, 36);
            this.btnPayment.TabIndex = 19;
            this.btnPayment.Text = "Submit Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(230, 321);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(91, 22);
            this.txtPin.TabIndex = 18;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(226, 295);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(43, 22);
            this.lblPin.TabIndex = 17;
            this.lblPin.Text = "PIN:";
            // 
            // txtExpireDate
            // 
            this.txtExpireDate.Location = new System.Drawing.Point(67, 321);
            this.txtExpireDate.Name = "txtExpireDate";
            this.txtExpireDate.Size = new System.Drawing.Size(91, 22);
            this.txtExpireDate.TabIndex = 16;
            this.txtExpireDate.Text = "MM/YY";
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpireDate.Location = new System.Drawing.Point(63, 295);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(131, 22);
            this.lblExpireDate.TabIndex = 15;
            this.lblExpireDate.Text = "Expiration Date:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(67, 253);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(298, 22);
            this.txtCardNumber.TabIndex = 14;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(63, 228);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(118, 22);
            this.lblCardNumber.TabIndex = 13;
            this.lblCardNumber.Text = "Card Number:";
            // 
            // radDebitCard
            // 
            this.radDebitCard.AutoSize = true;
            this.radDebitCard.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDebitCard.Location = new System.Drawing.Point(135, 127);
            this.radDebitCard.Name = "radDebitCard";
            this.radDebitCard.Size = new System.Drawing.Size(111, 26);
            this.radDebitCard.TabIndex = 12;
            this.radDebitCard.TabStop = true;
            this.radDebitCard.Text = "Debit Card";
            this.radDebitCard.UseVisualStyleBackColor = true;
            // 
            // radCreditCard
            // 
            this.radCreditCard.AutoSize = true;
            this.radCreditCard.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCreditCard.Location = new System.Drawing.Point(135, 95);
            this.radCreditCard.Name = "radCreditCard";
            this.radCreditCard.Size = new System.Drawing.Size(117, 26);
            this.radCreditCard.TabIndex = 11;
            this.radCreditCard.TabStop = true;
            this.radCreditCard.Text = "Credit Card";
            this.radCreditCard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select  your payment method:";
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCash.Location = new System.Drawing.Point(135, 63);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(65, 26);
            this.radCash.TabIndex = 5;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.gbxPayment);
            this.Controls.Add(this.gbxItemizedBill);
            this.Controls.Add(this.lblYourBill);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCheckout";
            this.Text = "Checkout";
            this.gbxItemizedBill.ResumeLayout(false);
            this.gbxItemizedBill.PerformLayout();
            this.gbxPayment.ResumeLayout(false);
            this.gbxPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYourBill;
        private System.Windows.Forms.GroupBox gbxItemizedBill;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.ListBox lstItemizedBill;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNoTaxTip;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.GroupBox gbxPayment;
        private System.Windows.Forms.RadioButton radDebitCard;
        private System.Windows.Forms.RadioButton radCreditCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtExpireDate;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Button btnCalcTotal;
    }
}