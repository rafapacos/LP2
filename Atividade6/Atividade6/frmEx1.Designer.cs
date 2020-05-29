namespace Atividade6 {
    partial class frmEx1 {
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
            this.btnWhiteSpace = new System.Windows.Forms.Button();
            this.btnLetterR = new System.Windows.Forms.Button();
            this.btnLetterPair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(21, 12);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(753, 276);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnWhiteSpace
            // 
            this.btnWhiteSpace.Location = new System.Drawing.Point(74, 305);
            this.btnWhiteSpace.Name = "btnWhiteSpace";
            this.btnWhiteSpace.Size = new System.Drawing.Size(135, 77);
            this.btnWhiteSpace.TabIndex = 1;
            this.btnWhiteSpace.Text = "Número de Espaços em Branco";
            this.btnWhiteSpace.UseVisualStyleBackColor = true;
            this.btnWhiteSpace.Click += new System.EventHandler(this.btnWhiteSpace_Click);
            // 
            // btnLetterR
            // 
            this.btnLetterR.Location = new System.Drawing.Point(323, 305);
            this.btnLetterR.Name = "btnLetterR";
            this.btnLetterR.Size = new System.Drawing.Size(135, 77);
            this.btnLetterR.TabIndex = 2;
            this.btnLetterR.Text = "Número de letras \"R\"";
            this.btnLetterR.UseVisualStyleBackColor = true;
            this.btnLetterR.Click += new System.EventHandler(this.btnLetterR_Click);
            // 
            // btnLetterPair
            // 
            this.btnLetterPair.Location = new System.Drawing.Point(562, 305);
            this.btnLetterPair.Name = "btnLetterPair";
            this.btnLetterPair.Size = new System.Drawing.Size(135, 77);
            this.btnLetterPair.TabIndex = 3;
            this.btnLetterPair.Text = "Número de Par de Letras";
            this.btnLetterPair.UseVisualStyleBackColor = true;
            this.btnLetterPair.Click += new System.EventHandler(this.btnLetterPair_Click);
            // 
            // frmEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLetterPair);
            this.Controls.Add(this.btnLetterR);
            this.Controls.Add(this.btnWhiteSpace);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmEx1";
            this.Text = "frmEx1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnWhiteSpace;
        private System.Windows.Forms.Button btnLetterR;
        private System.Windows.Forms.Button btnLetterPair;
    }
}