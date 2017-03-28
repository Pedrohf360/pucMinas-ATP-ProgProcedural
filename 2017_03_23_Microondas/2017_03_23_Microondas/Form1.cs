using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POOLib;

namespace _2017_03_23_Microondas
{
    public partial class Form1 : Form
    {
        Microondas microwave = new Microondas();

        Timer timerHoras = new Timer();

        Relogio relogio = new Relogio();

        public Form1()
        {
            InitializeComponent();

            pbImagemMicroondas.ImageLocation = @"imagens\microondasLuzDesligada.jpg";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerHoras.Tick += new EventHandler(timerRelogio_Tick);

            timerHoras.Start();
        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            relogio.ajusteHora(DateTime.Now.Hour, DateTime.Now.Minute, 0);

            lbRelogio.Text = relogio.mostrarHora().Remove(5);

        }

        private void btLigar_Click(object sender, EventArgs e)
        {
            Console.Beep();

            pbImagemMicroondas.ImageLocation = @"imagens\microondasLuzLigada.jpg";

            pbImagemMicroondas.Load();

            // Indica que o microondas já estava ligado, com isso deve começar a decrementar o temporizador.
            if (microwave.Ligado == true && microwave.PortaAberta == false && int.Parse(lbRelogio.Text.Replace(":","")) != 0)
            {
                microwave.TemporizadorAtivo = true;

                microwave.AjusteTemporizador(int.Parse(lbRelogio.Text.Substring(0, 2)), int.Parse(lbRelogio.Text.Substring(3, 2)));

                timerDecrementa.Start();
            }
            else
            {
                timerHoras.Stop();

                lbRelogio.Text = "00:00";
            }

            microwave.Ligar();
        }

        private void btDesliga_Click(object sender, EventArgs e)
        {
            Console.Beep();

            pbImagemMicroondas.ImageLocation = @"imagens\microondasLuzDesligada.jpg";

            pbImagemMicroondas.Load();

            microwave.Desligar();

            timerDecrementa.Stop();

            timerHoras.Start();
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {

            if (pbImagemMicroondas.ImageLocation == @"imagens\microondasLuzDesligada.jpg")
            {
                pbImagemMicroondas.ImageLocation = @"imagens\microondasLuzDesligadaAberto.jpg";
                microwave.PortaAberta = true;
            }
            else if (pbImagemMicroondas.ImageLocation == @"imagens\microondasLuzDesligadaAberto.jpg")
            {
                pbImagemMicroondas.ImageLocation = @"imagens\microondasLuzDesligada.jpg";
                microwave.PortaAberta = false;
            }
            else if (microwave.TemporizadorAtivo == false && pbImagemMicroondas.ImageLocation == @"imagens\microondasLuzLigada.jpg")
            {
                pbImagemMicroondas.ImageLocation = @"imagens\microondasLuzLigadaAberto.jpg";
                microwave.PortaAberta = true;
            }
            else if (pbImagemMicroondas.ImageLocation == @"imagens\microondasLuzLigadaAberto.jpg")
            { 
                pbImagemMicroondas.ImageLocation = @"imagens\microondasLuzLigada.jpg";
                microwave.PortaAberta = false;
            }

            pbImagemMicroondas.Load();
        }

        /// <summary>
        /// O método da classe Microondas é chamado aqui, ajustando as horas do temporizador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormataTemporizador(object sender, EventArgs e)
        {
            if (lbRelogio.Text.Length == 1 || lbRelogio.Text.Length == 2) lbRelogio.Text = "00:00";

            if (microwave.Ligado == true)
            {
                Console.Beep();

                String tempoFormatado;
                tempoFormatado = lbRelogio.Text.Replace(":", "");

                tempoFormatado = tempoFormatado.Substring(1, 3) + (sender as Button).Text;

                lbRelogio.Text = tempoFormatado.Insert(2, ":");
            }
        }

        private void btPotencia_Click(object sender, EventArgs e)
        {
            if (microwave.Ligado == true)
            {
                Console.Beep();

                lbRelogio.Text = microwave.Potencia.ToString();
            }
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            if (microwave.Ligado == true)
            {
                Console.Beep();

                microwave.Potencia++;

                lbRelogio.Text = microwave.Potencia.ToString();
            }
        }

        private void btSubtrai_Click(object sender, EventArgs e)
        {
            if (microwave.Ligado == true)
            {
                Console.Beep();

                microwave.Potencia--;

                lbRelogio.Text = microwave.Potencia.ToString();
            }
        }

        private void timerDecrementa_Tick(object sender, EventArgs e)
        {
            int seg = microwave.TemporizadorSeg;
            int min = microwave.TemporizadorMin;

            seg--;

            if (seg == -1)
            {
                min--;
                seg = 59;
            }

            if (min == 0 && seg == 00)
            {
                timerDecrementa.Stop();

                microwave.TemporizadorAtivo = false;
            }

            microwave.AjusteTemporizador(min, seg);

            lbRelogio.Text = AjusteLabelTemporizador(min, seg);
        }

        private string AjusteLabelTemporizador(int min, int seg)
        {
            string textoFormatado = "";

            if (min < 10)
                textoFormatado = "0" + min;

            else if (min >= 10)
                textoFormatado += min;

            textoFormatado += ":";

            if (seg < 10)
                textoFormatado += "0" + seg;

            else if (seg > 10)
                textoFormatado += seg;

            return textoFormatado;
        }
    }
}
