﻿namespace Atividade7 {
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
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnEx4 = new System.Windows.Forms.Button();
            this.btnEx5 = new System.Windows.Forms.Button();
            this.btnEx6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEx1
            // 
            this.btnEx1.Location = new System.Drawing.Point(76, 52);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(162, 75);
            this.btnEx1.TabIndex = 0;
            this.btnEx1.Text = "Ler 20 números e inverter";
            this.btnEx1.UseVisualStyleBackColor = true;
            this.btnEx1.Click += new System.EventHandler(this.btnEx1_Click);
            // 
            // btnEx2
            // 
            this.btnEx2.Location = new System.Drawing.Point(325, 52);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(162, 75);
            this.btnEx2.TabIndex = 1;
            this.btnEx2.Text = "Ler 20 números e inverter (Reverse)";
            this.btnEx2.UseVisualStyleBackColor = true;
            this.btnEx2.Click += new System.EventHandler(this.btnEx2_Click);
            // 
            // btnEx3
            // 
            this.btnEx3.Location = new System.Drawing.Point(76, 170);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(162, 75);
            this.btnEx3.TabIndex = 2;
            this.btnEx3.Text = "Faturamento de Produtos";
            this.btnEx3.UseVisualStyleBackColor = true;
            this.btnEx3.Click += new System.EventHandler(this.btnEx3_Click);
            // 
            // btnEx4
            // 
            this.btnEx4.Location = new System.Drawing.Point(325, 170);
            this.btnEx4.Name = "btnEx4";
            this.btnEx4.Size = new System.Drawing.Size(162, 75);
            this.btnEx4.TabIndex = 3;
            this.btnEx4.Text = "Excluir Otávio";
            this.btnEx4.UseVisualStyleBackColor = true;
            this.btnEx4.Click += new System.EventHandler(this.btnEx4_Click);
            // 
            // btnEx5
            // 
            this.btnEx5.Location = new System.Drawing.Point(76, 286);
            this.btnEx5.Name = "btnEx5";
            this.btnEx5.Size = new System.Drawing.Size(162, 75);
            this.btnEx5.TabIndex = 4;
            this.btnEx5.Text = "Médias Alunos";
            this.btnEx5.UseVisualStyleBackColor = true;
            this.btnEx5.Click += new System.EventHandler(this.btnEx5_Click);
            // 
            // btnEx6
            // 
            this.btnEx6.Location = new System.Drawing.Point(325, 286);
            this.btnEx6.Name = "btnEx6";
            this.btnEx6.Size = new System.Drawing.Size(162, 75);
            this.btnEx6.TabIndex = 5;
            this.btnEx6.Text = "Contar Caracteres";
            this.btnEx6.UseVisualStyleBackColor = true;
            this.btnEx6.Click += new System.EventHandler(this.btnEx6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.btnEx6);
            this.Controls.Add(this.btnEx5);
            this.Controls.Add(this.btnEx4);
            this.Controls.Add(this.btnEx3);
            this.Controls.Add(this.btnEx2);
            this.Controls.Add(this.btnEx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnEx4;
        private System.Windows.Forms.Button btnEx5;
        private System.Windows.Forms.Button btnEx6;
    }
}

