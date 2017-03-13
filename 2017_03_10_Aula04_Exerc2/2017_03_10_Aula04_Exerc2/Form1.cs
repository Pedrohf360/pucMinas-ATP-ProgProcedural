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

namespace _2017_03_10_Aula04_Exerc2
{
    public partial class Form1 : Form
    {
        Conta c = new Conta("Pedro H.", 2958, 123456789, 2, 500);

        String[] dadosArquivos;

        private String[] SplitArquivo()
        {
            String[] dadosArquivosAux;
            String textoArquivo;

            using (StreamReader read = new StreamReader(@"dadosContas.txt"))
            {
                textoArquivo = read.ReadToEnd();

                textoArquivo = textoArquivo.Replace("\r", "");

                dadosArquivosAux = textoArquivo.Split(';', '\n', '\r');
            }

            return dadosArquivosAux;
        }

        public Form1()
        {
            InitializeComponent();

            lbAgenciaNumero.Text = c.agencia.ToString();
            lbNumContaNumero.Text = c.numConta.ToString();
            lbSaldoNumero.Text = c.ObterSaldo().ToString();
            dadosArquivos = SplitArquivo();
        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            c.Depositar(double.Parse(tbValorOperacao.Text));

            lbSaldoNumero.Text = c.ObterSaldo().ToString();
        }

        private void btSacar_Click(object sender, EventArgs e)
        {
            c.Sacar(double.Parse(tbValorOperacao.Text));

            lbSaldoNumero.Text = c.ObterSaldo().ToString();
        }
    }
}
