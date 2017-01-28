using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_01_27_VetMatriz2
{
    class Program
    {
        // Transfere o valor de 2 arrays p/ apenas 2, com o tamanho dos 2 juntos e seus elementos.
        static int[] TransfValores(int[] vet1, int[] vet2)
        {
            int cont = 0;

            int[] vet = new int[vet1.Length + vet2.Length];

            for (int i = 0; i < vet.Length; i++)
            {
                if (i < vet1.Length)
                {
                    vet[i] = vet1[i];
                    continue;
                }

                vet[i] = vet2[cont];
                cont++;
            }

            return vet;
        }

        static int[] OrdenaDecrescente(int[] vetParaOrdenar)
        {
            int maiorValor = int.MinValue, posicaoDeletarArray = 0;

            int[] vetorOrdenado = new int[vetParaOrdenar.Length];

            for (int i = 0; i < vetParaOrdenar.Length; i++)
            {
                for (int j = 0; j < vetParaOrdenar.Length; j++)
                {
                    if (vetParaOrdenar[j] > maiorValor)
                    {
                        maiorValor = vetParaOrdenar[j];
                        posicaoDeletarArray = j;
                    }
                }
                vetorOrdenado[i] = maiorValor;
                vetParaOrdenar[posicaoDeletarArray] = int.MinValue;
                maiorValor = int.MinValue;
            }

            return vetorOrdenado;
        }

        static void ImprimirArray(int[] vet)
        {
            int cont = 1;

            foreach (int i in vet)
            {
                Console.WriteLine(cont + ") " + i);
                cont++;
            }
        }

        static void Main(string[] args)
        {
            int[] vet1 = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] vet2 = new int[10] {11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            int[] vet3 = new int[vet1.Length + vet2.Length];
            int[] vetOrdenado = new int[vet3.Length];

            vet3 = TransfValores(vet1, vet2);

            vetOrdenado = OrdenaDecrescente(vet3);


            Console.WriteLine("Vetor 1 + Vetor 2 unidos em um único array, ordenados em ordem decrescente:\n");
            ImprimirArray(vetOrdenado);

            Console.ReadKey();
        }
    }
}
