using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_17_ArquivosVetores2
{
    class Cliente
    {
        private String nome;
        private double valorCompra;
        private double percentualDesconto;
        private double valorDescontado;
        private double valorFinalCompra;

        // Construtor:
        public Cliente(String nomeCliente, double valorCompra, double percentualDesconto)
        {
            this.nome = nomeCliente;
            this.valorCompra = valorCompra;
            this.percentualDesconto = percentualDesconto;

            this.valorDescontado = this.valorCompra * (this.percentualDesconto / 100);
        }

        /// <summary>
        /// Alterar ou retornar o valor da compra.
        /// </summary>
        /// <param name="valorCompra">Digite o valor da compra, caso deseje alterá-la. Isso não faz sentido, na verdade.</param>
        public double ValorCompra
        {
            get { return this.valorCompra; }
            set { this.valorCompra = value; }
        }

        public double PercentualDesconto
        {
            get { return this.percentualDesconto; }
            set { this.percentualDesconto = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public double ValorDescontado
        {
            get { return this.valorDescontado; }
        }

        public double ValorFinalCompra
        {
            get { return this.valorFinalCompra; }
        }
    }
}