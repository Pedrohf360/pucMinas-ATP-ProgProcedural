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

namespace _2017_02_09_Revisao_04
{
    class Program
    {
        static string ConverterSegundos(int numSegundos)
        {
            string horasTexto;
            int horas = 0, minutos = 0, segundos = 0;

            horas = numSegundos / 3600;
            minutos = numSegundos % 3600 / 60;
            segundos = numSegundos % 3600 % 60;

            horasTexto = horas.ToString() + ":" + minutos.ToString() + ":" + segundos.ToString();

            return horasTexto;
        }

        static void Main(string[] args)
        {
            int numSegundos;
            string horasTexto;

            Console.Write("Digite a quantidade de segundos desejada: ");
            numSegundos = int.Parse(Console.ReadLine());

            horasTexto = ConverterSegundos(numSegundos);

            Console.Write("\nHoras (horas, minutos, segundos): {0}.", horasTexto);

            Console.WriteLine("\n\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
