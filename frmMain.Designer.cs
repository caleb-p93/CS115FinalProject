namespace DeliciosoERistorante
{
    partial class SplashForm
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
                new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));   // FIXED resource manager

            this.btnMenu = new System.Windows.Forms.Button();          // menu button
            this.lblSplashTitle = new System.Windows.Forms.Label();    // splash title label
            this.lblSplashWelcome = new System.Windows.Forms.Label();  // welcome label

            this.SuspendLayout();                                      // suspend layout

            // btnMenu
            this.btnMenu.BackColor = System.Drawing.Color.Wheat;       // background color
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));   // font
            this.btnMenu.Location = new System.Drawing.Point(700, 153); // location
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4); // margin
            this.btnMenu.Name = "btnMenu";                             // name
            this.btnMenu.Size = new System.Drawing.Size(181, 69);      // size
            this.btnMenu.TabIndex = 0;                                 // tab index
            this.btnMenu.Text = "MENU";                               // text
            this.btnMenu.UseVisualStyleBackColor = false;              // use style
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);   // event hookup

            // lblSplashTitle
            this.lblSplashTitle.AutoSize = true;                       // autosize
            this.lblSplashTitle.BackColor = System.Drawing.Color.OldLace; // background
            this.lblSplashTitle.Font = new System.Drawing.Font("Palatino Linotype", 24F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));   // font
            this.lblSplashTitle.Location = new System.Drawing.Point(617, 30); // location
            this.lblSplashTitle.Name = "lblSplashTitle";               // name
            this.lblSplashTitle.Size = new System.Drawing.Size(345, 44); // size
            this.lblSplashTitle.TabIndex = 4;                          // tab index
            this.lblSplashTitle.Text = "Delicioso E-Ristorante";      // text

            // lblSplashWelcome
            this.lblSplashWelcome.AutoSize = true;                     // autosize
            this.lblSplashWelcome.BackColor = System.Drawing.SystemColors.ControlLightLight; // background
            this.lblSplashWelcome.Font = new System.Drawing.Font("Palatino Linotype", 18F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));   // font
            this.lblSplashWelcome.Location = new System.Drawing.Point(573, 317); // location
            this.lblSplashWelcome.Name = "lblSplashWelcome";           // name
            this.lblSplashWelcome.Size = new System.Drawing.Size(418, 32); // size
            this.lblSplashWelcome.TabIndex = 5;                        // tab index
            this.lblSplashWelcome.Text = "Welcome - Please tap MENU to begin"; // text

            // SplashForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F); // autoscale dimensions
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // autoscale mode
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;   // background color
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage"))); // background image
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch; // stretch background
            this.ClientSize = new System.Drawing.Size(1284, 749);       // form size
            this.Controls.Add(this.lblSplashWelcome);                   // add welcome label
            this.Controls.Add(this.lblSplashTitle);                     // add title label
            this.Controls.Add(this.btnMenu);                            // add menu button
            this.DoubleBuffered = true;                                 // enable double buffering
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));   // font
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // borderless form
            this.Margin = new System.Windows.Forms.Padding(4);          // margin
            this.Name = "SplashForm";                                   // form name
            this.Text = "Splash Page";                                  // form text

            this.ResumeLayout(false);                                   // resume layout
            this.PerformLayout();                                       // perform layout
        }

        #endregion

        private System.Windows.Forms.Button btnMenu;                    // menu button
        private System.Windows.Forms.Label lblSplashTitle;              // splash title label
        private System.Windows.Forms.Label lblSplashWelcome;            // welcome label
    }
}
