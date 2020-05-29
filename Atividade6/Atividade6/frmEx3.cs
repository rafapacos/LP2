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
    public partial class frmEx3 : Form {
        public frmEx3() {
            InitializeComponent();
        }

        private void btnPalindromo_Click(object sender, EventArgs e) {
            if(txtFrase.Text.Length <= 50) {
                string s = txtFrase.Text.Replace(" ", "");
                s = s.ToUpper();
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                string s2 = new string(arr);
                if( s == s2) {
                    MessageBox.Show("É um palíndromo !!!");
                } 
                else {
                    MessageBox.Show("Não é um palíndromo");
                }
               
            } 
            else {
                MessageBox.Show("No maximo 50 caracteres");
            }
            
        }
    }
}
