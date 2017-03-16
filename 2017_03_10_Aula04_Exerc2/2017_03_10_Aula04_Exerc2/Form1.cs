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
    public partial class fmTelaCadastro : Form
    {
        Conta[] cliente;
        String[] dadosArquivos;
        int posAux;

        private void SplitArquivo()
        {
            String textoArquivo;

            using (StreamReader read = new StreamReader(@"dadosContas.txt"))
            {
                textoArquivo = read.ReadToEnd();

                textoArquivo = textoArquivo.Replace("\r", "");

                dadosArquivos = textoArquivo.Split(';', '\n', '\r');
            }
        }

        private void PreencherVetorClasse(Conta[] vetorClasse)
        {
            int count = 0;

            for (int i = 0; i < vetorClasse.Length; i++)
            {
                // Removendo hífen do número de conta, para armazená-lo no vetor de clientes como um tipo inteiro.
                // Remove (aPartirDe, excluirXvalores);
                dadosArquivos[count + 2] = dadosArquivos[count + 2].Remove(3, 1);

                cliente[i] = new Conta(dadosArquivos[count], // Nome titular;
                        int.Parse(dadosArquivos[count + 1]), // Agência;
                        int.Parse(dadosArquivos[count + 2]), // Núm. conta;
                        int.Parse(dadosArquivos[count + 3]), // Tipo conta;
                        double.Parse(dadosArquivos[count + 4])); // Saldo bruto.

                count += 5;
            }
        }

        public fmTelaCadastro()
        {
            posAux = 0;

            SplitArquivo();

            // Comprimento do vetor de classe: Comprimento vetor splitado / número de informações por cliente, contidas no arquivo txt lido neste programa.
            cliente = new Conta[dadosArquivos.Length / 5];

            PreencherVetorClasse(cliente);

            InitializeComponent();
        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            cliente[posAux].Depositar(double.Parse(tbValorOperacao.Text));

            lbSaldoNum.Text = "R$ " + cliente[posAux].ObterSaldo().ToString();
        }

        private void btSacar_Click(object sender, EventArgs e)
        {
            cliente[posAux].Sacar(double.Parse(tbValorOperacao.Text));

            lbSaldoNum.Text = "R$ " + cliente[posAux].ObterSaldo().ToString();
        }

        private void VerificarNomeCliente(object sender, EventArgs e)
        {
            tbNomeCliente.Text = tbNomeCliente.Text.ToUpper();

            for (int i = 0; i < cliente.Length; i++)
            {
                cliente[i].titular = cliente[i].titular.ToUpper();

                if (tbNomeCliente.Text.Equals(cliente[i].titular) == true)
                {
                    lbSaldoNum.Text = "R$ " + cliente[i].ObterSaldo().ToString();
                    lbAgenciaNum.Text = cliente[i].agencia.ToString();
                    lbContaNum.Text = cliente[i].numConta.ToString();
                    posAux = i;
                }
            }
        }
    }
}
