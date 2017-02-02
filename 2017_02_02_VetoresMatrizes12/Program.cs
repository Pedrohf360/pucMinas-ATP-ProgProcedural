/*Faça um programa que carregue uma matriz 2 x 4 com números inteiros, calcule e mostre:
 a quantidade de elementos entre 12 e 20 em cada linha:
 a média dos elementos pares da matriz.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_02_VetoresMatrizes12
{
    class Program
    {
        const int ERRO = -1;

        static void PreencherMatriz(int[,] matriz1)
        {
            Random r = new Random();

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    matriz1[i, j] = r.Next(5, 20);
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

        static int QuantidElementEntre2Valores(int[,] matriz1, int linhaAtual ,int valorMenor, int valorMaior)
        {
            int quantElementosLinha = 0;

            for (int i = linhaAtual; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    if (matriz1[i, j] >= valorMenor && matriz1[i, j] <= valorMaior)
                    {
                        quantElementosLinha++;
                    }
                }
                return quantElementosLinha;
            }

            return ERRO;
        }

        static double SomaElementosPares(int[,] matriz1, ref int quantidElementPares)
        {
            int somaElementosPares = 0;
            quantidElementPares = 0;

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    if (matriz1[i, j] % 2 == 0)
                    {
                        somaElementosPares += matriz1[i, j];
                        quantidElementPares++;
                    }
                }
            }

            return somaElementosPares;
        }

        static double MediaElementosPares(int[,] matriz1)
        {
            double mediaElementosPares = 0;
            double somaElementosPares = 0, quantidElementPares = 0;

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    if (matriz1[i, j] % 2 == 0)
                    {
                        somaElementosPares += matriz1[i, j];
                        quantidElementPares++;
                    }
                }
            }

            mediaElementosPares = somaElementosPares / quantidElementPares;

            return mediaElementosPares;
        }

        static void Main(string[] args)
        {
            double mediaElementosParesMatriz;
            int valorMenor, valorMaior, quantidElementEntre2Valores;
            int[,] matriz1;
            matriz1 = new int[2, 4];

            Console.WriteLine("Digite o intervalo que deseja analisar:\n");

            Console.Write("Valor menor: ");
            valorMenor = int.Parse(Console.ReadLine());

            Console.Write("\nValor maior: ");
            valorMaior = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey(true);
            Console.Clear();

            PreencherMatriz(matriz1);

            Console.WriteLine("Matriz original:\n");
            ImprimirMatriz(matriz1);
            Console.WriteLine(new string('-', 50));

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                quantidElementEntre2Valores = QuantidElementEntre2Valores(matriz1, i, valorMenor, valorMaior);

                Console.WriteLine("A quantidade de elementos entre {0} e {1}, na linha {2} da matriz informada = {3}.\n", valorMenor, valorMaior, i+1, quantidElementEntre2Valores);
            }

            Console.WriteLine(new string('-', 50));

            mediaElementosParesMatriz = MediaElementosPares(matriz1);
            Console.WriteLine("\nMédia dos elementos pares da matriz: {0:N2}.", mediaElementosParesMatriz);

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
