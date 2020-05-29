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
    public partial class frmEx4 : Form {
        public frmEx4() {
            InitializeComponent();
        }

        private void lblCargo_Click(object sender, EventArgs e) {

        }

        private void btnCalc_Click(object sender, EventArgs e) {
            double Salario, Producao, SalBruto, Gratificacao;
            int B = 0, C = 0, D = 0;
            //SalBruto = Salario + Salario * (0,05*B+0,1*C+0,1*D) + Gratificacao
            if(double.TryParse(txtSalBase.Text, out Salario) && double.TryParse(txtProducao.Text, out Producao) && 
                double.TryParse(txtGratificacao.Text, out Gratificacao)) {
                if(Producao >= 100) {
                    B = 1;
                }
                if(Producao >= 120) {
                    C = 1;
                }
                if(Producao >= 150) {
                    D = 1;
                }
                SalBruto = Salario + Salario * (0.05 * B + 0.1 * C + 0.1 * D) + Gratificacao;
                if (SalBruto > 7000.00) {
                    if( Producao >= 150 && Gratificacao > 0) {
                        txtSalBruto.Text = SalBruto.ToString("F2");
                    } 
                    else {
                        txtSalBruto.Text = "7000.00";
                    }
                } 
                else {
                    txtSalBruto.Text = SalBruto.ToString("F2");   
                }

            } 
            else {
                MessageBox.Show("Inserir Dados Válidos !");
            }
        }
    }
}
