using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_27_Aula06_HerancaPolimorfismo_Exerc3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ass. ADM:\nNome: {0};\nMatrícula: {1}.");

            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Ass. TÉCN.:\nNome: {0};\nMatrícula: {1}.");

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
