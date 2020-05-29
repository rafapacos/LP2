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
    public partial class Exercicio5 : Form {
        public Exercicio5() {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e) {
            Random objRandom = new Random();

            int Num = objRandom.Next(Convert.ToInt32(txtNum1.Text), (Convert.ToInt32(txtNum2.Text) + 1));

            MessageBox.Show("Numero Sorteado: " + Num);
        }
    }
}
