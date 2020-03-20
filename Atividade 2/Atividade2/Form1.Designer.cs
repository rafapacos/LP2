namespace Atividade2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labAlt = new System.Windows.Forms.Label();
            this.labPesoAtual = new System.Windows.Forms.Label();
            this.labPesoIdeal = new System.Windows.Forms.Label();
            this.labSituacao = new System.Windows.Forms.Label();
            this.grpboxSexo = new System.Windows.Forms.GroupBox();
            this.rdbtnMasc = new System.Windows.Forms.RadioButton();
            this.rdbtnFem = new System.Windows.Forms.RadioButton();
            this.mtxtAltura = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPesoAtual = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPesoIdeal = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSituacao = new System.Windows.Forms.MaskedTextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpboxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labAlt
            // 
            this.labAlt.AutoSize = true;
            this.labAlt.Location = new System.Drawing.Point(32, 28);
            this.labAlt.Name = "labAlt";
            this.labAlt.Size = new System.Drawing.Size(50, 13);
            this.labAlt.TabIndex = 0;
            this.labAlt.Text = "ALTURA";
            // 
            // labPesoAtual
            // 
            this.labPesoAtual.AutoSize = true;
            this.labPesoAtual.Location = new System.Drawing.Point(32, 60);
            this.labPesoAtual.Name = "labPesoAtual";
            this.labPesoAtual.Size = new System.Drawing.Size(74, 13);
            this.labPesoAtual.TabIndex = 1;
            this.labPesoAtual.Text = "PESO ATUAL";
            this.labPesoAtual.Click += new System.EventHandler(this.label2_Click);
            // 
            // labPesoIdeal
            // 
            this.labPesoIdeal.AutoSize = true;
            this.labPesoIdeal.Location = new System.Drawing.Point(32, 224);
            this.labPesoIdeal.Name = "labPesoIdeal";
            this.labPesoIdeal.Size = new System.Drawing.Size(70, 13);
            this.labPesoIdeal.TabIndex = 2;
            this.labPesoIdeal.Text = "PESO IDEAL";
            // 
            // labSituacao
            // 
            this.labSituacao.AutoSize = true;
            this.labSituacao.Location = new System.Drawing.Point(32, 259);
            this.labSituacao.Name = "labSituacao";
            this.labSituacao.Size = new System.Drawing.Size(61, 13);
            this.labSituacao.TabIndex = 3;
            this.labSituacao.Text = "SITUAÇÃO";
            // 
            // grpboxSexo
            // 
            this.grpboxSexo.Controls.Add(this.rdbtnFem);
            this.grpboxSexo.Controls.Add(this.rdbtnMasc);
            this.grpboxSexo.Location = new System.Drawing.Point(35, 100);
            this.grpboxSexo.Name = "grpboxSexo";
            this.grpboxSexo.Size = new System.Drawing.Size(208, 97);
            this.grpboxSexo.TabIndex = 4;
            this.grpboxSexo.TabStop = false;
            this.grpboxSexo.Text = "SEXO";
            // 
            // rdbtnMasc
            // 
            this.rdbtnMasc.AutoSize = true;
            this.rdbtnMasc.Location = new System.Drawing.Point(6, 29);
            this.rdbtnMasc.Name = "rdbtnMasc";
            this.rdbtnMasc.Size = new System.Drawing.Size(88, 17);
            this.rdbtnMasc.TabIndex = 0;
            this.rdbtnMasc.TabStop = true;
            this.rdbtnMasc.Text = "MASCULINO";
            this.rdbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rdbtnFem
            // 
            this.rdbtnFem.AutoSize = true;
            this.rdbtnFem.Location = new System.Drawing.Point(6, 62);
            this.rdbtnFem.Name = "rdbtnFem";
            this.rdbtnFem.Size = new System.Drawing.Size(77, 17);
            this.rdbtnFem.TabIndex = 1;
            this.rdbtnFem.TabStop = true;
            this.rdbtnFem.Text = "FEMININO";
            this.rdbtnFem.UseVisualStyleBackColor = true;
            // 
            // mtxtAltura
            // 
            this.mtxtAltura.Location = new System.Drawing.Point(121, 25);
            this.mtxtAltura.Mask = "0,00";
            this.mtxtAltura.Name = "mtxtAltura";
            this.mtxtAltura.Size = new System.Drawing.Size(100, 20);
            this.mtxtAltura.TabIndex = 5;
            // 
            // mtxtPesoAtual
            // 
            this.mtxtPesoAtual.Location = new System.Drawing.Point(121, 60);
            this.mtxtPesoAtual.Name = "mtxtPesoAtual";
            this.mtxtPesoAtual.Size = new System.Drawing.Size(100, 20);
            this.mtxtPesoAtual.TabIndex = 6;
            // 
            // mtxtPesoIdeal
            // 
            this.mtxtPesoIdeal.Enabled = false;
            this.mtxtPesoIdeal.Location = new System.Drawing.Point(121, 217);
            this.mtxtPesoIdeal.Name = "mtxtPesoIdeal";
            this.mtxtPesoIdeal.Size = new System.Drawing.Size(100, 20);
            this.mtxtPesoIdeal.TabIndex = 7;
            // 
            // mtxtSituacao
            // 
            this.mtxtSituacao.Enabled = false;
            this.mtxtSituacao.Location = new System.Drawing.Point(121, 256);
            this.mtxtSituacao.Name = "mtxtSituacao";
            this.mtxtSituacao.Size = new System.Drawing.Size(227, 20);
            this.mtxtSituacao.TabIndex = 8;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(22, 311);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(159, 72);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(239, 311);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(159, 72);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 436);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.mtxtSituacao);
            this.Controls.Add(this.mtxtPesoIdeal);
            this.Controls.Add(this.mtxtPesoAtual);
            this.Controls.Add(this.mtxtAltura);
            this.Controls.Add(this.grpboxSexo);
            this.Controls.Add(this.labSituacao);
            this.Controls.Add(this.labPesoIdeal);
            this.Controls.Add(this.labPesoAtual);
            this.Controls.Add(this.labAlt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpboxSexo.ResumeLayout(false);
            this.grpboxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAlt;
        private System.Windows.Forms.Label labPesoAtual;
        private System.Windows.Forms.Label labPesoIdeal;
        private System.Windows.Forms.Label labSituacao;
        private System.Windows.Forms.GroupBox grpboxSexo;
        private System.Windows.Forms.RadioButton rdbtnFem;
        private System.Windows.Forms.RadioButton rdbtnMasc;
        private System.Windows.Forms.MaskedTextBox mtxtAltura;
        private System.Windows.Forms.MaskedTextBox mtxtPesoAtual;
        private System.Windows.Forms.MaskedTextBox mtxtPesoIdeal;
        private System.Windows.Forms.MaskedTextBox mtxtSituacao;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpar;
    }
}

