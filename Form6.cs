using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Project
{
    public partial class Form6 : Form
    {
        private bool aux;
        public Form6()
        {
            InitializeComponent();
            aux = false;
            this.ControlBox = false;
            this.Text = null;
            CheckBox1.Checked = false;
            CheckBox1.Text = "Não pago";
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Dia.Maximum = 30;
            Dia.Value = 1;
        }

        private void Definir_Click(object sender, EventArgs e)
        {
            if(!aux)
            {
                Definir.Text = "Confirma?";
                aux = true;
                return;
            }
            Atual.Reserv = new Reserva();
            Atual.Reserv.Hora.Hour = this.Hora.Text.Split(':')[0].Replace(":", "").Trim();
            Atual.Reserv.Hora.Min = this.Hora.Text.Split(':')[1].Replace(":", "").Trim();
            Atual.Reserv.Data = new Date((int)Dia.Value, Mes.SelectedIndex+1);
            PrintF.PrintFile(this.CheckBox1.Checked);
            this.Close();
        }

        private void Mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            aux = false;
        }

        private void Dia_Enter(object sender, EventArgs e)
        {
            aux = false;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                CheckBox1.Text = "Pago";
            }
            else
            {
                CheckBox1.Text = "Não pago";
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            

        }
    }
}
