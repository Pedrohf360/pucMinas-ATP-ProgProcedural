using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_06_03_Aula03_Exerc3_LPOO
{
    public partial class Form1 : Form
    {
        int volume = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btSomaVolume_Click(object sender, EventArgs e)
        {


            lbVolumeNum.Text = volume++.ToString();
        }

        private void btSubtraiVolume_Click(object sender, EventArgs e)
        {
           
        }

        private void btLigaDesl_Click(object sender, EventArgs e)
        {

        }

        private void btLigaDesl_Click_1(object sender, EventArgs e)
        {
            tbLigDesl.Text = "Ligar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbLigDesl.Text = "Desligar";
        }

        private void btSubtraiVolume_Click_1(object sender, EventArgs e)
        {
            lbVolumeNum.Text = volume--.ToString();
        }
    }
}
