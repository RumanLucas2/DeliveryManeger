namespace Project
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.Voltar = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.FichaLabel = new System.Windows.Forms.Label();
            this.CepLabel = new System.Windows.Forms.Label();
            this.TellLabel = new System.Windows.Forms.Label();
            this.CPFLabel = new System.Windows.Forms.Label();
            this.CPFCheck = new System.Windows.Forms.CheckBox();
            this.ComplementoLabel = new System.Windows.Forms.Label();
            this.Complemento = new System.Windows.Forms.TextBox();
            this.NumeroLabel = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.TextBox();
            this.Endereço = new System.Windows.Forms.TextBox();
            this.NiverText = new System.Windows.Forms.Label();
            this.Aniversario = new System.Windows.Forms.MaskedTextBox();
            this.Telefone = new System.Windows.Forms.MaskedTextBox();
            this.CPF = new System.Windows.Forms.MaskedTextBox();
            this.Cep = new System.Windows.Forms.MaskedTextBox();
            this.Warning = new System.Windows.Forms.Label();
            this.aux = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(12, 668);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(150, 88);
            this.Voltar.TabIndex = 9;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(1052, 668);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(150, 88);
            this.Salvar.TabIndex = 9;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // NomeLabel
            // 
            this.NomeLabel.AutoSize = true;
            this.NomeLabel.Location = new System.Drawing.Point(12, 59);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(86, 35);
            this.NomeLabel.TabIndex = 3;
            this.NomeLabel.Text = "Nome:";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(87, 56);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(1102, 41);
            this.Nome.TabIndex = 0;
            this.Nome.Enter += new System.EventHandler(this.Nome_Enter);
            // 
            // FichaLabel
            // 
            this.FichaLabel.AutoSize = true;
            this.FichaLabel.Location = new System.Drawing.Point(12, 9);
            this.FichaLabel.Name = "FichaLabel";
            this.FichaLabel.Size = new System.Drawing.Size(189, 35);
            this.FichaLabel.TabIndex = 1;
            this.FichaLabel.Text = "Ficha do Cliente";
            // 
            // CepLabel
            // 
            this.CepLabel.AutoSize = true;
            this.CepLabel.Location = new System.Drawing.Point(12, 170);
            this.CepLabel.Name = "CepLabel";
            this.CepLabel.Size = new System.Drawing.Size(63, 35);
            this.CepLabel.TabIndex = 5;
            this.CepLabel.Text = "Cep:";
            // 
            // TellLabel
            // 
            this.TellLabel.AutoSize = true;
            this.TellLabel.Location = new System.Drawing.Point(15, 116);
            this.TellLabel.Name = "TellLabel";
            this.TellLabel.Size = new System.Drawing.Size(110, 35);
            this.TellLabel.TabIndex = 7;
            this.TellLabel.Text = "Telefone:";
            // 
            // CPFLabel
            // 
            this.CPFLabel.AutoSize = true;
            this.CPFLabel.Location = new System.Drawing.Point(324, 116);
            this.CPFLabel.Name = "CPFLabel";
            this.CPFLabel.Size = new System.Drawing.Size(62, 35);
            this.CPFLabel.TabIndex = 11;
            this.CPFLabel.Text = "CPF:";
            // 
            // CPFCheck
            // 
            this.CPFCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CPFCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.CPFCheck.BackColor = System.Drawing.Color.Snow;
            this.CPFCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CPFCheck.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CPFCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CPFCheck.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CPFCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CPFCheck.Font = new System.Drawing.Font("Nirmala UI Semilight", 18F);
            this.CPFCheck.ForeColor = System.Drawing.Color.LightSlateGray;
            this.CPFCheck.Location = new System.Drawing.Point(381, 109);
            this.CPFCheck.Margin = new System.Windows.Forms.Padding(5);
            this.CPFCheck.Name = "CPFCheck";
            this.CPFCheck.Size = new System.Drawing.Size(40, 40);
            this.CPFCheck.TabIndex = 10;
            this.CPFCheck.Text = "✗";
            this.CPFCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CPFCheck.UseVisualStyleBackColor = false;
            this.CPFCheck.CheckedChanged += new System.EventHandler(this.CPFCheck_CheckedChanged);
            // 
            // ComplementoLabel
            // 
            this.ComplementoLabel.AutoSize = true;
            this.ComplementoLabel.Location = new System.Drawing.Point(232, 173);
            this.ComplementoLabel.Name = "ComplementoLabel";
            this.ComplementoLabel.Size = new System.Drawing.Size(174, 35);
            this.ComplementoLabel.TabIndex = 14;
            this.ComplementoLabel.Text = "Complemento:";
            // 
            // Complemento
            // 
            this.Complemento.Location = new System.Drawing.Point(363, 170);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(826, 41);
            this.Complemento.TabIndex = 5;
            // 
            // NumeroLabel
            // 
            this.NumeroLabel.AutoSize = true;
            this.NumeroLabel.Location = new System.Drawing.Point(12, 231);
            this.NumeroLabel.Name = "NumeroLabel";
            this.NumeroLabel.Size = new System.Drawing.Size(108, 35);
            this.NumeroLabel.TabIndex = 16;
            this.NumeroLabel.Text = "Numero:";
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(96, 228);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(160, 41);
            this.Numero.TabIndex = 6;
            // 
            // Endereço
            // 
            this.Endereço.BackColor = System.Drawing.SystemColors.Control;
            this.Endereço.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Endereço.Location = new System.Drawing.Point(12, 373);
            this.Endereço.Multiline = true;
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(435, 289);
            this.Endereço.TabIndex = 18;
            this.Endereço.Text = "\r\n";
            // 
            // NiverText
            // 
            this.NiverText.AutoSize = true;
            this.NiverText.Location = new System.Drawing.Point(711, 116);
            this.NiverText.Name = "NiverText";
            this.NiverText.Size = new System.Drawing.Size(140, 35);
            this.NiverText.TabIndex = 21;
            this.NiverText.Text = "Aniversário:";
            // 
            // Aniversario
            // 
            this.Aniversario.Location = new System.Drawing.Point(818, 112);
            this.Aniversario.Mask = "00/00";
            this.Aniversario.Name = "Aniversario";
            this.Aniversario.Size = new System.Drawing.Size(348, 41);
            this.Aniversario.TabIndex = 3;
            this.Aniversario.Click += new System.EventHandler(this.Aniversario_Click);
            this.Aniversario.Enter += new System.EventHandler(this.Aniversario_Enter);
            // 
            // Telefone
            // 
            this.Telefone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.Telefone.Location = new System.Drawing.Point(104, 112);
            this.Telefone.Mask = "(00) 00000-0000";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(152, 41);
            this.Telefone.TabIndex = 1;
            this.Telefone.Enter += new System.EventHandler(this.Telefone_Enter);
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(429, 112);
            this.CPF.Mask = "999,000,999-00";
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(193, 41);
            this.CPF.TabIndex = 2;
            this.CPF.Click += new System.EventHandler(this.CPF_Click);
            this.CPF.Enter += new System.EventHandler(this.CPF_Enter);
            // 
            // Cep
            // 
            this.Cep.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Cep.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.Cep.Location = new System.Drawing.Point(58, 170);
            this.Cep.Mask = "00000-000";
            this.Cep.Name = "Cep";
            this.Cep.Size = new System.Drawing.Size(168, 41);
            this.Cep.TabIndex = 4;
            this.Cep.UseWaitCursor = true;
            this.Cep.Click += new System.EventHandler(this.Cep_Click);
            this.Cep.Enter += new System.EventHandler(this.Cep_Enter);
            this.Cep.Leave += new System.EventHandler(this.CepLeave);
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.ForeColor = System.Drawing.Color.Red;
            this.Warning.Location = new System.Drawing.Point(20, 281);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(0, 35);
            this.Warning.TabIndex = 31;
            // 
            // aux
            // 
            this.aux.AutoSize = true;
            this.aux.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.aux.Location = new System.Drawing.Point(363, 211);
            this.aux.Name = "aux";
            this.aux.Size = new System.Drawing.Size(534, 35);
            this.aux.TabIndex = 32;
            this.aux.Text = "Deixe o complemento em branco se não houver";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 768);
            this.Controls.Add(this.aux);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.Cep);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Aniversario);
            this.Controls.Add(this.NiverText);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.Complemento);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.NumeroLabel);
            this.Controls.Add(this.ComplementoLabel);
            this.Controls.Add(this.CPFCheck);
            this.Controls.Add(this.CPFLabel);
            this.Controls.Add(this.TellLabel);
            this.Controls.Add(this.CepLabel);
            this.Controls.Add(this.FichaLabel);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.NomeLabel);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Voltar);
            this.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Cadastro";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label FichaLabel;
        private System.Windows.Forms.Label CepLabel;
        private System.Windows.Forms.Label TellLabel;
        private System.Windows.Forms.Label CPFLabel;
        public System.Windows.Forms.CheckBox CPFCheck;
        private System.Windows.Forms.Label ComplementoLabel;
        private System.Windows.Forms.TextBox Complemento;
        private System.Windows.Forms.Label NumeroLabel;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.TextBox Endereço;
        private System.Windows.Forms.Label NiverText;
        private System.Windows.Forms.MaskedTextBox Aniversario;
        private System.Windows.Forms.MaskedTextBox Telefone;
        private System.Windows.Forms.MaskedTextBox CPF;
        private System.Windows.Forms.MaskedTextBox Cep;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.Label aux;
    }
}