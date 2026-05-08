namespace DeliciosoERistorante
{
    partial class frmReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.lblReceipt = new System.Windows.Forms.Label();
            this.gbxReceipt = new System.Windows.Forms.GroupBox();
            this.lblThankYou = new System.Windows.Forms.Label();
            this.btnSaveReceipt = new System.Windows.Forms.Button();
            this.txtTotalReceipt = new System.Windows.Forms.TextBox();
            this.txtTaxReceipt = new System.Windows.Forms.TextBox();
            this.lblTotalReceipt = new System.Windows.Forms.Label();
            this.txtSubtotalReceipt = new System.Windows.Forms.TextBox();
            this.txtTipReceipt = new System.Windows.Forms.TextBox();
            this.lblTaxReceipt = new System.Windows.Forms.Label();
            this.lblTipReceipt = new System.Windows.Forms.Label();
            this.lblSubtotalReceipt = new System.Windows.Forms.Label();
            this.lstOrderSummary = new System.Windows.Forms.ListBox();
            this.lblOrderSum = new System.Windows.Forms.Label();
            this.lblCust = new System.Windows.Forms.Label();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.txtReceiptNum = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblReceiptName = new System.Windows.Forms.Label();
            this.lblReceiptNum = new System.Windows.Forms.Label();
            this.saveReceiptFile = new System.Windows.Forms.SaveFileDialog();
            this.gbxReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.BackColor = System.Drawing.Color.OldLace;
            this.lblReceipt.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceipt.Location = new System.Drawing.Point(558, 21);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(129, 44);
            this.lblReceipt.TabIndex = 5;
            this.lblReceipt.Text = "Receipt";
            // 
            // gbxReceipt
            // 
            this.gbxReceipt.BackColor = System.Drawing.Color.OldLace;
            this.gbxReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxReceipt.Controls.Add(this.lblThankYou);
            this.gbxReceipt.Controls.Add(this.btnSaveReceipt);
            this.gbxReceipt.Controls.Add(this.txtTotalReceipt);
            this.gbxReceipt.Controls.Add(this.txtTaxReceipt);
            this.gbxReceipt.Controls.Add(this.lblTotalReceipt);
            this.gbxReceipt.Controls.Add(this.txtSubtotalReceipt);
            this.gbxReceipt.Controls.Add(this.txtTipReceipt);
            this.gbxReceipt.Controls.Add(this.lblTaxReceipt);
            this.gbxReceipt.Controls.Add(this.lblTipReceipt);
            this.gbxReceipt.Controls.Add(this.lblSubtotalReceipt);
            this.gbxReceipt.Controls.Add(this.lstOrderSummary);
            this.gbxReceipt.Controls.Add(this.lblOrderSum);
            this.gbxReceipt.Controls.Add(this.lblCust);
            this.gbxReceipt.Controls.Add(this.txtPaymentMethod);
            this.gbxReceipt.Controls.Add(this.lblPaymentMethod);
            this.gbxReceipt.Controls.Add(this.txtDateTime);
            this.gbxReceipt.Controls.Add(this.txtReceiptNum);
            this.gbxReceipt.Controls.Add(this.txtCustName);
            this.gbxReceipt.Controls.Add(this.lblDateTime);
            this.gbxReceipt.Controls.Add(this.lblReceiptName);
            this.gbxReceipt.Controls.Add(this.lblReceiptNum);
            this.gbxReceipt.Location = new System.Drawing.Point(117, 102);
            this.gbxReceipt.Name = "gbxReceipt";
            this.gbxReceipt.Size = new System.Drawing.Size(1005, 595);
            this.gbxReceipt.TabIndex = 6;
            this.gbxReceipt.TabStop = false;
            this.gbxReceipt.Text = "Order Summary";
            // 
            // lblThankYou
            // 
            this.lblThankYou.AutoSize = true;
            this.lblThankYou.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThankYou.Location = new System.Drawing.Point(355, 534);
            this.lblThankYou.Name = "lblThankYou";
            this.lblThankYou.Size = new System.Drawing.Size(311, 28);
            this.lblThankYou.TabIndex = 27;
            this.lblThankYou.Text = "Thank you for dining with us!";
            // 
            // btnSaveReceipt
            // 
            this.btnSaveReceipt.BackColor = System.Drawing.Color.Wheat;
            this.btnSaveReceipt.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReceipt.Location = new System.Drawing.Point(449, 477);
            this.btnSaveReceipt.Name = "btnSaveReceipt";
            this.btnSaveReceipt.Size = new System.Drawing.Size(136, 41);
            this.btnSaveReceipt.TabIndex = 26;
            this.btnSaveReceipt.Text = "Save Receipt";
            this.btnSaveReceipt.UseVisualStyleBackColor = false;
            // 
            // txtTotalReceipt
            // 
            this.txtTotalReceipt.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalReceipt.Location = new System.Drawing.Point(838, 413);
            this.txtTotalReceipt.Name = "txtTotalReceipt";
            this.txtTotalReceipt.ReadOnly = true;
            this.txtTotalReceipt.Size = new System.Drawing.Size(100, 22);
            this.txtTotalReceipt.TabIndex = 24;
            // 
            // txtTaxReceipt
            // 
            this.txtTaxReceipt.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaxReceipt.Location = new System.Drawing.Point(838, 332);
            this.txtTaxReceipt.Name = "txtTaxReceipt";
            this.txtTaxReceipt.ReadOnly = true;
            this.txtTaxReceipt.Size = new System.Drawing.Size(100, 22);
            this.txtTaxReceipt.TabIndex = 23;
            // 
            // lblTotalReceipt
            // 
            this.lblTotalReceipt.AutoSize = true;
            this.lblTotalReceipt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReceipt.Location = new System.Drawing.Point(716, 413);
            this.lblTotalReceipt.Name = "lblTotalReceipt";
            this.lblTotalReceipt.Size = new System.Drawing.Size(105, 22);
            this.lblTotalReceipt.TabIndex = 21;
            this.lblTotalReceipt.Text = "Grand Total:";
            // 
            // txtSubtotalReceipt
            // 
            this.txtSubtotalReceipt.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubtotalReceipt.Location = new System.Drawing.Point(838, 294);
            this.txtSubtotalReceipt.Name = "txtSubtotalReceipt";
            this.txtSubtotalReceipt.ReadOnly = true;
            this.txtSubtotalReceipt.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotalReceipt.TabIndex = 22;
            // 
            // txtTipReceipt
            // 
            this.txtTipReceipt.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipReceipt.Location = new System.Drawing.Point(838, 368);
            this.txtTipReceipt.Name = "txtTipReceipt";
            this.txtTipReceipt.ReadOnly = true;
            this.txtTipReceipt.Size = new System.Drawing.Size(100, 22);
            this.txtTipReceipt.TabIndex = 25;
            // 
            // lblTaxReceipt
            // 
            this.lblTaxReceipt.AutoSize = true;
            this.lblTaxReceipt.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxReceipt.Location = new System.Drawing.Point(755, 333);
            this.lblTaxReceipt.Name = "lblTaxReceipt";
            this.lblTaxReceipt.Size = new System.Drawing.Size(66, 18);
            this.lblTaxReceipt.TabIndex = 19;
            this.lblTaxReceipt.Text = "Tax 9.5%:";
            // 
            // lblTipReceipt
            // 
            this.lblTipReceipt.AutoSize = true;
            this.lblTipReceipt.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipReceipt.Location = new System.Drawing.Point(725, 369);
            this.lblTipReceipt.Name = "lblTipReceipt";
            this.lblTipReceipt.Size = new System.Drawing.Size(96, 18);
            this.lblTipReceipt.TabIndex = 20;
            this.lblTipReceipt.Text = "Tip Amount $:";
            // 
            // lblSubtotalReceipt
            // 
            this.lblSubtotalReceipt.AutoSize = true;
            this.lblSubtotalReceipt.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalReceipt.Location = new System.Drawing.Point(755, 295);
            this.lblSubtotalReceipt.Name = "lblSubtotalReceipt";
            this.lblSubtotalReceipt.Size = new System.Drawing.Size(63, 18);
            this.lblSubtotalReceipt.TabIndex = 18;
            this.lblSubtotalReceipt.Text = "Subtotal:";
            // 
            // lstOrderSummary
            // 
            this.lstOrderSummary.BackColor = System.Drawing.SystemColors.Window;
            this.lstOrderSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstOrderSummary.FormattingEnabled = true;
            this.lstOrderSummary.ItemHeight = 16;
            this.lstOrderSummary.Location = new System.Drawing.Point(600, 69);
            this.lstOrderSummary.Name = "lstOrderSummary";
            this.lstOrderSummary.Size = new System.Drawing.Size(338, 208);
            this.lstOrderSummary.TabIndex = 17;
            // 
            // lblOrderSum
            // 
            this.lblOrderSum.AutoSize = true;
            this.lblOrderSum.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSum.Location = new System.Drawing.Point(684, 34);
            this.lblOrderSum.Name = "lblOrderSum";
            this.lblOrderSum.Size = new System.Drawing.Size(171, 28);
            this.lblOrderSum.TabIndex = 16;
            this.lblOrderSum.Text = "Order Summary";
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust.Location = new System.Drawing.Point(134, 34);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(154, 28);
            this.lblCust.TabIndex = 15;
            this.lblCust.Text = "Customer Info";
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.BackColor = System.Drawing.SystemColors.Window;
            this.txtPaymentMethod.Location = new System.Drawing.Point(225, 251);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.ReadOnly = true;
            this.txtPaymentMethod.Size = new System.Drawing.Size(148, 22);
            this.txtPaymentMethod.TabIndex = 14;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(29, 251);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(172, 26);
            this.lblPaymentMethod.TabIndex = 13;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // txtDateTime
            // 
            this.txtDateTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtDateTime.Location = new System.Drawing.Point(225, 198);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.ReadOnly = true;
            this.txtDateTime.Size = new System.Drawing.Size(148, 22);
            this.txtDateTime.TabIndex = 12;
            // 
            // txtReceiptNum
            // 
            this.txtReceiptNum.BackColor = System.Drawing.SystemColors.Window;
            this.txtReceiptNum.Location = new System.Drawing.Point(225, 150);
            this.txtReceiptNum.Name = "txtReceiptNum";
            this.txtReceiptNum.ReadOnly = true;
            this.txtReceiptNum.Size = new System.Drawing.Size(148, 22);
            this.txtReceiptNum.TabIndex = 11;
            // 
            // txtCustName
            // 
            this.txtCustName.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustName.Location = new System.Drawing.Point(225, 101);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(243, 22);
            this.txtCustName.TabIndex = 10;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(50, 198);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(151, 26);
            this.lblDateTime.TabIndex = 9;
            this.lblDateTime.Text = "Date and Time:";
            // 
            // lblReceiptName
            // 
            this.lblReceiptName.AutoSize = true;
            this.lblReceiptName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptName.Location = new System.Drawing.Point(36, 96);
            this.lblReceiptName.Name = "lblReceiptName";
            this.lblReceiptName.Size = new System.Drawing.Size(164, 26);
            this.lblReceiptName.TabIndex = 8;
            this.lblReceiptName.Text = "Customer Name:";
            // 
            // lblReceiptNum
            // 
            this.lblReceiptNum.AutoSize = true;
            this.lblReceiptNum.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptNum.Location = new System.Drawing.Point(36, 146);
            this.lblReceiptNum.Name = "lblReceiptNum";
            this.lblReceiptNum.Size = new System.Drawing.Size(165, 26);
            this.lblReceiptNum.TabIndex = 7;
            this.lblReceiptNum.Text = "Receipt Number:";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1268, 749);
            this.Controls.Add(this.gbxReceipt);
            this.Controls.Add(this.lblReceipt);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Receipt";
            this.Text = "Form1";
            this.gbxReceipt.ResumeLayout(false);
            this.gbxReceipt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.GroupBox gbxReceipt;
        private System.Windows.Forms.Label lblReceiptNum;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblReceiptName;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtReceiptNum;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblOrderSum;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.ListBox lstOrderSummary;
        private System.Windows.Forms.TextBox txtTotalReceipt;
        private System.Windows.Forms.TextBox txtTaxReceipt;
        private System.Windows.Forms.Label lblTotalReceipt;
        private System.Windows.Forms.TextBox txtSubtotalReceipt;
        private System.Windows.Forms.TextBox txtTipReceipt;
        private System.Windows.Forms.Label lblTaxReceipt;
        private System.Windows.Forms.Label lblTipReceipt;
        private System.Windows.Forms.Label lblSubtotalReceipt;
        private System.Windows.Forms.Label lblThankYou;
        private System.Windows.Forms.Button btnSaveReceipt;
        private System.Windows.Forms.SaveFileDialog saveReceiptFile;
    }
}
