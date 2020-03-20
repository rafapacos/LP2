using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double dAltura, dPesoAtual, dPesoIdeal;

            if (double.TryParse(mtxtAltura.Text, out dAltura) && double.TryParse(mtxtPesoAtual.Text, out dPesoAtual))
            {
                if (rdbtnMasc.Checked)
                {
                    dPesoIdeal = (72.7 * (dAltura/100)) - 58;
                    dPesoIdeal = Math.Round(dPesoIdeal, 2);
                    mtxtPesoIdeal.Text = dPesoIdeal.ToString();
                    if (dPesoAtual < dPesoIdeal)
                        mtxtSituacao.Text = "Coma Massas e Doces";
                    if (dPesoAtual > dPesoIdeal)
                        mtxtSituacao.Text = "Regime Obrigatório já";
                    if (dPesoAtual == dPesoIdeal)
                        mtxtSituacao.Text = "Incrivel, Peso Perfeito !";
                }
                if (rdbtnFem.Checked)
                {
                    dPesoIdeal = (62.1 * (dAltura / 100)) - 44.7;
                    dPesoIdeal = Math.Round(dPesoIdeal, 2);
                    mtxtPesoIdeal.Text = dPesoIdeal.ToString();
                    if (dPesoAtual < dPesoIdeal)
                        mtxtSituacao.Text = "Coma Massas e Doces";
                    if (dPesoAtual > dPesoIdeal)
                        mtxtSituacao.Text = "Regime Obrigatório já";
                    if (dPesoAtual == dPesoIdeal)
                        mtxtSituacao.Text = "Incrivel, Peso Perfeito !";
                }               
            }
            else
                MessageBox.Show("INSERIR VALORES NUMÉRICOS");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mtxtAltura.Clear();
            mtxtPesoAtual.Clear();
            mtxtPesoIdeal.Clear();
            mtxtSituacao.Clear();
        }
    }
}
