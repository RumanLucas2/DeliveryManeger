namespace Project
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.Mes = new System.Windows.Forms.ComboBox();
            this.Definir = new System.Windows.Forms.Button();
            this.Dia = new System.Windows.Forms.NumericUpDown();
            this.Hora = new System.Windows.Forms.MaskedTextBox();
            this.DiaText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Voltar = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.Dia)).BeginInit();
            this.SuspendLayout();
            // 
            // Mes
            // 
            this.Mes.FormattingEnabled = true;
            this.Mes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Desembro"});
            this.Mes.Location = new System.Drawing.Point(203, 30);
            this.Mes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Mes.Name = "Mes";
            this.Mes.Size = new System.Drawing.Size(209, 36);
            this.Mes.TabIndex = 2;
            this.Mes.Text = "Escolha o mes";
            this.Mes.SelectedIndexChanged += new System.EventHandler(this.Mes_SelectedIndexChanged);
            // 
            // Definir
            // 
            this.Definir.Location = new System.Drawing.Point(379, 218);
            this.Definir.Name = "Definir";
            this.Definir.Size = new System.Drawing.Size(122, 52);
            this.Definir.TabIndex = 5;
            this.Definir.Text = "Escolher";
            this.Definir.UseVisualStyleBackColor = true;
            this.Definir.Click += new System.EventHandler(this.Definir_Click);
            // 
            // Dia
            // 
            this.Dia.Location = new System.Drawing.Point(79, 30);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(73, 34);
            this.Dia.TabIndex = 1;
            this.Dia.Enter += new System.EventHandler(this.Dia_Enter);
            // 
            // Hora
            // 
            this.Hora.Location = new System.Drawing.Point(80, 109);
            this.Hora.Mask = "00:00";
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(72, 34);
            this.Hora.TabIndex = 3;
            this.Hora.ValidatingType = typeof(System.DateTime);
            // 
            // DiaText
            // 
            this.DiaText.BackColor = System.Drawing.SystemColors.Menu;
            this.DiaText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiaText.Location = new System.Drawing.Point(13, 32);
            this.DiaText.Name = "DiaText";
            this.DiaText.Size = new System.Drawing.Size(60, 27);
            this.DiaText.TabIndex = 5;
            this.DiaText.Text = "Dia:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(13, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 27);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Hora:";
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CheckBox1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.CheckBox1.FlatAppearance.BorderSize = 3;
            this.CheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.CheckBox1.Location = new System.Drawing.Point(13, 169);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(114, 32);
            this.CheckBox1.TabIndex = 4;
            this.CheckBox1.Text = "Não Pago";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(13, 218);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(122, 52);
            this.Voltar.TabIndex = 7;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 282);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DiaText);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.Dia);
            this.Controls.Add(this.Definir);
            this.Controls.Add(this.Mes);
            this.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Mes;
        private System.Windows.Forms.Button Definir;
        private System.Windows.Forms.NumericUpDown Dia;
        private System.Windows.Forms.MaskedTextBox Hora;
        private System.Windows.Forms.TextBox DiaText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.Button Voltar;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}