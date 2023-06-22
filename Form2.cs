using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class IniPedido : Form
    {
        public IniPedido()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = null;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            System.Drawing.Icon icon = new System.Drawing.Icon("icones\\logo.ico");
            this.Icon = icon;
            pesquisar.Text = null;
            avançar.Enabled = false;
            avançar.Visible = false;
            Alterar.Text = "alterar";
            Alterar.Enabled = false;
            Alterar.Visible = false;
            voltar.Text = "Cancelar";
            TextoCliente.Enabled= false;
        }

        private void Procurar_Click(object sender, EventArgs e)
        {
            if (avançar.Text == "Continuar")
            {
                //abrir forms de pedidos
                Pedido w = new Pedido();
                w.Show();
            }
            else
            {
                //abrir forms cadastro
                Cadastro w = new Cadastro();
                w.Show();
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            string Tell = Telefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim().Replace(" ", "");
            Atual.User = new Cliente();
            Atual.User = DataBase.Collection.FindCellphone(Tell);
            if (Atual.User != null)
            {
                Atual.User.Endereço = CEP.SetEndereço(Atual.User.Endereço.Cep).GetAwaiter().GetResult();
                avançar.Text = "Continuar";
                var lista = new List<string>
                {
                    $"Nome: {Atual.User.Name}",
                    $"Endereço: {Atual.User.Endereço.Logradouro}, {Atual.User.Numero}",
                    $"Complemento: {Atual.User.Complemento}"
                };
                TextoCliente.Lines = lista.ToArray();
               // Alterar.Enabled = true;
               // Alterar.Visible = true;
                avançar.Enabled = true;
                avançar.Visible = true;
            }
            else
            {
                avançar.Text = "Cadastrar";
               // Alterar.Enabled = false;
               // Alterar.Visible = false;
                avançar.Enabled = true;
                avançar.Visible = true;
                TextoCliente.Text = null;
            }
        }

        private void Alterar_Click(object sender, EventArgs e)
        {

        }
    }
}
