using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_06_Aula07_AgregCompos_SistBanc
{
    class Conta
    {
        double saldo;
        Agencia agencia;

        public Conta(int saldo, Agencia agencia)
        {
            this.saldo = saldo;
            this.agencia = agencia;
        }

        // Deve-se verifica se a conta possui saldo suficiente para a transferência
        public void transfere(Conta destino, double valor)
        {
            if (this.saldo >= valor)
            {
                saldo -= valor;
                destino.saldo += valor;
            }
        }

        public void deposita(double valor)
        {
            saldo += valor;
        }

        public void saca(double valor)
        {
            if (this.saldo >= valor)
                saldo -= valor;
        }

        public void imprimeExtrato()
        {
            Console.WriteLine("Saldo atual: " + this.saldo);
        }

        public double Saldo
        {
            get { return this.saldo; }
            set {this.saldo = value;}
        }

        public Agencia Agencia
        {
            get { return this.agencia; }
            set { this.agencia = value; }
        }
    }
}
