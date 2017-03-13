using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_10_Aula04_Exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoValeTransporte cartao1, cartao2;

            cartao1 = new CartaoValeTransporte(21074, 50.00);

            Console.WriteLine("Saldo atual do cartão vale-transporte 1: R${0:N2}", cartao1.ObterSaldoAtual()); // R$ 50,00 

            cartao1.Pagar(2.80);
            Console.WriteLine("Saldo atual do cartão vale-transporte 1: R${0:N2}", cartao1.ObterSaldoAtual()); // R$ 47,20 

            cartao1.Pagar(1.40);
            Console.WriteLine("Saldo atual do cartão vale-transporte 1: R${0:N2}", cartao1.ObterSaldoAtual()); // R$ 45,80 

            cartao1.Carregar(5.00);
            Console.WriteLine("Saldo atual do cartão vale-transporte 1: R${0:N2}", cartao1.ObterSaldoAtual()); // R$ 50,80

            cartao2 = new CartaoValeTransporte(390176, 25.00);

            Console.WriteLine("Saldo atual do cartão vale-transporte 2: R${0:N2}", cartao2.ObterSaldoAtual()); // R$ 25,00

            cartao1.Bloquear(cartao2);

            Console.WriteLine("Saldo atual do cartão vale-transporte 1: R${0:N2}", cartao1.ObterSaldoAtual()); // R$ 0,00

            Console.WriteLine("Saldo atual do cartão vale-transporte 2: R${0:N2}", cartao2.ObterSaldoAtual()); // R$ 75,80

            Console.ReadKey();
        }
    }
}