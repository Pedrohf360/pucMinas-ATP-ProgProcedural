using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_27_Aula06_HerancaPolimorfismo_Exerc2
{
    class PFisica : Contribuinte
    {
        protected String cpf;
        protected double salario;

        public PFisica(String n, string end, double sal, String c)
        {
            this.cpf = c;
            this.salario = sal;
        }

        public override double calcImposto()
        {
            double imposto = 0;

            if (this.salario > 1400 && this.salario <= 2100) imposto = this.salario * 0.10 - 100;

            else if (this.salario > 2100 && this.salario <= 2800) imposto = this.salario * 0.15 - 270;

            else if (this.salario > 2800 && this.salario <= 3600) imposto = this.salario * 0.25 - 500;

            else if (this.salario > 3600) imposto = this.salario * 0.30 - 700;

            return imposto;
        }
    }
}
