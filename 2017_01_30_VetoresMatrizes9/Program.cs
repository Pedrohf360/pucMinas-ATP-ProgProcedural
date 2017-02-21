/*Faça um programa que leia um vetor de 15 posições com números inteiros. Crie, a seguir. um vetor
resultante que contenha todos os números primos do vetor digitado. Escreva o vetor resultante
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_01_30_VetoresMatrizes9
{
    class Program
    {
        static void PreencherVetor(int[] vetor1)
        {
            for (int i = 1; i < vetor1.Length; i++)
            {
                vetor1[i] = i;
            }
        }

        static void ImprimirVetor(int[] vetor1)
        {
            int cont = 1;

            for (int i = 0; i < vetor1.Length;)
            {
                if (vetor1[i] > 0)
                {
                    Console.WriteLine(cont + ") " + vetor1[i]);
                    cont++;
                }

                i++;
            }
        }

        // Verificar se as posições do vetor divididas por números de 2 a 10 possuem resto 0 em algum caso. Se sim, não é primo.
        static int[] VetorValoresPrimos(int[] vetor1)
        {
            int testePrimo = 0;
            int[] vetorResultante;
            vetorResultante = new int[vetor1.Length];

            for (int i = 0; i < vetor1.Length; i++)
            {
                if (vetor1[i] == 1) continue;

                if (vetor1[i] > 10)
                {
                    for (int j = 2; j < vetor1[i]; j++)
                    {
                        if (vetor1[i] % j == 0 || vetor1[i] == 1)
                        {
                            testePrimo++;
                            break;
                        }
                    }
                }
                else
                {
                    for (int j = 2; j < vetor1[i]; j++)
                    {
                        if (vetor1[i] % j == 0 || vetor1[i] == 1)
                        {
                            testePrimo++;
                            break;
                        }
                    }
                }
                if (testePrimo == 0) vetorResultante[i] = vetor1[i];
                testePrimo = 0;
            }

            return vetorResultante;
        }

        static void Main(string[] args)
        {
            int[] vetor1, vetorResultante;
            vetor1 = new int[100];
            vetorResultante = new int[vetor1.Length];

            PreencherVetor(vetor1);
            vetorResultante = VetorValoresPrimos(vetor1);

            Console.WriteLine("Vetor original:\n");
            ImprimirVetor(vetor1);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Vetor apenas com valores primos:\n");
            ImprimirVetor(vetorResultante);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
