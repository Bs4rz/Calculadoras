namespace Projeto_Calculos_1TDSN_2025
{
    partial class fmrVisorUnico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNegativo = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVisor = new System.Windows.Forms.Label();
            this.lblAntiga = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.lblTeclado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNegativo
            // 
            this.btnNegativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNegativo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNegativo.Location = new System.Drawing.Point(12, 349);
            this.btnNegativo.Name = "btnNegativo";
            this.btnNegativo.Size = new System.Drawing.Size(77, 76);
            this.btnNegativo.TabIndex = 0;
            this.btnNegativo.Text = "+/-";
            this.btnNegativo.UseVisualStyleBackColor = false;
            this.btnNegativo.Click += new System.EventHandler(this.btnNegativo_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(178, 349);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(77, 76);
            this.btnVirgula.TabIndex = 1;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            this.btnVirgula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnZero
            // 
            this.btnZero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnZero.Location = new System.Drawing.Point(95, 349);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(77, 76);
            this.btnZero.TabIndex = 2;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.F_numeros);
            this.btnZero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(284, 269);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(74, 40);
            this.btnMultiplicar.TabIndex = 15;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.Operacoes);
            this.btnMultiplicar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(284, 310);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(74, 40);
            this.btnDividir.TabIndex = 14;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.Operacoes);
            this.btnDividir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(284, 352);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(74, 40);
            this.btnPotencia.TabIndex = 13;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.Operacoes);
            this.btnPotencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(284, 395);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(74, 40);
            this.btnIgual.TabIndex = 12;
            this.btnIgual.Tag = "";
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            this.btnIgual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(284, 227);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(74, 40);
            this.btnSubtrair.TabIndex = 16;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.Operacoes);
            this.btnSubtrair.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(284, 184);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(74, 40);
            this.btnSomar.TabIndex = 17;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.Operacoes);
            this.btnSomar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnTres
            // 
            this.btnTres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTres.Location = new System.Drawing.Point(178, 267);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(77, 76);
            this.btnTres.TabIndex = 19;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.F_numeros);
            this.btnTres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnUm
            // 
            this.btnUm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUm.Location = new System.Drawing.Point(12, 267);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(77, 76);
            this.btnUm.TabIndex = 18;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.F_numeros);
            this.btnUm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnDois
            // 
            this.btnDois.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDois.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDois.Location = new System.Drawing.Point(95, 267);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(77, 76);
            this.btnDois.TabIndex = 20;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.F_numeros);
            this.btnDois.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuatro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnQuatro.Location = new System.Drawing.Point(12, 185);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(77, 76);
            this.btnQuatro.TabIndex = 21;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.F_numeros);
            this.btnQuatro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnSeis
            // 
            this.btnSeis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSeis.Location = new System.Drawing.Point(178, 185);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(77, 76);
            this.btnSeis.TabIndex = 22;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.F_numeros);
            this.btnSeis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnCinco
            // 
            this.btnCinco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCinco.Location = new System.Drawing.Point(95, 185);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(77, 76);
            this.btnCinco.TabIndex = 23;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.F_numeros);
            this.btnCinco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnSete
            // 
            this.btnSete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSete.Location = new System.Drawing.Point(12, 103);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(77, 76);
            this.btnSete.TabIndex = 24;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.F_numeros);
            this.btnSete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnNove
            // 
            this.btnNove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNove.Location = new System.Drawing.Point(178, 103);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(77, 76);
            this.btnNove.TabIndex = 25;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.F_numeros);
            this.btnNove.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnOito
            // 
            this.btnOito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOito.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOito.Location = new System.Drawing.Point(95, 103);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(77, 76);
            this.btnOito.TabIndex = 26;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.F_numeros);
            this.btnOito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(3, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 347);
            this.label1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(275, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 348);
            this.label2.TabIndex = 30;
            // 
            // lblVisor
            // 
            this.lblVisor.BackColor = System.Drawing.Color.White;
            this.lblVisor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisor.Location = new System.Drawing.Point(3, 9);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(374, 73);
            this.lblVisor.TabIndex = 31;
            this.lblVisor.Text = "0";
            this.lblVisor.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblAntiga
            // 
            this.lblAntiga.BackColor = System.Drawing.Color.White;
            this.lblAntiga.Location = new System.Drawing.Point(12, 21);
            this.lblAntiga.Name = "lblAntiga";
            this.lblAntiga.Size = new System.Drawing.Size(365, 23);
            this.lblAntiga.TabIndex = 32;
            this.lblAntiga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(284, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 40);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // btnErase
            // 
            this.btnErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErase.Location = new System.Drawing.Point(284, 94);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(74, 40);
            this.btnErase.TabIndex = 34;
            this.btnErase.Text = "<-";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            this.btnErase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            // 
            // lblTeclado
            // 
            this.lblTeclado.AutoSize = true;
            this.lblTeclado.Location = new System.Drawing.Point(12, 91);
            this.lblTeclado.Name = "lblTeclado";
            this.lblTeclado.Size = new System.Drawing.Size(0, 13);
            this.lblTeclado.TabIndex = 35;
            // 
            // fmrVisorUnico
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(379, 446);
            this.Controls.Add(this.lblTeclado);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblAntiga);
            this.Controls.Add(this.lblVisor);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnNegativo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "fmrVisorUnico";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Click += new System.EventHandler(this.Operacoes);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrVisorUnico_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNegativo;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVisor;
        private System.Windows.Forms.Label lblAntiga;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Label lblTeclado;
    }
}