using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Cadastro : Form
    {
        public Cadastro(string Telefone)
        {
            InitializeComponent();
            this.ControlBox = false;
            Atual.User = new Cliente();
            this.Telefone.Text = Telefone;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = null;
            
            Cep.MaxLength = 8;

            Telefone.MaxLength = 9;

            CPF.MaxLength = 11;
            CPFCheck.CheckState = CheckState.Unchecked;
            CPF.Enabled = false;
            CPF.ReadOnly = true;

            //caixa de texto que aparece o logradouro:: Endereço
            Endereço.ReadOnly = true;
            Endereço.Hide();

            //Caixa de testo dos avisos:: Warning
            Warning.ForeColor = System.Drawing.Color.Red;
        }


        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CPFCheck_CheckedChanged(object sender, EventArgs e)
        {

            if (CPFCheck.CheckState == CheckState.Checked)
            {
                CPFCheck.ThreeState = false;
                CPFCheck.ForeColor = System.Drawing.Color.RoyalBlue;
                CPFCheck.BackColor = System.Drawing.Color.LightSkyBlue;
                CPFCheck.Text = "\u2713";
                CPF.ReadOnly = false;
                CPF.Enabled = true;
            }
            else if (CPFCheck.CheckState == CheckState.Unchecked)
            {
                CPFCheck.ThreeState = false;
                CPFCheck.ForeColor = System.Drawing.Color.Red;
                CPFCheck.BackColor = System.Drawing.Color.Snow;
                CPFCheck.Text = "\u2717";
                CPF.ReadOnly = true;
                CPF.Enabled = false;
            }
        }

        private void WarningControlOff(Control componente, Control variante)
        {
            Warning.Text = Warning.Text.Replace($"{variante.Name},", "");
            componente.ForeColor = System.Drawing.Color.Black;
        }
        private void WarningControl(Control componente, Control variante)
        {
            Warning.Text += $"{variante.Name}, ";
            TrocaCor(componente, "Red");
        }
        private void Salvar_Click(object sender, EventArgs e)
        {
            Warning.Text = "";
            if (Nome.Text == string.Empty)
            {
                WarningControl(NomeLabel, Nome);
            }
            else
            {
                WarningControlOff(NomeLabel, Nome);
            }

            if (Telefone.MaskCompleted == false)
            {
                WarningControl(TellLabel, Telefone);
            }
            else
            {
                WarningControlOff(TellLabel, Telefone);
            }

            if (CPFCheck.Checked == true && CPF.MaskCompleted == false)
            {
                WarningControl(CPFLabel, CPF);
            }
            else
            {
                WarningControlOff(CPFLabel, CPF);
            }

            if (Cep.MaskCompleted == false)
            {
                WarningControl(CepLabel, Cep);
            }
            else
            {
                WarningControlOff(CepLabel, Cep);
            }

            if (Aniversario.MaskCompleted == false)
            {
                WarningControl(NiverText, Aniversario);
            }
            else
            {
                WarningControlOff(NiverText, Aniversario);
            }
            if (!(Warning.Text.Trim() == ""))
            {
                Warning.Text += "Esta(ão) incorretos para chamada";
                return;
            }
            Atual.User.Name = Nome.Text;
            Atual.User.Telefone = new CellPhone(int.Parse(Telefone.Text.Split(' ')[0].Replace("(", "").Replace(")", "")), int.Parse(Telefone.Text.Split(' ')[1].Trim().Replace("-", "")));
            if (CPFCheck.Checked == true)
            {
                Atual.User.CPF = CPF.Text;
            }
            else
            {
                Atual.User.CPF = "Não informado";
            }
            //pegando informações
            var split = Aniversario.Text.Split('/');
            for(int i = 0; i< split.Length; i++)
            {
                var aux = split[i].Trim();
                split[i] = aux.Replace("/", "");
            }
            Atual.User.Aniversario = new Date(int.Parse(split[0]), int.Parse(split[1]));
            Atual.User.Complemento = Complemento.Text;
            Atual.User.Numero = Numero.Text;
            //amostras
            Pedido w = new Pedido();
            w.Show();
            Salvar.Hide();
            Salvar.Enabled = false;
            this.Close();
            Atual.WhatsApp(Atual.Set.Cadastro);
            ExcelClass.Save(Atual.User);
        }
        private void TrocaCor(Control componente, string color)
        {
            componente.ForeColor = System.Drawing.Color.FromName(color);
        }

        private void CepLeave(object sender, EventArgs e)
        {
            if (Cep.MaskCompleted == true)
            {
                
                var aux = Task.Run(async () =>
                {
                    await Print();
                    
                });
                Test(aux);
            }
        }

        private async void Test(Task aux)
        {
            await aux;
            Endereço.Show();
            Endereço.Text = (Internet.Connection == false ? "Sem Internet" : $"Logradouro é: {Atual.User.Endereço.Logradouro}?");
        }

        private async Task Print()
        {
            //pegando informações
            Atual.User.Endereço = await CEP.SetEndereço(Cep.Text);
            return;
        }

        private void Nome_Enter(object sender, EventArgs e)
        {
            Nome.SelectAll();
        }

        private void Telefone_Enter(object sender, EventArgs e)
        {
            Telefone.SelectAll();
        }

        private void CPF_Enter(object sender, EventArgs e)
        {
            CPF.SelectAll();
        }

        private void Aniversario_Enter(object sender, EventArgs e)
        {
            Aniversario.SelectAll();
        }

        private void Cep_Enter(object sender, EventArgs e)
        {
            Cep.SelectAll();
        }

        private void CPF_Click(object sender, EventArgs e)
        {
            CPF.SelectionStart = CPF.Text.Replace("_", "").Replace(".","").Replace("-","").Replace(" ", "").Length > 3 ? (CPF.Text.Replace("_", "").Replace(".", "").Replace("-", "").Replace(" ", "").Length > 6 ? (CPF.Text.Replace("_", "").Replace(".", "").Replace("-", "").Replace(" ", "").Length > 9 ? CPF.Text.Replace("_", "").Replace(".", "").Replace("-", "").Replace(" ", "").Length +3 : CPF.Text.Replace("_", "").Replace(".", "").Replace("-", "").Replace(" ", "").Length +2) : CPF.Text.Replace("_", "").Replace(".", "").Replace("-", "").Replace(" ", "").Length +1) : CPF.Text.Replace("_", "").Replace(".", "").Replace("-", "").Replace(" ", "").Length;
        }

        private void Cep_Click(object sender, EventArgs e)
        {
            Cep.SelectionStart = Cep.Text.Replace("_", "").Replace("-", "").Replace(" ", "").Length > 5 ? Cep.Text.Replace("_", "").Replace("-", "").Replace(" ", "").Length + 1 : Cep.Text.Replace("_", "").Replace("-", "").Replace(" ", "").Length;
        }

        private void Aniversario_Click(object sender, EventArgs e)
        {
            Aniversario.SelectionStart = Aniversario.Text.Replace("/", "").Replace("_", "").Replace(" ", "").Length >= 2 ? Aniversario.Text.Replace("/", "").Replace("_", "").Replace(" ", "").Length +1 : Aniversario.Text.Replace("/", "").Replace("_", "").Replace(" ", "").Length;
        }
    }
}
