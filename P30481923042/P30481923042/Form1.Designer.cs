﻿namespace P30481923042 {
    partial class Form1 {
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
            this.lboxFaturamentos = new System.Windows.Forms.ListBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxFaturamentos
            // 
            this.lboxFaturamentos.FormattingEnabled = true;
            this.lboxFaturamentos.Location = new System.Drawing.Point(480, 17);
            this.lboxFaturamentos.Name = "lboxFaturamentos";
            this.lboxFaturamentos.Size = new System.Drawing.Size(308, 420);
            this.lboxFaturamentos.TabIndex = 0;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(114, 156);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(154, 99);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lboxFaturamentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxFaturamentos;
        private System.Windows.Forms.Button btnVerificar;
    }
}

