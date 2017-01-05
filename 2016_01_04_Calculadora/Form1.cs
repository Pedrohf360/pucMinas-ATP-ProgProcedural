using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2016_01_04_Calculadora
{
    public partial class Form1 : Form
    {
        Double total, ultimoNum;
        String operador;

        private void Limpar()
        {
            total = 0;
            ultimoNum = 0;
            operador = "+";
            tbResultado.Text = "0";
        }

        private void Calcular()
        {
            switch (operador)
            {
                case "+":
                    total = total + ultimoNum;
                    break;
                case "-":
                    total = total - ultimoNum;
                    break;
                case "*":
                    total = total * ultimoNum;
                    break;
                case "/":
                    total = total / ultimoNum;
                    break;
            }

            ultimoNum = 0;
            tbResultado.Text = total.ToString();
        }

        public Form1()
        {
            InitializeComponent();

            Limpar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtNumero(object sender, EventArgs e)
        {
            if (ultimoNum == 0)
            {
                tbResultado.Text = (sender as Button).Text;
            }
            else
            {
                tbResultado.Text = tbResultado.Text + (sender as Button).Text;
            }

            ultimoNum = Convert.ToDouble(tbResultado.Text);
        }

        private void BtOperador(object sender, EventArgs e)
        {
            ultimoNum = Convert.ToDouble(tbResultado.Text);

            Calcular();

            operador = (sender as Button).Text;
        }

        private void btIgualdade_Click(object sender, EventArgs e)
        {
            ultimoNum = Convert.ToDouble(tbResultado.Text);

            Calcular();

            operador = "+";

            total = 0;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
