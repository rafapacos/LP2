namespace Atividade5 {
    partial class Exercicio4 {
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnCharNum = new System.Windows.Forms.Button();
            this.btnWhiteWord = new System.Windows.Forms.Button();
            this.btnCharAlpha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(112, 28);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(591, 245);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnCharNum
            // 
            this.btnCharNum.Location = new System.Drawing.Point(112, 291);
            this.btnCharNum.Name = "btnCharNum";
            this.btnCharNum.Size = new System.Drawing.Size(108, 72);
            this.btnCharNum.TabIndex = 1;
            this.btnCharNum.Text = "Caracteres Numericos";
            this.btnCharNum.UseVisualStyleBackColor = true;
            this.btnCharNum.Click += new System.EventHandler(this.btnCharNum_Click);
            // 
            // btnWhiteWord
            // 
            this.btnWhiteWord.Location = new System.Drawing.Point(328, 291);
            this.btnWhiteWord.Name = "btnWhiteWord";
            this.btnWhiteWord.Size = new System.Drawing.Size(108, 72);
            this.btnWhiteWord.TabIndex = 2;
            this.btnWhiteWord.Text = "Palavra Branco";
            this.btnWhiteWord.UseVisualStyleBackColor = true;
            this.btnWhiteWord.Click += new System.EventHandler(this.btnWhiteWord_Click);
            // 
            // btnCharAlpha
            // 
            this.btnCharAlpha.Location = new System.Drawing.Point(534, 291);
            this.btnCharAlpha.Name = "btnCharAlpha";
            this.btnCharAlpha.Size = new System.Drawing.Size(108, 72);
            this.btnCharAlpha.TabIndex = 3;
            this.btnCharAlpha.Text = "Caracteres Alfabeticos";
            this.btnCharAlpha.UseVisualStyleBackColor = true;
            this.btnCharAlpha.Click += new System.EventHandler(this.btnCharAlpha_Click);
            // 
            // Exercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCharAlpha);
            this.Controls.Add(this.btnWhiteWord);
            this.Controls.Add(this.btnCharNum);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "Exercicio4";
            this.Text = "Exercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnCharNum;
        private System.Windows.Forms.Button btnWhiteWord;
        private System.Windows.Forms.Button btnCharAlpha;
    }
}