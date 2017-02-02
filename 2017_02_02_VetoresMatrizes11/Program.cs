/*Faça um programa que carregue uma matriz 3 x 5 com números inteiros, calcule e mostre a quantidade
de elementos entre 15 e 20.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_02_VetoresMatrizes11
{
    class Program
    {
        static void PreencherMatriz(int[,] matriz1)
        {
            Random r = new Random();

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    matriz1[i, j] = r.Next(10, 20);
                }
            }
        }

        static void ImprimirMatriz(int[,] matriz1)
        {
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write(matriz1[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int QuantElementEntre2Valores(int[,] matriz1, int valorMenor, int valorMaior)
        {
            int quantElement = 0;

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    if (matriz1[i, j] >= valorMenor && matriz1[i, j] <= valorMaior)
                    {
                        quantElement++;
                    }
                }
            }

            return quantElement;
        }

        static void Main(string[] args)
        {
            int valorMenor, valorMaior, quantElementosEntre2Valores;
            int[,] matriz1;
            matriz1 = new int[3, 5];

            Console.WriteLine("Identificar quantidade de valores entre:\n");

            Console.Write("Menor valor: ");
            valorMenor = int.Parse(Console.ReadLine());

            Console.Write("\nMaior valor: ");
            valorMaior = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey(true);
            Console.Clear();

            PreencherMatriz(matriz1);
            quantElementosEntre2Valores = QuantElementEntre2Valores(matriz1, valorMenor, valorMaior);

            Console.WriteLine("Matriz informada:\n");
            ImprimirMatriz(matriz1);
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("\nA matriz informada possui {0} elementos entre {1} e {2}.", quantElementosEntre2Valores, valorMenor, valorMaior);

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
