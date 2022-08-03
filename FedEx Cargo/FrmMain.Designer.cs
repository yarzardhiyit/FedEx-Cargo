namespace FedEx_Cargo
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diamensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spotRatePricingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fedExExpressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dHLExpressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPSExpressSaverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainUI = new System.Windows.Forms.GroupBox();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.ucSpotRate1 = new FedEx_Cargo.UcSpotRate();
            this.ucDiam1 = new FedEx_Cargo.UcDiam();
            this.ucIntro1 = new FedEx_Cargo.UcIntro();
            this.menuStrip1.SuspendLayout();
            this.MainUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.exitToolStripMenuItem.Text = "Home";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diamensionToolStripMenuItem,
            this.spotRatePricingToolStripMenuItem,
            this.fedExExpressToolStripMenuItem,
            this.dHLExpressToolStripMenuItem,
            this.uPSExpressSaverToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 26);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // diamensionToolStripMenuItem
            // 
            this.diamensionToolStripMenuItem.Name = "diamensionToolStripMenuItem";
            this.diamensionToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.diamensionToolStripMenuItem.Text = "Diamension";
            this.diamensionToolStripMenuItem.Click += new System.EventHandler(this.diamensionToolStripMenuItem_Click);
            // 
            // spotRatePricingToolStripMenuItem
            // 
            this.spotRatePricingToolStripMenuItem.Name = "spotRatePricingToolStripMenuItem";
            this.spotRatePricingToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.spotRatePricingToolStripMenuItem.Text = "Spot Rate Pricing";
            this.spotRatePricingToolStripMenuItem.Click += new System.EventHandler(this.spotRatePricingToolStripMenuItem_Click);
            // 
            // fedExExpressToolStripMenuItem
            // 
            this.fedExExpressToolStripMenuItem.Name = "fedExExpressToolStripMenuItem";
            this.fedExExpressToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.fedExExpressToolStripMenuItem.Text = "FedEx Express";
            // 
            // dHLExpressToolStripMenuItem
            // 
            this.dHLExpressToolStripMenuItem.Name = "dHLExpressToolStripMenuItem";
            this.dHLExpressToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.dHLExpressToolStripMenuItem.Text = "DHL Express";
            // 
            // uPSExpressSaverToolStripMenuItem
            // 
            this.uPSExpressSaverToolStripMenuItem.Name = "uPSExpressSaverToolStripMenuItem";
            this.uPSExpressSaverToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.uPSExpressSaverToolStripMenuItem.Text = "UPS Express Saver";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUSToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUSToolStripMenuItem
            // 
            this.aboutUSToolStripMenuItem.Name = "aboutUSToolStripMenuItem";
            this.aboutUSToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.aboutUSToolStripMenuItem.Text = "About us";
            this.aboutUSToolStripMenuItem.Click += new System.EventHandler(this.aboutUSToolStripMenuItem_Click);
            // 
            // MainUI
            // 
            this.MainUI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainUI.Controls.Add(this.lblCopyRight);
            this.MainUI.Controls.Add(this.ucSpotRate1);
            this.MainUI.Controls.Add(this.ucDiam1);
            this.MainUI.Controls.Add(this.ucIntro1);
            this.MainUI.Location = new System.Drawing.Point(12, 31);
            this.MainUI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainUI.Name = "MainUI";
            this.MainUI.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainUI.Size = new System.Drawing.Size(776, 407);
            this.MainUI.TabIndex = 1;
            this.MainUI.TabStop = false;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.Location = new System.Drawing.Point(472, 368);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(264, 30);
            this.lblCopyRight.TabIndex = 2;
            this.lblCopyRight.Text = "Ceazar Calculator\r\n© 2022 Ceazar Millenium | All rights reserved.";
            // 
            // ucSpotRate1
            // 
            this.ucSpotRate1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucSpotRate1.Location = new System.Drawing.Point(0, 15);
            this.ucSpotRate1.Name = "ucSpotRate1";
            this.ucSpotRate1.Size = new System.Drawing.Size(774, 405);
            this.ucSpotRate1.TabIndex = 3;
            // 
            // ucDiam1
            // 
            this.ucDiam1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucDiam1.Location = new System.Drawing.Point(5, 15);
            this.ucDiam1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucDiam1.Name = "ucDiam1";
            this.ucDiam1.Size = new System.Drawing.Size(764, 386);
            this.ucDiam1.TabIndex = 1;
            // 
            // ucIntro1
            // 
            this.ucIntro1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucIntro1.Location = new System.Drawing.Point(5, 15);
            this.ucIntro1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucIntro1.Name = "ucIntro1";
            this.ucIntro1.Size = new System.Drawing.Size(764, 385);
            this.ucIntro1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.MainUI);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 495);
            this.MinimumSize = new System.Drawing.Size(818, 495);
            this.Name = "FrmMain";
            this.Text = "Ceazar Calculator";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainUI.ResumeLayout(false);
            this.MainUI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diamensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spotRatePricingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fedExExpressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dHLExpressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPSExpressSaverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUSToolStripMenuItem;
        private System.Windows.Forms.GroupBox MainUI;
        private UcIntro ucIntro1;
        private UcDiam ucDiam1;
        private System.Windows.Forms.Label lblCopyRight;
        private UcSpotRate ucSpotRate1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

