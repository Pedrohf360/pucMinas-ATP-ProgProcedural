using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_01_Exerc1POO
{
    class Produto
    {
        // Bebidas = 0; Comida = 1; Material Escolar = 2.
        private int categoria;
        private string nomeProduto;
        public static int quantEstoqueBedidas, quantEstoqueComida, quantEstoqueMatEscolar;

        // Variáveis auxiliares armazenarão os valores originais dos produtos em estoque.
        public static int quantEstoqueBebidasAux, quantEstoqueComidaAux, quantEstoqueMatEscolarAux;
        private double precoCusto, precoVenda;
        private double margemLucroPorcent, margemLucro;

        // As taxações de imposto serão definidas na classe principal (método main).
        public static double impostoPorcentBebidas, impostoPorcentComida, impostoPorcentMatEscolar;
        private double impostoCobrado;

        /// <summary>
        /// Construtor da classe Produto, utilizado para cadastrar novos produtos.
        /// </summary>
        /// <param name="categoria">0: Bebidas; 1: Comida; 2: Material Escolar.</param>
        /// <param name="margemLucro">Porcentagem da margem de lucro (mín: 20%; máx: 50%).</param>
        public Produto (int categoria, string nomeProduto, double precoCusto, double margemLucroPorcent)
        {
            this.categoria = categoria;
            this.nomeProduto = nomeProduto;
            this.precoCusto = precoCusto;
            this.margemLucroPorcent = margemLucroPorcent;

            QuantMercadoriasEstoque(categoria, ref quantEstoqueBedidas, ref quantEstoqueComida, ref quantEstoqueMatEscolar);
            this.margemLucro = CalcMargemLucro(margemLucroPorcent, precoCusto);
            this.impostoCobrado = CalcImposto(categoria, precoCusto, margemLucro, impostoPorcentBebidas, impostoPorcentComida, impostoPorcentMatEscolar);
            this.precoVenda = CalcPrecoVenda(precoCusto, margemLucro, impostoCobrado);
        }

        /// <summary>
        /// Preço de venda = preço de custo + margem de lucro + imposto cobrado.
        /// </summary>
        /// <param name="precoCusto"></param>
        /// <param name="margemLucro"></param>
        /// <param name="impostoCobrado"></param>
        /// <returns></returns>
        public double CalcPrecoVenda(double precoCusto, double margemLucro, double impostoCobrado)
        {
            double precoVenda;

            precoVenda = precoCusto + margemLucro + impostoCobrado;

            return precoVenda;
        }

        public double CalcImposto(int categoria, double precoCusto, double margemLucro, double impPorcentBebidas, double impPorcentComida, double impPorcentMatEscolar)
        {
            double valorImposto = 0;

            switch (categoria)
            {
                // Bebidas.
                case 0:
                    valorImposto = (precoCusto + margemLucro) * (impostoPorcentBebidas / 100);
                    break;

                // Comida.
                case 1:
                    valorImposto = (precoCusto + margemLucro) * (impostoPorcentComida / 100);
                    break;

                // Material escolar.
                case 2:
                    valorImposto = (precoCusto + margemLucro) * (impostoPorcentMatEscolar / 100);
                    break;
            }

            return valorImposto;
        }

        public double CalcMargemLucro(double margemLucroPorcent, double precoCusto)
        {
            double margemLucro;

            margemLucro = precoCusto * (margemLucroPorcent / 100);

            return margemLucro;
        }

        public void QuantMercadoriasEstoque (int categoria, ref int quantEstoqueBebidas, ref int quantEstoqueComida, ref int quantEstoqueMatEscolar)
        {
            switch (categoria)
            {
                case 0:
                    quantEstoqueBebidas--;
                    break;

                case 1:
                    quantEstoqueComida--;
                    break;

                case 2:
                    quantEstoqueMatEscolar--;
                    break;
            }
        }

        public int QuantVendido (int categoria, int quantEstoqueBebidas, int quantEstoqueComida, int quantEstoqueMatEscolar, int quantEstoqueBebidasAux, int quantEstoqueComidaAux, int quantEstoqueMatEscolarAux)
        {
            int totalVendido = 0;

            switch (categoria)
            {
                case 0:
                    totalVendido = quantEstoqueBebidasAux - quantEstoqueBedidas;
                    break;

                case 1:
                    totalVendido = quantEstoqueComidaAux - quantEstoqueComida;
                    break;

                case 2:
                    totalVendido = quantEstoqueMatEscolarAux - quantEstoqueMatEscolarAux;
                    break;
            }

            return totalVendido;
        }

        public int ImprimiCategoria (int categoria)
        {
            switch (categoria)
            {
                case 0:
                    return quantEstoqueBedidas;

                case 1:
                    return quantEstoqueComida;

                case 2:
                    return quantEstoqueMatEscolarAux;
            }

            return 0;
        }

        public double ImpostoCobrado
        {
            get { return this.impostoCobrado; }
            set { this.impostoCobrado = value; }
        }

        public double MargemLucro
        {
            get { return this.margemLucro; }
            set
            {
                if (value >= 20 && value <= 50)
                this.margemLucro = value;
            }
        }

        public double PrecoVenda
        {
            get { return this.precoVenda; }
            set { this.precoVenda = value; }
        }

        public double PrecoCusto
        {
            get { return this.precoCusto; }
            set { this.precoCusto = value; }
        }

        public int Categoria
        {
            get { return this.categoria; }
            set { this.categoria = value; }
        }

        public string NomeProduto
        {
            get { return this.nomeProduto; }
            set { this.nomeProduto = value; }
        }
    }
}
