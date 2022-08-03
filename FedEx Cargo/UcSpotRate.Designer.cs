namespace FedEx_Cargo
{
    partial class UcSpotRate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSpotRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblIPRating = new System.Windows.Forms.Label();
            this.cbLane = new System.Windows.Forms.ComboBox();
            this.txtWeightBreak = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblPS = new System.Windows.Forms.Label();
            this.txtPS = new System.Windows.Forms.TextBox();
            this.txtFSI = new System.Windows.Forms.TextBox();
            this.lblFSI = new System.Windows.Forms.Label();
            this.btnDoJob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSpotRate
            // 
            this.lblSpotRate.AutoSize = true;
            this.lblSpotRate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpotRate.Location = new System.Drawing.Point(3, 0);
            this.lblSpotRate.Name = "lblSpotRate";
            this.lblSpotRate.Size = new System.Drawing.Size(301, 28);
            this.lblSpotRate.TabIndex = 0;
            this.lblSpotRate.Text = "FedEx Cargo - Spot Rate Pricing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spot Rate Pricing ကို လွယ်ကူစွာ တွက်ချက် သိရှိနိုင်စေရန် ဖြစ်ပါတယ်။ Additional ha" +
    "ndling surcharge\r\n - dimension ကို standard size မဟုတ်သော ပုံးများတွင်ကောက်ယူပါသ" +
    "ည်။ ပုံမှန် အားဖြင့် ฿252 ဖြစ်ပါတယ်။";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(127, 214);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(117, 16);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight Break (KG)";
            // 
            // lblIPRating
            // 
            this.lblIPRating.AutoSize = true;
            this.lblIPRating.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPRating.Location = new System.Drawing.Point(4, 121);
            this.lblIPRating.Name = "lblIPRating";
            this.lblIPRating.Size = new System.Drawing.Size(593, 23);
            this.lblIPRating.TabIndex = 4;
            this.lblIPRating.Text = "* Special Spot Rate, Peak Surcharge, Fuel Surcharge တို့သည် အလိုအလျှောက် တွက်ချက်" +
    "မှုသာ ဖြစ်ပါတယ်။";
            // 
            // cbLane
            // 
            this.cbLane.FormattingEnabled = true;
            this.cbLane.Items.AddRange(new object[] {
            "USA",
            "Hong Kong",
            "Japan",
            "Malaysia",
            "Singapore",
            "Taiwan",
            "China",
            "Europe 1",
            "Europe 2",
            "Canada"});
            this.cbLane.Location = new System.Drawing.Point(537, 172);
            this.cbLane.Name = "cbLane";
            this.cbLane.Size = new System.Drawing.Size(121, 24);
            this.cbLane.TabIndex = 5;
            this.cbLane.Text = "USA";
            // 
            // txtWeightBreak
            // 
            this.txtWeightBreak.Location = new System.Drawing.Point(259, 211);
            this.txtWeightBreak.Name = "txtWeightBreak";
            this.txtWeightBreak.Size = new System.Drawing.Size(399, 22);
            this.txtWeightBreak.TabIndex = 6;
            this.txtWeightBreak.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWeightBreak_KeyDown);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(127, 175);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(229, 16);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total Estimated Freight Charge | THB";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(374, 172);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(157, 22);
            this.txtTotal.TabIndex = 8;
            // 
            // lblPS
            // 
            this.lblPS.AutoSize = true;
            this.lblPS.Location = new System.Drawing.Point(127, 251);
            this.lblPS.Name = "lblPS";
            this.lblPS.Size = new System.Drawing.Size(104, 16);
            this.lblPS.TabIndex = 9;
            this.lblPS.Text = "Peak Surcharge";
            // 
            // txtPS
            // 
            this.txtPS.Location = new System.Drawing.Point(259, 248);
            this.txtPS.Name = "txtPS";
            this.txtPS.Size = new System.Drawing.Size(135, 22);
            this.txtPS.TabIndex = 10;
            this.txtPS.Text = "16";
            // 
            // txtFSI
            // 
            this.txtFSI.Location = new System.Drawing.Point(523, 248);
            this.txtFSI.Name = "txtFSI";
            this.txtFSI.Size = new System.Drawing.Size(135, 22);
            this.txtFSI.TabIndex = 11;
            this.txtFSI.Text = "32.5";
            // 
            // lblFSI
            // 
            this.lblFSI.AutoSize = true;
            this.lblFSI.Location = new System.Drawing.Point(413, 251);
            this.lblFSI.Name = "lblFSI";
            this.lblFSI.Size = new System.Drawing.Size(98, 16);
            this.lblFSI.TabIndex = 12;
            this.lblFSI.Text = "Fuel Surcharge";
            // 
            // btnDoJob
            // 
            this.btnDoJob.Location = new System.Drawing.Point(417, 297);
            this.btnDoJob.Name = "btnDoJob";
            this.btnDoJob.Size = new System.Drawing.Size(241, 41);
            this.btnDoJob.TabIndex = 13;
            this.btnDoJob.Text = "Calculate";
            this.btnDoJob.UseVisualStyleBackColor = true;
            this.btnDoJob.Click += new System.EventHandler(this.btnDoJob_Click);
            // 
            // UcSpotRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btnDoJob);
            this.Controls.Add(this.lblFSI);
            this.Controls.Add(this.txtFSI);
            this.Controls.Add(this.txtPS);
            this.Controls.Add(this.lblPS);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtWeightBreak);
            this.Controls.Add(this.cbLane);
            this.Controls.Add(this.lblIPRating);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSpotRate);
            this.Name = "UcSpotRate";
            this.Size = new System.Drawing.Size(774, 405);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpotRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblIPRating;
        private System.Windows.Forms.ComboBox cbLane;
        private System.Windows.Forms.TextBox txtWeightBreak;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblPS;
        private System.Windows.Forms.TextBox txtPS;
        private System.Windows.Forms.TextBox txtFSI;
        private System.Windows.Forms.Label lblFSI;
        private System.Windows.Forms.Button btnDoJob;
    }
}
