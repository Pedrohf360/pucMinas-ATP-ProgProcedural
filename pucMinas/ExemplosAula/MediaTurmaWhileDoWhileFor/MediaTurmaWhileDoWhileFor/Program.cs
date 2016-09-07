using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTurmaWhileDoWhileFor
{
    class Program
    {/*
            Programa para ler as notas finais de alunos
            de uma turma e imprimir a média da turma, a 
            quantidade de alunos aprovados e a quantidade 
            de alunos reprovados. Nota do semestre de 0 a 100
            e nota de aprovacao 60.
        */
        static void Main(string[] args)
        {
            //VARIÁVEIS
            float nota, media, soma = 0;
            int numAlunos, aprov, reprov = 0;

            //ENTRADA
            Console.Write("Quantos alunos há na turma? ");
            numAlunos = int.Parse(Console.ReadLine());

            //PROCESSAMENTO
            while (numAlunos <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nO número de alunos deve ser maior que 0. Digite novamente: ");
                Console.ResetColor();
                numAlunos = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= numAlunos; i++)
            {
                do
                {
                    Console.Write("\nDigite a nota do {0}º aluno (entre 0 e 100): ", i);
                    nota = float.Parse(Console.ReadLine());
                } while (nota <= 0 && nota >= 100);

                if (nota < 60)
                {
                    reprov++; //Contador
                }
                soma += nota; //Acumulador
            }

            media = soma / numAlunos;
            aprov = numAlunos - reprov;

            //SAÍDA
            Console.WriteLine("\nA média dos alunos da turma é de: {0}.",  media);
            Console.WriteLine("\n\tReprovados: {0}\n\tAprovados: {1}", reprov, aprov);

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    } 
}
