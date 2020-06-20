using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace P30481923042 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e) {
            lboxFaturamentos.Items.Clear();
            double[,] Faturamentos = new double[2, 4];
            string[,] strFaturamentos = new string[2, 4];
            double[] FaturamentoMes = new double[2];
            string[] aux = new string[4];
            int cont = 0;
            double TotGeral = 0.00;

            for ( var i = 0; i < 2; i++) {
                for(var j = 0; j < 4; j++) {
                    do {
                        strFaturamentos[i, j] = Interaction.InputBox("Digite o faturamento da semana " + (j+1) + " do mês " + (i+1)
                            , "Entrada dos Dados");
                    } while (!double.TryParse(strFaturamentos[i, j], out Faturamentos[i, j]));
                    aux[j] = "Total do mês " + (i + 1) + " Semana " + (j + 1) + " R$ " + Faturamentos[i, j].ToString("F2") + "\n";
                    lboxFaturamentos.Items.Insert(cont, aux[j]);
                    cont++;

                }
                FaturamentoMes[i] = Faturamentos[i, 0] + Faturamentos[i, 1] + Faturamentos[i, 2] + Faturamentos[i, 3];
                MessageBox.Show(FaturamentoMes[i].ToString("f2"));
                lboxFaturamentos.Items.Insert(cont, ">> Total Mês R$ " + FaturamentoMes[i].ToString("F2"));
                cont++;
                lboxFaturamentos.Items.Insert((cont), "--------------------------------------------");
                cont++;
                TotGeral += FaturamentoMes[i];

            }
            lboxFaturamentos.Items.Insert(cont, ">> Total Geral: R$ " + TotGeral.ToString("F2"));


        }
    }
}
