/*4. Faça um programa que leia dois vetores de dez posições e faça a multiplicação dos elementos de mesmo
índice colocando o resultado em um terceiro vetor. Mostre o vetor resultante.

Obs.: Quando se compila o programa através da tecla "F11", ele funciona normalmente. Porém, quando executado diretamente pelo "F5", o objeto da classe
Random gera os mesmos valores para os 2 arrays, não sei por quê.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_01_28_VetoresMatrizes4
{
    class Program
    {
        static void PreencherVetor(int[] nomeVetor)
        {
            Random r = new Random();

            for (int i = 0; i < nomeVetor.Length; i++)
            {
                nomeVetor[i] = r.Next(10);
            }
        }

        static int[] MultiplicaElementosMesmoIndice(int[] nomeVetor1, int[] nomeVetor2)
        {
            int[] vetorResultante;
            
            // vetorResultante deve ser do tamanho do menor vetor, pois só serão multiplicados os números enquanto houverem posições nos 2 vetores.
            if (nomeVetor1.Length > nomeVetor2.Length) vetorResultante = new int[nomeVetor2.Length];
            else vetorResultante = new int[nomeVetor1.Length];

            for (int i = 0; i < vetorResultante.Length; i++)
            {
                vetorResultante[i] = nomeVetor1[i] * nomeVetor2[i];
            }

            return vetorResultante;
        }

        static void ImprimeArray(int[] nomeArray)
        {
            int cont = 1;

            //foreach (int i in nomeArray)
            for (int i = 0; i < nomeArray.Length; i++)
            {
                Console.WriteLine(i + 1 + ") " + nomeArray[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] vetor1, vetor2, vetorResultante;
            vetor1 = new int[10];
            vetor2 = new int[10];

            if (vetor1.Length > vetor2.Length) vetorResultante = new int[vetor2.Length];
            else vetorResultante = new int[vetor1.Length];
            
            PreencherVetor(vetor1);
            PreencherVetor(vetor2);

            vetorResultante = MultiplicaElementosMesmoIndice(vetor1, vetor2);

            Console.WriteLine("Elementos vetor 1:\n");
            ImprimeArray(vetor1);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Elementos vetor 2:\n");
            ImprimeArray(vetor2);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Elementos de mesmo índice multiplicados:\n");
            ImprimeArray(vetorResultante);

            Console.WriteLine("\n\nPressione qualquer tecla para encerrar.");
            Console.ReadKey(true);
        }
    }
}
