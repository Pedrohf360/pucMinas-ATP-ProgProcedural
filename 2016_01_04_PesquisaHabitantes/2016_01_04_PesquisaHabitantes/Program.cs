using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016_01_04_PesquisaHabitantes
{
    class Program
    {
        struct CaracHab
        {
            public int age;
            public int sex;
            public double familiarMoney;
            public int childNum;
        }

        static void PreencherStruct(CaracHab[] nomeStruct)
        {
            for (int i = 0; i < nomeStruct.Length; i++)
            {
                Console.WriteLine(i + 1 + ") What is your age?");
                nomeStruct[i].age = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your sex? (1- Male, 2- Female)");
                nomeStruct[i].sex = int.Parse(Console.ReadLine());

                Console.WriteLine("How many money do you have?");
                nomeStruct[i].familiarMoney = double.Parse(Console.ReadLine());

                Console.WriteLine("How many childs do you have?");
                nomeStruct[i].childNum = int.Parse(Console.ReadLine());

                Console.Clear();
            }
        }

        /* static double CalculaSoma(CaracHab[] nomeStruct)
         {
            
         }
         */

        static int Menu()
        {
            int opcao = 0;

            try
            {
                Console.WriteLine("Digite a opção desejada:\n\n1- Média de salário entre os habitantes;\n2- Maior e menor idade entre o grupo;\n3- Quantidade de mulheres com mais de 2 filhos e renda familiar inferior a R$600, 00.");
                opcao = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                Console.WriteLine("\nPressione qualquer tecla para continuar.");
                Console.ReadLine();
            }

            Console.Clear();

            return opcao;
        }

        static void Main(string[] args)
        {
            int hanitNum = 20, opcao;

            CaracHab[] search1 = new CaracHab[20];

            PreencherStruct(search1);

            do{

                opcao = Menu();
                switch (opcao)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                }
            } while (opcao !=  5);

            Console.ReadLine();
        }
    }
}
