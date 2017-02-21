using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_01_28_VetoresMatrizes5
{
    class Program
    {
        static void PreencherVetor(int[] nomeVetor, int intervalo1, int intervalor2)
        {
            Random r = new Random();

            for (int i = 0; i < nomeVetor.Length; i++)
            {
                nomeVetor[i] = r.Next(intervalo1, intervalor2);
            }
        }

        static void ImprimeVetor(int[] nomeVetor)
        {
            int cont = 1;

            foreach (int i in nomeVetor)
            {
                Console.WriteLine(cont + ") " + i);
                cont++;
            }
        }

        static void ImprimeVetorPositivos(int[] nomeVetor, out int cont)
        {
            cont = 1;

            for (int i = 0; i < nomeVetor.Length; i++)
            {
                if (nomeVetor[i] >= 0)
                {
                    Console.WriteLine(cont + ") " + nomeVetor[i]);
                    cont++;
                }
            }

            cont--;
        }

        static void Main(string[] args)
        {
            int cont;
            int[] vetor1;
            vetor1 = new int[50];

            PreencherVetor(vetor1, -10, 5);

            Console.WriteLine("Vetor 1 completo:\n");
            ImprimeVetor(vetor1);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Valores positivos do vetor 1");
            ImprimeVetorPositivos(vetor1, out cont);

            Console.WriteLine("\nA quantidade de valores positivos = {0}", cont);

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
