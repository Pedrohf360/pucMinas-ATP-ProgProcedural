using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_01_Exerc1POO
{
    class Program
    {
        public static double TotalImpostos(Produto[] vet, int categoria)
        {
            double totalImpostos = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i].Categoria == categoria)
                {
                    totalImpostos += vet[i].ImpostoCobrado;
                }
            }

            return totalImpostos;
        }

        static void PreencheVetor(Produto[] vet)
        {
            int cont = 0;

            for (int i = 0; i < vet.Length; i++)
            {

                if (i < 4) vet[i] = new Produto(cont, "Bebida", i, 20);

                if (i >= 4 && i < 8) vet[i] = new Produto(cont, "Comida", i, 20);

                if (i >= 8) vet[i] = new Produto(cont, "Material Escolar", i, 20);

                if (i == 3 || i == 7) cont++;
            }
        }

        static void ImprimirVetor(Produto[] vet)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < vet.Length; j++)
                {
                    if (vet[j].Categoria == i)
                    {
                        Console.WriteLine("Nome: " + vet[j].NomeProduto);
                        Console.WriteLine("Preço de venda: " + vet[j].PrecoVenda);
                        Console.WriteLine("Quant. estoque: " + vet[j].ImprimiCategoria(i));
                        Console.WriteLine(new string('-', 35));
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            double totalImpostosPagos;

            Produto.quantEstoqueBedidas = 500;
            Produto.quantEstoqueComida = 450;
            Produto.quantEstoqueMatEscolar = 400;

            Produto.quantEstoqueBebidasAux = Produto.quantEstoqueBedidas;
            Produto.quantEstoqueComidaAux = Produto.quantEstoqueComida;
            Produto.quantEstoqueMatEscolarAux = Produto.quantEstoqueMatEscolar;

            Produto.impostoPorcentBebidas = 45;
            Produto.impostoPorcentComida = 18;
            Produto.impostoPorcentMatEscolar = 21;

            Produto[] vet = new Produto[12];

            PreencheVetor(vet);

            totalImpostosPagos = TotalImpostos(vet, 0);

            Console.WriteLine("Total impostos pagos, categoria 0: R${0:N2}.", totalImpostosPagos);

            Console.WriteLine();

            ImprimirVetor(vet);

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
