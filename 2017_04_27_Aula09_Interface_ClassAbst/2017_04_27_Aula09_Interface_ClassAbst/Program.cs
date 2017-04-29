using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_27_Aula09_Interface_ClassAbst
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado E = new Empregado("J. Costa", 1998, 6.10, 30);
            Console.WriteLine("Nome: {0}" , E.LerNome());
            Console.WriteLine("Antiguidade: {0} anos",
            E.AnosDeCasa(System.DateTime.Now.Year));
            Console.WriteLine("Salario: {0} Reais" , E.salario());
            }
            }
        }
