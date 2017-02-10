/*
Nome: Pedro H. Ferreira Fonseca
Disciplina: POO
Data: 2017/02/17
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_07_Revisao_03
{
    class Program
    {
        static double CalcSalarBruto(int numHorasTrab, int numDependentes)
        {
            double salarBruto;

            salarBruto = numHorasTrab * 12 + 40 * numDependentes;

            return salarBruto;
        }

        static double CalcSalarLiquido(double salarBruto, double descInss, double descImpRenda)
        {
            double salarLiquido;

            salarLiquido = salarBruto - (descInss + descImpRenda);

            return salarLiquido;
        }

        static double CalcDescInss(double salarBruto)
        {
            double inss;

            inss = salarBruto * 0.08;

            return inss;
        }

        static double CalcDescImpRenda(double salarBruto)
        {
            double impRenda;

            impRenda = salarBruto * 0.05;

            return impRenda;
        }

        static void Main(string[] args)
        {
            double salarBruto, descInss, descImpRenda, salarLiquido;
            string nome;
            int numHorasTrab, numDepend;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Número de horas trabalhadas: ");
            numHorasTrab = int.Parse(Console.ReadLine());

            Console.Write("Número de dependentes: ");
            numDepend = int.Parse(Console.ReadLine());

            salarBruto = CalcSalarBruto(numHorasTrab, numDepend);
            descInss = CalcDescInss(salarBruto);
            descImpRenda = CalcDescImpRenda(salarBruto);
            salarLiquido = CalcSalarLiquido(salarBruto, descInss, descImpRenda);

            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Nome: {0}.", nome);
            Console.WriteLine("Salário bruto: R${0:N2}.", salarBruto);
            Console.WriteLine("Valor INSS descontado: R${0:N2}.", descInss);
            Console.WriteLine("Valor IR descontado: R${0:N2}.", descImpRenda);
            Console.WriteLine("Salário líquido: R${0:N2}.", salarLiquido);
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
