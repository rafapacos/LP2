using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtbResult.Text = "";
            double dLado1, dLado2, dLado3;

            if(double.TryParse(textBox1.Text, out dLado1) == false)
            {
                wrnlbl1.Text = "Valor Invalido";
            }
            else
                wrnlbl1.Text = "";
            if (double.TryParse(textBox2.Text, out dLado2) == false)
            {
                wrnlbl2.Text = "Valor Invalido";
            }
            else
                wrnlbl2.Text = "";
            if (double.TryParse(textBox3.Text, out dLado3) == false)
            {
                wrnlbl3.Text = "Valor Invalido";
            }
            else
                wrnlbl3.Text = "";
            if(Math.Abs(dLado1 - dLado2) > dLado3 || (dLado1 + dLado2) < dLado3)
            {
                MessageBox.Show("Lados não pertencem a um triangulo!");
            }
            else if (Math.Abs(dLado1 - dLado3) > dLado2 || (dLado1 + dLado3) < dLado2)
            {
                MessageBox.Show("Lados não pertencem a um triangulo!");
            }
            else if (Math.Abs(dLado3 - dLado2) > dLado1 || (dLado3 + dLado2) < dLado1)
            {
                MessageBox.Show("Lados não pertencem a um triangulo!");
            }
            else
            {
                if (dLado1 == dLado2 && dLado2 == dLado3)
                    txtbResult.Text = "Triangulo Equilátero";
                else if(dLado1 == dLado2 || dLado2 == dLado3 || dLado1 == dLado3)
                    txtbResult.Text = "Triangulo Isósceles";
                else
                    txtbResult.Text = "Triangulo Escaleno";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            txtbResult.Clear();
        }
    }
}
