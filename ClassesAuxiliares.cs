using System;
using System.Threading.Tasks;
using RestSharp; 

namespace Project
{
    public class CEP
    {
        public string Cep { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Localidade { get; set; } = string.Empty;
        public string Uf { get; set; } = string.Empty;
        public string Ibge { get; set; } = string.Empty;
        public string Gia { get; set; } = string.Empty;
        public string Ddd { get; set; } = string.Empty;
        public string Siafi { get; set; } = string.Empty;
        public CEP() { }

        public CEP(string _cep)
        {
            Cep = _cep;
        }

        /// <summary>
        /// Busca o endereço do cliente em via cep.
        /// </summary>
        /// <param name="_cep"></param>
        /// <returns></returns>
        public static async Task<CEP> SetEndereço(string _cep)//Pega o endereço do Cliente
        {
            string url = $"https://viacep.com.br/ws/{_cep.Replace("-", "")}/json/";
            RestClient client = new RestClient();
            try
            {
                RestRequest request = new RestRequest(url, Method.Get);
                RestResponse response = client.Execute(request);
                string[] slpiter = response.Content.Split(',');
                await Task.Delay(0);
                return new CEP
                {
                    Cep = slpiter[0].Replace("\"", "").Split(':')[1].Trim(),
                    Logradouro = slpiter[1].Replace("\"", "").Split(':')[1].Trim(),
                    Complemento = slpiter[2].Replace("\"", "").Split(':')[1].Trim(),
                    Bairro = slpiter[3].Replace("\"", "").Split(':')[1].Trim(),
                    Localidade = slpiter[4].Replace("\"", "").Split(':')[1].Trim(),
                    Uf = slpiter[5].Replace("\"", "").Split(':')[1].Trim(),
                    Ibge = slpiter[6].Replace("\"", "").Split(':')[1].Trim(),
                    Gia = slpiter[7].Replace("\"", "").Split(':')[1].Trim(),
                    Ddd = slpiter[8].Replace("\"", "").Split(':')[1].Trim(),
                    Siafi = slpiter[9].Replace("\"", "").Split(':')[1].Trim(),
                };
            }
            catch
            {
                return new CEP();
            }
        }
    }

    public class Date
    {
        public int Day;

        public int Month;

        public int Year;

        /// <summary>
        /// Retorna tipo Mes/Dia/Ano
        /// </summary>
        public string Full_Date_Ameriaca;

        /// <summary>
        /// Retorna tipo Dia/Mes/Ano
        /// </summary>
        public string Full_Date;

        public Date(){ }
        /// <summary>
        /// Retorna com todas as variaveis setadas
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public Date (int day, int month)
        {
            Day = day;
            Month = month;
            Full_Date = $"{day}|{month}";
            Full_Date_Ameriaca = $"{month}|{day}";
        }
    }

    public class CellPhone
    {
        public int DDD;

        public int PhoneNumber;

        public int Country;

        /// <summary>
        /// saida exemplo: 11123456789
        /// </summary>
        public string NormalCellPhone;

        /// <summary>
        /// saida exemplo: +55(11)1234-56789
        /// </summary>
        public string FullCellPhone;

        /// <summary>
        /// saida exemplo: (11) 1234-56789
        /// </summary>
        public string ToStore;

        /// <summary>
        /// Configura o celular para o jeito certo tendo como saida um completo "+<paramref name="codigo"/> () 
        /// </summary>
        /// <param name="ddd"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="codigo"></param>
        public CellPhone(int ddd, int phoneNumber, int codigo = 55)
        {
            DDD = ddd;
            PhoneNumber = phoneNumber;
            Country = codigo;
            FullCellPhone = $"+{codigo} ({ddd}) {phoneNumber.ToString().Insert(5, "-")}";
            NormalCellPhone = $"{ddd}{phoneNumber}";
            ToStore = $"({ddd}) {phoneNumber.ToString().Insert(5, "-")}";
        }
        public CellPhone() { }
        /// <summary>
        /// Volta da saida do excel para os outros
        /// </summary>
        public CellPhone Inverter(string ExcelCell)
        {
            int ddd = int.Parse($"{ExcelCell.Split(' ')[0].Replace("(", "").Replace(")", "")}");
            int pn = int.Parse($"{ExcelCell.Split(' ')[1].Replace("-", "")}");
            return new CellPhone(ddd, pn);
        }
    }

    //public static class Token
    //{
    //    public static string  Valid;

    //    public static bool Terminate { get; set; } = false;

    //    private static async Task TokenGet()//Pega o endereço do Cliente
    //    {

    //        string url = $"https://api.correios.com.br/token/v1/autentica";

    //        string acceptHeader = "application/json";

    //        string authorizationHeader = "Basic NTI2MTI0ODg4NDc6bHVjYXMxMjM=";

    //        var client = new RestClient();

    //        var request = new RestRequest(url, Method.Post);

    //        await Task.Delay(0);
    //        request.AddHeader("accept", acceptHeader);

    //        await Task.Delay(0);
    //        request.AddHeader("Authorization", authorizationHeader);

    //        var response = await client.ExecuteAsync(request);


    //        if (response.IsSuccessful)
    //        {
    //            await Task.Delay(0);
    //            string responseBody = response.Content;
    //            var separar = responseBody.Split(',');
    //            Valid = separar[separar.Length-1];
    //        }
    //        else
    //        {
    //            await Task.Delay(0);
    //            return;
    //        }
    //    }

    //    public static async Task Verify()
    //    {
    //        while(!Terminate)
    //        {
    //            await TokenGet();
    //        }
    //    }
    //}
}
