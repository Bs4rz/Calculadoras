using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Calculos_1TDSN_2025
{
    public partial class fmrVisorUnico: Form
    {
        string operacao = "";
        decimal vNumAnt;
        bool vLimpar = false;
        
        public fmrVisorUnico()
        {
            InitializeComponent();
        }

        private void F_numeros(object sender, EventArgs e)
        {
            string Digito = ((Button)sender).Text;

            if (vLimpar)
            {
                lblVisor.Text = "";
                vLimpar = false;
            }
            if (lblVisor.Text == "0")
            {
                lblVisor.Text = Digito;
            }
            else
            {
                lblVisor.Text += Digito;
            }

            if (lblVisor.Text.Length > 17)
            {
                lblVisor.Text = lblVisor.Text;
                lblAntiga.Visible = false;
            }
            else
            {
                lblAntiga.Visible = true;
            }
                lblVisor.Focus();

        }


        private void Operacoes(object sender, EventArgs e)
        {
            operacao = ((Button)sender).Text;
            vNumAnt = decimal.Parse(lblVisor.Text);
            vLimpar = true;
            lblAntiga.Text = vNumAnt.ToString();
            lblAntiga.Text += operacao;

            lblVisor.Focus();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(lblVisor.Text);
            lblAntiga.Text += vNumAtual.ToString();
            switch (operacao)
            {
                case "+":
                    lblVisor.Text = (vNumAnt + vNumAtual).ToString();
                    break;
                case "-":
                    lblVisor.Text = (vNumAnt - vNumAtual).ToString();
                    break;
                case "x":
                    lblVisor.Text = (vNumAnt * vNumAtual).ToString();
                    break;
                case "/":
                    if (vNumAtual == 0 || vNumAnt == 0)
                    {
                        lblVisor.Text = "1";
                    }
                    else
                    {
                        lblVisor.Text = (vNumAnt / vNumAtual).ToString();
                    }
                    break;
                case "^":
                    lblVisor.Text = Math.Pow(double.Parse(vNumAnt.ToString()), double.Parse(vNumAtual.ToString())).ToString();
                    break;
            } 
            lblVisor.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "0";
            lblAntiga.Text = "";
            operacao = "";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!lblVisor.Text.Contains(","))
            {
                lblVisor.Text += ",";
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            // Verifica se há algo para apagar e se não está apenas com "0"
            if (lblVisor.Text.Length > 0 && lblVisor.Text != "0")
            {
                // Remove o último caractere
                lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);

                // Se após apagar ficar vazio ou se o que sobrou for apenas "-" (no caso de números negativos), coloca "0"
                if (lblVisor.Text.Length == 0 || lblVisor.Text == "-")
                {
                    lblVisor.Text = "0";
                }
            }
            lblVisor.Focus();
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {
            if (lblVisor.Text != "0")
            {
                if (lblVisor.Text.StartsWith("-"))
                {
                    lblVisor.Text = lblVisor.Text.Substring(1);
                }
                else
                {
                    lblVisor.Text = "-" + lblVisor.Text;
                }
            }
            lblVisor.Focus();
        }
    }
}