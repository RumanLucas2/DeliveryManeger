using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Project
{
    public class PrintF
    {
        private static string Pagamento;

        internal readonly static string texto = (
                    ("Bolo da Madre\n") +
                    ($"Nome: {Atual.User.Name}\n") +
                    ("Produto\n") +
                    ($"{Bolos()}\n") +
                    ($"Valor Total: {BoloManager.ListaBolo.Value},00 R$\n") +
                    ($"Data: {Atual.Reserv.Data.Day}/{Atual.Reserv.Data.Month} ({Atual.Reserv.Hora.Hour}:{Atual.Reserv.Hora.Min})\n") +
                    ($"Status: {Pagamento}\n") +
                    ($"Endereço: {Atual.User.Endereço.Endereço}")

            );

        private static readonly string filePath = @"Nota\NotaFiscal.txt";
        private static PrintDocument pd = new PrintDocument();


        /// <summary>
        /// para imprimir o arquivo
        /// </summary>
        public static void PrintFile(bool Status)
        {
            if (Status)
            {
                Pagamento = "Pago";
            }
            else
            {
                Pagamento = "À Pagar";
            }
            Imprimir();
            try
            {
                pd.Print();
                Atual.WhatsApp(Atual.Set.Message, texto);
            }
            catch
            {

            }
            
        }

        private static void Imprimir()
        {
            
            pd.PrintPage += new PrintPageEventHandler(ImprimirDocumento);
        }
        private static void ImprimirDocumento(object sender, PrintPageEventArgs e)
        {
            float linhasPorPagina = 0;
            float yPosicao = 0;
            int contador = 0;
            float margemEsquerda = 0;
            float margemSuperior = e.MarginBounds.Top;
            string linha = null;
            SolidBrush mCaneta = new SolidBrush(Color.Black);
            
            try
            {
                ///manter em 8
                using (Font font = new Font("Arial", 8))
                {
                    yPosicao = margemSuperior + font.GetHeight();
                    // desenha a proxima linha no controle RichTextBox
                    e.Graphics.Flush();
                    e.Graphics.DrawString(texto, font, mCaneta, margemEsquerda, yPosicao);
                }
            }
            catch(Exception ex)
            {

            }
        }

        private static string Bolos()
        {
            string Retorno = string.Empty;

            foreach(Bolo aux in BoloManager.ListaBolo)
            {
                Retorno += ($"{aux.Quantidade}*{aux.Nome}\n");
                if(aux.OBS != "")
                {
                    Retorno += ($"{aux.OBS}\n");
                }
            }
            return Retorno;
        }
    }
}
