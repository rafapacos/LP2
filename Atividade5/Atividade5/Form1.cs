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
    public partial class frmPrincipal : Form {
        public frmPrincipal() {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Você clicou no Copiar");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {

        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e) {
            Exercicio2 frm2 = new Exercicio2();
            frm2.MdiParent = this;
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e) {
            Exercicio3 frm3 = new Exercicio3();
            frm3.MdiParent = this;
            frm3.WindowState = FormWindowState.Maximized;
            frm3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e) {
            Exercicio4 frm4 = new Exercicio4();
            frm4.MdiParent = this;
            frm4.WindowState = FormWindowState.Maximized;
            frm4.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e) {
            Exercicio5 frm5 = new Exercicio5();
            frm5.MdiParent = this;
            frm5.WindowState = FormWindowState.Maximized;
            frm5.Show();
        }
    }
}
