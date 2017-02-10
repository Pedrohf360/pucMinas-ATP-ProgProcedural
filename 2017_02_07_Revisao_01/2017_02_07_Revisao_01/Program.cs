/* 
Nome: Pedro H. Ferreira FonsecaDisciplina: POOData: 07/02/17
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_07_Revisao_01
{
    class Program
    {
        static double CustoCriacaoCoelhos(int numCoelhos)
        {
            double custoCoelhos;

            custoCoelhos = (numCoelhos * 0.70) / 18 + 10;

            return custoCoelhos;
        }
        static void Main(string[] args)
        {
            double custoCriacaoCoelhos;
            int numCoelhos;

            Console.Write("Quantidade de coelhos: ");
            numCoelhos = int.Parse(Console.ReadLine());

            custoCriacaoCoelhos = CustoCriacaoCoelhos(numCoelhos);

            Console.Write("\nCusto de criação dos coelhos: {0:N2}.", custoCriacaoCoelhos);

            Console.WriteLine("\n\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
