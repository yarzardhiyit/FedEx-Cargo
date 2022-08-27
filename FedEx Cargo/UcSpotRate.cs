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
            double Red;
            string sRed = txtRd.Text;
            Red = double.Parse(sRed);

            switch (cbLane.SelectedIndex)
            {
                //USA QV: 18 July, 2022
                case 0:
                    if (WB < 45)
                    {
                        WB = WB * 205 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 71)
                    {
                        WB = WB * 193 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 100)
                    {
                        WB = WB * 188 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 300)
                    {
                        WB = WB * 185 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 500)
                    {
                        WB = WB * 182 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 1000)
                    {
                        WB = WB * 167 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB == 1000 || WB > 1000)
                    {
                        WB = WB * 155 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }; break;

                //Hong Kong
                case 1:
                    if (WB < 45)
                    {
                        WB = WB * 77 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 71)
                    {
                        WB = WB * 74 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 100)
                    {
                        WB = WB * 70 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 300)
                    {
                        WB = WB * 63 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 500)
                    {
                        WB = WB * 50 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 1000)
                    {
                        WB = WB * 47 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB == 1000 || WB > 1000)
                    {
                        WB = WB * 46 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }; break;

                //Japan
                case 2:
                    if (WB < 45)
                    {
                        WB = WB * 132 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 71)
                    {
                        WB = WB * 130 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 100)
                    {
                        WB = WB * 128 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 300)
                    {
                        WB = WB * 105 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 500)
                    {
                        WB = WB * 96 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 1000)
                    {
                        WB = WB * 89 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB == 1000 || WB > 1000)
                    {
                        WB = WB * 86 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }; break;

                //Malaysia
                case 3:
                    if (WB < 45)
                    {
                        WB = WB * 96 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 71)
                    {
                        WB = WB * 85 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 100)
                    {
                        WB = WB * 74 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 300)
                    {
                        WB = WB * 63 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 500)
                    {
                        WB = WB * 61 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 1000)
                    {
                        WB = WB * 60 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB == 1000 || WB > 1000)
                    {
                        WB = WB * 59 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }; break;

                //Singapore
                case 4:
                    if (WB < 45)
                    {
                        WB = WB * 110 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 71)
                    {
                        WB = WB * 107 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 100)
                    {
                        WB = WB * 104 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 300)
                    {
                        WB = WB * 93 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 500)
                    {
                        WB = WB * 74 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 1000)
                    {
                        WB = WB * 73 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB == 1000 || WB > 1000)
                    {
                        WB = WB * 72 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }; break;

                //Taiwan
                case 5:
                    if (WB < 45)
                    {
                        WB = WB * 90 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 71)
                    {
                        WB = WB * 86 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 100)
                    {
                        WB = WB * 82 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 300)
                    {
                        WB = WB * 68 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 500)
                    {
                        WB = WB * 54 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 1000)
                    {
                        WB = WB * 49 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB == 1000 || WB > 1000)
                    {
                        WB = WB * 48 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }; break;

                //China
                case 6:
                    if (WB < 45)
                    {
                        WB = WB * 126 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 71)
                    {
                        WB = WB * 123 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 100)
                    {
                        WB = WB * 119 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 300)
                    {
                        WB = WB * 104 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 500)
                    {
                        WB = WB * 96 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 1000)
                    {
                        WB = WB * 89 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB == 1000 || WB > 1000)
                    {
                        WB = WB * 87 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }; break;

                //Europe 1
                case 7:
                    if (WB < 45)
                    {
                        WB = WB * 213 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 71)
                    {
                        WB = WB * 181 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 100)
                    {
                        WB = WB * 176 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 300)
                    {
                        WB = WB * 167 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 500)
                    {
                        WB = WB * 165 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 1000)
                    {
                        WB = WB * 163 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB == 1000 || WB > 1000)
                    {
                        WB = WB * 162 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }; break;

                //Europe 2
                case 8:
                    if (WB < 45)
                    {
                        WB = WB * 218 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 71)
                    {
                        WB = WB * 205 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 100)
                    {
                        WB = WB * 202 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 300)
                    {
                        WB = WB * 193 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 500)
                    {
                        WB = WB * 190 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 1000)
                    {
                        WB = WB * 189 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB == 1000 || WB > 1000)
                    {
                        WB = WB * 188 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }; break;

                //Canada QV: 18 July, 2022
                case 9:
                    if (WB < 45)
                    {
                        WB = WB * 220 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 71)
                    {
                        WB = WB * 219 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 100)
                    {
                        WB = WB * 218 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 300)
                    {
                        WB = WB * 217 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 500)
                    {
                        WB = WB * 215 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 1000)
                    {
                        WB = WB * 205 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB == 1000 || WB > 1000)
                    {
                        WB = WB * 200 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }; break;

                //USA QV: 29 Aug, 2022
                case 10:
                    if (WB < 45)
                    {
                        WB = WB * 229 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 71)
                    {
                        WB = WB * 216 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 100)
                    {
                        WB = WB * 210 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 300)
                    {
                        WB = WB * 200 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 500)
                    {
                        WB = WB * 195 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 1000)
                    {
                        WB = WB * 190 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB == 1000 || WB > 1000)
                    {
                        WB = WB * 183 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }; break;

                //Canada QV: 29 Aug, 2022
                case 11:
                    if (WB < 45)
                    {
                        WB = WB * 270 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 71)
                    {
                        WB = WB * 269 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 100)
                    {
                        WB = WB * 256 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 300)
                    {
                        WB = WB * 255 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 500)
                    {
                        WB = WB * 248 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB < 1000)
                    {
                        WB = WB * 241 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }
                    else if (WB == 1000 || WB > 1000)
                    {
                        WB = WB * 235 + WB * PS + HS + Red;
                        FSI = (FSI / 100) * WB;
                        WB = WB + FSI;
                        txtTotal.Text = WB.ToString();
                    }; break;
            }

            /*
            int srPrice;
            int sUSA sHK, sJP, sMY, sSSG, sTW, sCN, sEU1, sEU2, sCA;


            switch (cbLane.SelectedIndex)
            {
                case 0: srPrice = sUSA; break;
                case 1: srPrice = sHK; break;
                case 2: srPrice = sJP; break;
                case 3: srPrice = sMY; break;
                case 4: srPrice = sSSG; break;
                case 5: srPrice = sTW; break;
                case 6: srPrice = sCN; break;
                case 7: srPrice = sEU1; break;
                case 8: srPrice = sEU2; break;
                case 9: srPrice = sCA; break;
            }
            */



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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
