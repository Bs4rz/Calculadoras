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
                    lblVisor.Text = (vNumAnt / vNumAtual).ToString();
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


    }
}
