/*
Nome: Pedro H. Ferreira Fonseca
Disciplina: POO
Data: 07/02/17
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_07_Revisao_02
{
    class Program
    {
        static void TrocaValores(ref char a, ref char b)
        {
            char c;
            c = a;
            a = b;
            b = c;
        }

        static void Main(string[] args)
        {
            char a, b;

            Console.Write("Informe o valor de \"a\" (1 caractere): ");
            a = char.Parse(Console.ReadLine());

            Console.Write("Informe o valor de \"b\" (1 caractere): ");
            b = char.Parse(Console.ReadLine());

            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Valor de \"a\" (original): {0}.", a);
            Console.WriteLine("Valor de \"b\" (original): {0}.", b);

            Console.WriteLine(new string('-', 30));

            TrocaValores(ref a, ref b);

            Console.WriteLine("Valor de \"a\" (trocado): {0}.", a);
            Console.WriteLine("Valor de \"b\" (trocado): {0}.", b);

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
