using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System;
using System.Runtime.InteropServices;

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
            /// procura o cliente na lista
            /// </summary>
            /// <param name="PhoneNumber">Insira o numero de telefone do Cliente</param>
            /// <returns>Retorna o cliente caso o ache; Se não retorna vazio</returns>
            public Cliente FindCellphone(string PhoneNumber)
            {
                return Find(cliente => cliente.Telefone.NormalCellPhone == PhoneNumber);
            }
        }
    }

    /// <summary>
    /// Classe que trabalha com o cliente
    /// </summary>
    public class Atual
    {
        private static bool visualizer = false;
        public enum Set
        {
            Cadastro = 0x1,
            Message = 0x2
        }
         ;
        public static Cliente User { get; set; } = new Cliente();

        public static Reserva Reserv { get; set; } = new Reserva();
        public static void Reset()
        {
            User = new Cliente();
            Reserv = new Reserva();
            visualizer = false;
        }

        private static void WhatsApp()
        {
            string phoneNumber = $"55{User.Telefone.NormalCellPhone}";
            string mensagem = $"Ola {User.Name}, você acabou de se cadastrar como parte da familia Bolo Da Madre Indaiatuba";
            // Constrói a URL de envio da mensagem
            string url = $"https://api.whatsapp.com/send/?phone={phoneNumber}&text={mensagem}&type=phone_number&app_absent=0";
            var process = new Process();
            process.StartInfo.FileName = url;
            process.Start();
            Task.Delay(5000).Wait();
            SendKeys.Flush();
            SendKeys.Send("{ENTER}");
            process.WaitForExit(5000);
        }

        private static void WhatsAppTicket(string text)
        {
            if (visualizer == true) return;
            string phoneNumber = $"55{User.Telefone.NormalCellPhone}";
            string mensagem = text.Replace("\n", "%0A");
            // Constrói a URL de envio da mensagem
            
            string url = $"https://api.whatsapp.com/send/?phone={phoneNumber}&text={mensagem}&type=phone_number&app_absent=0";
            var process = new Process();
            process.StartInfo.FileName = url;
            process.Start();
            Task.Delay(5000).Wait();
            SendKeys.Flush();
            SendKeys.Send("{ENTER}");
            process.WaitForExit(5000);
            visualizer = true;
        }

        public static void WhatsApp(Set atribute, string message = "")
        {
            if(atribute == Set.Cadastro) WhatsApp();
            if(atribute == Set.Message) WhatsAppTicket(message);
        }
        

        public Attribute Attribute { get; set; }
    }

    public class Reserva
    {
        public Date Data { get; set; } = new Date();
        public Time Hora { get; set; } = new Time();

        public Reserva() { }
    }

    /// <summary>
    /// Classe que representa o cliente
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Nome do Cliente
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Data de aniversario do cliente
        /// </summary>
        public Date Aniversario { get; set; } = new Date();

        /// <summary>
        /// CPF do cliente
        /// </summary>
        public string CPF { get; set; } = string.Empty; 

        /// <summary>
        /// 
        /// Complemento do endereço do Cliente
        /// </summary>
        public string Complemento { get; set; } = string.Empty;

        /// <summary>
        /// Numero de de residencia do Cliente
        /// </summary>
        public string Numero { get; set; } = string.Empty;

        /// <summary>
        /// retorna o CEP do cliente, que contem todo o endereço
        /// </summary>
        public CEP Endereço { get; set; } = new CEP();

        public CellPhone Telefone { get; set; } = new CellPhone();

        public Cliente() { }
    }
}
