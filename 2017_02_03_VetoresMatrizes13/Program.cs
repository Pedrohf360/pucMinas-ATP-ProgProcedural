/*Faça um programa que carregue uma matriz 6 x 3, calcule e mostre:
 o maior elemento da matriz e sua respectiva posição. ou seja, linha e coluna:
 o menor elemento da matriz e sua respectiva posição. ou seja, linha e coluna.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_03_VetoresMatrizes13
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
                    matriz1[i, j] = r.Next(0, 20);
                }
            }
        }

        static void ImprimirMatriz(int[,] matriz1)
        {
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                Console.Write(i+1 + ") ");
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write("\t");
                    Console.Write(matriz1[i, j]);
                }
                Console.WriteLine();
            }
        }

        static int MaiorValorEposicaoMatriz(int[,] matriz1, ref int linha, ref int coluna)
        {
            int maiorValor = int.MinValue;

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    if (matriz1[i, j] > maiorValor)
                    {
                        maiorValor = matriz1[i, j];
                        linha = i + 1;
                        coluna = j + 1;
                    }
                }
            }

            return maiorValor;
        }

        static int MenorValorEposicaoMatriz(int[,] matriz1, ref int linha, ref int coluna)
        {
            int menorValor = int.MaxValue;

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    if (matriz1[i, j] < menorValor)
                    {
                        menorValor = matriz1[i, j];
                        linha = i + 1;
                        coluna = j + 1;
                    }
                }
            }

            return menorValor;
        }

        static int Menu()
        {
            int opcao = 0;
            Console.WriteLine("Digite a opção desejada:\n");

            Console.WriteLine("1) Exibir matriz;\n2) Exibir maior elemento da matriz e sua posição;\n3) Exibir menos elemeno da matriz e sua posição;\n4) Sair.");

            try
            {
                opcao = Convert.ToInt16(Console.ReadLine());
            } catch (Exception e)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + e.Message);
                Console.ResetColor();

                Console.WriteLine("\nPressione qualquer tecla para continuar.");
                Console.ReadKey(true);
                Console.Clear();
            }

            return opcao;
        }


        static void Main(string[] args)
        {
            int linha = 0, coluna = 0, maiorValorMatriz, menorValorMatriz, opcao;
            int[,] matriz1;
            matriz1 = new int[6, 3];

            PreencherMatriz(matriz1);

            do
            {
                opcao = Menu();

                switch (opcao)
                {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("Matriz original:\n");
                        ImprimirMatriz(matriz1);

                        Console.WriteLine("\n\nPressione qualquer tecla para continuar.");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();

                        maiorValorMatriz = MaiorValorEposicaoMatriz(matriz1, ref linha, ref coluna);
                        Console.Write("Maior valor da matriz: {0};\nPosição: linha {1}, coluna {2}.", maiorValorMatriz, linha, coluna);

                        Console.WriteLine("\n\nPressione qualquer tecla para continuar.");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();

                        menorValorMatriz = MenorValorEposicaoMatriz(matriz1, ref linha, ref coluna);
                        Console.Write("Menor valor da matriz: {0};\nPosição: linha {1}, coluna {2}.", menorValorMatriz, linha, coluna);

                        Console.WriteLine("\n\nPressione qualquer tecla para continuar.");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                }
            } while (opcao != 4);
        }
    }
}
