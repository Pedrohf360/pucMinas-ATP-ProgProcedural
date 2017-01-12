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

                Console.WriteLine("\nWhat is your sex? (1- Male, 2- Female)");
                nomeStruct[i].sex = int.Parse(Console.ReadLine());

                Console.WriteLine("\nHow many money do you have?");
                nomeStruct[i].familiarMoney = double.Parse(Console.ReadLine());

                Console.WriteLine("\nHow many childs do you have?");
                nomeStruct[i].childNum = int.Parse(Console.ReadLine());

                // Decrementa 1 inteiro da variável "i" se algum valor informativo estiver incorreto, desta forma, a posição em que os dados incorretos
                // foram digitados será corrigida.
                if ((nomeStruct[i].age < 0 || nomeStruct[i].age > 150) || (nomeStruct[i].sex < 1 || nomeStruct[i].sex > 2) || nomeStruct[i].childNum < 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Algo de errado não está correto! Verifique os dados digitados e tente novamente!");
                    Console.ResetColor();

                    Console.WriteLine("\nPressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    i--;
                }

                Console.Clear();
            }
        }

        static int Menu()
        {
            int opcao = 0;

            try
            {
                Console.WriteLine("Digite a opção desejada:\n\n1- Média de salário entre os habitantes;\n2- Maior e menor idade entre o grupo;\n3- Quantidade de mulheres com mais de 2 filhos e renda familiar inferior a R$600, 00;\n4- Sair.");
                opcao = int.Parse(Console.ReadLine());

                while (opcao < 1 || opcao > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida. Pressione qualquer tecla e tente novamente.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.ResetColor();

                    Console.WriteLine("Digite a opção desejada:\n\n1- Média de salário entre os habitantes;\n2- Maior e menor idade entre o grupo;\n3- Quantidade de mulheres com mais de 2 filhos e renda familiar inferior a R$600, 00;\n4- Sair.");
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

        // O programador pode escolher se deseja obter a maior ou a menor idadae do struct CaracHab[]
        static int MaiorMenorIdade(CaracHab[] nomeStruct, string maiorOuMenor)
        {
            int maior = 0, menor = 150;
            maiorOuMenor.ToUpper();

            for (int i = 0; i < nomeStruct.Length; i++)
            {
                if (nomeStruct[i].age > maior) maior = nomeStruct[i].age;
                if (nomeStruct[i].age < menor) menor = nomeStruct[i].age;
            }

            if (maiorOuMenor == "maior") return maior;
            if (maiorOuMenor == "menor") return menor;

            return -1;
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 25);
            int habitNum = 3, opcao, quantidadeMulherMais2filhos = 0;
            double media;

            CaracHab[] search1 = new CaracHab[habitNum];

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
                        Console.ReadKey();
                        break;

                    //2- Maior e menor idade entre o grupo
                    case 2:
                        Console.WriteLine("Maior idade entre o grupo: {0} anos.", MaiorMenorIdade(search1, "maior"));

                        Console.WriteLine("Menor idade entre o grupo: {0} anos.", MaiorMenorIdade(search1, "menor"));

                        Console.WriteLine("\n\nPressione qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;

                    //3- Quantidade de mulheres com mais de 2 filhos e renda familiar inferior a R$600, 00
                    case 3:
                        for (int i = 0; i < search1.Length; i++)
                        {
                            if (search1[i].childNum > 2 && search1[i].familiarMoney < 600) quantidadeMulherMais2filhos++;
                        }

                        Console.WriteLine("Quantidade de mulheres com mais de 2 filhos e renda familiar inferior a R$600, 00: {0} mulheres.", quantidadeMulherMais2filhos);

                        Console.WriteLine("\n\nPressione qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;

                }
            } while (opcao !=  4);
        }
    }
}
