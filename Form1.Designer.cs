using System;

namespace Project
{
    partial class Inicio
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
            this.ButtonPedidos = new System.Windows.Forms.Button();
            this.OFF = new System.Windows.Forms.Button();
            this.configuração = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonPedidos
            // 
            this.ButtonPedidos.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F);
            this.ButtonPedidos.Location = new System.Drawing.Point(198, 178);
            this.ButtonPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPedidos.Name = "ButtonPedidos";
            this.ButtonPedidos.Size = new System.Drawing.Size(219, 331);
            this.ButtonPedidos.TabIndex = 0;
            this.ButtonPedidos.Text = "button1";
            this.ButtonPedidos.UseVisualStyleBackColor = true;
            this.ButtonPedidos.Click += new System.EventHandler(this.ButtonPedidos_Click);
            // 
            // OFF
            // 
            this.OFF.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F);
            this.OFF.Location = new System.Drawing.Point(1011, 689);
            this.OFF.Margin = new System.Windows.Forms.Padding(2);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(143, 74);
            this.OFF.TabIndex = 1;
            this.OFF.Text = "button1";
            this.OFF.UseVisualStyleBackColor = true;
            this.OFF.Click += new System.EventHandler(this.OFF_Click);
            // 
            // configuração
            // 
            this.configuração.Image = global::Project.Properties.Resources.engrenagem;
            this.configuração.Location = new System.Drawing.Point(1078, 12);
            this.configuração.Name = "configuração";
            this.configuração.Size = new System.Drawing.Size(75, 75);
            this.configuração.TabIndex = 2;
            this.configuração.UseVisualStyleBackColor = true;
            this.configuração.Click += new System.EventHandler(this.Configuração_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 774);
            this.Controls.Add(this.configuração);
            this.Controls.Add(this.OFF);
            this.Controls.Add(this.ButtonPedidos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonPedidos;
        private System.Windows.Forms.Button OFF;
        private System.Windows.Forms.Button configuração;
    }
}

