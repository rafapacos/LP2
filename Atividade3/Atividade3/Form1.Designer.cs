namespace Atividade3
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
            this.labLado1 = new System.Windows.Forms.Label();
            this.labLado2 = new System.Windows.Forms.Label();
            this.labLado3 = new System.Windows.Forms.Label();
            this.labResultado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtbResult = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.wrnlbl1 = new System.Windows.Forms.Label();
            this.wrnlbl2 = new System.Windows.Forms.Label();
            this.wrnlbl3 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLado1
            // 
            this.labLado1.AutoSize = true;
            this.labLado1.Location = new System.Drawing.Point(77, 9);
            this.labLado1.Name = "labLado1";
            this.labLado1.Size = new System.Drawing.Size(40, 13);
            this.labLado1.TabIndex = 0;
            this.labLado1.Text = "Lado 1";
            // 
            // labLado2
            // 
            this.labLado2.AutoSize = true;
            this.labLado2.Location = new System.Drawing.Point(77, 51);
            this.labLado2.Name = "labLado2";
            this.labLado2.Size = new System.Drawing.Size(40, 13);
            this.labLado2.TabIndex = 1;
            this.labLado2.Text = "Lado 2";
            // 
            // labLado3
            // 
            this.labLado3.AutoSize = true;
            this.labLado3.Location = new System.Drawing.Point(77, 91);
            this.labLado3.Name = "labLado3";
            this.labLado3.Size = new System.Drawing.Size(40, 13);
            this.labLado3.TabIndex = 2;
            this.labLado3.Text = "Lado 3";
            // 
            // labResultado
            // 
            this.labResultado.AutoSize = true;
            this.labResultado.Location = new System.Drawing.Point(12, 182);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(131, 13);
            this.labResultado.TabIndex = 3;
            this.labResultado.Text = "Classificação do Triangulo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // txtbResult
            // 
            this.txtbResult.Enabled = false;
            this.txtbResult.Location = new System.Drawing.Point(149, 179);
            this.txtbResult.Name = "txtbResult";
            this.txtbResult.Size = new System.Drawing.Size(205, 20);
            this.txtbResult.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(35, 238);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(142, 68);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // wrnlbl1
            // 
            this.wrnlbl1.AutoSize = true;
            this.wrnlbl1.ForeColor = System.Drawing.Color.Red;
            this.wrnlbl1.Location = new System.Drawing.Point(278, 9);
            this.wrnlbl1.Name = "wrnlbl1";
            this.wrnlbl1.Size = new System.Drawing.Size(0, 13);
            this.wrnlbl1.TabIndex = 6;
            // 
            // wrnlbl2
            // 
            this.wrnlbl2.AutoSize = true;
            this.wrnlbl2.ForeColor = System.Drawing.Color.Red;
            this.wrnlbl2.Location = new System.Drawing.Point(278, 47);
            this.wrnlbl2.Name = "wrnlbl2";
            this.wrnlbl2.Size = new System.Drawing.Size(0, 13);
            this.wrnlbl2.TabIndex = 7;
            // 
            // wrnlbl3
            // 
            this.wrnlbl3.AutoSize = true;
            this.wrnlbl3.ForeColor = System.Drawing.Color.Red;
            this.wrnlbl3.Location = new System.Drawing.Point(278, 88);
            this.wrnlbl3.Name = "wrnlbl3";
            this.wrnlbl3.Size = new System.Drawing.Size(0, 13);
            this.wrnlbl3.TabIndex = 8;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(203, 238);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(142, 68);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 343);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.wrnlbl3);
            this.Controls.Add(this.wrnlbl2);
            this.Controls.Add(this.wrnlbl1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtbResult);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.labLado3);
            this.Controls.Add(this.labLado2);
            this.Controls.Add(this.labLado1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLado1;
        private System.Windows.Forms.Label labLado2;
        private System.Windows.Forms.Label labLado3;
        private System.Windows.Forms.Label labResultado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtbResult;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label wrnlbl1;
        private System.Windows.Forms.Label wrnlbl2;
        private System.Windows.Forms.Label wrnlbl3;
        private System.Windows.Forms.Button btnLimpar;
    }
}

