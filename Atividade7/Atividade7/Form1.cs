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

namespace Atividade7 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e) {
            int[] Vetor = new int[20];
            string aux = "";
            string Valor = "";


            for (var i = 0; i < 20; i++) {
                Valor = Interaction.InputBox("Digite um valor: " + (i + 1), "Entrada de dados");

                if (Valor == "")
                    break;

                if (int.TryParse(Valor, out Vetor[i])) {
                    aux = Vetor[i].ToString() + "\n" + aux;
                } else {
                    MessageBox.Show("Número Inválido !");
                    i--;
                }
            }
        }

        private void btnEx2_Click(object sender, EventArgs e) {
            int[] Vetor = new int[20];
            string aux = "";
            string Valor = "";

            for (var i = 0; i < 20; i++) {
                Valor = Interaction.InputBox("Digite um valor: " + (i + 1), "Entrada de dados");

                if (Valor == "")
                    break;

                if (!int.TryParse(Valor, out Vetor[i])) {
                    MessageBox.Show("Número Inválido !");
                    i--;
                }

            }
            Array.Reverse(Vetor);

            for (var i = 0; i < 20; i++) {
                aux = aux + "\n" + Vetor[i];
            }
        }

        private void btnEx3_Click(object sender, EventArgs e) {
            double[] Qtidade = new double[10];
            double[] Preco = new double[10];
            double[] Faturamento = new double[10];
            double ValTotal = 0;
            string aux = "";
            string aux2 = "";
            string aux3 = "";

            for (var i = 0; i < 10; i++) {
                do {
                    aux = Interaction.InputBox("Digite a quantidade vendida do produto " + (i + 1), "Entrada de dados");
                } while (!double.TryParse(aux, out Qtidade[i]));


                do {
                    aux2 = Interaction.InputBox("Digite o Preço do produto " + (i + 1), "Entrada de dados");
                } while (!double.TryParse(aux2, out Preco[i]));

                Faturamento[i] = Qtidade[i] * Preco[i];
                aux3 = aux3 + "\n" + "O Faturamento do Produto " + (i + 1) + " é: R$ " + Faturamento[i].ToString("F2");
                ValTotal += Faturamento[i];
            }
            MessageBox.Show(aux3);
            MessageBox.Show("O Faturamento Total é: R$ " + ValTotal.ToString("F2"));
        }

        private void btnEx4_Click(object sender, EventArgs e) {
            ArrayList Alunos = new ArrayList(){"Ana", "André", "Débora", "Fátima",
            "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais"};

            Alunos.Remove("Otávio");

            for( var i = 0; i < Alunos.Count; i++) {
               MessageBox.Show(Alunos[i].ToString());
            }

        }

        private void btnEx5_Click(object sender, EventArgs e) {

            string[,] NotasAlunos = new string[20 , 4];
            int j = 0;
            double[] Medias = new double[20];
            string aux = "";

            for( var i = 0; i < 20; i++) {
                NotasAlunos[i , j] = Interaction.InputBox("Digite o Nome do Aluno ", "Entrada dos Dados");
                for(j = 1; j < 4; j++) {
                    do {
                        NotasAlunos[i, j] = Interaction.InputBox("Digite a Nota " + j + " do Aluno ", "Entrada dos Dados");
                    } while (!double.TryParse(NotasAlunos[i, j], out _));
                }
                j = 0;
                Medias[i] = 
                   (double.Parse(NotasAlunos[i, 1]) + double.Parse(NotasAlunos[i, 2]) + double.Parse(NotasAlunos[i, 3])) / 3;

                aux = aux + NotasAlunos[i, 0] + " -> Média: " + Medias[i].ToString("F2") + "\n";
            }
            MessageBox.Show(aux);
        }

        private void btnEx6_Click(object sender, EventArgs e) {
            Exercicio6 Ex6 = new Exercicio6();
            Ex6.Show();
        }
    }
}
