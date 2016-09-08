using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_AlgorSeq_ConvCentigFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIÁVEIS
            float grausCent, grausFahr;

            //ENTRADA
            Console.Write("Quantos graus Centígrados está fazendo? ");
            grausCent = float.Parse(Console.ReadLine());

            grausFahr = (9 * grausCent + 160) / 5;

            //SAÍDA
            Console.WriteLine("\nA conversão de graus Centígrados para Fahrenheit fica assim: {0}°C = {1}°F.", grausCent, grausFahr);

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);

        }
    }
}
