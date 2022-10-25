using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FedEx_Cargo
{
    public partial class FdxGround : UserControl
    {
        public FdxGround()
        {
            InitializeComponent();
        }

        private void CalcFDXGround()
        {
            //Unit Converter (kg to lb)

            double Wkg;
            double Wlb;
            string sWkg = txtKg.Text;
            double Usd;

            //Residential Delivery Surcharge
            double Red;
            string sRed = txtResidentialDeli.Text;
            Red = double.Parse(sRed);

            //Fuel Surcharge
            double FSI;
            string sFsi = txtFuelSurchg.Text;
            FSI = double.Parse(sFsi);

            if (string.IsNullOrEmpty(sWkg))
            {
                MessageBox.Show("Please input WEIGHT in Kilogram.");
                return;
            }
            else
            {
                Wkg = double.Parse(sWkg);
                Wlb = Wkg * 2.205;
                txtlb.Text = Wlb.ToString();

                //FDX Ground USA - NJ Estimated Charge Calculator
                switch (cbZone.SelectedIndex)
                {
                    //Begin Zone 2
                    case 0: 
                        if (Wlb < 4)
                        {
                            Wlb = Wlb + 7.00 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 5)
                        {
                            Wlb = Wlb + 7.05 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 6)
                        {
                            Wlb = Wlb + 7.11 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 7)
                        {
                            Wlb = Wlb + 7.51 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 8)
                        {
                            Wlb = Wlb + 7.73 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 9)
                        {
                            Wlb = Wlb + 7.85 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 10)
                        {
                            Wlb = Wlb + 15.84 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 11)
                        {
                            Wlb = Wlb + 16.64 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 12)
                        {
                            Wlb = Wlb + 16.92 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 13)
                        {
                            Wlb = Wlb + 16.93 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 14)
                        {
                            Wlb = Wlb + 17.61 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 15)
                        {
                            Wlb = Wlb + 17.62 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 16)
                        {
                            Wlb = Wlb + 18.62 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 17)
                        {
                            Wlb = Wlb + 18.77 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 18)
                        {
                            Wlb = Wlb + 18.95 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 19)
                        {
                            Wlb = Wlb + 19.48 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 20)
                        {
                            Wlb = Wlb + 19.62 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 21)
                        {
                            Wlb = Wlb + 20.32 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 22)
                        {
                            Wlb = Wlb + 20.38 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 23)
                        {
                            Wlb = Wlb + 20.46 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 24)
                        {
                            Wlb = Wlb + 21.02 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 25)
                        {
                            Wlb = Wlb + 21.26 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 26)
                        {
                            Wlb = Wlb + 22.28 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 27)
                        {
                            Wlb = Wlb + 22.81 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 28)
                        {
                            Wlb = Wlb + 23.43 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 29)
                        {
                            Wlb = Wlb + 23.49 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 30)
                        {
                            Wlb = Wlb + 23.17 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 32)
                        {
                            Wlb = Wlb + 24.17 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 33)
                        {
                            Wlb = Wlb + 24.32 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 34)
                        {
                            Wlb = Wlb + 24.45 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 35)
                        {
                            Wlb = Wlb + 24.93 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 36)
                        {
                            Wlb = Wlb + 25.29 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 37)
                        {
                            Wlb = Wlb + 25.67 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 38)
                        {
                            Wlb = Wlb + 26.07 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 39)
                        {
                            Wlb = Wlb + 26.94 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 40)
                        {
                            Wlb = Wlb + 26.96 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 41)
                        {
                            Wlb = Wlb + 27.31 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 42)
                        {
                            Wlb = Wlb + 27.48 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 43)
                        {
                            Wlb = Wlb + 28.11 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 44)
                        {
                            Wlb = Wlb + 28.50 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 45)
                        {
                            Wlb = Wlb + 28.53 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 46)
                        {
                            Wlb = Wlb + 29.16 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 47)
                        {
                            Wlb = Wlb + 29.26 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 48)
                        {
                            Wlb = Wlb + 29.27 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 49)
                        {
                            Wlb = Wlb + 29.29 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb == 50 || Wlb > 50)
                        {
                            Wlb = Wlb + 29.30 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        break; //End Zone 2

                        //Begin Zone 3
                    case 1: 
                        if (Wlb < 1)
                        {
                            Wlb = Wlb + 7.00 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 2)
                        {
                            Wlb = Wlb + 7.06 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 3)
                        {
                            Wlb = Wlb + 7.45 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 4)
                        {
                            Wlb = Wlb + 7.49 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 5)
                        {
                            Wlb = Wlb + 7.83 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 6)
                        {
                            Wlb = Wlb + 7.87 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 7)
                        {
                            Wlb = Wlb + 8.04 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 8)
                        {
                            Wlb = Wlb + 8.34 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 9)
                        {
                            Wlb = Wlb + 8.35 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 10)
                        {
                            Wlb = Wlb + 17.00 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 11)
                        {
                            Wlb = Wlb + 17.31 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 12)
                        {
                            Wlb = Wlb + 18.04 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 13)
                        {
                            Wlb = Wlb + 18.13 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 14)
                        {
                            Wlb = Wlb + 18.61 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 15)
                        {
                            Wlb = Wlb + 19.02 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 16)
                        {
                            Wlb = Wlb + 20.17 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 17)
                        {
                            Wlb = Wlb + 20.59 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 18)
                        {
                            Wlb = Wlb + 20.86 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 19)
                        {
                            Wlb = Wlb + 21.88 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 20)
                        {
                            Wlb = Wlb + 22.07 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 21)
                        {
                            Wlb = Wlb + 22.92 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 22)
                        {
                            Wlb = Wlb + 23.16 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 23)
                        {
                            Wlb = Wlb + 23.60 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 24)
                        {
                            Wlb = Wlb + 24.54 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 25)
                        {
                            Wlb = Wlb + 24.83 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 26)
                        {
                            Wlb = Wlb + 25.67 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 27)
                        {
                            Wlb = Wlb + 26.29 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 28)
                        {
                            Wlb = Wlb + 26.93 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 29)
                        {
                            Wlb = Wlb + 27.43 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 30)
                        {
                            Wlb = Wlb + 27.45 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 31)
                        {
                            Wlb = Wlb + 28.04 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 32)
                        {
                            Wlb = Wlb + 28.05 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 33)
                        {
                            Wlb = Wlb + 28.47 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 34)
                        {
                            Wlb = Wlb + 29.12 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 35)
                        {
                            Wlb = Wlb + 30.66 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 36)
                        {
                            Wlb = Wlb + 30.67 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 37)
                        {
                            Wlb = Wlb + 31.08 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 38)
                        {
                            Wlb = Wlb + 31.55 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 39)
                        {
                            Wlb = Wlb + 32.78 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 40)
                        {
                            Wlb = Wlb + 32.90 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 41)
                        {
                            Wlb = Wlb + 34.00 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 42)
                        {
                            Wlb = Wlb + 34.44 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 43)
                        {
                            Wlb = Wlb + 34.95 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 44)
                        {
                            Wlb = Wlb + 35.48 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 45)
                        {
                            Wlb = Wlb + 35.49 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 46)
                        {
                            Wlb = Wlb + 35.85 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 47)
                        {
                            Wlb = Wlb + 36.31 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 48)
                        {
                            Wlb = Wlb + 36.63 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb < 49)
                        {
                            Wlb = Wlb + 36.64 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        else if (Wlb == 50 || Wlb > 50)
                        {
                            Wlb = Wlb + 36.65 + Red;
                            FSI = (FSI / 100) * Wlb;
                            Wlb = Wlb + FSI;
                            txtUSD.Text = Wlb.ToString();
                        }
                        break; //End Zone 3

                        //Begin Zone 4
                    case 2: 
                        {
                            if (Wlb < 1)
                            {
                                Wlb = Wlb + 7.00 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 2)
                            {
                                Wlb = Wlb + 7.63 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 3)
                            {
                                Wlb = Wlb + 8.05 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 4)
                            {
                                Wlb = Wlb + 8.31 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 6)
                            {
                                Wlb = Wlb + 8.59 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 7)
                            {
                                Wlb = Wlb + 8.82 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 8)
                            {
                                Wlb = Wlb + 9.13 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 9)
                            {
                                Wlb = Wlb + 9.25 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 10)
                            {
                                Wlb = Wlb + 18.61 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 11)
                            {
                                Wlb = Wlb + 18.95 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 12)
                            {
                                Wlb = Wlb + 19.14 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 13)
                            {
                                Wlb = Wlb + 19.36 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 14)
                            {
                                Wlb = Wlb + 19.56 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 15)
                            {
                                Wlb = Wlb + 19.83 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 16)
                            {
                                Wlb = Wlb + 20.81 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 17)
                            {
                                Wlb = Wlb + 21.04 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 18)
                            {
                                Wlb = Wlb + 21.26 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 19)
                            {
                                Wlb = Wlb + 22.41 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 20)
                            {
                                Wlb = Wlb + 22.54 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 21)
                            {
                                Wlb = Wlb + 23.47 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 22)
                            {
                                Wlb = Wlb + 24.38 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 23)
                            {
                                Wlb = Wlb + 24.92 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 24)
                            {
                                Wlb = Wlb + 26.20 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 25)
                            {
                                Wlb = Wlb + 26.52 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 26)
                            {
                                Wlb = Wlb + 27.63 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 27)
                            {
                                Wlb = Wlb + 27.92 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 28)
                            {
                                Wlb = Wlb + 29.49 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 29)
                            {
                                Wlb = Wlb + 29.76 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 30)
                            {
                                Wlb = Wlb + 30.17 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 31)
                            {
                                Wlb = Wlb + 30.77 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 32)
                            {
                                Wlb = Wlb + 30.79 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 33)
                            {
                                Wlb = Wlb + 32.16 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 34)
                            {
                                Wlb = Wlb + 33.20 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 35)
                            {
                                Wlb = Wlb + 33.97 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 36)
                            {
                                Wlb = Wlb + 34.56 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 37)
                            {
                                Wlb = Wlb + 34.91 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 38)
                            {
                                Wlb = Wlb + 36.04 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 39)
                            {
                                Wlb = Wlb + 37.22 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 40)
                            {
                                Wlb = Wlb + 37.33 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 41)
                            {
                                Wlb = Wlb + 38.32 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 42)
                            {
                                Wlb = Wlb + 39.81 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 43)
                            {
                                Wlb = Wlb + 39.88 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 44)
                            {
                                Wlb = Wlb + 40.89 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 45)
                            {
                                Wlb = Wlb + 40.90 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 46)
                            {
                                Wlb = Wlb + 42.21 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 47)
                            {
                                Wlb = Wlb + 42.88 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 48)
                            {
                                Wlb = Wlb + 43.37 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 49)
                            {
                                Wlb = Wlb + 43.40 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb == 50 || Wlb > 50)
                            {
                                Wlb = Wlb + 43.40 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                        }
                        break; //End Zone 4

                        //Begin Zone 5
                    case 3:
                        {
                            if (Wlb < 1)
                            {
                                Wlb = Wlb + 7.00 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 2)
                            {
                                Wlb = Wlb + 7.81 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 3)
                            {
                                Wlb = Wlb + 8.38 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 4)
                            {
                                Wlb = Wlb + 8.84 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 5)
                            {
                                Wlb = Wlb + 9.24 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 6)
                            {
                                Wlb = Wlb + 9.28 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 7)
                            {
                                Wlb = Wlb + 9.57 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 8)
                            {
                                Wlb = Wlb + 9.85 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 9)
                            {
                                Wlb = Wlb + 9.93 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 10)
                            {
                                Wlb = Wlb + 20.32 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 11)
                            {
                                Wlb = Wlb + 20.37 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 12)
                            {
                                Wlb = Wlb + 20.66 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 13)
                            {
                                Wlb = Wlb + 21.05 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 14)
                            {
                                Wlb = Wlb + 21.57 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 15)
                            {
                                Wlb = Wlb + 22.33 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 16)
                            {
                                Wlb = Wlb + 23.41 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 17)
                            {
                                Wlb = Wlb + 24.07 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 18)
                            {
                                Wlb = Wlb + 25.22 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 19)
                            {
                                Wlb = Wlb + 26.42 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 20)
                            {
                                Wlb = Wlb + 27.47 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 21)
                            {
                                Wlb = Wlb + 27.79 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 22)
                            {
                                Wlb = Wlb + 28.55 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 23)
                            {
                                Wlb = Wlb + 29.36 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 24)
                            {
                                Wlb = Wlb + 30.64 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 25)
                            {
                                Wlb = Wlb + 31.46 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 26)
                            {
                                Wlb = Wlb + 32.75 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 27)
                            {
                                Wlb = Wlb + 33.29 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 28)
                            {
                                Wlb = Wlb + 35.24 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 29)
                            {
                                Wlb = Wlb + 25.26 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 30)
                            {
                                Wlb = Wlb + 35.79 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 31)
                            {
                                Wlb = Wlb + 36.25 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 32)
                            {
                                Wlb = Wlb + 36.26 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 33)
                            {
                                Wlb = Wlb + 37.97 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 34)
                            {
                                Wlb = Wlb + 39.29 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 35)
                            {
                                Wlb = Wlb + 40.25 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 36)
                            {
                                Wlb = Wlb + 41.24 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 37)
                            {
                                Wlb = Wlb + 42.14 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 38)
                            {
                                Wlb = Wlb + 43.16 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 39)
                            {
                                Wlb = Wlb + 44.50 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 40)
                            {
                                Wlb = Wlb + 44.51 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 41)
                            {
                                Wlb = Wlb + 46.09 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 42)
                            {
                                Wlb = Wlb + 46.23 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 43)
                            {
                                Wlb = Wlb + 48.60 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 44)
                            {
                                Wlb = Wlb + 49.46 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 45)
                            {
                                Wlb = Wlb + 49.47 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 46)
                            {
                                Wlb = Wlb + 50.39 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 47)
                            {
                                Wlb = Wlb + 50.77 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 48)
                            {
                                Wlb = Wlb + 52.61 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 49)
                            {
                                Wlb = Wlb + 52.62 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb == 50 || Wlb > 50)
                            {
                                Wlb = Wlb + 52.66 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                        }
                        break ; //End Zone 5

                        //Begin Zone 6
                    case 4:
                        {
                            if (Wlb < 1)
                            {
                                Wlb = Wlb + 7.22 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 2)
                            {
                                Wlb = Wlb + 8.14 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 3)
                            {
                                Wlb = Wlb + 8.72 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 4)
                            {
                                Wlb = Wlb + 9.09 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 5)
                            {
                                Wlb = Wlb + 9.61 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 6)
                            {
                                Wlb = Wlb + 9.63 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 7)
                            {
                                Wlb = Wlb + 9.80 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 8)
                            {
                                Wlb = Wlb + 10.20 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 9)
                            {
                                Wlb = Wlb + 10.41 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 10)
                            {
                                Wlb = Wlb + 20.98 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 11)
                            {
                                Wlb = Wlb + 21.60 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 12)
                            {
                                Wlb = Wlb + 22.36 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 13)
                            {
                                Wlb = Wlb + 23.07 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 14)
                            {
                                Wlb = Wlb + 24.41 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 15)
                            {
                                Wlb = Wlb + 25.76 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 16)
                            {
                                Wlb = Wlb + 27.40 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 17)
                            {
                                Wlb = Wlb + 28.56 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 18)
                            {
                                Wlb = Wlb + 30.04 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 19)
                            {
                                Wlb = Wlb + 30.93 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 20)
                            {
                                Wlb = Wlb + 32.00 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 21)
                            {
                                Wlb = Wlb + 33.00 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 22)
                            {
                                Wlb = Wlb + 34.33 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 23)
                            {
                                Wlb = Wlb + 35.98 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 24)
                            {
                                Wlb = Wlb + 37.33 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 25)
                            {
                                Wlb = Wlb + 37.99 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 26)
                            {
                                Wlb = Wlb + 39.37 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 27)
                            {
                                Wlb = Wlb + 40.96 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 28)
                            {
                                Wlb = Wlb + 42.96 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 29)
                            {
                                Wlb = Wlb + 44.19 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 30)
                            {
                                Wlb = Wlb + 43.86 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 31)
                            {
                                Wlb = Wlb + 45.13 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 32)
                            {
                                Wlb = Wlb + 45.14 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 33)
                            {
                                Wlb = Wlb + 47.97 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 34)
                            {
                                Wlb = Wlb + 48.10 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 35)
                            {
                                Wlb = Wlb + 48.82 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 36)
                            {
                                Wlb = Wlb + 50.86 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 37)
                            {
                                Wlb = Wlb + 51.08 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 38)
                            {
                                Wlb = Wlb + 52.24 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 39)
                            {
                                Wlb = Wlb + 54.62 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 40)
                            {
                                Wlb = Wlb + 54.70 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 41)
                            {
                                Wlb = Wlb + 56.97 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 42)
                            {
                                Wlb = Wlb + 57.22 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 43)
                            {
                                Wlb = Wlb + 60.32 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 44)
                            {
                                Wlb = Wlb + 60.68 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 45)
                            {
                                Wlb = Wlb + 60.69 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 46)
                            {
                                Wlb = Wlb + 62.29 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 47)
                            {
                                Wlb = Wlb + 63.15 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 48)
                            {
                                Wlb = Wlb + 64.09 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 49)
                            {
                                Wlb = Wlb + 64.56 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb == 50 || Wlb > 50)
                            {
                                Wlb = Wlb + 64.58 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                        }
                        break; //End Zone 6

                        //Begin Zone 7
                    case 5:
                        {
                            if (Wlb < 1)
                            {
                                Wlb = Wlb + 7.29 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 2)
                            {
                                Wlb = Wlb + 8.45 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 3)
                            {
                                Wlb = Wlb + 9.02 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 4)
                            {
                                Wlb = Wlb + 9.68 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 5)
                            {
                                Wlb = Wlb + 10.13 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 6)
                            {
                                Wlb = Wlb + 10.14 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 7)
                            {
                                Wlb = Wlb + 10.42 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 8)
                            {
                                Wlb = Wlb + 10.84 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 9)
                            {
                                Wlb = Wlb + 11.29 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 10)
                            {
                                Wlb = Wlb + 23.55 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 11)
                            {
                                Wlb = Wlb + 25.43 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 12)
                            {
                                Wlb = Wlb + 26.46 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 13)
                            {
                                Wlb = Wlb + 28.07 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 14)
                            {
                                Wlb = Wlb + 30.10 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 15)
                            {
                                Wlb = Wlb + 31.03 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 16)
                            {
                                Wlb = Wlb + 33.65 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 17)
                            {
                                Wlb = Wlb + 35.38 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 18)
                            {
                                Wlb = Wlb + 36.43 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 19)
                            {
                                Wlb = Wlb + 37.53 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 20)
                            {
                                Wlb = Wlb + 38.93 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 21)
                            {
                                Wlb = Wlb + 40.02 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 22)
                            {
                                Wlb = Wlb + 41.50 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 23)
                            {
                                Wlb = Wlb + 42.89 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 24)
                            {
                                Wlb = Wlb + 43.92 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 25)
                            {
                                Wlb = Wlb + 45.83 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 26)
                            {
                                Wlb = Wlb + 47.70 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 27)
                            {
                                Wlb = Wlb + 48.58 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 28)
                            {
                                Wlb = Wlb + 50.77 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 29)
                            {
                                Wlb = Wlb + 52.40 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 30)
                            {
                                Wlb = Wlb + 51.43 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 31)
                            {
                                Wlb = Wlb + 52.86 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 32)
                            {
                                Wlb = Wlb + 52.87 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 33)
                            {
                                Wlb = Wlb + 54.60 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 34)
                            {
                                Wlb = Wlb + 56.24 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 35)
                            {
                                Wlb = Wlb + 57.68 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 36)
                            {
                                Wlb = Wlb + 59.64 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 37)
                            {
                                Wlb = Wlb + 61.58 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 38)
                            {
                                Wlb = Wlb + 62.40 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 39)
                            {
                                Wlb = Wlb + 64.25 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 40)
                            {
                                Wlb = Wlb + 64.26 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 41)
                            {
                                Wlb = Wlb + 66.24 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 42)
                            {
                                Wlb = Wlb + 67.36 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 43)
                            {
                                Wlb = Wlb + 69.82 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 44)
                            {
                                Wlb = Wlb + 71.98 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 45)
                            {
                                Wlb = Wlb + 73.39 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 46)
                            {
                                Wlb = Wlb + 74.18 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 47)
                            {
                                Wlb = Wlb + 75.63 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 48)
                            {
                                Wlb = Wlb + 76.32 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 49)
                            {
                                Wlb = Wlb + 77.85 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb == 50 || Wlb > 50)
                            {
                                Wlb = Wlb + 77.86 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                        }
                        break; //End Zone 7

                        //Begin Zone 8
                    case 6:
                        {
                            if (Wlb < 1)
                            {
                                Wlb = Wlb + 7.43 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 2)
                            {
                                Wlb = Wlb + 8.59 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 3)
                            {
                                Wlb = Wlb + 9.46 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 4)
                            {
                                Wlb = Wlb + 10.13 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 5)
                            {
                                Wlb = Wlb + 10.74 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 6)
                            {
                                Wlb = Wlb + 10.75 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 7)
                            {
                                Wlb = Wlb + 11.15 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 8)
                            {
                                Wlb = Wlb + 11.64 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 9)
                            {
                                Wlb = Wlb + 12.25 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 10)
                            {
                                Wlb = Wlb + 26.02 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 11)
                            {
                                Wlb = Wlb + 27.64 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 12)
                            {
                                Wlb = Wlb + 28.93 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 13)
                            {
                                Wlb = Wlb + 30.24 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 14)
                            {
                                Wlb = Wlb + 32.88 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 15)
                            {
                                Wlb = Wlb + 34.23 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 16)
                            {
                                Wlb = Wlb + 37.03 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 17)
                            {
                                Wlb = Wlb + 37.36 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 18)
                            {
                                Wlb = Wlb + 39.92 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 19)
                            {
                                Wlb = Wlb + 41.86 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 20)
                            {
                                Wlb = Wlb + 43.36 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 21)
                            {
                                Wlb = Wlb + 44.69 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 22)
                            {
                                Wlb = Wlb + 46.65 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 23)
                            {
                                Wlb = Wlb + 48.50 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 24)
                            {
                                Wlb = Wlb + 51.27 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 25)
                            {
                                Wlb = Wlb + 52.28 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 26)
                            {
                                Wlb = Wlb + 54.43 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 27)
                            {
                                Wlb = Wlb + 55.34 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 28)
                            {
                                Wlb = Wlb + 58.01 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 29)
                            {
                                Wlb = Wlb + 58.99 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 30)
                            {
                                Wlb = Wlb + 60.03 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 31)
                            {
                                Wlb = Wlb + 61.94 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 32)
                            {
                                Wlb = Wlb + 63.21 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 33)
                            {
                                Wlb = Wlb + 64.31 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 34)
                            {
                                Wlb = Wlb + 67.39 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 35)
                            {
                                Wlb = Wlb + 68.51 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 36)
                            {
                                Wlb = Wlb + 70.54 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 37)
                            {
                                Wlb = Wlb + 71.23 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 38)
                            {
                                Wlb = Wlb + 72.56 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 39)
                            {
                                Wlb = Wlb + 74.05 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 40)
                            {
                                Wlb = Wlb + 74.57 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 41)
                            {
                                Wlb = Wlb + 76.87 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 42)
                            {
                                Wlb = Wlb + 77.25 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 43)
                            {
                                Wlb = Wlb + 79.35 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 44)
                            {
                                Wlb = Wlb + 80.19 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 45)
                            {
                                Wlb = Wlb + 80.75 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 46)
                            {
                                Wlb = Wlb + 82.89 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 47)
                            {
                                Wlb = Wlb + 84.22 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 48)
                            {
                                Wlb = Wlb + 85.56 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb < 49)
                            {
                                Wlb = Wlb + 86.06 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                            else if (Wlb == 50 || Wlb > 50)
                            {
                                Wlb = Wlb + 86.54 + Red;
                                FSI = (FSI / 100) * Wlb;
                                Wlb = Wlb + FSI;
                                txtUSD.Text = Wlb.ToString();
                            }
                        }
                        break; //End Zone 8
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalcFDXGround(); //No Ok Button, Just input WEIGHT and Enter.
            }
        }

        private void BtnKnowMore_Click(object sender, EventArgs e)
        {
            frmZone frmZone = new frmZone(); 
            frmZone.ShowDialog(); //Show Map Form
        }
    }
}