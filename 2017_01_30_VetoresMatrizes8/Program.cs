/*Faça um programa que leia dois vetores (A e B) de cinco posições de números inteiros. O programa
deve, então. subtrair o primeiro elemento de A do último de B, acumulando o valor, subtrair o segundo
elemento de A do penúltimo de B, acumulando o valor e assim por diante. Mostre o resultado da soma
de todas as subtrações.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_01_30_VetoresMatrizes8
{
    class Program
    {
        static void PreencherVetor(int[] vetor1)
        {
            Random r = new Random();

            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = r.Next(10);
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

        static int[] SubtraiVetores(int[] vetor1, int[] vetor2)
        {
            int indexVetor2 = vetor2.Length - 1;
            int[] vetorResultante;
            vetorResultante = new int[vetor1.Length];

            for (int i = 0; i < vetor1.Length; i++)
            {
                vetorResultante[i] = vetor1[i] - vetor2[indexVetor2];
                indexVetor2--; 
            }

            return vetorResultante;
        }

        static void Main(string[] args)
        {
            int[] vetorA, vetorB, vetorResultante;
            vetorA = new int[5] { 2, 3, 4, 5, 6 };
            vetorB = new int[vetorA.Length];
            vetorResultante = new int[vetorA.Length];

            PreencherVetor(vetorB);

            vetorResultante = SubtraiVetores(vetorA, vetorB);

            Console.WriteLine("Vetor A:\n");
            ImprimirVetor(vetorA);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Vetor B:\n");
            ImprimirVetor(vetorB);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Vetor resultante:\n");
            ImprimirVetor(vetorResultante);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
