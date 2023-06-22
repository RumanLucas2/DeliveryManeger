using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using DataTable = System.Data.DataTable;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using System;
using System.Collections.Generic;
using ExcelDataReader;
using System.Data;

namespace Project
{
    public class First_Time
    {
        private readonly string Arquivo = "config.txt";

        public DataTable DT { get; set; }

        private DataSet DS { get; set; }

        public bool Teste { get; set; }

        public DirectoryInfo Directoryinfo;

        public First_Time()
        {
            Teste = false;
            DT = new DataTable();
            Atual.User = new Cliente();
            Config();
        }
        private void Config()
        {
            StartDataTable();
            Directoryinfo = Directory.CreateDirectory(@"ClientesBase");
            Directoryinfo.Attributes |= FileAttributes.Hidden;
            if (!File.Exists(Arquivo))
            {
                // criando todos os diretorios Para futuro uso
                File.Create(Arquivo).Close();
                File.SetAttributes(Arquivo, File.GetAttributes(Arquivo) | FileAttributes.Hidden);
                Directory.CreateDirectory(@"caminho").Attributes |= FileAttributes.Hidden; // |= : se diferente, seta para o valor da direita, se nao, não altera
                ExcelClass.Run(true, Directoryinfo.FullName).Wait();
            }
            else
            {
                ExcelClass.Run(false, Directoryinfo.FullName).Wait();
            }
        }

        public async void StartDataTable()
        {
            // Configurar DataTable
            var stream = new FileStream(Project.Arquivo.CaminhoDoArquivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            DT.Columns.Add("Produto");
            DT.Columns.Add("Preço");
            IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

            DS = reader.AsDataSet(new ExcelDataSetConfiguration
            {
                UseColumnDataType = false,
                ConfigureDataTable = (tablereader) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = false
                }
            });
            GetTablenames(DS.Tables);
            reader.Close();
            Teste = true;
            await Task.Delay(0);
        }

        private void GetTablenames(DataTableCollection tables)
        {
            foreach (DataRow table in tables[0].Rows)
            {
                DT.Rows.Add(table[0].ToString(), table[1].ToString());
            }
        }
    }
}
