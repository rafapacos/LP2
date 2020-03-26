namespace Atividade4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblSalFam = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.txtbFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtbSalB = new System.Windows.Forms.MaskedTextBox();
            this.txtbFilhos = new System.Windows.Forms.MaskedTextBox();
            this.txtbINSS = new System.Windows.Forms.MaskedTextBox();
            this.txtbIRPF = new System.Windows.Forms.MaskedTextBox();
            this.txtbSalFam = new System.Windows.Forms.MaskedTextBox();
            this.txtbSalLiq = new System.Windows.Forms.MaskedTextBox();
            this.txtbDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.txtbDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.grpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbtFem = new System.Windows.Forms.RadioButton();
            this.rdbtMasc = new System.Windows.Forms.RadioButton();
            this.btnVerifDesc = new System.Windows.Forms.Button();
            this.checkbCasado = new System.Windows.Forms.CheckBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.grpbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            resources.ApplyResources(this.lblNome, "lblNome");
            this.lblNome.Name = "lblNome";
            // 
            // lblSal
            // 
            resources.ApplyResources(this.lblSal, "lblSal");
            this.lblSal.Name = "lblSal";
            // 
            // lblFilhos
            // 
            resources.ApplyResources(this.lblFilhos, "lblFilhos");
            this.lblFilhos.Name = "lblFilhos";
            // 
            // lblINSS
            // 
            resources.ApplyResources(this.lblINSS, "lblINSS");
            this.lblINSS.Name = "lblINSS";
            // 
            // lblIRPF
            // 
            resources.ApplyResources(this.lblIRPF, "lblIRPF");
            this.lblIRPF.Name = "lblIRPF";
            // 
            // lblSalFam
            // 
            resources.ApplyResources(this.lblSalFam, "lblSalFam");
            this.lblSalFam.Name = "lblSalFam";
            // 
            // lblSalLiq
            // 
            resources.ApplyResources(this.lblSalLiq, "lblSalLiq");
            this.lblSalLiq.Name = "lblSalLiq";
            // 
            // lblDescINSS
            // 
            resources.ApplyResources(this.lblDescINSS, "lblDescINSS");
            this.lblDescINSS.Name = "lblDescINSS";
            // 
            // lblDescIRPF
            // 
            resources.ApplyResources(this.lblDescIRPF, "lblDescIRPF");
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Click += new System.EventHandler(this.lblDescIRPF_Click);
            // 
            // txtbFunc
            // 
            resources.ApplyResources(this.txtbFunc, "txtbFunc");
            this.txtbFunc.Name = "txtbFunc";
            // 
            // txtbSalB
            // 
            resources.ApplyResources(this.txtbSalB, "txtbSalB");
            this.txtbSalB.Name = "txtbSalB";
            // 
            // txtbFilhos
            // 
            resources.ApplyResources(this.txtbFilhos, "txtbFilhos");
            this.txtbFilhos.Name = "txtbFilhos";
            // 
            // txtbINSS
            // 
            resources.ApplyResources(this.txtbINSS, "txtbINSS");
            this.txtbINSS.Name = "txtbINSS";
            // 
            // txtbIRPF
            // 
            resources.ApplyResources(this.txtbIRPF, "txtbIRPF");
            this.txtbIRPF.Name = "txtbIRPF";
            // 
            // txtbSalFam
            // 
            resources.ApplyResources(this.txtbSalFam, "txtbSalFam");
            this.txtbSalFam.Name = "txtbSalFam";
            // 
            // txtbSalLiq
            // 
            resources.ApplyResources(this.txtbSalLiq, "txtbSalLiq");
            this.txtbSalLiq.Name = "txtbSalLiq";
            // 
            // txtbDescIRPF
            // 
            resources.ApplyResources(this.txtbDescIRPF, "txtbDescIRPF");
            this.txtbDescIRPF.Name = "txtbDescIRPF";
            // 
            // txtbDescINSS
            // 
            resources.ApplyResources(this.txtbDescINSS, "txtbDescINSS");
            this.txtbDescINSS.Name = "txtbDescINSS";
            // 
            // grpbSexo
            // 
            this.grpbSexo.Controls.Add(this.rdbtFem);
            this.grpbSexo.Controls.Add(this.rdbtMasc);
            resources.ApplyResources(this.grpbSexo, "grpbSexo");
            this.grpbSexo.Name = "grpbSexo";
            this.grpbSexo.TabStop = false;
            // 
            // rdbtFem
            // 
            resources.ApplyResources(this.rdbtFem, "rdbtFem");
            this.rdbtFem.Name = "rdbtFem";
            this.rdbtFem.TabStop = true;
            this.rdbtFem.UseVisualStyleBackColor = true;
            // 
            // rdbtMasc
            // 
            resources.ApplyResources(this.rdbtMasc, "rdbtMasc");
            this.rdbtMasc.Name = "rdbtMasc";
            this.rdbtMasc.TabStop = true;
            this.rdbtMasc.UseVisualStyleBackColor = true;
            // 
            // btnVerifDesc
            // 
            resources.ApplyResources(this.btnVerifDesc, "btnVerifDesc");
            this.btnVerifDesc.Name = "btnVerifDesc";
            this.btnVerifDesc.UseVisualStyleBackColor = true;
            this.btnVerifDesc.Click += new System.EventHandler(this.btnVerifDesc_Click);
            // 
            // checkbCasado
            // 
            resources.ApplyResources(this.checkbCasado, "checkbCasado");
            this.checkbCasado.Name = "checkbCasado";
            this.checkbCasado.UseVisualStyleBackColor = true;
            // 
            // lblDados
            // 
            resources.ApplyResources(this.lblDados, "lblDados");
            this.lblDados.BackColor = System.Drawing.Color.White;
            this.lblDados.Name = "lblDados";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.checkbCasado);
            this.Controls.Add(this.btnVerifDesc);
            this.Controls.Add(this.grpbSexo);
            this.Controls.Add(this.txtbDescINSS);
            this.Controls.Add(this.txtbDescIRPF);
            this.Controls.Add(this.txtbSalLiq);
            this.Controls.Add(this.txtbSalFam);
            this.Controls.Add(this.txtbIRPF);
            this.Controls.Add(this.txtbINSS);
            this.Controls.Add(this.txtbFilhos);
            this.Controls.Add(this.txtbSalB);
            this.Controls.Add(this.txtbFunc);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblSalFam);
            this.Controls.Add(this.lblIRPF);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.grpbSexo.ResumeLayout(false);
            this.grpbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblSalFam;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.MaskedTextBox txtbFunc;
        private System.Windows.Forms.MaskedTextBox txtbSalB;
        private System.Windows.Forms.MaskedTextBox txtbFilhos;
        private System.Windows.Forms.MaskedTextBox txtbINSS;
        private System.Windows.Forms.MaskedTextBox txtbIRPF;
        private System.Windows.Forms.MaskedTextBox txtbSalFam;
        private System.Windows.Forms.MaskedTextBox txtbSalLiq;
        private System.Windows.Forms.MaskedTextBox txtbDescIRPF;
        private System.Windows.Forms.MaskedTextBox txtbDescINSS;
        private System.Windows.Forms.GroupBox grpbSexo;
        private System.Windows.Forms.RadioButton rdbtFem;
        private System.Windows.Forms.RadioButton rdbtMasc;
        private System.Windows.Forms.Button btnVerifDesc;
        private System.Windows.Forms.CheckBox checkbCasado;
        private System.Windows.Forms.Label lblDados;
    }
}

