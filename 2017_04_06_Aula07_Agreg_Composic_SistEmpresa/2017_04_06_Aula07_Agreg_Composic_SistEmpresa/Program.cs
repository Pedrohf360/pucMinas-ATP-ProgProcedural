using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_06_Aula07_Agreg_Composic_SistEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            
            ConsoleKeyInfo f;
            Funcionario[] funcs = new Funcionario[3];

            funcs[0] = new Funcionario(123, "um dois tres");

            funcs[1] = new Funcionario(234, "dois tres quatro");

            funcs[2] = new Funcionario(345, "tres quatro cinco");

            funcs[0].Depto = new Departamento(1, "Financeiro");

            funcs[1].Depto = new Departamento(2, "Vendas");

            funcs[2].Depto = new Departamento(3, "Só zueira, iéie");

            Console.WriteLine("Pressione a tecla \"A\"");
            f = Console.ReadKey(true);

            while (f.Key == ConsoleKey.A && cont < 3)
            {
                Console.Clear();

                Console.WriteLine(funcs[cont].ToString());

                f = Console.ReadKey(true);
                cont++;
            }

            Console.WriteLine("\n\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
