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
        private readonly string arquivo = "config.txt";

        public static DataTable DT { get; set; }

        private static DataSet DS { get; set; }

        public First_Time()
        {
            Atual.User = new Cliente();
            Config();
        }
        private void Config()
        {
            DirectoryInfo Directoryinfo;
            Directoryinfo = Directory.CreateDirectory(@"ClientesBase");
            Directoryinfo.Attributes |= FileAttributes.Hidden;
            if (!File.Exists(arquivo))
            {
                // criando todos os diretorios Para futuro uso
                Arquivo.SetArquive();
                StartDataTable();
                File.Create(arquivo).Close();
                File.SetAttributes(arquivo, File.GetAttributes(arquivo) | FileAttributes.Hidden);
                Directory.CreateDirectory(@"caminho").Attributes |= FileAttributes.Hidden; // |= : se diferente, seta para o valor da direita, se nao, não altera
                Directory.CreateDirectory(@"Nota").Attributes |= FileAttributes.Hidden;
                ExcelClass.Run(true, Directoryinfo.FullName).Wait();
            }
            else
            {
                Arquivo.SetCaminhoDoArquivo(File.ReadAllText(@"caminho\exel.txt"));//arquivo de base
                ExcelClass.Run(false, Directoryinfo.FullName).Wait();

            }
        }

        public static Task StartDataTable()
        {
            // Configurar DataTable
            DT = new DataTable();
            DS = new DataSet();
            var stream = new FileStream(Project.Arquivo.GetCaminhoDoArquivo(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
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
            return Task.CompletedTask;
        }

        private static void GetTablenames(DataTableCollection tables)
        {
            foreach (DataRow table in tables[0].Rows)
            {
                DT.Rows.Add(table[0].ToString(), table[1].ToString());
            }
        }
    }
}
