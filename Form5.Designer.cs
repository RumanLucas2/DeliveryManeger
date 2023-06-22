namespace Project
{
    partial class VerLista
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
            this.Remov = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.DataGridView();
            this.VoltarAçao = new System.Windows.Forms.Button();
            this.aviso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // Remov
            // 
            this.Remov.Location = new System.Drawing.Point(190, 661);
            this.Remov.Name = "Remov";
            this.Remov.Size = new System.Drawing.Size(170, 85);
            this.Remov.TabIndex = 1;
            this.Remov.Text = "Remover";
            this.Remov.UseVisualStyleBackColor = true;
            this.Remov.Click += new System.EventHandler(this.Remov_Click);
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(14, 660);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(170, 85);
            this.Voltar.TabIndex = 3;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Lista
            // 
            this.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lista.Location = new System.Drawing.Point(13, 13);
            this.Lista.Name = "Lista";
            this.Lista.RowHeadersWidth = 51;
            this.Lista.Size = new System.Drawing.Size(982, 642);
            this.Lista.TabIndex = 4;
            // 
            // VoltarAçao
            // 
            this.VoltarAçao.Location = new System.Drawing.Point(366, 661);
            this.VoltarAçao.Name = "VoltarAçao";
            this.VoltarAçao.Size = new System.Drawing.Size(170, 85);
            this.VoltarAçao.TabIndex = 7;
            this.VoltarAçao.Text = "Voltar remoção";
            this.VoltarAçao.Click += new System.EventHandler(this.VoltarAçao_Click);
            // 
            // aviso
            // 
            this.aviso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aviso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aviso.ForeColor = System.Drawing.Color.Red;
            this.aviso.Location = new System.Drawing.Point(1001, 13);
            this.aviso.Multiline = true;
            this.aviso.Name = "aviso";
            this.aviso.ReadOnly = true;
            this.aviso.Size = new System.Drawing.Size(454, 77);
            this.aviso.TabIndex = 8;
            // 
            // VerLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1214, 768);
            this.Controls.Add(this.aviso);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.VoltarAçao);
            this.Controls.Add(this.Remov);
            this.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "VerLista";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.VerLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Remov;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.DataGridView Lista;
        private System.Windows.Forms.Button VoltarAçao;
        private System.Windows.Forms.TextBox aviso;
    }
}