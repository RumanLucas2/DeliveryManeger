using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Project
{
    partial class Pedido
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.voltar = new System.Windows.Forms.Button();
            this.NomeTXT = new System.Windows.Forms.TextBox();
            this.PreçoTXT = new System.Windows.Forms.TextBox();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.PreçoLabel = new System.Windows.Forms.Label();
            this.qttLabel = new System.Windows.Forms.Label();
            this.qtt = new System.Windows.Forms.NumericUpDown();
            this.adicionar = new System.Windows.Forms.Button();
            this.compra = new System.Windows.Forms.Button();
            this.Busca = new System.Windows.Forms.TextBox();
            this.BuscaLabel = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.DataGridView();
            this.escolher = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aviso = new System.Windows.Forms.TextBox();
            this.BolosText = new System.Windows.Forms.Label();
            this.QuantidadeDeBolos = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.TotalTxt = new System.Windows.Forms.Label();
            this.inicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F);
            this.voltar.Location = new System.Drawing.Point(13, 667);
            this.voltar.Margin = new System.Windows.Forms.Padding(4);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(150, 88);
            this.voltar.TabIndex = 7;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // NomeTXT
            // 
            this.NomeTXT.Location = new System.Drawing.Point(829, 186);
            this.NomeTXT.Multiline = true;
            this.NomeTXT.Name = "NomeTXT";
            this.NomeTXT.ReadOnly = true;
            this.NomeTXT.Size = new System.Drawing.Size(368, 60);
            this.NomeTXT.TabIndex = 8;
            // 
            // PreçoTXT
            // 
            this.PreçoTXT.Location = new System.Drawing.Point(829, 293);
            this.PreçoTXT.Multiline = true;
            this.PreçoTXT.Name = "PreçoTXT";
            this.PreçoTXT.ReadOnly = true;
            this.PreçoTXT.Size = new System.Drawing.Size(368, 60);
            this.PreçoTXT.TabIndex = 5;
            // 
            // NomeLabel
            // 
            this.NomeLabel.AutoSize = true;
            this.NomeLabel.Location = new System.Drawing.Point(824, 155);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(174, 35);
            this.NomeLabel.TabIndex = 8;
            this.NomeLabel.Text = "Nome Do Bolo";
            // 
            // PreçoLabel
            // 
            this.PreçoLabel.AutoSize = true;
            this.PreçoLabel.Location = new System.Drawing.Point(824, 262);
            this.PreçoLabel.Name = "PreçoLabel";
            this.PreçoLabel.Size = new System.Drawing.Size(75, 35);
            this.PreçoLabel.TabIndex = 9;
            this.PreçoLabel.Text = "Preço";
            // 
            // qttLabel
            // 
            this.qttLabel.AutoSize = true;
            this.qttLabel.Location = new System.Drawing.Point(825, 363);
            this.qttLabel.Name = "qttLabel";
            this.qttLabel.Size = new System.Drawing.Size(148, 35);
            this.qttLabel.TabIndex = 14;
            this.qttLabel.Text = "Quantidade:";
            // 
            // qtt
            // 
            this.qtt.Location = new System.Drawing.Point(945, 361);
            this.qtt.Name = "qtt";
            this.qtt.Size = new System.Drawing.Size(114, 41);
            this.qtt.TabIndex = 4;
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(1065, 359);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(132, 81);
            this.adicionar.TabIndex = 5;
            this.adicionar.Text = "Adicionar à lista";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // compra
            // 
            this.compra.Location = new System.Drawing.Point(1047, 668);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(150, 88);
            this.compra.TabIndex = 6;
            this.compra.Text = "Avançar";
            this.compra.UseVisualStyleBackColor = true;
            this.compra.Click += new System.EventHandler(this.VerLista_Click);
            // 
            // Busca
            // 
            this.Busca.Location = new System.Drawing.Point(75, 11);
            this.Busca.Name = "Busca";
            this.Busca.Size = new System.Drawing.Size(744, 41);
            this.Busca.TabIndex = 1;
            this.Busca.TextChanged += new System.EventHandler(this.Busca_Mudou);
            // 
            // BuscaLabel
            // 
            this.BuscaLabel.AutoSize = true;
            this.BuscaLabel.Location = new System.Drawing.Point(8, 14);
            this.BuscaLabel.Name = "BuscaLabel";
            this.BuscaLabel.Size = new System.Drawing.Size(82, 35);
            this.BuscaLabel.TabIndex = 15;
            this.BuscaLabel.Text = "Busca:";
            // 
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            this.lista.AllowUserToResizeColumns = false;
            this.lista.AllowUserToResizeRows = false;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Location = new System.Drawing.Point(13, 66);
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            this.lista.RowHeadersWidth = 51;
            this.lista.Size = new System.Drawing.Size(806, 594);
            this.lista.TabIndex = 2;
            this.lista.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Lista_CellMouseDoubleClick);
            // 
            // escolher
            // 
            this.escolher.Location = new System.Drawing.Point(829, 66);
            this.escolher.Name = "escolher";
            this.escolher.Size = new System.Drawing.Size(132, 81);
            this.escolher.TabIndex = 3;
            this.escolher.Text = "escolher Item";
            this.escolher.UseVisualStyleBackColor = true;
            this.escolher.Click += new System.EventHandler(this.Escolher_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // aviso
            // 
            this.aviso.BackColor = System.Drawing.SystemColors.Control;
            this.aviso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aviso.ForeColor = System.Drawing.Color.Red;
            this.aviso.Location = new System.Drawing.Point(830, 412);
            this.aviso.Multiline = true;
            this.aviso.Name = "aviso";
            this.aviso.ReadOnly = true;
            this.aviso.Size = new System.Drawing.Size(229, 67);
            this.aviso.TabIndex = 21;
            // 
            // BolosText
            // 
            this.BolosText.AutoSize = true;
            this.BolosText.Location = new System.Drawing.Point(830, 505);
            this.BolosText.Name = "BolosText";
            this.BolosText.Size = new System.Drawing.Size(78, 35);
            this.BolosText.TabIndex = 23;
            this.BolosText.Text = "Bolos:";
            // 
            // QuantidadeDeBolos
            // 
            this.QuantidadeDeBolos.AutoSize = true;
            this.QuantidadeDeBolos.Location = new System.Drawing.Point(890, 505);
            this.QuantidadeDeBolos.Name = "QuantidadeDeBolos";
            this.QuantidadeDeBolos.Size = new System.Drawing.Size(54, 35);
            this.QuantidadeDeBolos.TabIndex = 24;
            this.QuantidadeDeBolos.Text = "999";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(830, 533);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(78, 35);
            this.Total.TabIndex = 25;
            this.Total.Text = "Total :";
            // 
            // TotalTxt
            // 
            this.TotalTxt.AutoSize = true;
            this.TotalTxt.Location = new System.Drawing.Point(890, 533);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.Size = new System.Drawing.Size(85, 35);
            this.TotalTxt.TabIndex = 26;
            this.TotalTxt.Text = "99,999";
            // 
            // inicioBindingSource
            // 
            this.inicioBindingSource.DataSource = typeof(Project.Inicio);
            // 
            // boloBindingSource
            // 
            this.boloBindingSource.DataSource = typeof(Project.Bolo);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 768);
            this.Controls.Add(this.TotalTxt);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.QuantidadeDeBolos);
            this.Controls.Add(this.aviso);
            this.Controls.Add(this.escolher);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.BuscaLabel);
            this.Controls.Add(this.Busca);
            this.Controls.Add(this.compra);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.qtt);
            this.Controls.Add(this.qttLabel);
            this.Controls.Add(this.PreçoLabel);
            this.Controls.Add(this.NomeLabel);
            this.Controls.Add(this.PreçoTXT);
            this.Controls.Add(this.NomeTXT);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.BolosText);
            this.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pedido";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Busca_KeyPress1(object sender, KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Busca_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.TextBox NomeTXT;
        private TextBox PreçoTXT;
        private Label NomeLabel;
        private Label PreçoLabel;
        private Label qttLabel;
        private NumericUpDown qtt;
        private Button adicionar;
        private Button compra;
        private TextBox Busca;
        private Label BuscaLabel;
        private DataGridView lista;
        private BindingSource inicioBindingSource;
        private BindingSource boloBindingSource;
        private Button escolher;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox aviso;
        private Label BolosText;
        private Label QuantidadeDeBolos;
        private Label Total;
        private Label TotalTxt;
    }
}