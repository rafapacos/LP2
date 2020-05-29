namespace Atividade6 {
    partial class frmEx4 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtbFunc = new System.Windows.Forms.MaskedTextBox();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblGrat = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblProducao = new System.Windows.Forms.Label();
            this.lblInscricao = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtCargo = new System.Windows.Forms.MaskedTextBox();
            this.txtInscricao = new System.Windows.Forms.MaskedTextBox();
            this.txtProducao = new System.Windows.Forms.MaskedTextBox();
            this.txtSalBase = new System.Windows.Forms.MaskedTextBox();
            this.txtGratificacao = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtbFunc
            // 
            this.txtbFunc.Location = new System.Drawing.Point(199, 21);
            this.txtbFunc.Name = "txtbFunc";
            this.txtbFunc.Size = new System.Drawing.Size(155, 20);
            this.txtbFunc.TabIndex = 31;
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBruto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSalBruto.Location = new System.Drawing.Point(83, 334);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(103, 17);
            this.lblSalBruto.TabIndex = 28;
            this.lblSalBruto.Text = "Salario Bruto";
            // 
            // lblGrat
            // 
            this.lblGrat.AutoSize = true;
            this.lblGrat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGrat.Location = new System.Drawing.Point(94, 218);
            this.lblGrat.Name = "lblGrat";
            this.lblGrat.Size = new System.Drawing.Size(69, 13);
            this.lblGrat.TabIndex = 26;
            this.lblGrat.Text = "Gratificações";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSalario.Location = new System.Drawing.Point(97, 178);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(66, 13);
            this.lblSalario.TabIndex = 25;
            this.lblSalario.Text = "Salario Base";
            // 
            // lblProducao
            // 
            this.lblProducao.AutoSize = true;
            this.lblProducao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProducao.Location = new System.Drawing.Point(110, 137);
            this.lblProducao.Name = "lblProducao";
            this.lblProducao.Size = new System.Drawing.Size(53, 13);
            this.lblProducao.TabIndex = 24;
            this.lblProducao.Text = "Produção";
            // 
            // lblInscricao
            // 
            this.lblInscricao.AutoSize = true;
            this.lblInscricao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInscricao.Location = new System.Drawing.Point(83, 98);
            this.lblInscricao.Name = "lblInscricao";
            this.lblInscricao.Size = new System.Drawing.Size(80, 13);
            this.lblInscricao.TabIndex = 23;
            this.lblInscricao.Text = "Nº de Inscrição";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCargo.Location = new System.Drawing.Point(128, 63);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 30;
            this.lblCargo.Text = "Cargo";
            this.lblCargo.Click += new System.EventHandler(this.lblCargo_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNome.Location = new System.Drawing.Point(55, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(108, 13);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Nome do Funcionário";
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Location = new System.Drawing.Point(190, 333);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(155, 20);
            this.txtSalBruto.TabIndex = 45;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(175, 256);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(179, 38);
            this.btnCalc.TabIndex = 46;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(199, 60);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(155, 20);
            this.txtCargo.TabIndex = 47;
            // 
            // txtInscricao
            // 
            this.txtInscricao.Location = new System.Drawing.Point(199, 95);
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.Size = new System.Drawing.Size(155, 20);
            this.txtInscricao.TabIndex = 48;
            // 
            // txtProducao
            // 
            this.txtProducao.Location = new System.Drawing.Point(199, 134);
            this.txtProducao.Name = "txtProducao";
            this.txtProducao.Size = new System.Drawing.Size(155, 20);
            this.txtProducao.TabIndex = 49;
            // 
            // txtSalBase
            // 
            this.txtSalBase.Location = new System.Drawing.Point(199, 175);
            this.txtSalBase.Name = "txtSalBase";
            this.txtSalBase.Size = new System.Drawing.Size(155, 20);
            this.txtSalBase.TabIndex = 50;
            // 
            // txtGratificacao
            // 
            this.txtGratificacao.Location = new System.Drawing.Point(199, 215);
            this.txtGratificacao.Name = "txtGratificacao";
            this.txtGratificacao.Size = new System.Drawing.Size(155, 20);
            this.txtGratificacao.TabIndex = 51;
            // 
            // frmEx4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.txtGratificacao);
            this.Controls.Add(this.txtSalBase);
            this.Controls.Add(this.txtProducao);
            this.Controls.Add(this.txtInscricao);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.txtbFunc);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblGrat);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblProducao);
            this.Controls.Add(this.lblInscricao);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.Name = "frmEx4";
            this.Text = "frmEx4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtbFunc;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblGrat;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblProducao;
        private System.Windows.Forms.Label lblInscricao;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox txtSalBruto;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.MaskedTextBox txtCargo;
        private System.Windows.Forms.MaskedTextBox txtInscricao;
        private System.Windows.Forms.MaskedTextBox txtProducao;
        private System.Windows.Forms.MaskedTextBox txtSalBase;
        private System.Windows.Forms.MaskedTextBox txtGratificacao;
    }
}