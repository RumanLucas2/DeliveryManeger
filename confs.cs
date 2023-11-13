using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace Project
{
    public partial class Confs : Form
    {

        public Confs()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Confs_Load(object sender, EventArgs e)
        {
            voltar.Text = "Voltar";
            CaminhoArquivo.Text = Arquivo.GetCaminhoDoArquivo();

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Arquivo.SetArquive();
        }
    }
}
