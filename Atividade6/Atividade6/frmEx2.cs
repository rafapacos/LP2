using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6 {
    public partial class frmEx2 : Form {
        public frmEx2() {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e) {
            double Num1;
            double Result = 0;
            if(double.TryParse(txtNumero.Text, out Num1)) {
                for( var i = 1.00; i <= Num1; i++) {
                    Result += (1 / i);
                }
                txtResultado.Text = Result.ToString("F2");
            }else {
                MessageBox.Show("Digitar número válido !");
            }

        }
    }
}
