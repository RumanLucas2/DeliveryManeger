using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Project
{
    /// <summary>
    /// Classe statica para o Banco de Dados
    /// </summary>
    public static class DataBase
    {
        public static ListaClientes Collection { get; set; }
        public class ListaClientes : List<Cliente>
        {
            public ListaClientes() { }

            /// <summary>
            /// Retorna o cliente que possui tal telefone
            /// </summary>
            /// <param name="PhoneNumber"></param>
            /// <returns></returns>
            public Cliente FindCellphone(string PhoneNumber)
            {
                return Find(cliente => cliente.Telefone.NormalCellPhone == PhoneNumber);
            }
        }
    }

    /// <summary>
    /// Classe que trabalha com o cliente
    /// </summary>
    public static class Atual
    {
        public static Cliente User { get; set; } = new Cliente();

        public static void WhatsApp()
        {
            string phoneNumber = $"55{User.Telefone.NormalCellPhone}";
            string mensagem = $"Ola {User.Name}, você acabou de se cadastrar como parte da familia Bolo Da Madre Indaiatuba";
            // Constrói a URL de envio da mensagem
            string url = $"https://wa.me/send/?phone={phoneNumber}&text={mensagem}";
            var process = new Process();
            process.StartInfo.FileName = url;
            process.Start();
            Task.Delay(5000).Wait();
            Clipboard.SetText(mensagem);
            SendKeys.Send("^v");
            SendKeys.Flush();
            SendKeys.Send("{ENTER}");
            process.WaitForExit(5000);
        }
    }


    /// <summary>
    /// Classe que representa o cliente
    /// </summary>
    public class Cliente
    {
        public string Name { get; set; } = string.Empty;

        public Date Aniversario { get; set; } = new Date();

        public string CPF { get; set; } = string.Empty; 

        public string Complemento { get; set; } = string.Empty;

        public string Numero { get; set; } = string.Empty;

        public CEP Endereço { get; set; } = new CEP();

        public CellPhone Telefone { get; set; } = new CellPhone();

        public Cliente() { }
    }
}
