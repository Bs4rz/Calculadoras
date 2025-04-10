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
    public partial class MDI_Menu : Form
    {
        // Variáveis para armazenar as instâncias dos formulários
        private frmCalcButtons objCalBot;
        private fmrCalcRadio objCalRad;
        private fmrVisorUnico objCalVisor;

        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void comBotoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objCalBot == null || objCalBot.IsDisposed)
            {
                objCalBot = new frmCalcButtons();
                objCalBot.MdiParent = this;
                objCalBot.FormClosed += (s, args) => { objCalBot = null; };
                objCalBot.Show();
            }
            else
            {
                objCalBot.BringToFront();
                if (objCalBot.WindowState == FormWindowState.Minimized)
                {
                    objCalBot.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MDI_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quer sair mesmo???", "Cê ta saindo",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Hand,
            MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stlDataHora.Text = DateTime.Now.ToString();
        }

        private void comRadioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objCalRad == null || objCalRad.IsDisposed)
            {
                objCalRad = new fmrCalcRadio();
                objCalRad.MdiParent = this;
                objCalRad.FormClosed += (s, args) => { objCalRad = null; };
                objCalRad.Show();
            }
            else
            {
                objCalRad.BringToFront();
                if (objCalRad.WindowState == FormWindowState.Minimized)
                {
                    objCalRad.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void visualÚnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objCalVisor == null || objCalVisor.IsDisposed)
            {
                objCalVisor = new fmrVisorUnico();
                objCalVisor.MdiParent = this;
                objCalVisor.FormClosed += (s, args) => { objCalVisor = null; };
                objCalVisor.Show();
            }
            else
            {
                objCalVisor.BringToFront();
                if (objCalVisor.WindowState == FormWindowState.Minimized)
                {
                    objCalVisor.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            visualÚnicoToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            comRadioButtonsToolStripMenuItem_Click(sender, e);
        }
    }
}