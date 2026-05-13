namespace DeliciosoERistorante
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.gbxMainDishes = new System.Windows.Forms.GroupBox();
            this.numMainDishes = new System.Windows.Forms.NumericUpDown();
            this.lblMainDishesQty = new System.Windows.Forms.Label();
            this.lstMainDishes = new System.Windows.Forms.ListBox();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numSalads = new System.Windows.Forms.NumericUpDown();
            this.lblSaladsQty = new System.Windows.Forms.Label();
            this.lstSalads = new System.Windows.Forms.ListBox();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.bgxBeverages = new System.Windows.Forms.GroupBox();
            this.numBeverages = new System.Windows.Forms.NumericUpDown();
            this.lblBeveragesQty = new System.Windows.Forms.Label();
            this.lstBeverages = new System.Windows.Forms.ListBox();
            this.gbxDesserts = new System.Windows.Forms.GroupBox();
            this.numDesserts = new System.Windows.Forms.NumericUpDown();
            this.lblDessertsQty = new System.Windows.Forms.Label();
            this.lstDesserts = new System.Windows.Forms.ListBox();
            this.gbxCurrentOrder = new System.Windows.Forms.GroupBox();
            this.btnRequestCheck = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnMenuClear = new System.Windows.Forms.Button();
            this.lstCurrentOrder = new System.Windows.Forms.ListBox();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.gbxMainDishes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMainDishes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalads)).BeginInit();
            this.bgxBeverages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBeverages)).BeginInit();
            this.gbxDesserts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDesserts)).BeginInit();
            this.gbxCurrentOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMainDishes
            // 
            this.gbxMainDishes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxMainDishes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbxMainDishes.BackgroundImage")));
            this.gbxMainDishes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxMainDishes.Controls.Add(this.numMainDishes);
            this.gbxMainDishes.Controls.Add(this.lblMainDishesQty);
            this.gbxMainDishes.Controls.Add(this.lstMainDishes);
            this.gbxMainDishes.Location = new System.Drawing.Point(481, 189);
            this.gbxMainDishes.Name = "gbxMainDishes";
            this.gbxMainDishes.Size = new System.Drawing.Size(428, 254);
            this.gbxMainDishes.TabIndex = 0;
            this.gbxMainDishes.TabStop = false;
            this.gbxMainDishes.Text = "Main Dishes";
            // 
            // numMainDishes
            // 
            this.numMainDishes.Location = new System.Drawing.Point(301, 211);
            this.numMainDishes.Name = "numMainDishes";
            this.numMainDishes.Size = new System.Drawing.Size(54, 25);
            this.numMainDishes.TabIndex = 3;
            // 
            // lblMainDishesQty
            // 
            this.lblMainDishesQty.AutoSize = true;
            this.lblMainDishesQty.BackColor = System.Drawing.SystemColors.Window;
            this.lblMainDishesQty.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainDishesQty.Location = new System.Drawing.Point(246, 214);
            this.lblMainDishesQty.Name = "lblMainDishesQty";
            this.lblMainDishesQty.Size = new System.Drawing.Size(49, 22);
            this.lblMainDishesQty.TabIndex = 2;
            this.lblMainDishesQty.Text = "QTY:";
            // 
            // lstMainDishes
            // 
            this.lstMainDishes.BackColor = System.Drawing.SystemColors.Window;
            this.lstMainDishes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMainDishes.FormattingEnabled = true;
            this.lstMainDishes.ItemHeight = 18;
            this.lstMainDishes.Items.AddRange(new object[] {
            "Spaghetti Marinara\t\t\t$11.99",
            "Fettuccine Alfredo\t\t\t$12.99",
            "Lasagna\t\t\t\t$13.99",
            "Cheese Pizza\t\t\t$10.99",
            "Pepperoni Pizza\t\t\t$11.49",
            "Chicken Parmesan\t\t\t$14.99",
            "Pasta Primavera \t\t\t$11.99",
            "Baked Ziti \t\t\t$12.49",
            "Meat Ravioli \t\t\t$13.49",
            "Shrimp Linguine \t\t\t$15.99"});
            this.lstMainDishes.Location = new System.Drawing.Point(50, 24);
            this.lstMainDishes.Name = "lstMainDishes";
            this.lstMainDishes.Size = new System.Drawing.Size(320, 180);
            this.lstMainDishes.TabIndex = 0;
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.Wheat;
            this.btnAddItems.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.Location = new System.Drawing.Point(63, 34);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(145, 34);
            this.btnAddItems.TabIndex = 4;
            this.btnAddItems.Text = "Add Selected Items";
            this.btnAddItems.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.numSalads);
            this.groupBox1.Controls.Add(this.lblSaladsQty);
            this.groupBox1.Controls.Add(this.lstSalads);
            this.groupBox1.Location = new System.Drawing.Point(1005, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 254);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salads";
            // 
            // numSalads
            // 
            this.numSalads.Location = new System.Drawing.Point(307, 146);
            this.numSalads.Name = "numSalads";
            this.numSalads.Size = new System.Drawing.Size(54, 25);
            this.numSalads.TabIndex = 4;
            // 
            // lblSaladsQty
            // 
            this.lblSaladsQty.AutoSize = true;
            this.lblSaladsQty.BackColor = System.Drawing.SystemColors.Window;
            this.lblSaladsQty.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaladsQty.Location = new System.Drawing.Point(252, 146);
            this.lblSaladsQty.Name = "lblSaladsQty";
            this.lblSaladsQty.Size = new System.Drawing.Size(49, 22);
            this.lblSaladsQty.TabIndex = 3;
            this.lblSaladsQty.Text = "QTY:";
            // 
            // lstSalads
            // 
            this.lstSalads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSalads.FormattingEnabled = true;
            this.lstSalads.ItemHeight = 18;
            this.lstSalads.Items.AddRange(new object[] {
            "Caesar Salad \t\t\t$7.99",
            "Caprese Salad\t\t \t$8.49",
            "Garden Salad \t\t\t$6.99",
            "Arugula Salad \t\t\t$7.49",
            "Greek Salad \t\t\t$8.99",
            "Antipasto Salad\t\t\t$6.49"});
            this.lstSalads.Location = new System.Drawing.Point(63, 24);
            this.lstSalads.Name = "lstSalads";
            this.lstSalads.Size = new System.Drawing.Size(298, 108);
            this.lstSalads.TabIndex = 0;
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.BackColor = System.Drawing.Color.OldLace;
            this.lblMenuTitle.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.Location = new System.Drawing.Point(785, 132);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(345, 44);
            this.lblMenuTitle.TabIndex = 3;
            this.lblMenuTitle.Text = "Delicioso E-Ristorante";
            // 
            // bgxBeverages
            // 
            this.bgxBeverages.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bgxBeverages.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bgxBeverages.BackgroundImage")));
            this.bgxBeverages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bgxBeverages.Controls.Add(this.numBeverages);
            this.bgxBeverages.Controls.Add(this.lblBeveragesQty);
            this.bgxBeverages.Controls.Add(this.lstBeverages);
            this.bgxBeverages.Location = new System.Drawing.Point(481, 463);
            this.bgxBeverages.Name = "bgxBeverages";
            this.bgxBeverages.Size = new System.Drawing.Size(428, 193);
            this.bgxBeverages.TabIndex = 2;
            this.bgxBeverages.TabStop = false;
            this.bgxBeverages.Text = "Beverages";
            // 
            // numBeverages
            // 
            this.numBeverages.Location = new System.Drawing.Point(301, 128);
            this.numBeverages.Name = "numBeverages";
            this.numBeverages.Size = new System.Drawing.Size(54, 25);
            this.numBeverages.TabIndex = 5;
            // 
            // lblBeveragesQty
            // 
            this.lblBeveragesQty.AutoSize = true;
            this.lblBeveragesQty.BackColor = System.Drawing.SystemColors.Window;
            this.lblBeveragesQty.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeveragesQty.Location = new System.Drawing.Point(246, 127);
            this.lblBeveragesQty.Name = "lblBeveragesQty";
            this.lblBeveragesQty.Size = new System.Drawing.Size(49, 22);
            this.lblBeveragesQty.TabIndex = 4;
            this.lblBeveragesQty.Text = "QTY:";
            // 
            // lstBeverages
            // 
            this.lstBeverages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBeverages.FormattingEnabled = true;
            this.lstBeverages.ItemHeight = 18;
            this.lstBeverages.Items.AddRange(new object[] {
            "Coffee \t\t\t\t$2.49",
            "Espresso \t\t\t\t$1.99",
            "Lemonade \t\t\t$2.99",
            "Iced Tea \t\t\t\t$2.49",
            "Wine \t\t\t\t$2.99"});
            this.lstBeverages.Location = new System.Drawing.Point(50, 24);
            this.lstBeverages.Name = "lstBeverages";
            this.lstBeverages.Size = new System.Drawing.Size(305, 90);
            this.lstBeverages.TabIndex = 0;
            // 
            // gbxDesserts
            // 
            this.gbxDesserts.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxDesserts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbxDesserts.BackgroundImage")));
            this.gbxDesserts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxDesserts.Controls.Add(this.numDesserts);
            this.gbxDesserts.Controls.Add(this.lblDessertsQty);
            this.gbxDesserts.Controls.Add(this.lstDesserts);
            this.gbxDesserts.Location = new System.Drawing.Point(1005, 463);
            this.gbxDesserts.Name = "gbxDesserts";
            this.gbxDesserts.Size = new System.Drawing.Size(428, 193);
            this.gbxDesserts.TabIndex = 2;
            this.gbxDesserts.TabStop = false;
            this.gbxDesserts.Text = "Desserts";
            // 
            // numDesserts
            // 
            this.numDesserts.Location = new System.Drawing.Point(307, 124);
            this.numDesserts.Name = "numDesserts";
            this.numDesserts.Size = new System.Drawing.Size(54, 25);
            this.numDesserts.TabIndex = 6;
            // 
            // lblDessertsQty
            // 
            this.lblDessertsQty.AutoSize = true;
            this.lblDessertsQty.BackColor = System.Drawing.SystemColors.Window;
            this.lblDessertsQty.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDessertsQty.Location = new System.Drawing.Point(252, 124);
            this.lblDessertsQty.Name = "lblDessertsQty";
            this.lblDessertsQty.Size = new System.Drawing.Size(49, 22);
            this.lblDessertsQty.TabIndex = 5;
            this.lblDessertsQty.Text = "QTY:";
            // 
            // lstDesserts
            // 
            this.lstDesserts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDesserts.FormattingEnabled = true;
            this.lstDesserts.ItemHeight = 18;
            this.lstDesserts.Items.AddRange(new object[] {
            "Tiramisu \t\t\t\t$6.99",
            "Cannoli \t\t\t\t$5.99",
            "Panna Cotta\t\t\t$6.49",
            "Gelato \t\t\t\t$5.49",
            "Cheesecake \t\t\t$7.99"});
            this.lstDesserts.Location = new System.Drawing.Point(63, 24);
            this.lstDesserts.Name = "lstDesserts";
            this.lstDesserts.Size = new System.Drawing.Size(298, 90);
            this.lstDesserts.TabIndex = 0;
            // 
            // gbxCurrentOrder
            // 
            this.gbxCurrentOrder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxCurrentOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbxCurrentOrder.BackgroundImage")));
            this.gbxCurrentOrder.Controls.Add(this.btnAddItems);
            this.gbxCurrentOrder.Controls.Add(this.btnRequestCheck);
            this.gbxCurrentOrder.Controls.Add(this.btnRemoveItem);
            this.gbxCurrentOrder.Controls.Add(this.btnMenuClear);
            this.gbxCurrentOrder.Controls.Add(this.lstCurrentOrder);
            this.gbxCurrentOrder.Controls.Add(this.btnSubmitOrder);
            this.gbxCurrentOrder.Location = new System.Drawing.Point(548, 675);
            this.gbxCurrentOrder.Name = "gbxCurrentOrder";
            this.gbxCurrentOrder.Size = new System.Drawing.Size(833, 160);
            this.gbxCurrentOrder.TabIndex = 3;
            this.gbxCurrentOrder.TabStop = false;
            this.gbxCurrentOrder.Text = "Current Order";
            // 
            // btnRequestCheck
            // 
            this.btnRequestCheck.BackColor = System.Drawing.Color.Wheat;
            this.btnRequestCheck.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestCheck.Location = new System.Drawing.Point(639, 89);
            this.btnRequestCheck.Name = "btnRequestCheck";
            this.btnRequestCheck.Size = new System.Drawing.Size(133, 45);
            this.btnRequestCheck.TabIndex = 4;
            this.btnRequestCheck.Text = "Request Check";
            this.btnRequestCheck.UseVisualStyleBackColor = false;
            // 
            // btnRemoveItem
            // 
                       this.btnRemoveItem.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(583, 34);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(114, 34);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // btnMenuClear
            // 
            this.btnMenuClear.BackColor = System.Drawing.Color.Wheat;
            this.btnMenuClear.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuClear.Location = new System.Drawing.Point(704, 34);
            this.btnMenuClear.Name = "btnMenuClear";
            this.btnMenuClear.Size = new System.Drawing.Size(114, 34);
            this.btnMenuClear.TabIndex = 2;
            this.btnMenuClear.Text = "Clear All";
            this.btnMenuClear.UseVisualStyleBackColor = false;
            // 
            // lstCurrentOrder
            // 
            this.lstCurrentOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCurrentOrder.FormattingEnabled = true;
            this.lstCurrentOrder.ItemHeight = 18;
            this.lstCurrentOrder.Location = new System.Drawing.Point(258, 34);
            this.lstCurrentOrder.Name = "lstCurrentOrder";
            this.lstCurrentOrder.Size = new System.Drawing.Size(305, 108);
            this.lstCurrentOrder.TabIndex = 0;
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.BackColor = System.Drawing.Color.Wheat;
            this.btnSubmitOrder.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrder.Location = new System.Drawing.Point(63, 89);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(145, 43);
            this.btnSubmitOrder.TabIndex = 1;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.gbxCurrentOrder);
            this.Controls.Add(this.gbxDesserts);
            this.Controls.Add(this.bgxBeverages);
            this.Controls.Add(this.lblMenuTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxMainDishes);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.Text = "Menu";

            // ⭐ NEW ADDITIONS FOR PROPORTIONAL RESIZING
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;   // start maximized
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;   // center screen
            this.Load += new System.EventHandler(this.frmMenu_Load);   // load event for proportional resizing
            this.Resize += new System.EventHandler(this.frmMenu_Resize);   // resize event for proportional resizing

            this.gbxMainDishes.ResumeLayout(false);
            this.gbxMainDishes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMainDishes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalads)).EndInit();
            this.bgxBeverages.ResumeLayout(false);
            this.bgxBeverages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBeverages)).EndInit();
            this.gbxDesserts.ResumeLayout(false);
            this.gbxDesserts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDesserts)).EndInit();
            this.gbxCurrentOrder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.GroupBox gbxMainDishes;
        private System.Windows.Forms.ListBox lstMainDishes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstSalads;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.GroupBox bgxBeverages;
        private System.Windows.Forms.ListBox lstBeverages;
        private System.Windows.Forms.GroupBox gbxDesserts;
        private System.Windows.Forms.ListBox lstDesserts;
        private System.Windows.Forms.GroupBox gbxCurrentOrder;
        private System.Windows.Forms.ListBox lstCurrentOrder;
        private System.Windows.Forms.NumericUpDown numMainDishes;
        private System.Windows.Forms.Label lblMainDishesQty;
        private System.Windows.Forms.NumericUpDown numSalads;
        private System.Windows.Forms.Label lblSaladsQty;
        private System.Windows.Forms.NumericUpDown numBeverages;
        private System.Windows.Forms.Label lblBeveragesQty;
        private System.Windows.Forms.NumericUpDown numDesserts;
        private System.Windows.Forms.Label lblDessertsQty;
        private System.Windows.Forms.Button btnMenuClear;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnRequestCheck;
        private System.Windows.Forms.Button btnAddItems;
    }
}
