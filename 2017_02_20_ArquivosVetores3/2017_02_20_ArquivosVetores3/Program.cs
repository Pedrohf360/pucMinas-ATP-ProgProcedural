using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2017_02_20_ArquivosVetores3
{
    class Program
    {
        static string[] LerArquivo(string nomeArquivo)
        {
            string textoArquivo;
            string[] vetorNumeros;
            vetorNumeros = new string[20];

            using (StreamReader read = new StreamReader(@nomeArquivo + ".txt"))
            {
                textoArquivo = read.ReadToEnd();

                textoArquivo = textoArquivo.Replace("\n", "");

                vetorNumeros = textoArquivo.Split('\r');

                read.Close();
            };

            return vetorNumeros;
        }

        static void TransfStringToInt(string[] vetorTexto, int[] vetorNumero)
        {
            for (int i = 0; i < vetorNumero.Length; i++)
            {
                vetorNumero[i] = int.Parse(vetorTexto[i]);
            }
        }

        static int QuantNumerosIguais(int[] vetor1, int[] vetor2)
        {
            int cont = 0;

            for (int i = 0; i < vetor1.Length; i++)
            {
                for (int j = 0; j < vetor2.Length; j++)
                {
                    if (vetor2[i] == vetor1[j])
                    {
                        cont++;
                        break;
                    }
                }
            }

            return cont;
        }

        static void Main(string[] args)
        {
            int[] arq1, arq2;
            string[] textoArquivo;
            int quantNumerosIguais;

            arq1 = new int[20];
            arq2 = new int[20];
            textoArquivo = new string[20];

            textoArquivo = LerArquivo("sequencia1");
            TransfStringToInt(textoArquivo, arq1);
            textoArquivo = LerArquivo("sequencia2");
            TransfStringToInt(textoArquivo, arq2);

            quantNumerosIguais = QuantNumerosIguais(arq1, arq2);

            Console.WriteLine("Quantidade de números do arquivo 2 iguais ao do arquivo 1: {0}", quantNumerosIguais);

            Console.WriteLine("\n\nPressione qualquer tecla para sair.");
            Console.ReadKey();

        }
    }
}
