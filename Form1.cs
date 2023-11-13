using System;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            
                
            InitializeComponent();
            
                            Internet.Start();
            Carry.Start();
            Text = null;
            ControlBox = false;
            MaximizeBox = true;
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonPedidos.Text = "Iniciar pedido";
            OFF.Text = "Finalizar programa";
        }

        private void ButtonPedidos_Click(object sender, EventArgs e)
        {
            //this.Hide();
            IniPedido w = new IniPedido();
            w.Show();

        }

        private void OFF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Configuração_Click(object sender, EventArgs e)
        {
            Confs w = new Confs();
            w.Show();
        }
    }

    public static class Carry
    {
        public static First_Time Id { get; set; }

        public static void Start()
        {
            Id = new First_Time();
        }
    }

    /// <summary>
    /// Arquivo de preços
    /// </summary>
    public static class Arquivo
    {
        public static string GetCaminhoDoArquivo()
        {
            return LerArquivo();
        }

        public static void SetCaminhoDoArquivo(string value)
        {
            ReescreverArquivo(value);
        }

        private static string _caminhoDoArquivo;

        public static string LerArquivo()
        {
            using (StreamReader sr = new StreamReader(@"caminho\exel.txt"))
            {
                _caminhoDoArquivo = sr.ReadToEnd();
            }
            return _caminhoDoArquivo;
        }

        private static void ReescreverArquivo(string aux)
        {
            if (aux == _caminhoDoArquivo)
            {
                return;
            }
            File.WriteAllText(@"caminho\exel.txt", aux);
            _caminhoDoArquivo = aux;
        }

        public static void SetArquive()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                // Configura as propriedades do OpenFileDialog
                Filter = "Arquivos do Excel (*.xlsx)|*.xlsx|Todos os arquivos (*.*)|*.*",
                Title = "Selecione um arquivo do Excel",
                Multiselect = false,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Arquivo.SetCaminhoDoArquivo(openFileDialog.FileName);
                // Fazer algo com o caminho do arquivo selecionado
            }
        }
    }
}
