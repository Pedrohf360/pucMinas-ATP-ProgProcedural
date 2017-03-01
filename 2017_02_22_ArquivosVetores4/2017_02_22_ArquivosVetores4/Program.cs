/*4) Considere que em uma eleição para pouteito concorrem três candidatos. Cada
candidato é identificado por um número floateiro: 1, 2 e 3. Em uma pesquisa
eleitoral foi perguntado, a cada entrevistado, em quem ele votaria na próxima
eleição para pouteito. Cada entrevistado deu seu voto conforme abaixo:
 1, 2 ou 3: voto para o respectivo candidato;
 4: voto nulo;
 5: indeciso.
Faça um programa em C# que leia um arquivo texto, de nome “votos.txt”, que
contém, em cada linha, o número correspondente ao voto do entrevistado; calcule
e escreva, na tela, o percentual de votos de cada candidato e o percentual de
eleitores indecisos.
Utilize um vetor de floateiros para acumular a quantidade de votos obtidos por cada
um dos candidatos, a quantidade de votos nulos e a quantidade de eleitores
indecisos, ao invés de criar cinco variáveis.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2017_02_22_ArquivosVetores4
{
    class Program
    {
        static String[] LerArquivo (String nomeArquivo)
        {
            String textoArquivo;
            String[] vetorVotosTexto;

            using (StreamReader read = new StreamReader(@nomeArquivo + ".txt"))
            {
                textoArquivo = read.ReadToEnd();

                textoArquivo = textoArquivo.Replace("\n", "");

                vetorVotosTexto = textoArquivo.Split('\r');
            };

            return vetorVotosTexto;
        }

        static void TransfereValores(String[] vetorTexto, int[] vetorfloateiros)
        {
            for (int i = 0; i < vetorfloateiros.Length; i++)
            {
                vetorfloateiros[i] = int.Parse(vetorTexto[i]);
            }
        }

        static void VerificaPorcentagemVotos(out float cand1, out float cand2, out float cand3, out float votosNulos, out float votosIndecisos, int[] votos)
        {
            cand1 = 0;
            cand2 = 0;
            cand3 = 0;
            votosNulos = 0;
            votosIndecisos = 0;

            float quantTotalVotos;

            for (int i = 0; i < votos.Length; i++)
            {
                switch (votos[i])
                {
                    case 1:
                        cand1++;
                        break;

                    case 2:
                        cand2++;
                        break;

                    case 3:
                        cand3++;
                        break;

                    case 4:
                        votosNulos++;
                        break;

                    case 5:
                        votosIndecisos++;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.ResetColor();
                        break;
                }
            }

            quantTotalVotos = cand1 + cand2 + cand3 + votosNulos + votosIndecisos;

            cand1 = (cand1 * 100) / quantTotalVotos;
            cand2 = (cand2 * 100) / quantTotalVotos;
            cand3 = (cand3 * 100) / quantTotalVotos;
            votosNulos = (votosNulos * 100) / quantTotalVotos;
            votosIndecisos = (votosIndecisos * 100) / quantTotalVotos;
        }


        static void Main(string[] args)
        {
            float candidato1, candidato2, candidato3, votosNulos, votosIndecisos;
            int[] votos;
            String[] votosTexto;

            votosTexto = LerArquivo("votos");

            votos = new int[votosTexto.Length];

            TransfereValores(votosTexto, votos);

            VerificaPorcentagemVotos(out candidato1, out candidato2, out candidato3, out votosNulos, out votosIndecisos, votos);

            Console.WriteLine("Porcentagem de votos obtidos pelo candidato 1: {0:N2}%;\nPorcentagem de votos obtidos pelo candidato 2: {1:N2}%;\nPorcentagem de votos obtidos pelo candidato 3: {2:N2}%;\nVotos nulos\\Indecisos: {3:N2}%.", candidato1, candidato2, candidato3, votosNulos + votosIndecisos);

            Console.WriteLine("\n\nPressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
