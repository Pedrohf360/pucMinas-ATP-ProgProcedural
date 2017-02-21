/*1) Faça um programa em C# que leia um arquivo texto, de nome “dadosVendedores.txt”, que contém, em cada linha, os seguintes dados: o nome
do vendedor; o valor total das vendas realizadas pelo vendedor no período; e o percentual de comissão desse vendedor. Esses dados estão separados, em cada
linha, pelo caractere ‘;’. Assuma que existem 5 (cinco) vendedores. Esse programa deve calcular e mostrar na tela o valor total das vendas realizadas por todos os
vendedores no período; o maior valor a ser recebido por um vendedor juntamente com o nome do vendedor que o receberá; e o menor valor a ser recebido por um
vendedor juntamente com seu nome. Calcule também e grave, em um arquivo texto de nome “relatório.txt”, os nomes dos vendedores e o valor que cada um deles tem a receber. Esse arquivo
deve apresentar as informações de cada vendedor em uma linha.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2017_02_16_VetoresArquivos1
{
    class Program
    {
        // número total de vendedores da loja.
        public const int numVendedores = 5;

        static void Main(string[] args)
        {
            // vetor que armazenará os dados dos vendedores da loja.
            Vendedor[] vendedores = new Vendedor[numVendedores];

            // string aux. para onde os dados das linhas lidas do arquivos de entrada serão copiados.
            String s;

            int i;
            double soma;

            Vendedor vendedorMaiorValor, vendedorMenorValor;

            String[] dadosVendedores;

            String nomeArquivoEntrada = @"dadosVendedores.txt";

            String nomeArquivoSaida = @"relatorio.txt";

            StreamReader arquivoLeitura;

            StreamWriter relatorio;

            if (File.Exists(nomeArquivoEntrada))
            {
                arquivoLeitura = new StreamReader(nomeArquivoEntrada, Encoding.ASCII);

                s = arquivoLeitura.ReadLine(); // ??????????????????????????????? ué

                i = 0;

                while (s != null)
                {
                    dadosVendedores = s.Split(';');

                    vendedores[i] = new Vendedor(dadosVendedores[0], int.Parse(dadosVendedores[1]), double.Parse(dadosVendedores[2]));

                    s = arquivoLeitura.ReadLine();

                    i++;
                }

                arquivoLeitura.Close();

                relatorio = new StreamWriter(nomeArquivoSaida, false, Encoding.ASCII);

                soma = 0;
                vendedorMaiorValor = vendedores[0];
                vendedorMenorValor = vendedores[0];


                for (i = 0; i < numVendedores; i++)
                {
                    relatorio.WriteLine("O vendedor {0} tem a receber R$ {1}.", vendedores[i].getNome(), vendedores[i].getValorReceber());

                    if (vendedores[i].getValorReceber() > vendedorMaiorValor.getValorReceber())
                        vendedorMaiorValor = vendedores[i];

                    if (vendedores[i].getValorReceber() < vendedorMenorValor.getValorReceber())
                        vendedorMenorValor = vendedores[i];

                    soma += vendedores[i].getValorTotalVendas();
                }

                // fecha e libera o arquivo de saída
                relatorio.Close();

                Console.WriteLine("O vendedor que possui o maior valor a receber é: {0}. Ele receberá R$ {1}.", vendedorMaiorValor.getNome(), vendedorMaiorValor.getValorReceber());

                Console.WriteLine("O vendedor que possui o menor valor a receber é: {0}. Ele receberá R$ {1}.", vendedorMenorValor.getNome(), vendedorMenorValor.getValorReceber());

                Console.WriteLine("A soma dos valores vendidos por todos os vendedores é R$ {0}.", soma);
            }
            else
            {
                Console.WriteLine("O arquivo {0} não existe.", nomeArquivoEntrada);
            }

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
            }   
        }
    }
