/*2) Uma empresa de vendas oferece a seus clientes descontos em função do valor da
compra efetuada pelo mesmo. Esse desconto é de 20%, se o valor da compra for
maior ou igual a R$1.800,00; e de 15% para compras de valores menores. Faça
um programa em C# que leia um arquivo texto, de nome “vendasClientes.txt”, que
contém, em cada linha, os seguintes dados, separados pelo caractere “-”: nome do
cliente; valor da compra efetuada pelo cliente. Esse programa deve calcular e
imprimir, em um outro arquivo texto, de nome “descontosClientes.txt”, o nome do
cliente e o desconto obtido por ele.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2017_02_16_VetoresArquivos2
{
    class Program
    {
        static string[] LerArquivo()
        {
            string textoArquivo, nomeArquivo;
            string[] itensArquivo;

            do
            {
                Console.Write("Digite o nome do arquivo a ser lido: ");
                nomeArquivo = Console.ReadLine();

                nomeArquivo += ".txt";

                Console.WriteLine("\nPressione qualquer tecla para sair.");
                Console.ReadKey(true);
                Console.Clear();

            } while (File.Exists(nomeArquivo) == false);

            using (StreamReader lerArquivo1 = new StreamReader(@nomeArquivo))
            {
                textoArquivo = lerArquivo1.ReadToEnd();

                lerArquivo1.Close();
            };

            itensArquivo = textoArquivo.Split(';', '\r', '\n', '\t');

            return itensArquivo;
        }

        static void Main(string[] args)
        {
            String nomeArquivo;
            String[] arquivoClientes;

            arquivoClientes = LerArquivo();

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
