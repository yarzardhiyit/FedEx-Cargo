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
    public partial class UcDiam : UserControl
    {
        public UcDiam()
        {
            InitializeComponent();
        }

        private void funCalc()
        {
            double Left, Right, High;
            double Dweight;
            string sLeft = txtL.Text;
            string sRight = txtR.Text;
            string sHigh = txtH.Text;

            const int Divcon = 5000;
            Left = double.Parse(sLeft);
            Right = double.Parse(sRight);
            High = double.Parse(sHigh);

            Dweight = (Left * Right * High) / Divcon ;
            txtDW.Text = Dweight.ToString();

        }

        private void btnDcalc_Click(object sender, EventArgs e)
        {
            funCalc();
        }

        private void txtH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                funCalc();
            }
        }
    }
}
