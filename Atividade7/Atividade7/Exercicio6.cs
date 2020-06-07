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

namespace Atividade7 {
    public partial class Exercicio6 : Form {
        public Exercicio6() {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e) {
            string[] Nomes = new string[2];
            int[] Valores = new int[2];
            int cont = 0;

            for (var i = 0; i < 2; i++) {
                Nomes[i] = Interaction.InputBox("Digite um Nome Completo", "Entrada de Dados");

                foreach (char c in Nomes[i]) {
                    if (char.IsWhiteSpace(c)) {
                        cont++;
                    }
                }
                Valores[i] = (Nomes[i].Length - cont);
                lbNomes.Items.Insert(i, "O Nome: " + Nomes[i] + " tem " + Valores[i] + " caracteres");
                cont = 0;
            }
        }
    }
}
