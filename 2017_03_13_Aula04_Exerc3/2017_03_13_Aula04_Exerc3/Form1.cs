using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2017_03_13_Aula04_Exerc3
{
    public partial class fmTelaIMC : Form
    {
        Pessoa[] pessoas;
        private String[] dadosArquivo, dataNascimento;
        private int dia, mes, ano;
        private int i = 0, j = 0; // i = pessoas; j = dadosArquivo

        public void SplitArquivo()
        {
            String textoArquivo;

            using (StreamReader read = new StreamReader(@"dadosPessoas.txt"))
            {
                textoArquivo = read.ReadToEnd();

                textoArquivo = textoArquivo.Replace("\r", "");

                dadosArquivo = textoArquivo.Split(':', '\n');

                read.Close();
            }
        }

        public void PreencherVetor()
        {
            int j = 0;

            for (; i < pessoas.Length; i++)
            {
                pessoas[i] = new Pessoa(dadosArquivo[j], double.Parse(dadosArquivo[j+1]), double.Parse(dadosArquivo[j+2]));
                j += 3;
            }
        }

        public fmTelaIMC()
        {
            SplitArquivo();

            pessoas = new Pessoa[10];

            PreencherVetor();

            dataNascimento = dadosArquivo[0].Split('/');

            dia = int.Parse(dataNascimento[0]);
            mes = int.Parse(dataNascimento[1]);
            ano = int.Parse(dataNascimento[2]);

            InitializeComponent();
        }

        private void btVerCadastros_Click_1(object sender, EventArgs e)
        {
            ltbCadastros.Items.Add("Data nascimento |   Peso (kg)   |   Altura (m)  |   Idade   |   IMC ");
            ltbCadastros.Items.Add(dadosArquivo[0] + "         |   " + dadosArquivo[1] + "           |   " + dadosArquivo[2]
                                    + " |   " + pessoas[0].IdadeAtual(dia, mes, ano) + "    |   " + pessoas[0].CalcularIMC());
            ltbCadastros.Items.Add(dadosArquivo[3] + "         |   " + dadosArquivo[4] + "              |   " + dadosArquivo[5]);
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            pessoas[i] = new Pessoa(mtbDataNasc.Text, double.Parse(tbPeso.Text), double.Parse(mtbAltura.Text));

            ltbCadastros.Items.Add(mtbDataNasc.Text + "         |   " + tbPeso.Text + "           |   " + mtbAltura.Text
                                    + " |   " + pessoas[i].IdadeAtual(dia, mes, ano) + "    |   " + pessoas[i].CalcularIMC());
        }

        private void btVerCadastros_Click(object sender, EventArgs e)
        {
            
        }

        private void ltbCadastros_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
