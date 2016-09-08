using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_AlgorSeq_CalcPrestAtraso
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIÁVEIS
            float valOrigPrest, valFinalPrest, valJuroMes, multa;
            int tempo;

            //ENTRADA
            Console.Write("Qual é o valor original da prestação? ");
            valOrigPrest = float.Parse(Console.ReadLine());

            Console.Write("Qual é o valor do juro mensal? ");
            valJuroMes = float.Parse(Console.ReadLine());

            Console.Write("Quantos meses decorridos (do lançamento da fatura até o dia atual)? ");
            tempo = int.Parse(Console.ReadLine());

            while (valOrigPrest <= 0 || valJuroMes <=0 || tempo <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nVerifique os valores digitados e tente novamente.");
                Console.ResetColor();

                Console.Write("\nQual é o valor original da prestação? ");
                valOrigPrest = float.Parse(Console.ReadLine());

                Console.Write("Qual é o valor do juro mensal? ");
                valJuroMes = float.Parse(Console.ReadLine());

                Console.Write("Quantos meses decorridos (do lançamento da fatura até o dia atual)? ");
                tempo = int.Parse(Console.ReadLine());
            }

            //PROCESSAMENTO
            multa = (valOrigPrest * (valJuroMes / 100) * tempo);
            valFinalPrest = valOrigPrest + multa;

            //SAÍDA
            Console.WriteLine("--------------------------------------------------------------------------\n\tPrestação original: R$ {0:N2}.", valOrigPrest);
            Console.WriteLine("\n\tTaxa de juros (simples): {0}%.", valJuroMes);
            Console.WriteLine("\n\tValor final (multa incluída): R$ {0:N2}.", valFinalPrest);

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
            //PREST = VALOR+ ( VALOR * (TAXA/100) *TEMPO)
        }
    }
}
