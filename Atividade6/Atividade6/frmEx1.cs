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
    public partial class frmEx1 : Form {
        public frmEx1() {
            InitializeComponent();
        }

        private void btnWhiteSpace_Click(object sender, EventArgs e) {
            int cont = 0;

            for (var i = 0; i < rchtxtTexto.Text.Length; i++) {
                if (char.IsWhiteSpace(rchtxtTexto.Text[i])){
                    cont++;
                }
            }
            MessageBox.Show("O Numero de Espaços em branco na frase é: " + cont);
        }

        private void btnLetterR_Click(object sender, EventArgs e) {
            int cont = 0;
            foreach(char c in rchtxtTexto.Text) {
                if (c == 'R' || c == 'r') {
                    cont++;
                }
            }
            MessageBox.Show("O Numero de Letras 'R' na frase é: " + cont);
        }

        private void btnLetterPair_Click(object sender, EventArgs e) {
            int i = 0;
            int cont = 0;
            while (i < rchtxtTexto.Text.Length - 1) {
                if(char.ToUpper(rchtxtTexto.Text[i]) == char.ToUpper(rchtxtTexto.Text[i + 1])) {
                    cont++;
                }
                i++;
            }
            MessageBox.Show("O Numero de Letras repetidas em seguida na frase é: " + cont);
        }
    }
}
