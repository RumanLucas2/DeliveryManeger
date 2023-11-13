using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class IniPedido : Form
    {
        private Task<CEP> task;
        public IniPedido()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = null;
            this.KeyPreview = true;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                if (Telefone.MaskCompleted == true)
                {
                    Pesquisar_Click(sender, e);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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
                Cadastro w = new Cadastro(this.Telefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-",""));
                w.Show();
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                task.Dispose();
            }
            catch (Exception)
            {

            }
            Atual.Reset();
            string Tell = Telefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim().Replace(" ", "");
            Atual.User = DataBase.Collection.FindCellphone(Tell);
            if (Atual.User != new Cliente() && Atual.User != null)
            {
                task = Task<CEP>.Run(async () => { return await CEP.SetEndereço(Atual.User.Endereço.GetCep()); });
                this.avançar.Text = "Continuar";
                Local(task);
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

        public async Task Local(Task<CEP> task)
        {

            TextoCliente.Lines = new string[]
            {
                $"Nome: {Atual.User.Name}",
                $"Endereço: Procurando Endereço, {Atual.User.Numero}",
                $"Complemento: {Atual.User.Complemento}"
            };

            await (Internet.Connection == false ? Quebra(task) : task);
            TextoCliente.Lines = new string[]
            {
                $"Nome: {Atual.User.Name}",
                $"Endereço: {(Internet.Connection == false ? ("Sem Conexão à internet")  : task.Result.Logradouro + ", " + Atual.User.Numero)}",
                $"Complemento: {Atual.User.Complemento}"
            };
            Atual.User.Endereço = task.Result;
        }

        public Task<CEP> Quebra(Task<CEP> task)
        {
            task.Dispose();
            var altTask = Task<CEP>.Run(() => new CEP 
            { 
                Logradouro = null
            });
            return altTask;
        }
        private void Telefone_Click(object sender, EventArgs e)
        {
            //(11) 99405-3799
            //11994053799
            string text = Telefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            Telefone.SelectionStart = (text.Length > 2 ? (text.Length > 7 ? text.Length + 4 : text.Length + 3) : text.Length + 1);
        }
    }
}
