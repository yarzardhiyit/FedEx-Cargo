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
    public partial class UcSpotRate : UserControl
    {
        public UcSpotRate()
        {
            InitializeComponent();
        }


        private void CargoCalc()
        {
            double WB;
            double HS;
            string sHS = txtHS.Text;
            HS = double.Parse(sHS);
            int PS;
            string sPS = txtPS.Text;
            PS = int.Parse(sPS);
            double FSI;
            string sFSI = txtFSI.Text;
            FSI = double.Parse(sFSI);
            string sWB = txtWeightBreak.Text;
            WB = double.Parse(sWB);

            if(WB < 45)
            {
                WB = WB * 205 + WB * PS + HS;
                FSI = (FSI / 100) * WB;
                WB = WB + FSI;
                txtTotal.Text = WB.ToString();
            }
            else if(WB < 71)
            {
                WB = WB * 193 + WB * PS + HS;
                FSI = (FSI / 100) * WB;
                WB = WB + FSI;
                txtTotal.Text = WB.ToString();
            }
            else if(WB < 100)
            {
                WB = WB * 188 + WB * PS + HS;
                FSI = (FSI / 100) * WB;
                WB = WB + FSI;
                txtTotal.Text = WB.ToString();
            }
            else if(WB < 300)
            {
                WB = WB * 185 + WB * PS + HS;
                FSI = (FSI / 100) * WB;
                WB = WB + FSI;
                txtTotal.Text = WB.ToString();
            }
            else if(WB < 500)
            {
                WB = WB * 182 + WB * PS + HS;
                FSI = (FSI / 100) * WB;
                WB = WB + FSI;
                txtTotal.Text = WB.ToString();
            }
            else if(WB < 1000)
            {
                WB = WB * 167 + WB * PS + HS;
                FSI = (FSI / 100) * WB;
                WB = WB + FSI;
                txtTotal.Text = WB.ToString();
            }
            else if(WB == 1000 || WB > 1000)
            {
                WB = WB * 155 + WB * PS + HS;
                FSI = (FSI / 100) * WB;
                WB = WB + FSI;
                txtTotal.Text = WB.ToString();
            }
        }

        private void txtWeightBreak_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CargoCalc();
            }
        }

        private void btnDoJob_Click(object sender, EventArgs e)
        {
            CargoCalc();
        }

    }
}
