using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_06_Aula07_AgregCompos_SistBanc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando relaciomaneto entre clientes e cartões de crédito.");
            Console.ReadKey();
            Console.Clear();

            Cliente c = new Cliente("Jõazin", 123);
            CartaoDeCredito cdc = new CartaoDeCredito(92318349, "10/19");
            
            c.Nome = "José da Silva";
            cdc.Numero = 111111;
            
            cdc.Cliente = c;

            Console.WriteLine("Press any key.");
            Console.ReadKey();

            //////////////////////////////////////////////////////////////////

            Console.WriteLine("Testando fatura...\n\n");
            Console.ReadKey();
            Console.Clear();

            Agencia a = new Agencia(1249);
            Conta conta = new Conta(1402, a);

            a.Numero = 178;
            conta.Saldo = 1000.0;

            conta.Agencia = a;

            ////////////////////////////////////////////////////////////////

            Console.WriteLine("Testando Métodos Conta...\n\n");
            Console.ReadKey();
            Console.Clear();

            conta.deposita(1000);
            conta.imprimeExtrato();

            Console.WriteLine("Saque de 100 reais...");
            Console.ReadKey();

            conta.saca(100);
            conta.imprimeExtrato();

            Console.WriteLine("FIM");
            Console.ReadKey();

            ////////////////////////////////////////////////////////////////

            Console.WriteLine("Testando fatura...\n\n");
            Console.ReadKey();
            Console.Clear();

            Fatura f = new Fatura(5000);
            f.adiciona(100);
            f.adiciona(200);

            f.imprimeDados();

            Console.WriteLine("Imprimir dados...");
            Console.ReadKey();
            Console.Clear();

            // ????
            double multa = f.calculaMulta();


        }
    }
}
