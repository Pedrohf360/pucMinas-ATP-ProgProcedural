using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_16_VetoresArquivos1
{
    class Vendedor
    {
        private String nome { get; set; }
        private int valorTotalVendas { get; set; }
        private double percentualComissao { get; set; }
        private double valorReceber { get; set; }

        public Vendedor (String nomeVendedor, int valorVendas, double comissao)
        {
            this.nome = nomeVendedor;
            this.valorTotalVendas = valorVendas;
            this.percentualComissao = comissao;
            this.valorReceber = valorTotalVendas * percentualComissao / 100;
        }

        public String getNome()
        {
            return (this.nome);
        }

        public void setNome (String nomeVendedor)
        {
            this.nome = nomeVendedor;
        }

        public int getValorTotalVendas()
        {
            return this.valorTotalVendas;
        }

        public void setValorTotalVendas (int valorVendas)
        {
            this.valorTotalVendas = valorVendas;
        }

        /// <summary>
        /// Retorna a comissão.
        /// </summary>
        /// <returns></returns>
        public double getComissao()
        {
            return this.percentualComissao;
        }

        /// <summary>
        /// Configurar o percentual da comissão.
        /// </summary>
        /// <param name="comissao">Digite o valor do percentual da comissão.</param>
        public void setComissao (double comissao)
        {
            this.percentualComissao = comissao;
        }

        /// <summary>
        /// Retorna o valor a receber.
        /// </summary>
        /// <returns></returns>
        public double getValorReceber()
        {
            return this.valorReceber;
        }

        /// <summary>
        /// Configura o valor da variável ValorReceber.
        /// </summary>
        /// <param name="valor">Digite o valor desejado.</param>
        public void setValorReceber(double valor)
        {
            this.valorReceber = valor;
        }   
    }
}
