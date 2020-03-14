namespace Atividade1
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
            this.labRaio = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.labAlt = new System.Windows.Forms.Label();
            this.labVol = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labRaio
            // 
            this.labRaio.AutoSize = true;
            this.labRaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRaio.Location = new System.Drawing.Point(174, 54);
            this.labRaio.Name = "labRaio";
            this.labRaio.Size = new System.Drawing.Size(37, 17);
            this.labRaio.TabIndex = 0;
            this.labRaio.Text = "Raio";
            // 
            // txtNum2
            // 
            this.txtNum2.AcceptsTab = true;
            this.txtNum2.Location = new System.Drawing.Point(511, 51);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(179, 20);
            this.txtNum2.TabIndex = 2;
            // 
            // labAlt
            // 
            this.labAlt.AutoSize = true;
            this.labAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAlt.Location = new System.Drawing.Point(460, 54);
            this.labAlt.Name = "labAlt";
            this.labAlt.Size = new System.Drawing.Size(45, 17);
            this.labAlt.TabIndex = 2;
            this.labAlt.Text = "Altura";
            // 
            // labVol
            // 
            this.labVol.AutoSize = true;
            this.labVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVol.Location = new System.Drawing.Point(282, 144);
            this.labVol.Name = "labVol";
            this.labVol.Size = new System.Drawing.Size(55, 17);
            this.labVol.TabIndex = 3;
            this.labVol.Text = "Volume";
            this.labVol.Click += new System.EventHandler(this.labVol_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.AcceptsTab = true;
            this.txtNum1.Location = new System.Drawing.Point(217, 51);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(179, 20);
            this.txtNum1.TabIndex = 1;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum3
            // 
            this.txtNum3.Enabled = false;
            this.txtNum3.Location = new System.Drawing.Point(343, 143);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(179, 20);
            this.txtNum3.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(310, 213);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(228, 72);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(674, 306);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 50);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.labVol);
            this.Controls.Add(this.labAlt);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.labRaio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labRaio;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label labAlt;
        private System.Windows.Forms.Label labVol;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnSair;
    }
}

