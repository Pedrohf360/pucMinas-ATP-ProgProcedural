/*Faça um programa que leia um vetor de 15 posições de números inteiros e divida todos os seus elementos
pelo maior valor do vetor. Mostre o vetor após os cálculos.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_02_VetoresMatrizes10
{
    class Program
    {
        static void PreencherVetor(double[] vetor1)
        {
            Random r = new Random();

            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = r.Next(0, 30);
            }
        }

        static void ImprimirVetor(double[] vetor1)
        {
            int cont = 1;

            foreach (double i in vetor1)
            {
                Console.WriteLine(cont + ") "+ i);
                cont++;
            }
        }

        static double MaiorValorVetor(double[] vetor1)
        {
            double maiorValor = int.MinValue;

            for (int i = 0; i < vetor1.Length; i++)
            {
                if (vetor1[i] > maiorValor)
                {
                    maiorValor = vetor1[i];
                }
            }

            return maiorValor;
        }

        static double[] DividirPeloMaiorValor(double[] vetor1)
        {
            double maiorValor;
            maiorValor = MaiorValorVetor(vetor1);

            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] /= maiorValor;
            }

            return vetor1;
        }

        static void Main(string[] args)
        {
            double[] vetor1;
            vetor1 = new double[5];

            PreencherVetor(vetor1);

            Console.WriteLine("Vetor original:\n");
            ImprimirVetor(vetor1);
            Console.WriteLine(new string('-', 30));

            DividirPeloMaiorValor(vetor1);

            Console.WriteLine("Vetor após divisão de todos valores pelo maior valor:\n");
            ImprimirVetor(vetor1);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
