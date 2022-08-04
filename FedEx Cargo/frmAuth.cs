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
    public partial class frmAuth : Form
    {
        public frmAuth()
        {
            InitializeComponent();
        }

        private void AuthLogin()
        {

            FrmMain frmMain = new FrmMain();

            string pwd;
            pwd = txtPwd.Text.ToString();

            int res;
            res = string.Compare(pwd, "alpine");

            if (res == 0)
            {
                //MessageBox.Show("Success!");
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password!");
            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AuthLogin();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuthLogin();
        }

        private void frmAuth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
