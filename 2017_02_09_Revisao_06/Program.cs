/*
Nome: Pedro H. Ferreira Fonseca
Disciplina: POO
Data: 09/02/17
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_09_Revisao_06
{
    class Program
    {
        static int CalcularIdade(int anoNascimento, int anoCorrente)
        {
            int idade;

            idade = anoCorrente - anoNascimento;

            return idade;
        }

        static void Main(string[] args)
        {
            int idade, anoCorrente, anoNascimento;
            string podeVotar, podeHabilitacao;

            Console.Write("Ano de nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.Write("Ano corrente: ");
            anoCorrente = int.Parse(Console.ReadLine());

            idade = CalcularIdade(anoNascimento, anoCorrente);

            if (idade >= 16) podeVotar = "Sim";
            else podeVotar = "Não";

            if (idade >= 18) podeHabilitacao = "Sim";
            else podeHabilitacao = "Não";

            Console.WriteLine("\nIdade para votar: {0}.", podeVotar);
            Console.WriteLine("Idade para conseguir carteira de habilitação: {0}.", podeHabilitacao);

            Console.WriteLine("\n\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);  
        }
    }
}
