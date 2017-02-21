/*Faça um programa que leia um vetor de dez posições. Em seguida, compacte o vetor, retirando os
valores nulos e negativos. Coloque o resultado no vetor B, mostrando o vetor resultante.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_01_30_VetoresMatrizes7
{
    class Program
    {
        static void PreencherVetor(int[] vetor1)
        {
            Random r = new Random();

            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = r.Next(-5, 4);
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

        // Saindo com pressa, gambiarra. Obs.: Se fosse algo sério, teria de voltar e corrigir depois.
        static int[] CompactarVetor(int[] vetor1, int valorMinimoPermitido)
        {
            int tamanhoVetorResultante = 0;
            int[] vetorResultante, arrayAuxiliar;
            arrayAuxiliar = new int[vetor1.Length];

            for (int i = 0; i < vetor1.Length; i++)
            {
                if (vetor1[i] >= valorMinimoPermitido) tamanhoVetorResultante++;
            }

            vetorResultante = new int[tamanhoVetorResultante];
            vetor1.CopyTo(arrayAuxiliar, 0);

            for (int i = 0; i < vetorResultante.Length; i++)
            {
                for (int j = 0; j < vetor1.Length; j++)
                    if (vetor1[j] >= valorMinimoPermitido)
                    {
                        vetorResultante[i] = vetor1[j];
                        vetor1[j] = 0;
                        i++;
                    }
            }

            arrayAuxiliar.CopyTo(vetor1, 0);

            return vetorResultante;
        }

        static void Main(string[] args)
        {
            int valorMinimoPermitido;
            int[] vetor1, vetor2;
            vetor1 = new int[10];
            vetor2 = new int[vetor1.Length];

            PreencherVetor(vetor1);

            Console.Write("Valor mínimo permitido: ");
            valorMinimoPermitido = Convert.ToInt16(Console.ReadLine());

            vetor2 = CompactarVetor(vetor1, valorMinimoPermitido);

            Console.WriteLine("Vetor original:\n");
            ImprimirVetor(vetor1);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Vetor compactado:\n");
            ImprimirVetor(vetor2);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
