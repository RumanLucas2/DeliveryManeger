using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace Project
{
    public struct Bolo
    {
        public string Nome;
        public int Quantidade;
        public string preço;
        public string OBS;
    }
    

    public partial class Pedido : Form
    {
        public Pedido()
        { 
            InitializeComponent();
            voltar.Text = "voltar";
            this.ControlBox = false;
            this.Text = null;
            //garante que todos os clientes terão bolos diferentes
            BoloManager.ListaBolo = new BoloManager.MyList();
            BoloManager.LastBolo = new BoloManager.MyClass();
            //espera o termino da chamada assíncrona
            if (!First_Time.StartDataTable().IsCompleted)
            {
                First_Time.StartDataTable().Wait();
            }
            //salva a data view
            lista.DataSource = First_Time.DT.DefaultView;
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            //iniciar qtt
            qtt.Value = 0;
            qtt.Enabled = false;
            aviso.Multiline = true;
            aviso.Visible = false;
            TotalTxt.Text = "0";
            QuantidadeDeBolos.Text = "0";
            //iniciar ver lista
            compra.Visible = false;
            compra.Enabled = false;
            //deixa a lista de uma forma mais visivel
            lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            lista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            if(NomeTXT.Text == string.Empty)
            {
                aviso.Text = "Escolha um produto primeiro";
            }
            else
            {
                if (qtt.Value <= 0)
                {
                    aviso.Text = "Quantidade precisa ser maior que 0";
                    aviso.Visible = true;
                }
                else
                {
                    aviso.Visible = false;
                    compra.Visible = true;
                    compra.Enabled = true;
                    BoloManager.ListaBolo.Add(new Bolo
                    {
                        Nome = NomeTXT.Text,
                        preço = PreçoTXT.Text,
                        Quantidade = ((int)qtt.Value),
                    });
                    QuantidadeDeBolos.Text = $"{int.Parse(QuantidadeDeBolos.Text) + (int)qtt.Value}";
                    TotalTxt.Text = $"R$ {int.Parse(TotalTxt.Text.Replace("$", "").Replace("R", "")) + (int.Parse(PreçoTXT.Text.Replace("$", "").Replace("R", "")) * (int)qtt.Value)}";
                }
            }
        }

        private void VerLista_Click(object sender, EventArgs e)
        {
            VerLista w = new VerLista();
            w.Show();
            this.Close();
        }

        private void Busca_Mudou(object sender, EventArgs e)
        {
            DataView dv = First_Time.DT.DefaultView;
            dv.RowFilter = string.Format("Produto like '%" + Busca.Text + "%'");
            lista.DataSource = dv.ToTable();
        }

        private void Lista_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NomeTXT.Text = lista.Rows[e.RowIndex].Cells[0].Value.ToString();
            PreçoTXT.Text = lista.Rows[e.RowIndex].Cells[1].Value.ToString();
            qtt.Enabled = true;
            qtt.Value = 1;
        }

        private void Escolher_Click(object sender, EventArgs e)
        {
            NomeTXT.Text = lista.Rows[lista.CurrentRow.Index].Cells[0].Value.ToString();
            PreçoTXT.Text = lista.Rows[lista.CurrentRow.Index].Cells[1].Value.ToString();
            qtt.Enabled = true;
            qtt.Value = 1;
        }
    }


    public static class BoloManager
    {
        public static MyList ListaBolo = new MyList();// Inicializa a lista vazia

        public static MyClass LastBolo { get; set; } = new MyClass();

        public class MyList : List<Bolo>
        {

            public int Value { get; set; } = 0;
            public void AddAt(int index, Bolo item)
            {
                if (index < 0 || index > Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                if (index == Count)
                {
                    Add(item);
                }
                else
                {
                    Insert(index, item);
                }
            }
            public new void Add(Bolo Item)
            {
                this.Value += int.Parse(Item.preço.Replace("R", "").Replace("$", "").Trim())*Item.Quantidade;
                base.Add(Item);
            }

            public new void Insert(int index, Bolo Item)
            {
                this.Value += int.Parse(Item.preço.Replace("R", "").Replace("$", "").Trim()) * Item.Quantidade;
                base.Insert(index, Item);
            }

            public new void RemoveAt(int index)
            {
                
                this.Value -= int.Parse(this[index].preço.Replace("R", "").Replace("$", "").Trim()) * this[index].Quantidade;
                base.RemoveAt(index);
            }
        }

        public class MyClass : List<RowItem>
        {
            public void AddAt(int index, RowItem item)
            {
                if (index < 0 || index > Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                if (index == Count)
                {
                    Add(item);
                }
                else
                {
                    Insert(index, item);
                }
            }
            public int Last()
            {
                return Count-1;
            }
        }

        public class RowItem
        {
            public int Row { get; set; }

            public Bolo Item { get; set; } = new Bolo();

        }
    }
}
