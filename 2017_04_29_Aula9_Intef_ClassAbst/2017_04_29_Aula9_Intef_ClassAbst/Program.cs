using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_29_Aula9_Intef_ClassAbst
{
    class Program
    {
        static int Menu()
        {
            int opcao = 0;

            try
            {
                while (opcao < 1 || opcao > 3)
                {
                    Console.WriteLine("1- Média aritmética");
                    Console.WriteLine("2- Média ponderada");
                    Console.WriteLine("3- Sair\n");

                    opcao = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return opcao;
        }

        static void Main(string[] args)
        {
            int opcao = 0;

            int[] amostras = new int[] {54, 32, 42, 15, 12};

            Calculos calc = new Calculos(amostras);

            do
            {
                opcao = Menu();
            switch (opcao)
            {
                case 1: 
                    Console.WriteLine("Média aritmética da amostra: " + calc.MediaAritmetica());

                    Console.WriteLine("\nContinuar.\n");
                    Console.ReadKey();

                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("Média aritmética ponderada: " + calc.MediaPonderada());

                    Console.WriteLine("\nContinuar.\n");
                    Console.ReadKey();

                    Console.Clear();
                    break;
            }
            } while (opcao != 3);
        }
    }
}
