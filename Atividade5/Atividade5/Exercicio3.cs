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
    public partial class Exercicio3 : Form {
        public Exercicio3() {
            InitializeComponent();
        }

        private void btnRemove1_Click(object sender, EventArgs e) {

            int Posicao;
            Posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while(Posicao >= 0) {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, Posicao)
                + txtPalavra2.Text.Substring(Posicao + txtPalavra1.Text.Length, 
                txtPalavra2.Text.Length - Posicao - txtPalavra1.Text.Length);

                Posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }

        }

        private void btnRemove2_Click(object sender, EventArgs e) {

            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInvert_Click(object sender, EventArgs e) {
            string s = txtPalavra1.Text;
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            s = new string(arr);
            txtPalavra2.Text = s;

        }
    }
}
