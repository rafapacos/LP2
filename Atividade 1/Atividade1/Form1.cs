using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labVol_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double verify1, verify2, Result;
            if (double.TryParse(txtNum1.Text, out verify1) && double.TryParse(txtNum2.Text, out verify2)){
                Result = Math.PI * Math.Pow(verify1, 2) * verify2;
                txtNum3.Text = Result.ToString("N2");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
