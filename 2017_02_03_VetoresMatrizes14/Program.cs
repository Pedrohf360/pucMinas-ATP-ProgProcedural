/*Faça um programa que receba:
 as notas de 15 alunos em cinco provas diferentes e armazene-as em uma matriz 15 x 5:
 os nomes dos 15 alunos e armazene-os em um vetor de 15 posições.
Calcule e mostre:
 para cada aluno: o nome, a média aritmética das cinco provas e a situação (Aprovado. Reprovado
ou Exame);
 a média da classe.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_03_VetoresMatrizes14
{
    class Program
    {
        static void PreencherMatriz(int[,] matriz1)
        {
            Random r = new Random();

            for (int i = 0;  i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    matriz1[i, j] = r.Next(0, 100);
                }
            }
        }

        static double SomaMatriz(int[,] matriz1)
        {
            double soma = 0;

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    soma += matriz1[i, j];
                }
            }

            return soma;
        }

        static double SomaLinha(int[,] matriz1, int numLinha)
        {
            double soma = 0; ;

            for (int i = 0; i < matriz1.GetLength(1); i++)
            {
                soma += matriz1[numLinha, i];
            }

            return soma;
        }

        static double MediaAritmetica(double soma, double quantidPosicoes)
        {
            double media;

            media = soma / quantidPosicoes;

            return media;
        }

        // Ler 1 linha (situação de um aluno) e exibir resultado.
        static string VerificarAprovacao(int[,] matriz1, int notaMinima, int numeroAluno)
        {
            double somaLinha = 0;
            string situacao;

            for (int i = 0; i < matriz1.GetLength(1); i++)
            {
                somaLinha += matriz1[numeroAluno, i];
            }

            if (MediaAritmetica(somaLinha, matriz1.GetLength(1)) >= notaMinima) situacao = "Aprovado!";
            else situacao = "Reprovado!";

            return situacao;
        }

        static void ExibirResultado(int[,] matriz1, string[] nomesAlunos)
        {
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                Console.Write(i + 1 + ") Nome: {0};\n", nomesAlunos[i]);
                Console.Write("Média aritmética: {0};\n", MediaAritmetica(SomaLinha(matriz1, i), matriz1.GetLength(1)));
                Console.Write("Situação: {0}.\n", VerificarAprovacao(matriz1, 60, i)); // return situacao.
                Console.WriteLine(new string('-', 50));
            }
        }

        static void Main(string[] args)
        {
            int[,] notasAlunos;
            string[] nomesAlunos;
            notasAlunos = new int[15, 5];
            nomesAlunos = new string[15] { "João", "Paulo", "Felipe", "Ana", "Marcos", "Vinícius", "Isadora", "Isabela", "Isaisa", "Isassauro", "Constantinópolis", "Joséclaudo", "Raum", "Moça", "hahaahhaÉnomeTAMBÉM" };

            PreencherMatriz(notasAlunos);

            ExibirResultado(notasAlunos, nomesAlunos);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nMédia da classe: {0}.", MediaAritmetica(SomaMatriz(notasAlunos), notasAlunos.GetLength(0) * notasAlunos.GetLength(1)));
            Console.ResetColor();

            Console.WriteLine("\n\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
