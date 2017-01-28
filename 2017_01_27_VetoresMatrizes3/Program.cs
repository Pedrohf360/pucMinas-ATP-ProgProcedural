using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_01_27_VetoresMatrizes3
{
    class Program
    {
        static void MaiorNumero(int[] nomeVetor, out int maiorNum, out int posicaoMaior)
        {
            maiorNum = int.MinValue;
            posicaoMaior = 0;

            for (int i = 0; i < nomeVetor.Length; i++)
            {
                if (nomeVetor[i] > maiorNum)
                {
                    maiorNum = nomeVetor[i];
                    posicaoMaior = i;
                }
            }
        }
        
        static void MenorNumero(int[] nomeVetor, out int menorNum, out int posicaoMenor)
        {
            menorNum = int.MaxValue;
            posicaoMenor = 0;

            for (int i = 0; i < nomeVetor.Length; i++)
            {
                if (nomeVetor[i] < menorNum)
                {
                    menorNum = nomeVetor[i];
                    posicaoMenor = i;
                }
            }
        }

        static void Main(string[] args)
        {
            int maiorNum = 0, posicaoMaiorNum = 0, menorNum, posicaoMenorNum = 0;
            int[] vetor = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            MaiorNumero(vetor, out maiorNum, out posicaoMaiorNum);
            MenorNumero(vetor, out menorNum, out posicaoMenorNum);
        
            Console.WriteLine("Maior número do array tratado: {0}.", maiorNum + "\nSua posição: " + posicaoMaiorNum);
            Console.WriteLine("Menor número do array tratado: {0}.", menorNum + "\nsua posição: " + posicaoMenorNum);

            Console.ReadKey();

        }
    }
}
