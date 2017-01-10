using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _516_01_04_PesquisaHabitantes
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

        static int Menu()
        {
            int opcao = 0;

            try
            {
                Console.WriteLine("Digite a opção desejada:\n\n1- Média de salário entre os habitantes;\n2- Maior e menor idade entre o grupo;\n3- Quantidade de mulheres com mais de 2 filhos e renda familiar inferior a R$600, 00.");
                opcao = int.Parse(Console.ReadLine());

                while (opcao < 1 || opcao > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida. Pressione qualquer tecla e tente novamente.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.ResetColor();

                    Console.WriteLine("Digite a opção desejada:\n\n1- Média de salário entre os habitantes;\n2- Maior e menor idade entre o grupo;\n3- Quantidade de mulheres com mais de 2 filhos e renda familiar inferior a R$600, 00.");
                    opcao = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + e.Message);
                Console.ResetColor();

                Console.WriteLine("\nPressione qualquer tecla para continuar.");
                Console.ReadKey();
            }

            Console.Clear();

            return opcao;
        }

        static double CalcularSoma(CaracHab[] nomeStruct)
        {
            double soma = 0;

            for (int i = 0; i < nomeStruct.Length; i++)
            {
                soma += nomeStruct[i].familiarMoney;
            }

            return soma;
        }

        static double CalcularMedia(int quantElementos, double somaElementos)
        {
            double media;

            media = somaElementos / quantElementos;

            return media;
        }

        static void Main(string[] args)
        {
            int habitNum = 5, opcao;
            double media;

            CaracHab[] search1 = new CaracHab[5];

            PreencherStruct(search1);

            do
            {
                Console.Clear();
                opcao = Menu();
                Console.Clear();
                switch (opcao)
                {
                    //1- Média de salário entre os habitantes
                    case 1:
                        media = CalcularMedia(search1.Length, CalcularSoma(search1));

                        Console.WriteLine("A média de salário entre os habitantes é de: R${0:N2}", media);

                        Console.WriteLine("\n\nPressione qualquer tecla para continuar.");
                        Console.ReadLine();
                        break;

                    //2- Maior e menor idade entre o grupo
                    case 2:
                        break;

                    //3- Quantidade de mulheres com mais de 2 filhos e renda familiar inferior a R$600, 00.ssssss
                    case 3:
                        break;

                }
            } while (opcao !=  5);

            Console.ReadLine();
        }
    }
}
