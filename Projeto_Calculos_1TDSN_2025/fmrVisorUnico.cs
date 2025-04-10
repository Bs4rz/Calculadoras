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
            lblAntiga.Text = " " + vNumAnt.ToString();
            lblAntiga.Text += " " + operacao;

            lblVisor.Focus();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(lblVisor.Text);
            lblAntiga.Text += " " + vNumAtual.ToString();
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
                    if (vNumAtual == 0 || vNumAnt == 0)
                    {
                        lblVisor.Text = "1";
                    }
                    else
                    {
                        lblVisor.Text = (vNumAnt * vNumAtual).ToString();
                    }
                    break;
                case "/":
                    if (vNumAtual == 0 || vNumAnt == 0)
                    {
                        lblVisor.Text = (vNumAnt + vNumAtual).ToString();
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
            
            if (lblVisor.Text.Length > 0 && lblVisor.Text != "0")
            {
                
                lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);

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

        // Adiciona o teclado
        private void fmrVisorUnico_KeyDown(object sender, KeyEventArgs e)
        {
            lblTeclado.Text = e.KeyCode.ToString();
            string digito = e.KeyCode.ToString();
            Button bot = new Button();

            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                bot.Text = digito.Substring(1, 1);
                F_numeros(bot, e);
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                bot.Text = digito.Substring(6, 1);
                F_numeros(bot, e);
            }
                switch (e.KeyCode.ToString())
                {
                    case "Add":
                        bot.Text = "+";
                        Operacoes(bot, e);
                        break;
                    case "Subtract":
                        bot.Text = "-";
                        Operacoes(bot, e);
                        break;
                    case "OemMinus":
                        bot.Text = "-";
                        Operacoes(bot, e);
                        break;
                    case "Multiply":
                        bot.Text = "*";
                        Operacoes(bot, e);
                        break;
                    case "None":
                        bot.Text = "/";
                        Operacoes(bot, e);
                        break;
                    case "Divide":
                        bot.Text = "/";
                        Operacoes(bot, e);
                        break;
                    case "Oemcomma":
                        bot.Text = ",";
                        btnVirgula_Click(bot, e);
                        break;
                    case "Back":
                        btnErase_Click(bot, e);
                        break;
                    case "Decimal":
                         bot.Text = "+";
                        Operacoes(bot, e);
                        break;
                    case "Oemplus":
                        bot.Text = "+";
                        Operacoes(bot, e);
                        break;
            }
        }
    }
}