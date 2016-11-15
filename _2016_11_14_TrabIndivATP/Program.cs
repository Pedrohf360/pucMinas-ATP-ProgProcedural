/* Nome: Pedro H. Ferreira Fonseca
 * 
 * Exercício: 
 * 1) Considere que existe um registro com os seguintes atributos:
 *  codigo_cliente e nome_cliente e um
outro registro com os seguintes atributos: 
Noconta, valor compra, codigo_cliente.
Faça um programa que:
(a) inclua clientes, não permitindo que dois clientes possuam o mesmo código;

(b) inclua contas, vericando se o código do cliente informado já está cadastrado. Caso não esteja,
não permita a inclusão;

(c) remova um determinado cliente. Antes de executar a remoção, verique se o cliente possui
alguma compra. Se possuir, mostrar a mensagem: Exclusão não permitida. Caso contrário,
proceder à exclusão.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016_11_14_TrabIndivATP
{
    
    class Program
    {
        public const int ERRO = -1;

        struct Cliente
        {
            public string nomeCliente;
            public int codCliente;
        }

        //Noconta, valor compra, codigo_cliente.
        struct cadCliente
        {
            double valCompra;
            int numConta, codCliente;
        }

        static void MensagemErro(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
        
        // RECEBE O STRUCT CLIENTE E A posATUAL DELE, VALIDANDO O VAOR DIGITADO ASSIM QUE FOR DIGITADO
        static int ValidaCodCliente(Cliente[] cliente, ref int posAtual) // REF, POIS INTERAGE COM O ITERATOR
        {
            for (int i = 0; i < cliente.Length; i++)
            {
                if (cliente[posAtual].codCliente == cliente[i].codCliente) return ERRO;
            }

            return 1;
        }

        // A OPÇÃO DE PREENCHER AUTOMATICAMENTE DEVERÁ SER UTILIZADA PARA FACILITAR A CORREÇÃO DO EXERCÍCIO.
        static void PreencherCad(Cliente[] cliente)
        {
            int codCliente, sairCad, cont = 0;

            do {

                Console.Write("Digite o nome do cliente: ");
                cliente[cont].nomeCliente = Console.ReadLine();
                Console.Write("Digite um código para o cliente: ");
                cliente[cont].codCliente = int.Parse(Console.ReadLine());
                codCliente = ValidaCodCliente(cliente, ref cont);

                while (codCliente == ERRO)
                {
                    MensagemErro("Ohhh! O código digitado já existe!");
                    Console.WriteLine("\nTente novamente.");

                    Console.ReadKey();
                    Console.Clear();

                    Console.Write("Digite um código para o cliente: ");
                    cliente[cont].codCliente = int.Parse(Console.ReadLine());
                    codCliente = ValidaCodCliente(cliente, ref cont);
                }

                Console.WriteLine("\nDigite \"0\" para sair.");
                sairCad = int.Parse(Console.ReadLine());
                cont++;
            } while (sairCad != 0);

                Console.WriteLine("\nPressione qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
        }

        static void Main(string[] args)
        {
            int codCliente;

            Console.SetWindowSize(40, 40);
            Console.SetCursorPosition(11, 20);
            Console.WriteLine("Cadastro de clientes");

            Cliente[] cliente = new Cliente[100];
           
            PreencherCad(cliente);

            Console.WriteLine("\n\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
            //(a)inclua clientes, não permitindo que dois clientes possuam o mesmo código;
        }
    }
}
