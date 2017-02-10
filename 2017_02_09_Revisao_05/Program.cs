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

namespace _2017_02_09_Revisao_05
{
    class Program
    {
        static float PesoIdeal(float altura, string sexo)
        {
            float pesoIdeal = 0;

            if (sexo == "M")
            {
                pesoIdeal = 72.7f * altura - 58f;
            }
            else
            {
                pesoIdeal = 62.1f * altura - 44.7f;
            }

            return pesoIdeal;
        }

        static void Main(string[] args)
        {
            float altura, pesoIdeal;
            string sexo;

            Console.WriteLine("Qual sua altura? (Ex.: 1,85).");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("\nQual seu sexo? (M ou F)");
            sexo = Console.ReadLine();

            sexo = sexo.ToUpper();

            pesoIdeal = PesoIdeal(altura, sexo);

            Console.Write("\nSeu peso ideal: {0}.", pesoIdeal);

            Console.WriteLine("\n\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
