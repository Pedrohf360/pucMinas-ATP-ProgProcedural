/*
 * Este programa não pôde ser devidamente desenvolvimento, pois o código fornecido pelo professor, no qual devemos nos basear p/ realizar a
 * atividade, está incorreto (efetua cálculo errôneamente). Além do mais, o prazo p/ entrega do mesmo já passou, então tanto faz kkk.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_04_27_Aula08_Classes_Interface
{
    public partial class Form1 : Form
    {
        ContaInvestimento conta;

        public Form1()
        {
            InitializeComponent();

            conta = new ContaInvestimento(123456789);
            cbxOperacao.Items.Add("Rendimento");
            cbxOperacao.Items.Add("Imposto");
        }

        private void btSimular_Click(object sender, EventArgs e)
        {
            double deposito = double.Parse(tbxDeposito.Text);

            double juros = double.Parse(tbxJuros.Text);

            int meses = int.Parse(tbxMeses.Text);

            double saldoSimulado = 0;

            object tipo = cbxOperacao.SelectedItem;

            if (tipo.Equals("Rendimento"))
                saldoSimulado = conta.SimulaInvestimento(new Rendimento(), deposito, juros, meses);
            else if (tipo.Equals("Imposto"))
                saldoSimulado = conta.SimulaInvestimento(new Imposto(), deposito, juros, meses);

            MessageBox.Show("Resultado da Simulação: " + saldoSimulado);
        }
    }
}
