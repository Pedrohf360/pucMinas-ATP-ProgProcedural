using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_12_Bodega
{
    class Program
    {
        public static double CalcImposto(double aliquota)
        {
            double valorImposto;
            double margemLucro = 100;

            // Para que a aliquota informada fique no formato correot (0.00)
            if (aliquota > 0)
                aliquota = aliquota / 100;

            valorImposto = margemLucro * aliquota;

            return valorImposto;
        }


        static void Main(string[] args)
        {
            double valorImposto;
            double aliquota;
            double margemLucro;

            Console.WriteLine("Alíquota:");
            aliquota = double.Parse(Console.ReadLine());

            Console.WriteLine("Margem Lucro:");
            margemLucro = double.Parse(Console.ReadLine());

            valorImposto = CalcImposto(aliquota);

            Console.WriteLine(valorImposto);

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);  
        }
    }
}
