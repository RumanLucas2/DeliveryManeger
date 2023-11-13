using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace Project
{
    public partial class VerLista : Form
    {

        /// <summary>
        /// 
        /// </summary>
        public DataTable dt;
        /// <summary>
        /// Vê toda a lista
        /// </summary>
        public VerLista()
        {
            InitializeComponent();
            OBS.Visible = false;
            OBS.Enabled = false;
            Print.Visible = true;
            Print.Enabled = true;
            aviso.Text = "";
            aviso.Visible = false;
            aviso.Enabled = false;
            this.ControlBox = false;
            this.Text = null;
            // Cria um novo DataTable
            dt = new DataTable();

            // Adiciona as colunas "Produto" e "Preço" ao DataTable
            dt.Columns.Add("Produto");
            dt.Columns.Add("Preço");

            // Adiciona a nova coluna ao DataTable "dt"
            dt.Columns.Add(new DataColumn("Quantidade", typeof(decimal)));

            // Adiciona os dados da lista de bolos ao DataTable
            foreach (Bolo bolo in BoloManager.ListaBolo)
            {
                // Cria uma nova linha do DataTable
                DataRow row = dt.NewRow();

                // Define os valores das células
                row["Produto"] = bolo.Nome;
                row["Preço"] = bolo.preço;
                row["Quantidade"] = bolo.Quantidade;
                

                // Adiciona a linha ao DataTable
                dt.Rows.Add(row);
            }
            // Define o DataTable como a fonte de dados do DataGridView
            Lista.DataSource = dt;
            Lista.ColumnHeadersVisible= true;
        }

        /// <summary>
        /// mostra a lista de itens do cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerLista_Load(object sender, EventArgs e)
        {
            
            Lista.DataSource = dt.DefaultView;
            Lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Lista.Columns["Preço"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Lista.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Lista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void Remov_Click(object sender, EventArgs e)
        {
            //
            if (Lista.Rows.Count <= 1) return;
            var aux1 = BoloManager.ListaBolo[Lista.CurrentRow.Index];
            var aux2 = Lista.CurrentRow.Index;
            BoloManager.LastBolo.Add(new BoloManager.RowItem
            {
                Item = aux1,
                Row = aux2
            });
            BoloManager.ListaBolo.RemoveAt(aux2);
            dt.Rows[aux2].Delete();
            Lista.DataSource = dt;
            aviso.Text = null;
        }


        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void VoltarAçao_Click(object sender, EventArgs e)
        {
            if (BoloManager.LastBolo.Count <= 0)
            {
                Task.Run(async () =>
                {
                    aviso.Text = "Não esiste remoção à ser desfeita";
                    aviso.Visible = true;
                    await Task.Delay(750);
                    aviso.Text = "";
                    aviso.Visible = false;
                });
            }
            else
            {
                aviso.Text = null;

                // criar nova linha de dados e preencher com informações do item recuperado
                DataRow row = dt.NewRow();
                row["Produto"] = BoloManager.LastBolo[BoloManager.LastBolo.Count - 1].Item.Nome;
                row["Preço"] = BoloManager.LastBolo[BoloManager.LastBolo.Count - 1].Item.preço;
                row["Quantidade"] = BoloManager.LastBolo[BoloManager.LastBolo.Count - 1].Item.Quantidade;

                // inserir nova linha de dados na posição original do item removido
                dt.Rows.InsertAt(row, BoloManager.LastBolo[BoloManager.LastBolo.Last()].Row);
                BoloManager.ListaBolo.AddAt(BoloManager.LastBolo[BoloManager.LastBolo.Last()].Row, BoloManager.LastBolo[BoloManager.LastBolo.Last()].Item);
                BoloManager.LastBolo.RemoveAt(BoloManager.LastBolo.Last());

                // atualizar a fonte de dados do componente Lista
                Lista.DataSource = dt;
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Close();
        }

        private void OBS_Click(object sender, EventArgs e)
        {

        }

        private void Lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
