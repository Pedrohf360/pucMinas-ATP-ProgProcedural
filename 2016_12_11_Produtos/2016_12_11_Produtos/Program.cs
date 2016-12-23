/* 1. Faça um programa que receba o nome de cinco produtos e seus respectivos preços, calcule e mostre:
 a quantidade de produtos com preço inferior a R$ 50,00;
 o nome dos produtos com preço entre R$ 50,00 e R$ 100.00;
 a média dos preços dos produtos com preço superior a R$ 100.00.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016_12_11_Produtos
{
    class Program
    {
        struct Produto
        {
            public string nome;
            public double preco;
        }

        static void PreencherCadProd(Produto[] nomeStruct)
        {
            int cont = 0;
            do
            {
                Console.Write("Nome: ");
                nomeStruct[cont].nome = Console.ReadLine();

                Console.Write("\nPreço: ");
                nomeStruct[cont].preco = double.Parse(Console.ReadLine());

                Console.WriteLine(new string('-', 30));

                cont++;
            } while (cont < nomeStruct.Length);
        }

        // Retorna quantidade de valores maiores ou menores do que o informado
        static int QtdMaiorMenor(Produto[] nomeStruct, int informeValor, string maiorMenor)
        {
            int qtdMaior = 0, qtdMenor = 0;

            maiorMenor.ToUpper();

            if (maiorMenor == "menor")
            {
                for (int i = 0; i < nomeStruct.Length; i++)
                {
                    if (nomeStruct[i].preco < informeValor)
                    {
                        qtdMenor++;
                    }
                }
                return qtdMenor;
            }
            else
            {
                for (int i = 0; i < nomeStruct.Length; i++)
                {
                    if (nomeStruct[i].preco > informeValor)
                    {
                        qtdMaior++;
                    }
                }
                return qtdMaior;
            }

            return 0;
        }

        static double SomaValores(Produto[] nomeStruct)
        {
            double soma = 0;

            for (int i = 0; i < nomeStruct.Length; i++)
            {
                if (nomeStruct[i].preco > 100) soma += nomeStruct[i].preco;
            }

            return soma;
        }

        static void NomeProdEntreXeY(Produto[] nomeStruct, double x, double y)
        {
            int cont = 0;

            for (int i = 0; i < nomeStruct.Length; i++)
            {
                if (nomeStruct[i].preco >= x && nomeStruct[i].preco <= y)
                {
                    Console.WriteLine(i + 1 + ") " + nomeStruct[i].nome);
                    Console.WriteLine();
                    cont++;
                }
            }

            if (cont == 0) Console.WriteLine("\nNão há nenhum produto com preço entre {0} e {1}.", x, y);
        }

        static void Main(string[] args)
        {
            int qtdInf50, qtdSup100;
            double somaPrecos, mediaSup100 = 0;

            Produto[] cadProd = new Produto[5];

            PreencherCadProd(cadProd);

            qtdInf50 = QtdMaiorMenor(cadProd, 50, "menor");
            Console.WriteLine("\nQuantidade de produtos com preço inferior a R$50, 00: {0}.", qtdInf50);

            qtdSup100 = QtdMaiorMenor(cadProd, 100, "maior");
            somaPrecos = SomaValores(cadProd);
            
            if (qtdSup100 != 0) mediaSup100 = somaPrecos / qtdSup100;

            Console.WriteLine("\nMédia da soma dos produtos com preço superior a R$100, 00: {0}.", mediaSup100);

            Console.WriteLine("\nNome dos produtos com preço entre R$50, 00 e R$100, 00:");
            NomeProdEntreXeY(cadProd, 50, 100);

            Console.WriteLine("\n\nPressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
