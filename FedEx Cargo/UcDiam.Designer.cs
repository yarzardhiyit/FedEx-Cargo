namespace FedEx_Cargo
{
    partial class UcDiam
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
            this.lblDiamension = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDcalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDiamension
            // 
            this.lblDiamension.AutoSize = true;
            this.lblDiamension.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiamension.Location = new System.Drawing.Point(3, 0);
            this.lblDiamension.Name = "lblDiamension";
            this.lblDiamension.Size = new System.Drawing.Size(307, 28);
            this.lblDiamension.TabIndex = 0;
            this.lblDiamension.Text = "Diamensional Weight Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "ရည်ရွယ်ချက်ကတော့ Actual weight နဲ့ Diamensional weight ကို နှိုင်းယှဥ်ရာတွင် Rate" +
    "d weight ကို \r\nအလွယ်တကူ သိရှိနိုင်ရန် ဖြစ်ပါတယ်။";
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(206, 149);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(100, 22);
            this.txtL.TabIndex = 2;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(337, 149);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 22);
            this.txtR.TabIndex = 3;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(468, 149);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 22);
            this.txtH.TabIndex = 4;
            this.txtH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtH_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "x";
            // 
            // txtDW
            // 
            this.txtDW.Enabled = false;
            this.txtDW.Location = new System.Drawing.Point(206, 205);
            this.txtDW.Name = "txtDW";
            this.txtDW.Size = new System.Drawing.Size(362, 22);
            this.txtDW.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "အလျား";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "အနံ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(526, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "အမြင့်";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Diamensional weight";
            // 
            // btnDcalc
            // 
            this.btnDcalc.Location = new System.Drawing.Point(206, 247);
            this.btnDcalc.Name = "btnDcalc";
            this.btnDcalc.Size = new System.Drawing.Size(362, 38);
            this.btnDcalc.TabIndex = 14;
            this.btnDcalc.Text = "Do Job";
            this.btnDcalc.UseVisualStyleBackColor = true;
            this.btnDcalc.Click += new System.EventHandler(this.btnDcalc_Click);
            // 
            // UcDiam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btnDcalc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDiamension);
            this.Name = "UcDiam";
            this.Size = new System.Drawing.Size(774, 405);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiamension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDcalc;
    }
}
