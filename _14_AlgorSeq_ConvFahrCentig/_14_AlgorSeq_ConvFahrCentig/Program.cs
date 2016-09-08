using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_AlgorSeq_ConvFahrCentig
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIÁVEIS
            float grFahr, grCent;

            Console.Write("Digite o valor em °F (graus Fahrenheit) que deseja converter para °C (graus Celsius).: ");
            grFahr = float.Parse(Console.ReadLine());

            grCent = (grFahr - 32) * 5 / 9;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n{0}°F convertido para °C = {1}°C.", grFahr, grCent);
            Console.ResetColor();

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);  
        }
    }
}
