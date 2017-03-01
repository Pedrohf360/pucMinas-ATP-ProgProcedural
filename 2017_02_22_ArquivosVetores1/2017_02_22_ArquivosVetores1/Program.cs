using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Exercicio1
{
    class Program
    {
        // número total de vendedores da loja.
        public const int numVendedores = 5;

        static void Main(string[] args)
        {
            // vetor que armazenará os dados dos vendedores da loja.
            Vendedor[] vendedores = new Vendedor[numVendedores];

            // string auxiliar para onde os dados das linhas lidas do arquivo de entrada serão copiados.
            String s;

            int i;
            double soma;
            Vendedor vendedorMaiorValor, vendedorMenorValor;

            // vetor de Strings onde os dados dos vendedores serão armazenados após terem sido lidos do arquivo de entrada e separados campo por campo.
            String[] dadosVendedores;

            // definição do nome, do arquivo de entrada, que contém os dados de cada vendedor da loja separados por ";". Atenção para o formato.
            String nomeArquivoEntrada = @"dadosVendedores.txt";
            // definição do nome, do arquivo de saída, que conterá o relatório com os nomes dos vendedores e o valor que cada um deles terá a receber. Atenção para o formato.
            String nomeArquivoSaida = @"relatorio.txt";

            // definição da "stream" de leitura de dados.
            StreamReader arquivoLeitura;
            // definição da "stream" para gravação dos dados em arquivo.
            StreamWriter relatorio;

            // verifica se o arquivo de entrada existe.
            if (File.Exists(nomeArquivoEntrada))
            {
                // caso o arquivo de entrada exista, cria a "stream" de leitura que possui como parâmetros o nome do arquivo de entrada e o tipo de codificação.
                arquivoLeitura = new StreamReader(nomeArquivoEntrada, Encoding.ASCII);

                // leitura, linha a linha, do arquivo de entrada.
                s = arquivoLeitura.ReadLine();

                i = 0;

                // a leitura do arquivo de entrada é feita, linha por linha, para a String s.
                // quando o arquivo termina, a string lida é nula.
                while (s != null)
                {
                    // os dados dos vendedores, que foram lidos do arquivo de entrada e armazenados na String s, são "quebrados", campo a campo, utilizando-se o separador de campos ';'. 
                    dadosVendedores = s.Split(';');

                    // armazena os dados lidos dos vendedores no vetor de vendedores.
                    vendedores[i] = new Vendedor(dadosVendedores[0], int.Parse(dadosVendedores[1]), double.Parse(dadosVendedores[2]));

                    // leitura, linha a linha, do arquivo de entrada.
                    s = arquivoLeitura.ReadLine();

                    i++;

                }
                // fecha e libera o arquivo de entrada.
                arquivoLeitura.Close();

                // cria a "stream" de saída que possui como parâmetros o nome do arquivo de saída; a indicação de que as novas informações não serão concatenadas no final do arquivo, caso ele já exista; e o tipo de codificação.
                relatorio = new StreamWriter(nomeArquivoSaida, false, Encoding.ASCII);

                soma = 0;
                vendedorMaiorValor = vendedores[0];
                vendedorMenorValor = vendedores[0];

                // escreve sequencialmente no arquivo de saída os dados (nome e valor a receber) dos 5 vendedores. O método é análogo ao da escrita em console.
                // os vendedores que têm o maior e o menor valores a receber também são identificados, assim como a soma dos valores vendidos por todos os vendedores. 
                for (i = 0; i < numVendedores; i++)
                {
                    relatorio.WriteLine("O vendedor {0} tem a receber R$ {1}.", vendedores[i].getNome(), vendedores[i].getValorReceber());

                    if (vendedores[i].getValorReceber() > vendedorMaiorValor.getValorReceber())
                        vendedorMaiorValor = vendedores[i];

                    if (vendedores[i].getValorReceber() < vendedorMenorValor.getValorReceber())
                        vendedorMenorValor = vendedores[i];

                    soma += vendedores[i].getValorTotalVendas();
                }

                // fecha e libera o arquivo de saída.
                relatorio.Close();

                Console.WriteLine("O vendedor que possui o maior valor a receber é: {0}. Ele receberá R$ {1}", vendedorMaiorValor.getNome(), vendedorMaiorValor.getValorReceber());
                Console.WriteLine("O vendedor que possui o menor valor a receber é: {0}. Ele receberá R$ {1}", vendedorMenorValor.getNome(), vendedorMenorValor.getValorReceber());
                Console.WriteLine("A soma dos valores vendidos por todos os vendedores é R$ {0}", soma);
            }
            else
            {
                Console.WriteLine("O arquivo {0} não existe", nomeArquivoEntrada);
            }
            Console.ReadKey();
        }
    }
}