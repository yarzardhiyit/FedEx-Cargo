using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FedEx_Cargo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Load += FrmMain_Load;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetActivePanel(ucIntro1);
        }

        public void SetActivePanel(UserControl control)
        {
            ucIntro1.Visible = false;
            ucDiam1.Visible = false;
            ucSpotRate1.Visible = false;
            FdxGround1.Visible = false;

            control.Visible = true;
        }

        private void aboutUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App: Ceazar Cargo \nVersion: 1.0.0.20 \nDeveloped By: yarzardhiyit");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucIntro1);
        }

        private void diamensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucDiam1);
        }

        private void spotRatePricingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucSpotRate1);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void disputeInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(FdxGround1);
        }
    }
}
