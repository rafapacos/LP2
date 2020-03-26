using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDescIRPF_Click(object sender, EventArgs e)
        {

        }

        private void btnVerifDesc_Click(object sender, EventArgs e)
        {
            double dSalBruto, dDescINSS, dSalLiq, dDescIRPF = 0.00, dSalFam = 0.00;
            int iFilhos;

            if (txtbFunc.Text == "" || double.TryParse(txtbFunc.Text, out dSalBruto) == true)
            {
                MessageBox.Show("Entrar com Nome Correto");
            }
            else
            {
                if (double.TryParse(txtbSalB.Text, out dSalBruto) && int.TryParse(txtbFilhos.Text, out iFilhos))
                {
                    dSalBruto = dSalBruto / 100;
                    if (dSalBruto <= 800.47)
                    {
                        dDescINSS = 0.0765 * dSalBruto;
                        txtbINSS.Text = "7.65%";
                    }
                    else if (dSalBruto <= 1050)
                    {
                        dDescINSS = 0.0865 * dSalBruto;
                        txtbINSS.Text = "8.65%";
                    }
                    else if (dSalBruto <= 1400.77)
                    {
                        dDescINSS = 0.09 * dSalBruto;
                        txtbINSS.Text = "9.00%";
                    }
                    else if (dSalBruto <= 2801.56)
                    {
                        dDescINSS = 0.11 * dSalBruto;
                        txtbINSS.Text = "11.%";
                    }
                    else
                    {
                        dDescINSS = 308.17;
                        txtbINSS.Text = "Teto R$ " + dDescINSS.ToString();
                    }

                    if (dSalBruto <= 1257.12)
                    {
                        txtbIRPF.Text = "Isento";
                    }
                    else if (dSalBruto <= 2508.12)
                    {
                        dDescIRPF = 0.15;
                        txtbIRPF.Text = (dDescIRPF * 100).ToString() + "%";

                    }
                    else
                    {
                        dDescIRPF = 0.275;
                        txtbIRPF.Text = (dDescIRPF * 100).ToString() + "%";
                    }
                    if (dSalBruto <= 435.52)
                    {
                        dSalFam = 22.33 * iFilhos;
                    }
                    dSalLiq = dSalBruto - dDescINSS - dDescIRPF * dSalBruto + dSalFam;
                    txtbSalLiq.Text = Math.Round(dSalLiq, 2).ToString("N2");
                    txtbSalFam.Text = dSalFam.ToString("N2");
                    txtbDescINSS.Text = dDescINSS.ToString("N2");
                    txtbDescIRPF.Text = (dDescIRPF * dSalBruto).ToString("N2");
                    if (rdbtMasc.Checked)
                    {
                        if (checkbCasado.Checked)
                        {
                            lblDados.Text = "Os desconto do Salário do Sr." + txtbFunc.Text + "\n" +
                                "que é casado e que tem " + iFilhos.ToString() + " filho(s) são: ";
                        }
                        else
                        {
                            lblDados.Text = "Os desconto do Salário do Sra." + txtbFunc.Text + "\n" +
                                "que é solteiro e que tem " + iFilhos.ToString() + " filho(s) são: ";
                        }

                    }
                    else if (rdbtFem.Checked)
                    {
                        if (checkbCasado.Checked)
                        {
                            lblDados.Text = "Os desconto do Salário do Sr." + txtbFunc.Text + "\n" +
                                "que é casada e que tem " + iFilhos.ToString() + " filho(s) são: ";
                        }
                        else
                        {
                            lblDados.Text = "Os desconto do Salário do Sra." + txtbFunc.Text + "\n" +
                                "que é solteira e que tem " + iFilhos.ToString() + " filho(s) são: ";
                        }
                    }
                    else
                        MessageBox.Show("Marcar o Sexo !");
                }
                else
                    MessageBox.Show("Preencher Dados Válidos");
            }    
        }
    }
}
