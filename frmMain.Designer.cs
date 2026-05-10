namespace DeliciosoERistorante
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;    // component container

        protected override void Dispose(bool disposing)               // dispose method
        {
            if (disposing && (components != null))                    // check components
            {
                components.Dispose();                                 // dispose components
            }

            base.Dispose(disposing);                                  // call base dispose
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()                             // initialize components
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblSplashTitle = new System.Windows.Forms.Label();
            this.lblSplashWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Wheat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(1151, 255);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(181, 69);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblSplashTitle
            // 
            this.lblSplashTitle.AutoSize = true;
            this.lblSplashTitle.BackColor = System.Drawing.Color.OldLace;
            this.lblSplashTitle.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplashTitle.Location = new System.Drawing.Point(1063, 143);
            this.lblSplashTitle.Name = "lblSplashTitle";
            this.lblSplashTitle.Size = new System.Drawing.Size(345, 44);
            this.lblSplashTitle.TabIndex = 4;
            this.lblSplashTitle.Text = "Delicioso E-Ristorante";
            // 
            // lblSplashWelcome
            // 
            this.lblSplashWelcome.AutoSize = true;
            this.lblSplashWelcome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSplashWelcome.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplashWelcome.Location = new System.Drawing.Point(1042, 402);
            this.lblSplashWelcome.Name = "lblSplashWelcome";
            this.lblSplashWelcome.Size = new System.Drawing.Size(418, 32);
            this.lblSplashWelcome.TabIndex = 5;
            this.lblSplashWelcome.Text = "Welcome - Please tap MENU to begin";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lblSplashWelcome);
            this.Controls.Add(this.lblSplashTitle);
            this.Controls.Add(this.btnMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Splash Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;                    // menu button
        private System.Windows.Forms.Label lblSplashTitle;              // splash title label
        private System.Windows.Forms.Label lblSplashWelcome;            // welcome label
    }
}
