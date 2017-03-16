using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_13_Aula04_Exerc3
{
    class Pessoa
    {
        private String dataNascimento;
        private double peso;
        private double altura;

        public Pessoa(String dataNasc, double peso, double altura)
        {
            this.dataNascimento = dataNasc;
            this.peso = peso;
            this.altura = altura;
        }

        public TimeSpan IdadeAtual(int diaNasc, int mesNasc, int anoNasc)
        {
            DateTime nascimento = new DateTime(anoNasc, mesNasc, diaNasc);

            TimeSpan t = DateTime.Now.Date.Subtract(nascimento);

            return t;
        }

        public double CalcularIMC()
        {
            return this.peso / (this.altura * this.altura);
        }

        public double Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }

        public double Altura
        {
            get { return this.altura; }
            set { this.altura = value; }
        }

        public String DataNasc
        {
            get { return this.dataNascimento; }
            set { this.dataNascimento = value; }
        }
    }
}
