using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_16_VetoresArquivos2
{
    class Cliente
    {
        private double valorCompra;
        private double percentualDesconto;
        private double valorDesconto;
        private String nome;

        // Construtor:
        public Cliente (String nomeCliente, double valorCompra, double percentualDesconto)
        {
            this.nome = nomeCliente;
            this.valorCompra = valorCompra;
            this.percentualDesconto = percentualDesconto;
            this.valorDesconto = this.valorCompra * this.percentualDesconto / 100;
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
            get {
                    if (this.valorCompra >= 1800)
                        this.percentualDesconto = 20;
                    else this.percentualDesconto = 15;

                    return this.percentualDesconto;
                }

            set {
                    if (this.percentualDesconto >= 0 && this.percentualDesconto <= 100)
                        this.percentualDesconto = value;
                }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
    }
}
