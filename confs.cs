using System;
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
            CaminhoArquivo.Text = Arquivo.CaminhoDoArquivo;

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                // Configura as propriedades do OpenFileDialog
                Filter = "Arquivos do Excel (*.xlsx)|*.xlsx|Todos os arquivos (*.*)|*.*",
                Title = "Selecione um arquivo do Excel",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CaminhoArquivo.Text = openFileDialog.FileName;
                Arquivo.CaminhoDoArquivo = CaminhoArquivo.Text;
                // Fazer algo com o caminho do arquivo selecionado
            }
        }
    }
}
