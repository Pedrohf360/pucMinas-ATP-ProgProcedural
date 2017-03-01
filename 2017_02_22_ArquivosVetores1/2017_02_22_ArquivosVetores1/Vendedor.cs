using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio1
{
    class Vendedor
    {
        private String nome;
        private int valorTotalVendas;
        private double percentualComissao;
        private double valorReceber;

        public Vendedor(String nomeVendedor, int valorVendas, double comissao)
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

        public void setNome(String nomeVendedor)
        {
            this.nome = nomeVendedor;
        }

        public int getValorTotalVendas()
        {
            return (this.valorTotalVendas);
        }

        public void setValorTotalVendas(int valorVendas)
        {
            this.valorTotalVendas = valorVendas;
        }

        public double getComissao()
        {
            return (this.percentualComissao);
        }

        public void setComissao(double comissao)
        {
            this.percentualComissao = comissao;
        }

        public double getValorReceber()
        {
            return (this.valorReceber);
        }

        public void setValorReceber(double valor)
        {
            this.valorReceber = valor;
        }
    }
}
