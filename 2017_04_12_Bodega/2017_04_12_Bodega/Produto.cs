using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_12_Bodega
{
    abstract class Produto
    {
        protected string nome;
        protected double precoCusto;
        protected double margemLucro;
        protected double aliquota;

        public Produto(string nome, double precoCusto, double margemLucro, double aliq)
        {
            this.nome = nome;
            this.precoCusto = precoCusto;
            this.aliquota = aliq;

            if (margemLucro < 20)
                this.margemLucro = 0.2;
            else if (margemLucro > 50)
                this.margemLucro = 0.5;
            else
                this.margemLucro = margemLucro / 100;
        }

        public double PrecoLucro()
        {
            return this.precoCusto * this.margemLucro;
        }

        public double PrecoImposto()
        {
            return (precoCusto + PrecoLucro()) * aliquota;
        }

        public double PrecoVenda()
        {
            return precoCusto + PrecoLucro() + PrecoImposto();
        }

        public override string ToString()
        {
            return "Nome: " + this.nome +
                   "\nPreço imposto: R$" + PrecoImposto().ToString("0.##") +
                   "\nPreço Total: R$" + PrecoVenda().ToString("0.##");
        }

        public override bool Equals(object obj)
        {
            if (obj.ToString().Equals(this.ToString()))
                return true;
            else
                return false;
        }
    }
}
