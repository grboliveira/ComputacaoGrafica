﻿namespace TPCG
{
    partial class tela
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
            this.imagem = new System.Windows.Forms.PictureBox();
            this.painel = new System.Windows.Forms.Panel();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lbY = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.cdlg = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            this.painel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagem
            // 
            this.imagem.BackColor = System.Drawing.Color.White;
            this.imagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagem.Location = new System.Drawing.Point(0, 0);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(837, 572);
            this.imagem.TabIndex = 0;
            this.imagem.TabStop = false;
            this.imagem.Click += new System.EventHandler(this.imagem_Click);
            // 
            // painel
            // 
            this.painel.Controls.Add(this.txtY);
            this.painel.Controls.Add(this.txtX);
            this.painel.Controls.Add(this.lbY);
            this.painel.Controls.Add(this.lbX);
            this.painel.Dock = System.Windows.Forms.DockStyle.Right;
            this.painel.Location = new System.Drawing.Point(699, 0);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(138, 572);
            this.painel.TabIndex = 1;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(29, 85);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(68, 20);
            this.txtY.TabIndex = 4;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(29, 46);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(68, 20);
            this.txtX.TabIndex = 3;
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(26, 69);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(20, 13);
            this.lbY.TabIndex = 2;
            this.lbY.Text = "Y1";
            this.lbY.Click += new System.EventHandler(this.lbY_Click);
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(26, 29);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(20, 13);
            this.lbX.TabIndex = 1;
            this.lbX.Text = "X1";
            // 
            // tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 572);
            this.Controls.Add(this.painel);
            this.Controls.Add(this.imagem);
            this.Name = "tela";
            this.Text = "Manipulação Imagem";
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.ColorDialog cdlg;
    }
}

