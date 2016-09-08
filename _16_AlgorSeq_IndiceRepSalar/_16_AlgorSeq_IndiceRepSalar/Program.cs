using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_AlgorSeq_IndiceRepSalar
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIÁVEIS
            int codFunc;
            float indRep, indProd, salAtual, salNovo, aumento;



            //ENTRADA
            Console.Write("Digite o código do respectivo funcionário: ");
            codFunc = int.Parse(Console.ReadLine());

            Console.Write("Salário atual: ");
            salAtual = float.Parse(Console.ReadLine());

            Console.Write("Índice de reposição (tempo de trabalho na empresa, em anos: 1 a 40+)): ");
            indRep = float.Parse(Console.ReadLine());

            Console.Write("Índice de produtividade (0 a 10)): ");
            indProd = float.Parse(Console.ReadLine());

            while (codFunc <= 0 || salAtual <= 0 || indRep <= 0 || indProd <= 0)
            {
                Console.WriteLine("Verifique as informações inseridas e tente novamente.");

                Console.Write("\nDigite o código do respectivo funcionário: ");
                codFunc = int.Parse(Console.ReadLine());

                Console.Write("Salário atual: ");
                salAtual = float.Parse(Console.ReadLine());

                Console.Write("Índice de reposição (tempo de trabalho na empresa, em anos: 1 a 40+)): ");
                indRep = float.Parse(Console.ReadLine());

                Console.Write("Índice de produtividade (0 a 10)): ");
                indProd = float.Parse(Console.ReadLine());

            }

            

            //PROCESSAMENTO
            if (indRep < 4)
            {
                aumento = 500 + (500 * (indProd/100));
            } else if (indRep < 8)
            {
                aumento = 1500 + (1500 * (indProd/100));
            }
            else if(indRep >=8)
            {
                aumento = 2000 + (2000 * (indProd / 100));
            }
            else {
                aumento = 0;
            }
            salNovo = salAtual + indRep;

            //SAÍDA
           Console.Write("----------------------------------------------------------");

           Console.Write("\nCódigo do funcionário: {0}.\n\nSalário atual: R$ {1:N2}.", codFunc, salAtual);
           Console.Write("\tAumento salarial: R$ {0:N2}.\tNovo salário R$ {1:N2}.", aumento, salNovo);

           Console.ForegroundColor = ConsoleColor.White;
           Console.WriteLine("\n\nPressione qualquer tecla para sair.");
           Console.ReadKey(true);
           Console.ResetColor();
            
        }
    }
}
