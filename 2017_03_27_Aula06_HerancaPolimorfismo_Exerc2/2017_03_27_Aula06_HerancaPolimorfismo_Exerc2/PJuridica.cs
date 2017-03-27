using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_27_Aula06_HerancaPolimorfismo_Exerc2
{
    class PJuridica : Contribuinte
    {
        protected String cnpj;
        protected double faturamento; // Neste exercício, o faturamento é considerado a Renda Bruta (o correto seria criar uma variável rendaBruta).

        public PJuridica(String n, string end, double f, String c)
        {
            this.cnpj = c;
            this.faturamento = f;
        }

        public override double calcImposto()
        {
            double imposto;

            imposto = this.faturamento * 0.10;

            return imposto;
        }
    }
}
