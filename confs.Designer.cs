namespace Project
{
    partial class Confs
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
            this.voltar = new System.Windows.Forms.Button();
            this.CaminhoArquivo = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.LabelC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F);
            this.voltar.Location = new System.Drawing.Point(706, 397);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(82, 41);
            this.voltar.TabIndex = 1;
            this.voltar.Text = "button1";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // CaminhoArquivo
            // 
            this.CaminhoArquivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.CaminhoArquivo.Location = new System.Drawing.Point(101, 217);
            this.CaminhoArquivo.Name = "CaminhoArquivo";
            this.CaminhoArquivo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CaminhoArquivo.Size = new System.Drawing.Size(201, 34);
            this.CaminhoArquivo.TabIndex = 2;
            this.CaminhoArquivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // search
            // 
            this.search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.search.Location = new System.Drawing.Point(308, 216);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(35, 35);
            this.search.TabIndex = 3;
            this.search.Text = "...";
            this.search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // LabelC
            // 
            this.LabelC.AutoSize = true;
            this.LabelC.Location = new System.Drawing.Point(12, 217);
            this.LabelC.Name = "LabelC";
            this.LabelC.Size = new System.Drawing.Size(92, 28);
            this.LabelC.TabIndex = 4;
            this.LabelC.Text = "Caminho:";
            // 
            // Confs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CaminhoArquivo);
            this.Controls.Add(this.LabelC);
            this.Controls.Add(this.search);
            this.Controls.Add(this.voltar);
            this.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F);
            this.Name = "Confs";
            this.Text = "confs";
            this.Load += new System.EventHandler(this.Confs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.TextBox CaminhoArquivo;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label LabelC;
    }
}