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
        Timer relogio = new Timer();

        Relogio relogioMestreCaram = new Relogio();

        public Form1()
        {
            InitializeComponent();

            pbImagemMicroondas.ImageLocation = @"imagens\microondasLuzDesligada.jpg";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            relogio.Tick += new EventHandler(timerRelogio_Tick);

            relogio.Start();
        }


        private void bt1_Click(object sender, EventArgs e)
        {

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            
        }

        private void mtbRelogio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;

            string tempo = "";

            if (h < 10)
                tempo += "0" + h;
            else
                tempo += h;

            tempo += ":";

            if (m < 10)
                tempo += "0" + m;
            else
                tempo += m;

            lbRelogio.Text = tempo;
        }

        private void btLigar_Click(object sender, EventArgs e)
        {
            pbImagemMicroondas.ImageLocation = @"imagens\microondasLuzLigada.jpg";

            pbImagemMicroondas.Load();
        }

        private void btDesliga_Click(object sender, EventArgs e)
        {
            pbImagemMicroondas.ImageLocation = @"imagens\microondasLuzDesligada.jpg";

            pbImagemMicroondas.Load();
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            // Continuar daqui: como verificar qual é a imagem atual na pictureBOx?
            if (pbImagemMicroondas.ImageLocation == @"imagens\microondasLuzDesligada.jpg")
            {
                pbImagemMicroondas.ImageLocation = @"imagens\microondasLuzDesligadaAberto.jpg";
            }
            else if (pbImagemMicroondas.ImageLocation == @"imagens\microondasLuzDesligadaAberto.jpg")
            {
                pbImagemMicroondas.ImageLocation = @"imagens\microondasLuzDesligada.jpg";
            }

            pbImagemMicroondas.Load();
        }
    }
}
