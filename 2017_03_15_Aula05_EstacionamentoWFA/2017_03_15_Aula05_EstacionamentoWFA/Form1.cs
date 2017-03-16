using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_03_15_Aula05_EstacionamentoWFA
{
    public partial class frmControleEstacionamento : Form
    {
        const int TOTALVAGAS = 10; // Por padrão, constantes são statics.
        Carro[] estacionamento;
        int contCarros;

        public frmControleEstacionamento()
        {
            estacionamento = new Carro[TOTALVAGAS];
            contCarros = 0;
            InitializeComponent();
        }

        private void btEntrada(object sender, EventArgs e)
        {
            string auxPlaca = mtbPlaca.Text;
            Carro novoCarro = new Carro(auxPlaca);
            String[] horaEntrada = mtbHora.Text.Split(':');
            novoCarro.setHoraEntrada(horaEntrada[0], horaEntrada[1]);

            if (contCarros < TOTALVAGAS)
            {
                estacionamento[contCarros] = novoCarro;
                contCarros++;
                lbVagas.Text = "Carros Estacionados: " + contCarros;
            }
            else
            {
                lbVagas.Text = "Vagas esgotadas"
            }

            mtbHora.Clear();
            mtbPlaca.Clear();
            mtbPlaca.Focus();
        }

        private void btListar(object sender, EventArgs e)
        {
            lbCarros.Items.Clear();
            for (int i = 0; i < contCarros; i++)
            {
                lbCarros.Items.Add(estacionamento[i].getPlaca() + " | " +
                    estacionamento[i].getHoraEntrada().ToShortTimeString());
            }
        }

        private void btnCalcularValores(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;
            int auxPos = lbCarros.SelectedIndex;

            if (auxPos == 1)
            {
                lbVagas.Text = "Selecione um carro.";
            }
            else
            {
                estacionamento[auxPos].setHoraSaida(DateTime.Now.Hour, DateTime.Now.Minute);
                string placa = estacionamento[auxPos].getPlaca();
                double valAux = estacionamento[auxPos].TarifaPagar();
                lbCarros.Items[auxPos] = (placa + " | " + estacionamento[auxPos].getHoraEntrada().ToShortTimeString() + " | " +
                    estacionamento[auxPos].getHoraSaida().ToShortTimeString() + " | " + String.Format("{0:c}", valAux));
            }
        }
    }
}
