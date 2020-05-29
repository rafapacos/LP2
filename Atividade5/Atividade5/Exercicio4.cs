using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade5 {
    public partial class Exercicio4 : Form {
        public Exercicio4() {
            InitializeComponent();
        }

        private void btnCharNum_Click(object sender, EventArgs e) {

            int i = 0;

            for (var x = 0; x<= rchtxtTexto.Text.Length - 1; x++) {

                if (char.IsNumber(rchtxtTexto.Text[x]))
                    i += 1;
            }

            MessageBox.Show("Caracteres Numerico: " + i);
        }

        private void btnWhiteWord_Click(object sender, EventArgs e) {

            int i = 0;

            while( i < rchtxtTexto.Text.Length) {
                if(char.IsWhiteSpace(rchtxtTexto.Text[i])) {
                    MessageBox.Show("Primeiro Caracter branco: " + (i + 1));
                    break;
                }
                i++;
            }
        }

        private void btnCharAlpha_Click(object sender, EventArgs e) {

            int i = 0;

            foreach (char c in rchtxtTexto.Text) {
                if(char.IsLetter(c))
                    i++;
            }
            MessageBox.Show("Caracteres Alfabetico: " + i);
        }
    }
}
