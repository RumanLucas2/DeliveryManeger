using System;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            Arquivo.CaminhoDoArquivo = File.ReadAllText(@"caminho\exel.txt");
            Carry.Start();
            InitializeComponent();
            this.Text = null;
            this.ControlBox = false;
            this.MaximizeBox = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            System.Drawing.Icon icon = new System.Drawing.Icon("icones\\logo.ico");
            this.Icon = icon;
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
        public static string CaminhoDoArquivo
        {
            get => LerArquivo();

            set => ReescreverArquivo(value);
        }

        private static string _caminhoDoArquivo;

        private static string LerArquivo()
        {
            using (StreamReader sr = new StreamReader(@"caminho\exel.txt"))
            {
                _caminhoDoArquivo = sr.ReadToEnd();
                sr.Close();
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
    }
}
