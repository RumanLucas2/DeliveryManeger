namespace Project
{
    partial class IniPedido
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
            this.avançar = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.pesquisar = new System.Windows.Forms.Button();
            this.escrita = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TextoCliente = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Alterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // avançar
            // 
            this.avançar.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avançar.Location = new System.Drawing.Point(818, 681);
            this.avançar.Margin = new System.Windows.Forms.Padding(4);
            this.avançar.Name = "avançar";
            this.avançar.Size = new System.Drawing.Size(220, 88);
            this.avançar.TabIndex = 3;
            this.avançar.Text = "button1";
            this.avançar.UseVisualStyleBackColor = true;
            this.avançar.Click += new System.EventHandler(this.Procurar_Click);
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F);
            this.voltar.Location = new System.Drawing.Point(1043, 681);
            this.voltar.Margin = new System.Windows.Forms.Padding(4);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(150, 88);
            this.voltar.TabIndex = 5;
            this.voltar.Text = "button1";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // pesquisar
            // 
            this.pesquisar.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F);
            this.pesquisar.Image = global::Project.Properties.Resources.lupa__1_;
            this.pesquisar.Location = new System.Drawing.Point(436, 102);
            this.pesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(40, 40);
            this.pesquisar.TabIndex = 2;
            this.pesquisar.UseVisualStyleBackColor = true;
            this.pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // escrita
            // 
            this.escrita.AutoSize = true;
            this.escrita.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F);
            this.escrita.Location = new System.Drawing.Point(18, 108);
            this.escrita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.escrita.Name = "escrita";
            this.escrita.Size = new System.Drawing.Size(110, 35);
            this.escrita.TabIndex = 0;
            this.escrita.Text = "Telefone:";
            // 
            // TextoCliente
            // 
            this.TextoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextoCliente.ForeColor = System.Drawing.Color.Black;
            this.TextoCliente.Location = new System.Drawing.Point(112, 195);
            this.TextoCliente.Margin = new System.Windows.Forms.Padding(6);
            this.TextoCliente.Multiline = true;
            this.TextoCliente.Name = "TextoCliente";
            this.TextoCliente.ReadOnly = true;
            this.TextoCliente.Size = new System.Drawing.Size(537, 250);
            this.TextoCliente.TabIndex = 6;
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(111, 105);
            this.Telefone.Mask = "(00) 99999-0000";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(318, 41);
            this.Telefone.TabIndex = 1;
            // 
            // Alterar
            // 
            this.Alterar.CausesValidation = false;
            this.Alterar.Location = new System.Drawing.Point(643, 681);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(168, 88);
            this.Alterar.TabIndex = 7;
            this.Alterar.Text = "button1";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // IniPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1214, 793);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.TextoCliente);
            this.Controls.Add(this.escrita);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.avançar);
            this.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IniPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void press(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void enter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button avançar;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Label escrita;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox TextoCliente;
        private System.Windows.Forms.MaskedTextBox Telefone;
        public System.Windows.Forms.Button Alterar;
    }
}