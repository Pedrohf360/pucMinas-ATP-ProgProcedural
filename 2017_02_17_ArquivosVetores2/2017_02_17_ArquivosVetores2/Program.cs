using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2017_02_17_ArquivosVetores2
{
    class Program
    {
        const int numClientes = 5;
        static string[] LerArquivo()
        {
            string textoArquivo, nomeArquivo;
            string[] itensArquivo;

            do
            {
                nomeArquivo = "vendasClientes";

                nomeArquivo += ".txt";

            } while (File.Exists(nomeArquivo) == false);

            using (StreamReader lerArquivo1 = new StreamReader(@nomeArquivo))
            {
                textoArquivo = lerArquivo1.ReadToEnd();

                lerArquivo1.Close();
            };
            textoArquivo = textoArquivo.Replace("\n", "");

            itensArquivo = textoArquivo.Split(';', '\r');

            return itensArquivo;
        }

        static void CalcularDesconto(string[] arrayOriginal, double[] clientesDescontos)
        {
            int cont = 0;

            for (int i = 1; i < arrayOriginal.Length; i += 2)
            {
                if (int.Parse(arrayOriginal[i]) >= 1800) clientesDescontos[cont] = 20;
                else clientesDescontos[cont] = 15;

                cont++;
            }

            cont++;

        }

        /// <summary>ValorCompra
        /// Transfere os valores do array splitado para o vetor da classe Cliente. Alterar métodos se necessário incluir mais infomações por linha no arquivo vendasClientes.
        /// Observe que o loop 'for', int j, possui como condição j < 2 (2 = quant. de informações por linha). Não encontrei uma forma de modularizar este.
        /// </summary>
        /// <param name="arrayOriginal">Array splitado, por exemplo.</param>
        /// <param name="clientes">Instância da classe Clientes, em forma de vetor.</param>
        static void TransfValorArquivoParaVetor(string[] arrayOriginal, Cliente[] clientes, double[] clientesDescontos)
        {
            int cont = 0;

            for (int i = 0; i <= arrayOriginal.Length; i += 2)
            {
                clientes[cont] = new Cliente(arrayOriginal[i], double.Parse(arrayOriginal[i + 1]), clientesDescontos[cont]);

                if (i == arrayOriginal.Length - 2 || cont == clientes.Length - 1) break;

                cont++;
            }
        }

        static void EscreverArquivo(Cliente[] clientes)
        {
            string nomeArquivo;

            nomeArquivo = "descontoClientes";

            using (StreamWriter arquivoClientes = new StreamWriter(@nomeArquivo + ".txt", false))
            {
                for (int i = 0; i < clientes.Length; i++)
                {
                    arquivoClientes.WriteLine(clientes[i].Nome + ";" + clientes[i].ValorDescontado);
                }

                arquivoClientes.Close();
            };
        }

        static void Main(string[] args)
        {
            String[] arquivoClientes;

            double[] clientesDescontos;

            arquivoClientes = LerArquivo();

            clientesDescontos = new double[numClientes];

            Cliente[] clientes = new Cliente[numClientes];

            CalcularDesconto(arquivoClientes, clientesDescontos);

            TransfValorArquivoParaVetor(arquivoClientes, clientes, clientesDescontos);

            EscreverArquivo(clientes);

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}