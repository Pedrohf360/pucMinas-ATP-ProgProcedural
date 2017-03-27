using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_27_Aula06_HerancaPolimorfismo_Exerc1
{
    class PessoaFis : Pessoa
    {
        private String CPF;
        private double salario;

        public override String ImprimeDados()
        {
            string aux = base.ImprimeDados();

            aux += "\nCPF: " + CPF + "\nSalário: " + salario;

            return aux;
        }

        public override double CalcImposto()
        {
            double aux = base.CalcImposto();

            return aux;
        }
    }
}
