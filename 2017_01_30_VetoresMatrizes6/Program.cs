/*Faça um programa que leia um vetor inteiro de 30 posições e crie um segundo vetor, substituindo os
valores nulos por 1. Mostre os dois vetores.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_01_30_VetoresMatrizes6
{
    class Program
    {
        static void PreencherVetor(int[] vetor1)
        {
            Random r = new Random();

            for (int i = 5; i < vetor1.Length; i++)
            {
                vetor1[i] = r.Next(0, 5);
            }
        }

        static void ImprimirVetor(int[] vetor1)
        {
            int cont = 1;

            foreach (int i in vetor1)
            {
                Console.WriteLine(cont + ") " + i);
                cont++;
            }
        }

        // O programador deve informar qual valor deseja substituir no vetor (0, no caso) e qual valor deseja adicionar em seu lugar.
        static int[] SubstituirValoresVetor(int[] vetor1, int valorOriginal, int valorSubstituto)
        {
            int[] vetorSubstituto = new int[vetor1.Length];
            vetor1.CopyTo(vetorSubstituto, 0);

            for (int i = 0; i < vetor1.Length; i++)
            {
                if (vetor1[i] == valorOriginal)
                {
                    vetorSubstituto[i] = valorSubstituto;
                }
            }

            return vetorSubstituto;
        }

        static void Main(string[] args)
        {
            int valorOriginal, valorSubstituto;
            int[] vetor1, vetorSubstituto;
            vetor1 = new int[30];
            vetorSubstituto = new int[vetor1.Length];

            Console.Write("\nValor original: ");
            valorOriginal = int.Parse(Console.ReadLine());

            Console.Write("\nValor substituto: ");
            valorSubstituto = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 30));

            PreencherVetor(vetor1);
            vetorSubstituto = SubstituirValoresVetor(vetor1, valorOriginal, valorSubstituto);

            Console.WriteLine("Vetor original:\n");
            ImprimirVetor(vetor1);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Vetor substituto: ({0} substituído por {1}).\n", valorOriginal, valorSubstituto);
            ImprimirVetor(vetorSubstituto);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);


        }
    }
}
