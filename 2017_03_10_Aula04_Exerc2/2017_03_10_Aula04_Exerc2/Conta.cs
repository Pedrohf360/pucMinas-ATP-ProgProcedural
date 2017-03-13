using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_10_Aula04_Exerc2
{
    class Conta
    {
        private const int ERRO = -1; // Variável criada apenas para ser retornada em caso de incoerência de dados informados pelo usuário.
        public String titular; // nome do titular da conta
        public int agencia; // número da agência da conta
        public int numConta; // número da conta
        private int tipoConta; // indica o tipo da conta: 1) conta-corrente, 2) poupança, 3) investimento
        private double saldoBruto; // saldo atual da conta

        public Conta(String nome, int ag, int numC, int tipo, double saldoInicial)
        {
            this.titular = nome;
            this.agencia = ag;
            this.numConta = numC;
            this.tipoConta = tipo;
            this.saldoBruto = saldoInicial;
        }

        // 1) conta-corrente, 2) poupança, 3) investimento
        public double ObterSaldo()
        {
            double saldoLiquido;

            if (this.tipoConta == 1)
                return this.saldoBruto;

            if (this.tipoConta == 2)
                return this.saldoBruto + this.saldoBruto * 0.0050;

            if (this.tipoConta == 3)
                return saldoLiquido = this.saldoBruto + this.saldoBruto * 0.0065 - this.saldoBruto * 0.15;

            return ERRO;
        }

        public void Depositar(double credito)
        {
            if (credito >= 0) this.saldoBruto += credito;
        }

        public void Sacar(double quantia)
        {
            if (quantia >= 0 && this.saldoBruto >= quantia) this.saldoBruto -= quantia;
        }

    }
}